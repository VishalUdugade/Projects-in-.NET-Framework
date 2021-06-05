<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usermanagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usermanagement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_Rec_Content = New System.Windows.Forms.Panel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.tb_lg_id = New System.Windows.Forms.TextBox()
        Me.lbl_lg_id = New System.Windows.Forms.Label()
        Me.panel_new_un_pas = New System.Windows.Forms.Panel()
        Me.tb_Usertype = New System.Windows.Forms.TextBox()
        Me.lbl_Usertype = New System.Windows.Forms.Label()
        Me.tb_new_pass = New System.Windows.Forms.TextBox()
        Me.tb_new_un = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_new_un = New System.Windows.Forms.Label()
        Me.cb_usertype = New System.Windows.Forms.ComboBox()
        Me.lbl_Select_ut = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_banner = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_Rec_Content.SuspendLayout()
        Me.panel_new_un_pas.SuspendLayout()
        Me.gbTime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1359, 59)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UserManagement"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_Rec_Content
        '
        Me.panel_Rec_Content.AutoSize = True
        Me.panel_Rec_Content.BackColor = System.Drawing.Color.DarkKhaki
        Me.panel_Rec_Content.Controls.Add(Me.btn_Back)
        Me.panel_Rec_Content.Controls.Add(Me.tb_lg_id)
        Me.panel_Rec_Content.Controls.Add(Me.lbl_lg_id)
        Me.panel_Rec_Content.Controls.Add(Me.panel_new_un_pas)
        Me.panel_Rec_Content.Controls.Add(Me.cb_usertype)
        Me.panel_Rec_Content.Controls.Add(Me.lbl_Select_ut)
        Me.panel_Rec_Content.Controls.Add(Me.btn_Clear)
        Me.panel_Rec_Content.Controls.Add(Me.btn_search)
        Me.panel_Rec_Content.Controls.Add(Me.tb_Password)
        Me.panel_Rec_Content.Controls.Add(Me.tb_Username)
        Me.panel_Rec_Content.Controls.Add(Me.lbl_Password)
        Me.panel_Rec_Content.Controls.Add(Me.lbl_Username)
        Me.panel_Rec_Content.Controls.Add(Me.btn_Update)
        Me.panel_Rec_Content.Controls.Add(Me.btn_Save)
        Me.panel_Rec_Content.Location = New System.Drawing.Point(0, 234)
        Me.panel_Rec_Content.Name = "panel_Rec_Content"
        Me.panel_Rec_Content.Size = New System.Drawing.Size(1366, 495)
        Me.panel_Rec_Content.TabIndex = 6
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(11, 443)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(102, 43)
        Me.btn_Back.TabIndex = 103
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'tb_lg_id
        '
        Me.tb_lg_id.Enabled = False
        Me.tb_lg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lg_id.Location = New System.Drawing.Point(317, 180)
        Me.tb_lg_id.Name = "tb_lg_id"
        Me.tb_lg_id.Size = New System.Drawing.Size(204, 22)
        Me.tb_lg_id.TabIndex = 13
        '
        'lbl_lg_id
        '
        Me.lbl_lg_id.AutoSize = True
        Me.lbl_lg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lg_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_lg_id.Location = New System.Drawing.Point(135, 181)
        Me.lbl_lg_id.Name = "lbl_lg_id"
        Me.lbl_lg_id.Size = New System.Drawing.Size(63, 16)
        Me.lbl_lg_id.TabIndex = 12
        Me.lbl_lg_id.Text = "Login Id"
        '
        'panel_new_un_pas
        '
        Me.panel_new_un_pas.Controls.Add(Me.tb_Usertype)
        Me.panel_new_un_pas.Controls.Add(Me.lbl_Usertype)
        Me.panel_new_un_pas.Controls.Add(Me.tb_new_pass)
        Me.panel_new_un_pas.Controls.Add(Me.tb_new_un)
        Me.panel_new_un_pas.Controls.Add(Me.Label2)
        Me.panel_new_un_pas.Controls.Add(Me.lbl_new_un)
        Me.panel_new_un_pas.Location = New System.Drawing.Point(748, 63)
        Me.panel_new_un_pas.Name = "panel_new_un_pas"
        Me.panel_new_un_pas.Size = New System.Drawing.Size(432, 160)
        Me.panel_new_un_pas.TabIndex = 11
        '
        'tb_Usertype
        '
        Me.tb_Usertype.Enabled = False
        Me.tb_Usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Usertype.Location = New System.Drawing.Point(205, 108)
        Me.tb_Usertype.Name = "tb_Usertype"
        Me.tb_Usertype.Size = New System.Drawing.Size(204, 22)
        Me.tb_Usertype.TabIndex = 13
        '
        'lbl_Usertype
        '
        Me.lbl_Usertype.AutoSize = True
        Me.lbl_Usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usertype.ForeColor = System.Drawing.Color.Black
        Me.lbl_Usertype.Location = New System.Drawing.Point(23, 109)
        Me.lbl_Usertype.Name = "lbl_Usertype"
        Me.lbl_Usertype.Size = New System.Drawing.Size(71, 16)
        Me.lbl_Usertype.TabIndex = 12
        Me.lbl_Usertype.Text = "Usertype"
        '
        'tb_new_pass
        '
        Me.tb_new_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_new_pass.Location = New System.Drawing.Point(205, 63)
        Me.tb_new_pass.Name = "tb_new_pass"
        Me.tb_new_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_new_pass.Size = New System.Drawing.Size(204, 22)
        Me.tb_new_pass.TabIndex = 10
        '
        'tb_new_un
        '
        Me.tb_new_un.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_new_un.Location = New System.Drawing.Point(205, 16)
        Me.tb_new_un.Name = "tb_new_un"
        Me.tb_new_un.Size = New System.Drawing.Size(204, 22)
        Me.tb_new_un.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Password"
        '
        'lbl_new_un
        '
        Me.lbl_new_un.AutoSize = True
        Me.lbl_new_un.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_un.ForeColor = System.Drawing.Color.Black
        Me.lbl_new_un.Location = New System.Drawing.Point(23, 17)
        Me.lbl_new_un.Name = "lbl_new_un"
        Me.lbl_new_un.Size = New System.Drawing.Size(113, 16)
        Me.lbl_new_un.TabIndex = 7
        Me.lbl_new_un.Text = "New Username"
        '
        'cb_usertype
        '
        Me.cb_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_usertype.FormattingEnabled = True
        Me.cb_usertype.Items.AddRange(New Object() {"Owner", "Cashier", "Receptionist"})
        Me.cb_usertype.Location = New System.Drawing.Point(317, 224)
        Me.cb_usertype.Name = "cb_usertype"
        Me.cb_usertype.Size = New System.Drawing.Size(204, 24)
        Me.cb_usertype.TabIndex = 8
        '
        'lbl_Select_ut
        '
        Me.lbl_Select_ut.AutoSize = True
        Me.lbl_Select_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Select_ut.ForeColor = System.Drawing.Color.Black
        Me.lbl_Select_ut.Location = New System.Drawing.Point(135, 225)
        Me.lbl_Select_ut.Name = "lbl_Select_ut"
        Me.lbl_Select_ut.Size = New System.Drawing.Size(119, 16)
        Me.lbl_Select_ut.TabIndex = 7
        Me.lbl_Select_ut.Text = "Select Usertype"
        '
        'btn_Clear
        '
        Me.btn_Clear.BackgroundImage = CType(resources.GetObject("btn_Clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(748, 385)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(108, 35)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackgroundImage = CType(resources.GetObject("btn_search.BackgroundImage"), System.Drawing.Image)
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_search.Location = New System.Drawing.Point(555, 69)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(105, 37)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'tb_Password
        '
        Me.tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.Location = New System.Drawing.Point(317, 131)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.Size = New System.Drawing.Size(204, 22)
        Me.tb_Password.TabIndex = 6
        '
        'tb_Username
        '
        Me.tb_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Username.Location = New System.Drawing.Point(317, 82)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(204, 22)
        Me.tb_Username.TabIndex = 5
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.ForeColor = System.Drawing.Color.Black
        Me.lbl_Password.Location = New System.Drawing.Point(135, 132)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(76, 16)
        Me.lbl_Password.TabIndex = 4
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.Black
        Me.lbl_Username.Location = New System.Drawing.Point(135, 83)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(79, 16)
        Me.lbl_Username.TabIndex = 3
        Me.lbl_Username.Text = "Username"
        '
        'btn_Update
        '
        Me.btn_Update.BackgroundImage = CType(resources.GetObject("btn_Update.BackgroundImage"), System.Drawing.Image)
        Me.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update.FlatAppearance.BorderSize = 0
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(565, 385)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(108, 35)
        Me.btn_Update.TabIndex = 2
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackgroundImage = CType(resources.GetObject("btn_Save.BackgroundImage"), System.Drawing.Image)
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(392, 385)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(110, 35)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'gbTime
        '
        Me.gbTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbTime.BackColor = System.Drawing.Color.Khaki
        Me.gbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbTime.Controls.Add(Me.lblZone)
        Me.gbTime.Controls.Add(Me.lblDate)
        Me.gbTime.Controls.Add(Me.lblTime)
        Me.gbTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTime.ForeColor = System.Drawing.Color.DarkOrange
        Me.gbTime.Location = New System.Drawing.Point(1094, -6)
        Me.gbTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Size = New System.Drawing.Size(261, 172)
        Me.gbTime.TabIndex = 94
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Time and Date"
        '
        'lblZone
        '
        Me.lblZone.AutoSize = True
        Me.lblZone.BackColor = System.Drawing.Color.Transparent
        Me.lblZone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblZone.Location = New System.Drawing.Point(6, 103)
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
        Me.lblDate.Location = New System.Drawing.Point(6, 66)
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.india_banner_small
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1098, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'lbl_banner
        '
        Me.lbl_banner.AutoSize = True
        Me.lbl_banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_banner.Font = New System.Drawing.Font("Modern No. 20", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_banner.Location = New System.Drawing.Point(3, 5)
        Me.lbl_banner.Name = "lbl_banner"
        Me.lbl_banner.Size = New System.Drawing.Size(513, 48)
        Me.lbl_banner.TabIndex = 96
        Me.lbl_banner.Text = "Intrip Tours and Travels"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1356, 729)
        Me.ShapeContainer1.TabIndex = 95
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1357
        Me.LineShape3.X2 = -1
        Me.LineShape3.Y1 = 230
        Me.LineShape3.Y2 = 230
        '
        'Timer1
        '
        '
        'frm_Usermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1356, 729)
        Me.Controls.Add(Me.lbl_banner)
        Me.Controls.Add(Me.gbTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panel_Rec_Content)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.IsMdiContainer = True
        Me.Name = "frm_Usermanagement"
        Me.Text = "Usermanagement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Rec_Content.ResumeLayout(False)
        Me.panel_Rec_Content.PerformLayout()
        Me.panel_new_un_pas.ResumeLayout(False)
        Me.panel_new_un_pas.PerformLayout()
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel_Rec_Content As System.Windows.Forms.Panel
    Friend WithEvents gbTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_banner As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents tb_Usertype As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Usertype As System.Windows.Forms.Label
    Friend WithEvents panel_new_un_pas As System.Windows.Forms.Panel
    Friend WithEvents tb_new_pass As System.Windows.Forms.TextBox
    Friend WithEvents tb_new_un As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_usertype As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Select_ut As System.Windows.Forms.Label
    Friend WithEvents lbl_new_un As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents tb_Username As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents tb_lg_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_lg_id As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
