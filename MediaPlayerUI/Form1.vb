Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Threading

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        PanelToolsSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        'showSubmenu(PanelMediaSubmenu)
        'Me.Close() conserva
        If currentForm IsNot Nothing Then currentForm.Close()

    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        'showSubmenu(PanelPlaylistSubmenu)
        OpenChildForm(New Form4())
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        'showSubmenu(PanelToolsSubmenu)
        OpenChildForm(New Form2())
    End Sub

#Region "Buttons Submenu"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        OpenChildForm(New Form2())
        '...
        'your codes
        '...
        hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        OpenChildForm(New Form3())
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
#End Region

    Private Sub btnEqualizer_Click(sender As Object, e As EventArgs) Handles btnEqualizer.Click
        '...
        'your codes
        '...
        OpenChildForm(New Form5())
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        '...
        'your codes
        '...
        OpenChildForm(New Form6())

        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            Process.Start("steam://")
            Process.Start("ts3server://Legionrp.ts35.ovh")
            Process.Start("discord://")
            Thread.Sleep(7000)

            Dim p As New Process
            Dim appData As String ' = GetFolderPath(SpecialFolder.LocalApplicationData)
            appData = "fivem://connect/5.181.31.171:30120"
            ' Display the path
            ' Console.WriteLine("App Data Folder Path: " & appData)
            Dim ps As New ProcessStartInfo("explorer.exe", appData)
            p.StartInfo = ps
            p.Start()

            'Process.Start("FiveM://")
            'fivem://connect/cfx.re/join/e23ywr
        Catch
            MessageBox.Show("Vai in Tools e installa tutti e tre i software")

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenChildForm(New Form7())

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        If currentForm IsNot Nothing Then currentForm.Close()


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        OpenChildForm(New Form3())
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.legionrp.it/")
    End Sub
End Class
