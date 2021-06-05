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
    public partial class Add_New_Material : Form
    {
        public SqlDataReader dr;
        public Add_New_Material()
        {
            InitializeComponent();
        }

        private void Add_New_Material_Load(object sender, EventArgs e)
        {

            common_class obj = new common_class();
            obj.openconnection();
            int i;
            i = obj.Auto_Increment("select count(Stock_ID) from tbl_Add_New_Material", 1001);
            tb_Product_ID.Text = Convert.ToString(i);

            obj.openconnection();
            cb_Material.Items.Clear();
             obj.cmd = new SqlCommand("Select * from tbl_Add_New_Material",obj.con);
            dr = obj.cmd.ExecuteReader();
            while(dr.Read())
            {
                cb_Material.Items.Add((string)dr["Material"]);
            }
            dr.Dispose();
            obj.cmd.Dispose();

            cb_Thikness.Items.Clear();
            obj.cmd = new SqlCommand("select distinct Thikness from tbl_Add_New_Material", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Thikness.Items.Add((int)dr["Thikness"]);
            }
            dr.Dispose();
            obj.cmd.Dispose();

            cb_Typ_of_wrk.Items.Clear();
            obj.cmd = new SqlCommand("select distinct Typ_of_wrk from tbl_Add_New_Material",obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Typ_of_wrk.Items.Add((string)dr["Typ_of_wrk"]);
            }
            dr.Dispose();
            obj.cmd.Dispose();
        }

        private void btn_add_materials_Click(object sender, EventArgs e)
        {
            if (tb_Product_ID.Text != "" && dtp_MA_Date.Text != "" && cb_Material.Text != "" && cb_Thikness.Text != "" && tb_Rate.Text != "" && cb_Typ_of_wrk.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Insert into tbl_Add_New_Material values(" + tb_Product_ID.Text + ",'" + dtp_MA_Date.Text + "','" + cb_Material.Text + "'," + cb_Thikness.Text + "," + tb_Rate.Text + ",'" + cb_Typ_of_wrk.Text + "')", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Saved Successfully...");
                    obj.cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Record Not Saved Successully...");
                }
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("First Fill All fields....");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
        }

       

       
    }    
}
