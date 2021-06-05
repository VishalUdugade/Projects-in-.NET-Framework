<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Add_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Add_Employee))
        Me.lbl_Add_Employee_pkg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Schedule_pkg = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.panel_Name = New System.Windows.Forms.Panel()
        Me.tb_first_name = New System.Windows.Forms.TextBox()
        Me.lbl_Emp_Last_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Emp_Middle_Nm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Emp_Name__first = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.tb_Middle_Name = New System.Windows.Forms.TextBox()
        Me.gb_Employee_Name = New System.Windows.Forms.GroupBox()
        Me.panel_Custo_Con_Det = New System.Windows.Forms.Panel()
        Me.tb_Email_Id = New System.Windows.Forms.TextBox()
        Me.tb_Alter_Mob_No = New System.Windows.Forms.TextBox()
        Me.tb_Mob_No = New System.Windows.Forms.TextBox()
        Me.lbl_Alter_MO_NO = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Email_ID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Mobail_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Employee_contact = New System.Windows.Forms.GroupBox()
        Me.panel_other_details = New System.Windows.Forms.Panel()
        Me.tb_city_town_vill = New System.Windows.Forms.TextBox()
        Me.tb_pin_code = New System.Windows.Forms.TextBox()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.tb_age = New System.Windows.Forms.TextBox()
        Me.lbl_Age = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_State = New System.Windows.Forms.ComboBox()
        Me.lbl_pin_code = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_emp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DOB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_City = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_State = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Address = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Employee_Details = New System.Windows.Forms.GroupBox()
        Me.lbl_Employee_id = New System.Windows.Forms.Label()
        Me.panel_post = New System.Windows.Forms.Panel()
        Me.rb_Driver = New System.Windows.Forms.RadioButton()
        Me.rb_Receptionist = New System.Windows.Forms.RadioButton()
        Me.rb_Tour_Guide = New System.Windows.Forms.RadioButton()
        Me.rb_Cashier = New System.Windows.Forms.RadioButton()
        Me.panel_sal = New System.Windows.Forms.Panel()
        Me.cb_Bank_Name = New System.Windows.Forms.ComboBox()
        Me.lbl_Bank_Name = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Bank_Acc_no = New System.Windows.Forms.TextBox()
        Me.tb_emp_sal = New System.Windows.Forms.TextBox()
        Me.lbl_Salary = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Bank_Acc_no = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Pan_No = New System.Windows.Forms.TextBox()
        Me.lbl_Pan_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Emp_Post_Sal = New System.Windows.Forms.GroupBox()
        Me.panel_leagel_info = New System.Windows.Forms.Panel()
        Me.tb_four_wheel_dri_lic_no = New System.Windows.Forms.TextBox()
        Me.lbl_Four_Wheeler_dri_lic_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Addhar_No = New System.Windows.Forms.TextBox()
        Me.lbl_Addhar_No = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Legal_Info = New System.Windows.Forms.GroupBox()
        Me.lbl_Joining_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_Joining_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Emp_Id = New System.Windows.Forms.Label()
        Me.panel_Schedule_pkg.SuspendLayout()
        Me.panel_Name.SuspendLayout()
        Me.gb_Employee_Name.SuspendLayout()
        Me.panel_Custo_Con_Det.SuspendLayout()
        Me.gb_Employee_contact.SuspendLayout()
        Me.panel_other_details.SuspendLayout()
        Me.gb_Employee_Details.SuspendLayout()
        Me.panel_post.SuspendLayout()
        Me.panel_sal.SuspendLayout()
        Me.gb_Emp_Post_Sal.SuspendLayout()
        Me.panel_leagel_info.SuspendLayout()
        Me.gb_Legal_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Add_Employee_pkg
        '
        Me.lbl_Add_Employee_pkg.AutoSize = True
        Me.lbl_Add_Employee_pkg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Add_Employee_pkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Add_Employee_pkg.ForeColor = System.Drawing.Color.White
        Me.lbl_Add_Employee_pkg.Location = New System.Drawing.Point(579, 16)
        Me.lbl_Add_Employee_pkg.Name = "lbl_Add_Employee_pkg"
        Me.lbl_Add_Employee_pkg.Size = New System.Drawing.Size(236, 37)
        Me.lbl_Add_Employee_pkg.TabIndex = 0
        Me.lbl_Add_Employee_pkg.Text = "Add Employee"
        '
        'panel_Schedule_pkg
        '
        Me.panel_Schedule_pkg.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.BackgroundImage = CType(resources.GetObject("panel_Schedule_pkg.BackgroundImage"), System.Drawing.Image)
        Me.panel_Schedule_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Schedule_pkg.Controls.Add(Me.lbl_Add_Employee_pkg)
        Me.panel_Schedule_pkg.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.Location = New System.Drawing.Point(1, 1)
        Me.panel_Schedule_pkg.Name = "panel_Schedule_pkg"
        Me.panel_Schedule_pkg.Quality = 10
        Me.panel_Schedule_pkg.Size = New System.Drawing.Size(1348, 66)
        Me.panel_Schedule_pkg.TabIndex = 1
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = True
        Me.btn_Save.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Save.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Save_Icon_32
        Me.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Save.Location = New System.Drawing.Point(608, 674)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(102, 43)
        Me.btn_Save.TabIndex = 101
        Me.btn_Save.Text = "Save"
        Me.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(29, 674)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(102, 43)
        Me.btn_Back.TabIndex = 102
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Clear.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Actions_edit_clear_icon__5_
        Me.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Clear.Location = New System.Drawing.Point(1216, 674)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(102, 43)
        Me.btn_Clear.TabIndex = 100
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'panel_Name
        '
        Me.panel_Name.BackColor = System.Drawing.Color.Khaki
        Me.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Name.Controls.Add(Me.tb_first_name)
        Me.panel_Name.Controls.Add(Me.lbl_Emp_Last_Nm)
        Me.panel_Name.Controls.Add(Me.lbl_Emp_Middle_Nm)
        Me.panel_Name.Controls.Add(Me.lbl_Emp_Name__first)
        Me.panel_Name.Controls.Add(Me.tb_Last_Name)
        Me.panel_Name.Controls.Add(Me.tb_Middle_Name)
        Me.panel_Name.Location = New System.Drawing.Point(6, 23)
        Me.panel_Name.Name = "panel_Name"
        Me.panel_Name.Size = New System.Drawing.Size(623, 106)
        Me.panel_Name.TabIndex = 0
        '
        'tb_first_name
        '
        Me.tb_first_name.ForeColor = System.Drawing.Color.Black
        Me.tb_first_name.Location = New System.Drawing.Point(244, 5)
        Me.tb_first_name.MaxLength = 30
        Me.tb_first_name.Name = "tb_first_name"
        Me.tb_first_name.Size = New System.Drawing.Size(305, 26)
        Me.tb_first_name.TabIndex = 1
        '
        'lbl_Emp_Last_Nm
        '
        Me.lbl_Emp_Last_Nm.AutoSize = True
        Me.lbl_Emp_Last_Nm.Location = New System.Drawing.Point(37, 72)
        Me.lbl_Emp_Last_Nm.Name = "lbl_Emp_Last_Nm"
        Me.lbl_Emp_Last_Nm.Size = New System.Drawing.Size(95, 20)
        Me.lbl_Emp_Last_Nm.TabIndex = 5
        Me.lbl_Emp_Last_Nm.Text = "Last Name"
        '
        'lbl_Emp_Middle_Nm
        '
        Me.lbl_Emp_Middle_Nm.AutoSize = True
        Me.lbl_Emp_Middle_Nm.Location = New System.Drawing.Point(37, 38)
        Me.lbl_Emp_Middle_Nm.Name = "lbl_Emp_Middle_Nm"
        Me.lbl_Emp_Middle_Nm.Size = New System.Drawing.Size(112, 20)
        Me.lbl_Emp_Middle_Nm.TabIndex = 4
        Me.lbl_Emp_Middle_Nm.Text = "Middle Name"
        '
        'lbl_Emp_Name__first
        '
        Me.lbl_Emp_Name__first.AutoSize = True
        Me.lbl_Emp_Name__first.Location = New System.Drawing.Point(37, 8)
        Me.lbl_Emp_Name__first.Name = "lbl_Emp_Name__first"
        Me.lbl_Emp_Name__first.Size = New System.Drawing.Size(96, 20)
        Me.lbl_Emp_Name__first.TabIndex = 3
        Me.lbl_Emp_Name__first.Text = "First Name"
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
        'gb_Employee_Name
        '
        Me.gb_Employee_Name.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Employee_Name.Controls.Add(Me.panel_Name)
        Me.gb_Employee_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_Name.Location = New System.Drawing.Point(16, 111)
        Me.gb_Employee_Name.Name = "gb_Employee_Name"
        Me.gb_Employee_Name.Size = New System.Drawing.Size(637, 136)
        Me.gb_Employee_Name.TabIndex = 0
        Me.gb_Employee_Name.TabStop = False
        Me.gb_Employee_Name.Text = "Employee Name"
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
        Me.panel_Custo_Con_Det.Size = New System.Drawing.Size(623, 112)
        Me.panel_Custo_Con_Det.TabIndex = 1
        '
        'tb_Email_Id
        '
        Me.tb_Email_Id.Enabled = False
        Me.tb_Email_Id.Location = New System.Drawing.Point(244, 72)
        Me.tb_Email_Id.MaxLength = 30
        Me.tb_Email_Id.Name = "tb_Email_Id"
        Me.tb_Email_Id.Size = New System.Drawing.Size(305, 26)
        Me.tb_Email_Id.TabIndex = 6
        '
        'tb_Alter_Mob_No
        '
        Me.tb_Alter_Mob_No.Enabled = False
        Me.tb_Alter_Mob_No.Location = New System.Drawing.Point(244, 40)
        Me.tb_Alter_Mob_No.MaxLength = 10
        Me.tb_Alter_Mob_No.Name = "tb_Alter_Mob_No"
        Me.tb_Alter_Mob_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Alter_Mob_No.TabIndex = 5
        '
        'tb_Mob_No
        '
        Me.tb_Mob_No.Enabled = False
        Me.tb_Mob_No.Location = New System.Drawing.Point(244, 5)
        Me.tb_Mob_No.MaxLength = 10
        Me.tb_Mob_No.Name = "tb_Mob_No"
        Me.tb_Mob_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Mob_No.TabIndex = 4
        '
        'lbl_Alter_MO_NO
        '
        Me.lbl_Alter_MO_NO.AutoSize = True
        Me.lbl_Alter_MO_NO.Location = New System.Drawing.Point(1, 46)
        Me.lbl_Alter_MO_NO.Name = "lbl_Alter_MO_NO"
        Me.lbl_Alter_MO_NO.Size = New System.Drawing.Size(162, 20)
        Me.lbl_Alter_MO_NO.TabIndex = 2
        Me.lbl_Alter_MO_NO.Text = "Alternet Mobile No."
        '
        'lbl_Email_ID
        '
        Me.lbl_Email_ID.AutoSize = True
        Me.lbl_Email_ID.Location = New System.Drawing.Point(3, 81)
        Me.lbl_Email_ID.Name = "lbl_Email_ID"
        Me.lbl_Email_ID.Size = New System.Drawing.Size(77, 20)
        Me.lbl_Email_ID.TabIndex = 1
        Me.lbl_Email_ID.Text = "Email ID"
        '
        'lbl_Mobail_No
        '
        Me.lbl_Mobail_No.AutoSize = True
        Me.lbl_Mobail_No.Location = New System.Drawing.Point(3, 11)
        Me.lbl_Mobail_No.Name = "lbl_Mobail_No"
        Me.lbl_Mobail_No.Size = New System.Drawing.Size(93, 20)
        Me.lbl_Mobail_No.TabIndex = 0
        Me.lbl_Mobail_No.Text = "Mobile No."
        '
        'gb_Employee_contact
        '
        Me.gb_Employee_contact.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Employee_contact.Controls.Add(Me.panel_Custo_Con_Det)
        Me.gb_Employee_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_contact.Location = New System.Drawing.Point(16, 253)
        Me.gb_Employee_contact.Name = "gb_Employee_contact"
        Me.gb_Employee_contact.Size = New System.Drawing.Size(637, 143)
        Me.gb_Employee_contact.TabIndex = 1
        Me.gb_Employee_contact.TabStop = False
        Me.gb_Employee_contact.Text = "Employee Contact Deatil"
        '
        'panel_other_details
        '
        Me.panel_other_details.BackColor = System.Drawing.Color.Khaki
        Me.panel_other_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_other_details.Controls.Add(Me.tb_city_town_vill)
        Me.panel_other_details.Controls.Add(Me.tb_pin_code)
        Me.panel_other_details.Controls.Add(Me.tb_address)
        Me.panel_other_details.Controls.Add(Me.tb_age)
        Me.panel_other_details.Controls.Add(Me.lbl_Age)
        Me.panel_other_details.Controls.Add(Me.cb_State)
        Me.panel_other_details.Controls.Add(Me.lbl_pin_code)
        Me.panel_other_details.Controls.Add(Me.rb_Female)
        Me.panel_other_details.Controls.Add(Me.rb_Male)
        Me.panel_other_details.Controls.Add(Me.lbl_Gender)
        Me.panel_other_details.Controls.Add(Me.dtp_emp_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_DOB)
        Me.panel_other_details.Controls.Add(Me.lbl_City)
        Me.panel_other_details.Controls.Add(Me.lbl_State)
        Me.panel_other_details.Controls.Add(Me.lbl_Address)
        Me.panel_other_details.Location = New System.Drawing.Point(6, 21)
        Me.panel_other_details.Name = "panel_other_details"
        Me.panel_other_details.Size = New System.Drawing.Size(663, 337)
        Me.panel_other_details.TabIndex = 4
        '
        'tb_city_town_vill
        '
        Me.tb_city_town_vill.Enabled = False
        Me.tb_city_town_vill.Location = New System.Drawing.Point(295, 218)
        Me.tb_city_town_vill.MaxLength = 20
        Me.tb_city_town_vill.Name = "tb_city_town_vill"
        Me.tb_city_town_vill.Size = New System.Drawing.Size(305, 26)
        Me.tb_city_town_vill.TabIndex = 5
        '
        'tb_pin_code
        '
        Me.tb_pin_code.Enabled = False
        Me.tb_pin_code.Location = New System.Drawing.Point(295, 261)
        Me.tb_pin_code.MaxLength = 6
        Me.tb_pin_code.Name = "tb_pin_code"
        Me.tb_pin_code.Size = New System.Drawing.Size(305, 26)
        Me.tb_pin_code.TabIndex = 6
        '
        'tb_address
        '
        Me.tb_address.Enabled = False
        Me.tb_address.Location = New System.Drawing.Point(295, 95)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(305, 72)
        Me.tb_address.TabIndex = 3
        '
        'tb_age
        '
        Me.tb_age.Enabled = False
        Me.tb_age.Location = New System.Drawing.Point(295, 60)
        Me.tb_age.Name = "tb_age"
        Me.tb_age.Size = New System.Drawing.Size(131, 26)
        Me.tb_age.TabIndex = 2
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Location = New System.Drawing.Point(58, 60)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(41, 20)
        Me.lbl_Age.TabIndex = 21
        Me.lbl_Age.Text = "Age"
        '
        'cb_State
        '
        Me.cb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_State.FormattingEnabled = True
        Me.cb_State.Items.AddRange(New Object() {"Maharashtra"})
        Me.cb_State.Location = New System.Drawing.Point(295, 179)
        Me.cb_State.Name = "cb_State"
        Me.cb_State.Size = New System.Drawing.Size(305, 28)
        Me.cb_State.TabIndex = 4
        '
        'lbl_pin_code
        '
        Me.lbl_pin_code.AutoSize = True
        Me.lbl_pin_code.Location = New System.Drawing.Point(58, 272)
        Me.lbl_pin_code.Name = "lbl_pin_code"
        Me.lbl_pin_code.Size = New System.Drawing.Size(81, 20)
        Me.lbl_pin_code.TabIndex = 13
        Me.lbl_pin_code.Text = "Pin Code"
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Enabled = False
        Me.rb_Female.Location = New System.Drawing.Point(478, 305)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(86, 24)
        Me.rb_Female.TabIndex = 8
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Enabled = False
        Me.rb_Male.Location = New System.Drawing.Point(328, 305)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(65, 24)
        Me.rb_Male.TabIndex = 7
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Location = New System.Drawing.Point(56, 307)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(69, 20)
        Me.lbl_Gender.TabIndex = 10
        Me.lbl_Gender.Text = "Gender"
        '
        'dtp_emp_DOB
        '
        Me.dtp_emp_DOB.Checked = False
        Me.dtp_emp_DOB.Enabled = False
        Me.dtp_emp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_emp_DOB.Location = New System.Drawing.Point(295, 18)
        Me.dtp_emp_DOB.Name = "dtp_emp_DOB"
        Me.dtp_emp_DOB.Size = New System.Drawing.Size(305, 26)
        Me.dtp_emp_DOB.TabIndex = 1
        Me.dtp_emp_DOB.Value = New Date(2019, 12, 9, 0, 0, 0, 0)
        '
        'lbl_DOB
        '
        Me.lbl_DOB.AutoSize = True
        Me.lbl_DOB.Location = New System.Drawing.Point(58, 16)
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(47, 20)
        Me.lbl_DOB.TabIndex = 8
        Me.lbl_DOB.Text = "DOB"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.Location = New System.Drawing.Point(58, 224)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(173, 20)
        Me.lbl_City.TabIndex = 6
        Me.lbl_City.Text = "City/Townhall/Village"
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Location = New System.Drawing.Point(58, 179)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(53, 20)
        Me.lbl_State.TabIndex = 1
        Me.lbl_State.Text = "State"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Location = New System.Drawing.Point(56, 101)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'gb_Employee_Details
        '
        Me.gb_Employee_Details.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Employee_Details.Controls.Add(Me.panel_other_details)
        Me.gb_Employee_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Employee_Details.Location = New System.Drawing.Point(663, 111)
        Me.gb_Employee_Details.Name = "gb_Employee_Details"
        Me.gb_Employee_Details.Size = New System.Drawing.Size(675, 370)
        Me.gb_Employee_Details.TabIndex = 3
        Me.gb_Employee_Details.TabStop = False
        Me.gb_Employee_Details.Text = "Employee Details"
        '
        'lbl_Employee_id
        '
        Me.lbl_Employee_id.AutoSize = True
        Me.lbl_Employee_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Employee_id.Location = New System.Drawing.Point(12, 75)
        Me.lbl_Employee_id.Name = "lbl_Employee_id"
        Me.lbl_Employee_id.Size = New System.Drawing.Size(111, 20)
        Me.lbl_Employee_id.TabIndex = 24
        Me.lbl_Employee_id.Text = "Employee ID"
        '
        'panel_post
        '
        Me.panel_post.BackColor = System.Drawing.Color.Khaki
        Me.panel_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_post.Controls.Add(Me.rb_Driver)
        Me.panel_post.Controls.Add(Me.rb_Receptionist)
        Me.panel_post.Controls.Add(Me.rb_Tour_Guide)
        Me.panel_post.Controls.Add(Me.rb_Cashier)
        Me.panel_post.Enabled = False
        Me.panel_post.Location = New System.Drawing.Point(6, 23)
        Me.panel_post.Name = "panel_post"
        Me.panel_post.Size = New System.Drawing.Size(623, 69)
        Me.panel_post.TabIndex = 2
        '
        'rb_Driver
        '
        Me.rb_Driver.AutoSize = True
        Me.rb_Driver.Location = New System.Drawing.Point(361, 37)
        Me.rb_Driver.Name = "rb_Driver"
        Me.rb_Driver.Size = New System.Drawing.Size(74, 24)
        Me.rb_Driver.TabIndex = 10
        Me.rb_Driver.Text = "Driver"
        Me.rb_Driver.UseVisualStyleBackColor = True
        '
        'rb_Receptionist
        '
        Me.rb_Receptionist.AutoSize = True
        Me.rb_Receptionist.Location = New System.Drawing.Point(361, 5)
        Me.rb_Receptionist.Name = "rb_Receptionist"
        Me.rb_Receptionist.Size = New System.Drawing.Size(128, 24)
        Me.rb_Receptionist.TabIndex = 8
        Me.rb_Receptionist.Text = "Receptionist"
        Me.rb_Receptionist.UseVisualStyleBackColor = True
        '
        'rb_Tour_Guide
        '
        Me.rb_Tour_Guide.AutoSize = True
        Me.rb_Tour_Guide.Location = New System.Drawing.Point(101, 37)
        Me.rb_Tour_Guide.Name = "rb_Tour_Guide"
        Me.rb_Tour_Guide.Size = New System.Drawing.Size(116, 24)
        Me.rb_Tour_Guide.TabIndex = 9
        Me.rb_Tour_Guide.Text = "Tour Guide"
        Me.rb_Tour_Guide.UseVisualStyleBackColor = True
        '
        'rb_Cashier
        '
        Me.rb_Cashier.AutoSize = True
        Me.rb_Cashier.Location = New System.Drawing.Point(101, 5)
        Me.rb_Cashier.Name = "rb_Cashier"
        Me.rb_Cashier.Size = New System.Drawing.Size(88, 24)
        Me.rb_Cashier.TabIndex = 7
        Me.rb_Cashier.Text = "Cashier"
        Me.rb_Cashier.UseVisualStyleBackColor = True
        '
        'panel_sal
        '
        Me.panel_sal.BackColor = System.Drawing.Color.Khaki
        Me.panel_sal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_sal.Controls.Add(Me.cb_Bank_Name)
        Me.panel_sal.Controls.Add(Me.lbl_Bank_Name)
        Me.panel_sal.Controls.Add(Me.tb_Bank_Acc_no)
        Me.panel_sal.Controls.Add(Me.tb_emp_sal)
        Me.panel_sal.Controls.Add(Me.lbl_Salary)
        Me.panel_sal.Controls.Add(Me.lbl_Bank_Acc_no)
        Me.panel_sal.Controls.Add(Me.tb_Pan_No)
        Me.panel_sal.Controls.Add(Me.lbl_Pan_No)
        Me.panel_sal.Location = New System.Drawing.Point(6, 98)
        Me.panel_sal.Name = "panel_sal"
        Me.panel_sal.Size = New System.Drawing.Size(623, 147)
        Me.panel_sal.TabIndex = 3
        '
        'cb_Bank_Name
        '
        Me.cb_Bank_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Bank_Name.FormattingEnabled = True
        Me.cb_Bank_Name.Items.AddRange(New Object() {"ALLAHABAD BANK", "ANDHRA BANK", "BANK OF BARODA", "BANK OF INDIA", "BANK OF MAHARASHTRA", "CANARA BANK", "CENTRAL BANK OF INDIA", "CORPORATION BANK", "IDBI BANK LTD.", "IND BANK HOUSING LTD.", "INDBANK MERCHANT BANKING SERVICES LTD.", "INDIAN BANK", "INDIAN OVERSEAS BANK", "JAMMU & KASHMIR BANK LTD.,THE", "ORIENTAL BANK OF COMMERCE", "PNB GILTS LTD.", "PUNJAB & SIND BANK", "PUNJAB NATIONAL BANK", "STATE BANK OF INDIA", "SYNDICATE BANK", "UCO BANK", "UNION BANK OF INDIA", "UNITED BANK OF INDIA"})
        Me.cb_Bank_Name.Location = New System.Drawing.Point(244, 39)
        Me.cb_Bank_Name.Name = "cb_Bank_Name"
        Me.cb_Bank_Name.Size = New System.Drawing.Size(305, 28)
        Me.cb_Bank_Name.TabIndex = 26
        '
        'lbl_Bank_Name
        '
        Me.lbl_Bank_Name.AutoSize = True
        Me.lbl_Bank_Name.Location = New System.Drawing.Point(8, 45)
        Me.lbl_Bank_Name.Name = "lbl_Bank_Name"
        Me.lbl_Bank_Name.Size = New System.Drawing.Size(101, 20)
        Me.lbl_Bank_Name.TabIndex = 25
        Me.lbl_Bank_Name.Text = "Bank Name"
        '
        'tb_Bank_Acc_no
        '
        Me.tb_Bank_Acc_no.Enabled = False
        Me.tb_Bank_Acc_no.Location = New System.Drawing.Point(244, 77)
        Me.tb_Bank_Acc_no.MaxLength = 15
        Me.tb_Bank_Acc_no.Name = "tb_Bank_Acc_no"
        Me.tb_Bank_Acc_no.Size = New System.Drawing.Size(305, 26)
        Me.tb_Bank_Acc_no.TabIndex = 2
        '
        'tb_emp_sal
        '
        Me.tb_emp_sal.Enabled = False
        Me.tb_emp_sal.Location = New System.Drawing.Point(244, 110)
        Me.tb_emp_sal.MaxLength = 18
        Me.tb_emp_sal.Name = "tb_emp_sal"
        Me.tb_emp_sal.Size = New System.Drawing.Size(305, 26)
        Me.tb_emp_sal.TabIndex = 3
        '
        'lbl_Salary
        '
        Me.lbl_Salary.AutoSize = True
        Me.lbl_Salary.Location = New System.Drawing.Point(8, 113)
        Me.lbl_Salary.Name = "lbl_Salary"
        Me.lbl_Salary.Size = New System.Drawing.Size(142, 20)
        Me.lbl_Salary.TabIndex = 0
        Me.lbl_Salary.Text = "Employee Salary"
        '
        'lbl_Bank_Acc_no
        '
        Me.lbl_Bank_Acc_no.AutoSize = True
        Me.lbl_Bank_Acc_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bank_Acc_no.Location = New System.Drawing.Point(9, 77)
        Me.lbl_Bank_Acc_no.Name = "lbl_Bank_Acc_no"
        Me.lbl_Bank_Acc_no.Size = New System.Drawing.Size(106, 32)
        Me.lbl_Bank_Acc_no.TabIndex = 22
        Me.lbl_Bank_Acc_no.Text = "Bank Account " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      No."
        '
        'tb_Pan_No
        '
        Me.tb_Pan_No.Enabled = False
        Me.tb_Pan_No.Location = New System.Drawing.Point(244, 6)
        Me.tb_Pan_No.MaxLength = 10
        Me.tb_Pan_No.Name = "tb_Pan_No"
        Me.tb_Pan_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Pan_No.TabIndex = 1
        '
        'lbl_Pan_No
        '
        Me.lbl_Pan_No.AutoSize = True
        Me.lbl_Pan_No.Location = New System.Drawing.Point(8, 8)
        Me.lbl_Pan_No.Name = "lbl_Pan_No"
        Me.lbl_Pan_No.Size = New System.Drawing.Size(107, 20)
        Me.lbl_Pan_No.TabIndex = 20
        Me.lbl_Pan_No.Text = "Pancard No."
        '
        'gb_Emp_Post_Sal
        '
        Me.gb_Emp_Post_Sal.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Emp_Post_Sal.Controls.Add(Me.panel_sal)
        Me.gb_Emp_Post_Sal.Controls.Add(Me.panel_post)
        Me.gb_Emp_Post_Sal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Emp_Post_Sal.Location = New System.Drawing.Point(16, 402)
        Me.gb_Emp_Post_Sal.Name = "gb_Emp_Post_Sal"
        Me.gb_Emp_Post_Sal.Size = New System.Drawing.Size(637, 253)
        Me.gb_Emp_Post_Sal.TabIndex = 2
        Me.gb_Emp_Post_Sal.TabStop = False
        Me.gb_Emp_Post_Sal.Text = "Employee Post && Salary"
        '
        'panel_leagel_info
        '
        Me.panel_leagel_info.BackColor = System.Drawing.Color.Khaki
        Me.panel_leagel_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_leagel_info.Controls.Add(Me.tb_four_wheel_dri_lic_no)
        Me.panel_leagel_info.Controls.Add(Me.lbl_Four_Wheeler_dri_lic_No)
        Me.panel_leagel_info.Controls.Add(Me.tb_Addhar_No)
        Me.panel_leagel_info.Controls.Add(Me.lbl_Addhar_No)
        Me.panel_leagel_info.Location = New System.Drawing.Point(6, 23)
        Me.panel_leagel_info.Name = "panel_leagel_info"
        Me.panel_leagel_info.Size = New System.Drawing.Size(663, 131)
        Me.panel_leagel_info.TabIndex = 5
        '
        'tb_four_wheel_dri_lic_no
        '
        Me.tb_four_wheel_dri_lic_no.Enabled = False
        Me.tb_four_wheel_dri_lic_no.Location = New System.Drawing.Point(295, 73)
        Me.tb_four_wheel_dri_lic_no.MaxLength = 16
        Me.tb_four_wheel_dri_lic_no.Name = "tb_four_wheel_dri_lic_no"
        Me.tb_four_wheel_dri_lic_no.Size = New System.Drawing.Size(305, 26)
        Me.tb_four_wheel_dri_lic_no.TabIndex = 2
        '
        'lbl_Four_Wheeler_dri_lic_No
        '
        Me.lbl_Four_Wheeler_dri_lic_No.AutoSize = True
        Me.lbl_Four_Wheeler_dri_lic_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Four_Wheeler_dri_lic_No.Location = New System.Drawing.Point(28, 67)
        Me.lbl_Four_Wheeler_dri_lic_No.Name = "lbl_Four_Wheeler_dri_lic_No"
        Me.lbl_Four_Wheeler_dri_lic_No.Size = New System.Drawing.Size(143, 32)
        Me.lbl_Four_Wheeler_dri_lic_No.TabIndex = 27
        Me.lbl_Four_Wheeler_dri_lic_No.Text = "     Four Wheeler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Driving Licence No"
        '
        'tb_Addhar_No
        '
        Me.tb_Addhar_No.Enabled = False
        Me.tb_Addhar_No.Location = New System.Drawing.Point(295, 23)
        Me.tb_Addhar_No.MaxLength = 12
        Me.tb_Addhar_No.Name = "tb_Addhar_No"
        Me.tb_Addhar_No.Size = New System.Drawing.Size(305, 26)
        Me.tb_Addhar_No.TabIndex = 1
        '
        'lbl_Addhar_No
        '
        Me.lbl_Addhar_No.AutoSize = True
        Me.lbl_Addhar_No.Location = New System.Drawing.Point(58, 23)
        Me.lbl_Addhar_No.Name = "lbl_Addhar_No"
        Me.lbl_Addhar_No.Size = New System.Drawing.Size(99, 20)
        Me.lbl_Addhar_No.TabIndex = 25
        Me.lbl_Addhar_No.Text = "Addhar No."
        '
        'gb_Legal_Info
        '
        Me.gb_Legal_Info.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Legal_Info.Controls.Add(Me.panel_leagel_info)
        Me.gb_Legal_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Legal_Info.Location = New System.Drawing.Point(663, 493)
        Me.gb_Legal_Info.Name = "gb_Legal_Info"
        Me.gb_Legal_Info.Size = New System.Drawing.Size(675, 160)
        Me.gb_Legal_Info.TabIndex = 4
        Me.gb_Legal_Info.TabStop = False
        Me.gb_Legal_Info.Text = "Legal Information"
        '
        'lbl_Joining_Date
        '
        Me.lbl_Joining_Date.AutoSize = True
        Me.lbl_Joining_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joining_Date.Location = New System.Drawing.Point(666, 75)
        Me.lbl_Joining_Date.Name = "lbl_Joining_Date"
        Me.lbl_Joining_Date.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Joining_Date.TabIndex = 27
        Me.lbl_Joining_Date.Text = "Joining Date"
        '
        'dtp_Joining_date
        '
        Me.dtp_Joining_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Joining_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Joining_date.Location = New System.Drawing.Point(810, 74)
        Me.dtp_Joining_date.Name = "dtp_Joining_date"
        Me.dtp_Joining_date.Size = New System.Drawing.Size(145, 22)
        Me.dtp_Joining_date.TabIndex = 450
        '
        'lbl_Emp_Id
        '
        Me.lbl_Emp_Id.BackColor = System.Drawing.Color.White
        Me.lbl_Emp_Id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Emp_Id.Enabled = False
        Me.lbl_Emp_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp_Id.ForeColor = System.Drawing.Color.Black
        Me.lbl_Emp_Id.Location = New System.Drawing.Point(202, 75)
        Me.lbl_Emp_Id.Name = "lbl_Emp_Id"
        Me.lbl_Emp_Id.Size = New System.Drawing.Size(100, 23)
        Me.lbl_Emp_Id.TabIndex = 29
        '
        'frm_Add_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.lbl_Emp_Id)
        Me.Controls.Add(Me.dtp_Joining_date)
        Me.Controls.Add(Me.lbl_Joining_Date)
        Me.Controls.Add(Me.gb_Legal_Info)
        Me.Controls.Add(Me.gb_Emp_Post_Sal)
        Me.Controls.Add(Me.lbl_Employee_id)
        Me.Controls.Add(Me.gb_Employee_Details)
        Me.Controls.Add(Me.gb_Employee_contact)
        Me.Controls.Add(Me.gb_Employee_Name)
        Me.Controls.Add(Me.panel_Schedule_pkg)
        Me.Name = "frm_Add_Employee"
        Me.Text = "Add Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Schedule_pkg.ResumeLayout(False)
        Me.panel_Schedule_pkg.PerformLayout()
        Me.panel_Name.ResumeLayout(False)
        Me.panel_Name.PerformLayout()
        Me.gb_Employee_Name.ResumeLayout(False)
        Me.panel_Custo_Con_Det.ResumeLayout(False)
        Me.panel_Custo_Con_Det.PerformLayout()
        Me.gb_Employee_contact.ResumeLayout(False)
        Me.panel_other_details.ResumeLayout(False)
        Me.panel_other_details.PerformLayout()
        Me.gb_Employee_Details.ResumeLayout(False)
        Me.panel_post.ResumeLayout(False)
        Me.panel_post.PerformLayout()
        Me.panel_sal.ResumeLayout(False)
        Me.panel_sal.PerformLayout()
        Me.gb_Emp_Post_Sal.ResumeLayout(False)
        Me.panel_leagel_info.ResumeLayout(False)
        Me.panel_leagel_info.PerformLayout()
        Me.gb_Legal_Info.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Add_Employee_pkg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_Schedule_pkg As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents panel_Name As System.Windows.Forms.Panel
    Friend WithEvents tb_first_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Emp_Last_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Emp_Middle_Nm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Emp_Name__first As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_Middle_Name As System.Windows.Forms.TextBox
    Friend WithEvents gb_Employee_Name As System.Windows.Forms.GroupBox
    Friend WithEvents panel_Custo_Con_Det As System.Windows.Forms.Panel
    Friend WithEvents tb_Email_Id As System.Windows.Forms.TextBox
    Friend WithEvents tb_Alter_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents tb_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Alter_MO_NO As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Email_ID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Mobail_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Employee_contact As System.Windows.Forms.GroupBox
    Friend WithEvents panel_other_details As System.Windows.Forms.Panel
    Friend WithEvents tb_city_town_vill As System.Windows.Forms.TextBox
    Friend WithEvents tb_pin_code As System.Windows.Forms.TextBox
    Friend WithEvents tb_address As System.Windows.Forms.TextBox
    Friend WithEvents tb_age As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Age As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cb_State As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_pin_code As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Gender As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_emp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_DOB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_City As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_State As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Address As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Employee_Details As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Employee_id As System.Windows.Forms.Label
    Friend WithEvents panel_post As System.Windows.Forms.Panel
    Friend WithEvents rb_Driver As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Receptionist As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Tour_Guide As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Cashier As System.Windows.Forms.RadioButton
    Friend WithEvents panel_sal As System.Windows.Forms.Panel
    Friend WithEvents cb_Bank_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Bank_Name As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Bank_Acc_no As System.Windows.Forms.TextBox
    Friend WithEvents tb_emp_sal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Salary As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Bank_Acc_no As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Pan_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Pan_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Emp_Post_Sal As System.Windows.Forms.GroupBox
    Friend WithEvents panel_leagel_info As System.Windows.Forms.Panel
    Friend WithEvents tb_four_wheel_dri_lic_no As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Four_Wheeler_dri_lic_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Addhar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Addhar_No As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Legal_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Joining_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_Joining_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Emp_Id As System.Windows.Forms.Label
End Class
