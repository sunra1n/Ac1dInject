Module Module2
    Public firmware As String = ""
    Public iPhonev As String = ""
    Public model As String = ""
    Public extra As String = ""
    Public tether As Boolean = False
    Public bits As String
    Public itunesexists As Boolean = False
    Public mode As String
    Private Property window As ProcessWindowStyle

    Public Sub cmd(ByVal file As String, ByVal arg As String)
        'from stantheripper (who probably took it from iH8s0w)...
        Dim procNlite As New Process
        window = 1
        procNlite.StartInfo.FileName = file
        procNlite.StartInfo.Arguments = " " & arg
        procNlite.StartInfo.WindowStyle = window
        Application.DoEvents()
        procNlite.Start()
        Do Until procNlite.HasExited
            Application.DoEvents()
            For i = 0 To 5000000
                Application.DoEvents()
            Next
        Loop
        procNlite.WaitForExit()
    End Sub


End Module
