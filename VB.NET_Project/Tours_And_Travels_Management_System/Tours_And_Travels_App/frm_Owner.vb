
Public Class frm_Owner

    Private Sub frm_Owner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        panel_stable.Show()
        panel_Customer.Hide()
        panel_Bill.Hide()
        panel_Employee.Hide()
        panel_Package.Hide()
        panel_Report.Hide()

        If Comman_Declared.identify = "Receptionist" Then
            lbl_Username.Text = "Receptionist"
            rs_userimg.BackgroundImage = Tours_And_Travels_App.My.Resources.Receptionist_Icon_128
            btn_Emp.Hide()
            btn_Bill.Hide()
            btn_Repor.Hide()
            panel_Bill.Hide()
            panel_Employee.Hide()
            btn_Create_package.Hide()
            btn_Update_package.Hide()
            btn_Delete_package.Hide()
            btn_Schedule_package.Hide()
            btn_View_All_Pkg.Hide()
            btn_Update_Customer.Hide()
            btn_Delete_Customer.Hide()
            btn_All_Customer.Hide()
            btn_U_M.Hide()
            btn_Repor.Hide()
        ElseIf Comman_Declared.identify = "Cashier" Then
            lbl_Username.Text = "Cashier"
            rs_userimg.BackgroundImage = Tours_And_Travels_App.My.Resources.Administrator_Icon_25671
            btn_Emp.Hide()
            btn_Repor.Hide()
            panel_Employee.Hide()
            btn_Create_package.Hide()
            btn_Update_package.Hide()
            btn_Delete_package.Hide()
            btn_Schedule_package.Hide()
            btn_View_All_Pkg.Hide()
            btn_Add_Customer.Hide()
            btn_Update_Customer.Hide()
            btn_Delete_Customer.Hide()
            btn_All_Customer.Hide()
            btn_U_M.Hide()
            btn_Repor.Hide()
            btn_Add_Customer.Text = "Show Customer"
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dddd, dd MMMM yyyy")
        lblZone.Text = TimeZone.CurrentTimeZone.StandardName
    End Sub
    Private Sub btn_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pkg.Click
        panel_Customer.Hide()
        panel_Bill.Hide()
        panel_Employee.Hide()
        panel_Report.Hide()
        panel_Package.Show()
    End Sub

    Private Sub btn_Emp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Emp.Click
        panel_Customer.Hide()
        panel_Bill.Hide()
        panel_Report.Hide()
        panel_Package.Show()
        panel_Employee.Show()
    End Sub

    Private Sub btn_Cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cust.Click
        panel_Employee.Hide()
        panel_Bill.Hide()
        panel_Package.Hide()
        panel_Report.Hide()
        panel_Customer.Show()
    End Sub

    Private Sub btn_Repor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Repor.Click
        panel_Customer.Hide()
        panel_Employee.Hide()
        panel_Bill.Hide()
        panel_Employee.Hide()
        panel_Package.Hide()
        panel_Report.Show()
    End Sub

    Private Sub btn_Bill_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bill.Click
        panel_Customer.Show()
        panel_Employee.Hide()
        panel_Package.Hide()
        panel_Bill.Show()
        panel_Report.Hide()
    End Sub
    Private Sub btn_Create_package_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create_package.Click
        Me.Hide()
        frm_Create_Packages.Show()
    End Sub
    Private Sub btn_Update_package_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_package.Click
        Me.Hide()
        frm_Update_Package.Show()
    End Sub

    Private Sub btn_Schedule_package_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Schedule_package.Click
        Me.Hide()
        frm_Schedule_Pkg.Show()
    End Sub

    Private Sub btn_view_package_to_cus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_package_to_cus.Click
        Me.Hide()
        frm_Show_Pkgs_to_Customer.Show()
    End Sub

    Private Sub btn_View_All_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_All_Pkg.Click
        frm_View_All_Package.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Delete_package_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_package.Click
        frm_Delete_Package.Show()
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

    Private Sub btn_Bill_Cust_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Comman_Declared.pay_verifying_form = 1
        Me.Hide()
        frm_Payment.Show()
    End Sub
    Private Sub btn_Add_Customer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Customer.Click
        Me.Hide()
        frm_Add_Customer.Show()
    End Sub

    Private Sub btn_Update_Customer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Customer.Click
        Me.Hide()
        frm_Update_Customer.Show()
    End Sub

    Private Sub btn_Delete_Customer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Customer.Click
        Me.Hide()
        frm_Delete_Customer.Show()
    End Sub

    Private Sub btn_All_Customer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Customer.Click
        Me.Hide()
        frm_View_All_Customer_Details.Show()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        If MsgBox("Are You sure Want to Logout", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            Me.Close()
            frm_Login.Show()
        End If
    End Sub

    Private Sub btn_show_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frm_View_single_Customer_Details.Show()
    End Sub

    Private Sub btn_Show_Cust_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show_Cust.Click
        Me.Hide()
        frm_View_single_Customer_Details.Show()
    End Sub

    Private Sub btn_Bill_Cust_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bill_Cust.Click
        Me.Hide()
        frm_Payment.Show()
        Comman_Declared.pay_verifying_form = 1
    End Sub

    Private Sub btn_U_M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_U_M.Click
        Me.Hide()
        frm_Usermanagement.Show()
    End Sub

    Private Sub btn_Booking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Booking.Click
        Me.Hide()
        frm_booking.Show()
    End Sub

    Private Sub btn_date_wise_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_date_wise_cust.Click
        Report_frm_datewise_customer.Show()
    End Sub

    Private Sub btn_Single_day_calculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Single_day_calculation.Click
        Report_frm_Single_Day_calcuation.Show()
    End Sub

    Private Sub btn_Pkg_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pkg_Report.Click
        Report_frm_Single_Package_Report.Show()
    End Sub

    Private Sub btn_Tour_Dates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tour_Dates.Click
        Report_frm_Tour_Dates_Cust.Show()
    End Sub
End Class