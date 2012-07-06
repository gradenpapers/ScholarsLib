Public Class Login

    Private HomeForm As Home

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LoadMe(ByRef ParentForm As Home)
        HomeForm = ParentForm
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        LoginButton.Enabled = False
        ExitButton.Enabled = False
        UsernameInput.Enabled = False
        PasswordInput.Enabled = False

        UserLogin()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        HomeForm.UserId = -1

        HomeForm = Nothing

        Me.Close()
    End Sub

    Private Sub PasswordInput_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserLogin()
        End If
    End Sub

    Private Sub UserLogin()
        Dim LoginDt As New Data.DataTable

        ErrorMessage.Visible = False

        Using data_layer As New DataLayer
            LoginDt = data_layer.UserLogin(UsernameInput.Text, PasswordInput.Text)
        End Using

        If LoginDt.Rows.Count > 0 Then
            HomeForm.UserId = LoginDt.Rows(0).Item("user_id")
            HomeForm.Email = LoginDt.Rows(0).Item("email")
            HomeForm.FirstName = LoginDt.Rows(0).Item("first_name")
            HomeForm.MiddleName = LoginDt.Rows(0).Item("middle_name")
            HomeForm.LastName = LoginDt.Rows(0).Item("last_name")
            HomeForm.HomePhone = LoginDt.Rows(0).Item("home_phone")
            HomeForm.OtherPhone = LoginDt.Rows(0).Item("other_phone")
            HomeForm.Administrator = LoginDt.Rows(0).Item("administrator")

            HomeForm = Nothing

            LoginDt.Dispose()

            Me.Close()
        Else
            LoginDt.Dispose()

            ErrorMessage.Text = "Login error.  Please try again."
            ErrorMessage.Location = New Point((Me.Width / 2) - (ErrorMessage.Width / 2), ErrorMessage.Location.Y)
            ErrorMessage.Visible = True

            LoginButton.Enabled = True
            ExitButton.Enabled = True
            UsernameInput.Enabled = True
            PasswordInput.Enabled = True
        End If
    End Sub
End Class
