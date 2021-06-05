Imports System.Data.SqlClient

Public Class frm_Package_Tour_Dates

    Private Sub frm_Package_Tour_Dates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim x As Integer = 228
            Dim y As Integer = 125
            Dim d_cnt As Integer = Comman_Declared.pkg_tour_dates
            Dim dno As Integer = 1
            Comman_Declared.c_tours_date_id = Auto_Increment("select max(date_id) from pkg_tours_date", 1)

            While d_cnt > 0
                Dim obj = New UC_Package_Tour_Dates
                obj.Location = New System.Drawing.Point(x, y)
                obj.tb_tour_date_id.Text = Comman_Declared.c_tours_date_id
                Me.Controls.Add(obj)

                obj.lbl_Sr_no.Text = dno

                x = x + 730
                y = y + 35
                x = 228

                Comman_Declared.c_tours_date_id = Comman_Declared.c_tours_date_id + 1
                dno = dno + 1
                d_cnt = d_cnt - 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            If Comman_Declared.verifying_forms = 1 Then
                Me.Hide()
                frm_Create_Packages.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 3 Then
                Me.Close()
                frm_Update_Package.Show()
                Comman_Declared.verifying_forms = 0
            ElseIf Comman_Declared.verifying_forms = 4 Then
                Me.Close()
                frm_Delete_Package.Show()
                Comman_Declared.verifying_forms = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Edit_days_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit_days.Click
        Try
            If MsgBox("Are You Sure For Edit Days...", MsgBoxStyle.Question, MsgBoxStyle.YesNo) = DialogResult.Yes Then
                getconnection()
                cmd = New SqlCommand("truncate table temporary_tours_date", con)
                cmd.ExecuteNonQuery()
                terminateconnection()
                Me.Close()
                frm_Create_Packages.tb_Number_of_tours.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class