<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_frm_datewise_customer
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
        Me.panel_show_data = New System.Windows.Forms.Panel()
        Me.dtp_from_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_to_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_From = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panel_show_data
        '
        Me.panel_show_data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_show_data.Location = New System.Drawing.Point(0, 124)
        Me.panel_show_data.Name = "panel_show_data"
        Me.panel_show_data.Size = New System.Drawing.Size(1350, 605)
        Me.panel_show_data.TabIndex = 0
        '
        'dtp_from_date
        '
        Me.dtp_from_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from_date.Location = New System.Drawing.Point(177, 37)
        Me.dtp_from_date.Name = "dtp_from_date"
        Me.dtp_from_date.Size = New System.Drawing.Size(200, 29)
        Me.dtp_from_date.TabIndex = 1
        '
        'dtp_to_date
        '
        Me.dtp_to_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to_date.Location = New System.Drawing.Point(478, 37)
        Me.dtp_to_date.Name = "dtp_to_date"
        Me.dtp_to_date.Size = New System.Drawing.Size(200, 29)
        Me.dtp_to_date.TabIndex = 2
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_From.Location = New System.Drawing.Point(112, 41)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(50, 20)
        Me.lbl_From.TabIndex = 3
        Me.lbl_From.Text = "From"
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.Location = New System.Drawing.Point(435, 43)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(29, 20)
        Me.lbl_to.TabIndex = 4
        Me.lbl_to.Text = "To"
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(787, 35)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(97, 36)
        Me.btn_Search.TabIndex = 5
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'frm_datewise_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.dtp_to_date)
        Me.Controls.Add(Me.dtp_from_date)
        Me.Controls.Add(Me.panel_show_data)
        Me.Name = "frm_datewise_customer"
        Me.Text = "frm_datewise_customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_show_data As System.Windows.Forms.Panel
    Friend WithEvents dtp_from_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_to_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_From As System.Windows.Forms.Label
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
End Class
