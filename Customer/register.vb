
Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class register
    Dim constr As New SQLiteConnection("Data Source=C:\Users\2015\source\repos\Customer\Customer\Data.db;")
    Dim conn As New SQLiteConnection(constr)
    Dim check_class As New check_class

    Function check_user(user)
        Dim bool As Boolean

        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_user As String
        cmd.Connection = conn
        cmd.CommandText = "select username from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetString("username") Then
                db_user = reader.GetString("username")
            End If
        End While
        conn.Close()
        If user = db_user Then
            bool = True
        Else
            bool = False
        End If
        Return bool
    End Function

    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = txtUser.Text
        Dim email = txtMail.Text
        Dim password
        Dim chk = check_user(username)
        Dim chk_mail = EmailAddressCheck(email)
        Dim privilege = "Customer"
        If username <> "" Or email <> "" Or password <> "" Or txtConPass.Text <> "" Then
            If txtPass.Text = txtConPass.Text Then
                If chk = False Then
                    If chk_mail = True Then
                        If check_class.checK_email(email) = False Then
                            conn.Open()
                            password = txtPass.Text
                            Dim cmd As New SQLiteCommand
                            cmd.Connection = conn
                            cmd.CommandText = "INSERT INTO credentials(username,password,email,privilege)" &
                                        "VALUES (@username,@password,@email,@privilege)"
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.Parameters.AddWithValue("@password", password)
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.Parameters.AddWithValue("@privilege", privilege)
                            Dim recadded As Integer = cmd.ExecuteNonQuery()
                            conn.Close()
                            MsgBox(" Success Registered!", MsgBoxStyle.Information)
                            Dim Form1 As New Form1()
                            Form1.Show()
                            Me.Close()
                        Else
                            MessageBox.Show("
This email has already been used.")
                        End If
                    Else
                        MessageBox.Show("Your email address is invalid")
                    End If
                Else
                    MessageBox.Show("This username has already inuse")
                End If
            Else
                MessageBox.Show("Password incorrect")
            End If
        Else
            MessageBox.Show("Please inform all")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim login_page As New Form1()
        login_page.Show()
        Me.Close()
    End Sub

End Class