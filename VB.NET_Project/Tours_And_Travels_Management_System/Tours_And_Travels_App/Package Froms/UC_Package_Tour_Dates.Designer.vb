<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Package_Tour_Dates
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
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_Sr_no = New System.Windows.Forms.Label()
        Me.dtp_Tour_Start_Date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Tour_End_Date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.tb_tour_date_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 315
        Me.LineShape2.X2 = 315
        Me.LineShape2.Y1 = -2
        Me.LineShape2.Y2 = 29
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 108
        Me.LineShape1.X2 = 108
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 30
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(691, 37)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 2
        Me.LineShape3.X2 = 520
        Me.LineShape3.Y1 = 32
        Me.LineShape3.Y2 = 32
        '
        'lbl_Sr_no
        '
        Me.lbl_Sr_no.BackColor = System.Drawing.Color.White
        Me.lbl_Sr_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Sr_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sr_no.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Sr_no.Name = "lbl_Sr_no"
        Me.lbl_Sr_no.Size = New System.Drawing.Size(101, 24)
        Me.lbl_Sr_no.TabIndex = 2
        Me.lbl_Sr_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_Tour_Start_Date
        '
        Me.dtp_Tour_Start_Date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_Tour_Start_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Tour_Start_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Tour_Start_Date.Location = New System.Drawing.Point(112, 3)
        Me.dtp_Tour_Start_Date.Name = "dtp_Tour_Start_Date"
        Me.dtp_Tour_Start_Date.Size = New System.Drawing.Size(200, 26)
        Me.dtp_Tour_Start_Date.TabIndex = 7
        Me.dtp_Tour_Start_Date.Value = New Date(2019, 12, 14, 0, 0, 0, 0)
        '
        'dtp_Tour_End_Date
        '
        Me.dtp_Tour_End_Date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_Tour_End_Date.Enabled = False
        Me.dtp_Tour_End_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Tour_End_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Tour_End_Date.Location = New System.Drawing.Point(319, 3)
        Me.dtp_Tour_End_Date.Name = "dtp_Tour_End_Date"
        Me.dtp_Tour_End_Date.Size = New System.Drawing.Size(200, 26)
        Me.dtp_Tour_End_Date.TabIndex = 8
        Me.dtp_Tour_End_Date.Value = New Date(2019, 12, 3, 0, 0, 0, 0)
        '
        'btn_Next
        '
        Me.btn_Next.Enabled = False
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(541, 5)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(75, 28)
        Me.btn_Next.TabIndex = 9
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = True
        '
        'tb_tour_date_id
        '
        Me.tb_tour_date_id.Enabled = False
        Me.tb_tour_date_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tour_date_id.Location = New System.Drawing.Point(636, 4)
        Me.tb_tour_date_id.Multiline = True
        Me.tb_tour_date_id.Name = "tb_tour_date_id"
        Me.tb_tour_date_id.Size = New System.Drawing.Size(44, 27)
        Me.tb_tour_date_id.TabIndex = 10
        Me.tb_tour_date_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UC_Package_Tour_Dates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tb_tour_date_id)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.dtp_Tour_End_Date)
        Me.Controls.Add(Me.dtp_Tour_Start_Date)
        Me.Controls.Add(Me.lbl_Sr_no)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "UC_Package_Tour_Dates"
        Me.Size = New System.Drawing.Size(691, 37)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lbl_Sr_no As System.Windows.Forms.Label
    Friend WithEvents dtp_Tour_Start_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Tour_End_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Next As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tb_tour_date_id As System.Windows.Forms.TextBox

End Class
