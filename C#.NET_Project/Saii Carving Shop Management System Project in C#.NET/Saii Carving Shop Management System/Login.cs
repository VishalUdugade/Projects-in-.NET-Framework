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
    public partial class Login : Form
    {

       // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\Ashish Project\Saii Carving Shop Management System C#\Saii_Carving_Shop_Info.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"); 
        public Login()
        {
            InitializeComponent();
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
            //common_class obj = new common_class();
            //obj.openconnection();
            //SqlCommand cmd = new SqlCommand("Select * From tbl_Login Where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'",obj.con);
            ////con.Open();
           // if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            if((tb_Username.Text == "A" && tb_Password.Text == "123") || (tb_Username.Text == "U" && tb_Password.Text == "231"))
            {
                if(tb_Username.Text == "A")
                {
                    MessageBox.Show("!!Welcome Tushar!!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                     MessageBox.Show("!!!Welcome To Saii Carving!!!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                MDIParent objs = new MDIParent();
                objs.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password...");
            }
            tb_Username.Text="";
            tb_Password.Text="";
            tb_Password.Enabled = false;
            btn_LOGIN.Enabled = false;
            // obj.closeconnection();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}