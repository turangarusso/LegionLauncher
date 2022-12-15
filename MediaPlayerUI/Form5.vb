Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Threading

Public Class Form5
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("steam://")
        Process.Start("http://www.vacbanned.com/")
        MessageBox.Show("Su steam vai sul tuo nome poi il tuo profilo, tasto destro sulla pagina e seleziona copia URL della pagina, copialo su VacBanned controllando il formato del link")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe")
        Thread.Sleep(4000)
        Dim p As New Process

        Dim appData2 As String = GetFolderPath(SpecialFolder.UserProfile)
        ' Display the path
        appData2 = appData2 & "\Downloads\SteamSetup.exe"
        'Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo(appData2)
        Try

            p.StartInfo = ps
            p.Start()
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86")
        Thread.Sleep(7000)
        Dim p As New Process

        Dim appData2 As String = GetFolderPath(SpecialFolder.UserProfile)
        ' Display the path
        appData2 = appData2 & "\Downloads\DiscordSetup.exe"
        'Console.WriteLine("App Data Folder Path: " & appData2)
        'MsgBox(appData2, MsgBoxStyle.Information)
        Try
            Dim ps As New ProcessStartInfo(appData2)
            p.StartInfo = ps
            p.Start()
        Catch
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://gaming.v10networks.com/saltychat/download/3.0.5")
        Thread.Sleep(2000)
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.CommonProgramFiles)
        appData = "C:\Program Files\TeamSpeak 3 Client\package_inst.exe"
        Dim appData2 As String = GetFolderPath(SpecialFolder.UserProfile)
        ' Display the path
        appData2 = appData2 & "\Downloads\SaltyChat_3.0.5.ts3_plugin"
        'Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData2)
        Try

            p.StartInfo = ps
            p.Start()
        Catch
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://www.teamspeak.com/en/downloads/#")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://fivem.net/")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Process.Start("steam://")
        Process.Start("steam://url/StoreAccount")


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Little_Optimization_PC.bat"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub SaaLine1_Load(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim appData2 As String = GetFolderPath(SpecialFolder.UserProfile)
        appData2 = appData2 & "\AppData\Roaming\CitizenFX\fivem.cfg"
        My.Computer.FileSystem.CopyFile(
    "C:\Program Files (x86)\EasyBooster\fivem.cfg",
    appData2, overwrite:=True)
    End Sub
End Class