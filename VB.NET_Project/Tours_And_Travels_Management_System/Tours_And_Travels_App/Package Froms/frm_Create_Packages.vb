Imports System.Data.SqlClient
Imports System.IO

Public Class frm_Create_Packages

    Dim tg_arr(20) As Integer
    Dim d_arr(20) As Integer
    Dim objimg As New OpenFileDialog
   
    Private Sub frm_Create_Packages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtp_Expiry_Date.Value = Today.Date
            dtp_Pkg_Create_Date.Value = Today.Date

            tb_Package_ID.Text = Auto_Increment("Select count(pkg_id) from pkg_info", 1001)
            Comman_Declared.temp_table_pkg_id = Val(tb_Package_ID.Text)
            tb_pkg_name.Focus()
            dtp_Pkg_Create_Date.Value = Date.Now.Date
            ' dtp_Expiry_Date.Value = Date.Now.Date

            getconnection()

            cmd = New SqlCommand("select emp_id,first_name,middle_name,last_name from Emp_Info where emp_post = '" + lbl_Driver_Name.Text + "' And avability = '" & True & "'", con)
            Dim dr As SqlDataReader
            Dim mr As SqlDataReader
            Dim cnt As Integer = 0

            dr = cmd.ExecuteReader()

            cb_Driver_Name.Items.Clear()


            While dr.Read
                d_arr(cnt) = dr("emp_id")
                cb_Driver_Name.Items.Add(dr("first_name") + " " + dr("middle_name") + " " + dr("last_name").ToString)
                cnt = cnt + 1
            End While
            cnt = 0
            dr.Close()

            cmd = New SqlCommand("select emp_id,first_name,middle_name,last_name from Emp_Info where emp_post = '" + lbl_Select_Tour_Guide.Text + "' And avability = '" & True & "'", con)
            mr = cmd.ExecuteReader()
            While mr.Read
                tg_arr(cnt) = mr("emp_id")
                cb_Tour_Guide.Items.Add(mr("first_name") + " " + mr("middle_name") + " " + mr("last_name").ToString)
                cnt = cnt + 1
            End While
            mr.Close()
            cb_Driver_Name.DisplayMember = "Select Driver"
            cnt = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Import.Click
        Try
            comon_class.brows(pb_pkg_img.Image)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_Cancal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancal.Click
        pb_pkg_img.Image = Nothing
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If tb_Package_ID.Text <> "" And tb_Persons_Capacity.Text <> "" And tb_pkg_name.Text <> "" And tb_route.Text <> "" And tb_Adult_Price.Text <> "" And tb_Children_Price.Text <> "" And tb_Days.Text <> "" And tb_Total_Price.Text <> "" And tb_GST.Text <> "" And tb_Note.Text <> "" And tb_Number_of_tours.Text <> "" And tb_Note.Text <> "" Then

                Comman_Declared.c_day_no = Val(tb_Days.Text)
                Dim c_place As String = Nothing
                Dim ms As New MemoryStream
                Dim tour As String = cb_Tour_Guide.Text
                Dim cn As Integer = 0
                Dim tg_emp_id As Integer = 0
                Dim d_emp_id As Integer = 0
                Dim tgs_index As Integer = cb_Tour_Guide.SelectedIndex
                Dim ds_index As Integer = cb_Driver_Name.SelectedIndex

                Do While cn < 20
                    If cn = tgs_index Then
                        tg_emp_id = tg_arr(cn)
                        Exit Do
                    End If
                    cn = cn + 1
                Loop

                cn = 0

                Do While cn < 20
                    If cn = ds_index Then
                        d_emp_id = d_arr(cn)
                        Exit Do
                    End If
                    cn = cn + 1
                Loop



                cmd = New SqlCommand("insert into pkg_info values(" & tb_Package_ID.Text & ",'" & tb_pkg_name.Text & "','" & tb_route.Text & "'," & tb_Adult_Price.Text & "," & tb_Children_Price.Text & "," & tb_Days.Text & "," & tb_Nights.Text & ",'" & tb_Note.Text & "'," & tb_Total_Price.Text & "," & tb_GST.Text & "," & tb_Grand_Total.Text & "," & tb_Number_of_tours.Text & ",'" & dtp_Pkg_Create_Date.Text & "','" & dtp_Expiry_Date.Text & "'," & tb_Persons_Capacity.Text + "," & tg_emp_id & ",'" & cb_Tour_Guide.Text & "'," & d_emp_id & ",'" & cb_Driver_Name.Text & "',@pb_pkg_img)", con)
                pb_pkg_img.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                cmd.Parameters.Add("@pb_pkg_img", SqlDbType.Image).Value = ms.ToArray()

                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record of Package are  successfully saved")
                    cmd.Dispose()
                Else
                    MessageBox.Show("Record of Package not saved")
                End If

                cmd = New SqlCommand("Update Emp_Info set avability = " & 0 & " where emp_id = " & tg_emp_id & "", con)
                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("tg Emp_Id is Updated", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("tg Emp_Id is not updated", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                End If
                cmd.Dispose()

                cmd = New SqlCommand("Update Emp_Info set avability = " & 0 & " where emp_id = " & d_emp_id & "", con)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("d Emp_Id is Updated", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                Else
                    MsgBox("d Emp_Id is not updated", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                End If
                '===============================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

                Dim temp As Integer
                cmd.Dispose()
                cmd = New SqlCommand("select count(pkg_id) from temporary_day_descri where pkg_id = " & tb_Package_ID.Text & "", con)
                temp = cmd.ExecuteScalar()
                cmd.Dispose()
                While temp > 0
                    cmd.CommandText = "select * from temporary_day_descri"
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        Comman_Declared.c_pkg_id = dr("pkg_id").ToString
                        Comman_Declared.cs_day_id = dr("day_id").ToString
                        Comman_Declared.c_day_no = dr("tour_day_no").ToString
                        c_place = dr("day_place").ToString
                        Comman_Declared.l_hotel_name = dr("day_lh_name").ToString
                        Comman_Declared.l_hotel_place = dr("day_lh_place").ToString
                        Comman_Declared.d_hotel_name = dr("day_dh_name").ToString
                        Comman_Declared.d_hotel_place = dr("day_dh_place").ToString
                        Comman_Declared.c_description = dr("day_description").ToString
                        Comman_Declared.c_day_id = dr("day_id").ToString

                    End If
                    dr.Close()
                    cmd.Dispose()
                    cmd = New SqlCommand("insert into pkg_days_descri Values(" & Comman_Declared.c_pkg_id & "," & Comman_Declared.cs_day_id & ",'" & Comman_Declared.c_day_no & "','" & c_place & "','" & Comman_Declared.l_hotel_name & "','" & Comman_Declared.l_hotel_place & "','" & Comman_Declared.d_hotel_name & "','" & Comman_Declared.d_hotel_place & "','" & Comman_Declared.c_description & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd = New SqlCommand("delete from temporary_day_descri where day_id=" & Comman_Declared.c_day_id & "", con)
                    If temp = temp - (temp - 1) Then

                        If cmd.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("Record Of Days Description are successfully saved")
                            ' tb_Package_ID.Text = Auto_Increment("Select count(pkg_id) from pkg_info", 1001)
                        Else
                            MessageBox.Show("Record of Days Description are not saved")
                        End If
                    Else
                        cmd.ExecuteNonQuery()
                    End If
                    cmd.Dispose()
                    temp = temp - 1
                End While

                '==============================================================================================================================================================================================================================================================================================================================================================================================================

                Dim tempdate As Integer
                cmd.Dispose()
                cmd = New SqlCommand("select count(pkg_id) from temporary_tours_date where pkg_id = " & tb_Package_ID.Text & "", con)
                tempdate = cmd.ExecuteScalar()
                While tempdate > 0
                    cmd.CommandText = "select * from temporary_tours_date"
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        Comman_Declared.c_pkg_id = dr("pkg_id")
                        Comman_Declared.c_tour_dt_id = dr("date_id")
                        Comman_Declared.c_start_date = dr("tour_start_date").ToString
                        Comman_Declared.c_end_date = dr("tour_end_date").ToString

                    End If
                    dr.Close()
                    cmd.Dispose()
                    cmd = New SqlCommand("insert into pkg_tours_date values(" & Comman_Declared.c_pkg_id & "," & Comman_Declared.c_tour_dt_id & ",'" & Comman_Declared.c_start_date & "','" & Comman_Declared.c_end_date & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd = New SqlCommand("delete from temporary_tours_date where date_id = " & Comman_Declared.c_tour_dt_id & "", con)
                    If tempdate = tempdate - (tempdate - 1) Then
                        If cmd.ExecuteNonQuery = 1 Then
                            MsgBox("Record Deleted from temporary_tours_date and added into Pkg_tours_date ", MsgBoxStyle.OkOnly)
                            tb_Package_ID.Text = Auto_Increment("select count(pkg_id) from pkg_info", 1001)
                            cmd.Dispose()
                            clear_control()
                        Else
                            MsgBox("Record NOt Deleted from temporary_tours_date and Do Not added into Pkg_tours_date ", MsgBoxStyle.OkOnly)
                        End If
                    Else
                        cmd.ExecuteNonQuery()
                    End If
                    cmd.Dispose()
                    tempdate = tempdate - 1
                End While
                '==========================================================================================================================================================================================
                terminateconnection()
            Else
                MsgBox("Please Fill All Fields and Save /OR Clear All Fields", MsgBoxStyle.Question, MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub lbl_Nights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Nights.Click
        Me.Hide()
        frm_View_Single_Package.Show()
    End Sub




    Private Sub btn_Add_Days_Description_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Days_Description.Click
        Try
            If MsgBox("Please Sure That You Enterd Days Number is Correct", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                Comman_Declared.co_days = tb_Days.Text
                frm_Days_Description.Show()
                getconnection()
                Dim x As Integer = 50
                Dim y As Integer = 100
                Dim d_cnt As Integer = Comman_Declared.co_days
                Dim dno As Integer = 1
                Comman_Declared.c_day_id = Auto_Increment("select count(day_id) from pkg_days_descri", 100)

                While d_cnt > 0
                    Dim obj = New pkg_Days_Description
                    obj.Location = New System.Drawing.Point(x, y)
                    frm_Days_Description.Controls.Add(obj)

                    obj.lbl_Days_no.Text = "Day" + dno.ToString
                    obj.tb_day_id.Text = Comman_Declared.c_day_id
                    x = x + 1357
                    y = y + 375
                    x = 50
                    Comman_Declared.c_day_id = Comman_Declared.c_day_id + 1
                    dno = dno + 1
                    d_cnt = d_cnt - 1
                End While
                Comman_Declared.verifying_forms = 1
                tb_Total_Price.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Add_Tours_Dates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Tours_Dates.Click
        Try
            If MsgBox("Please sure You enterd Number for Tour Dates is Correct", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                If dtp_Pkg_Create_Date.Value > Date.Now.Date Then
                    If dtp_Expiry_Date.Value > dtp_Pkg_Create_Date.Value Then
                        Comman_Declared.verifying_forms = 1
                        Comman_Declared.pkg_tour_dates = tb_Number_of_tours.Text
                        frm_Package_Tour_Dates.Show()
                        btn_Import.Enabled = True
                    Else
                        MsgBox("Please select correct package end date ", MsgBoxStyle.OkOnly)
                    End If
                Else
                    MsgBox("Please select correct package create date ", MsgBoxStyle.OkOnly)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            frm_booking.Show()
            Me.Hide()
            If tb_Package_ID.Text <> "" And cb_Tour_Guide.Text <> "" And cb_Driver_Name.Text <> "" And tb_pkg_name.Text <> "" And tb_route.Text <> "" And tb_Adult_Price.Text <> "" And tb_Children_Price.Text <> "" And tb_Days.Text <> "" And tb_Nights.Text <> "" And tb_Note.Text <> "" And tb_Number_of_tours.Text <> "" And gb_package_detail.Text <> "" And tb_GST.Text <> "" And tb_Grand_Total.Text <> "" And tb_Persons_Capacity.Text <> "" And dtp_Pkg_Create_Date.Value <> Today.Date And dtp_Expiry_Date.Value <> Today.Date And pb_pkg_img.Image Is Nothing Then
                MsgBox("Please Fill All Fields and Save OR Clear All Data", MsgBoxStyle.OkCancel)

            Else
                frm_Owner.Show()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function clear_control()
        tb_Persons_Capacity.Text = ""
        tb_pkg_name.Text = ""
        lbl_Days.Text = ""
        dtp_Pkg_Create_Date.Value = Today.Date
        dtp_Expiry_Date.Value = Today.Date
        pb_pkg_img.Image = Nothing
        cb_Tour_Guide.SelectedIndex = -1
        cb_Driver_Name.SelectedIndex = -1
        clearAllCombo(panel_Tour_Guide)
        clearAllCombo(panel_driver_name)
        clearAllTxtbo(gb_package_detail)
        clearAllTxtbo(panel_price)
        clearAllTxtbo(panel_duration)
        clearAllTxtbo(panel_Note)
        clearAllTxtbo(panel_no_of_tours)
        clearAllTxtbo(Panel_Total_Price)
        clearAllTxtbo(panel_GST)
        clearAllTxtbo(panel_Grand_Total)
        Return 0
    End Function

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Try
            clear_control()

            '===========================================================================================================================
            getconnection()
            cmd = New SqlCommand("Truncate table temporary_day_descri", con)
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("temporary_day_descri table is Truncated Successfully", MsgBoxStyle.OkOnly)
            Else
                MsgBox("temporary_day_descri NOT Truncated Successfully", MsgBoxStyle.OkOnly)
            End If
            cmd.Dispose()

            '===========================================================================================================================

            cmd = New SqlCommand("Truncate table temporary_tours_date", con)
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("temporary_tours_date table is Truncated Successfully", MsgBoxStyle.OkOnly)
            Else
                MsgBox("temporary_tours_date table NOT is Truncated Successfully", MsgBoxStyle.OkOnly)
            End If
            cmd.Dispose()

            '===========================================================================================================================

            terminateconnection()
        Catch ex As Exception
        End Try
    End Sub
    '#Region "TextChanged Event"

    '    Private Sub tb_pkg_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        tb_route.Enabled = True
    '    End Sub

    '    Private Sub tb_route_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        tb_Adult_Price.Enabled = True
    '    End Sub

    '    Private Sub tb_Adult_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Adult_Price.TextChanged
    '        tb_Children_Price.Enabled = True
    '    End Sub

    '    Private Sub tb_Children_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Children_Price.TextChanged
    '        tb_Days.Enabled = True
    '    End Sub
    '    Private Sub tb_Number_of_tours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Number_of_tours.TextChanged
    '        btn_Add_Tours_Dates.Enabled = True
    '    End Sub

    Private Sub tb_Days_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Days.TextChanged
        Try
            btn_Add_Days_Description.Enabled = True
            If tb_Days.Text <> "" Then
                tb_Nights.Text = tb_Days.Text - 1
            Else
                btn_Add_Days_Description.Enabled = False
                tb_Nights.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Total_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Total_Price.TextChanged
        Try
            tb_GST.Enabled = True
            If tb_GST.Text <> "" And tb_Total_Price.Text <> "" Then
                Dim GST_Amount As Integer = ((Val(tb_Total_Price.Text) * Val(tb_GST.Text)) / 100)
                Dim Grand_Tot As Integer = Val(tb_Total_Price.Text) + GST_Amount
                tb_Grand_Total.Text = Grand_Tot
                dtp_Pkg_Create_Date.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tb_GST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_GST.TextChanged
        Try
            If tb_GST.Text <> "" And tb_Total_Price.Text <> "" Then
                Dim GST_Amount As Integer = ((Val(tb_Total_Price.Text) * Val(tb_GST.Text)) / 100)
                Dim Grand_Tot As Integer = Val(tb_Total_Price.Text) + GST_Amount
                tb_Grand_Total.Text = Grand_Tot
                dtp_Pkg_Create_Date.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    '    Private Sub tb_Note_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Note.TextChanged
    '        cb_Tour_Guide.Enabled = True
    '        cb_Driver_Name.Enabled = True
    '    End Sub
    '#End Region

    '#Region "Leave Event"
    '    Private Sub btn_Import_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Import.Leave
    '        If pb_pkg_img.Image Is Nothing Then
    '            tb_Note.Text = ""
    '            tb_Note.Enabled = False
    '        End If
    '    End Sub


    '    Private Sub tb_pkg_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pkg_name.Leave
    '        If tb_pkg_name.Text = "" Then
    '            tb_route.Text = ""
    '            tb_route.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_route_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If tb_route.Text = "" Then
    '            tb_Adult_Price.Text = ""
    '            tb_Adult_Price.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_Adult_Price_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Adult_Price.Leave
    '        If tb_Adult_Price.Text = "" Then
    '            tb_Children_Price.Text = ""
    '            tb_Children_Price.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_Children_Price_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Children_Price.Leave
    '        If tb_Children_Price.Text = "" Then
    '            tb_Days.Text = ""
    '            tb_Days.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_Total_Price_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Total_Price.Leave
    '        If tb_Total_Price.Text = "" Then
    '            tb_GST.Text = ""
    '            tb_GST.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_Number_of_tours_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Number_of_tours.Leave
    '        If tb_Number_of_tours.Text = "" Then
    '            btn_Add_Tours_Dates.Enabled = False
    '        End If
    '    End Sub


    '    Private Sub tb_GST_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_GST.Leave
    '        If tb_GST.Text = "" Then
    '            dtp_Pkg_Create_Date.Value = Today.Date
    '            dtp_Pkg_Create_Date.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub tb_Note_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Note.Leave
    '        If tb_Note.Text = "" Then
    '            cb_Tour_Guide.SelectedText = ""
    '            cb_Driver_Name.SelectedText = ""
    '        End If
    '    End Sub
    '    Private Sub tb_Days_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Days.Leave
    '        If tb_Days.Text = "" Then
    '            btn_Add_Days_Description.Enabled = False
    '            tb_Nights.Text = ""
    '            tb_Total_Price.Text = ""
    '            tb_Total_Price.Enabled = True

    '        End If
    '    End Sub
    '#End Region

#Region "KeyPress Event"
    Private Sub Isnumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Adult_Price.KeyPress, tb_Children_Price.KeyPress, tb_Days.KeyPress, tb_Total_Price.KeyPress, tb_Number_of_tours.KeyPress, MyBase.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Ischar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_pkg_name.KeyPress, tb_Note.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And e.KeyChar <> Chr(46) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If
    End Sub

    Private Sub route(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_route.KeyPress

        If ((e.KeyChar < Chr(65) Or e.KeyChar > Chr(90)) And e.KeyChar <> Chr(45) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122))) Then

            e.Handled = True

        End If

    End Sub

    Private Sub GST(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, tb_GST.KeyPress

        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And (e.KeyChar <> Chr(46)) And (e.KeyChar <> Chr(8))) Then

            e.Handled = True

        End If

    End Sub
#End Region



    Private Sub dtp_Pkg_Create_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Pkg_Create_Date.ValueChanged
        If dtp_Pkg_Create_Date.Value >= Date.Now.Date Then
            dtp_Expiry_Date.Enabled = True
        End If

    End Sub

    Private Sub dtp_Expiry_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Expiry_Date.ValueChanged
        If dtp_Expiry_Date.Value > dtp_Pkg_Create_Date.Value Then
            tb_Number_of_tours.Enabled = True
        End If
    End Sub

    Private Sub cb_Tour_Guide_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Tour_Guide.SelectedIndexChanged
        tb_Persons_Capacity.Enabled = True
    End Sub

    Private Sub cb_Driver_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Driver_Name.SelectedIndexChanged
        tb_Persons_Capacity.Enabled = True
    End Sub

    Private Sub tb_pkg_name_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pkg_name.TextChanged
        tb_route.Enabled = True
    End Sub

    Private Sub tb_Number_of_tours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Number_of_tours.TextChanged
        If tb_Number_of_tours.Text <> "" Then
            btn_Add_Tours_Dates.Enabled = True
        Else
            btn_Add_Tours_Dates.Enabled = False
            tb_Number_of_tours.Text = ""
        End If
    End Sub

 
End Class