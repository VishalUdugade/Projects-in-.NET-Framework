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
    public partial class Add_Update_Stock : Form
    {
        SqlDataReader dr;
        public Add_Update_Stock()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            if (tb_stock_ID.Text != "")
            {
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Add_Update_Stock where Stock_ID = " + tb_stock_ID.Text + "",obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_Current_Stock.Enabled = true;
                    btn_add.Enabled = false;
                    btn_Update.Enabled = true;
                    tb_stock_ID.Text =Convert.ToString(dr["Stock_ID"]);
                    tb_Current_Stock.Text = Convert.ToString(dr["Stock"]);
                    tb_Rate.Text = Convert.ToString(dr["Rate"]);
                    dtp_Stock_Added_Date.Text = Convert.ToString(dr["Stock_Added_Date"]);
                    tb_Supplier_Name.Text = Convert.ToString(dr["Supplier_Name"]);
                    cb_Thikness.Text = Convert.ToString(dr["Thikness"]);
                    cb_Material.Text = Convert.ToString(dr["Material"]);
                    dr.Close();
                    obj.cmd.Dispose();
                    
                }
                else
                {
                    btn_add.Enabled = true;
                    btn_Update.Enabled = false;
                }

            } 

        }

        private void Add_Update_Stock_Load(object sender, EventArgs e)
        {
            btn_Update.Enabled = false;
            btn_add.Enabled = true;
            common_class obj = new common_class();
            obj.openconnection();

            int i = 0;
             i = obj.Auto_Increment("select count(Stock_ID) from tbl_Add_Update_Stock", 1001);
             tb_stock_ID.Text = Convert.ToString(i);
             obj.cmd.Dispose();

             obj.openconnection();
            obj.cmd = new SqlCommand("select distinct Material from tbl_Add_New_Material",obj.con);
            dr = obj.cmd.ExecuteReader();
            cb_Material.Items.Clear();
             while(dr.Read())
            {
                cb_Material.Items.Add((string)(dr["Material"]));
            }
            dr.Close();
            obj.cmd.Dispose();

            obj.cmd = new SqlCommand("select distinct Thikness from tbl_Add_New_Material",obj.con);
            dr = obj.cmd.ExecuteReader();
            cb_Thikness.Items.Clear();
            while(dr.Read())
            {
                cb_Thikness.Items.Add((int)(dr["Thikness"]));
            }
             dr.Close();
            obj.cmd.Dispose();

            tb_Current_Stock.Enabled = false;
            tb_Current_Stock.Text = "0";
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            if (tb_stock_ID.Text != "" && cb_Material.SelectedIndex != -1 && cb_Thikness.SelectedIndex != -1 && dtp_Stock_Added_Date.Text != "" && cb_Thikness.Text != "" && tb_Rate.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Insert into tbl_Add_Update_Stock values(" + tb_stock_ID.Text + ",'" + cb_Material.Text + "','" + tb_Added_Stock.Text + "','" + dtp_Stock_Added_Date.Text + "'," + cb_Thikness.Text + ",'" + tb_Supplier_Name.Text + "','" + tb_Rate.Text + "')", obj.con);
                if(obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Saved Successfully...");
                    obj.cmd.Dispose();
                    obj.closeconnection();
                    clear();
                    Add_Update_Stock_Load(this, null);

                }
                else
                {
                    MessageBox.Show("Record Not Saved Successfully...");
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            clear();
            Add_Update_Stock_Load(this, null);
            
        }
        void clear()
        {
            //tb_Current_Stock.Text = "";
            //tb_Rate.Text = "";
            //tb_Stock_Added.Text = "";
            //dtp_Stock_Added_Date.Value = DateTime.Now;
            //cb_Material.SelectedIndex = -1;
            //cb_Thikness.SelectedIndex = -1;
            common_class obj = new common_class();
            obj.ClearAllCombobox(this);
            obj.ClearTextBoxes(this);
            Add_Update_Stock_Load(this,null);

        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            if (tb_stock_ID.Text != "" && cb_Material.Text != "" && tb_Current_Stock.Text != "" && tb_Added_Stock.Text != "" && dtp_Stock_Added_Date.Text != "" && cb_Thikness.Text != "" && tb_Rate.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Update tbl_Add_Update_Stock set Material = '" + cb_Material.Text + "',Stock = " + tb_total_qty.Text + ",Stock_Added_Date = '" + dtp_Stock_Added_Date.Text + "',Thikness = " + cb_Thikness.Text + ",Supplier_Name = '" + tb_Supplier_Name.Text + "',Rate = " + tb_Rate.Text + " where Stock_ID=" + tb_stock_ID.Text + "", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Saved Successfully..");
                    clear();
                    Add_Update_Stock_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Record are Not saved Successfully..");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields..");
            }
        }

        private void tb_Stock_Added_TextChanged(object sender, EventArgs e)
        {
            if (tb_Added_Stock.Text != "")
            {
                tb_total_qty.Text = Convert.ToString(int.Parse(tb_Current_Stock.Text) + int.Parse(tb_Added_Stock.Text));
            }
            else if (tb_Added_Stock.Text == "" || int.Parse(tb_Added_Stock.Text) == 0)
            {
                tb_total_qty.Text = Convert.ToString(tb_Current_Stock.Text);
            }
        }
    }
}
