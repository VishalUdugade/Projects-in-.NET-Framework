Imports System.Data.SqlClient

Public Class frm_booking
    Dim dr As SqlDataReader
    Private Sub frm_Package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_booking_date.Value = Today.Date
        dtp_tour_start_date.Value = Today.Date
        dtp_tour_end_date.Value = Today.Date
        tb_cust_id.Focus()
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub
    Function clear()
        clearAllTxtbo(panel_Name)
        clearAllTxtbo(panel_no_of_travellers)
        clearAllTxtbo(panel_Advance_pay)
        tb_pay_mode.Text = ""
        tb_Full_Pay.Text = ""
        lbl_Pkg_Day_Night.Text = ""
        lbl_Pkg_Name.Text = ""
        lbl_Pkg_Route.Text = ""
        pb_Package_Image.Image = Nothing
        dtp_booking_date.Value = Today.Date
        dtp_tour_start_date.Value = Today.Date
        dtp_tour_end_date.Value = Today.Date
        tb_refund_amount.Text = ""
        Return 0
    End Function
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        If tb_cust_id.Text <> "" Then
            clear()
            getconnection()
            cmd = New SqlCommand("select pkg_id from Cust_Info where cust_id=" & tb_cust_id.Text & "", con)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                tb_pkg_id.Text = dr("pkg_id")
            Else
                MsgBox("Record Not Found...", MsgBoxStyle.OkOnly)
                Return
            End If
            dr.Close()
            cmd.Dispose()

            cmd = New SqlCommand("select * from Cust_Info full join pkg_info on pkg_info.pkg_id = Cust_Info.pkg_id  full join  pkg_payment on Cust_Info.cust_id = pkg_payment.cust_id  full join report_payment on pkg_payment.pay_id = report_payment.pay_id where pkg_info.pkg_id = " & tb_pkg_id.Text & "", con)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                tb_pkg_id.Text = dr("pkg_id")
                tb_first_name.Text = dr("first_name")
                tb_Middle_Name.Text = dr("middle_name")
                tb_Last_Name.Text = dr("last_name")
                tb_No_Children.Text = dr("no_children")
                tb_No_Adult.Text = dr("no_adult")
                pb_Package_Image.Image = comon_class.view(dr("pkg_img"))
                lbl_Pkg_Day_Night.Text = dr("days_dur").ToString + " " + "days" + "/" + dr("night_dur").ToString + " " + "nights"
                lbl_Pkg_Name.Text = dr("pkg_name")
                lbl_Pkg_Route.Text = dr("route")
                dtp_booking_date.Value = dr("booking_date")
                dtp_tour_start_date.Value = dr("t_start_date")
                dtp_tour_end_date.Value = dr("t_end_date")

                dr.Close()
                cmd.Dispose()
                cmd = New SqlCommand("select pay_mode from pkg_payment where cust_id = " & tb_cust_id.Text & "", con)
                tb_pay_mode.Text = cmd.ExecuteScalar()
                cmd.Dispose()

            End If
            cmd.Dispose()
            dr.Close()

            If tb_pay_mode.Text = "Advance" Then
                Dim grass_pay As ULong = 0
                cmd = New SqlCommand("select grass_pay from pkg_payment where cust_id = " & tb_cust_id.Text & "", con)
                grass_pay = cmd.ExecuteScalar()
                cmd.Dispose()

                cmd = New SqlCommand("select sum(ent_pay_amount) from report_payment where cust_id = " & tb_cust_id.Text & "", con)
                tb_Previous_Payment.Text = cmd.ExecuteScalar()
                cmd.Dispose()

                tb_remainig_pay_amount.Text = grass_pay - Val(tb_Previous_Payment.Text)

            ElseIf tb_pay_mode.Text = "Full Payment" Then

                cmd = New SqlCommand("select full_pay from report_payment where cust_id = " & tb_cust_id.Text & "", con)
                tb_Full_Pay.Text = cmd.ExecuteScalar()
                cmd.Dispose()
            End If

            Dim cddate As Date
            cddate = dtp_tour_start_date.Value.AddDays(-1)
            If cddate = Today.Date Then
                tb_refund_amount.Text = Val(tb_Previous_Payment.Text) / 2
            End If

        End If
    End Sub

    Private Sub btn_show_Travellers_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_Travellers_Info.Click
        If tb_Passen_Total.Text <> "" And tb_cust_id.Text <> "" Then
            getconnection()
            Dim x As Integer = 22
            Dim y As Integer = 150
            Dim p_sr_no As Integer = 1
            cmd = New SqlCommand("select * from Traveller where cust_id = " & tb_cust_id.Text & "", con)
            dr = cmd.ExecuteReader()
            Comman_Declared.add_traveller_verifying_form = 5
            frm_Add_Travellers_Information.Show()
            frm_Add_Travellers_Information.lbl_Add_Travellers_Info.Text = "Travellers Information"
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
            dr.Close()
            cmd.Dispose()
        Else
            MsgBox("Please Enter Customer Id first", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        clear()
        tb_pkg_id.Text = ""
        tb_cust_id.Text = ""
    End Sub

    Private Sub btb_Show_Iternary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb_Show_Iternary.Click
        If tb_cust_id.Text <> "" And dtp_tour_end_date.Value <> Today.Date And dtp_tour_start_date.Value <> Today.Date Then
            getconnection()
            Comman_Declared.verifying_forms = 5
            frm_Days_Description.Show()
            frm_Days_Description.btn_Edit_days.Hide()
            frm_Days_Description.lbl_Days_Description.Text = "Days Description"
            Dim x As Integer = 50
            Dim y As Integer = 100
            Dim tdate As Date = Nothing
            tdate = dtp_tour_start_date.Value
            cmd = New SqlCommand("select * from pkg_days_descri where pkg_id = " & tb_pkg_id.Text & "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim obj = New pkg_Days_Description
                obj.Location = New System.Drawing.Point(x, y)
                obj.Enabled = False

                If tdate = dtp_tour_start_date.Value Then
                    obj.dtp_Date.Value = tdate
                    tdate = tdate.AddDays(1)
                Else
                    obj.dtp_Date.Value = tdate
                    tdate = tdate.AddDays(1)
                End If
                obj.tb_day_id.Text = dr("day_id")
                obj.lbl_Days_no.Text = dr("tour_day_no").ToString
                obj.tb_Place.Text = dr("day_place").ToString
                obj.tb_L_Name.Text = dr("day_lh_name").ToString
                obj.tb_L_Place.Text = dr("day_lh_place").ToString
                obj.tb_D_Name.Text = dr("day_dh_name").ToString
                obj.tb_D_Place.Text = dr("day_dh_place").ToString
                obj.tb_Days_Descri.Text = dr("day_description").ToString

                frm_Days_Description.Controls.Add(obj)


                x = x + 1357
                y = y + 375
                x = 50

            End While
            cmd.Dispose()
            dr.Close()
            terminateconnection()
            Comman_Declared.increment_date = Nothing

        Else
            MsgBox("Search the record..", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btn_Cancal_book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancal_book.Click
        If MsgBox("Are you sure want to cancel booking ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If tb_refund_amount.Text <> "" Then
                getconnection()
                If tb_pay_mode.Text = "Advance" Then
                    cmd = New SqlCommand("insert into cancel_booking(cust_id,pkg_id,cancaltion_date,first_name,middle_name,last_name,pay_mode,tot_pre_pay,remaining_pay,refund_amount) values(" & tb_cust_id.Text & "," & tb_pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "','" & tb_first_name.Text & "','" & tb_Middle_Name.Text & "','" & tb_Last_Name.Text & "','" & tb_pay_mode.Text & "'," & tb_Previous_Payment.Text & "," & tb_remainig_pay_amount.Text & "," & tb_refund_amount.Text & ")", con)
                    If cmd.ExecuteNonQuery > 0 Then

                        traveller()

                        MsgBox("Booking Canceled Successfully", MsgBoxStyle.OkOnly)

                    Else
                        MsgBox("Booking Not Canceled Successfully", MsgBoxStyle.OkOnly)
                    End If
                ElseIf tb_pay_mode.Text = "Full Payment" Then
                    cmd = New SqlCommand("insert into cancel_booking(cust_id,pkg_id,cancaltion_date,first_name,middle_name,last_name,pay_mode,refund_amount) values(" & tb_cust_id.Text & "," & tb_pkg_id.Text & ",'" & dtp_Cust_today_date.Text & "'," & tb_first_name.Text & "," & tb_Middle_Name.Text & "," & tb_Last_Name.Text & "," & tb_pay_mode.Text & "," & tb_Full_Pay.Text & "," & tb_refund_amount.Text & ")", con)
                    If cmd.ExecuteNonQuery > 0 Then
                        traveller()
                        MsgBox("Booking Canceled Successfully", MsgBoxStyle.OkOnly)
                    Else
                        MsgBox("Booking Not Canceled Successfully", MsgBoxStyle.OkOnly)
                    End If
                End If
            Else
                MsgBox("Please Enter Refundale Amount..", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Function traveller()
        Dim pkg_id As Integer
        Dim cust_id As Integer
        Dim trave_id As Integer
        Dim pass_name As String
        Dim gender As String
        Dim DOB As Date
        Dim age As String
        Dim addhar_no As ULong

        Dim cnt As Integer = 0
        cmd.Dispose()

        cmd = New SqlCommand("select count(trave_id) from Traveller where cust_id = " & tb_cust_id.Text & "", con)
        cnt = cmd.ExecuteScalar()
        cmd.Dispose()

       
        While cnt > 0

            cmd = New SqlCommand("select * from Traveller where cust_id = " & tb_cust_id.Text & "", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                pkg_id = dr("pkg_id")
                cust_id = dr("cust_id")
                trave_id = dr("trave_id")
                pass_name = dr("pass_name")
                gender = dr("gender")
                DOB = dr("DOB")
                age = dr("age")
                addhar_no = dr("addhar_no")
            End If
            dr.Close()
            cmd.Dispose()

            ' cmd = New SqlCommand("insert into cancel_traveller values(" & pkg_id & "," & cust_id & "," & trave_id & ",'" & pass_name & "','" & gender & "','" & DOB & "'," & age & "," & addhar_no & ")", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'cmd = New SqlCommand("delete from Traveller where cust_id = " & tb_cust_id.Text & "", con)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()

            cnt = cnt - 1
        End While


        'cmd = New SqlCommand("delete from Cust_Info where cust_id = " & tb_cust_id.Text & "", con)
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

        dr.Close()
        cmd.Dispose()
        Return 0
    End Function

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
End Class