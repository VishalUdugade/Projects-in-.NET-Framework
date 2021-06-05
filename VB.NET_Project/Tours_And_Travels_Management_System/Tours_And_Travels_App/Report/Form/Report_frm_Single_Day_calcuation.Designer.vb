<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_frm_Single_Day_calcuation
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
        Me.lbl_Search_tp = New System.Windows.Forms.Label()
        Me.cb_Search_type = New System.Windows.Forms.ComboBox()
        Me.dtp_Search_Date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.CRV_Single_Day_Cal = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'lbl_Search_tp
        '
        Me.lbl_Search_tp.AutoSize = True
        Me.lbl_Search_tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search_tp.Location = New System.Drawing.Point(79, 39)
        Me.lbl_Search_tp.Name = "lbl_Search_tp"
        Me.lbl_Search_tp.Size = New System.Drawing.Size(109, 20)
        Me.lbl_Search_tp.TabIndex = 0
        Me.lbl_Search_tp.Text = "Search Type"
        '
        'cb_Search_type
        '
        Me.cb_Search_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Search_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Search_type.FormattingEnabled = True
        Me.cb_Search_type.Items.AddRange(New Object() {"Today", "Another Day"})
        Me.cb_Search_type.Location = New System.Drawing.Point(224, 36)
        Me.cb_Search_type.Name = "cb_Search_type"
        Me.cb_Search_type.Size = New System.Drawing.Size(229, 28)
        Me.cb_Search_type.TabIndex = 1
        '
        'dtp_Search_Date
        '
        Me.dtp_Search_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Search_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Search_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Search_Date.Location = New System.Drawing.Point(554, 38)
        Me.dtp_Search_Date.Name = "dtp_Search_Date"
        Me.dtp_Search_Date.Size = New System.Drawing.Size(200, 24)
        Me.dtp_Search_Date.TabIndex = 2
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(816, 35)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(97, 29)
        Me.btn_Search.TabIndex = 3
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'CRV_Single_Day_Cal
        '
        Me.CRV_Single_Day_Cal.ActiveViewIndex = -1
        Me.CRV_Single_Day_Cal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Single_Day_Cal.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Single_Day_Cal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CRV_Single_Day_Cal.Location = New System.Drawing.Point(0, 105)
        Me.CRV_Single_Day_Cal.Name = "CRV_Single_Day_Cal"
        Me.CRV_Single_Day_Cal.Size = New System.Drawing.Size(1350, 624)
        Me.CRV_Single_Day_Cal.TabIndex = 4
        '
        'Report_frm_Single_Day_calcuation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.CRV_Single_Day_Cal)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.dtp_Search_Date)
        Me.Controls.Add(Me.cb_Search_type)
        Me.Controls.Add(Me.lbl_Search_tp)
        Me.Name = "Report_frm_Single_Day_calcuation"
        Me.Text = "Single_Day_calcuation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Search_tp As System.Windows.Forms.Label
    Friend WithEvents cb_Search_type As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_Search_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents CRV_Single_Day_Cal As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
