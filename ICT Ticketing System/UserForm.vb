Imports System.Data.SqlClient
Imports MetroFramework
Imports System.Data
Imports Tulpep.NotificationWindow
Imports System.Drawing

Public Class UserForm
    Dim strTechNo As String = String.Empty

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        mdi_main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtempname.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert Employee Name")
            Exit Sub
        ElseIf txtrequest.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert Request")
            Exit Sub
        ElseIf txtremarks.Text = Nothing Then
            MetroMessageBox.Show(Me, "Insert Remarks")
        End If

        Dim strState As String = String.Empty
        Dim saveUserRequest As PrcessClass = New PrcessClass

        If (strTechNo <> String.Empty) Then

            strState = saveUserRequest.UpdateRatingEmployeeRequest(strTechNo, CInt(cborating.SelectedValue))

            If (strState = "true") Then

                MetroMessageBox.Show(Me, "Record Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshUserListView1()


            Else

                MetroMessageBox.Show(Me, "Record Not Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else

            strState = saveUserRequest.SaveEmployeeRequest("UserRequest", txtempname.Text, txtrequest.Text, txtremarks.Text)

            If (strState = "true") Then

                MetroMessageBox.Show(Me, "Record Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshUserListView1()



            Else

                MetroMessageBox.Show(Me, "Record Not Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        End If


        ClearFields()

    End Sub

    Private Sub dgUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUser.CellClick
        Dim v_SelectedRow As Integer
        Dim strStatus As String = String.Empty
        txtempname.Enabled = False
        txtrequest.Enabled = False
        txtremarks.Enabled = False


        v_SelectedRow = dgUser.CurrentRow.Index

        strStatus = dgUser.Item(5, v_SelectedRow).Value

        If (strStatus = "Pending") Then

            cborating.Enabled = False
        Else

            cborating.Enabled = True

        End If

        strTechNo = dgUser.Item(0, v_SelectedRow).Value
        txtempname.Text = dgUser.Item(1, v_SelectedRow).Value
        txtrequest.Text = dgUser.Item(2, v_SelectedRow).Value
        txtremarks.Text = dgUser.Item(3, v_SelectedRow).Value
        cborating.Text = dgUser.Item(8, v_SelectedRow).Value.ToString
        btnDelete.Enabled = True

    End Sub

    Private Sub RefreshUserListView1()
        Dim GetUserRequest As PrcessClass = New PrcessClass
        dgUser.DataSource = GetUserRequest.GetUserRequest("SP_GetUSerRequest")
        dgUser.Columns(1).Width = 200
        dgUser.Columns(2).Width = 300
        dgUser.Columns(3).Width = 300
        dgUser.Columns(9).Width = 180
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        btnDelete.Enabled = False
        cbo_getRatings()
        RefreshUserListView1()
        cborating.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If (strTechNo = String.Empty) Then

            MessageBox.Show("No records to delete", "Delete Information", MessageBoxButtons.OK)
        Else

            Dim results As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo)

            If (results = DialogResult.Yes) Then
                Dim strState As String = String.Empty
                Dim DeleteClass As PrcessClass = New PrcessClass

                strState = DeleteClass.DeleteEmployeeRequest("SP_DeleteUserRequest", strTechNo)

                If (strState = "true") Then

                    MetroMessageBox.Show(Me, "User Request deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    RefreshUserListView1()
                Else

                    MetroMessageBox.Show(Me, "Record Not delete.", "Deleted Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        strTechNo = String.Empty
        txtempname.Enabled = True
        txtrequest.Enabled = True
        txtremarks.Enabled = True
        cborating.Enabled = False
        cborating.SelectedValue = 1
        btnSave.Enabled = True
        ClearFields()
    End Sub

    Private Sub cbo_getRatings()
        Try

            Using conn As New SqlConnection(connectionstring)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_GetRatings"
                conn.Open()
                cmd.Connection = conn
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                cborating.DataSource = dt
                cborating.ValueMember = "Id"
                cborating.DisplayMember = "rating"

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub ClearFields()
        txtempname.Clear()
        txtrequest.Clear()
        txtremarks.Clear()
        txtempname.Focus()
        strTechNo = String.Empty
    End Sub
End Class