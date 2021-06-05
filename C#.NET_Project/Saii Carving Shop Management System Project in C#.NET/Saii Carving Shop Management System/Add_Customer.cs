using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Saii_Carving_Shop_Management_System
{
    public partial class Add_Customer : Form
    {
        public  int cust_id;
        public int current_stock_val = 0;
        public SqlDataReader dr;

        public Add_Customer()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cust_id = int.Parse(tb_Customer_Id.Text);
            common_class obj = new common_class();
            obj.openconnection();
            if (this.tb_Customer_Id.Text != "" && tb_Customer_Name.Text != "" && dtp_Date.Text != "" && this.tb_Mobile_No.Text != "" && this.cb_Material.Text != "" && this.cb_Thikness.Text != "" && this.cb_Type_of_Work.Text != "" && this.tb_Area.Text != "" && this.tb_Quantity.Text != "" && this.tb_Rate.Text != "" && this.tb_Total.Text != "" && this.tb_Discount.Text != "" && this.tb_GST.Text != "" && this.tb_Final_Bill.Text != "")
            {
                    obj.cmd = new SqlCommand("Insert into Customer_Details values(" + tb_Customer_Id.Text + ",'" + tb_Customer_Name.Text + "','" + dtp_Date.Text + "'," + tb_Mobile_No.Text + "," + tb_Total.Text + "," + tb_Discount.Text + "," + tb_GST.Text + "," + tb_Final_Bill.Text + ")", obj.con);
                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Saved Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Record are Not saved Successfully");
                    }
                    obj.cmd.Dispose();

                    int i = 0;
                    foreach (DataGridViewRow row in dgv_Add_Customer.Rows)
                    {
                        obj.cmd = new SqlCommand("Insert into C_Purchase_Details values(" + dgv_Add_Customer.Rows[i].Cells[0].Value + ",'" + dgv_Add_Customer.Rows[i].Cells[1].Value + "','" + dgv_Add_Customer.Rows[i].Cells[2].Value + "','" + dgv_Add_Customer.Rows[i].Cells[3].Value + "'," + dgv_Add_Customer.Rows[i].Cells[4].Value + "," + dgv_Add_Customer.Rows[i].Cells[5].Value + "," + dgv_Add_Customer.Rows[i].Cells[6].Value + "," + dgv_Add_Customer.Rows[i].Cells[7].Value + ")", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.cmd.Dispose();

                        current_stock_val = 0;

                        obj.cmd = new SqlCommand("select Current_Stock from tbl_Add_Update_Stock where Material = '" + dgv_Add_Customer.Rows[i].Cells[1].Value + "'",obj.con);
                        dr = obj.cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            current_stock_val = (int)dr["Current_Stock"];
                        }
                        dr.Close();

                        current_stock_val = current_stock_val - int.Parse(dgv_Add_Customer.Rows[i].Cells[5].Value.ToString());

                        obj.cmd = new SqlCommand("Update tbl_Add_Update_Stock set Stock = " + current_stock_val + " where Material = '" + dgv_Add_Customer.Rows[i].Cells[1].Value + "'",obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.cmd.Dispose();
                        i = i + 1;
                    }

                    if (i > 0)
                    {
                        MessageBox.Show("Record Added Successfully...");
                        CustomerReport_dv cmm = new CustomerReport_dv(int.Parse(tb_Customer_Id.Text));
                        cmm.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Server Error..");
                    }
            }
            else
            {
                MessageBox.Show("First Fill All Fields...");
            }

            obj.closeconnection();
            cb_Material.Text = "";
            cb_Thikness.Text = "";
            cb_Type_of_Work.Text = "";
            obj.ClearTextBoxes(this);
            Add_Customer_Load(this, null);
            tb_Customer_Id.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int cnt = 0,qty = 0;
            double rate = 0.0;
            if (tb_Quantity.Text != "" && tb_Rate.Text != "" && tb_Area.Text != "")
            {
                if (current_stock_val < int.Parse(tb_Quantity.Text))
                {
                    MessageBox.Show("There is no enough stock available... STOCK Available is = " + current_stock_val + "");
                }
                else
                {
                    foreach (DataGridViewRow row in dgv_Add_Customer.Rows)
                    {
                        if (Convert.ToString(cb_Material.Text) == dgv_Add_Customer.Rows[cnt].Cells[1].Value.ToString() && Convert.ToString(cb_Thikness.Text) == dgv_Add_Customer.Rows[cnt].Cells[2].Value.ToString() &&Convert.ToString(cb_Type_of_Work.Text) == dgv_Add_Customer.Rows[cnt].Cells[3].Value.ToString())
                        {
                            qty = int.Parse(dgv_Add_Customer.Rows[cnt].Cells[5].Value.ToString());
                            rate = double.Parse(dgv_Add_Customer.Rows[cnt].Cells[6].Value.ToString());
                            if (MessageBox.Show("This type of record is already avilable", " do you want to merge it ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                dgv_Add_Customer.Rows.RemoveAt(cnt);
                                dgv_Add_Customer.Rows.Add(tb_Customer_Id.Text, cb_Material.Text, cb_Thikness.Text, cb_Type_of_Work.Text, tb_Area.Text, tb_Quantity.Text, tb_Rate.Text,double.Parse(tb_Area.Text) * int.Parse(tb_Quantity.Text) * double.Parse(tb_Rate.Text));
                                goto nxt;
                            }
                            else
                            {
                                return;
                            }
                        }
                        cnt = cnt + 1;
                    }
                    dgv_Add_Customer.Rows.Add(tb_Customer_Id.Text, cb_Material.Text, cb_Thikness.Text, cb_Type_of_Work.Text, tb_Area.Text, tb_Quantity.Text, tb_Rate.Text, double.Parse(tb_Area.Text) * int.Parse(tb_Quantity.Text) * double.Parse(tb_Rate.Text));
 nxt: ;
                }
            }
            else
            {
                MessageBox.Show("Please First Fill All Fields...");
            }
            tb_Total.Text =Convert.ToString(double.Parse(tb_Area.Text) * int.Parse(tb_Quantity.Text) * double.Parse(tb_Rate.Text));
            //cb_Material.SelectedIndex = -1;
            //cb_Thikness.SelectedIndex = -1;
            //cb_Type_of_Work.SelectedIndex = -1;
            //tb_Quantity.Text = "";
            //tb_Rate.Text = "";
        }
        private void Add_Customer_Load(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.ClearAllCombobox(this);
            obj.ClearTextBoxes(this);

            int i = 0;
            i = obj.Auto_Increment("select count(Customer_ID) from Customer_Details",1001);
            tb_Customer_Id.Text = Convert.ToString(i);

            obj.openconnection();
            cb_Material.Items.Clear();
            obj.cmd = new SqlCommand("Select * from tbl_Add_New_Material", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Material.Items.Add((string)dr["Material"]);
            }
            dr.Dispose();
            obj.cmd.Dispose();
        }
        private void cb_Thikness_SelectedIndexChanged(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.openconnection();
            obj.cmd = new SqlCommand("select distinct Typ_of_wrk from tbl_Add_New_Material where Material='" + cb_Material.Text + "' and  Thikness= " + cb_Thikness.Text + " ",obj.con);
            this.dr = obj.cmd.ExecuteReader();
            cb_Type_of_Work.Items.Clear();
            while(dr.Read())
            {
                cb_Type_of_Work.Items.Add((string)dr["Typ_of_wrk"]);
            }  
           dr.Close();
           obj.cmd.Dispose();
           obj.closeconnection();
        }

        private void cb_Type_of_Work_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Material.Text != "" && cb_Thikness.Text != "" && cb_Type_of_Work.Text != "")
            {
               common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Add_Update_Stock where Material ='" + cb_Material.Text + "'AND Thikness = " + cb_Thikness.Text + "",obj.con);
                this.dr = obj.cmd.ExecuteReader();
                if(dr.Read())
                {
                    tb_Rate.Text = Convert.ToString(dr["Rate"]);
                }
                else
                {
                    cb_Type_of_Work.Items.Clear();
                     MessageBox.Show("No such record found");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.ClearAllCombobox(this);
            obj.ClearTextBoxes(this);
        }

        private void cb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Thikness.Items.Clear();
            common_class obj = new common_class();
            obj.openconnection();
            obj.cmd = new SqlCommand("select distinct Thikness from tbl_Add_New_Material where Material='" + cb_Material.Text + "'",obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Thikness.Items.Add((int)dr["Thikness"]);
            }
            obj.cmd.Dispose();
            dr.Close();

            obj.cmd = new SqlCommand("select Current_Stock  from tbl_Add_Update_Stock where Material='" + cb_Material.Text + "'", obj.con);
            dr = obj.cmd.ExecuteReader();
            if (dr.Read())
            {
                current_stock_val = (int)dr["Current_Stock"];

            }
            else
            {
                current_stock_val = 0;
                MessageBox.Show("There is no enough stock available... STOCK Available is = " + current_stock_val + "");
            }
            //current_stock_val = (int)obj.cmd.ExecuteScalar();
            obj.cmd.Dispose();
            dr.Close();
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "" && tb_GST.Text != "" && tb_Final_Bill.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_Discount.Text) / 100;
                double val1 = double.Parse(tb_Final_Bill.Text);
                double diff = val1 - (dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if (tb_GST.Text == "" && tb_Discount.Text != "" && tb_Total.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_Discount.Text) / 100;
                double val1 = double.Parse(tb_Total.Text);
                double diff = val1 - (dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if (tb_Discount.Text == "" && tb_GST.Text != "")
            {
                    tb_GST_TextChanged(this, null);
            }
            else if (tb_Discount.Text == "" && tb_GST.Text == "")
            {
                tb_Final_Bill.Text = "";
            }
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "" && tb_Discount.Text == "" && tb_Total.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_GST.Text) / 100;
                double val1 = double.Parse(tb_Total.Text);
                double diff = val1 + (dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if (tb_GST.Text != "" && tb_Discount.Text != "" && tb_Final_Bill.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_GST.Text) / 100;
                double val1 = double.Parse(tb_Final_Bill.Text);
                double diff = val1 + (dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if(tb_Discount.Text != "" && tb_GST.Text == "")
            {
                tb_Discount_TextChanged(this, null);
            }
            else if (tb_Discount.Text == "" && tb_GST.Text == "")
            {
                tb_Final_Bill.Text = "";
            }
        }
        private void tb_Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            common_class obj = new common_class();
            obj.numlock(e);
        }

        private void tb_Quantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            common_class obj = new common_class();
            obj.charlock(e);
        }

        private void tb_Area_KeyPress(object sender, KeyPressEventArgs e)
        {
            common_class obj = new common_class();
            obj.charforpoint(e);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            CustomerReport_dv cmm = new CustomerReport_dv(int.Parse(tb_Customer_Id.Text));
            cmm.ShowDialog();
        }

       

       
     }
 }       