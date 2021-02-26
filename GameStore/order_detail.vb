Imports System.Data.SQLite
Public Class order_detail
    Public Property txt_user As String
    Dim check_class As New check_class
    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)
    Private Sub order_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim check_address = check_class.checK_address(txt_user)
        Dim email = check_class.get_email(txt_user)
        Dim user_id = check_class.getUserID(txt_user)
        Dim total = check_class.get_total_price(user_id)
        Dim address As String
        Dim price = check_class.get_price(user_id)
        If check_address = False Then
            address = ""
            lblUser.Text = txt_user
            lblEmail.Text = email
            lblTotal.Text = price
            lblHistoryPrice.Text = total
            lblBillAddress.Text = address
        Else
            address = check_class.get_address(txt_user)
            lblUser.Text = txt_user
            lblEmail.Text = email
            lblTotal.Text = price
            lblHistoryPrice.Text = total
            lblBillAddress.Text = address
        End If
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class