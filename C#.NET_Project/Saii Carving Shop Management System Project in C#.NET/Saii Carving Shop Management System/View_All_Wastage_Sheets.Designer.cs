namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_Wastage_Sheets
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_Vstock = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_view_Wastage_Sheets = new System.Windows.Forms.Label();
            this.dgv_Stock = new System.Windows.Forms.DataGridView();
            this.cb_westage_sheet_nm = new System.Windows.Forms.ComboBox();
            this.tblWastageSheetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet2 = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet2();
            this.tbl_Wastage_SheetsTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet2TableAdapters.tbl_Wastage_SheetsTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWastageSheetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1627, 217);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(156, 60);
            this.btn_Close.TabIndex = 82;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1243, 326);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 65);
            this.btn_Refresh.TabIndex = 78;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(763, 327);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(180, 64);
            this.btn_Search.TabIndex = 77;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_Vstock
            // 
            this.cb_Vstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Vstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vstock.FormattingEnabled = true;
            this.cb_Vstock.Items.AddRange(new object[] {
            "Material",
            "Thikness"});
            this.cb_Vstock.Location = new System.Drawing.Point(665, 183);
            this.cb_Vstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Vstock.Name = "cb_Vstock";
            this.cb_Vstock.Size = new System.Drawing.Size(357, 44);
            this.cb_Vstock.TabIndex = 75;
            this.cb_Vstock.SelectedIndexChanged += new System.EventHandler(this.cb_Vstock_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(97, 187);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(318, 40);
            this.lbl_Search_Customer.TabIndex = 81;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_Wastage_Sheets);
            this.Panel1.Location = new System.Drawing.Point(335, 2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(2079, 102);
            this.Panel1.TabIndex = 80;
            // 
            // lbl_view_Wastage_Sheets
            // 
            this.lbl_view_Wastage_Sheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_Wastage_Sheets.AutoSize = true;
            this.lbl_view_Wastage_Sheets.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_Wastage_Sheets.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_Wastage_Sheets.ForeColor = System.Drawing.Color.White;
            this.lbl_view_Wastage_Sheets.Location = new System.Drawing.Point(860, 12);
            this.lbl_view_Wastage_Sheets.Name = "lbl_view_Wastage_Sheets";
            this.lbl_view_Wastage_Sheets.Size = new System.Drawing.Size(683, 77);
            this.lbl_view_Wastage_Sheets.TabIndex = 0;
            this.lbl_view_Wastage_Sheets.Text = "View Wastage Sheets";
            // 
            // dgv_Stock
            // 
            this.dgv_Stock.AllowUserToAddRows = false;
            this.dgv_Stock.AllowUserToDeleteRows = false;
            this.dgv_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock.Location = new System.Drawing.Point(3, 470);
            this.dgv_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Stock.Name = "dgv_Stock";
            this.dgv_Stock.ReadOnly = true;
            this.dgv_Stock.RowTemplate.Height = 24;
            this.dgv_Stock.Size = new System.Drawing.Size(1899, 554);
            this.dgv_Stock.TabIndex = 79;
            // 
            // cb_westage_sheet_nm
            // 
            this.cb_westage_sheet_nm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_westage_sheet_nm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_westage_sheet_nm.DataSource = this.tblWastageSheetsBindingSource;
            this.cb_westage_sheet_nm.Enabled = false;
            this.cb_westage_sheet_nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_westage_sheet_nm.FormattingEnabled = true;
            this.cb_westage_sheet_nm.Location = new System.Drawing.Point(1145, 183);
            this.cb_westage_sheet_nm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_westage_sheet_nm.Name = "cb_westage_sheet_nm";
            this.cb_westage_sheet_nm.Size = new System.Drawing.Size(357, 44);
            this.cb_westage_sheet_nm.TabIndex = 83;
            // 
            // tblWastageSheetsBindingSource
            // 
            this.tblWastageSheetsBindingSource.DataMember = "tbl_Wastage_Sheets";
            this.tblWastageSheetsBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet2;
            // 
            // saii_Carving_Shop_InfoDataSet2
            // 
            this.saii_Carving_Shop_InfoDataSet2.DataSetName = "Saii_Carving_Shop_InfoDataSet2";
            this.saii_Carving_Shop_InfoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Wastage_SheetsTableAdapter
            // 
            this.tbl_Wastage_SheetsTableAdapter.ClearBeforeFill = true;
            // 
            // View_All_Wastage_Sheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 897);
            this.Controls.Add(this.cb_westage_sheet_nm);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_Vstock);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgv_Stock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_All_Wastage_Sheets";
            this.Text = "View_All_Wastage_Sheets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Wastage_Sheets_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWastageSheetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cb_Vstock;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lbl_view_Wastage_Sheets;
        internal System.Windows.Forms.DataGridView dgv_Stock;
        internal System.Windows.Forms.ComboBox cb_westage_sheet_nm;
        private Saii_Carving_Shop_InfoDataSet2 saii_Carving_Shop_InfoDataSet2;
        private System.Windows.Forms.BindingSource tblWastageSheetsBindingSource;
        private Saii_Carving_Shop_InfoDataSet2TableAdapters.tbl_Wastage_SheetsTableAdapter tbl_Wastage_SheetsTableAdapter;
    }
}