<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintReport
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintReport))
        Me.dtpkFrom = New MetroFramework.Controls.MetroDateTime()
        Me.dtpkTo = New MetroFramework.Controls.MetroDateTime()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchSummary = New System.Windows.Forms.Button()
        Me.btnSummaryPrint = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkSummary = New MetroFramework.Controls.MetroCheckBox()
        Me.checkTech = New MetroFramework.Controls.MetroCheckBox()
        Me.Cbo_TechDate = New MetroFramework.Controls.MetroComboBox()
        Me.dgGridPrint = New MetroFramework.Controls.MetroGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgGridPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpkFrom
        '
        Me.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkFrom.Location = New System.Drawing.Point(67, 19)
        Me.dtpkFrom.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpkFrom.Name = "dtpkFrom"
        Me.dtpkFrom.Size = New System.Drawing.Size(176, 29)
        Me.dtpkFrom.TabIndex = 3
        '
        'dtpkTo
        '
        Me.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkTo.Location = New System.Drawing.Point(67, 54)
        Me.dtpkTo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpkTo.Name = "dtpkTo"
        Me.dtpkTo.Size = New System.Drawing.Size(174, 29)
        Me.dtpkTo.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_search_50
        Me.btnSearch.Location = New System.Drawing.Point(32, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 57)
        Me.btnSearch.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 24)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "From:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 58)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "To:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Controls.Add(Me.GroupBox2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(4, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(967, 121)
        Me.MetroPanel1.TabIndex = 14
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpkTo)
        Me.GroupBox1.Controls.Add(Me.dtpkFrom)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(300, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 110)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Range"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchSummary)
        Me.GroupBox2.Controls.Add(Me.btnSummaryPrint)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Location = New System.Drawing.Point(602, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 110)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'btnSearchSummary
        '
        Me.btnSearchSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSummary.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_search_50
        Me.btnSearchSummary.Location = New System.Drawing.Point(32, 24)
        Me.btnSearchSummary.Name = "btnSearchSummary"
        Me.btnSearchSummary.Size = New System.Drawing.Size(89, 57)
        Me.btnSearchSummary.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnSearchSummary, "Search")
        Me.btnSearchSummary.UseVisualStyleBackColor = True
        '
        'btnSummaryPrint
        '
        Me.btnSummaryPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryPrint.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_print_50
        Me.btnSummaryPrint.Location = New System.Drawing.Point(136, 24)
        Me.btnSummaryPrint.Name = "btnSummaryPrint"
        Me.btnSummaryPrint.Size = New System.Drawing.Size(89, 57)
        Me.btnSummaryPrint.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnSummaryPrint, "Search")
        Me.btnSummaryPrint.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_cancel_50
        Me.BtnExit.Location = New System.Drawing.Point(237, 24)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(89, 57)
        Me.BtnExit.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Close")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_print_50
        Me.btnPrint.Location = New System.Drawing.Point(136, 24)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 57)
        Me.btnPrint.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkSummary)
        Me.GroupBox3.Controls.Add(Me.checkTech)
        Me.GroupBox3.Controls.Add(Me.Cbo_TechDate)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 110)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Technician Name"
        '
        'checkSummary
        '
        Me.checkSummary.AutoSize = True
        Me.checkSummary.Location = New System.Drawing.Point(8, 46)
        Me.checkSummary.Name = "checkSummary"
        Me.checkSummary.Size = New System.Drawing.Size(112, 15)
        Me.checkSummary.TabIndex = 16
        Me.checkSummary.Text = "Summary Report"
        Me.checkSummary.UseSelectable = True
        '
        'checkTech
        '
        Me.checkTech.AutoSize = True
        Me.checkTech.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkTech.Location = New System.Drawing.Point(8, 21)
        Me.checkTech.Name = "checkTech"
        Me.checkTech.Size = New System.Drawing.Size(134, 15)
        Me.checkTech.TabIndex = 2
        Me.checkTech.Text = "Search by Technician"
        Me.checkTech.UseSelectable = True
        '
        'Cbo_TechDate
        '
        Me.Cbo_TechDate.FormattingEnabled = True
        Me.Cbo_TechDate.ItemHeight = 23
        Me.Cbo_TechDate.Location = New System.Drawing.Point(7, 71)
        Me.Cbo_TechDate.Name = "Cbo_TechDate"
        Me.Cbo_TechDate.Size = New System.Drawing.Size(268, 29)
        Me.Cbo_TechDate.TabIndex = 1
        Me.Cbo_TechDate.UseSelectable = True
        '
        'dgGridPrint
        '
        Me.dgGridPrint.AllowUserToAddRows = False
        Me.dgGridPrint.AllowUserToDeleteRows = False
        Me.dgGridPrint.AllowUserToResizeRows = False
        Me.dgGridPrint.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGridPrint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGridPrint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgGridPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGridPrint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGridPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGridPrint.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgGridPrint.EnableHeadersVisualStyles = False
        Me.dgGridPrint.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgGridPrint.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGridPrint.Location = New System.Drawing.Point(12, 191)
        Me.dgGridPrint.Name = "dgGridPrint"
        Me.dgGridPrint.ReadOnly = True
        Me.dgGridPrint.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGridPrint.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgGridPrint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgGridPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGridPrint.Size = New System.Drawing.Size(1179, 437)
        Me.dgGridPrint.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Print Report"
        '
        'PrintReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_system_report_60
        Me.BackImagePadding = New System.Windows.Forms.Padding(35, 15, 0, 0)
        Me.BackMaxSize = 35
        Me.ClientSize = New System.Drawing.Size(1206, 641)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgGridPrint)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PrintReport"
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgGridPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpkFrom As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpkTo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnSearch As Button
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents dgGridPrint As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnPrint As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents checkSummary As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkTech As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Cbo_TechDate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSummaryPrint As Button
    Friend WithEvents btnSearchSummary As Button
    Friend WithEvents Label1 As Label
End Class
