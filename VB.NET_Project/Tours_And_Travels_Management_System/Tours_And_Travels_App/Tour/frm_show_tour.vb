Imports System.Data.SqlClient

Public Class frm_show_tour
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels_DB;Integrated Security=True")
    Dim cmd As New SqlCommand

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
  
    End Function

    Private Sub btn_fetch_Click(sender As System.Object, e As System.EventArgs) Handles btn_fetch.Click
        If tb_destin.Text <> "" Then
            pnl_tour.Controls.Clear()

            connection()
            ' Common_variables.tour_nm = tb_destin.Text

            Dim x As Integer = 30
            Dim y As Integer = 50
            Dim cnt As Integer = 1
            Dim dr As SqlDataReader
            cmd.Connection = con
            '' cmd.CommandText = "Select Tour_Id,Source,Destination From Tour_tbl where Destination='" & Common_variables.tour_nm & "' "

            dr = cmd.ExecuteReader()

            'While dr.Read()
            '    '     Dim obj = New uc_Tour_details
            '    obj.Location = New System.Drawing.Point(x, y)
            '    obj.tb_tour_id.Text = dr("Tour_Id").ToString
            '    obj.tb_source.Text = dr("Source").ToString
            '    obj.tb_destin.Text = dr("Destination").ToString

            '    pnl_tour.Controls.Add(obj)

            '    x = x + 357
            '    cnt = cnt + 1
            '    If cnt > 4 Then
            '        cnt = 1
            '        y = y + 300
            '        x = 30
            '    End If

            'End While
            dr.Close()
            con.Close()
        End If

    End Sub
End Class