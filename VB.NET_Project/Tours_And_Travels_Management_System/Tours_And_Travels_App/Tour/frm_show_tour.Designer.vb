<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_tour
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_destin = New System.Windows.Forms.TextBox()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.btn_fetch = New System.Windows.Forms.Button()
        Me.pnl_tour = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        '     Me.PictureBox1.BackgroundImage = Global.Tours_And_Travels_Management_System.My.Resources.Resources.Tour_img
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2040, 184)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Azure
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(852, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 49)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Show Tours"
        '
        'tb_destin
        '
        Me.tb_destin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destin.Location = New System.Drawing.Point(674, 220)
        Me.tb_destin.MaxLength = 30
        Me.tb_destin.Name = "tb_destin"
        Me.tb_destin.Size = New System.Drawing.Size(327, 34)
        Me.tb_destin.TabIndex = 93
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.Location = New System.Drawing.Point(429, 220)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(152, 31)
        Me.lbl_to.TabIndex = 94
        Me.lbl_to.Text = "Destination"
        '
        'btn_fetch
        '
        Me.btn_fetch.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_fetch.Font = New System.Drawing.Font("Rockwell", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fetch.ForeColor = System.Drawing.Color.Azure
        Me.btn_fetch.Location = New System.Drawing.Point(1096, 206)
        Me.btn_fetch.Name = "btn_fetch"
        Me.btn_fetch.Size = New System.Drawing.Size(230, 55)
        Me.btn_fetch.TabIndex = 95
        Me.btn_fetch.Text = "Fetch"
        Me.btn_fetch.UseVisualStyleBackColor = False
        '
        'pnl_tour
        '
        Me.pnl_tour.AutoScroll = True
        Me.pnl_tour.AutoSize = True
        Me.pnl_tour.Location = New System.Drawing.Point(12, 265)
        Me.pnl_tour.Name = "pnl_tour"
        Me.pnl_tour.Size = New System.Drawing.Size(1874, 756)
        Me.pnl_tour.TabIndex = 97
        '
        'frm_show_tour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1054)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_tour)
        Me.Controls.Add(Me.btn_fetch)
        Me.Controls.Add(Me.tb_destin)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_show_tour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Tour"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_destin As System.Windows.Forms.TextBox
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents btn_fetch As System.Windows.Forms.Button
    Friend WithEvents pnl_tour As System.Windows.Forms.Panel
End Class
