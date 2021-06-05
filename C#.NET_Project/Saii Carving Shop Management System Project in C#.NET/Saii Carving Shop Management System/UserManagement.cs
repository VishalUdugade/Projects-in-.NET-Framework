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
    public partial class UserManagement : Form
    {
        SqlDataReader dr;
        string username = "";
        string password = "";
        public UserManagement()
        {
            InitializeComponent();
        }
        public void function_Clear()
        {
            common_class obj = new common_class();
            obj.ClearTabControl(tp_Add_New_User);
           
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            if (tab_UserManagement.SelectedIndex == 0)
            {
                common_class obj = new common_class();
                int i = 0;
                i = obj.Auto_Increment("select count(ID) from tbl_Login", 100);
                tb_ID.Text = Convert.ToString(i);
            }
        }
        private void tab_UserManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_UserManagement.SelectedIndex == 0)
            {
                common_class obj = new common_class();
                int i = 0;
                i = obj.Auto_Increment("select count(ID) from tbl_Login", 100);
                tb_ID.Text = Convert.ToString(i);
            }
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_User.Text != "" && tb_Enter_Pass.Text != "" && tb_Conf_Pass.Text != "")
            {
                if (tb_Enter_Pass.Text == tb_Conf_Pass.Text)
                {
                    common_class obj = new common_class();
                    obj.openconnection();
                    obj.cmd = new SqlCommand("insert into tbl_Login values(" + tb_ID.Text + ",'" + tb_User.Text + "','" + tb_Enter_Pass.Text + "')", obj.con);
                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Saved Successfully");
                        obj.ClearTabControl(tp_Add_New_User);
                        UserManagement_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Record are Not saved Successfully");
                    }
                    obj.cmd.Dispose();
                    obj.closeconnection();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Conform Password");
                }
            }
        }

        private void btn_NewPassClear_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.ClearTabControl(tp_Add_New_User);
            UserManagement_Load(this, null);
        }

        private void btn_changepass_Search_Click(object sender, EventArgs e)
        {
            if (tbc_Current_Password.Text != "" && tbc_Username.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Login where Username = '" + tbc_Username.Text + "' and Password = '" + tbc_Current_Password.Text + "'", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    username = Convert.ToString(dr["Username"]);
                    password = Convert.ToString(dr["Password"]);
                    obj.cmd.Dispose();
                    if (tbc_Username.Text == username)
                    {
                        if (tbc_Current_Password.Text == password)
                        {
                            tbc_user_id.Text = Convert.ToString(dr["ID"]);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username");
                    }
                }
                else
                {
                    MessageBox.Show(" Recored Not Found");
                }
                dr.Dispose();
            }
            else
            {
                MessageBox.Show("Please Enter Username and password First..");
            }
            
        }

        private void btn_Update_Password_Click(object sender, EventArgs e)
        {
            if (tbc_Username.Text != "" && tbc_New_Password.Text != "" && tbc_Current_Password.Text != "")
            {
                    common_class obj = new common_class();
                    obj.openconnection();
                    obj.cmd = new SqlCommand("update tbl_Login set Password ='" + tbc_New_Password.Text + "' where Id = " + tbc_user_id.Text + "", obj.con);
                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        obj.ClearTabControl(tab_change_pass);
                    }
                    else
                    {
                        MessageBox.Show("Record are Not Updated Successfully");
                    }
                    obj.cmd.Dispose();
                    obj.closeconnection();
            }
        }

        private void btn_changepass_Clear_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.ClearTabControl(tab_change_pass);
        }

        private void btn_deleteusersearch_Click(object sender, EventArgs e)
        {
            if (tbd_Pass.Text != "" && tbd_Uname.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Login where Username = '" + tbd_Uname.Text + "' and Password = '" + tbd_Pass.Text + "'", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    username = Convert.ToString(dr["Username"]);
                    password = Convert.ToString(dr["Password"]);
                    obj.cmd.Dispose();
                    if (tbd_Uname.Text == username)
                    {
                        if (tbd_Pass.Text == password)
                        {
                            tbd_U_ID.Text = Convert.ToString(dr["ID"]);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username");
                    }
                }
                else
                {
                    MessageBox.Show(" Recored Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username and password First..");
            }
            dr.Dispose();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tbd_Uname.Text != "" && tbd_Pass.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Delete from tbl_Login where Username = '" + tbd_Uname.Text + "' and Password = " + tbd_Pass.Text + "", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    obj.ClearTabControl(tab_delete_user);
                }
                else
                {
                    MessageBox.Show("Record Are Not Deleted");
                }
            }
            else
            {
                MessageBox.Show("The Field IS Empty..");
            }
        }

        private void btn_deletclear_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            obj.ClearTabControl(tab_delete_user);
        }

      
    }
}
