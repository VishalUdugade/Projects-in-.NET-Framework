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
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.openconnection();
            int i=0;
            i = obj.Auto_Increment("select count(Employee_ID) from tbl_Add_New_Employee", 1001);
            tb_Employee_ID.Text = Convert.ToString(i);
            obj.closeconnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Address.Text != "" && tb_Position.Text != "" && dtp_Joining_Date.Text != "" && tb_Mobile_Number.Text != "" && tb_Alternate_Mobile_Number.Text != "" && tb_Aadhar_Number.Text != "" && tb_PAN_Number.Text != "" && tb_Salary.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Insert into tbl_Add_New_Employee values(" + tb_Employee_ID.Text + ",'" + tb_First_Name.Text + "','" + tb_Middle_Name.Text + "','" + tb_Last_Name.Text + "','" + tb_Address.Text + "','" + tb_Position.Text + "','" + dtp_Joining_Date.Text + "'," + tb_Mobile_Number.Text + "," + tb_Alternate_Mobile_Number.Text + "," + tb_Aadhar_Number.Text + ",'" + tb_PAN_Number.Text + "'," + tb_Salary.Text + ")", obj.con);
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
                MessageBox.Show("First Fill All Fields...");
            }
            
        }
    }
}
