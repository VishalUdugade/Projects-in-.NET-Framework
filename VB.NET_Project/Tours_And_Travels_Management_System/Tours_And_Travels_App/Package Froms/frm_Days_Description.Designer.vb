<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Days_Description
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
        Me.panel_Add_Package = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_Edit_days = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_Days_Description = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_Add_Package.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Add_Package
        '
        Me.panel_Add_Package.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Add_Package.Controls.Add(Me.btn_Edit_days)
        Me.panel_Add_Package.Controls.Add(Me.btn_Back)
        Me.panel_Add_Package.Controls.Add(Me.lbl_Days_Description)
        Me.panel_Add_Package.ForeColor = System.Drawing.Color.Gray
        Me.panel_Add_Package.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientBottomRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopLeft = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.GradientTopRight = System.Drawing.Color.DarkGoldenrod
        Me.panel_Add_Package.Location = New System.Drawing.Point(0, 1)
        Me.panel_Add_Package.Name = "panel_Add_Package"
        Me.panel_Add_Package.Quality = 10
        Me.panel_Add_Package.Size = New System.Drawing.Size(1116, 64)
        Me.panel_Add_Package.TabIndex = 1
        '
        'btn_Edit_days
        '
        Me.btn_Edit_days.AutoSize = True
        Me.btn_Edit_days.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit_days.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.buttons
        Me.btn_Edit_days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit_days.FlatAppearance.BorderSize = 0
        Me.btn_Edit_days.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Edit_days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit_days.ForeColor = System.Drawing.Color.White
        Me.btn_Edit_days.Image = Global.Tours_And_Travels_App.My.Resources.Resources.Pensil_Icon_32
        Me.btn_Edit_days.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Edit_days.Location = New System.Drawing.Point(978, 11)
        Me.btn_Edit_days.Name = "btn_Edit_days"
        Me.btn_Edit_days.Size = New System.Drawing.Size(127, 43)
        Me.btn_Edit_days.TabIndex = 12
        Me.btn_Edit_days.Text = "Edit Days"
        Me.btn_Edit_days.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Edit_days.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.Tours_And_Travels_App.My.Resources.Resources.Back_Icon_256
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.Location = New System.Drawing.Point(14, 14)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(101, 37)
        Me.btn_Back.TabIndex = 64
        Me.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_Days_Description
        '
        Me.lbl_Days_Description.AutoSize = True
        Me.lbl_Days_Description.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Days_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Days_Description.ForeColor = System.Drawing.Color.White
        Me.lbl_Days_Description.Location = New System.Drawing.Point(431, 17)
        Me.lbl_Days_Description.Name = "lbl_Days_Description"
        Me.lbl_Days_Description.Size = New System.Drawing.Size(345, 37)
        Me.lbl_Days_Description.TabIndex = 0
        Me.lbl_Days_Description.Text = "Add Days Description"
        '
        'frm_Days_Description
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1117, 444)
        Me.Controls.Add(Me.panel_Add_Package)
        Me.Name = "frm_Days_Description"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Days_Description"
        Me.panel_Add_Package.ResumeLayout(False)
        Me.panel_Add_Package.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Add_Package As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_Days_Description As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Edit_days As System.Windows.Forms.Button
End Class
