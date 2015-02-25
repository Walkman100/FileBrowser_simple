Public Class FileBrowser
    Dim WorkingDir As String = Environment.GetEnvironmentVariable("USERPROFILE")
    Dim LineIsOrigin, LineIsUpstream, notInserted As Boolean
'    Dim PSFiles() As String = {"CheckVersion.ps1", "GitPrompt.ps1", "GitTabExpansion.ps1", "GitUtils.ps1", "TortoiseGit.ps1", "Utils.ps1", "posh-git.psm1", "profile.example.ps1"}

    Private Sub ExitFB(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        Application.Exit()
    End Sub

    Private Sub LoadFB(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LastDir <> "" Then
            WorkingDir = My.Settings.LastDir
        End If
        RefreshList()
        ' command line args
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith("hidegui") Then
                Me.WindowState = FormWindowState.Minimized
            End If
        Next
    End Sub

    Private Sub RefreshList()
        FileBrowserList.Items.Clear()
        For Each Folder As String In System.IO.Directory.GetDirectories(WorkingDir)
            FileBrowserList.Items.Add(Mid(Folder, Len(WorkingDir) + 1))
        Next
    End Sub
    
    Private Sub CDHere() Handles FileBrowserList.DoubleClick
        If FileBrowserList.SelectedIndices.ToString <> "" Then
            WorkingDir = WorkingDir & FileBrowserList.SelectedItems.ToString & "\"
            My.Settings.LastDir = WorkingDir
            RefreshList()
        Else
            Try
                WorkingDir = WorkingDir.Remove(WorkingDir.Length - 1)
                WorkingDir = WorkingDir.Remove(WorkingDir.LastIndexOf("\"))
                WorkingDir = WorkingDir & "\"
                My.Settings.LastDir = WorkingDir
                RefreshList()
            Catch ex As System.ArgumentOutOfRangeException
                MsgBox("Cannot go higher than the root of a drive!", MsgBoxStyle.Critical, "Trying to go up from a drive root")
            End Try
        End If
    End Sub

'    Sub btnCD_Click(sender As Object, e As EventArgs) Handles btnCD.Click
'        If ShellWorker.IsBusy = False Then
'            ' show file chooser dialog, set result as Dir
'            folderBrowserDialog.SelectedPath = Dir
'            folderBrowserDialog.ShowDialog()
'            Dir = folderBrowserDialog.SelectedPath & "\"
'            My.Settings.SavedDir = Dir
'
'            ' rebuild list automatically
'            RebuildRepoList()
'        Else
'            MsgBox("A script is currently in progress! Changing directory will mess up the script. Please cancel using the button above first.", MsgBoxStyle.Critical)
'        End If
'    End Sub

'    Sub ContextMenuStripReposCopyRepoName_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposCopyRepoName.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Try
'                Clipboard.SetText(lstRepos.SelectedItem, TextDataFormat.UnicodeText)
'                MsgBox(lstRepos.SelectedItem & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        Else
'            Try
'                Clipboard.SetText(Dir, TextDataFormat.UnicodeText)
'                MsgBox(Dir & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        End If
'    End Sub
'
'    Sub ContextMenuStripReposCopyRepoPath_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposCopyRepoPath.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Try
'                Clipboard.SetText(Dir & lstRepos.SelectedItem, TextDataFormat.UnicodeText)
'                MsgBox(Dir & lstRepos.SelectedItem & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        Else
'            Try
'                Clipboard.SetText(Dir, TextDataFormat.UnicodeText)
'                MsgBox(Dir & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        End If
'    End Sub
'
'    Private Sub ContextMenuStripReposRemoveEntry_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposRemoveEntry.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            lstRepos.Items.RemoveAt(lstRepos.SelectedIndex)
'        End If
'    End Sub
End Class
