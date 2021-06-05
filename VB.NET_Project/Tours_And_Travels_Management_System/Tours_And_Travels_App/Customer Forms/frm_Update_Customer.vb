Imports System.Data.SqlClient

Public Class frm_Update_Customer

    Dim custgen As String = Nothing
    Function values()
        If rb_Male.Checked = True Then
            custgen = rb_Male.Text
        ElseIf rb_Female.Checked = True Then
            custgen = rb_Female.Text
        End If
        Return 0
    End Function
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_cust_id.Text <> "" Then

                getconnection()
                cmd = New SqlCommand("select * from Cust_Info where cust_id = " & tb_cust_id.Text & "", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    tb_pkg_id.Text = dr("pkg_id")
                    dtp_Cust_today_date.Value = dr("booking_date")
                    tb_first_name.Text = dr("first_name").ToString
                    tb_Middle_Name.Text = dr("middle_name").ToString
                    tb_Last_Name.Text = dr("last_name").ToString
                    tb_Mob_No.Text = dr("mob_no")
                    tb_Alter_Mob_No.Text = dr("alter_mob_no").ToString
                    tb_Email_Id.Text = dr("email_id")
                    dtp_cust_DOB.Value = dr("DOB")
                    tb_age.Text = dr("age")
                    tb_address.Text = dr("address").ToString
                    custgen = dr("gender")
                    tb_Addhar_No.Text = dr("addhar_no")
                    tb_Pan_No.Text = dr("pan_no")
                    dtp_tour_start_date.Value = dr("t_start_date")
                    dtp_tour_end_date.Value = dr("t_end_date")
                End If
                cmd.Dispose()
                dr.Close()

                cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age <= " & 18 & "", con)
                tb_No_Children.Text = cmd.ExecuteScalar
                cmd.Dispose()

                cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age > " & 18 & "", con)
                tb_No_Adult.Text = cmd.ExecuteScalar
                cmd.Dispose()

                If custgen = "Male" Then
                    rb_Male.Checked = True
                ElseIf custgen = "female" Then
                    rb_Female.Checked = True
                End If

                terminateconnection()
                cmd.Dispose()
                dr.Close()
                btn_Update_Travellers_Info.Enabled = True
                btn_Update.Enabled = True
                btn_Add_New_Traveller.Enabled = True
            Else
                MsgBox("Please Enter Customer ID First", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_cust_id_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cust_id.Leave
        Try
            If tb_cust_id.Text = "" Then
                btn_Update.Enabled = False
                btn_Update_Travellers_Info.Enabled = False
                btn_Change_Pkg.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Update_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_cust_id.Focus()
       
    End Sub

    Private Sub btn_Change_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Change_Pkg.Click
        Comman_Declared.cust_verifying_form = 2
        frm_Show_Pkgs_to_Customer.Show()
    End Sub

    Private Sub frm_Update_Customer_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            If Comman_Declared.cust_verifying_form = 2 Then
                tb_pkg_id.Text = Comman_Declared.show_pkg_id
                dtp_Cust_today_date.Value = Date.Now.Date
                dtp_cust_DOB.Value = Date.Now.Date
                tb_pkg_id.Text = Comman_Declared.show_pkg_id
                dtp_tour_start_date.Value = frm_View_Single_Package.cb_tour_dates.SelectedItem
                getconnection()

                Dim dr As SqlDataReader
                cmd = New SqlCommand("select days_dur from Pkg_Info where pkg_id = " & tb_pkg_id.Text & "", con)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Comman_Declared.c_days_dur = dr("days_dur")
                End If
                dtp_tour_end_date.Value = dtp_tour_start_date.Value.AddDays(Comman_Declared.c_days_dur - 1)
                'Dim replace As String = CDate(tb_tour_start_date.Text).AddDays(Comman_Declared.c_days_dur - 1).ToShortDateString
                'tb_tour_end_date.Text = replace
                Comman_Declared.c_days_dur = 0
                Comman_Declared.cust_verifying_form = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Update_Travellers_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Travellers_Info.Click
        Try
            If tb_cust_id.Text <> "" And tb_first_name.Text <> "" Then
                getconnection()
                Dim x As Integer = 22
                Dim y As Integer = 150
                Dim p_sr_no As Integer = 1
                cmd = New SqlCommand("select * from Traveller where cust_id = " & tb_cust_id.Text & "", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()

                Comman_Declared.add_traveller_verifying_form = 3
                frm_Add_Travellers_Information.Show()
                frm_Add_Travellers_Information.btn_Edit_Travellers_No.Hide()
                frm_Add_Travellers_Information.btn_Back.Enabled = True

                While dr.Read()
                    Dim obj = New UC_Add_Travellers
                    obj.Location = New System.Drawing.Point(x, y)

                    obj.tb_Passenger_Name.Enabled = True
                    obj.tb_Addhar_No.Enabled = True
                    obj.dtp_DOB.Enabled = True
                    obj.btn_Next.Text = "Update"

                    obj.lbl_traveller_id.Text = dr("trave_id")
                    obj.tb_Passenger_Name.Text = dr("pass_name")
                    obj.dtp_DOB.Value = dr("DOB")
                    obj.tb_Age.Text = dr("age")
                    obj.tb_Addhar_No.Text = dr("addhar_no")

                    frm_Add_Travellers_Information.Controls.Add(obj)

                    obj.lbl_Sr_no.Text = p_sr_no


                    x = x + 1270

                    y = y + 30

                    x = 22


                    'If pa_count <= enabled - 1 Then
                    '    obj.Enabled = False
                    'End If
                    p_sr_no = p_sr_no + 1
                End While
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Try
            If tb_cust_id.Text <> "" Then
                getconnection()
                btn_Update.Enabled = True
                btn_Update_Travellers_Info.Enabled = True
                btn_Change_Pkg.Enabled = True
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And tb_Addhar_No.Text <> "" And custgen <> Nothing Then
                    cmd = New SqlCommand("Update Cust_Info set pkg_id = " & tb_pkg_id.Text & ",booking_date = '" & dtp_Cust_today_date.Text & "',first_name = '" & tb_first_name.Text & "',middle_name = '" & tb_Middle_Name.Text & "',last_name = '" & tb_Last_Name.Text & "',mob_no = " & tb_Mob_No.Text & ",alter_mob_no = " & tb_Alter_Mob_No.Text & ",email_id = '" & tb_Email_Id.Text & "',DOB = '" & dtp_cust_DOB.Text & "',age = " & tb_age.Text & ",address = '" & tb_address.Text & "',gender = '" & custgen & "',addhar_no = " & tb_Addhar_No.Text & ",pan_no = '" & tb_Pan_No.Text & "',tot_traveller = " & tb_Passen_Total.Text & ",t_start_date = '" & dtp_tour_start_date.Text & "',t_end_date = '" & dtp_tour_end_date.Text & "' where cust_id = " & tb_cust_id.Text & "", con)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Record Updated Successfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                    Else
                        MsgBox("Record Not Updated ", MsgBoxStyle.OkOnly)
                    End If

                    '===============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

                    Dim pkg_id As Integer = 0
                    Dim cust_id As Integer = 0
                    Dim trave_id As Integer = 0
                    Dim pass_name As String = 0
                    Dim gender As String = 0
                    Dim DOB As String = 0
                    Dim age As String = 0
                    Dim addhar_no As ULong = 0

                    cmd = New SqlCommand("select count(cust_id) from temporary_traveller where cust_id = " & tb_cust_id.Text & "", con)
                    Dim trave_cnt As Integer = cmd.ExecuteScalar
                    cmd.Dispose()

                    While trave_cnt > 0
                        Dim dr As SqlDataReader
                        cmd = New SqlCommand("select * from temporary_traveller where cust_id = " & tb_cust_id.Text & "", con)
                        dr = cmd.ExecuteReader

                        If dr.Read() Then
                            trave_id = dr("trave_id")
                            pass_name = dr("pass_name")
                            gender = dr("gender")
                            pkg_id = dr("pkg_id")
                            cust_id = dr("cust_id")
                            DOB = dr("DOB")
                            age = dr("age")
                            addhar_no = dr("addhar_no")
                        End If
                        cmd.Dispose()
                        dr.Close()

                        cmd = New SqlCommand("Update Traveller Set pass_name = '" & pass_name & "',gender = '" & gender & "',DOB = '" & DOB & "',age = " & age & ",addhar_no = " & addhar_no & " where trave_id = " & trave_id & "", con)
                        If cmd.ExecuteNonQuery > 0 Then
                            cmd.Dispose()
                        Else
                            cmd = New SqlCommand("insert into Traveller values(" & pkg_id & "," & cust_id & "," & trave_id & ",'" & pass_name & "','" & gender & "','" & DOB & "'," & age & "," & addhar_no & ")", con)
                            If cmd.ExecuteNonQuery > 0 Then
                                cmd.Dispose()
                                If age <= 18 Then
                                    cmd = New SqlCommand("select no_children from Cust_Info where cust_id = " & tb_cust_id.Text & "", con)
                                    Dim cust As Integer = cmd.ExecuteScalar
                                    cmd.Dispose()

                                    cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age <= " & 18 & "", con)
                                    Dim tra_count As Integer = cmd.ExecuteScalar
                                    cmd.Dispose()

                                    If tra_count <> cust Then
                                        cmd = New SqlCommand("Update Cust_Info set no_children = " & tra_count & " where cust_id = " & tb_cust_id.Text & "", con)
                                        cmd.ExecuteNonQuery()
                                        cmd.Dispose()
                                    End If
                                ElseIf age > 18 Then
                                    cmd = New SqlCommand("select no_adult from Cust_Info where cust_id = " & tb_cust_id.Text & "", con)
                                    Dim cust As Integer = cmd.ExecuteScalar
                                    cmd.Dispose()

                                    cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age > " & 18 & "", con)
                                    Dim tra_count As Integer = cmd.ExecuteScalar
                                    cmd.Dispose()

                                    If tra_count <> cust Then
                                        cmd = New SqlCommand("Update Cust_Info set no_adult = " & tra_count & " where cust_id = " & tb_cust_id.Text & "", con)
                                        cmd.ExecuteNonQuery()
                                        cmd.Dispose()
                                    End If
                                End If
                            End If
                        End If


                        cmd = New SqlCommand("Delete from temporary_traveller where trave_id = " & trave_id & "", con)
                        If trave_cnt = trave_cnt - (trave_cnt - 1) Then
                            If cmd.ExecuteNonQuery > 0 Then
                                MsgBox("Record are Successfully Deleted from temporary_traveller....", MsgBoxStyle.OkOnly)
                                cmd.Dispose()
                            Else
                                MsgBox("Record are Not Deleted from temporary_traveller....", MsgBoxStyle.OkOnly)
                            End If
                        Else
                            cmd.ExecuteNonQuery()
                        End If
                        cmd.Dispose()
                        trave_cnt = trave_cnt - 1
                    End While

                Else
                    MsgBox("First Fill All Fields..", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please Enter Customer Id First", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_add_new_traveller_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_add_new_traveller.Leave
        If tb_add_new_traveller.Text = "" Then
            btn_Add_New_Traveller.Enabled = False
        End If
    End Sub

    Private Sub btn_Add_New_Traveller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Traveller.Click
        Try
            getconnection()
            frm_Add_Travellers_Information.Close()
            If tb_add_new_traveller.Text <> "" Then
                If Val(tb_add_new_traveller.Text) > 0 Then
                    Comman_Declared.co_passenger = Val(tb_add_new_traveller.Text)
                    Comman_Declared.c_traveller_id = Auto_Increment("select count(cust_id) from Traveller", 191)
                    Dim x As Integer = 22
                    Dim y As Integer = 150
                    Dim p_sr_no As Integer = 1
                    Dim pa_count As Integer = Val(tb_add_new_traveller.Text)
                    frm_Add_Travellers_Information.Show()

                    While pa_count > 0
                        Dim obj = New UC_Add_Travellers
                        obj.Location = New System.Drawing.Point(x, y)

                        obj.btn_Next.Text = "Set"
                        frm_Add_Travellers_Information.Controls.Add(obj)

                        obj.lbl_Sr_no.Text = p_sr_no
                        obj.lbl_traveller_id.Text = Comman_Declared.c_traveller_id

                        x = x + 1270

                        y = y + 30

                        x = 22

                        Comman_Declared.c_traveller_id = Comman_Declared.c_traveller_id + 1

                        p_sr_no = p_sr_no + 1
                        pa_count = pa_count - 1
                    End While

                Else
                    MsgBox("Please Enter Correct Number....", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please enter total Number of Traveller....", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function clear()
        frm_Add_Travellers_Information.Close()
        clearAllTxtbo(panel_Name)
        clearAllTxtbo(panel_Custo_Con_Det)
        clearAllTxtbo(panel_no_of_travellers)
        clearAllTxtbo(panel_other_details)
        clearAllTxtbo(panel_leagel_info)
        dtp_cust_DOB.Value = Today.Date
        dtp_Cust_today_date.Value = Today.Date
        dtp_tour_start_date.Value = Today.Date
        dtp_tour_end_date.Value = Today.Date
        clearAllRadiobutton(panel_other_details)
        tb_pkg_id.Text = ""
        tb_cust_id.Text = ""

        getconnection()
        cmd = New SqlCommand("select count(trave_id) from temporary_traveller ", con)
        Dim cnt As Integer = cmd.ExecuteScalar()
        If cnt > 0 Then
            cmd.Dispose()
            cmd = New SqlCommand("Truncate table temporary_traveller", con)
            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("temporary traveller are truncated Successfull...", MsgBoxStyle.OkOnly)
            End If
        End If
        Return 0
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frm_Owner.Show()
    End Sub

    Private Sub tb_No_Children_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Children.TextChanged
        If tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" Then
            tb_Passen_Total.Text = Val(tb_No_Adult.Text) + Val(tb_No_Children.Text)
        End If
    End Sub

    Private Sub tb_No_Adult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Adult.TextChanged
        If tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" Then
            tb_Passen_Total.Text = Val(tb_No_Adult.Text) + Val(tb_No_Children.Text)
        End If
    End Sub
    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Mob_No.KeyPress, tb_Alter_Mob_No.KeyPress, tb_Addhar_No.KeyPress, tb_No_Adult.KeyPress, tb_No_Children.KeyPress, tb_cust_id.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

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
End Class