
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_Show_Pkgs_to_Customer
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels;Integrated Security=True")
    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Function Add_Usercontrol()
        'Dim count As Integer
        connection()
        'cmd = New SqlCommand("select count(img_id) from Pkg_Images ", con)
        'count = cmd.ExecuteScalar()

        Dim x As Integer = 80
        Dim y As Integer = 90
        Dim cnt As Integer = 1
        Dim dr As SqlDataReader
        Dim ms As New MemoryStream
        Dim cm As New SqlCommand("select pkg_id,pkg_name,pkg_img from pkg_info ", con)

        dr = cm.ExecuteReader()
        While dr.Read()
            Dim objr = New UC_Packages
            objr.Location = New System.Drawing.Point(x, y)

            objr.lbl_Pkg_Name.Text = dr("pkg_name").ToString
            objr.tb_pkg_id.Text = dr("pkg_id").ToString
            objr.pb_Pkg_Img.Image = comon_class.view(dr("pkg_img"))

            panel_view_pkg.Controls.Add(objr)

            x = x + 450
            cnt = cnt + 1

            If cnt > 3 Then
                cnt = 1
                y = y + 350
                x = 80
            End If

        End While
        con.Close()
        Return 0
    End Function
    Private Sub frm_Show_Pkgs_to_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Add_Usercontrol()

    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frm_Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            If tb_Min_Budget.Text <> "" And tb_Min_Budget.Text <> "" Then
                If Val(tb_Min_Budget.Text) <= Val(tb_Max_Budget.Text) Then
                    panel_view_pkg.Controls.Clear()
                    'Dim count As Integer
                    connection()
                    ' cmd = New SqlCommand("select count(img_id) from Pkg_Images ", con)
                    'count = cmd.ExecuteScalar()

                    Dim x As Integer = 80
                    Dim y As Integer = 90
                    Dim cnt As Integer = 1
                    Dim dr As SqlDataReader
                    Dim ms As New MemoryStream
                    Dim cm As New SqlCommand("select pkg_id,pkg_name,pkg_img from pkg_info where  total_pri between " + tb_Min_Budget.Text + " and " + tb_Max_Budget.Text + " ", con)

                    dr = cm.ExecuteReader()
                    While dr.Read()
                        Dim objr = New UC_Packages
                        objr.Location = New System.Drawing.Point(x, y)

                        objr.lbl_Pkg_Name.Text = dr("pkg_name").ToString
                        objr.tb_pkg_id.Text = dr("pkg_id").ToString
                        objr.pb_Pkg_Img.Image = comon_class.view(dr("pkg_img"))

                        panel_view_pkg.Controls.Add(objr)

                        x = x + 450
                        cnt = cnt + 1

                        If cnt > 3 Then
                            cnt = 1
                            y = y + 350
                            x = 80
                        End If

                    End While
                    con.Close()

                Else
                    MsgBox("Please Enter correct budget ", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("Please Enter Budget First", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_All_Pkg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Pkg.Click
        Try
            tb_Max_Budget.Text = ""
            tb_Min_Budget.Text = ""
            panel_view_pkg.Controls.Clear()
            Add_Usercontrol()
        Catch ex As Exception
        End Try
    End Sub
End Class


