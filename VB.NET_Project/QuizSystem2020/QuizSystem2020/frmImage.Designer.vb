<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImage
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.imgShow = New System.Windows.Forms.PictureBox()
        Me.btn_submit_score = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_points = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_team = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_subject = New System.Windows.Forms.ComboBox()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtQNumber = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtopd = New System.Windows.Forms.Button()
        Me.txtopb = New System.Windows.Forms.Button()
        Me.txtopc = New System.Windows.Forms.Button()
        Me.txtopa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.imgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShow.Location = New System.Drawing.Point(186, 646)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(81, 34)
        Me.btnShow.TabIndex = 242
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'imgShow
        '
        Me.imgShow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.imgShow.Location = New System.Drawing.Point(340, 52)
        Me.imgShow.Name = "imgShow"
        Me.imgShow.Size = New System.Drawing.Size(422, 288)
        Me.imgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgShow.TabIndex = 241
        Me.imgShow.TabStop = False
        '
        'btn_submit_score
        '
        Me.btn_submit_score.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_submit_score.Location = New System.Drawing.Point(947, 642)
        Me.btn_submit_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_submit_score.Name = "btn_submit_score"
        Me.btn_submit_score.Size = New System.Drawing.Size(96, 36)
        Me.btn_submit_score.TabIndex = 280
        Me.btn_submit_score.Text = "Submit"
        Me.btn_submit_score.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(768, 644)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "Points"
        '
        'cmb_points
        '
        Me.cmb_points.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_points.FormattingEnabled = True
        Me.cmb_points.Items.AddRange(New Object() {"10", "5"})
        Me.cmb_points.Location = New System.Drawing.Point(869, 644)
        Me.cmb_points.Name = "cmb_points"
        Me.cmb_points.Size = New System.Drawing.Size(72, 33)
        Me.cmb_points.TabIndex = 278
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(581, 645)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 33)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Team"
        '
        'cmb_team
        '
        Me.cmb_team.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_team.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_team.FormattingEnabled = True
        Me.cmb_team.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmb_team.Location = New System.Drawing.Point(690, 644)
        Me.cmb_team.Name = "cmb_team"
        Me.cmb_team.Size = New System.Drawing.Size(72, 33)
        Me.cmb_team.TabIndex = 276
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(123, 643)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 34)
        Me.Button3.TabIndex = 275
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 641)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 34)
        Me.Button1.TabIndex = 274
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_subject
        '
        Me.cmb_subject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_subject.FormattingEnabled = True
        Me.cmb_subject.Location = New System.Drawing.Point(12, 598)
        Me.cmb_subject.Name = "cmb_subject"
        Me.cmb_subject.Size = New System.Drawing.Size(202, 33)
        Me.cmb_subject.TabIndex = 273
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.Green
        Me.btnOptions.Location = New System.Drawing.Point(273, 646)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(89, 36)
        Me.btnOptions.TabIndex = 272
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnswer.Location = New System.Drawing.Point(373, 646)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(117, 36)
        Me.btnAnswer.TabIndex = 271
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtQNumber
        '
        Me.txtQNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNumber.ForeColor = System.Drawing.Color.Blue
        Me.txtQNumber.Location = New System.Drawing.Point(68, 643)
        Me.txtQNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQNumber.Name = "txtQNumber"
        Me.txtQNumber.Size = New System.Drawing.Size(49, 32)
        Me.txtQNumber.TabIndex = 268
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(496, 648)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 34)
        Me.btnStop.TabIndex = 270
        Me.btnStop.Text = "Clear"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtopd)
        Me.Panel1.Controls.Add(Me.txtopb)
        Me.Panel1.Controls.Add(Me.txtopc)
        Me.Panel1.Controls.Add(Me.txtopa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(192, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 144)
        Me.Panel1.TabIndex = 283
        '
        'txtopd
        '
        Me.txtopd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopd.ForeColor = System.Drawing.Color.Black
        Me.txtopd.Location = New System.Drawing.Point(456, 89)
        Me.txtopd.Name = "txtopd"
        Me.txtopd.Size = New System.Drawing.Size(203, 45)
        Me.txtopd.TabIndex = 250
        Me.txtopd.UseVisualStyleBackColor = True
        '
        'txtopb
        '
        Me.txtopb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopb.ForeColor = System.Drawing.Color.Black
        Me.txtopb.Location = New System.Drawing.Point(456, 17)
        Me.txtopb.Name = "txtopb"
        Me.txtopb.Size = New System.Drawing.Size(203, 45)
        Me.txtopb.TabIndex = 249
        Me.txtopb.UseVisualStyleBackColor = True
        '
        'txtopc
        '
        Me.txtopc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopc.ForeColor = System.Drawing.Color.Black
        Me.txtopc.Location = New System.Drawing.Point(121, 89)
        Me.txtopc.Name = "txtopc"
        Me.txtopc.Size = New System.Drawing.Size(203, 45)
        Me.txtopc.TabIndex = 248
        Me.txtopc.UseVisualStyleBackColor = True
        '
        'txtopa
        '
        Me.txtopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopa.ForeColor = System.Drawing.Color.Black
        Me.txtopa.Location = New System.Drawing.Point(121, 17)
        Me.txtopa.Name = "txtopa"
        Me.txtopa.Size = New System.Drawing.Size(203, 45)
        Me.txtopa.TabIndex = 247
        Me.txtopa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(341, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 33)
        Me.Label4.TabIndex = 246
        Me.Label4.Text = "Option D"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 33)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Option C"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(343, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 33)
        Me.Label2.TabIndex = 244
        Me.Label2.Text = "Option B"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 33)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Option A"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Red
        Me.txtQuestion.Location = New System.Drawing.Point(58, 357)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(899, 51)
        Me.txtQuestion.TabIndex = 282
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.DarkViolet
        Me.txtAnswer.Location = New System.Drawing.Point(236, 568)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(657, 63)
        Me.txtAnswer.TabIndex = 281
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnswer.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 46)
        Me.Panel2.TabIndex = 284
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.LightGreen
        Me.OvalShape1.Location = New System.Drawing.Point(983, 685)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.OvalShape1.Size = New System.Drawing.Size(17, 15)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1055, 702)
        Me.ShapeContainer1.TabIndex = 285
        Me.ShapeContainer1.TabStop = False
        '
        'frmImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1055, 702)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btn_submit_score)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_points)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_team)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_subject)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtQNumber)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.imgShow)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents imgShow As System.Windows.Forms.PictureBox
    Friend WithEvents btn_submit_score As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_points As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_team As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtQNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtopd As System.Windows.Forms.Button
    Friend WithEvents txtopb As System.Windows.Forms.Button
    Friend WithEvents txtopc As System.Windows.Forms.Button
    Friend WithEvents txtopa As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
