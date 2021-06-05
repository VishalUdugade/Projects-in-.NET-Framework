<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_View_All_Package
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_View_All_Package))
        Me.lbl_Search_Type = New System.Windows.Forms.Label()
        Me.dgv_Show_Pkg_Data = New System.Windows.Forms.DataGridView()
        Me.tb_Pkg_id = New System.Windows.Forms.TextBox()
        Me.panel_All_Cust_Detail = New System.Windows.Forms.Panel()
        Me.dgv_pkg_tours_dat = New System.Windows.Forms.DataGridView()
        Me.dgv_pkg_day_data = New System.Windows.Forms.DataGridView()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Pkg_Name = New System.Windows.Forms.Label()
        Me.lbl_Pkg_Id = New System.Windows.Forms.Label()
        Me.cb_Pkg_Nm = New System.Windows.Forms.ComboBox()
        Me.cb_Search_Type = New System.Windows.Forms.ComboBox()
        Me.btn_All_Pkg = New System.Windows.Forms.Button()
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_Show_Package_Data = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Back = New System.Windows.Forms.Button()
        CType(Me.dgv_Show_Pkg_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_All_Cust_Detail.SuspendLayout()
        CType(Me.dgv_pkg_tours_dat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pkg_day_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Add_Package.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Search_Type
        '
        Me.lbl_Search_Type.AutoSize = True
        Me.lbl_Search_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search_Type.Location = New System.Drawing.Point(277, 22)
        Me.lbl_Search_Type.Name = "lbl_Search_Type"
        Me.lbl_Search_Type.Size = New System.Drawing.Size(129, 24)
        Me.lbl_Search_Type.TabIndex = 356
        Me.lbl_Search_Type.Text = "Search Type"
        '
        'dgv_Show_Pkg_Data
        '
        Me.dgv_Show_Pkg_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Show_Pkg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Show_Pkg_Data.Location = New System.Drawing.Point(16, 63)
        Me.dgv_Show_Pkg_Data.Name = "dgv_Show_Pkg_Data"
        Me.dgv_Show_Pkg_Data.Size = New System.Drawing.Size(437, 478)
        Me.dgv_Show_Pkg_Data.TabIndex = 0
        '
        'tb_Pkg_id
        '
        Me.tb_Pkg_id.Enabled = False
        Me.tb_Pkg_id.Location = New System.Drawing.Point(854, 4)
        Me.tb_Pkg_id.Name = "tb_Pkg_id"
        Me.tb_Pkg_id.Size = New System.Drawing.Size(176, 20)
        Me.tb_Pkg_id.TabIndex = 357
        '
        'panel_All_Cust_Detail
        '
        Me.panel_All_Cust_Detail.BackColor = System.Drawing.Color.Khaki
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_pkg_tours_dat)
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_pkg_day_data)
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_Search)
        Me.panel_All_Cust_Detail.Controls.Add(Me.lbl_Pkg_Name)
        Me.panel_All_Cust_Detail.Controls.Add(Me.lbl_Pkg_Id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.cb_Pkg_Nm)
        Me.panel_All_Cust_Detail.Controls.Add(Me.cb_Search_Type)
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_All_Pkg)
        Me.panel_All_Cust_Detail.Controls.Add(Me.lbl_Search_Type)
        Me.panel_All_Cust_Detail.Controls.Add(Me.tb_Pkg_id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_Show_Pkg_Data)
        Me.panel_All_Cust_Detail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel_All_Cust_Detail.Location = New System.Drawing.Point(0, 63)
        Me.panel_All_Cust_Detail.Name = "panel_All_Cust_Detail"
        Me.panel_All_Cust_Detail.Size = New System.Drawing.Size(1362, 580)
        Me.panel_All_Cust_Detail.TabIndex = 360
        '
        'dgv_pkg_tours_dat
        '
        Me.dgv_pkg_tours_dat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_pkg_tours_dat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pkg_tours_dat.Location = New System.Drawing.Point(1127, 63)
        Me.dgv_pkg_tours_dat.Name = "dgv_pkg_tours_dat"
        Me.dgv_pkg_tours_dat.Size = New System.Drawing.Size(232, 478)
        Me.dgv_pkg_tours_dat.TabIndex = 402
        '
        'dgv_pkg_day_data
        '
        Me.dgv_pkg_day_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_pkg_day_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pkg_day_data.Location = New System.Drawing.Point(453, 63)
        Me.dgv_pkg_day_data.Name = "dgv_pkg_day_data"
        Me.dgv_pkg_day_data.Size = New System.Drawing.Size(676, 478)
        Me.dgv_pkg_day_data.TabIndex = 401
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
        'lbl_Pkg_Name
        '
        Me.lbl_Pkg_Name.AutoSize = True
        Me.lbl_Pkg_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Name.Location = New System.Drawing.Point(701, 39)
        Me.lbl_Pkg_Name.Name = "lbl_Pkg_Name"
        Me.lbl_Pkg_Name.Size = New System.Drawing.Size(115, 16)
        Me.lbl_Pkg_Name.TabIndex = 399
        Me.lbl_Pkg_Name.Text = "Package Name"
        '
        'lbl_Pkg_Id
        '
        Me.lbl_Pkg_Id.AutoSize = True
        Me.lbl_Pkg_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Id.Location = New System.Drawing.Point(727, 7)
        Me.lbl_Pkg_Id.Name = "lbl_Pkg_Id"
        Me.lbl_Pkg_Id.Size = New System.Drawing.Size(89, 16)
        Me.lbl_Pkg_Id.TabIndex = 398
        Me.lbl_Pkg_Id.Text = "Package ID"
        '
        'cb_Pkg_Nm
        '
        Me.cb_Pkg_Nm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Pkg_Nm.Enabled = False
        Me.cb_Pkg_Nm.FormattingEnabled = True
        Me.cb_Pkg_Nm.Location = New System.Drawing.Point(857, 36)
        Me.cb_Pkg_Nm.Name = "cb_Pkg_Nm"
        Me.cb_Pkg_Nm.Size = New System.Drawing.Size(296, 21)
        Me.cb_Pkg_Nm.TabIndex = 397
        '
        'cb_Search_Type
        '
        Me.cb_Search_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Search_Type.FormattingEnabled = True
        Me.cb_Search_Type.Items.AddRange(New Object() {"Package ID", "Package Name"})
        Me.cb_Search_Type.Location = New System.Drawing.Point(427, 22)
        Me.cb_Search_Type.Name = "cb_Search_Type"
        Me.cb_Search_Type.Size = New System.Drawing.Size(210, 21)
        Me.cb_Search_Type.TabIndex = 396
        '
        'btn_All_Pkg
        '
        Me.btn_All_Pkg.AutoSize = True
        Me.btn_All_Pkg.BackColor = System.Drawing.Color.Transparent
        Me.btn_All_Pkg.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_All_Pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_All_Pkg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_All_Pkg.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_All_Pkg.ForeColor = System.Drawing.Color.White
        Me.btn_All_Pkg.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_All_Pkg.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_All_Pkg.Location = New System.Drawing.Point(17, 12)
        Me.btn_All_Pkg.Name = "btn_All_Pkg"
        Me.btn_All_Pkg.Size = New System.Drawing.Size(133, 40)
        Me.btn_All_Pkg.TabIndex = 395
        Me.btn_All_Pkg.Text = "All Packages"
        Me.btn_All_Pkg.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_All_Pkg.UseVisualStyleBackColor = False
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.lbl_Show_Package_Data)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.Location = New System.Drawing.Point(0, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1362, 56)
        Me.panel_Add_Package.TabIndex = 361
        '
        'lbl_Show_Package_Data
        '
        Me.lbl_Show_Package_Data.AutoSize = True
        Me.lbl_Show_Package_Data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Show_Package_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Show_Package_Data.ForeColor = System.Drawing.Color.White
        Me.lbl_Show_Package_Data.Location = New System.Drawing.Point(516, 8)
        Me.lbl_Show_Package_Data.Name = "lbl_Show_Package_Data"
        Me.lbl_Show_Package_Data.Size = New System.Drawing.Size(324, 37)
        Me.lbl_Show_Package_Data.TabIndex = 0
        Me.lbl_Show_Package_Data.Text = "Show Package Data"
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(50, 672)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 37)
        Me.btn_Back.TabIndex = 565
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'frm_View_All_Package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Controls.Add(Me.panel_All_Cust_Detail)
        Me.Name = "frm_View_All_Package"
        Me.Text = "View_All_Package"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_Show_Pkg_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_All_Cust_Detail.ResumeLayout(False)
        Me.panel_All_Cust_Detail.PerformLayout()
        CType(Me.dgv_pkg_tours_dat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pkg_day_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Search_Type As System.Windows.Forms.Label
    Friend WithEvents dgv_Show_Pkg_Data As System.Windows.Forms.DataGridView
    Friend WithEvents tb_Pkg_id As System.Windows.Forms.TextBox
    Friend WithEvents panel_All_Cust_Detail As System.Windows.Forms.Panel
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Show_Package_Data As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_All_Pkg As System.Windows.Forms.Button
    Friend WithEvents lbl_Pkg_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Pkg_Id As System.Windows.Forms.Label
    Friend WithEvents cb_Pkg_Nm As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Search_Type As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents dgv_pkg_tours_dat As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_pkg_day_data As System.Windows.Forms.DataGridView
End Class
