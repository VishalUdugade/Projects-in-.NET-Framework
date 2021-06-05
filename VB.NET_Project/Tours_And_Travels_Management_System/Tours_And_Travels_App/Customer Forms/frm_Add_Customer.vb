Imports System.Data.SqlClient

'Imports Bunifu.Framework.UI

Public Class frm_Add_Customer
    Dim custgen As String = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            tb_first_name.Text = ""
            tb_Middle_Name.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Add_Travellers_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Travellers_Info.Click
        Try
            If MsgBox("Please Sure that you enterd numbers is Correct..", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                Comman_Declared.co_passenger = tb_Passen_Total.Text
                frm_Add_Travellers_Information.Show()
                getconnection()
                Comman_Declared.c_traveller_id = Auto_Increment("select max(trave_id) from Traveller", 1)
                Dim x As Integer = 22
                Dim y As Integer = 150
                Dim p_sr_no As Integer = 1
                Dim pa_count As Integer = Comman_Declared.co_passenger
                'Dim enabled As Integer = Comman_Declared.co_passenger

                While pa_count > 0
                    Dim obj = New UC_Add_Travellers
                    obj.Location = New System.Drawing.Point(x, y)
                    frm_Add_Travellers_Information.Controls.Add(obj)

                    obj.lbl_Sr_no.Text = p_sr_no
                    obj.lbl_traveller_id.Text = Comman_Declared.c_traveller_id

                    x = x + 1270

                    y = y + 30

                    x = 22

                    Comman_Declared.c_traveller_id = Comman_Declared.c_traveller_id + 1
                    'If pa_count <= enabled - 1 Then
                    '    obj.Enabled = False
                    'End If
                    p_sr_no = p_sr_no + 1
                    pa_count = pa_count - 1
                End While
                Comman_Declared.add_traveller_verifying_form = 1
                ' Me.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Adult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" Then
                tb_Passen_Total.Text = Val(tb_No_Children.Text) + Val(tb_No_Adult.Text)
                btn_Add_Travellers_Info.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Children_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" Then
                tb_Passen_Total.Text = Val(tb_No_Children.Text) + Val(tb_No_Adult.Text)
                If tb_Passen_Total.Text <> "" Then
                    btn_Add_Travellers_Info.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Payment.Click
        Try
            Comman_Declared.pay_verifying_form = 2
            frm_Payment.Show()
            Me.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Add_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lbl_Pkg_id.Text = Comman_Declared.show_pkg_id
            If Val(lbl_Pkg_id.Text) = 0 Then
                MsgBox("Please Select Package First", MsgBoxStyle.OkOnly)
                Me.Close()
                frm_Show_Pkgs_to_Customer.Show()
                Return
            End If
            lbl_Cust_Id.Text = Auto_Increment("select count(cust_id) from Cust_Info", 4001)
            Comman_Declared.back_button = 1
            tb_first_name.Focus()
            dtp_Cust_today_date.Value = Date.Now.Date
            dtp_cust_DOB.Value = Date.Now.Date
            If frm_View_Single_Package.cb_tour_dates.SelectedIndex <> -1 Then
                dtp_tour_start_date.Value = frm_View_Single_Package.cb_tour_dates.SelectedItem
            End If
            getconnection()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("select days_dur from Pkg_Info where pkg_id = " & lbl_Pkg_id.Text & "", con)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Comman_Declared.c_days_dur = dr("days_dur")
            End If
            dtp_tour_end_date.Value = dtp_tour_start_date.Value.AddDays(Comman_Declared.c_days_dur - 1)
            Comman_Declared.c_days_dur = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            frm_View_Single_Package.Close()
            Me.Close()
            frm_Owner.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Children_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If tb_No_Children.Text = "" Then
                btn_Add_Travellers_Info.Enabled = False
                tb_Passen_Total.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Adult_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If tb_No_Adult.Text = "" Then
                btn_Add_Travellers_Info.Enabled = False
                tb_Passen_Total.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Mob_No.KeyPress, tb_Alter_Mob_No.KeyPress, tb_Addhar_No.KeyPress, tb_No_Adult.KeyPress, tb_No_Children.KeyPress
        Try
            If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

                e.Handled = True

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SingleName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Middle_Name.KeyPress, tb_Last_Name.KeyPress, tb_first_name.KeyPress
        Try
            If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

                e.Handled = True

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Gmail(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_Email_Id.KeyPress
        Try
            If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(64) And e.KeyChar <> Chr(46) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

                e.Handled = True

            End If
        Catch ex As Exception
        End Try
    End Sub
   


    Private Sub dtp_emp_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_cust_DOB.ValueChanged
        Try
            If dtp_cust_DOB.Value < Date.Now.Date Then
                Dim ts As TimeSpan = DateTime.Now.Date - dtp_cust_DOB.Value
                tb_age.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
            ElseIf dtp_cust_DOB.Value > Date.Now.Date Then
                tb_age.Text = ""

            End If
        Catch ex As Exception
        End Try
    End Sub

    Function values()
            If rb_Male.Checked = True Then
                custgen = rb_Male.Text
            ElseIf rb_Female.Checked = True Then
                custgen = rb_Female.Text
            End If
            Return 0
    End Function

    Function traveller_data()
        getconnection()
        Dim cntt As Integer = 0
        Dim pkg_id As Integer = 0
        Dim cust_id As Integer = 0
        Dim trave_id As Integer = 0
        Dim pass_name As String = Nothing
        Dim gender As String = Nothing
        Dim dob As String = Nothing
        Dim age As Integer = 0
        Dim addhar_no As String = 0


        cmd = New SqlCommand("select count(pkg_id) from temporary_traveller where cust_id = " & lbl_Cust_Id.Text & "", con)
        cntt = cmd.ExecuteScalar()
        'Dim cnt As Integer = Comman_Declared.co_passenger

        While cntt > 0
            cmd = New SqlCommand("select * from temporary_traveller ", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                pkg_id = dr("pkg_id")
                cust_id = dr("cust_id")
                trave_id = dr("trave_id")
                pass_name = dr("pass_name").ToString
                gender = dr("gender").ToString
                dob = dr("DOB").ToString
                age = dr("age")
                addhar_no = dr("addhar_no")
            End If
            cmd.Dispose()
            dr.Close()

            cmd = New SqlCommand("insert into Traveller values(" & pkg_id & "," & cust_id & "," & trave_id & ",'" & pass_name & "','" & gender & "','" & dob & "'," & age & "," & addhar_no & ")", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New SqlCommand("Delete from temporary_traveller where trave_id = " & trave_id & "", con)
            If cntt = cntt - (cntt - 1) Then
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record are deleted fromt tem.traveller and added into traveller Successfully...", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record Not deleted fromt tem.traveller and added into traveller Successfully...", MsgBoxStyle.OkOnly)
                End If
            Else
                cmd.ExecuteNonQuery()
            End If
            cmd.Dispose()
            cntt = cntt - 1
        End While
        Return 0
    End Function

    Private Sub btn_Save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            getconnection()
            values()
            If tb_Alter_Mob_No.Text = "" And tb_Pan_No.Text = "" Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" And btn_Add_Travellers_Info.Enabled = True And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_Addhar_No.Text <> "" And custgen = Nothing Then
                    cmd = New SqlCommand("insert into Cust_Info(cust_id,pkg_id,booking_date,first_name,middle_name,last_name,mob_no,email_id,DOB,age,address,state,gender,addhar_no,no_children,no_adult,t_start_date,t_end_date) values(" & lbl_Cust_Id.Text & "," & lbl_Pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "','" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & dtp_cust_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & custgen & "'," & tb_Addhar_No.Text & "," & tb_No_Children.Text & "," & tb_No_Adult.Text & ",'" & dtp_tour_start_date.Value & "','" & dtp_tour_end_date.Value & "'", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                        traveller_data()
                        lbl_Cust_Id.Text = Auto_Increment("select count(cust_id) from Cust_Info", 4001)
                    Else
                        MsgBox("Record Not Saved Successfully...", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Please First Fill All Fields....", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text <> "" And tb_Pan_No.Text = "" Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" And btn_Add_Travellers_Info.Enabled = True And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_Addhar_No.Text <> "" And custgen = Nothing And tb_Alter_Mob_No.Text <> "" Then
                    cmd = New SqlCommand("insert into Cust_Info(cust_id,pkg_id,booking_date,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,DOB,age,address,state,gender,addhar_no,no_children,no_adult,t_start_date,t_end_date) values(" & lbl_Cust_Id.Text & "," & lbl_Pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "','" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & dtp_cust_DOB.Text & "','" & tb_age.Text & "','" & tb_address.Text & "','" & cb_State.Text & "','" & custgen & "'," & tb_Addhar_No.Text & "," & tb_No_Children.Text & "," & tb_No_Adult.Text & ",'" & dtp_tour_start_date.Value & "','" & dtp_tour_end_date.Value & "'", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                        traveller_data()
                        lbl_Cust_Id.Text = Auto_Increment("select count(cust_id) from Cust_Info", 4001)
                    Else
                        MsgBox("Record Not Saved Successfully...", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Please First Fill All Fields....", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text = "" And tb_Pan_No.Text <> "" Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" And btn_Add_Travellers_Info.Enabled = True And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.SelectedIndex <> -1 And tb_Addhar_No.Text <> "" And tb_Pan_No.Text <> "" Then
                    cmd = New SqlCommand("insert into Cust_Info(cust_id,pkg_id,booking_date,first_name,middle_name,last_name,mob_no,email_id,DOB,age,address,state,gender,addhar_no,pan_no,no_children,no_adult,t_start_date,t_end_date) values(" & lbl_Cust_Id.Text & "," & lbl_Pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "','" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & dtp_cust_DOB.Text & "'," & tb_age.Text & ",'" & tb_address.Text & "','" & cb_State.Text & "','" & custgen & "'," & tb_Addhar_No.Text & ",'" & tb_Pan_No.Text & "'," & tb_No_Children.Text & "," & tb_No_Adult.Text & ",'" & dtp_tour_start_date.Text & "','" & dtp_tour_end_date.Text & "')", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                        traveller_data()
                        lbl_Cust_Id.Text = Auto_Increment("select count(cust_id) from Cust_Info", 4001)
                    Else
                        MsgBox("Record Not Saved Successfully...", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Please First Fill All Fields....", MsgBoxStyle.OkOnly)
                End If
            ElseIf tb_Alter_Mob_No.Text <> "" And tb_Pan_No.Text <> "" Then
                If tb_first_name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Mob_No.Text <> "" And tb_Email_Id.Text <> "" And tb_No_Adult.Text <> "" And tb_No_Children.Text <> "" And tb_age.Text <> "" And tb_address.Text <> "" And cb_State.Text <> "" And tb_Addhar_No.Text <> "" And custgen <> Nothing And tb_Pan_No.Text <> "" And tb_Alter_Mob_No.Text <> "" Then
                    cmd = New SqlCommand("insert into Cust_Info(cust_id,pkg_id,booking_date,first_name,middle_name,last_name,mob_no,alter_mob_no,email_id,DOB,age,address,state,gender,addhar_no,pan_no,no_children,no_adult,t_start_date,t_end_date) values(" & lbl_Cust_Id.Text & "," & lbl_Pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "','" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "'," & tb_Mob_No.Text & "," & tb_Alter_Mob_No.Text & ",'" & tb_Email_Id.Text & "','" & dtp_cust_DOB.Text & "'," & tb_age.Text & ",'" & tb_address.Text & "','" & cb_State.Text & "','" & custgen & "'," & tb_Addhar_No.Text & ",'" & tb_Pan_No.Text & "'," & tb_No_Children.Text & "," & tb_No_Adult.Text & ",'" & dtp_tour_start_date.Text & "','" & dtp_tour_end_date.Text & "')", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Successfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                        traveller_data()
                        lbl_Cust_Id.Text = Auto_Increment("select count(cust_id) from Cust_Info", 4001)
                    Else
                        MsgBox("Record Not Saved Successfully...", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Please First Fill All Fields....", MsgBoxStyle.OkOnly)
                End If
            End If
            clear()
            terminateconnection()
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
        clearAllRadiobutton(panel_other_details)
        cb_State.SelectedIndex = -1
        btn_Add_Travellers_Info.Enabled = False
        Return 0
    End Function
    Private Sub btn_clear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Try
            If tb_Passen_Total.Text <> "" Then
                getconnection()
                cmd = New SqlCommand("select count(trave_id) from temporary_traveller", con)
                If cmd.ExecuteNonQuery > 0 Then
                    If MsgBox("Are you Sure Want to Clear", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                        cmd = New SqlCommand("truncate table temporary_traveller ", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                End If
            End If
            clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Adult_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Adult.TextChanged
        Try
            If tb_No_Children.Text <> "" And tb_No_Adult.Text <> "" Then
                tb_Passen_Total.Text = Val(tb_No_Children.Text) + Val(tb_No_Adult.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Children_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Children.TextChanged
        Try
            If tb_No_Children.Text <> "" And tb_No_Adult.Text <> "" Then
                tb_Passen_Total.Text = Val(tb_No_Children.Text) + Val(tb_No_Adult.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Children_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Children.Leave
        Try
            If tb_No_Children.Text = "" Then
                tb_Passen_Total.Text = ""
                btn_Add_Travellers_Info.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_No_Adult_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_No_Adult.Leave
        Try
            If tb_No_Adult.Text = "" Then
                tb_Passen_Total.Text = ""
                btn_Add_Travellers_Info.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Change_Pkg_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Change_Pkg_Details.Click
        Me.Hide()
        frm_View_Single_Package.Show()
    End Sub

    Private Sub frm_Add_Customer_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Comman_Declared.back_button = 1
            tb_first_name.Focus()
            dtp_Cust_today_date.Value = Date.Now.Date
            dtp_cust_DOB.Value = Date.Now.Date
            lbl_Pkg_id.Text = Comman_Declared.show_pkg_id
            If frm_View_Single_Package.cb_tour_dates.SelectedIndex <> -1 Then
                dtp_tour_start_date.Value = frm_View_Single_Package.cb_tour_dates.SelectedItem
            Else

            End If
            getconnection()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("select days_dur from Pkg_Info where pkg_id = " & lbl_Pkg_id.Text & "", con)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Comman_Declared.c_days_dur = dr("days_dur")
            End If

            dtp_tour_end_date.Value = dtp_tour_start_date.Value.AddDays(Comman_Declared.c_days_dur - 1)
            Comman_Declared.c_days_dur = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub tb_Passen_Total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Passen_Total.TextChanged
        btn_Add_Travellers_Info.Enabled = True
    End Sub
End Class