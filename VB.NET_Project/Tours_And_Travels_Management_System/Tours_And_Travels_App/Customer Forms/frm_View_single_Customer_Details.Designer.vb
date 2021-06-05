<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_View_single_Customer_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_View_single_Customer_Details))
        Me.lbl_tour_end_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Pan_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Customer_Name = New System.Windows.Forms.GroupBox()
        Me.panel_Name = New System.Windows.Forms.Panel()
        Me.tb_first_name = New System.Windows.Forms.TextBox()
        Me.lbl_Cust_Last_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Cust_Middle_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Cust_Name__first = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.tb_Middle_Name = New System.Windows.Forms.TextBox()
        Me.tb_pkg_id = New System.Windows.Forms.TextBox()
        Me.tb_Pan_No = New System.Windows.Forms.TextBox()
        Me.tb_Addhar_No = New System.Windows.Forms.TextBox()
        Me.lbl_Addhar_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_leagel_info = New System.Windows.Forms.Panel()
        Me.panel_no_of_travellers = New System.Windows.Forms.Panel()
        Me.tb_No_Adult = New System.Windows.Forms.TextBox()
        Me.lbl_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_No_Children = New System.Windows.Forms.TextBox()
        Me.lbl_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_show_Travellers_Info = New System.Windows.Forms.Button()
        Me.tb_Passen_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.tb_cust_id = New System.Windows.Forms.TextBox()
        Me.gb_Employee_Details = New System.Windows.Forms.GroupBox()
        Me.panel_other_details = New System.Windows.Forms.Panel()
        Me.tb_state = New System.Windows.Forms.TextBox()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.tb_age = New System.Windows.Forms.TextBox()
        Me.lbl_Age = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_cust_DOB = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DOB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_State = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Address = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_tour_start_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tour_start_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_tour_end_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.panel_dates = New System.Windows.Forms.Panel()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.panel_Schedule_pkg = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Show_Customer = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Customer_id = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.gb_Customer_contact = New System.Windows.Forms.GroupBox()
        Me.panel_Custo_Con_Det = New System.Windows.Forms.Panel()
        Me.tb_Email_Id = New System.Windows.Forms.TextBox()
        Me.tb_Alter_Mob_No = New System.Windows.Forms.TextBox()
        Me.tb_Mob_No = New System.Windows.Forms.TextBox()
        Me.lbl_Alter_MO_NO = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Email_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Mobail_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_Cust_today_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Today_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Legal_Info = New System.Windows.Forms.GroupBox()
        Me.lbl_Package_id = New System.Windows.Forms.Label()
        Me.gb_tour_dates = New System.Windows.Forms.GroupBox()
        Me.gb_Number_of_Travellers = New System.Windows.Forms.GroupBox()
        Me.btn_Payment = New System.Windows.Forms.Button()
        Me.gb_Customer_Name.SuspendLayout()
        Me.panel_Name.SuspendLayout()
        Me.panel_leagel_info.SuspendLayout()
        Me.panel_no_of_travellers.SuspendLayout()
        Me.gb_Employee_Details.SuspendLayout()
        Me.panel_other_details.SuspendLayout()
        Me.panel_dates.SuspendLayout()
        Me.panel_Schedule_pkg.SuspendLayout()
        Me.gb_Customer_contact.SuspendLayout()
        Me.panel_Custo_Con_Det.SuspendLayout()
        Me.gb_Legal_Info.SuspendLayout()
        Me.gb_tour_dates.SuspendLayout()
        Me.gb_Number_of_Travellers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_tour_end_date
        '
        Me.lbl_tour_end_date.AutoSize = True
        Me.lbl_tour_end_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_end_date.Location = New System.Drawing.Point(433, 13)
        Me.lbl_tour_end_date.Name = "lbl_tour_end_date"
        Me.lbl_tour_end_date.Size = New System.Drawing.Size(77, 18)
        Me.lbl_tour_end_date.TabIndex = 12
        Me.lbl_tour_end_date.Text = "End Date"
        '
        'lbl_Pan_No
        '
        Me.lbl_Pan_No.AutoSize = True
        Me.lbl_Pan_No.Location = New System.Drawing.Point(44, 51)
        Me.lbl_Pan_No.Name = "lbl_Pan_No"
        Me.lbl_Pan_No.Size = New System.Drawing.Size(107, 20)
        Me.lbl_Pan_No.TabIndex = 27
        Me.lbl_Pan_No.Text = "Pancard No."
        '
        'gb_Customer_Name
        '
        Me.gb_Customer_Name.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Customer_Name.Controls.Add(Me.panel_Name)
        Me.gb_Customer_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Customer_Name.Location = New System.Drawing.Point(17, 117)
        Me.gb_Customer_Name.Name = "gb_Customer_Name"
        Me.gb_Customer_Name.Size = New System.Drawing.Size(637, 136)
        Me.gb_Customer_Name.TabIndex = 610
        Me.gb_Customer_Name.TabStop = False
        Me.gb_Customer_Name.Text = "Customer Name"
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
        'tb_pkg_id
        '
        Me.tb_pkg_id.Enabled = False
        Me.tb_pkg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_id.Location = New System.Drawing.Point(1167, 79)
        Me.tb_pkg_id.Name = "tb_pkg_id"
        Me.tb_pkg_id.Size = New System.Drawing.Size(169, 24)
        Me.tb_pkg_id.TabIndex = 625
        '
        'tb_Pan_No
        '
        Me.tb_Pan_No.Enabled = False
        Me.tb_Pan_No.Location = New System.Drawing.Point(293, 43)
        Me.tb_Pan_No.MaxLength = 10
        Me.tb_Pan_No.Name = "tb_Pan_No"
        Me.tb_Pan_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Pan_No.TabIndex = 16
        '
        'tb_Addhar_No
        '
        Me.tb_Addhar_No.Enabled = False
        Me.tb_Addhar_No.Location = New System.Drawing.Point(294, 7)
        Me.tb_Addhar_No.MaxLength = 12
        Me.tb_Addhar_No.Name = "tb_Addhar_No"
        Me.tb_Addhar_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Addhar_No.TabIndex = 15
        '
        'lbl_Addhar_No
        '
        Me.lbl_Addhar_No.AutoSize = True
        Me.lbl_Addhar_No.Location = New System.Drawing.Point(44, 13)
        Me.lbl_Addhar_No.Name = "lbl_Addhar_No"
        Me.lbl_Addhar_No.Size = New System.Drawing.Size(99, 20)
        Me.lbl_Addhar_No.TabIndex = 25
        Me.lbl_Addhar_No.Text = "Addhar No."
        '
        'panel_leagel_info
        '
        Me.panel_leagel_info.BackColor = System.Drawing.Color.Khaki
        Me.panel_leagel_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_leagel_info.Controls.Add(Me.tb_Pan_No)
        Me.panel_leagel_info.Controls.Add(Me.lbl_Pan_No)
        Me.panel_leagel_info.Controls.Add(Me.tb_Addhar_No)
        Me.panel_leagel_info.Controls.Add(Me.lbl_Addhar_No)
        Me.panel_leagel_info.Location = New System.Drawing.Point(7, 27)
        Me.panel_leagel_info.Name = "panel_leagel_info"
        Me.panel_leagel_info.Size = New System.Drawing.Size(656, 99)
        Me.panel_leagel_info.TabIndex = 5
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
        'btn_show_Travellers_Info
        '
        Me.btn_show_Travellers_Info.AutoSize = True
        Me.btn_show_Travellers_Info.BackColor = System.Drawing.Color.Transparent
        Me.btn_show_Travellers_Info.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_show_Travellers_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_Travellers_Info.Enabled = False
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
        'tb_Passen_Total
        '
        Me.tb_Passen_Total.Enabled = False
        Me.tb_Passen_Total.Location = New System.Drawing.Point(483, 26)
        Me.tb_Passen_Total.Name = "tb_Passen_Total"
        Me.tb_Passen_Total.Size = New System.Drawing.Size(124, 26)
        Me.tb_Passen_Total.TabIndex = 24
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
        'tb_cust_id
        '
        Me.tb_cust_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cust_id.Location = New System.Drawing.Point(151, 80)
        Me.tb_cust_id.Name = "tb_cust_id"
        Me.tb_cust_id.Size = New System.Drawing.Size(169, 24)
        Me.tb_cust_id.TabIndex = 623
        '
        'gb_Employee_Details
        '
        Me.gb_Employee_Details.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Employee_Details.Controls.Add(Me.panel_other_details)
        Me.gb_Employee_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_Details.Location = New System.Drawing.Point(664, 117)
        Me.gb_Employee_Details.Name = "gb_Employee_Details"
        Me.gb_Employee_Details.Size = New System.Drawing.Size(675, 278)
        Me.gb_Employee_Details.TabIndex = 613
        Me.gb_Employee_Details.TabStop = False
        Me.gb_Employee_Details.Text = "Employee Details"
        '
        'panel_other_details
        '
        Me.panel_other_details.BackColor = System.Drawing.Color.Khaki
        Me.panel_other_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_other_details.Controls.Add(Me.tb_state)
        Me.panel_other_details.Controls.Add(Me.tb_address)
        Me.panel_other_details.Controls.Add(Me.tb_age)
        Me.panel_other_details.Controls.Add(Me.lbl_Age)
        Me.panel_other_details.Controls.Add(Me.rb_Female)
        Me.panel_other_details.Controls.Add(Me.rb_Male)
        Me.panel_other_details.Controls.Add(Me.lbl_Gender)
        Me.panel_other_details.Controls.Add(Me.dtp_cust_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_State)
        Me.panel_other_details.Controls.Add(Me.lbl_Address)
        Me.panel_other_details.Location = New System.Drawing.Point(6, 24)
        Me.panel_other_details.Name = "panel_other_details"
        Me.panel_other_details.Size = New System.Drawing.Size(663, 248)
        Me.panel_other_details.TabIndex = 4
        '
        'tb_state
        '
        Me.tb_state.Enabled = False
        Me.tb_state.Location = New System.Drawing.Point(295, 162)
        Me.tb_state.MaxLength = 12
        Me.tb_state.Name = "tb_state"
        Me.tb_state.Size = New System.Drawing.Size(305, 26)
        Me.tb_state.TabIndex = 22
        '
        'tb_address
        '
        Me.tb_address.Enabled = False
        Me.tb_address.Location = New System.Drawing.Point(295, 80)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(305, 72)
        Me.tb_address.TabIndex = 11
        '
        'tb_age
        '
        Me.tb_age.Enabled = False
        Me.tb_age.Location = New System.Drawing.Point(295, 45)
        Me.tb_age.Name = "tb_age"
        Me.tb_age.Size = New System.Drawing.Size(131, 26)
        Me.tb_age.TabIndex = 2
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Location = New System.Drawing.Point(58, 45)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(41, 20)
        Me.lbl_Age.TabIndex = 21
        Me.lbl_Age.Text = "Age"
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Enabled = False
        Me.rb_Female.Location = New System.Drawing.Point(482, 204)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(86, 24)
        Me.rb_Female.TabIndex = 14
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Enabled = False
        Me.rb_Male.Location = New System.Drawing.Point(332, 204)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(65, 24)
        Me.rb_Male.TabIndex = 13
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Location = New System.Drawing.Point(60, 206)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(69, 20)
        Me.lbl_Gender.TabIndex = 10
        Me.lbl_Gender.Text = "Gender"
        '
        'dtp_cust_DOB
        '
        Me.dtp_cust_DOB.Checked = False
        Me.dtp_cust_DOB.Enabled = False
        Me.dtp_cust_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cust_DOB.Location = New System.Drawing.Point(295, 12)
        Me.dtp_cust_DOB.Name = "dtp_cust_DOB"
        Me.dtp_cust_DOB.Size = New System.Drawing.Size(305, 26)
        Me.dtp_cust_DOB.TabIndex = 10
        Me.dtp_cust_DOB.Value = New Date(2019, 12, 30, 0, 0, 0, 0)
        '
        'lbl_DOB
        '
        Me.lbl_DOB.AutoSize = True
        Me.lbl_DOB.Location = New System.Drawing.Point(58, 10)
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(47, 20)
        Me.lbl_DOB.TabIndex = 8
        Me.lbl_DOB.Text = "DOB"
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Location = New System.Drawing.Point(58, 164)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(53, 20)
        Me.lbl_State.TabIndex = 1
        Me.lbl_State.Text = "State"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Location = New System.Drawing.Point(56, 86)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'dtp_tour_start_date
        '
        Me.dtp_tour_start_date.Enabled = False
        Me.dtp_tour_start_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tour_start_date.Location = New System.Drawing.Point(115, 13)
        Me.dtp_tour_start_date.Name = "dtp_tour_start_date"
        Me.dtp_tour_start_date.Size = New System.Drawing.Size(200, 22)
        Me.dtp_tour_start_date.TabIndex = 14
        '
        'lbl_tour_start_date
        '
        Me.lbl_tour_start_date.AutoSize = True
        Me.lbl_tour_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_start_date.Location = New System.Drawing.Point(15, 12)
        Me.lbl_tour_start_date.Name = "lbl_tour_start_date"
        Me.lbl_tour_start_date.Size = New System.Drawing.Size(84, 18)
        Me.lbl_tour_start_date.TabIndex = 1
        Me.lbl_tour_start_date.Text = "Start Date"
        '
        'dtp_tour_end_date
        '
        Me.dtp_tour_end_date.Enabled = False
        Me.dtp_tour_end_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tour_end_date.Location = New System.Drawing.Point(539, 10)
        Me.dtp_tour_end_date.Name = "dtp_tour_end_date"
        Me.dtp_tour_end_date.Size = New System.Drawing.Size(200, 22)
        Me.dtp_tour_end_date.TabIndex = 15
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
        Me.btn_Search.Location = New System.Drawing.Point(368, 71)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 40)
        Me.btn_Search.TabIndex = 624
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'panel_dates
        '
        Me.panel_dates.BackColor = System.Drawing.Color.Khaki
        Me.panel_dates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_dates.Controls.Add(Me.dtp_tour_end_date)
        Me.panel_dates.Controls.Add(Me.dtp_tour_start_date)
        Me.panel_dates.Controls.Add(Me.lbl_tour_end_date)
        Me.panel_dates.Controls.Add(Me.lbl_tour_start_date)
        Me.panel_dates.Location = New System.Drawing.Point(110, 15)
        Me.panel_dates.Name = "panel_dates"
        Me.panel_dates.Size = New System.Drawing.Size(775, 58)
        Me.panel_dates.TabIndex = 0
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
        Me.btn_Clear.Location = New System.Drawing.Point(1225, 672)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(103, 43)
        Me.btn_Clear.TabIndex = 620
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'panel_Schedule_pkg
        '
        Me.panel_Schedule_pkg.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.BackgroundImage = CType(resources.GetObject("panel_Schedule_pkg.BackgroundImage"), System.Drawing.Image)
        Me.panel_Schedule_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Schedule_pkg.Controls.Add(Me.lbl_Show_Customer)
        Me.panel_Schedule_pkg.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.Location = New System.Drawing.Point(2, 1)
        Me.panel_Schedule_pkg.Name = "panel_Schedule_pkg"
        Me.panel_Schedule_pkg.Quality = 10
        Me.panel_Schedule_pkg.Size = New System.Drawing.Size(1360, 56)
        Me.panel_Schedule_pkg.TabIndex = 611
        '
        'lbl_Show_Customer
        '
        Me.lbl_Show_Customer.AutoSize = True
        Me.lbl_Show_Customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Show_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Show_Customer.ForeColor = System.Drawing.Color.White
        Me.lbl_Show_Customer.Location = New System.Drawing.Point(579, 10)
        Me.lbl_Show_Customer.Name = "lbl_Show_Customer"
        Me.lbl_Show_Customer.Size = New System.Drawing.Size(258, 37)
        Me.lbl_Show_Customer.TabIndex = 0
        Me.lbl_Show_Customer.Text = "Show Customer"
        '
        'lbl_Customer_id
        '
        Me.lbl_Customer_id.AutoSize = True
        Me.lbl_Customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer_id.Location = New System.Drawing.Point(13, 80)
        Me.lbl_Customer_id.Name = "lbl_Customer_id"
        Me.lbl_Customer_id.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Customer_id.TabIndex = 615
        Me.lbl_Customer_id.Text = "Customer ID"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(10, 672)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(94, 46)
        Me.btn_back.TabIndex = 621
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'gb_Customer_contact
        '
        Me.gb_Customer_contact.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Customer_contact.Controls.Add(Me.panel_Custo_Con_Det)
        Me.gb_Customer_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Customer_contact.Location = New System.Drawing.Point(16, 258)
        Me.gb_Customer_contact.Name = "gb_Customer_contact"
        Me.gb_Customer_contact.Size = New System.Drawing.Size(637, 143)
        Me.gb_Customer_contact.TabIndex = 612
        Me.gb_Customer_contact.TabStop = False
        Me.gb_Customer_contact.Text = "Customer Contact Deatil"
        '
        'panel_Custo_Con_Det
        '
        Me.panel_Custo_Con_Det.BackColor = System.Drawing.Color.Khaki
        Me.panel_Custo_Con_Det.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Custo_Con_Det.Controls.Add(Me.tb_Email_Id)
        Me.panel_Custo_Con_Det.Controls.Add(Me.tb_Alter_Mob_No)
        Me.panel_Custo_Con_Det.Controls.Add(Me.tb_Mob_No)
        Me.panel_Custo_Con_Det.Controls.Add(Me.lbl_Alter_MO_NO)
        Me.panel_Custo_Con_Det.Controls.Add(Me.lbl_Email_ID)
        Me.panel_Custo_Con_Det.Controls.Add(Me.lbl_Mobail_No)
        Me.panel_Custo_Con_Det.Location = New System.Drawing.Point(6, 23)
        Me.panel_Custo_Con_Det.Name = "panel_Custo_Con_Det"
        Me.panel_Custo_Con_Det.Size = New System.Drawing.Size(623, 112)
        Me.panel_Custo_Con_Det.TabIndex = 1
        '
        'tb_Email_Id
        '
        Me.tb_Email_Id.Enabled = False
        Me.tb_Email_Id.Location = New System.Drawing.Point(246, 73)
        Me.tb_Email_Id.MaxLength = 30
        Me.tb_Email_Id.Name = "tb_Email_Id"
        Me.tb_Email_Id.Size = New System.Drawing.Size(305, 26)
        Me.tb_Email_Id.TabIndex = 6
        '
        'tb_Alter_Mob_No
        '
        Me.tb_Alter_Mob_No.Enabled = False
        Me.tb_Alter_Mob_No.Location = New System.Drawing.Point(246, 41)
        Me.tb_Alter_Mob_No.MaxLength = 10
        Me.tb_Alter_Mob_No.Name = "tb_Alter_Mob_No"
        Me.tb_Alter_Mob_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Alter_Mob_No.TabIndex = 5
        '
        'tb_Mob_No
        '
        Me.tb_Mob_No.Enabled = False
        Me.tb_Mob_No.Location = New System.Drawing.Point(246, 6)
        Me.tb_Mob_No.MaxLength = 10
        Me.tb_Mob_No.Name = "tb_Mob_No"
        Me.tb_Mob_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Mob_No.TabIndex = 4
        '
        'lbl_Alter_MO_NO
        '
        Me.lbl_Alter_MO_NO.AutoSize = True
        Me.lbl_Alter_MO_NO.Location = New System.Drawing.Point(3, 47)
        Me.lbl_Alter_MO_NO.Name = "lbl_Alter_MO_NO"
        Me.lbl_Alter_MO_NO.Size = New System.Drawing.Size(162, 20)
        Me.lbl_Alter_MO_NO.TabIndex = 2
        Me.lbl_Alter_MO_NO.Text = "Alternet Mobile No."
        '
        'lbl_Email_ID
        '
        Me.lbl_Email_ID.AutoSize = True
        Me.lbl_Email_ID.Location = New System.Drawing.Point(5, 82)
        Me.lbl_Email_ID.Name = "lbl_Email_ID"
        Me.lbl_Email_ID.Size = New System.Drawing.Size(77, 20)
        Me.lbl_Email_ID.TabIndex = 1
        Me.lbl_Email_ID.Text = "Email ID"
        '
        'lbl_Mobail_No
        '
        Me.lbl_Mobail_No.AutoSize = True
        Me.lbl_Mobail_No.Location = New System.Drawing.Point(5, 12)
        Me.lbl_Mobail_No.Name = "lbl_Mobail_No"
        Me.lbl_Mobail_No.Size = New System.Drawing.Size(93, 20)
        Me.lbl_Mobail_No.TabIndex = 0
        Me.lbl_Mobail_No.Text = "Mobile No."
        '
        'dtp_Cust_today_date
        '
        Me.dtp_Cust_today_date.Enabled = False
        Me.dtp_Cust_today_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Cust_today_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Cust_today_date.Location = New System.Drawing.Point(671, 79)
        Me.dtp_Cust_today_date.Name = "dtp_Cust_today_date"
        Me.dtp_Cust_today_date.Size = New System.Drawing.Size(145, 22)
        Me.dtp_Cust_today_date.TabIndex = 617
        '
        'lbl_Today_Date
        '
        Me.lbl_Today_Date.AutoSize = True
        Me.lbl_Today_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Today_Date.Location = New System.Drawing.Point(527, 80)
        Me.lbl_Today_Date.Name = "lbl_Today_Date"
        Me.lbl_Today_Date.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Today_Date.TabIndex = 616
        Me.lbl_Today_Date.Text = "Todays Date"
        '
        'gb_Legal_Info
        '
        Me.gb_Legal_Info.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Legal_Info.Controls.Add(Me.panel_leagel_info)
        Me.gb_Legal_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Legal_Info.Location = New System.Drawing.Point(665, 407)
        Me.gb_Legal_Info.Name = "gb_Legal_Info"
        Me.gb_Legal_Info.Size = New System.Drawing.Size(669, 148)
        Me.gb_Legal_Info.TabIndex = 614
        Me.gb_Legal_Info.TabStop = False
        Me.gb_Legal_Info.Text = "Legal Information"
        '
        'lbl_Package_id
        '
        Me.lbl_Package_id.AutoSize = True
        Me.lbl_Package_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_id.Location = New System.Drawing.Point(1059, 81)
        Me.lbl_Package_id.Name = "lbl_Package_id"
        Me.lbl_Package_id.Size = New System.Drawing.Size(102, 20)
        Me.lbl_Package_id.TabIndex = 618
        Me.lbl_Package_id.Text = "Package ID"
        '
        'gb_tour_dates
        '
        Me.gb_tour_dates.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_tour_dates.Controls.Add(Me.panel_dates)
        Me.gb_tour_dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tour_dates.Location = New System.Drawing.Point(21, 565)
        Me.gb_tour_dates.Name = "gb_tour_dates"
        Me.gb_tour_dates.Size = New System.Drawing.Size(896, 85)
        Me.gb_tour_dates.TabIndex = 622
        Me.gb_tour_dates.TabStop = False
        Me.gb_tour_dates.Text = "Tour Dates"
        '
        'gb_Number_of_Travellers
        '
        Me.gb_Number_of_Travellers.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Number_of_Travellers.Controls.Add(Me.panel_no_of_travellers)
        Me.gb_Number_of_Travellers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Number_of_Travellers.Location = New System.Drawing.Point(17, 407)
        Me.gb_Number_of_Travellers.Name = "gb_Number_of_Travellers"
        Me.gb_Number_of_Travellers.Size = New System.Drawing.Size(637, 149)
        Me.gb_Number_of_Travellers.TabIndex = 619
        Me.gb_Number_of_Travellers.TabStop = False
        Me.gb_Number_of_Travellers.Text = "Number of Travellers"
        '
        'btn_Payment
        '
        Me.btn_Payment.AutoSize = True
        Me.btn_Payment.BackColor = System.Drawing.Color.Transparent
        Me.btn_Payment.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Payment.FlatAppearance.BorderSize = 0
        Me.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Payment.ForeColor = System.Drawing.Color.White
        Me.btn_Payment.Image = CType(resources.GetObject("btn_Payment.Image"), System.Drawing.Image)
        Me.btn_Payment.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Payment.Location = New System.Drawing.Point(631, 675)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(125, 43)
        Me.btn_Payment.TabIndex = 626
        Me.btn_Payment.Text = "Payment"
        Me.btn_Payment.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Payment.UseVisualStyleBackColor = False
        '
        'frm_View_single_Customer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Payment)
        Me.Controls.Add(Me.gb_Customer_Name)
        Me.Controls.Add(Me.tb_pkg_id)
        Me.Controls.Add(Me.tb_cust_id)
        Me.Controls.Add(Me.gb_Employee_Details)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.panel_Schedule_pkg)
        Me.Controls.Add(Me.lbl_Customer_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.gb_Customer_contact)
        Me.Controls.Add(Me.dtp_Cust_today_date)
        Me.Controls.Add(Me.lbl_Today_Date)
        Me.Controls.Add(Me.gb_Legal_Info)
        Me.Controls.Add(Me.lbl_Package_id)
        Me.Controls.Add(Me.gb_tour_dates)
        Me.Controls.Add(Me.gb_Number_of_Travellers)
        Me.Name = "frm_View_single_Customer_Details"
        Me.Text = "View_Customer_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gb_Customer_Name.ResumeLayout(False)
        Me.panel_Name.ResumeLayout(False)
        Me.panel_Name.PerformLayout()
        Me.panel_leagel_info.ResumeLayout(False)
        Me.panel_leagel_info.PerformLayout()
        Me.panel_no_of_travellers.ResumeLayout(False)
        Me.panel_no_of_travellers.PerformLayout()
        Me.gb_Employee_Details.ResumeLayout(False)
        Me.panel_other_details.ResumeLayout(False)
        Me.panel_other_details.PerformLayout()
        Me.panel_dates.ResumeLayout(False)
        Me.panel_dates.PerformLayout()
        Me.panel_Schedule_pkg.ResumeLayout(False)
        Me.panel_Schedule_pkg.PerformLayout()
        Me.gb_Customer_contact.ResumeLayout(False)
        Me.panel_Custo_Con_Det.ResumeLayout(False)
        Me.panel_Custo_Con_Det.PerformLayout()
        Me.gb_Legal_Info.ResumeLayout(False)
        Me.gb_tour_dates.ResumeLayout(False)
        Me.gb_Number_of_Travellers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tour_end_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Pan_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Customer_Name As System.Windows.Forms.GroupBox
    Friend WithEvents panel_Name As System.Windows.Forms.Panel
    Friend WithEvents tb_first_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cust_Last_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Cust_Middle_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Cust_Name__first As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Middle_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_pkg_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_Pan_No As System.Windows.Forms.TextBox
    Friend WithEvents tb_Addhar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Addhar_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_leagel_info As System.Windows.Forms.Panel
    Friend WithEvents panel_no_of_travellers As System.Windows.Forms.Panel
    Friend WithEvents tb_No_Adult As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_No_Children As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_show_Travellers_Info As System.Windows.Forms.Button
    Friend WithEvents tb_Passen_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents tb_cust_id As System.Windows.Forms.TextBox
    Friend WithEvents gb_Employee_Details As System.Windows.Forms.GroupBox
    Friend WithEvents panel_other_details As System.Windows.Forms.Panel
    Friend WithEvents tb_state As System.Windows.Forms.TextBox
    Friend WithEvents tb_address As System.Windows.Forms.TextBox
    Friend WithEvents tb_age As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Age As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Gender As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_cust_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_DOB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_State As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Address As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_tour_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tour_start_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_tour_end_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents panel_dates As System.Windows.Forms.Panel
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents panel_Schedule_pkg As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Show_Customer As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Customer_id As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents gb_Customer_contact As System.Windows.Forms.GroupBox
    Friend WithEvents panel_Custo_Con_Det As System.Windows.Forms.Panel
    Friend WithEvents tb_Email_Id As System.Windows.Forms.TextBox
    Friend WithEvents tb_Alter_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents tb_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Alter_MO_NO As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Email_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Mobail_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_Cust_today_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Today_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Legal_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Package_id As System.Windows.Forms.Label
    Friend WithEvents gb_tour_dates As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Number_of_Travellers As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Payment As System.Windows.Forms.Button
End Class
