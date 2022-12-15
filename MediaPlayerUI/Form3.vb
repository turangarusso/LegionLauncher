Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Threading

Public Class Form3
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class