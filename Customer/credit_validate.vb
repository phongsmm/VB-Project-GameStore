Imports System.Data.SQLite
Public Class credit_validate
    Public Property txt_user As String
    Dim constr As New SQLiteConnection("Data Source=C:\Users\2015\source\repos\Customer\Customer\Data.db;")
    Dim conn As New SQLiteConnection(constr)
    Dim check_class As New check_class
    Private Sub validate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = txt_user
        cboCountry.SelectedIndex = 0
        DateTimePicker1.MinDate = DateTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim card_number = txtCardNumber.Text
        Dim expire_date = DateTimePicker1.Value.ToString("MM'/'yy")
        Dim today = DateTime.Now.ToString("MM'/'yy")
        Dim scode = txtSCode.Text
        Dim firstname = txtFirstName.Text
        Dim lastname = txtLastName.Text
        Dim bill = txtBilling.Text
        Dim country = cboCountry.SelectedItem
        Dim city = txtCityName.Text
        Dim zipcode = txtPostCode.Text
        Dim phone = txtPhoneNumber.Text
        'Dim check_card = check_class.check_creditcard(lblUser.Text)
        If firstname <> "" Or lastname <> "" Or bill <> "" Or city <> "" Then
            If card_number.Length = 16 And IsNumeric(card_number) Then
                If scode.Length = 3 And IsNumeric(scode) Then
                    If IsNumeric(zipcode) Then
                        If phone.Length = 10 And IsNumeric(phone) Then
                            If today <> expire_date Then
                                conn.Open()
                                Dim cmd As New SQLiteCommand
                                cmd.Connection = conn
                                cmd.CommandText = "UPDATE credentials SET card_number=@card_number,expire_date=@expire_date,scode=@scode,firstname=@firstname,lastname=@lastname,billing_address=@billing_address,country=@country,city=@city,zipcode=@zipcode,phone_number=@phone_number where username='" & lblUser.Text & "'"
                                cmd.Parameters.AddWithValue("@card_number", card_number)
                                cmd.Parameters.AddWithValue("@expire_date", expire_date)
                                cmd.Parameters.AddWithValue("@scode", scode)
                                cmd.Parameters.AddWithValue("@firstname", firstname)
                                cmd.Parameters.AddWithValue("@lastname", lastname)
                                cmd.Parameters.AddWithValue("@billing_address", bill)
                                cmd.Parameters.AddWithValue("@country", country)
                                cmd.Parameters.AddWithValue("@city", city)
                                cmd.Parameters.AddWithValue("@zipcode", zipcode)
                                cmd.Parameters.AddWithValue("@phone_number", phone)
                                Dim recadded As Integer = cmd.ExecuteNonQuery()
                                conn.Close()
                                MsgBox("Payment Information Added!", MsgBoxStyle.Information)
                                Me.Close()
                            Else
                                MsgBox("invalid expired date")
                            End If
                        Else
                            MsgBox("invalid phone number")
                        End If
                    Else
                        MsgBox("invalid zip Code/postal code")
                    End If
                Else
                    MsgBox("invalid Security Code")
                End If
            Else
                MsgBox("Invalid Credit Card Number")
            End If
        Else
            MsgBox("please inform all information")
        End If
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class