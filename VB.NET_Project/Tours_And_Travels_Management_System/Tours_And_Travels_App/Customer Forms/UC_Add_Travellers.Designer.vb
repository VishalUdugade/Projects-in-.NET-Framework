<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Add_Travellers
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
        Me.tb_Passenger_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Sr_no = New System.Windows.Forms.Label()
        Me.cb_Passe_Gender = New System.Windows.Forms.ComboBox()
        Me.dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.tb_Age = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tb_Addhar_No = New System.Windows.Forms.TextBox()
        Me.lbl_traveller_id = New System.Windows.Forms.Label()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_Passenger_Name
        '
        Me.tb_Passenger_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Passenger_Name.Location = New System.Drawing.Point(112, 1)
        Me.tb_Passenger_Name.Name = "tb_Passenger_Name"
        Me.tb_Passenger_Name.Size = New System.Drawing.Size(387, 27)
        Me.tb_Passenger_Name.TabIndex = 0
        '
        'lbl_Sr_no
        '
        Me.lbl_Sr_no.BackColor = System.Drawing.Color.White
        Me.lbl_Sr_no.Enabled = False
        Me.lbl_Sr_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Sr_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sr_no.Location = New System.Drawing.Point(3, 2)
        Me.lbl_Sr_no.Name = "lbl_Sr_no"
        Me.lbl_Sr_no.Size = New System.Drawing.Size(101, 26)
        Me.lbl_Sr_no.TabIndex = 1
        Me.lbl_Sr_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_Passe_Gender
        '
        Me.cb_Passe_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Passe_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Passe_Gender.FormattingEnabled = True
        Me.cb_Passe_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cb_Passe_Gender.Location = New System.Drawing.Point(505, 1)
        Me.cb_Passe_Gender.Name = "cb_Passe_Gender"
        Me.cb_Passe_Gender.Size = New System.Drawing.Size(158, 26)
        Me.cb_Passe_Gender.TabIndex = 2
        '
        'dtp_DOB
        '
        Me.dtp_DOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DOB.Location = New System.Drawing.Point(667, 2)
        Me.dtp_DOB.Name = "dtp_DOB"
        Me.dtp_DOB.Size = New System.Drawing.Size(200, 26)
        Me.dtp_DOB.TabIndex = 3
        Me.dtp_DOB.Value = New Date(2020, 1, 5, 0, 0, 0, 0)
        '
        'tb_Age
        '
        Me.tb_Age.Enabled = False
        Me.tb_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Age.Location = New System.Drawing.Point(871, 1)
        Me.tb_Age.Name = "tb_Age"
        Me.tb_Age.Size = New System.Drawing.Size(110, 27)
        Me.tb_Age.TabIndex = 4
        Me.tb_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1275, 32)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderWidth = 5
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 983
        Me.LineShape5.X2 = 983
        Me.LineShape5.Y1 = -3
        Me.LineShape5.Y2 = 29
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 5
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 869
        Me.LineShape4.X2 = 869
        Me.LineShape4.Y1 = -2
        Me.LineShape4.Y2 = 30
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 664
        Me.LineShape3.X2 = 664
        Me.LineShape3.Y1 = -3
        Me.LineShape3.Y2 = 27
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 501
        Me.LineShape2.X2 = 501
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 29
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 108
        Me.LineShape1.X2 = 108
        Me.LineShape1.Y1 = -2
        Me.LineShape1.Y2 = 31
        '
        'tb_Addhar_No
        '
        Me.tb_Addhar_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Addhar_No.Location = New System.Drawing.Point(986, 1)
        Me.tb_Addhar_No.MaxLength = 12
        Me.tb_Addhar_No.Name = "tb_Addhar_No"
        Me.tb_Addhar_No.Size = New System.Drawing.Size(201, 27)
        Me.tb_Addhar_No.TabIndex = 6
        '
        'lbl_traveller_id
        '
        Me.lbl_traveller_id.AutoSize = True
        Me.lbl_traveller_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_traveller_id.Location = New System.Drawing.Point(1224, 4)
        Me.lbl_traveller_id.Name = "lbl_traveller_id"
        Me.lbl_traveller_id.Size = New System.Drawing.Size(0, 18)
        Me.lbl_traveller_id.TabIndex = 17
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Khaki
        Me.btn_Next.FlatAppearance.BorderSize = 0
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(1193, 3)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(75, 23)
        Me.btn_Next.TabIndex = 18
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'UC_Add_Travellers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.lbl_traveller_id)
        Me.Controls.Add(Me.tb_Addhar_No)
        Me.Controls.Add(Me.tb_Age)
        Me.Controls.Add(Me.dtp_DOB)
        Me.Controls.Add(Me.cb_Passe_Gender)
        Me.Controls.Add(Me.lbl_Sr_no)
        Me.Controls.Add(Me.tb_Passenger_Name)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "UC_Add_Travellers"
        Me.Size = New System.Drawing.Size(1275, 32)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_Passenger_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Sr_no As System.Windows.Forms.Label
    Friend WithEvents cb_Passe_Gender As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tb_Addhar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_traveller_id As System.Windows.Forms.Label
    Friend WithEvents btn_Next As System.Windows.Forms.Button

End Class
