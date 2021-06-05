Imports System.Data.SqlClient

Public Class frm_Days_Description

    ' Dim tem As Integer = Comman_Declared.co_days
    Private Sub frm_Days_Description_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''getconnection()
        ''Dim x As Integer = 50
        ''Dim y As Integer = 100
        ''Dim d_cnt As Integer = Comman_Declared.co_days
        ''Dim dno As Integer = 1
        ''Comman_Declared.c_day_id = Auto_Increment("select count(day_id) from pkg_days_descri", 100)

        ''While d_cnt > 0
        ''    Dim obj = New pkg_Days_Description
        ''    obj.Location = New System.Drawing.Point(x, y)
        ''    Me.Controls.Add(obj)

        ''    obj.lbl_Days_no.Text = "Day" + dno.ToString
        ''    obj.tb_day_id.Text = Comman_Declared.c_day_id
        ''    x = x + 1357
        ''    y = y + 375
        ''    x = 50
        ''    Comman_Declared.c_day_id = Comman_Declared.c_day_id + 1
        ''    dno = dno + 1
        ''    d_cnt = d_cnt - 1
        ''End While
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frm_Create_Packages.Show()
    End Sub


    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            If Comman_Declared.verifying_forms = 1 Then
                Me.Close()
                frm_Create_Packages.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 2 Then
                Me.Close()
                frm_Show_Pkgs_to_Customer.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 3 Then
                Me.Close()
                frm_Update_Package.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 4 Then
                Me.Close()
                frm_Delete_Package.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 5 Then
                Me.Close()
                frm_booking.Show()
                Comman_Declared.verifying_forms = 0
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_Edit_days_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit_days.Click
        Try

            If MsgBox("Are You Sure For Edit Days", MsgBoxStyle.YesNo) = DialogResult.Yes Then

                getconnection()
                cmd = New SqlCommand("Truncate table temporary_day_descri", con)
                cmd.ExecuteNonQuery()

                Me.Close()
                frm_Create_Packages.Show()
                frm_Create_Packages.tb_Days.Text = ""
                terminateconnection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class