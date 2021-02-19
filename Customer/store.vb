Imports System.Data.SQLite
Imports System.Net.Mail
Public Class store
    Public Property txt_user As String
    Dim check_class As New check_class
    Dim order_name As String
    Dim order_price As Double
    Dim order_key As String
    Dim game_name
    Dim game_price
    Dim constr As New SQLiteConnection("Data Source=C:\Users\2015\source\repos\Customer\Customer\Data.db;")
    Dim conn As New SQLiteConnection(constr)
    Dim db_user As String
    Private Sub store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = txt_user
        cboCategory.SelectedIndex = 0
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "select Distinct category from game"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            cboCategory.Items.Add(reader(0))
        End While
        conn.Close()
    End Sub

    Function filterData(valueToSearch)
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "select game,price from game where game like '" & valueToSearch & "%'"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(reader)
        reader.Close()
        conn.Close()
        DataGridView1.DataSource = dt
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            If cboCategory.SelectedIndex = 0 Then
                conn.Open()
                Dim cmd As New SQLiteCommand
                cmd.Connection = conn
                cmd.CommandText = "select game,price from game"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable
                dt.Load(reader)
                reader.Close()
                conn.Close()
                DataGridView1.DataSource = dt

            Else
                conn.Open()
                Dim cmd As New SQLiteCommand
                cmd.Connection = conn
                cmd.CommandText = "select game,price from game where category='" & cboCategory.SelectedItem & "'"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable
                dt.Load(reader)
                reader.Close()
                conn.Close()
                DataGridView1.DataSource = dt
            End If
        Else
            filterData(txtSearch.Text)
        End If

    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Dim g_name = DataGridView1.CurrentRow.Cells(0).Value
        Dim g_price = DataGridView1.CurrentRow.Cells(1).Value
        Dim order = g_name + " x1 " + CStr(g_price)
        lbOrders.Items.Add(order)
    End Sub

    Private Sub lbOrders_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbOrders.MouseDoubleClick
        lbOrders.Items.RemoveAt(lbOrders.SelectedIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        check_order()
        Dim check_credit = check_class.checK_credit(lblUser.Text)
        Dim invoice = check_class.random_invoice()
        Dim game = order_name
        Dim price = order_price
        Dim date_time = DateTime.Now
        Dim key = order_key
        Dim mail = check_class.get_email(lblUser.Text)
        Dim userId = check_class.get_userId(lblUser.Text)
        If lbOrders.Items.Count > 0 Then
            order_name = ""
            order_key = ""
            order_price = 0
            If check_credit = True Then
                check_class.insert_order(invoice, game, key, price, date_time, mail, userId)
                Dim address = check_class.get_address(txt_user)
                Dim fullname = check_class.getName(userId)
                check_class.mail(invoice, date_time, fullname, address, mail, key)
                Dim order_detail As New order_detail()
                order_detail.txt_user = txt_user
                order_detail.Show()
                lbOrders.Items.Clear()
            Else
                Dim msg = MessageBox.Show("Payment information was not found!" & vbNewLine & " Would you like to add payment information?", "Payment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then
                    Dim validate As New credit_validate()
                    validate.txt_user = txt_user
                    validate.Show()
                End If
            End If
        Else
            MsgBox("Please Select Your Game Before Purchase...")
        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Dim home As New home()
        home.txt_user = txt_user
        home.Show()
        Me.Close()
    End Sub

    Function check_order()
        Dim key As String
        For i As Integer = 0 To lbOrders.Items.Count() - 1
            Dim str As String = lbOrders.Items(i)
            game_name = str.Split(" "c)(0)
            game_price = str.Split(" "c)(2)
            If i = lbOrders.Items.Count() - 1 Then
                order_name += game_name
                key = check_class.get_cdKey()
                order_key += key
            ElseIf i > 0 Then
                order_name += game_name + ","
                key = check_class.get_cdKey()
                order_key += key + ","
            ElseIf i = 0 And i = lbOrders.Items.Count() - 1 Then
                order_name += game_name
                key = check_class.get_cdKey()
                order_key += key
            Else
                order_name += game_name + ","
                key = check_class.get_cdKey()
                order_key += key + ","
            End If

            order_price += CDbl(game_price)
        Next
    End Function

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter

    End Sub
End Class