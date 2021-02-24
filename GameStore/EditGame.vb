Imports System.Data.SQLite

Public Class EditGame

    Public category As String
    Public game As String
    Public price As String
    Public id As Integer

    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)

    Private Sub EditGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT category from game GROUP BY category;"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            tb_cat.Items.Add(reader.GetValue(0))
        End While
        conn.Close()
        tb_cat.SelectedItem = category
        tb_name.Text = game
        tb_price.Text = price



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_name.Text <> "" And tb_price.Text <> "" And tb_cat.Text <> "" Then
            If Not IsNumeric(tb_price.Text) Then
                MessageBox.Show("Price must be numberic", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If CDbl(tb_price.Text < 0) Then
                MessageBox.Show("Price must more than Zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            conn.Open()
            Dim cmd As New SQLiteCommand
            cmd.Connection = conn
            cmd.CommandText = String.Format("
UPDATE game
SET game = @name, category = @cat , price = @price
WHERE id = '{0}'
", id)
            cmd.Parameters.AddWithValue("@name", tb_name.Text)
            cmd.Parameters.AddWithValue("@cat", tb_cat.Text)
            cmd.Parameters.AddWithValue("@price", CDbl(tb_price.Text))

            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update Successful", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please Fill All Of The Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim confirm = MessageBox.Show(String.Format("Please Confirm to Delete [ ID : {0} ] ", id), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm = DialogResult.Yes Then
            conn.Open()
            Dim cmd As New SQLiteCommand
            cmd.Connection = conn
            cmd.CommandText = String.Format("
UPDATE game
SET game = @name, category = @cat , price = @price
WHERE id = '{0}'
", id)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Delete Successful", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb_name.Text <> "" And tb_price.Text <> "" And tb_cat.Text <> "" Then
            If Not IsNumeric(tb_price.Text) Then
                MessageBox.Show("Price must be numberic", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If CDbl(tb_price.Text < 0) Then
                MessageBox.Show("Price must more than Zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            conn.Open()
            Dim cmd As New SQLiteCommand
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO game (game, category, price)
VALUES (@name, @cat, @price)"
            cmd.Parameters.AddWithValue("@name", tb_name.Text)
            cmd.Parameters.AddWithValue("@cat", tb_cat.Text)
            cmd.Parameters.AddWithValue("@price", CDbl(tb_price.Text))

            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Insert Successful", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please Fill All Of The Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tb_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_cat.SelectedIndexChanged

    End Sub
End Class