<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Create_Packages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Create_Packages))
        Me.tb_Package_ID = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lbl_Package_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_package_detail = New System.Windows.Forms.GroupBox()
        Me.tb_route = New System.Windows.Forms.TextBox()
        Me.lbl_Route = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_total_price_of_Packge = New System.Windows.Forms.GroupBox()
        Me.Panel_Total_Price = New System.Windows.Forms.Panel()
        Me.tb_Total_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Grand_Total = New System.Windows.Forms.Panel()
        Me.tb_Grand_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Grand_Total = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_GST = New System.Windows.Forms.Panel()
        Me.lbl_gst_percent_sign = New System.Windows.Forms.Label()
        Me.tb_GST = New System.Windows.Forms.TextBox()
        Me.lbl_GST = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Note = New System.Windows.Forms.Panel()
        Me.lbl_Note = New System.Windows.Forms.Label()
        Me.tb_Note = New System.Windows.Forms.TextBox()
        Me.panel_duration = New System.Windows.Forms.Panel()
        Me.tb_Nights = New System.Windows.Forms.TextBox()
        Me.tb_Days = New System.Windows.Forms.TextBox()
        Me.lbl_Days = New System.Windows.Forms.Label()
        Me.btn_Add_Days_Description = New System.Windows.Forms.Button()
        Me.lbl_Nights = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Duration = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_price = New System.Windows.Forms.Panel()
        Me.tb_Children_Price = New System.Windows.Forms.TextBox()
        Me.tb_Adult_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Package_Price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_pkg_name = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lbl_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_no_of_tours = New System.Windows.Forms.Panel()
        Me.btn_Add_Tours_Dates = New System.Windows.Forms.Button()
        Me.tb_Number_of_tours = New System.Windows.Forms.TextBox()
        Me.lbl_Pkg_No_Of_Organ_Tour = New System.Windows.Forms.Label()
        Me.panel_image = New System.Windows.Forms.Panel()
        Me.btn_Cancal = New System.Windows.Forms.Button()
        Me.btn_Import = New System.Windows.Forms.Button()
        Me.pb_pkg_img = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Import_Tour_img = New System.Windows.Forms.Label()
        Me.tb_Persons_Capacity = New System.Windows.Forms.TextBox()
        Me.lbl_Package_Person_Capacity = New System.Windows.Forms.Label()
        Me.gb_Package_Date = New System.Windows.Forms.GroupBox()
        Me.dtp_Expiry_Date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Expiry_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Pkg_Create_Date = New System.Windows.Forms.Label()
        Me.dtp_Pkg_Create_Date = New System.Windows.Forms.DateTimePicker()
        Me.gb_Pkg_Persons = New System.Windows.Forms.GroupBox()
        Me.panel_driver_name = New System.Windows.Forms.Panel()
        Me.cb_Driver_Name = New System.Windows.Forms.ComboBox()
        Me.lbl_Driver_Name = New System.Windows.Forms.Label()
        Me.panel_Tour_Guide = New System.Windows.Forms.Panel()
        Me.cb_Tour_Guide = New System.Windows.Forms.ComboBox()
        Me.lbl_Select_Tour_Guide = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Create_Package = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_package_detail.SuspendLayout()
        Me.gb_total_price_of_Packge.SuspendLayout()
        Me.Panel_Total_Price.SuspendLayout()
        Me.panel_Grand_Total.SuspendLayout()
        Me.panel_GST.SuspendLayout()
        Me.panel_Note.SuspendLayout()
        Me.panel_duration.SuspendLayout()
        Me.panel_price.SuspendLayout()
        Me.panel_no_of_tours.SuspendLayout()
        Me.panel_image.SuspendLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.gb_Package_Date.SuspendLayout()
        Me.gb_Pkg_Persons.SuspendLayout()
        Me.panel_driver_name.SuspendLayout()
        Me.panel_Tour_Guide.SuspendLayout()
        Me.panel_Add_Package.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_Package_ID
        '
        Me.tb_Package_ID.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_Package_ID.Enabled = False
        Me.tb_Package_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Package_ID.Location = New System.Drawing.Point(172, 62)
        Me.tb_Package_ID.MaxLength = 4
        Me.tb_Package_ID.Name = "tb_Package_ID"
        Me.tb_Package_ID.Size = New System.Drawing.Size(140, 26)
        Me.tb_Package_ID.TabIndex = 1
        Me.tb_Package_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Package_ID
        '
        Me.lbl_Package_ID.AutoSize = True
        Me.lbl_Package_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_ID.Location = New System.Drawing.Point(34, 66)
        Me.lbl_Package_ID.Name = "lbl_Package_ID"
        Me.lbl_Package_ID.Size = New System.Drawing.Size(102, 20)
        Me.lbl_Package_ID.TabIndex = 2
        Me.lbl_Package_ID.Text = "Package ID"
        '
        'gb_package_detail
        '
        Me.gb_package_detail.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_package_detail.Controls.Add(Me.tb_route)
        Me.gb_package_detail.Controls.Add(Me.lbl_Route)
        Me.gb_package_detail.Controls.Add(Me.gb_total_price_of_Packge)
        Me.gb_package_detail.Controls.Add(Me.panel_Note)
        Me.gb_package_detail.Controls.Add(Me.panel_duration)
        Me.gb_package_detail.Controls.Add(Me.panel_price)
        Me.gb_package_detail.Controls.Add(Me.tb_pkg_name)
        Me.gb_package_detail.Controls.Add(Me.lbl_Name)
        Me.gb_package_detail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_package_detail.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_package_detail.Location = New System.Drawing.Point(22, 167)
        Me.gb_package_detail.Name = "gb_package_detail"
        Me.gb_package_detail.Size = New System.Drawing.Size(719, 501)
        Me.gb_package_detail.TabIndex = 344
        Me.gb_package_detail.TabStop = False
        Me.gb_package_detail.Text = "Package Details"
        '
        'tb_route
        '
        Me.tb_route.Location = New System.Drawing.Point(106, 66)
        Me.tb_route.Name = "tb_route"
        Me.tb_route.Size = New System.Drawing.Size(591, 29)
        Me.tb_route.TabIndex = 18
        '
        'lbl_Route
        '
        Me.lbl_Route.AutoSize = True
        Me.lbl_Route.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Route.Location = New System.Drawing.Point(17, 70)
        Me.lbl_Route.Name = "lbl_Route"
        Me.lbl_Route.Size = New System.Drawing.Size(60, 22)
        Me.lbl_Route.TabIndex = 19
        Me.lbl_Route.Text = "Route"
        '
        'gb_total_price_of_Packge
        '
        Me.gb_total_price_of_Packge.Controls.Add(Me.Panel_Total_Price)
        Me.gb_total_price_of_Packge.Controls.Add(Me.panel_Grand_Total)
        Me.gb_total_price_of_Packge.Controls.Add(Me.panel_GST)
        Me.gb_total_price_of_Packge.Location = New System.Drawing.Point(427, 113)
        Me.gb_total_price_of_Packge.Name = "gb_total_price_of_Packge"
        Me.gb_total_price_of_Packge.Size = New System.Drawing.Size(269, 378)
        Me.gb_total_price_of_Packge.TabIndex = 17
        Me.gb_total_price_of_Packge.TabStop = False
        Me.gb_total_price_of_Packge.Text = " Package Price"
        '
        'Panel_Total_Price
        '
        Me.Panel_Total_Price.BackColor = System.Drawing.Color.Khaki
        Me.Panel_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Total_Price.Controls.Add(Me.tb_Total_Price)
        Me.Panel_Total_Price.Controls.Add(Me.lbl_Total_Price)
        Me.Panel_Total_Price.Location = New System.Drawing.Point(56, 38)
        Me.Panel_Total_Price.Name = "Panel_Total_Price"
        Me.Panel_Total_Price.Size = New System.Drawing.Size(153, 67)
        Me.Panel_Total_Price.TabIndex = 5
        '
        'tb_Total_Price
        '
        Me.tb_Total_Price.Location = New System.Drawing.Point(5, 30)
        Me.tb_Total_Price.Name = "tb_Total_Price"
        Me.tb_Total_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Total_Price.TabIndex = 7
        Me.tb_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_Price
        '
        Me.lbl_Total_Price.AutoSize = True
        Me.lbl_Total_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Price.Location = New System.Drawing.Point(35, 5)
        Me.lbl_Total_Price.Name = "lbl_Total_Price"
        Me.lbl_Total_Price.Size = New System.Drawing.Size(94, 20)
        Me.lbl_Total_Price.TabIndex = 5
        Me.lbl_Total_Price.Text = "Total Price"
        '
        'panel_Grand_Total
        '
        Me.panel_Grand_Total.BackColor = System.Drawing.Color.Khaki
        Me.panel_Grand_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Grand_Total.Controls.Add(Me.tb_Grand_Total)
        Me.panel_Grand_Total.Controls.Add(Me.lbl_Grand_Total)
        Me.panel_Grand_Total.Enabled = False
        Me.panel_Grand_Total.Location = New System.Drawing.Point(56, 301)
        Me.panel_Grand_Total.Name = "panel_Grand_Total"
        Me.panel_Grand_Total.Size = New System.Drawing.Size(153, 67)
        Me.panel_Grand_Total.TabIndex = 16
        '
        'tb_Grand_Total
        '
        Me.tb_Grand_Total.Enabled = False
        Me.tb_Grand_Total.Location = New System.Drawing.Point(6, 29)
        Me.tb_Grand_Total.Name = "tb_Grand_Total"
        Me.tb_Grand_Total.Size = New System.Drawing.Size(139, 29)
        Me.tb_Grand_Total.TabIndex = 6
        Me.tb_Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Grand_Total
        '
        Me.lbl_Grand_Total.AutoSize = True
        Me.lbl_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grand_Total.Location = New System.Drawing.Point(29, 5)
        Me.lbl_Grand_Total.Name = "lbl_Grand_Total"
        Me.lbl_Grand_Total.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Grand_Total.TabIndex = 5
        Me.lbl_Grand_Total.Text = "Grand Total"
        '
        'panel_GST
        '
        Me.panel_GST.BackColor = System.Drawing.Color.Khaki
        Me.panel_GST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_GST.Controls.Add(Me.lbl_gst_percent_sign)
        Me.panel_GST.Controls.Add(Me.tb_GST)
        Me.panel_GST.Controls.Add(Me.lbl_GST)
        Me.panel_GST.Location = New System.Drawing.Point(56, 168)
        Me.panel_GST.Name = "panel_GST"
        Me.panel_GST.Size = New System.Drawing.Size(153, 67)
        Me.panel_GST.TabIndex = 6
        '
        'lbl_gst_percent_sign
        '
        Me.lbl_gst_percent_sign.AutoSize = True
        Me.lbl_gst_percent_sign.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gst_percent_sign.Location = New System.Drawing.Point(109, 26)
        Me.lbl_gst_percent_sign.Name = "lbl_gst_percent_sign"
        Me.lbl_gst_percent_sign.Size = New System.Drawing.Size(30, 25)
        Me.lbl_gst_percent_sign.TabIndex = 7
        Me.lbl_gst_percent_sign.Text = "%"
        Me.lbl_gst_percent_sign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_GST
        '
        Me.tb_GST.Location = New System.Drawing.Point(7, 24)
        Me.tb_GST.Name = "tb_GST"
        Me.tb_GST.Size = New System.Drawing.Size(99, 29)
        Me.tb_GST.TabIndex = 6
        Me.tb_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_GST
        '
        Me.lbl_GST.AutoSize = True
        Me.lbl_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GST.Location = New System.Drawing.Point(49, 6)
        Me.lbl_GST.Name = "lbl_GST"
        Me.lbl_GST.Size = New System.Drawing.Size(45, 20)
        Me.lbl_GST.TabIndex = 5
        Me.lbl_GST.Text = "GST"
        '
        'panel_Note
        '
        Me.panel_Note.BackColor = System.Drawing.Color.Khaki
        Me.panel_Note.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Note.Controls.Add(Me.lbl_Note)
        Me.panel_Note.Controls.Add(Me.tb_Note)
        Me.panel_Note.Location = New System.Drawing.Point(17, 347)
        Me.panel_Note.Name = "panel_Note"
        Me.panel_Note.Size = New System.Drawing.Size(350, 144)
        Me.panel_Note.TabIndex = 8
        '
        'lbl_Note
        '
        Me.lbl_Note.AutoSize = True
        Me.lbl_Note.Location = New System.Drawing.Point(149, 4)
        Me.lbl_Note.Name = "lbl_Note"
        Me.lbl_Note.Size = New System.Drawing.Size(48, 21)
        Me.lbl_Note.TabIndex = 1
        Me.lbl_Note.Text = "Note"
        '
        'tb_Note
        '
        Me.tb_Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_Note.Location = New System.Drawing.Point(4, 28)
        Me.tb_Note.Multiline = True
        Me.tb_Note.Name = "tb_Note"
        Me.tb_Note.Size = New System.Drawing.Size(337, 109)
        Me.tb_Note.TabIndex = 0
        '
        'panel_duration
        '
        Me.panel_duration.BackColor = System.Drawing.Color.Khaki
        Me.panel_duration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_duration.Controls.Add(Me.tb_Nights)
        Me.panel_duration.Controls.Add(Me.tb_Days)
        Me.panel_duration.Controls.Add(Me.lbl_Days)
        Me.panel_duration.Controls.Add(Me.btn_Add_Days_Description)
        Me.panel_duration.Controls.Add(Me.lbl_Nights)
        Me.panel_duration.Controls.Add(Me.lbl_Duration)
        Me.panel_duration.Location = New System.Drawing.Point(17, 216)
        Me.panel_duration.Name = "panel_duration"
        Me.panel_duration.Size = New System.Drawing.Size(350, 120)
        Me.panel_duration.TabIndex = 3
        '
        'tb_Nights
        '
        Me.tb_Nights.Enabled = False
        Me.tb_Nights.Location = New System.Drawing.Point(202, 39)
        Me.tb_Nights.Name = "tb_Nights"
        Me.tb_Nights.Size = New System.Drawing.Size(139, 29)
        Me.tb_Nights.TabIndex = 14
        Me.tb_Nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_Days
        '
        Me.tb_Days.Location = New System.Drawing.Point(6, 39)
        Me.tb_Days.Name = "tb_Days"
        Me.tb_Days.Size = New System.Drawing.Size(139, 29)
        Me.tb_Days.TabIndex = 1
        Me.tb_Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Days
        '
        Me.lbl_Days.AutoSize = True
        Me.lbl_Days.Location = New System.Drawing.Point(34, 13)
        Me.lbl_Days.Name = "lbl_Days"
        Me.lbl_Days.Size = New System.Drawing.Size(51, 21)
        Me.lbl_Days.TabIndex = 12
        Me.lbl_Days.Text = "Days"
        '
        'btn_Add_Days_Description
        '
        Me.btn_Add_Days_Description.AutoSize = True
        Me.btn_Add_Days_Description.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Days_Description.BackgroundImage = CType(resources.GetObject("btn_Add_Days_Description.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add_Days_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_Days_Description.Enabled = False
        Me.btn_Add_Days_Description.FlatAppearance.BorderSize = 0
        Me.btn_Add_Days_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_Days_Description.ForeColor = System.Drawing.Color.White
        Me.btn_Add_Days_Description.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Add_2_Icon_16
        Me.btn_Add_Days_Description.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_Days_Description.Location = New System.Drawing.Point(131, 78)
        Me.btn_Add_Days_Description.Name = "btn_Add_Days_Description"
        Me.btn_Add_Days_Description.Size = New System.Drawing.Size(79, 31)
        Me.btn_Add_Days_Description.TabIndex = 2
        Me.btn_Add_Days_Description.Text = "Add"
        Me.btn_Add_Days_Description.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_Days_Description.UseVisualStyleBackColor = False
        '
        'lbl_Nights
        '
        Me.lbl_Nights.AutoSize = True
        Me.lbl_Nights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nights.Location = New System.Drawing.Point(242, 17)
        Me.lbl_Nights.Name = "lbl_Nights"
        Me.lbl_Nights.Size = New System.Drawing.Size(60, 20)
        Me.lbl_Nights.TabIndex = 7
        Me.lbl_Nights.Text = "Nights"
        '
        'lbl_Duration
        '
        Me.lbl_Duration.AutoSize = True
        Me.lbl_Duration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Duration.Location = New System.Drawing.Point(136, 4)
        Me.lbl_Duration.Name = "lbl_Duration"
        Me.lbl_Duration.Size = New System.Drawing.Size(78, 20)
        Me.lbl_Duration.TabIndex = 5
        Me.lbl_Duration.Text = "Duration"
        '
        'panel_price
        '
        Me.panel_price.BackColor = System.Drawing.Color.Khaki
        Me.panel_price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_price.Controls.Add(Me.tb_Children_Price)
        Me.panel_price.Controls.Add(Me.tb_Adult_Price)
        Me.panel_price.Controls.Add(Me.lbl_Children)
        Me.panel_price.Controls.Add(Me.lbl_Adult)
        Me.panel_price.Controls.Add(Me.lbl_Package_Price)
        Me.panel_price.Location = New System.Drawing.Point(17, 114)
        Me.panel_price.Name = "panel_price"
        Me.panel_price.Size = New System.Drawing.Size(350, 93)
        Me.panel_price.TabIndex = 2
        '
        'tb_Children_Price
        '
        Me.tb_Children_Price.Location = New System.Drawing.Point(202, 49)
        Me.tb_Children_Price.Name = "tb_Children_Price"
        Me.tb_Children_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Children_Price.TabIndex = 2
        Me.tb_Children_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_Adult_Price
        '
        Me.tb_Adult_Price.Location = New System.Drawing.Point(6, 48)
        Me.tb_Adult_Price.Name = "tb_Adult_Price"
        Me.tb_Adult_Price.Size = New System.Drawing.Size(139, 29)
        Me.tb_Adult_Price.TabIndex = 1
        Me.tb_Adult_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Children
        '
        Me.lbl_Children.AutoSize = True
        Me.lbl_Children.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Children.Location = New System.Drawing.Point(227, 26)
        Me.lbl_Children.Name = "lbl_Children"
        Me.lbl_Children.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Children.TabIndex = 5
        Me.lbl_Children.Text = "Children"
        '
        'lbl_Adult
        '
        Me.lbl_Adult.AutoSize = True
        Me.lbl_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adult.Location = New System.Drawing.Point(43, 26)
        Me.lbl_Adult.Name = "lbl_Adult"
        Me.lbl_Adult.Size = New System.Drawing.Size(51, 20)
        Me.lbl_Adult.TabIndex = 4
        Me.lbl_Adult.Text = "Adult"
        '
        'lbl_Package_Price
        '
        Me.lbl_Package_Price.AutoSize = True
        Me.lbl_Package_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_Price.Location = New System.Drawing.Point(148, 4)
        Me.lbl_Package_Price.Name = "lbl_Package_Price"
        Me.lbl_Package_Price.Size = New System.Drawing.Size(49, 20)
        Me.lbl_Package_Price.TabIndex = 3
        Me.lbl_Package_Price.Text = "Price"
        '
        'tb_pkg_name
        '
        Me.tb_pkg_name.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_pkg_name.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_name.Location = New System.Drawing.Point(232, 24)
        Me.tb_pkg_name.Name = "tb_pkg_name"
        Me.tb_pkg_name.Size = New System.Drawing.Size(464, 25)
        Me.tb_pkg_name.TabIndex = 0
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(13, 29)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(129, 20)
        Me.lbl_Name.TabIndex = 3
        Me.lbl_Name.Text = "Package Name"
        '
        'panel_no_of_tours
        '
        Me.panel_no_of_tours.BackColor = System.Drawing.Color.Khaki
        Me.panel_no_of_tours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_no_of_tours.Controls.Add(Me.btn_Add_Tours_Dates)
        Me.panel_no_of_tours.Controls.Add(Me.tb_Number_of_tours)
        Me.panel_no_of_tours.Controls.Add(Me.lbl_Pkg_No_Of_Organ_Tour)
        Me.panel_no_of_tours.Location = New System.Drawing.Point(319, 18)
        Me.panel_no_of_tours.Name = "panel_no_of_tours"
        Me.panel_no_of_tours.Size = New System.Drawing.Size(261, 138)
        Me.panel_no_of_tours.TabIndex = 4
        '
        'btn_Add_Tours_Dates
        '
        Me.btn_Add_Tours_Dates.AutoSize = True
        Me.btn_Add_Tours_Dates.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Tours_Dates.BackgroundImage = CType(resources.GetObject("btn_Add_Tours_Dates.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add_Tours_Dates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_Tours_Dates.Enabled = False
        Me.btn_Add_Tours_Dates.FlatAppearance.BorderSize = 0
        Me.btn_Add_Tours_Dates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_Tours_Dates.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Tours_Dates.ForeColor = System.Drawing.Color.White
        Me.btn_Add_Tours_Dates.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Add_2_Icon_32
        Me.btn_Add_Tours_Dates.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_Tours_Dates.Location = New System.Drawing.Point(52, 84)
        Me.btn_Add_Tours_Dates.Name = "btn_Add_Tours_Dates"
        Me.btn_Add_Tours_Dates.Size = New System.Drawing.Size(151, 40)
        Me.btn_Add_Tours_Dates.TabIndex = 12
        Me.btn_Add_Tours_Dates.Text = "Add Tours Dates" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For This Package"
        Me.btn_Add_Tours_Dates.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_Tours_Dates.UseVisualStyleBackColor = False
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
        'lbl_Pkg_No_Of_Organ_Tour
        '
        Me.lbl_Pkg_No_Of_Organ_Tour.AutoSize = True
        Me.lbl_Pkg_No_Of_Organ_Tour.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_No_Of_Organ_Tour.Location = New System.Drawing.Point(25, 7)
        Me.lbl_Pkg_No_Of_Organ_Tour.Name = "lbl_Pkg_No_Of_Organ_Tour"
        Me.lbl_Pkg_No_Of_Organ_Tour.Size = New System.Drawing.Size(226, 36)
        Me.lbl_Pkg_No_Of_Organ_Tour.TabIndex = 0
        Me.lbl_Pkg_No_Of_Organ_Tour.Text = "How Many Number of Tours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are Organised For This Package"
        '
        'panel_image
        '
        Me.panel_image.BackColor = System.Drawing.Color.Khaki
        Me.panel_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_image.Controls.Add(Me.btn_Cancal)
        Me.panel_image.Controls.Add(Me.btn_Import)
        Me.panel_image.Controls.Add(Me.pb_pkg_img)
        Me.panel_image.Controls.Add(Me.BunifuGradientPanel1)
        Me.panel_image.Location = New System.Drawing.Point(761, 345)
        Me.panel_image.Name = "panel_image"
        Me.panel_image.Size = New System.Drawing.Size(588, 323)
        Me.panel_image.TabIndex = 7
        '
        'btn_Cancal
        '
        Me.btn_Cancal.AutoSize = True
        Me.btn_Cancal.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancal.BackgroundImage = CType(resources.GetObject("btn_Cancal.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cancal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancal.FlatAppearance.BorderSize = 0
        Me.btn_Cancal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancal.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancal.ForeColor = System.Drawing.Color.White
        Me.btn_Cancal.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Sign_Error_Icon_32
        Me.btn_Cancal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Cancal.Location = New System.Drawing.Point(357, 273)
        Me.btn_Cancal.Name = "btn_Cancal"
        Me.btn_Cancal.Size = New System.Drawing.Size(99, 38)
        Me.btn_Cancal.TabIndex = 3
        Me.btn_Cancal.Text = "Cancal"
        Me.btn_Cancal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Cancal.UseVisualStyleBackColor = False
        '
        'btn_Import
        '
        Me.btn_Import.AutoSize = True
        Me.btn_Import.BackColor = System.Drawing.Color.Transparent
        Me.btn_Import.BackgroundImage = CType(resources.GetObject("btn_Import.BackgroundImage"), System.Drawing.Image)
        Me.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Import.FlatAppearance.BorderSize = 0
        Me.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Import.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Import.ForeColor = System.Drawing.Color.White
        Me.btn_Import.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Import.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Import.Location = New System.Drawing.Point(117, 273)
        Me.btn_Import.Name = "btn_Import"
        Me.btn_Import.Size = New System.Drawing.Size(99, 38)
        Me.btn_Import.TabIndex = 2
        Me.btn_Import.Text = "Import"
        Me.btn_Import.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Import.UseVisualStyleBackColor = False
        '
        'pb_pkg_img
        '
        Me.pb_pkg_img.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pb_pkg_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_pkg_img.Location = New System.Drawing.Point(3, 44)
        Me.pb_pkg_img.Name = "pb_pkg_img"
        Me.pb_pkg_img.Size = New System.Drawing.Size(578, 213)
        Me.pb_pkg_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_pkg_img.TabIndex = 1
        Me.pb_pkg_img.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_Import_Tour_img)
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
        'lbl_Import_Tour_img
        '
        Me.lbl_Import_Tour_img.AutoSize = True
        Me.lbl_Import_Tour_img.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Import_Tour_img.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Import_Tour_img.Location = New System.Drawing.Point(218, 6)
        Me.lbl_Import_Tour_img.Name = "lbl_Import_Tour_img"
        Me.lbl_Import_Tour_img.Size = New System.Drawing.Size(157, 20)
        Me.lbl_Import_Tour_img.TabIndex = 0
        Me.lbl_Import_Tour_img.Text = "Import Tour Image"
        '
        'tb_Persons_Capacity
        '
        Me.tb_Persons_Capacity.Enabled = False
        Me.tb_Persons_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Persons_Capacity.Location = New System.Drawing.Point(955, 62)
        Me.tb_Persons_Capacity.Name = "tb_Persons_Capacity"
        Me.tb_Persons_Capacity.Size = New System.Drawing.Size(123, 24)
        Me.tb_Persons_Capacity.TabIndex = 333
        Me.tb_Persons_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Package_Person_Capacity
        '
        Me.lbl_Package_Person_Capacity.AutoSize = True
        Me.lbl_Package_Person_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_Person_Capacity.Location = New System.Drawing.Point(773, 63)
        Me.lbl_Package_Person_Capacity.Name = "lbl_Package_Person_Capacity"
        Me.lbl_Package_Person_Capacity.Size = New System.Drawing.Size(148, 20)
        Me.lbl_Package_Person_Capacity.TabIndex = 352
        Me.lbl_Package_Person_Capacity.Text = "Persons Capacity"
        '
        'gb_Package_Date
        '
        Me.gb_Package_Date.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Package_Date.Controls.Add(Me.dtp_Expiry_Date)
        Me.gb_Package_Date.Controls.Add(Me.panel_no_of_tours)
        Me.gb_Package_Date.Controls.Add(Me.lbl_Expiry_Date)
        Me.gb_Package_Date.Controls.Add(Me.lbl_Pkg_Create_Date)
        Me.gb_Package_Date.Controls.Add(Me.dtp_Pkg_Create_Date)
        Me.gb_Package_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Package_Date.Location = New System.Drawing.Point(761, 167)
        Me.gb_Package_Date.Name = "gb_Package_Date"
        Me.gb_Package_Date.Size = New System.Drawing.Size(589, 162)
        Me.gb_Package_Date.TabIndex = 354
        Me.gb_Package_Date.TabStop = False
        Me.gb_Package_Date.Text = "Package Date"
        '
        'dtp_Expiry_Date
        '
        Me.dtp_Expiry_Date.Enabled = False
        Me.dtp_Expiry_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Expiry_Date.Location = New System.Drawing.Point(131, 98)
        Me.dtp_Expiry_Date.Name = "dtp_Expiry_Date"
        Me.dtp_Expiry_Date.Size = New System.Drawing.Size(154, 24)
        Me.dtp_Expiry_Date.TabIndex = 353
        Me.dtp_Expiry_Date.Value = New Date(2020, 3, 31, 0, 0, 0, 0)
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
        'gb_Pkg_Persons
        '
        Me.gb_Pkg_Persons.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Pkg_Persons.Controls.Add(Me.panel_driver_name)
        Me.gb_Pkg_Persons.Controls.Add(Me.panel_Tour_Guide)
        Me.gb_Pkg_Persons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Pkg_Persons.Location = New System.Drawing.Point(22, 92)
        Me.gb_Pkg_Persons.Name = "gb_Pkg_Persons"
        Me.gb_Pkg_Persons.Size = New System.Drawing.Size(1328, 67)
        Me.gb_Pkg_Persons.TabIndex = 356
        Me.gb_Pkg_Persons.TabStop = False
        Me.gb_Pkg_Persons.Text = "Package Persons"
        '
        'panel_driver_name
        '
        Me.panel_driver_name.BackColor = System.Drawing.Color.Khaki
        Me.panel_driver_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_driver_name.Controls.Add(Me.cb_Driver_Name)
        Me.panel_driver_name.Controls.Add(Me.lbl_Driver_Name)
        Me.panel_driver_name.Location = New System.Drawing.Point(739, 19)
        Me.panel_driver_name.Name = "panel_driver_name"
        Me.panel_driver_name.Size = New System.Drawing.Size(580, 40)
        Me.panel_driver_name.TabIndex = 10
        '
        'cb_Driver_Name
        '
        Me.cb_Driver_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Driver_Name.FormattingEnabled = True
        Me.cb_Driver_Name.Location = New System.Drawing.Point(117, 9)
        Me.cb_Driver_Name.Name = "cb_Driver_Name"
        Me.cb_Driver_Name.Size = New System.Drawing.Size(451, 24)
        Me.cb_Driver_Name.TabIndex = 1
        '
        'lbl_Driver_Name
        '
        Me.lbl_Driver_Name.AutoSize = True
        Me.lbl_Driver_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Driver_Name.Location = New System.Drawing.Point(4, 11)
        Me.lbl_Driver_Name.Name = "lbl_Driver_Name"
        Me.lbl_Driver_Name.Size = New System.Drawing.Size(53, 18)
        Me.lbl_Driver_Name.TabIndex = 0
        Me.lbl_Driver_Name.Text = "Driver"
        '
        'panel_Tour_Guide
        '
        Me.panel_Tour_Guide.BackColor = System.Drawing.Color.Khaki
        Me.panel_Tour_Guide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Tour_Guide.Controls.Add(Me.cb_Tour_Guide)
        Me.panel_Tour_Guide.Controls.Add(Me.lbl_Select_Tour_Guide)
        Me.panel_Tour_Guide.Location = New System.Drawing.Point(17, 19)
        Me.panel_Tour_Guide.Name = "panel_Tour_Guide"
        Me.panel_Tour_Guide.Size = New System.Drawing.Size(702, 40)
        Me.panel_Tour_Guide.TabIndex = 9
        '
        'cb_Tour_Guide
        '
        Me.cb_Tour_Guide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Tour_Guide.FormattingEnabled = True
        Me.cb_Tour_Guide.Location = New System.Drawing.Point(150, 9)
        Me.cb_Tour_Guide.Name = "cb_Tour_Guide"
        Me.cb_Tour_Guide.Size = New System.Drawing.Size(460, 24)
        Me.cb_Tour_Guide.TabIndex = 1
        '
        'lbl_Select_Tour_Guide
        '
        Me.lbl_Select_Tour_Guide.AutoSize = True
        Me.lbl_Select_Tour_Guide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Select_Tour_Guide.Location = New System.Drawing.Point(6, 11)
        Me.lbl_Select_Tour_Guide.Name = "lbl_Select_Tour_Guide"
        Me.lbl_Select_Tour_Guide.Size = New System.Drawing.Size(92, 18)
        Me.lbl_Select_Tour_Guide.TabIndex = 0
        Me.lbl_Select_Tour_Guide.Text = "Tour Guide"
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
        Me.btn_Clear.Location = New System.Drawing.Point(1238, 682)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(106, 42)
        Me.btn_Clear.TabIndex = 358
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(35, 687)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 37)
        Me.btn_Back.TabIndex = 564
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.BackgroundImage = CType(resources.GetObject("btn_Save.BackgroundImage"), System.Drawing.Image)
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Save_Icon_32
        Me.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Save.Location = New System.Drawing.Point(696, 679)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(106, 45)
        Me.btn_Save.TabIndex = 10
        Me.btn_Save.Text = "Save"
        Me.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.lbl_Create_Package)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.Location = New System.Drawing.Point(3, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1386, 56)
        Me.panel_Add_Package.TabIndex = 0
        '
        'lbl_Create_Package
        '
        Me.lbl_Create_Package.AutoSize = True
        Me.lbl_Create_Package.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Create_Package.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Create_Package.ForeColor = System.Drawing.Color.White
        Me.lbl_Create_Package.Location = New System.Drawing.Point(540, 8)
        Me.lbl_Create_Package.Name = "lbl_Create_Package"
        Me.lbl_Create_Package.Size = New System.Drawing.Size(259, 37)
        Me.lbl_Create_Package.TabIndex = 0
        Me.lbl_Create_Package.Text = "Create Package"
        '
        'frm_Create_Packages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.gb_Pkg_Persons)
        Me.Controls.Add(Me.gb_Package_Date)
        Me.Controls.Add(Me.panel_image)
        Me.Controls.Add(Me.tb_Persons_Capacity)
        Me.Controls.Add(Me.lbl_Package_Person_Capacity)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.gb_package_detail)
        Me.Controls.Add(Me.lbl_Package_ID)
        Me.Controls.Add(Me.tb_Package_ID)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Name = "frm_Create_Packages"
        Me.Text = "Add Packages"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gb_package_detail.ResumeLayout(False)
        Me.gb_package_detail.PerformLayout()
        Me.gb_total_price_of_Packge.ResumeLayout(False)
        Me.Panel_Total_Price.ResumeLayout(False)
        Me.Panel_Total_Price.PerformLayout()
        Me.panel_Grand_Total.ResumeLayout(False)
        Me.panel_Grand_Total.PerformLayout()
        Me.panel_GST.ResumeLayout(False)
        Me.panel_GST.PerformLayout()
        Me.panel_Note.ResumeLayout(False)
        Me.panel_Note.PerformLayout()
        Me.panel_duration.ResumeLayout(False)
        Me.panel_duration.PerformLayout()
        Me.panel_price.ResumeLayout(False)
        Me.panel_price.PerformLayout()
        Me.panel_no_of_tours.ResumeLayout(False)
        Me.panel_no_of_tours.PerformLayout()
        Me.panel_image.ResumeLayout(False)
        Me.panel_image.PerformLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.gb_Package_Date.ResumeLayout(False)
        Me.gb_Package_Date.PerformLayout()
        Me.gb_Pkg_Persons.ResumeLayout(False)
        Me.panel_driver_name.ResumeLayout(False)
        Me.panel_driver_name.PerformLayout()
        Me.panel_Tour_Guide.ResumeLayout(False)
        Me.panel_Tour_Guide.PerformLayout()
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Create_Package As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Package_ID As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lbl_Package_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_package_detail As System.Windows.Forms.GroupBox
    Friend WithEvents tb_pkg_name As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lbl_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_price As System.Windows.Forms.Panel
    Friend WithEvents lbl_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Package_Price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Duration As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_duration As System.Windows.Forms.Panel
    Friend WithEvents lbl_Nights As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_GST As System.Windows.Forms.Panel
    Friend WithEvents lbl_GST As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel_Total_Price As System.Windows.Forms.Panel
    Friend WithEvents lbl_Total_Price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents panel_image As System.Windows.Forms.Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pb_pkg_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Import_Tour_img As System.Windows.Forms.Label
    Friend WithEvents btn_Import As System.Windows.Forms.Button
    Friend WithEvents panel_Note As System.Windows.Forms.Panel
    Friend WithEvents lbl_Note As System.Windows.Forms.Label
    Friend WithEvents tb_Note As System.Windows.Forms.TextBox
    Friend WithEvents tb_Persons_Capacity As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Package_Person_Capacity As System.Windows.Forms.Label
    Friend WithEvents gb_Package_Date As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Pkg_Create_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents panel_no_of_tours As System.Windows.Forms.Panel
    Friend WithEvents tb_Number_of_tours As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Pkg_No_Of_Organ_Tour As System.Windows.Forms.Label
    Friend WithEvents btn_Cancal As System.Windows.Forms.Button
    Friend WithEvents dtp_Expiry_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Expiry_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Add_Days_Description As System.Windows.Forms.Button
    Friend WithEvents lbl_Pkg_Create_Date As System.Windows.Forms.Label
    Friend WithEvents panel_Grand_Total As System.Windows.Forms.Panel
    Friend WithEvents lbl_Grand_Total As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents gb_Pkg_Persons As System.Windows.Forms.GroupBox
    Friend WithEvents panel_driver_name As System.Windows.Forms.Panel
    Friend WithEvents cb_Driver_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Driver_Name As System.Windows.Forms.Label
    Friend WithEvents panel_Tour_Guide As System.Windows.Forms.Panel
    Friend WithEvents cb_Tour_Guide As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Select_Tour_Guide As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents tb_GST As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add_Tours_Dates As System.Windows.Forms.Button
    Friend WithEvents tb_Total_Price As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nights As System.Windows.Forms.TextBox
    Friend WithEvents tb_Days As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Days As System.Windows.Forms.Label
    Friend WithEvents tb_Children_Price As System.Windows.Forms.TextBox
    Friend WithEvents tb_Adult_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_gst_percent_sign As System.Windows.Forms.Label
    Friend WithEvents gb_total_price_of_Packge As System.Windows.Forms.GroupBox
    Friend WithEvents tb_route As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Route As Bunifu.Framework.UI.BunifuCustomLabel
End Class
