Imports System.Data.SqlClient

Module Auto_Increm_Module

    Public cnt As Integer = 0
    ' Public start_no As Integer

    Function Auto_Increment(ByVal get_current_id As String, ByVal start_no As Integer)

        getconnection()
        cmd = New SqlCommand(get_current_id, con)

        cnt = cmd.ExecuteScalar()
        cnt = cnt + start_no
        '  End With
        ' terminateconnection()
        Return cnt

    End Function
End Module
