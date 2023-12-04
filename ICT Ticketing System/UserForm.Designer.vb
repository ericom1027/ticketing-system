<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtempname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtremarks = New MetroFramework.Controls.MetroTextBox()
        Me.txtrequest = New MetroFramework.Controls.MetroTextBox()
        Me.cborating = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgUser = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ICT TICKETING SYSTEM"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_save_20
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(115, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 32)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "  &Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_cancel_19
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(309, 38)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 32)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "    &Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(20, 165)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel7.TabIndex = 22
        Me.MetroLabel7.Text = "Rating:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(20, 121)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel5.TabIndex = 20
        Me.MetroLabel5.Text = "Remarks:"
        '
        'txtempname
        '
        '
        '
        '
        Me.txtempname.CustomButton.Image = Nothing
        Me.txtempname.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtempname.CustomButton.Name = ""
        Me.txtempname.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtempname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtempname.CustomButton.TabIndex = 1
        Me.txtempname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtempname.CustomButton.UseSelectable = True
        Me.txtempname.CustomButton.Visible = False
        Me.txtempname.Lines = New String(-1) {}
        Me.txtempname.Location = New System.Drawing.Point(132, 27)
        Me.txtempname.MaxLength = 32767
        Me.txtempname.Name = "txtempname"
        Me.txtempname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtempname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtempname.SelectedText = ""
        Me.txtempname.SelectionLength = 0
        Me.txtempname.SelectionStart = 0
        Me.txtempname.ShortcutsEnabled = True
        Me.txtempname.Size = New System.Drawing.Size(246, 29)
        Me.txtempname.TabIndex = 28
        Me.txtempname.UseSelectable = True
        Me.txtempname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtempname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 78)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "Issue/Request:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 33)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Employee Name:"
        '
        'txtremarks
        '
        '
        '
        '
        Me.txtremarks.CustomButton.Image = Nothing
        Me.txtremarks.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtremarks.CustomButton.Name = ""
        Me.txtremarks.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtremarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtremarks.CustomButton.TabIndex = 1
        Me.txtremarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtremarks.CustomButton.UseSelectable = True
        Me.txtremarks.CustomButton.Visible = False
        Me.txtremarks.Lines = New String(-1) {}
        Me.txtremarks.Location = New System.Drawing.Point(132, 115)
        Me.txtremarks.MaxLength = 32767
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtremarks.SelectedText = ""
        Me.txtremarks.SelectionLength = 0
        Me.txtremarks.SelectionStart = 0
        Me.txtremarks.ShortcutsEnabled = True
        Me.txtremarks.Size = New System.Drawing.Size(246, 29)
        Me.txtremarks.TabIndex = 30
        Me.txtremarks.UseSelectable = True
        Me.txtremarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtrequest
        '
        '
        '
        '
        Me.txtrequest.CustomButton.Image = Nothing
        Me.txtrequest.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtrequest.CustomButton.Name = ""
        Me.txtrequest.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtrequest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrequest.CustomButton.TabIndex = 1
        Me.txtrequest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrequest.CustomButton.UseSelectable = True
        Me.txtrequest.CustomButton.Visible = False
        Me.txtrequest.Lines = New String(-1) {}
        Me.txtrequest.Location = New System.Drawing.Point(132, 71)
        Me.txtrequest.MaxLength = 32767
        Me.txtrequest.Name = "txtrequest"
        Me.txtrequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrequest.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrequest.SelectedText = ""
        Me.txtrequest.SelectionLength = 0
        Me.txtrequest.SelectionStart = 0
        Me.txtrequest.ShortcutsEnabled = True
        Me.txtrequest.Size = New System.Drawing.Size(246, 29)
        Me.txtrequest.TabIndex = 29
        Me.txtrequest.UseSelectable = True
        Me.txtrequest.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrequest.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cborating
        '
        Me.cborating.FormattingEnabled = True
        Me.cborating.ItemHeight = 23
        Me.cborating.Items.AddRange(New Object() {"EXCELLENT", "ABOVE AVERAGE", "AVERAGE", "BELOW AVERAGE", "POOR"})
        Me.cborating.Location = New System.Drawing.Point(132, 159)
        Me.cborating.Name = "cborating"
        Me.cborating.Size = New System.Drawing.Size(246, 29)
        Me.cborating.TabIndex = 32
        Me.cborating.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cborating)
        Me.GroupBox1.Controls.Add(Me.txtrequest)
        Me.GroupBox1.Controls.Add(Me.txtremarks)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.txtempname)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 213)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Records"
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AllowUserToResizeRows = False
        Me.dgUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgUser.EnableHeadersVisualStyles = False
        Me.dgUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUser.Location = New System.Drawing.Point(419, 112)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser.Size = New System.Drawing.Size(1163, 517)
        Me.dgUser.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 99)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_close_window_20
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(211, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 32)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "  &Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_add_20
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(19, 38)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(82, 32)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = " &New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.ICT_Ticketing_System.My.Resources.Resources.npdc_logo_png
        Me.BackImagePadding = New System.Windows.Forms.Padding(30, 6, 0, 0)
        Me.BackMaxSize = 100
        Me.ClientSize = New System.Drawing.Size(1596, 649)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UserForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtempname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtremarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtrequest As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cborating As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUser As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
End Class
