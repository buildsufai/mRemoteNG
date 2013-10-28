﻿Imports mRemoteNG.Controls
Imports SharedLibraryNG

Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmOptions
        Inherits System.Windows.Forms.Form

        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents lvPages As Controls.ListView
        Friend WithEvents imgListPages As System.Windows.Forms.ImageList
        Friend WithEvents chkWriteLogFile As System.Windows.Forms.CheckBox
        Friend WithEvents chkAutomaticallyGetSessionInfo As System.Windows.Forms.CheckBox
        Friend WithEvents lblXulRunnerPath As System.Windows.Forms.Label
        Friend WithEvents chkEncryptCompleteFile As System.Windows.Forms.CheckBox
        Friend WithEvents btnBrowseXulRunnerPath As System.Windows.Forms.Button
        Friend WithEvents chkUseCustomPuttyPath As System.Windows.Forms.CheckBox
        Friend WithEvents txtXULrunnerPath As System.Windows.Forms.TextBox
        Friend WithEvents txtCustomPuttyPath As System.Windows.Forms.TextBox
        Friend WithEvents lblUVNCSCPort As System.Windows.Forms.Label
        Friend WithEvents btnBrowseCustomPuttyPath As System.Windows.Forms.Button
        Friend WithEvents lblSeconds As System.Windows.Forms.Label
        Friend WithEvents btnLaunchPutty As System.Windows.Forms.Button
        Friend WithEvents numUVNCSCPort As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblConfigurePuttySessions As System.Windows.Forms.Label
        Friend WithEvents numPuttyWaitTime As System.Windows.Forms.NumericUpDown
        Friend WithEvents chkAutomaticReconnect As System.Windows.Forms.CheckBox
        Friend WithEvents lblMaximumPuttyWaitTime As System.Windows.Forms.Label
        Friend WithEvents lblUpdatesExplanation As System.Windows.Forms.Label
        Friend WithEvents pnlUpdateCheck As System.Windows.Forms.Panel
        Friend WithEvents btnUpdateCheckNow As System.Windows.Forms.Button
        Friend WithEvents chkCheckForUpdatesOnStartup As System.Windows.Forms.CheckBox
        Friend WithEvents cboUpdateCheckFrequency As System.Windows.Forms.ComboBox
        Friend WithEvents pnlProxy As System.Windows.Forms.Panel
        Friend WithEvents pnlProxyBasic As System.Windows.Forms.Panel
        Friend WithEvents lblProxyAddress As System.Windows.Forms.Label
        Friend WithEvents txtProxyAddress As System.Windows.Forms.TextBox
        Friend WithEvents lblProxyPort As System.Windows.Forms.Label
        Friend WithEvents numProxyPort As System.Windows.Forms.NumericUpDown
        Friend WithEvents chkUseProxyForAutomaticUpdates As System.Windows.Forms.CheckBox
        Friend WithEvents chkUseProxyAuthentication As System.Windows.Forms.CheckBox
        Friend WithEvents pnlProxyAuthentication As System.Windows.Forms.Panel
        Friend WithEvents lblProxyUsername As System.Windows.Forms.Label
        Friend WithEvents txtProxyUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblProxyPassword As System.Windows.Forms.Label
        Friend WithEvents txtProxyPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnTestProxy As System.Windows.Forms.Button
        Friend WithEvents pnlRdpReconnectionCount As System.Windows.Forms.Panel
        Friend WithEvents lblRdpReconnectionCount As System.Windows.Forms.Label
        Friend WithEvents numRdpReconnectionCount As System.Windows.Forms.NumericUpDown
        Friend WithEvents chkSingleClickOnConnectionOpensIt As System.Windows.Forms.CheckBox
        Friend WithEvents chkSingleClickOnOpenedConnectionSwitchesToIt As System.Windows.Forms.CheckBox
        Friend WithEvents pnlAutoSave As System.Windows.Forms.Panel
        Friend WithEvents lblAutoSave1 As System.Windows.Forms.Label
        Friend WithEvents numAutoSave As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblAutoSave2 As System.Windows.Forms.Label
        Friend WithEvents chkHostnameLikeDisplayName As System.Windows.Forms.CheckBox
        Friend WithEvents chkUseOnlyErrorsAndInfosPanel As System.Windows.Forms.CheckBox
        Friend WithEvents lblSwitchToErrorsAndInfos As System.Windows.Forms.Label
        Friend WithEvents chkMCInformation As System.Windows.Forms.CheckBox
        Friend WithEvents chkMCErrors As System.Windows.Forms.CheckBox
        Friend WithEvents chkMCWarnings As System.Windows.Forms.CheckBox
        Friend WithEvents chkOpenNewTabRightOfSelected As System.Windows.Forms.CheckBox
        Friend WithEvents chkShowProtocolOnTabs As System.Windows.Forms.CheckBox
        Friend WithEvents chkDoubleClickClosesTab As System.Windows.Forms.CheckBox
        Friend WithEvents chkShowLogonInfoOnTabs As System.Windows.Forms.CheckBox
        Friend WithEvents chkAlwaysShowPanelSelectionDlg As System.Windows.Forms.CheckBox
        Friend WithEvents lblLanguageRestartRequired As System.Windows.Forms.Label
        Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
        Friend WithEvents lblLanguage As System.Windows.Forms.Label
        Friend WithEvents chkShowDescriptionTooltipsInTree As System.Windows.Forms.CheckBox
        Friend WithEvents chkMinimizeToSystemTray As System.Windows.Forms.CheckBox
        Friend WithEvents chkShowSystemTrayIcon As System.Windows.Forms.CheckBox
        Friend WithEvents chkShowFullConnectionsFilePathInTitle As System.Windows.Forms.CheckBox
        Friend WithEvents chkSaveConsOnExit As System.Windows.Forms.CheckBox
        Friend WithEvents chkProperInstallationOfComponentsAtStartup As System.Windows.Forms.CheckBox
        Friend WithEvents chkSingleInstance As System.Windows.Forms.CheckBox
        Friend WithEvents chkReconnectOnStart As System.Windows.Forms.CheckBox
        Friend WithEvents tcTabControl As System.Windows.Forms.TabControl
        Friend WithEvents tabStartupExit As System.Windows.Forms.TabPage
        Friend WithEvents tabAppearance As System.Windows.Forms.TabPage
        Friend WithEvents tabTabsAndPanels As System.Windows.Forms.TabPage
        Friend WithEvents tabConnections As System.Windows.Forms.TabPage
        Friend WithEvents tabUpdates As System.Windows.Forms.TabPage
        Friend WithEvents tabAdvanced As System.Windows.Forms.TabPage
        Friend WithEvents tabSQLServer As System.Windows.Forms.TabPage
        Friend WithEvents pnlDefaultCredentials As System.Windows.Forms.Panel
        Friend WithEvents radCredentialsCustom As System.Windows.Forms.RadioButton
        Friend WithEvents lblDefaultCredentials As System.Windows.Forms.Label
        Friend WithEvents radCredentialsNoInfo As System.Windows.Forms.RadioButton
        Friend WithEvents radCredentialsWindows As System.Windows.Forms.RadioButton
        Friend WithEvents txtCredentialsDomain As System.Windows.Forms.TextBox
        Friend WithEvents lblCredentialsUsername As System.Windows.Forms.Label
        Friend WithEvents txtCredentialsPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblCredentialsPassword As System.Windows.Forms.Label
        Friend WithEvents txtCredentialsUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblCredentialsDomain As System.Windows.Forms.Label
        Friend WithEvents chkUseSQLServer As System.Windows.Forms.CheckBox
        Friend WithEvents lblSQLInfo As System.Windows.Forms.Label
        Friend WithEvents lblSQLUsername As System.Windows.Forms.Label
        Friend WithEvents txtSQLPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblSQLServer As System.Windows.Forms.Label
        Friend WithEvents txtSQLUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblSQLPassword As System.Windows.Forms.Label
        Friend WithEvents txtSQLServer As System.Windows.Forms.TextBox
        Friend WithEvents lblExperimental As System.Windows.Forms.Label
        Friend WithEvents lblSQLDatabaseName As System.Windows.Forms.Label
        Friend WithEvents txtSQLDatabaseName As System.Windows.Forms.TextBox
        Friend WithEvents chkAlwaysShowPanelTabs As System.Windows.Forms.CheckBox
        Friend WithEvents chkIdentifyQuickConnectTabs As System.Windows.Forms.CheckBox
        Friend WithEvents pnlConfirmCloseConnection As System.Windows.Forms.Panel
        Friend WithEvents lblClosingConnections As System.Windows.Forms.Label
        Friend WithEvents radCloseWarnAll As System.Windows.Forms.RadioButton
        Friend WithEvents radCloseWarnMultiple As System.Windows.Forms.RadioButton
        Friend WithEvents radCloseWarnExit As System.Windows.Forms.RadioButton
        Friend WithEvents radCloseWarnNever As System.Windows.Forms.RadioButton
        Friend WithEvents tabTheme As System.Windows.Forms.TabPage
        Friend WithEvents ThemePropertyGrid As System.Windows.Forms.PropertyGrid
        Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
        Friend WithEvents btnThemeNew As System.Windows.Forms.Button
        Friend WithEvents cboTheme As System.Windows.Forms.ComboBox
        Friend WithEvents btnThemeDelete As System.Windows.Forms.Button
        Friend WithEvents tabKeyboard As System.Windows.Forms.TabPage
        Private components As System.ComponentModel.IContainer

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim linKeyboardCommand As Microsoft.VisualBasic.PowerPacks.LineShape
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
            Dim Alignment1 As mRemoteNG.Controls.Alignment = New mRemoteNG.Controls.Alignment()
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Startup/Exit", "StartupExit_Icon.ico")
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Appearance", "Panels_Icon.ico")
            Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tabs & Panels", "Tab_Icon.ico")
            Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Connections", "Root_Icon.ico")
            Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SQL Server", "database.bmp")
            Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Updates", "Update_Icon.ico")
            Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Advanced", "Config_Icon.ico")
            Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Theme", "Appearance_Icon.ico")
            Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Keyboard", "Keyboard.png")
            Dim Alignment2 As mRemoteNG.Controls.Alignment = New mRemoteNG.Controls.Alignment()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.imgListPages = New System.Windows.Forms.ImageList(Me.components)
            Me.lblMaximumPuttyWaitTime = New System.Windows.Forms.Label()
            Me.chkAutomaticReconnect = New System.Windows.Forms.CheckBox()
            Me.numPuttyWaitTime = New System.Windows.Forms.NumericUpDown()
            Me.lblConfigurePuttySessions = New System.Windows.Forms.Label()
            Me.numUVNCSCPort = New System.Windows.Forms.NumericUpDown()
            Me.btnLaunchPutty = New System.Windows.Forms.Button()
            Me.lblSeconds = New System.Windows.Forms.Label()
            Me.btnBrowseCustomPuttyPath = New System.Windows.Forms.Button()
            Me.lblUVNCSCPort = New System.Windows.Forms.Label()
            Me.txtCustomPuttyPath = New System.Windows.Forms.TextBox()
            Me.txtXULrunnerPath = New System.Windows.Forms.TextBox()
            Me.chkUseCustomPuttyPath = New System.Windows.Forms.CheckBox()
            Me.btnBrowseXulRunnerPath = New System.Windows.Forms.Button()
            Me.chkEncryptCompleteFile = New System.Windows.Forms.CheckBox()
            Me.lblXulRunnerPath = New System.Windows.Forms.Label()
            Me.chkAutomaticallyGetSessionInfo = New System.Windows.Forms.CheckBox()
            Me.chkWriteLogFile = New System.Windows.Forms.CheckBox()
            Me.pnlProxy = New System.Windows.Forms.Panel()
            Me.pnlProxyBasic = New System.Windows.Forms.Panel()
            Me.lblProxyAddress = New System.Windows.Forms.Label()
            Me.txtProxyAddress = New System.Windows.Forms.TextBox()
            Me.lblProxyPort = New System.Windows.Forms.Label()
            Me.numProxyPort = New System.Windows.Forms.NumericUpDown()
            Me.chkUseProxyForAutomaticUpdates = New System.Windows.Forms.CheckBox()
            Me.chkUseProxyAuthentication = New System.Windows.Forms.CheckBox()
            Me.pnlProxyAuthentication = New System.Windows.Forms.Panel()
            Me.lblProxyUsername = New System.Windows.Forms.Label()
            Me.txtProxyUsername = New System.Windows.Forms.TextBox()
            Me.lblProxyPassword = New System.Windows.Forms.Label()
            Me.txtProxyPassword = New System.Windows.Forms.TextBox()
            Me.btnTestProxy = New System.Windows.Forms.Button()
            Me.pnlUpdateCheck = New System.Windows.Forms.Panel()
            Me.btnUpdateCheckNow = New System.Windows.Forms.Button()
            Me.chkCheckForUpdatesOnStartup = New System.Windows.Forms.CheckBox()
            Me.cboUpdateCheckFrequency = New System.Windows.Forms.ComboBox()
            Me.lblUpdatesExplanation = New System.Windows.Forms.Label()
            Me.chkHostnameLikeDisplayName = New System.Windows.Forms.CheckBox()
            Me.pnlAutoSave = New System.Windows.Forms.Panel()
            Me.lblAutoSave1 = New System.Windows.Forms.Label()
            Me.numAutoSave = New System.Windows.Forms.NumericUpDown()
            Me.lblAutoSave2 = New System.Windows.Forms.Label()
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt = New System.Windows.Forms.CheckBox()
            Me.chkSingleClickOnConnectionOpensIt = New System.Windows.Forms.CheckBox()
            Me.pnlRdpReconnectionCount = New System.Windows.Forms.Panel()
            Me.lblRdpReconnectionCount = New System.Windows.Forms.Label()
            Me.numRdpReconnectionCount = New System.Windows.Forms.NumericUpDown()
            Me.chkAlwaysShowPanelSelectionDlg = New System.Windows.Forms.CheckBox()
            Me.chkShowLogonInfoOnTabs = New System.Windows.Forms.CheckBox()
            Me.chkDoubleClickClosesTab = New System.Windows.Forms.CheckBox()
            Me.chkShowProtocolOnTabs = New System.Windows.Forms.CheckBox()
            Me.chkOpenNewTabRightOfSelected = New System.Windows.Forms.CheckBox()
            Me.chkMCWarnings = New System.Windows.Forms.CheckBox()
            Me.chkMCErrors = New System.Windows.Forms.CheckBox()
            Me.chkMCInformation = New System.Windows.Forms.CheckBox()
            Me.lblSwitchToErrorsAndInfos = New System.Windows.Forms.Label()
            Me.chkUseOnlyErrorsAndInfosPanel = New System.Windows.Forms.CheckBox()
            Me.chkShowFullConnectionsFilePathInTitle = New System.Windows.Forms.CheckBox()
            Me.chkShowSystemTrayIcon = New System.Windows.Forms.CheckBox()
            Me.chkMinimizeToSystemTray = New System.Windows.Forms.CheckBox()
            Me.chkShowDescriptionTooltipsInTree = New System.Windows.Forms.CheckBox()
            Me.lblLanguage = New System.Windows.Forms.Label()
            Me.cboLanguage = New System.Windows.Forms.ComboBox()
            Me.lblLanguageRestartRequired = New System.Windows.Forms.Label()
            Me.chkReconnectOnStart = New System.Windows.Forms.CheckBox()
            Me.chkSingleInstance = New System.Windows.Forms.CheckBox()
            Me.chkProperInstallationOfComponentsAtStartup = New System.Windows.Forms.CheckBox()
            Me.chkSaveConsOnExit = New System.Windows.Forms.CheckBox()
            Me.tcTabControl = New System.Windows.Forms.TabControl()
            Me.tabStartupExit = New System.Windows.Forms.TabPage()
            Me.tabAppearance = New System.Windows.Forms.TabPage()
            Me.tabTabsAndPanels = New System.Windows.Forms.TabPage()
            Me.chkAlwaysShowPanelTabs = New System.Windows.Forms.CheckBox()
            Me.chkIdentifyQuickConnectTabs = New System.Windows.Forms.CheckBox()
            Me.tabConnections = New System.Windows.Forms.TabPage()
            Me.pnlDefaultCredentials = New System.Windows.Forms.Panel()
            Me.radCredentialsCustom = New System.Windows.Forms.RadioButton()
            Me.lblDefaultCredentials = New System.Windows.Forms.Label()
            Me.radCredentialsNoInfo = New System.Windows.Forms.RadioButton()
            Me.radCredentialsWindows = New System.Windows.Forms.RadioButton()
            Me.txtCredentialsDomain = New System.Windows.Forms.TextBox()
            Me.lblCredentialsUsername = New System.Windows.Forms.Label()
            Me.txtCredentialsPassword = New System.Windows.Forms.TextBox()
            Me.lblCredentialsPassword = New System.Windows.Forms.Label()
            Me.txtCredentialsUsername = New System.Windows.Forms.TextBox()
            Me.lblCredentialsDomain = New System.Windows.Forms.Label()
            Me.pnlConfirmCloseConnection = New System.Windows.Forms.Panel()
            Me.lblClosingConnections = New System.Windows.Forms.Label()
            Me.radCloseWarnAll = New System.Windows.Forms.RadioButton()
            Me.radCloseWarnMultiple = New System.Windows.Forms.RadioButton()
            Me.radCloseWarnExit = New System.Windows.Forms.RadioButton()
            Me.radCloseWarnNever = New System.Windows.Forms.RadioButton()
            Me.tabSQLServer = New System.Windows.Forms.TabPage()
            Me.lblSQLDatabaseName = New System.Windows.Forms.Label()
            Me.txtSQLDatabaseName = New System.Windows.Forms.TextBox()
            Me.lblExperimental = New System.Windows.Forms.Label()
            Me.chkUseSQLServer = New System.Windows.Forms.CheckBox()
            Me.lblSQLUsername = New System.Windows.Forms.Label()
            Me.txtSQLPassword = New System.Windows.Forms.TextBox()
            Me.lblSQLInfo = New System.Windows.Forms.Label()
            Me.lblSQLServer = New System.Windows.Forms.Label()
            Me.txtSQLUsername = New System.Windows.Forms.TextBox()
            Me.txtSQLServer = New System.Windows.Forms.TextBox()
            Me.lblSQLPassword = New System.Windows.Forms.Label()
            Me.tabUpdates = New System.Windows.Forms.TabPage()
            Me.tabAdvanced = New System.Windows.Forms.TabPage()
            Me.tabTheme = New System.Windows.Forms.TabPage()
            Me.btnThemeDelete = New System.Windows.Forms.Button()
            Me.btnThemeNew = New System.Windows.Forms.Button()
            Me.cboTheme = New System.Windows.Forms.ComboBox()
            Me.ThemePropertyGrid = New System.Windows.Forms.PropertyGrid()
            Me.tabKeyboard = New System.Windows.Forms.TabPage()
            Me.btnResetKeyboardShortcuts = New System.Windows.Forms.Button()
            Me.btnDeleteKeyboardShortcut = New System.Windows.Forms.Button()
            Me.btnNewKeyboardShortcut = New System.Windows.Forms.Button()
            Me.grpModifyKeyboardShortcut = New System.Windows.Forms.GroupBox()
            Me.hotModifyKeyboardShortcut = New SharedLibraryNG.HotkeyControl()
            Me.lblKeyboardCommand = New System.Windows.Forms.Label()
            Me.lstKeyboardShortcuts = New System.Windows.Forms.ListBox()
            Me.lblKeyboardShortcuts = New System.Windows.Forms.Label()
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.lvKeyboardCommands = New mRemoteNG.Controls.ListView()
            Me.dlgColor = New System.Windows.Forms.ColorDialog()
            Me.lvPages = New mRemoteNG.Controls.ListView()
            linKeyboardCommand = New Microsoft.VisualBasic.PowerPacks.LineShape()
            CType(Me.numPuttyWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numUVNCSCPort, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlProxy.SuspendLayout()
            Me.pnlProxyBasic.SuspendLayout()
            CType(Me.numProxyPort, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlProxyAuthentication.SuspendLayout()
            Me.pnlUpdateCheck.SuspendLayout()
            Me.pnlAutoSave.SuspendLayout()
            CType(Me.numAutoSave, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRdpReconnectionCount.SuspendLayout()
            CType(Me.numRdpReconnectionCount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcTabControl.SuspendLayout()
            Me.tabStartupExit.SuspendLayout()
            Me.tabAppearance.SuspendLayout()
            Me.tabTabsAndPanels.SuspendLayout()
            Me.tabConnections.SuspendLayout()
            Me.pnlDefaultCredentials.SuspendLayout()
            Me.pnlConfirmCloseConnection.SuspendLayout()
            Me.tabSQLServer.SuspendLayout()
            Me.tabUpdates.SuspendLayout()
            Me.tabAdvanced.SuspendLayout()
            Me.tabTheme.SuspendLayout()
            Me.tabKeyboard.SuspendLayout()
            Me.grpModifyKeyboardShortcut.SuspendLayout()
            Me.SuspendLayout()
            '
            'linKeyboardCommand
            '
            linKeyboardCommand.Name = "linKeyboardCommand"
            linKeyboardCommand.X1 = 213
            linKeyboardCommand.X2 = 593
            linKeyboardCommand.Y1 = 25
            linKeyboardCommand.Y2 = 25
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.Location = New System.Drawing.Point(626, 507)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "&OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(707, 507)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'imgListPages
            '
            Me.imgListPages.ImageStream = CType(resources.GetObject("imgListPages.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgListPages.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imgListPages.Images.SetKeyName(0, "StartupExit_Icon.ico")
            Me.imgListPages.Images.SetKeyName(1, "Panels_Icon.ico")
            Me.imgListPages.Images.SetKeyName(2, "Tab_Icon.ico")
            Me.imgListPages.Images.SetKeyName(3, "Root_Icon.ico")
            Me.imgListPages.Images.SetKeyName(4, "database.bmp")
            Me.imgListPages.Images.SetKeyName(5, "Update_Icon.ico")
            Me.imgListPages.Images.SetKeyName(6, "Config_Icon.ico")
            Me.imgListPages.Images.SetKeyName(7, "Appearance_Icon.ico")
            Me.imgListPages.Images.SetKeyName(8, "Keyboard.png")
            '
            'lblMaximumPuttyWaitTime
            '
            Me.lblMaximumPuttyWaitTime.Location = New System.Drawing.Point(3, 188)
            Me.lblMaximumPuttyWaitTime.Name = "lblMaximumPuttyWaitTime"
            Me.lblMaximumPuttyWaitTime.Size = New System.Drawing.Size(364, 13)
            Me.lblMaximumPuttyWaitTime.TabIndex = 9
            Me.lblMaximumPuttyWaitTime.Text = "Maximum PuTTY wait time:"
            Me.lblMaximumPuttyWaitTime.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'chkAutomaticReconnect
            '
            Me.chkAutomaticReconnect.AutoSize = True
            Me.chkAutomaticReconnect.Location = New System.Drawing.Point(3, 72)
            Me.chkAutomaticReconnect.Name = "chkAutomaticReconnect"
            Me.chkAutomaticReconnect.Size = New System.Drawing.Size(399, 17)
            Me.chkAutomaticReconnect.TabIndex = 3
            Me.chkAutomaticReconnect.Text = "Automatically try to reconnect when disconnected from server (RDP && ICA only)"
            Me.chkAutomaticReconnect.UseVisualStyleBackColor = True
            '
            'numPuttyWaitTime
            '
            Me.numPuttyWaitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numPuttyWaitTime.Location = New System.Drawing.Point(373, 186)
            Me.numPuttyWaitTime.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
            Me.numPuttyWaitTime.Name = "numPuttyWaitTime"
            Me.numPuttyWaitTime.Size = New System.Drawing.Size(49, 20)
            Me.numPuttyWaitTime.TabIndex = 10
            Me.numPuttyWaitTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'lblConfigurePuttySessions
            '
            Me.lblConfigurePuttySessions.Location = New System.Drawing.Point(3, 157)
            Me.lblConfigurePuttySessions.Name = "lblConfigurePuttySessions"
            Me.lblConfigurePuttySessions.Size = New System.Drawing.Size(364, 13)
            Me.lblConfigurePuttySessions.TabIndex = 7
            Me.lblConfigurePuttySessions.Text = "To configure PuTTY sessions click this button:"
            Me.lblConfigurePuttySessions.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numUVNCSCPort
            '
            Me.numUVNCSCPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numUVNCSCPort.Location = New System.Drawing.Point(373, 279)
            Me.numUVNCSCPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.numUVNCSCPort.Name = "numUVNCSCPort"
            Me.numUVNCSCPort.Size = New System.Drawing.Size(72, 20)
            Me.numUVNCSCPort.TabIndex = 16
            Me.numUVNCSCPort.Value = New Decimal(New Integer() {5500, 0, 0, 0})
            '
            'btnLaunchPutty
            '
            Me.btnLaunchPutty.Image = Global.mRemoteNG.My.Resources.Resources.PuttyConfig
            Me.btnLaunchPutty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLaunchPutty.Location = New System.Drawing.Point(373, 152)
            Me.btnLaunchPutty.Name = "btnLaunchPutty"
            Me.btnLaunchPutty.Size = New System.Drawing.Size(110, 23)
            Me.btnLaunchPutty.TabIndex = 8
            Me.btnLaunchPutty.Text = "Launch PuTTY"
            Me.btnLaunchPutty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnLaunchPutty.UseVisualStyleBackColor = True
            '
            'lblSeconds
            '
            Me.lblSeconds.AutoSize = True
            Me.lblSeconds.Location = New System.Drawing.Point(428, 188)
            Me.lblSeconds.Name = "lblSeconds"
            Me.lblSeconds.Size = New System.Drawing.Size(47, 13)
            Me.lblSeconds.TabIndex = 11
            Me.lblSeconds.Text = "seconds"
            '
            'btnBrowseCustomPuttyPath
            '
            Me.btnBrowseCustomPuttyPath.Enabled = False
            Me.btnBrowseCustomPuttyPath.Location = New System.Drawing.Point(373, 116)
            Me.btnBrowseCustomPuttyPath.Name = "btnBrowseCustomPuttyPath"
            Me.btnBrowseCustomPuttyPath.Size = New System.Drawing.Size(75, 23)
            Me.btnBrowseCustomPuttyPath.TabIndex = 6
            Me.btnBrowseCustomPuttyPath.Text = "Browse..."
            Me.btnBrowseCustomPuttyPath.UseVisualStyleBackColor = True
            '
            'lblUVNCSCPort
            '
            Me.lblUVNCSCPort.Location = New System.Drawing.Point(3, 281)
            Me.lblUVNCSCPort.Name = "lblUVNCSCPort"
            Me.lblUVNCSCPort.Size = New System.Drawing.Size(364, 13)
            Me.lblUVNCSCPort.TabIndex = 15
            Me.lblUVNCSCPort.Text = "UltraVNC SingleClick Listening Port:"
            Me.lblUVNCSCPort.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCustomPuttyPath
            '
            Me.txtCustomPuttyPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCustomPuttyPath.Enabled = False
            Me.txtCustomPuttyPath.Location = New System.Drawing.Point(21, 118)
            Me.txtCustomPuttyPath.Name = "txtCustomPuttyPath"
            Me.txtCustomPuttyPath.Size = New System.Drawing.Size(346, 20)
            Me.txtCustomPuttyPath.TabIndex = 5
            '
            'txtXULrunnerPath
            '
            Me.txtXULrunnerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtXULrunnerPath.Location = New System.Drawing.Point(21, 238)
            Me.txtXULrunnerPath.Name = "txtXULrunnerPath"
            Me.txtXULrunnerPath.Size = New System.Drawing.Size(346, 20)
            Me.txtXULrunnerPath.TabIndex = 13
            '
            'chkUseCustomPuttyPath
            '
            Me.chkUseCustomPuttyPath.AutoSize = True
            Me.chkUseCustomPuttyPath.Location = New System.Drawing.Point(3, 95)
            Me.chkUseCustomPuttyPath.Name = "chkUseCustomPuttyPath"
            Me.chkUseCustomPuttyPath.Size = New System.Drawing.Size(146, 17)
            Me.chkUseCustomPuttyPath.TabIndex = 4
            Me.chkUseCustomPuttyPath.Text = "Use custom PuTTY path:"
            Me.chkUseCustomPuttyPath.UseVisualStyleBackColor = True
            '
            'btnBrowseXulRunnerPath
            '
            Me.btnBrowseXulRunnerPath.Location = New System.Drawing.Point(373, 236)
            Me.btnBrowseXulRunnerPath.Name = "btnBrowseXulRunnerPath"
            Me.btnBrowseXulRunnerPath.Size = New System.Drawing.Size(75, 23)
            Me.btnBrowseXulRunnerPath.TabIndex = 14
            Me.btnBrowseXulRunnerPath.Text = "Browse..."
            Me.btnBrowseXulRunnerPath.UseVisualStyleBackColor = True
            '
            'chkEncryptCompleteFile
            '
            Me.chkEncryptCompleteFile.AutoSize = True
            Me.chkEncryptCompleteFile.Location = New System.Drawing.Point(3, 26)
            Me.chkEncryptCompleteFile.Name = "chkEncryptCompleteFile"
            Me.chkEncryptCompleteFile.Size = New System.Drawing.Size(180, 17)
            Me.chkEncryptCompleteFile.TabIndex = 1
            Me.chkEncryptCompleteFile.Text = "Encrypt complete connection file"
            Me.chkEncryptCompleteFile.UseVisualStyleBackColor = True
            '
            'lblXulRunnerPath
            '
            Me.lblXulRunnerPath.AutoSize = True
            Me.lblXulRunnerPath.Location = New System.Drawing.Point(3, 220)
            Me.lblXulRunnerPath.Name = "lblXulRunnerPath"
            Me.lblXulRunnerPath.Size = New System.Drawing.Size(85, 13)
            Me.lblXulRunnerPath.TabIndex = 12
            Me.lblXulRunnerPath.Text = "XULrunner path:"
            '
            'chkAutomaticallyGetSessionInfo
            '
            Me.chkAutomaticallyGetSessionInfo.AutoSize = True
            Me.chkAutomaticallyGetSessionInfo.Location = New System.Drawing.Point(3, 49)
            Me.chkAutomaticallyGetSessionInfo.Name = "chkAutomaticallyGetSessionInfo"
            Me.chkAutomaticallyGetSessionInfo.Size = New System.Drawing.Size(198, 17)
            Me.chkAutomaticallyGetSessionInfo.TabIndex = 2
            Me.chkAutomaticallyGetSessionInfo.Text = "Automatically get session information"
            Me.chkAutomaticallyGetSessionInfo.UseVisualStyleBackColor = True
            '
            'chkWriteLogFile
            '
            Me.chkWriteLogFile.AutoSize = True
            Me.chkWriteLogFile.Location = New System.Drawing.Point(3, 3)
            Me.chkWriteLogFile.Name = "chkWriteLogFile"
            Me.chkWriteLogFile.Size = New System.Drawing.Size(171, 17)
            Me.chkWriteLogFile.TabIndex = 0
            Me.chkWriteLogFile.Text = "Write log file (mRemoteNG.log)"
            Me.chkWriteLogFile.UseVisualStyleBackColor = True
            '
            'pnlProxy
            '
            Me.pnlProxy.Controls.Add(Me.pnlProxyBasic)
            Me.pnlProxy.Controls.Add(Me.chkUseProxyForAutomaticUpdates)
            Me.pnlProxy.Controls.Add(Me.chkUseProxyAuthentication)
            Me.pnlProxy.Controls.Add(Me.pnlProxyAuthentication)
            Me.pnlProxy.Controls.Add(Me.btnTestProxy)
            Me.pnlProxy.Location = New System.Drawing.Point(3, 200)
            Me.pnlProxy.Name = "pnlProxy"
            Me.pnlProxy.Size = New System.Drawing.Size(536, 224)
            Me.pnlProxy.TabIndex = 2
            '
            'pnlProxyBasic
            '
            Me.pnlProxyBasic.Controls.Add(Me.lblProxyAddress)
            Me.pnlProxyBasic.Controls.Add(Me.txtProxyAddress)
            Me.pnlProxyBasic.Controls.Add(Me.lblProxyPort)
            Me.pnlProxyBasic.Controls.Add(Me.numProxyPort)
            Me.pnlProxyBasic.Enabled = False
            Me.pnlProxyBasic.Location = New System.Drawing.Point(8, 32)
            Me.pnlProxyBasic.Name = "pnlProxyBasic"
            Me.pnlProxyBasic.Size = New System.Drawing.Size(512, 40)
            Me.pnlProxyBasic.TabIndex = 1
            '
            'lblProxyAddress
            '
            Me.lblProxyAddress.Location = New System.Drawing.Point(8, 4)
            Me.lblProxyAddress.Name = "lblProxyAddress"
            Me.lblProxyAddress.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyAddress.TabIndex = 0
            Me.lblProxyAddress.Text = "Address:"
            Me.lblProxyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyAddress
            '
            Me.txtProxyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyAddress.Location = New System.Drawing.Point(104, 8)
            Me.txtProxyAddress.Name = "txtProxyAddress"
            Me.txtProxyAddress.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyAddress.TabIndex = 1
            '
            'lblProxyPort
            '
            Me.lblProxyPort.Location = New System.Drawing.Point(350, 5)
            Me.lblProxyPort.Name = "lblProxyPort"
            Me.lblProxyPort.Size = New System.Drawing.Size(64, 23)
            Me.lblProxyPort.TabIndex = 2
            Me.lblProxyPort.Text = "Port:"
            Me.lblProxyPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numProxyPort
            '
            Me.numProxyPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numProxyPort.Location = New System.Drawing.Point(420, 8)
            Me.numProxyPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.numProxyPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numProxyPort.Name = "numProxyPort"
            Me.numProxyPort.Size = New System.Drawing.Size(64, 20)
            Me.numProxyPort.TabIndex = 3
            Me.numProxyPort.Value = New Decimal(New Integer() {80, 0, 0, 0})
            '
            'chkUseProxyForAutomaticUpdates
            '
            Me.chkUseProxyForAutomaticUpdates.AutoSize = True
            Me.chkUseProxyForAutomaticUpdates.Location = New System.Drawing.Point(8, 8)
            Me.chkUseProxyForAutomaticUpdates.Name = "chkUseProxyForAutomaticUpdates"
            Me.chkUseProxyForAutomaticUpdates.Size = New System.Drawing.Size(168, 17)
            Me.chkUseProxyForAutomaticUpdates.TabIndex = 0
            Me.chkUseProxyForAutomaticUpdates.Text = "Use a proxy server to connect"
            Me.chkUseProxyForAutomaticUpdates.UseVisualStyleBackColor = True
            '
            'chkUseProxyAuthentication
            '
            Me.chkUseProxyAuthentication.AutoSize = True
            Me.chkUseProxyAuthentication.Enabled = False
            Me.chkUseProxyAuthentication.Location = New System.Drawing.Point(32, 80)
            Me.chkUseProxyAuthentication.Name = "chkUseProxyAuthentication"
            Me.chkUseProxyAuthentication.Size = New System.Drawing.Size(216, 17)
            Me.chkUseProxyAuthentication.TabIndex = 2
            Me.chkUseProxyAuthentication.Text = "This proxy server requires authentication"
            Me.chkUseProxyAuthentication.UseVisualStyleBackColor = True
            '
            'pnlProxyAuthentication
            '
            Me.pnlProxyAuthentication.Controls.Add(Me.lblProxyUsername)
            Me.pnlProxyAuthentication.Controls.Add(Me.txtProxyUsername)
            Me.pnlProxyAuthentication.Controls.Add(Me.lblProxyPassword)
            Me.pnlProxyAuthentication.Controls.Add(Me.txtProxyPassword)
            Me.pnlProxyAuthentication.Enabled = False
            Me.pnlProxyAuthentication.Location = New System.Drawing.Point(8, 104)
            Me.pnlProxyAuthentication.Name = "pnlProxyAuthentication"
            Me.pnlProxyAuthentication.Size = New System.Drawing.Size(512, 72)
            Me.pnlProxyAuthentication.TabIndex = 3
            '
            'lblProxyUsername
            '
            Me.lblProxyUsername.Location = New System.Drawing.Point(8, 4)
            Me.lblProxyUsername.Name = "lblProxyUsername"
            Me.lblProxyUsername.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyUsername.TabIndex = 0
            Me.lblProxyUsername.Text = "Username:"
            Me.lblProxyUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyUsername
            '
            Me.txtProxyUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyUsername.Location = New System.Drawing.Point(104, 8)
            Me.txtProxyUsername.Name = "txtProxyUsername"
            Me.txtProxyUsername.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyUsername.TabIndex = 1
            '
            'lblProxyPassword
            '
            Me.lblProxyPassword.Location = New System.Drawing.Point(8, 36)
            Me.lblProxyPassword.Name = "lblProxyPassword"
            Me.lblProxyPassword.Size = New System.Drawing.Size(96, 24)
            Me.lblProxyPassword.TabIndex = 2
            Me.lblProxyPassword.Text = "Password:"
            Me.lblProxyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtProxyPassword
            '
            Me.txtProxyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProxyPassword.Location = New System.Drawing.Point(104, 40)
            Me.txtProxyPassword.Name = "txtProxyPassword"
            Me.txtProxyPassword.Size = New System.Drawing.Size(240, 20)
            Me.txtProxyPassword.TabIndex = 3
            Me.txtProxyPassword.UseSystemPasswordChar = True
            '
            'btnTestProxy
            '
            Me.btnTestProxy.Location = New System.Drawing.Point(8, 184)
            Me.btnTestProxy.Name = "btnTestProxy"
            Me.btnTestProxy.Size = New System.Drawing.Size(120, 32)
            Me.btnTestProxy.TabIndex = 4
            Me.btnTestProxy.Text = "Test Proxy"
            Me.btnTestProxy.UseVisualStyleBackColor = True
            '
            'pnlUpdateCheck
            '
            Me.pnlUpdateCheck.Controls.Add(Me.btnUpdateCheckNow)
            Me.pnlUpdateCheck.Controls.Add(Me.chkCheckForUpdatesOnStartup)
            Me.pnlUpdateCheck.Controls.Add(Me.cboUpdateCheckFrequency)
            Me.pnlUpdateCheck.Location = New System.Drawing.Point(3, 48)
            Me.pnlUpdateCheck.Name = "pnlUpdateCheck"
            Me.pnlUpdateCheck.Size = New System.Drawing.Size(536, 120)
            Me.pnlUpdateCheck.TabIndex = 1
            '
            'btnUpdateCheckNow
            '
            Me.btnUpdateCheckNow.Location = New System.Drawing.Point(8, 80)
            Me.btnUpdateCheckNow.Name = "btnUpdateCheckNow"
            Me.btnUpdateCheckNow.Size = New System.Drawing.Size(120, 32)
            Me.btnUpdateCheckNow.TabIndex = 2
            Me.btnUpdateCheckNow.Text = "Check Now"
            Me.btnUpdateCheckNow.UseVisualStyleBackColor = True
            '
            'chkCheckForUpdatesOnStartup
            '
            Me.chkCheckForUpdatesOnStartup.AutoSize = True
            Me.chkCheckForUpdatesOnStartup.Location = New System.Drawing.Point(8, 8)
            Me.chkCheckForUpdatesOnStartup.Name = "chkCheckForUpdatesOnStartup"
            Me.chkCheckForUpdatesOnStartup.Size = New System.Drawing.Size(213, 17)
            Me.chkCheckForUpdatesOnStartup.TabIndex = 0
            Me.chkCheckForUpdatesOnStartup.Text = "Check for updates and announcements"
            Me.chkCheckForUpdatesOnStartup.UseVisualStyleBackColor = True
            '
            'cboUpdateCheckFrequency
            '
            Me.cboUpdateCheckFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboUpdateCheckFrequency.FormattingEnabled = True
            Me.cboUpdateCheckFrequency.Location = New System.Drawing.Point(48, 40)
            Me.cboUpdateCheckFrequency.Name = "cboUpdateCheckFrequency"
            Me.cboUpdateCheckFrequency.Size = New System.Drawing.Size(128, 21)
            Me.cboUpdateCheckFrequency.TabIndex = 1
            '
            'lblUpdatesExplanation
            '
            Me.lblUpdatesExplanation.Location = New System.Drawing.Point(3, 0)
            Me.lblUpdatesExplanation.Name = "lblUpdatesExplanation"
            Me.lblUpdatesExplanation.Size = New System.Drawing.Size(536, 40)
            Me.lblUpdatesExplanation.TabIndex = 0
            Me.lblUpdatesExplanation.Text = "mRemoteNG can periodically connect to the mRemoteNG website to check for updates " & _
        "and product announcements."
            '
            'chkHostnameLikeDisplayName
            '
            Me.chkHostnameLikeDisplayName.AutoSize = True
            Me.chkHostnameLikeDisplayName.Location = New System.Drawing.Point(3, 49)
            Me.chkHostnameLikeDisplayName.Name = "chkHostnameLikeDisplayName"
            Me.chkHostnameLikeDisplayName.Size = New System.Drawing.Size(328, 17)
            Me.chkHostnameLikeDisplayName.TabIndex = 2
            Me.chkHostnameLikeDisplayName.Text = "Set hostname like display name when creating new connections"
            Me.chkHostnameLikeDisplayName.UseVisualStyleBackColor = True
            '
            'pnlAutoSave
            '
            Me.pnlAutoSave.Controls.Add(Me.lblAutoSave1)
            Me.pnlAutoSave.Controls.Add(Me.numAutoSave)
            Me.pnlAutoSave.Controls.Add(Me.lblAutoSave2)
            Me.pnlAutoSave.Location = New System.Drawing.Point(3, 107)
            Me.pnlAutoSave.Name = "pnlAutoSave"
            Me.pnlAutoSave.Size = New System.Drawing.Size(596, 29)
            Me.pnlAutoSave.TabIndex = 4
            '
            'lblAutoSave1
            '
            Me.lblAutoSave1.Location = New System.Drawing.Point(6, 9)
            Me.lblAutoSave1.Name = "lblAutoSave1"
            Me.lblAutoSave1.Size = New System.Drawing.Size(288, 13)
            Me.lblAutoSave1.TabIndex = 0
            Me.lblAutoSave1.Text = "Auto Save every:"
            Me.lblAutoSave1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numAutoSave
            '
            Me.numAutoSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numAutoSave.Location = New System.Drawing.Point(300, 7)
            Me.numAutoSave.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.numAutoSave.Name = "numAutoSave"
            Me.numAutoSave.Size = New System.Drawing.Size(53, 20)
            Me.numAutoSave.TabIndex = 1
            '
            'lblAutoSave2
            '
            Me.lblAutoSave2.AutoSize = True
            Me.lblAutoSave2.Location = New System.Drawing.Point(359, 9)
            Me.lblAutoSave2.Name = "lblAutoSave2"
            Me.lblAutoSave2.Size = New System.Drawing.Size(135, 13)
            Me.lblAutoSave2.TabIndex = 2
            Me.lblAutoSave2.Text = "Minutes (0 means disabled)"
            '
            'chkSingleClickOnOpenedConnectionSwitchesToIt
            '
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.AutoSize = True
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.Location = New System.Drawing.Point(3, 26)
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.Name = "chkSingleClickOnOpenedConnectionSwitchesToIt"
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.Size = New System.Drawing.Size(254, 17)
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.TabIndex = 1
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.Text = "Single click on opened connection switches to it"
            Me.chkSingleClickOnOpenedConnectionSwitchesToIt.UseVisualStyleBackColor = True
            '
            'chkSingleClickOnConnectionOpensIt
            '
            Me.chkSingleClickOnConnectionOpensIt.AutoSize = True
            Me.chkSingleClickOnConnectionOpensIt.Location = New System.Drawing.Point(3, 3)
            Me.chkSingleClickOnConnectionOpensIt.Name = "chkSingleClickOnConnectionOpensIt"
            Me.chkSingleClickOnConnectionOpensIt.Size = New System.Drawing.Size(191, 17)
            Me.chkSingleClickOnConnectionOpensIt.TabIndex = 0
            Me.chkSingleClickOnConnectionOpensIt.Text = "Single click on connection opens it"
            Me.chkSingleClickOnConnectionOpensIt.UseVisualStyleBackColor = True
            '
            'pnlRdpReconnectionCount
            '
            Me.pnlRdpReconnectionCount.Controls.Add(Me.lblRdpReconnectionCount)
            Me.pnlRdpReconnectionCount.Controls.Add(Me.numRdpReconnectionCount)
            Me.pnlRdpReconnectionCount.Location = New System.Drawing.Point(3, 72)
            Me.pnlRdpReconnectionCount.Name = "pnlRdpReconnectionCount"
            Me.pnlRdpReconnectionCount.Size = New System.Drawing.Size(596, 29)
            Me.pnlRdpReconnectionCount.TabIndex = 3
            '
            'lblRdpReconnectionCount
            '
            Me.lblRdpReconnectionCount.Location = New System.Drawing.Point(6, 9)
            Me.lblRdpReconnectionCount.Name = "lblRdpReconnectionCount"
            Me.lblRdpReconnectionCount.Size = New System.Drawing.Size(288, 13)
            Me.lblRdpReconnectionCount.TabIndex = 0
            Me.lblRdpReconnectionCount.Text = "RDP Reconnection Count"
            Me.lblRdpReconnectionCount.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numRdpReconnectionCount
            '
            Me.numRdpReconnectionCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numRdpReconnectionCount.Location = New System.Drawing.Point(300, 7)
            Me.numRdpReconnectionCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numRdpReconnectionCount.Name = "numRdpReconnectionCount"
            Me.numRdpReconnectionCount.Size = New System.Drawing.Size(53, 20)
            Me.numRdpReconnectionCount.TabIndex = 1
            Me.numRdpReconnectionCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'chkAlwaysShowPanelSelectionDlg
            '
            Me.chkAlwaysShowPanelSelectionDlg.AutoSize = True
            Me.chkAlwaysShowPanelSelectionDlg.Location = New System.Drawing.Point(3, 141)
            Me.chkAlwaysShowPanelSelectionDlg.Name = "chkAlwaysShowPanelSelectionDlg"
            Me.chkAlwaysShowPanelSelectionDlg.Size = New System.Drawing.Size(317, 17)
            Me.chkAlwaysShowPanelSelectionDlg.TabIndex = 6
            Me.chkAlwaysShowPanelSelectionDlg.Text = "Always show panel selection dialog when opening connectins"
            Me.chkAlwaysShowPanelSelectionDlg.UseVisualStyleBackColor = True
            '
            'chkShowLogonInfoOnTabs
            '
            Me.chkShowLogonInfoOnTabs.AutoSize = True
            Me.chkShowLogonInfoOnTabs.Location = New System.Drawing.Point(3, 49)
            Me.chkShowLogonInfoOnTabs.Name = "chkShowLogonInfoOnTabs"
            Me.chkShowLogonInfoOnTabs.Size = New System.Drawing.Size(203, 17)
            Me.chkShowLogonInfoOnTabs.TabIndex = 2
            Me.chkShowLogonInfoOnTabs.Text = "Show logon information on tab names"
            Me.chkShowLogonInfoOnTabs.UseVisualStyleBackColor = True
            '
            'chkDoubleClickClosesTab
            '
            Me.chkDoubleClickClosesTab.AutoSize = True
            Me.chkDoubleClickClosesTab.Location = New System.Drawing.Point(3, 118)
            Me.chkDoubleClickClosesTab.Name = "chkDoubleClickClosesTab"
            Me.chkDoubleClickClosesTab.Size = New System.Drawing.Size(159, 17)
            Me.chkDoubleClickClosesTab.TabIndex = 5
            Me.chkDoubleClickClosesTab.Text = "Double click on tab closes it"
            Me.chkDoubleClickClosesTab.UseVisualStyleBackColor = True
            '
            'chkShowProtocolOnTabs
            '
            Me.chkShowProtocolOnTabs.AutoSize = True
            Me.chkShowProtocolOnTabs.Location = New System.Drawing.Point(3, 72)
            Me.chkShowProtocolOnTabs.Name = "chkShowProtocolOnTabs"
            Me.chkShowProtocolOnTabs.Size = New System.Drawing.Size(166, 17)
            Me.chkShowProtocolOnTabs.TabIndex = 3
            Me.chkShowProtocolOnTabs.Text = "Show protocols on tab names"
            Me.chkShowProtocolOnTabs.UseVisualStyleBackColor = True
            '
            'chkOpenNewTabRightOfSelected
            '
            Me.chkOpenNewTabRightOfSelected.AutoSize = True
            Me.chkOpenNewTabRightOfSelected.Location = New System.Drawing.Point(3, 26)
            Me.chkOpenNewTabRightOfSelected.Name = "chkOpenNewTabRightOfSelected"
            Me.chkOpenNewTabRightOfSelected.Size = New System.Drawing.Size(280, 17)
            Me.chkOpenNewTabRightOfSelected.TabIndex = 1
            Me.chkOpenNewTabRightOfSelected.Text = "Open new tab to the right of the currently selected tab"
            Me.chkOpenNewTabRightOfSelected.UseVisualStyleBackColor = True
            '
            'chkMCWarnings
            '
            Me.chkMCWarnings.AutoSize = True
            Me.chkMCWarnings.Enabled = False
            Me.chkMCWarnings.Location = New System.Drawing.Point(19, 256)
            Me.chkMCWarnings.Name = "chkMCWarnings"
            Me.chkMCWarnings.Size = New System.Drawing.Size(71, 17)
            Me.chkMCWarnings.TabIndex = 10
            Me.chkMCWarnings.Text = "Warnings"
            Me.chkMCWarnings.UseVisualStyleBackColor = True
            '
            'chkMCErrors
            '
            Me.chkMCErrors.AutoSize = True
            Me.chkMCErrors.Enabled = False
            Me.chkMCErrors.Location = New System.Drawing.Point(19, 279)
            Me.chkMCErrors.Name = "chkMCErrors"
            Me.chkMCErrors.Size = New System.Drawing.Size(53, 17)
            Me.chkMCErrors.TabIndex = 11
            Me.chkMCErrors.Text = "Errors"
            Me.chkMCErrors.UseVisualStyleBackColor = True
            '
            'chkMCInformation
            '
            Me.chkMCInformation.AutoSize = True
            Me.chkMCInformation.Enabled = False
            Me.chkMCInformation.Location = New System.Drawing.Point(19, 233)
            Me.chkMCInformation.Name = "chkMCInformation"
            Me.chkMCInformation.Size = New System.Drawing.Size(83, 17)
            Me.chkMCInformation.TabIndex = 9
            Me.chkMCInformation.Text = "Informations"
            Me.chkMCInformation.UseVisualStyleBackColor = True
            '
            'lblSwitchToErrorsAndInfos
            '
            Me.lblSwitchToErrorsAndInfos.AutoSize = True
            Me.lblSwitchToErrorsAndInfos.Location = New System.Drawing.Point(3, 213)
            Me.lblSwitchToErrorsAndInfos.Name = "lblSwitchToErrorsAndInfos"
            Me.lblSwitchToErrorsAndInfos.Size = New System.Drawing.Size(159, 13)
            Me.lblSwitchToErrorsAndInfos.TabIndex = 8
            Me.lblSwitchToErrorsAndInfos.Text = "Switch to Notifications panel on:"
            '
            'chkUseOnlyErrorsAndInfosPanel
            '
            Me.chkUseOnlyErrorsAndInfosPanel.AutoSize = True
            Me.chkUseOnlyErrorsAndInfosPanel.Location = New System.Drawing.Point(3, 188)
            Me.chkUseOnlyErrorsAndInfosPanel.Name = "chkUseOnlyErrorsAndInfosPanel"
            Me.chkUseOnlyErrorsAndInfosPanel.Size = New System.Drawing.Size(278, 17)
            Me.chkUseOnlyErrorsAndInfosPanel.TabIndex = 7
            Me.chkUseOnlyErrorsAndInfosPanel.Text = "Use only Notifications panel (no messagebox popups)"
            Me.chkUseOnlyErrorsAndInfosPanel.UseVisualStyleBackColor = True
            '
            'chkShowFullConnectionsFilePathInTitle
            '
            Me.chkShowFullConnectionsFilePathInTitle.AutoSize = True
            Me.chkShowFullConnectionsFilePathInTitle.Location = New System.Drawing.Point(3, 141)
            Me.chkShowFullConnectionsFilePathInTitle.Name = "chkShowFullConnectionsFilePathInTitle"
            Me.chkShowFullConnectionsFilePathInTitle.Size = New System.Drawing.Size(239, 17)
            Me.chkShowFullConnectionsFilePathInTitle.TabIndex = 4
            Me.chkShowFullConnectionsFilePathInTitle.Text = "Show full connections file path in window title"
            Me.chkShowFullConnectionsFilePathInTitle.UseVisualStyleBackColor = True
            '
            'chkShowSystemTrayIcon
            '
            Me.chkShowSystemTrayIcon.AutoSize = True
            Me.chkShowSystemTrayIcon.Location = New System.Drawing.Point(3, 187)
            Me.chkShowSystemTrayIcon.Name = "chkShowSystemTrayIcon"
            Me.chkShowSystemTrayIcon.Size = New System.Drawing.Size(172, 17)
            Me.chkShowSystemTrayIcon.TabIndex = 5
            Me.chkShowSystemTrayIcon.Text = "Always show System Tray Icon"
            Me.chkShowSystemTrayIcon.UseVisualStyleBackColor = True
            '
            'chkMinimizeToSystemTray
            '
            Me.chkMinimizeToSystemTray.AutoSize = True
            Me.chkMinimizeToSystemTray.Location = New System.Drawing.Point(3, 210)
            Me.chkMinimizeToSystemTray.Name = "chkMinimizeToSystemTray"
            Me.chkMinimizeToSystemTray.Size = New System.Drawing.Size(139, 17)
            Me.chkMinimizeToSystemTray.TabIndex = 6
            Me.chkMinimizeToSystemTray.Text = "Minimize to System Tray"
            Me.chkMinimizeToSystemTray.UseVisualStyleBackColor = True
            '
            'chkShowDescriptionTooltipsInTree
            '
            Me.chkShowDescriptionTooltipsInTree.AutoSize = True
            Me.chkShowDescriptionTooltipsInTree.Location = New System.Drawing.Point(3, 118)
            Me.chkShowDescriptionTooltipsInTree.Name = "chkShowDescriptionTooltipsInTree"
            Me.chkShowDescriptionTooltipsInTree.Size = New System.Drawing.Size(231, 17)
            Me.chkShowDescriptionTooltipsInTree.TabIndex = 3
            Me.chkShowDescriptionTooltipsInTree.Text = "Show description tooltips in connection tree"
            Me.chkShowDescriptionTooltipsInTree.UseVisualStyleBackColor = True
            '
            'lblLanguage
            '
            Me.lblLanguage.AutoSize = True
            Me.lblLanguage.Location = New System.Drawing.Point(3, 0)
            Me.lblLanguage.Name = "lblLanguage"
            Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
            Me.lblLanguage.TabIndex = 0
            Me.lblLanguage.Text = "Language"
            '
            'cboLanguage
            '
            Me.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboLanguage.FormattingEnabled = True
            Me.cboLanguage.Location = New System.Drawing.Point(3, 24)
            Me.cboLanguage.Name = "cboLanguage"
            Me.cboLanguage.Size = New System.Drawing.Size(304, 21)
            Me.cboLanguage.Sorted = True
            Me.cboLanguage.TabIndex = 1
            '
            'lblLanguageRestartRequired
            '
            Me.lblLanguageRestartRequired.AutoSize = True
            Me.lblLanguageRestartRequired.Location = New System.Drawing.Point(3, 56)
            Me.lblLanguageRestartRequired.Name = "lblLanguageRestartRequired"
            Me.lblLanguageRestartRequired.Size = New System.Drawing.Size(380, 13)
            Me.lblLanguageRestartRequired.TabIndex = 2
            Me.lblLanguageRestartRequired.Text = "mRemoteNG must be restarted before changes to the language will take effect."
            '
            'chkReconnectOnStart
            '
            Me.chkReconnectOnStart.AutoSize = True
            Me.chkReconnectOnStart.Location = New System.Drawing.Point(3, 27)
            Me.chkReconnectOnStart.Name = "chkReconnectOnStart"
            Me.chkReconnectOnStart.Size = New System.Drawing.Size(273, 17)
            Me.chkReconnectOnStart.TabIndex = 3
            Me.chkReconnectOnStart.Text = "Reconnect to previously opened sessions on startup"
            Me.chkReconnectOnStart.UseVisualStyleBackColor = True
            '
            'chkSingleInstance
            '
            Me.chkSingleInstance.AutoSize = True
            Me.chkSingleInstance.Location = New System.Drawing.Point(3, 51)
            Me.chkSingleInstance.Name = "chkSingleInstance"
            Me.chkSingleInstance.Size = New System.Drawing.Size(366, 17)
            Me.chkSingleInstance.TabIndex = 4
            Me.chkSingleInstance.Text = "Allow only a single instance of the application (mRemote restart required)"
            Me.chkSingleInstance.UseVisualStyleBackColor = True
            '
            'chkProperInstallationOfComponentsAtStartup
            '
            Me.chkProperInstallationOfComponentsAtStartup.AutoSize = True
            Me.chkProperInstallationOfComponentsAtStartup.Location = New System.Drawing.Point(3, 75)
            Me.chkProperInstallationOfComponentsAtStartup.Name = "chkProperInstallationOfComponentsAtStartup"
            Me.chkProperInstallationOfComponentsAtStartup.Size = New System.Drawing.Size(262, 17)
            Me.chkProperInstallationOfComponentsAtStartup.TabIndex = 5
            Me.chkProperInstallationOfComponentsAtStartup.Text = "Check proper installation of components at startup"
            Me.chkProperInstallationOfComponentsAtStartup.UseVisualStyleBackColor = True
            '
            'chkSaveConsOnExit
            '
            Me.chkSaveConsOnExit.AutoSize = True
            Me.chkSaveConsOnExit.Location = New System.Drawing.Point(3, 3)
            Me.chkSaveConsOnExit.Name = "chkSaveConsOnExit"
            Me.chkSaveConsOnExit.Size = New System.Drawing.Size(146, 17)
            Me.chkSaveConsOnExit.TabIndex = 2
            Me.chkSaveConsOnExit.Text = "Save connections on exit"
            Me.chkSaveConsOnExit.UseVisualStyleBackColor = True
            '
            'tcTabControl
            '
            Me.tcTabControl.Controls.Add(Me.tabStartupExit)
            Me.tcTabControl.Controls.Add(Me.tabAppearance)
            Me.tcTabControl.Controls.Add(Me.tabTabsAndPanels)
            Me.tcTabControl.Controls.Add(Me.tabConnections)
            Me.tcTabControl.Controls.Add(Me.tabSQLServer)
            Me.tcTabControl.Controls.Add(Me.tabUpdates)
            Me.tcTabControl.Controls.Add(Me.tabAdvanced)
            Me.tcTabControl.Controls.Add(Me.tabTheme)
            Me.tcTabControl.Controls.Add(Me.tabKeyboard)
            Me.tcTabControl.Location = New System.Drawing.Point(172, 12)
            Me.tcTabControl.Name = "tcTabControl"
            Me.tcTabControl.SelectedIndex = 0
            Me.tcTabControl.Size = New System.Drawing.Size(610, 489)
            Me.tcTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tcTabControl.TabIndex = 1
            Me.tcTabControl.TabStop = False
            '
            'tabStartupExit
            '
            Me.tabStartupExit.Controls.Add(Me.chkReconnectOnStart)
            Me.tabStartupExit.Controls.Add(Me.chkSaveConsOnExit)
            Me.tabStartupExit.Controls.Add(Me.chkSingleInstance)
            Me.tabStartupExit.Controls.Add(Me.chkProperInstallationOfComponentsAtStartup)
            Me.tabStartupExit.Location = New System.Drawing.Point(4, 22)
            Me.tabStartupExit.Name = "tabStartupExit"
            Me.tabStartupExit.Size = New System.Drawing.Size(602, 463)
            Me.tabStartupExit.TabIndex = 0
            Me.tabStartupExit.Text = "Startup/Exit"
            Me.tabStartupExit.UseVisualStyleBackColor = True
            '
            'tabAppearance
            '
            Me.tabAppearance.Controls.Add(Me.lblLanguageRestartRequired)
            Me.tabAppearance.Controls.Add(Me.cboLanguage)
            Me.tabAppearance.Controls.Add(Me.lblLanguage)
            Me.tabAppearance.Controls.Add(Me.chkShowFullConnectionsFilePathInTitle)
            Me.tabAppearance.Controls.Add(Me.chkShowDescriptionTooltipsInTree)
            Me.tabAppearance.Controls.Add(Me.chkShowSystemTrayIcon)
            Me.tabAppearance.Controls.Add(Me.chkMinimizeToSystemTray)
            Me.tabAppearance.Location = New System.Drawing.Point(4, 22)
            Me.tabAppearance.Name = "tabAppearance"
            Me.tabAppearance.Size = New System.Drawing.Size(602, 463)
            Me.tabAppearance.TabIndex = 1
            Me.tabAppearance.Text = "Appearance"
            Me.tabAppearance.UseVisualStyleBackColor = True
            '
            'tabTabsAndPanels
            '
            Me.tabTabsAndPanels.Controls.Add(Me.chkAlwaysShowPanelTabs)
            Me.tabTabsAndPanels.Controls.Add(Me.chkIdentifyQuickConnectTabs)
            Me.tabTabsAndPanels.Controls.Add(Me.chkUseOnlyErrorsAndInfosPanel)
            Me.tabTabsAndPanels.Controls.Add(Me.chkOpenNewTabRightOfSelected)
            Me.tabTabsAndPanels.Controls.Add(Me.lblSwitchToErrorsAndInfos)
            Me.tabTabsAndPanels.Controls.Add(Me.chkAlwaysShowPanelSelectionDlg)
            Me.tabTabsAndPanels.Controls.Add(Me.chkMCInformation)
            Me.tabTabsAndPanels.Controls.Add(Me.chkShowLogonInfoOnTabs)
            Me.tabTabsAndPanels.Controls.Add(Me.chkMCErrors)
            Me.tabTabsAndPanels.Controls.Add(Me.chkDoubleClickClosesTab)
            Me.tabTabsAndPanels.Controls.Add(Me.chkMCWarnings)
            Me.tabTabsAndPanels.Controls.Add(Me.chkShowProtocolOnTabs)
            Me.tabTabsAndPanels.Location = New System.Drawing.Point(4, 22)
            Me.tabTabsAndPanels.Name = "tabTabsAndPanels"
            Me.tabTabsAndPanels.Size = New System.Drawing.Size(602, 463)
            Me.tabTabsAndPanels.TabIndex = 2
            Me.tabTabsAndPanels.Text = "Tabs & Panels"
            Me.tabTabsAndPanels.UseVisualStyleBackColor = True
            '
            'chkAlwaysShowPanelTabs
            '
            Me.chkAlwaysShowPanelTabs.AutoSize = True
            Me.chkAlwaysShowPanelTabs.Location = New System.Drawing.Point(3, 3)
            Me.chkAlwaysShowPanelTabs.Name = "chkAlwaysShowPanelTabs"
            Me.chkAlwaysShowPanelTabs.Size = New System.Drawing.Size(139, 17)
            Me.chkAlwaysShowPanelTabs.TabIndex = 0
            Me.chkAlwaysShowPanelTabs.Text = "Always show panel tabs"
            Me.chkAlwaysShowPanelTabs.UseVisualStyleBackColor = True
            '
            'chkIdentifyQuickConnectTabs
            '
            Me.chkIdentifyQuickConnectTabs.AutoSize = True
            Me.chkIdentifyQuickConnectTabs.Location = New System.Drawing.Point(3, 95)
            Me.chkIdentifyQuickConnectTabs.Name = "chkIdentifyQuickConnectTabs"
            Me.chkIdentifyQuickConnectTabs.Size = New System.Drawing.Size(293, 17)
            Me.chkIdentifyQuickConnectTabs.TabIndex = 4
            Me.chkIdentifyQuickConnectTabs.Text = Global.mRemoteNG.My.Language.strIdentifyQuickConnectTabs
            Me.chkIdentifyQuickConnectTabs.UseVisualStyleBackColor = True
            '
            'tabConnections
            '
            Me.tabConnections.Controls.Add(Me.pnlRdpReconnectionCount)
            Me.tabConnections.Controls.Add(Me.chkSingleClickOnConnectionOpensIt)
            Me.tabConnections.Controls.Add(Me.chkHostnameLikeDisplayName)
            Me.tabConnections.Controls.Add(Me.pnlDefaultCredentials)
            Me.tabConnections.Controls.Add(Me.chkSingleClickOnOpenedConnectionSwitchesToIt)
            Me.tabConnections.Controls.Add(Me.pnlAutoSave)
            Me.tabConnections.Controls.Add(Me.pnlConfirmCloseConnection)
            Me.tabConnections.Location = New System.Drawing.Point(4, 22)
            Me.tabConnections.Name = "tabConnections"
            Me.tabConnections.Size = New System.Drawing.Size(602, 463)
            Me.tabConnections.TabIndex = 3
            Me.tabConnections.Text = "Connections"
            Me.tabConnections.UseVisualStyleBackColor = True
            '
            'pnlDefaultCredentials
            '
            Me.pnlDefaultCredentials.Controls.Add(Me.radCredentialsCustom)
            Me.pnlDefaultCredentials.Controls.Add(Me.lblDefaultCredentials)
            Me.pnlDefaultCredentials.Controls.Add(Me.radCredentialsNoInfo)
            Me.pnlDefaultCredentials.Controls.Add(Me.radCredentialsWindows)
            Me.pnlDefaultCredentials.Controls.Add(Me.txtCredentialsDomain)
            Me.pnlDefaultCredentials.Controls.Add(Me.lblCredentialsUsername)
            Me.pnlDefaultCredentials.Controls.Add(Me.txtCredentialsPassword)
            Me.pnlDefaultCredentials.Controls.Add(Me.lblCredentialsPassword)
            Me.pnlDefaultCredentials.Controls.Add(Me.txtCredentialsUsername)
            Me.pnlDefaultCredentials.Controls.Add(Me.lblCredentialsDomain)
            Me.pnlDefaultCredentials.Location = New System.Drawing.Point(3, 142)
            Me.pnlDefaultCredentials.Name = "pnlDefaultCredentials"
            Me.pnlDefaultCredentials.Size = New System.Drawing.Size(596, 175)
            Me.pnlDefaultCredentials.TabIndex = 5
            '
            'radCredentialsCustom
            '
            Me.radCredentialsCustom.AutoSize = True
            Me.radCredentialsCustom.Location = New System.Drawing.Point(16, 69)
            Me.radCredentialsCustom.Name = "radCredentialsCustom"
            Me.radCredentialsCustom.Size = New System.Drawing.Size(87, 17)
            Me.radCredentialsCustom.TabIndex = 3
            Me.radCredentialsCustom.Text = "the following:"
            Me.radCredentialsCustom.UseVisualStyleBackColor = True
            '
            'lblDefaultCredentials
            '
            Me.lblDefaultCredentials.AutoSize = True
            Me.lblDefaultCredentials.Location = New System.Drawing.Point(3, 9)
            Me.lblDefaultCredentials.Name = "lblDefaultCredentials"
            Me.lblDefaultCredentials.Size = New System.Drawing.Size(257, 13)
            Me.lblDefaultCredentials.TabIndex = 0
            Me.lblDefaultCredentials.Text = "For empty Username, Password or Domain fields use:"
            '
            'radCredentialsNoInfo
            '
            Me.radCredentialsNoInfo.AutoSize = True
            Me.radCredentialsNoInfo.Checked = True
            Me.radCredentialsNoInfo.Location = New System.Drawing.Point(16, 31)
            Me.radCredentialsNoInfo.Name = "radCredentialsNoInfo"
            Me.radCredentialsNoInfo.Size = New System.Drawing.Size(91, 17)
            Me.radCredentialsNoInfo.TabIndex = 1
            Me.radCredentialsNoInfo.TabStop = True
            Me.radCredentialsNoInfo.Text = "no information"
            Me.radCredentialsNoInfo.UseVisualStyleBackColor = True
            '
            'radCredentialsWindows
            '
            Me.radCredentialsWindows.AutoSize = True
            Me.radCredentialsWindows.Location = New System.Drawing.Point(16, 50)
            Me.radCredentialsWindows.Name = "radCredentialsWindows"
            Me.radCredentialsWindows.Size = New System.Drawing.Size(227, 17)
            Me.radCredentialsWindows.TabIndex = 2
            Me.radCredentialsWindows.Text = "my current credentials (windows logon info)"
            Me.radCredentialsWindows.UseVisualStyleBackColor = True
            '
            'txtCredentialsDomain
            '
            Me.txtCredentialsDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCredentialsDomain.Enabled = False
            Me.txtCredentialsDomain.Location = New System.Drawing.Point(140, 147)
            Me.txtCredentialsDomain.Name = "txtCredentialsDomain"
            Me.txtCredentialsDomain.Size = New System.Drawing.Size(150, 20)
            Me.txtCredentialsDomain.TabIndex = 9
            '
            'lblCredentialsUsername
            '
            Me.lblCredentialsUsername.Enabled = False
            Me.lblCredentialsUsername.Location = New System.Drawing.Point(37, 95)
            Me.lblCredentialsUsername.Name = "lblCredentialsUsername"
            Me.lblCredentialsUsername.Size = New System.Drawing.Size(97, 13)
            Me.lblCredentialsUsername.TabIndex = 4
            Me.lblCredentialsUsername.Text = "Username:"
            Me.lblCredentialsUsername.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCredentialsPassword
            '
            Me.txtCredentialsPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCredentialsPassword.Enabled = False
            Me.txtCredentialsPassword.Location = New System.Drawing.Point(140, 120)
            Me.txtCredentialsPassword.Name = "txtCredentialsPassword"
            Me.txtCredentialsPassword.Size = New System.Drawing.Size(150, 20)
            Me.txtCredentialsPassword.TabIndex = 7
            Me.txtCredentialsPassword.UseSystemPasswordChar = True
            '
            'lblCredentialsPassword
            '
            Me.lblCredentialsPassword.Enabled = False
            Me.lblCredentialsPassword.Location = New System.Drawing.Point(34, 123)
            Me.lblCredentialsPassword.Name = "lblCredentialsPassword"
            Me.lblCredentialsPassword.Size = New System.Drawing.Size(100, 13)
            Me.lblCredentialsPassword.TabIndex = 6
            Me.lblCredentialsPassword.Text = "Password:"
            Me.lblCredentialsPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCredentialsUsername
            '
            Me.txtCredentialsUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCredentialsUsername.Enabled = False
            Me.txtCredentialsUsername.Location = New System.Drawing.Point(140, 93)
            Me.txtCredentialsUsername.Name = "txtCredentialsUsername"
            Me.txtCredentialsUsername.Size = New System.Drawing.Size(150, 20)
            Me.txtCredentialsUsername.TabIndex = 5
            '
            'lblCredentialsDomain
            '
            Me.lblCredentialsDomain.Enabled = False
            Me.lblCredentialsDomain.Location = New System.Drawing.Point(34, 150)
            Me.lblCredentialsDomain.Name = "lblCredentialsDomain"
            Me.lblCredentialsDomain.Size = New System.Drawing.Size(100, 13)
            Me.lblCredentialsDomain.TabIndex = 8
            Me.lblCredentialsDomain.Text = "Domain:"
            Me.lblCredentialsDomain.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'pnlConfirmCloseConnection
            '
            Me.pnlConfirmCloseConnection.Controls.Add(Me.lblClosingConnections)
            Me.pnlConfirmCloseConnection.Controls.Add(Me.radCloseWarnAll)
            Me.pnlConfirmCloseConnection.Controls.Add(Me.radCloseWarnMultiple)
            Me.pnlConfirmCloseConnection.Controls.Add(Me.radCloseWarnExit)
            Me.pnlConfirmCloseConnection.Controls.Add(Me.radCloseWarnNever)
            Me.pnlConfirmCloseConnection.Location = New System.Drawing.Point(3, 323)
            Me.pnlConfirmCloseConnection.Name = "pnlConfirmCloseConnection"
            Me.pnlConfirmCloseConnection.Size = New System.Drawing.Size(596, 137)
            Me.pnlConfirmCloseConnection.TabIndex = 6
            '
            'lblClosingConnections
            '
            Me.lblClosingConnections.AutoSize = True
            Me.lblClosingConnections.Location = New System.Drawing.Point(3, 9)
            Me.lblClosingConnections.Name = "lblClosingConnections"
            Me.lblClosingConnections.Size = New System.Drawing.Size(136, 13)
            Me.lblClosingConnections.TabIndex = 0
            Me.lblClosingConnections.Text = "When closing connections:"
            '
            'radCloseWarnAll
            '
            Me.radCloseWarnAll.AutoSize = True
            Me.radCloseWarnAll.Location = New System.Drawing.Point(16, 31)
            Me.radCloseWarnAll.Name = "radCloseWarnAll"
            Me.radCloseWarnAll.Size = New System.Drawing.Size(194, 17)
            Me.radCloseWarnAll.TabIndex = 1
            Me.radCloseWarnAll.TabStop = True
            Me.radCloseWarnAll.Text = "Warn me when closing connections"
            Me.radCloseWarnAll.UseVisualStyleBackColor = True
            '
            'radCloseWarnMultiple
            '
            Me.radCloseWarnMultiple.AutoSize = True
            Me.radCloseWarnMultiple.Location = New System.Drawing.Point(16, 54)
            Me.radCloseWarnMultiple.Name = "radCloseWarnMultiple"
            Me.radCloseWarnMultiple.Size = New System.Drawing.Size(254, 17)
            Me.radCloseWarnMultiple.TabIndex = 2
            Me.radCloseWarnMultiple.TabStop = True
            Me.radCloseWarnMultiple.Text = "Warn me only when closing multiple connections"
            Me.radCloseWarnMultiple.UseVisualStyleBackColor = True
            '
            'radCloseWarnExit
            '
            Me.radCloseWarnExit.AutoSize = True
            Me.radCloseWarnExit.Location = New System.Drawing.Point(16, 77)
            Me.radCloseWarnExit.Name = "radCloseWarnExit"
            Me.radCloseWarnExit.Size = New System.Drawing.Size(216, 17)
            Me.radCloseWarnExit.TabIndex = 3
            Me.radCloseWarnExit.TabStop = True
            Me.radCloseWarnExit.Text = "Warn me only when exiting mRemoteNG"
            Me.radCloseWarnExit.UseVisualStyleBackColor = True
            '
            'radCloseWarnNever
            '
            Me.radCloseWarnNever.AutoSize = True
            Me.radCloseWarnNever.Location = New System.Drawing.Point(16, 100)
            Me.radCloseWarnNever.Name = "radCloseWarnNever"
            Me.radCloseWarnNever.Size = New System.Drawing.Size(226, 17)
            Me.radCloseWarnNever.TabIndex = 4
            Me.radCloseWarnNever.TabStop = True
            Me.radCloseWarnNever.Text = "Do not warn me when closing connections"
            Me.radCloseWarnNever.UseVisualStyleBackColor = True
            '
            'tabSQLServer
            '
            Me.tabSQLServer.Controls.Add(Me.lblSQLDatabaseName)
            Me.tabSQLServer.Controls.Add(Me.txtSQLDatabaseName)
            Me.tabSQLServer.Controls.Add(Me.lblExperimental)
            Me.tabSQLServer.Controls.Add(Me.chkUseSQLServer)
            Me.tabSQLServer.Controls.Add(Me.lblSQLUsername)
            Me.tabSQLServer.Controls.Add(Me.txtSQLPassword)
            Me.tabSQLServer.Controls.Add(Me.lblSQLInfo)
            Me.tabSQLServer.Controls.Add(Me.lblSQLServer)
            Me.tabSQLServer.Controls.Add(Me.txtSQLUsername)
            Me.tabSQLServer.Controls.Add(Me.txtSQLServer)
            Me.tabSQLServer.Controls.Add(Me.lblSQLPassword)
            Me.tabSQLServer.Location = New System.Drawing.Point(4, 22)
            Me.tabSQLServer.Name = "tabSQLServer"
            Me.tabSQLServer.Size = New System.Drawing.Size(602, 463)
            Me.tabSQLServer.TabIndex = 6
            Me.tabSQLServer.Text = "SQL Server"
            Me.tabSQLServer.UseVisualStyleBackColor = True
            '
            'lblSQLDatabaseName
            '
            Me.lblSQLDatabaseName.Enabled = False
            Me.lblSQLDatabaseName.Location = New System.Drawing.Point(23, 132)
            Me.lblSQLDatabaseName.Name = "lblSQLDatabaseName"
            Me.lblSQLDatabaseName.Size = New System.Drawing.Size(111, 13)
            Me.lblSQLDatabaseName.TabIndex = 5
            Me.lblSQLDatabaseName.Text = "Database:"
            Me.lblSQLDatabaseName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtSQLDatabaseName
            '
            Me.txtSQLDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSQLDatabaseName.Enabled = False
            Me.txtSQLDatabaseName.Location = New System.Drawing.Point(140, 130)
            Me.txtSQLDatabaseName.Name = "txtSQLDatabaseName"
            Me.txtSQLDatabaseName.Size = New System.Drawing.Size(153, 20)
            Me.txtSQLDatabaseName.TabIndex = 6
            '
            'lblExperimental
            '
            Me.lblExperimental.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblExperimental.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
            Me.lblExperimental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblExperimental.Location = New System.Drawing.Point(3, 0)
            Me.lblExperimental.Name = "lblExperimental"
            Me.lblExperimental.Size = New System.Drawing.Size(596, 25)
            Me.lblExperimental.TabIndex = 0
            Me.lblExperimental.Text = "EXPERIMENTAL"
            Me.lblExperimental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'chkUseSQLServer
            '
            Me.chkUseSQLServer.AutoSize = True
            Me.chkUseSQLServer.Location = New System.Drawing.Point(3, 76)
            Me.chkUseSQLServer.Name = "chkUseSQLServer"
            Me.chkUseSQLServer.Size = New System.Drawing.Size(234, 17)
            Me.chkUseSQLServer.TabIndex = 2
            Me.chkUseSQLServer.Text = "Use SQL Server to load && save connections"
            Me.chkUseSQLServer.UseVisualStyleBackColor = True
            '
            'lblSQLUsername
            '
            Me.lblSQLUsername.Enabled = False
            Me.lblSQLUsername.Location = New System.Drawing.Point(23, 158)
            Me.lblSQLUsername.Name = "lblSQLUsername"
            Me.lblSQLUsername.Size = New System.Drawing.Size(111, 13)
            Me.lblSQLUsername.TabIndex = 7
            Me.lblSQLUsername.Text = "Username:"
            Me.lblSQLUsername.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtSQLPassword
            '
            Me.txtSQLPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSQLPassword.Enabled = False
            Me.txtSQLPassword.Location = New System.Drawing.Point(140, 182)
            Me.txtSQLPassword.Name = "txtSQLPassword"
            Me.txtSQLPassword.Size = New System.Drawing.Size(153, 20)
            Me.txtSQLPassword.TabIndex = 10
            Me.txtSQLPassword.UseSystemPasswordChar = True
            '
            'lblSQLInfo
            '
            Me.lblSQLInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSQLInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
            Me.lblSQLInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSQLInfo.Location = New System.Drawing.Point(3, 25)
            Me.lblSQLInfo.Name = "lblSQLInfo"
            Me.lblSQLInfo.Size = New System.Drawing.Size(596, 25)
            Me.lblSQLInfo.TabIndex = 1
            Me.lblSQLInfo.Text = "Please see Help - Getting started - SQL Configuration for more Info!"
            Me.lblSQLInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSQLServer
            '
            Me.lblSQLServer.Enabled = False
            Me.lblSQLServer.Location = New System.Drawing.Point(23, 106)
            Me.lblSQLServer.Name = "lblSQLServer"
            Me.lblSQLServer.Size = New System.Drawing.Size(111, 13)
            Me.lblSQLServer.TabIndex = 3
            Me.lblSQLServer.Text = "SQL Server:"
            Me.lblSQLServer.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtSQLUsername
            '
            Me.txtSQLUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSQLUsername.Enabled = False
            Me.txtSQLUsername.Location = New System.Drawing.Point(140, 156)
            Me.txtSQLUsername.Name = "txtSQLUsername"
            Me.txtSQLUsername.Size = New System.Drawing.Size(153, 20)
            Me.txtSQLUsername.TabIndex = 8
            '
            'txtSQLServer
            '
            Me.txtSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSQLServer.Enabled = False
            Me.txtSQLServer.Location = New System.Drawing.Point(140, 103)
            Me.txtSQLServer.Name = "txtSQLServer"
            Me.txtSQLServer.Size = New System.Drawing.Size(153, 20)
            Me.txtSQLServer.TabIndex = 4
            '
            'lblSQLPassword
            '
            Me.lblSQLPassword.Enabled = False
            Me.lblSQLPassword.Location = New System.Drawing.Point(23, 184)
            Me.lblSQLPassword.Name = "lblSQLPassword"
            Me.lblSQLPassword.Size = New System.Drawing.Size(111, 13)
            Me.lblSQLPassword.TabIndex = 9
            Me.lblSQLPassword.Text = "Password:"
            Me.lblSQLPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'tabUpdates
            '
            Me.tabUpdates.Controls.Add(Me.lblUpdatesExplanation)
            Me.tabUpdates.Controls.Add(Me.pnlUpdateCheck)
            Me.tabUpdates.Controls.Add(Me.pnlProxy)
            Me.tabUpdates.Location = New System.Drawing.Point(4, 22)
            Me.tabUpdates.Name = "tabUpdates"
            Me.tabUpdates.Size = New System.Drawing.Size(602, 463)
            Me.tabUpdates.TabIndex = 4
            Me.tabUpdates.Text = "Updates"
            Me.tabUpdates.UseVisualStyleBackColor = True
            '
            'tabAdvanced
            '
            Me.tabAdvanced.Controls.Add(Me.chkWriteLogFile)
            Me.tabAdvanced.Controls.Add(Me.chkAutomaticallyGetSessionInfo)
            Me.tabAdvanced.Controls.Add(Me.lblXulRunnerPath)
            Me.tabAdvanced.Controls.Add(Me.lblMaximumPuttyWaitTime)
            Me.tabAdvanced.Controls.Add(Me.chkEncryptCompleteFile)
            Me.tabAdvanced.Controls.Add(Me.chkAutomaticReconnect)
            Me.tabAdvanced.Controls.Add(Me.btnBrowseXulRunnerPath)
            Me.tabAdvanced.Controls.Add(Me.numPuttyWaitTime)
            Me.tabAdvanced.Controls.Add(Me.chkUseCustomPuttyPath)
            Me.tabAdvanced.Controls.Add(Me.lblConfigurePuttySessions)
            Me.tabAdvanced.Controls.Add(Me.txtXULrunnerPath)
            Me.tabAdvanced.Controls.Add(Me.numUVNCSCPort)
            Me.tabAdvanced.Controls.Add(Me.txtCustomPuttyPath)
            Me.tabAdvanced.Controls.Add(Me.btnLaunchPutty)
            Me.tabAdvanced.Controls.Add(Me.lblUVNCSCPort)
            Me.tabAdvanced.Controls.Add(Me.lblSeconds)
            Me.tabAdvanced.Controls.Add(Me.btnBrowseCustomPuttyPath)
            Me.tabAdvanced.Location = New System.Drawing.Point(4, 22)
            Me.tabAdvanced.Name = "tabAdvanced"
            Me.tabAdvanced.Size = New System.Drawing.Size(602, 463)
            Me.tabAdvanced.TabIndex = 5
            Me.tabAdvanced.Text = "Advanced"
            Me.tabAdvanced.UseVisualStyleBackColor = True
            '
            'tabTheme
            '
            Me.tabTheme.Controls.Add(Me.btnThemeDelete)
            Me.tabTheme.Controls.Add(Me.btnThemeNew)
            Me.tabTheme.Controls.Add(Me.cboTheme)
            Me.tabTheme.Controls.Add(Me.ThemePropertyGrid)
            Me.tabTheme.Location = New System.Drawing.Point(4, 22)
            Me.tabTheme.Name = "tabTheme"
            Me.tabTheme.Padding = New System.Windows.Forms.Padding(3)
            Me.tabTheme.Size = New System.Drawing.Size(602, 463)
            Me.tabTheme.TabIndex = 7
            Me.tabTheme.Text = "Theme"
            Me.tabTheme.UseVisualStyleBackColor = True
            '
            'btnThemeDelete
            '
            Me.btnThemeDelete.Location = New System.Drawing.Point(524, 5)
            Me.btnThemeDelete.Name = "btnThemeDelete"
            Me.btnThemeDelete.Size = New System.Drawing.Size(75, 23)
            Me.btnThemeDelete.TabIndex = 2
            Me.btnThemeDelete.Text = "&Delete"
            Me.btnThemeDelete.UseVisualStyleBackColor = True
            '
            'btnThemeNew
            '
            Me.btnThemeNew.Location = New System.Drawing.Point(443, 5)
            Me.btnThemeNew.Name = "btnThemeNew"
            Me.btnThemeNew.Size = New System.Drawing.Size(75, 23)
            Me.btnThemeNew.TabIndex = 1
            Me.btnThemeNew.Text = "&New"
            Me.btnThemeNew.UseVisualStyleBackColor = True
            '
            'cboTheme
            '
            Me.cboTheme.FormattingEnabled = True
            Me.cboTheme.Location = New System.Drawing.Point(3, 7)
            Me.cboTheme.Name = "cboTheme"
            Me.cboTheme.Size = New System.Drawing.Size(434, 21)
            Me.cboTheme.TabIndex = 0
            '
            'ThemePropertyGrid
            '
            Me.ThemePropertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ThemePropertyGrid.Location = New System.Drawing.Point(3, 34)
            Me.ThemePropertyGrid.Name = "ThemePropertyGrid"
            Me.ThemePropertyGrid.Size = New System.Drawing.Size(596, 426)
            Me.ThemePropertyGrid.TabIndex = 3
            Me.ThemePropertyGrid.UseCompatibleTextRendering = True
            '
            'tabKeyboard
            '
            Me.tabKeyboard.Controls.Add(Me.btnResetKeyboardShortcuts)
            Me.tabKeyboard.Controls.Add(Me.btnDeleteKeyboardShortcut)
            Me.tabKeyboard.Controls.Add(Me.btnNewKeyboardShortcut)
            Me.tabKeyboard.Controls.Add(Me.grpModifyKeyboardShortcut)
            Me.tabKeyboard.Controls.Add(Me.lblKeyboardCommand)
            Me.tabKeyboard.Controls.Add(Me.lstKeyboardShortcuts)
            Me.tabKeyboard.Controls.Add(Me.lblKeyboardShortcuts)
            Me.tabKeyboard.Controls.Add(Me.ShapeContainer1)
            Me.tabKeyboard.Controls.Add(Me.lvKeyboardCommands)
            Me.tabKeyboard.Location = New System.Drawing.Point(4, 22)
            Me.tabKeyboard.Name = "tabKeyboard"
            Me.tabKeyboard.Padding = New System.Windows.Forms.Padding(3)
            Me.tabKeyboard.Size = New System.Drawing.Size(602, 463)
            Me.tabKeyboard.TabIndex = 8
            Me.tabKeyboard.Text = "Keyboard"
            Me.tabKeyboard.UseVisualStyleBackColor = True
            '
            'btnResetKeyboardShortcuts
            '
            Me.btnResetKeyboardShortcuts.Location = New System.Drawing.Point(476, 158)
            Me.btnResetKeyboardShortcuts.Name = "btnResetKeyboardShortcuts"
            Me.btnResetKeyboardShortcuts.Size = New System.Drawing.Size(120, 23)
            Me.btnResetKeyboardShortcuts.TabIndex = 7
            Me.btnResetKeyboardShortcuts.Text = "&Reset to Default"
            Me.btnResetKeyboardShortcuts.UseVisualStyleBackColor = True
            '
            'btnDeleteKeyboardShortcut
            '
            Me.btnDeleteKeyboardShortcut.Location = New System.Drawing.Point(297, 158)
            Me.btnDeleteKeyboardShortcut.Name = "btnDeleteKeyboardShortcut"
            Me.btnDeleteKeyboardShortcut.Size = New System.Drawing.Size(75, 23)
            Me.btnDeleteKeyboardShortcut.TabIndex = 6
            Me.btnDeleteKeyboardShortcut.Text = "&Delete"
            Me.btnDeleteKeyboardShortcut.UseVisualStyleBackColor = True
            '
            'btnNewKeyboardShortcut
            '
            Me.btnNewKeyboardShortcut.Location = New System.Drawing.Point(216, 158)
            Me.btnNewKeyboardShortcut.Name = "btnNewKeyboardShortcut"
            Me.btnNewKeyboardShortcut.Size = New System.Drawing.Size(75, 23)
            Me.btnNewKeyboardShortcut.TabIndex = 5
            Me.btnNewKeyboardShortcut.Text = "&New"
            Me.btnNewKeyboardShortcut.UseVisualStyleBackColor = True
            '
            'grpModifyKeyboardShortcut
            '
            Me.grpModifyKeyboardShortcut.Controls.Add(Me.hotModifyKeyboardShortcut)
            Me.grpModifyKeyboardShortcut.Location = New System.Drawing.Point(216, 187)
            Me.grpModifyKeyboardShortcut.Name = "grpModifyKeyboardShortcut"
            Me.grpModifyKeyboardShortcut.Size = New System.Drawing.Size(380, 103)
            Me.grpModifyKeyboardShortcut.TabIndex = 8
            Me.grpModifyKeyboardShortcut.TabStop = False
            Me.grpModifyKeyboardShortcut.Text = "Modify Shortcut"
            '
            'hotModifyKeyboardShortcut
            '
            Me.hotModifyKeyboardShortcut.Hotkey = System.Windows.Forms.Keys.None
            Me.hotModifyKeyboardShortcut.HotkeyModifiers = System.Windows.Forms.Keys.None
            Me.hotModifyKeyboardShortcut.Location = New System.Drawing.Point(26, 41)
            Me.hotModifyKeyboardShortcut.Name = "hotModifyKeyboardShortcut"
            Me.hotModifyKeyboardShortcut.Size = New System.Drawing.Size(329, 20)
            Me.hotModifyKeyboardShortcut.TabIndex = 0
            Me.hotModifyKeyboardShortcut.Text = "None"
            '
            'lblKeyboardCommand
            '
            Me.lblKeyboardCommand.AutoSize = True
            Me.lblKeyboardCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblKeyboardCommand.Location = New System.Drawing.Point(213, 7)
            Me.lblKeyboardCommand.Name = "lblKeyboardCommand"
            Me.lblKeyboardCommand.Size = New System.Drawing.Size(71, 17)
            Me.lblKeyboardCommand.TabIndex = 2
            Me.lblKeyboardCommand.Text = "Command"
            '
            'lstKeyboardShortcuts
            '
            Me.lstKeyboardShortcuts.FormattingEnabled = True
            Me.lstKeyboardShortcuts.Location = New System.Drawing.Point(216, 57)
            Me.lstKeyboardShortcuts.Name = "lstKeyboardShortcuts"
            Me.lstKeyboardShortcuts.Size = New System.Drawing.Size(380, 95)
            Me.lstKeyboardShortcuts.TabIndex = 4
            '
            'lblKeyboardShortcuts
            '
            Me.lblKeyboardShortcuts.AutoSize = True
            Me.lblKeyboardShortcuts.Location = New System.Drawing.Point(213, 41)
            Me.lblKeyboardShortcuts.Name = "lblKeyboardShortcuts"
            Me.lblKeyboardShortcuts.Size = New System.Drawing.Size(100, 13)
            Me.lblKeyboardShortcuts.TabIndex = 3
            Me.lblKeyboardShortcuts.Text = "Keyboard Shortcuts"
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {linKeyboardCommand})
            Me.ShapeContainer1.Size = New System.Drawing.Size(596, 457)
            Me.ShapeContainer1.TabIndex = 0
            Me.ShapeContainer1.TabStop = False
            '
            'lvKeyboardCommands
            '
            Me.lvKeyboardCommands.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.lvKeyboardCommands.HideSelection = False
            Me.lvKeyboardCommands.InactiveHighlightBackColor = System.Drawing.SystemColors.Highlight
            Me.lvKeyboardCommands.InactiveHighlightBorderColor = System.Drawing.SystemColors.HotTrack
            Me.lvKeyboardCommands.InactiveHighlightForeColor = System.Drawing.SystemColors.HighlightText
            Alignment1.Horizontal = mRemoteNG.Controls.HorizontalAlignment.Left
            Alignment1.Vertical = mRemoteNG.Controls.VerticalAlignment.Middle
            Me.lvKeyboardCommands.LabelAlignment = Alignment1
            Me.lvKeyboardCommands.LabelWrap = False
            Me.lvKeyboardCommands.Location = New System.Drawing.Point(7, 7)
            Me.lvKeyboardCommands.MultiSelect = False
            Me.lvKeyboardCommands.Name = "lvKeyboardCommands"
            Me.lvKeyboardCommands.OwnerDraw = True
            Me.lvKeyboardCommands.Size = New System.Drawing.Size(200, 450)
            Me.lvKeyboardCommands.TabIndex = 1
            Me.lvKeyboardCommands.TileSize = New System.Drawing.Size(196, 20)
            Me.lvKeyboardCommands.UseCompatibleStateImageBehavior = False
            Me.lvKeyboardCommands.View = System.Windows.Forms.View.Tile
            '
            'lvPages
            '
            Me.lvPages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lvPages.FullRowSelect = True
            Me.lvPages.HideSelection = False
            Me.lvPages.InactiveHighlightBackColor = System.Drawing.SystemColors.Highlight
            Me.lvPages.InactiveHighlightBorderColor = System.Drawing.SystemColors.HotTrack
            Me.lvPages.InactiveHighlightForeColor = System.Drawing.SystemColors.HighlightText
            Me.lvPages.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
            Alignment2.Horizontal = mRemoteNG.Controls.HorizontalAlignment.Left
            Alignment2.Vertical = mRemoteNG.Controls.VerticalAlignment.Middle
            Me.lvPages.LabelAlignment = Alignment2
            Me.lvPages.LabelWrap = False
            Me.lvPages.LargeImageList = Me.imgListPages
            Me.lvPages.Location = New System.Drawing.Point(12, 12)
            Me.lvPages.MultiSelect = False
            Me.lvPages.Name = "lvPages"
            Me.lvPages.OwnerDraw = True
            Me.lvPages.Scrollable = False
            Me.lvPages.ShowFocusCues = False
            Me.lvPages.Size = New System.Drawing.Size(154, 489)
            Me.lvPages.TabIndex = 0
            Me.lvPages.TabStop = False
            Me.lvPages.TileSize = New System.Drawing.Size(150, 30)
            Me.lvPages.UseCompatibleStateImageBehavior = False
            Me.lvPages.View = System.Windows.Forms.View.Tile
            '
            'frmOptions
            '
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(794, 542)
            Me.Controls.Add(Me.tcTabControl)
            Me.Controls.Add(Me.lvPages)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = Global.mRemoteNG.My.Resources.Resources.Options_Icon
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmOptions"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Options"
            CType(Me.numPuttyWaitTime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numUVNCSCPort, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlProxy.ResumeLayout(False)
            Me.pnlProxy.PerformLayout()
            Me.pnlProxyBasic.ResumeLayout(False)
            Me.pnlProxyBasic.PerformLayout()
            CType(Me.numProxyPort, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlProxyAuthentication.ResumeLayout(False)
            Me.pnlProxyAuthentication.PerformLayout()
            Me.pnlUpdateCheck.ResumeLayout(False)
            Me.pnlUpdateCheck.PerformLayout()
            Me.pnlAutoSave.ResumeLayout(False)
            Me.pnlAutoSave.PerformLayout()
            CType(Me.numAutoSave, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlRdpReconnectionCount.ResumeLayout(False)
            CType(Me.numRdpReconnectionCount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcTabControl.ResumeLayout(False)
            Me.tabStartupExit.ResumeLayout(False)
            Me.tabStartupExit.PerformLayout()
            Me.tabAppearance.ResumeLayout(False)
            Me.tabAppearance.PerformLayout()
            Me.tabTabsAndPanels.ResumeLayout(False)
            Me.tabTabsAndPanels.PerformLayout()
            Me.tabConnections.ResumeLayout(False)
            Me.tabConnections.PerformLayout()
            Me.pnlDefaultCredentials.ResumeLayout(False)
            Me.pnlDefaultCredentials.PerformLayout()
            Me.pnlConfirmCloseConnection.ResumeLayout(False)
            Me.pnlConfirmCloseConnection.PerformLayout()
            Me.tabSQLServer.ResumeLayout(False)
            Me.tabSQLServer.PerformLayout()
            Me.tabUpdates.ResumeLayout(False)
            Me.tabAdvanced.ResumeLayout(False)
            Me.tabAdvanced.PerformLayout()
            Me.tabTheme.ResumeLayout(False)
            Me.tabKeyboard.ResumeLayout(False)
            Me.tabKeyboard.PerformLayout()
            Me.grpModifyKeyboardShortcut.ResumeLayout(False)
            Me.grpModifyKeyboardShortcut.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lvKeyboardCommands As Controls.ListView
        Friend WithEvents lblKeyboardCommand As System.Windows.Forms.Label
        Friend WithEvents lstKeyboardShortcuts As System.Windows.Forms.ListBox
        Friend WithEvents btnResetKeyboardShortcuts As System.Windows.Forms.Button
        Friend WithEvents btnDeleteKeyboardShortcut As System.Windows.Forms.Button
        Friend WithEvents btnNewKeyboardShortcut As System.Windows.Forms.Button
        Friend WithEvents hotModifyKeyboardShortcut As SharedLibraryNG.HotkeyControl
        Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents grpModifyKeyboardShortcut As System.Windows.Forms.GroupBox
        Friend WithEvents lblKeyboardShortcuts As System.Windows.Forms.Label
    End Class
End Namespace