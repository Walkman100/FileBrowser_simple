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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowserList = New System.Windows.Forms.ListView()
        Me.FileBrowserTree = New System.Windows.Forms.TreeView()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripCut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripHelp = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MenuStripToolsSwitchMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripRepos.SuspendLayout
        Me.MenuStrip.SuspendLayout
        Me.ToolStrip.SuspendLayout
        CType(Me.SplitContainer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer.Panel1.SuspendLayout
        Me.SplitContainer.Panel2.SuspendLayout
        Me.SplitContainer.SuspendLayout
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
        'OpenFileDialog
        '
        Me.OpenFileDialog.AddExtension = false
        Me.OpenFileDialog.CheckFileExists = false
        Me.OpenFileDialog.CheckPathExists = false
        Me.OpenFileDialog.DereferenceLinks = false
        Me.OpenFileDialog.Filter = "All files|*.*"
        Me.OpenFileDialog.Multiselect = true
        Me.OpenFileDialog.SupportMultiDottedExtensions = true
        Me.OpenFileDialog.Title = "FileBrowser: Mode OpenFileDialog"
        Me.OpenFileDialog.ValidateNames = false
        '
        'FileBrowserList
        '
        Me.FileBrowserList.ContextMenuStrip = Me.ContextMenuStripRepos
        Me.FileBrowserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileBrowserList.Location = New System.Drawing.Point(0, 0)
        Me.FileBrowserList.Name = "FileBrowserList"
        Me.FileBrowserList.Size = New System.Drawing.Size(349, 602)
        Me.FileBrowserList.TabIndex = 1
        Me.FileBrowserList.UseCompatibleStateImageBehavior = false
        '
        'FileBrowserTree
        '
        Me.FileBrowserTree.ContextMenuStrip = Me.ContextMenuStripRepos
        Me.FileBrowserTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileBrowserTree.Location = New System.Drawing.Point(0, 0)
        Me.FileBrowserTree.Name = "FileBrowserTree"
        Me.FileBrowserTree.Size = New System.Drawing.Size(176, 602)
        Me.FileBrowserTree.TabIndex = 2
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(529, 22)
        Me.StatusStrip.TabIndex = 3
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripEdit, Me.MenuStripTools, Me.MenuStripHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "menuStrip1"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFileNew, Me.MenuStripFileSeparator1, Me.MenuStripFileSeparator2, Me.MenuStripFilePrint, Me.MenuStripFilePrintPreview, Me.MenuStripFileSeparator3, Me.MenuStripFileExit})
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(38, 20)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripFileNew
        '
        Me.MenuStripFileNew.Image = CType(resources.GetObject("MenuStripFileNew.Image"),System.Drawing.Image)
        Me.MenuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileNew.Name = "MenuStripFileNew"
        Me.MenuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.MenuStripFileNew.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileNew.Text = "&New"
        '
        'MenuStripFileSeparator1
        '
        Me.MenuStripFileSeparator1.Name = "MenuStripFileSeparator1"
        Me.MenuStripFileSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFileSeparator2
        '
        Me.MenuStripFileSeparator2.Name = "MenuStripFileSeparator2"
        Me.MenuStripFileSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFilePrint
        '
        Me.MenuStripFilePrint.Image = CType(resources.GetObject("MenuStripFilePrint.Image"),System.Drawing.Image)
        Me.MenuStripFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrint.Name = "MenuStripFilePrint"
        Me.MenuStripFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
        Me.MenuStripFilePrint.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFilePrint.Text = "&Print"
        '
        'MenuStripFilePrintPreview
        '
        Me.MenuStripFilePrintPreview.Image = CType(resources.GetObject("MenuStripFilePrintPreview.Image"),System.Drawing.Image)
        Me.MenuStripFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrintPreview.Name = "MenuStripFilePrintPreview"
        Me.MenuStripFilePrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFilePrintPreview.Text = "Print Pre&view"
        '
        'MenuStripFileSeparator3
        '
        Me.MenuStripFileSeparator3.Name = "MenuStripFileSeparator3"
        Me.MenuStripFileSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFileExit
        '
        Me.MenuStripFileExit.Name = "MenuStripFileExit"
        Me.MenuStripFileExit.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileExit.Text = "E&xit"
        '
        'MenuStripEdit
        '
        Me.MenuStripEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripEditUndo, Me.MenuStripEditRedo, Me.MenuStripEditSeparator1, Me.MenuStripEditCut, Me.MenuStripEditCopy, Me.MenuStripEditPaste, Me.MenuStripEditSeparator2, Me.MenuStripEditSelectAll})
        Me.MenuStripEdit.Name = "MenuStripEdit"
        Me.MenuStripEdit.Size = New System.Drawing.Size(40, 20)
        Me.MenuStripEdit.Text = "&Edit"
        '
        'MenuStripEditUndo
        '
        Me.MenuStripEditUndo.Name = "MenuStripEditUndo"
        Me.MenuStripEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z),System.Windows.Forms.Keys)
        Me.MenuStripEditUndo.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditUndo.Text = "&Undo"
        '
        'MenuStripEditRedo
        '
        Me.MenuStripEditRedo.Name = "MenuStripEditRedo"
        Me.MenuStripEditRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y),System.Windows.Forms.Keys)
        Me.MenuStripEditRedo.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditRedo.Text = "&Redo"
        '
        'MenuStripEditSeparator1
        '
        Me.MenuStripEditSeparator1.Name = "MenuStripEditSeparator1"
        Me.MenuStripEditSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripEditCut
        '
        Me.MenuStripEditCut.Image = CType(resources.GetObject("MenuStripEditCut.Image"),System.Drawing.Image)
        Me.MenuStripEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCut.Name = "MenuStripEditCut"
        Me.MenuStripEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.MenuStripEditCut.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditCut.Text = "Cu&t"
        '
        'MenuStripEditCopy
        '
        Me.MenuStripEditCopy.Image = CType(resources.GetObject("MenuStripEditCopy.Image"),System.Drawing.Image)
        Me.MenuStripEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCopy.Name = "MenuStripEditCopy"
        Me.MenuStripEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.MenuStripEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditCopy.Text = "&Copy"
        '
        'MenuStripEditPaste
        '
        Me.MenuStripEditPaste.Image = CType(resources.GetObject("MenuStripEditPaste.Image"),System.Drawing.Image)
        Me.MenuStripEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditPaste.Name = "MenuStripEditPaste"
        Me.MenuStripEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
        Me.MenuStripEditPaste.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditPaste.Text = "&Paste"
        '
        'MenuStripEditSeparator2
        '
        Me.MenuStripEditSeparator2.Name = "MenuStripEditSeparator2"
        Me.MenuStripEditSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripEditSelectAll
        '
        Me.MenuStripEditSelectAll.Name = "MenuStripEditSelectAll"
        Me.MenuStripEditSelectAll.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditSelectAll.Text = "Select &All"
        '
        'MenuStripTools
        '
        Me.MenuStripTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripToolsCustomize, Me.MenuStripToolsOptions, Me.MenuStripToolsSwitchMode})
        Me.MenuStripTools.Name = "MenuStripTools"
        Me.MenuStripTools.Size = New System.Drawing.Size(49, 20)
        Me.MenuStripTools.Text = "&Tools"
        '
        'MenuStripToolsCustomize
        '
        Me.MenuStripToolsCustomize.Name = "MenuStripToolsCustomize"
        Me.MenuStripToolsCustomize.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripToolsCustomize.Text = "&Customize"
        '
        'MenuStripToolsOptions
        '
        Me.MenuStripToolsOptions.Name = "MenuStripToolsOptions"
        Me.MenuStripToolsOptions.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripToolsOptions.Text = "&Options"
        '
        'MenuStripHelp
        '
        Me.MenuStripHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripHelpContents, Me.MenuStripHelpIndex, Me.MenuStripHelpSearch, Me.MenuStripHelpSeparator1, Me.MenuStripHelpAbout})
        Me.MenuStripHelp.Name = "MenuStripHelp"
        Me.MenuStripHelp.Size = New System.Drawing.Size(44, 20)
        Me.MenuStripHelp.Text = "&Help"
        '
        'MenuStripHelpContents
        '
        Me.MenuStripHelpContents.Name = "MenuStripHelpContents"
        Me.MenuStripHelpContents.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpContents.Text = "&Contents"
        '
        'MenuStripHelpIndex
        '
        Me.MenuStripHelpIndex.Name = "MenuStripHelpIndex"
        Me.MenuStripHelpIndex.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpIndex.Text = "&Index"
        '
        'MenuStripHelpSearch
        '
        Me.MenuStripHelpSearch.Name = "MenuStripHelpSearch"
        Me.MenuStripHelpSearch.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpSearch.Text = "&Search"
        '
        'MenuStripHelpSeparator1
        '
        Me.MenuStripHelpSeparator1.Name = "MenuStripHelpSeparator1"
        Me.MenuStripHelpSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripHelpAbout
        '
        Me.MenuStripHelpAbout.Name = "MenuStripHelpAbout"
        Me.MenuStripHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpAbout.Text = "&About..."
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNew, Me.ToolStripPrint, Me.ToolStripSeparator1, Me.ToolStripCut, Me.ToolStripCopy, Me.ToolStripPaste, Me.ToolStripSeparator2, Me.ToolStripHelp})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(529, 25)
        Me.ToolStrip.TabIndex = 5
        Me.ToolStrip.Text = "toolStrip1"
        '
        'ToolStripNew
        '
        Me.ToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNew.Image = CType(resources.GetObject("ToolStripNew.Image"),System.Drawing.Image)
        Me.ToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNew.Name = "ToolStripNew"
        Me.ToolStripNew.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNew.Text = "&New"
        '
        'ToolStripPrint
        '
        Me.ToolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPrint.Image = CType(resources.GetObject("ToolStripPrint.Image"),System.Drawing.Image)
        Me.ToolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPrint.Name = "ToolStripPrint"
        Me.ToolStripPrint.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripPrint.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCut
        '
        Me.ToolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCut.Image = CType(resources.GetObject("ToolStripCut.Image"),System.Drawing.Image)
        Me.ToolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCut.Name = "ToolStripCut"
        Me.ToolStripCut.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCut.Text = "C&ut"
        '
        'ToolStripCopy
        '
        Me.ToolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCopy.Image = CType(resources.GetObject("ToolStripCopy.Image"),System.Drawing.Image)
        Me.ToolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCopy.Name = "ToolStripCopy"
        Me.ToolStripCopy.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCopy.Text = "&Copy"
        '
        'ToolStripPaste
        '
        Me.ToolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPaste.Image = CType(resources.GetObject("ToolStripPaste.Image"),System.Drawing.Image)
        Me.ToolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPaste.Name = "ToolStripPaste"
        Me.ToolStripPaste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripPaste.Text = "&Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripHelp
        '
        Me.ToolStripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripHelp.Image = CType(resources.GetObject("ToolStripHelp.Image"),System.Drawing.Image)
        Me.ToolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHelp.Name = "ToolStripHelp"
        Me.ToolStripHelp.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripHelp.Text = "He&lp"
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.FileBrowserTree)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.FileBrowserList)
        Me.SplitContainer.Size = New System.Drawing.Size(529, 602)
        Me.SplitContainer.SplitterDistance = 176
        Me.SplitContainer.TabIndex = 6
        '
        'MenuStripToolsSwitchMode
        '
        Me.MenuStripToolsSwitchMode.Name = "MenuStripToolsSwitchMode"
        Me.MenuStripToolsSwitchMode.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripToolsSwitchMode.Text = "Switch Mode"
        '
        'FileBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 673)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FileBrowser"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileBrowser: Mode Custom"
        Me.ContextMenuStripRepos.ResumeLayout(false)
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.ToolStrip.ResumeLayout(false)
        Me.ToolStrip.PerformLayout
        Me.SplitContainer.Panel1.ResumeLayout(false)
        Me.SplitContainer.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents MenuStripToolsSwitchMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStripHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripHelpSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpContents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripToolsOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripToolsCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripEditRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFilePrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileBrowserTree As System.Windows.Forms.TreeView
    Friend WithEvents FileBrowserList As System.Windows.Forms.ListView
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStripReposGitPushThis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposGitPullThis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposCDHere As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposRemoveEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposCopyRepoPath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposCopyRepoName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposOpenURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenSLN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenReadme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposOpenInGitHub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInBash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInPS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInCMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInExplorer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripRepos As System.Windows.Forms.ContextMenuStrip

End Class
