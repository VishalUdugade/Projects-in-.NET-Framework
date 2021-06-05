<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Add_Travellers_Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Add_Travellers_Information))
        Me.panel_form_Index = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Addhar_No = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_DOB = New System.Windows.Forms.Label()
        Me.lbl_Passe_Sex = New System.Windows.Forms.Label()
        Me.lbl_Passenger_Name = New System.Windows.Forms.Label()
        Me.lbl_Sr_No = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_Designe = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_Edit_Travellers_No = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_Add_Travellers_Info = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_form_Index.SuspendLayout()
        Me.panel_Add_Package.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_form_Index
        '
        Me.panel_form_Index.BackColor = System.Drawing.Color.Khaki
        Me.panel_form_Index.BackgroundImage = CType(resources.GetObject("panel_form_Index.BackgroundImage"), System.Drawing.Image)
        Me.panel_form_Index.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_form_Index.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_form_Index.Controls.Add(Me.lbl_Addhar_No)
        Me.panel_form_Index.Controls.Add(Me.lbl_Age)
        Me.panel_form_Index.Controls.Add(Me.lbl_DOB)
        Me.panel_form_Index.Controls.Add(Me.lbl_Passe_Sex)
        Me.panel_form_Index.Controls.Add(Me.lbl_Passenger_Name)
        Me.panel_form_Index.Controls.Add(Me.lbl_Sr_No)
        Me.panel_form_Index.Controls.Add(Me.ShapeContainer1)
        Me.panel_form_Index.GradientBottomLeft = System.Drawing.Color.White
        Me.panel_form_Index.GradientBottomRight = System.Drawing.Color.White
        Me.panel_form_Index.GradientTopLeft = System.Drawing.Color.White
        Me.panel_form_Index.GradientTopRight = System.Drawing.Color.White
        Me.panel_form_Index.Location = New System.Drawing.Point(21, 103)
        Me.panel_form_Index.Name = "panel_form_Index"
        Me.panel_form_Index.Quality = 10
        Me.panel_form_Index.Size = New System.Drawing.Size(1191, 45)
        Me.panel_form_Index.TabIndex = 12
        '
        'lbl_Addhar_No
        '
        Me.lbl_Addhar_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Addhar_No.Location = New System.Drawing.Point(988, 0)
        Me.lbl_Addhar_No.Name = "lbl_Addhar_No"
        Me.lbl_Addhar_No.Size = New System.Drawing.Size(201, 43)
        Me.lbl_Addhar_No.TabIndex = 15
        Me.lbl_Addhar_No.Text = "Addhar No."
        Me.lbl_Addhar_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Age
        '
        Me.lbl_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(874, 0)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(110, 43)
        Me.lbl_Age.TabIndex = 5
        Me.lbl_Age.Text = "Age"
        Me.lbl_Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DOB
        '
        Me.lbl_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DOB.Location = New System.Drawing.Point(669, 0)
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(200, 43)
        Me.lbl_DOB.TabIndex = 4
        Me.lbl_DOB.Text = "DOB"
        Me.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Passe_Sex
        '
        Me.lbl_Passe_Sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Passe_Sex.Location = New System.Drawing.Point(506, 0)
        Me.lbl_Passe_Sex.Name = "lbl_Passe_Sex"
        Me.lbl_Passe_Sex.Size = New System.Drawing.Size(158, 45)
        Me.lbl_Passe_Sex.TabIndex = 3
        Me.lbl_Passe_Sex.Text = "Gender" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(M/F)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_Passe_Sex.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Passenger_Name
        '
        Me.lbl_Passenger_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Passenger_Name.Location = New System.Drawing.Point(114, 0)
        Me.lbl_Passenger_Name.Name = "lbl_Passenger_Name"
        Me.lbl_Passenger_Name.Size = New System.Drawing.Size(387, 43)
        Me.lbl_Passenger_Name.TabIndex = 2
        Me.lbl_Passenger_Name.Text = "Passenger Name"
        Me.lbl_Passenger_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Sr_No
        '
        Me.lbl_Sr_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sr_No.Location = New System.Drawing.Point(2, 0)
        Me.lbl_Sr_No.Name = "lbl_Sr_No"
        Me.lbl_Sr_No.Size = New System.Drawing.Size(104, 45)
        Me.lbl_Sr_No.TabIndex = 0
        Me.lbl_Sr_No.Text = "Sr No."
        Me.lbl_Sr_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1189, 43)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderWidth = 5
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 985
        Me.LineShape5.X2 = 985
        Me.LineShape5.Y1 = 0
        Me.LineShape5.Y2 = 44
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 5
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 871
        Me.LineShape4.X2 = 871
        Me.LineShape4.Y1 = 0
        Me.LineShape4.Y2 = 44
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 666
        Me.LineShape3.X2 = 666
        Me.LineShape3.Y1 = 1
        Me.LineShape3.Y2 = 45
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 503
        Me.LineShape2.X2 = 503
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 44
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 109
        Me.LineShape1.X2 = 109
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 44
        '
        'lbl_Designe
        '
        Me.lbl_Designe.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lbl_Designe.Location = New System.Drawing.Point(-3, 68)
        Me.lbl_Designe.Name = "lbl_Designe"
        Me.lbl_Designe.Size = New System.Drawing.Size(1323, 13)
        Me.lbl_Designe.TabIndex = 13
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.SystemColors.Control
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.btn_Edit_Travellers_No)
        Me.panel_Add_Package.Controls.Add(Me.btn_Back)
        Me.panel_Add_Package.Controls.Add(Me.lbl_Add_Travellers_Info)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.SteelBlue
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.SystemColors.ControlText
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.SystemColors.ButtonFace
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.Khaki
        Me.panel_Add_Package.Location = New System.Drawing.Point(1, 2)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1319, 64)
        Me.panel_Add_Package.TabIndex = 14
        '
        'btn_Edit_Travellers_No
        '
        Me.btn_Edit_Travellers_No.AutoSize = True
        Me.btn_Edit_Travellers_No.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit_Travellers_No.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Edit_Travellers_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit_Travellers_No.FlatAppearance.BorderSize = 0
        Me.btn_Edit_Travellers_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit_Travellers_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit_Travellers_No.ForeColor = System.Drawing.Color.White
        Me.btn_Edit_Travellers_No.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Pensil_Icon_32
        Me.btn_Edit_Travellers_No.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Edit_Travellers_No.Location = New System.Drawing.Point(1131, 11)
        Me.btn_Edit_Travellers_No.Name = "btn_Edit_Travellers_No"
        Me.btn_Edit_Travellers_No.Size = New System.Drawing.Size(147, 42)
        Me.btn_Edit_Travellers_No.TabIndex = 12
        Me.btn_Edit_Travellers_No.Text = "Edit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Travellers No"
        Me.btn_Edit_Travellers_No.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Edit_Travellers_No.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.Enabled = False
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(14, 11)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(95, 42)
        Me.btn_Back.TabIndex = 64
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_Add_Travellers_Info
        '
        Me.lbl_Add_Travellers_Info.AutoSize = True
        Me.lbl_Add_Travellers_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Add_Travellers_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Add_Travellers_Info.ForeColor = System.Drawing.Color.White
        Me.lbl_Add_Travellers_Info.Location = New System.Drawing.Point(431, 17)
        Me.lbl_Add_Travellers_Info.Name = "lbl_Add_Travellers_Info"
        Me.lbl_Add_Travellers_Info.Size = New System.Drawing.Size(402, 37)
        Me.lbl_Add_Travellers_Info.TabIndex = 0
        Me.lbl_Add_Travellers_Info.Text = "Add Traveller Information"
        '
        'frm_Add_Travellers_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1322, 437)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Controls.Add(Me.lbl_Designe)
        Me.Controls.Add(Me.panel_form_Index)
        Me.Name = "frm_Add_Travellers_Information"
        Me.Text = "Add_Travellers_Details"
        Me.panel_form_Index.ResumeLayout(False)
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_form_Index As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Sr_No As System.Windows.Forms.Label
    Friend WithEvents lbl_Designe As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Passenger_Name As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_Passe_Sex As System.Windows.Forms.Label
    Friend WithEvents lbl_DOB As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_Age As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_Edit_Travellers_No As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents lbl_Add_Travellers_Info As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Addhar_No As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
