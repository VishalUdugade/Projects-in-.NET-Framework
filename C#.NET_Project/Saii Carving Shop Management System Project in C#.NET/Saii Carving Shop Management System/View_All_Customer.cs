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
    public partial class View_All_Customer : Form
    {
        string str;
        SqlDataReader dr;
        public View_All_Customer()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_v_Customer.SelectedIndex != -1 && cb_name.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                if (cb_v_Customer.Text == "Customer Name")
                {;
                str = "Select * from Customer_Details where Customer_Name = '" + cb_name.Text + "'";
                }
                else if (cb_v_Customer.Text == "Mobile Number")
                {
                    str = "Select * from Customer_Details where Mobile_No = " + cb_name.Text + "";
                }

                obj.datagridview(str, dgv_v_Customer);
            }
            else
            {
                MessageBox.Show("First Select Search type and enter search name..");
            }
        }
        private void View_All_Customer_Load(object sender, EventArgs e)
        {
            //this.customer_DetailsTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet3.Customer_Details);
            common_class obj = new common_class();
            str = "Select * from Customer_Details";
            obj.datagridview(str, dgv_v_Customer);

        }

        private void cb_v_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            common_class obj = new common_class();
           
            if (cb_v_Customer.SelectedIndex == 0)
            {
                
                if (cb_v_Customer.Text != "")
                {
                    obj.openconnection();
                    cb_name.Items.Clear();
                    obj.cmd = new SqlCommand("Select Customer_Name from Customer_Details",obj.con);
                    dr = obj.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cb_name.Items.Add((string)dr["Customer_Name"]);
                    }
                    dr.Close();
                    obj.cmd.Dispose();
                }
            }
            else if (cb_v_Customer.SelectedIndex == 1)
            {
                if (cb_v_Customer.Text != "")
                {
                    obj.openconnection();
                    cb_name.Items.Clear();
                    obj.cmd = new SqlCommand("Select Mobile_No from Customer_Details", obj.con);
                    dr = obj.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cb_name.Items.Add((SByte)dr["Mobile_No"]).ToString();
                    }
                    dr.Close();
                    obj.cmd.Dispose();
                }
                obj.closeconnection();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            str = "Select * from Customer_Details";
            obj.datagridview(str, dgv_v_Customer);
        }
    }
}
