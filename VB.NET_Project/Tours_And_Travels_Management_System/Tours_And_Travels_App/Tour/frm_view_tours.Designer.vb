<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view_tours
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cobo_view_tour_by = New System.Windows.Forms.ComboBox()
        Me.lbl_view_tour = New System.Windows.Forms.Label()
        Me.btn_view_tour_fetch = New System.Windows.Forms.Button()
        Me.dgv_view_all_tour = New System.Windows.Forms.DataGridView()
        Me.btn_view_tour_back = New System.Windows.Forms.Button()
        Me.tb_view_tour = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.dgv_view_tour_days = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_view_all_tour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_view_tour_days, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cobo_view_tour_by
        '
        Me.cobo_view_tour_by.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobo_view_tour_by.FormattingEnabled = True
        Me.cobo_view_tour_by.Items.AddRange(New Object() {"Tour_Id", "Destination"})
        Me.cobo_view_tour_by.Location = New System.Drawing.Point(350, 218)
        Me.cobo_view_tour_by.Name = "cobo_view_tour_by"
        Me.cobo_view_tour_by.Size = New System.Drawing.Size(336, 37)
        Me.cobo_view_tour_by.TabIndex = 57
        '
        'lbl_view_tour
        '
        Me.lbl_view_tour.AutoSize = True
        Me.lbl_view_tour.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_view_tour.Location = New System.Drawing.Point(135, 218)
        Me.lbl_view_tour.Name = "lbl_view_tour"
        Me.lbl_view_tour.Size = New System.Drawing.Size(186, 31)
        Me.lbl_view_tour.TabIndex = 56
        Me.lbl_view_tour.Text = "View Tour By"
        '
        'btn_view_tour_fetch
        '
        Me.btn_view_tour_fetch.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_view_tour_fetch.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_tour_fetch.ForeColor = System.Drawing.Color.Azure
        Me.btn_view_tour_fetch.Location = New System.Drawing.Point(1230, 211)
        Me.btn_view_tour_fetch.Name = "btn_view_tour_fetch"
        Me.btn_view_tour_fetch.Size = New System.Drawing.Size(209, 47)
        Me.btn_view_tour_fetch.TabIndex = 58
        Me.btn_view_tour_fetch.Text = "Fetch"
        Me.btn_view_tour_fetch.UseVisualStyleBackColor = False
        '
        'dgv_view_all_tour
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_view_all_tour.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_view_all_tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_view_all_tour.Location = New System.Drawing.Point(37, 286)
        Me.dgv_view_all_tour.Name = "dgv_view_all_tour"
        Me.dgv_view_all_tour.RowTemplate.Height = 24
        Me.dgv_view_all_tour.Size = New System.Drawing.Size(1203, 620)
        Me.dgv_view_all_tour.TabIndex = 59
        '
        'btn_view_tour_back
        '
        Me.btn_view_tour_back.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_view_tour_back.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_tour_back.ForeColor = System.Drawing.Color.Azure
        Me.btn_view_tour_back.Location = New System.Drawing.Point(830, 928)
        Me.btn_view_tour_back.Name = "btn_view_tour_back"
        Me.btn_view_tour_back.Size = New System.Drawing.Size(257, 68)
        Me.btn_view_tour_back.TabIndex = 60
        Me.btn_view_tour_back.Text = "Back "
        Me.btn_view_tour_back.UseVisualStyleBackColor = False
        '
        'tb_view_tour
        '
        Me.tb_view_tour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_view_tour.Location = New System.Drawing.Point(793, 225)
        Me.tb_view_tour.Name = "tb_view_tour"
        Me.tb_view_tour.Size = New System.Drawing.Size(327, 34)
        Me.tb_view_tour.TabIndex = 61
        '
        'PictureBox1
        '
        ''  Me.PictureBox1.Image = Global.Tours_And_Travels_Management_System.My.Resources.Resources.Tour_img
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2040, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(872, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 49)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "View Tours"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_refresh.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.Azure
        Me.btn_refresh.Location = New System.Drawing.Point(1507, 212)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(185, 47)
        Me.btn_refresh.TabIndex = 83
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'dgv_view_tour_days
        '
        Me.dgv_view_tour_days.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_view_tour_days.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_view_tour_days.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_view_tour_days.Location = New System.Drawing.Point(1259, 286)
        Me.dgv_view_tour_days.Name = "dgv_view_tour_days"
        Me.dgv_view_tour_days.RowTemplate.Height = 24
        Me.dgv_view_tour_days.Size = New System.Drawing.Size(565, 620)
        Me.dgv_view_tour_days.TabIndex = 84
        '
        'frm_view_tours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_view_tour_days)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_view_tour)
        Me.Controls.Add(Me.btn_view_tour_back)
        Me.Controls.Add(Me.dgv_view_all_tour)
        Me.Controls.Add(Me.btn_view_tour_fetch)
        Me.Controls.Add(Me.cobo_view_tour_by)
        Me.Controls.Add(Me.lbl_view_tour)
        Me.Name = "frm_view_tours"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Tours"
        CType(Me.dgv_view_all_tour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_view_tour_days, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cobo_view_tour_by As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_view_tour As System.Windows.Forms.Label
    Friend WithEvents btn_view_tour_fetch As System.Windows.Forms.Button
    Friend WithEvents dgv_view_all_tour As System.Windows.Forms.DataGridView
    Friend WithEvents btn_view_tour_back As System.Windows.Forms.Button
    Friend WithEvents tb_view_tour As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents dgv_view_tour_days As System.Windows.Forms.DataGridView
End Class
