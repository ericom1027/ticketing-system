<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_user))
        Me.txt_user = New MetroFramework.Controls.MetroTextBox()
        Me.txt_pass = New MetroFramework.Controls.MetroTextBox()
        Me.cbo_userlvl = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgAddUser = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndeleteUser = New System.Windows.Forms.Button()
        CType(Me.dgAddUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_user
        '
        '
        '
        '
        Me.txt_user.CustomButton.Image = Nothing
        Me.txt_user.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txt_user.CustomButton.Name = ""
        Me.txt_user.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_user.CustomButton.TabIndex = 1
        Me.txt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_user.CustomButton.UseSelectable = True
        Me.txt_user.CustomButton.Visible = False
        Me.txt_user.Lines = New String(-1) {}
        Me.txt_user.Location = New System.Drawing.Point(114, 76)
        Me.txt_user.MaxLength = 32767
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_user.SelectedText = ""
        Me.txt_user.SelectionLength = 0
        Me.txt_user.SelectionStart = 0
        Me.txt_user.ShortcutsEnabled = True
        Me.txt_user.Size = New System.Drawing.Size(186, 23)
        Me.txt_user.TabIndex = 1
        Me.txt_user.UseSelectable = True
        Me.txt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_pass
        '
        '
        '
        '
        Me.txt_pass.CustomButton.Image = Nothing
        Me.txt_pass.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txt_pass.CustomButton.Name = ""
        Me.txt_pass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pass.CustomButton.TabIndex = 1
        Me.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pass.CustomButton.UseSelectable = True
        Me.txt_pass.CustomButton.Visible = False
        Me.txt_pass.Lines = New String(-1) {}
        Me.txt_pass.Location = New System.Drawing.Point(114, 114)
        Me.txt_pass.MaxLength = 32767
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pass.SelectedText = ""
        Me.txt_pass.SelectionLength = 0
        Me.txt_pass.SelectionStart = 0
        Me.txt_pass.ShortcutsEnabled = True
        Me.txt_pass.Size = New System.Drawing.Size(186, 23)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.UseSelectable = True
        Me.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbo_userlvl
        '
        Me.cbo_userlvl.FormattingEnabled = True
        Me.cbo_userlvl.ItemHeight = 23
        Me.cbo_userlvl.Location = New System.Drawing.Point(114, 152)
        Me.cbo_userlvl.Name = "cbo_userlvl"
        Me.cbo_userlvl.Size = New System.Drawing.Size(186, 29)
        Me.cbo_userlvl.TabIndex = 3
        Me.cbo_userlvl.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 77)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Username:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 116)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Password:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(20, 154)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "User Level:"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_cancel_19
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(207, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 34)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "   &Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_save_20
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(37, 201)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 34)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgAddUser
        '
        Me.dgAddUser.AllowUserToAddRows = False
        Me.dgAddUser.AllowUserToDeleteRows = False
        Me.dgAddUser.AllowUserToResizeRows = False
        Me.dgAddUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAddUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAddUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgAddUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAddUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAddUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAddUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgAddUser.EnableHeadersVisualStyles = False
        Me.dgAddUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgAddUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAddUser.Location = New System.Drawing.Point(324, 63)
        Me.dgAddUser.Name = "dgAddUser"
        Me.dgAddUser.ReadOnly = True
        Me.dgAddUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAddUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgAddUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgAddUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAddUser.Size = New System.Drawing.Size(310, 196)
        Me.dgAddUser.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndeleteUser)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 203)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btndeleteUser
        '
        Me.btndeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteUser.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_close_window_201
        Me.btndeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeleteUser.Location = New System.Drawing.Point(117, 145)
        Me.btndeleteUser.Name = "btndeleteUser"
        Me.btndeleteUser.Size = New System.Drawing.Size(79, 34)
        Me.btndeleteUser.TabIndex = 9
        Me.btndeleteUser.Text = " &Delete"
        Me.btndeleteUser.UseVisualStyleBackColor = True
        '
        'Add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_user_30
        Me.BackImagePadding = New System.Windows.Forms.Padding(120, 20, 0, 0)
        Me.BackMaxSize = 33
        Me.ClientSize = New System.Drawing.Size(647, 269)
        Me.Controls.Add(Me.dgAddUser)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbo_userlvl)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Add_user"
        Me.Text = "Add User"
        CType(Me.dgAddUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbo_userlvl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgAddUser As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndeleteUser As Button
End Class
