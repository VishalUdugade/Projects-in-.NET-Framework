Imports System.Data.SqlClient

Public Class pkg_Days_Description

   
    Private Sub pkg_Days_Description_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lbl_Days_no.Text = "Day1" Then
            tb_L_Place.Enabled = True
            tb_L_Place.Focus()
        End If
    End Sub

#Region "TextChanged Event"

    Private Sub tb_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Place.TextChanged
        tb_L_Name.Enabled = True
    End Sub
    Private Sub tb_L_Name_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_L_Name.TextChanged
        tb_L_Place.Enabled = True
    End Sub

    Private Sub tb_L_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_L_Place.TextChanged
        tb_D_Name.Enabled = True
    End Sub

    Private Sub tb_D_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_D_Name.TextChanged
        tb_D_Place.Enabled = True
    End Sub

    Private Sub tb_D_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_D_Place.TextChanged
        tb_Days_Descri.Enabled = True
    End Sub

    Private Sub tb_Days_Descri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Days_Descri.TextChanged
        btn_next.Enabled = True
    End Sub
#End Region

#Region "Leave Event"
    Private Sub tb_Place_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Place.Leave
        If tb_Place.Text = "" Then
            tb_L_Name.Text = ""
            tb_L_Name.Enabled = False
        End If
    End Sub
    Private Sub tb_L_Name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_L_Name.Leave
        If tb_L_Name.Text = "" Then
            tb_L_Place.Text = ""
            tb_L_Place.Enabled = False
        End If
    End Sub

    Private Sub tb_L_Place_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_L_Place.Leave
        If tb_L_Place.Text = "" Then
            tb_D_Name.Text = ""
            tb_D_Name.Enabled = False
        End If
    End Sub

    Private Sub tb_D_Name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_D_Name.Leave
        If tb_D_Name.Text = "" Then
            tb_D_Place.Text = ""
            tb_D_Place.Enabled = False
        End If
    End Sub

    Private Sub tb_D_Place_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_D_Place.Leave
        If tb_D_Name.Text = "" Then
            tb_Days_Descri.Text = ""
            tb_Days_Descri.Enabled = False
        End If
    End Sub

    Private Sub tb_Days_Descri_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Days_Descri.Leave
        If tb_Days_Descri.Text = "" Then
            btn_next.Enabled = False
        End If
    End Sub
#End Region


    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click

        Dim temp_id As Integer = 100
        getconnection()

        If btn_next.Text = "Next" Then

            cmd = New SqlCommand("Insert into temporary_day_descri Values(" & Comman_Declared.temp_table_pkg_id & ", " & tb_day_id.Text & ",'" & lbl_Days_no.Text & "','" & tb_Place.Text & "','" & tb_L_Name.Text & "','" & tb_L_Place.Text & "','" & tb_D_Name.Text & "','" & tb_D_Place.Text & "','" & tb_Days_Descri.Text & "')", con)

            Dim i As Integer
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record saved succesfully....", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Record not saved....", MsgBoxStyle.OkOnly)
            End If

            If Val(Comman_Declared.co_days) = Val(Comman_Declared.back_button) Then

                frm_Days_Description.btn_Back.Enabled = True

            Else

                Comman_Declared.back_button = Comman_Declared.back_button + 1

            End If
            Me.Enabled = False

        ElseIf btn_next.Text = "Update" Then
            Dim pkg_id As Integer = frm_Update_Package.tb_Package_ID.Text
            cmd = New SqlCommand("Insert into temporary_day_descri Values(" & pkg_id & ", " & tb_day_id.Text & ",'" & lbl_Days_no.Text & "','" & tb_Place.Text & "','" & tb_L_Name.Text & "','" & tb_L_Place.Text & "','" & tb_D_Name.Text & "','" & tb_D_Place.Text & "','" & tb_Days_Descri.Text & "')", con)

            Dim i As Integer
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record saved in temp.table succesfully....", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Record not saved....", MsgBoxStyle.OkOnly)
            End If
        ElseIf btn_next.Text = "Set" Then
            Dim pkg_id As Integer = frm_Update_Package.tb_Package_ID.Text
            cmd = New SqlCommand("Insert into temporary_day_descri Values(" & pkg_id & ", " & tb_day_id.Text & ",'" & lbl_Days_no.Text & "','" & tb_Place.Text & "','" & tb_L_Name.Text & "','" & tb_L_Place.Text & "','" & tb_D_Name.Text & "','" & tb_D_Place.Text & "','" & tb_Days_Descri.Text & "')", con)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record saved succesfully....", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Record not saved....", MsgBoxStyle.OkOnly)
            End If

            If Val(Comman_Declared.co_days) = Val(Comman_Declared.back_button) Then

                frm_Days_Description.btn_Back.Enabled = True
                Comman_Declared.co_days = 0
            Else

                Comman_Declared.back_button = Comman_Declared.back_button + 1

            End If
            Me.Enabled = False
        End If
    End Sub

    Private Sub route(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Place.KeyPress, MyBase.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(32) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If

    End Sub
    
   
End Class
