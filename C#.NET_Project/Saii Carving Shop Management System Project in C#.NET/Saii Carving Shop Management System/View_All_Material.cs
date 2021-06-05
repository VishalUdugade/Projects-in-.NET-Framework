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
    public partial class View_All_Material : Form
    {
        string str;
        public View_All_Material()
        {
            InitializeComponent();
        }

        private void View_All_Material_Load(object sender, EventArgs e)
        {
            cb_Material_name.Enabled = false;
            this.tbl_Add_New_MaterialTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet.tbl_Add_New_Material);
            common_class obj = new common_class();
            str = "select * from tbl_Add_New_Material";
            obj.datagridview(str, dgv_Employee);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_v_Material.SelectedIndex != -1 && cb_Material_name.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                if (cb_v_Material.SelectedIndex == 0)
                {
                    str = "select * from tbl_Add_New_Material where Stock_ID = " + cb_Material_name.Text + "";
                }
                else if (cb_v_Material.SelectedIndex == 1)
                {
                    str = "select * from tbl_Add_New_Material where Material = '" + cb_Material_name.Text + "'";
                }
                else if (cb_v_Material.SelectedIndex == 2)
                {
                    str = "select * from tbl_Add_New_Material where Thikness = " + cb_Material_name.Text + "";
                }
                obj.datagridview(str, dgv_Employee);
            }
            else
            {
                MessageBox.Show("first select Material type and Enter Employee Information");
            }
        }

        private void cb_v_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Material_name.Enabled = true;
            if (cb_v_Material.SelectedIndex == 0)
            {
                cb_Material_name.DisplayMember = "Stock_ID";
                cb_Material_name.ValueMember = "Stock_ID";
            }
            else if (cb_v_Material.SelectedIndex == 1)
            {
                cb_Material_name.DisplayMember = "Material";
                cb_Material_name.ValueMember = "Material";
            }
            else if (cb_v_Material.SelectedIndex == 2)
            {
                cb_Material_name.DisplayMember = "Thikness";
                cb_Material_name.ValueMember = "Thikness";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            str = "select * from tbl_Add_New_Material";
            obj.datagridview(str, dgv_Employee);
        }
    }
}
