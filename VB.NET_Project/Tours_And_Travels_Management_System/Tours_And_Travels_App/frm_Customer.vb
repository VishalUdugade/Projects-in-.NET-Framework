Public Class frm_Customer

    Private Sub frm_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Add_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Customer.Click
        Me.Hide()
        frm_Show_Pkgs_to_Customer.Show()
    End Sub

    Private Sub btn_view_Single_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Customer.Click
        Me.Hide()
        frm_View_All_Customer_Details.Show()
    End Sub

    Private Sub btn_Update_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Customer.Click
        Me.Hide()
        frm_Update_Customer.Show()
    End Sub

    Private Sub btn_Delete_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Customer.Click
        Me.Hide()
        frm_Delete_Customer.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dddd, dd MMMM yyyy")
        lblZone.Text = TimeZone.CurrentTimeZone.StandardName
    End Sub
End Class