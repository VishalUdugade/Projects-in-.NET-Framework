<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Package_Tour_Dates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Package_Tour_Dates))
        Me.panel_form_Index = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_End_Tour_Date = New System.Windows.Forms.Label()
        Me.lbl_Start_Tour_Date = New System.Windows.Forms.Label()
        Me.lbl_Sr_No = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_Edit_days = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_Package_Tours_Dates = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_form_Index.SuspendLayout()
        Me.panel_Add_Package.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_form_Index
        '
        Me.panel_form_Index.BackgroundImage = CType(resources.GetObject("panel_form_Index.BackgroundImage"), System.Drawing.Image)
        Me.panel_form_Index.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_form_Index.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_form_Index.Controls.Add(Me.lbl_End_Tour_Date)
        Me.panel_form_Index.Controls.Add(Me.lbl_Start_Tour_Date)
        Me.panel_form_Index.Controls.Add(Me.lbl_Sr_No)
        Me.panel_form_Index.Controls.Add(Me.ShapeContainer1)
        Me.panel_form_Index.GradientBottomLeft = System.Drawing.Color.White
        Me.panel_form_Index.GradientBottomRight = System.Drawing.Color.White
        Me.panel_form_Index.GradientTopLeft = System.Drawing.Color.White
        Me.panel_form_Index.GradientTopRight = System.Drawing.Color.White
        Me.panel_form_Index.Location = New System.Drawing.Point(229, 80)
        Me.panel_form_Index.Name = "panel_form_Index"
        Me.panel_form_Index.Quality = 10
        Me.panel_form_Index.Size = New System.Drawing.Size(518, 45)
        Me.panel_form_Index.TabIndex = 13
        '
        'lbl_End_Tour_Date
        '
        Me.lbl_End_Tour_Date.BackColor = System.Drawing.Color.Khaki
        Me.lbl_End_Tour_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_End_Tour_Date.Location = New System.Drawing.Point(317, 1)
        Me.lbl_End_Tour_Date.Name = "lbl_End_Tour_Date"
        Me.lbl_End_Tour_Date.Size = New System.Drawing.Size(199, 42)
        Me.lbl_End_Tour_Date.TabIndex = 3
        Me.lbl_End_Tour_Date.Text = "End Tour Date"
        Me.lbl_End_Tour_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Start_Tour_Date
        '
        Me.lbl_Start_Tour_Date.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Start_Tour_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Start_Tour_Date.Location = New System.Drawing.Point(109, 1)
        Me.lbl_Start_Tour_Date.Name = "lbl_Start_Tour_Date"
        Me.lbl_Start_Tour_Date.Size = New System.Drawing.Size(201, 42)
        Me.lbl_Start_Tour_Date.TabIndex = 2
        Me.lbl_Start_Tour_Date.Text = "Start Tour Date"
        Me.lbl_Start_Tour_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Sr_No
        '
        Me.lbl_Sr_No.BackColor = System.Drawing.Color.Khaki
        Me.lbl_Sr_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sr_No.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Sr_No.Name = "lbl_Sr_No"
        Me.lbl_Sr_No.Size = New System.Drawing.Size(105, 43)
        Me.lbl_Sr_No.TabIndex = 0
        Me.lbl_Sr_No.Text = "Sr No."
        Me.lbl_Sr_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(516, 43)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 313
        Me.LineShape2.X2 = 313
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 44
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 106
        Me.LineShape1.X2 = 106
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 44
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImage = CType(resources.GetObject("panel_Add_Package.BackgroundImage"), System.Drawing.Image)
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.btn_Edit_days)
        Me.panel_Add_Package.Controls.Add(Me.btn_Back)
        Me.panel_Add_Package.Controls.Add(Me.lbl_Package_Tours_Dates)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.Location = New System.Drawing.Point(0, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(979, 56)
        Me.panel_Add_Package.TabIndex = 2
        '
        'btn_Edit_days
        '
        Me.btn_Edit_days.AutoSize = True
        Me.btn_Edit_days.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit_days.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Edit_days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit_days.FlatAppearance.BorderSize = 0
        Me.btn_Edit_days.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit_days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit_days.ForeColor = System.Drawing.Color.White
        Me.btn_Edit_days.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Pensil_Icon_32
        Me.btn_Edit_days.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Edit_days.Location = New System.Drawing.Point(841, 7)
        Me.btn_Edit_days.Name = "btn_Edit_days"
        Me.btn_Edit_days.Size = New System.Drawing.Size(127, 38)
        Me.btn_Edit_days.TabIndex = 12
        Me.btn_Edit_days.Text = "Edit Days"
        Me.btn_Edit_days.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Edit_days.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.Enabled = False
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(9, 13)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(88, 29)
        Me.btn_Back.TabIndex = 64
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_Package_Tours_Dates
        '
        Me.lbl_Package_Tours_Dates.AutoSize = True
        Me.lbl_Package_Tours_Dates.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Package_Tours_Dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Package_Tours_Dates.ForeColor = System.Drawing.Color.White
        Me.lbl_Package_Tours_Dates.Location = New System.Drawing.Point(321, 8)
        Me.lbl_Package_Tours_Dates.Name = "lbl_Package_Tours_Dates"
        Me.lbl_Package_Tours_Dates.Size = New System.Drawing.Size(344, 37)
        Me.lbl_Package_Tours_Dates.TabIndex = 0
        Me.lbl_Package_Tours_Dates.Text = "Package Tours Dates"
        '
        'frm_Package_Tour_Dates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(980, 299)
        Me.Controls.Add(Me.panel_form_Index)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Name = "frm_Package_Tour_Dates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Package_Tour_Dates"
        Me.panel_form_Index.ResumeLayout(False)
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_Edit_days As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents lbl_Package_Tours_Dates As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_form_Index As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_End_Tour_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_Start_Tour_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_Sr_No As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
