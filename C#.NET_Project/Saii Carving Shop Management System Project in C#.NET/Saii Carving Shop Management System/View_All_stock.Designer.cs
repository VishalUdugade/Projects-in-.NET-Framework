namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_stock
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
            this.lbl_view_All_Stock = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_Vstock = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgv_Stock = new System.Windows.Forms.DataGridView();
            this.cb_v_name = new System.Windows.Forms.ComboBox();
            this.tblAddUpdateStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet5 = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet5();
            this.tbl_Add_Update_StockTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet5TableAdapters.tbl_Add_Update_StockTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddUpdateStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_view_All_Stock
            // 
            this.lbl_view_All_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_All_Stock.AutoSize = true;
            this.lbl_view_All_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_All_Stock.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_All_Stock.ForeColor = System.Drawing.Color.White;
            this.lbl_view_All_Stock.Location = new System.Drawing.Point(860, 12);
            this.lbl_view_All_Stock.Name = "lbl_view_All_Stock";
            this.lbl_view_All_Stock.Size = new System.Drawing.Size(454, 77);
            this.lbl_view_All_Stock.TabIndex = 0;
            this.lbl_view_All_Stock.Text = "View All Stock";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1397, 301);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 52);
            this.btn_Close.TabIndex = 74;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1056, 301);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(135, 52);
            this.btn_Refresh.TabIndex = 70;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(729, 301);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(135, 52);
            this.btn_Search.TabIndex = 69;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_Vstock
            // 
            this.cb_Vstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Vstock.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Vstock.FormattingEnabled = true;
            this.cb_Vstock.Items.AddRange(new object[] {
            "Material",
            "Thikness"});
            this.cb_Vstock.Location = new System.Drawing.Point(675, 165);
            this.cb_Vstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Vstock.Name = "cb_Vstock";
            this.cb_Vstock.Size = new System.Drawing.Size(332, 42);
            this.cb_Vstock.TabIndex = 67;
            this.cb_Vstock.SelectedIndexChanged += new System.EventHandler(this.cb_Vstock_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(96, 169);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(316, 38);
            this.lbl_Search_Customer.TabIndex = 73;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_All_Stock);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(2079, 102);
            this.Panel1.TabIndex = 72;
            // 
            // dgv_Stock
            // 
            this.dgv_Stock.AllowUserToAddRows = false;
            this.dgv_Stock.AllowUserToDeleteRows = false;
            this.dgv_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock.Location = new System.Drawing.Point(1, 377);
            this.dgv_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Stock.Name = "dgv_Stock";
            this.dgv_Stock.ReadOnly = true;
            this.dgv_Stock.RowTemplate.Height = 24;
            this.dgv_Stock.Size = new System.Drawing.Size(1899, 554);
            this.dgv_Stock.TabIndex = 71;
            // 
            // cb_v_name
            // 
            this.cb_v_name.DataSource = this.tblAddUpdateStockBindingSource;
            this.cb_v_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_v_name.FormattingEnabled = true;
            this.cb_v_name.Location = new System.Drawing.Point(1172, 165);
            this.cb_v_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_v_name.Name = "cb_v_name";
            this.cb_v_name.Size = new System.Drawing.Size(332, 42);
            this.cb_v_name.TabIndex = 75;
            // 
            // tblAddUpdateStockBindingSource
            // 
            this.tblAddUpdateStockBindingSource.DataMember = "tbl_Add_Update_Stock";
            this.tblAddUpdateStockBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet5;
            // 
            // saii_Carving_Shop_InfoDataSet5
            // 
            this.saii_Carving_Shop_InfoDataSet5.DataSetName = "Saii_Carving_Shop_InfoDataSet5";
            this.saii_Carving_Shop_InfoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_Update_StockTableAdapter
            // 
            this.tbl_Add_Update_StockTableAdapter.ClearBeforeFill = true;
            // 
            // View_All_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.cb_v_name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_Vstock);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgv_Stock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_All_stock";
            this.Text = "View_All_stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_stock_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddUpdateStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_view_All_Stock;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cb_Vstock;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView dgv_Stock;
        internal System.Windows.Forms.ComboBox cb_v_name;
        private Saii_Carving_Shop_InfoDataSet5 saii_Carving_Shop_InfoDataSet5;
        private System.Windows.Forms.BindingSource tblAddUpdateStockBindingSource;
        private Saii_Carving_Shop_InfoDataSet5TableAdapters.tbl_Add_Update_StockTableAdapter tbl_Add_Update_StockTableAdapter;
    }
}