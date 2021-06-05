Imports System.Data.SqlClient

Public Class frm_Delete_Employee
    Dim post As String
    Dim empgen As String
    Dim state As String

    Function Clear_Controls()
        dtp_emp_DOB.Value = Date.Now.Date
        clearAllTxtbo(panel_Name)
        clearAllTxtbo(panel_Custo_Con_Det)
        clearAllTxtbo(panel_sal)
        clearAllTxtbo(panel_other_details)
        clearAllTxtbo(panel_leagel_info)
        clearAllCombo(panel_other_details)
        clearAllRadiobutton(panel_post)
        clearAllRadiobutton(panel_other_details)
        Return 0
    End Function
    Function values()
        If rb_Cashier.Checked = True Then
            post = rb_Cashier.Text
        End If

        If rb_Receptionist.Checked = True Then
            post = rb_Receptionist.Text
        End If

        If rb_Tour_Guide.Checked = True Then
            post = rb_Tour_Guide.Text
        End If

        If rb_Driver.Checked = True Then
            post = rb_Driver.Text
        End If

        '============================================

        If rb_Male.Checked = True Then
            empgen = rb_Male.Text
        End If

        If rb_Female.Checked = True Then
            empgen = rb_Female.Text
        End If
        Return 0
    End Function

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            values()
            If tb_first_name.Text <> "" Or tb_Middle_Name.Text <> "" Or tb_Last_Name.Text <> "" Or tb_Mob_No.Text <> "" Or tb_Email_Id.Text <> "" Or post <> "" Or empgen <> "" Or tb_Pan_No.Text <> "" Or tb_Bank_Acc_no.Text <> "" Or tb_emp_sal.Text <> "" Or tb_age.Text <> "" Or tb_address.Text <> "" Or tb_State.Text <> "" Or tb_city_town_vill.Text <> "" Or tb_pin_code.Text <> "" Or tb_Addhar_No.Text <> "" Then
                MsgBox("Please Update the data OR Clear All fields", MsgBoxStyle.OkCancel)

            Else
                frm_Employee.Show()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Clear_Controls()
            tb_Emp_id.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_Emp_id.Text <> "" Then
                getconnection()

                Dim dr As SqlDataReader
                cmd = New SqlCommand("select * from Emp_Info where emp_id = " & tb_Emp_id.Text & "", con)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    tb_first_name.Text = dr("first_name").ToString()
                    tb_Middle_Name.Text = dr("middle_name").ToString
                    tb_Last_Name.Text = dr("last_name").ToString
                    tb_Mob_No.Text = dr("mob_no")
                    tb_Alter_Mob_No.Text = dr("alter_mob_no")
                    tb_Email_Id.Text = dr("email_id")
                    Dim post As String = dr("emp_post").ToString
                    dtp_emp_DOB.Value = dr("DOB").ToString
                    tb_age.Text = dr("age")
                    tb_address.Text = dr("address").ToString
                    tb_State.Text = (dr("state")).ToString()
                    tb_city_town_vill.Text = dr("city_town_vill").ToString
                    tb_pin_code.Text = dr("pin_code")
                    Dim gender As String = dr("gender").ToString
                    tb_Addhar_No.Text = dr("addhar_no")
                    tb_four_wheel_dri_lic_no.Text = dr("four_dri_lic")
                    tb_Pan_No.Text = dr("pan_no")
                    tb_Bank_Name.Text = dr("bank_name")
                    tb_Bank_Acc_no.Text = dr("bank_acc_no")
                    tb_emp_sal.Text = dr("salary")

                    If post = "Cashier" Then
                        rb_Cashier.Checked = True
                    ElseIf post = "Driver" Then
                        rb_Driver.Checked = True
                    ElseIf post = "Tour Guide" Then
                        rb_Tour_Guide.Checked = True
                    ElseIf post = "Receptionist" Then
                        rb_Receptionist.Checked = True
                    End If

                    If gender = "Male" Then
                        rb_Male.Checked = True
                    ElseIf gender = "Female" Then
                        rb_Female.Checked = True
                    End If

                    dr.Close()
                    cmd.Dispose()
                End If

            Else
                MsgBox("Please Enter Employee ID First..", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        ''If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_Pan_No.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And tb_State.Text <> "" And tb_city_town_vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
        ''    cmd = New SqlCommand("Delete from Emp_Info where emp_id = " & tb_Emp_id.Text & "", con)
        ''    Dim i As Integer = cmd.ExecuteNonQuery()
        ''    If (i > 0) Then
        ''        MsgBox("Record Deleted Successfully...!")
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("Record Not Deleted Successfully....?")
        ''    End If
        ''Else
        ''    MsgBox("First Select Employee...", MsgBoxStyle.OkOnly)
        ''End If
        Clear_Controls()
    End Sub

    Private Sub btn_Clear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Clear_Controls()
    End Sub

    Private Sub frm_Delete_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Emp_id.Focus()
    End Sub

    Private Sub btn_Back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub
End Class