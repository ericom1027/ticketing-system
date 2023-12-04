Imports System.Data.SqlClient
Imports MetroFramework
Imports System.Data
Public Class AddTechnicianFrm
    Dim strTechNo As String = String.Empty
    Private Sub RefreshTechGrid()
        Dim techgrid As PrcessClass = New PrcessClass
        dgGridAddTech.DataSource = techgrid.GetTechnicianGrid("SP_GetTechnicianGrid")
    End Sub

    Private Sub AddTechnicianFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTechGrid()
        Me.dgGridAddTech.Columns("techid").Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        mdi_main.Show()
    End Sub

    Private Sub dgGridAddTech_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGridAddTech.CellContentClick
        Dim v_techgridRow As Integer
        v_techgridRow = dgGridAddTech.CurrentRow.Index
        strTechNo = dgGridAddTech.Item(0, v_techgridRow).Value
        txtTechname.Text = dgGridAddTech.Item(1, v_techgridRow).Value
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If (strTechNo = String.Empty) Then

            MessageBox.Show("No records to delete", "Delete Information", MessageBoxButtons.OK)
        Else

            Dim results As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo)

            If (results = DialogResult.Yes) Then
                Dim strState As String = String.Empty
                Dim DeleteTech As PrcessClass = New PrcessClass

                strState = DeleteTech.SP_DeleteTech("SP_DeleteTech", strTechNo)

                If (strState = "true") Then

                    MetroMessageBox.Show(Me, "Technician deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTechname.Clear()
                    RefreshTechGrid()
                Else

                    MetroMessageBox.Show(Me, "Record Not delete.", "Deleted Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtTechname.Text = Nothing Then
            MetroMessageBox.Show(Me, "Enter Technician Name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim strtech As String = String.Empty
        Dim SaveTechengineer As PrcessClass = New PrcessClass

        Dim strtechCheck As String = String.Empty
        strtechCheck = SaveTechengineer.CheckTechname(txtTechname.Text)

        If strtechCheck = "1" Then

            MetroMessageBox.Show(Me, "Technician Name already exists!", "Change Technician Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RefreshTechGrid()
            txtTechname.Clear()
        Else
            strtech = SaveTechengineer.SaveTechnician(txtTechname.Text)
            If (strtech = "true") Then
                MetroMessageBox.Show(Me, "Record Save.", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshTechGrid()
                txtTechname.Clear()
            Else

                MetroMessageBox.Show(Me, "Record not Save", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshTechGrid()
                txtTechname.Clear()
            End If
        End If
    End Sub
End Class