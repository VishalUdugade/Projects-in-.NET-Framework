using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace Saii_Carving_Shop_Management_System
{
    public partial class CustomerReport_dv : Form
    {
        public int id = 0;
        public CustomerReport_dv(int customer_id)
        {
            InitializeComponent();
            id = customer_id;
        }

        private void CustomerReport_dv_Load(object sender, EventArgs e)
        {
            common_class obj = new common_class();
            if(id != 0)
            {
                documentViewer1.DocumentSource = "";
                DataTable dt = new DataTable();     
                obj.openconnection();
                obj.cmd = new SqlCommand("SELECT * FROM Customer_Details INNER JOIN C_Purchase_Details ON Customer_Details.Customer_ID = C_Purchase_Details.Customer_ID  WHERE  (Customer_Details.Customer_ID = " + id + ")",obj.con);
                SqlDataAdapter da = new SqlDataAdapter(obj.cmd);
                da.Fill(dt);
                if(dt.Rows.Count != 0)
                {
                    CustomerReport report = new CustomerReport();
                    report.DataSource = dt;
                    report.DataAdapter = da;
                    report.DataMember = "";
                    ReportPrintTool tool = new ReportPrintTool(report);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;

                }
                else
                {
                      MessageBox.Show("No Record Found???");
                }
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("No Record Found???");
            }
        }
    }
}
