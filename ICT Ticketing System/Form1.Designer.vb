<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ticketing
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ticketing))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txttsno = New MetroFramework.Controls.MetroTextBox()
        Me.txtempname = New MetroFramework.Controls.MetroTextBox()
        Me.txtrequest = New MetroFramework.Controls.MetroTextBox()
        Me.cbotech = New MetroFramework.Controls.MetroComboBox()
        Me.txtremarks = New MetroFramework.Controls.MetroTextBox()
        Me.dtDateCompleted = New MetroFramework.Controls.MetroDateTime()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cborating = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_Status = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.dgAdminUserRequest = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgAdminUserRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ICT TICKETING SYSTEM"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 25)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Ticket no:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(9, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Employee Name:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(9, 84)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Request:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(9, 146)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Assigned to:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 113)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Remarks:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(9, 216)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Date:"
        '
        'txttsno
        '
        '
        '
        '
        Me.txttsno.CustomButton.Image = Nothing
        Me.txttsno.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.txttsno.CustomButton.Name = ""
        Me.txttsno.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txttsno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttsno.CustomButton.TabIndex = 1
        Me.txttsno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttsno.CustomButton.UseSelectable = True
        Me.txttsno.CustomButton.Visible = False
        Me.txttsno.Lines = New String(-1) {}
        Me.txttsno.Location = New System.Drawing.Point(119, 24)
        Me.txttsno.MaxLength = 32767
        Me.txttsno.Name = "txttsno"
        Me.txttsno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttsno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttsno.SelectedText = ""
        Me.txttsno.SelectionLength = 0
        Me.txttsno.SelectionStart = 0
        Me.txttsno.ShortcutsEnabled = True
        Me.txttsno.Size = New System.Drawing.Size(246, 23)
        Me.txttsno.TabIndex = 8
        Me.txttsno.UseSelectable = True
        Me.txttsno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttsno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtempname
        '
        '
        '
        '
        Me.txtempname.CustomButton.Image = Nothing
        Me.txtempname.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.txtempname.CustomButton.Name = ""
        Me.txtempname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtempname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtempname.CustomButton.TabIndex = 1
        Me.txtempname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtempname.CustomButton.UseSelectable = True
        Me.txtempname.CustomButton.Visible = False
        Me.txtempname.Lines = New String(-1) {}
        Me.txtempname.Location = New System.Drawing.Point(119, 53)
        Me.txtempname.MaxLength = 32767
        Me.txtempname.Name = "txtempname"
        Me.txtempname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtempname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtempname.SelectedText = ""
        Me.txtempname.SelectionLength = 0
        Me.txtempname.SelectionStart = 0
        Me.txtempname.ShortcutsEnabled = True
        Me.txtempname.Size = New System.Drawing.Size(246, 23)
        Me.txtempname.TabIndex = 9
        Me.txtempname.UseSelectable = True
        Me.txtempname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtempname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtrequest
        '
        '
        '
        '
        Me.txtrequest.CustomButton.Image = Nothing
        Me.txtrequest.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.txtrequest.CustomButton.Name = ""
        Me.txtrequest.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtrequest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrequest.CustomButton.TabIndex = 1
        Me.txtrequest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrequest.CustomButton.UseSelectable = True
        Me.txtrequest.CustomButton.Visible = False
        Me.txtrequest.Lines = New String(-1) {}
        Me.txtrequest.Location = New System.Drawing.Point(119, 82)
        Me.txtrequest.MaxLength = 32767
        Me.txtrequest.Name = "txtrequest"
        Me.txtrequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrequest.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrequest.SelectedText = ""
        Me.txtrequest.SelectionLength = 0
        Me.txtrequest.SelectionStart = 0
        Me.txtrequest.ShortcutsEnabled = True
        Me.txtrequest.Size = New System.Drawing.Size(246, 23)
        Me.txtrequest.TabIndex = 10
        Me.txtrequest.UseSelectable = True
        Me.txtrequest.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrequest.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbotech
        '
        Me.cbotech.FormattingEnabled = True
        Me.cbotech.ItemHeight = 23
        Me.cbotech.Location = New System.Drawing.Point(119, 140)
        Me.cbotech.Name = "cbotech"
        Me.cbotech.Size = New System.Drawing.Size(246, 29)
        Me.cbotech.TabIndex = 11
        Me.cbotech.UseSelectable = True
        '
        'txtremarks
        '
        '
        '
        '
        Me.txtremarks.CustomButton.Image = Nothing
        Me.txtremarks.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.txtremarks.CustomButton.Name = ""
        Me.txtremarks.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtremarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtremarks.CustomButton.TabIndex = 1
        Me.txtremarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtremarks.CustomButton.UseSelectable = True
        Me.txtremarks.CustomButton.Visible = False
        Me.txtremarks.Lines = New String(-1) {}
        Me.txtremarks.Location = New System.Drawing.Point(119, 111)
        Me.txtremarks.MaxLength = 32767
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtremarks.SelectedText = ""
        Me.txtremarks.SelectionLength = 0
        Me.txtremarks.SelectionStart = 0
        Me.txtremarks.ShortcutsEnabled = True
        Me.txtremarks.Size = New System.Drawing.Size(246, 23)
        Me.txtremarks.TabIndex = 12
        Me.txtremarks.UseSelectable = True
        Me.txtremarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtDateCompleted
        '
        Me.dtDateCompleted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateCompleted.Location = New System.Drawing.Point(119, 210)
        Me.dtDateCompleted.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDateCompleted.Name = "dtDateCompleted"
        Me.dtDateCompleted.Size = New System.Drawing.Size(246, 29)
        Me.dtDateCompleted.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_save_20
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(85, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 32)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_cancel_19
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(188, 23)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 32)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "  &Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(10, 249)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "Rating:"
        '
        'cborating
        '
        Me.cborating.FormattingEnabled = True
        Me.cborating.ItemHeight = 23
        Me.cborating.Location = New System.Drawing.Point(119, 245)
        Me.cborating.Name = "cborating"
        Me.cborating.Size = New System.Drawing.Size(246, 29)
        Me.cborating.TabIndex = 19
        Me.cborating.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_Status)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.cborating)
        Me.GroupBox1.Controls.Add(Me.dtDateCompleted)
        Me.GroupBox1.Controls.Add(Me.txtremarks)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.cbotech)
        Me.GroupBox1.Controls.Add(Me.txtrequest)
        Me.GroupBox1.Controls.Add(Me.txtempname)
        Me.GroupBox1.Controls.Add(Me.txttsno)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 296)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Record"
        '
        'cbo_Status
        '
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.ItemHeight = 23
        Me.cbo_Status.Location = New System.Drawing.Point(119, 175)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(146, 29)
        Me.cbo_Status.TabIndex = 21
        Me.cbo_Status.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(9, 179)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel8.TabIndex = 20
        Me.MetroLabel8.Text = "Status:"
        '
        'dgAdminUserRequest
        '
        Me.dgAdminUserRequest.AllowUserToAddRows = False
        Me.dgAdminUserRequest.AllowUserToDeleteRows = False
        Me.dgAdminUserRequest.AllowUserToResizeRows = False
        Me.dgAdminUserRequest.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAdminUserRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgAdminUserRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAdminUserRequest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAdminUserRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAdminUserRequest.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgAdminUserRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAdminUserRequest.EnableHeadersVisualStyles = False
        Me.dgAdminUserRequest.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgAdminUserRequest.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminUserRequest.Location = New System.Drawing.Point(3, 16)
        Me.dgAdminUserRequest.Name = "dgAdminUserRequest"
        Me.dgAdminUserRequest.ReadOnly = True
        Me.dgAdminUserRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAdminUserRequest.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgAdminUserRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgAdminUserRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAdminUserRequest.Size = New System.Drawing.Size(1162, 508)
        Me.dgAdminUserRequest.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgAdminUserRequest)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1168, 527)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 70)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'frm_ticketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.ICT_Ticketing_System.My.Resources.Resources.npdc_logo_png
        Me.BackImagePadding = New System.Windows.Forms.Padding(30, 6, 0, 0)
        Me.BackMaxSize = 100
        Me.ClientSize = New System.Drawing.Size(1582, 644)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ticketing"
        Me.Padding = New System.Windows.Forms.Padding(23, 60, 23, 20)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgAdminUserRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txttsno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtempname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtrequest As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbotech As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtremarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtDateCompleted As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cborating As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgAdminUserRequest As MetroFramework.Controls.MetroGrid
    Friend WithEvents cbo_Status As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
