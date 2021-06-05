Imports System.Data.SqlClient

Public Class frm_View_All_Customer_Details

    Private Sub btn_Customer_Fetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_All_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Customer.Click
        Try
            getconnection()
            dgv_View_All_Customer.Refresh()
            cmd = New SqlCommand("select * from Cust_Info", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgv_View_All_Customer.DataSource = dt
            cmd.Dispose()
            con.Close()

            cmd = New SqlCommand("select * from Traveller", con)
            Dim ta As New SqlDataAdapter(cmd)
            Dim df As New DataTable()

            ta.Fill(df)
            dgv_Traveller.DataSource = df
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_Customer_id.Text <> "" Then
                getconnection()
                cmd = New SqlCommand("select * from Cust_Info where cust_id = " & tb_Customer_id.Text & "", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                da.Fill(dt)
                dgv_View_All_Customer.DataSource = dt
                cmd.Dispose()
                con.Close()

                cmd = New SqlCommand("select * from Traveller where cust_id = " & tb_Customer_id.Text & "", con)
                Dim ta As New SqlDataAdapter(cmd)
                Dim df As New DataTable()

                ta.Fill(df)
                dgv_Traveller.DataSource = df
                cmd.Dispose()
                con.Close()
            Else
                MsgBox("Please Enter Customer ID First", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Hide()
        frm_Owner.Show()
    End Sub
End Class
