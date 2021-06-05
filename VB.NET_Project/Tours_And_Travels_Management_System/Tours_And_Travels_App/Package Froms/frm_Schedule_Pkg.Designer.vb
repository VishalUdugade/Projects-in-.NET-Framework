<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Schedule_Pkg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Schedule_Pkg))
        Me.panel_Schedule_pkg = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Schedule_pkg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Out_dated_Package = New System.Windows.Forms.Panel()
        Me.panel_Capacity_is_Full = New System.Windows.Forms.Panel()
        Me.panel_out_dated_tours = New System.Windows.Forms.Panel()
        Me.lbl_Out_Dated_Package = New System.Windows.Forms.Label()
        Me.lbl_Capacity_is_Full = New System.Windows.Forms.Label()
        Me.lbl_out_dated_tours = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_Days = New System.Windows.Forms.TextBox()
        Me.lbl_Days = New System.Windows.Forms.Label()
        Me.dtp_chg_start_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tour_start_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtp_chg_expiry_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tour_expiry_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Out_dated_Tour_Date = New System.Windows.Forms.Label()
        Me.cb_tour_dates = New System.Windows.Forms.ComboBox()
        Me.tb_Persons_Capacity = New System.Windows.Forms.TextBox()
        Me.lbl_Package_Person_Capacity = New System.Windows.Forms.Label()
        Me.dtp_pkg_Expiry_Date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Expiry_Date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Pkg_Create_Date = New System.Windows.Forms.Label()
        Me.dtp_Pkg_Create_Date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_pkg_name = New System.Windows.Forms.Label()
        Me.btb_Show_Iternary = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.panel_Schedule_pkg.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Schedule_pkg
        '
        Me.panel_Schedule_pkg.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.BackgroundImage = CType(resources.GetObject("panel_Schedule_pkg.BackgroundImage"), System.Drawing.Image)
        Me.panel_Schedule_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Schedule_pkg.Controls.Add(Me.lbl_Schedule_pkg)
        Me.panel_Schedule_pkg.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.Location = New System.Drawing.Point(1, 2)
        Me.panel_Schedule_pkg.Name = "panel_Schedule_pkg"
        Me.panel_Schedule_pkg.Quality = 10
        Me.panel_Schedule_pkg.Size = New System.Drawing.Size(1348, 59)
        Me.panel_Schedule_pkg.TabIndex = 0
        '
        'lbl_Schedule_pkg
        '
        Me.lbl_Schedule_pkg.AutoSize = True
        Me.lbl_Schedule_pkg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Schedule_pkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Schedule_pkg.ForeColor = System.Drawing.Color.White
        Me.lbl_Schedule_pkg.Location = New System.Drawing.Point(579, 12)
        Me.lbl_Schedule_pkg.Name = "lbl_Schedule_pkg"
        Me.lbl_Schedule_pkg.Size = New System.Drawing.Size(298, 37)
        Me.lbl_Schedule_pkg.TabIndex = 0
        Me.lbl_Schedule_pkg.Text = "Schedule Package"
        '
        'panel_Out_dated_Package
        '
        Me.panel_Out_dated_Package.BackColor = System.Drawing.Color.Khaki
        Me.panel_Out_dated_Package.Location = New System.Drawing.Point(7, 116)
        Me.panel_Out_dated_Package.Name = "panel_Out_dated_Package"
        Me.panel_Out_dated_Package.Size = New System.Drawing.Size(142, 601)
        Me.panel_Out_dated_Package.TabIndex = 1
        '
        'panel_Capacity_is_Full
        '
        Me.panel_Capacity_is_Full.BackColor = System.Drawing.Color.Khaki
        Me.panel_Capacity_is_Full.Location = New System.Drawing.Point(160, 116)
        Me.panel_Capacity_is_Full.Name = "panel_Capacity_is_Full"
        Me.panel_Capacity_is_Full.Size = New System.Drawing.Size(142, 601)
        Me.panel_Capacity_is_Full.TabIndex = 2
        '
        'panel_out_dated_tours
        '
        Me.panel_out_dated_tours.AutoSize = True
        Me.panel_out_dated_tours.BackColor = System.Drawing.Color.Khaki
        Me.panel_out_dated_tours.Location = New System.Drawing.Point(311, 116)
        Me.panel_out_dated_tours.Name = "panel_out_dated_tours"
        Me.panel_out_dated_tours.Size = New System.Drawing.Size(142, 601)
        Me.panel_out_dated_tours.TabIndex = 2
        '
        'lbl_Out_Dated_Package
        '
        Me.lbl_Out_Dated_Package.BackColor = System.Drawing.Color.Goldenrod
        Me.lbl_Out_Dated_Package.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Out_Dated_Package.Location = New System.Drawing.Point(12, 71)
        Me.lbl_Out_Dated_Package.Name = "lbl_Out_Dated_Package"
        Me.lbl_Out_Dated_Package.Size = New System.Drawing.Size(137, 42)
        Me.lbl_Out_Dated_Package.TabIndex = 3
        Me.lbl_Out_Dated_Package.Text = "Out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Dated Package"
        Me.lbl_Out_Dated_Package.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Capacity_is_Full
        '
        Me.lbl_Capacity_is_Full.BackColor = System.Drawing.Color.Goldenrod
        Me.lbl_Capacity_is_Full.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Capacity_is_Full.Location = New System.Drawing.Point(160, 71)
        Me.lbl_Capacity_is_Full.Name = "lbl_Capacity_is_Full"
        Me.lbl_Capacity_is_Full.Size = New System.Drawing.Size(142, 42)
        Me.lbl_Capacity_is_Full.TabIndex = 4
        Me.lbl_Capacity_is_Full.Text = "Capacity is Full"
        Me.lbl_Capacity_is_Full.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_out_dated_tours
        '
        Me.lbl_out_dated_tours.BackColor = System.Drawing.Color.Goldenrod
        Me.lbl_out_dated_tours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_out_dated_tours.Location = New System.Drawing.Point(311, 71)
        Me.lbl_out_dated_tours.Name = "lbl_out_dated_tours"
        Me.lbl_out_dated_tours.Size = New System.Drawing.Size(142, 42)
        Me.lbl_out_dated_tours.TabIndex = 5
        Me.lbl_out_dated_tours.Text = "Out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Dated Tours"
        Me.lbl_out_dated_tours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.tb_Days)
        Me.Panel1.Controls.Add(Me.lbl_Days)
        Me.Panel1.Controls.Add(Me.dtp_chg_start_date)
        Me.Panel1.Controls.Add(Me.lbl_tour_start_date)
        Me.Panel1.Controls.Add(Me.dtp_chg_expiry_date)
        Me.Panel1.Controls.Add(Me.lbl_tour_expiry_date)
        Me.Panel1.Controls.Add(Me.lbl_Out_dated_Tour_Date)
        Me.Panel1.Controls.Add(Me.cb_tour_dates)
        Me.Panel1.Controls.Add(Me.tb_Persons_Capacity)
        Me.Panel1.Controls.Add(Me.lbl_Package_Person_Capacity)
        Me.Panel1.Controls.Add(Me.dtp_pkg_Expiry_Date)
        Me.Panel1.Controls.Add(Me.lbl_Expiry_Date)
        Me.Panel1.Controls.Add(Me.lbl_Pkg_Create_Date)
        Me.Panel1.Controls.Add(Me.dtp_Pkg_Create_Date)
        Me.Panel1.Location = New System.Drawing.Point(459, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 419)
        Me.Panel1.TabIndex = 6
        '
        'tb_Days
        '
        Me.tb_Days.Enabled = False
        Me.tb_Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Days.Location = New System.Drawing.Point(217, 61)
        Me.tb_Days.Name = "tb_Days"
        Me.tb_Days.Size = New System.Drawing.Size(139, 22)
        Me.tb_Days.TabIndex = 366
        Me.tb_Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Days
        '
        Me.lbl_Days.AutoSize = True
        Me.lbl_Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Days.Location = New System.Drawing.Point(133, 61)
        Me.lbl_Days.Name = "lbl_Days"
        Me.lbl_Days.Size = New System.Drawing.Size(49, 20)
        Me.lbl_Days.TabIndex = 367
        Me.lbl_Days.Text = "Days"
        '
        'dtp_chg_start_date
        '
        Me.dtp_chg_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_chg_start_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_chg_start_date.Location = New System.Drawing.Point(473, 191)
        Me.dtp_chg_start_date.Name = "dtp_chg_start_date"
        Me.dtp_chg_start_date.Size = New System.Drawing.Size(154, 22)
        Me.dtp_chg_start_date.TabIndex = 365
        Me.dtp_chg_start_date.Value = New Date(2019, 12, 26, 0, 0, 0, 0)
        '
        'lbl_tour_start_date
        '
        Me.lbl_tour_start_date.AutoSize = True
        Me.lbl_tour_start_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_start_date.Location = New System.Drawing.Point(469, 155)
        Me.lbl_tour_start_date.Name = "lbl_tour_start_date"
        Me.lbl_tour_start_date.Size = New System.Drawing.Size(160, 20)
        Me.lbl_tour_start_date.TabIndex = 364
        Me.lbl_tour_start_date.Text = "Change Start Date"
        '
        'dtp_chg_expiry_date
        '
        Me.dtp_chg_expiry_date.Enabled = False
        Me.dtp_chg_expiry_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_chg_expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_chg_expiry_date.Location = New System.Drawing.Point(706, 191)
        Me.dtp_chg_expiry_date.Name = "dtp_chg_expiry_date"
        Me.dtp_chg_expiry_date.Size = New System.Drawing.Size(154, 22)
        Me.dtp_chg_expiry_date.TabIndex = 363
        Me.dtp_chg_expiry_date.Value = New Date(2019, 12, 26, 0, 0, 0, 0)
        '
        'lbl_tour_expiry_date
        '
        Me.lbl_tour_expiry_date.AutoSize = True
        Me.lbl_tour_expiry_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tour_expiry_date.Location = New System.Drawing.Point(694, 155)
        Me.lbl_tour_expiry_date.Name = "lbl_tour_expiry_date"
        Me.lbl_tour_expiry_date.Size = New System.Drawing.Size(168, 20)
        Me.lbl_tour_expiry_date.TabIndex = 362
        Me.lbl_tour_expiry_date.Text = "Change Expiry Date"
        '
        'lbl_Out_dated_Tour_Date
        '
        Me.lbl_Out_dated_Tour_Date.AutoSize = True
        Me.lbl_Out_dated_Tour_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Out_dated_Tour_Date.Location = New System.Drawing.Point(443, 62)
        Me.lbl_Out_dated_Tour_Date.Name = "lbl_Out_dated_Tour_Date"
        Me.lbl_Out_dated_Tour_Date.Size = New System.Drawing.Size(186, 20)
        Me.lbl_Out_dated_Tour_Date.TabIndex = 360
        Me.lbl_Out_dated_Tour_Date.Text = "Out Dated Tour Dates"
        '
        'cb_tour_dates
        '
        Me.cb_tour_dates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tour_dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tour_dates.FormattingEnabled = True
        Me.cb_tour_dates.Location = New System.Drawing.Point(706, 62)
        Me.cb_tour_dates.Name = "cb_tour_dates"
        Me.cb_tour_dates.Size = New System.Drawing.Size(160, 24)
        Me.cb_tour_dates.TabIndex = 361
        '
        'tb_Persons_Capacity
        '
        Me.tb_Persons_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Persons_Capacity.Location = New System.Drawing.Point(217, 264)
        Me.tb_Persons_Capacity.Name = "tb_Persons_Capacity"
        Me.tb_Persons_Capacity.Size = New System.Drawing.Size(123, 24)
        Me.tb_Persons_Capacity.TabIndex = 358
        Me.tb_Persons_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Package_Person_Capacity
        '
        Me.lbl_Package_Person_Capacity.AutoSize = True
        Me.lbl_Package_Person_Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_Person_Capacity.Location = New System.Drawing.Point(50, 264)
        Me.lbl_Package_Person_Capacity.Name = "lbl_Package_Person_Capacity"
        Me.lbl_Package_Person_Capacity.Size = New System.Drawing.Size(148, 20)
        Me.lbl_Package_Person_Capacity.TabIndex = 359
        Me.lbl_Package_Person_Capacity.Text = "Persons Capacity"
        '
        'dtp_pkg_Expiry_Date
        '
        Me.dtp_pkg_Expiry_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_pkg_Expiry_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_pkg_Expiry_Date.Location = New System.Drawing.Point(217, 197)
        Me.dtp_pkg_Expiry_Date.Name = "dtp_pkg_Expiry_Date"
        Me.dtp_pkg_Expiry_Date.Size = New System.Drawing.Size(154, 22)
        Me.dtp_pkg_Expiry_Date.TabIndex = 357
        Me.dtp_pkg_Expiry_Date.Value = New Date(2020, 3, 31, 0, 0, 0, 0)
        '
        'lbl_Expiry_Date
        '
        Me.lbl_Expiry_Date.AutoSize = True
        Me.lbl_Expiry_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Expiry_Date.Location = New System.Drawing.Point(23, 197)
        Me.lbl_Expiry_Date.Name = "lbl_Expiry_Date"
        Me.lbl_Expiry_Date.Size = New System.Drawing.Size(175, 20)
        Me.lbl_Expiry_Date.TabIndex = 356
        Me.lbl_Expiry_Date.Text = "Package Expiry Date"
        '
        'lbl_Pkg_Create_Date
        '
        Me.lbl_Pkg_Create_Date.AutoSize = True
        Me.lbl_Pkg_Create_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Create_Date.Location = New System.Drawing.Point(17, 133)
        Me.lbl_Pkg_Create_Date.Name = "lbl_Pkg_Create_Date"
        Me.lbl_Pkg_Create_Date.Size = New System.Drawing.Size(181, 20)
        Me.lbl_Pkg_Create_Date.TabIndex = 355
        Me.lbl_Pkg_Create_Date.Text = "Package Create Date"
        '
        'dtp_Pkg_Create_Date
        '
        Me.dtp_Pkg_Create_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Pkg_Create_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Pkg_Create_Date.Location = New System.Drawing.Point(217, 133)
        Me.dtp_Pkg_Create_Date.Name = "dtp_Pkg_Create_Date"
        Me.dtp_Pkg_Create_Date.Size = New System.Drawing.Size(154, 22)
        Me.dtp_Pkg_Create_Date.TabIndex = 354
        Me.dtp_Pkg_Create_Date.Value = New Date(2019, 12, 21, 0, 0, 0, 0)
        '
        'lbl_pkg_name
        '
        Me.lbl_pkg_name.BackColor = System.Drawing.Color.Goldenrod
        Me.lbl_pkg_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pkg_name.ForeColor = System.Drawing.Color.Teal
        Me.lbl_pkg_name.Location = New System.Drawing.Point(460, 71)
        Me.lbl_pkg_name.Name = "lbl_pkg_name"
        Me.lbl_pkg_name.Size = New System.Drawing.Size(889, 64)
        Me.lbl_pkg_name.TabIndex = 0
        Me.lbl_pkg_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btb_Show_Iternary
        '
        Me.btb_Show_Iternary.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btb_Show_Iternary.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btb_Show_Iternary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btb_Show_Iternary.FlatAppearance.BorderSize = 0
        Me.btb_Show_Iternary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btb_Show_Iternary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_Show_Iternary.ForeColor = System.Drawing.Color.White
        Me.btb_Show_Iternary.Image = CType(resources.GetObject("btb_Show_Iternary.Image"), System.Drawing.Image)
        Me.btb_Show_Iternary.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btb_Show_Iternary.Location = New System.Drawing.Point(1157, 612)
        Me.btb_Show_Iternary.Name = "btb_Show_Iternary"
        Me.btb_Show_Iternary.Size = New System.Drawing.Size(140, 44)
        Me.btb_Show_Iternary.TabIndex = 43
        Me.btb_Show_Iternary.Text = "Reschedule"
        Me.btb_Show_Iternary.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btb_Show_Iternary.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(559, 634)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(98, 46)
        Me.btn_Back.TabIndex = 565
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'frm_Schedule_Pkg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btb_Show_Iternary)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_out_dated_tours)
        Me.Controls.Add(Me.lbl_Capacity_is_Full)
        Me.Controls.Add(Me.lbl_Out_Dated_Package)
        Me.Controls.Add(Me.panel_out_dated_tours)
        Me.Controls.Add(Me.panel_Capacity_is_Full)
        Me.Controls.Add(Me.panel_Out_dated_Package)
        Me.Controls.Add(Me.panel_Schedule_pkg)
        Me.Controls.Add(Me.lbl_pkg_name)
        Me.Name = "frm_Schedule_Pkg"
        Me.Text = "Schedule_Pkg"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Schedule_pkg.ResumeLayout(False)
        Me.panel_Schedule_pkg.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_Schedule_pkg As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Schedule_pkg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_Out_dated_Package As System.Windows.Forms.Panel
    Friend WithEvents panel_Capacity_is_Full As System.Windows.Forms.Panel
    Friend WithEvents panel_out_dated_tours As System.Windows.Forms.Panel
    Friend WithEvents lbl_Out_Dated_Package As System.Windows.Forms.Label
    Friend WithEvents lbl_Capacity_is_Full As System.Windows.Forms.Label
    Friend WithEvents lbl_out_dated_tours As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_pkg_name As System.Windows.Forms.Label
    Friend WithEvents dtp_pkg_Expiry_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Expiry_Date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Pkg_Create_Date As System.Windows.Forms.Label
    Friend WithEvents dtp_Pkg_Create_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_Persons_Capacity As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Package_Person_Capacity As System.Windows.Forms.Label
    Friend WithEvents dtp_chg_expiry_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tour_expiry_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Out_dated_Tour_Date As System.Windows.Forms.Label
    Friend WithEvents cb_tour_dates As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_chg_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tour_start_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Days As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Days As System.Windows.Forms.Label
    Friend WithEvents btb_Show_Iternary As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
