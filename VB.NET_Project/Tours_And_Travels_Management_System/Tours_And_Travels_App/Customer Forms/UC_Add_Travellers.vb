Imports System.Data.SqlClient

Public Class UC_Add_Travellers

    Private Sub UC_Add_Travellers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Comman_Declared.add_traveller_verifying_form = 1 Then
            dtp_DOB.Value = Date.Now.Date
        End If
    End Sub

    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Addhar_No.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Ischar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Passenger_Name.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If

    End Sub

    Private Sub dtp_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DOB.ValueChanged
        If dtp_DOB.Value < Today.Date Then
            Dim ts As TimeSpan = DateTime.Now.Date - dtp_DOB.Value
            tb_Age.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
        ElseIf dtp_DOB.Value > Date.Now.Date Then
            tb_Age.Text = ""
        End If
    End Sub
    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        getconnection()
        
        If btn_Next.Text = "Next" Then
            If tb_Passenger_Name.Text <> "" And cb_Passe_Gender.SelectedIndex <> -1 And tb_Age.Text <> "" And tb_Addhar_No.Text <> "" Then
                Dim pkg_id As Integer = frm_Add_Customer.lbl_Pkg_id.Text
                Dim cust_id As Integer = frm_Add_Customer.lbl_Cust_Id.Text
                cmd = New SqlCommand("insert into temporary_traveller values(" & pkg_id & "," & cust_id & "," & lbl_traveller_id.Text & ",'" & tb_Passenger_Name.Text & "','" & cb_Passe_Gender.Text & "','" & dtp_DOB.Value & "','" & tb_Age.Text & "'," & tb_Addhar_No.Text & ")", con)
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record Not Saved Successfully..", MsgBoxStyle.OkOnly)
                End If


                If Val(Comman_Declared.co_passenger) = Val(Comman_Declared.back_button) Then
                    frm_Add_Travellers_Information.btn_Back.Enabled = True
                    Comman_Declared.co_passenger = 0
                End If
                Comman_Declared.back_button = Comman_Declared.back_button + 1
                Me.Enabled = False
            Else
                MsgBox("Please Fill All Field First...", MsgBoxStyle.OkOnly)
            End If
        ElseIf btn_Next.Text = "Delete" Then
            If cb_Passe_Gender.SelectedIndex <> -1 Then
                '    cmd = New SqlCommand("delete from Traveller where trave_id = " & lbl_traveller_id.Text & "", con)
                '    If cmd.ExecuteNonQuery = 1 Then
                '        MsgBox("Record Deleted Successfully....", MsgBoxStyle.OkOnly)
                '        cmd.Dispose()
                'Me.Enabled = False
                '    Else
                '        MsgBox("Record Not Deleted Successfully.....", MsgBoxStyle.OkOnly)
                '    End If
            Else
                MsgBox("Please Select Gender", MsgBoxStyle.OkOnly)
            End If
        ElseIf btn_Next.Text = "Update" Then
            If tb_Passenger_Name.Text <> "" And cb_Passe_Gender.SelectedIndex <> -1 And tb_Age.Text <> "" And tb_Addhar_No.Text <> "" Then
                getconnection()
                Dim pkg_id As Integer = frm_Update_Customer.tb_pkg_id.Text
                Dim cust_id As Integer = frm_Update_Customer.tb_cust_id.Text
                cmd = New SqlCommand("insert into temporary_traveller values(" & pkg_id & "," & cust_id & "," & lbl_traveller_id.Text & ",'" & tb_Passenger_Name.Text & "','" & cb_Passe_Gender.Text & "','" & dtp_DOB.Value & "','" & tb_Age.Text & "'," & tb_Addhar_No.Text & ")", con)
                'cmd = New SqlCommand("Update Traveller set pass_name = '" & tb_Passenger_Name.Text & "',gender = '" & cb_Passe_Gender.Text & "',DOB = '" & dtp_DOB.Text & "',age = " & tb_Age.Text & ",addhar_no = " & tb_Addhar_No.Text & "", con)
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record Updated Successfully...", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record Not Updated Successfully..", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please Fill All Fields", MsgBoxStyle.OkOnly)
            End If
        ElseIf btn_Next.Text = "Set" Then
            If tb_Passenger_Name.Text <> "" And cb_Passe_Gender.SelectedIndex <> -1 And tb_Age.Text <> "" And tb_Addhar_No.Text <> "" Then
                Dim pkg_id As Integer = frm_Update_Customer.tb_pkg_id.Text
                Dim cust_id As Integer = frm_Update_Customer.tb_cust_id.Text
                cmd = New SqlCommand("insert into temporary_traveller values(" & pkg_id & "," & cust_id & "," & lbl_traveller_id.Text & ",'" & tb_Passenger_Name.Text & "','" & cb_Passe_Gender.Text & "','" & dtp_DOB.Value & "','" & tb_Age.Text & "'," & tb_Addhar_No.Text & ")", con)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record Not Saved Successfully..", MsgBoxStyle.OkOnly)
                End If


                If Val(Comman_Declared.co_passenger) = Val(Comman_Declared.back_button) Then
                    frm_Add_Travellers_Information.btn_Back.Enabled = True
                    Comman_Declared.co_passenger = 0
                End If
                Comman_Declared.back_button = Comman_Declared.back_button + 1
                Me.Enabled = False
            Else
                MsgBox("Please Fill All Field First...", MsgBoxStyle.OkOnly)
            End If
        End If
        terminateconnection()
    End Sub
End Class
