Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Dim dbpath = Application.StartupPath
    Dim dbname = "data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))


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



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim conn As New SQLiteConnection(constr)
        conn.Open()

        Try
            Dim sql As String = "select * from Users Where Username = @name And Password = @password"
            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.Parameters.AddWithValue("name", TextBox1.Text)
            cmd.Parameters.AddWithValue("password", MD5(TextBox2.Text))
            Dim reader As SQLiteDataReader = cmd.ExecuteReader

            If Not reader.HasRows Then
                MessageBox.Show("Invalid Username or Password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


            While reader.Read
                If reader(3) = 0 Then
                    ''Guest

                ElseIf reader(3) = 1 Then
                    ''Admin


                End If


            End While


        Catch ex As Exception
            MessageBox.Show("Connection Lost!")

        End Try





        conn.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conn As New SQLiteConnection(constr)
        conn.Open()

        Try
            Dim sql As String = "select * from Users Where Username = @name"
            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.Parameters.AddWithValue("name", TextBox1.Text)

            Dim reader As SQLiteDataReader = cmd.ExecuteReader

            If reader.HasRows Then
                MessageBox.Show("This Username has already used!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If TextBox1.Text.Length > 2 Then
                    If TextBox2.Text.Length > 5 Then
                        Dim x = 0
                        For Each A In TextBox2.Text
                            If IsNumeric(A) Then
                                x += 1
                            End If
                        Next
                        If x > 0 Then
                            MessageBox.Show("Registered")
                            sql = "insert into Users (Username,Password,Auth) values (@username,@password,0)"
                            Dim cmd2 As New SQLiteCommand(sql, conn)
                            cmd2.Parameters.AddWithValue("username", TextBox1.Text)
                            cmd2.Parameters.AddWithValue("password", MD5(TextBox2.Text))
                            cmd2.ExecuteNonQuery()


                        Else
                            MessageBox.Show("Password must contain number at least 1 character ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        End If

                    Else

                        MessageBox.Show("Password require at least 6 character", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If
                Else
                    MessageBox.Show("Username require at least 3 character", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If



        Catch ex As Exception
            MessageBox.Show("Connection Lost!")

        End Try





        conn.Close()

    End Sub
End Class
