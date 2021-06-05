<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Show_Pkgs_to_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Show_Pkgs_to_Customer))
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_All_Package = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Budget = New System.Windows.Forms.Label()
        Me.tb_Min_Budget = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tb_Max_Budget = New System.Windows.Forms.TextBox()
        Me.lbl_Min_Budget = New System.Windows.Forms.Label()
        Me.lbl_Max_Budget = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.panel_search_pkg_budget = New System.Windows.Forms.Panel()
        Me.panel_view_pkg = New System.Windows.Forms.Panel()
        Me.btn_All_Pkg = New System.Windows.Forms.Button()
        Me.panel_Add_Package.SuspendLayout()
        Me.panel_search_pkg_budget.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.btn_Back)
        Me.panel_Add_Package.Controls.Add(Me.lbl_All_Package)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.SteelBlue
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.SystemColors.ControlText
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.SystemColors.ButtonFace
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.Khaki
        Me.panel_Add_Package.Location = New System.Drawing.Point(-3, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1386, 56)
        Me.panel_Add_Package.TabIndex = 1
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(14, 6)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(136, 44)
        Me.btn_Back.TabIndex = 358
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_All_Package
        '
        Me.lbl_All_Package.AutoSize = True
        Me.lbl_All_Package.BackColor = System.Drawing.Color.Transparent
        Me.lbl_All_Package.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_All_Package.ForeColor = System.Drawing.Color.White
        Me.lbl_All_Package.Location = New System.Drawing.Point(540, 8)
        Me.lbl_All_Package.Name = "lbl_All_Package"
        Me.lbl_All_Package.Size = New System.Drawing.Size(214, 37)
        Me.lbl_All_Package.TabIndex = 0
        Me.lbl_All_Package.Text = "All Packages"
        '
        'lbl_Budget
        '
        Me.lbl_Budget.AutoSize = True
        Me.lbl_Budget.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Budget.Location = New System.Drawing.Point(9, 28)
        Me.lbl_Budget.Name = "lbl_Budget"
        Me.lbl_Budget.Size = New System.Drawing.Size(268, 25)
        Me.lbl_Budget.TabIndex = 2
        Me.lbl_Budget.Text = "Enter Customers Budget"
        '
        'tb_Min_Budget
        '
        Me.tb_Min_Budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Min_Budget.Location = New System.Drawing.Point(334, 30)
        Me.tb_Min_Budget.Name = "tb_Min_Budget"
        Me.tb_Min_Budget.Size = New System.Drawing.Size(199, 24)
        Me.tb_Min_Budget.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1383, 712)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 1355
        Me.LineShape1.Y1 = 134
        Me.LineShape1.Y2 = 134
        '
        'tb_Max_Budget
        '
        Me.tb_Max_Budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Max_Budget.Location = New System.Drawing.Point(630, 28)
        Me.tb_Max_Budget.Name = "tb_Max_Budget"
        Me.tb_Max_Budget.Size = New System.Drawing.Size(199, 24)
        Me.tb_Max_Budget.TabIndex = 5
        '
        'lbl_Min_Budget
        '
        Me.lbl_Min_Budget.AutoSize = True
        Me.lbl_Min_Budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Min_Budget.Location = New System.Drawing.Point(391, 6)
        Me.lbl_Min_Budget.Name = "lbl_Min_Budget"
        Me.lbl_Min_Budget.Size = New System.Drawing.Size(92, 18)
        Me.lbl_Min_Budget.TabIndex = 6
        Me.lbl_Min_Budget.Text = "Min Budget"
        '
        'lbl_Max_Budget
        '
        Me.lbl_Max_Budget.AutoSize = True
        Me.lbl_Max_Budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Max_Budget.Location = New System.Drawing.Point(690, 6)
        Me.lbl_Max_Budget.Name = "lbl_Max_Budget"
        Me.lbl_Max_Budget.Size = New System.Drawing.Size(96, 18)
        Me.lbl_Max_Budget.TabIndex = 7
        Me.lbl_Max_Budget.Text = "Max Budget"
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
        Me.btn_Search.Location = New System.Drawing.Point(925, 14)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(101, 38)
        Me.btn_Search.TabIndex = 389
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'panel_search_pkg_budget
        '
        Me.panel_search_pkg_budget.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_search_pkg_budget.Controls.Add(Me.lbl_Min_Budget)
        Me.panel_search_pkg_budget.Controls.Add(Me.btn_Search)
        Me.panel_search_pkg_budget.Controls.Add(Me.lbl_Budget)
        Me.panel_search_pkg_budget.Controls.Add(Me.lbl_Max_Budget)
        Me.panel_search_pkg_budget.Controls.Add(Me.tb_Min_Budget)
        Me.panel_search_pkg_budget.Controls.Add(Me.tb_Max_Budget)
        Me.panel_search_pkg_budget.Location = New System.Drawing.Point(251, 63)
        Me.panel_search_pkg_budget.Name = "panel_search_pkg_budget"
        Me.panel_search_pkg_budget.Size = New System.Drawing.Size(1069, 61)
        Me.panel_search_pkg_budget.TabIndex = 390
        '
        'panel_view_pkg
        '
        Me.panel_view_pkg.AutoSize = True
        Me.panel_view_pkg.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.panel_view_pkg.Location = New System.Drawing.Point(0, 134)
        Me.panel_view_pkg.Name = "panel_view_pkg"
        Me.panel_view_pkg.Size = New System.Drawing.Size(1356, 578)
        Me.panel_view_pkg.TabIndex = 393
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
        Me.btn_All_Pkg.Location = New System.Drawing.Point(25, 75)
        Me.btn_All_Pkg.Name = "btn_All_Pkg"
        Me.btn_All_Pkg.Size = New System.Drawing.Size(133, 40)
        Me.btn_All_Pkg.TabIndex = 394
        Me.btn_All_Pkg.Text = "All Packages"
        Me.btn_All_Pkg.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_All_Pkg.UseVisualStyleBackColor = False
        '
        'frm_Show_Pkgs_to_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_All_Pkg)
        Me.Controls.Add(Me.panel_view_pkg)
        Me.Controls.Add(Me.panel_search_pkg_budget)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_Show_Pkgs_to_Customer"
        Me.Text = "View  Pkg to Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.panel_search_pkg_budget.ResumeLayout(False)
        Me.panel_search_pkg_budget.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_All_Package As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents lbl_Budget As System.Windows.Forms.Label
    Friend WithEvents tb_Min_Budget As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tb_Max_Budget As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Min_Budget As System.Windows.Forms.Label
    Friend WithEvents lbl_Max_Budget As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents panel_search_pkg_budget As System.Windows.Forms.Panel
    Friend WithEvents panel_view_pkg As System.Windows.Forms.Panel
    Friend WithEvents btn_All_Pkg As System.Windows.Forms.Button
End Class
