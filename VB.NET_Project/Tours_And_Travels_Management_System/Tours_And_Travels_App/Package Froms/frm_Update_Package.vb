Imports System.Data.SqlClient
Imports System.IO

Public Class frm_Update_Package
    Dim tg_arr(20) As Integer
    Dim d_arr(20) As Integer
    Private Sub frm_Update_Package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cb_pkg_name.Focus()
            getconnection()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select pkg_name from pkg_info ", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cb_pkg_name.Items.Add(dr("pkg_name"))
            End While
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_Package_ID.Text = "" And cb_pkg_name.SelectedIndex = -1 Then
                MsgBox("Please Select Package Name", MsgBoxStyle.OkOnly)
            Else
                getconnection()
                btn_Show_Days_Description.Enabled = True
                btn_Show_Tours_Dates.Enabled = True
                btn_Import.Enabled = True
                btn_Clear.Enabled = True
                btn_Update.Enabled = True
                btn_Add_days.Enabled = True

                cb_Tour_Guide.Items.Clear()
                cb_Driver_Name.Items.Clear()
                'If tb_Package_ID.Text = "" And cb_pkg_name.SelectedIndex = -1 Then
                '    MsgBox("Please Enter Package ID or Package Name", MsgBoxStyle.OkOnly)
                'Else
                Dim dr As SqlDataReader
                '    If (tb_Package_ID.Text <> "" And cb_pkg_name.SelectedIndex = -1) Or (tb_Package_ID.Text <> "" And cb_pkg_name.SelectedIndex <> -1) Then
                '        getconnection()

                '        cmd = New SqlCommand("select * from pkg_info where pkg_id = " & tb_Package_ID.Text & "", con)
                '        dr = cmd.ExecuteReader()

                '        If dr.Read() Then
                '            tb_pkg_name.Text = dr("pkg_name").ToString
                '            tb_route.Text = dr("route").ToString
                '            tb_Adult_Price.Text = dr("adult_pri")
                '            tb_Children_Price.Text = dr("children_pri")
                '            tb_Days.Text = dr("days_dur")
                '            tb_Nights.Text = dr("night_dur")
                '            tb_Note.Text = dr("note").ToString
                '            tb_Total_Price.Text = dr("total_pri")
                '            tb_GST.Text = dr("GST")
                '            tb_Grand_Total.Text = dr("grand_total")
                '            tb_Number_of_tours.Text = dr("tot_pkg_tours")
                '            dtp_Pkg_Create_Date.Value = dr("create_date").ToString
                '            dtp_Expiry_Date.Value = dr("expiry_date").ToString
                '            tb_Persons_Capacity.Text = dr("per_capacity")
                '            tb_tour_guide_name.Text = dr("tour_guide_nm").ToString()
                '            tb_Driver.Text = dr("driver_name").ToString()
                '            pb_pkg_img.Image = comon_class.view(dr("pkg_img"))
                '        Else
                '            MsgBox("Record Not Found", MsgBoxStyle.OkOnly)
                '        End If
                '        dr.Close()
                '        cmd.Dispose()
                '    End If

                If cb_pkg_name.SelectedIndex <> -1 Then
                    cmd = New SqlCommand("select * from pkg_info where pkg_name = '" & cb_pkg_name.Text & "'", con)
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then
                        tb_Package_ID.Text = dr("pkg_id").ToString
                        tb_pkg_name.Text = dr("pkg_name").ToString
                        tb_route.Text = dr("route").ToString
                        tb_Adult_Price.Text = dr("adult_pri")
                        tb_Children_Price.Text = dr("children_pri")
                        'tb_Days.Text = dr("days_dur")
                        'tb_Nights.Text = dr("night_dur")
                        tb_Note.Text = dr("note").ToString
                        tb_Total_Price.Text = dr("total_pri")
                        tb_GST.Text = dr("GST")
                        tb_Grand_Total.Text = dr("grand_total")
                        tb_Number_of_tours.Text = dr("tot_pkg_tours")
                        dtp_Pkg_Create_Date.Value = dr("create_date").ToString
                        dtp_Expiry_Date.Value = dr("expiry_date").ToString
                        tb_Persons_Capacity.Text = dr("per_capacity")
                        tb_tg_id.Text = dr("t_emp_id")
                        tb_tour_guide_name.Text = dr("tour_guide_nm").ToString()
                        tb_d_id.Text = dr("d_emp_id")
                        tb_Driver.Text = dr("driver_name").ToString()
                        pb_pkg_img.Image = comon_class.view(dr("pkg_img"))

                        dr.Close()
                        cmd.Dispose()
                        cmd = New SqlCommand("select count(day_id) from pkg_days_descri where pkg_id = " & tb_Package_ID.Text & "", con)
                        tb_Days.Text = cmd.ExecuteScalar
                        cmd.Dispose()

                        tb_Nights.Text = Val(tb_Days.Text) - 1
                    Else
                        MsgBox("Record Not Found", MsgBoxStyle.OkOnly)
                    End If
                    dr.Close()
                    cmd.Dispose()
                End If


                Dim cnt As Integer = 0
                Dim tour_guide As String = "Tour Guide"
                cmd = New SqlCommand("select first_name,middle_name,last_name,emp_id from Emp_Info where emp_post = '" & tour_guide & "' And avability = " & 1 & "", con)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    cb_Tour_Guide.Items.Add(dr("first_name") + " " + dr("middle_name") + " " + dr("last_name").ToString)
                    tg_arr(cnt) = dr("emp_id")
                    cnt = cnt + 1
                End While
                dr.Close()
                cmd.Dispose()


                Dim dcnt As Integer = 0
                Dim Driver As String = "Driver"
                cmd = New SqlCommand("select first_name,middle_name,last_name,emp_id from Emp_Info where emp_post = '" & Driver & "' And avability = " & 1 & "", con)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    cb_Driver_Name.Items.Add(dr("first_name") + " " + dr("middle_name") + " " + dr("last_name").ToString)
                    d_arr(dcnt) = dr("emp_id")
                    dcnt = dcnt + 1
                End While
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            If tb_Package_ID.Text <> "" Or cb_Tour_Guide.Text <> "" Or cb_Driver_Name.Text <> "" Or tb_pkg_name.Text <> "" Or tb_route.Text <> "" Or tb_Adult_Price.Text <> "" Or tb_Children_Price.Text <> "" Or tb_Days.Text <> "" Or tb_Nights.Text <> "" Or tb_Note.Text <> "" Or tb_Number_of_tours.Text <> "" Or tb_Total_Price.Text <> "" Or tb_GST.Text <> "" Or tb_Grand_Total.Text <> "" Or tb_Persons_Capacity.Text <> "" Then
                MsgBox("Please Update Data Or  Clear All Data And go back ", MsgBoxStyle.OkCancel)

            Else
                frm_Owner.Show()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function Clear_Controls()
        tb_Package_ID.Text = ""
        tb_selected_td_id.Text = ""
        tb_selected_tg_id.Text = ""
        tb_pkg_name.Text = ""
        lbl_Days.Text = ""
        tb_Persons_Capacity.Text = ""
        tb_Number_of_tours.Text = ""
        pb_pkg_img.Image = Nothing
        cb_pkg_name.SelectedIndex = -1
        dtp_Pkg_Create_Date.Value = Date.Now.Date
        dtp_Expiry_Date.Value = Date.Now.Date
        clearAllCombo(panel_Tour_Guide)
        clearAllCombo(panel_driver_name)
        clearAllTxtbo(gb_Package_Information)
        clearAllTxtbo(gb_Pkg_Persons)
        clearAllTxtbo(panel_Note)
        clearAllTxtbo(panel_duration)
        btn_Show_Days_Description.Enabled = False
        btn_Show_Tours_Dates.Enabled = False
        btn_Update.Enabled = False
        btn_Clear.Enabled = False
        Return 0
    End Function

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Try
            Clear_Controls()
            getconnection()
            cmd = New SqlCommand("Truncate table temporary_day_descri", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New SqlCommand("Truncate table temporary_tours_date", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Package_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Package_ID.TextChanged
        btn_Search.Enabled = True
    End Sub

    Private Sub tb_Days_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Import.Click
        comon_class.brows(pb_pkg_img.Image)
        btn_None.Enabled = True
    End Sub

    Private Sub cb_Tour_Guide_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Tour_Guide.SelectedValueChanged
        Try
            Dim tg_index As Integer = cb_Tour_Guide.SelectedIndex
            Dim cnt As Integer
            While cnt < 20
                If cnt = tg_index Then
                    tb_selected_tg_id.Text = tg_arr(cnt)
                    Exit While
                End If
                cnt = cnt + 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_Driver_Name_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Driver_Name.SelectedValueChanged
        Try
            Dim d_index As Integer = cb_Tour_Guide.SelectedIndex
            Dim cnt As Integer
            While cnt < 20
                If cnt = d_index Then
                    tb_selected_td_id.Text = d_arr(cnt)
                    Exit While
                End If
                cnt = cnt + 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tb_Total_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Total_Price.TextChanged
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

    Private Sub btn_Show_Days_Description_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show_Days_Description.Click
        Try
            Comman_Declared.verifying_forms = 3
            frm_Days_Description.Show()
            frm_Days_Description.btn_Edit_days.Hide()
            frm_Days_Description.btn_Back.Enabled = True
            getconnection()
            Dim dat As Integer = 1
            Dim x As Integer = 50
            Dim y As Integer = 100

            cmd = New SqlCommand("select * from pkg_days_descri where pkg_id = " & tb_Package_ID.Text & "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()


            While dr.Read()
                Dim obj = New pkg_Days_Description
                obj.Location = New System.Drawing.Point(x, y)


                obj.btn_next.Text = "Set"
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Show_Tours_Dates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show_Tours_Dates.Click
        Try
            Comman_Declared.verifying_forms = 3
            getconnection()
            frm_Package_Tour_Dates.Show()
            frm_Package_Tour_Dates.btn_Back.Enabled = True
            frm_Package_Tour_Dates.btn_Edit_days.Hide()
            Dim x As Integer = 228
            Dim y As Integer = 125
            Dim dno As Integer = 1
            cmd = New SqlCommand("select * from pkg_tours_date where pkg_id = " & tb_Package_ID.Text & "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim obj = New UC_Package_Tour_Dates
                obj.Location = New System.Drawing.Point(x, y)

                obj.tb_tour_date_id.Text = dr("date_id")
                obj.dtp_Tour_Start_Date.Value = dr("tour_start_date")
                obj.dtp_Tour_End_Date.Value = dr("tour_end_date")
                obj.lbl_Sr_no.Text = dno
                obj.btn_Next.Text = "Set"
                frm_Package_Tour_Dates.Controls.Add(obj)
                y = y + 35
                x = 228

                dno = dno + 1

            End While
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_None_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_None.Click

    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Try
            If tb_Package_ID.Text <> "" And tb_Persons_Capacity.Text <> "" And tb_pkg_name.Text <> "" And tb_route.Text <> "" And tb_Adult_Price.Text <> "" And tb_Children_Price.Text <> "" And tb_Days.Text <> "" And tb_Total_Price.Text <> "" And tb_GST.Text <> "" And tb_Note.Text <> "" And tb_Number_of_tours.Text <> "" Then
                Dim ms As New MemoryStream
                getconnection()
                If cb_Driver_Name.SelectedIndex <> -1 And cb_Tour_Guide.SelectedIndex <> -1 Then
                    cmd = New SqlCommand("Update pkg_info SET pkg_name = '" & tb_pkg_name.Text & "', route = '" & tb_route.Text & "', adult_pri = " & tb_Adult_Price.Text & ", children_pri = " & tb_Children_Price.Text & ", days_dur = " & tb_Days.Text & ", night_dur = " & tb_Nights.Text & ", note = '" & tb_Note.Text & "', total_pri = " & tb_Total_Price.Text & ", GST = " & tb_GST.Text & ", grand_total = " & tb_Grand_Total.Text & ", tot_pkg_tours = " & tb_Number_of_tours.Text & ", create_date = '" & dtp_Pkg_Create_Date.Text & "', expiry_date = '" & dtp_Expiry_Date.Text & "', per_capacity = " & tb_Persons_Capacity.Text & ", t_emp_id = " & tb_selected_tg_id.Text & ", tour_guide_nm = '" & cb_Tour_Guide.Text & "', d_emp_id = " & tb_selected_td_id.Text & ", driver_name = '" & cb_Driver_Name.Text & "', pkg_img = @pb_pkg_img where pkg_id = " & tb_Package_ID.Text & "", con)
                ElseIf cb_Tour_Guide.SelectedIndex <> -1 And cb_Driver_Name.SelectedIndex = -1 Then
                    cmd = New SqlCommand("Update pkg_info SET pkg_name = '" & tb_pkg_name.Text & "', route = '" & tb_route.Text & "', adult_pri = " & tb_Adult_Price.Text & ", children_pri = " & tb_Children_Price.Text & ", days_dur = " & tb_Days.Text & ", night_dur = " & tb_Nights.Text & ", note = '" & tb_Note.Text & "', total_pri = " & tb_Total_Price.Text & ", GST = " & tb_GST.Text & ", grand_total = " & tb_Grand_Total.Text & ", tot_pkg_tours = " & tb_Number_of_tours.Text & ", create_date = '" & dtp_Pkg_Create_Date.Text & "', expiry_date = '" & dtp_Expiry_Date.Text & "', per_capacity = " & tb_Persons_Capacity.Text & ", t_emp_id = " & tb_selected_tg_id.Text & ", tour_guide_nm = '" & cb_Tour_Guide.Text & "', pkg_img = @pb_pkg_img where pkg_id = " & tb_Package_ID.Text & "", con)
                ElseIf cb_Driver_Name.SelectedIndex <> -1 And cb_Tour_Guide.SelectedIndex = -1 Then
                    cmd = New SqlCommand("Update pkg_info SET pkg_name = '" & tb_pkg_name.Text & "', route = '" & tb_route.Text & "', adult_pri = " & tb_Adult_Price.Text & ", children_pri = " & tb_Children_Price.Text & ", days_dur = " & tb_Days.Text & ", night_dur = " & tb_Nights.Text & ", note = '" & tb_Note.Text & "', total_pri = " & tb_Total_Price.Text & ", GST = " & tb_GST.Text & ", grand_total = " & tb_Grand_Total.Text & ", tot_pkg_tours = " & tb_Number_of_tours.Text & ", create_date = '" & dtp_Pkg_Create_Date.Text & "', expiry_date = '" & dtp_Expiry_Date.Text & "', per_capacity = " & tb_Persons_Capacity.Text & ", d_emp_id = " & tb_selected_td_id.Text & ", driver_name = '" & cb_Driver_Name.Text & "', pkg_img = @pb_pkg_img where pkg_id = " & tb_Package_ID.Text & "", con)
                ElseIf cb_Driver_Name.SelectedIndex = -1 And cb_Tour_Guide.SelectedIndex = -1 Then
                    cmd = New SqlCommand("Update pkg_info SET pkg_name = '" & tb_pkg_name.Text & "', route = '" & tb_route.Text & "', adult_pri = " & tb_Adult_Price.Text & ", children_pri = " & tb_Children_Price.Text & ", days_dur = " & tb_Days.Text & ", night_dur = " & tb_Nights.Text & ", note = '" & tb_Note.Text & "', total_pri = " & tb_Total_Price.Text & ", GST = " & tb_GST.Text & ", grand_total = " & tb_Grand_Total.Text & ", tot_pkg_tours = " & tb_Number_of_tours.Text & ", create_date = '" & dtp_Pkg_Create_Date.Text & "', expiry_date = '" & dtp_Expiry_Date.Text & "', per_capacity = " & tb_Persons_Capacity.Text & ", pkg_img = @pb_pkg_img where pkg_id = " & tb_Package_ID.Text & "", con)
                End If
                Dim bm As Bitmap = New Bitmap(pb_pkg_img.Image)
                bm.Save(ms, Imaging.ImageFormat.Jpeg)
                cmd.Parameters.Add("@pb_pkg_img", SqlDbType.Image).Value = ms.ToArray()

                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Record Updated Successfully....", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                    ms.Close()
                    ms.Dispose()

                    If cb_Tour_Guide.SelectedIndex <> -1 Then
                        cmd = New SqlCommand("Update Emp_Info set avability = " & 0 & " where emp_id = " & tb_selected_tg_id.Text & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        cmd = New SqlCommand("Update Emp_Info set avability = " & 1 & " where emp_id = " & tb_tg_id.Text & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                    If cb_Driver_Name.SelectedIndex <> -1 Then
                        cmd = New SqlCommand("Update Emp_Info set avability = " & 0 & " where emp_id = " & tb_d_id.Text & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New SqlCommand("Update Emp_Info set avability = " & 1 & " where emp_id = " & tb_selected_td_id.Text & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                Else
                    MsgBox("Record is Not Updated Successfully....", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                End If
                '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================

                Dim pkg_id As Integer = 0
                Dim day_id As Integer = 0
                Dim tour_day_no As String = Nothing
                Dim day_place As String = Nothing
                Dim day_lh_name As String = Nothing
                Dim day_lh_place As String = Nothing
                Dim day_dh_name As String = Nothing
                Dim day_dh_place As String = Nothing
                Dim day_description As String = Nothing

                cmd = New SqlCommand("select count(day_id) from temporary_day_descri", con)
                Dim day_cnt As Integer = cmd.ExecuteScalar()
                cmd.Dispose()

                While day_cnt > 0

                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("select * from temporary_day_descri ", con)
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then
                        pkg_id = dr("pkg_id")
                        day_id = dr("day_id")
                        tour_day_no = dr("tour_day_no").ToString
                        day_place = dr("day_place").ToString
                        day_lh_name = dr("day_lh_name").ToString
                        day_lh_place = dr("day_lh_place").ToString
                        day_dh_name = dr("day_dh_name").ToString
                        day_dh_place = dr("day_dh_place").ToString
                        day_description = dr("day_description").ToString
                    End If
                    cmd.Dispose()
                    dr.Close()

                    cmd = New SqlCommand("Update pkg_days_descri SET tour_day_no = '" & tour_day_no & "',day_place = '" & day_place & "',day_lh_name = '" & day_lh_name & "',day_lh_place = '" & day_lh_place & "',day_dh_name = '" & day_dh_name & "',day_dh_place = '" & day_dh_place & "',day_description = '" & day_description & "' where day_id = " & day_id & "", con)
                    If cmd.ExecuteNonQuery > 0 Then

                    Else
                        cmd.Dispose()
                        cmd = New SqlCommand("insert into pkg_days_descri values(" & pkg_id & "," & day_id & ",'" & tour_day_no & "','" & day_place & "','" & day_lh_name & "','" & day_lh_place & "','" & day_dh_name & "','" & day_dh_place & "','" & day_description & "')", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New SqlCommand("select count(day_id) from pkg_days_descri where pkg_id = " & pkg_id & "", con)
                        Dim days_de As Integer = cmd.ExecuteScalar()
                        cmd.Dispose()

                        cmd = New SqlCommand("select days_dur from pkg_info where pkg_id = " & pkg_id & "", con)
                        Dim pkg_days_dur As Integer = cmd.ExecuteScalar()
                        cmd.Dispose()

                        If days_de <> pkg_days_dur Then
                            cmd = New SqlCommand("Update pkg_info Set days_dur = " & days_de & ", night_dur = " & days_de - 1 & "  where pkg_id = " & pkg_id & "", con)
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                    cmd.Dispose()

                    cmd = New SqlCommand("Delete from temporary_day_descri where day_id = " & day_id & "", con)
                    If day_cnt = day_cnt - (day_cnt - 1) Then
                        If cmd.ExecuteNonQuery = 1 Then
                            MsgBox("Records are successfully Deleted form tem.days table ", MsgBoxStyle.OkOnly)
                            cmd.Dispose()
                        Else
                            MsgBox("Records are  not Deleted form tem.days table ", MsgBoxStyle.OkOnly)
                        End If
                    Else
                        cmd.ExecuteNonQuery()
                    End If
                    cmd.Dispose()
                    day_cnt = day_cnt - 1
                End While

                '=================================================================================================================================================================================================================================================================================================================================================================

                Dim d_pkg_id As Integer = 0
                Dim date_id As Integer = 0
                Dim tour_start_date As Date = Nothing
                Dim tour_end_date As Date = Nothing

                cmd = New SqlCommand("select count(date_id) from temporary_tours_date", con)
                Dim date_cnt As Integer = cmd.ExecuteScalar()
                cmd.Dispose()

                While date_cnt > 0

                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("select * from temporary_tours_date ", con)
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then
                        pkg_id = dr("pkg_id")
                        date_id = dr("date_id")
                        tour_start_date = dr("tour_start_date").ToString
                        tour_end_date = dr("tour_end_date").ToString
                    End If
                    cmd.Dispose()
                    dr.Close()

                    cmd = New SqlCommand("Update pkg_tours_date SET tour_start_date = '" & tour_start_date & "',tour_end_date = '" & tour_end_date & "' where date_id = " & date_id & "", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New SqlCommand("Delete from temporary_tours_date where date_id = " & date_id & "", con)
                    If date_cnt = date_cnt - (date_cnt - 1) Then
                        If cmd.ExecuteNonQuery = 1 Then
                            MsgBox("Records are successfully Deleted form tem.date table ", MsgBoxStyle.OkOnly)
                            cmd.Dispose()
                        Else
                            MsgBox("Records are  not Deleted form tem.date table ", MsgBoxStyle.OkOnly)
                        End If
                    Else
                        cmd.ExecuteNonQuery()
                    End If
                    cmd.Dispose()
                    date_cnt = date_cnt - 1
                End While
                terminateconnection()
            Else
                MsgBox("Please Fill All Fields and Save /OR Clear All Fields", MsgBoxStyle.Question, MsgBoxStyle.OkOnly)
            End If

            Clear_Controls()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Add_days_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_days.Click
        Try
            If tb_Add_Days.Text <> "" Then
                If Val(tb_Add_Days.Text) > 0 Then
                    frm_Package_Tour_Dates.Close()
                    Comman_Declared.verifying_forms = 3
                    getconnection()
                    Dim x As Integer = 50
                    Dim y As Integer = 100
                    Dim d_cnt As Integer = Val(tb_Add_Days.Text)
                    cmd = New SqlCommand("select count(day_id) from pkg_days_descri where pkg_id = " & tb_Package_ID.Text & "", con)
                    Dim dno As Integer = cmd.ExecuteScalar + 1
                    Comman_Declared.c_day_id = Auto_Increment("select count(day_id) from pkg_days_descri", 100)
                    frm_Days_Description.Show()

                    While d_cnt > 0
                        Dim obj = New pkg_Days_Description
                        obj.Location = New System.Drawing.Point(x, y)

                        obj.btn_next.Text = "Set"
                        obj.lbl_Days_no.Text = "Day" + dno.ToString
                        frm_Days_Description.Controls.Add(obj)


                        obj.tb_day_id.Text = Comman_Declared.c_day_id
                        x = x + 1357
                        y = y + 375
                        x = 50
                        Comman_Declared.c_day_id = Comman_Declared.c_day_id + 1
                        dno = dno + 1
                        d_cnt = d_cnt - 1
                    End While
                Else
                    MsgBox("Please Enter Correct Number..", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please Enter Number of Days you want to Add...", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class