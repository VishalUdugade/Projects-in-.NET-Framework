Public Class frm_Cashier

    Private Sub frm_Cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dddd, dd MMMM yyyy")
        lblZone.Text = TimeZone.CurrentTimeZone.StandardName
    End Sub
End Class