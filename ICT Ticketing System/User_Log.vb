Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Drawing

Public Class User_Log
    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        Me.txtpass.Text = Me.txtpass.Text.ToLower
        If e.KeyCode = Keys.Enter Then
            btnlog.PerformClick()
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtuser.Text = Nothing Then
            Warninglbl.Text = "Enter User ID."
            Exit Sub
        ElseIf txtpass.Text = Nothing Then
            Warninglbl.Text = "Enter Password."
            Exit Sub
        End If

        Dim strState As String = String.Empty
        Dim getuLvl As PrcessClass = New PrcessClass

        strState = getuLvl.GetuserLevel(txtuser.Text, txtpass.Text)

        gUsrLvl = strState

        If (strState <> String.Empty) Then


            mdi_main.Show()
            Me.Hide()
            MetroMessageBox.Show(Me, "Login Succesful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MetroMessageBox.Show(Me, "Incorrect Username or Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtuser.Clear()
            txtpass.Clear()
        End If
    End Sub

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        Warninglbl.Text = ""
        txtpass.Clear()
    End Sub
End Class