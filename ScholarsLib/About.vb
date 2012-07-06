Public Class About

    Private Sub About_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AboutVersionLabel.Text = Application.ProductVersion
    End Sub
End Class