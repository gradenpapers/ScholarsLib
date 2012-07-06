<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.CurrentStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.MainContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WhatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HomeTabs = New System.Windows.Forms.TabControl
        Me.HomeTab = New System.Windows.Forms.TabPage
        Me.HomePanel = New System.Windows.Forms.Panel
        Me.AddItemLink = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AddUserLink = New System.Windows.Forms.LinkLabel
        Me.CheckinItemLink = New System.Windows.Forms.LinkLabel
        Me.CheckoutItemLink = New System.Windows.Forms.LinkLabel
        Me.FindPersonLink = New System.Windows.Forms.LinkLabel
        Me.FindItemLink = New System.Windows.Forms.LinkLabel
        Me.WelcomeLabel = New System.Windows.Forms.Label
        Me.HomeDisclaimer = New System.Windows.Forms.Label
        Me.FindItemTab = New System.Windows.Forms.TabPage
        Me.FindItemPanel = New System.Windows.Forms.Panel
        Me.FindItemPublishedToLabel = New System.Windows.Forms.Label
        Me.FindItemPublishedFromLabel = New System.Windows.Forms.Label
        Me.FindItemPublishedToInput = New System.Windows.Forms.DateTimePicker
        Me.FindItemPublishedFromInput = New System.Windows.Forms.DateTimePicker
        Me.FindItemPublisherInput = New System.Windows.Forms.TextBox
        Me.FindItemTitleInput = New System.Windows.Forms.TextBox
        Me.FindItemAuthorInput = New System.Windows.Forms.TextBox
        Me.FindItemButton = New System.Windows.Forms.Button
        Me.FindItemItemsGrid = New System.Windows.Forms.DataGridView
        Me.FindItemPublisherLabel = New System.Windows.Forms.Label
        Me.FindItemPublishDateLabel = New System.Windows.Forms.Label
        Me.FindItemAuthorLabel = New System.Windows.Forms.Label
        Me.FindItemTitleLabel = New System.Windows.Forms.Label
        Me.FindPersonTab = New System.Windows.Forms.TabPage
        Me.FindUserPanel = New System.Windows.Forms.Panel
        Me.FindUserButton = New System.Windows.Forms.Button
        Me.FindUserUsersGrid = New System.Windows.Forms.DataGridView
        Me.FindUserEmailInput = New System.Windows.Forms.TextBox
        Me.FindUserEmailLabel = New System.Windows.Forms.Label
        Me.FindUserLastNameInput = New System.Windows.Forms.TextBox
        Me.FindUserLastNameLabel = New System.Windows.Forms.Label
        Me.FindUserMiddleNameInput = New System.Windows.Forms.TextBox
        Me.FindUserMiddleNameLabel = New System.Windows.Forms.Label
        Me.FindUserFirstNameInput = New System.Windows.Forms.TextBox
        Me.FindUserFirstNameLabel = New System.Windows.Forms.Label
        Me.CheckoutItemTab = New System.Windows.Forms.TabPage
        Me.CheckinItemTab = New System.Windows.Forms.TabPage
        Me.AddEditItemTab = New System.Windows.Forms.TabPage
        Me.AddEditUserTab = New System.Windows.Forms.TabPage
        Me.AddEditUserPanel = New System.Windows.Forms.Panel
        Me.AddEditUserDeleteButton = New System.Windows.Forms.Button
        Me.AddEditUserStateInput = New System.Windows.Forms.ComboBox
        Me.AddEditUserAdministratorInput = New System.Windows.Forms.CheckBox
        Me.AddEditUserAdministratorLabel = New System.Windows.Forms.Label
        Me.AddEditUserOtherPhoneInput = New System.Windows.Forms.TextBox
        Me.AddEditUserOtherPhoneLabel = New System.Windows.Forms.Label
        Me.AddEditUserHomePhoneInput = New System.Windows.Forms.TextBox
        Me.AddEditUserHomePhoneLabel = New System.Windows.Forms.Label
        Me.AddEditUserPasswordInput = New System.Windows.Forms.TextBox
        Me.AddEditUserPasswordLabel = New System.Windows.Forms.Label
        Me.AddEditUserCityInput = New System.Windows.Forms.TextBox
        Me.AddEditUserErrorMessage = New System.Windows.Forms.Label
        Me.AddEditUserButton = New System.Windows.Forms.Button
        Me.AddEditUserZipInput = New System.Windows.Forms.TextBox
        Me.AddEditUserZipLabel = New System.Windows.Forms.Label
        Me.AddEditUserStateLabel = New System.Windows.Forms.Label
        Me.AddEditUserCityLabel = New System.Windows.Forms.Label
        Me.AddEditUserAddressInput = New System.Windows.Forms.TextBox
        Me.AddEditUserAddressLabel = New System.Windows.Forms.Label
        Me.AddEditUserEmailInput = New System.Windows.Forms.TextBox
        Me.AddEditUserEmailLabel = New System.Windows.Forms.Label
        Me.AddEditUserLastNameInput = New System.Windows.Forms.TextBox
        Me.AddEditUserLastNameLabel = New System.Windows.Forms.Label
        Me.AddEditUserMiddleNameInput = New System.Windows.Forms.TextBox
        Me.AddEditUserMiddleNameLabel = New System.Windows.Forms.Label
        Me.AddEditUserFirstNameInput = New System.Windows.Forms.TextBox
        Me.AddEditUserFirstNameLabel = New System.Windows.Forms.Label
        Me.AddEditUserUsernameInput = New System.Windows.Forms.TextBox
        Me.AddEditUserUsernameLabel = New System.Windows.Forms.Label
        Me.TabImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FinishedButton = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MainContextMenu.SuspendLayout()
        Me.HomeTabs.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.HomePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FindItemTab.SuspendLayout()
        Me.FindItemPanel.SuspendLayout()
        CType(Me.FindItemItemsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FindPersonTab.SuspendLayout()
        Me.FindUserPanel.SuspendLayout()
        CType(Me.FindUserUsersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddEditUserTab.SuspendLayout()
        Me.AddEditUserPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.FileToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(50, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(992, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CurrentStatus
        '
        Me.CurrentStatus.Name = "CurrentStatus"
        Me.CurrentStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MainContextMenu
        '
        Me.MainContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatToolStripMenuItem})
        Me.MainContextMenu.Name = "MainContextMenu"
        Me.MainContextMenu.Size = New System.Drawing.Size(117, 26)
        '
        'WhatToolStripMenuItem
        '
        Me.WhatToolStripMenuItem.Name = "WhatToolStripMenuItem"
        Me.WhatToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.WhatToolStripMenuItem.Text = "What?"
        '
        'StartupTimer
        '
        Me.StartupTimer.Enabled = True
        Me.StartupTimer.Interval = 1
        '
        'HomeTabs
        '
        Me.HomeTabs.Controls.Add(Me.HomeTab)
        Me.HomeTabs.Controls.Add(Me.FindItemTab)
        Me.HomeTabs.Controls.Add(Me.FindPersonTab)
        Me.HomeTabs.Controls.Add(Me.CheckoutItemTab)
        Me.HomeTabs.Controls.Add(Me.CheckinItemTab)
        Me.HomeTabs.Controls.Add(Me.AddEditItemTab)
        Me.HomeTabs.Controls.Add(Me.AddEditUserTab)
        Me.HomeTabs.HotTrack = True
        Me.HomeTabs.ImageList = Me.TabImageList
        Me.HomeTabs.ItemSize = New System.Drawing.Size(20, 32)
        Me.HomeTabs.Location = New System.Drawing.Point(0, 27)
        Me.HomeTabs.Name = "HomeTabs"
        Me.HomeTabs.SelectedIndex = 0
        Me.HomeTabs.Size = New System.Drawing.Size(992, 439)
        Me.HomeTabs.TabIndex = 4
        '
        'HomeTab
        '
        Me.HomeTab.BackColor = System.Drawing.Color.Black
        Me.HomeTab.Controls.Add(Me.HomePanel)
        Me.HomeTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeTab.ImageKey = "scholars_lib_home.gif"
        Me.HomeTab.Location = New System.Drawing.Point(4, 36)
        Me.HomeTab.Name = "HomeTab"
        Me.HomeTab.Size = New System.Drawing.Size(984, 399)
        Me.HomeTab.TabIndex = 2
        Me.HomeTab.Text = "Home"
        Me.HomeTab.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.AddItemLink)
        Me.HomePanel.Controls.Add(Me.PictureBox1)
        Me.HomePanel.Controls.Add(Me.AddUserLink)
        Me.HomePanel.Controls.Add(Me.CheckinItemLink)
        Me.HomePanel.Controls.Add(Me.CheckoutItemLink)
        Me.HomePanel.Controls.Add(Me.FindPersonLink)
        Me.HomePanel.Controls.Add(Me.FindItemLink)
        Me.HomePanel.Controls.Add(Me.WelcomeLabel)
        Me.HomePanel.Controls.Add(Me.HomeDisclaimer)
        Me.HomePanel.Location = New System.Drawing.Point(44, 3)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(629, 329)
        Me.HomePanel.TabIndex = 2
        '
        'AddItemLink
        '
        Me.AddItemLink.AutoSize = True
        Me.AddItemLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AddItemLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.AddItemLink.Location = New System.Drawing.Point(456, 223)
        Me.AddItemLink.Name = "AddItemLink"
        Me.AddItemLink.Size = New System.Drawing.Size(82, 20)
        Me.AddItemLink.TabIndex = 9
        Me.AddItemLink.TabStop = True
        Me.AddItemLink.Text = "Add Item"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(196, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 139)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'AddUserLink
        '
        Me.AddUserLink.AutoSize = True
        Me.AddUserLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AddUserLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.AddUserLink.Location = New System.Drawing.Point(95, 223)
        Me.AddUserLink.Name = "AddUserLink"
        Me.AddUserLink.Size = New System.Drawing.Size(84, 20)
        Me.AddUserLink.TabIndex = 6
        Me.AddUserLink.TabStop = True
        Me.AddUserLink.Text = "Add User"
        '
        'CheckinItemLink
        '
        Me.CheckinItemLink.AutoSize = True
        Me.CheckinItemLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckinItemLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.CheckinItemLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.CheckinItemLink.Location = New System.Drawing.Point(475, 172)
        Me.CheckinItemLink.Name = "CheckinItemLink"
        Me.CheckinItemLink.Size = New System.Drawing.Size(114, 20)
        Me.CheckinItemLink.TabIndex = 5
        Me.CheckinItemLink.TabStop = True
        Me.CheckinItemLink.Text = "Checkin Item"
        '
        'CheckoutItemLink
        '
        Me.CheckoutItemLink.AutoSize = True
        Me.CheckoutItemLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutItemLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.CheckoutItemLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.CheckoutItemLink.Location = New System.Drawing.Point(456, 123)
        Me.CheckoutItemLink.Name = "CheckoutItemLink"
        Me.CheckoutItemLink.Size = New System.Drawing.Size(126, 20)
        Me.CheckoutItemLink.TabIndex = 4
        Me.CheckoutItemLink.TabStop = True
        Me.CheckoutItemLink.Text = "Checkout Item"
        '
        'FindPersonLink
        '
        Me.FindPersonLink.AutoSize = True
        Me.FindPersonLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindPersonLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.FindPersonLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.FindPersonLink.Location = New System.Drawing.Point(49, 172)
        Me.FindPersonLink.Name = "FindPersonLink"
        Me.FindPersonLink.Size = New System.Drawing.Size(105, 20)
        Me.FindPersonLink.TabIndex = 3
        Me.FindPersonLink.TabStop = True
        Me.FindPersonLink.Text = "Find Person"
        '
        'FindItemLink
        '
        Me.FindItemLink.AutoSize = True
        Me.FindItemLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.FindItemLink.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemLink.Location = New System.Drawing.Point(94, 123)
        Me.FindItemLink.Name = "FindItemLink"
        Me.FindItemLink.Size = New System.Drawing.Size(85, 20)
        Me.FindItemLink.TabIndex = 2
        Me.FindItemLink.TabStop = True
        Me.FindItemLink.Text = "Find Item"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.ForeColor = System.Drawing.Color.White
        Me.WelcomeLabel.Location = New System.Drawing.Point(46, 11)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(543, 38)
        Me.WelcomeLabel.TabIndex = 0
        Me.WelcomeLabel.Text = "Welcome to Scholar's Library"
        '
        'HomeDisclaimer
        '
        Me.HomeDisclaimer.AutoSize = True
        Me.HomeDisclaimer.ForeColor = System.Drawing.Color.White
        Me.HomeDisclaimer.Location = New System.Drawing.Point(196, 58)
        Me.HomeDisclaimer.Name = "HomeDisclaimer"
        Me.HomeDisclaimer.Size = New System.Drawing.Size(253, 26)
        Me.HomeDisclaimer.TabIndex = 1
        Me.HomeDisclaimer.Text = "You may use the following buttons, or you can use" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the tabs located at the top of" & _
            " the screen at any time."
        Me.HomeDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FindItemTab
        '
        Me.FindItemTab.AutoScroll = True
        Me.FindItemTab.BackColor = System.Drawing.Color.Black
        Me.FindItemTab.Controls.Add(Me.FindItemPanel)
        Me.FindItemTab.ImageKey = "scholars_lib_find_item.gif"
        Me.FindItemTab.Location = New System.Drawing.Point(4, 36)
        Me.FindItemTab.Name = "FindItemTab"
        Me.FindItemTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FindItemTab.Size = New System.Drawing.Size(984, 399)
        Me.FindItemTab.TabIndex = 1
        Me.FindItemTab.Text = "Find Item"
        Me.FindItemTab.UseVisualStyleBackColor = True
        '
        'FindItemPanel
        '
        Me.FindItemPanel.Controls.Add(Me.FindItemPublishedToLabel)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublishedFromLabel)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublishedToInput)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublishedFromInput)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublisherInput)
        Me.FindItemPanel.Controls.Add(Me.FindItemTitleInput)
        Me.FindItemPanel.Controls.Add(Me.FindItemAuthorInput)
        Me.FindItemPanel.Controls.Add(Me.FindItemButton)
        Me.FindItemPanel.Controls.Add(Me.FindItemItemsGrid)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublisherLabel)
        Me.FindItemPanel.Controls.Add(Me.FindItemPublishDateLabel)
        Me.FindItemPanel.Controls.Add(Me.FindItemAuthorLabel)
        Me.FindItemPanel.Controls.Add(Me.FindItemTitleLabel)
        Me.FindItemPanel.Location = New System.Drawing.Point(-4, 6)
        Me.FindItemPanel.Name = "FindItemPanel"
        Me.FindItemPanel.Size = New System.Drawing.Size(980, 401)
        Me.FindItemPanel.TabIndex = 0
        '
        'FindItemPublishedToLabel
        '
        Me.FindItemPublishedToLabel.AutoSize = True
        Me.FindItemPublishedToLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemPublishedToLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemPublishedToLabel.Location = New System.Drawing.Point(652, 52)
        Me.FindItemPublishedToLabel.Name = "FindItemPublishedToLabel"
        Me.FindItemPublishedToLabel.Size = New System.Drawing.Size(34, 17)
        Me.FindItemPublishedToLabel.TabIndex = 14
        Me.FindItemPublishedToLabel.Text = "To:"
        '
        'FindItemPublishedFromLabel
        '
        Me.FindItemPublishedFromLabel.AutoSize = True
        Me.FindItemPublishedFromLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemPublishedFromLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemPublishedFromLabel.Location = New System.Drawing.Point(652, 17)
        Me.FindItemPublishedFromLabel.Name = "FindItemPublishedFromLabel"
        Me.FindItemPublishedFromLabel.Size = New System.Drawing.Size(54, 17)
        Me.FindItemPublishedFromLabel.TabIndex = 13
        Me.FindItemPublishedFromLabel.Text = "From:"
        '
        'FindItemPublishedToInput
        '
        Me.FindItemPublishedToInput.Location = New System.Drawing.Point(712, 49)
        Me.FindItemPublishedToInput.Name = "FindItemPublishedToInput"
        Me.FindItemPublishedToInput.Size = New System.Drawing.Size(250, 20)
        Me.FindItemPublishedToInput.TabIndex = 12
        '
        'FindItemPublishedFromInput
        '
        Me.FindItemPublishedFromInput.Location = New System.Drawing.Point(712, 14)
        Me.FindItemPublishedFromInput.Name = "FindItemPublishedFromInput"
        Me.FindItemPublishedFromInput.Size = New System.Drawing.Size(250, 20)
        Me.FindItemPublishedFromInput.TabIndex = 11
        '
        'FindItemPublisherInput
        '
        Me.FindItemPublisherInput.Location = New System.Drawing.Point(158, 80)
        Me.FindItemPublisherInput.Name = "FindItemPublisherInput"
        Me.FindItemPublisherInput.Size = New System.Drawing.Size(307, 20)
        Me.FindItemPublisherInput.TabIndex = 9
        '
        'FindItemTitleInput
        '
        Me.FindItemTitleInput.Location = New System.Drawing.Point(158, 47)
        Me.FindItemTitleInput.Name = "FindItemTitleInput"
        Me.FindItemTitleInput.Size = New System.Drawing.Size(307, 20)
        Me.FindItemTitleInput.TabIndex = 8
        '
        'FindItemAuthorInput
        '
        Me.FindItemAuthorInput.Location = New System.Drawing.Point(158, 14)
        Me.FindItemAuthorInput.Name = "FindItemAuthorInput"
        Me.FindItemAuthorInput.Size = New System.Drawing.Size(307, 20)
        Me.FindItemAuthorInput.TabIndex = 7
        '
        'FindItemButton
        '
        Me.FindItemButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemButton.Location = New System.Drawing.Point(542, 80)
        Me.FindItemButton.Name = "FindItemButton"
        Me.FindItemButton.Size = New System.Drawing.Size(132, 23)
        Me.FindItemButton.TabIndex = 6
        Me.FindItemButton.Text = "Find Item"
        Me.FindItemButton.UseVisualStyleBackColor = True
        '
        'FindItemItemsGrid
        '
        Me.FindItemItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FindItemItemsGrid.Location = New System.Drawing.Point(45, 123)
        Me.FindItemItemsGrid.Name = "FindItemItemsGrid"
        Me.FindItemItemsGrid.Size = New System.Drawing.Size(917, 275)
        Me.FindItemItemsGrid.TabIndex = 5
        '
        'FindItemPublisherLabel
        '
        Me.FindItemPublisherLabel.AutoSize = True
        Me.FindItemPublisherLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemPublisherLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemPublisherLabel.Location = New System.Drawing.Point(42, 83)
        Me.FindItemPublisherLabel.Name = "FindItemPublisherLabel"
        Me.FindItemPublisherLabel.Size = New System.Drawing.Size(86, 17)
        Me.FindItemPublisherLabel.TabIndex = 3
        Me.FindItemPublisherLabel.Text = "Publisher:"
        '
        'FindItemPublishDateLabel
        '
        Me.FindItemPublishDateLabel.AutoSize = True
        Me.FindItemPublishDateLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemPublishDateLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemPublishDateLabel.Location = New System.Drawing.Point(539, 17)
        Me.FindItemPublishDateLabel.Name = "FindItemPublishDateLabel"
        Me.FindItemPublishDateLabel.Size = New System.Drawing.Size(89, 17)
        Me.FindItemPublishDateLabel.TabIndex = 2
        Me.FindItemPublishDateLabel.Text = "Published:"
        '
        'FindItemAuthorLabel
        '
        Me.FindItemAuthorLabel.AutoSize = True
        Me.FindItemAuthorLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemAuthorLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemAuthorLabel.Location = New System.Drawing.Point(42, 17)
        Me.FindItemAuthorLabel.Name = "FindItemAuthorLabel"
        Me.FindItemAuthorLabel.Size = New System.Drawing.Size(68, 17)
        Me.FindItemAuthorLabel.TabIndex = 1
        Me.FindItemAuthorLabel.Text = "Author:"
        '
        'FindItemTitleLabel
        '
        Me.FindItemTitleLabel.AutoSize = True
        Me.FindItemTitleLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindItemTitleLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindItemTitleLabel.Location = New System.Drawing.Point(42, 50)
        Me.FindItemTitleLabel.Name = "FindItemTitleLabel"
        Me.FindItemTitleLabel.Size = New System.Drawing.Size(47, 17)
        Me.FindItemTitleLabel.TabIndex = 0
        Me.FindItemTitleLabel.Text = "Title:"
        '
        'FindPersonTab
        '
        Me.FindPersonTab.BackColor = System.Drawing.Color.Black
        Me.FindPersonTab.Controls.Add(Me.FindUserPanel)
        Me.FindPersonTab.ImageKey = "scholars_lib_find_user.gif"
        Me.FindPersonTab.Location = New System.Drawing.Point(4, 36)
        Me.FindPersonTab.Name = "FindPersonTab"
        Me.FindPersonTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FindPersonTab.Size = New System.Drawing.Size(984, 399)
        Me.FindPersonTab.TabIndex = 0
        Me.FindPersonTab.Text = "Find Person"
        Me.FindPersonTab.UseVisualStyleBackColor = True
        '
        'FindUserPanel
        '
        Me.FindUserPanel.Controls.Add(Me.FindUserButton)
        Me.FindUserPanel.Controls.Add(Me.FindUserUsersGrid)
        Me.FindUserPanel.Controls.Add(Me.FindUserEmailInput)
        Me.FindUserPanel.Controls.Add(Me.FindUserEmailLabel)
        Me.FindUserPanel.Controls.Add(Me.FindUserLastNameInput)
        Me.FindUserPanel.Controls.Add(Me.FindUserLastNameLabel)
        Me.FindUserPanel.Controls.Add(Me.FindUserMiddleNameInput)
        Me.FindUserPanel.Controls.Add(Me.FindUserMiddleNameLabel)
        Me.FindUserPanel.Controls.Add(Me.FindUserFirstNameInput)
        Me.FindUserPanel.Controls.Add(Me.FindUserFirstNameLabel)
        Me.FindUserPanel.Location = New System.Drawing.Point(8, 6)
        Me.FindUserPanel.Name = "FindUserPanel"
        Me.FindUserPanel.Size = New System.Drawing.Size(867, 401)
        Me.FindUserPanel.TabIndex = 0
        '
        'FindUserButton
        '
        Me.FindUserButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindUserButton.Location = New System.Drawing.Point(368, 155)
        Me.FindUserButton.Name = "FindUserButton"
        Me.FindUserButton.Size = New System.Drawing.Size(132, 23)
        Me.FindUserButton.TabIndex = 27
        Me.FindUserButton.Text = "Find Person"
        Me.FindUserButton.UseVisualStyleBackColor = True
        '
        'FindUserUsersGrid
        '
        Me.FindUserUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FindUserUsersGrid.Location = New System.Drawing.Point(68, 189)
        Me.FindUserUsersGrid.Name = "FindUserUsersGrid"
        Me.FindUserUsersGrid.Size = New System.Drawing.Size(727, 211)
        Me.FindUserUsersGrid.TabIndex = 26
        '
        'FindUserEmailInput
        '
        Me.FindUserEmailInput.Location = New System.Drawing.Point(354, 123)
        Me.FindUserEmailInput.Name = "FindUserEmailInput"
        Me.FindUserEmailInput.Size = New System.Drawing.Size(250, 20)
        Me.FindUserEmailInput.TabIndex = 25
        '
        'FindUserEmailLabel
        '
        Me.FindUserEmailLabel.AutoSize = True
        Me.FindUserEmailLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindUserEmailLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindUserEmailLabel.Location = New System.Drawing.Point(237, 126)
        Me.FindUserEmailLabel.Name = "FindUserEmailLabel"
        Me.FindUserEmailLabel.Size = New System.Drawing.Size(55, 17)
        Me.FindUserEmailLabel.TabIndex = 24
        Me.FindUserEmailLabel.Text = "Email:"
        '
        'FindUserLastNameInput
        '
        Me.FindUserLastNameInput.Location = New System.Drawing.Point(354, 88)
        Me.FindUserLastNameInput.Name = "FindUserLastNameInput"
        Me.FindUserLastNameInput.Size = New System.Drawing.Size(250, 20)
        Me.FindUserLastNameInput.TabIndex = 23
        '
        'FindUserLastNameLabel
        '
        Me.FindUserLastNameLabel.AutoSize = True
        Me.FindUserLastNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindUserLastNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindUserLastNameLabel.Location = New System.Drawing.Point(237, 91)
        Me.FindUserLastNameLabel.Name = "FindUserLastNameLabel"
        Me.FindUserLastNameLabel.Size = New System.Drawing.Size(94, 17)
        Me.FindUserLastNameLabel.TabIndex = 21
        Me.FindUserLastNameLabel.Text = "Last Name:"
        '
        'FindUserMiddleNameInput
        '
        Me.FindUserMiddleNameInput.Location = New System.Drawing.Point(354, 54)
        Me.FindUserMiddleNameInput.Name = "FindUserMiddleNameInput"
        Me.FindUserMiddleNameInput.Size = New System.Drawing.Size(250, 20)
        Me.FindUserMiddleNameInput.TabIndex = 22
        '
        'FindUserMiddleNameLabel
        '
        Me.FindUserMiddleNameLabel.AutoSize = True
        Me.FindUserMiddleNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindUserMiddleNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindUserMiddleNameLabel.Location = New System.Drawing.Point(237, 57)
        Me.FindUserMiddleNameLabel.Name = "FindUserMiddleNameLabel"
        Me.FindUserMiddleNameLabel.Size = New System.Drawing.Size(112, 17)
        Me.FindUserMiddleNameLabel.TabIndex = 19
        Me.FindUserMiddleNameLabel.Text = "Middle Name:"
        '
        'FindUserFirstNameInput
        '
        Me.FindUserFirstNameInput.Location = New System.Drawing.Point(354, 20)
        Me.FindUserFirstNameInput.Name = "FindUserFirstNameInput"
        Me.FindUserFirstNameInput.Size = New System.Drawing.Size(250, 20)
        Me.FindUserFirstNameInput.TabIndex = 20
        '
        'FindUserFirstNameLabel
        '
        Me.FindUserFirstNameLabel.AutoSize = True
        Me.FindUserFirstNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindUserFirstNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FindUserFirstNameLabel.Location = New System.Drawing.Point(237, 23)
        Me.FindUserFirstNameLabel.Name = "FindUserFirstNameLabel"
        Me.FindUserFirstNameLabel.Size = New System.Drawing.Size(96, 17)
        Me.FindUserFirstNameLabel.TabIndex = 18
        Me.FindUserFirstNameLabel.Text = "First Name:"
        '
        'CheckoutItemTab
        '
        Me.CheckoutItemTab.BackColor = System.Drawing.Color.Black
        Me.CheckoutItemTab.ImageKey = "scholars_lib_item_checkout.gif"
        Me.CheckoutItemTab.Location = New System.Drawing.Point(4, 36)
        Me.CheckoutItemTab.Name = "CheckoutItemTab"
        Me.CheckoutItemTab.Size = New System.Drawing.Size(984, 399)
        Me.CheckoutItemTab.TabIndex = 3
        Me.CheckoutItemTab.Text = "Checkout Item"
        Me.CheckoutItemTab.UseVisualStyleBackColor = True
        '
        'CheckinItemTab
        '
        Me.CheckinItemTab.BackColor = System.Drawing.Color.Black
        Me.CheckinItemTab.ImageKey = "scholars_lib_item_checkin.gif"
        Me.CheckinItemTab.Location = New System.Drawing.Point(4, 36)
        Me.CheckinItemTab.Name = "CheckinItemTab"
        Me.CheckinItemTab.Size = New System.Drawing.Size(984, 399)
        Me.CheckinItemTab.TabIndex = 4
        Me.CheckinItemTab.Text = "Checkin Item"
        Me.CheckinItemTab.UseVisualStyleBackColor = True
        '
        'AddEditItemTab
        '
        Me.AddEditItemTab.BackColor = System.Drawing.Color.Black
        Me.AddEditItemTab.ImageKey = "scholars_lib_item.gif"
        Me.AddEditItemTab.Location = New System.Drawing.Point(4, 36)
        Me.AddEditItemTab.Name = "AddEditItemTab"
        Me.AddEditItemTab.Size = New System.Drawing.Size(984, 399)
        Me.AddEditItemTab.TabIndex = 6
        Me.AddEditItemTab.Text = "Add/Edit Item"
        Me.AddEditItemTab.UseVisualStyleBackColor = True
        '
        'AddEditUserTab
        '
        Me.AddEditUserTab.BackColor = System.Drawing.Color.Black
        Me.AddEditUserTab.Controls.Add(Me.AddEditUserPanel)
        Me.AddEditUserTab.ImageKey = "scholars_lib_user.gif"
        Me.AddEditUserTab.Location = New System.Drawing.Point(4, 36)
        Me.AddEditUserTab.Name = "AddEditUserTab"
        Me.AddEditUserTab.Size = New System.Drawing.Size(984, 399)
        Me.AddEditUserTab.TabIndex = 5
        Me.AddEditUserTab.Text = "Add/Edit User"
        Me.AddEditUserTab.UseVisualStyleBackColor = True
        '
        'AddEditUserPanel
        '
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserDeleteButton)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserStateInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserAdministratorInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserAdministratorLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserOtherPhoneInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserOtherPhoneLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserHomePhoneInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserHomePhoneLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserPasswordInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserPasswordLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserCityInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserErrorMessage)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserButton)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserZipInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserZipLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserStateLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserCityLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserAddressInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserAddressLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserEmailInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserEmailLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserLastNameInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserLastNameLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserMiddleNameInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserMiddleNameLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserFirstNameInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserFirstNameLabel)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserUsernameInput)
        Me.AddEditUserPanel.Controls.Add(Me.AddEditUserUsernameLabel)
        Me.AddEditUserPanel.Location = New System.Drawing.Point(1, 6)
        Me.AddEditUserPanel.Name = "AddEditUserPanel"
        Me.AddEditUserPanel.Size = New System.Drawing.Size(980, 401)
        Me.AddEditUserPanel.TabIndex = 0
        '
        'AddEditUserDeleteButton
        '
        Me.AddEditUserDeleteButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserDeleteButton.Location = New System.Drawing.Point(492, 261)
        Me.AddEditUserDeleteButton.Name = "AddEditUserDeleteButton"
        Me.AddEditUserDeleteButton.Size = New System.Drawing.Size(132, 23)
        Me.AddEditUserDeleteButton.TabIndex = 36
        Me.AddEditUserDeleteButton.Text = "Delete"
        Me.AddEditUserDeleteButton.UseVisualStyleBackColor = True
        '
        'AddEditUserStateInput
        '
        Me.AddEditUserStateInput.FormattingEnabled = True
        Me.AddEditUserStateInput.Location = New System.Drawing.Point(630, 120)
        Me.AddEditUserStateInput.Name = "AddEditUserStateInput"
        Me.AddEditUserStateInput.Size = New System.Drawing.Size(250, 21)
        Me.AddEditUserStateInput.TabIndex = 29
        '
        'AddEditUserAdministratorInput
        '
        Me.AddEditUserAdministratorInput.AutoSize = True
        Me.AddEditUserAdministratorInput.Location = New System.Drawing.Point(630, 195)
        Me.AddEditUserAdministratorInput.Name = "AddEditUserAdministratorInput"
        Me.AddEditUserAdministratorInput.Size = New System.Drawing.Size(81, 17)
        Me.AddEditUserAdministratorInput.TabIndex = 33
        Me.AddEditUserAdministratorInput.Text = "CheckBox1"
        Me.AddEditUserAdministratorInput.UseVisualStyleBackColor = True
        '
        'AddEditUserAdministratorLabel
        '
        Me.AddEditUserAdministratorLabel.AutoSize = True
        Me.AddEditUserAdministratorLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserAdministratorLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserAdministratorLabel.Location = New System.Drawing.Point(503, 195)
        Me.AddEditUserAdministratorLabel.Name = "AddEditUserAdministratorLabel"
        Me.AddEditUserAdministratorLabel.Size = New System.Drawing.Size(120, 17)
        Me.AddEditUserAdministratorLabel.TabIndex = 35
        Me.AddEditUserAdministratorLabel.Text = "Administrator:"
        '
        'AddEditUserOtherPhoneInput
        '
        Me.AddEditUserOtherPhoneInput.Location = New System.Drawing.Point(208, 225)
        Me.AddEditUserOtherPhoneInput.Name = "AddEditUserOtherPhoneInput"
        Me.AddEditUserOtherPhoneInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserOtherPhoneInput.TabIndex = 21
        '
        'AddEditUserOtherPhoneLabel
        '
        Me.AddEditUserOtherPhoneLabel.AutoSize = True
        Me.AddEditUserOtherPhoneLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserOtherPhoneLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserOtherPhoneLabel.Location = New System.Drawing.Point(91, 228)
        Me.AddEditUserOtherPhoneLabel.Name = "AddEditUserOtherPhoneLabel"
        Me.AddEditUserOtherPhoneLabel.Size = New System.Drawing.Size(112, 17)
        Me.AddEditUserOtherPhoneLabel.TabIndex = 33
        Me.AddEditUserOtherPhoneLabel.Text = "Other Phone:"
        '
        'AddEditUserHomePhoneInput
        '
        Me.AddEditUserHomePhoneInput.Location = New System.Drawing.Point(208, 190)
        Me.AddEditUserHomePhoneInput.Name = "AddEditUserHomePhoneInput"
        Me.AddEditUserHomePhoneInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserHomePhoneInput.TabIndex = 19
        '
        'AddEditUserHomePhoneLabel
        '
        Me.AddEditUserHomePhoneLabel.AutoSize = True
        Me.AddEditUserHomePhoneLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserHomePhoneLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserHomePhoneLabel.Location = New System.Drawing.Point(91, 193)
        Me.AddEditUserHomePhoneLabel.Name = "AddEditUserHomePhoneLabel"
        Me.AddEditUserHomePhoneLabel.Size = New System.Drawing.Size(112, 17)
        Me.AddEditUserHomePhoneLabel.TabIndex = 31
        Me.AddEditUserHomePhoneLabel.Text = "Home Phone:"
        '
        'AddEditUserPasswordInput
        '
        Me.AddEditUserPasswordInput.Location = New System.Drawing.Point(208, 52)
        Me.AddEditUserPasswordInput.Name = "AddEditUserPasswordInput"
        Me.AddEditUserPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.AddEditUserPasswordInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserPasswordInput.TabIndex = 11
        '
        'AddEditUserPasswordLabel
        '
        Me.AddEditUserPasswordLabel.AutoSize = True
        Me.AddEditUserPasswordLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserPasswordLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserPasswordLabel.Location = New System.Drawing.Point(91, 55)
        Me.AddEditUserPasswordLabel.Name = "AddEditUserPasswordLabel"
        Me.AddEditUserPasswordLabel.Size = New System.Drawing.Size(90, 17)
        Me.AddEditUserPasswordLabel.TabIndex = 29
        Me.AddEditUserPasswordLabel.Text = "Password:"
        '
        'AddEditUserCityInput
        '
        Me.AddEditUserCityInput.Location = New System.Drawing.Point(630, 88)
        Me.AddEditUserCityInput.Name = "AddEditUserCityInput"
        Me.AddEditUserCityInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserCityInput.TabIndex = 27
        '
        'AddEditUserErrorMessage
        '
        Me.AddEditUserErrorMessage.AutoSize = True
        Me.AddEditUserErrorMessage.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.AddEditUserErrorMessage.Location = New System.Drawing.Point(454, 300)
        Me.AddEditUserErrorMessage.Name = "AddEditUserErrorMessage"
        Me.AddEditUserErrorMessage.Size = New System.Drawing.Size(49, 17)
        Me.AddEditUserErrorMessage.TabIndex = 28
        Me.AddEditUserErrorMessage.Text = "Error"
        '
        'AddEditUserButton
        '
        Me.AddEditUserButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserButton.Location = New System.Drawing.Point(337, 261)
        Me.AddEditUserButton.Name = "AddEditUserButton"
        Me.AddEditUserButton.Size = New System.Drawing.Size(132, 23)
        Me.AddEditUserButton.TabIndex = 34
        Me.AddEditUserButton.Text = "Submit"
        Me.AddEditUserButton.UseVisualStyleBackColor = True
        '
        'AddEditUserZipInput
        '
        Me.AddEditUserZipInput.Location = New System.Drawing.Point(630, 156)
        Me.AddEditUserZipInput.Name = "AddEditUserZipInput"
        Me.AddEditUserZipInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserZipInput.TabIndex = 31
        '
        'AddEditUserZipLabel
        '
        Me.AddEditUserZipLabel.AutoSize = True
        Me.AddEditUserZipLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserZipLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserZipLabel.Location = New System.Drawing.Point(503, 157)
        Me.AddEditUserZipLabel.Name = "AddEditUserZipLabel"
        Me.AddEditUserZipLabel.Size = New System.Drawing.Size(38, 17)
        Me.AddEditUserZipLabel.TabIndex = 24
        Me.AddEditUserZipLabel.Text = "Zip:"
        '
        'AddEditUserStateLabel
        '
        Me.AddEditUserStateLabel.AutoSize = True
        Me.AddEditUserStateLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserStateLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserStateLabel.Location = New System.Drawing.Point(503, 120)
        Me.AddEditUserStateLabel.Name = "AddEditUserStateLabel"
        Me.AddEditUserStateLabel.Size = New System.Drawing.Size(54, 17)
        Me.AddEditUserStateLabel.TabIndex = 22
        Me.AddEditUserStateLabel.Text = "State:"
        '
        'AddEditUserCityLabel
        '
        Me.AddEditUserCityLabel.AutoSize = True
        Me.AddEditUserCityLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserCityLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserCityLabel.Location = New System.Drawing.Point(503, 89)
        Me.AddEditUserCityLabel.Name = "AddEditUserCityLabel"
        Me.AddEditUserCityLabel.Size = New System.Drawing.Size(44, 17)
        Me.AddEditUserCityLabel.TabIndex = 20
        Me.AddEditUserCityLabel.Text = "City:"
        '
        'AddEditUserAddressInput
        '
        Me.AddEditUserAddressInput.Location = New System.Drawing.Point(630, 54)
        Me.AddEditUserAddressInput.Name = "AddEditUserAddressInput"
        Me.AddEditUserAddressInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserAddressInput.TabIndex = 25
        '
        'AddEditUserAddressLabel
        '
        Me.AddEditUserAddressLabel.AutoSize = True
        Me.AddEditUserAddressLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserAddressLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserAddressLabel.Location = New System.Drawing.Point(503, 53)
        Me.AddEditUserAddressLabel.Name = "AddEditUserAddressLabel"
        Me.AddEditUserAddressLabel.Size = New System.Drawing.Size(77, 17)
        Me.AddEditUserAddressLabel.TabIndex = 18
        Me.AddEditUserAddressLabel.Text = "Address:"
        '
        'AddEditUserEmailInput
        '
        Me.AddEditUserEmailInput.Location = New System.Drawing.Point(630, 20)
        Me.AddEditUserEmailInput.Name = "AddEditUserEmailInput"
        Me.AddEditUserEmailInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserEmailInput.TabIndex = 23
        '
        'AddEditUserEmailLabel
        '
        Me.AddEditUserEmailLabel.AutoSize = True
        Me.AddEditUserEmailLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserEmailLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserEmailLabel.Location = New System.Drawing.Point(503, 19)
        Me.AddEditUserEmailLabel.Name = "AddEditUserEmailLabel"
        Me.AddEditUserEmailLabel.Size = New System.Drawing.Size(55, 17)
        Me.AddEditUserEmailLabel.TabIndex = 16
        Me.AddEditUserEmailLabel.Text = "Email:"
        '
        'AddEditUserLastNameInput
        '
        Me.AddEditUserLastNameInput.Location = New System.Drawing.Point(208, 154)
        Me.AddEditUserLastNameInput.Name = "AddEditUserLastNameInput"
        Me.AddEditUserLastNameInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserLastNameInput.TabIndex = 17
        '
        'AddEditUserLastNameLabel
        '
        Me.AddEditUserLastNameLabel.AutoSize = True
        Me.AddEditUserLastNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserLastNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserLastNameLabel.Location = New System.Drawing.Point(91, 157)
        Me.AddEditUserLastNameLabel.Name = "AddEditUserLastNameLabel"
        Me.AddEditUserLastNameLabel.Size = New System.Drawing.Size(94, 17)
        Me.AddEditUserLastNameLabel.TabIndex = 14
        Me.AddEditUserLastNameLabel.Text = "Last Name:"
        '
        'AddEditUserMiddleNameInput
        '
        Me.AddEditUserMiddleNameInput.Location = New System.Drawing.Point(208, 120)
        Me.AddEditUserMiddleNameInput.Name = "AddEditUserMiddleNameInput"
        Me.AddEditUserMiddleNameInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserMiddleNameInput.TabIndex = 15
        '
        'AddEditUserMiddleNameLabel
        '
        Me.AddEditUserMiddleNameLabel.AutoSize = True
        Me.AddEditUserMiddleNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserMiddleNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserMiddleNameLabel.Location = New System.Drawing.Point(91, 123)
        Me.AddEditUserMiddleNameLabel.Name = "AddEditUserMiddleNameLabel"
        Me.AddEditUserMiddleNameLabel.Size = New System.Drawing.Size(112, 17)
        Me.AddEditUserMiddleNameLabel.TabIndex = 12
        Me.AddEditUserMiddleNameLabel.Text = "Middle Name:"
        '
        'AddEditUserFirstNameInput
        '
        Me.AddEditUserFirstNameInput.Location = New System.Drawing.Point(208, 86)
        Me.AddEditUserFirstNameInput.Name = "AddEditUserFirstNameInput"
        Me.AddEditUserFirstNameInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserFirstNameInput.TabIndex = 13
        '
        'AddEditUserFirstNameLabel
        '
        Me.AddEditUserFirstNameLabel.AutoSize = True
        Me.AddEditUserFirstNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserFirstNameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserFirstNameLabel.Location = New System.Drawing.Point(91, 89)
        Me.AddEditUserFirstNameLabel.Name = "AddEditUserFirstNameLabel"
        Me.AddEditUserFirstNameLabel.Size = New System.Drawing.Size(96, 17)
        Me.AddEditUserFirstNameLabel.TabIndex = 10
        Me.AddEditUserFirstNameLabel.Text = "First Name:"
        '
        'AddEditUserUsernameInput
        '
        Me.AddEditUserUsernameInput.Location = New System.Drawing.Point(208, 18)
        Me.AddEditUserUsernameInput.Name = "AddEditUserUsernameInput"
        Me.AddEditUserUsernameInput.Size = New System.Drawing.Size(250, 20)
        Me.AddEditUserUsernameInput.TabIndex = 9
        '
        'AddEditUserUsernameLabel
        '
        Me.AddEditUserUsernameLabel.AutoSize = True
        Me.AddEditUserUsernameLabel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEditUserUsernameLabel.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.AddEditUserUsernameLabel.Location = New System.Drawing.Point(91, 21)
        Me.AddEditUserUsernameLabel.Name = "AddEditUserUsernameLabel"
        Me.AddEditUserUsernameLabel.Size = New System.Drawing.Size(91, 17)
        Me.AddEditUserUsernameLabel.TabIndex = 8
        Me.AddEditUserUsernameLabel.Text = "Username:"
        '
        'TabImageList
        '
        Me.TabImageList.ImageStream = CType(resources.GetObject("TabImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TabImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TabImageList.Images.SetKeyName(0, "scholars_lib_home.gif")
        Me.TabImageList.Images.SetKeyName(1, "scholars_lib_find_item.gif")
        Me.TabImageList.Images.SetKeyName(2, "scholars_lib_find_user.gif")
        Me.TabImageList.Images.SetKeyName(3, "scholars_lib_item.gif")
        Me.TabImageList.Images.SetKeyName(4, "scholars_lib_user.gif")
        Me.TabImageList.Images.SetKeyName(5, "scholars_lib_item_checkin.gif")
        Me.TabImageList.Images.SetKeyName(6, "scholars_lib_item_checkout.gif")
        '
        'FinishedButton
        '
        Me.FinishedButton.BackColor = System.Drawing.Color.Transparent
        Me.FinishedButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishedButton.Location = New System.Drawing.Point(873, 1)
        Me.FinishedButton.Name = "FinishedButton"
        Me.FinishedButton.Size = New System.Drawing.Size(115, 23)
        Me.FinishedButton.TabIndex = 3
        Me.FinishedButton.Text = "Finished"
        Me.FinishedButton.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 491)
        Me.Controls.Add(Me.FinishedButton)
        Me.Controls.Add(Me.HomeTabs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Scholar's Library"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MainContextMenu.ResumeLayout(False)
        Me.HomeTabs.ResumeLayout(False)
        Me.HomeTab.ResumeLayout(False)
        Me.HomePanel.ResumeLayout(False)
        Me.HomePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FindItemTab.ResumeLayout(False)
        Me.FindItemPanel.ResumeLayout(False)
        Me.FindItemPanel.PerformLayout()
        CType(Me.FindItemItemsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FindPersonTab.ResumeLayout(False)
        Me.FindUserPanel.ResumeLayout(False)
        Me.FindUserPanel.PerformLayout()
        CType(Me.FindUserUsersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddEditUserTab.ResumeLayout(False)
        Me.AddEditUserPanel.ResumeLayout(False)
        Me.AddEditUserPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CurrentStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WhatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupTimer As System.Windows.Forms.Timer
    Friend WithEvents HomeTabs As System.Windows.Forms.TabControl
    Friend WithEvents FindPersonTab As System.Windows.Forms.TabPage
    Friend WithEvents FindItemTab As System.Windows.Forms.TabPage
    Friend WithEvents HomeTab As System.Windows.Forms.TabPage
    Friend WithEvents CheckoutItemTab As System.Windows.Forms.TabPage
    Friend WithEvents CheckinItemTab As System.Windows.Forms.TabPage
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents HomeDisclaimer As System.Windows.Forms.Label
    Friend WithEvents HomePanel As System.Windows.Forms.Panel
    Friend WithEvents FindPersonLink As System.Windows.Forms.LinkLabel
    Friend WithEvents FindItemLink As System.Windows.Forms.LinkLabel
    Friend WithEvents AddUserLink As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckinItemLink As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckoutItemLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AddEditUserTab As System.Windows.Forms.TabPage
    Friend WithEvents AddItemLink As System.Windows.Forms.LinkLabel
    Friend WithEvents AddEditItemTab As System.Windows.Forms.TabPage
    Friend WithEvents FindItemPanel As System.Windows.Forms.Panel
    Friend WithEvents FindItemAuthorLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemTitleLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemPublishDateLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemPublisherLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemButton As System.Windows.Forms.Button
    Friend WithEvents FindItemItemsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FindItemAuthorInput As System.Windows.Forms.TextBox
    Friend WithEvents FindItemPublisherInput As System.Windows.Forms.TextBox
    Friend WithEvents FindItemTitleInput As System.Windows.Forms.TextBox
    Friend WithEvents FindItemPublishedToLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemPublishedFromLabel As System.Windows.Forms.Label
    Friend WithEvents FindItemPublishedToInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents FindItemPublishedFromInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddEditUserPanel As System.Windows.Forms.Panel
    Friend WithEvents AddEditUserLastNameInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserMiddleNameInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserMiddleNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserFirstNameInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserUsernameInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserZipInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserZipLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserStateLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserCityLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserAddressInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserAddressLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserEmailInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserEmailLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserButton As System.Windows.Forms.Button
    Friend WithEvents AddEditUserErrorMessage As System.Windows.Forms.Label
    Friend WithEvents AddEditUserCityInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserPasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserAdministratorInput As System.Windows.Forms.CheckBox
    Friend WithEvents AddEditUserAdministratorLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserOtherPhoneInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserOtherPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserHomePhoneInput As System.Windows.Forms.TextBox
    Friend WithEvents AddEditUserHomePhoneLabel As System.Windows.Forms.Label
    Friend WithEvents AddEditUserStateInput As System.Windows.Forms.ComboBox
    Friend WithEvents AddEditUserDeleteButton As System.Windows.Forms.Button
    Friend WithEvents FindUserPanel As System.Windows.Forms.Panel
    Friend WithEvents FindUserEmailInput As System.Windows.Forms.TextBox
    Friend WithEvents FindUserEmailLabel As System.Windows.Forms.Label
    Friend WithEvents FindUserLastNameInput As System.Windows.Forms.TextBox
    Friend WithEvents FindUserLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FindUserMiddleNameInput As System.Windows.Forms.TextBox
    Friend WithEvents FindUserMiddleNameLabel As System.Windows.Forms.Label
    Friend WithEvents FindUserFirstNameInput As System.Windows.Forms.TextBox
    Friend WithEvents FindUserFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents FindUserButton As System.Windows.Forms.Button
    Friend WithEvents FindUserUsersGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FinishedButton As System.Windows.Forms.Button
    Friend WithEvents TabImageList As System.Windows.Forms.ImageList
End Class
