Public Class ResultsForm

    Private Sub ResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvResults.Items.Add(New ListViewItem(New String() {"No Change", String.Format("There are {0} identical files", Manager.Syncer.SameFiles.Count)}))

        If Manager.Syncer.NewFiles.Count = 0 Then
            lvResults.Items.Add(New ListViewItem(New String() {"Create", "No files will be created"}))
        Else
            For Each f In Manager.Syncer.NewFiles
                lvResults.Items.Add(New ListViewItem(New String() {"Create", f}))
            Next
        End If

        If Manager.Syncer.ChangedFiles.Count = 0 Then
            lvResults.Items.Add(New ListViewItem(New String() {"Update", "No files will be updated"}))
        Else
            For Each f In Manager.Syncer.ChangedFiles
                lvResults.Items.Add(New ListViewItem(New String() {"Update", f}))
            Next

        End If

        If Manager.Syncer.DeletedFiles.Count = 0 Then
            lvResults.Items.Add(New ListViewItem(New String() {"Delete", "No files will be deleted"}))
        Else
            For Each f In Manager.Syncer.DeletedFiles
                lvResults.Items.Add(New ListViewItem(New String() {"Delete", f}))
            Next
        End If

    End Sub

   
End Class