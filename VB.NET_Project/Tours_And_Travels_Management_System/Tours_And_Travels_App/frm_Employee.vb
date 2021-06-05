Public Class frm_Employee

    Private Sub frm_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        frm_Login.Show()
        Me.Hide()
    End Sub
    Private Sub btn_Add_Employee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Employee.Click
        frm_Add_Employee.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Update_Employee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Employee.Click
        frm_Update_Employee.Show()
        Me.Hide()
    End Sub

    Private Sub btn_view_all_employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_all_employee.Click
        frm_View_All_Employee.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Delete_Employee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Employee.Click
        frm_Delete_Employee.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dddd, dd MMMM yyyy")
        lblZone.Text = TimeZone.CurrentTimeZone.StandardName
    End Sub
End Class