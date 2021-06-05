<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_tour
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
        Me.rb_sleeper_travel = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_tour = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_non_sleeper_travel = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_total_price = New System.Windows.Forms.TextBox()
        Me.tb_child_price = New System.Windows.Forms.TextBox()
        Me.tb_adl_price = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_arrival_time = New System.Windows.Forms.DateTimePicker()
        Me.dtp_departure_time = New System.Windows.Forms.DateTimePicker()
        Me.tb_destin = New System.Windows.Forms.TextBox()
        Me.tb_source = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.tb_route = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_route = New System.Windows.Forms.Label()
        Me.tb_distance = New System.Windows.Forms.TextBox()
        Me.lbl_distance = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lb_travels_Nm = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clb_travel_days = New System.Windows.Forms.CheckedListBox()
        Me.lbl_travel_days = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_tour.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_tour_id
        '
        Me.tb_tour_id.Enabled = False
        Me.tb_tour_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tour_id.Location = New System.Drawing.Point(232, 17)
        Me.tb_tour_id.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_tour_id.MaxLength = 5
        Me.tb_tour_id.Name = "tb_tour_id"
        Me.tb_tour_id.Size = New System.Drawing.Size(246, 29)
        Me.tb_tour_id.TabIndex = 55
        '
        'lbl_tour_id
        '
        Me.lbl_tour_id.AutoSize = True
        Me.lbl_tour_id.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_id.Location = New System.Drawing.Point(50, 22)
        Me.lbl_tour_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tour_id.Name = "lbl_tour_id"
        Me.lbl_tour_id.Size = New System.Drawing.Size(88, 25)
        Me.lbl_tour_id.TabIndex = 19
        Me.lbl_tour_id.Text = "Tour ID"
        '
        'rb_sleeper_travel
        '
        Me.rb_sleeper_travel.AutoSize = True
        Me.rb_sleeper_travel.Location = New System.Drawing.Point(92, 22)
        Me.rb_sleeper_travel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rb_sleeper_travel.Name = "rb_sleeper_travel"
        Me.rb_sleeper_travel.Size = New System.Drawing.Size(224, 24)
        Me.rb_sleeper_travel.TabIndex = 11
        Me.rb_sleeper_travel.TabStop = True
        Me.rb_sleeper_travel.Text = "Travel Sleeper With AC"
        Me.rb_sleeper_travel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Mode"
        '
        'pnl_tour
        '
        Me.pnl_tour.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_tour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_tour.Controls.Add(Me.tb_tour_id)
        Me.pnl_tour.Controls.Add(Me.lbl_tour_id)
        Me.pnl_tour.Location = New System.Drawing.Point(71, 25)
        Me.pnl_tour.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_tour.Name = "pnl_tour"
        Me.pnl_tour.Size = New System.Drawing.Size(542, 58)
        Me.pnl_tour.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.pnl_tour)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 184)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1238, 89)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transport"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rb_non_sleeper_travel)
        Me.Panel2.Controls.Add(Me.rb_sleeper_travel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(662, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 58)
        Me.Panel2.TabIndex = 2
        '
        'rb_non_sleeper_travel
        '
        Me.rb_non_sleeper_travel.AutoSize = True
        Me.rb_non_sleeper_travel.Location = New System.Drawing.Point(326, 24)
        Me.rb_non_sleeper_travel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rb_non_sleeper_travel.Name = "rb_non_sleeper_travel"
        Me.rb_non_sleeper_travel.Size = New System.Drawing.Size(188, 24)
        Me.rb_non_sleeper_travel.TabIndex = 48
        Me.rb_non_sleeper_travel.TabStop = True
        Me.rb_non_sleeper_travel.Text = "Travel Non-Sleeper"
        Me.rb_non_sleeper_travel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(675, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Arrival Time"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.dtp_arrival_time)
        Me.Panel4.Controls.Add(Me.dtp_departure_time)
        Me.Panel4.Controls.Add(Me.tb_destin)
        Me.Panel4.Controls.Add(Me.tb_source)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lbl_to)
        Me.Panel4.Controls.Add(Me.lbl_from)
        Me.Panel4.Location = New System.Drawing.Point(64, 298)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1239, 240)
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
        Me.GroupBox2.Location = New System.Drawing.Point(145, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(908, 81)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'tb_total_price
        '
        Me.tb_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_price.Location = New System.Drawing.Point(713, 34)
        Me.tb_total_price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_total_price.MaxLength = 5
        Me.tb_total_price.Name = "tb_total_price"
        Me.tb_total_price.Size = New System.Drawing.Size(144, 29)
        Me.tb_total_price.TabIndex = 7
        '
        'tb_child_price
        '
        Me.tb_child_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_child_price.Location = New System.Drawing.Point(453, 34)
        Me.tb_child_price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_child_price.MaxLength = 5
        Me.tb_child_price.Name = "tb_child_price"
        Me.tb_child_price.Size = New System.Drawing.Size(144, 29)
        Me.tb_child_price.TabIndex = 6
        '
        'tb_adl_price
        '
        Me.tb_adl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_adl_price.Location = New System.Drawing.Point(166, 35)
        Me.tb_adl_price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_adl_price.MaxLength = 5
        Me.tb_adl_price.Name = "tb_adl_price"
        Me.tb_adl_price.Size = New System.Drawing.Size(144, 29)
        Me.tb_adl_price.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(623, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 35)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Child Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Adults Price"
        '
        'dtp_arrival_time
        '
        Me.dtp_arrival_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_arrival_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_arrival_time.Location = New System.Drawing.Point(843, 79)
        Me.dtp_arrival_time.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_arrival_time.Name = "dtp_arrival_time"
        Me.dtp_arrival_time.Size = New System.Drawing.Size(246, 29)
        Me.dtp_arrival_time.TabIndex = 4
        '
        'dtp_departure_time
        '
        Me.dtp_departure_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_departure_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_departure_time.Location = New System.Drawing.Point(304, 79)
        Me.dtp_departure_time.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_departure_time.Name = "dtp_departure_time"
        Me.dtp_departure_time.Size = New System.Drawing.Size(246, 29)
        Me.dtp_departure_time.TabIndex = 3
        Me.dtp_departure_time.Value = New Date(2020, 1, 1, 15, 26, 31, 0)
        '
        'tb_destin
        '
        Me.tb_destin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destin.Location = New System.Drawing.Point(843, 19)
        Me.tb_destin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_destin.MaxLength = 30
        Me.tb_destin.Name = "tb_destin"
        Me.tb_destin.Size = New System.Drawing.Size(246, 29)
        Me.tb_destin.TabIndex = 2
        '
        'tb_source
        '
        Me.tb_source.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_source.Location = New System.Drawing.Point(304, 16)
        Me.tb_source.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_source.MaxLength = 30
        Me.tb_source.Name = "tb_source"
        Me.tb_source.Size = New System.Drawing.Size(246, 29)
        Me.tb_source.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Departure Time"
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.Location = New System.Drawing.Point(675, 21)
        Me.lbl_to.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(128, 25)
        Me.lbl_to.TabIndex = 21
        Me.lbl_to.Text = "Destination"
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_from.Location = New System.Drawing.Point(121, 19)
        Me.lbl_from.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(82, 25)
        Me.lbl_from.TabIndex = 20
        Me.lbl_from.Text = "Source"
        '
        'tb_route
        '
        Me.tb_route.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_route.Location = New System.Drawing.Point(145, 98)
        Me.tb_route.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_route.MaxLength = 50
        Me.tb_route.Multiline = True
        Me.tb_route.Name = "tb_route"
        Me.tb_route.Size = New System.Drawing.Size(354, 89)
        Me.tb_route.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.tb_route)
        Me.Panel5.Controls.Add(Me.lbl_route)
        Me.Panel5.Controls.Add(Me.tb_distance)
        Me.Panel5.Controls.Add(Me.lbl_distance)
        Me.Panel5.Location = New System.Drawing.Point(64, 565)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(530, 216)
        Me.Panel5.TabIndex = 61
        '
        'lbl_route
        '
        Me.lbl_route.AutoSize = True
        Me.lbl_route.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_route.Location = New System.Drawing.Point(27, 102)
        Me.lbl_route.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_route.Name = "lbl_route"
        Me.lbl_route.Size = New System.Drawing.Size(60, 21)
        Me.lbl_route.TabIndex = 41
        Me.lbl_route.Text = "Route"
        '
        'tb_distance
        '
        Me.tb_distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_distance.Location = New System.Drawing.Point(145, 29)
        Me.tb_distance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_distance.MaxLength = 10
        Me.tb_distance.Name = "tb_distance"
        Me.tb_distance.Size = New System.Drawing.Size(338, 29)
        Me.tb_distance.TabIndex = 8
        '
        'lbl_distance
        '
        Me.lbl_distance.AutoSize = True
        Me.lbl_distance.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_distance.Location = New System.Drawing.Point(26, 33)
        Me.lbl_distance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_distance.Name = "lbl_distance"
        Me.lbl_distance.Size = New System.Drawing.Size(100, 25)
        Me.lbl_distance.TabIndex = 33
        Me.lbl_distance.Text = "Distance"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_add.Font = New System.Drawing.Font("Rockwell", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Azure
        Me.btn_add.Location = New System.Drawing.Point(1177, 647)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(155, 58)
        Me.btn_add.TabIndex = 13
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.lb_travels_Nm)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.clb_travel_days)
        Me.Panel6.Controls.Add(Me.lbl_travel_days)
        Me.Panel6.Location = New System.Drawing.Point(639, 560)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(504, 240)
        Me.Panel6.TabIndex = 62
        '
        'lb_travels_Nm
        '
        Me.lb_travels_Nm.BackColor = System.Drawing.Color.AliceBlue
        Me.lb_travels_Nm.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_travels_Nm.FormattingEnabled = True
        Me.lb_travels_Nm.ItemHeight = 20
        Me.lb_travels_Nm.Location = New System.Drawing.Point(62, 38)
        Me.lb_travels_Nm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lb_travels_Nm.Name = "lb_travels_Nm"
        Me.lb_travels_Nm.Size = New System.Drawing.Size(174, 184)
        Me.lb_travels_Nm.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Selected Days "
        '
        'clb_travel_days
        '
        Me.clb_travel_days.BackColor = System.Drawing.Color.AliceBlue
        Me.clb_travel_days.CheckOnClick = True
        Me.clb_travel_days.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_travel_days.FormattingEnabled = True
        Me.clb_travel_days.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.clb_travel_days.Location = New System.Drawing.Point(300, 38)
        Me.clb_travel_days.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clb_travel_days.Name = "clb_travel_days"
        Me.clb_travel_days.Size = New System.Drawing.Size(172, 165)
        Me.clb_travel_days.TabIndex = 10
        '
        'lbl_travel_days
        '
        Me.lbl_travel_days.AutoSize = True
        Me.lbl_travel_days.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_travel_days.Location = New System.Drawing.Point(82, 10)
        Me.lbl_travel_days.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_travel_days.Name = "lbl_travel_days"
        Me.lbl_travel_days.Size = New System.Drawing.Size(131, 21)
        Me.lbl_travel_days.TabIndex = 36
        Me.lbl_travel_days.Text = "Travels Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(423, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 41)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Add Tour"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1015, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'frm_add_tour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Panel6)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_add_tour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Tour"
        Me.pnl_tour.ResumeLayout(False)
        Me.pnl_tour.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents rb_sleeper_travel As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl_tour As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtp_arrival_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_departure_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_destin As System.Windows.Forms.TextBox
    Friend WithEvents tb_source As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents tb_route As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_route As System.Windows.Forms.Label
    Friend WithEvents tb_distance As System.Windows.Forms.TextBox
    Friend WithEvents lbl_distance As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents clb_travel_days As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_travel_days As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_total_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_child_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_adl_price As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rb_non_sleeper_travel As System.Windows.Forms.RadioButton
    Friend WithEvents lb_travels_Nm As System.Windows.Forms.ListBox
End Class
