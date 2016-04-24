Imports PS.ExeBase

Public Class SyncherForm

    Private Output As Output.RichTextOutputWriter
    Private CancelSync As Boolean = False

    Private Sub SyncherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.InitializeFonts(Me)
        Manager.Syncer.Output = New Output.RichTextOutputWriter(txtOutput)
        Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            Manager.Syncer.Output.WriteLine("Analyzing differences...")
            Manager.Syncer.Analyze()

            If Manager.Syncer.HasChanges Then
                If MessageBox.Show(String.Format("You will be updating folder {5}{0}{0}Synchronizing these folders will make the following changes:{0}New files:{1}{1}{2}{0}Updated files:{1}{3}{0}Deleted files:{1}{4}{0}{0}Are you sure you want to continue?", vbCrLf, vbTab, Manager.Syncer.NewFiles.Count, Manager.Syncer.ChangedFiles.Count, Manager.Syncer.DeletedFiles.Count, Manager.Syncer.TargetFolder), "Confirm", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
                    CancelSync = True
                    Exit Sub
                End If
            Else
                MessageBox.Show("These folders are identical")
                CancelSync = True
                Exit Sub
            End If

            Manager.Syncer.Synchronize()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Manager.Syncer.Output.WriteLine(String.Format("{0}{0}AN ERROR OCCURRED{0}{0}{1}", vbCrLf, ex.ToString))
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Manager.Syncer.Cancel()
        Cursor = Cursors.Default
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Cursor = Cursors.Default
        If CancelSync = True Then
            'we're done
            Close()
        End If
    End Sub
End Class