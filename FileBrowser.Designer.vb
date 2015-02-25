<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileBrowser))
        Me.ContextMenuStripRepos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStripReposOpenInExplorer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInCMD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInPS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInBash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInGitHub = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposOpenReadme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenSLN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposCopyRepoName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposCopyRepoPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposRemoveEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposCDHere = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposGitPullThis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposGitPushThis = New System.Windows.Forms.ToolStripMenuItem()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.indexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ContextMenuStripRepos.SuspendLayout
        Me.menuStrip1.SuspendLayout
        Me.toolStrip1.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'ContextMenuStripRepos
        '
        Me.ContextMenuStripRepos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuStripReposOpenInExplorer, Me.ContextMenuStripReposOpenInCMD, Me.ContextMenuStripReposOpenInPS, Me.ContextMenuStripReposOpenInBash, Me.ContextMenuStripReposOpenInGitHub, Me.ContextMenuStripReposSeparator1, Me.ContextMenuStripReposOpenReadme, Me.ContextMenuStripReposOpenSLN, Me.ContextMenuStripReposOpenURL, Me.ContextMenuStripReposSeparator2, Me.ContextMenuStripReposCopyRepoName, Me.ContextMenuStripReposCopyRepoPath, Me.ContextMenuStripReposSeparator3, Me.ContextMenuStripReposRemoveEntry, Me.ContextMenuStripReposCDHere, Me.ContextMenuStripReposSeparator4, Me.ContextMenuStripReposGitPullThis, Me.ContextMenuStripReposGitPushThis})
        Me.ContextMenuStripRepos.Name = "contextMenuStripRepos"
        Me.ContextMenuStripRepos.Size = New System.Drawing.Size(273, 336)
        '
        'ContextMenuStripReposOpenInExplorer
        '
        Me.ContextMenuStripReposOpenInExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInExplorer.Name = "ContextMenuStripReposOpenInExplorer"
        Me.ContextMenuStripReposOpenInExplorer.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInExplorer.Text = "Open Repo in Windows Explorer"
        '
        'ContextMenuStripReposOpenInCMD
        '
        Me.ContextMenuStripReposOpenInCMD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInCMD.Name = "ContextMenuStripReposOpenInCMD"
        Me.ContextMenuStripReposOpenInCMD.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInCMD.Text = "Open Repo in CMD"
        '
        'ContextMenuStripReposOpenInPS
        '
        Me.ContextMenuStripReposOpenInPS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInPS.Name = "ContextMenuStripReposOpenInPS"
        Me.ContextMenuStripReposOpenInPS.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInPS.Text = "Open Repo in Windows PowerShell"
        '
        'ContextMenuStripReposOpenInBash
        '
        Me.ContextMenuStripReposOpenInBash.Name = "ContextMenuStripReposOpenInBash"
        Me.ContextMenuStripReposOpenInBash.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInBash.Text = "Open Repo in Git Bash"
        '
        'ContextMenuStripReposOpenInGitHub
        '
        Me.ContextMenuStripReposOpenInGitHub.Name = "ContextMenuStripReposOpenInGitHub"
        Me.ContextMenuStripReposOpenInGitHub.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInGitHub.Text = "Open Repo in GitHub for Windows"
        '
        'ContextMenuStripReposSeparator1
        '
        Me.ContextMenuStripReposSeparator1.Name = "ContextMenuStripReposSeparator1"
        Me.ContextMenuStripReposSeparator1.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposOpenReadme
        '
        Me.ContextMenuStripReposOpenReadme.Name = "ContextMenuStripReposOpenReadme"
        Me.ContextMenuStripReposOpenReadme.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenReadme.Text = "Open Repo Readme"
        '
        'ContextMenuStripReposOpenSLN
        '
        Me.ContextMenuStripReposOpenSLN.Name = "ContextMenuStripReposOpenSLN"
        Me.ContextMenuStripReposOpenSLN.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenSLN.Text = "Open Repo SLN"
        '
        'ContextMenuStripReposOpenURL
        '
        Me.ContextMenuStripReposOpenURL.Name = "ContextMenuStripReposOpenURL"
        Me.ContextMenuStripReposOpenURL.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenURL.Text = "Open Repo URL"
        '
        'ContextMenuStripReposSeparator2
        '
        Me.ContextMenuStripReposSeparator2.Name = "ContextMenuStripReposSeparator2"
        Me.ContextMenuStripReposSeparator2.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposCopyRepoName
        '
        Me.ContextMenuStripReposCopyRepoName.Name = "ContextMenuStripReposCopyRepoName"
        Me.ContextMenuStripReposCopyRepoName.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCopyRepoName.Text = "Copy Repo Name"
        '
        'ContextMenuStripReposCopyRepoPath
        '
        Me.ContextMenuStripReposCopyRepoPath.Name = "ContextMenuStripReposCopyRepoPath"
        Me.ContextMenuStripReposCopyRepoPath.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCopyRepoPath.Text = "Copy Repo Path"
        '
        'ContextMenuStripReposSeparator3
        '
        Me.ContextMenuStripReposSeparator3.Name = "ContextMenuStripReposSeparator3"
        Me.ContextMenuStripReposSeparator3.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposRemoveEntry
        '
        Me.ContextMenuStripReposRemoveEntry.Name = "ContextMenuStripReposRemoveEntry"
        Me.ContextMenuStripReposRemoveEntry.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposRemoveEntry.Text = "Remove Entry"
        '
        'ContextMenuStripReposCDHere
        '
        Me.ContextMenuStripReposCDHere.Name = "ContextMenuStripReposCDHere"
        Me.ContextMenuStripReposCDHere.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCDHere.Text = "CD Here..."
        '
        'ContextMenuStripReposSeparator4
        '
        Me.ContextMenuStripReposSeparator4.Name = "ContextMenuStripReposSeparator4"
        Me.ContextMenuStripReposSeparator4.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposGitPullThis
        '
        Me.ContextMenuStripReposGitPullThis.Name = "ContextMenuStripReposGitPullThis"
        Me.ContextMenuStripReposGitPullThis.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposGitPullThis.Text = "Git Pull this"
        '
        'ContextMenuStripReposGitPushThis
        '
        Me.ContextMenuStripReposGitPushThis.Name = "ContextMenuStripReposGitPushThis"
        Me.ContextMenuStripReposGitPushThis.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposGitPushThis.Text = "Git Push this"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'listView1
        '
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.Location = New System.Drawing.Point(0, 0)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(349, 602)
        Me.listView1.TabIndex = 1
        Me.listView1.UseCompatibleStateImageBehavior = false
        '
        'treeView1
        '
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView1.Location = New System.Drawing.Point(0, 0)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Size = New System.Drawing.Size(176, 602)
        Me.treeView1.TabIndex = 2
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(529, 22)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.menuStrip1.TabIndex = 4
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator1, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"),System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.newToolStripMenuItem.Text = "&New"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"),System.Drawing.Image)
        Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.openToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"),System.Drawing.Image)
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.saveToolStripMenuItem.Text = "&Save"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.saveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"),System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.printToolStripMenuItem.Text = "&Print"
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"),System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.toolStripSeparator3, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator4, Me.selectAllToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.editToolStripMenuItem.Text = "&Edit"
        '
        'undoToolStripMenuItem
        '
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z),System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.undoToolStripMenuItem.Text = "&Undo"
        '
        'redoToolStripMenuItem
        '
        Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
        Me.redoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y),System.Windows.Forms.Keys)
        Me.redoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.redoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'cutToolStripMenuItem
        '
        Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"),System.Drawing.Image)
        Me.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.cutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.cutToolStripMenuItem.Text = "Cu&t"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"),System.Drawing.Image)
        Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.copyToolStripMenuItem.Text = "&Copy"
        '
        'pasteToolStripMenuItem
        '
        Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"),System.Drawing.Image)
        Me.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.pasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.selectAllToolStripMenuItem.Text = "Select &All"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customizeToolStripMenuItem, Me.optionsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'customizeToolStripMenuItem
        '
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.customizeToolStripMenuItem.Text = "&Customize"
        '
        'optionsToolStripMenuItem
        '
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.optionsToolStripMenuItem.Text = "&Options"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator5, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "&Help"
        '
        'contentsToolStripMenuItem
        '
        Me.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
        Me.contentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.contentsToolStripMenuItem.Text = "&Contents"
        '
        'indexToolStripMenuItem
        '
        Me.indexToolStripMenuItem.Name = "indexToolStripMenuItem"
        Me.indexToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.indexToolStripMenuItem.Text = "&Index"
        '
        'searchToolStripMenuItem
        '
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.searchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aboutToolStripMenuItem.Text = "&About..."
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator6, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator7, Me.helpToolStripButton})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(529, 25)
        Me.toolStrip1.TabIndex = 5
        Me.toolStrip1.Text = "toolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"),System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"),System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"),System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"),System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"),System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"),System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"),System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"),System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.treeView1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.listView1)
        Me.splitContainer1.Size = New System.Drawing.Size(529, 602)
        Me.splitContainer1.SplitterDistance = 176
        Me.splitContainer1.TabIndex = 6
        '
        'FileBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 673)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "FileBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileBrowser"
        Me.ContextMenuStripRepos.ResumeLayout(false)
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private helpToolStripButton As System.Windows.Forms.ToolStripButton
    Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Private copyToolStripButton As System.Windows.Forms.ToolStripButton
    Private cutToolStripButton As System.Windows.Forms.ToolStripButton
    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private printToolStripButton As System.Windows.Forms.ToolStripButton
    Private saveToolStripButton As System.Windows.Forms.ToolStripButton
    Private openToolStripButton As System.Windows.Forms.ToolStripButton
    Private newToolStripButton As System.Windows.Forms.ToolStripButton
    Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private toolTip1 As System.Windows.Forms.ToolTip
    Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private indexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private contentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private customizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private redoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private undoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private treeView1 As System.Windows.Forms.TreeView
    Private listView1 As System.Windows.Forms.ListView
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend ContextMenuStripReposGitPushThis As System.Windows.Forms.ToolStripMenuItem
    Friend ContextMenuStripReposGitPullThis As System.Windows.Forms.ToolStripMenuItem
    Friend ContextMenuStripReposSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend ContextMenuStripReposCDHere As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposRemoveEntry As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private ContextMenuStripReposCopyRepoPath As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposCopyRepoName As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend ContextMenuStripReposOpenURL As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenSLN As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenReadme As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private ContextMenuStripReposOpenInGitHub As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenInBash As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenInPS As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenInCMD As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripReposOpenInExplorer As System.Windows.Forms.ToolStripMenuItem
    Private ContextMenuStripRepos As System.Windows.Forms.ContextMenuStrip

End Class
