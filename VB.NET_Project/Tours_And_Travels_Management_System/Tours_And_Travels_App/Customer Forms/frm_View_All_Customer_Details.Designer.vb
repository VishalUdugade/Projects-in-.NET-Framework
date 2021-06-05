<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_View_All_Customer_Details
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
        Me.panel_Add_Customer = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_view_All_Customer = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_All_Cust_Detail = New System.Windows.Forms.Panel()
        Me.dgv_Traveller = New System.Windows.Forms.DataGridView()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_All_Customer = New System.Windows.Forms.Button()
        Me.lbl_Customer_id = New System.Windows.Forms.Label()
        Me.tb_Customer_id = New System.Windows.Forms.TextBox()
        Me.dgv_View_All_Customer = New System.Windows.Forms.DataGridView()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.panel_Add_Customer.SuspendLayout()
        Me.panel_All_Cust_Detail.SuspendLayout()
        CType(Me.dgv_Traveller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_View_All_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Add_Customer
        '
        Me.panel_Add_Customer.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Customer.Controls.Add(Me.lbl_view_All_Customer)
        Me.panel_Add_Customer.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_Add_Customer.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panel_Add_Customer.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.panel_Add_Customer.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.panel_Add_Customer.Location = New System.Drawing.Point(-5, 1)
        Me.panel_Add_Customer.Name = "panel_Add_Customer"
        Me.panel_Add_Customer.Quality = 10
        Me.panel_Add_Customer.Size = New System.Drawing.Size(1354, 54)
        Me.panel_Add_Customer.TabIndex = 356
        '
        'lbl_view_All_Customer
        '
        Me.lbl_view_All_Customer.AutoSize = True
        Me.lbl_view_All_Customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_view_All_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_view_All_Customer.ForeColor = System.Drawing.Color.White
        Me.lbl_view_All_Customer.Location = New System.Drawing.Point(401, 6)
        Me.lbl_view_All_Customer.Name = "lbl_view_All_Customer"
        Me.lbl_view_All_Customer.Size = New System.Drawing.Size(470, 42)
        Me.lbl_view_All_Customer.TabIndex = 0
        Me.lbl_view_All_Customer.Text = "View All Customer Details"
        '
        'panel_All_Cust_Detail
        '
        Me.panel_All_Cust_Detail.BackColor = System.Drawing.Color.Khaki
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_Traveller)
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_Search)
        Me.panel_All_Cust_Detail.Controls.Add(Me.btn_All_Customer)
        Me.panel_All_Cust_Detail.Controls.Add(Me.lbl_Customer_id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.tb_Customer_id)
        Me.panel_All_Cust_Detail.Controls.Add(Me.dgv_View_All_Customer)
        Me.panel_All_Cust_Detail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel_All_Cust_Detail.Location = New System.Drawing.Point(4, 58)
        Me.panel_All_Cust_Detail.Name = "panel_All_Cust_Detail"
        Me.panel_All_Cust_Detail.Size = New System.Drawing.Size(1345, 578)
        Me.panel_All_Cust_Detail.TabIndex = 357
        '
        'dgv_Traveller
        '
        Me.dgv_Traveller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Traveller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Traveller.Location = New System.Drawing.Point(738, 63)
        Me.dgv_Traveller.Name = "dgv_Traveller"
        Me.dgv_Traveller.Size = New System.Drawing.Size(604, 502)
        Me.dgv_Traveller.TabIndex = 402
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
        Me.btn_Search.Location = New System.Drawing.Point(944, 10)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(101, 38)
        Me.btn_Search.TabIndex = 401
        Me.btn_Search.Text = "Search"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btn_All_Customer
        '
        Me.btn_All_Customer.AutoSize = True
        Me.btn_All_Customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_All_Customer.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_All_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_All_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_All_Customer.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_All_Customer.ForeColor = System.Drawing.Color.White
        Me.btn_All_Customer.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__6_
        Me.btn_All_Customer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_All_Customer.Location = New System.Drawing.Point(17, 10)
        Me.btn_All_Customer.Name = "btn_All_Customer"
        Me.btn_All_Customer.Size = New System.Drawing.Size(133, 40)
        Me.btn_All_Customer.TabIndex = 396
        Me.btn_All_Customer.Text = "All Customer"
        Me.btn_All_Customer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_All_Customer.UseVisualStyleBackColor = False
        '
        'lbl_Customer_id
        '
        Me.lbl_Customer_id.AutoSize = True
        Me.lbl_Customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer_id.Location = New System.Drawing.Point(557, 16)
        Me.lbl_Customer_id.Name = "lbl_Customer_id"
        Me.lbl_Customer_id.Size = New System.Drawing.Size(124, 24)
        Me.lbl_Customer_id.TabIndex = 356
        Me.lbl_Customer_id.Text = "Customer ID"
        '
        'tb_Customer_id
        '
        Me.tb_Customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Customer_id.Location = New System.Drawing.Point(697, 18)
        Me.tb_Customer_id.Name = "tb_Customer_id"
        Me.tb_Customer_id.Size = New System.Drawing.Size(188, 22)
        Me.tb_Customer_id.TabIndex = 357
        '
        'dgv_View_All_Customer
        '
        Me.dgv_View_All_Customer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_View_All_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_View_All_Customer.Location = New System.Drawing.Point(5, 63)
        Me.dgv_View_All_Customer.Name = "dgv_View_All_Customer"
        Me.dgv_View_All_Customer.Size = New System.Drawing.Size(735, 502)
        Me.dgv_View_All_Customer.TabIndex = 0
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(21, 668)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 37)
        Me.btn_Back.TabIndex = 566
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'frm_View_All_Customer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.panel_All_Cust_Detail)
        Me.Controls.Add(Me.panel_Add_Customer)
        Me.Name = "frm_View_All_Customer_Details"
        Me.Text = "View_All_Customer_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Add_Customer.ResumeLayout(False)
        Me.panel_Add_Customer.PerformLayout()
        Me.panel_All_Cust_Detail.ResumeLayout(False)
        Me.panel_All_Cust_Detail.PerformLayout()
        CType(Me.dgv_Traveller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_View_All_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Add_Customer As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_view_All_Customer As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_All_Cust_Detail As System.Windows.Forms.Panel
    Friend WithEvents lbl_Customer_id As System.Windows.Forms.Label
    Friend WithEvents tb_Customer_id As System.Windows.Forms.TextBox
    Friend WithEvents dgv_View_All_Customer As System.Windows.Forms.DataGridView
    Friend WithEvents btn_All_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents dgv_Traveller As System.Windows.Forms.DataGridView
End Class
