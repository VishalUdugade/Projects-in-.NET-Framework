namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_Customer
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
            this.cb_v_Customer = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.lbl_view_Single_All_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet3 = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet3();
            this.customer_DetailsTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet3TableAdapters.Customer_DetailsTableAdapter();
            this.dgv_v_Customer = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_v_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(896, 192);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 44);
            this.btn_Close.TabIndex = 67;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(571, 192);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(116, 44);
            this.btn_Refresh.TabIndex = 64;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(266, 192);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 44);
            this.btn_Search.TabIndex = 63;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_v_Customer
            // 
            this.cb_v_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_v_Customer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_v_Customer.FormattingEnabled = true;
            this.cb_v_Customer.Items.AddRange(new object[] {
            "Customer Name",
            "Mobile Number"});
            this.cb_v_Customer.Location = new System.Drawing.Point(451, 94);
            this.cb_v_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.cb_v_Customer.Name = "cb_v_Customer";
            this.cb_v_Customer.Size = new System.Drawing.Size(266, 35);
            this.cb_v_Customer.TabIndex = 61;
            this.cb_v_Customer.SelectedIndexChanged += new System.EventHandler(this.cb_v_Customer_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(24, 94);
            this.lbl_Search_Customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(223, 26);
            this.lbl_Search_Customer.TabIndex = 66;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // lbl_view_Single_All_Customer
            // 
            this.lbl_view_Single_All_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_Single_All_Customer.AutoSize = true;
            this.lbl_view_Single_All_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_Single_All_Customer.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_Single_All_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_view_Single_All_Customer.Location = new System.Drawing.Point(556, 10);
            this.lbl_view_Single_All_Customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_view_Single_All_Customer.Name = "lbl_view_Single_All_Customer";
            this.lbl_view_Single_All_Customer.Size = new System.Drawing.Size(410, 55);
            this.lbl_view_Single_All_Customer.TabIndex = 0;
            this.lbl_view_Single_All_Customer.Text = "View All Customer";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_Single_All_Customer);
            this.Panel1.Location = new System.Drawing.Point(11, 2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1522, 82);
            this.Panel1.TabIndex = 65;
            // 
            // cb_name
            // 
            this.cb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(832, 93);
            this.cb_name.Margin = new System.Windows.Forms.Padding(2);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(266, 35);
            this.cb_name.TabIndex = 68;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "Customer_Details";
            this.customerDetailsBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet3;
            // 
            // saii_Carving_Shop_InfoDataSet3
            // 
            this.saii_Carving_Shop_InfoDataSet3.DataSetName = "Saii_Carving_Shop_InfoDataSet3";
            this.saii_Carving_Shop_InfoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_DetailsTableAdapter
            // 
            this.customer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_v_Customer
            // 
            this.dgv_v_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_v_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_v_Customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_v_Customer.Location = new System.Drawing.Point(0, 296);
            this.dgv_v_Customer.Name = "dgv_v_Customer";
            this.dgv_v_Customer.Size = new System.Drawing.Size(1350, 433);
            this.dgv_v_Customer.TabIndex = 69;
            // 
            // View_All_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_v_Customer);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_v_Customer);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_All_Customer";
            this.Text = "View_All_Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.View_All_Customer_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_v_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cb_v_Customer;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Label lbl_view_Single_All_Customer;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox cb_name;
        private Saii_Carving_Shop_InfoDataSet3 saii_Carving_Shop_InfoDataSet3;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private Saii_Carving_Shop_InfoDataSet3TableAdapters.Customer_DetailsTableAdapter customer_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_v_Customer;
    }
}