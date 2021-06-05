<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_frm_Tour_Dates_Cust
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Search_Type = New System.Windows.Forms.ComboBox()
        Me.cb_Type_Name = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Tour_Start_Date = New System.Windows.Forms.ComboBox()
        Me.cb_Tour_End_Date = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.CRV_Tours_Date_Customer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Type"
        '
        'cb_Search_Type
        '
        Me.cb_Search_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Search_Type.FormattingEnabled = True
        Me.cb_Search_Type.Items.AddRange(New Object() {"Package ID", "Package Name"})
        Me.cb_Search_Type.Location = New System.Drawing.Point(180, 71)
        Me.cb_Search_Type.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cb_Search_Type.Name = "cb_Search_Type"
        Me.cb_Search_Type.Size = New System.Drawing.Size(199, 28)
        Me.cb_Search_Type.TabIndex = 1
        '
        'cb_Type_Name
        '
        Me.cb_Type_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_Type_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Type_Name.FormattingEnabled = True
        Me.cb_Type_Name.Location = New System.Drawing.Point(497, 71)
        Me.cb_Type_Name.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cb_Type_Name.Name = "cb_Type_Name"
        Me.cb_Type_Name.Size = New System.Drawing.Size(307, 28)
        Me.cb_Type_Name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(939, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tour Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1172, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tour End Date"
        '
        'cb_Tour_Start_Date
        '
        Me.cb_Tour_Start_Date.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_Tour_Start_Date.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Tour_Start_Date.FormattingEnabled = True
        Me.cb_Tour_Start_Date.Location = New System.Drawing.Point(897, 71)
        Me.cb_Tour_Start_Date.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cb_Tour_Start_Date.Name = "cb_Tour_Start_Date"
        Me.cb_Tour_Start_Date.Size = New System.Drawing.Size(199, 28)
        Me.cb_Tour_Start_Date.TabIndex = 5
        '
        'cb_Tour_End_Date
        '
        Me.cb_Tour_End_Date.Location = New System.Drawing.Point(1129, 71)
        Me.cb_Tour_End_Date.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cb_Tour_End_Date.Name = "cb_Tour_End_Date"
        Me.cb_Tour_End_Date.Size = New System.Drawing.Size(207, 26)
        Me.cb_Tour_End_Date.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(570, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter Search Name"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(31, 19)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(157, 29)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'CRV_Tours_Date_Customer
        '
        Me.CRV_Tours_Date_Customer.ActiveViewIndex = -1
        Me.CRV_Tours_Date_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Tours_Date_Customer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Tours_Date_Customer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CRV_Tours_Date_Customer.Location = New System.Drawing.Point(0, 134)
        Me.CRV_Tours_Date_Customer.Name = "CRV_Tours_Date_Customer"
        Me.CRV_Tours_Date_Customer.Size = New System.Drawing.Size(1350, 595)
        Me.CRV_Tours_Date_Customer.TabIndex = 9
        '
        'Report_frm_Tour_Dates_Cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.CRV_Tours_Date_Customer)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_Tour_End_Date)
        Me.Controls.Add(Me.cb_Tour_Start_Date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_Type_Name)
        Me.Controls.Add(Me.cb_Search_Type)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Report_frm_Tour_Dates_Cust"
        Me.Text = "Report_frm_Tour_Dates_Cust"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_Search_Type As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Type_Name As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Tour_Start_Date As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Tour_End_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents CRV_Tours_Date_Customer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
