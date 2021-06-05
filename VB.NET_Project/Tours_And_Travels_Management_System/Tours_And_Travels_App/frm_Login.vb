Imports System.Data.SqlClient

Public Class frm_Login

    Private Sub pb_Owner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Owner.Click
        lbl_User_Name.Text = "Owner"
        panel_Login.Enabled = True
        pb_Owner.BackColor = Color.Khaki
        pb_Cashier.BackColor = Color.Goldenrod
        pb_Receptionist.BackColor = Color.Goldenrod
    End Sub

    Private Sub pb_Receptionist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Receptionist.Click
        lbl_User_Name.Text = "Receptionist"
        panel_Login.Enabled = True
        pb_Receptionist.BackColor = Color.Khaki
        pb_Owner.BackColor = Color.Goldenrod
        pb_Cashier.BackColor = Color.Goldenrod
    End Sub

    Private Sub pb_Cashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Cashier.Click
        lbl_User_Name.Text = "Cashier"
        panel_Login.Enabled = True
        pb_Cashier.BackColor = Color.Khaki
        pb_Owner.BackColor = Color.Goldenrod
        pb_Receptionist.BackColor = Color.Goldenrod
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Password.Focus()
        panel_Login.Enabled = False
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If tb_Password.Text <> "" And tb_Username.Text <> "" Then
            'getconnection()
            'cmd = New SqlCommand("select * from Login where username = '" & tb_Username.Text & "' And password = '" & tb_Password.Text & "'", con)
            'Dim dr As SqlDataReader
            'dr = cmd.ExecuteReader()
            'Dim username As String
            'Dim password As String
            'Dim usertype As String
            'If dr.Read() Then
            '    username = dr("username")
            '    usertype = dr("usertype")
            '    password = dr("password")
            '    dr.Close()
            '    cmd.Dispose()
            Comman_Declared.identify = lbl_User_Name.Text
            If "o" = tb_Username.Text And "o" = tb_Password.Text And lbl_User_Name.Text = "Owner" Then
                MsgBox("Welcome Owner", MsgBoxStyle.OkOnly)
                frm_Owner.Show()
                Me.Hide()
                Return
            ElseIf "r" = tb_Username.Text And "r" = tb_Password.Text And lbl_User_Name.Text = "Receptionist" Then
                MsgBox("Welcome Receptionist", MsgBoxStyle.OkOnly)
                frm_Owner.Show()
                Me.Hide()
                Return
            ElseIf "c" = tb_Username.Text And "c" = tb_Password.Text And lbl_User_Name.Text = "Cashier" Then
                MsgBox("Welcome Cashier", MsgBoxStyle.OkOnly)
                frm_Owner.Show()
                Me.Hide()
                Return      
            Else
                MsgBox("Please Enter Correct Username And Password", MsgBoxStyle.OkOnly)
            End If
            'cmd.Dispose()

            Else
            MsgBox("first fill All Fields..", MsgBoxStyle.OkOnly)
        End If
        tb_Password.Text = ""
        tb_Username.Text = ""
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        tb_Password.Text = ""
        tb_Username.Text = ""
    End Sub

    Private Sub frm_Login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tb_Password.Text = ""
        tb_Username.Text = ""
        lbl_User_Name.Text = ""
        panel_Login.Enabled = False
        pb_Receptionist.BackColor = Color.Goldenrod
        pb_Owner.BackColor = Color.Goldenrod
        pb_Cashier.BackColor = Color.Goldenrod
    End Sub
End Class
