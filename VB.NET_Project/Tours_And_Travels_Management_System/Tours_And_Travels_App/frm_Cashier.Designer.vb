<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cashier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btn_Customer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_banner = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.panel_Rec_Content = New System.Windows.Forms.Panel()
        Me.btn_view_package_to_cus = New System.Windows.Forms.Button()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btn_Bill = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Rec_Content.SuspendLayout()
        Me.gbTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1359, 18)
        Me.Label2.TabIndex = 98
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btn_Customer
        '
        Me.btn_Customer.AutoSize = True
        Me.btn_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Customer.FlatAppearance.BorderSize = 0
        Me.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customer.Image = Global.Tours_And_Travels_App.My.Resources.Resources.user_add_icon
        Me.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Customer.Location = New System.Drawing.Point(570, 155)
        Me.btn_Customer.Name = "btn_Customer"
        Me.btn_Customer.Size = New System.Drawing.Size(167, 157)
        Me.btn_Customer.TabIndex = 110
        Me.btn_Customer.Text = " Customer"
        Me.btn_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Customer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.india_banner_small
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(6, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1098, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'lbl_banner
        '
        Me.lbl_banner.AutoSize = True
        Me.lbl_banner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_banner.Font = New System.Drawing.Font("Modern No. 20", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_banner.Location = New System.Drawing.Point(4, 1)
        Me.lbl_banner.Name = "lbl_banner"
        Me.lbl_banner.Size = New System.Drawing.Size(513, 48)
        Me.lbl_banner.TabIndex = 102
        Me.lbl_banner.Text = "Intrip Tours and Travels"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Apps_session_logout_icon
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.Location = New System.Drawing.Point(1258, 405)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(70, 52)
        Me.btn_logout.TabIndex = 62
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.UseVisualStyleBackColor = False
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
        'panel_Rec_Content
        '
        Me.panel_Rec_Content.AutoSize = True
        Me.panel_Rec_Content.BackColor = System.Drawing.Color.DarkKhaki
        Me.panel_Rec_Content.Controls.Add(Me.btn_Bill)
        Me.panel_Rec_Content.Controls.Add(Me.btn_Customer)
        Me.panel_Rec_Content.Controls.Add(Me.btn_logout)
        Me.panel_Rec_Content.Controls.Add(Me.btn_view_package_to_cus)
        Me.panel_Rec_Content.Location = New System.Drawing.Point(1, 275)
        Me.panel_Rec_Content.Name = "panel_Rec_Content"
        Me.panel_Rec_Content.Size = New System.Drawing.Size(1349, 463)
        Me.panel_Rec_Content.TabIndex = 99
        '
        'btn_view_package_to_cus
        '
        Me.btn_view_package_to_cus.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_view_package_to_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_package_to_cus.FlatAppearance.BorderSize = 0
        Me.btn_view_package_to_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_package_to_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_package_to_cus.Image = Global.Tours_And_Travels_App.My.Resources.Resources.eye_icon__1_
        Me.btn_view_package_to_cus.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view_package_to_cus.Location = New System.Drawing.Point(186, 169)
        Me.btn_view_package_to_cus.Name = "btn_view_package_to_cus"
        Me.btn_view_package_to_cus.Size = New System.Drawing.Size(167, 143)
        Me.btn_view_package_to_cus.TabIndex = 71
        Me.btn_view_package_to_cus.Text = "View Packages"
        Me.btn_view_package_to_cus.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_view_package_to_cus.UseVisualStyleBackColor = True
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
        Me.gbTime.Location = New System.Drawing.Point(1098, -2)
        Me.gbTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTime.Size = New System.Drawing.Size(255, 172)
        Me.gbTime.TabIndex = 101
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Time and Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1359, 75)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Cashier"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1354
        Me.LineShape3.X2 = -4
        Me.LineShape3.Y1 = 269
        Me.LineShape3.Y2 = 269
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 741)
        Me.ShapeContainer1.TabIndex = 103
        Me.ShapeContainer1.TabStop = False
        '
        'btn_Bill
        '
        Me.btn_Bill.AutoSize = True
        Me.btn_Bill.BackColor = System.Drawing.Color.Transparent
        Me.btn_Bill.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Bill.FlatAppearance.BorderSize = 0
        Me.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bill.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Electronic_billing_machine_Icon_128
        Me.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Bill.Location = New System.Drawing.Point(979, 155)
        Me.btn_Bill.Name = "btn_Bill"
        Me.btn_Bill.Size = New System.Drawing.Size(199, 143)
        Me.btn_Bill.TabIndex = 111
        Me.btn_Bill.Text = "Bill"
        Me.btn_Bill.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Bill.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(513, 48)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Intrip Tours and Travels"
        '
        'Timer1
        '
        '
        'frm_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_banner)
        Me.Controls.Add(Me.panel_Rec_Content)
        Me.Controls.Add(Me.gbTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_Cashier"
        Me.Text = "Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Rec_Content.ResumeLayout(False)
        Me.panel_Rec_Content.PerformLayout()
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btn_Customer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_banner As System.Windows.Forms.Label
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents panel_Rec_Content As System.Windows.Forms.Panel
    Friend WithEvents btn_view_package_to_cus As System.Windows.Forms.Button
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents gbTime As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btn_Bill As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
