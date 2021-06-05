<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Update_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Update_Employee))
        Me.panel_Schedule_pkg = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Update_Employee_pkg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_Joining_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Joining_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Legal_Info = New System.Windows.Forms.GroupBox()
        Me.panel_legal_info = New System.Windows.Forms.Panel()
        Me.tb_four_wheelr_dri_lic = New System.Windows.Forms.TextBox()
        Me.lbl_Four_Wheeler_dri_lic_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Addhar_No = New System.Windows.Forms.TextBox()
        Me.lbl_Addhar_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Emp_id = New System.Windows.Forms.TextBox()
        Me.lbl_Employee_id = New System.Windows.Forms.Label()
        Me.gb_Employee_Details = New System.Windows.Forms.GroupBox()
        Me.panel_other_details = New System.Windows.Forms.Panel()
        Me.tb_State = New System.Windows.Forms.TextBox()
        Me.tb_pin_code = New System.Windows.Forms.TextBox()
        Me.tb_City_Town_Vill = New System.Windows.Forms.TextBox()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.tb_age = New System.Windows.Forms.TextBox()
        Me.lbl_Age = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_pin_code = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DOB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_City = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_State = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Address = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Employee_contact = New System.Windows.Forms.GroupBox()
        Me.panel_Custo_Con_Det = New System.Windows.Forms.Panel()
        Me.tb_Email_Id = New System.Windows.Forms.TextBox()
        Me.tb_Alter_Mob_No = New System.Windows.Forms.TextBox()
        Me.tb_Mob_No = New System.Windows.Forms.TextBox()
        Me.lbl_Alter_MO_NO = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Email_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Mobail_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Employee_Name = New System.Windows.Forms.GroupBox()
        Me.panel_name = New System.Windows.Forms.Panel()
        Me.tb_first_name = New System.Windows.Forms.TextBox()
        Me.lbl_Emp_Last_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Emp_Middle_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Emp_Name__first = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.tb_Middle_Name = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.gb_Emp_Post_Sal = New System.Windows.Forms.GroupBox()
        Me.panel_sal = New System.Windows.Forms.Panel()
        Me.tb_Curr_Bank_Nm = New System.Windows.Forms.TextBox()
        Me.lbl_Current_Bank_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_Bank_Name = New System.Windows.Forms.ComboBox()
        Me.lbl_new_Bank_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Bank_Acc_no = New System.Windows.Forms.TextBox()
        Me.tb_emp_sal = New System.Windows.Forms.TextBox()
        Me.lbl_Salary = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Bank_Acc_no = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_pan_no = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_post = New System.Windows.Forms.Panel()
        Me.rb_Driver = New System.Windows.Forms.RadioButton()
        Me.rb_Receptionist = New System.Windows.Forms.RadioButton()
        Me.rb_Tour_Guide = New System.Windows.Forms.RadioButton()
        Me.rb_Cashier = New System.Windows.Forms.RadioButton()
        Me.panel_Schedule_pkg.SuspendLayout()
        Me.gb_Legal_Info.SuspendLayout()
        Me.panel_legal_info.SuspendLayout()
        Me.gb_Employee_Details.SuspendLayout()
        Me.panel_other_details.SuspendLayout()
        Me.gb_Employee_contact.SuspendLayout()
        Me.panel_Custo_Con_Det.SuspendLayout()
        Me.gb_Employee_Name.SuspendLayout()
        Me.panel_name.SuspendLayout()
        Me.gb_Emp_Post_Sal.SuspendLayout()
        Me.panel_sal.SuspendLayout()
        Me.panel_post.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Schedule_pkg
        '
        Me.panel_Schedule_pkg.BackgroundImage = CType(resources.GetObject("panel_Schedule_pkg.BackgroundImage"), System.Drawing.Image)
        Me.panel_Schedule_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Schedule_pkg.Controls.Add(Me.lbl_Update_Employee_pkg)
        Me.panel_Schedule_pkg.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_Schedule_pkg.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_Schedule_pkg.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_Schedule_pkg.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_Schedule_pkg.Location = New System.Drawing.Point(2, 1)
        Me.panel_Schedule_pkg.Name = "panel_Schedule_pkg"
        Me.panel_Schedule_pkg.Quality = 10
        Me.panel_Schedule_pkg.Size = New System.Drawing.Size(1366, 55)
        Me.panel_Schedule_pkg.TabIndex = 15
        '
        'lbl_Update_Employee_pkg
        '
        Me.lbl_Update_Employee_pkg.AutoSize = True
        Me.lbl_Update_Employee_pkg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Update_Employee_pkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Update_Employee_pkg.ForeColor = System.Drawing.Color.White
        Me.lbl_Update_Employee_pkg.Location = New System.Drawing.Point(579, 9)
        Me.lbl_Update_Employee_pkg.Name = "lbl_Update_Employee_pkg"
        Me.lbl_Update_Employee_pkg.Size = New System.Drawing.Size(284, 37)
        Me.lbl_Update_Employee_pkg.TabIndex = 0
        Me.lbl_Update_Employee_pkg.Text = "Update Employee"
        '
        'dtp_Joining_date
        '
        Me.dtp_Joining_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Joining_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Joining_date.Location = New System.Drawing.Point(810, 82)
        Me.dtp_Joining_date.Name = "dtp_Joining_date"
        Me.dtp_Joining_date.Size = New System.Drawing.Size(200, 24)
        Me.dtp_Joining_date.TabIndex = 30
        '
        'lbl_Joining_Date
        '
        Me.lbl_Joining_Date.AutoSize = True
        Me.lbl_Joining_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joining_Date.Location = New System.Drawing.Point(666, 83)
        Me.lbl_Joining_Date.Name = "lbl_Joining_Date"
        Me.lbl_Joining_Date.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Joining_Date.TabIndex = 29
        Me.lbl_Joining_Date.Text = "Joining Date"
        '
        'gb_Legal_Info
        '
        Me.gb_Legal_Info.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Legal_Info.Controls.Add(Me.panel_legal_info)
        Me.gb_Legal_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Legal_Info.Location = New System.Drawing.Point(663, 503)
        Me.gb_Legal_Info.Name = "gb_Legal_Info"
        Me.gb_Legal_Info.Size = New System.Drawing.Size(675, 154)
        Me.gb_Legal_Info.TabIndex = 28
        Me.gb_Legal_Info.TabStop = False
        Me.gb_Legal_Info.Text = "Legal Information"
        '
        'panel_legal_info
        '
        Me.panel_legal_info.BackColor = System.Drawing.Color.Khaki
        Me.panel_legal_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_legal_info.Controls.Add(Me.tb_four_wheelr_dri_lic)
        Me.panel_legal_info.Controls.Add(Me.lbl_Four_Wheeler_dri_lic_No)
        Me.panel_legal_info.Controls.Add(Me.tb_Addhar_No)
        Me.panel_legal_info.Controls.Add(Me.lbl_Addhar_No)
        Me.panel_legal_info.Location = New System.Drawing.Point(6, 23)
        Me.panel_legal_info.Name = "panel_legal_info"
        Me.panel_legal_info.Size = New System.Drawing.Size(663, 121)
        Me.panel_legal_info.TabIndex = 0
        '
        'tb_four_wheelr_dri_lic
        '
        Me.tb_four_wheelr_dri_lic.Enabled = False
        Me.tb_four_wheelr_dri_lic.Location = New System.Drawing.Point(295, 45)
        Me.tb_four_wheelr_dri_lic.Name = "tb_four_wheelr_dri_lic"
        Me.tb_four_wheelr_dri_lic.Size = New System.Drawing.Size(305, 26)
        Me.tb_four_wheelr_dri_lic.TabIndex = 28
        '
        'lbl_Four_Wheeler_dri_lic_No
        '
        Me.lbl_Four_Wheeler_dri_lic_No.AutoSize = True
        Me.lbl_Four_Wheeler_dri_lic_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Four_Wheeler_dri_lic_No.Location = New System.Drawing.Point(28, 39)
        Me.lbl_Four_Wheeler_dri_lic_No.Name = "lbl_Four_Wheeler_dri_lic_No"
        Me.lbl_Four_Wheeler_dri_lic_No.Size = New System.Drawing.Size(149, 32)
        Me.lbl_Four_Wheeler_dri_lic_No.TabIndex = 27
        Me.lbl_Four_Wheeler_dri_lic_No.Text = "     Four Wheeler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Driving Licence No"
        '
        'tb_Addhar_No
        '
        Me.tb_Addhar_No.Location = New System.Drawing.Point(295, 10)
        Me.tb_Addhar_No.Name = "tb_Addhar_No"
        Me.tb_Addhar_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Addhar_No.TabIndex = 26
        '
        'lbl_Addhar_No
        '
        Me.lbl_Addhar_No.AutoSize = True
        Me.lbl_Addhar_No.Location = New System.Drawing.Point(56, 10)
        Me.lbl_Addhar_No.Name = "lbl_Addhar_No"
        Me.lbl_Addhar_No.Size = New System.Drawing.Size(99, 20)
        Me.lbl_Addhar_No.TabIndex = 25
        Me.lbl_Addhar_No.Text = "Addhar No."
        '
        'tb_Emp_id
        '
        Me.tb_Emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Emp_id.Location = New System.Drawing.Point(219, 81)
        Me.tb_Emp_id.Name = "tb_Emp_id"
        Me.tb_Emp_id.Size = New System.Drawing.Size(167, 24)
        Me.tb_Emp_id.TabIndex = 26
        '
        'lbl_Employee_id
        '
        Me.lbl_Employee_id.AutoSize = True
        Me.lbl_Employee_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Employee_id.Location = New System.Drawing.Point(12, 81)
        Me.lbl_Employee_id.Name = "lbl_Employee_id"
        Me.lbl_Employee_id.Size = New System.Drawing.Size(111, 20)
        Me.lbl_Employee_id.TabIndex = 25
        Me.lbl_Employee_id.Text = "Employee ID"
        '
        'gb_Employee_Details
        '
        Me.gb_Employee_Details.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Employee_Details.Controls.Add(Me.panel_other_details)
        Me.gb_Employee_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_Details.Location = New System.Drawing.Point(663, 119)
        Me.gb_Employee_Details.Name = "gb_Employee_Details"
        Me.gb_Employee_Details.Size = New System.Drawing.Size(675, 367)
        Me.gb_Employee_Details.TabIndex = 24
        Me.gb_Employee_Details.TabStop = False
        Me.gb_Employee_Details.Text = "Employee Details"
        '
        'panel_other_details
        '
        Me.panel_other_details.BackColor = System.Drawing.Color.Khaki
        Me.panel_other_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_other_details.Controls.Add(Me.tb_State)
        Me.panel_other_details.Controls.Add(Me.tb_pin_code)
        Me.panel_other_details.Controls.Add(Me.tb_City_Town_Vill)
        Me.panel_other_details.Controls.Add(Me.tb_address)
        Me.panel_other_details.Controls.Add(Me.tb_age)
        Me.panel_other_details.Controls.Add(Me.lbl_Age)
        Me.panel_other_details.Controls.Add(Me.lbl_pin_code)
        Me.panel_other_details.Controls.Add(Me.rb_Female)
        Me.panel_other_details.Controls.Add(Me.rb_Male)
        Me.panel_other_details.Controls.Add(Me.lbl_Gender)
        Me.panel_other_details.Controls.Add(Me.dtp_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_City)
        Me.panel_other_details.Controls.Add(Me.lbl_State)
        Me.panel_other_details.Controls.Add(Me.lbl_Address)
        Me.panel_other_details.Location = New System.Drawing.Point(6, 21)
        Me.panel_other_details.Name = "panel_other_details"
        Me.panel_other_details.Size = New System.Drawing.Size(663, 337)
        Me.panel_other_details.TabIndex = 0
        '
        'tb_State
        '
        Me.tb_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_State.Location = New System.Drawing.Point(295, 201)
        Me.tb_State.Name = "tb_State"
        Me.tb_State.Size = New System.Drawing.Size(305, 24)
        Me.tb_State.TabIndex = 29
        '
        'tb_pin_code
        '
        Me.tb_pin_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pin_code.Location = New System.Drawing.Point(295, 281)
        Me.tb_pin_code.Name = "tb_pin_code"
        Me.tb_pin_code.Size = New System.Drawing.Size(305, 24)
        Me.tb_pin_code.TabIndex = 28
        '
        'tb_City_Town_Vill
        '
        Me.tb_City_Town_Vill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_City_Town_Vill.Location = New System.Drawing.Point(295, 243)
        Me.tb_City_Town_Vill.Name = "tb_City_Town_Vill"
        Me.tb_City_Town_Vill.Size = New System.Drawing.Size(305, 24)
        Me.tb_City_Town_Vill.TabIndex = 27
        '
        'tb_address
        '
        Me.tb_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.Location = New System.Drawing.Point(295, 95)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(305, 72)
        Me.tb_address.TabIndex = 26
        '
        'tb_age
        '
        Me.tb_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_age.Location = New System.Drawing.Point(295, 60)
        Me.tb_age.Name = "tb_age"
        Me.tb_age.Size = New System.Drawing.Size(131, 24)
        Me.tb_age.TabIndex = 25
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(58, 60)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(36, 18)
        Me.lbl_Age.TabIndex = 21
        Me.lbl_Age.Text = "Age"
        '
        'lbl_pin_code
        '
        Me.lbl_pin_code.AutoSize = True
        Me.lbl_pin_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pin_code.Location = New System.Drawing.Point(58, 281)
        Me.lbl_pin_code.Name = "lbl_pin_code"
        Me.lbl_pin_code.Size = New System.Drawing.Size(77, 18)
        Me.lbl_pin_code.TabIndex = 13
        Me.lbl_pin_code.Text = "Pin Code"
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Location = New System.Drawing.Point(478, 312)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(86, 24)
        Me.rb_Female.TabIndex = 12
        Me.rb_Female.TabStop = True
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Location = New System.Drawing.Point(328, 312)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(65, 24)
        Me.rb_Male.TabIndex = 11
        Me.rb_Male.TabStop = True
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(56, 310)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(63, 18)
        Me.lbl_Gender.TabIndex = 10
        Me.lbl_Gender.Text = "Gender"
        '
        'dtp_DOB
        '
        Me.dtp_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DOB.Location = New System.Drawing.Point(295, 18)
        Me.dtp_DOB.Name = "dtp_DOB"
        Me.dtp_DOB.Size = New System.Drawing.Size(305, 24)
        Me.dtp_DOB.TabIndex = 9
        '
        'lbl_DOB
        '
        Me.lbl_DOB.AutoSize = True
        Me.lbl_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DOB.Location = New System.Drawing.Point(58, 16)
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(44, 18)
        Me.lbl_DOB.TabIndex = 8
        Me.lbl_DOB.Text = "DOB"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_City.Location = New System.Drawing.Point(58, 243)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(163, 18)
        Me.lbl_City.TabIndex = 6
        Me.lbl_City.Text = "City/Townhall/Village"
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_State.Location = New System.Drawing.Point(58, 206)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(47, 18)
        Me.lbl_State.TabIndex = 1
        Me.lbl_State.Text = "State"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(56, 101)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(69, 18)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'gb_Employee_contact
        '
        Me.gb_Employee_contact.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Employee_contact.Controls.Add(Me.panel_Custo_Con_Det)
        Me.gb_Employee_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_contact.Location = New System.Drawing.Point(16, 259)
        Me.gb_Employee_contact.Name = "gb_Employee_contact"
        Me.gb_Employee_contact.Size = New System.Drawing.Size(637, 125)
        Me.gb_Employee_contact.TabIndex = 23
        Me.gb_Employee_contact.TabStop = False
        Me.gb_Employee_contact.Text = "Employee Contact Deatil"
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
        Me.panel_Custo_Con_Det.Location = New System.Drawing.Point(6, 25)
        Me.panel_Custo_Con_Det.Name = "panel_Custo_Con_Det"
        Me.panel_Custo_Con_Det.Size = New System.Drawing.Size(623, 92)
        Me.panel_Custo_Con_Det.TabIndex = 0
        '
        'tb_Email_Id
        '
        Me.tb_Email_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Email_Id.Location = New System.Drawing.Point(244, 59)
        Me.tb_Email_Id.MaxLength = 50
        Me.tb_Email_Id.Name = "tb_Email_Id"
        Me.tb_Email_Id.Size = New System.Drawing.Size(305, 22)
        Me.tb_Email_Id.TabIndex = 8
        '
        'tb_Alter_Mob_No
        '
        Me.tb_Alter_Mob_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Alter_Mob_No.Location = New System.Drawing.Point(244, 31)
        Me.tb_Alter_Mob_No.MaxLength = 10
        Me.tb_Alter_Mob_No.Name = "tb_Alter_Mob_No"
        Me.tb_Alter_Mob_No.Size = New System.Drawing.Size(305, 22)
        Me.tb_Alter_Mob_No.TabIndex = 7
        '
        'tb_Mob_No
        '
        Me.tb_Mob_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Mob_No.Location = New System.Drawing.Point(244, 4)
        Me.tb_Mob_No.MaxLength = 10
        Me.tb_Mob_No.Name = "tb_Mob_No"
        Me.tb_Mob_No.Size = New System.Drawing.Size(305, 22)
        Me.tb_Mob_No.TabIndex = 6
        '
        'lbl_Alter_MO_NO
        '
        Me.lbl_Alter_MO_NO.AutoSize = True
        Me.lbl_Alter_MO_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Alter_MO_NO.Location = New System.Drawing.Point(1, 34)
        Me.lbl_Alter_MO_NO.Name = "lbl_Alter_MO_NO"
        Me.lbl_Alter_MO_NO.Size = New System.Drawing.Size(146, 16)
        Me.lbl_Alter_MO_NO.TabIndex = 2
        Me.lbl_Alter_MO_NO.Text = "Alternet Mobile No."
        '
        'lbl_Email_ID
        '
        Me.lbl_Email_ID.AutoSize = True
        Me.lbl_Email_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email_ID.Location = New System.Drawing.Point(3, 62)
        Me.lbl_Email_ID.Name = "lbl_Email_ID"
        Me.lbl_Email_ID.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Email_ID.TabIndex = 1
        Me.lbl_Email_ID.Text = "Email ID"
        '
        'lbl_Mobail_No
        '
        Me.lbl_Mobail_No.AutoSize = True
        Me.lbl_Mobail_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mobail_No.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Mobail_No.Name = "lbl_Mobail_No"
        Me.lbl_Mobail_No.Size = New System.Drawing.Size(87, 16)
        Me.lbl_Mobail_No.TabIndex = 0
        Me.lbl_Mobail_No.Text = "Mobile No."
        '
        'gb_Employee_Name
        '
        Me.gb_Employee_Name.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Employee_Name.Controls.Add(Me.panel_name)
        Me.gb_Employee_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_Name.Location = New System.Drawing.Point(16, 119)
        Me.gb_Employee_Name.Name = "gb_Employee_Name"
        Me.gb_Employee_Name.Size = New System.Drawing.Size(637, 119)
        Me.gb_Employee_Name.TabIndex = 22
        Me.gb_Employee_Name.TabStop = False
        Me.gb_Employee_Name.Text = "Employee Name"
        '
        'panel_name
        '
        Me.panel_name.BackColor = System.Drawing.Color.Khaki
        Me.panel_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_name.Controls.Add(Me.tb_first_name)
        Me.panel_name.Controls.Add(Me.lbl_Emp_Last_Nm)
        Me.panel_name.Controls.Add(Me.lbl_Emp_Middle_Nm)
        Me.panel_name.Controls.Add(Me.lbl_Emp_Name__first)
        Me.panel_name.Controls.Add(Me.tb_Last_Name)
        Me.panel_name.Controls.Add(Me.tb_Middle_Name)
        Me.panel_name.Location = New System.Drawing.Point(6, 23)
        Me.panel_name.Name = "panel_name"
        Me.panel_name.Size = New System.Drawing.Size(623, 86)
        Me.panel_name.TabIndex = 0
        '
        'tb_first_name
        '
        Me.tb_first_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_first_name.ForeColor = System.Drawing.Color.Black
        Me.tb_first_name.Location = New System.Drawing.Point(244, 3)
        Me.tb_first_name.Name = "tb_first_name"
        Me.tb_first_name.Size = New System.Drawing.Size(285, 22)
        Me.tb_first_name.TabIndex = 6
        '
        'lbl_Emp_Last_Nm
        '
        Me.lbl_Emp_Last_Nm.AutoSize = True
        Me.lbl_Emp_Last_Nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp_Last_Nm.Location = New System.Drawing.Point(37, 59)
        Me.lbl_Emp_Last_Nm.Name = "lbl_Emp_Last_Nm"
        Me.lbl_Emp_Last_Nm.Size = New System.Drawing.Size(85, 16)
        Me.lbl_Emp_Last_Nm.TabIndex = 5
        Me.lbl_Emp_Last_Nm.Text = "Last Name"
        '
        'lbl_Emp_Middle_Nm
        '
        Me.lbl_Emp_Middle_Nm.AutoSize = True
        Me.lbl_Emp_Middle_Nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp_Middle_Nm.Location = New System.Drawing.Point(37, 31)
        Me.lbl_Emp_Middle_Nm.Name = "lbl_Emp_Middle_Nm"
        Me.lbl_Emp_Middle_Nm.Size = New System.Drawing.Size(103, 16)
        Me.lbl_Emp_Middle_Nm.TabIndex = 4
        Me.lbl_Emp_Middle_Nm.Text = "Middle Name"
        '
        'lbl_Emp_Name__first
        '
        Me.lbl_Emp_Name__first.AutoSize = True
        Me.lbl_Emp_Name__first.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp_Name__first.Location = New System.Drawing.Point(37, 4)
        Me.lbl_Emp_Name__first.Name = "lbl_Emp_Name__first"
        Me.lbl_Emp_Name__first.Size = New System.Drawing.Size(86, 16)
        Me.lbl_Emp_Name__first.TabIndex = 3
        Me.lbl_Emp_Name__first.Text = "First Name"
        '
        'tb_Last_Name
        '
        Me.tb_Last_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Last_Name.Location = New System.Drawing.Point(244, 59)
        Me.tb_Last_Name.Name = "tb_Last_Name"
        Me.tb_Last_Name.Size = New System.Drawing.Size(285, 22)
        Me.tb_Last_Name.TabIndex = 2
        '
        'tb_Middle_Name
        '
        Me.tb_Middle_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Middle_Name.Location = New System.Drawing.Point(244, 31)
        Me.tb_Middle_Name.Name = "tb_Middle_Name"
        Me.tb_Middle_Name.Size = New System.Drawing.Size(285, 22)
        Me.tb_Middle_Name.TabIndex = 1
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
        Me.btn_Search.Location = New System.Drawing.Point(408, 73)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 40)
        Me.btn_Search.TabIndex = 375
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Actions_edit_clear_icon__5_
        Me.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Clear.Location = New System.Drawing.Point(1214, 669)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(118, 46)
        Me.btn_Clear.TabIndex = 374
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(16, 672)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(124, 39)
        Me.btn_Back.TabIndex = 373
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.AutoSize = True
        Me.btn_Update.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update.FlatAppearance.BorderSize = 0
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Text_Edit_icon__5_
        Me.btn_Update.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Update.Location = New System.Drawing.Point(598, 665)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(118, 46)
        Me.btn_Update.TabIndex = 372
        Me.btn_Update.Text = "Update"
        Me.btn_Update.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'gb_Emp_Post_Sal
        '
        Me.gb_Emp_Post_Sal.BackColor = System.Drawing.Color.Moccasin
        Me.gb_Emp_Post_Sal.Controls.Add(Me.panel_sal)
        Me.gb_Emp_Post_Sal.Controls.Add(Me.panel_post)
        Me.gb_Emp_Post_Sal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Emp_Post_Sal.Location = New System.Drawing.Point(12, 388)
        Me.gb_Emp_Post_Sal.Name = "gb_Emp_Post_Sal"
        Me.gb_Emp_Post_Sal.Size = New System.Drawing.Size(637, 269)
        Me.gb_Emp_Post_Sal.TabIndex = 376
        Me.gb_Emp_Post_Sal.TabStop = False
        Me.gb_Emp_Post_Sal.Text = "Employee Post && Salary"
        '
        'panel_sal
        '
        Me.panel_sal.BackColor = System.Drawing.Color.Khaki
        Me.panel_sal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_sal.Controls.Add(Me.tb_Curr_Bank_Nm)
        Me.panel_sal.Controls.Add(Me.lbl_Current_Bank_Nm)
        Me.panel_sal.Controls.Add(Me.cb_Bank_Name)
        Me.panel_sal.Controls.Add(Me.lbl_new_Bank_Name)
        Me.panel_sal.Controls.Add(Me.tb_Bank_Acc_no)
        Me.panel_sal.Controls.Add(Me.tb_emp_sal)
        Me.panel_sal.Controls.Add(Me.lbl_Salary)
        Me.panel_sal.Controls.Add(Me.lbl_Bank_Acc_no)
        Me.panel_sal.Controls.Add(Me.tb_pan_no)
        Me.panel_sal.Controls.Add(Me.BunifuCustomLabel1)
        Me.panel_sal.Location = New System.Drawing.Point(6, 94)
        Me.panel_sal.Name = "panel_sal"
        Me.panel_sal.Size = New System.Drawing.Size(623, 165)
        Me.panel_sal.TabIndex = 3
        '
        'tb_Curr_Bank_Nm
        '
        Me.tb_Curr_Bank_Nm.Enabled = False
        Me.tb_Curr_Bank_Nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Curr_Bank_Nm.Location = New System.Drawing.Point(244, 34)
        Me.tb_Curr_Bank_Nm.MaxLength = 10
        Me.tb_Curr_Bank_Nm.Name = "tb_Curr_Bank_Nm"
        Me.tb_Curr_Bank_Nm.Size = New System.Drawing.Size(305, 22)
        Me.tb_Curr_Bank_Nm.TabIndex = 27
        '
        'lbl_Current_Bank_Nm
        '
        Me.lbl_Current_Bank_Nm.AutoSize = True
        Me.lbl_Current_Bank_Nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current_Bank_Nm.Location = New System.Drawing.Point(9, 36)
        Me.lbl_Current_Bank_Nm.Name = "lbl_Current_Bank_Nm"
        Me.lbl_Current_Bank_Nm.Size = New System.Drawing.Size(147, 16)
        Me.lbl_Current_Bank_Nm.TabIndex = 28
        Me.lbl_Current_Bank_Nm.Text = "Current Bank Name"
        '
        'cb_Bank_Name
        '
        Me.cb_Bank_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Bank_Name.Enabled = False
        Me.cb_Bank_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Bank_Name.FormattingEnabled = True
        Me.cb_Bank_Name.Items.AddRange(New Object() {"ALLAHABAD BANK", "ANDHRA BANK", "BANK OF BARODA", "BANK OF INDIA", "BANK OF MAHARASHTRA", "CANARA BANK", "CENTRAL BANK OF INDIA", "CORPORATION BANK", "IDBI BANK LTD.", "IND BANK HOUSING LTD.", "INDBANK MERCHANT BANKING SERVICES LTD.", "INDIAN BANK", "INDIAN OVERSEAS BANK", "JAMMU & KASHMIR BANK LTD.,THE", "ORIENTAL BANK OF COMMERCE", "PNB GILTS LTD.", "PUNJAB & SIND BANK", "PUNJAB NATIONAL BANK", "STATE BANK OF INDIA", "SYNDICATE BANK", "UCO BANK", "UNION BANK OF INDIA", "UNITED BANK OF INDIA"})
        Me.cb_Bank_Name.Location = New System.Drawing.Point(244, 63)
        Me.cb_Bank_Name.Name = "cb_Bank_Name"
        Me.cb_Bank_Name.Size = New System.Drawing.Size(305, 24)
        Me.cb_Bank_Name.TabIndex = 26
        '
        'lbl_new_Bank_Name
        '
        Me.lbl_new_Bank_Name.AutoSize = True
        Me.lbl_new_Bank_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_Bank_Name.Location = New System.Drawing.Point(8, 69)
        Me.lbl_new_Bank_Name.Name = "lbl_new_Bank_Name"
        Me.lbl_new_Bank_Name.Size = New System.Drawing.Size(141, 16)
        Me.lbl_new_Bank_Name.TabIndex = 25
        Me.lbl_new_Bank_Name.Text = "Select Bank Name"
        '
        'tb_Bank_Acc_no
        '
        Me.tb_Bank_Acc_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Bank_Acc_no.Location = New System.Drawing.Point(244, 96)
        Me.tb_Bank_Acc_no.MaxLength = 15
        Me.tb_Bank_Acc_no.Name = "tb_Bank_Acc_no"
        Me.tb_Bank_Acc_no.Size = New System.Drawing.Size(305, 22)
        Me.tb_Bank_Acc_no.TabIndex = 2
        '
        'tb_emp_sal
        '
        Me.tb_emp_sal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emp_sal.Location = New System.Drawing.Point(244, 129)
        Me.tb_emp_sal.MaxLength = 18
        Me.tb_emp_sal.Name = "tb_emp_sal"
        Me.tb_emp_sal.Size = New System.Drawing.Size(305, 22)
        Me.tb_emp_sal.TabIndex = 3
        '
        'lbl_Salary
        '
        Me.lbl_Salary.AutoSize = True
        Me.lbl_Salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Salary.Location = New System.Drawing.Point(8, 132)
        Me.lbl_Salary.Name = "lbl_Salary"
        Me.lbl_Salary.Size = New System.Drawing.Size(130, 16)
        Me.lbl_Salary.TabIndex = 0
        Me.lbl_Salary.Text = "Employee Salary"
        '
        'lbl_Bank_Acc_no
        '
        Me.lbl_Bank_Acc_no.AutoSize = True
        Me.lbl_Bank_Acc_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bank_Acc_no.Location = New System.Drawing.Point(9, 96)
        Me.lbl_Bank_Acc_no.Name = "lbl_Bank_Acc_no"
        Me.lbl_Bank_Acc_no.Size = New System.Drawing.Size(110, 32)
        Me.lbl_Bank_Acc_no.TabIndex = 22
        Me.lbl_Bank_Acc_no.Text = "Bank Account " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      No."
        '
        'tb_pan_no
        '
        Me.tb_pan_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pan_no.Location = New System.Drawing.Point(244, 6)
        Me.tb_pan_no.MaxLength = 10
        Me.tb_pan_no.Name = "tb_pan_no"
        Me.tb_pan_no.Size = New System.Drawing.Size(305, 22)
        Me.tb_pan_no.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(8, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(98, 16)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "Pancard No."
        '
        'panel_post
        '
        Me.panel_post.BackColor = System.Drawing.Color.Khaki
        Me.panel_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_post.Controls.Add(Me.rb_Driver)
        Me.panel_post.Controls.Add(Me.rb_Receptionist)
        Me.panel_post.Controls.Add(Me.rb_Tour_Guide)
        Me.panel_post.Controls.Add(Me.rb_Cashier)
        Me.panel_post.Location = New System.Drawing.Point(6, 23)
        Me.panel_post.Name = "panel_post"
        Me.panel_post.Size = New System.Drawing.Size(623, 61)
        Me.panel_post.TabIndex = 2
        '
        'rb_Driver
        '
        Me.rb_Driver.AutoSize = True
        Me.rb_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Driver.Location = New System.Drawing.Point(361, 37)
        Me.rb_Driver.Name = "rb_Driver"
        Me.rb_Driver.Size = New System.Drawing.Size(69, 20)
        Me.rb_Driver.TabIndex = 10
        Me.rb_Driver.Text = "Driver"
        Me.rb_Driver.UseVisualStyleBackColor = True
        '
        'rb_Receptionist
        '
        Me.rb_Receptionist.AutoSize = True
        Me.rb_Receptionist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Receptionist.Location = New System.Drawing.Point(361, 5)
        Me.rb_Receptionist.Name = "rb_Receptionist"
        Me.rb_Receptionist.Size = New System.Drawing.Size(114, 20)
        Me.rb_Receptionist.TabIndex = 8
        Me.rb_Receptionist.Text = "Receptionist"
        Me.rb_Receptionist.UseVisualStyleBackColor = True
        '
        'rb_Tour_Guide
        '
        Me.rb_Tour_Guide.AutoSize = True
        Me.rb_Tour_Guide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Tour_Guide.Location = New System.Drawing.Point(101, 37)
        Me.rb_Tour_Guide.Name = "rb_Tour_Guide"
        Me.rb_Tour_Guide.Size = New System.Drawing.Size(105, 20)
        Me.rb_Tour_Guide.TabIndex = 9
        Me.rb_Tour_Guide.Text = "Tour Guide"
        Me.rb_Tour_Guide.UseVisualStyleBackColor = True
        '
        'rb_Cashier
        '
        Me.rb_Cashier.AutoSize = True
        Me.rb_Cashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Cashier.Location = New System.Drawing.Point(101, 5)
        Me.rb_Cashier.Name = "rb_Cashier"
        Me.rb_Cashier.Size = New System.Drawing.Size(81, 20)
        Me.rb_Cashier.TabIndex = 7
        Me.rb_Cashier.Text = "Cashier"
        Me.rb_Cashier.UseVisualStyleBackColor = True
        '
        'frm_Update_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.gb_Emp_Post_Sal)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.dtp_Joining_date)
        Me.Controls.Add(Me.lbl_Joining_Date)
        Me.Controls.Add(Me.gb_Legal_Info)
        Me.Controls.Add(Me.tb_Emp_id)
        Me.Controls.Add(Me.lbl_Employee_id)
        Me.Controls.Add(Me.gb_Employee_Details)
        Me.Controls.Add(Me.gb_Employee_contact)
        Me.Controls.Add(Me.gb_Employee_Name)
        Me.Controls.Add(Me.panel_Schedule_pkg)
        Me.Name = "frm_Update_Employee"
        Me.Text = "Update Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Schedule_pkg.ResumeLayout(False)
        Me.panel_Schedule_pkg.PerformLayout()
        Me.gb_Legal_Info.ResumeLayout(False)
        Me.panel_legal_info.ResumeLayout(False)
        Me.panel_legal_info.PerformLayout()
        Me.gb_Employee_Details.ResumeLayout(False)
        Me.panel_other_details.ResumeLayout(False)
        Me.panel_other_details.PerformLayout()
        Me.gb_Employee_contact.ResumeLayout(False)
        Me.panel_Custo_Con_Det.ResumeLayout(False)
        Me.panel_Custo_Con_Det.PerformLayout()
        Me.gb_Employee_Name.ResumeLayout(False)
        Me.panel_name.ResumeLayout(False)
        Me.panel_name.PerformLayout()
        Me.gb_Emp_Post_Sal.ResumeLayout(False)
        Me.panel_sal.ResumeLayout(False)
        Me.panel_sal.PerformLayout()
        Me.panel_post.ResumeLayout(False)
        Me.panel_post.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_Schedule_pkg As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Update_Employee_pkg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_Joining_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Joining_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Legal_Info As System.Windows.Forms.GroupBox
    Friend WithEvents panel_legal_info As System.Windows.Forms.Panel
    Friend WithEvents tb_four_wheelr_dri_lic As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Four_Wheeler_dri_lic_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Addhar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Addhar_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Emp_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Employee_id As System.Windows.Forms.Label
    Friend WithEvents gb_Employee_Details As System.Windows.Forms.GroupBox
    Friend WithEvents panel_other_details As System.Windows.Forms.Panel
    Friend WithEvents tb_address As System.Windows.Forms.TextBox
    Friend WithEvents tb_age As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Age As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_pin_code As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Gender As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_DOB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_City As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_State As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Address As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Employee_contact As System.Windows.Forms.GroupBox
    Friend WithEvents panel_Custo_Con_Det As System.Windows.Forms.Panel
    Friend WithEvents tb_Email_Id As System.Windows.Forms.TextBox
    Friend WithEvents tb_Alter_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents tb_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Alter_MO_NO As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Email_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Mobail_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Employee_Name As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents tb_pin_code As System.Windows.Forms.TextBox
    Friend WithEvents tb_City_Town_Vill As System.Windows.Forms.TextBox
    Friend WithEvents gb_Emp_Post_Sal As System.Windows.Forms.GroupBox
    Friend WithEvents panel_sal As System.Windows.Forms.Panel
    Friend WithEvents cb_Bank_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_new_Bank_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Bank_Acc_no As System.Windows.Forms.TextBox
    Friend WithEvents tb_emp_sal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Salary As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Bank_Acc_no As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_pan_no As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_post As System.Windows.Forms.Panel
    Friend WithEvents rb_Driver As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Receptionist As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Tour_Guide As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Cashier As System.Windows.Forms.RadioButton
    Friend WithEvents panel_name As System.Windows.Forms.Panel
    Friend WithEvents tb_first_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Emp_Last_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Emp_Middle_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Emp_Name__first As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Middle_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Curr_Bank_Nm As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Current_Bank_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_State As System.Windows.Forms.TextBox
End Class
