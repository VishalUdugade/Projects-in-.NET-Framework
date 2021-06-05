Imports System.Data.SqlClient
Public Class Report_frm_Single_Day_calcuation
    Private Sub Single_Day_calcuation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Search_Date.Value = Today.Date
    End Sub

    Private Sub cb_Search_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Search_type.SelectedIndexChanged
        Try
            If cb_Search_type.SelectedIndex = 0 Then
                cb_Search_type.Enabled = False
            ElseIf cb_Search_type.SelectedIndex = 1 Then
                cb_Search_type.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If cb_Search_type.SelectedIndex <> -1 Then
                If (cb_Search_type.SelectedIndex = 0) Then
                    dtp_Search_Date.Value = Today.Date
                End If
                getconnection()
                Dim dt1 As New DataTable()
                cmd = New SqlCommand("select * from report_payment where pay_date = '" & dtp_Search_Date.Text & "'", con)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt1)

                terminateconnection()
                Dim rpt As New Single_Day_Calculation()

                rpt.Database.Tables("report_payment").SetDataSource(dt1)

                CRV_Single_Day_Cal.ReportSource = Nothing
                CRV_Single_Day_Cal.ReportSource = rpt


                cmd.Dispose()

            Else
                MsgBox("Select Search type first...", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class