Imports System.Data.SqlClient

Public Class frm_add_tour
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels_DB;Integrated Security=True")
    Dim cmnd As New SqlCommand
    Dim mode As String

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Function clear_data()
        rb_sleeper_travel.Checked = False
        rb_non_sleeper_travel.Checked = False
        tb_source.Text = ""
        tb_destin.Text = ""
        dtp_arrival_time.Text = ""
        dtp_departure_time.Text = ""
        tb_distance.Text = ""
        tb_route.Text = ""
        tb_adl_price.Text = ""
        tb_child_price.Text = ""
        tb_total_price.Text = ""
        For i As Integer = 0 To clb_travel_days.Items.Count - 1
            clb_travel_days.SetItemChecked(i, False)
        Next
        tb_source.Focus()
        Return 0
    End Function

    Function Increament()
        Dim Cnt As Integer
        connection()

        cmnd.Connection = con
        cmnd.CommandText = "Select count(Tour_Id) From Tour_tbl"

        Cnt = cmnd.ExecuteScalar
        Cnt = Cnt + 101
        cmnd.Dispose()
        Return Cnt
    End Function

    Private Sub frm_add_tour_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tb_tour_id.Text = Increament()
        ''    Common_variables.tour_nm = Val(tb_destin.Text)
    End Sub

    Private Sub btn_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click
        connection()
        Dim cnt As Integer = 0
        Dim days As String
        Dim Str1 As String = Nothing
        cmnd.Connection = con
        If tb_tour_id.Text <> "" And mode <> "" And tb_source.Text <> "" And tb_destin.Text <> "" And tb_distance.Text <> "" And tb_route.Text <> "" And clb_travel_days.Text <> "" And tb_adl_price.Text <> "" And tb_child_price.Text <> "" And tb_total_price.Text <> "" Then

            cmnd.CommandText = "Insert Into Tour_tbl  Values(" & tb_tour_id.Text & ",'" & mode & "','" & tb_source.Text & "','" & tb_destin.Text & "','" & dtp_departure_time.Text & "','" & dtp_arrival_time.Text & "','" & tb_distance.Text & "','" & tb_route.Text & "', " & tb_adl_price.Text & "," & tb_child_price.Text & "," & tb_total_price.Text & ")"
            cmnd.ExecuteNonQuery()
            cmnd.Dispose()
            If clb_travel_days.CheckedItems.Count > 0 Then

                While cnt < clb_travel_days.CheckedItems.Count
                    days = clb_travel_days.CheckedItems(cnt).ToString
                    cmnd.CommandText = "Insert Into Tour_Days_tbl Values(" & tb_tour_id.Text & ",'" & lb_travels_Nm.Text & "','" & days & "')"
                    cmnd.ExecuteNonQuery()
                    cnt = cnt + 1
                End While

            End If

            MessageBox.Show("Tour Is Saved", "Saved", MessageBoxButtons.OKCancel)
            clear_data()
            tb_tour_id.Text = Increament()
        Else
            MessageBox.Show("Please Fill All Content", "Sorry", MessageBoxButtons.RetryCancel)
        End If

    End Sub

    Private Sub tb_adl_price_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tb_total_price.KeyPress, tb_child_price.KeyPress, tb_adl_price.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then

        Else
            e.Handled = True
            MessageBox.Show("Please Enter Price In Numeric Format!!")
        End If

    End Sub

    Private Sub rb_non_sleeper_travel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_non_sleeper_travel.CheckedChanged
        mode = Nothing
        connection()
        cmnd.Connection = con
        Dim dr As SqlDataReader
        If rb_non_sleeper_travel.Checked = True Then
            mode = rb_non_sleeper_travel.Text
            cmnd.CommandText = "Select Sr_No,Travel_Non_Sleeper from Travels_info_tbl"
            dr = cmnd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr("Travel_Non_Sleeper").ToString
                lb_travels_Nm.Items.Add(str)
                lb_travels_Nm.ValueMember = dr(0)
            End While
            dr.Close()
            cmnd.Dispose()
        Else
            lb_travels_Nm.Items.Clear()
        End If
    End Sub
    Private Sub rb_sleeper_travel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_sleeper_travel.CheckedChanged
        mode = Nothing
        connection()
        cmnd.Connection = con
        Dim dr As SqlDataReader

        If rb_sleeper_travel.Checked = True Then
            mode = rb_sleeper_travel.Text
            cmnd.CommandText = "Select Sr_No,Travel_Sleeper_With_AC from Travels_info_tbl"
            dr = cmnd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr("Travel_Sleeper_With_AC").ToString
                lb_travels_Nm.Items.Add(str)
                lb_travels_Nm.ValueMember = dr(0)
            End While
            dr.Close()
            cmnd.Dispose()
        Else
            lb_travels_Nm.Items.Clear()
        End If
    End Sub

    Private Sub tb_child_price_TextChanged(sender As System.Object, e As System.EventArgs) Handles tb_child_price.TextChanged
        Dim adlt As Double
        Dim chil As Double
        If tb_child_price.Text <> "" Then
            If tb_adl_price.Text = "" Then
                adlt = 0
            Else
                adlt = Double.Parse(tb_adl_price.Text)
            End If
            chil = Double.Parse(tb_child_price.Text)
            tb_total_price.Text = adlt + chil
        Else
            tb_total_price.Text = ""
        End If

    End Sub

    Private Sub tb_adl_price_TextChanged(sender As System.Object, e As System.EventArgs) Handles tb_adl_price.TextChanged
        Dim adlt As Double

        If tb_adl_price.Text <> "" Then
            adlt = Double.Parse(tb_adl_price.Text)

            tb_total_price.Text = adlt
        Else
            tb_total_price.Text = ""

        End If
    End Sub
End Class