Imports System.Data.SQLite
Public Class order_detail
    Public Property txt_user As String
    Dim check_class As New check_class
    Dim constr As New SQLiteConnection("Data Source=C:\Users\2015\source\repos\Customer\Customer\Data.db;")
    Dim conn As New SQLiteConnection(constr)
    Private Sub order_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim email = check_class.get_email(txt_user)
        Dim user_id = check_class.getUserID(txt_user)
        Dim total = check_class.get_total_price(user_id)
        Dim address = check_class.get_address(txt_user)
        Dim price = check_class.get_price(user_id)
        lblUser.Text = txt_user
        lblEmail.Text = email
        lblTotal.Text = price
        lblHistoryPrice.Text = total
        lblBillAddress.Text = address
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "select invoice_id,game,price,date from orders where user_id='" & user_id & "'"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(reader)
        reader.Close()
        conn.Close()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class