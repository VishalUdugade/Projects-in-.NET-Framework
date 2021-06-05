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
    public partial class View_All_Employee : Form
    {
        string str;
        public View_All_Employee()
        {
            InitializeComponent();
        }

        private void View_All_Employee_Load(object sender, EventArgs e)
        {
            this.tbl_Add_New_EmployeeTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet4.tbl_Add_New_Employee);
            cb_e_name.Enabled = false;
            str = "select * from tbl_Add_New_Employee";
            common_class obj = new common_class();
            obj.datagridview(str, dgv_Employee);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_v_Employee.SelectedIndex != -1 && cb_e_name.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                if (cb_v_Employee.SelectedIndex == 0)
                {
                    str = "select * from tbl_Add_New_Employee where Employee_ID = " + cb_e_name.Text + "";
                }
                else if (cb_v_Employee.SelectedIndex == 1)
                {
                    str = "select * from tbl_Add_New_Employee where Mobile_Number = " + cb_e_name.Text + "";
                }

                obj.datagridview(str, dgv_Employee);
            }
            else
            {
                MessageBox.Show("first select Employee type and Enter Employee Information");
            }
        }

        private void cb_v_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_e_name.Enabled = true;
            if (cb_v_Employee.SelectedIndex == 0)
            {
                cb_e_name.DisplayMember = "Employee_ID";
                cb_e_name.ValueMember = "Employee_ID";
            }
            else if (cb_v_Employee.SelectedIndex == 1)
            {
                cb_e_name.DisplayMember = "Mobile_Number";
                cb_e_name.ValueMember = "Mobile_Number";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            str = "select * from tbl_Add_New_Employee";
            common_class obj = new common_class();
            obj.datagridview(str, dgv_Employee);
        }
    }
}
