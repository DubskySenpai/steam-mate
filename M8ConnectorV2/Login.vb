Imports System
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports Steam8v2.Main

Public Class Login

    Dim SQLConn As MySqlConnection
    Dim SQLCommand As MySqlCommand
    Dim SQLReader As MySqlDataReader

    Dim readLogin As String
    Dim readUser As String
    Dim readPassword As String
    Dim readMember As String

    Dim count As Integer = 0

    Dim pathDocs As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim path As String
    Dim pathAutoLogin As String
    Public pathConfig As String







    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = pathDocs + "/Steam8"
            pathAutoLogin = path + "/autologin.txt"
            pathConfig = path + "/config.txt"

            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If

            If Not File.Exists(pathAutoLogin) Then
                File.Create(pathAutoLogin)
            End If

            If Not File.Exists(pathConfig) Then
                File.Create(pathConfig)
            End If

            Dim readLines() As String = IO.File.ReadAllLines(pathAutoLogin)
            If count = 0 Then
                readUser = readLines(0)
                count = count + 1
            End If
            If count = 1 Then
                readPassword = readLines(1)
                count = count + 1
            End If
            If count = 2 Then
                readMember = readLines(2)
                count = count + 1
            End If

            tb_username.Text = readUser
            tb_password.Text = readPassword
            cb_membership.Text = readMember

        Catch ex As Exception
            MsgBox("Problems occured While checking/creating config files", MsgBoxStyle.Critical, "Fehler <204>")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_close.Click
        Me.Close()
    End Sub

    Private Sub tb_username_TextChanged(sender As Object, e As EventArgs) Handles tb_username.Click
        tb_username.Text = ""
    End Sub

    Private Sub tb_password_TextChanged(sender As Object, e As EventArgs) Handles tb_password.Click
        tb_password.Text = ""
    End Sub

    Private Sub tb_password_MouseDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles tb_password.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub


    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        If cb_remember.Checked Then
            Try
                Dim lines() As String = System.IO.File.ReadAllLines(pathAutoLogin)
                lines(0) = tb_username.Text
                lines(1) = tb_password.Text
                lines(2) = cb_membership.Text
                System.IO.File.WriteAllLines(pathAutoLogin, lines)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Login()
        Else
            Login()
        End If
    End Sub



    Private Sub Go()
        Me.Hide()

        Main.Show()
    End Sub







    Private Function Login()
        SQLConn = New MySqlConnection
        SQLConn.ConnectionString = "server=localhost;port=3306;userid=root;password=;database=steam8"
        SQLCommand = New MySqlCommand
        Dim SQLReader As MySqlDataReader

        Try
            SQLConn.Open()
            Dim Abfrage As String
            Abfrage = "Select * from steam8.accounts where username='" & tb_username.Text & "' and password='" & tb_password.Text & "' and membership='" & cb_membership.Text & "'"
            SQLCommand = New MySqlCommand(Abfrage, SQLConn)
            SQLReader = SQLCommand.ExecuteReader
            Dim count As Integer
            count = 0

            While SQLReader.Read
                count = count + 1
            End While

            If count = 1 Then
                Main.sessionname = tb_username.Text
                Go()
            ElseIf count >= 1 Then
                MsgBox("Check your Login Information again", MsgBoxStyle.Critical, "Error <201>")
            Else
                MsgBox("Check your Login Information again", MsgBoxStyle.Critical, "Error <201>")
            End If


            SQLConn.Close()
        Catch ex As MySqlException
            MsgBox("Couldn't connect to the Database Server", MsgBoxStyle.Information, "Error <200>")
        Finally
            SQLConn.Dispose()
        End Try
    End Function


    'Drag & Drop'
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
End Class