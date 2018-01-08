<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.bt_login = New System.Windows.Forms.Button()
        Me.pb_close = New System.Windows.Forms.PictureBox()
        Me.cb_membership = New System.Windows.Forms.ComboBox()
        Me.cb_remember = New System.Windows.Forms.CheckBox()
        CType(Me.pb_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_password
        '
        Me.tb_password.BackColor = System.Drawing.Color.Cyan
        Me.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.Cross
        Me.tb_password.Font = New System.Drawing.Font("Kenyan Coffee Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(40, 74)
        Me.tb_password.MaxLength = 16
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tb_password.Size = New System.Drawing.Size(200, 30)
        Me.tb_password.TabIndex = 6
        Me.tb_password.Text = "OOO"
        Me.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_username
        '
        Me.tb_username.BackColor = System.Drawing.Color.Cyan
        Me.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_username.Cursor = System.Windows.Forms.Cursors.Cross
        Me.tb_username.Font = New System.Drawing.Font("Kenyan Coffee Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.Location = New System.Drawing.Point(40, 30)
        Me.tb_username.MaxLength = 16
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(200, 30)
        Me.tb_username.TabIndex = 5
        Me.tb_username.Text = "Username"
        Me.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bt_login
        '
        Me.bt_login.BackColor = System.Drawing.Color.SpringGreen
        Me.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_login.Font = New System.Drawing.Font("Kenyan Coffee Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_login.Location = New System.Drawing.Point(40, 180)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(200, 60)
        Me.bt_login.TabIndex = 4
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = False
        '
        'pb_close
        '
        Me.pb_close.Image = CType(resources.GetObject("pb_close.Image"), System.Drawing.Image)
        Me.pb_close.Location = New System.Drawing.Point(250, 5)
        Me.pb_close.Name = "pb_close"
        Me.pb_close.Size = New System.Drawing.Size(25, 25)
        Me.pb_close.TabIndex = 7
        Me.pb_close.TabStop = False
        '
        'cb_membership
        '
        Me.cb_membership.BackColor = System.Drawing.Color.Cyan
        Me.cb_membership.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_membership.Font = New System.Drawing.Font("Kenyan Coffee Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_membership.FormattingEnabled = True
        Me.cb_membership.Items.AddRange(New Object() {"Member", "Beta Tester", "Moderator", "Bot", "Admin"})
        Me.cb_membership.Location = New System.Drawing.Point(40, 143)
        Me.cb_membership.Name = "cb_membership"
        Me.cb_membership.Size = New System.Drawing.Size(200, 31)
        Me.cb_membership.TabIndex = 8
        '
        'cb_remember
        '
        Me.cb_remember.AutoSize = True
        Me.cb_remember.Font = New System.Drawing.Font("Kenyan Coffee Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_remember.ForeColor = System.Drawing.Color.White
        Me.cb_remember.Location = New System.Drawing.Point(79, 246)
        Me.cb_remember.Name = "cb_remember"
        Me.cb_remember.Size = New System.Drawing.Size(114, 27)
        Me.cb_remember.TabIndex = 9
        Me.cb_remember.Text = "Remember me"
        Me.cb_remember.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 282)
        Me.Controls.Add(Me.cb_remember)
        Me.Controls.Add(Me.cb_membership)
        Me.Controls.Add(Me.pb_close)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.bt_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pb_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_close As PictureBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_username As TextBox
    Friend WithEvents bt_login As Button
    Friend WithEvents cb_membership As ComboBox
    Friend WithEvents cb_remember As CheckBox
End Class
