<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.bt_updatecheck = New System.Windows.Forms.Button()
        Me.label_hello = New System.Windows.Forms.Label()
        Me.label_user = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_os = New System.Windows.Forms.Label()
        Me.label_ip = New System.Windows.Forms.Label()
        Me.label_rank = New System.Windows.Forms.Label()
        Me.pb_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_updatecheck
        '
        Me.bt_updatecheck.BackColor = System.Drawing.Color.SpringGreen
        Me.bt_updatecheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_updatecheck.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_updatecheck.Location = New System.Drawing.Point(52, 238)
        Me.bt_updatecheck.Name = "bt_updatecheck"
        Me.bt_updatecheck.Size = New System.Drawing.Size(200, 50)
        Me.bt_updatecheck.TabIndex = 0
        Me.bt_updatecheck.Text = "Check for Updates"
        Me.bt_updatecheck.UseVisualStyleBackColor = False
        '
        'label_hello
        '
        Me.label_hello.AutoSize = True
        Me.label_hello.BackColor = System.Drawing.Color.Transparent
        Me.label_hello.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_hello.ForeColor = System.Drawing.Color.SpringGreen
        Me.label_hello.Location = New System.Drawing.Point(85, 9)
        Me.label_hello.Name = "label_hello"
        Me.label_hello.Size = New System.Drawing.Size(48, 25)
        Me.label_hello.TabIndex = 1
        Me.label_hello.Text = "Hallo,"
        '
        'label_user
        '
        Me.label_user.AutoSize = True
        Me.label_user.BackColor = System.Drawing.Color.Transparent
        Me.label_user.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_user.ForeColor = System.Drawing.Color.SpringGreen
        Me.label_user.Location = New System.Drawing.Point(139, 9)
        Me.label_user.Name = "label_user"
        Me.label_user.Size = New System.Drawing.Size(72, 25)
        Me.label_user.TabIndex = 2
        Me.label_user.Text = "Unknown"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "[OS]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "[IP]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "[RANK]"
        '
        'label_os
        '
        Me.label_os.AutoSize = True
        Me.label_os.BackColor = System.Drawing.Color.Transparent
        Me.label_os.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_os.ForeColor = System.Drawing.Color.SpringGreen
        Me.label_os.Location = New System.Drawing.Point(94, 73)
        Me.label_os.Name = "label_os"
        Me.label_os.Size = New System.Drawing.Size(72, 25)
        Me.label_os.TabIndex = 6
        Me.label_os.Text = "Unknown"
        '
        'label_ip
        '
        Me.label_ip.AutoSize = True
        Me.label_ip.BackColor = System.Drawing.Color.Transparent
        Me.label_ip.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ip.ForeColor = System.Drawing.Color.SpringGreen
        Me.label_ip.Location = New System.Drawing.Point(94, 118)
        Me.label_ip.Name = "label_ip"
        Me.label_ip.Size = New System.Drawing.Size(72, 25)
        Me.label_ip.TabIndex = 7
        Me.label_ip.Text = "Unknown"
        '
        'label_rank
        '
        Me.label_rank.AutoSize = True
        Me.label_rank.BackColor = System.Drawing.Color.Transparent
        Me.label_rank.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_rank.ForeColor = System.Drawing.Color.SpringGreen
        Me.label_rank.Location = New System.Drawing.Point(94, 161)
        Me.label_rank.Name = "label_rank"
        Me.label_rank.Size = New System.Drawing.Size(72, 25)
        Me.label_rank.TabIndex = 8
        Me.label_rank.Text = "Unknown"
        '
        'pb_close
        '
        Me.pb_close.Image = CType(resources.GetObject("pb_close.Image"), System.Drawing.Image)
        Me.pb_close.Location = New System.Drawing.Point(263, 9)
        Me.pb_close.Name = "pb_close"
        Me.pb_close.Size = New System.Drawing.Size(25, 25)
        Me.pb_close.TabIndex = 9
        Me.pb_close.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.pb_close)
        Me.Controls.Add(Me.label_rank)
        Me.Controls.Add(Me.label_ip)
        Me.Controls.Add(Me.label_os)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_user)
        Me.Controls.Add(Me.label_hello)
        Me.Controls.Add(Me.bt_updatecheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        CType(Me.pb_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_updatecheck As Button
    Friend WithEvents label_hello As Label
    Friend WithEvents label_user As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label_os As Label
    Friend WithEvents label_ip As Label
    Friend WithEvents label_rank As Label
    Friend WithEvents pb_close As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
