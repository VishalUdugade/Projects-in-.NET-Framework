
Imports System.Data.SqlClient
Imports System.IO
Public Class comon_class
    Public Shared Sub brows(ByRef search As Image)
        Dim obj As New OpenFileDialog
        obj.Filter = "Choose Images(*.JPG;*.PNG;*GIF;*JPEG)|*.jpg;*.png;*gif;*jpeg"
        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
            search = Image.FromFile(obj.FileName)
        End If
    End Sub
    Public Shared Sub insert(ByRef pht As Image, ByVal id As Integer)
        Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Tours_And_Travels;Integrated Security=True")
        Dim command As New SqlCommand("insert into Table_Images(id,the_image)values(@id,@img)", connection)
        Dim ms As New MemoryStream
        pht.Save(ms, pht.RawFormat)
        command.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
        command.Parameters.Add("@id", SqlDbType.Int).Value = id
        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("record save")
        Else
            MessageBox.Show("record  not save")
        End If
    End Sub
    Public Shared Function view(ByVal img As Byte())
        Using ms As New MemoryStream(img)
            Return Image.FromStream(ms)
        End Using

    End Function

End Class



