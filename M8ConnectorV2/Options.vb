Imports Steam8v2.Main
Imports Steam8v2.Login
Imports System
Imports System.Text
Imports System.IO

Public Class Options

    Dim pathConfig As String

    Public topcolor As String
    Public sidecolor As String
    Public tab_home As String
    Public tab_profiles As String
    Public tab_chat As String
    Public tab_groups As String
    Public tab_store As String

    Dim actual As String = "Home"

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pathConfig = Login.pathConfig
        Dim readOptionLine() As String = IO.File.ReadAllLines(pathConfig)



        cb_toppanel.Text = readOptionLine(0)
        cb_sidepanel.Text = readOptionLine(1)
        tab_home = readOptionLine(2)
        tab_profiles = readOptionLine(3)
        tab_chat = readOptionLine(4)
        tab_groups = readOptionLine(5)
        tab_store = readOptionLine(6)

        cb_mainpanel.Text = tab_home



    End Sub

    Private Sub bt_accept_Click(sender As Object, e As EventArgs) Handles bt_accept.Click
        Try
            Dim writeOptionLine() As String = System.IO.File.ReadAllLines(pathConfig)
            writeOptionLine(0) = cb_toppanel.Text
            writeOptionLine(1) = cb_toppanel.Text
            writeOptionLine(2) = tab_home
            writeOptionLine(3) = tab_profiles
            writeOptionLine(4) = tab_chat
            writeOptionLine(5) = tab_groups
            writeOptionLine(6) = tab_store
            System.IO.File.WriteAllLines(pathConfig, writeOptionLine)

            ChangeColor()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bt_abort_Click(sender As Object, e As EventArgs) Handles bt_abort.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If actual = "Home" Then
            tab_home = cb_mainpanel.Text
            Label3.Text = "Profiles"
            actual = "Profiles"
            cb_mainpanel.Text = tab_profiles
        ElseIf actual = "Profiles" Then
            tab_profiles = cb_mainpanel.Text
            Label3.Text = "Chat"
            actual = "Chat"
            cb_mainpanel.Text = tab_chat
        ElseIf actual = "Chat" Then
            tab_chat = cb_mainpanel.Text
            Label3.Text = "Groups"
            actual = "Groups"
            cb_mainpanel.Text = tab_chat
        ElseIf actual = "Groups" Then
            tab_groups = cb_mainpanel.Text
            Label3.Text = "Store"
            actual = "Store"
            cb_mainpanel.Text = tab_store
        ElseIf actual = "Store" Then
            tab_store = cb_mainpanel.Text
            Label3.Text = "Home"
            actual = "Home"
            cb_mainpanel.Text = tab_home
        End If
    End Sub

    Private Sub bt_openconfig_Click(sender As Object, e As EventArgs) Handles bt_openconfig.Click
        Process.Start(pathConfig)
    End Sub

    Private Function ChangeColor()

        If cb_toppanel.Text = "Default" Then
            Main.panel_top.BackColor = Color.FromArgb(255, 59, 66, 76)
        Else
            Main.panel_top.BackColor = Color.FromName(cb_toppanel.Text)
        End If

        If cb_sidepanel.Text = "Default" Then
            Main.panel_sidebar.BackColor = Color.FromArgb(255, 59, 66, 76)
        Else
            Main.panel_sidebar.BackColor = Color.FromName(cb_sidepanel.Text)
        End If

        If actual = "Home" Then
            Main.tab_home.BackColor = Color.FromName(cb_mainpanel.Text)
        ElseIf actual = "Profiles" Then
            Main.tab_profiles.BackColor = Color.FromName(cb_mainpanel.Text)
        ElseIf actual = "Chat" Then
            Main.tab_chat.BackColor = Color.FromName(cb_mainpanel.Text)
        ElseIf actual = "Groups" Then
            Main.tab_groups.BackColor = Color.FromName(cb_mainpanel.Text)
        ElseIf actual = "Store" Then
            Main.tab_store.BackColor = Color.FromName(cb_mainpanel.Text)
        End If
    End Function


End Class