Imports System.Data.SQLite

Public Class Admin
    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim login_page As New Form1()
        login_page.Show()
        Me.Close()
    End Sub



    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim cmd1, cmd2, cmd3 As New SQLiteCommand

        Dim db_user As String
        Dim Sql1 = "select username,password,email,privilege from credentials"
        Dim Sql2 = "select id,category,game,price from game"
        cmd1.Connection = conn
        cmd1.CommandText = "SELECT country  , count(country) FROM credentials
GROUP BY country;"
        cmd2.Connection = conn
        cmd2.CommandText = "SELECT category , count(category) As `Count` FROM game
GROUP BY category;"
        cmd3.Connection = conn
        cmd3.CommandText = " SELECT game , count(game) As `Count` FROM orders
GROUP BY game; 
"
        Dim adapter1 As New SQLiteDataAdapter(Sql1, conn)
        Dim adapter2 As New SQLiteDataAdapter(Sql2, conn)
        Dim reader1 As SQLiteDataReader = cmd1.ExecuteReader()
        Dim reader2 As SQLiteDataReader = cmd2.ExecuteReader()
        Dim reader3 As SQLiteDataReader = cmd3.ExecuteReader()

        Dim table1 As New DataSet
        Dim table2 As New DataSet
        adapter1.Fill(table1)
        adapter2.Fill(table2)

        DataGridView1.DataSource = table1.Tables(0)
        DataGridView2.DataSource = table2.Tables(0)

        Chart1.Series("People").Points.Clear()
        Chart2.Series("Game").Points.Clear()
        Chart3.Series("Order").Points.Clear()




        While reader1.Read()
            Chart1.Series("People").Points.AddXY(reader1.GetValue(0), reader1.GetValue(1))

        End While

        While reader2.Read()
            Chart2.Series("Game").Points.AddXY(reader2.GetValue(0), reader2.GetValue(1))

        End While

        While reader3.Read()
            Chart3.Series("Order").Points.AddXY(reader3.GetValue(0), reader3.GetValue(1))

        End While


        conn.Close()

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim edit As New EditCustomer
        edit.username = DataGridView1.SelectedCells(0).Value
        edit.password = DataGridView1.SelectedCells(1).Value
        edit.privilege = DataGridView1.SelectedCells(3).Value
        edit.ShowDialog()
        Admin_Load(sender, e)

    End Sub

    Private Sub DataGridView2_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseDoubleClick

        Dim edit As New EditGame
        edit.id = DataGridView2.SelectedCells(0).Value
        edit.category = DataGridView2.SelectedCells(1).Value
        edit.game = DataGridView2.SelectedCells(2).Value
        edit.price = DataGridView2.SelectedCells(3).Value
        edit.ShowDialog()
        Admin_Load(sender, e)
    End Sub

End Class