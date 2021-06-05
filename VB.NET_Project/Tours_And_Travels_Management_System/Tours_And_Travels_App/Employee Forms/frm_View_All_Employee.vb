Imports System.Data.SqlClient

Public Class frm_View_All_Employee

    Private Sub btn_All_Employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Employee.Click
        Try
            getconnection()
            dgv_Show_Emp_Data.Refresh()
            cmd = New SqlCommand("select * from Emp_Info", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgv_Show_Emp_Data.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_Emp_id.Text <> "" Then
                getconnection()
                dgv_Show_Emp_Data.Refresh()
                cmd = New SqlCommand("select * from Emp_Info where emp_id = " & tb_Emp_id.Text & "", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                da.Fill(dt)
                dgv_Show_Emp_Data.DataSource = dt
                cmd.Dispose()
                con.Close()
            Else
                MsgBox("Please Enter Employee ID First...", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_View_All_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Emp_id.Focus()
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Hide()
        frm_Owner.Show()
    End Sub
End Class