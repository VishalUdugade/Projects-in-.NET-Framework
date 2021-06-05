<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_View_Single_Package
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_View_Single_Package))
        Me.lbl_Pkg_Day_Night = New System.Windows.Forms.Label()
        Me.lbl_Pkg_Name = New System.Windows.Forms.Label()
        Me.lbl_Pkg_Route = New System.Windows.Forms.Label()
        Me.tb_Grand_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Grand_Total = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_GST = New System.Windows.Forms.TextBox()
        Me.lbl_GST = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Total_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Price = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_Children_Price = New System.Windows.Forms.TextBox()
        Me.tb_Adult_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Children = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_Adult = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Price = New System.Windows.Forms.GroupBox()
        Me.lbl_gst_percent_sign = New System.Windows.Forms.Label()
        Me.lbl_Tour_Date = New System.Windows.Forms.Label()
        Me.cb_tour_dates = New System.Windows.Forms.ComboBox()
        Me.btb_Show_Iternary = New System.Windows.Forms.Button()
        Me.pb_Package_Image = New System.Windows.Forms.PictureBox()
        Me.gb_Iternary = New System.Windows.Forms.GroupBox()
        Me.tb_tour_guide_name = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lbl_Select_Tour_Guide = New System.Windows.Forms.Label()
        Me.tb_Note = New System.Windows.Forms.TextBox()
        Me.gb_Note = New System.Windows.Forms.GroupBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Book = New System.Windows.Forms.Button()
        Me.tb_pkg_id = New System.Windows.Forms.TextBox()
        Me.lbl_pkg_id = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gb_Price.SuspendLayout()
        CType(Me.pb_Package_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Iternary.SuspendLayout()
        Me.gb_Note.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Pkg_Day_Night
        '
        Me.lbl_Pkg_Day_Night.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Day_Night.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Day_Night.Location = New System.Drawing.Point(12, 172)
        Me.lbl_Pkg_Day_Night.Name = "lbl_Pkg_Day_Night"
        Me.lbl_Pkg_Day_Night.Size = New System.Drawing.Size(149, 23)
        Me.lbl_Pkg_Day_Night.TabIndex = 32
        Me.lbl_Pkg_Day_Night.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Pkg_Name
        '
        Me.lbl_Pkg_Name.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Name.Location = New System.Drawing.Point(11, 201)
        Me.lbl_Pkg_Name.Name = "lbl_Pkg_Name"
        Me.lbl_Pkg_Name.Size = New System.Drawing.Size(328, 29)
        Me.lbl_Pkg_Name.TabIndex = 33
        Me.lbl_Pkg_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Pkg_Route
        '
        Me.lbl_Pkg_Route.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Pkg_Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pkg_Route.Location = New System.Drawing.Point(10, 237)
        Me.lbl_Pkg_Route.Name = "lbl_Pkg_Route"
        Me.lbl_Pkg_Route.Size = New System.Drawing.Size(549, 28)
        Me.lbl_Pkg_Route.TabIndex = 34
        Me.lbl_Pkg_Route.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Grand_Total
        '
        Me.tb_Grand_Total.Enabled = False
        Me.tb_Grand_Total.Location = New System.Drawing.Point(149, 195)
        Me.tb_Grand_Total.Name = "tb_Grand_Total"
        Me.tb_Grand_Total.Size = New System.Drawing.Size(139, 26)
        Me.tb_Grand_Total.TabIndex = 6
        Me.tb_Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Grand_Total
        '
        Me.lbl_Grand_Total.AutoSize = True
        Me.lbl_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grand_Total.Location = New System.Drawing.Point(8, 201)
        Me.lbl_Grand_Total.Name = "lbl_Grand_Total"
        Me.lbl_Grand_Total.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Grand_Total.TabIndex = 5
        Me.lbl_Grand_Total.Text = "Grand Total"
        '
        'tb_GST
        '
        Me.tb_GST.Enabled = False
        Me.tb_GST.Location = New System.Drawing.Point(150, 153)
        Me.tb_GST.Name = "tb_GST"
        Me.tb_GST.Size = New System.Drawing.Size(100, 26)
        Me.tb_GST.TabIndex = 6
        Me.tb_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_GST
        '
        Me.lbl_GST.AutoSize = True
        Me.lbl_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GST.Location = New System.Drawing.Point(9, 159)
        Me.lbl_GST.Name = "lbl_GST"
        Me.lbl_GST.Size = New System.Drawing.Size(45, 20)
        Me.lbl_GST.TabIndex = 5
        Me.lbl_GST.Text = "GST"
        '
        'tb_Total_Price
        '
        Me.tb_Total_Price.Enabled = False
        Me.tb_Total_Price.Location = New System.Drawing.Point(149, 109)
        Me.tb_Total_Price.Name = "tb_Total_Price"
        Me.tb_Total_Price.Size = New System.Drawing.Size(139, 26)
        Me.tb_Total_Price.TabIndex = 7
        Me.tb_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Total_Price
        '
        Me.lbl_Total_Price.AutoSize = True
        Me.lbl_Total_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Price.Location = New System.Drawing.Point(6, 115)
        Me.lbl_Total_Price.Name = "lbl_Total_Price"
        Me.lbl_Total_Price.Size = New System.Drawing.Size(94, 20)
        Me.lbl_Total_Price.TabIndex = 5
        Me.lbl_Total_Price.Text = "Total Price"
        '
        'tb_Children_Price
        '
        Me.tb_Children_Price.Enabled = False
        Me.tb_Children_Price.Location = New System.Drawing.Point(149, 64)
        Me.tb_Children_Price.Name = "tb_Children_Price"
        Me.tb_Children_Price.Size = New System.Drawing.Size(139, 26)
        Me.tb_Children_Price.TabIndex = 2
        Me.tb_Children_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_Adult_Price
        '
        Me.tb_Adult_Price.Enabled = False
        Me.tb_Adult_Price.Location = New System.Drawing.Point(149, 26)
        Me.tb_Adult_Price.Name = "tb_Adult_Price"
        Me.tb_Adult_Price.Size = New System.Drawing.Size(139, 26)
        Me.tb_Adult_Price.TabIndex = 1
        Me.tb_Adult_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Children
        '
        Me.lbl_Children.AutoSize = True
        Me.lbl_Children.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Children.Location = New System.Drawing.Point(6, 70)
        Me.lbl_Children.Name = "lbl_Children"
        Me.lbl_Children.Size = New System.Drawing.Size(75, 20)
        Me.lbl_Children.TabIndex = 5
        Me.lbl_Children.Text = "Children"
        '
        'lbl_Adult
        '
        Me.lbl_Adult.AutoSize = True
        Me.lbl_Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adult.Location = New System.Drawing.Point(6, 32)
        Me.lbl_Adult.Name = "lbl_Adult"
        Me.lbl_Adult.Size = New System.Drawing.Size(51, 20)
        Me.lbl_Adult.TabIndex = 4
        Me.lbl_Adult.Text = "Adult"
        '
        'gb_Price
        '
        Me.gb_Price.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Price.Controls.Add(Me.lbl_gst_percent_sign)
        Me.gb_Price.Controls.Add(Me.tb_Grand_Total)
        Me.gb_Price.Controls.Add(Me.tb_GST)
        Me.gb_Price.Controls.Add(Me.lbl_Grand_Total)
        Me.gb_Price.Controls.Add(Me.tb_Total_Price)
        Me.gb_Price.Controls.Add(Me.lbl_GST)
        Me.gb_Price.Controls.Add(Me.tb_Adult_Price)
        Me.gb_Price.Controls.Add(Me.lbl_Total_Price)
        Me.gb_Price.Controls.Add(Me.tb_Children_Price)
        Me.gb_Price.Controls.Add(Me.lbl_Adult)
        Me.gb_Price.Controls.Add(Me.lbl_Children)
        Me.gb_Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Price.Location = New System.Drawing.Point(3, 289)
        Me.gb_Price.Name = "gb_Price"
        Me.gb_Price.Size = New System.Drawing.Size(306, 242)
        Me.gb_Price.TabIndex = 39
        Me.gb_Price.TabStop = False
        Me.gb_Price.Text = "Price"
        '
        'lbl_gst_percent_sign
        '
        Me.lbl_gst_percent_sign.AutoSize = True
        Me.lbl_gst_percent_sign.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gst_percent_sign.Location = New System.Drawing.Point(248, 152)
        Me.lbl_gst_percent_sign.Name = "lbl_gst_percent_sign"
        Me.lbl_gst_percent_sign.Size = New System.Drawing.Size(30, 25)
        Me.lbl_gst_percent_sign.TabIndex = 8
        Me.lbl_gst_percent_sign.Text = "%"
        Me.lbl_gst_percent_sign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Tour_Date
        '
        Me.lbl_Tour_Date.AutoSize = True
        Me.lbl_Tour_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tour_Date.Location = New System.Drawing.Point(6, 35)
        Me.lbl_Tour_Date.Name = "lbl_Tour_Date"
        Me.lbl_Tour_Date.Size = New System.Drawing.Size(98, 20)
        Me.lbl_Tour_Date.TabIndex = 40
        Me.lbl_Tour_Date.Text = "Tour Dates"
        '
        'cb_tour_dates
        '
        Me.cb_tour_dates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tour_dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tour_dates.FormattingEnabled = True
        Me.cb_tour_dates.Location = New System.Drawing.Point(131, 34)
        Me.cb_tour_dates.Name = "cb_tour_dates"
        Me.cb_tour_dates.Size = New System.Drawing.Size(160, 24)
        Me.cb_tour_dates.TabIndex = 41
        '
        'btb_Show_Iternary
        '
        Me.btb_Show_Iternary.AutoSize = True
        Me.btb_Show_Iternary.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btb_Show_Iternary.BackgroundImage = CType(resources.GetObject("btb_Show_Iternary.BackgroundImage"), System.Drawing.Image)
        Me.btb_Show_Iternary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btb_Show_Iternary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btb_Show_Iternary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_Show_Iternary.ForeColor = System.Drawing.Color.White
        Me.btb_Show_Iternary.Image = Global.Tours_And_Travels_App.My.Resources.Resources.view_icon__5_
        Me.btb_Show_Iternary.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btb_Show_Iternary.Location = New System.Drawing.Point(119, 88)
        Me.btb_Show_Iternary.Name = "btb_Show_Iternary"
        Me.btb_Show_Iternary.Size = New System.Drawing.Size(121, 48)
        Me.btb_Show_Iternary.TabIndex = 42
        Me.btb_Show_Iternary.Text = "Show " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iternary"
        Me.btb_Show_Iternary.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btb_Show_Iternary.UseVisualStyleBackColor = False
        '
        'pb_Package_Image
        '
        Me.pb_Package_Image.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Package_Image.Location = New System.Drawing.Point(3, 3)
        Me.pb_Package_Image.Name = "pb_Package_Image"
        Me.pb_Package_Image.Size = New System.Drawing.Size(1345, 268)
        Me.pb_Package_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Package_Image.TabIndex = 31
        Me.pb_Package_Image.TabStop = False
        '
        'gb_Iternary
        '
        Me.gb_Iternary.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Iternary.Controls.Add(Me.lbl_Tour_Date)
        Me.gb_Iternary.Controls.Add(Me.btb_Show_Iternary)
        Me.gb_Iternary.Controls.Add(Me.cb_tour_dates)
        Me.gb_Iternary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_Iternary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Iternary.Location = New System.Drawing.Point(359, 353)
        Me.gb_Iternary.Name = "gb_Iternary"
        Me.gb_Iternary.Size = New System.Drawing.Size(306, 148)
        Me.gb_Iternary.TabIndex = 43
        Me.gb_Iternary.TabStop = False
        Me.gb_Iternary.Text = "Iternary"
        '
        'tb_tour_guide_name
        '
        Me.tb_tour_guide_name.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_tour_guide_name.Enabled = False
        Me.tb_tour_guide_name.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tour_guide_name.Location = New System.Drawing.Point(500, 302)
        Me.tb_tour_guide_name.Name = "tb_tour_guide_name"
        Me.tb_tour_guide_name.Size = New System.Drawing.Size(369, 28)
        Me.tb_tour_guide_name.TabIndex = 45
        '
        'lbl_Select_Tour_Guide
        '
        Me.lbl_Select_Tour_Guide.AutoSize = True
        Me.lbl_Select_Tour_Guide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Select_Tour_Guide.Location = New System.Drawing.Point(356, 304)
        Me.lbl_Select_Tour_Guide.Name = "lbl_Select_Tour_Guide"
        Me.lbl_Select_Tour_Guide.Size = New System.Drawing.Size(92, 18)
        Me.lbl_Select_Tour_Guide.TabIndex = 44
        Me.lbl_Select_Tour_Guide.Text = "Tour Guide"
        '
        'tb_Note
        '
        Me.tb_Note.Enabled = False
        Me.tb_Note.Location = New System.Drawing.Point(49, 14)
        Me.tb_Note.Multiline = True
        Me.tb_Note.Name = "tb_Note"
        Me.tb_Note.Size = New System.Drawing.Size(912, 80)
        Me.tb_Note.TabIndex = 46
        '
        'gb_Note
        '
        Me.gb_Note.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.gb_Note.Controls.Add(Me.tb_Note)
        Me.gb_Note.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Note.Location = New System.Drawing.Point(3, 537)
        Me.gb_Note.Name = "gb_Note"
        Me.gb_Note.Size = New System.Drawing.Size(975, 100)
        Me.gb_Note.TabIndex = 48
        Me.gb_Note.TabStop = False
        Me.gb_Note.Text = "Note"
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Location = New System.Drawing.Point(16, 672)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(99, 46)
        Me.btn_Back.TabIndex = 565
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Book
        '
        Me.btn_Book.AutoSize = True
        Me.btn_Book.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Book.BackgroundImage = CType(resources.GetObject("btn_Book.BackgroundImage"), System.Drawing.Image)
        Me.btn_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Book.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Book.ForeColor = System.Drawing.Color.White
        Me.btn_Book.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Add_2_Icon_32
        Me.btn_Book.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Book.Location = New System.Drawing.Point(998, 670)
        Me.btn_Book.Name = "btn_Book"
        Me.btn_Book.Size = New System.Drawing.Size(108, 47)
        Me.btn_Book.TabIndex = 566
        Me.btn_Book.Text = "Book"
        Me.btn_Book.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Book.UseVisualStyleBackColor = False
        '
        'tb_pkg_id
        '
        Me.tb_pkg_id.Enabled = False
        Me.tb_pkg_id.Location = New System.Drawing.Point(1102, 303)
        Me.tb_pkg_id.Name = "tb_pkg_id"
        Me.tb_pkg_id.Size = New System.Drawing.Size(147, 20)
        Me.tb_pkg_id.TabIndex = 567
        Me.tb_pkg_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_pkg_id
        '
        Me.lbl_pkg_id.AutoSize = True
        Me.lbl_pkg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pkg_id.Location = New System.Drawing.Point(959, 305)
        Me.lbl_pkg_id.Name = "lbl_pkg_id"
        Me.lbl_pkg_id.Size = New System.Drawing.Size(105, 20)
        Me.lbl_pkg_id.TabIndex = 568
        Me.lbl_pkg_id.Text = "Package No"
        '
        'frm_View_Single_Package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tb_pkg_id)
        Me.Controls.Add(Me.lbl_pkg_id)
        Me.Controls.Add(Me.btn_Book)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.gb_Note)
        Me.Controls.Add(Me.tb_tour_guide_name)
        Me.Controls.Add(Me.lbl_Select_Tour_Guide)
        Me.Controls.Add(Me.gb_Iternary)
        Me.Controls.Add(Me.gb_Price)
        Me.Controls.Add(Me.lbl_Pkg_Route)
        Me.Controls.Add(Me.lbl_Pkg_Name)
        Me.Controls.Add(Me.lbl_Pkg_Day_Night)
        Me.Controls.Add(Me.pb_Package_Image)
        Me.Name = "frm_View_Single_Package"
        Me.Text = "Show_Package"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gb_Price.ResumeLayout(False)
        Me.gb_Price.PerformLayout()
        CType(Me.pb_Package_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Iternary.ResumeLayout(False)
        Me.gb_Iternary.PerformLayout()
        Me.gb_Note.ResumeLayout(False)
        Me.gb_Note.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_Package_Image As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Pkg_Day_Night As System.Windows.Forms.Label
    Friend WithEvents lbl_Pkg_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Pkg_Route As System.Windows.Forms.Label
    Friend WithEvents tb_Grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Grand_Total As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_GST As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GST As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Total_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_Price As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_Children_Price As System.Windows.Forms.TextBox
    Friend WithEvents tb_Adult_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Children As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_Adult As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gb_Price As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Tour_Date As System.Windows.Forms.Label
    Friend WithEvents cb_tour_dates As System.Windows.Forms.ComboBox
    Friend WithEvents btb_Show_Iternary As System.Windows.Forms.Button
    Friend WithEvents gb_Iternary As System.Windows.Forms.GroupBox
    Friend WithEvents tb_tour_guide_name As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lbl_Select_Tour_Guide As System.Windows.Forms.Label
    Friend WithEvents tb_Note As System.Windows.Forms.TextBox
    Friend WithEvents gb_Note As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Book As System.Windows.Forms.Button
    Friend WithEvents lbl_gst_percent_sign As System.Windows.Forms.Label
    Friend WithEvents tb_pkg_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pkg_id As Bunifu.Framework.UI.BunifuCustomLabel
End Class
