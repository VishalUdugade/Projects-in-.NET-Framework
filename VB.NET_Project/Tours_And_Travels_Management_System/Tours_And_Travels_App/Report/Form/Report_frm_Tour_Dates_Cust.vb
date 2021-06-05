Imports System.Data.SqlClient
Public Class Report_frm_Tour_Dates_Cust
    Dim dr As SqlDataReader
    Dim pkg_id As Integer
    Private Sub cb_Search_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Search_Type.SelectedIndexChanged
        Try
            If cb_Search_Type.SelectedIndex = 0 Then
                cb_Type_Name.Items.Clear()
                getconnection()
                cmd = New SqlCommand("select pkg_id from pkg_info", con)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    cb_Type_Name.Items.Add(dr("pkg_id"))
                End While
                dr.Close()
                cmd.Dispose()

            ElseIf cb_Search_Type.SelectedIndex = 1 Then
                cb_Type_Name.Items.Clear()
                getconnection()
                cmd = New SqlCommand("select pkg_name from pkg_info", con)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    cb_Type_Name.Items.Add(dr("pkg_name"))
                End While
                dr.Close()
                cmd.Dispose()
            End If
            terminateconnection()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_Type_Name_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Type_Name.SelectedValueChanged
        Try
            If cb_Search_Type.SelectedIndex <> -1 Then
                getconnection()
                If cb_Search_Type.SelectedIndex = 0 Then
                    cb_Tour_Start_Date.Items.Clear()
                    cmd = New SqlCommand("Select tour_start_date from pkg_tours_date where pkg_id = '" & cb_Type_Name.Text & "' and tour_end_date < '" & Date.Now.Date & "'", con)
                    dr = cmd.ExecuteReader()
                    While dr.Read()
                        cb_Tour_Start_Date.Items.Add(dr("tour_start_date"))
                    End While
                    dr.Close()
                    cmd.Dispose()
                ElseIf cb_Search_Type.SelectedIndex = 1 Then
                    cmd = New SqlCommand("select pkg_id from pkg_info where pkg_name = '" & cb_Type_Name.Text & "'", con)
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        pkg_id = dr("pkg_id")
                        dr.Close()
                        cmd.Dispose()

                        cb_Tour_Start_Date.Items.Clear()
                        cmd = New SqlCommand("Select tour_start_date from pkg_tours_date where pkg_id = '" & pkg_id & "' and tour_end_date < '" & Date.Now.Date & "'", con)
                        dr = cmd.ExecuteReader()
                        While dr.Read()
                            cb_Tour_Start_Date.Items.Add(dr("tour_start_date"))
                        End While
                        dr.Close()
                        cmd.Dispose()
                    Else


                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_Tour_Start_Date_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Tour_Start_Date.SelectedValueChanged
        Try
            If cb_Search_Type.SelectedIndex <> -1 And cb_Type_Name.Text <> "" Then
                getconnection()
                cmd = New SqlCommand("select tour_end_date from pkg_tours_date where tour_start_date = '" & cb_Tour_Start_Date.Text & "'", con)
                dr = cmd.ExecuteReader()
                cb_Tour_End_Date.Text = ""
                If dr.Read() Then
                    cb_Tour_End_Date.Text = dr("tour_end_date")
                Else

                End If
                cmd.Dispose()
                dr.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        Try
            If cb_Search_Type.SelectedIndex <> -1 And cb_Type_Name.Text <> "" And cb_Tour_Start_Date.Text <> "" And cb_Tour_End_Date.Text <> "" Then
                getconnection()
                cmd = New SqlCommand("select * from Cust_Info where t_start_date = '" & cb_Tour_Start_Date.Text & "' and t_end_date = '" & cb_Tour_End_Date.Text & "'", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                terminateconnection()
                Dim rpt As New Tour_Dates_Cust_rpt()
                rpt.Database.Tables("Cust_Info").SetDataSource(dt)

                CRV_Tours_Date_Customer.ReportSource = Nothing
                CRV_Tours_Date_Customer.ReportSource = rpt
            Else
                MsgBox("First fill All Fields...", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class