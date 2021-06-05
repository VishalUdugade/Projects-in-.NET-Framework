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
    public partial class Update_Employee : Form
    {
        public SqlDataReader dr;
        public Update_Employee()
        {
            InitializeComponent();
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Address.Text != "" && dtp_Joining_Date.Text != "" && tb_Mobile_Number.Text != "" && tb_Alternate_Mobile_Number.Text != "" && tb_Aadhar_Number.Text != "" && tb_PAN_Number.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Update tbl_Add_New_Employee set First_Name='" + tb_First_Name.Text + "',Middle_Name='" + tb_Middle_Name.Text + "',Last_Name='" + tb_Last_Name.Text + "',Address='" + tb_Address.Text + "',Position='" + tb_Position.Text + "',Joining_Date='" + dtp_Joining_Date.Text + "',Mobile_Number=" + tb_Mobile_Number.Text + ",Alt_Mobile_Number=" + tb_Alternate_Mobile_Number.Text + ",Aadhar_Number=" + tb_Aadhar_Number.Text + ",PAN_Number='" + tb_PAN_Number.Text + "',Salary=" + tb_Salary.Text + " where Employee_ID=" + tb_Employee_ID.Text + "",obj.con);
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Select * from tbl_Add_New_Employee where Employee_ID=" + tb_Employee_ID.Text + "", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    tb_First_Name.Text = Convert.ToString(dr["First_Name"]);
                    tb_Middle_Name.Text = Convert.ToString(dr["Middle_Name"]);
                    tb_Last_Name.Text = Convert.ToString(dr["Last_Name"]);
                    tb_Address.Text = Convert.ToString(dr["Address"]);
                    dtp_Joining_Date.Text = Convert.ToString(dr["Joining_Date"]);
                    tb_Mobile_Number.Text = Convert.ToString(dr["Mobile_Number"]);
                    tb_Alternate_Mobile_Number.Text = Convert.ToString(dr["Alt_Mobile_Number"]);
                    tb_Aadhar_Number.Text = Convert.ToString(dr["Aadhar_Number"]);
                    tb_PAN_Number.Text = Convert.ToString(dr["PAN_Number"]);
                    tb_Position.Text = Convert.ToString(dr["Position"]);
                    tb_Salary.Text = Convert.ToString(dr["Salary"]);
                }
                else
                {
                    MessageBox.Show("Record Not Found..");
                }
                dr.Close();
                obj.cmd.Dispose();
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("First enter Employee ID...");
            }
        }
    }
}
