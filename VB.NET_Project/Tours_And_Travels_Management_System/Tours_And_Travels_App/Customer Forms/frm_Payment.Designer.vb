<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Payment))
        Me.panel_pkg_Payment = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_fees_Payment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Customer_pkg_Info = New System.Windows.Forms.GroupBox()
        Me.tb_pkg_name = New System.Windows.Forms.TextBox()
        Me.tb_pay_id = New System.Windows.Forms.TextBox()
        Me.lbl_pay_id = New System.Windows.Forms.Label()
        Me.tb_pkg_id = New System.Windows.Forms.TextBox()
        Me.tb_Cust_id = New System.Windows.Forms.TextBox()
        Me.tb_pkg_adult_price = New System.Windows.Forms.TextBox()
        Me.lbl_Adult_Price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_pkg_chlidren_price = New System.Windows.Forms.TextBox()
        Me.lbl_Children_price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Pkg_Grand_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Grand_Total = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.dtp_pay_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Payment_Date = New System.Windows.Forms.Label()
        Me.lbl_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Package_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Customer_id = New System.Windows.Forms.Label()
        Me.tb_cust_name = New System.Windows.Forms.TextBox()
        Me.lbl_Cust_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Payment_Details = New System.Windows.Forms.GroupBox()
        Me.tb_Total_of_Children_Adult = New System.Windows.Forms.TextBox()
        Me.lbl_Tot_of_adult_children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_grand_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_tot_chi_adult = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Payment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_total_of_Adult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_adult_price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_no_of_adult = New System.Windows.Forms.TextBox()
        Me.lbl_Total_of_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_total_of_children = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_children_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_no_of_children = New System.Windows.Forms.TextBox()
        Me.lbl_Total_of_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_cust_no = New System.Windows.Forms.Label()
        Me.panel_full_pay = New System.Windows.Forms.Panel()
        Me.tb_Full_Pay = New System.Windows.Forms.TextBox()
        Me.lbl_full_pay = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_grass_pay_amount = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Grass_Amount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Discount = New System.Windows.Forms.TextBox()
        Me.lbl_Discount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Advance_pay = New System.Windows.Forms.Panel()
        Me.tb_Pay_Amount = New System.Windows.Forms.TextBox()
        Me.lbl_Enter_Amount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_remainig_pay_amount = New System.Windows.Forms.TextBox()
        Me.lbl_Remainig_Payment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Previous_Payment = New System.Windows.Forms.TextBox()
        Me.lbl_Previous_Pay = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rb_Full_Pay = New System.Windows.Forms.RadioButton()
        Me.rb_Advance = New System.Windows.Forms.RadioButton()
        Me.lbl_Payment_Mode = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_payble_amount = New System.Windows.Forms.TextBox()
        Me.lbl_Plus = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dgv_previous_payment = New System.Windows.Forms.DataGridView()
        Me.btn_Bill = New System.Windows.Forms.Button()
        Me.panel_pkg_Payment.SuspendLayout()
        Me.gb_Customer_pkg_Info.SuspendLayout()
        Me.gb_Payment_Details.SuspendLayout()
        Me.panel_full_pay.SuspendLayout()
        Me.panel_Advance_pay.SuspendLayout()
        CType(Me.dgv_previous_payment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_pkg_Payment
        '
        Me.panel_pkg_Payment.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_pkg_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_pkg_Payment.Controls.Add(Me.lbl_fees_Payment)
        Me.panel_pkg_Payment.ForeColor = System.Drawing.Color.Gray
        Me.panel_pkg_Payment.GradientBottomLeft = System.Drawing.Color.SteelBlue
        Me.panel_pkg_Payment.GradientBottomRight = System.Drawing.SystemColors.ControlText
        Me.panel_pkg_Payment.GradientTopLeft = System.Drawing.SystemColors.ButtonFace
        Me.panel_pkg_Payment.GradientTopRight = System.Drawing.Color.Khaki
        Me.panel_pkg_Payment.Location = New System.Drawing.Point(2, 0)
        Me.panel_pkg_Payment.Name = "panel_pkg_Payment"
        Me.panel_pkg_Payment.Quality = 10
        Me.panel_pkg_Payment.Size = New System.Drawing.Size(1005, 56)
        Me.panel_pkg_Payment.TabIndex = 1
        '
        'lbl_fees_Payment
        '
        Me.lbl_fees_Payment.AutoSize = True
        Me.lbl_fees_Payment.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fees_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fees_Payment.ForeColor = System.Drawing.Color.White
        Me.lbl_fees_Payment.Location = New System.Drawing.Point(363, 9)
        Me.lbl_fees_Payment.Name = "lbl_fees_Payment"
        Me.lbl_fees_Payment.Size = New System.Drawing.Size(374, 37)
        Me.lbl_fees_Payment.TabIndex = 0
        Me.lbl_fees_Payment.Text = "Package Fees Payment"
        '
        'gb_Customer_pkg_Info
        '
        Me.gb_Customer_pkg_Info.BackColor = System.Drawing.Color.Khaki
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_pkg_name)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_pay_id)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_pay_id)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_pkg_id)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_Cust_id)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_pkg_adult_price)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Adult_Price)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_pkg_chlidren_price)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Children_price)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_Pkg_Grand_Total)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Grand_Total)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.btn_Search)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.dtp_pay_date)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Payment_Date)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Name)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Package_ID)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Customer_id)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.tb_cust_name)
        Me.gb_Customer_pkg_Info.Controls.Add(Me.lbl_Cust_Name)
        Me.gb_Customer_pkg_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Customer_pkg_Info.Location = New System.Drawing.Point(2, 60)
        Me.gb_Customer_pkg_Info.Name = "gb_Customer_pkg_Info"
        Me.gb_Customer_pkg_Info.Size = New System.Drawing.Size(1005, 177)
        Me.gb_Customer_pkg_Info.TabIndex = 2
        Me.gb_Customer_pkg_Info.TabStop = False
        Me.gb_Customer_pkg_Info.Text = "Customer/Package Information"
        '
        'tb_pkg_name
        '
        Me.tb_pkg_name.Enabled = False
        Me.tb_pkg_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tb_pkg_name.Location = New System.Drawing.Point(213, 120)
        Me.tb_pkg_name.Name = "tb_pkg_name"
        Me.tb_pkg_name.Size = New System.Drawing.Size(466, 22)
        Me.tb_pkg_name.TabIndex = 480
        '
        'tb_pay_id
        '
        Me.tb_pay_id.Enabled = False
        Me.tb_pay_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pay_id.Location = New System.Drawing.Point(853, 17)
        Me.tb_pay_id.Name = "tb_pay_id"
        Me.tb_pay_id.Size = New System.Drawing.Size(135, 22)
        Me.tb_pay_id.TabIndex = 479
        Me.tb_pay_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_pay_id
        '
        Me.lbl_pay_id.AutoSize = True
        Me.lbl_pay_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_id.Location = New System.Drawing.Point(689, 18)
        Me.lbl_pay_id.Name = "lbl_pay_id"
        Me.lbl_pay_id.Size = New System.Drawing.Size(99, 20)
        Me.lbl_pay_id.TabIndex = 478
        Me.lbl_pay_id.Text = "Payment Id"
        '
        'tb_pkg_id
        '
        Me.tb_pkg_id.Enabled = False
        Me.tb_pkg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_id.Location = New System.Drawing.Point(213, 90)
        Me.tb_pkg_id.Name = "tb_pkg_id"
        Me.tb_pkg_id.Size = New System.Drawing.Size(128, 22)
        Me.tb_pkg_id.TabIndex = 477
        '
        'tb_Cust_id
        '
        Me.tb_Cust_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cust_id.Location = New System.Drawing.Point(213, 32)
        Me.tb_Cust_id.Name = "tb_Cust_id"
        Me.tb_Cust_id.Size = New System.Drawing.Size(128, 22)
        Me.tb_Cust_id.TabIndex = 1
        '
        'tb_pkg_adult_price
        '
        Me.tb_pkg_adult_price.Enabled = False
        Me.tb_pkg_adult_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_adult_price.Location = New System.Drawing.Point(869, 146)
        Me.tb_pkg_adult_price.Name = "tb_pkg_adult_price"
        Me.tb_pkg_adult_price.Size = New System.Drawing.Size(128, 22)
        Me.tb_pkg_adult_price.TabIndex = 475
        Me.tb_pkg_adult_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Adult_Price
        '
        Me.lbl_Adult_Price.AutoSize = True
        Me.lbl_Adult_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adult_Price.Location = New System.Drawing.Point(754, 149)
        Me.lbl_Adult_Price.Name = "lbl_Adult_Price"
        Me.lbl_Adult_Price.Size = New System.Drawing.Size(83, 16)
        Me.lbl_Adult_Price.TabIndex = 474
        Me.lbl_Adult_Price.Text = "Adult Price"
        '
        'tb_pkg_chlidren_price
        '
        Me.tb_pkg_chlidren_price.Enabled = False
        Me.tb_pkg_chlidren_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_chlidren_price.Location = New System.Drawing.Point(551, 149)
        Me.tb_pkg_chlidren_price.Name = "tb_pkg_chlidren_price"
        Me.tb_pkg_chlidren_price.Size = New System.Drawing.Size(128, 22)
        Me.tb_pkg_chlidren_price.TabIndex = 473
        Me.tb_pkg_chlidren_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Children_price
        '
        Me.lbl_Children_price.AutoSize = True
        Me.lbl_Children_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Children_price.Location = New System.Drawing.Point(422, 152)
        Me.lbl_Children_price.Name = "lbl_Children_price"
        Me.lbl_Children_price.Size = New System.Drawing.Size(105, 16)
        Me.lbl_Children_price.TabIndex = 472
        Me.lbl_Children_price.Text = "Children Price"
        '
        'tb_Pkg_Grand_Total
        '
        Me.tb_Pkg_Grand_Total.Enabled = False
        Me.tb_Pkg_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Pkg_Grand_Total.Location = New System.Drawing.Point(213, 149)
        Me.tb_Pkg_Grand_Total.Name = "tb_Pkg_Grand_Total"
        Me.tb_Pkg_Grand_Total.Size = New System.Drawing.Size(128, 22)
        Me.tb_Pkg_Grand_Total.TabIndex = 471
        Me.tb_Pkg_Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Grand_Total
        '
        Me.lbl_Grand_Total.AutoSize = True
        Me.lbl_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grand_Total.Location = New System.Drawing.Point(8, 155)
        Me.lbl_Grand_Total.Name = "lbl_Grand_Total"
        Me.lbl_Grand_Total.Size = New System.Drawing.Size(173, 16)
        Me.lbl_Grand_Total.TabIndex = 470
        Me.lbl_Grand_Total.Text = "Grand Total of Package"
        '
        'btn_Search
        '
        Me.btn_Search.AutoSize = True
        Me.btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.btn_Search.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Search.Location = New System.Drawing.Point(398, 14)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(111, 40)
        Me.btn_Search.TabIndex = 469
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'dtp_pay_date
        '
        Me.dtp_pay_date.Enabled = False
        Me.dtp_pay_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_pay_date.Location = New System.Drawing.Point(853, 52)
        Me.dtp_pay_date.Name = "dtp_pay_date"
        Me.dtp_pay_date.Size = New System.Drawing.Size(135, 26)
        Me.dtp_pay_date.TabIndex = 468
        Me.dtp_pay_date.Value = New Date(2020, 1, 14, 12, 22, 54, 0)
        '
        'lbl_Payment_Date
        '
        Me.lbl_Payment_Date.AutoSize = True
        Me.lbl_Payment_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Payment_Date.Location = New System.Drawing.Point(689, 56)
        Me.lbl_Payment_Date.Name = "lbl_Payment_Date"
        Me.lbl_Payment_Date.Size = New System.Drawing.Size(122, 20)
        Me.lbl_Payment_Date.TabIndex = 467
        Me.lbl_Payment_Date.Text = "Payment Date"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(10, 125)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(115, 16)
        Me.lbl_Name.TabIndex = 465
        Me.lbl_Name.Text = "Package Name"
        '
        'lbl_Package_ID
        '
        Me.lbl_Package_ID.AutoSize = True
        Me.lbl_Package_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_ID.Location = New System.Drawing.Point(10, 93)
        Me.lbl_Package_ID.Name = "lbl_Package_ID"
        Me.lbl_Package_ID.Size = New System.Drawing.Size(89, 16)
        Me.lbl_Package_ID.TabIndex = 463
        Me.lbl_Package_ID.Text = "Package ID"
        '
        'lbl_Customer_id
        '
        Me.lbl_Customer_id.AutoSize = True
        Me.lbl_Customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer_id.Location = New System.Drawing.Point(9, 35)
        Me.lbl_Customer_id.Name = "lbl_Customer_id"
        Me.lbl_Customer_id.Size = New System.Drawing.Size(92, 16)
        Me.lbl_Customer_id.TabIndex = 460
        Me.lbl_Customer_id.Text = "Customer ID"
        '
        'tb_cust_name
        '
        Me.tb_cust_name.Enabled = False
        Me.tb_cust_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cust_name.ForeColor = System.Drawing.Color.Black
        Me.tb_cust_name.Location = New System.Drawing.Point(213, 62)
        Me.tb_cust_name.MaxLength = 30
        Me.tb_cust_name.Name = "tb_cust_name"
        Me.tb_cust_name.Size = New System.Drawing.Size(305, 22)
        Me.tb_cust_name.TabIndex = 4
        '
        'lbl_Cust_Name
        '
        Me.lbl_Cust_Name.AutoSize = True
        Me.lbl_Cust_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cust_Name.Location = New System.Drawing.Point(8, 68)
        Me.lbl_Cust_Name.Name = "lbl_Cust_Name"
        Me.lbl_Cust_Name.Size = New System.Drawing.Size(118, 16)
        Me.lbl_Cust_Name.TabIndex = 5
        Me.lbl_Cust_Name.Text = "Customer Name"
        '
        'gb_Payment_Details
        '
        Me.gb_Payment_Details.BackColor = System.Drawing.Color.Khaki
        Me.gb_Payment_Details.Controls.Add(Me.tb_Total_of_Children_Adult)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Tot_of_adult_children)
        Me.gb_Payment_Details.Controls.Add(Me.Label9)
        Me.gb_Payment_Details.Controls.Add(Me.Label7)
        Me.gb_Payment_Details.Controls.Add(Me.tb_grand_total)
        Me.gb_Payment_Details.Controls.Add(Me.Label8)
        Me.gb_Payment_Details.Controls.Add(Me.tb_tot_chi_adult)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Total_Payment)
        Me.gb_Payment_Details.Controls.Add(Me.tb_total_of_Adult)
        Me.gb_Payment_Details.Controls.Add(Me.Label5)
        Me.gb_Payment_Details.Controls.Add(Me.tb_adult_price)
        Me.gb_Payment_Details.Controls.Add(Me.Label6)
        Me.gb_Payment_Details.Controls.Add(Me.tb_no_of_adult)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Total_of_Adult)
        Me.gb_Payment_Details.Controls.Add(Me.tb_total_of_children)
        Me.gb_Payment_Details.Controls.Add(Me.Label4)
        Me.gb_Payment_Details.Controls.Add(Me.tb_children_price)
        Me.gb_Payment_Details.Controls.Add(Me.Label1)
        Me.gb_Payment_Details.Controls.Add(Me.tb_no_of_children)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Total_of_Children)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_cust_no)
        Me.gb_Payment_Details.Controls.Add(Me.panel_full_pay)
        Me.gb_Payment_Details.Controls.Add(Me.tb_grass_pay_amount)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Total_Grass_Amount)
        Me.gb_Payment_Details.Controls.Add(Me.tb_Discount)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Discount)
        Me.gb_Payment_Details.Controls.Add(Me.panel_Advance_pay)
        Me.gb_Payment_Details.Controls.Add(Me.rb_Full_Pay)
        Me.gb_Payment_Details.Controls.Add(Me.rb_Advance)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Payment_Mode)
        Me.gb_Payment_Details.Controls.Add(Me.tb_payble_amount)
        Me.gb_Payment_Details.Controls.Add(Me.lbl_Plus)
        Me.gb_Payment_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Payment_Details.Location = New System.Drawing.Point(2, 241)
        Me.gb_Payment_Details.Name = "gb_Payment_Details"
        Me.gb_Payment_Details.Size = New System.Drawing.Size(1005, 294)
        Me.gb_Payment_Details.TabIndex = 3
        Me.gb_Payment_Details.TabStop = False
        Me.gb_Payment_Details.Text = "Payment Details"
        '
        'tb_Total_of_Children_Adult
        '
        Me.tb_Total_of_Children_Adult.Enabled = False
        Me.tb_Total_of_Children_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Total_of_Children_Adult.Location = New System.Drawing.Point(771, 37)
        Me.tb_Total_of_Children_Adult.Name = "tb_Total_of_Children_Adult"
        Me.tb_Total_of_Children_Adult.Size = New System.Drawing.Size(137, 22)
        Me.tb_Total_of_Children_Adult.TabIndex = 497
        Me.tb_Total_of_Children_Adult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Tot_of_adult_children
        '
        Me.lbl_Tot_of_adult_children.AutoSize = True
        Me.lbl_Tot_of_adult_children.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tot_of_adult_children.Location = New System.Drawing.Point(744, 17)
        Me.lbl_Tot_of_adult_children.Name = "lbl_Tot_of_adult_children"
        Me.lbl_Tot_of_adult_children.Size = New System.Drawing.Size(191, 16)
        Me.lbl_Tot_of_adult_children.TabIndex = 496
        Me.lbl_Tot_of_adult_children.Text = "Total of Adult and Children"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Khaki
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(327, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 26)
        Me.Label9.TabIndex = 495
        Me.Label9.Text = "%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Khaki
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(511, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 26)
        Me.Label7.TabIndex = 494
        Me.Label7.Text = "="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_grand_total
        '
        Me.tb_grand_total.Enabled = False
        Me.tb_grand_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_grand_total.Location = New System.Drawing.Point(213, 80)
        Me.tb_grand_total.Name = "tb_grand_total"
        Me.tb_grand_total.Size = New System.Drawing.Size(128, 22)
        Me.tb_grand_total.TabIndex = 493
        Me.tb_grand_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Khaki
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(351, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 26)
        Me.Label8.TabIndex = 492
        Me.Label8.Text = "+"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_tot_chi_adult
        '
        Me.tb_tot_chi_adult.Enabled = False
        Me.tb_tot_chi_adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tot_chi_adult.Location = New System.Drawing.Point(373, 80)
        Me.tb_tot_chi_adult.Name = "tb_tot_chi_adult"
        Me.tb_tot_chi_adult.Size = New System.Drawing.Size(128, 22)
        Me.tb_tot_chi_adult.TabIndex = 491
        Me.tb_tot_chi_adult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_Payment
        '
        Me.lbl_Total_Payment.AutoSize = True
        Me.lbl_Total_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Payment.Location = New System.Drawing.Point(14, 83)
        Me.lbl_Total_Payment.Name = "lbl_Total_Payment"
        Me.lbl_Total_Payment.Size = New System.Drawing.Size(123, 16)
        Me.lbl_Total_Payment.TabIndex = 490
        Me.lbl_Total_Payment.Text = "Payment Amount"
        '
        'tb_total_of_Adult
        '
        Me.tb_total_of_Adult.Enabled = False
        Me.tb_total_of_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_of_Adult.Location = New System.Drawing.Point(538, 49)
        Me.tb_total_of_Adult.Name = "tb_total_of_Adult"
        Me.tb_total_of_Adult.Size = New System.Drawing.Size(128, 22)
        Me.tb_total_of_Adult.TabIndex = 489
        Me.tb_total_of_Adult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Khaki
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(510, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 26)
        Me.Label5.TabIndex = 488
        Me.Label5.Text = "="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_adult_price
        '
        Me.tb_adult_price.Enabled = False
        Me.tb_adult_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_adult_price.Location = New System.Drawing.Point(373, 50)
        Me.tb_adult_price.Name = "tb_adult_price"
        Me.tb_adult_price.Size = New System.Drawing.Size(128, 22)
        Me.tb_adult_price.TabIndex = 487
        Me.tb_adult_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Khaki
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(351, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 26)
        Me.Label6.TabIndex = 486
        Me.Label6.Text = "x"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_no_of_adult
        '
        Me.tb_no_of_adult.Enabled = False
        Me.tb_no_of_adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_of_adult.Location = New System.Drawing.Point(213, 50)
        Me.tb_no_of_adult.Name = "tb_no_of_adult"
        Me.tb_no_of_adult.Size = New System.Drawing.Size(79, 22)
        Me.tb_no_of_adult.TabIndex = 485
        Me.tb_no_of_adult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_of_Adult
        '
        Me.lbl_Total_of_Adult.AutoSize = True
        Me.lbl_Total_of_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_of_Adult.Location = New System.Drawing.Point(12, 53)
        Me.lbl_Total_of_Adult.Name = "lbl_Total_of_Adult"
        Me.lbl_Total_of_Adult.Size = New System.Drawing.Size(100, 16)
        Me.lbl_Total_of_Adult.TabIndex = 484
        Me.lbl_Total_of_Adult.Text = "Total of Adult"
        '
        'tb_total_of_children
        '
        Me.tb_total_of_children.Enabled = False
        Me.tb_total_of_children.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_of_children.Location = New System.Drawing.Point(538, 19)
        Me.tb_total_of_children.Name = "tb_total_of_children"
        Me.tb_total_of_children.Size = New System.Drawing.Size(128, 22)
        Me.tb_total_of_children.TabIndex = 483
        Me.tb_total_of_children.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Khaki
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(510, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 26)
        Me.Label4.TabIndex = 482
        Me.Label4.Text = "="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_children_price
        '
        Me.tb_children_price.Enabled = False
        Me.tb_children_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_children_price.Location = New System.Drawing.Point(373, 20)
        Me.tb_children_price.Name = "tb_children_price"
        Me.tb_children_price.Size = New System.Drawing.Size(128, 22)
        Me.tb_children_price.TabIndex = 481
        Me.tb_children_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(351, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 26)
        Me.Label1.TabIndex = 480
        Me.Label1.Text = "x"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_no_of_children
        '
        Me.tb_no_of_children.Enabled = False
        Me.tb_no_of_children.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_of_children.Location = New System.Drawing.Point(213, 22)
        Me.tb_no_of_children.Name = "tb_no_of_children"
        Me.tb_no_of_children.Size = New System.Drawing.Size(128, 22)
        Me.tb_no_of_children.TabIndex = 479
        Me.tb_no_of_children.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_of_Children
        '
        Me.lbl_Total_of_Children.AutoSize = True
        Me.lbl_Total_of_Children.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_of_Children.Location = New System.Drawing.Point(12, 25)
        Me.lbl_Total_of_Children.Name = "lbl_Total_of_Children"
        Me.lbl_Total_of_Children.Size = New System.Drawing.Size(122, 16)
        Me.lbl_Total_of_Children.TabIndex = 478
        Me.lbl_Total_of_Children.Text = "Total of Children"
        '
        'lbl_cust_no
        '
        Me.lbl_cust_no.AutoSize = True
        Me.lbl_cust_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust_no.Location = New System.Drawing.Point(325, 53)
        Me.lbl_cust_no.Name = "lbl_cust_no"
        Me.lbl_cust_no.Size = New System.Drawing.Size(16, 16)
        Me.lbl_cust_no.TabIndex = 477
        Me.lbl_cust_no.Text = "1"
        Me.lbl_cust_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_full_pay
        '
        Me.panel_full_pay.Controls.Add(Me.tb_Full_Pay)
        Me.panel_full_pay.Controls.Add(Me.lbl_full_pay)
        Me.panel_full_pay.Enabled = False
        Me.panel_full_pay.Location = New System.Drawing.Point(593, 200)
        Me.panel_full_pay.Name = "panel_full_pay"
        Me.panel_full_pay.Size = New System.Drawing.Size(399, 89)
        Me.panel_full_pay.TabIndex = 476
        '
        'tb_Full_Pay
        '
        Me.tb_Full_Pay.Enabled = False
        Me.tb_Full_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Full_Pay.Location = New System.Drawing.Point(246, 33)
        Me.tb_Full_Pay.Name = "tb_Full_Pay"
        Me.tb_Full_Pay.Size = New System.Drawing.Size(139, 22)
        Me.tb_Full_Pay.TabIndex = 470
        Me.tb_Full_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_full_pay
        '
        Me.lbl_full_pay.AutoSize = True
        Me.lbl_full_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_full_pay.Location = New System.Drawing.Point(19, 39)
        Me.lbl_full_pay.Name = "lbl_full_pay"
        Me.lbl_full_pay.Size = New System.Drawing.Size(97, 16)
        Me.lbl_full_pay.TabIndex = 469
        Me.lbl_full_pay.Text = "Full Payment"
        '
        'tb_grass_pay_amount
        '
        Me.tb_grass_pay_amount.Enabled = False
        Me.tb_grass_pay_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_grass_pay_amount.Location = New System.Drawing.Point(213, 138)
        Me.tb_grass_pay_amount.Name = "tb_grass_pay_amount"
        Me.tb_grass_pay_amount.Size = New System.Drawing.Size(160, 22)
        Me.tb_grass_pay_amount.TabIndex = 475
        Me.tb_grass_pay_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_Grass_Amount
        '
        Me.lbl_Total_Grass_Amount.AutoSize = True
        Me.lbl_Total_Grass_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Grass_Amount.Location = New System.Drawing.Point(12, 144)
        Me.lbl_Total_Grass_Amount.Name = "lbl_Total_Grass_Amount"
        Me.lbl_Total_Grass_Amount.Size = New System.Drawing.Size(172, 16)
        Me.lbl_Total_Grass_Amount.TabIndex = 474
        Me.lbl_Total_Grass_Amount.Text = "Grass Payment Amount "
        '
        'tb_Discount
        '
        Me.tb_Discount.Enabled = False
        Me.tb_Discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Discount.Location = New System.Drawing.Point(213, 109)
        Me.tb_Discount.Name = "tb_Discount"
        Me.tb_Discount.Size = New System.Drawing.Size(107, 22)
        Me.tb_Discount.TabIndex = 473
        Me.tb_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Discount
        '
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Discount.Location = New System.Drawing.Point(12, 112)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(68, 16)
        Me.lbl_Discount.TabIndex = 472
        Me.lbl_Discount.Text = "Discount"
        '
        'panel_Advance_pay
        '
        Me.panel_Advance_pay.Controls.Add(Me.tb_Pay_Amount)
        Me.panel_Advance_pay.Controls.Add(Me.lbl_Enter_Amount)
        Me.panel_Advance_pay.Controls.Add(Me.tb_remainig_pay_amount)
        Me.panel_Advance_pay.Controls.Add(Me.lbl_Remainig_Payment)
        Me.panel_Advance_pay.Controls.Add(Me.tb_Previous_Payment)
        Me.panel_Advance_pay.Controls.Add(Me.lbl_Previous_Pay)
        Me.panel_Advance_pay.Enabled = False
        Me.panel_Advance_pay.Location = New System.Drawing.Point(0, 200)
        Me.panel_Advance_pay.Name = "panel_Advance_pay"
        Me.panel_Advance_pay.Size = New System.Drawing.Size(583, 89)
        Me.panel_Advance_pay.TabIndex = 471
        '
        'tb_Pay_Amount
        '
        Me.tb_Pay_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Pay_Amount.Location = New System.Drawing.Point(361, 33)
        Me.tb_Pay_Amount.Name = "tb_Pay_Amount"
        Me.tb_Pay_Amount.Size = New System.Drawing.Size(161, 22)
        Me.tb_Pay_Amount.TabIndex = 474
        Me.tb_Pay_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Enter_Amount
        '
        Me.lbl_Enter_Amount.AutoSize = True
        Me.lbl_Enter_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Enter_Amount.Location = New System.Drawing.Point(13, 39)
        Me.lbl_Enter_Amount.Name = "lbl_Enter_Amount"
        Me.lbl_Enter_Amount.Size = New System.Drawing.Size(130, 16)
        Me.lbl_Enter_Amount.TabIndex = 473
        Me.lbl_Enter_Amount.Text = "Enter Pay Amount"
        '
        'tb_remainig_pay_amount
        '
        Me.tb_remainig_pay_amount.Enabled = False
        Me.tb_remainig_pay_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_remainig_pay_amount.Location = New System.Drawing.Point(362, 62)
        Me.tb_remainig_pay_amount.Name = "tb_remainig_pay_amount"
        Me.tb_remainig_pay_amount.Size = New System.Drawing.Size(160, 22)
        Me.tb_remainig_pay_amount.TabIndex = 472
        Me.tb_remainig_pay_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Remainig_Payment
        '
        Me.lbl_Remainig_Payment.AutoSize = True
        Me.lbl_Remainig_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remainig_Payment.Location = New System.Drawing.Point(11, 66)
        Me.lbl_Remainig_Payment.Name = "lbl_Remainig_Payment"
        Me.lbl_Remainig_Payment.Size = New System.Drawing.Size(193, 16)
        Me.lbl_Remainig_Payment.TabIndex = 471
        Me.lbl_Remainig_Payment.Text = "Remainig Payment Amount"
        '
        'tb_Previous_Payment
        '
        Me.tb_Previous_Payment.Enabled = False
        Me.tb_Previous_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Previous_Payment.Location = New System.Drawing.Point(360, 5)
        Me.tb_Previous_Payment.Name = "tb_Previous_Payment"
        Me.tb_Previous_Payment.Size = New System.Drawing.Size(162, 22)
        Me.tb_Previous_Payment.TabIndex = 470
        Me.tb_Previous_Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Previous_Pay
        '
        Me.lbl_Previous_Pay.AutoSize = True
        Me.lbl_Previous_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Previous_Pay.Location = New System.Drawing.Point(12, 8)
        Me.lbl_Previous_Pay.Name = "lbl_Previous_Pay"
        Me.lbl_Previous_Pay.Size = New System.Drawing.Size(173, 16)
        Me.lbl_Previous_Pay.TabIndex = 469
        Me.lbl_Previous_Pay.Text = "Total Previous Payment"
        '
        'rb_Full_Pay
        '
        Me.rb_Full_Pay.AutoSize = True
        Me.rb_Full_Pay.Enabled = False
        Me.rb_Full_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Full_Pay.Location = New System.Drawing.Point(722, 174)
        Me.rb_Full_Pay.Name = "rb_Full_Pay"
        Me.rb_Full_Pay.Size = New System.Drawing.Size(115, 20)
        Me.rb_Full_Pay.TabIndex = 470
        Me.rb_Full_Pay.TabStop = True
        Me.rb_Full_Pay.Text = "Full Payment"
        Me.rb_Full_Pay.UseVisualStyleBackColor = True
        '
        'rb_Advance
        '
        Me.rb_Advance.AutoSize = True
        Me.rb_Advance.Enabled = False
        Me.rb_Advance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Advance.Location = New System.Drawing.Point(362, 174)
        Me.rb_Advance.Name = "rb_Advance"
        Me.rb_Advance.Size = New System.Drawing.Size(87, 20)
        Me.rb_Advance.TabIndex = 469
        Me.rb_Advance.TabStop = True
        Me.rb_Advance.Text = "Advance"
        Me.rb_Advance.UseVisualStyleBackColor = True
        '
        'lbl_Payment_Mode
        '
        Me.lbl_Payment_Mode.AutoSize = True
        Me.lbl_Payment_Mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Payment_Mode.Location = New System.Drawing.Point(12, 174)
        Me.lbl_Payment_Mode.Name = "lbl_Payment_Mode"
        Me.lbl_Payment_Mode.Size = New System.Drawing.Size(111, 16)
        Me.lbl_Payment_Mode.TabIndex = 468
        Me.lbl_Payment_Mode.Text = "Payment Mode"
        '
        'tb_payble_amount
        '
        Me.tb_payble_amount.Enabled = False
        Me.tb_payble_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_payble_amount.Location = New System.Drawing.Point(538, 79)
        Me.tb_payble_amount.Name = "tb_payble_amount"
        Me.tb_payble_amount.Size = New System.Drawing.Size(128, 22)
        Me.tb_payble_amount.TabIndex = 467
        Me.tb_payble_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Plus
        '
        Me.lbl_Plus.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Plus.Enabled = False
        Me.lbl_Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Plus.ForeColor = System.Drawing.Color.Black
        Me.lbl_Plus.Location = New System.Drawing.Point(302, 47)
        Me.lbl_Plus.Name = "lbl_Plus"
        Me.lbl_Plus.Size = New System.Drawing.Size(17, 26)
        Me.lbl_Plus.TabIndex = 462
        Me.lbl_Plus.Text = "+"
        Me.lbl_Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(13, 685)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(127, 38)
        Me.btn_Back.TabIndex = 566
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.BackgroundImage = CType(resources.GetObject("btn_Save.BackgroundImage"), System.Drawing.Image)
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.Enabled = False
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Save_Icon_16
        Me.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Save.Location = New System.Drawing.Point(541, 686)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(127, 38)
        Me.btn_Save.TabIndex = 565
        Me.btn_Save.Text = "Save"
        Me.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.BackgroundImage = CType(resources.GetObject("btn_Clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Actions_edit_clear_icon__5_
        Me.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Clear.Location = New System.Drawing.Point(872, 685)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(127, 39)
        Me.btn_Clear.TabIndex = 567
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.AutoSize = True
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Enabled = False
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Text_Edit_icon__5_
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_update.Location = New System.Drawing.Point(712, 685)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(127, 38)
        Me.btn_update.TabIndex = 568
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dgv_previous_payment
        '
        Me.dgv_previous_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_previous_payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_previous_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_previous_payment.Location = New System.Drawing.Point(2, 536)
        Me.dgv_previous_payment.Name = "dgv_previous_payment"
        Me.dgv_previous_payment.Size = New System.Drawing.Size(1005, 133)
        Me.dgv_previous_payment.TabIndex = 569
        '
        'btn_Bill
        '
        Me.btn_Bill.AutoSize = True
        Me.btn_Bill.BackColor = System.Drawing.Color.Transparent
        Me.btn_Bill.BackgroundImage = CType(resources.GetObject("btn_Bill.BackgroundImage"), System.Drawing.Image)
        Me.btn_Bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Bill.FlatAppearance.BorderSize = 0
        Me.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bill.ForeColor = System.Drawing.Color.White
        Me.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Bill.Location = New System.Drawing.Point(324, 685)
        Me.btn_Bill.Name = "btn_Bill"
        Me.btn_Bill.Size = New System.Drawing.Size(127, 38)
        Me.btn_Bill.TabIndex = 570
        Me.btn_Bill.Text = "Print Bill"
        Me.btn_Bill.UseVisualStyleBackColor = False
        '
        'frm_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Bill)
        Me.Controls.Add(Me.dgv_previous_payment)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.gb_Payment_Details)
        Me.Controls.Add(Me.gb_Customer_pkg_Info)
        Me.Controls.Add(Me.panel_pkg_Payment)
        Me.Name = "frm_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Payment"
        Me.panel_pkg_Payment.ResumeLayout(False)
        Me.panel_pkg_Payment.PerformLayout()
        Me.gb_Customer_pkg_Info.ResumeLayout(False)
        Me.gb_Customer_pkg_Info.PerformLayout()
        Me.gb_Payment_Details.ResumeLayout(False)
        Me.gb_Payment_Details.PerformLayout()
        Me.panel_full_pay.ResumeLayout(False)
        Me.panel_full_pay.PerformLayout()
        Me.panel_Advance_pay.ResumeLayout(False)
        Me.panel_Advance_pay.PerformLayout()
        CType(Me.dgv_previous_payment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_pkg_Payment As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_fees_Payment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Customer_pkg_Info As System.Windows.Forms.GroupBox
    Friend WithEvents tb_cust_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cust_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Customer_id As System.Windows.Forms.Label
    Friend WithEvents lbl_Package_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Payment_Details As System.Windows.Forms.GroupBox
    Friend WithEvents tb_payble_amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Payment_Mode As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_Advance_pay As System.Windows.Forms.Panel
    Friend WithEvents rb_Full_Pay As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Advance As System.Windows.Forms.RadioButton
    Friend WithEvents tb_remainig_pay_amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remainig_Payment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Previous_Payment As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Previous_Pay As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_full_pay As System.Windows.Forms.Panel
    Friend WithEvents tb_Full_Pay As System.Windows.Forms.TextBox
    Friend WithEvents lbl_full_pay As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_grass_pay_amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_Grass_Amount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Discount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Discount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents dtp_pay_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Payment_Date As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents tb_Pay_Amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Enter_Amount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_pkg_adult_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adult_Price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_pkg_chlidren_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Children_price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Pkg_Grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Grand_Total As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_grand_total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_tot_chi_adult As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_Payment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_total_of_Adult As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_adult_price As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_no_of_adult As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_of_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_total_of_children As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_children_price As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_no_of_children As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_of_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_cust_no As System.Windows.Forms.Label
    Friend WithEvents lbl_Plus As System.Windows.Forms.Label
    Friend WithEvents dgv_previous_payment As System.Windows.Forms.DataGridView
    Friend WithEvents tb_Cust_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_pkg_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_Total_of_Children_Adult As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tot_of_adult_children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_pay_id As System.Windows.Forms.Label
    Friend WithEvents tb_pay_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_pkg_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_Bill As System.Windows.Forms.Button
End Class
