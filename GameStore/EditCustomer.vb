Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text
Public Class EditCustomer

    Public username As String
    Public password As String
    Public privilege As String

    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)

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

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_name.Text = username
        tb_pass.Text = password
        tb_p.Text = privilege

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_name.Text <> "" And tb_pass.Text <> "" And tb_p.Text <> "" Then
            conn.Open()
            Dim cmd As New SQLiteCommand
            cmd.Connection = conn
            cmd.CommandText = String.Format("
UPDATE credentials
SET username = @username, password = @password , privilege = @privilege
WHERE username = '{0}'
", username)
            cmd.Parameters.AddWithValue("@username", tb_name.Text)
            cmd.Parameters.AddWithValue("@password", MD5(tb_pass.Text))
            cmd.Parameters.AddWithValue("@privilege", tb_p.Text)

            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update Successful", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please Fill All Of The Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim confirm = MessageBox.Show(String.Format("Please Confirm to Delete [ {0} ] ", username), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm = DialogResult.Yes Then
            conn.Open()
            Dim cmd As New SQLiteCommand
            cmd.Connection = conn
            cmd.CommandText = String.Format("
DELETE FROM credentials
WHERE username = '{0}'
", username)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Delete Successful", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If


    End Sub
End Class