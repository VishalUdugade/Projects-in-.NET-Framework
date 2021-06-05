Imports System.Data.SqlClient

Public Class frm_update_tour
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels_DB;Integrated Security=True")
    Dim cmnd As New SqlCommand
    Dim mode As String

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub btn_UPsearch_Click(sender As System.Object, e As System.EventArgs) Handles btn_UPsearch.Click
        connection()
        lb_travels_Nm.Items.Clear()
        clb_travel_days.Items.Clear()
        Dim dr As SqlDataReader
        cmnd.Connection = con
        If tb_tour_id.Text <> "" Then
            cmnd.CommandText = "Select * from Tour_tbl where Tour_Id=" & tb_tour_id.Text & ""
            dr = cmnd.ExecuteReader()
            While dr.Read()
                tb_source.Text = dr("Source").ToString
                tb_destina.Text = dr("Destination").ToString
                dtp_UPdeparture_time.Text = dr("Depart_time").ToString
                dtp_UParrival_time.Text = dr("Arrive_time").ToString
                tb_distance.Text = dr("Distance").ToString
                tb_route.Text = dr("Route").ToString
                tb_ext_mode.Text = dr("Mode").ToString
                tb_adl_price.Text = dr("Adult_price").ToString
                tb_child_price.Text = dr("Child_price").ToString
                tb_total_price.Text = dr("Total").ToString
            End While
            dr.Close()
            cmnd.Dispose()
            Dim str1 As String
            cmnd.CommandText = "Select distinct(Travels_Name) from Tour_Days_tbl where Tour_Id=" & tb_tour_id.Text & ""
            dr = cmnd.ExecuteReader
            While dr.Read()
                str1 = dr("Travels_Name").ToString
                lb_travels_Nm.Items.Add(str1)
                lb_travels_Nm.ValueMember = dr(0)

            End While
            dr.Close()
            cmnd.Dispose()

            cmnd.CommandText = "Select Selected_Days From Tour_Days_tbl Where Tour_Id=" & tb_tour_id.Text & " "
            dr = cmnd.ExecuteReader()

            While dr.Read()
                Dim str As String = dr("Selected_Days")
                clb_travel_days.Items.Add(str)
                clb_travel_days.SetItemChecked(clb_travel_days.Items.Count - 1, True)
            End While
            dr.Close()
        Else
            MsgBox("Please Enter Tour ID First", MsgBoxStyle.RetryCancel)
            tb_tour_id.Focus()

        End If
        con.Close()
    End Sub

    Private Sub btn_remove_days_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove_days.Click
        connection()

        cmnd.Connection = con
        If MsgBox("You Want Delete Previous Record And Add New Records.", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If lb_travels_Nm.SelectedItems.Count > 0 Then
                cmnd.CommandText = "Delete From Tour_Days_tbl where Travels_Name='" & lb_travels_Nm.Text & "'"
                cmnd.ExecuteNonQuery()
                cmnd.Dispose()
                lb_travels_Nm.Items.Clear()
                clb_travel_days.Items.Clear()

                rb_sleeper_travel.Enabled = True
                rb_non_sleeper_travel.Enabled = True
                clb_travel_days.Items.Add("Sunday")
                clb_travel_days.Items.Add("Monday")
                clb_travel_days.Items.Add("Tuesday")
                clb_travel_days.Items.Add("Wednesday")
                clb_travel_days.Items.Add("Thursday")
                clb_travel_days.Items.Add("Friday")
                clb_travel_days.Items.Add("Saturday")
            Else
                MsgBox("Please Select Travel Name Which You Want To Remove Then Click The Remove Button.", MsgBoxStyle.OkOnly)
                lb_travels_Nm.Enabled = True
                clb_travel_days.Enabled = True
            End If
        End If
    End Sub

    Private Sub rb_sleeper_travel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_sleeper_travel.CheckedChanged
        mode = Nothing
        connection()
        cmnd.Connection = con
        Dim dr As SqlDataReader

        If rb_sleeper_travel.Checked = True Then
            mode = rb_sleeper_travel.Text
            cmnd.CommandText = "Select Sr_No,Travel_Sleeper_With_AC from Travels_info_tbl"
            dr = cmnd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr("Travel_Sleeper_With_AC").ToString
                lb_travels_Nm.Items.Add(str)
                lb_travels_Nm.ValueMember = dr(0)
            End While
            dr.Close()
            cmnd.Dispose()
            con.Close()
        Else
            lb_travels_Nm.Items.Clear()
        End If
    End Sub

    Private Sub rb_non_sleeper_travel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_non_sleeper_travel.CheckedChanged
        mode = Nothing
        connection()
        cmnd.Connection = con
        Dim dr As SqlDataReader
        If rb_non_sleeper_travel.Checked = True Then
            mode = rb_non_sleeper_travel.Text
            cmnd.CommandText = "Select Sr_No,Travel_Non_Sleeper from Travels_info_tbl"
            dr = cmnd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr("Travel_Non_Sleeper").ToString
                lb_travels_Nm.Items.Add(str)
                lb_travels_Nm.ValueMember = dr(0)
            End While
            dr.Close()
            cmnd.Dispose()
            con.Close()
        Else
            lb_travels_Nm.Items.Clear()
        End If
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        connection()
        Dim cnt As Integer = 0
        Dim days As String
        Dim Str1 As String = Nothing
        cmnd.Connection = con
        If tb_adl_price.Text <> "" And tb_child_price.Text <> "" Then

            If MsgBox(" Are You Sure New Travels Name And Its Days Inserting.", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                If lb_travels_Nm.Enabled <> False Then
                    If lb_travels_Nm.SelectedItems.Count > 0 Then
                        If clb_travel_days.CheckedItems.Count > 0 Then
                            While cnt < clb_travel_days.CheckedItems.Count
                                days = clb_travel_days.CheckedItems(cnt).ToString
                                cmnd.CommandText = "Insert Into Tour_Days_tbl Values(" & tb_tour_id.Text & ",'" & lb_travels_Nm.Text & "','" & days & "')"
                                cmnd.ExecuteNonQuery()
                                cmnd.Dispose()
                                cnt = cnt + 1
                            End While
                            cmnd.CommandText = "Update Tour_tbl set Adult_price='" & tb_adl_price.Text & "',Child_price='" & tb_child_price.Text & "',Total='" & tb_total_price.Text & "' where Tour_Id=" & tb_tour_id.Text & " "
                            cmnd.ExecuteNonQuery()
                            cmnd.Dispose()
                            MsgBox("Tour Update Successfully.", MsgBoxStyle.OkOnly)
                            lb_travels_Nm.Enabled = False
                        End If
                    Else
                        If MsgBox("Please Select Travel Name And Its Days.", MsgBoxStyle.OkCancel) = DialogResult.OK Then
                            cmnd.CommandText = "Update Tour_tbl set Adult_price='" & tb_adl_price.Text & "',Child_price='" & tb_child_price.Text & "',Total='" & tb_total_price.Text & "' where Tour_Id=" & tb_tour_id.Text & " "
                            cmnd.ExecuteNonQuery()
                            cmnd.Dispose()
                            lb_travels_Nm.Enabled = True
                            btn_remove_days.Focus()
                        End If
                    End If

                End If
                cmnd.CommandText = "Update Tour_tbl set Adult_price='" & tb_adl_price.Text & "',Child_price='" & tb_child_price.Text & "',Total='" & tb_total_price.Text & "' where Tour_Id=" & tb_tour_id.Text & " "
                cmnd.ExecuteNonQuery()
                cmnd.Dispose()

            End If
        Else
            MsgBox("Please Fill All Field.", MsgBoxStyle.OkOnly)
        End If
        con.Close()
    End Sub
End Class