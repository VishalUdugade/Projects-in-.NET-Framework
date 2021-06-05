<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Update_Package
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Update_Package))
        Me.tb_Package_ID = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.tb_Persons_Capacity = New System.Windows.Forms.TextBox()
        Me.lbl_Package_Person_Capacity = New System.Windows.Forms.Label()
        Me.panel_image = New System.Windows.Forms.Panel()
        Me.btn_None = New System.Windows.Forms.Button()
        Me.btn_Import = New System.Windows.Forms.Button()
        Me.pb_pkg_img = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Import_img = New System.Windows.Forms.Label()
        Me.lbl_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Nights = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Days = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_Tour_Guide = New System.Windows.Forms.ComboBox()
        Me.lbl_Select_Tour_Guide = New System.Windows.Forms.Label()
        Me.lbl_Driver_Name = New System.Windows.Forms.Label()
        Me.cb_Driver_Name = New System.Windows.Forms.ComboBox()
        Me.panel_driver_name = New System.Windows.Forms.Panel()
        Me.tb_selected_td_id = New System.Windows.Forms.TextBox()
        Me.gb_Pkg_Persons = New System.Windows.Forms.GroupBox()
        Me.tb_d_id = New System.Windows.Forms.TextBox()
        Me.tb_Driver = New System.Windows.Forms.TextBox()
        Me.tb_tg_id = New System.Windows.Forms.TextBox()
        Me.lbl_Current_Driver_name = New System.Windows.Forms.Label()
        Me.tb_tour_guide_name = New System.Windows.Forms.TextBox()
        Me.lbl_Current_Tour_Guide = New System.Windows.Forms.Label()
        Me.panel_Tour_Guide = New System.Windows.Forms.Panel()
        Me.tb_selected_tg_id = New System.Windows.Forms.TextBox()
        Me.tb_Note = New System.Windows.Forms.TextBox()
        Me.tb_GST = New System.Windows.Forms.TextBox()
        Me.lbl_GST = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Note = New System.Windows.Forms.Label()
        Me.lbl_Total_Price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Note = New System.Windows.Forms.Panel()
        Me.gb_Package_Information = New System.Windows.Forms.GroupBox()
        Me.btn_Add_days = New System.Windows.Forms.Button()
        Me.tb_Add_Days = New System.Windows.Forms.TextBox()
        Me.lbl_Add_Days = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_gst_percent_sign = New System.Windows.Forms.Label()
        Me.tb_Total_Price = New System.Windows.Forms.TextBox()
        Me.tb_pkg_name = New System.Windows.Forms.TextBox()
        Me.tb_Grand_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Grand_Total = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Children_Price = New System.Windows.Forms.TextBox()
        Me.tb_Adult_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_route = New System.Windows.Forms.TextBox()
        Me.lbl_Route = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_duration = New System.Windows.Forms.Panel()
        Me.tb_Nights = New System.Windows.Forms.TextBox()
        Me.btn_Show_Days_Description = New System.Windows.Forms.Button()
        Me.tb_Days = New System.Windows.Forms.TextBox()
        Me.lbl_Package_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Update_Package = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_pkg_name = New System.Windows.Forms.ComboBox()
        Me.gb_Package_Date = New System.Windows.Forms.GroupBox()
        Me.dtp_Expiry_Date = New System.Windows.Forms.DateTimePicker()
        Me.panel_No_Tours = New System.Windows.Forms.Panel()
        Me.btn_Show_Tours_Dates = New System.Windows.Forms.Button()
        Me.tb_Number_of_tours = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Expiry_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Pkg_Create_Date = New System.Windows.Forms.Label()
        Me.dtp_Pkg_Create_Date = New System.Windows.Forms.DateTimePicker()
        Me.panel_image.SuspendLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.panel_driver_name.SuspendLayout()
        Me.gb_Pkg_Persons.SuspendLayout()
        Me.panel_Tour_Guide.SuspendLayout()
        Me.panel_Note.SuspendLayout()
        Me.gb_Package_Information.SuspendLayout()
        Me.panel_duration.SuspendLayout()
        Me.panel_Add_Package.SuspendLayout()
        Me.gb_Package_Date.SuspendLayout()
        Me.panel_No_Tours.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_Package_ID
        '
        Me.tb_Package_ID.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_Package_ID.Enabled = False
        Me.tb_Package_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Package_ID.Location = New System.Drawing.Point(163, 68)
        Me.tb_Package_ID.MaxLength = 4
        Me.tb_Package_ID.Name = "tb_Package_ID"
        Me.tb_Package_ID.Size = New System.Drawing.Size(140, 24)
        Me.tb_Package_ID.TabIndex = 360
        '
        'tb_Persons_Capacity
        '
        Me.tb_Persons_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Persons_Capacity.Location = New System.Drawing.Point(1155, 66)
        Me.tb_Persons_Capacity.Name = "tb_Persons_Capacity"
        Me.tb_Persons_Capacity.Size = New System.Drawing.Size(123, 22)
        Me.tb_Persons_Capacity.TabIndex = 366
        Me.tb_Persons_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Package_Person_Capacity
        '
        Me.lbl_Package_Person_Capacity.AutoSize = True
        Me.lbl_Package_Person_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_Person_Capacity.Location = New System.Drawing.Point(978, 63)
        Me.lbl_Package_Person_Capacity.Name = "lbl_Package_Person_Capacity"
        Me.lbl_Package_Person_Capacity.Size = New System.Drawing.Size(148, 20)
        Me.lbl_Package_Person_Capacity.TabIndex = 365
        Me.lbl_Package_Person_Capacity.Text = "Persons Capacity"
        '
        'panel_image
        '
        Me.panel_image.BackColor = System.Drawing.Color.Khaki
        Me.panel_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_image.Controls.Add(Me.btn_None)
        Me.panel_image.Controls.Add(Me.btn_Import)
        Me.panel_image.Controls.Add(Me.pb_pkg_img)
        Me.panel_image.Controls.Add(Me.BunifuGradientPanel1)
        Me.panel_image.Location = New System.Drawing.Point(760, 393)
        Me.panel_image.Name = "panel_image"
        Me.panel_image.Size = New System.Drawing.Size(588, 288)
        Me.panel_image.TabIndex = 363
        '
        'btn_None
        '
        Me.btn_None.AutoSize = True
        Me.btn_None.BackColor = System.Drawing.Color.Transparent
        Me.btn_None.BackgroundImage = CType(resources.GetObject("btn_None.BackgroundImage"), System.Drawing.Image)
        Me.btn_None.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_None.Enabled = False
        Me.btn_None.FlatAppearance.BorderSize = 0
        Me.btn_None.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_None.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_None.ForeColor = System.Drawing.Color.White
        Me.btn_None.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Sign_Error_Icon_32
        Me.btn_None.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_None.Location = New System.Drawing.Point(439, 234)
        Me.btn_None.Name = "btn_None"
        Me.btn_None.Size = New System.Drawing.Size(101, 40)
        Me.btn_None.TabIndex = 3
        Me.btn_None.Text = "Cancal"
        Me.btn_None.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_None.UseVisualStyleBackColor = False
        '
        'btn_Import
        '
        Me.btn_Import.AutoSize = True
        Me.btn_Import.BackColor = System.Drawing.Color.Transparent
        Me.btn_Import.BackgroundImage = CType(resources.GetObject("btn_Import.BackgroundImage"), System.Drawing.Image)
        Me.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Import.Enabled = False
        Me.btn_Import.FlatAppearance.BorderSize = 0
        Me.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Import.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Import.ForeColor = System.Drawing.Color.White
        Me.btn_Import.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Import.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Import.Location = New System.Drawing.Point(53, 234)
        Me.btn_Import.Name = "btn_Import"
        Me.btn_Import.Size = New System.Drawing.Size(102, 40)
        Me.btn_Import.TabIndex = 2
        Me.btn_Import.Text = "Browse"
        Me.btn_Import.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Import.UseVisualStyleBackColor = False
        '
        'pb_pkg_img
        '
        Me.pb_pkg_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_pkg_img.Location = New System.Drawing.Point(3, 44)
        Me.pb_pkg_img.Name = "pb_pkg_img"
        Me.pb_pkg_img.Size = New System.Drawing.Size(578, 184)
        Me.pb_pkg_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_pkg_img.TabIndex = 1
        Me.pb_pkg_img.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_Import_img)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(3, 2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(578, 36)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'lbl_Import_img
        '
        Me.lbl_Import_img.AutoSize = True
        Me.lbl_Import_img.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Import_img.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Import_img.Location = New System.Drawing.Point(276, 8)
        Me.lbl_Import_img.Name = "lbl_Import_img"
        Me.lbl_Import_img.Size = New System.Drawing.Size(106, 18)
        Me.lbl_Import_img.TabIndex = 0
        Me.lbl_Import_img.Text = "Import Image"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(9, 26)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(129, 20)
        Me.lbl_Name.TabIndex = 3
        Me.lbl_Name.Text = "Package Name"
        '
        'lbl_Nights
        '
        Me.lbl_Nights.AutoSize = True
        Me.lbl_Nights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nights.Location = New System.Drawing.Point(20, 49)
        Me.lbl_Nights.Name = "lbl_Nights"
        Me.lbl_Nights.Size = New System.Drawing.Size(60, 20)
        Me.lbl_Nights.TabIndex = 7
        Me.lbl_Nights.Text = "Nights"
        '
        'lbl_Days
        '
        Me.lbl_Days.AutoSize = True
        Me.lbl_Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Days.Location = New System.Drawing.Point(31, 12)
        Me.lbl_Days.Name = "lbl_Days"
        Me.lbl_Days.Size = New System.Drawing.Size(49, 20)
        Me.lbl_Days.TabIndex = 6
        Me.lbl_Days.Text = "Days"
        '
        'cb_Tour_Guide
        '
        Me.cb_Tour_Guide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Tour_Guide.FormattingEnabled = True
        Me.cb_Tour_Guide.Location = New System.Drawing.Point(194, 7)
        Me.cb_Tour_Guide.Name = "cb_Tour_Guide"
        Me.cb_Tour_Guide.Size = New System.Drawing.Size(377, 24)
        Me.cb_Tour_Guide.TabIndex = 1
        '
        'lbl_Select_Tour_Guide
        '
        Me.lbl_Select_Tour_Guide.AutoSize = True
        Me.lbl_Select_Tour_Guide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Select_Tour_Guide.Location = New System.Drawing.Point(6, 9)
        Me.lbl_Select_Tour_Guide.Name = "lbl_Select_Tour_Guide"
        Me.lbl_Select_Tour_Guide.Size = New System.Drawing.Size(182, 18)
        Me.lbl_Select_Tour_Guide.TabIndex = 0
        Me.lbl_Select_Tour_Guide.Text = "Select New Tour Guide"
        '
        'lbl_Driver_Name
        '
        Me.lbl_Driver_Name.AutoSize = True
        Me.lbl_Driver_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Driver_Name.Location = New System.Drawing.Point(5, 10)
        Me.lbl_Driver_Name.Name = "lbl_Driver_Name"
        Me.lbl_Driver_Name.Size = New System.Drawing.Size(194, 18)
        Me.lbl_Driver_Name.TabIndex = 0
        Me.lbl_Driver_Name.Text = "Select Tour Driver Name"
        '
        'cb_Driver_Name
        '
        Me.cb_Driver_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Driver_Name.FormattingEnabled = True
        Me.cb_Driver_Name.Location = New System.Drawing.Point(206, 5)
        Me.cb_Driver_Name.Name = "cb_Driver_Name"
        Me.cb_Driver_Name.Size = New System.Drawing.Size(348, 24)
        Me.cb_Driver_Name.TabIndex = 1
        '
        'panel_driver_name
        '
        Me.panel_driver_name.BackColor = System.Drawing.Color.Khaki
        Me.panel_driver_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_driver_name.Controls.Add(Me.tb_selected_td_id)
        Me.panel_driver_name.Controls.Add(Me.cb_Driver_Name)
        Me.panel_driver_name.Controls.Add(Me.lbl_Driver_Name)
        Me.panel_driver_name.Location = New System.Drawing.Point(725, 60)
        Me.panel_driver_name.Name = "panel_driver_name"
        Me.panel_driver_name.Size = New System.Drawing.Size(602, 40)
        Me.panel_driver_name.TabIndex = 1
        '
        'tb_selected_td_id
        '
        Me.tb_selected_td_id.Enabled = False
        Me.tb_selected_td_id.Location = New System.Drawing.Point(563, 6)
        Me.tb_selected_td_id.Name = "tb_selected_td_id"
        Me.tb_selected_td_id.Size = New System.Drawing.Size(31, 22)
        Me.tb_selected_td_id.TabIndex = 23
        '
        'gb_Pkg_Persons
        '
        Me.gb_Pkg_Persons.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Pkg_Persons.Controls.Add(Me.tb_d_id)
        Me.gb_Pkg_Persons.Controls.Add(Me.tb_Driver)
        Me.gb_Pkg_Persons.Controls.Add(Me.tb_tg_id)
        Me.gb_Pkg_Persons.Controls.Add(Me.lbl_Current_Driver_name)
        Me.gb_Pkg_Persons.Controls.Add(Me.tb_tour_guide_name)
        Me.gb_Pkg_Persons.Controls.Add(Me.lbl_Current_Tour_Guide)
        Me.gb_Pkg_Persons.Controls.Add(Me.panel_driver_name)
        Me.gb_Pkg_Persons.Controls.Add(Me.panel_Tour_Guide)
        Me.gb_Pkg_Persons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Pkg_Persons.Location = New System.Drawing.Point(22, 105)
        Me.gb_Pkg_Persons.Name = "gb_Pkg_Persons"
        Me.gb_Pkg_Persons.Size = New System.Drawing.Size(1328, 111)
        Me.gb_Pkg_Persons.TabIndex = 368
        Me.gb_Pkg_Persons.TabStop = False
        Me.gb_Pkg_Persons.Text = "Package Persons"
        '
        'tb_d_id
        '
        Me.tb_d_id.Enabled = False
        Me.tb_d_id.Location = New System.Drawing.Point(1290, 27)
        Me.tb_d_id.Name = "tb_d_id"
        Me.tb_d_id.Size = New System.Drawing.Size(31, 22)
        Me.tb_d_id.TabIndex = 23
        '
        'tb_Driver
        '
        Me.tb_Driver.Enabled = False
        Me.tb_Driver.Location = New System.Drawing.Point(871, 27)
        Me.tb_Driver.Name = "tb_Driver"
        Me.tb_Driver.Size = New System.Drawing.Size(409, 22)
        Me.tb_Driver.TabIndex = 21
        '
        'tb_tg_id
        '
        Me.tb_tg_id.Enabled = False
        Me.tb_tg_id.Location = New System.Drawing.Point(634, 27)
        Me.tb_tg_id.Name = "tb_tg_id"
        Me.tb_tg_id.Size = New System.Drawing.Size(31, 22)
        Me.tb_tg_id.TabIndex = 22
        '
        'lbl_Current_Driver_name
        '
        Me.lbl_Current_Driver_name.AutoSize = True
        Me.lbl_Current_Driver_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current_Driver_name.Location = New System.Drawing.Point(737, 29)
        Me.lbl_Current_Driver_name.Name = "lbl_Current_Driver_name"
        Me.lbl_Current_Driver_name.Size = New System.Drawing.Size(114, 18)
        Me.lbl_Current_Driver_name.TabIndex = 20
        Me.lbl_Current_Driver_name.Text = "Current Driver"
        '
        'tb_tour_guide_name
        '
        Me.tb_tour_guide_name.Enabled = False
        Me.tb_tour_guide_name.Location = New System.Drawing.Point(198, 25)
        Me.tb_tour_guide_name.Name = "tb_tour_guide_name"
        Me.tb_tour_guide_name.Size = New System.Drawing.Size(409, 22)
        Me.tb_tour_guide_name.TabIndex = 19
        '
        'lbl_Current_Tour_Guide
        '
        Me.lbl_Current_Tour_Guide.AutoSize = True
        Me.lbl_Current_Tour_Guide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current_Tour_Guide.Location = New System.Drawing.Point(25, 29)
        Me.lbl_Current_Tour_Guide.Name = "lbl_Current_Tour_Guide"
        Me.lbl_Current_Tour_Guide.Size = New System.Drawing.Size(153, 18)
        Me.lbl_Current_Tour_Guide.TabIndex = 2
        Me.lbl_Current_Tour_Guide.Text = "Current Tour Guide"
        '
        'panel_Tour_Guide
        '
        Me.panel_Tour_Guide.BackColor = System.Drawing.Color.Khaki
        Me.panel_Tour_Guide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Tour_Guide.Controls.Add(Me.tb_selected_tg_id)
        Me.panel_Tour_Guide.Controls.Add(Me.cb_Tour_Guide)
        Me.panel_Tour_Guide.Controls.Add(Me.lbl_Select_Tour_Guide)
        Me.panel_Tour_Guide.Location = New System.Drawing.Point(17, 60)
        Me.panel_Tour_Guide.Name = "panel_Tour_Guide"
        Me.panel_Tour_Guide.Size = New System.Drawing.Size(678, 40)
        Me.panel_Tour_Guide.TabIndex = 0
        '
        'tb_selected_tg_id
        '
        Me.tb_selected_tg_id.Enabled = False
        Me.tb_selected_tg_id.Location = New System.Drawing.Point(615, 7)
        Me.tb_selected_tg_id.Name = "tb_selected_tg_id"
        Me.tb_selected_tg_id.Size = New System.Drawing.Size(31, 22)
        Me.tb_selected_tg_id.TabIndex = 23
        '
        'tb_Note
        '
        Me.tb_Note.Location = New System.Drawing.Point(14, 25)
        Me.tb_Note.Multiline = True
        Me.tb_Note.Name = "tb_Note"
        Me.tb_Note.Size = New System.Drawing.Size(337, 109)
        Me.tb_Note.TabIndex = 0
        '
        'tb_GST
        '
        Me.tb_GST.Location = New System.Drawing.Point(563, 344)
        Me.tb_GST.Name = "tb_GST"
        Me.tb_GST.Size = New System.Drawing.Size(106, 29)
        Me.tb_GST.TabIndex = 6
        Me.tb_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_GST
        '
        Me.lbl_GST.AutoSize = True
        Me.lbl_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GST.Location = New System.Drawing.Point(447, 347)
        Me.lbl_GST.Name = "lbl_GST"
        Me.lbl_GST.Size = New System.Drawing.Size(45, 20)
        Me.lbl_GST.TabIndex = 5
        Me.lbl_GST.Text = "GST"
        '
        'lbl_Note
        '
        Me.lbl_Note.AutoSize = True
        Me.lbl_Note.Location = New System.Drawing.Point(161, 1)
        Me.lbl_Note.Name = "lbl_Note"
        Me.lbl_Note.Size = New System.Drawing.Size(48, 21)
        Me.lbl_Note.TabIndex = 1
        Me.lbl_Note.Text = "Note"
        '
        'lbl_Total_Price
        '
        Me.lbl_Total_Price.AutoSize = True
        Me.lbl_Total_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Price.Location = New System.Drawing.Point(421, 296)
        Me.lbl_Total_Price.Name = "lbl_Total_Price"
        Me.lbl_Total_Price.Size = New System.Drawing.Size(94, 20)
        Me.lbl_Total_Price.TabIndex = 5
        Me.lbl_Total_Price.Text = "Total Price"
        '
        'panel_Note
        '
        Me.panel_Note.BackColor = System.Drawing.Color.Khaki
        Me.panel_Note.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Note.Controls.Add(Me.lbl_Note)
        Me.panel_Note.Controls.Add(Me.tb_Note)
        Me.panel_Note.Location = New System.Drawing.Point(17, 289)
        Me.panel_Note.Name = "panel_Note"
        Me.panel_Note.Size = New System.Drawing.Size(373, 144)
        Me.panel_Note.TabIndex = 14
        '
        'gb_Package_Information
        '
        Me.gb_Package_Information.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Package_Information.Controls.Add(Me.btn_Add_days)
        Me.gb_Package_Information.Controls.Add(Me.tb_Add_Days)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Add_Days)
        Me.gb_Package_Information.Controls.Add(Me.lbl_gst_percent_sign)
        Me.gb_Package_Information.Controls.Add(Me.tb_Total_Price)
        Me.gb_Package_Information.Controls.Add(Me.tb_GST)
        Me.gb_Package_Information.Controls.Add(Me.tb_pkg_name)
        Me.gb_Package_Information.Controls.Add(Me.lbl_GST)
        Me.gb_Package_Information.Controls.Add(Me.tb_Grand_Total)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Total_Price)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Grand_Total)
        Me.gb_Package_Information.Controls.Add(Me.tb_Children_Price)
        Me.gb_Package_Information.Controls.Add(Me.tb_Adult_Price)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Children)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Adult)
        Me.gb_Package_Information.Controls.Add(Me.tb_route)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Route)
        Me.gb_Package_Information.Controls.Add(Me.panel_Note)
        Me.gb_Package_Information.Controls.Add(Me.panel_duration)
        Me.gb_Package_Information.Controls.Add(Me.lbl_Name)
        Me.gb_Package_Information.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Package_Information.Location = New System.Drawing.Point(21, 222)
        Me.gb_Package_Information.Name = "gb_Package_Information"
        Me.gb_Package_Information.Size = New System.Drawing.Size(719, 459)
        Me.gb_Package_Information.TabIndex = 364
        Me.gb_Package_Information.TabStop = False
        Me.gb_Package_Information.Text = "Package Details"
        '
        'btn_Add_days
        '
        Me.btn_Add_days.AutoSize = True
        Me.btn_Add_days.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_days.BackgroundImage = CType(resources.GetObject("btn_Add_days.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add_days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_days.Enabled = False
        Me.btn_Add_days.FlatAppearance.BorderSize = 0
        Me.btn_Add_days.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_days.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_days.ForeColor = System.Drawing.Color.White
        Me.btn_Add_days.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Add_2_Icon_16
        Me.btn_Add_days.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_days.Location = New System.Drawing.Point(498, 217)
        Me.btn_Add_days.Name = "btn_Add_days"
        Me.btn_Add_days.Size = New System.Drawing.Size(106, 33)
        Me.btn_Add_days.TabIndex = 381
        Me.btn_Add_days.Text = "Add Days"
        Me.btn_Add_days.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_days.UseVisualStyleBackColor = False
        '
        'tb_Add_Days
        '
        Me.tb_Add_Days.Location = New System.Drawing.Point(480, 175)
        Me.tb_Add_Days.Name = "tb_Add_Days"
        Me.tb_Add_Days.Size = New System.Drawing.Size(139, 29)
        Me.tb_Add_Days.TabIndex = 380
        Me.tb_Add_Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Add_Days
        '
        Me.lbl_Add_Days.AutoSize = True
        Me.lbl_Add_Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Add_Days.Location = New System.Drawing.Point(498, 140)
        Me.lbl_Add_Days.Name = "lbl_Add_Days"
        Me.lbl_Add_Days.Size = New System.Drawing.Size(86, 20)
        Me.lbl_Add_Days.TabIndex = 379
        Me.lbl_Add_Days.Text = "Add Days"
        '
        'lbl_gst_percent_sign
        '
        Me.lbl_gst_percent_sign.AutoSize = True
        Me.lbl_gst_percent_sign.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gst_percent_sign.Location = New System.Drawing.Point(666, 346)
        Me.lbl_gst_percent_sign.Name = "lbl_gst_percent_sign"
        Me.lbl_gst_percent_sign.Size = New System.Drawing.Size(30, 25)
        Me.lbl_gst_percent_sign.TabIndex = 378
        Me.lbl_gst_percent_sign.Text = "%"
        Me.lbl_gst_percent_sign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Total_Price
        '
        Me.tb_Total_Price.Location = New System.Drawing.Point(560, 292)
        Me.tb_Total_Price.Name = "tb_Total_Price"
        Me.tb_Total_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Total_Price.TabIndex = 377
        Me.tb_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_pkg_name
        '
        Me.tb_pkg_name.Location = New System.Drawing.Point(159, 18)
        Me.tb_pkg_name.Name = "tb_pkg_name"
        Me.tb_pkg_name.Size = New System.Drawing.Size(543, 29)
        Me.tb_pkg_name.TabIndex = 376
        '
        'tb_Grand_Total
        '
        Me.tb_Grand_Total.Enabled = False
        Me.tb_Grand_Total.Location = New System.Drawing.Point(563, 396)
        Me.tb_Grand_Total.Name = "tb_Grand_Total"
        Me.tb_Grand_Total.Size = New System.Drawing.Size(139, 29)
        Me.tb_Grand_Total.TabIndex = 25
        Me.tb_Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Grand_Total
        '
        Me.lbl_Grand_Total.AutoSize = True
        Me.lbl_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grand_Total.Location = New System.Drawing.Point(421, 400)
        Me.lbl_Grand_Total.Name = "lbl_Grand_Total"
        Me.lbl_Grand_Total.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Grand_Total.TabIndex = 24
        Me.lbl_Grand_Total.Text = "Grand Total"
        '
        'tb_Children_Price
        '
        Me.tb_Children_Price.Location = New System.Drawing.Point(159, 140)
        Me.tb_Children_Price.Name = "tb_Children_Price"
        Me.tb_Children_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Children_Price.TabIndex = 23
        Me.tb_Children_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_Adult_Price
        '
        Me.tb_Adult_Price.Location = New System.Drawing.Point(159, 99)
        Me.tb_Adult_Price.Name = "tb_Adult_Price"
        Me.tb_Adult_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Adult_Price.TabIndex = 22
        Me.tb_Adult_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Children
        '
        Me.lbl_Children.AutoSize = True
        Me.lbl_Children.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Children.Location = New System.Drawing.Point(19, 149)
        Me.lbl_Children.Name = "lbl_Children"
        Me.lbl_Children.Size = New System.Drawing.Size(119, 20)
        Me.lbl_Children.TabIndex = 21
        Me.lbl_Children.Text = "Children price"
        '
        'lbl_Adult
        '
        Me.lbl_Adult.AutoSize = True
        Me.lbl_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adult.Location = New System.Drawing.Point(42, 108)
        Me.lbl_Adult.Name = "lbl_Adult"
        Me.lbl_Adult.Size = New System.Drawing.Size(96, 20)
        Me.lbl_Adult.TabIndex = 20
        Me.lbl_Adult.Text = "Adult Price"
        '
        'tb_route
        '
        Me.tb_route.Location = New System.Drawing.Point(159, 57)
        Me.tb_route.Name = "tb_route"
        Me.tb_route.Size = New System.Drawing.Size(543, 29)
        Me.tb_route.TabIndex = 18
        '
        'lbl_Route
        '
        Me.lbl_Route.AutoSize = True
        Me.lbl_Route.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Route.Location = New System.Drawing.Point(79, 61)
        Me.lbl_Route.Name = "lbl_Route"
        Me.lbl_Route.Size = New System.Drawing.Size(60, 22)
        Me.lbl_Route.TabIndex = 17
        Me.lbl_Route.Text = "Route"
        '
        'panel_duration
        '
        Me.panel_duration.BackColor = System.Drawing.Color.Khaki
        Me.panel_duration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_duration.Controls.Add(Me.tb_Nights)
        Me.panel_duration.Controls.Add(Me.btn_Show_Days_Description)
        Me.panel_duration.Controls.Add(Me.lbl_Nights)
        Me.panel_duration.Controls.Add(Me.tb_Days)
        Me.panel_duration.Controls.Add(Me.lbl_Days)
        Me.panel_duration.Location = New System.Drawing.Point(23, 194)
        Me.panel_duration.Name = "panel_duration"
        Me.panel_duration.Size = New System.Drawing.Size(367, 81)
        Me.panel_duration.TabIndex = 6
        '
        'tb_Nights
        '
        Me.tb_Nights.Enabled = False
        Me.tb_Nights.Location = New System.Drawing.Point(101, 41)
        Me.tb_Nights.Name = "tb_Nights"
        Me.tb_Nights.Size = New System.Drawing.Size(139, 29)
        Me.tb_Nights.TabIndex = 12
        Me.tb_Nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Show_Days_Description
        '
        Me.btn_Show_Days_Description.AutoSize = True
        Me.btn_Show_Days_Description.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show_Days_Description.BackgroundImage = CType(resources.GetObject("btn_Show_Days_Description.BackgroundImage"), System.Drawing.Image)
        Me.btn_Show_Days_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Show_Days_Description.Enabled = False
        Me.btn_Show_Days_Description.FlatAppearance.BorderSize = 0
        Me.btn_Show_Days_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Show_Days_Description.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show_Days_Description.ForeColor = System.Drawing.Color.White
        Me.btn_Show_Days_Description.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_Show_Days_Description.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Show_Days_Description.Location = New System.Drawing.Point(248, 22)
        Me.btn_Show_Days_Description.Name = "btn_Show_Days_Description"
        Me.btn_Show_Days_Description.Size = New System.Drawing.Size(112, 31)
        Me.btn_Show_Days_Description.TabIndex = 11
        Me.btn_Show_Days_Description.Text = "Show Days"
        Me.btn_Show_Days_Description.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Show_Days_Description.UseVisualStyleBackColor = False
        '
        'tb_Days
        '
        Me.tb_Days.Enabled = False
        Me.tb_Days.Location = New System.Drawing.Point(100, 6)
        Me.tb_Days.Name = "tb_Days"
        Me.tb_Days.Size = New System.Drawing.Size(139, 29)
        Me.tb_Days.TabIndex = 375
        Me.tb_Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Package_ID
        '
        Me.lbl_Package_ID.AutoSize = True
        Me.lbl_Package_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_ID.Location = New System.Drawing.Point(25, 69)
        Me.lbl_Package_ID.Name = "lbl_Package_ID"
        Me.lbl_Package_ID.Size = New System.Drawing.Size(102, 20)
        Me.lbl_Package_ID.TabIndex = 361
        Me.lbl_Package_ID.Text = "Package ID"
        '
        'btn_Search
        '
        Me.btn_Search.AutoSize = True
        Me.btn_Search.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Search.Location = New System.Drawing.Point(760, 61)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(99, 40)
        Me.btn_Search.TabIndex = 371
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.BackgroundImage = CType(resources.GetObject("btn_Clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Actions_edit_clear_icon__5_
        Me.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Clear.Location = New System.Drawing.Point(1244, 691)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(89, 45)
        Me.btn_Clear.TabIndex = 370
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(21, 695)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(106, 41)
        Me.btn_Back.TabIndex = 369
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.AutoSize = True
        Me.btn_Update.BackColor = System.Drawing.Color.Transparent
        Me.btn_Update.BackgroundImage = CType(resources.GetObject("btn_Update.BackgroundImage"), System.Drawing.Image)
        Me.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update.Enabled = False
        Me.btn_Update.FlatAppearance.BorderSize = 0
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Text_Edit_icon__5_
        Me.btn_Update.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Update.Location = New System.Drawing.Point(690, 691)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(112, 45)
        Me.btn_Update.TabIndex = 362
        Me.btn_Update.Text = "Update"
        Me.btn_Update.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.lbl_Update_Package)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.Location = New System.Drawing.Point(-21, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1386, 56)
        Me.panel_Add_Package.TabIndex = 359
        '
        'lbl_Update_Package
        '
        Me.lbl_Update_Package.AutoSize = True
        Me.lbl_Update_Package.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Update_Package.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Update_Package.ForeColor = System.Drawing.Color.White
        Me.lbl_Update_Package.Location = New System.Drawing.Point(670, 8)
        Me.lbl_Update_Package.Name = "lbl_Update_Package"
        Me.lbl_Update_Package.Size = New System.Drawing.Size(267, 37)
        Me.lbl_Update_Package.TabIndex = 0
        Me.lbl_Update_Package.Text = "Update Package"
        '
        'cb_pkg_name
        '
        Me.cb_pkg_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_pkg_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pkg_name.FormattingEnabled = True
        Me.cb_pkg_name.Location = New System.Drawing.Point(366, 66)
        Me.cb_pkg_name.Name = "cb_pkg_name"
        Me.cb_pkg_name.Size = New System.Drawing.Size(357, 28)
        Me.cb_pkg_name.TabIndex = 372
        '
        'gb_Package_Date
        '
        Me.gb_Package_Date.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Package_Date.Controls.Add(Me.dtp_Expiry_Date)
        Me.gb_Package_Date.Controls.Add(Me.panel_No_Tours)
        Me.gb_Package_Date.Controls.Add(Me.lbl_Expiry_Date)
        Me.gb_Package_Date.Controls.Add(Me.lbl_Pkg_Create_Date)
        Me.gb_Package_Date.Controls.Add(Me.dtp_Pkg_Create_Date)
        Me.gb_Package_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Package_Date.Location = New System.Drawing.Point(761, 222)
        Me.gb_Package_Date.Name = "gb_Package_Date"
        Me.gb_Package_Date.Size = New System.Drawing.Size(589, 162)
        Me.gb_Package_Date.TabIndex = 373
        Me.gb_Package_Date.TabStop = False
        Me.gb_Package_Date.Text = "Package Date"
        '
        'dtp_Expiry_Date
        '
        Me.dtp_Expiry_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Expiry_Date.Location = New System.Drawing.Point(131, 98)
        Me.dtp_Expiry_Date.Name = "dtp_Expiry_Date"
        Me.dtp_Expiry_Date.Size = New System.Drawing.Size(154, 24)
        Me.dtp_Expiry_Date.TabIndex = 353
        Me.dtp_Expiry_Date.Value = New Date(2020, 3, 31, 0, 0, 0, 0)
        '
        'panel_No_Tours
        '
        Me.panel_No_Tours.BackColor = System.Drawing.Color.Khaki
        Me.panel_No_Tours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_No_Tours.Controls.Add(Me.btn_Show_Tours_Dates)
        Me.panel_No_Tours.Controls.Add(Me.tb_Number_of_tours)
        Me.panel_No_Tours.Controls.Add(Me.Label1)
        Me.panel_No_Tours.Location = New System.Drawing.Point(319, 18)
        Me.panel_No_Tours.Name = "panel_No_Tours"
        Me.panel_No_Tours.Size = New System.Drawing.Size(261, 138)
        Me.panel_No_Tours.TabIndex = 4
        '
        'btn_Show_Tours_Dates
        '
        Me.btn_Show_Tours_Dates.AutoSize = True
        Me.btn_Show_Tours_Dates.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show_Tours_Dates.BackgroundImage = CType(resources.GetObject("btn_Show_Tours_Dates.BackgroundImage"), System.Drawing.Image)
        Me.btn_Show_Tours_Dates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Show_Tours_Dates.Enabled = False
        Me.btn_Show_Tours_Dates.FlatAppearance.BorderSize = 0
        Me.btn_Show_Tours_Dates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Show_Tours_Dates.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show_Tours_Dates.ForeColor = System.Drawing.Color.White
        Me.btn_Show_Tours_Dates.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_Show_Tours_Dates.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Show_Tours_Dates.Location = New System.Drawing.Point(56, 88)
        Me.btn_Show_Tours_Dates.Name = "btn_Show_Tours_Dates"
        Me.btn_Show_Tours_Dates.Size = New System.Drawing.Size(147, 30)
        Me.btn_Show_Tours_Dates.TabIndex = 12
        Me.btn_Show_Tours_Dates.Text = "Show Tours Dates"
        Me.btn_Show_Tours_Dates.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Show_Tours_Dates.UseVisualStyleBackColor = False
        '
        'tb_Number_of_tours
        '
        Me.tb_Number_of_tours.Enabled = False
        Me.tb_Number_of_tours.Location = New System.Drawing.Point(62, 50)
        Me.tb_Number_of_tours.Name = "tb_Number_of_tours"
        Me.tb_Number_of_tours.Size = New System.Drawing.Size(128, 24)
        Me.tb_Number_of_tours.TabIndex = 1
        Me.tb_Number_of_tours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How Many Number of Tours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are Organised For This Package"
        '
        'lbl_Expiry_Date
        '
        Me.lbl_Expiry_Date.AutoSize = True
        Me.lbl_Expiry_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Expiry_Date.Location = New System.Drawing.Point(18, 98)
        Me.lbl_Expiry_Date.Name = "lbl_Expiry_Date"
        Me.lbl_Expiry_Date.Size = New System.Drawing.Size(101, 20)
        Me.lbl_Expiry_Date.TabIndex = 352
        Me.lbl_Expiry_Date.Text = "Expiry Date"
        '
        'lbl_Pkg_Create_Date
        '
        Me.lbl_Pkg_Create_Date.AutoSize = True
        Me.lbl_Pkg_Create_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Create_Date.Location = New System.Drawing.Point(12, 43)
        Me.lbl_Pkg_Create_Date.Name = "lbl_Pkg_Create_Date"
        Me.lbl_Pkg_Create_Date.Size = New System.Drawing.Size(107, 20)
        Me.lbl_Pkg_Create_Date.TabIndex = 7
        Me.lbl_Pkg_Create_Date.Text = "Create Date"
        '
        'dtp_Pkg_Create_Date
        '
        Me.dtp_Pkg_Create_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Pkg_Create_Date.Location = New System.Drawing.Point(131, 43)
        Me.dtp_Pkg_Create_Date.Name = "dtp_Pkg_Create_Date"
        Me.dtp_Pkg_Create_Date.Size = New System.Drawing.Size(154, 24)
        Me.dtp_Pkg_Create_Date.TabIndex = 4
        Me.dtp_Pkg_Create_Date.Value = New Date(2019, 12, 21, 0, 0, 0, 0)
        '
        'frm_Update_Package
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.Controls.Add(Me.gb_Package_Date)
        Me.Controls.Add(Me.cb_pkg_name)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.tb_Package_ID)
        Me.Controls.Add(Me.tb_Persons_Capacity)
        Me.Controls.Add(Me.lbl_Package_Person_Capacity)
        Me.Controls.Add(Me.panel_image)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Controls.Add(Me.gb_Pkg_Persons)
        Me.Controls.Add(Me.gb_Package_Information)
        Me.Controls.Add(Me.lbl_Package_ID)
        Me.Name = "frm_Update_Package"
        Me.Text = "Update Package"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_image.ResumeLayout(False)
        Me.panel_image.PerformLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.panel_driver_name.ResumeLayout(False)
        Me.panel_driver_name.PerformLayout()
        Me.gb_Pkg_Persons.ResumeLayout(False)
        Me.gb_Pkg_Persons.PerformLayout()
        Me.panel_Tour_Guide.ResumeLayout(False)
        Me.panel_Tour_Guide.PerformLayout()
        Me.panel_Note.ResumeLayout(False)
        Me.panel_Note.PerformLayout()
        Me.gb_Package_Information.ResumeLayout(False)
        Me.gb_Package_Information.PerformLayout()
        Me.panel_duration.ResumeLayout(False)
        Me.panel_duration.PerformLayout()
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.gb_Package_Date.ResumeLayout(False)
        Me.gb_Package_Date.PerformLayout()
        Me.panel_No_Tours.ResumeLayout(False)
        Me.panel_No_Tours.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Import As System.Windows.Forms.Button
    Friend WithEvents tb_Package_ID As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents pb_pkg_img As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Import_img As System.Windows.Forms.Label
    Friend WithEvents tb_Persons_Capacity As System.Windows.Forms.TextBox
    Friend WithEvents btn_None As System.Windows.Forms.Button
    Friend WithEvents lbl_Package_Person_Capacity As System.Windows.Forms.Label
    Friend WithEvents panel_image As System.Windows.Forms.Panel
    Friend WithEvents lbl_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Show_Days_Description As System.Windows.Forms.Button
    Friend WithEvents lbl_Nights As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Days As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cb_Tour_Guide As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Select_Tour_Guide As System.Windows.Forms.Label
    Friend WithEvents lbl_Driver_Name As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents cb_Driver_Name As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Update_Package As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_driver_name As System.Windows.Forms.Panel
    Friend WithEvents gb_Pkg_Persons As System.Windows.Forms.GroupBox
    Friend WithEvents panel_Tour_Guide As System.Windows.Forms.Panel
    Friend WithEvents tb_Note As System.Windows.Forms.TextBox
    Friend WithEvents tb_GST As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GST As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Note As System.Windows.Forms.Label
    Friend WithEvents lbl_Total_Price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_Note As System.Windows.Forms.Panel
    Friend WithEvents gb_Package_Information As System.Windows.Forms.GroupBox
    Friend WithEvents panel_duration As System.Windows.Forms.Panel
    Friend WithEvents lbl_Package_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents tb_Nights As System.Windows.Forms.TextBox
    Friend WithEvents cb_pkg_name As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Children_Price As System.Windows.Forms.TextBox
    Friend WithEvents tb_Adult_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_route As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Route As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Grand_Total As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Package_Date As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Expiry_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents panel_No_Tours As System.Windows.Forms.Panel
    Friend WithEvents btn_Show_Tours_Dates As System.Windows.Forms.Button
    Friend WithEvents tb_Number_of_tours As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Expiry_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Pkg_Create_Date As System.Windows.Forms.Label
    Friend WithEvents dtp_Pkg_Create_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_tour_guide_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Current_Tour_Guide As System.Windows.Forms.Label
    Friend WithEvents tb_Driver As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Current_Driver_name As System.Windows.Forms.Label
    Friend WithEvents tb_pkg_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Days As System.Windows.Forms.TextBox
    Friend WithEvents tb_Total_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gst_percent_sign As System.Windows.Forms.Label
    Friend WithEvents tb_d_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_tg_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add_days As System.Windows.Forms.Button
    Friend WithEvents tb_Add_Days As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Add_Days As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_selected_td_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_selected_tg_id As System.Windows.Forms.TextBox
End Class
