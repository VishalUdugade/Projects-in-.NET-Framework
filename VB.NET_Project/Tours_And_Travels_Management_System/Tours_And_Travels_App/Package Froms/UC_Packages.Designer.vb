<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Packages
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
        Me.lbl_Pkg_Name = New System.Windows.Forms.Label()
        Me.pb_Pkg_Img = New System.Windows.Forms.PictureBox()
        Me.btn_pkg_view = New System.Windows.Forms.Button()
        Me.tb_pkg_id = New System.Windows.Forms.TextBox()
        CType(Me.pb_Pkg_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Pkg_Name
        '
        Me.lbl_Pkg_Name.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_Pkg_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Pkg_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Name.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Pkg_Name.Location = New System.Drawing.Point(3, 207)
        Me.lbl_Pkg_Name.Name = "lbl_Pkg_Name"
        Me.lbl_Pkg_Name.Size = New System.Drawing.Size(272, 42)
        Me.lbl_Pkg_Name.TabIndex = 3
        Me.lbl_Pkg_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_Pkg_Img
        '
        Me.pb_Pkg_Img.Location = New System.Drawing.Point(3, 3)
        Me.pb_Pkg_Img.Name = "pb_Pkg_Img"
        Me.pb_Pkg_Img.Size = New System.Drawing.Size(271, 201)
        Me.pb_Pkg_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Pkg_Img.TabIndex = 0
        Me.pb_Pkg_Img.TabStop = False
        '
        'btn_pkg_view
        '
        Me.btn_pkg_view.AutoSize = True
        Me.btn_pkg_view.BackColor = System.Drawing.Color.Khaki
        Me.btn_pkg_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pkg_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pkg_view.Location = New System.Drawing.Point(3, 254)
        Me.btn_pkg_view.Name = "btn_pkg_view"
        Me.btn_pkg_view.Size = New System.Drawing.Size(272, 32)
        Me.btn_pkg_view.TabIndex = 4
        Me.btn_pkg_view.Text = "Show Package"
        Me.btn_pkg_view.UseVisualStyleBackColor = False
        '
        'tb_pkg_id
        '
        Me.tb_pkg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pkg_id.Location = New System.Drawing.Point(9, 177)
        Me.tb_pkg_id.Name = "tb_pkg_id"
        Me.tb_pkg_id.Size = New System.Drawing.Size(100, 22)
        Me.tb_pkg_id.TabIndex = 5
        Me.tb_pkg_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UC_Packages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tb_pkg_id)
        Me.Controls.Add(Me.btn_pkg_view)
        Me.Controls.Add(Me.lbl_Pkg_Name)
        Me.Controls.Add(Me.pb_Pkg_Img)
        Me.Name = "UC_Packages"
        Me.Size = New System.Drawing.Size(280, 295)
        CType(Me.pb_Pkg_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_Pkg_Img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Pkg_Name As System.Windows.Forms.Label
    Friend WithEvents btn_pkg_view As System.Windows.Forms.Button
    Friend WithEvents tb_pkg_id As System.Windows.Forms.TextBox

End Class
