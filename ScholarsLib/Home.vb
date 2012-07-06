Public Class Home
    Implements IUserInterface

#Region "IUserInterface"
    Private TempUserId As Integer
    Private TempEmail As String
    Private TempFirstName As String
    Private TempMiddleName As String
    Private TempLastName As String
    Private TempHomePhone As String
    Private TempOtherPhone As String
    Private TempAdministrator As Boolean

    Public Property UserId() As Integer Implements IUserInterface.UserId
        Get
            UserId = TempUserId
        End Get
        Set(ByVal value As Integer)
            TempUserId = value
        End Set
    End Property

    Public Property Email() As String Implements IUserInterface.Email
        Get
            Email = TempEmail
        End Get
        Set(ByVal value As String)
            TempEmail = value
        End Set
    End Property

    Public Property FirstName() As String Implements IUserInterface.FirstName
        Get
            FirstName = TempFirstName
        End Get
        Set(ByVal value As String)
            TempFirstName = value
        End Set
    End Property

    Public Property LastName() As String Implements IUserInterface.LastName
        Get
            LastName = TempLastName
        End Get
        Set(ByVal value As String)
            TempLastName = value
        End Set
    End Property

    Public Property MiddleName() As String Implements IUserInterface.MiddleName
        Get
            MiddleName = TempMiddleName
        End Get
        Set(ByVal value As String)
            TempMiddleName = value
        End Set
    End Property

    Public Property HomePhone() As String Implements IUserInterface.HomePhone
        Get
            HomePhone = TempHomePhone
        End Get
        Set(ByVal value As String)
            TempHomePhone = value
        End Set
    End Property

    Public Property OtherPhone() As String Implements IUserInterface.OtherPhone
        Get
            OtherPhone = TempOtherPhone
        End Get
        Set(ByVal value As String)
            TempOtherPhone = value
        End Set
    End Property

    Public Property Administrator() As Boolean Implements IUserInterface.Administrator
        Get
            Administrator = TempAdministrator
        End Get
        Set(ByVal value As Boolean)
            TempAdministrator = value
        End Set
    End Property
#End Region

#Region "Main Form Stuff"
    Dim CurrentUser As Integer = -1
    Dim CurrentItem As Integer = -1

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = MainContextMenu

        Me.WindowState = FormWindowState.Maximized

        InitializeTabs()
        InitializeDataBoundFields()
    End Sub

    Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize, Me.ResizeEnd, Me.SizeChanged
        HomeTabs.Height = Me.Height - 80
        HomeTabs.Width = Me.Width
        Center(HomePanel)
        Center(FindItemPanel)
        Center(FindUserPanel)
        Center(AddEditUserPanel)
        FinishedButton.Location = New System.Drawing.Point(Me.Width - FinishedButton.Width - 15, FinishedButton.Location.Y)
    End Sub

    ''' <summary>
    ''' This sub's only function is to load the login screen.  This was done because
    ''' the program threw an exception everytime I tried to do this from within the
    ''' page load if the user chose to exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub StartupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupTimer.Tick
        StartupTimer.Enabled = False

        CurrentStatus.Text = "Login"

        UserId = -1

        Dim LoginForm As New Login
        LoginForm.LoadMe(Me)
        LoginForm.ShowDialog()
        LoginForm.Dispose()

        If UserId = -1 Then
            Me.Close()
        Else
            EnforcePrivilages()

            CurrentStatus.Text = "Home"
        End If
    End Sub

    Private Sub InitializeTabs()
        HomeTab.BackColor = Color.Black
        FindItemTab.BackColor = Color.Black
        FindPersonTab.BackColor = Color.Black
        CheckoutItemTab.BackColor = Color.Black
        CheckinItemTab.BackColor = Color.Black
        AddEditItemTab.BackColor = Color.Black
        AddEditUserTab.BackColor = Color.Black
    End Sub

    Private Sub InitializeDataBoundFields()
        Dim StateDt As New DataTable

        Using data_layer As New DataLayer
            StateDt = data_layer.GetStates()
        End Using

        StateDt.Rows.InsertAt(StateDt.NewRow(), 0)

        AddEditUserStateInput.ValueMember = "state_cd"
        AddEditUserStateInput.DisplayMember = "state_desc"
        AddEditUserStateInput.DataSource = StateDt
    End Sub

    Private Sub EnforcePrivilages()
        If Not Administrator Then
            AddUserLink.Visible = False
            AddItemLink.Visible = False
            AddEditUserTab.Dispose()
            AddEditItemTab.Dispose()
        End If
    End Sub
#End Region

#Region "Main Menu Stuff"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim AboutForm As New About
        AboutForm.ShowDialog()
        AboutForm.Dispose()
    End Sub
#End Region

#Region "Footer Strip Stuff"
    'code
#End Region

#Region "Tab/Link Clicks"
    Private Sub FindItemTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindItemTab.Enter
        CurrentStatus.Text = "Find an Item"

        FindItemPublishedFromInput.Value = "1/1/1900"
        FindItemPublishedToInput.Value = Date.Today.ToShortDateString
        FindItemAuthorInput.Text = ""
        FindItemTitleInput.Text = ""
        FindItemPublisherInput.Text = ""
        FindItemItemsGrid.DataSource = ""
    End Sub

    Private Sub FindPersonTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindPersonTab.Enter
        CurrentStatus.Text = "Find a Person"

        FindUserFirstNameInput.Text = ""
        FindUserMiddleNameInput.Text = ""
        FindUserLastNameInput.Text = ""
        FindUserEmailInput.Text = ""
        FindUserUsersGrid.DataSource = ""
    End Sub

    Private Sub CheckoutItemTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutItemTab.Enter
        CurrentStatus.Text = "Checkout an Item"
    End Sub

    Private Sub CheckinItemTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckinItemTab.Enter
        CurrentStatus.Text = "Checkin an Item"
    End Sub

    Private Sub AddEditUserTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditUserTab.Enter
        CurrentStatus.Text = "Add/Edit a User"

        AddEditUserErrorMessage.Visible = False

        If CurrentUser = -1 Then
            AddEditUserButton.Text = "Add User"
            AddEditUserDeleteButton.Visible = False

            AddEditUserUsernameInput.Text = ""
            AddEditUserPasswordInput.Text = ""
            AddEditUserFirstNameInput.Text = ""
            AddEditUserMiddleNameInput.Text = ""
            AddEditUserLastNameInput.Text = ""
            AddEditUserHomePhoneInput.Text = ""
            AddEditUserOtherPhoneInput.Text = ""
            AddEditUserEmailInput.Text = ""
            AddEditUserAddressInput.Text = ""
            AddEditUserCityInput.Text = ""
            AddEditUserStateInput.SelectedIndex = 0
            AddEditUserZipInput.Text = ""
            AddEditUserAdministratorInput.Checked = False
        Else
            AddEditUserButton.Text = "Update User"
            AddEditUserDeleteButton.Visible = True

            Dim UserDt As New DataTable

            Using data_layer As New DataLayer
                UserDt = data_layer.GetUserInfo(CurrentUser)
            End Using

            AddEditUserUsernameInput.Text = UserDt.Rows(0).Item("username")
            AddEditUserPasswordInput.Text = UserDt.Rows(0).Item("password")
            AddEditUserFirstNameInput.Text = UserDt.Rows(0).Item("first_name")
            AddEditUserMiddleNameInput.Text = UserDt.Rows(0).Item("middle_name")
            AddEditUserLastNameInput.Text = UserDt.Rows(0).Item("last_name")
            AddEditUserHomePhoneInput.Text = UserDt.Rows(0).Item("home_phone")
            AddEditUserOtherPhoneInput.Text = UserDt.Rows(0).Item("other_phone")
            AddEditUserEmailInput.Text = UserDt.Rows(0).Item("email")
            AddEditUserAddressInput.Text = UserDt.Rows(0).Item("address")
            AddEditUserCityInput.Text = UserDt.Rows(0).Item("city")
            AddEditUserStateInput.SelectedValue = UserDt.Rows(0).Item("state_cd")
            AddEditUserZipInput.Text = UserDt.Rows(0).Item("zip")
            AddEditUserAdministratorInput.Checked = Convert.ToBoolean(UserDt.Rows(0).Item("administrator"))

            UserDt.Dispose()
        End If
    End Sub

    Private Sub AddEditItemTab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditItemTab.Enter
        CurrentStatus.Text = "Add/Edit an Item"
    End Sub

    Private Sub FindItemLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FindItemLink.LinkClicked
        HomeTabs.SelectTab(FindItemTab)
    End Sub

    Private Sub FindPersonLink_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FindPersonLink.LinkClicked
        HomeTabs.SelectTab(FindPersonTab)
    End Sub

    Private Sub CheckinItemLink_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CheckinItemLink.LinkClicked
        HomeTabs.SelectTab(CheckinItemTab)
    End Sub

    Private Sub CheckoutItemLink_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CheckoutItemLink.LinkClicked
        HomeTabs.SelectTab(CheckoutItemTab)
    End Sub

    Private Sub AddUserLink_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddUserLink.LinkClicked
        HomeTabs.SelectTab(AddEditUserTab)
    End Sub

    Private Sub AddItemLink_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AddItemLink.LinkClicked
        HomeTabs.SelectTab(AddEditItemTab)
    End Sub
#End Region

#Region "Find Item Stuff"
    Private Sub FindItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindItemButton.Click
        Dim dt As New DataTable

        Using data_layer As New DataLayer
            dt = data_layer.GetItems(FindItemAuthorInput.Text, FindItemTitleInput.Text, FindItemPublishedFromInput.Value.ToShortDateString, FindItemPublishedToInput.Value.ToShortDateString, FindItemPublisherInput.Text)
        End Using

        With FindItemItemsGrid
            .Columns.Clear()
            .AutoGenerateColumns = True
            .DataSource = dt
            .Columns("item_id").Visible = False
            .Columns("item_type_desc").Width = 150
            .Columns("item_type_desc").HeaderText = "Item Type"
            .Columns("title").Width = .Width - 475 'This is the width of the other cells + the width of the left margin (45px).
            .Columns("title").HeaderText = "Title"
            .Columns("author").Width = 100
            .Columns("author").HeaderText = "Author"
            .Columns("publish_date").Width = 80
            .Columns("publish_date").HeaderText = "Date"
            .Columns("checked_out").Width = 100
            .Columns("checked_out").HeaderText = "Checked Out"
        End With
    End Sub

    Private Sub FindItemItemsGrid_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles FindItemItemsGrid.SelectionChanged
        If FindItemItemsGrid.CurrentRow IsNot Nothing Then
            If FindItemItemsGrid.CurrentRow.Index <> FindItemItemsGrid.Rows.Count - 1 Then
                CurrentItem = FindItemItemsGrid.Rows(FindItemItemsGrid.CurrentRow.Index).Cells(0).Value
            Else
                CurrentItem = -1
            End If
        Else
            CurrentItem = -1
        End If
    End Sub
#End Region

#Region "Add/Edit User Stuff"
    Private Sub AddEditUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditUserButton.Click
        AddEditUserErrorMessage.Visible = False

        If CurrentUser = -1 Then
            Dim ReturnValue As DataTable

            Using data_layer As New DataLayer
                ReturnValue = data_layer.AddUser(AddEditUserUsernameInput.Text, AddEditUserPasswordInput.Text, AddEditUserFirstNameInput.Text, AddEditUserMiddleNameInput.Text, AddEditUserLastNameInput.Text, AddEditUserEmailInput.Text, AddEditUserAddressInput.Text, AddEditUserCityInput.Text, AddEditUserStateInput.SelectedValue, AddEditUserZipInput.Text, AddEditUserHomePhoneInput.Text, AddEditUserOtherPhoneInput.Text, AddEditUserAdministratorInput.Checked)
            End Using

            If ReturnValue.Rows(0).Item("ret_val") <> "0" Then
                AddEditUserErrorMessage.Text = "There was an error adding this user."
                AddEditUserErrorMessage.Visible = True
            Else
                CurrentUser = ReturnValue.Rows(0).Item("user_id")
                AddEditUserButton.Text = "Update User"
                AddEditUserDeleteButton.Visible = True
            End If
        Else
            Dim ReturnValue As String

            Using data_layer As New DataLayer
                ReturnValue = data_layer.UpdateUser(CurrentUser, AddEditUserUsernameInput.Text, AddEditUserPasswordInput.Text, AddEditUserFirstNameInput.Text, AddEditUserMiddleNameInput.Text, AddEditUserLastNameInput.Text, AddEditUserEmailInput.Text, AddEditUserAddressInput.Text, AddEditUserCityInput.Text, AddEditUserStateInput.Text, AddEditUserZipInput.Text, AddEditUserHomePhoneInput.Text, AddEditUserOtherPhoneInput.Text, AddEditUserAdministratorInput.Checked)
            End Using

            If ReturnValue <> "0" Then
                AddEditUserErrorMessage.Text = "There was an error updating this user."
                AddEditUserErrorMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub AddEditUserDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditUserDeleteButton.Click
        AddEditUserErrorMessage.Visible = False

        If MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo, "?Delete?") = MsgBoxResult.Yes Then
            Dim ReturnValue As String = ""

            Using data_layer As New DataLayer
                ReturnValue = data_layer.DeleteUser(CurrentUser)
            End Using

            If ReturnValue = "0" Then
                CurrentUser = -1
                HomeTabs.SelectTab(HomeTab)
            Else
                AddEditUserErrorMessage.Text = "There was an error deleteing this user."
                AddEditUserErrorMessage.Visible = True
            End If
        End If
    End Sub
#End Region

#Region "Standard Functions"
    Public Sub Center(ByRef TheObj As Object)
        TheObj.Location = New System.Drawing.Point((Me.Width / 2) - (TheObj.Width / 2), TheObj.Location.Y)
    End Sub

    Private Sub FinishedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishedButton.Click
        'Global Variables
        CurrentUser = -1
        CurrentItem = -1

        HomeTabs.SelectTab(HomeTab)
    End Sub
#End Region

#Region "Find User Stuff"
    Private Sub FindUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindUserButton.Click
        Dim FindUserDt As New DataTable

        Using data_layer As New DataLayer
            FindUserDt = data_layer.GetUsers(FindUserFirstNameInput.Text, FindUserMiddleNameInput.Text, FindUserLastNameInput.Text, FindUserEmailInput.Text)
        End Using

        With FindUserUsersGrid
            .AutoGenerateColumns = True
            .DataSource = FindUserDt
            .Columns(0).Visible = False
            .Columns(1).Width = .Width - 495 'This is the width of the other cells + the width of the left margin (45px).
            .Columns(2).Width = 100
            .Columns(3).Width = 250
            .Columns(4).Width = 100
        End With
    End Sub

    Private Sub FindUserUsersGrid_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles FindUserUsersGrid.SelectionChanged
        If FindUserUsersGrid.CurrentRow IsNot Nothing Then
            If FindUserUsersGrid.CurrentRow.Index <> FindUserUsersGrid.Rows.Count - 1 Then
                CurrentUser = FindUserUsersGrid.Rows(FindUserUsersGrid.CurrentRow.Index).Cells(0).Value
            Else
                CurrentUser = -1
            End If
        Else
            CurrentUser = -1
        End If
    End Sub
#End Region

End Class