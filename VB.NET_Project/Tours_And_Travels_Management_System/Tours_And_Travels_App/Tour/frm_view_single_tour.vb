'Imports System.Data.SqlClient

'Public Class frm_view_single_tour
'    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels_DB;Integrated Security=True")
'    Dim cmnd As New SqlCommand
'    Function connection()
'        If con.State = ConnectionState.Closed Then
'            con.Open()
'        End If
'        Return 0
'    End Function
'    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
'        Me.Hide()
'        frm_show_tour.Show()
'    End Sub

'    Private Sub frm_view_single_tour_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
'        Me.WindowState = FormWindowState.Maximized
'        connection()
'        Dim dr As SqlDataReader
'        cmnd.Connection = con

'        ''' cmnd.CommandText = "Select * from Tour_tbl where Tour_Id=" & Common_variables.tour_id & ""
'        dr = cmnd.ExecuteReader()
'        While dr.Read()
'            tb_source.Text = dr("Source").ToString
'            tb_destin.Text = dr("Destination").ToString
'            dtp_departure_time.Text = dr("Depart_time").ToString
'            dtp_arrival_time.Text = dr("Arrive_time").ToString
'            tb_distance.Text = dr("Distance").ToString
'            tb_route.Text = dr("Route").ToString
'            tb_type_travels.Text = dr("Mode").ToString
'            tb_adl_price.Text = dr("Adult_price").ToString
'            tb_child_price.Text = dr("Child_price").ToString
'            tb_total_price.Text = dr("Total").ToString
'        End While
'        dr.Close()
'        cmnd.Dispose()
'        lb_Travelling_days.Items.Clear()
'        '''   cmnd.CommandText = "Select * from Tour_Days_tbl where Tour_Id=" & Common_variables.tour_id & ""
'        dr = cmnd.ExecuteReader()
'        While dr.Read()
'            tb_travel_nm.Text = dr("Travels_Name").ToString
'            Dim str As String = dr("Selected_Days").ToString
'            lb_Travelling_days.Items.Add(str)
'            lb_Travelling_days.ValueMember = dr(0)
'        End While
'        dr.Close()
'        cmnd.Dispose()
'    End Sub

'    Private Sub frm_view_single_tour_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class