Imports System.Windows.Forms

Public Class mdi_main

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripNew.Click
        UserForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripAdmin.Click
        frm_ticketing.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripAdduser.Click
        Add_user.Show()
    End Sub

    Private Sub ulvl()
        If gUsrLvl = "3" Then
            ToolStripAdmin.Visible = False
            ToolStripAdduser.Visible = False
            ToolStripPrint.Visible = False
            AddTechnicianToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub mdi_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ulvl()
    End Sub

    Private Sub ToolStripPrint_Click(sender As Object, e As EventArgs) Handles ToolStripPrint.Click
        PrintReport.Show()
    End Sub

    Private Sub AddTechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTechnicianToolStripMenuItem.Click
        AddTechnicianFrm.Show()
    End Sub

    Private Sub lblTimer_Tick(sender As Object, e As EventArgs) Handles lblTimer.Tick
        Dim getTotalInProcess As New PrcessClass
        btnCount.Text = getTotalInProcess.GetstrTotal().ToString()
        If Val(btnCount.Text) > 0 Then
            btnCount.BackColor = Color.Red
        Else
            btnCount.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnblink_Tick(sender As Object, e As EventArgs) Handles btnblink.Tick
        Dim r As Integer = 255
        r = r - 1
        If r = 0 Then r = 255
        btnCount.Text = ""
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        btnblink.Start()
    End Sub
End Class
