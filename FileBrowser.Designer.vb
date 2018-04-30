Partial Class FileBrowser
    Inherits System.Windows.Forms.Form
    
    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
    
    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileBrowser))
        Me.splitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.treeViewFolders = New System.Windows.Forms.TreeView()
        Me.imageListMain = New System.Windows.Forms.ImageList(Me.components)
        Me.listViewFiles = New System.Windows.Forms.ListView()
        Me.columnHeaderName = New System.Windows.Forms.ColumnHeader()
        Me.columnHeaderType = New System.Windows.Forms.ColumnHeader()
        Me.columnHeaderLastModified = New System.Windows.Forms.ColumnHeader()
        CType(Me.splitContainerMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainerMain.Panel1.SuspendLayout
        Me.splitContainerMain.Panel2.SuspendLayout
        Me.splitContainerMain.SuspendLayout
        Me.SuspendLayout
        '
        'splitContainerMain
        '
        Me.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.splitContainerMain.Name = "splitContainerMain"
        '
        'splitContainerMain.Panel1
        '
        Me.splitContainerMain.Panel1.Controls.Add(Me.treeViewFolders)
        '
        'splitContainerMain.Panel2
        '
        Me.splitContainerMain.Panel2.Controls.Add(Me.listViewFiles)
        Me.splitContainerMain.Size = New System.Drawing.Size(916, 580)
        Me.splitContainerMain.SplitterDistance = 305
        Me.splitContainerMain.TabIndex = 0
        '
        'treeViewFolders
        '
        Me.treeViewFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeViewFolders.ImageIndex = 0
        Me.treeViewFolders.ImageList = Me.imageListMain
        Me.treeViewFolders.Location = New System.Drawing.Point(0, 0)
        Me.treeViewFolders.Name = "treeViewFolders"
        Me.treeViewFolders.SelectedImageIndex = 0
        Me.treeViewFolders.Size = New System.Drawing.Size(305, 580)
        Me.treeViewFolders.TabIndex = 0
        '
        'imageListMain
        '
        Me.imageListMain.ImageStream = CType(resources.GetObject("imageListMain.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageListMain.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListMain.Images.SetKeyName(0, "imageres(#3)-Folder.ico")
        Me.imageListMain.Images.SetKeyName(1, "format-justify-center.png")
        '
        'listViewFiles
        '
        Me.listViewFiles.AllowColumnReorder = true
        Me.listViewFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderName, Me.columnHeaderType, Me.columnHeaderLastModified})
        Me.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listViewFiles.FullRowSelect = true
        Me.listViewFiles.GridLines = true
        Me.listViewFiles.HideSelection = false
        Me.listViewFiles.LabelEdit = true
        Me.listViewFiles.Location = New System.Drawing.Point(0, 0)
        Me.listViewFiles.Name = "listViewFiles"
        Me.listViewFiles.Size = New System.Drawing.Size(607, 580)
        Me.listViewFiles.SmallImageList = Me.imageListMain
        Me.listViewFiles.TabIndex = 0
        Me.listViewFiles.UseCompatibleStateImageBehavior = false
        Me.listViewFiles.View = System.Windows.Forms.View.Details
        '
        'columnHeaderName
        '
        Me.columnHeaderName.Text = "Name"
        '
        'columnHeaderType
        '
        Me.columnHeaderType.Text = "Type"
        '
        'columnHeaderLastModified
        '
        Me.columnHeaderLastModified.Text = "Last Modified"
        '
        'FileBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 580)
        Me.Controls.Add(Me.splitContainerMain)
        Me.Name = "FileBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileBrowser"
        Me.splitContainerMain.Panel1.ResumeLayout(false)
        Me.splitContainerMain.Panel2.ResumeLayout(false)
        CType(Me.splitContainerMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainerMain.ResumeLayout(false)
        Me.ResumeLayout(false)
    End Sub
    Private WithEvents columnHeaderLastModified As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeaderType As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeaderName As System.Windows.Forms.ColumnHeader
    Private WithEvents listViewFiles As System.Windows.Forms.ListView
    Private WithEvents treeViewFolders As System.Windows.Forms.TreeView
    Private imageListMain As System.Windows.Forms.ImageList
    Private splitContainerMain As System.Windows.Forms.SplitContainer
End Class
