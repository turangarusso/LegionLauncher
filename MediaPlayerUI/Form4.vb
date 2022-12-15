Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Threading

Public Class Form4
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Completato")
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim appData As String = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = appData & "\FiveM\FiveM.app\data\server-cache"
        MessageBox.Show("Cache pulita")
        Try
            My.Computer.FileSystem.DeleteDirectory(appData, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
            MessageBox.Show("Cartella non trovata (server-cache)")

        End Try



        Dim appData1 As String = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData1 = appData1 & "\FiveM\FiveM.app\data\server-cache-priv"
        Try
            My.Computer.FileSystem.DeleteDirectory(appData1, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
            MessageBox.Show("Cartella non trovata (server-cache-priv)")
        End Try

        Dim appData2 As String = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData2 = appData2 & "\FiveM\FiveM.app\data\nui-storage"
        Try
            My.Computer.FileSystem.DeleteDirectory(appData2, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
            MessageBox.Show("Cartella non trovata (nui-storage)")
        End Try
        Dim appData3 As String = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData3 = appData3 & "\FiveM\FiveM.app\data\cache"
        Try
            My.Computer.FileSystem.DeleteDirectory(appData3, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
            MessageBox.Show("Cartella non trovata (cartella cache)")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        tempclean = New System.Threading.Thread(AddressOf clean)
        tempclean.Start()
        MsgBox("File temporanei Rimossi", MsgBoxStyle.Information)

    End Sub
    Dim tempclean As Thread
    Dim tempFolderPath As String = System.IO.Path.GetTempPath()

    Sub clean()
        For Each filePath In Directory.GetFiles(tempFolderPath)
            Try
                File.Delete(filePath)
            Catch
            End Try
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim appData11 As String = GetFolderPath(SpecialFolder.ApplicationData)
        appData11 = appData11 & "\TS3Client\logs"
        MessageBox.Show(appData11)
        Try
            My.Computer.FileSystem.DeleteDirectory(appData11, FileIO.DeleteDirectoryOption.DeleteAllContents)

        Catch
            MessageBox.Show("Cartella non trovata (Log TS3Clint)")
        End Try
        MessageBox.Show("Logs Cancellati")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("https://gaming.v10networks.com/saltychat/download/3.0.5")
        Thread.Sleep(2000)
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.CommonProgramFiles)
        appData = "C:\Program Files\TeamSpeak 3 Client\package_inst.exe"
        Dim appData2 As String = GetFolderPath(SpecialFolder.UserProfile)
        ' Display the path
        appData2 = appData2 & "\Downloads\SaltyChat_3.0.5.ts3_plugin"
        'Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo(appData, appData2)
        Try

            p.StartInfo = ps
            p.Start()
        Catch
            MessageBox.Show("devi avere SaltyChat_3.0.5.ts3_plugin in downloads e Teamspek installato in C:\Program Files\TeamSpeak 3 Client\package_inst.exe")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Fix Applicato")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Zyorby_Cleaner_V2.bat"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\DnsJumper.exe"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Ultimate Windows Tweaker 4.8.exe"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Disable Windows Telemetry.reg"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Disable Spectre and Meltdown 2.0.reg"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim p As New Process
        Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
        appData = "C:\Program Files (x86)\EasyBooster\Disable Memory Compression.cmd"
        ' Display the path
        ' Console.WriteLine("App Data Folder Path: " & appData)
        Dim ps As New ProcessStartInfo("explorer.exe", appData)
        p.StartInfo = ps
        p.Start()
        MessageBox.Show("Completato")
    End Sub
End Class