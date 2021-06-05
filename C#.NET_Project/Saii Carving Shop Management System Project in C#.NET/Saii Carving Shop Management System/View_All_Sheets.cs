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
    public partial class View_All_Sheets : Form
    {
        string str;
        public View_All_Sheets()
        {
            InitializeComponent();
        }

        private void View_All_Sheets_Load(object sender, EventArgs e)
        {
            this.tbl_Wastage_SheetsTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet1.tbl_Wastage_Sheets);
            cb_sheets_name.Enabled = true;
            common_class obj = new common_class();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_v_Sheets.SelectedIndex != -1 && cb_sheets_name.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                if (cb_v_Sheets.SelectedIndex == 0)
                {
                    obj.cmd = new SqlCommand("select * from tbl_Wastage_Sheets where Sheet_Type = '" + cb_sheets_name.Text + "'", obj.con);
                }
                else if (cb_v_Sheets.SelectedIndex == 1)
                {
                    obj.cmd = new SqlCommand("select * from tbl_Wastage_Sheets where Thikness = " + cb_sheets_name.Text + "", obj.con);
                }

                SqlDataAdapter da = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_Employee.DataSource = dt;
                obj.cmd.Dispose();
                dt.Dispose();
                obj.closeconnection();
                da.Dispose();
            }
            else
            {
                MessageBox.Show("first select Sheet type and Enter Sheet Information");
            }
        }

        private void cb_v_Sheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_sheets_name.Enabled = true;
            if (cb_v_Sheets.SelectedIndex == 0)
            {
                cb_sheets_name.DisplayMember = "Sheet_Type";
                cb_sheets_name.ValueMember = "Sheet_Type";
            }
            else if (cb_v_Sheets.SelectedIndex == 1)
            {
                cb_sheets_name.DisplayMember = "Thikness";
                cb_sheets_name.ValueMember = "Thikness";
            }
        }
    }
}
