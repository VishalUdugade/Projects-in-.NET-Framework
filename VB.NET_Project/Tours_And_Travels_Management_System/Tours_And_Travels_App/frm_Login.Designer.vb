<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.lbl_Tours_And_Travels = New System.Windows.Forms.Label()
        Me.pb_Receptionist = New System.Windows.Forms.PictureBox()
        Me.pb_Owner = New System.Windows.Forms.PictureBox()
        Me.pb_Cashier = New System.Windows.Forms.PictureBox()
        Me.lbl_User_Name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_Login = New System.Windows.Forms.Panel()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        CType(Me.pb_Receptionist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Cashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Tours_And_Travels
        '
        Me.lbl_Tours_And_Travels.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Tours_And_Travels.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tours_And_Travels.Location = New System.Drawing.Point(2, 2)
        Me.lbl_Tours_And_Travels.Name = "lbl_Tours_And_Travels"
        Me.lbl_Tours_And_Travels.Size = New System.Drawing.Size(619, 53)
        Me.lbl_Tours_And_Travels.TabIndex = 0
        Me.lbl_Tours_And_Travels.Text = "Tours and Travels"
        Me.lbl_Tours_And_Travels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_Receptionist
        '
        Me.pb_Receptionist.BackColor = System.Drawing.Color.Goldenrod
        Me.pb_Receptionist.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Receptionist_Icon_128
        Me.pb_Receptionist.Location = New System.Drawing.Point(107, 57)
        Me.pb_Receptionist.Name = "pb_Receptionist"
        Me.pb_Receptionist.Size = New System.Drawing.Size(100, 88)
        Me.pb_Receptionist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Receptionist.TabIndex = 2
        Me.pb_Receptionist.TabStop = False
        '
        'pb_Owner
        '
        Me.pb_Owner.BackColor = System.Drawing.Color.Goldenrod
        Me.pb_Owner.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Administrator_Icon_256
        Me.pb_Owner.Location = New System.Drawing.Point(3, 57)
        Me.pb_Owner.Name = "pb_Owner"
        Me.pb_Owner.Size = New System.Drawing.Size(100, 88)
        Me.pb_Owner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Owner.TabIndex = 1
        Me.pb_Owner.TabStop = False
        '
        'pb_Cashier
        '
        Me.pb_Cashier.BackColor = System.Drawing.Color.Goldenrod
        Me.pb_Cashier.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Administrator_Icon_25671
        Me.pb_Cashier.Location = New System.Drawing.Point(211, 57)
        Me.pb_Cashier.Name = "pb_Cashier"
        Me.pb_Cashier.Size = New System.Drawing.Size(100, 88)
        Me.pb_Cashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Cashier.TabIndex = 3
        Me.pb_Cashier.TabStop = False
        '
        'lbl_User_Name
        '
        Me.lbl_User_Name.BackColor = System.Drawing.Color.Khaki
        Me.lbl_User_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_User_Name.Location = New System.Drawing.Point(3, 149)
        Me.lbl_User_Name.Name = "lbl_User_Name"
        Me.lbl_User_Name.Size = New System.Drawing.Size(308, 39)
        Me.lbl_User_Name.TabIndex = 4
        Me.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(317, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 437)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'panel_Login
        '
        Me.panel_Login.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel_Login.Controls.Add(Me.lbl_Login)
        Me.panel_Login.Controls.Add(Me.tb_Password)
        Me.panel_Login.Controls.Add(Me.tb_Username)
        Me.panel_Login.Controls.Add(Me.btn_Clear)
        Me.panel_Login.Controls.Add(Me.btn_Login)
        Me.panel_Login.Controls.Add(Me.lbl_Password)
        Me.panel_Login.Controls.Add(Me.lbl_Username)
        Me.panel_Login.Location = New System.Drawing.Point(3, 191)
        Me.panel_Login.Name = "panel_Login"
        Me.panel_Login.Size = New System.Drawing.Size(308, 307)
        Me.panel_Login.TabIndex = 6
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.Location = New System.Drawing.Point(109, 10)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(53, 20)
        Me.lbl_Login.TabIndex = 6
        Me.lbl_Login.Text = "Login"
        '
        'tb_Password
        '
        Me.tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.Location = New System.Drawing.Point(151, 124)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.Size = New System.Drawing.Size(137, 22)
        Me.tb_Password.TabIndex = 2
        '
        'tb_Username
        '
        Me.tb_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Username.Location = New System.Drawing.Point(151, 59)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(137, 22)
        Me.tb_Username.TabIndex = 1
        '
        'btn_Clear
        '
        Me.btn_Clear.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Image = CType(resources.GetObject("btn_Clear.Image"), System.Drawing.Image)
        Me.btn_Clear.Location = New System.Drawing.Point(185, 225)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(103, 41)
        Me.btn_Clear.TabIndex = 3
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Login
        '
        Me.btn_Login.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Image = CType(resources.GetObject("btn_Login.Image"), System.Drawing.Image)
        Me.btn_Login.Location = New System.Drawing.Point(9, 225)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(103, 41)
        Me.btn_Login.TabIndex = 2
        Me.btn_Login.Text = "Login"
        Me.btn_Login.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(21, 124)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(86, 20)
        Me.lbl_Password.TabIndex = 1
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(21, 59)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(91, 20)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username"
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 499)
        Me.Controls.Add(Me.panel_Login)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_User_Name)
        Me.Controls.Add(Me.pb_Cashier)
        Me.Controls.Add(Me.pb_Receptionist)
        Me.Controls.Add(Me.pb_Owner)
        Me.Controls.Add(Me.lbl_Tours_And_Travels)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pb_Receptionist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Cashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Login.ResumeLayout(False)
        Me.panel_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Tours_And_Travels As System.Windows.Forms.Label
    Friend WithEvents pb_Owner As System.Windows.Forms.PictureBox
    Friend WithEvents pb_Receptionist As System.Windows.Forms.PictureBox
    Friend WithEvents pb_Cashier As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Login As System.Windows.Forms.Panel
    Friend WithEvents lbl_Login As System.Windows.Forms.Label
    Friend WithEvents tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents tb_Username As System.Windows.Forms.TextBox
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label

End Class
