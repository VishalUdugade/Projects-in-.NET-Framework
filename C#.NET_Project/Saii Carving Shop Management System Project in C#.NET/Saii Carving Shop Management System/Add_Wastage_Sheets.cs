using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Saii_Carving_Shop_Management_System
{
    public partial class Add_Wastage_Sheets : Form
    {
        SqlDataReader dr;
        public Add_Wastage_Sheets()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_Sheet_Type.SelectedIndex != -1)
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Select * from tbl_Wastage_Sheets where Sheet_Type ='" + cb_Sheet_Type.Text + "'",obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    cb_Sheet_Type.Text = Convert.ToString(dr["Sheet_Type"]);
                    cb_Thikness.Text = Convert.ToString(dr["Thikness"]);
                    tb_Quantity.Text = Convert.ToString(dr["Quantity"]);
                    dtp_Date.Text = Convert.ToString(dr["Date"]);
                    tb_Area.Text = Convert.ToString(dr["Area"]);
                    tb_Rate.Text = Convert.ToString(dr["Rate"]);
                }
                else
                {
                    MessageBox.Show("Invalid Sheet_Type");
                }
                obj.cmd.Dispose();
                dr.Dispose();
            }
            else
            {
                MessageBox.Show("First Select Sheet Type...");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cb_Sheet_Type.Text != "" && cb_Thikness.Text != "" && tb_Quantity.Text != "" && dtp_Date.Text != "" && tb_Area.Text != "" && tb_Rate.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Insert into tbl_Wastage_Sheets values('" + cb_Sheet_Type.Text + "'," + cb_Thikness.Text + "," + tb_Quantity.Text + ",'" + dtp_Date.Text + "'," + tb_Area.Text + "," + tb_Rate.Text + ")",obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Saved Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed...");
                }
                obj.cmd.Dispose();
                obj.ClearAllCombobox(this);
                obj.ClearTextBoxes(this);
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("First fill All Fields..");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cb_Sheet_Type.Text != "" && cb_Thikness.Text != "" && tb_Quantity.Text != "" && dtp_Date.Text != "" && tb_Area.Text != "" && tb_Rate.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("update tbl_Wastage_Sheets Set Sheet_Type = '" + cb_Sheet_Type.Text + "',Thikness =" + cb_Thikness.Text + ",Quantity =" + tb_Quantity.Text + ",Date ='" + dtp_Date.Text + "',Area = " + tb_Area.Text + ",Rate = " + tb_Rate.Text + " Where Sheet_Type='" + cb_Sheet_Type.Text + "' ", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Updated Successfully...");
                }
                else
                {
                    MessageBox.Show("Records Not Updated Successfully...");
                }
                obj.cmd.Dispose();
                obj.ClearAllCombobox(this);
                obj.ClearTextBoxes(this);
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("First fill all fields...");
            }
        }

        private void Add_Wastage_Sheets_Load(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.openconnection();
            obj.cmd = new SqlCommand("select Sheet_Type from tbl_Wastage_Sheets",obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Sheet_Type.Items.Add((string)dr["Sheet_Type"]);
            }
            obj.cmd.Dispose();
            dr.Close();
            obj.closeconnection();
        }
    }
}
