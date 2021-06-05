namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_Sheets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_view_All_Sheets = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_v_Sheets = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.cb_sheets_name = new System.Windows.Forms.ComboBox();
            this.tblWastageSheetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet1 = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet1();
            this.tbl_Wastage_SheetsTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet1TableAdapters.tbl_Wastage_SheetsTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWastageSheetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1653, 218);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(142, 47);
            this.btn_Close.TabIndex = 78;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // lbl_view_All_Sheets
            // 
            this.lbl_view_All_Sheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_All_Sheets.AutoSize = true;
            this.lbl_view_All_Sheets.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_All_Sheets.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_All_Sheets.ForeColor = System.Drawing.Color.White;
            this.lbl_view_All_Sheets.Location = new System.Drawing.Point(648, 12);
            this.lbl_view_All_Sheets.Name = "lbl_view_All_Sheets";
            this.lbl_view_All_Sheets.Size = new System.Drawing.Size(479, 77);
            this.lbl_view_All_Sheets.TabIndex = 0;
            this.lbl_view_All_Sheets.Text = "View All Sheets";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1225, 350);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 47);
            this.btn_Refresh.TabIndex = 77;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(749, 350);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 47);
            this.btn_Search.TabIndex = 76;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_v_Sheets
            // 
            this.cb_v_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_v_Sheets.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_v_Sheets.FormattingEnabled = true;
            this.cb_v_Sheets.Items.AddRange(new object[] {
            "Sheet Type",
            "Thikness"});
            this.cb_v_Sheets.Location = new System.Drawing.Point(651, 196);
            this.cb_v_Sheets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_v_Sheets.Name = "cb_v_Sheets";
            this.cb_v_Sheets.Size = new System.Drawing.Size(333, 42);
            this.cb_v_Sheets.TabIndex = 74;
            this.cb_v_Sheets.SelectedIndexChanged += new System.EventHandler(this.cb_v_Sheets_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(163, 199);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(316, 38);
            this.lbl_Search_Customer.TabIndex = 81;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_All_Sheets);
            this.Panel1.Location = new System.Drawing.Point(0, 2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1908, 102);
            this.Panel1.TabIndex = 80;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Employee.Location = new System.Drawing.Point(0, 570);
            this.dgv_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(1902, 463);
            this.dgv_Employee.TabIndex = 79;
            // 
            // cb_sheets_name
            // 
            this.cb_sheets_name.DataSource = this.tblWastageSheetsBindingSource;
            this.cb_sheets_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sheets_name.FormattingEnabled = true;
            this.cb_sheets_name.Location = new System.Drawing.Point(1124, 196);
            this.cb_sheets_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_sheets_name.Name = "cb_sheets_name";
            this.cb_sheets_name.Size = new System.Drawing.Size(333, 42);
            this.cb_sheets_name.TabIndex = 82;
            // 
            // tblWastageSheetsBindingSource
            // 
            this.tblWastageSheetsBindingSource.DataMember = "tbl_Wastage_Sheets";
            this.tblWastageSheetsBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet1;
            // 
            // saii_Carving_Shop_InfoDataSet1
            // 
            this.saii_Carving_Shop_InfoDataSet1.DataSetName = "Saii_Carving_Shop_InfoDataSet1";
            this.saii_Carving_Shop_InfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Wastage_SheetsTableAdapter
            // 
            this.tbl_Wastage_SheetsTableAdapter.ClearBeforeFill = true;
            // 
            // View_All_Sheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.cb_sheets_name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_v_Sheets);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgv_Employee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_All_Sheets";
            this.Text = "View_All_Sheets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Sheets_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWastageSheetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Label lbl_view_All_Sheets;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cb_v_Sheets;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private Saii_Carving_Shop_InfoDataSet1 saii_Carving_Shop_InfoDataSet1;
        private System.Windows.Forms.BindingSource tblWastageSheetsBindingSource;
        private Saii_Carving_Shop_InfoDataSet1TableAdapters.tbl_Wastage_SheetsTableAdapter tbl_Wastage_SheetsTableAdapter;
        private System.Windows.Forms.ComboBox cb_sheets_name;
    }
}