<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Log))
        Me.txtpass = New MetroFramework.Controls.MetroTextBox()
        Me.txtuser = New MetroFramework.Controls.MetroTextBox()
        Me.btnlog = New MetroFramework.Controls.MetroButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Warninglbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass
        '
        '
        '
        '
        Me.txtpass.CustomButton.Image = Nothing
        Me.txtpass.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtpass.CustomButton.Name = ""
        Me.txtpass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpass.CustomButton.TabIndex = 1
        Me.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpass.CustomButton.UseSelectable = True
        Me.txtpass.CustomButton.Visible = False
        Me.txtpass.Lines = New String(-1) {}
        Me.txtpass.Location = New System.Drawing.Point(40, 243)
        Me.txtpass.MaxLength = 32767
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.PromptText = "Password"
        Me.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpass.SelectedText = ""
        Me.txtpass.SelectionLength = 0
        Me.txtpass.SelectionStart = 0
        Me.txtpass.ShortcutsEnabled = True
        Me.txtpass.Size = New System.Drawing.Size(173, 23)
        Me.txtpass.TabIndex = 9
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass.UseSelectable = True
        Me.txtpass.WaterMark = "Password"
        Me.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpass.WaterMarkFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtuser
        '
        '
        '
        '
        Me.txtuser.CustomButton.Image = Nothing
        Me.txtuser.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtuser.CustomButton.Name = ""
        Me.txtuser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtuser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtuser.CustomButton.TabIndex = 1
        Me.txtuser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtuser.CustomButton.UseSelectable = True
        Me.txtuser.CustomButton.Visible = False
        Me.txtuser.Lines = New String(-1) {}
        Me.txtuser.Location = New System.Drawing.Point(40, 208)
        Me.txtuser.MaxLength = 32767
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.PromptText = "Username"
        Me.txtuser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtuser.SelectedText = ""
        Me.txtuser.SelectionLength = 0
        Me.txtuser.SelectionStart = 0
        Me.txtuser.ShortcutsEnabled = True
        Me.txtuser.Size = New System.Drawing.Size(173, 23)
        Me.txtuser.TabIndex = 8
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuser.UseSelectable = True
        Me.txtuser.WaterMark = "Username"
        Me.txtuser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtuser.WaterMarkFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnlog
        '
        Me.btnlog.Location = New System.Drawing.Point(130, 281)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(83, 32)
        Me.btnlog.TabIndex = 11
        Me.btnlog.Text = "Sign in"
        Me.btnlog.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ICT_Ticketing_System.My.Resources.Resources.icons8_account_70
        Me.PictureBox2.Location = New System.Drawing.Point(78, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(47, 166)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(169, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Please sign in to get access."
        '
        'Warninglbl
        '
        Me.Warninglbl.AutoSize = True
        Me.Warninglbl.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warninglbl.ForeColor = System.Drawing.Color.Black
        Me.Warninglbl.Location = New System.Drawing.Point(75, 330)
        Me.Warninglbl.Name = "Warninglbl"
        Me.Warninglbl.Size = New System.Drawing.Size(0, 14)
        Me.Warninglbl.TabIndex = 18
        '
        'User_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImagePadding = New System.Windows.Forms.Padding(85, 20, 0, 0)
        Me.BackMaxSize = 40
        Me.ClientSize = New System.Drawing.Size(274, 367)
        Me.Controls.Add(Me.Warninglbl)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.txtpass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "User_Log"
        Me.Text = "Login"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtuser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnlog As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Warninglbl As Label
End Class
