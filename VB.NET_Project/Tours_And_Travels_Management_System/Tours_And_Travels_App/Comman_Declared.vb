Public Class Comman_Declared
    Public Shared temp_table_pkg_id As Integer = 0

    Public Shared co_days As Integer = 0

    Public Shared co_passenger As Integer = 0

    Public Shared pkg_imgid As Integer = 0

    Public Shared pkg_tour_dates As Integer = 0

    Public Shared c_day_id As Integer = 0

    Public Shared c_tours_date_id As Integer = 0

    Public Shared c_traveller_id As Integer = 0

    Public Shared back_button As Integer = 1

    Public Shared done_date_button As Integer = 1

    Public Shared show_pkg_id As Integer = 0

    Public Shared increment_date As Date = Nothing

    Public Shared verifying_forms As Integer = 0

    Public Shared c_days_dur As Integer = 0

    Public Shared cs_day_id As Integer = 0

    Public Shared cust_verifying_form As Integer = 0

    Public Shared add_traveller_verifying_form As Integer = 0

    Public Shared pay_verifying_form As Integer = 0

    Public Shared identify As String = Nothing


#Region "Scheduling Variables"
    Public Shared sc_pkg_id As Integer = 0
    Public Shared sc_pkg_name As String = Nothing
#End Region

#Region "Package days description common variables"
    Public Shared c_pkg_id As String = Nothing
    Public Shared c_day_no As String = Nothing
    Public Shared c_place As String = Nothing
    Public Shared l_hotel_name As String = Nothing
    Public Shared l_hotel_place As String = Nothing
    Public Shared d_hotel_name As String = Nothing
    Public Shared d_hotel_place As String = Nothing
    Public Shared c_description As String = Nothing
#End Region


#Region "Tours Days Commaon Variables"
    Public Shared c_tour_dt_id As Integer = 0
    Public Shared c_start_date As String = 0
    Public Shared c_end_date As String = 0
#End Region

    Public Shared Sub days_descri(ByVal day_no As String, ByVal place As String, ByVal l_hotel_nm As String, ByVal l_hotel_pl As String, ByVal d_hotel_nm As String, ByVal d_hotel_pl As String, ByVal c_descri As String, ByVal c_tod As String)

        c_day_no = day_no
        c_place = place
        l_hotel_name = l_hotel_nm
        l_hotel_place = l_hotel_pl
        d_hotel_name = d_hotel_nm
        d_hotel_place = d_hotel_pl
        c_description = c_descri


    End Sub
End Class
