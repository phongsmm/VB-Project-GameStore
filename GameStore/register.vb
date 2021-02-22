
Imports System.Data.SQLite
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class register
    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
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
            If user = reader.GetValue(0) Then
                db_user = reader.GetValue(0)
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

    Function EmailAddressCheck(emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function

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
                            cmd.Parameters.AddWithValue("@password", MD5(password))
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
                    MessageBox.Show("This username has already inuse", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Password Not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please inform all", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim login_page As New Form1()
        login_page.Show()
        Me.Close()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtPass.PasswordChar = "*" Then
            txtPass.PasswordChar = ""
            txtConPass.PasswordChar = ""
            Button3.BackColor = Color.DimGray
        Else
            txtPass.PasswordChar = "*"
            txtConPass.PasswordChar = "*"
            Button3.BackColor = Color.White
        End If
    End Sub
End Class