Public Class frameMainFrame
    'Dim vari As Integer = 1
    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "admin1" And txtPassword.Text = "ad123" Then
            MsgBox("Access Granted as ADMIN 1")
            formSelect_Category.Show()
            Me.Hide()
            '  vari = 2
        ElseIf txtUserName.Text = "admin2" And txtPassword.Text = "admin123" Then
            MsgBox("Access Granted as ADMIN 2")
            formSelect_Category.Show()
            Me.Hide()
            '   vari = 2
        Else
            MsgBox("Access Denied")
        End If
        user = txtUserName.Text
        'If vari = 2 Then
        'Me.Close()
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class

