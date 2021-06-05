Imports System.Data.SqlClient

Public Class frm_View_Single_Package

    Private Sub frm_Show_Package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objd As New pkg_Days_Description
            Comman_Declared.increment_date = objd.dtp_Date.Value.Date

            getconnection()
            Dim dr As SqlDataReader

            cmd = New SqlCommand("Select * from pkg_info where pkg_id = " & Comman_Declared.show_pkg_id & "", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                tb_pkg_id.Text = dr("pkg_id")
                lbl_Pkg_Name.Text = dr("pkg_name").ToString
                lbl_Pkg_Route.Text = dr("route").ToString
                tb_Adult_Price.Text = dr("adult_pri")
                tb_Children_Price.Text = dr("children_pri")
                lbl_Pkg_Day_Night.Text = dr("days_dur").ToString + " " + "Days" + "/" + dr("night_dur").ToString + " " + "Nights"
                tb_Note.Text = dr("note").ToString
                tb_Total_Price.Text = dr("total_pri")
                tb_GST.Text = dr("GST")
                tb_Grand_Total.Text = dr("grand_total")
                tb_tour_guide_name.Text = dr("tour_guide_nm")
                pb_Package_Image.Image = comon_class.view(dr("pkg_img"))
            End If
            dr.Close()
            cmd.Dispose()

            cmd = New SqlCommand("select  tour_start_date from pkg_tours_date where pkg_id = " & Comman_Declared.show_pkg_id & " And tour_start_date > '" & Date.Now.Date & "'", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cb_tour_dates.Items.Add(dr("tour_start_date"))
            End While
            dr.Close()
            cmd.Dispose()
            terminateconnection()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frm_Show_Pkgs_to_Customer.Show()
    End Sub

    Private Sub btn_Add_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Me.Hide()
        'frm_Add_Customer.Show()
    End Sub

    Private Sub lbl_Grand_Total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Grand_Total.Click

    End Sub

    Private Sub btb_Show_Iternary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btb_Show_Iternary.Click
        Try
            If cb_tour_dates.SelectedIndex <> -1 Then

                frm_Days_Description.btn_Back.Enabled = True
                frm_Days_Description.btn_Edit_days.Hide()
                frm_Days_Description.Show()
                getconnection()
                Dim dat As Integer = 1
                Dim x As Integer = 50
                Dim y As Integer = 100
                Dim dr As SqlDataReader
                cmd = New SqlCommand("select * from pkg_days_descri where pkg_id = " & Comman_Declared.show_pkg_id & "", con)
                dr = cmd.ExecuteReader()


                While dr.Read()
                    Dim obj = New pkg_Days_Description
                    obj.Location = New System.Drawing.Point(x, y)
                    frm_Days_Description.Controls.Add(obj)
                    obj.Enabled = False

                    If Comman_Declared.increment_date < cb_tour_dates.SelectedItem Then
                        obj.dtp_Date.Value = cb_tour_dates.SelectedItem
                        Comman_Declared.increment_date = cb_tour_dates.SelectedItem
                    Else
                        Comman_Declared.increment_date = Comman_Declared.increment_date.AddDays(1)
                        obj.dtp_Date.Value = Comman_Declared.increment_date
                    End If
                    obj.lbl_Days_no.Text = dr("tour_day_no").ToString
                    obj.tb_Place.Text = dr("day_place").ToString
                    obj.tb_L_Name.Text = dr("day_lh_name").ToString
                    obj.tb_L_Place.Text = dr("day_lh_place").ToString
                    obj.tb_D_Name.Text = dr("day_dh_name").ToString
                    obj.tb_D_Place.Text = dr("day_dh_place").ToString
                    obj.tb_Days_Descri.Text = dr("day_description").ToString

                    x = x + 1357
                    y = y + 375
                    x = 50

                End While
                cmd.Dispose()
                dr.Close()
                terminateconnection()

                Comman_Declared.verifying_forms = 2
                Comman_Declared.increment_date = Nothing
            Else
                MsgBox("Please Select Tour Date First...!", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Try
            ' Comman_Declared.show_pkg_id 
            Me.Close()
            frm_Days_Description.Close()
            frm_Show_Pkgs_to_Customer.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Book.Click
        Try
            If cb_tour_dates.SelectedIndex <> -1 Then
                If Comman_Declared.cust_verifying_form = 2 Then
                    frm_Show_Pkgs_to_Customer.Hide()
                    Me.Hide()
                    Comman_Declared.show_pkg_id = tb_pkg_id.Text
                    frm_Update_Customer.Show()
                Else
                    Comman_Declared.show_pkg_id = tb_pkg_id.Text
                    Me.Hide()
                    frm_Add_Customer.Show()
                End If

            Else
                MsgBox("Please Select Tour Date First...!", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class