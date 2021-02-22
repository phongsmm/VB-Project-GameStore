Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text
Public Class Form1
    Dim dbpath = Application.StartupPath
    Dim dbname = "data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)
    Dim db_user As String
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim register As New register()
        register.Show()
        Me.Close()
    End Sub

    Public Function MD5(ByVal strString As String) As String
        Dim ASCIIenc As New ASCIIEncoding
        Dim strReturn As String
        Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(strString)
        Dim Md5Hash As New MD5CryptoServiceProvider
        Dim ByteHash() As Byte = Md5Hash.ComputeHash(ByteSourceText)
        For Each b As Byte In ByteHash
            strReturn = strReturn & b.ToString("x2")
        Next
        Return strReturn
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn.Open()
        Dim user = txtBoxUser.Text
        Dim pass = MD5(txtBoxPass.Text)
        Dim db_user As String
        Dim db_pass As String
        Dim auth As String
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "select username,password,privilege from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetString("username") Then
                If pass = reader.GetString("password") Then
                    db_user = reader.GetString("username")
                    db_pass = reader.GetString("password")
                    auth = reader.GetString("privilege")
                End If
            End If
        End While
        conn.Close()

        If user = db_user And pass = db_pass And auth = "Customer" Then
            Dim home As New home()
            home.txt_user = db_user
            home.Show()
            Me.Close()
        ElseIf user = db_user And pass = db_pass And auth = "Admin" Then
            MessageBox.Show("HI ADMIN")

        Else
            MessageBox.Show("Username/Password incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtBoxPass.PasswordChar = "*" Then
            txtBoxPass.PasswordChar = ""
            Button3.BackColor = Color.DimGray
        Else
            txtBoxPass.PasswordChar = "*"
            Button3.BackColor = Color.White
        End If
    End Sub
End Class