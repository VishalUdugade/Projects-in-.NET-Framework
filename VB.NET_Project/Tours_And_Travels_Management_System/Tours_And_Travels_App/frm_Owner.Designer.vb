<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Owner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Owner))
        Me.lbl_banner = New System.Windows.Forms.Label()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rs_userimg = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.panel_time = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Booking = New System.Windows.Forms.Button()
        Me.btn_U_M = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_Bill = New System.Windows.Forms.Button()
        Me.btn_Repor = New System.Windows.Forms.Button()
        Me.btn_Cust = New System.Windows.Forms.Button()
        Me.btn_Emp = New System.Windows.Forms.Button()
        Me.btn_Pkg = New System.Windows.Forms.Button()
        Me.panel_stable = New System.Windows.Forms.Panel()
        Me.panel_Report = New System.Windows.Forms.Panel()
        Me.btn_Tour_Dates = New System.Windows.Forms.Button()
        Me.btn_Pkg_Report = New System.Windows.Forms.Button()
        Me.btn_Single_day_calculation = New System.Windows.Forms.Button()
        Me.btn_date_wise_cust = New System.Windows.Forms.Button()
        Me.panel_Bill = New System.Windows.Forms.Panel()
        Me.btn_Bill_Cust = New System.Windows.Forms.Button()
        Me.panel_Customer = New System.Windows.Forms.Panel()
        Me.btn_Show_Cust = New System.Windows.Forms.Button()
        Me.btn_Delete_Customer = New System.Windows.Forms.Button()
        Me.btn_Update_Customer = New System.Windows.Forms.Button()
        Me.btn_All_Customer = New System.Windows.Forms.Button()
        Me.btn_Add_Customer = New System.Windows.Forms.Button()
        Me.panel_Package = New System.Windows.Forms.Panel()
        Me.panel_Employee = New System.Windows.Forms.Panel()
        Me.btn_Delete_Employee = New System.Windows.Forms.Button()
        Me.btn_view_all_employee = New System.Windows.Forms.Button()
        Me.btn_Update_Employee = New System.Windows.Forms.Button()
        Me.btn_Add_Employee = New System.Windows.Forms.Button()
        Me.btn_View_All_Pkg = New System.Windows.Forms.Button()
        Me.btn_view_package_to_cus = New System.Windows.Forms.Button()
        Me.btn_Delete_package = New System.Windows.Forms.Button()
        Me.btn_Schedule_package = New System.Windows.Forms.Button()
        Me.btn_Update_package = New System.Windows.Forms.Button()
        Me.btn_Create_package = New System.Windows.Forms.Button()
        Me.gbTime.SuspendLayout()
        Me.panel_time.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panel_stable.SuspendLayout()
        Me.panel_Report.SuspendLayout()
        Me.panel_Bill.SuspendLayout()
        Me.panel_Customer.SuspendLayout()
        Me.panel_Package.SuspendLayout()
        Me.panel_Employee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_banner
        '
        Me.lbl_banner.AutoSize = True
        Me.lbl_banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_banner.Font = New System.Drawing.Font("Modern No. 20", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_banner.Location = New System.Drawing.Point(12, 9)
        Me.lbl_banner.Name = "lbl_banner"
        Me.lbl_banner.Size = New System.Drawing.Size(513, 48)
        Me.lbl_banner.TabIndex = 57
        Me.lbl_banner.Text = "Intrip Tours and Travels"
        '
        'gbTime
        '
        Me.gbTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbTime.BackColor = System.Drawing.Color.Transparent
        Me.gbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbTime.Controls.Add(Me.lblZone)
        Me.gbTime.Controls.Add(Me.lblDate)
        Me.gbTime.Controls.Add(Me.lblTime)
        Me.gbTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTime.ForeColor = System.Drawing.Color.DarkOrange
        Me.gbTime.Location = New System.Drawing.Point(5, 2)
        Me.gbTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Size = New System.Drawing.Size(255, 136)
        Me.gbTime.TabIndex = 58
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Time and Date"
        '
        'lblZone
        '
        Me.lblZone.AutoSize = True
        Me.lblZone.BackColor = System.Drawing.Color.Transparent
        Me.lblZone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblZone.Location = New System.Drawing.Point(6, 81)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(70, 16)
        Me.lblZone.TabIndex = 2
        Me.lblZone.Text = "Loading..."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblDate.Location = New System.Drawing.Point(6, 55)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(70, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Loading..."
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTime.Location = New System.Drawing.Point(6, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(146, 33)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Loading..."
        '
        'lbl_Username
        '
        Me.lbl_Username.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Username.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_Username.Location = New System.Drawing.Point(155, 143)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(1209, 90)
        Me.lbl_Username.TabIndex = 59
        Me.lbl_Username.Text = "Admin"
        Me.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.rs_userimg})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 729)
        Me.ShapeContainer1.TabIndex = 60
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1350
        Me.LineShape3.X2 = -2
        Me.LineShape3.Y1 = 286
        Me.LineShape3.Y2 = 286
        '
        'rs_userimg
        '
        Me.rs_userimg.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Administrator_Icon_256
        Me.rs_userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rs_userimg.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.rs_userimg.Location = New System.Drawing.Point(-20, 145)
        Me.rs_userimg.Name = "rs_userimg"
        Me.rs_userimg.Size = New System.Drawing.Size(170, 140)
        '
        'panel_time
        '
        Me.panel_time.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel_time.Controls.Add(Me.gbTime)
        Me.panel_time.Location = New System.Drawing.Point(1105, 0)
        Me.panel_time.Name = "panel_time"
        Me.panel_time.Size = New System.Drawing.Size(259, 141)
        Me.panel_time.TabIndex = 62
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Image = Global.Tours_And_Travels_App.My.Resources.Resources.india_banner_small
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1102, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(155, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1209, 27)
        Me.Label1.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(155, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1209, 27)
        Me.Label2.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.btn_Booking)
        Me.Panel1.Controls.Add(Me.btn_U_M)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_Bill)
        Me.Panel1.Controls.Add(Me.btn_Repor)
        Me.Panel1.Controls.Add(Me.btn_Cust)
        Me.Panel1.Controls.Add(Me.btn_Emp)
        Me.Panel1.Controls.Add(Me.btn_Pkg)
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(0, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 437)
        Me.Panel1.TabIndex = 70
        '
        'btn_Booking
        '
        Me.btn_Booking.BackgroundImage = CType(resources.GetObject("btn_Booking.BackgroundImage"), System.Drawing.Image)
        Me.btn_Booking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Booking.FlatAppearance.BorderSize = 0
        Me.btn_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Booking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Booking.Location = New System.Drawing.Point(32, 215)
        Me.btn_Booking.Name = "btn_Booking"
        Me.btn_Booking.Size = New System.Drawing.Size(108, 35)
        Me.btn_Booking.TabIndex = 70
        Me.btn_Booking.Text = "Booking"
        Me.btn_Booking.UseVisualStyleBackColor = True
        '
        'btn_U_M
        '
        Me.btn_U_M.BackgroundImage = CType(resources.GetObject("btn_U_M.BackgroundImage"), System.Drawing.Image)
        Me.btn_U_M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_U_M.FlatAppearance.BorderSize = 0
        Me.btn_U_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_U_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_U_M.Location = New System.Drawing.Point(32, 272)
        Me.btn_U_M.Name = "btn_U_M"
        Me.btn_U_M.Size = New System.Drawing.Size(108, 35)
        Me.btn_U_M.TabIndex = 69
        Me.btn_U_M.Text = "UserManage"
        Me.btn_U_M.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Apps_session_logout_icon
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.Location = New System.Drawing.Point(50, 379)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(70, 52)
        Me.btn_logout.TabIndex = 68
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_Bill
        '
        Me.btn_Bill.BackgroundImage = CType(resources.GetObject("btn_Bill.BackgroundImage"), System.Drawing.Image)
        Me.btn_Bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Bill.FlatAppearance.BorderSize = 0
        Me.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bill.Location = New System.Drawing.Point(32, 165)
        Me.btn_Bill.Name = "btn_Bill"
        Me.btn_Bill.Size = New System.Drawing.Size(108, 35)
        Me.btn_Bill.TabIndex = 4
        Me.btn_Bill.Text = "Bill"
        Me.btn_Bill.UseVisualStyleBackColor = True
        '
        'btn_Repor
        '
        Me.btn_Repor.BackgroundImage = CType(resources.GetObject("btn_Repor.BackgroundImage"), System.Drawing.Image)
        Me.btn_Repor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Repor.FlatAppearance.BorderSize = 0
        Me.btn_Repor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Repor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Repor.Location = New System.Drawing.Point(32, 325)
        Me.btn_Repor.Name = "btn_Repor"
        Me.btn_Repor.Size = New System.Drawing.Size(108, 35)
        Me.btn_Repor.TabIndex = 3
        Me.btn_Repor.Text = "Report"
        Me.btn_Repor.UseVisualStyleBackColor = True
        '
        'btn_Cust
        '
        Me.btn_Cust.BackgroundImage = CType(resources.GetObject("btn_Cust.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cust.FlatAppearance.BorderSize = 0
        Me.btn_Cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cust.Location = New System.Drawing.Point(32, 116)
        Me.btn_Cust.Name = "btn_Cust"
        Me.btn_Cust.Size = New System.Drawing.Size(108, 35)
        Me.btn_Cust.TabIndex = 2
        Me.btn_Cust.Text = "Customer"
        Me.btn_Cust.UseVisualStyleBackColor = True
        '
        'btn_Emp
        '
        Me.btn_Emp.BackgroundImage = CType(resources.GetObject("btn_Emp.BackgroundImage"), System.Drawing.Image)
        Me.btn_Emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Emp.FlatAppearance.BorderSize = 0
        Me.btn_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Emp.Location = New System.Drawing.Point(32, 66)
        Me.btn_Emp.Name = "btn_Emp"
        Me.btn_Emp.Size = New System.Drawing.Size(108, 35)
        Me.btn_Emp.TabIndex = 1
        Me.btn_Emp.Text = "Employee"
        Me.btn_Emp.UseVisualStyleBackColor = True
        '
        'btn_Pkg
        '
        Me.btn_Pkg.BackgroundImage = CType(resources.GetObject("btn_Pkg.BackgroundImage"), System.Drawing.Image)
        Me.btn_Pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Pkg.FlatAppearance.BorderSize = 0
        Me.btn_Pkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pkg.Location = New System.Drawing.Point(32, 16)
        Me.btn_Pkg.Name = "btn_Pkg"
        Me.btn_Pkg.Size = New System.Drawing.Size(108, 35)
        Me.btn_Pkg.TabIndex = 0
        Me.btn_Pkg.Text = "Package"
        Me.btn_Pkg.UseVisualStyleBackColor = True
        '
        'panel_stable
        '
        Me.panel_stable.BackgroundImage = CType(resources.GetObject("panel_stable.BackgroundImage"), System.Drawing.Image)
        Me.panel_stable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_stable.Controls.Add(Me.panel_Report)
        Me.panel_stable.Controls.Add(Me.panel_Bill)
        Me.panel_stable.Controls.Add(Me.panel_Customer)
        Me.panel_stable.Controls.Add(Me.panel_Package)
        Me.panel_stable.Location = New System.Drawing.Point(186, 289)
        Me.panel_stable.Name = "panel_stable"
        Me.panel_stable.Size = New System.Drawing.Size(1164, 440)
        Me.panel_stable.TabIndex = 71
        '
        'panel_Report
        '
        Me.panel_Report.Controls.Add(Me.btn_Tour_Dates)
        Me.panel_Report.Controls.Add(Me.btn_Pkg_Report)
        Me.panel_Report.Controls.Add(Me.btn_Single_day_calculation)
        Me.panel_Report.Controls.Add(Me.btn_date_wise_cust)
        Me.panel_Report.Location = New System.Drawing.Point(3, 0)
        Me.panel_Report.Name = "panel_Report"
        Me.panel_Report.Size = New System.Drawing.Size(1158, 435)
        Me.panel_Report.TabIndex = 119
        '
        'btn_Tour_Dates
        '
        Me.btn_Tour_Dates.FlatAppearance.BorderSize = 0
        Me.btn_Tour_Dates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Tour_Dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tour_Dates.Image = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Tour_Dates.Location = New System.Drawing.Point(581, 252)
        Me.btn_Tour_Dates.Name = "btn_Tour_Dates"
        Me.btn_Tour_Dates.Size = New System.Drawing.Size(149, 121)
        Me.btn_Tour_Dates.TabIndex = 3
        Me.btn_Tour_Dates.Text = "Tour Dates"
        Me.btn_Tour_Dates.UseVisualStyleBackColor = True
        '
        'btn_Pkg_Report
        '
        Me.btn_Pkg_Report.FlatAppearance.BorderSize = 0
        Me.btn_Pkg_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pkg_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pkg_Report.Image = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Pkg_Report.Location = New System.Drawing.Point(228, 239)
        Me.btn_Pkg_Report.Name = "btn_Pkg_Report"
        Me.btn_Pkg_Report.Size = New System.Drawing.Size(149, 121)
        Me.btn_Pkg_Report.TabIndex = 2
        Me.btn_Pkg_Report.Text = "Package Report"
        Me.btn_Pkg_Report.UseVisualStyleBackColor = True
        '
        'btn_Single_day_calculation
        '
        Me.btn_Single_day_calculation.FlatAppearance.BorderSize = 0
        Me.btn_Single_day_calculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Single_day_calculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Single_day_calculation.Image = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Single_day_calculation.Location = New System.Drawing.Point(581, 32)
        Me.btn_Single_day_calculation.Name = "btn_Single_day_calculation"
        Me.btn_Single_day_calculation.Size = New System.Drawing.Size(149, 121)
        Me.btn_Single_day_calculation.TabIndex = 1
        Me.btn_Single_day_calculation.Text = "Single Day Summary"
        Me.btn_Single_day_calculation.UseVisualStyleBackColor = True
        '
        'btn_date_wise_cust
        '
        Me.btn_date_wise_cust.FlatAppearance.BorderSize = 0
        Me.btn_date_wise_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_date_wise_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_date_wise_cust.Image = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_date_wise_cust.Location = New System.Drawing.Point(228, 32)
        Me.btn_date_wise_cust.Name = "btn_date_wise_cust"
        Me.btn_date_wise_cust.Size = New System.Drawing.Size(149, 121)
        Me.btn_date_wise_cust.TabIndex = 0
        Me.btn_date_wise_cust.Text = "Datewise Customer"
        Me.btn_date_wise_cust.UseVisualStyleBackColor = True
        '
        'panel_Bill
        '
        Me.panel_Bill.Controls.Add(Me.btn_Bill_Cust)
        Me.panel_Bill.Location = New System.Drawing.Point(3, 1)
        Me.panel_Bill.Name = "panel_Bill"
        Me.panel_Bill.Size = New System.Drawing.Size(1158, 435)
        Me.panel_Bill.TabIndex = 118
        '
        'btn_Bill_Cust
        '
        Me.btn_Bill_Cust.AutoSize = True
        Me.btn_Bill_Cust.BackColor = System.Drawing.Color.Transparent
        Me.btn_Bill_Cust.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Bill_Cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Bill_Cust.FlatAppearance.BorderSize = 0
        Me.btn_Bill_Cust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Bill_Cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bill_Cust.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Electronic_billing_machine_Icon_128
        Me.btn_Bill_Cust.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Bill_Cust.Location = New System.Drawing.Point(471, 99)
        Me.btn_Bill_Cust.Name = "btn_Bill_Cust"
        Me.btn_Bill_Cust.Size = New System.Drawing.Size(181, 157)
        Me.btn_Bill_Cust.TabIndex = 111
        Me.btn_Bill_Cust.Text = "Bill"
        Me.btn_Bill_Cust.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Bill_Cust.UseVisualStyleBackColor = False
        '
        'panel_Customer
        '
        Me.panel_Customer.Controls.Add(Me.btn_Show_Cust)
        Me.panel_Customer.Controls.Add(Me.btn_Delete_Customer)
        Me.panel_Customer.Controls.Add(Me.btn_Update_Customer)
        Me.panel_Customer.Controls.Add(Me.btn_All_Customer)
        Me.panel_Customer.Controls.Add(Me.btn_Add_Customer)
        Me.panel_Customer.Location = New System.Drawing.Point(3, 2)
        Me.panel_Customer.Name = "panel_Customer"
        Me.panel_Customer.Size = New System.Drawing.Size(1158, 437)
        Me.panel_Customer.TabIndex = 117
        '
        'btn_Show_Cust
        '
        Me.btn_Show_Cust.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Show_Cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Show_Cust.FlatAppearance.BorderSize = 0
        Me.btn_Show_Cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Show_Cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show_Cust.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Man_2_Icon_128
        Me.btn_Show_Cust.Location = New System.Drawing.Point(445, 18)
        Me.btn_Show_Cust.Name = "btn_Show_Cust"
        Me.btn_Show_Cust.Size = New System.Drawing.Size(178, 157)
        Me.btn_Show_Cust.TabIndex = 116
        Me.btn_Show_Cust.Text = "Show Customer"
        Me.btn_Show_Cust.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Show_Cust.UseVisualStyleBackColor = True
        '
        'btn_Delete_Customer
        '
        Me.btn_Delete_Customer.AutoSize = True
        Me.btn_Delete_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_Delete_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Delete_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete_Customer.FlatAppearance.BorderSize = 0
        Me.btn_Delete_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Delete_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_Customer.Image = Global.Tours_And_Travels_App.My.Resources.Resources.user_delete_icon
        Me.btn_Delete_Customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Delete_Customer.Location = New System.Drawing.Point(238, 239)
        Me.btn_Delete_Customer.Name = "btn_Delete_Customer"
        Me.btn_Delete_Customer.Size = New System.Drawing.Size(181, 157)
        Me.btn_Delete_Customer.TabIndex = 115
        Me.btn_Delete_Customer.Text = "Delete Customer"
        Me.btn_Delete_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Delete_Customer.UseVisualStyleBackColor = False
        '
        'btn_Update_Customer
        '
        Me.btn_Update_Customer.AutoSize = True
        Me.btn_Update_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_Update_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Update_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update_Customer.FlatAppearance.BorderSize = 0
        Me.btn_Update_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Update_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_Customer.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Edit_Male_User_Icon_128
        Me.btn_Update_Customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Update_Customer.Location = New System.Drawing.Point(658, 18)
        Me.btn_Update_Customer.Name = "btn_Update_Customer"
        Me.btn_Update_Customer.Size = New System.Drawing.Size(181, 157)
        Me.btn_Update_Customer.TabIndex = 114
        Me.btn_Update_Customer.Text = "Update Customer"
        Me.btn_Update_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update_Customer.UseVisualStyleBackColor = False
        '
        'btn_All_Customer
        '
        Me.btn_All_Customer.AutoSize = True
        Me.btn_All_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_All_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_All_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_All_Customer.FlatAppearance.BorderSize = 0
        Me.btn_All_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_All_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_All_Customer.Image = CType(resources.GetObject("btn_All_Customer.Image"), System.Drawing.Image)
        Me.btn_All_Customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_All_Customer.Location = New System.Drawing.Point(658, 239)
        Me.btn_All_Customer.Name = "btn_All_Customer"
        Me.btn_All_Customer.Size = New System.Drawing.Size(181, 164)
        Me.btn_All_Customer.TabIndex = 113
        Me.btn_All_Customer.Text = "All Customer"
        Me.btn_All_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_All_Customer.UseVisualStyleBackColor = False
        '
        'btn_Add_Customer
        '
        Me.btn_Add_Customer.AutoSize = True
        Me.btn_Add_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Add_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_Customer.FlatAppearance.BorderSize = 0
        Me.btn_Add_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Add_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Customer.Image = Global.Tours_And_Travels_App.My.Resources.Resources.user_add_icon
        Me.btn_Add_Customer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_Customer.Location = New System.Drawing.Point(241, 18)
        Me.btn_Add_Customer.Name = "btn_Add_Customer"
        Me.btn_Add_Customer.Size = New System.Drawing.Size(178, 157)
        Me.btn_Add_Customer.TabIndex = 112
        Me.btn_Add_Customer.Text = "Add Customer"
        Me.btn_Add_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_Customer.UseVisualStyleBackColor = False
        '
        'panel_Package
        '
        Me.panel_Package.Controls.Add(Me.panel_Employee)
        Me.panel_Package.Controls.Add(Me.btn_View_All_Pkg)
        Me.panel_Package.Controls.Add(Me.btn_view_package_to_cus)
        Me.panel_Package.Controls.Add(Me.btn_Delete_package)
        Me.panel_Package.Controls.Add(Me.btn_Schedule_package)
        Me.panel_Package.Controls.Add(Me.btn_Update_package)
        Me.panel_Package.Controls.Add(Me.btn_Create_package)
        Me.panel_Package.Location = New System.Drawing.Point(3, 2)
        Me.panel_Package.Name = "panel_Package"
        Me.panel_Package.Size = New System.Drawing.Size(1154, 437)
        Me.panel_Package.TabIndex = 73
        '
        'panel_Employee
        '
        Me.panel_Employee.Controls.Add(Me.btn_Delete_Employee)
        Me.panel_Employee.Controls.Add(Me.btn_view_all_employee)
        Me.panel_Employee.Controls.Add(Me.btn_Update_Employee)
        Me.panel_Employee.Controls.Add(Me.btn_Add_Employee)
        Me.panel_Employee.Location = New System.Drawing.Point(0, 3)
        Me.panel_Employee.Name = "panel_Employee"
        Me.panel_Employee.Size = New System.Drawing.Size(1158, 437)
        Me.panel_Employee.TabIndex = 77
        '
        'btn_Delete_Employee
        '
        Me.btn_Delete_Employee.AutoSize = True
        Me.btn_Delete_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Delete_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Delete_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Delete_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_Employee.Image = CType(resources.GetObject("btn_Delete_Employee.Image"), System.Drawing.Image)
        Me.btn_Delete_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Delete_Employee.Location = New System.Drawing.Point(611, 250)
        Me.btn_Delete_Employee.Name = "btn_Delete_Employee"
        Me.btn_Delete_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Delete_Employee.TabIndex = 116
        Me.btn_Delete_Employee.Text = "Delete Employee"
        Me.btn_Delete_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Delete_Employee.UseVisualStyleBackColor = False
        '
        'btn_view_all_employee
        '
        Me.btn_view_all_employee.AutoSize = True
        Me.btn_view_all_employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_view_all_employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_view_all_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_all_employee.FlatAppearance.BorderSize = 0
        Me.btn_view_all_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_all_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_all_employee.Image = Global.Tours_And_Travels_App.My.Resources.Resources.eye_icon__1_
        Me.btn_view_all_employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view_all_employee.Location = New System.Drawing.Point(238, 236)
        Me.btn_view_all_employee.Name = "btn_view_all_employee"
        Me.btn_view_all_employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_view_all_employee.TabIndex = 115
        Me.btn_view_all_employee.Text = "View All Employee"
        Me.btn_view_all_employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_view_all_employee.UseVisualStyleBackColor = False
        '
        'btn_Update_Employee
        '
        Me.btn_Update_Employee.AutoSize = True
        Me.btn_Update_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Update_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Update_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Update_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_Employee.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Edit_Male_User_Icon_128
        Me.btn_Update_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Update_Employee.Location = New System.Drawing.Point(611, 15)
        Me.btn_Update_Employee.Name = "btn_Update_Employee"
        Me.btn_Update_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Update_Employee.TabIndex = 114
        Me.btn_Update_Employee.Text = "Update Employee"
        Me.btn_Update_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update_Employee.UseVisualStyleBackColor = False
        '
        'btn_Add_Employee
        '
        Me.btn_Add_Employee.AutoSize = True
        Me.btn_Add_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Add_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Add_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Employee.Image = CType(resources.GetObject("btn_Add_Employee.Image"), System.Drawing.Image)
        Me.btn_Add_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_Employee.Location = New System.Drawing.Point(238, 15)
        Me.btn_Add_Employee.Name = "btn_Add_Employee"
        Me.btn_Add_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Add_Employee.TabIndex = 113
        Me.btn_Add_Employee.Text = "Add Employee"
        Me.btn_Add_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_Employee.UseVisualStyleBackColor = False
        '
        'btn_View_All_Pkg
        '
        Me.btn_View_All_Pkg.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_View_All_Pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_View_All_Pkg.FlatAppearance.BorderSize = 0
        Me.btn_View_All_Pkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_View_All_Pkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View_All_Pkg.Image = Global.Tours_And_Travels_App.My.Resources.Resources.eye_icon__1_
        Me.btn_View_All_Pkg.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_View_All_Pkg.Location = New System.Drawing.Point(482, 250)
        Me.btn_View_All_Pkg.Name = "btn_View_All_Pkg"
        Me.btn_View_All_Pkg.Size = New System.Drawing.Size(167, 143)
        Me.btn_View_All_Pkg.TabIndex = 76
        Me.btn_View_All_Pkg.Text = "View All Packages"
        Me.btn_View_All_Pkg.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_View_All_Pkg.UseVisualStyleBackColor = True
        '
        'btn_view_package_to_cus
        '
        Me.btn_view_package_to_cus.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_view_package_to_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_package_to_cus.FlatAppearance.BorderSize = 0
        Me.btn_view_package_to_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_package_to_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_package_to_cus.Image = Global.Tours_And_Travels_App.My.Resources.Resources.eye_icon__1_
        Me.btn_view_package_to_cus.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view_package_to_cus.Location = New System.Drawing.Point(477, 30)
        Me.btn_view_package_to_cus.Name = "btn_view_package_to_cus"
        Me.btn_view_package_to_cus.Size = New System.Drawing.Size(167, 143)
        Me.btn_view_package_to_cus.TabIndex = 75
        Me.btn_view_package_to_cus.Text = "View Packages"
        Me.btn_view_package_to_cus.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_view_package_to_cus.UseVisualStyleBackColor = True
        '
        'btn_Delete_package
        '
        Me.btn_Delete_package.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Delete_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete_package.FlatAppearance.BorderSize = 0
        Me.btn_Delete_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete_package.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_package.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Package_delete_icon
        Me.btn_Delete_package.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Delete_package.Location = New System.Drawing.Point(819, 250)
        Me.btn_Delete_package.Name = "btn_Delete_package"
        Me.btn_Delete_package.Size = New System.Drawing.Size(167, 157)
        Me.btn_Delete_package.TabIndex = 74
        Me.btn_Delete_package.Text = "Delete Package"
        Me.btn_Delete_package.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Delete_package.UseVisualStyleBackColor = True
        '
        'btn_Schedule_package
        '
        Me.btn_Schedule_package.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Schedule_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Schedule_package.FlatAppearance.BorderSize = 0
        Me.btn_Schedule_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Schedule_package.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Schedule_package.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Scheduled_Tasks_Icon_128
        Me.btn_Schedule_package.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Schedule_package.Location = New System.Drawing.Point(819, 30)
        Me.btn_Schedule_package.Name = "btn_Schedule_package"
        Me.btn_Schedule_package.Size = New System.Drawing.Size(167, 157)
        Me.btn_Schedule_package.TabIndex = 73
        Me.btn_Schedule_package.Text = "Schedule Package"
        Me.btn_Schedule_package.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Schedule_package.UseVisualStyleBackColor = True
        '
        'btn_Update_package
        '
        Me.btn_Update_package.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Update_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update_package.FlatAppearance.BorderSize = 0
        Me.btn_Update_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_package.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_package.Image = Global.Tours_And_Travels_App.My.Resources.Resources.product_icon
        Me.btn_Update_package.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Update_package.Location = New System.Drawing.Point(169, 250)
        Me.btn_Update_package.Name = "btn_Update_package"
        Me.btn_Update_package.Size = New System.Drawing.Size(167, 157)
        Me.btn_Update_package.TabIndex = 72
        Me.btn_Update_package.Text = "Update Package"
        Me.btn_Update_package.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update_package.UseVisualStyleBackColor = True
        '
        'btn_Create_package
        '
        Me.btn_Create_package.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Create_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Create_package.FlatAppearance.BorderSize = 0
        Me.btn_Create_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Create_package.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Create_package.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Package_Add_Icon_128
        Me.btn_Create_package.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Create_package.Location = New System.Drawing.Point(168, 30)
        Me.btn_Create_package.Name = "btn_Create_package"
        Me.btn_Create_package.Size = New System.Drawing.Size(167, 157)
        Me.btn_Create_package.TabIndex = 71
        Me.btn_Create_package.Text = "Create Package"
        Me.btn_Create_package.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Create_package.UseVisualStyleBackColor = True
        '
        'frm_Owner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.panel_stable)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_time)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_banner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_Owner"
        Me.Text = "Owner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.panel_time.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panel_stable.ResumeLayout(False)
        Me.panel_Report.ResumeLayout(False)
        Me.panel_Bill.ResumeLayout(False)
        Me.panel_Bill.PerformLayout()
        Me.panel_Customer.ResumeLayout(False)
        Me.panel_Customer.PerformLayout()
        Me.panel_Package.ResumeLayout(False)
        Me.panel_Employee.ResumeLayout(False)
        Me.panel_Employee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_banner As System.Windows.Forms.Label
    Friend WithEvents gbTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents rs_userimg As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents panel_time As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Bill As System.Windows.Forms.Button
    Friend WithEvents btn_Repor As System.Windows.Forms.Button
    Friend WithEvents btn_Cust As System.Windows.Forms.Button
    Friend WithEvents btn_Emp As System.Windows.Forms.Button
    Friend WithEvents btn_Pkg As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents panel_stable As System.Windows.Forms.Panel
    Friend WithEvents panel_Package As System.Windows.Forms.Panel
    Friend WithEvents btn_View_All_Pkg As System.Windows.Forms.Button
    Friend WithEvents btn_view_package_to_cus As System.Windows.Forms.Button
    Friend WithEvents btn_Delete_package As System.Windows.Forms.Button
    Friend WithEvents btn_Schedule_package As System.Windows.Forms.Button
    Friend WithEvents btn_Update_package As System.Windows.Forms.Button
    Friend WithEvents btn_Create_package As System.Windows.Forms.Button
    Friend WithEvents panel_Customer As System.Windows.Forms.Panel
    Friend WithEvents panel_Bill As System.Windows.Forms.Panel
    Friend WithEvents btn_Bill_Cust As System.Windows.Forms.Button
    Friend WithEvents btn_Show_Cust As System.Windows.Forms.Button
    Friend WithEvents btn_Delete_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_Update_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_All_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Customer As System.Windows.Forms.Button
    Friend WithEvents panel_Employee As System.Windows.Forms.Panel
    Friend WithEvents btn_Delete_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_view_all_employee As System.Windows.Forms.Button
    Friend WithEvents btn_Update_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_U_M As System.Windows.Forms.Button
    Friend WithEvents btn_Booking As System.Windows.Forms.Button
    Friend WithEvents panel_Report As System.Windows.Forms.Panel
    Friend WithEvents btn_Tour_Dates As System.Windows.Forms.Button
    Friend WithEvents btn_Pkg_Report As System.Windows.Forms.Button
    Friend WithEvents btn_Single_day_calculation As System.Windows.Forms.Button
    Friend WithEvents btn_date_wise_cust As System.Windows.Forms.Button
End Class
