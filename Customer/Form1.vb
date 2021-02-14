Imports System.Data.SQLite
Public Class Form1
    Dim constr As New SQLiteConnection("Data Source=C:\Users\2015\source\repos\Customer\Customer\Data.db;")
    Dim conn As New SQLiteConnection(constr)
    Dim db_user As String
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim register As New register()
        register.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn.Open()
        Dim user = txtBoxUser.Text
        Dim pass = txtBoxPass.Text
        Dim db_user As String
        Dim db_pass As String
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "select username,password from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetString("username") Then
                If pass = reader.GetString("password") Then
                    db_user = reader.GetString("username")
                    db_pass = reader.GetString("password")
                End If
            End If
        End While
        conn.Close()

        If user = db_user And pass = db_pass Then
            Dim home As New home()
            home.txt_user = db_user
            home.Show()
            Me.Close()
        Else
            MsgBox("Username/Password incorrect")
        End If

    End Sub

End Class