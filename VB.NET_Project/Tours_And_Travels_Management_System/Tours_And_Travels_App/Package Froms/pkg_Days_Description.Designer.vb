<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pkg_Days_Description
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pkg_Days_Description))
        Me.gb_Hotelling = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_D_Place = New System.Windows.Forms.TextBox()
        Me.tb_D_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Dinner_Hotel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_L_Place = New System.Windows.Forms.TextBox()
        Me.tb_L_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Place = New System.Windows.Forms.Label()
        Me.lb_Name = New System.Windows.Forms.Label()
        Me.lbl_Lunch_Hotel = New System.Windows.Forms.Label()
        Me.gb_Description = New System.Windows.Forms.GroupBox()
        Me.tb_Days_Descri = New System.Windows.Forms.TextBox()
        Me.lbl_Days_no = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pb_place = New System.Windows.Forms.PictureBox()
        Me.tb_Place = New System.Windows.Forms.TextBox()
        Me.lbl_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.panel_Date = New System.Windows.Forms.Panel()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.tb_day_id = New System.Windows.Forms.TextBox()
        Me.gb_Hotelling.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gb_Description.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pb_place, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Date.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Hotelling
        '
        Me.gb_Hotelling.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Hotelling.Controls.Add(Me.Panel2)
        Me.gb_Hotelling.Controls.Add(Me.Panel1)
        Me.gb_Hotelling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Hotelling.Location = New System.Drawing.Point(3, 47)
        Me.gb_Hotelling.Name = "gb_Hotelling"
        Me.gb_Hotelling.Size = New System.Drawing.Size(261, 252)
        Me.gb_Hotelling.TabIndex = 12
        Me.gb_Hotelling.TabStop = False
        Me.gb_Hotelling.Text = "Hotelling"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.tb_D_Place)
        Me.Panel2.Controls.Add(Me.tb_D_Name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_Name)
        Me.Panel2.Controls.Add(Me.lbl_Dinner_Hotel)
        Me.Panel2.Location = New System.Drawing.Point(6, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 106)
        Me.Panel2.TabIndex = 1
        '
        'tb_D_Place
        '
        Me.tb_D_Place.Enabled = False
        Me.tb_D_Place.Location = New System.Drawing.Point(67, 65)
        Me.tb_D_Place.Name = "tb_D_Place"
        Me.tb_D_Place.Size = New System.Drawing.Size(165, 26)
        Me.tb_D_Place.TabIndex = 7
        '
        'tb_D_Name
        '
        Me.tb_D_Name.Enabled = False
        Me.tb_D_Name.Location = New System.Drawing.Point(67, 30)
        Me.tb_D_Name.Name = "tb_D_Name"
        Me.tb_D_Name.Size = New System.Drawing.Size(165, 26)
        Me.tb_D_Name.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Place"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.ForeColor = System.Drawing.Color.Black
        Me.lbl_Name.Location = New System.Drawing.Point(3, 30)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(55, 20)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "Name"
        '
        'lbl_Dinner_Hotel
        '
        Me.lbl_Dinner_Hotel.AutoSize = True
        Me.lbl_Dinner_Hotel.ForeColor = System.Drawing.Color.Black
        Me.lbl_Dinner_Hotel.Location = New System.Drawing.Point(86, 2)
        Me.lbl_Dinner_Hotel.Name = "lbl_Dinner_Hotel"
        Me.lbl_Dinner_Hotel.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Dinner_Hotel.TabIndex = 0
        Me.lbl_Dinner_Hotel.Text = "Dinner Hotel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tb_L_Place)
        Me.Panel1.Controls.Add(Me.tb_L_Name)
        Me.Panel1.Controls.Add(Me.lbl_Place)
        Me.Panel1.Controls.Add(Me.lb_Name)
        Me.Panel1.Controls.Add(Me.lbl_Lunch_Hotel)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 106)
        Me.Panel1.TabIndex = 0
        '
        'tb_L_Place
        '
        Me.tb_L_Place.Enabled = False
        Me.tb_L_Place.Location = New System.Drawing.Point(67, 65)
        Me.tb_L_Place.Name = "tb_L_Place"
        Me.tb_L_Place.Size = New System.Drawing.Size(165, 26)
        Me.tb_L_Place.TabIndex = 5
        '
        'tb_L_Name
        '
        Me.tb_L_Name.Enabled = False
        Me.tb_L_Name.Location = New System.Drawing.Point(67, 29)
        Me.tb_L_Name.Name = "tb_L_Name"
        Me.tb_L_Name.Size = New System.Drawing.Size(165, 26)
        Me.tb_L_Name.TabIndex = 4
        '
        'lbl_Place
        '
        Me.lbl_Place.AutoSize = True
        Me.lbl_Place.ForeColor = System.Drawing.Color.Black
        Me.lbl_Place.Location = New System.Drawing.Point(3, 71)
        Me.lbl_Place.Name = "lbl_Place"
        Me.lbl_Place.Size = New System.Drawing.Size(53, 20)
        Me.lbl_Place.TabIndex = 2
        Me.lbl_Place.Text = "Place"
        '
        'lb_Name
        '
        Me.lb_Name.AutoSize = True
        Me.lb_Name.ForeColor = System.Drawing.Color.Black
        Me.lb_Name.Location = New System.Drawing.Point(3, 30)
        Me.lb_Name.Name = "lb_Name"
        Me.lb_Name.Size = New System.Drawing.Size(55, 20)
        Me.lb_Name.TabIndex = 1
        Me.lb_Name.Text = "Name"
        '
        'lbl_Lunch_Hotel
        '
        Me.lbl_Lunch_Hotel.AutoSize = True
        Me.lbl_Lunch_Hotel.ForeColor = System.Drawing.Color.Black
        Me.lbl_Lunch_Hotel.Location = New System.Drawing.Point(86, 1)
        Me.lbl_Lunch_Hotel.Name = "lbl_Lunch_Hotel"
        Me.lbl_Lunch_Hotel.Size = New System.Drawing.Size(106, 20)
        Me.lbl_Lunch_Hotel.TabIndex = 0
        Me.lbl_Lunch_Hotel.Text = "Lunch Hotel"
        '
        'gb_Description
        '
        Me.gb_Description.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Description.Controls.Add(Me.tb_Days_Descri)
        Me.gb_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Description.Location = New System.Drawing.Point(279, 47)
        Me.gb_Description.Name = "gb_Description"
        Me.gb_Description.Size = New System.Drawing.Size(716, 252)
        Me.gb_Description.TabIndex = 13
        Me.gb_Description.TabStop = False
        Me.gb_Description.Text = "Description"
        '
        'tb_Days_Descri
        '
        Me.tb_Days_Descri.Enabled = False
        Me.tb_Days_Descri.Location = New System.Drawing.Point(6, 25)
        Me.tb_Days_Descri.Multiline = True
        Me.tb_Days_Descri.Name = "tb_Days_Descri"
        Me.tb_Days_Descri.Size = New System.Drawing.Size(704, 218)
        Me.tb_Days_Descri.TabIndex = 6
        '
        'lbl_Days_no
        '
        Me.lbl_Days_no.BackColor = System.Drawing.Color.Chocolate
        Me.lbl_Days_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Days_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Days_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_Days_no.Location = New System.Drawing.Point(68, 4)
        Me.lbl_Days_no.Name = "lbl_Days_no"
        Me.lbl_Days_no.Size = New System.Drawing.Size(196, 36)
        Me.lbl_Days_no.TabIndex = 15
        Me.lbl_Days_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Khaki
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.pb_place)
        Me.Panel3.Controls.Add(Me.tb_Place)
        Me.Panel3.Location = New System.Drawing.Point(279, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(412, 36)
        Me.Panel3.TabIndex = 17
        '
        'pb_place
        '
        Me.pb_place.Image = CType(resources.GetObject("pb_place.Image"), System.Drawing.Image)
        Me.pb_place.Location = New System.Drawing.Point(4, 5)
        Me.pb_place.Name = "pb_place"
        Me.pb_place.Size = New System.Drawing.Size(46, 24)
        Me.pb_place.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_place.TabIndex = 2
        Me.pb_place.TabStop = False
        '
        'tb_Place
        '
        Me.tb_Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Place.Location = New System.Drawing.Point(56, 5)
        Me.tb_Place.Name = "tb_Place"
        Me.tb_Place.Size = New System.Drawing.Size(349, 24)
        Me.tb_Place.TabIndex = 1
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.BackColor = System.Drawing.Color.Coral
        Me.lbl_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.Black
        Me.lbl_Date.Location = New System.Drawing.Point(6, 5)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(50, 22)
        Me.lbl_Date.TabIndex = 6
        Me.lbl_Date.Text = "Date"
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(67, 5)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(142, 24)
        Me.dtp_Date.TabIndex = 7
        Me.dtp_Date.Value = New Date(2019, 7, 24, 0, 0, 0, 0)
        '
        'panel_Date
        '
        Me.panel_Date.BackColor = System.Drawing.Color.Khaki
        Me.panel_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Date.Controls.Add(Me.dtp_Date)
        Me.panel_Date.Controls.Add(Me.lbl_Date)
        Me.panel_Date.Enabled = False
        Me.panel_Date.Location = New System.Drawing.Point(697, 4)
        Me.panel_Date.Name = "panel_Date"
        Me.panel_Date.Size = New System.Drawing.Size(215, 36)
        Me.panel_Date.TabIndex = 16
        '
        'btn_next
        '
        Me.btn_next.Enabled = False
        Me.btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(917, 4)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(78, 34)
        Me.btn_next.TabIndex = 18
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'tb_day_id
        '
        Me.tb_day_id.Enabled = False
        Me.tb_day_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_day_id.Location = New System.Drawing.Point(9, 4)
        Me.tb_day_id.Multiline = True
        Me.tb_day_id.Name = "tb_day_id"
        Me.tb_day_id.Size = New System.Drawing.Size(53, 36)
        Me.tb_day_id.TabIndex = 19
        Me.tb_day_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pkg_Days_Description
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.tb_day_id)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel_Date)
        Me.Controls.Add(Me.lbl_Days_no)
        Me.Controls.Add(Me.gb_Description)
        Me.Controls.Add(Me.gb_Hotelling)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "pkg_Days_Description"
        Me.Size = New System.Drawing.Size(1000, 307)
        Me.gb_Hotelling.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_Description.ResumeLayout(False)
        Me.gb_Description.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pb_place, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Date.ResumeLayout(False)
        Me.panel_Date.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_Hotelling As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Lunch_Hotel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Dinner_Hotel As System.Windows.Forms.Label
    Friend WithEvents lbl_Place As System.Windows.Forms.Label
    Friend WithEvents lb_Name As System.Windows.Forms.Label
    Friend WithEvents gb_Description As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Days_no As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tb_Place As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents panel_Date As System.Windows.Forms.Panel
    Friend WithEvents tb_Days_Descri As System.Windows.Forms.TextBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents tb_D_Place As System.Windows.Forms.TextBox
    Friend WithEvents tb_D_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_L_Place As System.Windows.Forms.TextBox
    Friend WithEvents tb_L_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_day_id As System.Windows.Forms.TextBox
    Friend WithEvents pb_place As System.Windows.Forms.PictureBox

End Class
