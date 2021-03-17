Public Class frmLogin

 
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        myLogin.verifyUser()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub GlobalTimer1_Tick(sender As Object, e As EventArgs) Handles GlobalTimer1.Tick
          globalClock = Format(Date.Now, "General Date")

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            myLogin.verifyUser()
        End If
    End Sub
End Class
