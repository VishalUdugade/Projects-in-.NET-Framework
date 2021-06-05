<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view_single_tour
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_total_price = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_adl_price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_child_price = New System.Windows.Forms.TextBox()
        Me.dtp_arrival_time = New System.Windows.Forms.DateTimePicker()
        Me.tb_destin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_departure_time = New System.Windows.Forms.DateTimePicker()
        Me.tb_source = New System.Windows.Forms.TextBox()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lb_Travelling_days = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_travel_nm = New System.Windows.Forms.TextBox()
        Me.lbl_travel_days = New System.Windows.Forms.Label()
        Me.tb_route = New System.Windows.Forms.TextBox()
        Me.lbl_route = New System.Windows.Forms.Label()
        Me.tb_distance = New System.Windows.Forms.TextBox()
        Me.lbl_distance = New System.Windows.Forms.Label()
        Me.tb_type_travels = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(150, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 582)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtp_arrival_time)
        Me.Panel1.Controls.Add(Me.tb_destin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp_departure_time)
        Me.Panel1.Controls.Add(Me.tb_source)
        Me.Panel1.Controls.Add(Me.lbl_to)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_from)
        Me.Panel1.Location = New System.Drawing.Point(17, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 544)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Moccasin
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.tb_total_price)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tb_adl_price)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.tb_child_price)
        Me.Panel2.Location = New System.Drawing.Point(3, 306)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 213)
        Me.Panel2.TabIndex = 93
        '
        'tb_total_price
        '
        Me.tb_total_price.Enabled = False
        Me.tb_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_price.Location = New System.Drawing.Point(212, 158)
        Me.tb_total_price.MaxLength = 5
        Me.tb_total_price.Name = "tb_total_price"
        Me.tb_total_price.Size = New System.Drawing.Size(231, 34)
        Me.tb_total_price.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(287, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 31)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total"
        '
        'tb_adl_price
        '
        Me.tb_adl_price.Enabled = False
        Me.tb_adl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_adl_price.Location = New System.Drawing.Point(33, 57)
        Me.tb_adl_price.MaxLength = 5
        Me.tb_adl_price.Name = "tb_adl_price"
        Me.tb_adl_price.Size = New System.Drawing.Size(244, 34)
        Me.tb_adl_price.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Adults Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Child Price"
        '
        'tb_child_price
        '
        Me.tb_child_price.Enabled = False
        Me.tb_child_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_child_price.Location = New System.Drawing.Point(369, 57)
        Me.tb_child_price.MaxLength = 5
        Me.tb_child_price.Name = "tb_child_price"
        Me.tb_child_price.Size = New System.Drawing.Size(246, 34)
        Me.tb_child_price.TabIndex = 6
        '
        'dtp_arrival_time
        '
        Me.dtp_arrival_time.Enabled = False
        Me.dtp_arrival_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_arrival_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_arrival_time.Location = New System.Drawing.Point(275, 230)
        Me.dtp_arrival_time.Name = "dtp_arrival_time"
        Me.dtp_arrival_time.Size = New System.Drawing.Size(327, 34)
        Me.dtp_arrival_time.TabIndex = 90
        '
        'tb_destin
        '
        Me.tb_destin.Enabled = False
        Me.tb_destin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destin.Location = New System.Drawing.Point(275, 99)
        Me.tb_destin.MaxLength = 30
        Me.tb_destin.Name = "tb_destin"
        Me.tb_destin.Size = New System.Drawing.Size(327, 34)
        Me.tb_destin.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 31)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Arrival Time"
        '
        'dtp_departure_time
        '
        Me.dtp_departure_time.Enabled = False
        Me.dtp_departure_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_departure_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_departure_time.Location = New System.Drawing.Point(275, 163)
        Me.dtp_departure_time.Name = "dtp_departure_time"
        Me.dtp_departure_time.Size = New System.Drawing.Size(327, 34)
        Me.dtp_departure_time.TabIndex = 89
        Me.dtp_departure_time.Value = New Date(2020, 1, 1, 15, 26, 31, 0)
        '
        'tb_source
        '
        Me.tb_source.Enabled = False
        Me.tb_source.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_source.Location = New System.Drawing.Point(275, 42)
        Me.tb_source.MaxLength = 30
        Me.tb_source.Name = "tb_source"
        Me.tb_source.Size = New System.Drawing.Size(327, 34)
        Me.tb_source.TabIndex = 89
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.Location = New System.Drawing.Point(30, 99)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(152, 31)
        Me.lbl_to.TabIndex = 92
        Me.lbl_to.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Departure Time"
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_from.Location = New System.Drawing.Point(30, 45)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(98, 31)
        Me.lbl_from.TabIndex = 91
        Me.lbl_from.Text = "Source"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(983, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 582)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About Travelling"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lb_Travelling_days)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tb_travel_nm)
        Me.Panel3.Controls.Add(Me.lbl_travel_days)
        Me.Panel3.Controls.Add(Me.tb_route)
        Me.Panel3.Controls.Add(Me.lbl_route)
        Me.Panel3.Controls.Add(Me.tb_distance)
        Me.Panel3.Controls.Add(Me.lbl_distance)
        Me.Panel3.Controls.Add(Me.tb_type_travels)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(16, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(738, 544)
        Me.Panel3.TabIndex = 0
        '
        'lb_Travelling_days
        '
        Me.lb_Travelling_days.BackColor = System.Drawing.SystemColors.Window
        Me.lb_Travelling_days.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Travelling_days.FormattingEnabled = True
        Me.lb_Travelling_days.ItemHeight = 25
        Me.lb_Travelling_days.Location = New System.Drawing.Point(298, 391)
        Me.lb_Travelling_days.Name = "lb_Travelling_days"
        Me.lb_Travelling_days.Size = New System.Drawing.Size(336, 129)
        Me.lb_Travelling_days.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 27)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Selected Days "
        '
        'tb_travel_nm
        '
        Me.tb_travel_nm.Enabled = False
        Me.tb_travel_nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_travel_nm.Location = New System.Drawing.Point(298, 324)
        Me.tb_travel_nm.MaxLength = 10
        Me.tb_travel_nm.Name = "tb_travel_nm"
        Me.tb_travel_nm.Size = New System.Drawing.Size(327, 34)
        Me.tb_travel_nm.TabIndex = 99
        '
        'lbl_travel_days
        '
        Me.lbl_travel_days.AutoSize = True
        Me.lbl_travel_days.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_travel_days.Location = New System.Drawing.Point(35, 324)
        Me.lbl_travel_days.Name = "lbl_travel_days"
        Me.lbl_travel_days.Size = New System.Drawing.Size(165, 27)
        Me.lbl_travel_days.TabIndex = 98
        Me.lbl_travel_days.Text = "Travels Name"
        '
        'tb_route
        '
        Me.tb_route.Enabled = False
        Me.tb_route.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_route.Location = New System.Drawing.Point(298, 165)
        Me.tb_route.MaxLength = 50
        Me.tb_route.Multiline = True
        Me.tb_route.Name = "tb_route"
        Me.tb_route.Size = New System.Drawing.Size(327, 125)
        Me.tb_route.TabIndex = 96
        '
        'lbl_route
        '
        Me.lbl_route.AutoSize = True
        Me.lbl_route.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_route.Location = New System.Drawing.Point(40, 170)
        Me.lbl_route.Name = "lbl_route"
        Me.lbl_route.Size = New System.Drawing.Size(76, 27)
        Me.lbl_route.TabIndex = 97
        Me.lbl_route.Text = "Route"
        '
        'tb_distance
        '
        Me.tb_distance.Enabled = False
        Me.tb_distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_distance.Location = New System.Drawing.Point(298, 106)
        Me.tb_distance.MaxLength = 10
        Me.tb_distance.Name = "tb_distance"
        Me.tb_distance.Size = New System.Drawing.Size(327, 34)
        Me.tb_distance.TabIndex = 94
        '
        'lbl_distance
        '
        Me.lbl_distance.AutoSize = True
        Me.lbl_distance.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_distance.Location = New System.Drawing.Point(34, 109)
        Me.lbl_distance.Name = "lbl_distance"
        Me.lbl_distance.Size = New System.Drawing.Size(120, 31)
        Me.lbl_distance.TabIndex = 95
        Me.lbl_distance.Text = "Distance"
        '
        'tb_type_travels
        '
        Me.tb_type_travels.Enabled = False
        Me.tb_type_travels.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_type_travels.Location = New System.Drawing.Point(298, 47)
        Me.tb_type_travels.MaxLength = 30
        Me.tb_type_travels.Name = "tb_type_travels"
        Me.tb_type_travels.Size = New System.Drawing.Size(327, 34)
        Me.tb_type_travels.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 31)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Type Of Travels"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Azure
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(842, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 49)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "View Tours"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_back.Font = New System.Drawing.Font("Rockwell", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Azure
        Me.btn_back.Location = New System.Drawing.Point(525, 906)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(246, 83)
        Me.btn_back.TabIndex = 92
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        '' Me.PictureBox1.BackgroundImage = Global.Tours_And_Travels_Management_System.My.Resources.Resources.Tour_img
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2040, 184)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(1041, 903)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 86)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Select Tour And " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Customer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_view_single_tour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_view_single_tour"
        Me.Text = "frm_view_single_tour"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_total_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_child_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_adl_price As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb_destin As System.Windows.Forms.TextBox
    Friend WithEvents tb_source As System.Windows.Forms.TextBox
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtp_arrival_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_departure_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tb_type_travels As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_distance As System.Windows.Forms.TextBox
    Friend WithEvents lbl_distance As System.Windows.Forms.Label
    Friend WithEvents tb_route As System.Windows.Forms.TextBox
    Friend WithEvents lbl_route As System.Windows.Forms.Label
    Friend WithEvents lbl_travel_days As System.Windows.Forms.Label
    Friend WithEvents tb_travel_nm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_Travelling_days As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
