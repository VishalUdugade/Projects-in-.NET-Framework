Imports System.Data.SqlClient

Public Class UC_Packages
    ' Public Property PIC() As PictureBox
    '    Get
    '       Return pb_Pkg_Img
    '  End Get
    ' Set(ByVal value As PictureBox)
    '    pb_Pkg_Img.Image = value.Image
    'End Set
    'End Property

    Private Sub pb_Pkg_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Pkg_Img.Click

    End Sub

    Private Sub btn_pkg_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pkg_view.Click
        Comman_Declared.show_pkg_id = tb_pkg_id.Text
        frm_View_Single_Package.Show()
    End Sub
End Class
