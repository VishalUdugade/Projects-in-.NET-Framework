Imports System.Data.SqlClient

Public Class frm_View_All_Package

    Private Sub cb_Search_Type_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Search_Type.SelectedValueChanged
        Try
            getconnection()
            If cb_Search_Type.Text = "Package ID" Then
                cb_Pkg_Nm.Items.Clear()
                tb_Pkg_id.Enabled = True
                cb_Pkg_Nm.SelectedIndex = -1
                cb_Pkg_Nm.Enabled = False
            ElseIf cb_Search_Type.Text = "Package Name" Then
                cb_Pkg_Nm.Enabled = True
                tb_Pkg_id.Text = ""
                tb_Pkg_id.Enabled = False
                cmd = New SqlCommand("select pkg_name from pkg_info", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()

                While dr.Read()
                    cb_Pkg_Nm.Items.Add(dr("pkg_name")).ToString()
                End While

                terminateconnection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            getconnection()
            If cb_Search_Type.SelectedIndex <> -1 Then
                If cb_Search_Type.Text = "Package ID" Then
                    If tb_Pkg_id.Enabled = True And tb_Pkg_id.Text <> "" Then
                        cmd = New SqlCommand("select pkg_id,pkg_name,route,adult_pri,children_pri,days_dur from pkg_info where pkg_id = " & tb_Pkg_id.Text & "", con)
                        Dim da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgv_Show_Pkg_Data.DataSource = dt
                        cmd.Dispose()
                        con.Close()
                        dt.Dispose()
                        da.Dispose()

                        cmd = New SqlCommand("select tour_day_no,day_place,day_lh_name,day_lh_place,day_dh_name,day_dh_place,day_description from pkg_days_descri where pkg_id = " & tb_Pkg_id.Text & "", con)
                        Dim ds As New SqlDataAdapter(cmd)
                        Dim df As New DataTable()
                        ds.Fill(df)
                        dgv_pkg_day_data.DataSource = df
                        cmd.Dispose()
                        con.Close()
                        dt.Dispose()
                        da.Dispose()

                        cmd = New SqlCommand("select tour_start_date,tour_end_date from pkg_tours_date where pkg_id = " & tb_Pkg_id.Text & "", con)
                        Dim dc As New SqlDataAdapter(cmd)
                        Dim dv As New DataTable()
                        dc.Fill(dv)
                        dgv_pkg_tours_dat.DataSource = dv
                        cmd.Dispose()
                        con.Close()
                        dt.Dispose()
                        da.Dispose()
                    Else
                        MsgBox("Please Enter Package ID First", MsgBoxStyle.OkOnly)
                    End If
                ElseIf cb_Search_Type.Text = "Package Name" Then
                    If cb_Pkg_Nm.Enabled = True And cb_Pkg_Nm.SelectedIndex <> -1 Then
                        Dim pkg_id As Integer = 0
                        cmd = New SqlCommand("select pkg_id from pkg_info where pkg_name = '" & cb_Pkg_Nm.Text & "'", con)
                        pkg_id = cmd.ExecuteScalar()
                        cmd.Dispose()

                        cmd = New SqlCommand("select * from pkg_info full join pkg_days_descri on pkg_info.pkg_id = pkg_days_descri.pkg_id where pkg_info.pkg_id = " & pkg_id & "", con)

                    Else
                        MsgBox("Please Select Package Name First", MsgBoxStyle.OkOnly)
                    End If
                End If

                'Dim da As New SqlDataAdapter(cmd)
                'Dim dt As New DataTable()

                'da.Fill(dt)
                'dgv_Show_Pkg_Data.DataSource = dt
                'cmd.Dispose()
                'con.Close()
                'dt.Dispose()
                'da.Dispose()
            Else
                MsgBox("Please Select Search Type First", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_All_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Pkg.Click
        Try
            getconnection()
            dgv_Show_Pkg_Data.Refresh()
            cmd = New SqlCommand("select pkg_id,pkg_name,route,adult_pri,children_pri,days_dur from pkg_info", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgv_Show_Pkg_Data.DataSource = dt
            cmd.Dispose()
            con.Close()
            dt.Dispose()
            da.Dispose()

            cmd = New SqlCommand("select pkg_id,tour_day_no,day_place,day_lh_name,day_lh_place,day_dh_name,day_dh_place,day_description from pkg_days_descri", con)
            Dim ds As New SqlDataAdapter(cmd)
            Dim df As New DataTable()
            ds.Fill(df)
            dgv_pkg_day_data.DataSource = df
            cmd.Dispose()
            con.Close()
            dt.Dispose()
            da.Dispose()

            cmd = New SqlCommand("select pkg_id,tour_start_date,tour_end_date from pkg_tours_date", con)
            Dim dc As New SqlDataAdapter(cmd)
            Dim dv As New DataTable()
            dc.Fill(dv)
            dgv_pkg_tours_dat.DataSource = dv
            cmd.Dispose()
            con.Close()
            dt.Dispose()
            da.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
        frm_Owner.Show()
    End Sub
End Class