Imports System.Data.SqlClient

Public Class frm_Update_Employee

    Dim post As String
    Dim empgen As String
    Dim state As String

    Function Clear_Controls()
        tb_Emp_id.Text = ""
        cb_Bank_Name.Enabled = False
        dtp_DOB.Value = Date.Now.Date
        dtp_Joining_date.Value = Date.Now.Date
        clearAllTxtbo(panel_name)
        clearAllTxtbo(panel_Custo_Con_Det)
        clearAllTxtbo(panel_sal)
        clearAllTxtbo(panel_other_details)
        clearAllTxtbo(panel_legal_info)
        clearAllCombo(panel_other_details)
        clearAllRadiobutton(panel_post)
        clearAllRadiobutton(panel_other_details)
        post = Nothing
        empgen = Nothing
        state = Nothing
        Return 0
    End Function
    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            values()
            If tb_first_name.Text <> "" Or tb_Middle_Name.Text <> "" Or tb_Last_Name.Text <> "" Or tb_Mob_No.Text <> "" Or tb_Email_Id.Text <> "" Or post <> Nothing Or empgen <> Nothing Or tb_pan_no.Text <> "" Or tb_Bank_Acc_no.Text <> "" Or tb_emp_sal.Text <> "" Or tb_age.Text <> "" Or tb_address.Text <> "" Or tb_State.Text <> "" Or tb_City_Town_Vill.Text <> "" Or tb_pin_code.Text <> "" Or tb_Addhar_No.Text <> "" Then
                MsgBox("Please Update the data OR Clear All fields", MsgBoxStyle.OkCancel)

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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Fetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
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
                    dtp_DOB.Value = dr("DOB").ToString
                    tb_age.Text = dr("age")
                    tb_address.Text = dr("address").ToString
                    tb_State.Text = (dr("state")).ToString()
                    tb_City_Town_Vill.Text = dr("city_town_vill").ToString
                    tb_pin_code.Text = dr("pin_code")
                    Dim gender As String = dr("gender").ToString
                    tb_Addhar_No.Text = dr("addhar_no")
                    tb_four_wheelr_dri_lic.Text = dr("four_dri_lic")
                    tb_pan_no.Text = dr("pan_no")
                    tb_Curr_Bank_Nm.Text = dr("bank_name")
                    tb_Bank_Acc_no.Text = dr("bank_acc_no")
                    tb_emp_sal.Text = dr("salary")

                    If post = "Cashier" Then
                        rb_Cashier.Checked = True
                    ElseIf post = "Driver" Then
                        tb_four_wheelr_dri_lic.Enabled = True
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
                    cb_Bank_Name.Enabled = True
                Else
                    MsgBox("Record Not Found...", MsgBoxStyle.OkOnly)
                    Clear_Controls()
                End If

            Else
                MsgBox("Please Enter Employee ID First..", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_Bank_Name_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Bank_Name.SelectedValueChanged
        tb_Curr_Bank_Nm.Text = cb_Bank_Name.Text
    End Sub

    Private Sub frm_Update_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Emp_id.Focus()
    End Sub

    Private Sub rb_Driver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Driver.CheckedChanged
        Try
            If rb_Driver.Checked = True Then
                tb_four_wheelr_dri_lic.Enabled = True
            ElseIf rb_Driver.Checked = False Then
                tb_four_wheelr_dri_lic.Enabled = False
                tb_four_wheelr_dri_lic.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
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

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Try
            getconnection()
            values()

            If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_pan_no.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And tb_State.Text <> "" And tb_City_Town_Vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
                cmd = New SqlCommand("Update Emp_Info set first_name = '" & tb_first_name.Text & "',middle_name = '" & tb_Middle_Name.Text & "',last_name = '" & tb_Last_Name.Text & "',mob_no = " & tb_Mob_No.Text & ",alter_mob_no = " & tb_Alter_Mob_No.Text & ",email_id = '" & tb_Email_Id.Text & "',emp_post = '" & post & "',join_date = '" & dtp_Joining_date.Text & "',DOB = '" & dtp_DOB.Text & "',age = '" & tb_age.Text & "',address = '" & tb_address.Text & "',state = '" & tb_State.Text & "',city_town_vill = '" & tb_City_Town_Vill.Text & "',pin_code = " & tb_pin_code.Text & " ,gender = '" & empgen & "', addhar_no = " & tb_Addhar_No.Text & ", four_dri_lic = '" & tb_four_wheelr_dri_lic.Text & "', pan_no = '" & tb_pan_no.Text & "', bank_name = '" & tb_Curr_Bank_Nm.Text & "', bank_acc_no = " & tb_Bank_Acc_no.Text & " , salary = " & tb_emp_sal.Text & " where emp_id = " & tb_Emp_id.Text & "", con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                    MsgBox("Record Update Successfully...!")
                    cmd.Dispose()
                Else
                    MsgBox("Record Not Saved Successfully....?")
                End If
            Else
                MsgBox("First Select Employee...", MsgBoxStyle.OkOnly)
            End If

            Clear_Controls()

            ''        If tb_Alter_Mob_No.Text = "" And rb_Driver.Checked = False Then
            ''        If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_pan_no.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_City_Town_Vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
            ''            cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,email_id,emp_post,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & tb_Emp_id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & empgen & "','" & dtp_emp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_City_Town_Vill.Text & "'," & tb_pin_code.Text & "," & tb_Addhar_No.Text & ",'" & tb_pan_no.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
            ''            Dim i As Integer = cmd.ExecuteNonQuery()
            ''            If (i > 0) Then
            ''                MsgBox("Record Saved Successfully...!")
            ''                'Clear_Controls()
            ''                'Enabled_False()
            ''                cmd.Dispose()
            ''            Else
            ''                MsgBox("Record Not Saved Successfully....?")
            ''            End If
            ''        Else
            ''            MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
            ''        End If
            ''        ElseIf tb_Alter_Mob_No.Text <> "" And rb_Driver.Checked = False Then
            ''        If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_pan_no.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_City_Town_Vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" Then
            ''            cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & tb_Emp_id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & empgen & "','" & dtp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_City_Town_Vill.Text & "'," & tb_pin_code.Text & "," & tb_Addhar_No.Text & ",'" & tb_pan_no.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
            ''            Dim i As Integer = cmd.ExecuteNonQuery()
            ''            If (i > 0) Then
            ''                MsgBox("Record Saved Successfully...!")
            ''                'Clear_Controls()
            ''                'Enabled_False()
            ''                cmd.Dispose()
            ''            Else
            ''                MsgBox("Record Not Saved Successfully....?")
            ''            End If
            ''        Else
            ''            MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
            ''        End If
            ''        ElseIf tb_Alter_Mob_No.Text = "" And rb_Driver.Checked = True Then
            ''        If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_pan_no.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_City_Town_Vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" And tb_four_wheelr_dri_lic.Text <> "" Then
            ''            cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,four_dri_lic,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & tb_Emp_id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & empgen & "','" & dtp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_City_Town_Vill.Text & "'," & tb_pin_code.Text & "," & tb_Addhar_No.Text & ",'" & tb_four_wheelr_dri_lic.Text & "','" & tb_pan_no.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
            ''            Dim i As Integer = cmd.ExecuteNonQuery()
            ''            If (i > 0) Then
            ''                MsgBox("Record Saved Successfully...!")
            ''                'Clear_Controls()
            ''                'Enabled_False()
            ''                cmd.Dispose()
            ''            Else
            ''                MsgBox("Record Not Saved Successfully....?")
            ''            End If
            ''        Else
            ''            MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
            ''        End If
            ''        ElseIf tb_Alter_Mob_No.Text <> "" And rb_Driver.Checked = True Then
            ''        If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Alter_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And post <> "" And empgen <> "" And tb_pan_no.Text <> "" And tb_Bank_Acc_no.Text <> "" And tb_emp_sal.Text <> "" And dtp_DOB.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_City_Town_Vill.Text <> "" And tb_pin_code.Text <> "" And tb_Addhar_No.Text <> "" And tb_four_wheelr_dri_lic.Text <> "" Then
            ''            cmd = New SqlCommand("Insert Into Emp_Info (emp_id,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,emp_post,DOB,age,address,state,city_town_vill,pin_code,gender,addhar_no,four_dri_lic,pan_no,bank_name,bank_acc_no,salary,avability) Values(" & tb_Emp_id.Text & ",'" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & post & "','" & empgen & "','" & dtp_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & tb_City_Town_Vill.Text & "'," & tb_pin_code.Text & "," & tb_Addhar_No.Text & ",'" & tb_four_wheelr_dri_lic.Text & "','" & tb_pan_no.Text & "','" & cb_Bank_Name.Text & "'," & tb_Bank_Acc_no.Text & "," & tb_emp_sal.Text & ",'" & 1 & "')", con)
            ''            Dim i As Integer = cmd.ExecuteNonQuery()
            ''            If (i > 0) Then
            ''                MsgBox("Record Saved Successfully...!")
            ''                'Clear_Controls()
            ''                'Enabled_False()
            ''                cmd.Dispose()
            ''            Else
            ''                MsgBox("Record Not Saved Successfully....?")
            ''            End If
            ''        Else
            ''            MsgBox("Please Fill All Fields...?", MsgBoxStyle.OkOnly)
            ''        End If
            ''        End If
        Catch ex As Exception
        End Try
    End Sub




    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_pin_code.KeyPress, tb_Mob_No.KeyPress, tb_emp_sal.KeyPress, tb_Bank_Acc_no.KeyPress, tb_Alter_Mob_No.KeyPress, tb_Addhar_No.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Ischar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_City_Town_Vill.KeyPress

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
    Private Sub FourDriLic(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_four_wheelr_dri_lic.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(45) And e.KeyChar <> Chr(32) And (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57))) Then

            e.Handled = True

        End If

    End Sub

    Private Sub dtp_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DOB.ValueChanged
        Try
            Dim ts As TimeSpan = DateTime.Now.Date - dtp_DOB.Value
            tb_age.Text = String.Format("{0:n0} years old", (ts.TotalDays / 365))
        Catch ex As Exception
        End Try
    End Sub
End Class