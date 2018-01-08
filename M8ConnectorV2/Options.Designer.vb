<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.bt_accept = New System.Windows.Forms.Button()
        Me.cb_toppanel = New System.Windows.Forms.ComboBox()
        Me.cb_sidepanel = New System.Windows.Forms.ComboBox()
        Me.cb_mainpanel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_openconfig = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_abort = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_accept
        '
        Me.bt_accept.BackColor = System.Drawing.Color.SpringGreen
        Me.bt_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_accept.Font = New System.Drawing.Font("Kenyan Coffee Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_accept.Location = New System.Drawing.Point(163, 236)
        Me.bt_accept.Name = "bt_accept"
        Me.bt_accept.Size = New System.Drawing.Size(125, 40)
        Me.bt_accept.TabIndex = 0
        Me.bt_accept.Text = "Übernehmen"
        Me.bt_accept.UseVisualStyleBackColor = False
        '
        'cb_toppanel
        '
        Me.cb_toppanel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cb_toppanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_toppanel.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_toppanel.FormattingEnabled = True
        Me.cb_toppanel.Items.AddRange(New Object() {"Standart", "Red", "Green", "Blue", "White"})
        Me.cb_toppanel.Location = New System.Drawing.Point(137, 18)
        Me.cb_toppanel.Name = "cb_toppanel"
        Me.cb_toppanel.Size = New System.Drawing.Size(151, 33)
        Me.cb_toppanel.TabIndex = 1
        '
        'cb_sidepanel
        '
        Me.cb_sidepanel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cb_sidepanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_sidepanel.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sidepanel.FormattingEnabled = True
        Me.cb_sidepanel.Items.AddRange(New Object() {"Standart", "Red", "Green", "Blue", "White"})
        Me.cb_sidepanel.Location = New System.Drawing.Point(137, 57)
        Me.cb_sidepanel.Name = "cb_sidepanel"
        Me.cb_sidepanel.Size = New System.Drawing.Size(151, 33)
        Me.cb_sidepanel.TabIndex = 2
        '
        'cb_mainpanel
        '
        Me.cb_mainpanel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cb_mainpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_mainpanel.Font = New System.Drawing.Font("Kenyan Coffee Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_mainpanel.FormattingEnabled = True
        Me.cb_mainpanel.Items.AddRange(New Object() {"Standart", "Red", "Green", "Blue", "White"})
        Me.cb_mainpanel.Location = New System.Drawing.Point(137, 96)
        Me.cb_mainpanel.Name = "cb_mainpanel"
        Me.cb_mainpanel.Size = New System.Drawing.Size(151, 33)
        Me.cb_mainpanel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SpringGreen
        Me.Label1.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Top Panel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SpringGreen
        Me.Label2.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Side Panel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SpringGreen
        Me.Label3.Font = New System.Drawing.Font("Kenyan Coffee Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Home"
        '
        'bt_openconfig
        '
        Me.bt_openconfig.BackColor = System.Drawing.Color.SpringGreen
        Me.bt_openconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_openconfig.Font = New System.Drawing.Font("Kenyan Coffee Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_openconfig.Location = New System.Drawing.Point(12, 190)
        Me.bt_openconfig.Name = "bt_openconfig"
        Me.bt_openconfig.Size = New System.Drawing.Size(276, 40)
        Me.bt_openconfig.TabIndex = 7
        Me.bt_openconfig.Text = "Konfigurationsdatei öffnen"
        Me.bt_openconfig.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'bt_abort
        '
        Me.bt_abort.BackColor = System.Drawing.Color.SpringGreen
        Me.bt_abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_abort.Font = New System.Drawing.Font("Kenyan Coffee Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_abort.Location = New System.Drawing.Point(12, 236)
        Me.bt_abort.Name = "bt_abort"
        Me.bt_abort.Size = New System.Drawing.Size(125, 40)
        Me.bt_abort.TabIndex = 9
        Me.bt_abort.Text = "Abbruch"
        Me.bt_abort.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.bt_abort)
        Me.Controls.Add(Me.bt_openconfig)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_mainpanel)
        Me.Controls.Add(Me.cb_sidepanel)
        Me.Controls.Add(Me.cb_toppanel)
        Me.Controls.Add(Me.bt_accept)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_accept As Button
    Friend WithEvents cb_toppanel As ComboBox
    Friend WithEvents cb_sidepanel As ComboBox
    Friend WithEvents cb_mainpanel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bt_openconfig As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_abort As Button
End Class
