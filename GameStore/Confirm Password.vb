Public Class Confirm_Password

    Public confirm_pass As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        confirm_pass = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub


End Class