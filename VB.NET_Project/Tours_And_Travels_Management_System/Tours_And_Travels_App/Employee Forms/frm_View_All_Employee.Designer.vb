<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_View_All_Employee
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
        Me.panel_Schedule_pkg = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_View_All_Employee = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_All_Cust_Detail = New System.Windows.Forms.Panel()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Emp_id = New System.Windows.Forms.Label()
        Me.btn_All_Employee = New System.Windows.Forms.Button()
        Me.tb_Emp_id = New System.Windows.Forms.TextBox()
        Me.dgv_Show_Emp_Data = New System.Windows.Forms.DataGridView()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.panel_Schedule_pkg.SuspendLayout()
        Me.panel_All_Cust_Detail.SuspendLayout()
        CType(Me.dgv_Show_Emp_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Schedule_pkg
        '
        Me.panel_Schedule_pkg.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Schedule_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Schedule_pkg.Controls.Add(Me.lbl_View_All_Employee)
        Me.panel_Schedule_pkg.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_Schedule_pkg.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_Schedule_pkg.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_Schedule_pkg.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_Schedule_pkg.Location = New System.Drawing.Point(1, 1)
        Me.panel_Schedule_pkg.Name = "panel_Schedule_pkg"
        Me.panel_Schedule_pkg.Quality = 10
        Me.panel_Schedule_pkg.Size = New System.Drawing.Size(1348, 55)
        Me.panel_Schedule_pkg.TabIndex = 17
        '
        'lbl_View_All_Employee
        '
        Me.lbl_View_All_Employee.AutoSize = True
        Me.lbl_View_All_Employee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_View_All_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_View_All_Employee.ForeColor = System.Drawing.Color.White
        Me.lbl_View_All_Employee.Location = New System.Drawing.Point(579, 10)
        Me.lbl_View_All_Employee.Name = "lbl_View_All_Employee"
        Me.lbl_View_All_Employee.Size = New System.Drawing.Size(297, 37)
        Me.lbl_View_All_Employee.TabIndex = 0
        Me.lbl_View_All_Employee.Text = "View All Employee"
        '
        'panel_All_Cust_Detail
        '
        Me.panel_All_Cust_Detail.BackColor = System.Drawing.Color.Khaki
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_Search)
        Me.panel_All_Cust_Detail.Controls.Add(Me.lbl_Emp_id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_All_Employee)
        Me.panel_All_Cust_Detail.Controls.Add(Me.tb_Emp_id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_Show_Emp_Data)
        Me.panel_All_Cust_Detail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel_All_Cust_Detail.Location = New System.Drawing.Point(-6, 66)
        Me.panel_All_Cust_Detail.Name = "panel_All_Cust_Detail"
        Me.panel_All_Cust_Detail.Size = New System.Drawing.Size(1362, 559)
        Me.panel_All_Cust_Detail.TabIndex = 361
        '
        'btn_Search
        '
        Me.btn_Search.AutoSize = True
        Me.btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.btn_Search.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Search.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Search_Icon_32
        Me.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Search.Location = New System.Drawing.Point(1234, 14)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(101, 38)
        Me.btn_Search.TabIndex = 400
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'lbl_Emp_id
        '
        Me.lbl_Emp_id.AutoSize = True
        Me.lbl_Emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp_id.Location = New System.Drawing.Point(857, 23)
        Me.lbl_Emp_id.Name = "lbl_Emp_id"
        Me.lbl_Emp_id.Size = New System.Drawing.Size(111, 20)
        Me.lbl_Emp_id.TabIndex = 398
        Me.lbl_Emp_id.Text = "Employee ID"
        '
        'btn_All_Employee
        '
        Me.btn_All_Employee.AutoSize = True
        Me.btn_All_Employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_All_Employee.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_All_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_All_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_All_Employee.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_All_Employee.ForeColor = System.Drawing.Color.White
        Me.btn_All_Employee.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_All_Employee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_All_Employee.Location = New System.Drawing.Point(17, 12)
        Me.btn_All_Employee.Name = "btn_All_Employee"
        Me.btn_All_Employee.Size = New System.Drawing.Size(133, 40)
        Me.btn_All_Employee.TabIndex = 395
        Me.btn_All_Employee.Text = "All Employee"
        Me.btn_All_Employee.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_All_Employee.UseVisualStyleBackColor = False
        '
        'tb_Emp_id
        '
        Me.tb_Emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Emp_id.Location = New System.Drawing.Point(992, 22)
        Me.tb_Emp_id.Name = "tb_Emp_id"
        Me.tb_Emp_id.Size = New System.Drawing.Size(176, 26)
        Me.tb_Emp_id.TabIndex = 357
        '
        'dgv_Show_Emp_Data
        '
        Me.dgv_Show_Emp_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Show_Emp_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Show_Emp_Data.Location = New System.Drawing.Point(17, 63)
        Me.dgv_Show_Emp_Data.Name = "dgv_Show_Emp_Data"
        Me.dgv_Show_Emp_Data.ReadOnly = True
        Me.dgv_Show_Emp_Data.Size = New System.Drawing.Size(1333, 478)
        Me.dgv_Show_Emp_Data.TabIndex = 0
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(44, 652)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 37)
        Me.btn_Back.TabIndex = 566
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'frm_View_All_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.panel_All_Cust_Detail)
        Me.Controls.Add(Me.panel_Schedule_pkg)
        Me.Name = "frm_View_All_Employee"
        Me.Text = "View All Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Schedule_pkg.ResumeLayout(False)
        Me.panel_Schedule_pkg.PerformLayout()
        Me.panel_All_Cust_Detail.ResumeLayout(False)
        Me.panel_All_Cust_Detail.PerformLayout()
        CType(Me.dgv_Show_Emp_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Schedule_pkg As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_View_All_Employee As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_All_Cust_Detail As System.Windows.Forms.Panel
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents lbl_Emp_id As System.Windows.Forms.Label
    Friend WithEvents btn_All_Employee As System.Windows.Forms.Button
    Friend WithEvents tb_Emp_id As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Show_Emp_Data As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
