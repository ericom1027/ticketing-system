Imports System.Data.SqlClient
Imports MetroFramework
Public Class Add_user
    Dim str_DelUser As String = String.Empty
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        mdi_main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_user.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert Username")
            Exit Sub
        ElseIf txt_pass.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert Name")
            Exit Sub
        ElseIf cbo_userlvl.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert User Level")
            Exit Sub
        End If

        Dim strState As String = String.Empty
        Dim saveAddUser As PrcessClass = New PrcessClass

        Dim strValue As String = String.Empty

        strValue = saveAddUser.CheckUsername(txt_user.Text)

        If (strValue = "1") Then

            MetroMessageBox.Show(Me, "Username already exists!", "Change Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_user.Focus()
            CleartxtFields()

        Else

            strState = saveAddUser.SaveUserlogin(txt_user.Text, txt_pass.Text, CInt(cbo_userlvl.SelectedValue))

            If (strState = "true") Then

                MetroMessageBox.Show(Me, "Record Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshUserDGrid()
                CleartxtFields()
            Else

                MetroMessageBox.Show(Me, "Record Not Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RefreshUserDGrid()
                CleartxtFields()
            End If

        End If
    End Sub
    Private Sub RefreshUserDGrid()
        Dim SaveUserlogin As PrcessClass = New PrcessClass
        dgAddUser.DataSource = SaveUserlogin.GetUserLog("SP_GetUserLogin")
    End Sub
    Private Sub Add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUserDGrid()
        cbo_ulvl()
        Me.dgAddUser.Columns("id").Visible = False
    End Sub
    Private Sub cbo_ulvl()
        Try

            cbo_userlvl.Items.Insert(0, "-Select-")
            cbo_userlvl.SelectedIndex = 0
            Using conn As New SqlConnection(connectionstring)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_GetAddUserLevel"
                conn.Open()
                cmd.Connection = conn
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                cbo_userlvl.DataSource = dt
                cbo_userlvl.ValueMember = "id"
                cbo_userlvl.DisplayMember = "Ulevel"
                conn.Close()

            End Using
        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try

    End Sub
    Private Sub CleartxtFields()
        txt_user.Clear()
        txt_pass.Clear()
        cbo_userlvl.SelectedIndex = 1
        cbo_userlvl.Text = String.Empty
    End Sub

    Private Sub btndeleteUser_Click(sender As Object, e As EventArgs) Handles btndeleteUser.Click
        If (str_DelUser = String.Empty) Then

            MessageBox.Show("No records to delete", "Delete Information", MessageBoxButtons.OK)
        Else

            Dim res As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo)

            If (res = DialogResult.Yes) Then
                Dim strdel As String = String.Empty
                Dim Del_User As PrcessClass = New PrcessClass

                strdel = Del_User.SP_DeleteUser("SP_DeleteUser", str_DelUser)

                If (strdel = "true") Then

                    MetroMessageBox.Show(Me, "Technician deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleartxtFields()
                    RefreshUserDGrid()
                Else

                    MetroMessageBox.Show(Me, "Record Not delete.", "Deleted Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        End If
    End Sub

    Private Sub dgAddUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAddUser.CellClick
        Dim v_userRow As Integer
        v_userRow = dgAddUser.CurrentRow.Index
        str_DelUser = dgAddUser.Item(0, v_userRow).Value
        txt_user.Text = dgAddUser.Item(1, v_userRow).Value
        txt_pass.Text = dgAddUser.Item(2, v_userRow).Value
        cbo_userlvl.Text = dgAddUser.Item(3, v_userRow).Value
    End Sub
End Class