Imports System
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports Steam8v2.Login
Imports Steam8v2.Main


Public Class Info

    Dim newversion As String
    Dim web As New WebClient
    Dim actualversion As String

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


    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualversion = Application.ProductVersion
        label_os.Text = My.Computer.Info.OSFullName
        label_user.Text = Main.sessionname

    End Sub


    Private Sub bt_updatecheck_Click(sender As Object, e As EventArgs) Handles bt_updatecheck.Click
        Try
            Using RequestData As New WebClient()
                newversion = RequestData.DownloadString("http://dubskyarchiv.ddns.net/projects/steam8/version.html")
            End Using

            If newversion = actualversion Then
                MsgBox("Du besitzt die aktuellste Verison", MsgBoxStyle.Information, "Update Info")
            Else
                MsgBox("Eine neue Version ist auf der Website verfügbar", MsgBoxStyle.Information, "Update Info")
            End If
        Catch ex As Exception
            MsgBox("Website konnte nicht erreicht werden, bitte wende dich an den Chat Support", MsgBoxStyle.Critical, "Fehler 202")
        End Try
    End Sub

    Private Sub pb_close_Click(sender As Object, e As EventArgs) Handles pb_close.Click
        Close()
    End Sub
End Class