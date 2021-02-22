Public Class Admin
    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim login_page As New Form1()
        login_page.Show()
        Me.Close()
    End Sub
End Class