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
    public partial class View_All_Wastage_Sheets : Form
    {
        string str;
        public View_All_Wastage_Sheets()
        {
            InitializeComponent();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cb_Vstock.SelectedIndex != -1 && cb_westage_sheet_nm.Text != "")
            {
                common_class obj = new common_class();
                obj.openconnection();
                if (cb_Vstock.Text == "Material")
                {
                    str = "Select * from tbl_Wastage_Sheets where Sheet_Type = '" + cb_westage_sheet_nm.Text + "'";
                   // obj.cmd = new SqlCommand("Select * from tbl_Wastage_Sheets where Sheet_Type = '" + cb_westage_sheet_nm.Text + "'", obj.con);
                }
                else if (cb_Vstock.Text == "Thikness")
                {
                    str = "Select * from tbl_Wastage_Sheets where Thikness = " + cb_westage_sheet_nm.Text + "";
                    //obj.cmd = new SqlCommand("Select * from tbl_Wastage_Sheets where Thikness = " + cb_westage_sheet_nm.Text + "", obj.con);
                }

                obj.datagridview(str, dgv_Stock);
            }
            else
            {
                MessageBox.Show("First Select Search type and enter search name..");
            }  
        }

        private void View_All_Wastage_Sheets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saii_Carving_Shop_InfoDataSet2.tbl_Wastage_Sheets' table. You can move, or remove it, as needed.
            this.tbl_Wastage_SheetsTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet2.tbl_Wastage_Sheets);
            common_class obj = new common_class();
            str = "select * from tbl_Wastage_Sheets";
            obj.datagridview(str, dgv_Stock);
        }

        private void cb_Vstock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_westage_sheet_nm.Enabled = true;
            if (cb_Vstock.SelectedIndex == 0)
            {
                cb_westage_sheet_nm.DisplayMember = "Sheet_Type";
                cb_westage_sheet_nm.ValueMember = "Sheet_Type";
            }
            else if (cb_Vstock.SelectedIndex == 1)
            {
                cb_westage_sheet_nm.DisplayMember = "Thikness";
                cb_westage_sheet_nm.ValueMember = "Thikness";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            str = "select * from tbl_Wastage_Sheets";
            obj.datagridview(str, dgv_Stock);
        }
    }
}
