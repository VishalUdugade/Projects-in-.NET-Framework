
Imports System.Data.SqlClient

Public Class frm_Add_Employee


    Dim post As String
    Dim empgen As String
    Dim state As String




    Private Sub frm_Add_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tb_first_name.Focus()
            tb_age.Text = ""
            lbl_Emp_Id.Text = Auto_Increment("select count(emp_id) from Emp_Info", 101)

            '        tb_first_name.SetWaterMark("First Name ")
            '       tb_Middle_Name.SetWaterMark("Middle Name")
            '      tb_Last_Name.SetWaterMark("Last Name")
        Catch ex As Exception
        End Try
    End Sub



    ' Private Sub tb_first_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_first_name.Leave
    '    If tb_first_name.Text = "" Then
    '       tb_first_name.Text = "First name"
    '
    '   End If
    '  If tb_first_name.Text <> "" Then
    '     tb_first_name.ForeColor = Color.Black
    '      End If
    ' End Sub

    '  Private Sub tb_first_name_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '     If tb_first_name.Text = "First name" Then
    '        tb_first_name.Text = ""
    '   End If
    ' End Sub

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

    Private Sub rb_Driver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Driver.CheckedChanged
        tb_Pan_No.Enabled = True

        tb_four_wheel_dri_lic_no.Text = ""
        tb_four_wheel_dri_lic_no.Enabled = False



    End Sub

    Function Clear_Controls()
        clearAllTxtbo(panel_Name)
        clearAllTxtbo(panel_Custo_Con_Det)
        clearAllTxtbo(panel_sal)
        clearAllTxtbo(panel_other_details)
        clearAllTxtbo(panel_leagel_info)
        clearAllCombo(panel_leagel_info)
        clearAllRadiobutton(panel_post)
        clearAllRadiobutton(panel_other_details)
        dtp_emp_DOB.Value = Date.Now.ToString()
        dtp_Joining_date.Value = Date.Now.ToString()
        cb_State.SelectedIndex = -1
        cb_Bank_Name.SelectedIndex = -1
        Return 0
    End Function
    Function Enabled_False()
        dtp_emp_DOB.Value = Date.Now.ToString()
        dtp_Joining_date.Value = Date.Now.ToString()
        cb_State.Text = "Select State"

        tb_age.Text = ""

        tb_Middle_Name.Enabled = False
        tb_Last_Name.Enabled = False
        tb_Mob_No.Enabled = False
        tb_Alter_Mob_No.Enabled = False
        tb_Email_Id.Enabled = False
        panel_post.Enabled = False
        tb_Pan_No.Enabled = False
        tb_Bank_Acc_no.Enabled = False
        tb_emp_sal.Enabled = False
        dtp_emp_DOB.Enabled = False
        tb_address.Enabled = False
        ' cb_State.DropDownStyle = ComboBoxStyle.DropDownList
        tb_city_town_vill.Enabled = False
        tb_pin_code.Enabled = False
        rb_Male.Enabled = False
        rb_Female.Enabled = False
        tb_Addhar_No.Enabled = False
        tb_four_wheel_dri_lic_no.Enabled = False
        Return 0
    End Function

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            '  con.ConnectionString = connstring
            getconnection()
            values()

            If tb_Alter_Mob_No.Text = "" And rb_Driver.Checked = False Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_Pan_No.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_emp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_city_town_vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
                    cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,email_id,emp_post,join_date,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & lbl_Emp_Id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & dtp_Joining_date.Text & "','" & dtp_emp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_city_town_vill.Text & "'," & tb_pin_code.Text & ",'" & empgen & "'," & tb_Addhar_No.Text & ",'" & tb_Pan_No.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Record Saved Successfully...!")
                        'Clear_Controls()
                        'Enabled_False()

                        lbl_Emp_Id.Text = Auto_Increment("select count(emp_id) from Emp_Info", 101)
                        cmd.Dispose()
                    Else
                        MsgBox("Record Not Saved Successfully....?")
                    End If
                Else
                    MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text <> "" And rb_Driver.Checked = False Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_Pan_No.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_emp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_city_town_vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
                    cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,join_date,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & lbl_Emp_Id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & dtp_Joining_date.Text & "','" & dtp_emp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_city_town_vill.Text & "'," & tb_pin_code.Text & ",'" & empgen & "'," & tb_Addhar_No.Text & ",'" & tb_Pan_No.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Record Saved Successfully...!")
                        'Clear_Controls()
                        'Enabled_False()

                        lbl_Emp_Id.Text = Auto_Increment("select count(emp_id) from Emp_Info", 101)
                        cmd.Dispose()
                    Else
                        MsgBox("Record Not Saved Successfully....?")
                    End If
                Else
                    MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text = "" And rb_Driver.Checked = True Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_Pan_No.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_emp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_city_town_vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" And tb_four_wheel_dri_lic_no.Text <> "" Then
                    cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,join_date,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,four_dri_lic,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & lbl_Emp_Id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & dtp_Joining_date.Text & "','" & dtp_emp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_city_town_vill.Text & "'," & tb_pin_code.Text & ",'" & empgen & "'," & tb_Addhar_No.Text & ",'" & tb_four_wheel_dri_lic_no.Text & "','" & tb_Pan_No.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Record Saved Successfully...!")
                        'Clear_Controls()
                        'Enabled_False()

                        lbl_Emp_Id.Text = Auto_Increment("select count(emp_id) from Emp_Info", 101)
                        cmd.Dispose()
                    Else
                        MsgBox("Record Not Saved Successfully....?")
                    End If
                Else
                    MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text <> "" And rb_Driver.Checked = True Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_Pan_No.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_emp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_city_town_vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" And tb_four_wheel_dri_lic_no.Text <> "" Then
                    cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,join_date,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,four_dri_lic,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & lbl_Emp_Id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & dtp_Joining_date.Text & "','" & dtp_emp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_city_town_vill.Text & "'," & tb_pin_code.Text & ",'" & empgen & "'," & tb_Addhar_No.Text & ",'" & tb_four_wheel_dri_lic_no.Text & "','" & tb_Pan_No.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Record Saved Successfully...!")
                        Clear_Controls()
                        Enabled_False()

                        lbl_Emp_Id.Text = Auto_Increment("select count(emp_id) from Emp_Info", 101)
                        cmd.Dispose()
                    Else
                        MsgBox("Record Not Saved Successfully....?")
                    End If
                Else
                    MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            values()
            If tb_first_name.Text <> "" Or tb_Middle_Name.Text <> "" Or tb_Last_Name.Text <> "" Or tb_Mob_No.Text <> "" Or tb_Email_Id.Text <> "" Or post <> "" Or empgen <> "" Or tb_Pan_No.Text <> "" Or tb_Bank_Acc_no.Text <> "" Or tb_emp_sal.Text <> "" Or tb_age.Text <> "" Or tb_address.Text <> "" Or tb_city_town_vill.Text <> "" Or tb_pin_code.Text <> "" Or tb_Addhar_No.Text <> "" Then
                MsgBox("Please Fill All Fields and Save OR Clear All Data", MsgBoxStyle.OkCancel)
            Else
                frm_Owner.Show()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub





    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Try
            Clear_Controls()
            cb_State.Text = "Select State"
            Enabled_False()
        Catch ex As Exception
        End Try
    End Sub

#Region "Checked Changed"
    Private Sub rb_Male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Male.CheckedChanged
        tb_Addhar_No.Enabled = True
    End Sub

    Private Sub rb_Female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Female.CheckedChanged
        tb_Addhar_No.Enabled = True
    End Sub
#End Region

#Region "TextChanged Events"

    Private Sub tb_first_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_first_name.TextChanged
        tb_Middle_Name.Enabled = True
    End Sub
    Private Sub tb_Middle_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Middle_Name.TextChanged
        tb_Last_Name.Enabled = True
    End Sub

    Private Sub tb_Last_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Last_Name.TextChanged
        tb_Mob_No.Enabled = True
    End Sub

    Private Sub tb_Mob_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Mob_No.TextChanged
        tb_Alter_Mob_No.Enabled = True
        tb_Email_Id.Enabled = True
    End Sub

    Private Sub tb_Email_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Email_Id.TextChanged
        panel_post.Enabled = True
    End Sub

    Private Sub rb_Cashier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Cashier.CheckedChanged
        tb_Pan_No.Enabled = True
    End Sub

    Private Sub rb_Receptionist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Receptionist.CheckedChanged
        tb_Pan_No.Enabled = True
    End Sub

    Private Sub rb_Tour_Guide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Tour_Guide.CheckedChanged
        tb_Pan_No.Enabled = True
    End Sub

    Private Sub tb_Pan_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Pan_No.TextChanged
        cb_Bank_Name.Enabled = True
    End Sub
    Private Sub cb_Bank_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Bank_Name.SelectedIndexChanged
        tb_Bank_Acc_no.Enabled = True
    End Sub

    Private Sub tb_Bank_Acc_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Bank_Acc_no.TextChanged
        tb_emp_sal.Enabled = True
    End Sub

    Private Sub tb_emp_sal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_emp_sal.TextChanged
        dtp_emp_DOB.Enabled = True
    End Sub

    Private Sub dtp_emp_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_emp_DOB.ValueChanged
        Dim ts As TimeSpan = DateTime.Now.Date - dtp_emp_DOB.Value
        tb_age.Text = String.Format("{0:n0} years old", (ts.TotalDays / 365))
        'tb_age.Enabled = False
    End Sub

    Private Sub tb_age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_age.TextChanged
        tb_address.Enabled = True
    End Sub

    Private Sub tb_address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_address.TextChanged
        cb_State.Enabled = True
    End Sub

    Private Sub cb_State_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_State.SelectedIndexChanged
        tb_city_town_vill.Enabled = True
    End Sub

    Private Sub tb_city_town_vill_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_city_town_vill.TextChanged
        tb_pin_code.Enabled = True
    End Sub

    Private Sub tb_pin_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pin_code.TextChanged
        rb_Male.Enabled = True
        rb_Female.Enabled = True
    End Sub
    '  Private Sub rb_Male_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Male.TextChanged
    '' If rb_Male.Checked = False And rb_Female.Checked = False Then
    '       tb_Addhar_No.Enabled = True
    '  End If
    '   End Sub
    '   Private Sub rb_Female_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Female.TextChanged
    '  If rb_Male.Checked = False And rb_Female.Checked = False Then
    '       tb_Addhar_No.Enabled = True
    '  End If

 '   End Sub


    Private Sub tb_Addhar_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Addhar_No.TextChanged
        If tb_four_wheel_dri_lic_no.Enabled = False Then
            btn_Save.Enabled = True
        End If
    End Sub
    Private Sub tb_four_wheel_dri_lic_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_four_wheel_dri_lic_no.TextChanged
        btn_Save.Enabled = True
    End Sub
#End Region

#Region "Leave Events"
    Private Sub tb_first_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_first_name.Leave
        If tb_first_name.Text = "" Then
            tb_Middle_Name.Text = ""
            tb_Middle_Name.Enabled = False
        End If
    End Sub

    Private Sub tb_Middle_Name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Middle_Name.Leave
        If tb_Middle_Name.Text = "" Then
            tb_Last_Name.Text = ""
            tb_Last_Name.Enabled = False
        End If
    End Sub

    Private Sub tb_Last_Name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Last_Name.Leave
        If tb_Last_Name.Text = "" Then
            tb_Mob_No.Text = ""
            tb_Mob_No.Enabled = False
        End If
    End Sub

    Private Sub tb_Mob_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Mob_No.Leave
        If tb_Mob_No.Text = "" Then
            tb_Alter_Mob_No.Text = ""
            tb_Alter_Mob_No.Enabled = False
            tb_Email_Id.Text = ""
            tb_Email_Id.Enabled = False
        End If
    End Sub



    Private Sub tb_Email_Id_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Email_Id.Leave
        If tb_Email_Id.Text = "" Then
            rb_Cashier.Checked = False
            rb_Receptionist.Checked = False
            rb_Driver.Checked = False
            rb_Tour_Guide.Checked = False
            panel_post.Enabled = False
        End If
    End Sub

    ' Private Sub panel_post_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panel_post.Leave
    '     If rb_Cashier.Checked = False And rb_Receptionist.Checked = False And rb_Driver.Checked = False And rb_Tour_Guide.Checked = False Then
    '       tb_Pan_No.Text = ""
    '        tb_Pan_No.Enabled = False
    '     End If

    '  End Sub

    Private Sub tb_Pan_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Pan_No.Leave
        If tb_Pan_No.Text = "" Then
            tb_Bank_Acc_no.Text = ""
            tb_Bank_Acc_no.Enabled = False
        End If
    End Sub

    Private Sub tb_Bank_Acc_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Bank_Acc_no.Leave
        If tb_Bank_Acc_no.Text = "" Then
            tb_emp_sal.Text = ""
            tb_emp_sal.Enabled = False
        End If
    End Sub

    Private Sub tb_emp_sal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_emp_sal.Leave
        If tb_emp_sal.Text = "" Then
            dtp_emp_DOB.Text = ""
            dtp_emp_DOB.Enabled = False
        End If
    End Sub

    Private Sub dtp_emp_DOB_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_emp_DOB.Leave
        If dtp_emp_DOB.Text = Today.Date.ToString("dddd, dd MMMM yyyy") Then

            MsgBox("Please Select the Employee Date...", MsgBoxStyle.OkOnly)
            tb_age.Text = ""
        End If

        If tb_age.Text = "" Then
            tb_address.Text = ""
            tb_address.Enabled = False
        End If
    End Sub

    Private Sub tb_address_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_address.Leave
        If tb_address.Text = "" Then
            cb_State.Text = ""
            cb_State.Enabled = False
        End If
    End Sub

    Private Sub cb_State_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_State.Leave
        If cb_State.Text = "" Then
            tb_city_town_vill.Text = ""
            tb_city_town_vill.Enabled = False
        End If
    End Sub

    Private Sub tb_city_town_vill_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_city_town_vill.Leave
        If tb_city_town_vill.Text = "" Then
            tb_pin_code.Text = ""
            tb_pin_code.Enabled = False
        End If
    End Sub

    Private Sub tb_pin_code_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pin_code.Leave
        If tb_pin_code.Text = "" Then
            rb_Male.Checked = False
            rb_Female.Checked = False

            rb_Male.Enabled = True
            rb_Male.Enabled = True
        End If
    End Sub

    ' Private Sub rb_Male_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Male.Leave
    '     If rb_Male.Checked = False And rb_Female.Checked = False Then
    '          tb_Addhar_No.Text = ""
    '          tb_Addhar_No.Enabled = False
    '       End If
    '   End Sub

    '   Private Sub rb_Female_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Female.Leave
    '       If rb_Male.Checked = False And rb_Female.Checked = False Then
    '           tb_Addhar_No.Text = ""
    ''           tb_Addhar_No.Enabled = False
    '       End If
    '   End Sub

    Private Sub tb_Addhar_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Addhar_No.Leave
        If tb_four_wheel_dri_lic_no.Enabled = True Then
            If tb_Addhar_No.Text = "" Then
                MsgBox("Please fill Enter the Addhar No", MsgBoxStyle.OkOnly)
            End If

        ElseIf tb_Addhar_No.Text = "" Then
            'btn_Save.Enabled = False
            tb_Addhar_No.Text = ""
            tb_Addhar_No.Enabled = False
        End If
    End Sub
    Private Sub tb_four_wheel_dri_lic_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_four_wheel_dri_lic_no.Leave
        If tb_four_wheel_dri_lic_no.Text = "" Then
            'btn_Save.Enabled = False
        End If
    End Sub


#End Region

#Region "Click Event"
    Private Sub rb_Driver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Driver.Click
        tb_four_wheel_dri_lic_no.Enabled = True
    End Sub
#End Region

#Region "Key Press Event"

    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_pin_code.KeyPress, tb_Mob_No.KeyPress, tb_emp_sal.KeyPress, tb_Bank_Acc_no.KeyPress, tb_Alter_Mob_No.KeyPress, tb_Addhar_No.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Ischar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_city_town_vill.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If

    End Sub
    Private Sub SingleName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Middle_Name.KeyPress, tb_Last_Name.KeyPress, tb_first_name.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Gmail(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Email_Id.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(64) And e.KeyChar <> Chr(46) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If

    End Sub
    ' Private Sub PanNo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Pan_No.KeyPress, MyBase.KeyPress

    ' If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(65) Or e.KeyChar > Chr(90))) Then
    '
    '   e.Handled = True

    ' End If

    ' End Sub
    Private Sub FourDriLic(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_four_wheel_dri_lic_no.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(45) And e.KeyChar <> Chr(32) And (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57))) Then

            e.Handled = True

        End If

    End Sub
#End Region

   
    
End Class