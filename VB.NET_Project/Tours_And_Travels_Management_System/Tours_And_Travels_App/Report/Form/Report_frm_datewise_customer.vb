Imports System.Data.SqlClient
Public Class Report_frm_datewise_customer

    Private Sub frm_datewise_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_from_date.Value = Today.Date
        dtp_to_date.Value = Today.Date
    End Sub
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If (dtp_from_date.Value < dtp_to_date.Value) Then
                getconnection()
                Dim dt1 As New DataTable()
                cmd = New SqlCommand("select * from Cust_Info where booking_date between '" & dtp_from_date.Value & "' And '" & dtp_to_date.Value & "'", con)
                Dim sda As New SqlDataAdapter(cmd)
                sda.Fill(dt1)

                terminateconnection()
                Dim rpt As New Tour_Dates_Cust_rpt()

                rpt.Database.Tables("Cust_Info").SetDataSource(dt1)

                Report_Frm_bill.CRV_Bill.ReportSource = Nothing
                Report_Frm_bill.CRV_Bill.ReportSource = rpt

                panel_show_data.Controls.Clear()
                panel_show_data.Controls.Add(Report_Frm_bill.CRV_Bill)

            Else
                MsgBox("Please Select Correct Date..", MsgBoxStyle.OkOnly)
            End If
            getconnection()
        Catch ex As Exception
        End Try

    End Sub
End Class