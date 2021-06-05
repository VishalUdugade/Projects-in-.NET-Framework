Imports System.Data.SqlClient
Public Class UC_Package_Tour_Dates


    Private Sub dtp_Tour_Start_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Tour_Start_Date.ValueChanged
        If btn_Next.Text = "Next" Then
            Dim day_no As Integer = Comman_Declared.co_days - 1
            dtp_Tour_End_Date.Value = dtp_Tour_Start_Date.Value.AddDays(day_no)
            btn_Next.Enabled = True
        End If
        If btn_Next.Text = "Set" Then
            Dim day_no As Integer = frm_Update_Package.tb_Days.Text - 1
            dtp_Tour_End_Date.Value = dtp_Tour_Start_Date.Value.AddDays(day_no)
            btn_Next.Enabled = True
        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        If btn_Next.Text = "Next" Then
            If dtp_Tour_Start_Date.Value > frm_Create_Packages.dtp_Pkg_Create_Date.Value And dtp_Tour_Start_Date.Value < frm_Create_Packages.dtp_Expiry_Date.Value Then
                getconnection()
                cmd = New SqlCommand("insert into temporary_tours_date values(" & Comman_Declared.temp_table_pkg_id & "," & tb_tour_date_id.Text & ",'" & dtp_Tour_Start_Date.Text & "','" & dtp_Tour_End_Date.Text & "')", con)


                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Records of dates are saved ", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                    Me.Enabled = False
                Else
                    MsgBox("Records of dates are not saved", MsgBoxStyle.OkOnly)
                End If

                If Val(Comman_Declared.pkg_tour_dates) = Val(Comman_Declared.done_date_button) Then

                    frm_Package_Tour_Dates.btn_Back.Enabled = True
                Else

                    Comman_Declared.done_date_button = Comman_Declared.done_date_button + 1

                End If
            Else
                MsgBox("Please Enter correct Date Which is Greater than Package Create Date And Smaller than Package End Date ", MsgBoxStyle.Question, MsgBoxStyle.OkOnly)
            End If
        ElseIf btn_Next.Text = "Set" Then
            If dtp_Tour_Start_Date.Value > frm_Update_Package.dtp_Pkg_Create_Date.Value And dtp_Tour_Start_Date.Value < frm_Update_Package.dtp_Expiry_Date.Value Then
                Dim pkg_id As Integer = frm_Update_Package.tb_Package_ID.Text
                getconnection()
                cmd = New SqlCommand("insert into temporary_tours_date values(" & pkg_id & "," & tb_tour_date_id.Text & ",'" & dtp_Tour_Start_Date.Text & "','" & dtp_Tour_End_Date.Text & "')", con)

                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Records of dates are saved  ", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Records of dates are not Saved", MsgBoxStyle.OkOnly)
                End If
           Else
                MsgBox("Please Enter correct Date Which is Greater than Package Create Date And Smaller than Package End Date ", MsgBoxStyle.Question, MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
End Class
