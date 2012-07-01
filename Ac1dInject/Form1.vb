'I'm not proud about that source code :P  but it works ...
Imports System.Net
Imports System.Linq
Imports System
Imports System.IO
Imports System.Management
Imports MobileDevice

Public Class Form1
    Dim iphone As New MobileDevice.iPhone
    Dim cc As String
    Public path As String = ""
    Public path2 As String = ""
    Public path3 As String = ""
    Public ipsw As String = ""
    Dim temp As String

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("http://twitter.com/sunra1n_")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer6.Stop()
        Timer7.Stop()
        Timer9.Start()
        Button1.Enabled = False
        CheckBox1.Enabled = False
        Device.Text = "Ac1dInject will jailbreak your " & iPhonev & " now (this may take a while) "
        Label7.Text = iPhonev
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        If firmware = "5.1.1" Then


            CheckBox1.Enabled = True
            Try


                'Place where I'm going to store all of the necessary files

                'make sure directory doesn't already exist
                ' System.IO.Directory.CreateDirectory(temp & "\Ac1dInject")
                'System.IO.Directory.CreateDirectory("C:\Ac1dInject")
                My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data\payloads_rocky\", temp & "\Ac1dInject\payloads_rocky\", True)
            Catch
                MsgBox("Please run me again as admin :)")
            End Try
            '......... Download Image / Offline Cache Image ..........
            Try
                If My.Computer.FileSystem.FileExists(temp & "\Ac1dInject\cinject.exe") Then

                    Button1.Text = "Jailbreaking"
                    Timer13.Start()
                Else
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
                    Label1.Text = "Loading files ..."
                    IPodIPodProgressbar3.Enabled = True
                    Dim client4 As WebClient = New WebClient
                    client4.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/Y.bat"), temp & "\Ac1dInject\Y.bat") 'exchange the links :)
                    Dim client As WebClient = New WebClient
                    client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\Ac1dInject\cinject")
                    IPodProgressbar2.Value = 10
                    Dim client2 As WebClient = New WebClient
                   
                    client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\Ac1dInject\cinject.exe")
                    IPodProgressbar2.Value = 20
                    Button1.Text = "Jailbreaking"
                    Timer13.Start()
                End If

            Catch
                ' MsgBox("You can't use Absinthe at the moment :( Please connect to the internet !", MsgBoxStyle.Critical)
            End Try



        Else
            If Label7.Text = "5.0" Then
            ElseIf Label7.Text = "5.0.1" Then
                CheckBox1.Enabled = True
                Try


                    'Place where I'm going to store all of the necessary files

                    'make sure directory doesn't already exist
                    ' System.IO.Directory.CreateDirectory(temp & "\Ac1dInject")
                    'System.IO.Directory.CreateDirectory("C:\Ac1dInject")
                    My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data\payloads\", temp & "\payloads\", True)
                Catch
                    MsgBox("Please run me again as admin :)")
                End Try
                '......... Download Image / Offline Cache Image ..........
                Try
                    If My.Computer.FileSystem.FileExists(temp & "\Ac1dInject\cinject.exe") Then


                    Else
                        IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
                        Label1.Text = "Loading files ..."
                        IPodIPodProgressbar3.Enabled = True
                       
                        Dim client As WebClient = New WebClient
                        client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\Ac1dInject\cinject")
                        IPodProgressbar2.Value = 10
                        Dim client2 As WebClient = New WebClient
                        client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\Ac1dInject\cinject.exe")
                        IPodProgressbar2.Value = 20
                        Button1.Text = "Jailbeaking"
                    End If
                Catch
                    ' MsgBox("You can't use Absinthe at the moment :( Please connect to the internet !", MsgBoxStyle.Critical)
                End Try
                If Button1.Text = "Jailbreaking" Then
                    Try
                        Label1.Text = "Install the cert ..."
                        CheckBox1.Enabled = False
                        If CheckBox1.CheckState = CheckState.Checked Then
                            Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.NormalFocus)
                            IPodIPodProgressbar3.Value = 40
                        Else
                            Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.Hide)
                            IPodIPodProgressbar3.Value = 40
                        End If

                        MsgBox("Please install the certificate now ! If you're done click ok ! :) Password : fill in NOTHING or maybe pod2g")
                        Button1.Text = "Processing ..."
                        Timer1.Start()
                        Button1.Enabled = False
                    Catch
                        'Button1.PerformClick()
                    End Try
                End If
            End If
            If Label7.Text = "" Then
            ElseIf Label7.Text = "iPod Touch 4" Then
            ElseIf Label7.Text = "iPod Touch 2G" Then
            ElseIf Label7.Text = "iPod Touch 2G" Then
            ElseIf Label7.Text = "iPod touch 1G" Then
            ElseIf Label7.Text = "iPad 1G" Then
            ElseIf Label7.Text = "iPhone 2G" Then
            ElseIf Label7.Text = "iPhone 3G" Then
            ElseIf Label7.Text = "iPhone 3GS" Then
            ElseIf Label7.Text = "iPhone 4" Then

                Label1.Text = "Loading redsn0w ..."
                Button1.Text = "Downloading ..."
                ' '  IPodProgressbar2.Value = 10
                Try
                    Timer9.Stop()

                    '  IPodProgressbar2.Style = ProgressBarStyle.Blocks
                    Label1.Text = "Loading redsn0w ..."
                    Device.Text = "You'll need to use redsn0w ... but Ac1dInject is here for you."
                    Dim client As WebClient = New WebClient
                    AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                    AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                    client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/redsn0w.exe"), temp & "\Ac1dInject\redsn0w.exe")
                    ' IPodProgressbar2.Value = 20



                Catch ex As Exception

                End Try
            End If
            '::: OLD 1.0 A5 JB Only Source Code :
            'If Label7.Text = "iPhone 4S" Then
            'ElseIf Label7.Text = "iPad 2G" Then

            '    CheckBox1.Enabled = True
            '    Try


            '        'Place where I'm going to store all of the necessary files

            '        'make sure directory doesn't already exist
            '        ' System.IO.Directory.CreateDirectory(temp & "\Ac1dInject")
            '        'System.IO.Directory.CreateDirectory("C:\Ac1dInject")
            '        My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data\payloads\", temp & "\payloads\", True)
            '    Catch
            '        MsgBox("Please run me again as admin :)")
            '    End Try
            '    '......... Download Image / Offline Cache Image ..........
            '    Try
            '        If My.Computer.FileSystem.FileExists(temp & "\Ac1dInject\cinject.exe") Then


            '        Else
            '            IPodProgressbar2.Style = ProgressBarStyle.Blocks
            '            Label1.Text = "Loading files ..."
            '            IPodProgressbar2.Enabled = True
            '            Dim client As WebClient = New WebClient
            '            client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\Ac1dInject\cinject")
            '            IPodProgressbar2.Value = 10
            '            Dim client2 As WebClient = New WebClient
            '            client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\Ac1dInject\cinject.exe")
            '            IPodProgressbar2.Value = 20
            '            Button1.Text = "Jailbeaking"
            '        End If
            '    Catch
            '        ' MsgBox("You can't use Absinthe at the moment :( Please connect to the internet !", MsgBoxStyle.Critical)
            '    End Try
            '    If Button1.Text = "Jailbreaking" Then
            '        Try
            '            Label1.Text = "Install the cert ..."
            '            CheckBox1.Enabled = False
            '            If CheckBox1.CheckState = CheckState.Checked Then
            '                Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.NormalFocus)
            '                IPodProgressbar2.Value = 40
            '            Else
            '                Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.Hide)
            '                IPodProgressbar2.Value = 40
            '            End If

            '            MsgBox("Please install the certificate now ! If you're done click ok ! :) Password : fill in NOTHING or maybe pod2g")
            '            Button1.Text = "Processing ..."
            '            Timer1.Start()
            '            Button1.Enabled = False
            '        Catch
            '            'Button1.PerformClick()
            '        End Try
            '    End If


        End If

    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        IPodProgressbar2.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
   

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        OpenFileDialog1.ShowDialog()
        Me.ipsw = OpenFileDialog1.FileName
        If Me.ipsw = "" Then
            MessageBox.Show("You didn't select an ipsw", "Ac1dInject")

        Else
            Shell(temp & "\Ac1dInject\redsn0w.exe -i " & Me.ipsw, AppWinStyle.NormalFocus)
            Timer10.Start()
            Label1.Text = "Done"
            Button1.Text = "Done"
            Device.Text = "Done"

        End If
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Shell("taskkill /IM:cinject.exe")
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:cinject.exe")
            path = temp & "\Ac1dInject\"

            'If My.Computer.FileSystem.DirectoryExists(path) = True Then
            ' My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
            ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")


        Catch

            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:ccinject.exe")
            path2 = temp & "\payloads\"
            'System.IO.Path.GetTempPath() & "Bluefreeze"
            If My.Computer.FileSystem.DirectoryExists(path2) = True Then
                My.Computer.FileSystem.DeleteDirectory(path2, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
                ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")



            End If
        Catch

            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:ccinject.exe")
            path3 = temp & "\payloads_rocky\"
            'System.IO.Path.GetTempPath() & "Bluefreeze"
            If My.Computer.FileSystem.DirectoryExists(path3) = True Then
                My.Computer.FileSystem.DeleteDirectory(path3, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
                ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")


            End If
        Catch
            Button2.PerformClick()
            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Shell("taskkill /IM:itunes.exe")
        Shell("taskkill /IM:cinject.exe")
        Timer6.Start()
        Timer19.Start()
        Label3.Text += 1

        ' This will kill the cinject process :)
        'Temporary path
        Dim temp As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        'Place where I'm going to store all of the necessary files
        mode = temp & "\Ac1dInject\"
        'make sure directory doesn't already exist
        System.IO.Directory.CreateDirectory(temp & "\Ac1dInject")
        'System.IO.Directory.CreateDirectory(temp & "\Ac1dInject\mode")
        Try
            System.IO.File.WriteAllBytes(mode & "\itunnel.exe", My.Resources.itunnel_mux_r61)
            System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", My.Resources.IPHUCWIN32)
            System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\readline5.dll", My.Resources.readline5)
            If System.IO.File.Exists("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll") Then
                System.IO.File.Delete("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
                System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            Else
                System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Button1.Text = "Processing ..." Then
            Try
                Label1.Text = "Preparing exploit ..."
                If CheckBox1.CheckState = CheckState.Checked Then
                    Shell(temp & "\Ac1dInject\cinject.exe -j " & temp & "\payloads\", AppWinStyle.NormalFocus) 'first command :)
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                Else
                    Shell(temp & "\Ac1dInject\cinject.exe -j " & temp & "\payloads\", AppWinStyle.Hide)
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                End If

                Timer2.Start()

                Timer3.Start()

                Timer1.Stop()

            Catch
                MsgBox("Please run Ac1dInject now again & click Jailbreak !", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ' cinject.exe = running ... = Label2.text = "CMD running" etc ...
        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cinject" Select p).ToArray()
        If processes.Count > 0 Then
            Label2.Text = "CMD running"
        Else
            Label2.Text = "CMD not running"
            Timer2.Stop()
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label2.Text = "CMD not running" Then
            Try
                Label1.Text = "Running exploit ..."
                If CheckBox1.CheckState = CheckState.Checked Then

                    Shell(temp & "\Ac1dInject\cinject.exe -w", AppWinStyle.NormalFocus)
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                    Timer3.Stop()
                Else

                    Shell(temp & "\Ac1dInject\cinject.exe -w", AppWinStyle.Hide)
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                    Timer3.Stop()
                End If

                Timer4.Start()
                Timer5.Start()

            Catch
                MsgBox("Please run Ac1dInject now again & click Jailbreak !", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cinject" Select p).ToArray()
        If processes.Count > 0 Then
            Label2.Text = "last step on"
        Else
            Label2.Text = "last step finish"
            Button1.Text = "Done"
            Button2.PerformClick()
            Timer4.Stop()
            Timer3.Stop()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:cinject.exe")
            path = temp & "\Ac1dInject\"

            If My.Computer.FileSystem.DirectoryExists(path) = True Then
                My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
                ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")
                ' IPodProgressbar2.Style = ProgressBarStyle.Blocks
                IPodProgressbar2.Value = 90
            End If
        Catch
            Button2.PerformClick()
            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:ccinject.exe")
            path2 = temp & "\payloads\"
            'System.IO.Path.GetTempPath() & "Bluefreeze"
            If My.Computer.FileSystem.DirectoryExists(path2) = True Then
                My.Computer.FileSystem.DeleteDirectory(path2, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
                ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")
                IPodLoader1.Visible = False
                MsgBox("Congratulations, your A5 Device is successfully jailbroken !", MsgBoxStyle.Exclamation)
                Label1.Text = "Done"
                Button1.Text = "Close Ac1dInject now :)"
                Timer9.Stop()
                Device.Text = "Done ... You can close Ac1dInject now."
                IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
                IPodProgressbar2.Value = 100
            End If
        Catch
            Button2.PerformClick()
            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
        Try
            Label1.Text = "Cleaning up ..."
            Shell("taskkill /IM:ccinject.exe")
            path3 = temp & "\payloads_rocky\"
            'System.IO.Path.GetTempPath() & "Bluefreeze"
            If My.Computer.FileSystem.DirectoryExists(path3) = True Then
                My.Computer.FileSystem.DeleteDirectory(path3, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
                ' MsgBox("Succesfully delete the temp folder !", MsgBoxStyle.Information, "XBoot Info")
                IPodLoader1.Visible = False
                MsgBox("Congratulations, your Device is successfully jailbroken !" & vbLf & "Please wait until your device resprings :)", MsgBoxStyle.Exclamation)
                Label1.Text = "Done"
                Button1.Text = "Close Ac1dInject now :)"
                Timer9.Stop()
                Device.Text = "Done ... You can close Ac1dInject now."
                IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
                IPodProgressbar2.Value = 100
            End If
        Catch
            Button2.PerformClick()
            ' MsgBox("An error has occurred !" & vbLf & "Please click the button once again ! Thanks ;)", MsgBoxStyle.Critical, "XBoot Info")
        End Try
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Counter.Text += 1
        If Counter.Text = "59" Then
            Timer5.Stop()
            MsgBox("Congratulations, your A5 Device is 3 steps away to be jailbroken !" & vbLf & "Last steps : " & vbLf & "1. Toggle the VPN switch in settings." & vbLf & "2. Ignore the VPN error and wait for reboot !" & vbLf & "3. Done, find Cydia! ", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer5.Start()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://sunra1n.su.funpic.de/donate/")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://sunra1n.su.funpic.de/")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        'Cool little thing for the waiting part, not important
        ' Button1.Enabled = False

        'Do this when iPhone is connected...
        If iphone.IsConnected = True Then
            Button1.Enabled = True
            'Label1.Text = "iDevice connected. Click on JAILBREAK to begin."
            'IPodProgressbar2.Style = ProgressBarStyle.Blocks
            Timer6.Stop()
            Timer7.Start()
            'Determine what type of device it is...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod Touch 3G"

            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod Touch 4"

            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod Touch 2G"

            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod touch 1G"

            ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
                iPhonev = "Apple TV 2G"

            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1G"

            ElseIf iphone.DeviceProductType = "iPad3,1" Then
                iPhonev = "The new iPad (3,1)"

            ElseIf iphone.DeviceProductType = "iPad3,2" Then
                iPhonev = "The new iPad (3,2)"

            ElseIf iphone.DeviceProductType = "iPad3,3" Then
                iPhonev = "The new iPad (3,3)"


            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3G"

            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3GS"

            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4S"



            End If
            If iphone.IsJailbreak = True Then
                Label1.Text = "Already jailbroken ..."
                Device.Text = "Your " & iPhonev & " is already jailbroken ..."
                Button1.Enabled = False
            Else
                firmware = iphone.DeviceVersion
                model = iphone.DeviceModelNumber
                Label7.Text = iPhonev
                iOSV.Text = firmware
                Device.Text = "" & iPhonev + " with " + firmware + " " + "(" & model & ")" & " detected. Press Jailbreak to begin."
                ' Device.Text = "Thanks for connect your  ·" & iPhonev + " " + "[ " + firmware + " " + "(" & model & ")" + " ]" & "·. Click Jailbreak to begin."
                CheckBox1.Enabled = True
            End If
            'Display it

        Else
            'If no device is connected then keep waiting

            Button1.Enabled = False
            If cc = "..." Then
                cc = ""
            End If
            cc = cc + "."
            Device.Text = "Please plug in your device " + cc
            Label1.Text = "Waiting ..."
        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If iphone.IsConnected = False Then
            'The user unplugged their device, wait for them to plug it back in
            'Resetting values
            Button1.Enabled = False
            iPhonev = ""
            firmware = ""
            model = ""

            'Device.Text = "Thanks for connect your  ·" & iPhonev + " " + "[ " + firmware + " " + "(" & model & ")" + " ]" & "·. Click Jailbreak to begin."

            IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
            If cc = "..." Then
                cc = ""
            End If
            cc = cc + "."
            Device.Text = "Please plug in your device " + cc
            Label1.Text = "Waiting ..."
        ElseIf iphone.IsConnected = True Then
            'The user plugged their devcie back in!
            Button1.Enabled = True
            IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks

            'Label1.Text = "iDevice connected. Click on JAILBREAK to begin."
            'Once again determine which device they have...
            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod Touch 3G"

            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod Touch 4"

            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod Touch 2G"

            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod touch 1G"

            ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
                iPhonev = "Apple TV 2G"

            ElseIf iphone.DeviceProductType = "iPad3,1" Then
                iPhonev = "The new iPad (3,1)"

            ElseIf iphone.DeviceProductType = "iPad3,2" Then
                iPhonev = "The new iPad (3,2)"

            ElseIf iphone.DeviceProductType = "iPad3,3" Then
                iPhonev = "The new iPad (3,3)"

            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1G"

            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3G"

            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3GS"

            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4S"

            End If

            If iphone.IsJailbreak = True Then
                Label1.Text = "Already jailbroken ..."
                Device.Text = "Your " & iPhonev & " is already jailbroken ..."
                Button1.Enabled = False
            Else
                firmware = iphone.DeviceVersion
                model = iphone.DeviceModelNumber
                Device.Text = "" & iPhonev + " with " + firmware + " " + "(" & model & ")" & " detected. Press Jailbreak to begin."
                CheckBox1.Enabled = True
            End If
            'Display it
        Else
            'If no device is connected then keep waiting

            Button1.Enabled = False
            If cc = "..." Then
                cc = ""
            End If
            cc = cc + "."
            Device.Text = "Please plug in your device " + cc
            Label1.Text = "Waiting ..."

        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Device.Text = iPhonev
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        If cc = "..." Then
            cc = ""
        End If
        cc = cc + "."
        Device.Text = "Ac1dInject will jailbreak your " & iPhonev & " now " & cc
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick

        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "redsn0w" Select p).ToArray()
        If processes.Count > 0 Then
            IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
            Device.Text = "RedSn0w is running. Please jailbreak your device with it."

        Else
            IPodLoader1.Visible = False
            Device.Text = "Thanks for using Ac1dInject. Enjoy your Jailbreak."
            Button1.Text = "Close Ac1dInject now :)"
            IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
            IPodProgressbar2.Value = 100

            'Button2.PerformClick()
            Timer4.Stop()
            Timer3.Stop()
            '  Timer10.Stop()
        End If
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Process.Start("http://twitter.com/sunra1n_")
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        If Label7.Text = "iPhone 4S" Then

            CheckBox1.Enabled = True
            Timer11.Stop()
        End If
    End Sub

    Private Sub Device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Device.Click

    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick

        If Button1.Text = "Processing ..." Then
            Try
                Label1.Text = "Beginning jailbreak ..."
                If CheckBox1.CheckState = CheckState.Checked Then
                    '  Shell(temp & "\Ac1dInject\cinject.exe -Y " & temp & "\payloads_rocky", AppWinStyle.NormalFocus) 'first command :)
                    ' Shell(temp & "\Ac1dInject\Y.bat", AppWinStyle.NormalFocus)
                    Process.Start(temp & "\Ac1dInject\Y.bat", AppWinStyle.NormalFocus)
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                    Timer12.Stop()
                    Timer14.Start()
                    Timer17.Start()

                    Timer15.Start()
                Else
                    Shell(temp & "\Ac1dInject\Y.bat", AppWinStyle.NormalFocus)
                    ' Shell(temp & "\Ac1dInject\cinject.exe  -Y " & temp & "\payloads_rocky", AppWinStyle.Hide)
                    Timer12.Stop()
                    Timer14.Start()
                    Timer17.Start()

                    Timer15.Start()
                    IPodIPodProgressbar3.Style = ProgressBarStyle.Marquee
                End If
                '   Timer12.Stop()
                Timer14.Start()


                'Timer3.Start()



            Catch
                '       MsgBox("Please run Ac1dInject now again & click Jailbreak !", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        If Button1.Text = "Jailbreaking" Then
            Try
                'Label1.Text = "Install the cert ..."
                'CheckBox1.Enabled = False
                'If CheckBox1.CheckState = CheckState.Checked Then
                '    Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.NormalFocus)
                '    IPodProgressbar2.Value = 40
                'Else
                '    Shell(temp & "\Ac1dInject\cinject.exe -i " & temp & "\payloads\jailbreak.mobileconfig ", AppWinStyle.Hide)
                '    IPodProgressbar2.Value = 40
                'End If

                'MsgBox("Please install the certificate now ! If you're done click ok ! :) Password : fill in NOTHING or maybe pod2g")
                Button1.Text = "Processing ..."
                Timer12.Start()
                IPodLoader1.Visible = True
                Button1.Enabled = False
                Timer13.Stop()
            Catch
                'Button1.PerformClick()
            End Try
        End If
    End Sub

    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick

        Label9.Text += 1
        If Label9.Text = "1" Then
            Label1.Text = "Beginning jailbreak ..."
            IPodProgressbar2.Value = 10
        End If
        If Label9.Text = "3" Then
            Label1.Text = "Uploading jb files ..."
            IPodProgressbar2.Value = 20
        End If

        If Label9.Text = "4" Then
            Label1.Text = "Hiding media ..."
            IPodProgressbar2.Value = 30
        End If
        If Label9.Text = "6" Then
            Label1.Text = "Getting backup ..."
            IPodProgressbar2.Value = 40
        End If
        If Label9.Text = "8" Then
            Label1.Text = "Modifying backup (stage 1) ..."
            IPodProgressbar2.Value = 45

        End If
        If Label9.Text = "12" Then
            Label1.Text = "Restoring from modified backup (this may take a while) ..."
            IPodProgressbar2.Value = 55
        End If
        If Label9.Text = "16" Then
            Label1.Text = "Sending jailbreak data ... Your device will appear to be restoring a backup."
            IPodProgressbar2.Value = 60
        End If
        If Label9.Text = "24" Then
            Label1.Text = "Fetching racoon..."
            IPodProgressbar2.Value = 65
        End If
        If Label9.Text = "26" Then
            Label1.Text = "Patching racoon..."
            IPodProgressbar2.Value = 70

        End If
        If Label9.Text = "27" Then
            Label1.Text = "Modifying backup (stage 2)..."
            IPodProgressbar2.Value = 80

        End If
        If Label9.Text = "29" Then
            Label1.Text = "Restoring from modified backup..."
            IPodProgressbar2.Value = 83


        End If
        If Label9.Text = "31" Then
            Label1.Text = "Unhiding media..."
            IPodProgressbar2.Value = 86

        End If


        If Label9.Text = "33" Then
            Label1.Text = "Rebooting ..."
            IPodProgressbar2.Value = 90
        End If
        If Label9.Text = "40" Then
            Label1.Text = "Adding Cydia ..."
            IPodProgressbar2.Value = 90
        End If
    End Sub

    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        If Label2.Text = "CMD not running" Then
            Try
                Timer18.Start()


            Catch
                MsgBox("Please run Ac1dInject now again & click Jailbreak !", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick

        If Label2.Text = "CMD not running" Then
            Timer4.Start()
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick

        ' cinject.exe = running ... = Label2.text = "CMD running" etc ...
        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cmd" Select p).ToArray()
        If processes.Count > 0 Then
            Label2.Text = "CMD running"
        Else
            Label2.Text = "CMD not running"
            Timer17.Stop()
        End If

    End Sub

    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick

        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cmd" Select p).ToArray()
        If processes.Count > 0 Then
            Label2.Text = "last step on"
        Else
            Label2.Text = "last step finish"
            Button1.Text = "Done"
            Button2.PerformClick()
            Timer18.Stop()


        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer6.Stop()
        Timer7.Stop()
        Timer9.Start()
        Button1.Enabled = False
        CheckBox1.Enabled = False
        Device.Text = "Ac1dInject will jailbreak your " & iPhonev & " now (this may take a while) "
        Label7.Text = iPhonev
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        Try


            'Place where I'm going to store all of the necessary files

            'make sure directory doesn't already exist
            ' System.IO.Directory.CreateDirectory(temp & "\Ac1dInject")
            'System.IO.Directory.CreateDirectory("C:\Ac1dInject")
            My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data\payloads_rocky\", temp & "\Ac1dInject\payloads_rocky", True)
        Catch
            MsgBox("Please run me again as admin :)")
        End Try
        '......... Download Image / Offline Cache Image ..........
        Try
            If My.Computer.FileSystem.FileExists(temp & "\Ac1dInject\cinject.exe") Then

                Button1.Text = "Jailbreaking"
                Timer13.Start()
            Else
                IPodIPodProgressbar3.Style = ProgressBarStyle.Blocks
                Label1.Text = "Loading files ..."
                IPodIPodProgressbar3.Enabled = True
                Dim client4 As WebClient = New WebClient
                client4.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/Y.bat"), temp & "\Ac1dInject\Y.bat")
                Dim client As WebClient = New WebClient
                client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\Ac1dInject\cinject")
                IPodProgressbar2.Value = 10
                Dim client2 As WebClient = New WebClient
                client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\Ac1dInject\cinject.exe")
                IPodProgressbar2.Value = 20
                Button1.Text = "Jailbreaking"
                Timer13.Start()
            End If


        Catch
            ' MsgBox("You can't use Absinthe at the moment :( Please connect to the internet !", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        ' Process.Start(temp & "\cinject-0.5.4\Y.bat", AppWinStyle.NormalFocus)
        Process.Start(Application.StartupPath & "\cinject.exe -Y " & Application.StartupPath & "\payloads_rocky", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Process.Start("C:\cinject-0.5.3\Y.bat", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        Label3.Text += 1
        If Label3.Text = "6" Then
            Try
                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\payloads_rocky") = True Then
                Else
                    Dim client4 As WebClient = New WebClient
                    client4.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/Y.bat"), Application.StartupPath & "\Y.bat")
                    Dim client As WebClient = New WebClient
                    client.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), Application.StartupPath & "\cinject")
                    Dim client2 As WebClient = New WebClient
                    client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), Application.StartupPath & "\cinject.exe")
                    My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data\payloads_rocky\", Application.StartupPath & "\payloads_rocky\", True)
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
