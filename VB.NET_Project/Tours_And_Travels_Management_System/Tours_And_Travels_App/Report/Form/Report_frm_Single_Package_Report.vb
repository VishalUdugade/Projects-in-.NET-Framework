Imports System.Data.SqlClient
Public Class Report_frm_Single_Package_Report
    Dim dr As SqlDataReader
    Private Sub Single_Package_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            getconnection()
            cmd = New SqlCommand("select pkg_name from pkg_info where expiry_date < '" & Today.Date & "'", con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                cb_Package_Name.Items.Add(dr("pkg_name"))
            End While
            dr.Close()
            cmd.Dispose()
            terminateconnection()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If (cb_Package_Name.SelectedIndex <> -1) Then
                getconnection()
                Dim id As Integer = 0
                cmd = New SqlCommand("select * from pkg_info where pkg_name = '" & cb_Package_Name.Text & "'", con)
                Dim sda As New SqlDataAdapter(cmd)
                Dim dt1 As New DataTable()
                sda.Fill(dt1)

                dr = cmd.ExecuteReader()
                If (dr.Read()) Then
                    id = dr("pkg_id")
                End If
                dr.Close()
                cmd.Dispose()

                Dim dt2 As New DataTable()
                cmd = New SqlCommand("select count(cust_id) As cust_id from Cust_Info where pkg_id = " & id & "", con)
                sda = New SqlDataAdapter(cmd)
                sda.Fill(dt2)

                Dim dt3 As New DataTable()
                cmd = New SqlCommand("select sum(ent_pay_amount)+sum(full_pay) AS ent_pay_amount from report_payment where pkg_id = " & id & "", con)
                sda = New SqlDataAdapter(cmd)
                sda.Fill(dt3)

                terminateconnection()
                Dim rpt As New single_package_report_rpt()

                rpt.Database.Tables("pkg_info").SetDataSource(dt1)
                rpt.Database.Tables("Cust_Info").SetDataSource(dt2)
                rpt.Database.Tables("report_payment").SetDataSource(dt3)

                CRV_Package_Calculation.ReportSource = Nothing
                CRV_Package_Calculation.ReportSource = rpt
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class