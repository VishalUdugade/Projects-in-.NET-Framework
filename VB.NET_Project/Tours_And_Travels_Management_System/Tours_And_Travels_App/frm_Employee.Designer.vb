<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Employee))
        Me.lbl_banner = New System.Windows.Forms.Label()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Employee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add_Employee = New System.Windows.Forms.Button()
        Me.btn_Update_Employee = New System.Windows.Forms.Button()
        Me.btn_view_all_employee = New System.Windows.Forms.Button()
        Me.btn_Delete_Employee = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbTime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_banner
        '
        Me.lbl_banner.AutoSize = True
        Me.lbl_banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_banner.Font = New System.Drawing.Font("Modern No. 20", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_banner.Location = New System.Drawing.Point(12, 10)
        Me.lbl_banner.Name = "lbl_banner"
        Me.lbl_banner.Size = New System.Drawing.Size(513, 48)
        Me.lbl_banner.TabIndex = 45
        Me.lbl_banner.Text = "Intrip Tours and Travels"
        '
        'gbTime
        '
        Me.gbTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbTime.BackColor = System.Drawing.Color.Transparent
        Me.gbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbTime.Controls.Add(Me.lblZone)
        Me.gbTime.Controls.Add(Me.lblDate)
        Me.gbTime.Controls.Add(Me.lblTime)
        Me.gbTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTime.ForeColor = System.Drawing.Color.DarkOrange
        Me.gbTime.Location = New System.Drawing.Point(1093, -1)
        Me.gbTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Size = New System.Drawing.Size(255, 172)
        Me.gbTime.TabIndex = 90
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 729)
        Me.ShapeContainer1.TabIndex = 91
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 1353
        Me.LineShape1.Y1 = 301
        Me.LineShape1.Y2 = 301
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Administrator_Icon_25671
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape1.Location = New System.Drawing.Point(-28, 172)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(170, 136)
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(44, 678)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(129, 42)
        Me.btn_Back.TabIndex = 89
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Apps_session_logout_icon
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.Location = New System.Drawing.Point(1239, 660)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(70, 60)
        Me.btn_logout.TabIndex = 88
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.india_banner_small
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1091, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'lbl_Employee
        '
        Me.lbl_Employee.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Employee.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Employee.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_Employee.Location = New System.Drawing.Point(120, 171)
        Me.lbl_Employee.Name = "lbl_Employee"
        Me.lbl_Employee.Size = New System.Drawing.Size(1228, 108)
        Me.lbl_Employee.TabIndex = 92
        Me.lbl_Employee.Text = "Employee"
        Me.lbl_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(121, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1226, 21)
        Me.Label1.TabIndex = 93
        '
        'btn_Add_Employee
        '
        Me.btn_Add_Employee.AutoSize = True
        Me.btn_Add_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Add_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Add_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Employee.Image = CType(resources.GetObject("btn_Add_Employee.Image"), System.Drawing.Image)
        Me.btn_Add_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add_Employee.Location = New System.Drawing.Point(32, 382)
        Me.btn_Add_Employee.Name = "btn_Add_Employee"
        Me.btn_Add_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Add_Employee.TabIndex = 109
        Me.btn_Add_Employee.Text = "Add Employee"
        Me.btn_Add_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Add_Employee.UseVisualStyleBackColor = False
        '
        'btn_Update_Employee
        '
        Me.btn_Update_Employee.AutoSize = True
        Me.btn_Update_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Update_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Update_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Update_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Update_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_Employee.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Edit_Male_User_Icon_128
        Me.btn_Update_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Update_Employee.Location = New System.Drawing.Point(412, 382)
        Me.btn_Update_Employee.Name = "btn_Update_Employee"
        Me.btn_Update_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Update_Employee.TabIndex = 110
        Me.btn_Update_Employee.Text = "Update Employee"
        Me.btn_Update_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Update_Employee.UseVisualStyleBackColor = False
        '
        'btn_view_all_employee
        '
        Me.btn_view_all_employee.AutoSize = True
        Me.btn_view_all_employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_view_all_employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_view_all_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_all_employee.FlatAppearance.BorderSize = 0
        Me.btn_view_all_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_all_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_all_employee.Image = Global.Tours_And_Travels_App.My.Resources.Resources.eye_icon__1_
        Me.btn_view_all_employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view_all_employee.Location = New System.Drawing.Point(823, 382)
        Me.btn_view_all_employee.Name = "btn_view_all_employee"
        Me.btn_view_all_employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_view_all_employee.TabIndex = 111
        Me.btn_view_all_employee.Text = "View All Employee"
        Me.btn_view_all_employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_view_all_employee.UseVisualStyleBackColor = False
        '
        'btn_Delete_Employee
        '
        Me.btn_Delete_Employee.AutoSize = True
        Me.btn_Delete_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_Delete_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Delete_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete_Employee.FlatAppearance.BorderSize = 0
        Me.btn_Delete_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_Employee.Image = CType(resources.GetObject("btn_Delete_Employee.Image"), System.Drawing.Image)
        Me.btn_Delete_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Delete_Employee.Location = New System.Drawing.Point(1142, 382)
        Me.btn_Delete_Employee.Name = "btn_Delete_Employee"
        Me.btn_Delete_Employee.Size = New System.Drawing.Size(167, 157)
        Me.btn_Delete_Employee.TabIndex = 112
        Me.btn_Delete_Employee.Text = "Delete Employee"
        Me.btn_Delete_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Delete_Employee.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btn_Delete_Employee)
        Me.Controls.Add(Me.btn_view_all_employee)
        Me.Controls.Add(Me.btn_Update_Employee)
        Me.Controls.Add(Me.btn_Add_Employee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Employee)
        Me.Controls.Add(Me.gbTime)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.lbl_banner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_Employee"
        Me.Text = "Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_banner As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents gbTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_Employee As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Add_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_Update_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_view_all_employee As System.Windows.Forms.Button
    Friend WithEvents btn_Delete_Employee As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
