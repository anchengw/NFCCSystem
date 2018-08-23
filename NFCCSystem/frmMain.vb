Public Class frmMain
    Inherits System.Windows.Forms.Form
    Dim WithEvents UserEvent As Easy.Win.EasyUser.EventHandler = EasyUser.EventHandler

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()
        ModProc.Active()
        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        EasyUser.LoadSkinsMenu(Me.cmdSkinMenu)
    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents C1MainMenu1 As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents cmdFileMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdHelpMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdBasicMgr As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAlarmSet As C1.Win.C1Command.C1Command
    Friend WithEvents cmdUserMgr As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdChangeUser As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAbout As C1.Win.C1Command.C1Command
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents C1CommandLink26 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink48 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdHelp As C1.Win.C1Command.C1Command
    Friend WithEvents MainMenu1 As Easy.Win.MainMenu.MainMenu
    Friend WithEvents NavigationPanel1 As Easy.Win.MainMenu.NavigationPanel
    Friend WithEvents cmdSkinMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink16 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSystemMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink17 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdShowTreeViewMenu As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink19 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink20 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdDBBackup As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRegister As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink21 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdWebSite As C1.Win.C1Command.C1Command
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stbState As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbClientName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbAccount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stbDeveloper As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents C1CommandLink24 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdAccountMgr As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink18 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdInitMgr As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink25 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdBillBatchCheck As C1.Win.C1Command.C1Command
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AlarmItem1 As Easy.Win.EasyReport.AlarmItem
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdShowMessagePanel As C1.Win.C1Command.C1Command
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSetMonthEnd As C1.Win.C1Command.C1Command
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDBInit As C1.Win.C1Command.C1Command
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.C1MainMenu1 = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdFileMenu = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdChangeUser = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdSetMonthEnd = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink24 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAccountMgr = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink25 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdBillBatchCheck = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdDBBackup = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdSkinMenu = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdShowTreeViewMenu = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdShowMessagePanel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.cmdHelpMenu = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink48 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdHelp = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink21 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdWebSite = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRegister = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdAbout = New C1.Win.C1Command.C1Command()
        Me.cmdBasicMgr = New C1.Win.C1Command.C1Command()
        Me.cmdAlarmSet = New C1.Win.C1Command.C1Command()
        Me.cmdUserMgr = New C1.Win.C1Command.C1Command()
        Me.cmdSystemMenu = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink17 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdDBInit = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdInitMgr = New C1.Win.C1Command.C1Command()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink16 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink18 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink19 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink20 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink26 = New C1.Win.C1Command.C1CommandLink()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu1 = New Easy.Win.MainMenu.MainMenu()
        Me.NavigationPanel1 = New Easy.Win.MainMenu.NavigationPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stbState = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbClientName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbAccount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stbDeveloper = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlarmItem1 = New Easy.Win.EasyReport.AlarmItem()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1MainMenu1
        '
        Me.C1MainMenu1.AccessibleName = "Menu Bar"
        Me.C1MainMenu1.CommandHolder = Me.C1CommandHolder1
        Me.C1MainMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink16, Me.C1CommandLink8})
        Me.C1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.C1MainMenu1.Name = "C1MainMenu1"
        Me.C1MainMenu1.Size = New System.Drawing.Size(784, 20)
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdFileMenu)
        Me.C1CommandHolder1.Commands.Add(Me.cmdHelpMenu)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBasicMgr)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAlarmSet)
        Me.C1CommandHolder1.Commands.Add(Me.cmdUserMgr)
        Me.C1CommandHolder1.Commands.Add(Me.cmdChangeUser)
        Me.C1CommandHolder1.Commands.Add(Me.cmdDBBackup)
        Me.C1CommandHolder1.Commands.Add(Me.cmdExit)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAbout)
        Me.C1CommandHolder1.Commands.Add(Me.cmdHelp)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSkinMenu)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSystemMenu)
        Me.C1CommandHolder1.Commands.Add(Me.cmdShowTreeViewMenu)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRegister)
        Me.C1CommandHolder1.Commands.Add(Me.cmdDBInit)
        Me.C1CommandHolder1.Commands.Add(Me.cmdWebSite)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAccountMgr)
        Me.C1CommandHolder1.Commands.Add(Me.cmdInitMgr)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBillBatchCheck)
        Me.C1CommandHolder1.Commands.Add(Me.cmdShowMessagePanel)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSetMonthEnd)
        Me.C1CommandHolder1.ImageList = Me.ImageList1
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdFileMenu
        '
        Me.cmdFileMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink13, Me.C1CommandLink10, Me.C1CommandLink24, Me.C1CommandLink25, Me.C1CommandLink14, Me.C1CommandLink12, Me.C1CommandLink3, Me.C1CommandLink7, Me.C1CommandLink15})
        Me.cmdFileMenu.HideNonRecentLinks = False
        Me.cmdFileMenu.Name = "cmdFileMenu"
        Me.cmdFileMenu.Text = "文件(&F)"
        '
        'C1CommandLink13
        '
        Me.C1CommandLink13.Command = Me.cmdChangeUser
        '
        'cmdChangeUser
        '
        Me.cmdChangeUser.ImageIndex = 2
        Me.cmdChangeUser.Name = "cmdChangeUser"
        Me.cmdChangeUser.Text = "更改操作员(&R)..."
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.cmdSetMonthEnd
        Me.C1CommandLink10.Delimiter = True
        Me.C1CommandLink10.SortOrder = 1
        '
        'cmdSetMonthEnd
        '
        Me.cmdSetMonthEnd.Name = "cmdSetMonthEnd"
        Me.cmdSetMonthEnd.Text = "月结"
        '
        'C1CommandLink24
        '
        Me.C1CommandLink24.Command = Me.cmdAccountMgr
        Me.C1CommandLink24.SortOrder = 2
        '
        'cmdAccountMgr
        '
        Me.cmdAccountMgr.Name = "cmdAccountMgr"
        Me.cmdAccountMgr.Text = "帐套管理"
        Me.cmdAccountMgr.Visible = False
        '
        'C1CommandLink25
        '
        Me.C1CommandLink25.Command = Me.cmdBillBatchCheck
        Me.C1CommandLink25.Delimiter = True
        Me.C1CommandLink25.SortOrder = 3
        '
        'cmdBillBatchCheck
        '
        Me.cmdBillBatchCheck.ImageIndex = 6
        Me.cmdBillBatchCheck.Name = "cmdBillBatchCheck"
        Me.cmdBillBatchCheck.Text = "单据管理中心"
        '
        'C1CommandLink14
        '
        Me.C1CommandLink14.Command = Me.cmdDBBackup
        Me.C1CommandLink14.Delimiter = True
        Me.C1CommandLink14.SortOrder = 4
        '
        'cmdDBBackup
        '
        Me.cmdDBBackup.ImageIndex = 3
        Me.cmdDBBackup.Name = "cmdDBBackup"
        Me.cmdDBBackup.Text = "数据备份..."
        '
        'C1CommandLink12
        '
        Me.C1CommandLink12.Command = Me.cmdSkinMenu
        Me.C1CommandLink12.Delimiter = True
        Me.C1CommandLink12.SortOrder = 5
        '
        'cmdSkinMenu
        '
        Me.cmdSkinMenu.Name = "cmdSkinMenu"
        Me.cmdSkinMenu.Text = "皮肤"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.cmdShowTreeViewMenu
        Me.C1CommandLink3.Delimiter = True
        Me.C1CommandLink3.SortOrder = 6
        '
        'cmdShowTreeViewMenu
        '
        Me.cmdShowTreeViewMenu.Name = "cmdShowTreeViewMenu"
        Me.cmdShowTreeViewMenu.Text = "显示树型菜单栏"
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.cmdShowMessagePanel
        Me.C1CommandLink7.SortOrder = 7
        '
        'cmdShowMessagePanel
        '
        Me.cmdShowMessagePanel.Name = "cmdShowMessagePanel"
        Me.cmdShowMessagePanel.Text = "显示消息面板"
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.cmdExit
        Me.C1CommandLink15.Delimiter = True
        Me.C1CommandLink15.SortOrder = 8
        '
        'cmdExit
        '
        Me.cmdExit.ImageIndex = 5
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.cmdExit.Text = "退出(&X)"
        '
        'cmdHelpMenu
        '
        Me.cmdHelpMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink48, Me.C1CommandLink21, Me.C1CommandLink4, Me.C1CommandLink9})
        Me.cmdHelpMenu.HideNonRecentLinks = False
        Me.cmdHelpMenu.Name = "cmdHelpMenu"
        Me.cmdHelpMenu.Text = "帮助(&H)"
        '
        'C1CommandLink48
        '
        Me.C1CommandLink48.Command = Me.cmdHelp
        '
        'cmdHelp
        '
        Me.cmdHelp.ImageIndex = 4
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.cmdHelp.Text = "帮助(&H)"
        Me.cmdHelp.Visible = False
        '
        'C1CommandLink21
        '
        Me.C1CommandLink21.Command = Me.cmdWebSite
        Me.C1CommandLink21.SortOrder = 1
        '
        'cmdWebSite
        '
        Me.cmdWebSite.Name = "cmdWebSite"
        Me.cmdWebSite.Text = "公司主页"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.cmdRegister
        Me.C1CommandLink4.Delimiter = True
        Me.C1CommandLink4.SortOrder = 2
        '
        'cmdRegister
        '
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Text = "使用单位注册(&R)..."
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.cmdAbout
        Me.C1CommandLink9.Delimiter = True
        Me.C1CommandLink9.SortOrder = 3
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Text = "关于(&A)"
        '
        'cmdBasicMgr
        '
        Me.cmdBasicMgr.ImageIndex = 0
        Me.cmdBasicMgr.Name = "cmdBasicMgr"
        Me.cmdBasicMgr.Text = "基础资料管理(&B)..."
        '
        'cmdAlarmSet
        '
        Me.cmdAlarmSet.Name = "cmdAlarmSet"
        Me.cmdAlarmSet.Text = "仓库辅料报警设定(&A)"
        Me.cmdAlarmSet.Visible = False
        '
        'cmdUserMgr
        '
        Me.cmdUserMgr.ImageIndex = 1
        Me.cmdUserMgr.Name = "cmdUserMgr"
        Me.cmdUserMgr.Text = "系统用户及权限管理(&U)"
        '
        'cmdSystemMenu
        '
        Me.cmdSystemMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink17, Me.C1CommandLink5, Me.C1CommandLink6, Me.C1CommandLink11})
        Me.cmdSystemMenu.HideNonRecentLinks = False
        Me.cmdSystemMenu.Name = "cmdSystemMenu"
        Me.cmdSystemMenu.Text = "基础设置(&S)"
        '
        'C1CommandLink17
        '
        Me.C1CommandLink17.Command = Me.cmdBasicMgr
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.cmdUserMgr
        Me.C1CommandLink5.SortOrder = 1
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.cmdDBInit
        Me.C1CommandLink6.Delimiter = True
        Me.C1CommandLink6.SortOrder = 2
        '
        'cmdDBInit
        '
        Me.cmdDBInit.Name = "cmdDBInit"
        Me.cmdDBInit.Text = "系统初始化(&Z)"
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Command = Me.cmdAlarmSet
        Me.C1CommandLink11.Delimiter = True
        Me.C1CommandLink11.SortOrder = 3
        '
        'cmdInitMgr
        '
        Me.cmdInitMgr.Name = "cmdInitMgr"
        Me.cmdInitMgr.Text = "期初数管理"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "Metallix Subscriptions.ico")
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.cmdFileMenu
        '
        'C1CommandLink16
        '
        Me.C1CommandLink16.Command = Me.cmdSystemMenu
        Me.C1CommandLink16.SortOrder = 1
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.cmdHelpMenu
        Me.C1CommandLink8.SortOrder = 2
        '
        'C1CommandLink18
        '
        Me.C1CommandLink18.Command = Me.cmdInitMgr
        Me.C1CommandLink18.SortOrder = 2
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Controls.Add(Me.C1ToolBar1)
        Me.C1CommandDock1.Id = 1
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 20)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(784, 48)
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.ButtonLookHorz = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink19, Me.C1CommandLink18, Me.C1CommandLink20, Me.C1CommandLink26})
        Me.C1ToolBar1.Location = New System.Drawing.Point(6, 0)
        Me.C1ToolBar1.Movable = False
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(491, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdBasicMgr
        Me.C1CommandLink2.Text = "基础资料管理"
        '
        'C1CommandLink19
        '
        Me.C1CommandLink19.Command = Me.cmdUserMgr
        Me.C1CommandLink19.SortOrder = 1
        Me.C1CommandLink19.Text = "系统用户及权限管理"
        '
        'C1CommandLink20
        '
        Me.C1CommandLink20.Command = Me.cmdHelp
        Me.C1CommandLink20.Delimiter = True
        Me.C1CommandLink20.SortOrder = 3
        '
        'C1CommandLink26
        '
        Me.C1CommandLink26.Command = Me.cmdExit
        Me.C1CommandLink26.Delimiter = True
        Me.C1CommandLink26.SortOrder = 4
        Me.C1CommandLink26.Text = "退出"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(200, 68)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 405)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 0)
        Me.Panel1.TabIndex = 19
        '
        'MainMenu1
        '
        Me.MainMenu1.AutoHide = False
        Me.MainMenu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu1.LeftBarImage = Nothing
        Me.MainMenu1.LeftMenuButtonImage = CType(resources.GetObject("MainMenu1.LeftMenuButtonImage"), System.Drawing.Image)
        Me.MainMenu1.Location = New System.Drawing.Point(0, 68)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.NavigationPanel = Nothing
        Me.MainMenu1.Size = New System.Drawing.Size(200, 405)
        Me.MainMenu1.TabIndex = 0
        Me.MainMenu1.ToolbarBackColor = System.Drawing.SystemColors.Control
        '
        'NavigationPanel1
        '
        Me.NavigationPanel1.ActiveLayerID = "Main"
        Me.NavigationPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavigationPanel1.BackColor = System.Drawing.Color.White
        Me.NavigationPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NavigationPanel1.Location = New System.Drawing.Point(-3, 24)
        Me.NavigationPanel1.MainMenu = Me.MainMenu1
        Me.NavigationPanel1.Name = "NavigationPanel1"
        Me.NavigationPanel1.Size = New System.Drawing.Size(376, 381)
        Me.NavigationPanel1.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stbState, Me.stbHelp, Me.stbClientName, Me.stbUserName, Me.stbAccount, Me.stbDeveloper})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 473)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stbState
        '
        Me.stbState.AutoSize = False
        Me.stbState.Name = "stbState"
        Me.stbState.Size = New System.Drawing.Size(84, 17)
        Me.stbState.Spring = True
        Me.stbState.Text = "就绪"
        Me.stbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stbHelp
        '
        Me.stbHelp.AutoSize = False
        Me.stbHelp.Name = "stbHelp"
        Me.stbHelp.Size = New System.Drawing.Size(200, 17)
        Me.stbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stbClientName
        '
        Me.stbClientName.AutoSize = False
        Me.stbClientName.Name = "stbClientName"
        Me.stbClientName.Size = New System.Drawing.Size(300, 17)
        Me.stbClientName.Text = "使用单位:"
        Me.stbClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stbUserName
        '
        Me.stbUserName.AutoSize = False
        Me.stbUserName.Name = "stbUserName"
        Me.stbUserName.Size = New System.Drawing.Size(150, 17)
        Me.stbUserName.Text = "操作员:"
        Me.stbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stbAccount
        '
        Me.stbAccount.Name = "stbAccount"
        Me.stbAccount.Size = New System.Drawing.Size(35, 17)
        Me.stbAccount.Text = "帐套:"
        '
        'stbDeveloper
        '
        Me.stbDeveloper.Name = "stbDeveloper"
        Me.stbDeveloper.Size = New System.Drawing.Size(203, 17)
        Me.stbDeveloper.Text = "开发单位:昆山常诚信息技术有限公司"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(204, 68)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.NavigationPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(580, 405)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.TabIndex = 27
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AlarmItem1)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(201, 405)
        Me.SplitContainer2.SplitterDistance = 132
        Me.SplitContainer2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "提醒："
        '
        'AlarmItem1
        '
        Me.AlarmItem1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlarmItem1.Location = New System.Drawing.Point(0, 24)
        Me.AlarmItem1.Name = "AlarmItem1"
        Me.AlarmItem1.ShowLastRefreshTime = True
        Me.AlarmItem1.Size = New System.Drawing.Size(201, 378)
        Me.AlarmItem1.TabIndex = 0
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "TABLE.ICO")
        Me.ImageList3.Images.SetKeyName(1, "1.ico")
        Me.ImageList3.Images.SetKeyName(2, "Second.ico")
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 495)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1CommandDock1)
        Me.Controls.Add(Me.C1MainMenu1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "日门管理系统"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim WithEvents MenuEvent As Easy.Win.MainMenu.EventHandler = EasyMenu.EventHandler

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.AlarmItem1.Dispose()

        'Me.MessageReceiver1.Dispose()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'EasyUser.SaveLocalValue("PWidth", Me.SplitContainer1.Size.Width)
        'EasyUser.SaveLocalValue("PHeight", Me.SplitContainer1.Size.Height)
        'EasyUser.SaveLocalValue("MMw", Me.MainMenu1.Size.Width)
        'EasyUser.SaveLocalValue("MMh", Me.MainMenu1.Size.Height)
        If MsgBox("你确定是要退出当前系统？", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "提示") = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Text = EasyUser.ProgramName
        Me.stbClientName.Text = "使用单位:昆山日门建筑装饰有限公司" '& EasyUser.ClientName
        'Me.stbDeveloper.Text = "主设计者:DongLai.YANG" '& EasyUser.Designer
        Me.stbDeveloper.Visible = False
        Me.stbUserName.Text = "操作员:" & EasyUser.GetLoginUserRealName()
        'Me.stbAccount.Text = "帐套:First2010" '& EasyUser.AccountName
        Me.stbAccount.Text = "帐套:" & EasyUser.AccountName
        Me.cmdShowMessagePanel.Checked = EasyUser.ReadLocalValue("ShowMessagePanel", 1) = "1"
        Me.SplitContainer1.Panel2Collapsed = Not Me.cmdShowMessagePanel.Checked
        Me.Timer1.Enabled = True
        EasyUser.LoadSkinsMenu(Me.cmdSkinMenu)
        ''''读取关闭窗体时保存的一些容器的宽度
        'If EasyUser.ReadLocalValue("PWidth") <> Nothing AndAlso EasyUser.ReadLocalValue("PHeight") <> Nothing AndAlso EasyUser.ReadLocalValue("MMw") <> Nothing AndAlso EasyUser.ReadLocalValue("MMh") <> Nothing Then
        '    Me.SplitContainer1.Size = New System.Drawing.Size(EasyUser.ReadLocalValue("PWidth"), EasyUser.ReadLocalValue("PHeight"))
        '    Me.MainMenu1.Size = New System.Drawing.Size(EasyUser.ReadLocalValue("MMw"), EasyUser.ReadLocalValue("MMh"))
        'End If
    End Sub

    Private Sub cmdBasicMgr_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdBasicMgr.Click
        EasyBase.Show(Me)
    End Sub

    Private Sub cmdUserMgr_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdUserMgr.Click
        EasyUser.ShowUser(Me)
    End Sub

    Private Sub cmdChangeUser_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdChangeUser.Click
        If EasyUser.Login Then
            Cnn = EasyUser.Connection
            CnnAccount = EasyUser.ConnectionAccount
            EasyBase.ConnectionMain = Cnn
            EasyBase.ConnectionAccount = CnnAccount
            EasyBill.ConnectionMain = Cnn
            EasyBill.ConnectionAccount = CnnAccount
            EasyWhere.ConnectionMain = Cnn
            EasyWhere.ConnectionAccount = CnnAccount
            EasyReport.ConnectionMain = Cnn
            EasyReport.ConnectionAccount = CnnAccount
            EasyMenu.Connection = Cnn

            UserID = EasyUser.LoginUserID
            EasyBase.UserID = UserID
            EasyBill.UserID = UserID
            EasyReport.UserID = UserID
            EasyWhere.UserID = UserID

            Me.MainMenu1.UserID = UserID
            Me.stbUserName.Text = "操作员:" & EasyUser.GetLoginUserRealName()
            Me.stbAccount.Text = "帐套:" & EasyUser.AccountName
        End If
    End Sub
    Private Sub cmdDBBackup_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdDBBackup.Click
        EasyUser.DBBackup()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAbout.Click
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
        frmAbout = Nothing
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdHelp.Click
        If Dir(Application.StartupPath & "\操作帮助.doc") <> "" Then
            Dim ProcessStartInfo As New System.Diagnostics.ProcessStartInfo
            ProcessStartInfo.FileName = Application.StartupPath & "\操作帮助.doc"
            ProcessStartInfo.WindowStyle = ProcessWindowStyle.Maximized
            System.Diagnostics.Process.Start(ProcessStartInfo)
            ProcessStartInfo = Nothing
        End If
    End Sub

    Private Sub MainMenu1_AutoHideChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenu1.AutoHideChanged
        Me.Splitter1.Visible = Not Me.MainMenu1.AutoHide
    End Sub
    Private Sub MainMenu1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenu1.VisibleChanged
        Me.cmdShowTreeViewMenu.Checked = Me.MainMenu1.Visible
        Me.Splitter1.Visible = Me.MainMenu1.Visible And Not Me.MainMenu1.AutoHide
    End Sub

    Private Sub cmdShowTreeViewMenu_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdShowTreeViewMenu.Click
        Me.MainMenu1.Visible = Not Me.MainMenu1.Visible

    End Sub



    Private Sub UserEvent_SkinChanged(ByVal sender As Object, ByVal e As Easy.Win.EasyUser.EventHandler.SkinChangedEventArgs) Handles UserEvent.SkinChanged
        Me.SuspendLayout()
        Me.Panel1.BackgroundImage = e.NewSkin.MainForm_TopBarImage
        Me.C1MainMenu1.BackColor = e.NewSkin.CommandBackColor
        Me.C1CommandDock1.BackColor = e.NewSkin.CommandBackColor
        Me.C1ToolBar1.BackColor = e.NewSkin.CommandBackColor
        Me.C1CommandHolder1.LookAndFeel = e.NewSkin.CommandLookAndFeel
        Me.Splitter1.BackColor = e.NewSkin.CommandBackColor
        Me.StatusStrip1.BackColor = e.NewSkin.CommandBackColor
        Me.SplitContainer1.BackColor = e.NewSkin.CommandBackColor
        EasyUser.SetSkin(Me.SplitContainer1.Panel2)
        Me.ResumeLayout()
    End Sub


    Private Sub cmdRegister_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRegister.Click
        EasyUser.Register()
    End Sub

    Private Sub UserEvent_AfterRegisterClient(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserEvent.AfterRegisterClient
        Me.Text = EasyUser.ClientName & "仓库管理系统"
        Me.stbClientName.Text = "使用单位:" & EasyUser.ClientName
    End Sub


    Private Sub cmdWebSite_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdWebSite.Click
        Try
            If EasyUser.DesignerWebSit <> "" Then
                System.Diagnostics.Process.Start(EasyUser.DesignerWebSit)
            End If
        Catch ex As Exception
            ' The error message
            MessageBox.Show("不能打开这个连接！")
        End Try
    End Sub



    Private Sub cmdLockSystem_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        EasyUser.LockSystem()
    End Sub


    Private Sub cmdAccountMgr_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAccountMgr.Click
        EasyUser.AccountMgr(Me)
    End Sub

    Private Sub cmdBillBatchCheck_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdBillBatchCheck.Click
        EasyBill.BillMgrCenter()
    End Sub


    Private Sub cmdShowMessagePanel_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdShowMessagePanel.Click
        sender.Checked = Not sender.Checked
        Me.SplitContainer1.Panel2Collapsed = Not sender.Checked
        EasyUser.SaveLocalValue("ShowMessagePanel", IIf(sender.Checked, 1, 0))
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Timer1.Enabled = False
        'EasyReport.ShowAlarm(Me)
    End Sub


    'Private Sub MenuEvent_CommandClick(ByVal sender As Object, ByVal e As Easy.Win.MainMenu.EventHandler.CommandClickEventArgs) Handles MenuEvent.CommandClick
    '    Select Case e.CommandName
    '        Case "Purchase"
    '            Me.NavigationPanel1.ShowLayer("naviPurchase")
    '        Case "sales"
    '            Me.NavigationPanel1.ShowLayer("naviSales")
    '        Case "Client"
    '            Me.NavigationPanel1.ShowLayer("naviClient")
    '        Case "Stock"
    '            Me.NavigationPanel1.ShowLayer("naviStock")
    '        Case "main"
    '            Me.NavigationPanel1.ShowLayer("naviMain")
    '    End Select
    'End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub AlarmItem1_AlarmItemSelected(ByVal sender As System.Object, ByVal e As Easy.Win.EasyReport.AlarmItem.AlarmItemSelectedEventArgs) Handles AlarmItem1.AlarmItemSelected

    End Sub
End Class
