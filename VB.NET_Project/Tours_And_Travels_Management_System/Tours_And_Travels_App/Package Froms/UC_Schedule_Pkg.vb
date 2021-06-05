Imports System.Data.SqlClient

Public Class UC_Schedule_Pkg

    Private Sub btn_pkg_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pkg_name.Click
        'Me.Enabled = False
        frm_Schedule_Pkg.cb_tour_dates.Items.Clear()
        Dim pk_id As Integer = 0
        getconnection()
        Dim dr As SqlDataReader

        cmd = New SqlCommand("select pkg_id,pkg_name,days_dur,create_date,expiry_date,per_capacity from pkg_info where pkg_name = '" & btn_pkg_name.Text & "'", con)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            pk_id = dr("pkg_id")
            frm_Schedule_Pkg.lbl_pkg_name.Text = dr("pkg_name")
            frm_Schedule_Pkg.tb_Days.Text = dr("days_dur")
            frm_Schedule_Pkg.dtp_Pkg_Create_Date.Value = dr("create_date").ToString
            frm_Schedule_Pkg.dtp_pkg_Expiry_Date.Value = dr("expiry_date").ToString
            frm_Schedule_Pkg.tb_Persons_Capacity.Text = dr("per_capacity")
        End If
        dr.Close()
        cmd.Dispose()


        cmd = New SqlCommand("select * from pkg_tours_date where pkg_id = " & pk_id & "", con)
        dr = cmd.ExecuteReader()

        While dr.Read()
            If dr("tour_end_date") < Date.Now.Date Then
                frm_Schedule_Pkg.cb_tour_dates.Items.Add(dr("tour_start_date"))
            End If
        End While
        dr.Close()
        cmd.Dispose()
        pk_id = 0
    End Sub
End Class
