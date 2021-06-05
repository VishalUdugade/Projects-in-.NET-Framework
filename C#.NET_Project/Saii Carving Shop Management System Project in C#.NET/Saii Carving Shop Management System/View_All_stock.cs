using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saii_Carving_Shop_Management_System
{
    public partial class View_All_stock : Form
    {
        string str;
        public View_All_stock()
        {
            InitializeComponent();
        }

        private void View_All_stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saii_Carving_Shop_InfoDataSet5.tbl_Add_Update_Stock' table. You can move, or remove it, as needed.
            this.tbl_Add_Update_StockTableAdapter.Fill(this.saii_Carving_Shop_InfoDataSet5.tbl_Add_Update_Stock);
            common_class obj = new common_class();
            str = "select * from tbl_Add_Update_Stock";
            obj.datagridview(str, dgv_Stock);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            if (cb_v_name.SelectedIndex != -1 && cb_Vstock.SelectedIndex != -1)
            {
                if (cb_Vstock.SelectedIndex == 0)
                {
                    str = "select * from tbl_Add_Update_Stock where Material = '" + cb_v_name.Text + "'";
                }
                else if (cb_Vstock.SelectedIndex == 1)
                {
                    str = "select * from tbl_Add_Update_Stock where Thikness = " + cb_v_name.Text + "";
                }
                obj.datagridview(str, dgv_Stock);
            }
            else
            {
                MessageBox.Show("First select product..");
            }
        }

        private void cb_Vstock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Vstock.SelectedIndex == 0)
            {
                cb_v_name.DisplayMember = "Material";
                cb_v_name.ValueMember = "Material";
            }
            else if (cb_Vstock.SelectedIndex == 1)
            {
                cb_v_name.DisplayMember = "Thikness";
                cb_v_name.ValueMember = "Thikness";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            str = "select * from tbl_Add_Update_Stock";
            obj.datagridview(str, dgv_Stock);
        }
    }
}
