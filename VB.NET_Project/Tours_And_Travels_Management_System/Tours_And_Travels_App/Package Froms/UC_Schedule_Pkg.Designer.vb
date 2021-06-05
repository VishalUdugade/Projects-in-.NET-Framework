<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Schedule_Pkg
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
        Me.btn_pkg_name = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_pkg_name
        '
        Me.btn_pkg_name.AutoSize = True
        Me.btn_pkg_name.BackColor = System.Drawing.Color.White
        Me.btn_pkg_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pkg_name.Location = New System.Drawing.Point(7, -1)
        Me.btn_pkg_name.Name = "btn_pkg_name"
        Me.btn_pkg_name.Size = New System.Drawing.Size(127, 42)
        Me.btn_pkg_name.TabIndex = 0
        Me.btn_pkg_name.UseVisualStyleBackColor = False
        '
        'UC_Schedule_Pkg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_pkg_name)
        Me.Name = "UC_Schedule_Pkg"
        Me.Size = New System.Drawing.Size(137, 44)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_pkg_name As System.Windows.Forms.Button

End Class
