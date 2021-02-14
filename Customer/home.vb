Public Class home
    Public Property txt_user As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login_page As New Form1()
        login_page.Show()
        Me.Close()
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        Dim store As New store()
        store.txt_user = txt_user
        store.Show()
        Me.Close()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = txt_user
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim order As New order_detail()
        order.txt_user = txt_user
        order.Show()
    End Sub
End Class