Imports System.Data.SqlClient
Imports MetroFramework
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class PrintReport
    Private Sub PrintReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshEmployeePrintGrid()
        cbo_getTechDate()
        Cbo_TechDate.Enabled = False
        btnSearch.Enabled = False
        btnSearchSummary.Enabled = False
        btnSummaryPrint.Enabled = False
        btnPrint.Enabled = False
        dtpkFrom.Enabled = False
        dtpkTo.Enabled = False
        dtpkFrom.MaxDate = Now.Date
        dtpkTo.MaxDate = Now.Date
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        mdi_main.Show()
    End Sub
    Private Sub RefreshEmployeePrintGrid()
        Dim EmpRequest As PrcessClass = New PrcessClass
        dgGridPrint.DataSource = EmpRequest.GetEmployeeRequest("SP_GetEmployeeRequest")
        dgGridPrint.Columns(1).Width = 200
        dgGridPrint.Columns(2).Width = 300
        dgGridPrint.Columns(3).Width = 300
        dgGridPrint.Columns(9).Width = 180
    End Sub
    Private Sub cbo_getTechDate()
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_GetEngr"
                conn.Open()
                cmd.Connection = conn
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                Cbo_TechDate.DataSource = dt
                Cbo_TechDate.ValueMember = "techid"
                Cbo_TechDate.DisplayMember = "techName"
                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim EmpRequest As PrcessClass = New PrcessClass
        dgGridPrint.DataSource = EmpRequest.FilterGetEmployeeRequest("SP_FilterGetEmployeeRequest", dtpkFrom.Value.ToShortDateString, dtpkTo.Value.ToShortDateString, Cbo_TechDate.SelectedValue)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim Checker As Boolean = True
        Dim Vn_Arial As BaseFont = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED)
        Dim fontNormal As Font = New Font(Vn_Arial, 9, 0)
        Dim fontNormal2 As Font = New Font(Vn_Arial, 12, 0)
        Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\\"
        Dim WorkingFolder = AppDomain.CurrentDomain.BaseDirectory
        Dim SampleImage = Path.Combine(WorkingFolder, "pic.png")
        Dim Pic = Image.GetInstance(SampleImage)
        Pic.SetAbsolutePosition(80, 760)

        Dim SampleImage1 = Path.Combine(WorkingFolder, "DOT.png")
        Dim Pic1 = Image.GetInstance(SampleImage1)
        Pic1.SetAbsolutePosition(442, 760)

        Try

            Dim FileName As String = folderPath & "Technician.pdf"

            Using stream As New FileStream(FileName, FileMode.Create)

                Dim pdfDoc As New Document(PageSize.A4, 5.0F, 5.0F, 5.0F, 10.0F)
                Dim writer = PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(Pic)
                pdfDoc.Add(Pic1)

                Dim cb As PdfContentByte = writer.DirectContent

                Dim ct As ColumnText = New ColumnText(cb)
                Dim par As New Paragraph(Environment.NewLine)


                fontNormal2 = New Font(Vn_Arial, 12, 0)

                Dim myText2b As Phrase = New Phrase("Department of Tourism ", fontNormal)
                ct.SetSimpleColumn(myText2b, -115, 818, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()
                fontNormal2 = New Font(Vn_Arial, 12, 0)

                Dim myText2 As Phrase = New Phrase("National Parks Development Committee", fontNormal2)
                ct.SetSimpleColumn(myText2, -115, 803, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()

                fontNormal2 = New Font(Vn_Arial, 12, 0)

                Dim myText2a As Phrase = New Phrase("T.M. Kalaw St., Rizal Park, Ermita Manila ", fontNormal)
                ct.SetSimpleColumn(myText2a, -115, 788, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()

                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)


                Dim Par1 As New Paragraph("TECHNICIAN", fontNormal2)
                Par1.SpacingBefore = 10
                Par1.SpacingAfter = 2
                Par1.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(Par1)

                fontNormal2 = New Font(Vn_Arial, 10, 0)

                Par1 = New Paragraph("From : " & dtpkFrom.Value.ToShortDateString & "  To : " & dtpkTo.Value.ToShortDateString, fontNormal2)
                Par1.SpacingBefore = 2
                Par1.SpacingAfter = 2
                Par1.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par1)


                fontNormal2 = New Font(Vn_Arial, 10, 0)

                Par1 = New Paragraph("Name : " & Cbo_TechDate.Text, fontNormal2)
                Par1.SpacingBefore = 2
                Par1.SpacingAfter = 2
                Par1.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par1)

                pdfDoc.Add(par)
                pdfDoc.Add(par)


                Dim intTblWidth() As Integer = {20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20}
                Dim tblcount As Integer = 0
                intTblWidth = {28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28}
                tblcount = 11

                Dim pdfTable As New PdfPTable(tblcount)
                pdfTable.DefaultCell.Padding = 3
                pdfTable.WidthPercentage = 100
                pdfTable.SetWidths(intTblWidth)
                pdfTable.HorizontalAlignment = Element.TITLE
                pdfTable.DefaultCell.BorderWidth = 0
                pdfTable.DefaultCell.FixedHeight = 18

                fontNormal2 = New Font(Vn_Arial, 8, 1)

                Dim cell As New PdfPCell

                cell = New PdfPCell(New Phrase("Ticket no", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Employee Name", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Remarks", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Date Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Time Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Status", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Date Completed", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Time Completed", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Tech Engineer", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Rating", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)


                fontNormal2 = New Font(Vn_Arial, 6, 0)

                For Each row As DataGridViewRow In dgGridPrint.Rows

                    pdfTable.AddCell(New Phrase(row.Cells(0).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(1).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(2).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(3).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(4).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(5).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(6).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(7).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(8).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(9).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(10).Value.ToString, fontNormal2))

                Next

                pdfDoc.Add(pdfTable)


                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)




                Dim Par7 As New Paragraph("                                             Requested by:                                                                       Approved by:", fontNormal)
                Par7.SpacingBefore = 10
                Par7.SpacingAfter = 2
                Par7.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par7)

                Dim Par2 As New Paragraph("                                                                              ________________________                                                      ____________________________", fontNormal2)
                Par2.SpacingBefore = 10
                Par2.SpacingAfter = 2
                Par2.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par2)

                Dim Par3 As New Paragraph("                                                   Signature                                                                 Section Head/Division Chief  ", fontNormal)
                Par3.SpacingBefore = 0
                Par3.SpacingAfter = 2
                Par3.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par3)

                pdfDoc.NewPage()
                pdfDoc.Close()
                stream.Close()

            End Using

            Process.Start(FileName)
            Checker = True

        Catch ex As Exception
            Checker = False
        End Try

        If Checker = False Then

            MsgBox("PDF file is in use, please close the file then try again")

        End If
        ChkPerTechDisable()
        btnPrint.Enabled = False
        checkTech.CheckState = 0
    End Sub

    Private Sub checkTech_CheckedChanged(sender As Object, e As EventArgs) Handles checkTech.CheckedChanged
        ChkPerTech()
    End Sub

    Private Sub ChkPerTech()
        If checkTech.Checked = True Then
            btnSearch.Enabled = True
            btnSearchSummary.Visible = False
            btnSummaryPrint.Visible = False
            Cbo_TechDate.Enabled = True
            dtpkFrom.Enabled = True
            dtpkTo.Enabled = True
            btnPrint.Enabled = True
        Else
            btnSearch.Enabled = False
            Cbo_TechDate.Enabled = False
            btnPrint.Enabled = False
            dtpkFrom.Enabled = False
            dtpkTo.Enabled = False
            Cbo_TechDate.SelectedIndex = -1
            Cbo_TechDate.Enabled = False
            RefreshEmployeePrintGrid()
        End If
    End Sub

    Private Sub ChkPerTechDisable()
        If checkTech.Checked = True Then
            btnSearch.Enabled = False
            Cbo_TechDate.Enabled = False
            btnPrint.Enabled = False
            dtpkFrom.Enabled = False
            dtpkTo.Enabled = False
            Cbo_TechDate.SelectedIndex = -1
            Cbo_TechDate.Enabled = False
            RefreshEmployeePrintGrid()
        End If
    End Sub
    Private Sub SummaryTechCheck()
        If checkSummary.Checked = True Then
            btnSearchSummary.Visible = True
            btnSearchSummary.Enabled = True
            btnSummaryPrint.Visible = True
            btnSummaryPrint.Enabled = True
            dtpkFrom.Enabled = True
            dtpkTo.Enabled = True
        Else
            btnPrint.Enabled = False
            btnSummaryPrint.Enabled = False
            btnSearchSummary.Enabled = False
            dtpkFrom.Enabled = False
            dtpkTo.Enabled = False
            RefreshEmployeePrintGrid()
        End If
    End Sub

    Private Sub checkSummary_CheckedChanged(sender As Object, e As EventArgs) Handles checkSummary.CheckedChanged
        SummaryTechCheck()
    End Sub

    Private Sub btnSearchSummary_Click(sender As Object, e As EventArgs) Handles btnSummaryPrint.Click
        Dim Checker As Boolean = True
        Dim Vn_Arial As BaseFont = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED)
        Dim fontNormal As Font = New Font(Vn_Arial, 10, 0)
        Dim fontNormal2 As Font = New Font(Vn_Arial, 15, 0)
        Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\\"
        Dim WorkingFolder = AppDomain.CurrentDomain.BaseDirectory
        Dim SampleImage = Path.Combine(WorkingFolder, "pic.png")
        Dim Pic = Image.GetInstance(SampleImage)
        Pic.SetAbsolutePosition(80, 760)

        Dim SampleImage1 = Path.Combine(WorkingFolder, "DOT.png")
        Dim Pic1 = Image.GetInstance(SampleImage1)
        Pic1.SetAbsolutePosition(442, 760)

        Try

            Dim FileName As String = folderPath & "Summary of Technician.pdf"

            Using stream As New FileStream(FileName, FileMode.Create)

                Dim pdfDoc As New Document(PageSize.A4, 5.0F, 5.0F, 5.0F, 10.0F)
                Dim writer = PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(Pic)
                pdfDoc.Add(Pic1)

                Dim cb As PdfContentByte = writer.DirectContent

                Dim ct As ColumnText = New ColumnText(cb)
                Dim par As New Paragraph(Environment.NewLine)


                fontNormal2 = New Font(Vn_Arial, 12, 0)

                Dim myText2b As Phrase = New Phrase("Department of Tourism ", fontNormal)
                ct.SetSimpleColumn(myText2b, -115, 818, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()
                fontNormal2 = New Font(Vn_Arial, 15, 0)

                Dim myText2 As Phrase = New Phrase("National Parks Development Committee", fontNormal2)
                ct.SetSimpleColumn(myText2, -115, 803, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()

                fontNormal2 = New Font(Vn_Arial, 12, 0)

                Dim myText2a As Phrase = New Phrase("T.M. Kalaw St., Rizal Park, Ermita Manila ", fontNormal)
                ct.SetSimpleColumn(myText2a, -115, 788, 700, 150, 15, Element.ALIGN_CENTER)
                ct.Go()

                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)
                pdfDoc.Add(par)

                Dim Par1 As New Paragraph("Summary of Technician", fontNormal2)
                Par1.SpacingBefore = 10
                Par1.SpacingAfter = 2
                Par1.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(Par1)

                fontNormal2 = New Font(Vn_Arial, 8, 0)

                Par1 = New Paragraph("From : " & dtpkFrom.Value.ToShortDateString & "  To : " & dtpkTo.Value.ToShortDateString, fontNormal2)
                Par1.SpacingBefore = 2
                Par1.SpacingAfter = 2
                Par1.Alignment = Element.ALIGN_LEFT
                pdfDoc.Add(Par1)


                pdfDoc.Add(par)

                Dim intTblWidth() As Integer = {20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20}
                Dim tblcount As Integer = 0
                intTblWidth = {28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28}
                tblcount = 11

                Dim pdfTable As New PdfPTable(tblcount)
                pdfTable.DefaultCell.Padding = 3
                pdfTable.WidthPercentage = 100
                pdfTable.SetWidths(intTblWidth)
                pdfTable.HorizontalAlignment = Element.TITLE
                pdfTable.DefaultCell.BorderWidth = 0
                pdfTable.DefaultCell.FixedHeight = 18



                fontNormal2 = New Font(Vn_Arial, 7, 0)

                Dim cell As New PdfPCell

                cell = New PdfPCell(New Phrase("Ticket no", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Employee Name", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Remarks", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Date Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Time Request", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Status", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Date Completed", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Time Completed", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Tech Engineer", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)
                cell = New PdfPCell(New Phrase("Rating", fontNormal2))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.AddCell(cell)


                fontNormal2 = New Font(Vn_Arial, 6, 0)

                For Each row As DataGridViewRow In dgGridPrint.Rows

                    pdfTable.AddCell(New Phrase(row.Cells(0).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(1).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(2).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(3).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(4).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(5).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(6).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(7).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(8).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(9).Value.ToString, fontNormal2))
                    pdfTable.AddCell(New Phrase(row.Cells(10).Value.ToString, fontNormal2))


                Next

                pdfDoc.Add(pdfTable)


                'pdfDoc.Add(par)
                'pdfDoc.Add(par)
                pdfDoc.Add(par)


                Dim Par7 As New Paragraph("Requested by:                                                   Approved by:", fontNormal2)
                Par7.SpacingBefore = 10
                Par7.SpacingAfter = 0
                Par7.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(Par7)

                Dim Par2 As New Paragraph("   ________________________                          ____________________________", fontNormal2)
                Par2.SpacingBefore = 10
                Par2.SpacingAfter = 0
                Par2.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(Par2)

                Dim Par3 As New Paragraph("   Signature                                                Section Head/Division Chief  ", fontNormal2)
                Par3.SpacingBefore = 0
                Par3.SpacingAfter = 2
                Par3.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(Par3)

                'pdfDoc.Add(par)
                'pdfDoc.Add(par)

                pdfDoc.Close()
                stream.Close()
            End Using

            Process.Start(FileName)
            Checker = True

        Catch ex As Exception
            Checker = False
        End Try

        If Checker = False Then
            MsgBox("PDF file is in use, please close the file then try again")
        End If
        btnSummaryPrint.Enabled = False
        checkSummary.CheckState = 0

    End Sub

    Private Sub btnSearchSummary_Click_1(sender As Object, e As EventArgs) Handles btnSearchSummary.Click
        Dim EmpRequestSummary As PrcessClass = New PrcessClass
        dgGridPrint.DataSource = EmpRequestSummary.GetEmployeeSummary("SP_GetEmployeeSummary", dtpkFrom.Value.ToShortDateString, dtpkTo.Value.ToShortDateString)
    End Sub
End Class