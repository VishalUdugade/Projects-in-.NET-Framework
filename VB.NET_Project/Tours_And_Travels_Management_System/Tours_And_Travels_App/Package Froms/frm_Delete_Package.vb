Imports System.Data.SqlClient

Public Class frm_Delete_Package

    Private Sub frm_Delete_Package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            getconnection()
            If tb_Package_ID.Text = "" And cb_pkg_name.SelectedIndex = -1 Then
                MsgBox("Please Select Package Name", MsgBoxStyle.OkOnly)
            Else
                btn_Show_Days_Description.Enabled = True
                btn_Show_Tours_Dates.Enabled = True
                btn_Clear.Enabled = True
                btn_Delete.Enabled = True

                Dim dr As SqlDataReader

                If cb_pkg_name.SelectedIndex <> -1 Then
                    cmd = New SqlCommand("select * from pkg_info where pkg_name = '" & cb_pkg_name.Text & "'", con)
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then
                        tb_Package_ID.Text = dr("pkg_id").ToString
                        tb_pkg_name.Text = dr("pkg_name").ToString
                        tb_route.Text = dr("route").ToString
                        tb_Adult_Price.Text = dr("adult_pri")
                        tb_Children_Price.Text = dr("children_pri")
                        tb_Days.Text = dr("days_dur")
                        tb_Nights.Text = dr("night_dur")
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
                    Else
                        MsgBox("Record Not Found", MsgBoxStyle.OkOnly)
                    End If
                    dr.Close()
                    cmd.Dispose()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Show_Days_Description_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show_Days_Description.Click
        Try
            Comman_Declared.verifying_forms = 4
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

                obj.btn_next.Hide()
                obj.tb_day_id.Text = dr("day_id")
                obj.lbl_Days_no.Text = dr("tour_day_no").ToString
                obj.tb_Place.Text = dr("day_place").ToString
                obj.tb_L_Name.Text = dr("day_lh_name").ToString
                obj.tb_L_Place.Text = dr("day_lh_place").ToString
                obj.tb_D_Name.Text = dr("day_dh_name").ToString
                obj.tb_D_Place.Text = dr("day_dh_place").ToString
                obj.tb_Days_Descri.Text = dr("day_description").ToString
                obj.Enabled = False
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
            Comman_Declared.verifying_forms = 4
            getconnection()
            frm_Package_Tour_Dates.Show()
            frm_Package_Tour_Dates.btn_Edit_days.Hide()
            frm_Package_Tour_Dates.btn_Back.Enabled = True
            Dim x As Integer = 228
            Dim y As Integer = 125
            Dim dno As Integer = 1
            cmd = New SqlCommand("select * from pkg_tours_date where pkg_id = " & tb_Package_ID.Text & "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim obj = New UC_Package_Tour_Dates
                obj.Location = New System.Drawing.Point(x, y)

                obj.tb_tour_date_id.Hide()
                obj.dtp_Tour_Start_Date.Value = dr("tour_start_date")
                obj.dtp_Tour_End_Date.Value = dr("tour_end_date")
                obj.lbl_Sr_no.Text = dno
                obj.btn_Next.Hide()
                obj.Enabled = False
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
    Function Clear_Controls()
        tb_Package_ID.Text = ""
        tb_pkg_name.Text = ""
        lbl_Days.Text = ""
        tb_Persons_Capacity.Text = ""
        tb_Number_of_tours.Text = ""
        pb_pkg_img.Image = Nothing
        cb_pkg_name.SelectedIndex = -1
        dtp_Pkg_Create_Date.Value = Date.Now.Date
        dtp_Expiry_Date.Value = Date.Now.Date
        clearAllTxtbo(gb_Package_Information)
        clearAllTxtbo(gb_Pkg_Persons)
        clearAllTxtbo(panel_Note)
        clearAllTxtbo(panel_duration)
        btn_Show_Days_Description.Enabled = False
        btn_Show_Tours_Dates.Enabled = False
        btn_Delete.Enabled = False
        btn_Clear.Enabled = False
        Return 0
    End Function
    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Clear_Controls()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        ''If tb_Package_ID.Text <> "" And tb_Persons_Capacity.Text <> "" And tb_pkg_name.Text <> "" And tb_route.Text <> "" And tb_Adult_Price.Text <> "" And tb_Children_Price.Text <> "" And tb_Days.Text <> "" And tb_Total_Price.Text <> "" And tb_GST.Text <> "" And tb_Note.Text <> "" And tb_Number_of_tours.Text <> "" Then
        ''    getconnection()
        ''    cmd = New SqlCommand("Update Emp_Info set avability = " & 1 & " where emp_id = " & tb_tg_id.Text & "", con)
        ''    If cmd.ExecuteNonQuery = 1 Then
        ''        MsgBox("tg Emp_Id is Updated", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("tg Emp_Id is not updated", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    End If
        ''    cmd.Dispose()

        ''    cmd = New SqlCommand("Update Emp_Info set avability = " & 1 & " where emp_id = " & tb_d_id.Text & "", con)
        ''    If cmd.ExecuteNonQuery = 1 Then
        ''        MsgBox("d Emp_Id is Updated", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("d Emp_Id is not updated", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    End If
        ''    cmd.Dispose()
        ''    '======================================================================================================================================================================================================================================================================================================================

        ''    cmd = New SqlCommand("Delete from pkg_days_descri where pkg_id = " & tb_Package_ID.Text & "", con)
        ''    If cmd.ExecuteNonQuery = 1 Then
        ''        MsgBox("Record Deleted from pkg_days_descri", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("Record Not Deleted from pkg_days_descri", MsgBoxStyle.OkOnly)
        ''    End If
        ''    cmd.Dispose()
        ''    '======================================================================================================================================================================================================================================================================================================================

        ''    cmd = New SqlCommand("Delete from pkg_tours_date where pkg_id = " & tb_Package_ID.Text & "", con)
        ''    If cmd.ExecuteNonQuery = 1 Then
        ''        MsgBox("Record Deleted from pkg_tours_date", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("Record Not Deleted from pkg_tours_date", MsgBoxStyle.OkOnly)
        ''    End If
        ''    cmd.Dispose()
        ''    '======================================================================================================================================================================================================================================================================================================================

        ''    cmd = New SqlCommand("Delete from pkg_info where pkg_id = " & tb_Package_ID.Text & "", con)
        ''    If cmd.ExecuteNonQuery = 1 Then
        ''        MsgBox("Package Deleted Successfully..", MsgBoxStyle.OkOnly)
        ''        cmd.Dispose()
        ''    Else
        ''        MsgBox("Package Not Deleted Successfully..", MsgBoxStyle.OkOnly)
        ''    End If
        ''    cmd.Dispose()
        ''    '=======================================================================================================================================================================================================================================================================================================================
        ''    Clear_Controls()
        ''End If

    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
        frm_Owner.Show()
    End Sub
End Class