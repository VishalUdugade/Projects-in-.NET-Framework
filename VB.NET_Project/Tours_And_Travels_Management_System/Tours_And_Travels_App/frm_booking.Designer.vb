<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_booking))
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.panel_book = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_book_cust = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Customer_id = New System.Windows.Forms.Label()
        Me.tb_Passen_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Today_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.dtp_Cust_today_date = New System.Windows.Forms.DateTimePicker()
        Me.tb_first_name = New System.Windows.Forms.TextBox()
        Me.lbl_Cust_Last_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Cust_Middle_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Cust_Name__first = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.tb_Middle_Name = New System.Windows.Forms.TextBox()
        Me.btn_show_Travellers_Info = New System.Windows.Forms.Button()
        Me.panel_Name = New System.Windows.Forms.Panel()
        Me.gb_Customer_Name = New System.Windows.Forms.GroupBox()
        Me.tb_pkg_id = New System.Windows.Forms.TextBox()
        Me.tb_cust_id = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Package_id = New System.Windows.Forms.Label()
        Me.gb_Number_of_Travellers = New System.Windows.Forms.GroupBox()
        Me.panel_no_of_travellers = New System.Windows.Forms.Panel()
        Me.tb_No_Adult = New System.Windows.Forms.TextBox()
        Me.lbl_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_No_Children = New System.Windows.Forms.TextBox()
        Me.lbl_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Cancal_book = New System.Windows.Forms.Button()
        Me.pb_Package_Image = New System.Windows.Forms.PictureBox()
        Me.gb_tour_details = New System.Windows.Forms.GroupBox()
        Me.dtp_tour_end_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_tour_start_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Pkg_Day_Night = New System.Windows.Forms.Label()
        Me.lbl_Pkg_Name = New System.Windows.Forms.Label()
        Me.lbl_Pkg_Route = New System.Windows.Forms.Label()
        Me.btb_Show_Iternary = New System.Windows.Forms.Button()
        Me.lbl_tour_end_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tour_start_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Payment_details = New System.Windows.Forms.GroupBox()
        Me.tb_Full_Pay = New System.Windows.Forms.TextBox()
        Me.lbl_full_pay = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_pay_mode = New System.Windows.Forms.TextBox()
        Me.panel_Advance_pay = New System.Windows.Forms.Panel()
        Me.tb_remainig_pay_amount = New System.Windows.Forms.TextBox()
        Me.lbl_Remainig_Payment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Previous_Payment = New System.Windows.Forms.TextBox()
        Me.lbl_Previous_Pay = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Payment_Mode = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_booking_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_booking_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Refund_Amount = New System.Windows.Forms.Label()
        Me.tb_refund_amount = New System.Windows.Forms.TextBox()
        Me.panel_book.SuspendLayout()
        Me.panel_Name.SuspendLayout()
        Me.gb_Customer_Name.SuspendLayout()
        Me.gb_Number_of_Travellers.SuspendLayout()
        Me.panel_no_of_travellers.SuspendLayout()
        CType(Me.pb_Package_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tour_details.SuspendLayout()
        Me.gb_Payment_details.SuspendLayout()
        Me.panel_Advance_pay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(514, -1)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(49, 20)
        Me.lbl_Total.TabIndex = 14
        Me.lbl_Total.Text = "Total"
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.White
        Me.btn_Clear.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Actions_edit_clear_icon__5_
        Me.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Clear.Location = New System.Drawing.Point(1218, 672)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(103, 43)
        Me.btn_Clear.TabIndex = 637
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'panel_book
        '
        Me.panel_book.BackgroundImage = CType(resources.GetObject("panel_book.BackgroundImage"), System.Drawing.Image)
        Me.panel_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_book.Controls.Add(Me.lbl_book_cust)
        Me.panel_book.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_book.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_book.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_book.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_book.Location = New System.Drawing.Point(-1, 1)
        Me.panel_book.Name = "panel_book"
        Me.panel_book.Quality = 10
        Me.panel_book.Size = New System.Drawing.Size(1360, 56)
        Me.panel_book.TabIndex = 628
        '
        'lbl_book_cust
        '
        Me.lbl_book_cust.AutoSize = True
        Me.lbl_book_cust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_book_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_cust.ForeColor = System.Drawing.Color.White
        Me.lbl_book_cust.Location = New System.Drawing.Point(579, 10)
        Me.lbl_book_cust.Name = "lbl_book_cust"
        Me.lbl_book_cust.Size = New System.Drawing.Size(251, 37)
        Me.lbl_book_cust.TabIndex = 0
        Me.lbl_book_cust.Text = "Book Customer"
        '
        'lbl_Customer_id
        '
        Me.lbl_Customer_id.AutoSize = True
        Me.lbl_Customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer_id.Location = New System.Drawing.Point(21, 70)
        Me.lbl_Customer_id.Name = "lbl_Customer_id"
        Me.lbl_Customer_id.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Customer_id.TabIndex = 632
        Me.lbl_Customer_id.Text = "Customer ID"
        '
        'tb_Passen_Total
        '
        Me.tb_Passen_Total.Enabled = False
        Me.tb_Passen_Total.Location = New System.Drawing.Point(483, 26)
        Me.tb_Passen_Total.Name = "tb_Passen_Total"
        Me.tb_Passen_Total.Size = New System.Drawing.Size(124, 26)
        Me.tb_Passen_Total.TabIndex = 24
        '
        'lbl_Today_Date
        '
        Me.lbl_Today_Date.AutoSize = True
        Me.lbl_Today_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Today_Date.Location = New System.Drawing.Point(494, 70)
        Me.lbl_Today_Date.Name = "lbl_Today_Date"
        Me.lbl_Today_Date.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Today_Date.TabIndex = 633
        Me.lbl_Today_Date.Text = "Todays Date"
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(8, 674)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(94, 46)
        Me.btn_Back.TabIndex = 638
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'dtp_Cust_today_date
        '
        Me.dtp_Cust_today_date.Enabled = False
        Me.dtp_Cust_today_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Cust_today_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Cust_today_date.Location = New System.Drawing.Point(610, 68)
        Me.dtp_Cust_today_date.Name = "dtp_Cust_today_date"
        Me.dtp_Cust_today_date.Size = New System.Drawing.Size(133, 22)
        Me.dtp_Cust_today_date.TabIndex = 634
        '
        'tb_first_name
        '
        Me.tb_first_name.Enabled = False
        Me.tb_first_name.ForeColor = System.Drawing.Color.Black
        Me.tb_first_name.Location = New System.Drawing.Point(244, 5)
        Me.tb_first_name.MaxLength = 30
        Me.tb_first_name.Name = "tb_first_name"
        Me.tb_first_name.Size = New System.Drawing.Size(305, 26)
        Me.tb_first_name.TabIndex = 1
        '
        'lbl_Cust_Last_Nm
        '
        Me.lbl_Cust_Last_Nm.AutoSize = True
        Me.lbl_Cust_Last_Nm.Location = New System.Drawing.Point(37, 72)
        Me.lbl_Cust_Last_Nm.Name = "lbl_Cust_Last_Nm"
        Me.lbl_Cust_Last_Nm.Size = New System.Drawing.Size(95, 20)
        Me.lbl_Cust_Last_Nm.TabIndex = 5
        Me.lbl_Cust_Last_Nm.Text = "Last Name"
        '
        'lbl_Cust_Middle_Nm
        '
        Me.lbl_Cust_Middle_Nm.AutoSize = True
        Me.lbl_Cust_Middle_Nm.Location = New System.Drawing.Point(37, 38)
        Me.lbl_Cust_Middle_Nm.Name = "lbl_Cust_Middle_Nm"
        Me.lbl_Cust_Middle_Nm.Size = New System.Drawing.Size(112, 20)
        Me.lbl_Cust_Middle_Nm.TabIndex = 4
        Me.lbl_Cust_Middle_Nm.Text = "Middle Name"
        '
        'lbl_Cust_Name__first
        '
        Me.lbl_Cust_Name__first.AutoSize = True
        Me.lbl_Cust_Name__first.Location = New System.Drawing.Point(37, 8)
        Me.lbl_Cust_Name__first.Name = "lbl_Cust_Name__first"
        Me.lbl_Cust_Name__first.Size = New System.Drawing.Size(96, 20)
        Me.lbl_Cust_Name__first.TabIndex = 3
        Me.lbl_Cust_Name__first.Text = "First Name"
        '
        'tb_Last_Name
        '
        Me.tb_Last_Name.Enabled = False
        Me.tb_Last_Name.Location = New System.Drawing.Point(244, 71)
        Me.tb_Last_Name.MaxLength = 30
        Me.tb_Last_Name.Name = "tb_Last_Name"
        Me.tb_Last_Name.Size = New System.Drawing.Size(305, 26)
        Me.tb_Last_Name.TabIndex = 3
        '
        'tb_Middle_Name
        '
        Me.tb_Middle_Name.Enabled = False
        Me.tb_Middle_Name.Location = New System.Drawing.Point(244, 37)
        Me.tb_Middle_Name.MaxLength = 30
        Me.tb_Middle_Name.Name = "tb_Middle_Name"
        Me.tb_Middle_Name.Size = New System.Drawing.Size(305, 26)
        Me.tb_Middle_Name.TabIndex = 2
        '
        'btn_show_Travellers_Info
        '
        Me.btn_show_Travellers_Info.AutoSize = True
        Me.btn_show_Travellers_Info.BackColor = System.Drawing.Color.Transparent
        Me.btn_show_Travellers_Info.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_show_Travellers_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_Travellers_Info.FlatAppearance.BorderSize = 0
        Me.btn_show_Travellers_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show_Travellers_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_Travellers_Info.ForeColor = System.Drawing.Color.White
        Me.btn_show_Travellers_Info.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_show_Travellers_Info.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_show_Travellers_Info.Location = New System.Drawing.Point(506, 57)
        Me.btn_show_Travellers_Info.Name = "btn_show_Travellers_Info"
        Me.btn_show_Travellers_Info.Size = New System.Drawing.Size(80, 37)
        Me.btn_show_Travellers_Info.TabIndex = 9
        Me.btn_show_Travellers_Info.Text = "Show"
        Me.btn_show_Travellers_Info.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_show_Travellers_Info.UseVisualStyleBackColor = False
        '
        'panel_Name
        '
        Me.panel_Name.BackColor = System.Drawing.Color.Khaki
        Me.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Name.Controls.Add(Me.tb_first_name)
        Me.panel_Name.Controls.Add(Me.lbl_Cust_Last_Nm)
        Me.panel_Name.Controls.Add(Me.lbl_Cust_Middle_Nm)
        Me.panel_Name.Controls.Add(Me.lbl_Cust_Name__first)
        Me.panel_Name.Controls.Add(Me.tb_Last_Name)
        Me.panel_Name.Controls.Add(Me.tb_Middle_Name)
        Me.panel_Name.Location = New System.Drawing.Point(6, 23)
        Me.panel_Name.Name = "panel_Name"
        Me.panel_Name.Size = New System.Drawing.Size(623, 106)
        Me.panel_Name.TabIndex = 0
        '
        'gb_Customer_Name
        '
        Me.gb_Customer_Name.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Customer_Name.Controls.Add(Me.panel_Name)
        Me.gb_Customer_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Customer_Name.Location = New System.Drawing.Point(10, 117)
        Me.gb_Customer_Name.Name = "gb_Customer_Name"
        Me.gb_Customer_Name.Size = New System.Drawing.Size(637, 136)
        Me.gb_Customer_Name.TabIndex = 627
        Me.gb_Customer_Name.TabStop = False
        Me.gb_Customer_Name.Text = "Customer Name"
        '
        'tb_pkg_id
        '
        Me.tb_pkg_id.Enabled = False
        Me.tb_pkg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_id.Location = New System.Drawing.Point(1201, 68)
        Me.tb_pkg_id.Name = "tb_pkg_id"
        Me.tb_pkg_id.Size = New System.Drawing.Size(137, 24)
        Me.tb_pkg_id.TabIndex = 642
        '
        'tb_cust_id
        '
        Me.tb_cust_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cust_id.Location = New System.Drawing.Point(159, 70)
        Me.tb_cust_id.Name = "tb_cust_id"
        Me.tb_cust_id.Size = New System.Drawing.Size(169, 24)
        Me.tb_cust_id.TabIndex = 640
        '
        'btn_Search
        '
        Me.btn_Search.AutoSize = True
        Me.btn_Search.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Search.Location = New System.Drawing.Point(370, 61)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 40)
        Me.btn_Search.TabIndex = 641
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'lbl_Package_id
        '
        Me.lbl_Package_id.AutoSize = True
        Me.lbl_Package_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_id.Location = New System.Drawing.Point(1093, 70)
        Me.lbl_Package_id.Name = "lbl_Package_id"
        Me.lbl_Package_id.Size = New System.Drawing.Size(102, 20)
        Me.lbl_Package_id.TabIndex = 635
        Me.lbl_Package_id.Text = "Package ID"
        '
        'gb_Number_of_Travellers
        '
        Me.gb_Number_of_Travellers.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Number_of_Travellers.Controls.Add(Me.panel_no_of_travellers)
        Me.gb_Number_of_Travellers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Number_of_Travellers.Location = New System.Drawing.Point(10, 262)
        Me.gb_Number_of_Travellers.Name = "gb_Number_of_Travellers"
        Me.gb_Number_of_Travellers.Size = New System.Drawing.Size(637, 149)
        Me.gb_Number_of_Travellers.TabIndex = 636
        Me.gb_Number_of_Travellers.TabStop = False
        Me.gb_Number_of_Travellers.Text = "Number of Travellers"
        '
        'panel_no_of_travellers
        '
        Me.panel_no_of_travellers.BackColor = System.Drawing.Color.Khaki
        Me.panel_no_of_travellers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_no_of_travellers.Controls.Add(Me.tb_No_Adult)
        Me.panel_no_of_travellers.Controls.Add(Me.lbl_Adult)
        Me.panel_no_of_travellers.Controls.Add(Me.tb_No_Children)
        Me.panel_no_of_travellers.Controls.Add(Me.lbl_Children)
        Me.panel_no_of_travellers.Controls.Add(Me.btn_show_Travellers_Info)
        Me.panel_no_of_travellers.Controls.Add(Me.tb_Passen_Total)
        Me.panel_no_of_travellers.Controls.Add(Me.lbl_Total)
        Me.panel_no_of_travellers.Location = New System.Drawing.Point(6, 22)
        Me.panel_no_of_travellers.Name = "panel_no_of_travellers"
        Me.panel_no_of_travellers.Size = New System.Drawing.Size(623, 114)
        Me.panel_no_of_travellers.TabIndex = 4
        '
        'tb_No_Adult
        '
        Me.tb_No_Adult.Enabled = False
        Me.tb_No_Adult.Location = New System.Drawing.Point(263, 62)
        Me.tb_No_Adult.Name = "tb_No_Adult"
        Me.tb_No_Adult.Size = New System.Drawing.Size(163, 26)
        Me.tb_No_Adult.TabIndex = 32
        '
        'lbl_Adult
        '
        Me.lbl_Adult.AutoSize = True
        Me.lbl_Adult.Location = New System.Drawing.Point(308, 22)
        Me.lbl_Adult.Name = "lbl_Adult"
        Me.lbl_Adult.Size = New System.Drawing.Size(60, 20)
        Me.lbl_Adult.TabIndex = 31
        Me.lbl_Adult.Text = "Adults"
        '
        'tb_No_Children
        '
        Me.tb_No_Children.Enabled = False
        Me.tb_No_Children.Location = New System.Drawing.Point(40, 62)
        Me.tb_No_Children.Name = "tb_No_Children"
        Me.tb_No_Children.Size = New System.Drawing.Size(163, 26)
        Me.tb_No_Children.TabIndex = 29
        '
        'lbl_Children
        '
        Me.lbl_Children.AutoSize = True
        Me.lbl_Children.Location = New System.Drawing.Point(85, 22)
        Me.lbl_Children.Name = "lbl_Children"
        Me.lbl_Children.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Children.TabIndex = 30
        Me.lbl_Children.Text = "Children"
        '
        'btn_Cancal_book
        '
        Me.btn_Cancal_book.AutoSize = True
        Me.btn_Cancal_book.BackColor = System.Drawing.Color.White
        Me.btn_Cancal_book.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Cancal_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancal_book.FlatAppearance.BorderSize = 0
        Me.btn_Cancal_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancal_book.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancal_book.ForeColor = System.Drawing.Color.White
        Me.btn_Cancal_book.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Cancal_book.Location = New System.Drawing.Point(610, 672)
        Me.btn_Cancal_book.Name = "btn_Cancal_book"
        Me.btn_Cancal_book.Size = New System.Drawing.Size(103, 43)
        Me.btn_Cancal_book.TabIndex = 643
        Me.btn_Cancal_book.Text = "Cancel"
        Me.btn_Cancal_book.UseVisualStyleBackColor = False
        '
        'pb_Package_Image
        '
        Me.pb_Package_Image.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Package_Image.Location = New System.Drawing.Point(6, 21)
        Me.pb_Package_Image.Name = "pb_Package_Image"
        Me.pb_Package_Image.Size = New System.Drawing.Size(673, 206)
        Me.pb_Package_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Package_Image.TabIndex = 644
        Me.pb_Package_Image.TabStop = False
        '
        'gb_tour_details
        '
        Me.gb_tour_details.BackColor = System.Drawing.Color.Moccasin
        Me.gb_tour_details.Controls.Add(Me.dtp_tour_end_date)
        Me.gb_tour_details.Controls.Add(Me.dtp_tour_start_date)
        Me.gb_tour_details.Controls.Add(Me.lbl_Pkg_Day_Night)
        Me.gb_tour_details.Controls.Add(Me.lbl_Pkg_Name)
        Me.gb_tour_details.Controls.Add(Me.lbl_Pkg_Route)
        Me.gb_tour_details.Controls.Add(Me.btb_Show_Iternary)
        Me.gb_tour_details.Controls.Add(Me.lbl_tour_end_date)
        Me.gb_tour_details.Controls.Add(Me.lbl_tour_start_date)
        Me.gb_tour_details.Controls.Add(Me.pb_Package_Image)
        Me.gb_tour_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tour_details.Location = New System.Drawing.Point(653, 117)
        Me.gb_tour_details.Name = "gb_tour_details"
        Me.gb_tour_details.Size = New System.Drawing.Size(685, 320)
        Me.gb_tour_details.TabIndex = 653
        Me.gb_tour_details.TabStop = False
        Me.gb_tour_details.Text = "Tour Details"
        '
        'dtp_tour_end_date
        '
        Me.dtp_tour_end_date.Enabled = False
        Me.dtp_tour_end_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tour_end_date.Location = New System.Drawing.Point(110, 291)
        Me.dtp_tour_end_date.Name = "dtp_tour_end_date"
        Me.dtp_tour_end_date.Size = New System.Drawing.Size(169, 22)
        Me.dtp_tour_end_date.TabIndex = 651
        '
        'dtp_tour_start_date
        '
        Me.dtp_tour_start_date.Enabled = False
        Me.dtp_tour_start_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tour_start_date.Location = New System.Drawing.Point(110, 250)
        Me.dtp_tour_start_date.Name = "dtp_tour_start_date"
        Me.dtp_tour_start_date.Size = New System.Drawing.Size(169, 22)
        Me.dtp_tour_start_date.TabIndex = 650
        '
        'lbl_Pkg_Day_Night
        '
        Me.lbl_Pkg_Day_Night.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Day_Night.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Day_Night.Location = New System.Drawing.Point(11, 104)
        Me.lbl_Pkg_Day_Night.Name = "lbl_Pkg_Day_Night"
        Me.lbl_Pkg_Day_Night.Size = New System.Drawing.Size(149, 23)
        Me.lbl_Pkg_Day_Night.TabIndex = 653
        Me.lbl_Pkg_Day_Night.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Pkg_Name
        '
        Me.lbl_Pkg_Name.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Name.Location = New System.Drawing.Point(11, 146)
        Me.lbl_Pkg_Name.Name = "lbl_Pkg_Name"
        Me.lbl_Pkg_Name.Size = New System.Drawing.Size(328, 29)
        Me.lbl_Pkg_Name.TabIndex = 654
        Me.lbl_Pkg_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Pkg_Route
        '
        Me.lbl_Pkg_Route.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Route.Location = New System.Drawing.Point(11, 195)
        Me.lbl_Pkg_Route.Name = "lbl_Pkg_Route"
        Me.lbl_Pkg_Route.Size = New System.Drawing.Size(549, 28)
        Me.lbl_Pkg_Route.TabIndex = 655
        Me.lbl_Pkg_Route.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btb_Show_Iternary
        '
        Me.btb_Show_Iternary.AutoSize = True
        Me.btb_Show_Iternary.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btb_Show_Iternary.BackgroundImage = CType(resources.GetObject("btb_Show_Iternary.BackgroundImage"), System.Drawing.Image)
        Me.btb_Show_Iternary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btb_Show_Iternary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btb_Show_Iternary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_Show_Iternary.ForeColor = System.Drawing.Color.White
        Me.btb_Show_Iternary.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__5_
        Me.btb_Show_Iternary.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btb_Show_Iternary.Location = New System.Drawing.Point(422, 252)
        Me.btb_Show_Iternary.Name = "btb_Show_Iternary"
        Me.btb_Show_Iternary.Size = New System.Drawing.Size(105, 48)
        Me.btb_Show_Iternary.TabIndex = 652
        Me.btb_Show_Iternary.Text = "Show " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iternary"
        Me.btb_Show_Iternary.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btb_Show_Iternary.UseVisualStyleBackColor = False
        '
        'lbl_tour_end_date
        '
        Me.lbl_tour_end_date.AutoSize = True
        Me.lbl_tour_end_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_end_date.Location = New System.Drawing.Point(16, 295)
        Me.lbl_tour_end_date.Name = "lbl_tour_end_date"
        Me.lbl_tour_end_date.Size = New System.Drawing.Size(77, 18)
        Me.lbl_tour_end_date.TabIndex = 649
        Me.lbl_tour_end_date.Text = "End Date"
        '
        'lbl_tour_start_date
        '
        Me.lbl_tour_start_date.AutoSize = True
        Me.lbl_tour_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_start_date.Location = New System.Drawing.Point(9, 252)
        Me.lbl_tour_start_date.Name = "lbl_tour_start_date"
        Me.lbl_tour_start_date.Size = New System.Drawing.Size(84, 18)
        Me.lbl_tour_start_date.TabIndex = 648
        Me.lbl_tour_start_date.Text = "Start Date"
        '
        'gb_Payment_details
        '
        Me.gb_Payment_details.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Payment_details.Controls.Add(Me.tb_Full_Pay)
        Me.gb_Payment_details.Controls.Add(Me.lbl_full_pay)
        Me.gb_Payment_details.Controls.Add(Me.tb_pay_mode)
        Me.gb_Payment_details.Controls.Add(Me.panel_Advance_pay)
        Me.gb_Payment_details.Controls.Add(Me.lbl_Payment_Mode)
        Me.gb_Payment_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Payment_details.Location = New System.Drawing.Point(10, 417)
        Me.gb_Payment_details.Name = "gb_Payment_details"
        Me.gb_Payment_details.Size = New System.Drawing.Size(637, 191)
        Me.gb_Payment_details.TabIndex = 654
        Me.gb_Payment_details.TabStop = False
        Me.gb_Payment_details.Text = "Payment Details"
        '
        'tb_Full_Pay
        '
        Me.tb_Full_Pay.Enabled = False
        Me.tb_Full_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Full_Pay.Location = New System.Drawing.Point(183, 153)
        Me.tb_Full_Pay.Name = "tb_Full_Pay"
        Me.tb_Full_Pay.Size = New System.Drawing.Size(234, 22)
        Me.tb_Full_Pay.TabIndex = 657
        Me.tb_Full_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_full_pay
        '
        Me.lbl_full_pay.AutoSize = True
        Me.lbl_full_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_full_pay.Location = New System.Drawing.Point(21, 153)
        Me.lbl_full_pay.Name = "lbl_full_pay"
        Me.lbl_full_pay.Size = New System.Drawing.Size(112, 20)
        Me.lbl_full_pay.TabIndex = 656
        Me.lbl_full_pay.Text = "Full Payment"
        '
        'tb_pay_mode
        '
        Me.tb_pay_mode.Enabled = False
        Me.tb_pay_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pay_mode.Location = New System.Drawing.Point(183, 30)
        Me.tb_pay_mode.Name = "tb_pay_mode"
        Me.tb_pay_mode.Size = New System.Drawing.Size(234, 22)
        Me.tb_pay_mode.TabIndex = 655
        Me.tb_pay_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panel_Advance_pay
        '
        Me.panel_Advance_pay.Controls.Add(Me.tb_remainig_pay_amount)
        Me.panel_Advance_pay.Controls.Add(Me.lbl_Remainig_Payment)
        Me.panel_Advance_pay.Controls.Add(Me.tb_Previous_Payment)
        Me.panel_Advance_pay.Controls.Add(Me.lbl_Previous_Pay)
        Me.panel_Advance_pay.Enabled = False
        Me.panel_Advance_pay.Location = New System.Drawing.Point(23, 65)
        Me.panel_Advance_pay.Name = "panel_Advance_pay"
        Me.panel_Advance_pay.Size = New System.Drawing.Size(403, 68)
        Me.panel_Advance_pay.TabIndex = 654
        '
        'tb_remainig_pay_amount
        '
        Me.tb_remainig_pay_amount.Enabled = False
        Me.tb_remainig_pay_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_remainig_pay_amount.Location = New System.Drawing.Point(234, 37)
        Me.tb_remainig_pay_amount.Name = "tb_remainig_pay_amount"
        Me.tb_remainig_pay_amount.Size = New System.Drawing.Size(160, 22)
        Me.tb_remainig_pay_amount.TabIndex = 472
        Me.tb_remainig_pay_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Remainig_Payment
        '
        Me.lbl_Remainig_Payment.AutoSize = True
        Me.lbl_Remainig_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remainig_Payment.Location = New System.Drawing.Point(11, 40)
        Me.lbl_Remainig_Payment.Name = "lbl_Remainig_Payment"
        Me.lbl_Remainig_Payment.Size = New System.Drawing.Size(193, 16)
        Me.lbl_Remainig_Payment.TabIndex = 471
        Me.lbl_Remainig_Payment.Text = "Remainig Payment Amount"
        '
        'tb_Previous_Payment
        '
        Me.tb_Previous_Payment.Enabled = False
        Me.tb_Previous_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Previous_Payment.Location = New System.Drawing.Point(232, 6)
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
        'lbl_Payment_Mode
        '
        Me.lbl_Payment_Mode.AutoSize = True
        Me.lbl_Payment_Mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Payment_Mode.Location = New System.Drawing.Point(20, 30)
        Me.lbl_Payment_Mode.Name = "lbl_Payment_Mode"
        Me.lbl_Payment_Mode.Size = New System.Drawing.Size(127, 20)
        Me.lbl_Payment_Mode.TabIndex = 653
        Me.lbl_Payment_Mode.Text = "Payment Mode"
        '
        'lbl_booking_date
        '
        Me.lbl_booking_date.AutoSize = True
        Me.lbl_booking_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_booking_date.Location = New System.Drawing.Point(788, 70)
        Me.lbl_booking_date.Name = "lbl_booking_date"
        Me.lbl_booking_date.Size = New System.Drawing.Size(118, 20)
        Me.lbl_booking_date.TabIndex = 655
        Me.lbl_booking_date.Text = "Booking Date"
        '
        'dtp_booking_date
        '
        Me.dtp_booking_date.Enabled = False
        Me.dtp_booking_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_booking_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_booking_date.Location = New System.Drawing.Point(912, 70)
        Me.dtp_booking_date.Name = "dtp_booking_date"
        Me.dtp_booking_date.Size = New System.Drawing.Size(129, 22)
        Me.dtp_booking_date.TabIndex = 656
        '
        'lbl_Refund_Amount
        '
        Me.lbl_Refund_Amount.AutoSize = True
        Me.lbl_Refund_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Refund_Amount.ForeColor = System.Drawing.Color.Red
        Me.lbl_Refund_Amount.Location = New System.Drawing.Point(655, 518)
        Me.lbl_Refund_Amount.Name = "lbl_Refund_Amount"
        Me.lbl_Refund_Amount.Size = New System.Drawing.Size(135, 20)
        Me.lbl_Refund_Amount.TabIndex = 657
        Me.lbl_Refund_Amount.Text = "Refund Amount"
        '
        'tb_refund_amount
        '
        Me.tb_refund_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_refund_amount.Location = New System.Drawing.Point(819, 519)
        Me.tb_refund_amount.Name = "tb_refund_amount"
        Me.tb_refund_amount.Size = New System.Drawing.Size(234, 22)
        Me.tb_refund_amount.TabIndex = 658
        Me.tb_refund_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tb_refund_amount)
        Me.Controls.Add(Me.lbl_Refund_Amount)
        Me.Controls.Add(Me.dtp_booking_date)
        Me.Controls.Add(Me.lbl_booking_date)
        Me.Controls.Add(Me.gb_Payment_details)
        Me.Controls.Add(Me.gb_tour_details)
        Me.Controls.Add(Me.btn_Cancal_book)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.panel_book)
        Me.Controls.Add(Me.lbl_Customer_id)
        Me.Controls.Add(Me.lbl_Today_Date)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.dtp_Cust_today_date)
        Me.Controls.Add(Me.gb_Customer_Name)
        Me.Controls.Add(Me.tb_pkg_id)
        Me.Controls.Add(Me.tb_cust_id)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Package_id)
        Me.Controls.Add(Me.gb_Number_of_Travellers)
        Me.Name = "frm_booking"
        Me.Text = "Package"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_book.ResumeLayout(False)
        Me.panel_book.PerformLayout()
        Me.panel_Name.ResumeLayout(False)
        Me.panel_Name.PerformLayout()
        Me.gb_Customer_Name.ResumeLayout(False)
        Me.gb_Number_of_Travellers.ResumeLayout(False)
        Me.panel_no_of_travellers.ResumeLayout(False)
        Me.panel_no_of_travellers.PerformLayout()
        CType(Me.pb_Package_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tour_details.ResumeLayout(False)
        Me.gb_tour_details.PerformLayout()
        Me.gb_Payment_details.ResumeLayout(False)
        Me.gb_Payment_details.PerformLayout()
        Me.panel_Advance_pay.ResumeLayout(False)
        Me.panel_Advance_pay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents panel_book As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_book_cust As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Customer_id As System.Windows.Forms.Label
    Friend WithEvents tb_Passen_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Today_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents dtp_Cust_today_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_first_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cust_Last_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Cust_Middle_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Cust_Name__first As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Middle_Name As System.Windows.Forms.TextBox
    Friend WithEvents btn_show_Travellers_Info As System.Windows.Forms.Button
    Friend WithEvents panel_Name As System.Windows.Forms.Panel
    Friend WithEvents gb_Customer_Name As System.Windows.Forms.GroupBox
    Friend WithEvents tb_pkg_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_cust_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents lbl_Package_id As System.Windows.Forms.Label
    Friend WithEvents gb_Number_of_Travellers As System.Windows.Forms.GroupBox
    Friend WithEvents panel_no_of_travellers As System.Windows.Forms.Panel
    Friend WithEvents tb_No_Adult As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_No_Children As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Cancal_book As System.Windows.Forms.Button
    Friend WithEvents pb_Package_Image As System.Windows.Forms.PictureBox
    Friend WithEvents gb_tour_details As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Payment_details As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Full_Pay As System.Windows.Forms.TextBox
    Friend WithEvents lbl_full_pay As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_pay_mode As System.Windows.Forms.TextBox
    Friend WithEvents panel_Advance_pay As System.Windows.Forms.Panel
    Friend WithEvents tb_remainig_pay_amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remainig_Payment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Previous_Payment As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Previous_Pay As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Payment_Mode As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_booking_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_booking_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_tour_end_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_tour_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Pkg_Day_Night As System.Windows.Forms.Label
    Friend WithEvents lbl_Pkg_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Pkg_Route As System.Windows.Forms.Label
    Friend WithEvents btb_Show_Iternary As System.Windows.Forms.Button
    Friend WithEvents lbl_tour_end_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tour_start_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Refund_Amount As System.Windows.Forms.Label
    Friend WithEvents tb_refund_amount As System.Windows.Forms.TextBox
End Class
