Imports System.Data.SqlClient

Public Class frm_View_single_Customer_Details

    Dim gender As String = Nothing
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
                    tb_state.Text = dr("state")
                    gender = dr("gender")
                    tb_Addhar_No.Text = dr("addhar_no")
                    tb_Pan_No.Text = dr("pan_no")
                    'tb_No_Children.Text = dr("no_children")
                    'tb_No_Adult.Text = dr("no_adult")
                    dtp_tour_start_date.Value = dr("t_start_date")
                    dtp_tour_end_date.Value = dr("t_end_date")

                Else
                    MsgBox("Record Not found...", MsgBoxStyle.OkOnly)
                End If
                cmd.Dispose()
                dr.Close()


                cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age <= " & 18 & "", con)
                tb_No_Children.Text = cmd.ExecuteScalar
                cmd.Dispose()

                cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & " And age > " & 18 & "", con)
                tb_No_Adult.Text = cmd.ExecuteScalar
                cmd.Dispose()

                tb_Passen_Total.Text = Val(tb_No_Adult.Text) + Val(tb_No_Children.Text)

                If gender = "Male" Then
                    rb_Male.Checked = True
                ElseIf gender = "female" Then
                    rb_Female.Checked = True
                End If

                terminateconnection()
                btn_show_Travellers_Info.Enabled = True
            Else
                MsgBox("Please Enter Customer ID First", MsgBoxStyle.OkOnly)
            End If
            btn_Payment.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_show_Travellers_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_Travellers_Info.Click
        Try
            getconnection()
            Dim x As Integer = 22
            Dim y As Integer = 150
            Dim p_sr_no As Integer = 1
            cmd = New SqlCommand("select * from Traveller where cust_id = " & tb_cust_id.Text & "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()

            Comman_Declared.add_traveller_verifying_form = 4
            frm_Add_Travellers_Information.Show()
            frm_Add_Travellers_Information.btn_Edit_Travellers_No.Hide()
            frm_Add_Travellers_Information.btn_Back.Enabled = True

            While dr.Read()
                Dim obj = New UC_Add_Travellers
                obj.Location = New System.Drawing.Point(x, y)

                obj.lbl_Sr_no.Enabled = False
                obj.tb_Passenger_Name.Enabled = False
                obj.dtp_DOB.Enabled = False
                obj.tb_Addhar_No.Enabled = False
                obj.btn_Next.Hide()
                obj.lbl_traveller_id.Hide()

                obj.cb_Passe_Gender.Items.Clear()

                obj.lbl_traveller_id.Text = dr("trave_id")
                obj.tb_Passenger_Name.Text = dr("pass_name")
                obj.cb_Passe_Gender.Items.Add(dr("gender"))
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Payment.Click
        Try
            If tb_cust_id.Text <> "" Then
                Comman_Declared.pay_verifying_form = 3
                frm_Payment.Show()
                Me.Enabled = False
            Else
                MsgBox("Please enter Customer Id First..", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function clear()

        frm_Add_Travellers_Information.Close()
        tb_pkg_id.Text = ""
        tb_cust_id.Text = ""
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
        btn_show_Travellers_Info.Enabled = False
        Return 0
    End Function
    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_Payment.Close()
        Me.Hide()
        frm_Owner.Show()
    End Sub
End Class