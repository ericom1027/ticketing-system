Imports System.Data.SqlClient
Imports MetroFramework
Public Class frm_ticketing
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        mdi_main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim strState As String = String.Empty
        Dim updateClass As PrcessClass = New PrcessClass

        strState = updateClass.UpdateEmployeeRequest(txttsno.Text, cbo_Status.SelectedValue, cbotech.SelectedValue, Convert.ToDateTime(dtDateCompleted.Text))


        If (strState = "true") Then

            MetroMessageBox.Show(Me, "Record Updated.", "Updated Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshListView1()
            cleartextfields()
        Else

            MetroMessageBox.Show(Me, "Record Not Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cleartextfields()
        End If


    End Sub

    Private Sub RefreshListView1()

        Dim getUerRequest As PrcessClass = New PrcessClass

        dgAdminUserRequest.DataSource = getUerRequest.GetUserRequest("SP_GetUSerRequest")
        dgAdminUserRequest.Columns(1).Width = 200
        dgAdminUserRequest.Columns(2).Width = 300
        dgAdminUserRequest.Columns(3).Width = 300
        dgAdminUserRequest.Columns(9).Width = 180

    End Sub

    Private Sub frm_ticketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        txttsno.ReadOnly = True
        txtempname.ReadOnly = True
        txtrequest.ReadOnly = True
        txtremarks.ReadOnly = True
        cbotech.Enabled = False
        cborating.Enabled = False
        cbo_Status.Enabled = False
        RefreshListView1()
        cbo_getstatus()
        dtDateCompleted.MaxDate = Date.Now.ToString
    End Sub

    Private Sub cbo_tech()
        Try

            Using conn As New SqlConnection(connectionstring)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_GetEngr"
                conn.Open()
                cmd.Connection = conn
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                cbotech.DataSource = dt
                cbotech.ValueMember = "techid"
                cbotech.DisplayMember = "techName"
                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbo_getstatus()
        Try

            Using conn As New SqlConnection(connectionstring)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_GetStatus"
                conn.Open()
                cmd.Connection = conn
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                cbo_Status.DataSource = dt
                cbo_Status.ValueMember = "Id"
                cbo_Status.DisplayMember = "Status"

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub dgAdminUserRequest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdminUserRequest.CellClick

        Dim v_SelectedRow As Integer

        v_SelectedRow = dgAdminUserRequest.CurrentCell.RowIndex

        txttsno.Text = dgAdminUserRequest.Item(0, v_SelectedRow).Value

        If (txttsno.Text <> String.Empty) Then

            cbotech.Enabled = True
            cbo_Status.Enabled = True
            cbo_tech()

        Else

            cbotech.Enabled = False
            cbo_Status.Enabled = False
        End If

        txtempname.Text = dgAdminUserRequest.Item(1, v_SelectedRow).Value
        txtrequest.Text = dgAdminUserRequest.Item(2, v_SelectedRow).Value
        txtremarks.Text = dgAdminUserRequest.Item(3, v_SelectedRow).Value
        cbotech.Text = dgAdminUserRequest.Item(9, v_SelectedRow).Value
        cbo_Status.Text = dgAdminUserRequest.Item(6, v_SelectedRow).Value
        dtDateCompleted.Text = dgAdminUserRequest.Item(7, v_SelectedRow).Value.ToString
        btnSave.Enabled = True

    End Sub

    Private Sub cleartextfields()
        txttsno.Clear()
        txtempname.Clear()
        txtrequest.Clear()
        txtremarks.Clear()
        cbotech.Text = String.Empty
        cbo_Status.Text = String.Empty
    End Sub
End Class