<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Frm_bill
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
        Me.CRV_Bill = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRV_Bill
        '
        Me.CRV_Bill.ActiveViewIndex = -1
        Me.CRV_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Bill.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Bill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_Bill.Location = New System.Drawing.Point(0, 0)
        Me.CRV_Bill.Name = "CRV_Bill"
        Me.CRV_Bill.ReuseParameterValuesOnRefresh = True
        Me.CRV_Bill.ShowCloseButton = False
        Me.CRV_Bill.ShowExportButton = False
        Me.CRV_Bill.ShowGotoPageButton = False
        Me.CRV_Bill.ShowGroupTreeButton = False
        Me.CRV_Bill.ShowPageNavigateButtons = False
        Me.CRV_Bill.ShowParameterPanelButton = False
        Me.CRV_Bill.ShowTextSearchButton = False
        Me.CRV_Bill.Size = New System.Drawing.Size(1356, 729)
        Me.CRV_Bill.TabIndex = 0
        Me.CRV_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 729)
        Me.Controls.Add(Me.CRV_Bill)
        Me.Name = "frm_bill"
        Me.Text = "Bill"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_Bill As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
