﻿Imports System.Data.SQLite
Imports System.Text
Imports System.Net.Mail
Public Class check_class
    Dim dbpath = Application.StartupPath
    Dim dbname = "Data.db"
    Dim constr As String = String.Format("Data Source = {0}", System.IO.Path.Combine(dbpath, dbname))
    Dim conn As New SQLiteConnection(constr)
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

    Function checK_credit(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim bool As Boolean
        cmd.Connection = conn
        cmd.CommandText = "select username,card_number from credentials where username='" & user & "'"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If IsDBNull(reader.GetValue(1)) Then
                bool = False
            Else
                bool = True
            End If
        End While
        conn.Close()
        Return bool
    End Function

    Function checK_address(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim bool As Boolean
        cmd.Connection = conn
        cmd.CommandText = "select username,billing_address from credentials where username='" & user & "'"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If IsDBNull(reader.GetValue(1)) Then
                bool = False
            Else
                bool = True
            End If
        End While
        conn.Close()
        Return bool
    End Function

    Function checK_email(email)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim bool As Boolean
        Dim db_email As String
        cmd.Connection = conn
        cmd.CommandText = "select username,email from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If email = reader.GetValue(1) Then
                db_email = reader.GetValue(1)
            End If
        End While
        conn.Close()
        If email = db_email Then
            bool = True
        Else
            bool = False
        End If
        Return bool
    End Function

    Function random_invoice()
        Dim r As New Random
        Dim digits(10) As Char

        For i As Integer = 0 To 9
            Dim digit As Integer = r.Next(10) 'random digit 0 to 9
            digits(i) = ChrW(digit + 48)
        Next

        Dim number As String = New String(digits)
        Return number
    End Function

    Function get_cdKey()
        Dim str As String
        Dim text_gen As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim mask = "$@$@-$$@$-@$@$-$$@$"

        Dim Output As New StringBuilder
        Dim random As New Random()
        For i As Integer = 0 To mask.Length - 1
            If (mask(i) = "@") Then
                Output.Append(random.Next(0, 9))
            ElseIf (mask(i) = "$") Then
                Output.Append(text_gen(random.Next(0, text_gen.Length())))
            Else
                Output.Append(mask(i))
            End If
        Next
        Return Output.ToString
    End Function

    Function get_userId(user)
        Dim bool As Boolean
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_userId As String
        cmd.Connection = conn
        cmd.CommandText = "select id,username from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetValue(1) Then
                db_userId = reader.GetValue(0)
            End If
        End While
        conn.Close()
        Return db_userId
    End Function

    Function get_email(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_email As String
        cmd.Connection = conn
        cmd.CommandText = "select email,username from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetValue(1) Then
                db_email = reader.GetValue(0)
            End If
        End While
        conn.Close()
        Return db_email
    End Function

    Function get_price(id)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_price As Double
        cmd.Connection = conn
        cmd.CommandText = "select credentials.id,orders.user_id,orders.price from credentials inner join orders on credentials.id=orders.user_id"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If id = reader.GetValue(1) Then
                db_price = reader.GetValue(2)
            End If
        End While
        conn.Close()
        Return db_price
    End Function

    Function getUserID(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_id As String
        cmd.Connection = conn
        cmd.CommandText = "select id,username from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetValue(1) Then
                db_id = reader.GetValue(0)
            End If
        End While
        conn.Close()
        Return db_id
    End Function

    Function getName(id)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_firstname As String
        Dim db_lastname As String
        cmd.Connection = conn
        cmd.CommandText = "select id,firstname,lastname from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If id = reader.GetValue(0) Then
                db_firstname = reader.GetValue(1)
                db_lastname = reader.GetValue(2)
            End If
        End While
        conn.Close()
        Return db_firstname + " " + db_lastname
    End Function



    Function get_address(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_address As String
        Dim db_city As String
        Dim db_country As String
        Dim db_zipcode As String
        Dim text As String
        cmd.Connection = conn
        cmd.CommandText = "select * from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetValue(1) Then
                db_address = reader.GetValue(10)
                db_city = reader.GetValue(12)
                db_zipcode = reader.GetValue(13)
                db_country = reader.GetValue(11)
                text += db_address + " " + db_city + " " + db_zipcode + " " + db_country
            End If
        End While
        conn.Close()
        Return text
    End Function

    Function get_total_price(id)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_price As Double
        Dim total As Double
        cmd.Connection = conn
        cmd.CommandText = "select credentials.id,orders.user_id,orders.price from credentials inner join orders on credentials.id=orders.user_id"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If id = reader.GetValue(1) Then
                db_price = reader.GetValue(2)
                total += db_price
            End If
        End While
        conn.Close()
        Return total
    End Function

    Function check_creditcard(user)
        conn.Open()
        Dim cmd As New SQLiteCommand
        Dim db_card As String
        cmd.Connection = conn
        cmd.CommandText = "select card_number,username from credentials"
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If user = reader.GetValue(1) Then
                db_card = reader.GetValue(0)
            End If
        End While
        conn.Close()
        Return db_card
    End Function

    Function insert_order(invoice_id, game, cd_key, price, date_time, email, user_id)
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO orders(invoice_id,game,cd_key,price,date,email,user_id)" &
                    "VALUES (@invoice_id,@game,@cd_key,@price,@date,@email,@user_id)"
        cmd.Parameters.AddWithValue("@invoice_id", invoice_id)
        cmd.Parameters.AddWithValue("@game", game)
        cmd.Parameters.AddWithValue("@cd_key", cd_key)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@date", date_time)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@user_id", user_id)
        Dim recadded As Integer = cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Success Orders!", MsgBoxStyle.Information)
    End Function

    Function mail(invoice, order_date, fullname, address, email, key)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("ibobbyvb@gmail.com", "T12345678")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            Dim body As String = "YOUR ORDER IS COMPLETE" & vbNewLine &
                                  "********************************************" & vbNewLine &
                                 "ORDER NUMBER  : " & invoice & vbNewLine &
                                 "THIS IS YOUR KEY GAME : " & key & vbNewLine &
                                 "ORDER DATE : " & order_date & vbNewLine &
                                 "CUSTOMER NAME : " & fullname & vbNewLine &
                                 "BILLING ADDRESS " & vbNewLine & address & vbNewLine &
                                 "********************************************"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("ibobbyvb@gmail.com")
            e_mail.To.Add(email)
            e_mail.Subject = "Order confirmation " & invoice
            e_mail.IsBodyHtml = False
            e_mail.Body = body
            Smtp_Server.Send(e_mail)
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Function

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
End Class
