Imports System.Data.SqlClient

Module vari_connection_module
    Public Const connstring = "Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels;Integrated Security=True"
    Public con As SqlConnection
    Public cmd As SqlCommand
    ' Public SqlEnter As String
    'Public dbreader As SqlDataReader
    'Public dbadapter As SqlDataAdapter
    'Public dbtable As DataTable
    'Public dbset As DataSet
    'Public dbdt As DataTable


    Public Sub getconnection()
        'create new connection string
        con = New SqlConnection
        con.ConnectionString = connstring
        If con.ConnectionString <> connstring Then

            MsgBox("database connection failed or does not exist...", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")
            Exit Sub

        ElseIf con.State = ConnectionState.Closed Then
            con.Open()
        Else
            MsgBox("Not Connected")
        End If

    End Sub

    Public Sub terminateconnection()

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub
End Module
