Imports PS.ExeBase

Public Class MainForm

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.SourceFolder = txtSource.Text
        My.Settings.TargetFolder = txtTarget.Text
        My.Settings.Save()
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Util.InitializeFonts(Me)

        lblStatus.Text = String.Empty
        txtSource.Text = My.Settings.SourceFolder
        txtTarget.Text = My.Settings.TargetFolder

        Manager.Syncer.SourceFolder = txtSource.Text
        Manager.Syncer.TargetFolder = txtTarget.Text

    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Cursor = Cursors.WaitCursor
        For Each c As Control In Me.Controls
            c.Enabled = False
        Next
        bgAnalyze.RunWorkerAsync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "Select the Source folder to sync from"
        If String.IsNullOrEmpty(txtSource.Text) = False Then
            FolderBrowserDialog1.SelectedPath = txtSource.Text
        End If
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtSource.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.Description = "Select the Target folder to sync to"
        If String.IsNullOrEmpty(txtTarget.Text) = False Then
            FolderBrowserDialog1.SelectedPath = txtTarget.Text
        End If
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtTarget.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Using frm As New SyncherForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub txtSource_TextChanged(sender As Object, e As EventArgs) Handles txtSource.TextChanged
        Manager.Syncer.SourceFolder = txtSource.Text
    End Sub

    Private Sub txtTarget_TextChanged(sender As Object, e As EventArgs) Handles txtTarget.TextChanged
        Manager.Syncer.TargetFolder = txtTarget.Text
    End Sub

    Private Sub bgAnalyze_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgAnalyze.DoWork
        Try
            Manager.Syncer.Output = New PS.ExeBase.Output.LabelOutputWriter(lblStatus)
            Manager.Syncer.Analyze()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgAnalyze_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgAnalyze.RunWorkerCompleted
        Cursor = Cursors.Default
        lblStatus.Text = String.Empty
        For Each c As Control In Me.Controls
            c.Enabled = True
        Next
        Using frm As New ResultsForm
            frm.ShowDialog()
        End Using
    End Sub
End Class
