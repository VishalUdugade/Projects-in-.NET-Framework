<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_update_tour
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
        Me.tb_tour_id = New System.Windows.Forms.TextBox()
        Me.lbl_tour_id = New System.Windows.Forms.Label()
        Me.btn_UPsearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_ext_mode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rb_non_sleeper_travel = New System.Windows.Forms.RadioButton()
        Me.rb_sleeper_travel = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_total_price = New System.Windows.Forms.TextBox()
        Me.tb_child_price = New System.Windows.Forms.TextBox()
        Me.tb_adl_price = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_UParrival_time = New System.Windows.Forms.DateTimePicker()
        Me.dtp_UPdeparture_time = New System.Windows.Forms.DateTimePicker()
        Me.tb_destina = New System.Windows.Forms.TextBox()
        Me.tb_source = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.tb_route = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_route = New System.Windows.Forms.Label()
        Me.tb_distance = New System.Windows.Forms.TextBox()
        Me.lbl_distance = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_remove_days = New System.Windows.Forms.Button()
        Me.lb_travels_Nm = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clb_travel_days = New System.Windows.Forms.CheckedListBox()
        Me.lbl_travel_days = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_tour_id
        '
        Me.tb_tour_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tour_id.Location = New System.Drawing.Point(189, 20)
        Me.tb_tour_id.Name = "tb_tour_id"
        Me.tb_tour_id.Size = New System.Drawing.Size(327, 34)
        Me.tb_tour_id.TabIndex = 46
        '
        'lbl_tour_id
        '
        Me.lbl_tour_id.AutoSize = True
        Me.lbl_tour_id.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_id.Location = New System.Drawing.Point(63, 21)
        Me.lbl_tour_id.Name = "lbl_tour_id"
        Me.lbl_tour_id.Size = New System.Drawing.Size(105, 31)
        Me.lbl_tour_id.TabIndex = 19
        Me.lbl_tour_id.Text = "Tour ID"
        '
        'btn_UPsearch
        '
        Me.btn_UPsearch.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_UPsearch.Font = New System.Drawing.Font("Rockwell", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UPsearch.ForeColor = System.Drawing.Color.Azure
        Me.btn_UPsearch.Location = New System.Drawing.Point(527, 8)
        Me.btn_UPsearch.Name = "btn_UPsearch"
        Me.btn_UPsearch.Size = New System.Drawing.Size(177, 51)
        Me.btn_UPsearch.TabIndex = 58
        Me.btn_UPsearch.Text = "Search"
        Me.btn_UPsearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(93, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1650, 124)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transport"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.tb_ext_mode)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.rb_non_sleeper_travel)
        Me.Panel2.Controls.Add(Me.rb_sleeper_travel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(865, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 97)
        Me.Panel2.TabIndex = 49
        '
        'tb_ext_mode
        '
        Me.tb_ext_mode.Enabled = False
        Me.tb_ext_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ext_mode.Location = New System.Drawing.Point(229, 7)
        Me.tb_ext_mode.Name = "tb_ext_mode"
        Me.tb_ext_mode.Size = New System.Drawing.Size(429, 34)
        Me.tb_ext_mode.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 31)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Existing Mode"
        '
        'rb_non_sleeper_travel
        '
        Me.rb_non_sleeper_travel.AutoSize = True
        Me.rb_non_sleeper_travel.Enabled = False
        Me.rb_non_sleeper_travel.Location = New System.Drawing.Point(434, 57)
        Me.rb_non_sleeper_travel.Name = "rb_non_sleeper_travel"
        Me.rb_non_sleeper_travel.Size = New System.Drawing.Size(234, 29)
        Me.rb_non_sleeper_travel.TabIndex = 48
        Me.rb_non_sleeper_travel.TabStop = True
        Me.rb_non_sleeper_travel.Text = "Travel Non-Sleeper"
        Me.rb_non_sleeper_travel.UseVisualStyleBackColor = True
        '
        'rb_sleeper_travel
        '
        Me.rb_sleeper_travel.AutoSize = True
        Me.rb_sleeper_travel.Enabled = False
        Me.rb_sleeper_travel.Location = New System.Drawing.Point(123, 55)
        Me.rb_sleeper_travel.Name = "rb_sleeper_travel"
        Me.rb_sleeper_travel.Size = New System.Drawing.Size(276, 29)
        Me.rb_sleeper_travel.TabIndex = 11
        Me.rb_sleeper_travel.TabStop = True
        Me.rb_sleeper_travel.Text = "Travel Sleeper With AC"
        Me.rb_sleeper_travel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Mode"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btn_UPsearch)
        Me.Panel3.Controls.Add(Me.tb_tour_id)
        Me.Panel3.Controls.Add(Me.lbl_tour_id)
        Me.Panel3.Location = New System.Drawing.Point(100, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(721, 71)
        Me.Panel3.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(947, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 31)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Arrival TIme"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.dtp_UParrival_time)
        Me.Panel4.Controls.Add(Me.dtp_UPdeparture_time)
        Me.Panel4.Controls.Add(Me.tb_destina)
        Me.Panel4.Controls.Add(Me.tb_source)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lbl_to)
        Me.Panel4.Controls.Add(Me.lbl_from)
        Me.Panel4.Location = New System.Drawing.Point(93, 366)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1650, 270)
        Me.Panel4.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.tb_total_price)
        Me.GroupBox2.Controls.Add(Me.tb_child_price)
        Me.GroupBox2.Controls.Add(Me.tb_adl_price)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(200, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1190, 100)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'tb_total_price
        '
        Me.tb_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_price.Location = New System.Drawing.Point(934, 42)
        Me.tb_total_price.Name = "tb_total_price"
        Me.tb_total_price.Size = New System.Drawing.Size(190, 34)
        Me.tb_total_price.TabIndex = 50
        '
        'tb_child_price
        '
        Me.tb_child_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_child_price.Location = New System.Drawing.Point(604, 42)
        Me.tb_child_price.Name = "tb_child_price"
        Me.tb_child_price.Size = New System.Drawing.Size(190, 34)
        Me.tb_child_price.TabIndex = 49
        '
        'tb_adl_price
        '
        Me.tb_adl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_adl_price.Location = New System.Drawing.Point(221, 43)
        Me.tb_adl_price.Name = "tb_adl_price"
        Me.tb_adl_price.Size = New System.Drawing.Size(190, 34)
        Me.tb_adl_price.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(831, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 31)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Child Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Adults Price"
        '
        'dtp_UParrival_time
        '
        Me.dtp_UParrival_time.Enabled = False
        Me.dtp_UParrival_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_UParrival_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_UParrival_time.Location = New System.Drawing.Point(1184, 95)
        Me.dtp_UParrival_time.Name = "dtp_UParrival_time"
        Me.dtp_UParrival_time.Size = New System.Drawing.Size(327, 34)
        Me.dtp_UParrival_time.TabIndex = 50
        '
        'dtp_UPdeparture_time
        '
        Me.dtp_UPdeparture_time.Enabled = False
        Me.dtp_UPdeparture_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_UPdeparture_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_UPdeparture_time.Location = New System.Drawing.Point(399, 95)
        Me.dtp_UPdeparture_time.Name = "dtp_UPdeparture_time"
        Me.dtp_UPdeparture_time.Size = New System.Drawing.Size(327, 34)
        Me.dtp_UPdeparture_time.TabIndex = 49
        '
        'tb_destina
        '
        Me.tb_destina.Enabled = False
        Me.tb_destina.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destina.Location = New System.Drawing.Point(1184, 23)
        Me.tb_destina.Name = "tb_destina"
        Me.tb_destina.Size = New System.Drawing.Size(327, 34)
        Me.tb_destina.TabIndex = 48
        '
        'tb_source
        '
        Me.tb_source.Enabled = False
        Me.tb_source.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_source.Location = New System.Drawing.Point(399, 23)
        Me.tb_source.Name = "tb_source"
        Me.tb_source.Size = New System.Drawing.Size(327, 34)
        Me.tb_source.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Departure Time"
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.Location = New System.Drawing.Point(947, 26)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(152, 31)
        Me.lbl_to.TabIndex = 21
        Me.lbl_to.Text = "Destination"
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_from.Location = New System.Drawing.Point(168, 23)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(98, 31)
        Me.lbl_from.TabIndex = 20
        Me.lbl_from.Text = "Source"
        '
        'tb_route
        '
        Me.tb_route.Enabled = False
        Me.tb_route.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_route.Location = New System.Drawing.Point(200, 121)
        Me.tb_route.Multiline = True
        Me.tb_route.Name = "tb_route"
        Me.tb_route.Size = New System.Drawing.Size(471, 109)
        Me.tb_route.TabIndex = 42
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.tb_route)
        Me.Panel5.Controls.Add(Me.lbl_route)
        Me.Panel5.Controls.Add(Me.tb_distance)
        Me.Panel5.Controls.Add(Me.lbl_distance)
        Me.Panel5.Location = New System.Drawing.Point(93, 688)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(710, 265)
        Me.Panel5.TabIndex = 61
        '
        'lbl_route
        '
        Me.lbl_route.AutoSize = True
        Me.lbl_route.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_route.Location = New System.Drawing.Point(43, 126)
        Me.lbl_route.Name = "lbl_route"
        Me.lbl_route.Size = New System.Drawing.Size(76, 27)
        Me.lbl_route.TabIndex = 41
        Me.lbl_route.Text = "Route"
        '
        'tb_distance
        '
        Me.tb_distance.Enabled = False
        Me.tb_distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_distance.Location = New System.Drawing.Point(200, 36)
        Me.tb_distance.Name = "tb_distance"
        Me.tb_distance.Size = New System.Drawing.Size(471, 34)
        Me.tb_distance.TabIndex = 34
        '
        'lbl_distance
        '
        Me.lbl_distance.AutoSize = True
        Me.lbl_distance.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_distance.Location = New System.Drawing.Point(42, 41)
        Me.lbl_distance.Name = "lbl_distance"
        Me.lbl_distance.Size = New System.Drawing.Size(120, 31)
        Me.lbl_distance.TabIndex = 33
        Me.lbl_distance.Text = "Distance"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_update.Font = New System.Drawing.Font("Rockwell", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Azure
        Me.btn_update.Location = New System.Drawing.Point(1583, 789)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(231, 71)
        Me.btn_update.TabIndex = 63
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.btn_remove_days)
        Me.Panel6.Controls.Add(Me.lb_travels_Nm)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.clb_travel_days)
        Me.Panel6.Controls.Add(Me.lbl_travel_days)
        Me.Panel6.Location = New System.Drawing.Point(899, 658)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(657, 336)
        Me.Panel6.TabIndex = 62
        '
        'btn_remove_days
        '
        Me.btn_remove_days.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_remove_days.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_days.ForeColor = System.Drawing.Color.Azure
        Me.btn_remove_days.Location = New System.Drawing.Point(182, 275)
        Me.btn_remove_days.Name = "btn_remove_days"
        Me.btn_remove_days.Size = New System.Drawing.Size(298, 46)
        Me.btn_remove_days.TabIndex = 59
        Me.btn_remove_days.Text = "Remove Days And Travels"
        Me.btn_remove_days.UseVisualStyleBackColor = False
        '
        'lb_travels_Nm
        '
        Me.lb_travels_Nm.BackColor = System.Drawing.Color.AliceBlue
        Me.lb_travels_Nm.Enabled = False
        Me.lb_travels_Nm.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_travels_Nm.FormattingEnabled = True
        Me.lb_travels_Nm.ItemHeight = 25
        Me.lb_travels_Nm.Location = New System.Drawing.Point(54, 42)
        Me.lb_travels_Nm.Name = "lb_travels_Nm"
        Me.lb_travels_Nm.Size = New System.Drawing.Size(231, 229)
        Me.lb_travels_Nm.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 27)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Selected Days "
        '
        'clb_travel_days
        '
        Me.clb_travel_days.BackColor = System.Drawing.Color.AliceBlue
        Me.clb_travel_days.CheckOnClick = True
        Me.clb_travel_days.Enabled = False
        Me.clb_travel_days.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_travel_days.FormattingEnabled = True
        Me.clb_travel_days.Location = New System.Drawing.Point(372, 41)
        Me.clb_travel_days.Name = "clb_travel_days"
        Me.clb_travel_days.Size = New System.Drawing.Size(228, 228)
        Me.clb_travel_days.TabIndex = 41
        '
        'lbl_travel_days
        '
        Me.lbl_travel_days.AutoSize = True
        Me.lbl_travel_days.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_travel_days.Location = New System.Drawing.Point(80, 13)
        Me.lbl_travel_days.Name = "lbl_travel_days"
        Me.lbl_travel_days.Size = New System.Drawing.Size(165, 27)
        Me.lbl_travel_days.TabIndex = 42
        Me.lbl_travel_days.Text = "Travels Name"
        '
        'PictureBox1
        '
        '' Me.PictureBox1.Image = Global.Tours_And_Travels_Management_System.My.Resources.Resources.Tour_img
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2040, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(825, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 51)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Update Tour"
        '
        'frm_update_tour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "frm_update_tour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Tour"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_tour_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tour_id As System.Windows.Forms.Label
    Friend WithEvents btn_UPsearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtp_UParrival_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_UPdeparture_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_destina As System.Windows.Forms.TextBox
    Friend WithEvents tb_source As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents tb_route As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_route As System.Windows.Forms.Label
    Friend WithEvents tb_distance As System.Windows.Forms.TextBox
    Friend WithEvents lbl_distance As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_total_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_child_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_adl_price As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_non_sleeper_travel As System.Windows.Forms.RadioButton
    Friend WithEvents rb_sleeper_travel As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_travels_Nm As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clb_travel_days As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_travel_days As System.Windows.Forms.Label
    Friend WithEvents btn_remove_days As System.Windows.Forms.Button
    Friend WithEvents tb_ext_mode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
