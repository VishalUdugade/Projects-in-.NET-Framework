namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_Employee
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
            this.lbl_view_All_Employee = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_v_Employee = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.cb_e_name = new System.Windows.Forms.ComboBox();
            this.tblAddNewEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet4 = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet4();
            this.tbl_Add_New_EmployeeTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet4TableAdapters.tbl_Add_New_EmployeeTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddNewEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_view_All_Employee
            // 
            this.lbl_view_All_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_All_Employee.AutoSize = true;
            this.lbl_view_All_Employee.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_All_Employee.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_All_Employee.ForeColor = System.Drawing.Color.White;
            this.lbl_view_All_Employee.Location = new System.Drawing.Point(662, 12);
            this.lbl_view_All_Employee.Name = "lbl_view_All_Employee";
            this.lbl_view_All_Employee.Size = new System.Drawing.Size(579, 77);
            this.lbl_view_All_Employee.TabIndex = 0;
            this.lbl_view_All_Employee.Text = "View All Employee";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1291, 358);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(131, 50);
            this.btn_Close.TabIndex = 70;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1018, 358);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 50);
            this.btn_Refresh.TabIndex = 69;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(737, 358);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 50);
            this.btn_Search.TabIndex = 68;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_v_Employee
            // 
            this.cb_v_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_v_Employee.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_v_Employee.FormattingEnabled = true;
            this.cb_v_Employee.Items.AddRange(new object[] {
            "Employee ID",
            "Mobile Number"});
            this.cb_v_Employee.Location = new System.Drawing.Point(784, 212);
            this.cb_v_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_v_Employee.Name = "cb_v_Employee";
            this.cb_v_Employee.Size = new System.Drawing.Size(333, 42);
            this.cb_v_Employee.TabIndex = 66;
            this.cb_v_Employee.SelectedIndexChanged += new System.EventHandler(this.cb_v_Employee_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(296, 212);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(316, 38);
            this.lbl_Search_Customer.TabIndex = 73;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_All_Employee);
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1902, 102);
            this.Panel1.TabIndex = 72;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Employee.Location = new System.Drawing.Point(0, 510);
            this.dgv_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(1902, 523);
            this.dgv_Employee.TabIndex = 71;
            // 
            // cb_e_name
            // 
            this.cb_e_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_e_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_e_name.DataSource = this.tblAddNewEmployeeBindingSource;
            this.cb_e_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_e_name.FormattingEnabled = true;
            this.cb_e_name.Location = new System.Drawing.Point(1274, 212);
            this.cb_e_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_e_name.Name = "cb_e_name";
            this.cb_e_name.Size = new System.Drawing.Size(333, 42);
            this.cb_e_name.TabIndex = 74;
            // 
            // tblAddNewEmployeeBindingSource
            // 
            this.tblAddNewEmployeeBindingSource.DataMember = "tbl_Add_New_Employee";
            this.tblAddNewEmployeeBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet4;
            // 
            // saii_Carving_Shop_InfoDataSet4
            // 
            this.saii_Carving_Shop_InfoDataSet4.DataSetName = "Saii_Carving_Shop_InfoDataSet4";
            this.saii_Carving_Shop_InfoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_New_EmployeeTableAdapter
            // 
            this.tbl_Add_New_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.cb_e_name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_v_Employee);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgv_Employee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_All_Employee";
            this.Text = "View_All_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Employee_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddNewEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_view_All_Employee;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cb_v_Employee;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView dgv_Employee;
        internal System.Windows.Forms.ComboBox cb_e_name;
        private Saii_Carving_Shop_InfoDataSet4 saii_Carving_Shop_InfoDataSet4;
        private System.Windows.Forms.BindingSource tblAddNewEmployeeBindingSource;
        private Saii_Carving_Shop_InfoDataSet4TableAdapters.tbl_Add_New_EmployeeTableAdapter tbl_Add_New_EmployeeTableAdapter;
    }
}