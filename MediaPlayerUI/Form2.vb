Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Threading

Public Class Form2
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Process.Start("http://www.legionrp.it/")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Process.Start("https://discord.gg/8Mu8e46Xva")
    End Sub
End Class