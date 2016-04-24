Imports PS.ExeBase

Public Class Manager
    Implements PS.ExeBase.IManager

    Shared Property Syncer As New Syncer

    Public Sub ExecuteCommandLine() Implements IManager.ExecuteCommandLine
        If Args.ArgExists("source") = False OrElse Args.ArgExists("target") = False Then
            Util.ShowException("Required command line arguments are: source, target")
            Exit Sub
        End If

        Syncer.SourceFolder = Args.GetArg("source")
        Syncer.TargetFolder = Args.GetArg("target")
        Using frm As New SyncherForm
            frm.ShowDialog()
        End Using
    End Sub

    Public Function GetStartupForm() As Form Implements IManager.GetStartupForm
        Return New MainForm
    End Function
End Class
