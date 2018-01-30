Public Class ANTI_CLASS

    '##############################
    '# Anti virtual environment   #
    '# By \\ NYAN CAT             #
    '#                            #
    '# Dim ANTI as new ANTI_CLASS #
    '# ANTI.ANTI_CLASS            #
    '##############################
   
    Public Sub RunAnti()
        Call VMware()
        Call Virtualbox()
        Call Sandboxie()
    End Sub

    Private Sub VMware()
        On Error Resume Next
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) & "\vmGuestLib.dll") Then
            System.Environment.Exit(0)
        End If
    End Sub

    Private Sub Virtualbox()
        On Error Resume Next
        If IO.File.Exists(Environment.GetEnvironmentVariable("windir") & "\vboxmrxnp.dll") Then
            System.Environment.Exit(0)
        End If
    End Sub

    Private Sub Sandboxie()
        On Error Resume Next
        If Process.GetProcessesByName("SbieSvc").Length >= 1 Then
            System.Environment.Exit(0)
        End If
    End Sub
    
End Class
