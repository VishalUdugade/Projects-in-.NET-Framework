<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_frm_Single_Package_Report
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
        Me.cb_Package_Name = New System.Windows.Forms.ComboBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.CRV_Package_Calculation = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cb_Package_Name
        '
        Me.cb_Package_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_Package_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Package_Name.FormattingEnabled = True
        Me.cb_Package_Name.Location = New System.Drawing.Point(370, 31)
        Me.cb_Package_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.cb_Package_Name.Name = "cb_Package_Name"
        Me.cb_Package_Name.Size = New System.Drawing.Size(423, 28)
        Me.cb_Package_Name.TabIndex = 0
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(838, 19)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(172, 52)
        Me.btn_Search.TabIndex = 1
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'CRV_Package_Calculation
        '
        Me.CRV_Package_Calculation.ActiveViewIndex = -1
        Me.CRV_Package_Calculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Package_Calculation.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Package_Calculation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CRV_Package_Calculation.Location = New System.Drawing.Point(0, 108)
        Me.CRV_Package_Calculation.Name = "CRV_Package_Calculation"
        Me.CRV_Package_Calculation.Size = New System.Drawing.Size(1356, 633)
        Me.CRV_Package_Calculation.TabIndex = 2
        '
        'Report_frm_Single_Package_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.Controls.Add(Me.CRV_Package_Calculation)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.cb_Package_Name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Report_frm_Single_Package_Report"
        Me.Text = "Single_Package_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_Package_Name As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents CRV_Package_Calculation As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
