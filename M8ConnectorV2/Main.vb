Imports System
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Steam8v2.Info
Imports Steam8v2.Login
Imports Steam8v2.Options

Public Class Main

    Dim pathDocs As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim path As String
    Dim pathLoginConfig As String
    Public pathConfig As String
    'FARBEN'
    Public topcolor As String
    Public sidecolor As String
    Public homecolor As String

    Public sessionname As String
    Dim sessionid As String

    Dim iddubsky As String = "76561198104614635"
    Dim idbot As String = "76561198144610873"
    Dim idbiuepixel As String = "76561198068071765"
    Dim idclashi As String = "76561198050281168"

    Dim steamJson As String
    Dim banJson As String
    Dim gameJson As String
    Dim badgeJson As String

    Dim steamProfileStatus As String
    Dim steam64 As String
    Dim steamCustom As String
    Dim steamStatus As String
    Dim steamName As String
    Dim steamGames As String
    Dim steamAvatar As String
    Dim steamSince As String

    Dim steamBadgeXP As String
    Dim steamBadgeLevel As String

    Dim friendStatus As String

    Dim steamBANvac As String
    Dim steamBANvacCount As String
    Dim steamBANcommunity As String
    Dim steamBANtrade As String




    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pathConfig = Login.pathConfig
        Dim readOptionLine() As String = IO.File.ReadAllLines(pathConfig)

        panel_top.BackColor = Color.FromName(readOptionLine(0))
        panel_sidebar.BackColor = Color.FromName(readOptionLine(1))
        tab_home.BackColor = Color.FromName(readOptionLine(2))
        tab_profiles.BackColor = Color.FromName(readOptionLine(3))
        tab_chat.BackColor = Color.FromName(readOptionLine(4))
        tab_groups.BackColor = Color.FromName(readOptionLine(5))
        tab_store.BackColor = Color.FromName(readOptionLine(6))



        label_usernamewelcome.Text = sessionname

        PictureBox35.ImageLocation = "http://vort3xgaming.com/wp-content/uploads/2017/03/bp_logo.png"

        friendStatus = "online"

        tab_control.Appearance = TabAppearance.FlatButtons
        tab_control.ItemSize = New Size(0, 1)
        tab_control.SizeMode = TabSizeMode.Fixed

        scroll_groups.Location = New Point(3, 638)

    End Sub










    '---- BUTTON ----'

    'Discord'
    Private Sub label_discord_Click(sender As Object, e As EventArgs) Handles label_discord.Click
        Process.Start("discord:///invite-proxy/142230614664413184")
    End Sub
    'Reddit'
    Private Sub label_reddit_Click(sender As Object, e As EventArgs) Handles label_reddit.Click
        tab_control.SelectedTab = tab_control.TabPages(4)
    End Sub
    'Profil'
    Private Sub label_profil_Click(sender As Object, e As EventArgs) Handles label_profil.Click
        tab_control.SelectedTab = tab_control.TabPages(1)
    End Sub
    'Chat'
    Private Sub label_chat_Click(sender As Object, e As EventArgs) Handles label_chat.Click
        tab_control.SelectedTab = tab_control.TabPages(2)
    End Sub
    'Close'
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_close.Click
        Login.Close()
        Me.Close()
    End Sub
    'Steam Button'
    Private Sub bt_steam_Click_1(sender As Object, e As EventArgs) Handles bt_steam.Click
        Process.Start("steam://url/SteamIDPage/" + steam64)
    End Sub
    'Chat senden'
    Private Sub chat_send_Click(sender As Object, e As EventArgs)

    End Sub
    'Info'
    Private Sub pb_info_Click(sender As Object, e As EventArgs) Handles pb_info.Click
        Info.Show()
    End Sub








    'Chat'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub loadingRandom()
        Try

            Using Request As New System.Net.WebClient()
                steamJson = Request.DownloadString("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=6306D27947A060E5827600B2B1D6A52C&steamids=" + cb_choose.Text)
            End Using

            Dim read = Newtonsoft.Json.Linq.JObject.Parse(steamJson)
            Dim result = Newtonsoft.Json.JsonConvert.DeserializeObject(steamJson)
            prgbar.Value = 20

            Using Request As New System.Net.WebClient()
                banJson = Request.DownloadString("http://api.steampowered.com/ISteamUser/GetPlayerBans/v1/?key=6306D27947A060E5827600B2B1D6A52C&steamids=" + cb_choose.Text)
            End Using

            Dim banread = Newtonsoft.Json.Linq.JObject.Parse(banJson)
            Dim banresult = Newtonsoft.Json.JsonConvert.DeserializeObject(banJson)
            prgbar.Value = 40

            Using Request As New System.Net.WebClient()
                gameJson = Request.DownloadString("http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=6306D27947A060E5827600B2B1D6A52C&steamid=" + cb_choose.Text)
            End Using

            Dim gameread = Newtonsoft.Json.Linq.JObject.Parse(gameJson)
            Dim gameresult = Newtonsoft.Json.JsonConvert.DeserializeObject(gameJson)
            prgbar.Value = 60

            Using Request As New System.Net.WebClient()
                badgeJson = Request.DownloadString("https://api.steampowered.com/IPlayerService/GetBadges/v1/?key=6306D27947A060E5827600B2B1D6A52C&steamid=" + cb_choose.Text)
            End Using

            Dim badgeread = Newtonsoft.Json.Linq.JObject.Parse(badgeJson)
            Dim badgeresult = Newtonsoft.Json.JsonConvert.DeserializeObject(badgeJson)
            prgbar.Value = 80

            steamProfileStatus = result("response")("players")(0)("communityvisibilitystate")
            steam64 = result("response")("players")(0)("steamid")
            steamAvatar = result("response")("players")(0)("avatarfull")
            steamName = result("response")("players")(0)("personaname")
            steamBadgeXP = badgeresult("response")("player_xp")
            steamBadgeLevel = badgeresult("response")("player_level")

            steamBANvac = banresult("players")(0)("VACBanned")
            steamBANtrade = banresult("players")(0)("EconomyBan")
            steamBANcommunity = banresult("players")(0)("CommunityBanned")
            steamBANvacCount = banresult("players")(0)("NumberOfVACBans")

            steamGames = gameresult("response")("game_count")






            If steam64 = "76561198104614635" Then
                label_rank.Text = "Admin"
                label_rank.ForeColor = Color.Red
            ElseIf steam64 = "76561198144610873" Then
                label_rank.Text = "BOT"
                label_rank.ForeColor = Color.Purple
            ElseIf steam64 = "76561198050281168" Then
                label_rank.Text = "Beta Tester"
                label_rank.ForeColor = Color.Gold
            ElseIf steam64 = "76561198068071765" Then
                label_rank.Text = "Beta Tester"
                label_rank.ForeColor = Color.Gold
            Else
                label_rank.Text = "Member"
                label_rank.ForeColor = Color.Green
            End If

            'Bann Verwertung'
            If steamBANcommunity = "True" Then
                label_bancommunity.ForeColor = Color.Red
            Else label_bancommunity.ForeColor = Color.Green
            End If
            If steamBANvac = "True" Then
                label_banvac.ForeColor = Color.Red
            Else label_banvac.ForeColor = Color.Green
            End If
            If steamBANtrade = "none" Then
                label_bantrade.ForeColor = Color.Green
            Else label_bantrade.ForeColor = Color.Red
            End If

            label_username.Text = steamName
            label_games.Text = steamGames
            label_xp.Text = steamBadgeXP
            label_level.Text = steamBadgeLevel
            pb_logo.ImageLocation = steamAvatar

            'Profil Status Verwertung'
            If steamProfileStatus = 1 Then
                pb_privateprofile.Visible = True
            ElseIf steamProfileStatus = 2 Then
                pb_privateprofile.Visible = True
            Else
                pb_privateprofile.Visible = False
            End If

            prgbar.Value = 100
        Catch ex As Exception
            MsgBox("Sorry, the SteamID doesn't seem right :/", MsgBoxStyle.Information, "Fehler <202>")
        End Try
    End Sub





    'Drag & Drop'
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel_top.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel_top.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel_top.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pb_goto.Click
        If cb_choose.Text = "Dubsky" Then
            cb_choose.Text = iddubsky
            loadingRandom()
        ElseIf cb_choose.Text = "OmegaBot" Then
            cb_choose.Text = idbot
            loadingRandom()
        ElseIf cb_choose.Text = "Clashcloud" Then
            cb_choose.Text = idclashi
            loadingRandom()
        ElseIf cb_choose.Text = "Biuepixel" Then
            cb_choose.Text = idbiuepixel
            loadingRandom()
        Else
            loadingRandom()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_steam8steamgroup.Click
        Process.Start("steam://url/GroupSteamIDPage/103582791458922638")
    End Sub

    Private Sub bt_profiles_Click(sender As Object, e As EventArgs) Handles bt_profiles.Click
        tab_control.SelectedTab = tab_control.TabPages(1)
    End Sub

    Private Sub bt_reddit_Click(sender As Object, e As EventArgs) Handles bt_reddit.Click
        tab_control.SelectedTab = tab_control.TabPages(4)
    End Sub

    Private Sub bt_groups_Click(sender As Object, e As EventArgs) Handles bt_groups.Click
        tab_control.SelectedTab = tab_control.TabPages(3)
    End Sub

    Private Sub label_banvac_Click(sender As Object, e As EventArgs) Handles label_banvac.Click
        MsgBox("VAC Bans: " + steamBANvacCount, MsgBoxStyle.Information, "VAC Ban count")
    End Sub

    Private Sub label_bantrade_Click(sender As Object, e As EventArgs) Handles label_bantrade.Click
        If steamBANtrade = "none" Then

        Else
            MsgBox("Banned from trading, because of violation of the ToS", MsgBoxStyle.Information, "Trade Ban Information")
        End If
    End Sub

    Private Sub label_bancommunity_Click(sender As Object, e As EventArgs) Handles label_bancommunity.Click
        If steamBANcommunity = "True" Then
            MsgBox("Banned from the Community, because of violations of the ToS", MsgBoxStyle.Information, "Community Ban Information")
        End If
    End Sub

    Private Sub label_groups_Click(sender As Object, e As EventArgs) Handles label_groups.Click
        tab_control.SelectedTab = tab_control.TabPages(3)
    End Sub

    Private Sub label_home_Click(sender As Object, e As EventArgs) Handles label_home.Click
        tab_control.SelectedTab = tab_control.TabPages(0)
    End Sub

    Private Sub bt_website_Click(sender As Object, e As EventArgs) Handles bt_website.Click
        Process.Start("http://dubskyarchiv.ddns.net/projects/steam8/index.php")
    End Sub

    Private Sub pb_privateprofile_Click(sender As Object, e As EventArgs) Handles pb_privateprofile.Click
        If steamProfileStatus = 2 Then
            MsgBox("Sorry, this profile isn't visible for the Steam API - Friends only", MsgBoxStyle.Information, "Profile Access Status")
        Else
            MsgBox("Sorry, this profile isn't visible for the Steam API - Private", MsgBoxStyle.Information, "Profile Access Status")
        End If
    End Sub

    Private Sub bt_support_Click(sender As Object, e As EventArgs) Handles bt_support.Click
        Process.Start("steam://friends/joinchat/103582791458922638")
    End Sub

    Private Sub bt_status_Click(sender As Object, e As EventArgs) Handles bt_status.Click

        If friendStatus = "beschäftigt" Then
            bt_status.Image = My.Resources.bt_online
            friendStatus = "online"
            Process.Start("steam://friends/status/online")
        ElseIf friendStatus = "online" Then
            bt_status.Image = My.Resources.bt_abwesend
            friendStatus = "abwesend"
            Process.Start("steam://friends/status/away")
        ElseIf friendStatus = "abwesend" Then
            bt_status.Image = My.Resources.bt_beschäftigt
            friendStatus = "beschäftigt"
            Process.Start("steam://friends/status/busy")
        End If
    End Sub

    Private Sub label_settings_Click(sender As Object, e As EventArgs) Handles label_settings.Click
        Options.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles label_store.Click
        tab_control.SelectedTab = tab_control.TabPages(5)
    End Sub

    Private Sub panel_sidebar_Paint(sender As Object, e As PaintEventArgs) Handles panel_sidebar.Paint

    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Process.Start("steam://url/StoreAppPage/578080")
    End Sub

    Private Sub scroll_groups_Scroll(sender As Object, e As ScrollEventArgs) Handles scroll_groups.Scroll

        Panel1.Width = scroll_groups.Value

    End Sub
End Class