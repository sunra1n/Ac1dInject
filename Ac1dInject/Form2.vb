Imports System.Net
Imports System
Public Class Form2
    Dim temp As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Shell("C:\Ac1dInject\cinject.exe -l", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim lol As New OpenFileDialog
        Dim name1 As String
        lol.Filter = "Profiles|*.crt"


        If lol.ShowDialog = Windows.Forms.DialogResult.OK Then
            name1 = lol.FileName

            Shell(temp & "\Ac1dInject\cinject.exe -i" & name1, AppWinStyle.Hide)
        Else
            MsgBox("OK, then not :) !", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Shell(temp & "\Ac1dInject\cinject.exe -r", AppWinStyle.Hide)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MsgBox("This take a while please do not close the black or this window ! Thanks :)", MsgBoxStyle.Information)
        Shell(temp & "\Ac1dInject\cinject.exe -B", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MsgBox("This take a while please do not close the black or this window ! Thanks :)", MsgBoxStyle.Information)
        Shell(temp & "\Ac1dInject\cinject.exe -R", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Shell(temp & "\Ac1dInject\cinject.exe -w", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Shell(temp & "\Ac1dInject\cinject.exe -h", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
      
        Try
            If My.Computer.FileSystem.FileExists(temp & "\Ac1dInject\cinject.exe") Then


            Else

                Dim client As WebClient = New WebClient
                client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\Ac1dInject\cinject")

                Dim client2 As WebClient = New WebClient
                client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\Ac1dInject\cinject.exe")

            End If
        Catch
            MsgBox("You can't use Ac1dInject at the moment :( Please connect to the internet !", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class