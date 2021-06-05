Imports System.Data.SqlClient

Public Class frm_Add_Travellers_Information

    Private Sub frm_Add_Travellers_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            If Comman_Declared.add_traveller_verifying_form = 1 Then
                Me.Close()
                frm_Add_Customer.Enabled = True
                frm_Add_Customer.Show()
                Comman_Declared.add_traveller_verifying_form = 0
            ElseIf Comman_Declared.add_traveller_verifying_form = 2 Then
                Me.Close()
                frm_Delete_Customer.Show()
                Comman_Declared.add_traveller_verifying_form = 0
            ElseIf Comman_Declared.add_traveller_verifying_form = 3 Then
                Me.Close()
                frm_Update_Customer.Show()
                Comman_Declared.add_traveller_verifying_form = 0
            ElseIf Comman_Declared.add_traveller_verifying_form = 4 Then
                Me.Close()
                frm_View_single_Customer_Details.Show()
                Comman_Declared.add_traveller_verifying_form = 0
            ElseIf Comman_Declared.add_traveller_verifying_form = 5 Then
                Me.Close()
                frm_booking.Show()
                Comman_Declared.add_traveller_verifying_form = 0
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_Edit_Travellers_No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit_Travellers_No.Click
        Try
            If Comman_Declared.add_traveller_verifying_form = 1 Then
                getconnection()
                cmd = New SqlCommand("select count(trave_id) from temporary_traveller", con)
                If cmd.ExecuteScalar > 0 Then
                    cmd.Dispose()
                    If MsgBox("Are you sure want to Change the number of travellers ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                        cmd = New SqlCommand("truncate table temporary_traveller", con)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Record are deleted  Successfully...", MsgBoxStyle.OkOnly)
                            Me.Close()
                            frm_Add_Customer.Show()
                            Comman_Declared.add_traveller_verifying_form = 0
                        Else
                            MsgBox("Record are Not deleted Successfully....", MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    cmd.Dispose()
                    Me.Close()
                    frm_Add_Customer.Show()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class