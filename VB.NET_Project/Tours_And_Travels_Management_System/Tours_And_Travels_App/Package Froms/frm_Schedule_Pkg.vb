Imports System.Data.SqlClient

Public Class frm_Schedule_Pkg
    Private Sub frm_Schedule_Pkg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getconnection()
        Dim x As Integer = 5
        Dim y As Integer = 10
        Dim dr As SqlDataReader

        cmd = New SqlCommand("select pkg_name from pkg_info where expiry_date < '" & Date.Now.Date & "'", con)
       
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim obj = New UC_Schedule_Pkg
            obj.Location = New System.Drawing.Point(x, y)
            panel_Out_dated_Package.Controls.Add(obj)

            obj.btn_pkg_name.Text = dr("pkg_name")

            y = y + 50
            x = 5
        End While
        dr.Close()
        cmd.Dispose()

        '=============================================================================================================================

        Dim p As Integer = 5
        Dim q As Integer = 10
        Dim dat As Date
        Dim name As Byte = True
        Dim pkg_nm As String = Nothing
        Dim d As SqlDataReader
        cmd = New SqlCommand("select * from pkg_info full join pkg_tours_date on pkg_info.pkg_id=pkg_tours_date.pkg_id", con)

        d = cmd.ExecuteReader()
        While d.Read()
                dat = d("tour_end_date")
                If pkg_nm = d("pkg_name") Then
                Continue While
                End If
                If dat < Today.Date Then
                    Dim obj = New UC_Schedule_Pkg
                    obj.Location = New System.Drawing.Point(p, q)
                    panel_out_dated_tours.Controls.Add(obj)
                    obj.btn_pkg_name.Text = d("pkg_name")
                    q = q + 50
                    p = 5
                    pkg_nm = d("pkg_name")
                End If
        End While
        d.Close()
        cmd.Dispose()
    End Sub

    Private Sub cb_tour_dates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tour_dates.SelectedIndexChanged
        dtp_chg_start_date.Value = cb_tour_dates.SelectedItem
    End Sub

    Private Sub dtp_chg_start_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_chg_start_date.ValueChanged
        Dim c_day As Integer = Val(tb_Days.Text) - 1
        dtp_chg_expiry_date.Value = dtp_chg_start_date.Value.AddDays(c_day)
        c_day = 0
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
        frm_Owner.Show()
    End Sub
End Class