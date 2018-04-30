Imports System.IO
Public Partial Class FileBrowser
    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()
        
    End Sub
    
    Sub FileBrowser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'PopulateTreeView("B:\")
        PopulateTreeView("..\..")
'        For Each item In System.IO.DriveInfo.GetDrives()
'            Try
'                PopulateTreeView(item.Name)
'            Catch ex As Exception
'                'treeViewFolders.Nodes.Item(item.Name).ToolTipText = ex.Message
'            End Try
'        Next
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "Select a folder to view:"
        If fbd.ShowDialog = DialogResult.OK Then
            PopulateTreeView(fbd.SelectedPath)
        End If
    End Sub
    
    Private Sub PopulateTreeView(path As String) 
        Dim rootNode As TreeNode
        
        Dim info As New DirectoryInfo(path)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            treeViewFolders.Nodes.Add(rootNode)
        End If
    
    End Sub
    
    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)
    
        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir
    
    End Sub
    
    Private Sub treeViewFolders_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles treeViewFolders.NodeMouseClick
    
        Dim newSelected As TreeNode = e.Node
        listViewFiles.Items.Clear()
        Dim nodeDirInfo As DirectoryInfo = _
        CType(newSelected.Tag, DirectoryInfo)
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing
    
        Dim dir As DirectoryInfo
        For Each dir In nodeDirInfo.GetDirectories()
            item = New ListViewItem(dir.Name, 0)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "Directory"), _
                New ListViewItem.ListViewSubItem(item, _
                dir.LastAccessTime.ToShortDateString())}
    
            item.SubItems.AddRange(subItems)
            listViewFiles.Items.Add(item)
        Next dir
        Dim file As FileInfo
        For Each file In nodeDirInfo.GetFiles()
            item = New ListViewItem(file.Name, 1)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "File"), _
                New ListViewItem.ListViewSubItem(item, _
                file.LastAccessTime.ToShortDateString())}
    
            item.SubItems.AddRange(subItems)
            listViewFiles.Items.Add(item)
        Next file
    
        listViewFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    
    End Sub
End Class
