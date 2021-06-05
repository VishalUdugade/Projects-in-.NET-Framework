Imports System.Data.SqlClient

Public Class frm_view_tours
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels_DB;Integrated Security=True")
    Dim cmd As New SqlCommand

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub

    Private Sub frm_view_tours_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connection()
        cmd.Connection = con

        cmd.CommandText = "Select * From Tour_tbl Order By Tour_Id ASC"

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        dgv_view_all_tour.DataSource = dt
        cmd.Dispose()

        cmd.CommandText = "Select * From Tour_Days_tbl Order By Tour_Id ASC"

        Dim ad As New SqlDataAdapter(cmd)
        Dim td As New DataTable
        ad.Fill(td)

        dgv_view_tour_days.DataSource = td
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_view_tour_fetch_Click(sender As System.Object, e As System.EventArgs) Handles btn_view_tour_fetch.Click
        connection()

        cmd.Connection = con

        If cobo_view_tour_by.Text = "Tour_Id" Then
            cmd.CommandText = "Select * from Tour_tbl where Tour_Id Like '%" & tb_view_tour.Text & "%'"

        End If
        If cobo_view_tour_by.Text = "Destination" Then
            cmd.CommandText = "Select * from Tour_tbl where Destination Like '%" & tb_view_tour.Text & "%'"
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgv_view_all_tour.DataSource = dt
        cmd.Dispose()

        If cobo_view_tour_by.Text = "Tour_Id" Then
            cmd.CommandText = "Select * from Tour_Days_tbl where Tour_Id Like '%" & tb_view_tour.Text & "%' "
        End If
        If cobo_view_tour_by.Text = "Destination" Then
            cmd.CommandText = "Select * from Tour_Days_tbl where Tour_Id=" & dgv_view_all_tour.Rows(0).Cells(0).Value & " "
        End If

        Dim ad As New SqlDataAdapter(cmd)
        Dim td As New DataTable
        ad.Fill(td)

        dgv_view_tour_days.DataSource = td
        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub btn_refresh_Click(sender As System.Object, e As System.EventArgs) Handles btn_refresh.Click
        connection()
        cmd.Connection = con

        cmd.CommandText = "Select * From Tour_tbl Order By Tour_Id ASC"

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        dgv_view_all_tour.DataSource = dt
        cmd.Dispose()

        cmd.CommandText = "Select * From Tour_Days_tbl Order By Tour_Id ASC"

        Dim ad As New SqlDataAdapter(cmd)
        Dim td As New DataTable
        ad.Fill(td)

        dgv_view_tour_days.DataSource = td
        cmd.Dispose()
        con.Close()
    End Sub
End Class