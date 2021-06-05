namespace Saii_Carving_Shop_Management_System
{
    partial class View_All_Material
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
            this.lbl_view_All_Material = new System.Windows.Forms.Label();
            this.cb_v_Material = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.cb_Material_name = new System.Windows.Forms.ComboBox();
            this.tblAddNewMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saii_Carving_Shop_InfoDataSet = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSet();
            this.tbl_Add_New_MaterialTableAdapter = new Saii_Carving_Shop_Management_System.Saii_Carving_Shop_InfoDataSetTableAdapters.tbl_Add_New_MaterialTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddNewMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1335, 392);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(115, 42);
            this.btn_Close.TabIndex = 86;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1003, 392);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(115, 42);
            this.btn_Refresh.TabIndex = 85;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(697, 392);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 42);
            this.btn_Search.TabIndex = 84;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_view_All_Material
            // 
            this.lbl_view_All_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_view_All_Material.AutoSize = true;
            this.lbl_view_All_Material.BackColor = System.Drawing.Color.Transparent;
            this.lbl_view_All_Material.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_All_Material.ForeColor = System.Drawing.Color.White;
            this.lbl_view_All_Material.Location = new System.Drawing.Point(680, 12);
            this.lbl_view_All_Material.Name = "lbl_view_All_Material";
            this.lbl_view_All_Material.Size = new System.Drawing.Size(548, 77);
            this.lbl_view_All_Material.TabIndex = 0;
            this.lbl_view_All_Material.Text = "View All Material";
            // 
            // cb_v_Material
            // 
            this.cb_v_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_v_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_v_Material.FormattingEnabled = true;
            this.cb_v_Material.Items.AddRange(new object[] {
            "Material ID",
            "Material Name",
            "Material Thikness"});
            this.cb_v_Material.Location = new System.Drawing.Point(731, 243);
            this.cb_v_Material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_v_Material.Name = "cb_v_Material";
            this.cb_v_Material.Size = new System.Drawing.Size(333, 39);
            this.cb_v_Material.TabIndex = 82;
            this.cb_v_Material.SelectedIndexChanged += new System.EventHandler(this.cb_v_Material_SelectedIndexChanged);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer.Location = new System.Drawing.Point(243, 247);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(316, 38);
            this.lbl_Search_Customer.TabIndex = 89;
            this.lbl_Search_Customer.Text = "Search Customer By";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.lbl_view_All_Material);
            this.Panel1.Location = new System.Drawing.Point(0, 2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1908, 102);
            this.Panel1.TabIndex = 88;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Employee.Location = new System.Drawing.Point(0, 578);
            this.dgv_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(1902, 455);
            this.dgv_Employee.TabIndex = 87;
            // 
            // cb_Material_name
            // 
            this.cb_Material_name.DataSource = this.tblAddNewMaterialBindingSource;
            this.cb_Material_name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Material_name.FormattingEnabled = true;
            this.cb_Material_name.Location = new System.Drawing.Point(1203, 247);
            this.cb_Material_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Material_name.Name = "cb_Material_name";
            this.cb_Material_name.Size = new System.Drawing.Size(333, 39);
            this.cb_Material_name.TabIndex = 90;
            // 
            // tblAddNewMaterialBindingSource
            // 
            this.tblAddNewMaterialBindingSource.DataMember = "tbl_Add_New_Material";
            this.tblAddNewMaterialBindingSource.DataSource = this.saii_Carving_Shop_InfoDataSet;
            // 
            // saii_Carving_Shop_InfoDataSet
            // 
            this.saii_Carving_Shop_InfoDataSet.DataSetName = "Saii_Carving_Shop_InfoDataSet";
            this.saii_Carving_Shop_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_New_MaterialTableAdapter
            // 
            this.tbl_Add_New_MaterialTableAdapter.ClearBeforeFill = true;
            // 
            // View_All_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.cb_Material_name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_v_Material);
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgv_Employee);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_All_Material";
            this.Text = "View_All_Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Material_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddNewMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saii_Carving_Shop_InfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.Label lbl_view_All_Material;
        internal System.Windows.Forms.ComboBox cb_v_Material;
        internal System.Windows.Forms.Label lbl_Search_Customer;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ComboBox cb_Material_name;
        private Saii_Carving_Shop_InfoDataSet saii_Carving_Shop_InfoDataSet;
        private System.Windows.Forms.BindingSource tblAddNewMaterialBindingSource;
        private Saii_Carving_Shop_InfoDataSetTableAdapters.tbl_Add_New_MaterialTableAdapter tbl_Add_New_MaterialTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Employee;

    }
}