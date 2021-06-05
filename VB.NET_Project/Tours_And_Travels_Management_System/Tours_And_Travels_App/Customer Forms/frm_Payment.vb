Imports System.Data.SqlClient

Public Class frm_Payment

    Dim pay_mode As String = Nothing
    Dim bill_no As Integer = 0
    Dim rem_pay As ULong = 0

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            If Comman_Declared.pay_verifying_form = 1 Then
                frm_Owner.Show()
                Me.Close()
                Comman_Declared.pay_verifying_form = 0
            ElseIf Comman_Declared.pay_verifying_form = 2 Then
                frm_Add_Customer.Enabled = True
                Me.Hide()
                Comman_Declared.pay_verifying_form = 0
            ElseIf Comman_Declared.pay_verifying_form = 3 Then
                frm_View_single_Customer_Details.Enabled = True
                Me.Hide()
                Comman_Declared.pay_verifying_form = 0
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function queries()
       
        cmd = New SqlCommand("select count(age) from Traveller where  cust_id = " & tb_Cust_id.Text & " And  age <= " & 18 & "", con)
        tb_no_of_children.Text = cmd.ExecuteScalar()
        cmd.Dispose()

        cmd = New SqlCommand("select count(age) from Traveller where  cust_id = " & tb_Cust_id.Text & " And  age > " & 18 & "", con)
        tb_no_of_adult.Text = cmd.ExecuteScalar()
        cmd.Dispose()

        queries2()
        Return 0
    End Function
    Function queries2()
        Dim dr As SqlDataReader

        cmd = New SqlCommand("select pkg_name,adult_pri,children_pri,grand_total from pkg_info where pkg_id = " & tb_pkg_id.Text & "", con)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            tb_pkg_name.Text = dr("pkg_name").ToString
            tb_pkg_adult_price.Text = dr("adult_pri")
            tb_pkg_chlidren_price.Text = dr("children_pri")
            tb_Pkg_Grand_Total.Text = dr("grand_total")
        End If
        cmd.Dispose()
        dr.Close()


        tb_adult_price.Text = tb_pkg_adult_price.Text
        tb_children_price.Text = tb_pkg_chlidren_price.Text

        tb_total_of_children.Text = Val(tb_no_of_children.Text) * Val(tb_children_price.Text)
        tb_total_of_Adult.Text = Val(tb_no_of_adult.Text + 1) * Val(tb_adult_price.Text)

        tb_Total_of_Children_Adult.Text = Val(tb_total_of_children.Text) + Val(tb_total_of_Adult.Text)

        tb_grand_total.Text = tb_Pkg_Grand_Total.Text
        tb_tot_chi_adult.Text = tb_Total_of_Children_Adult.Text

        tb_payble_amount.Text = Val(tb_grand_total.Text) + Val(tb_tot_chi_adult.Text)
        tb_grass_pay_amount.Text = Val(tb_payble_amount.Text)
        Return 0
    End Function
    Function values()
        If rb_Advance.Checked = True Then
            pay_mode = rb_Advance.Text
        ElseIf rb_Full_Pay.Checked = True Then
            pay_mode = rb_Full_Pay.Text
        End If
        Return 0
    End Function
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            clear_field()
            Dim dr As SqlDataReader

            getconnection()
            If tb_Cust_id.Text <> "" Then
                cmd = New SqlCommand("select discount from pkg_payment where cust_id = " & tb_Cust_id.Text & "", con)
                Dim i As Integer = cmd.ExecuteScalar()
                If i > 0 Then
                    cmd.Dispose()
                    tb_Discount.Enabled = False
                    btn_update.Enabled = True

                    bill_no = Auto_Increment("select count(bill_no) from report_payment where cust_id = " & tb_Cust_id.Text & "", 1)

                    cmd = New SqlCommand("select * from Cust_Info where cust_id = " & tb_Cust_id.Text & "", con)
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        tb_pkg_id.Text = dr("pkg_id")
                        tb_cust_name.Text = dr("first_name") + " " + dr("middle_name") + " " + dr("last_name").ToString
                    End If
                    dr.Close()
                    cmd.Dispose()


                    queries()

                    cmd = New SqlCommand("select * from pkg_payment where cust_id = " & tb_Cust_id.Text & "", con)
                    dr = cmd.ExecuteReader()
                    If dr.Read Then
                        tb_pay_id.Text = dr("pay_id")
                        tb_Pkg_Grand_Total.Text = dr("pkg_grand_tot")
                        tb_pkg_chlidren_price.Text = dr("pkg_children_pri")
                        tb_pkg_adult_price.Text = dr("pkg_adult_pri")
                        tb_Discount.Text = dr("discount")
                        pay_mode = dr("pay_mode").ToString
                        ' dtp_pay_date.Value = dr("pay_date")
                        tb_grass_pay_amount.Text = dr("grass_pay")
                    End If
                    dr.Close()
                    cmd.Dispose()

                    If pay_mode = "Advance" Then
                        rb_Advance.Checked = True
                    ElseIf pay_mode = "Full Payment" Then
                        rb_Full_Pay.Checked = True
                    End If

                    If rb_Advance.Checked = True Then
                        cmd = New SqlCommand("select bill_no,pay_date,pay_mode,tot_prev_pay,ent_pay_amount,rem_pay_amount from report_payment where cust_id = " & tb_Cust_id.Text & "", con)
                        Dim da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()

                        da.Fill(dt)

                        dgv_previous_payment.DataSource = dt
                        cmd.Dispose()
                        dt.Dispose()
                        da.Dispose()

                        getconnection()
                        cmd = New SqlCommand("select sum(ent_pay_amount) from report_payment where cust_id = " & tb_Cust_id.Text & "", con)
                        tb_Previous_Payment.Text = cmd.ExecuteScalar()
                        cmd.Dispose()
                        terminateconnection()

                    ElseIf rb_Full_Pay.Checked = True Then
                        getconnection()
                        cmd = New SqlCommand("select full_pay from report_payment where cust_id = " & tb_Cust_id.Text & "", con)
                        tb_Full_Pay.Text = cmd.ExecuteScalar()
                        cmd.Dispose()

                        cmd = New SqlCommand("select bill_no,pay_date,pay_mode,full_pay from report_payment where cust_id = " & tb_Cust_id.Text & "", con)
                        Dim da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()

                        da.Fill(dt)

                        dgv_previous_payment.DataSource = dt
                        cmd.Dispose()
                        dt.Dispose()
                        da.Dispose()
                        terminateconnection()

                    End If


                Else

                    dtp_pay_date.Value = Date.Now.Date
                    bill_no = Auto_Increment("select count(bill_no) from report_payment where cust_id = " & tb_Cust_id.Text & "", 1)
                    tb_pay_id.Text = Auto_Increment("select count(pay_id) from pkg_payment", 501)

                    cmd = New SqlCommand("select pkg_id,first_name,middle_name,last_name,no_children,no_adult from Cust_Info where cust_id = " & tb_Cust_id.Text & "", con)
                    '  Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        tb_pkg_id.Text = dr("pkg_id")
                        tb_cust_name.Text = dr("first_name") + " " + dr("middle_name") + " " + dr("last_name").ToString
                        tb_no_of_adult.Text = dr("no_adult")
                        tb_no_of_children.Text = dr("no_children")

                        cmd.Dispose()
                        dr.Close()
                        btn_Save.Enabled = True
                        tb_Discount.Enabled = True
                        rb_Advance.Enabled = True
                        rb_Full_Pay.Enabled = True
                        btn_update.Enabled = False
                        queries2()
                    Else
                        MsgBox("Record Not Found...", MsgBoxStyle.OkOnly)
                    End If
                End If
            Else
                MsgBox("Please Enter Customer Id first", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb_Advance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Advance.CheckedChanged
        Try
            tb_Full_Pay.Text = ""
            panel_full_pay.Enabled = False
            panel_Advance_pay.Enabled = True
            btn_update.Enabled = True
            tb_Pay_Amount.Enabled = True

            If tb_Discount.Text = "" And tb_Discount.Enabled = True Then
                tb_Discount.Text = 0
                tb_Previous_Payment.Text = 0
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            ElseIf tb_Discount.Text <> "" And tb_Discount.Enabled = True Then
                tb_Previous_Payment.Text = 0
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            End If

            'cmd = New SqlCommand("select discount from pkg_payment where cust_id = " & tb_Cust_id.Text & "", con)
            'Dim i As Integer = cmd.ExecuteScalar()
            'If i >= 0 Then
            '    If Val(tb_Discount.Text) = 0 Then
            '        tb_Previous_Payment.Text = 0
            '        tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            '    End If
            'End If

            'getconnection()
            'cmd = New SqlCommand("select count(ent_pay_amount) from report_payment", con)
            'Dim i As Integer = cmd.ExecuteScalar
            'If i <> 1 Then

            '    tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            '    tb_Previous_Payment.Text = 0
            '    cmd.Dispose()
            'Else
            '    cmd.Dispose()
            '    cmd = New SqlCommand("select sum(ent_pay_amount) from report_payment", con)
            '    tb_Previous_Payment.Text = cmd.ExecuteScalar()
            '    cmd.Dispose()

            '    tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Previous_Payment.Text)
            '    Return
            'End If

            'tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub rb_Full_Pay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Full_Pay.CheckedChanged
        Try
            tb_Previous_Payment.Text = ""
            tb_Pay_Amount.Text = ""
            tb_remainig_pay_amount.Text = ""
            panel_Advance_pay.Enabled = False
            panel_full_pay.Enabled = True
            btn_update.Enabled = False

            If tb_Discount.Enabled = True And tb_Discount.Text <> "" Then
                tb_Full_Pay.Text = tb_grass_pay_amount.Text
            ElseIf tb_Discount.Enabled = False And tb_Discount.Text <> "" Then
                tb_Full_Pay.Text = tb_grass_pay_amount.Text
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Discount.TextChanged
        Try
            If tb_Discount.Text <> "" And tb_Discount.Enabled = True Then
                tb_grass_pay_amount.Text = Val(tb_payble_amount.Text) * ((100 - Val(tb_Discount.Text)) / 100)

            ElseIf tb_Discount.Text = "" And tb_Discount.Enabled = True Then
                tb_grass_pay_amount.Text = Val(tb_payble_amount.Text)
            ElseIf tb_Discount.Enabled = False Then
                tb_grass_pay_amount.Text = Val(tb_payble_amount.Text) * ((100 - Val(tb_Discount.Text)) / 100)
                '     tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Previous_Payment.Text)
            End If
            'Else
            'tb_grass_pay_amount.Text = Val(tb_payble_amount.Text)
            'If rb_Advance.Checked = True Then
            '    tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            'End If
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            getconnection()
            values()
            If rb_Full_Pay.Checked = True Then
                cmd = New SqlCommand("insert into pkg_payment values(" & tb_Cust_id.Text & ",'" & tb_pkg_name.Text & "'," & tb_pay_id.Text & ",'" & dtp_pay_date.Text & "'," & tb_Pkg_Grand_Total.Text & "," & tb_pkg_chlidren_price.Text & "," & tb_adult_price.Text & "," & tb_total_of_children.Text & "," & tb_total_of_Adult.Text & "," & tb_payble_amount.Text & "," & tb_Discount.Text & "," & tb_grass_pay_amount.Text & ",'" & pay_mode & "'," & tb_Full_Pay.Text & ")", con)
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record Saved Successfull....", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record not saved succesfully...", MsgBoxStyle.OkOnly)
                End If

                cmd = New SqlCommand("insert into report_payment(cust_id,pkg_id,pay_id,bill_no,pay_date,tot_pay_amount,pay_mode,full_pay) values(" & tb_Cust_id.Text & "," & tb_pkg_id.Text & "," & tb_pay_id.Text & "," & bill_no & ",'" & dtp_pay_date.Text & "'," & tb_grass_pay_amount.Text & ",'" & pay_mode & "'," & tb_Full_Pay.Text & ")", con)
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record Saved Successfull....", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("Record not saved succesfully...", MsgBoxStyle.OkOnly)
                End If

            ElseIf rb_Advance.Checked = True Then
                If Val(tb_Pay_Amount.Text) >= 5000 Then
                    cmd = New SqlCommand("insert into pkg_payment (cust_id,pkg_name,pay_id,pay_date,pkg_grand_tot,pkg_children_pri,pkg_adult_pri,tot_children,tot_adult,pay_amount,discount,grass_pay,pay_mode)  values(" & tb_Cust_id.Text & ",'" & tb_pkg_name.Text & "'," & tb_pay_id.Text & ",'" & dtp_pay_date.Text & "'," & tb_Pkg_Grand_Total.Text & "," & tb_pkg_chlidren_price.Text & "," & tb_adult_price.Text & "," & tb_total_of_children.Text & "," & tb_total_of_Adult.Text & "," & tb_payble_amount.Text & "," & tb_Discount.Text & "," & tb_grass_pay_amount.Text & ",'" & pay_mode & "')", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Successfull....", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                    Else
                        MsgBox("Record not saved succesfully...", MsgBoxStyle.OkOnly)
                    End If

                    cmd = New SqlCommand("insert into report_payment(cust_id,pkg_id,pay_id,bill_no,pay_date,tot_pay_amount,pay_mode,tot_prev_pay,ent_pay_amount,rem_pay_amount) values(" & tb_Cust_id.Text & "," & tb_Cust_id.Text & "," & tb_pay_id.Text & "," & bill_no & ",'" & dtp_pay_date.Value & "'," & tb_grass_pay_amount.Text & ",'" & pay_mode & "'," & tb_Previous_Payment.Text & "," & tb_Pay_Amount.Text & "," & tb_remainig_pay_amount.Text & ")", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved in report Payment...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                    Else
                        MsgBox("Record not saved successfully...", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Amount of First Installment is Minimum 5000", MsgBoxStyle.OkOnly)
                End If

            End If



            clear_field()
            'cmd = New SqlCommand("insert into report_payment values(" & tb_Cust_id.Text & "," & tb_pkg_id.Text & "," & tb_pay_id.Text & "," & bill_no & ",'" & dtp_pay_date.Value & "'," & tb_payble_amount.Text & ",'" & pay_mode & "'," & tb_Previous_Payment.Text & "," & tb_Pay_Amount.Text & "," & tb_remainig_pay_amount.Text & "," & tb_Full_Pay.Text & ")", con)
            'If cmd.ExecuteNonQuery = 1 Then
            '    MsgBox("Record Saved in report Payment...", MsgBoxStyle.OkOnly)
            '    cmd.Dispose()
            'Else
            '    MsgBox("Record not saved successfully...", MsgBoxStyle.OkOnly)
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Previous_Payment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Previous_Payment.TextChanged
        Try
            tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Previous_Payment.Text)
            rem_pay = Val(tb_remainig_pay_amount.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Pay_Amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Pay_Amount.TextChanged
        Try
            If rb_Advance.Checked = True And tb_Discount.Enabled = True Then
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Pay_Amount.Text)
            ElseIf tb_Discount.Enabled = False And rb_Advance.Checked = True And tb_Pay_Amount.Text <> "" Then
                tb_remainig_pay_amount.Text = rem_pay - Val(tb_Pay_Amount.Text)
            ElseIf tb_Pay_Amount.Text = "" Then
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Previous_Payment.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_grass_pay_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_grass_pay_amount.TextChanged
        Try
            If tb_Discount.Enabled = True And rb_Advance.Checked = True Then
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text)
            ElseIf tb_Discount.Enabled = True And rb_Full_Pay.Checked = True Then
                tb_Full_Pay.Text = Val(tb_grass_pay_amount.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_remainig_pay_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_remainig_pay_amount.TextChanged
        Try
            If rb_Advance.Checked = True And tb_Discount.Enabled = True And tb_Pay_Amount.Text <> "" Then
                tb_remainig_pay_amount.Text = Val(tb_grass_pay_amount.Text) - Val(tb_Pay_Amount.Text)

            ElseIf Val(tb_remainig_pay_amount.Text) = 0 Then
                If (Val(tb_Previous_Payment.Text) = Val(tb_grass_pay_amount.Text)) Then
                    tb_Pay_Amount.Text = ""
                    tb_Pay_Amount.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tb_pay_id.Text = Auto_Increment("select count(pay_id) from pkg_payment", 501)
            tb_Cust_id.Focus()
            dtp_pay_date.Value = Today.Date
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Discount_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Discount.Leave
        Try
            If tb_Discount.Text = "" Then
                tb_Discount.Text = 0
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function clear_field()
        'clearAllTxtbo(gb_Customer_pkg_Info)
        tb_cust_name.Text = ""
        tb_pkg_id.Text = ""
        tb_pkg_name.Text = ""
        tb_Pkg_Grand_Total.Text = ""
        tb_Pkg_Grand_Total.Text = ""
        tb_pkg_adult_price.Text = ""
        tb_pkg_chlidren_price.Text = ""
        tb_pay_id.Text = ""

        dgv_previous_payment.DataSource = Nothing
        clearAllTxtbo(gb_Payment_Details)
        clearAllRadiobutton(gb_Payment_Details)
        clearAllTxtbo(panel_Advance_pay)
        clearAllTxtbo(panel_full_pay)

        tb_Discount.Enabled = False
        tb_Pay_Amount.Enabled = False
        btn_Save.Enabled = False
        btn_update.Enabled = False
        rb_Advance.Enabled = False
        rb_Full_Pay.Enabled = False
        Return 0
    End Function
    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click

        'If tb_Discount.Enabled = False Then
        '    'dgv_previous_payment.Data()
        'End If
        clear_field()


        'cmd = New SqlCommand("Truncate table pkg_payment", con)
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

        'cmd = New SqlCommand("Truncate table report_payment", con)
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()



    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try

            If tb_Pay_Amount.Text <> "" And (rb_Advance.Checked = True Or rb_Full_Pay.Checked = True) Then
                getconnection()
                values()

                If rb_Advance.Checked = True Then
                    cmd = New SqlCommand("insert into report_payment(cust_id,pkg_id,pay_id,bill_no,pay_date,tot_pay_amount,pay_mode,tot_prev_pay,ent_pay_amount,rem_pay_amount) values(" & tb_Cust_id.Text & "," & tb_Cust_id.Text & "," & tb_pay_id.Text & "," & bill_no & ",'" & dtp_pay_date.Text & "'," & tb_grass_pay_amount.Text & ",'" & pay_mode & "'," & tb_Previous_Payment.Text & "," & tb_Pay_Amount.Text & "," & tb_remainig_pay_amount.Text & ")", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Succesfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                    Else
                        MsgBox("Record not saved successfully...", MsgBoxStyle.OkOnly)
                    End If
                ElseIf rb_Full_Pay.Checked = True Then
                    cmd = New SqlCommand("insert into report_payment(cust_id,pkg_id,pay_id,bill_no,pay_date,tot_pay_amount,pay_mode,full_pay) values(" & tb_Cust_id.Text & "," & tb_Cust_id.Text & "," & tb_pay_id.Text & "," & bill_no & ",'" & dtp_pay_date.Text & "'," & tb_grass_pay_amount.Text & ",'" & pay_mode & "'," & tb_Full_Pay.Text & ")", con)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Record Saved Succesfully...", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                    Else
                        MsgBox("Record not saved successfully...", MsgBoxStyle.OkOnly)
                    End If
                End If

                clear_field()
            Else
                MsgBox("Please Enter pay Amount First", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bill.Click
        Try
            If tb_Cust_id.Text <> "" And tb_cust_name.Text <> "" And (rb_Advance.Checked <> False Or rb_Full_Pay.Checked <> False) Then
                Report_Frm_bill.Show()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class