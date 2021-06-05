Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Forms

Public Class Report_Frm_bill

    Private Sub Bill_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cust_id As Integer = 0
            cust_id = Val(frm_Payment.tb_Cust_id.Text)
            getconnection()
            Dim dt1 As New DataTable()
            cmd = New SqlCommand("select * from Cust_Info where cust_id = " & cust_id & "", con)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt1)

            Dim dt2 As New DataTable()
            cmd = New SqlCommand("select * from pkg_payment where cust_id = " & cust_id & "", con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dt2)

            Dim dt3 As New DataTable()
            cmd = New SqlCommand("select * from report_payment where cust_id = " & cust_id & "", con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dt3)

            terminateconnection()
            Dim rpt As New Bill_rpt()

            rpt.Database.Tables("Cust_Info").SetDataSource(dt1)
            rpt.Database.Tables("pkg_payment").SetDataSource(dt2)
            rpt.Database.Tables("report_payment").SetDataSource(dt3)

            CRV_Bill.ReportSource = Nothing
            CRV_Bill.ReportSource = rpt

            cmd.Dispose()
            adp.Dispose()
            terminateconnection()
        Catch ex As Exception
        End Try
    End Sub
End Class