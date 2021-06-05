Imports System.Data.OleDb

Public Class frmMedia

    Private Sub frmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        str = System.AppDomain.CurrentDomain.BaseDirectory
        Startconnection()
        '*******************************************************************for subjects
        Dim cm As New OleDbCommand
        Dim dtr As OleDbDataReader
        cm.Connection = con
        cm.CommandText = "select distinct Subject from Question1"
        dtr = cm.ExecuteReader()
        cmb_subject.Items.Clear()
        While dtr.Read()
            cmb_subject.Items.Add(dtr("Subject"))
        End While
        dtr.Close()

        '********************************************************************for teams
        cm.CommandText = "select team from studinfo"
        dtr = cm.ExecuteReader()
        cmb_team.Items.Clear()
        While dtr.Read()
            cmb_team.Items.Add(dtr("team"))
        End While
        cm.Dispose()
        dtr.Close()
        Endconnection()
    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        AxWindowsMediaPlayer1.URL = "E:\quizmedia2020\" + txtQNumber.Text + ".DAT"
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtQuestion.Text = Show_question(cmb_subject.Text, txtQNumber.Text)
            txtQuestion.Visible = True
            txtQNumber.Enabled = False
            btnAnswer.Enabled = True
            btnShow.Enabled = False
        End If
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        txtQNumber.Text = ""
        If (txtQNumber.Text <> "") Then

        End If
        OvalShape1.BackColor = Color.WhiteSmoke
        txtopa.BackColor = Color.White
        txtopb.BackColor = Color.White
        txtopc.BackColor = Color.White
        txtopd.BackColor = Color.White

        txtopa.ForeColor = Color.Black
        txtopb.ForeColor = Color.Black
        txtopc.ForeColor = Color.Black
        txtopd.ForeColor = Color.Black

        txtQuestion.Text = ""
        txtAnswer.Text = ""
        txtQNumber.Enabled = True
        txtAnswer.Text = ""
        txtQNumber.Text = ""

        cmb_points.Text = ""
        cmb_team.Text = ""
        btnShow.Enabled = True
        btnAnswer.Enabled = False
        hide_optiions()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) - 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) + 1
        End If
    End Sub
    Public Sub show_options()
        txtopa.Visible = True
        txtopb.Visible = True
        txtopc.Visible = True
        txtopd.Visible = True
    End Sub
    Public Sub hide_optiions()
        txtopa.Text = ""
        txtopb.Text = ""
        txtopc.Text = ""
        txtopd.Text = ""
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtopa.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "a")
            txtopb.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "b")
            txtopc.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "c")
            txtopd.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "d")
            txtQNumber.Enabled = False
            btnAnswer.Enabled = True
            btnShow.Enabled = False
            show_options()
            Panel1.Visible = True
        End If
    End Sub

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim answer As String
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtAnswer.Visible = True
            answer = Show_answer(cmb_subject.Text, txtQNumber.Text)
            ''''''''''''''''''''''''''''''''''''''''''''code for right code
            wrong_right_questions(txtopa, answer)
            wrong_right_questions(txtopb, answer)
            wrong_right_questions(txtopc, answer)
            wrong_right_questions(txtopd, answer)
        End If
    End Sub
    Public Sub wrong_right_questions(ByVal obj As Button, ByVal ans As String)
        If obj.BackColor = Color.Orange And obj.Text = ans Then
            obj.BackColor = Color.Green
            txtAnswer.Text = "Correct Answer"
            txtAnswer.ForeColor = Color.Green
        ElseIf obj.BackColor = Color.Orange And obj.Text <> ans Then
            obj.BackColor = Color.Red
            If txtopa.Text = ans Then
                txtopa.BackColor = Color.Green
                txtopa.ForeColor = Color.White
            ElseIf txtopb.Text = ans Then
                txtopb.BackColor = Color.Green
                txtopb.ForeColor = Color.White
            ElseIf txtopc.Text = ans Then
                txtopb.BackColor = Color.Green
                txtopc.ForeColor = Color.White
            ElseIf txtopd.Text = ans Then
                txtopd.BackColor = Color.Green
                txtopd.ForeColor = Color.White
            End If
            txtAnswer.Text = " Wrong Answer"
            txtAnswer.ForeColor = Color.Red
        End If
    End Sub
    Private Sub txtQNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQNumber.TextChanged
        If txtQNumber.Text <> "" Then
            If txtQNumber.Text = 1 Then
                Button3.Enabled = False
            Else
                Button3.Enabled = True
            End If
        End If
    End Sub
    Private Sub txtopa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtopa.ForeColor = Color.White
        txtopa.BackColor = Color.Orange
    End Sub

    Private Sub txtopb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtopb.BackColor = Color.Orange
        txtopb.ForeColor = Color.White
    End Sub

    Private Sub txtopc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtopc.BackColor = Color.Orange
        txtopc.ForeColor = Color.White
    End Sub

    Private Sub txtopd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtopd.BackColor = Color.Orange
        txtopd.ForeColor = Color.White
    End Sub

    Private Sub btn_submit_score_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit_score.Click
        If submit_points(cmb_team.Text, cmb_points.Text) Then
            OvalShape1.BackColor = Color.Green
        Else
            OvalShape1.BackColor = Color.Red
        End If

    End Sub


End Class