Imports System.Data.SqlClient

Public Class frm_Usermanagement



    Private Sub btn_Package_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Show_Pkgs_to_Customer.MdiParent = Me
        frm_Show_Pkgs_to_Customer.WindowState = FormWindowState.Maximized
        frm_Show_Pkgs_to_Customer.Show()
    End Sub

    Private Sub frm_Receptionist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        panel_new_un_pas.Hide()
        getconnection()
        tb_lg_id.Text = Auto_Increment("select count(lg_id) from Login", 1)
        terminateconnection()
    End Sub


    Private Sub btn_view_package_to_cus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Show_Pkgs_to_Customer.Show()
        Me.Hide()
    End Sub

    Private Sub btn_View_All_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_View_All_Package.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Add_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Add_Customer.Show()
        Me.Hide()
    End Sub

    Private Sub btn_View_All_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_View_All_Customer_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dddd, dd MMMM yyyy")
        lblZone.Text = TimeZone.CurrentTimeZone.StandardName
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        If tb_Username.Text <> "" And tb_Password.Text <> "" Then
            getconnection()
            cmd = New SqlCommand("select * from Login where username = '" & tb_Username.Text & "' and password = '" & tb_Password.Text & "'", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                tb_Usertype.Text = dr("usertype")
                tb_lg_id.Text = dr("lg_id")

                dr.Close()
                cmd.Dispose()
            Else
                MsgBox("Please enter correct Username and Password", MsgBoxStyle.OkOnly)
                Return
            End If

            panel_new_un_pas.Show()
            cb_usertype.Enabled = False
            btn_Save.Enabled = False
            cb_usertype.SelectedIndex = -1
            tb_new_un.Text = tb_Username.Text
            tb_new_pass.Text = tb_Password.Text

        Else
            MsgBox("First Fill All Field", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Function clear()
        tb_Password.Text = ""
        tb_Username.Text = ""
        tb_new_pass.Text = ""
        tb_new_un.Text = ""
        tb_Usertype.Text = ""
        tb_lg_id.Text = ""
        cb_usertype.SelectedIndex = -1
        panel_new_un_pas.Hide()
        btn_Save.Enabled = True
        cb_usertype.Enabled = True
        getconnection()
        tb_lg_id.Text = Auto_Increment("select count(lg_id) from Login", 1)
        terminateconnection()
        Return 0
    End Function
    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If tb_Password.Text <> "" And tb_Username.Text <> "" And cb_usertype.SelectedIndex <> -1 Then
            getconnection()
            cmd = New SqlCommand("select * from Login where username like '%" & tb_Username.Text & "%' or password like '%" & tb_Password.Text & "%' ", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MsgBox("please Enter another username and password", MsgBoxStyle.OkOnly)
                dr.Close()
                cmd.Dispose()
            Else
                dr.Close()
                cmd.Dispose()
                cmd = New SqlCommand("insert into Login values(" & tb_lg_id.Text & ",'" & tb_Username.Text & "','" & tb_Password.Text & "','" & cb_usertype.Text & "')", con)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Record Saved Successfully..", MsgBoxStyle.OkOnly)
                    clear()
                Else
                    MsgBox("Record are Not Saved Successfully..", MsgBoxStyle.OkOnly)
                End If
            End If
        Else
            MsgBox("first fill all fields", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        If tb_Password.Text <> "" And tb_Username.Text <> "" Then
            If tb_new_pass.Text <> "" And tb_new_un.Text <> "" Then
                getconnection()
                cmd = New SqlCommand("Update Login set username = '" & tb_new_un.Text & "', password = '" & tb_new_pass.Text & "' where lg_id = " & tb_lg_id.Text & "", con)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Record Updated successfully..", MsgBoxStyle.OkOnly)
                    cmd.Dispose()
                    clear()
                Else
                    MsgBox("Record Not Updated successfully..", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please first fill all fields", MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("please enter Previous Username And Password First", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
        frm_Owner.Show()
    End Sub
End Class