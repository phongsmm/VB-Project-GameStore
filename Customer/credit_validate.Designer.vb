<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class credit_validate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSCode = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBilling = New System.Windows.Forms.TextBox()
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(34, 53)
        Me.txtCardNumber.MaxLength = 16
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(188, 23)
        Me.txtCardNumber.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMMyyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(266, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(83, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Card Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(264, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "expiration date and security code"
        '
        'txtSCode
        '
        Me.txtSCode.Location = New System.Drawing.Point(355, 53)
        Me.txtSCode.MaxLength = 3
        Me.txtSCode.Name = "txtSCode"
        Me.txtSCode.Size = New System.Drawing.Size(58, 23)
        Me.txtSCode.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(34, 135)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(91, 23)
        Me.txtFirstName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(34, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(131, 135)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(91, 23)
        Me.txtLastName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(140, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(34, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Biling address"
        '
        'txtBilling
        '
        Me.txtBilling.Location = New System.Drawing.Point(34, 177)
        Me.txtBilling.Name = "txtBilling"
        Me.txtBilling.Size = New System.Drawing.Size(188, 23)
        Me.txtBilling.TabIndex = 10
        '
        'txtCityName
        '
        Me.txtCityName.Location = New System.Drawing.Point(266, 135)
        Me.txtCityName.MaxLength = 255
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.Size = New System.Drawing.Size(145, 23)
        Me.txtCityName.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(266, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(266, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Zip or postal code"
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(266, 177)
        Me.txtPostCode.MaxLength = 10
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(145, 23)
        Me.txtPostCode.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(34, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Country"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(266, 219)
        Me.txtPhoneNumber.MaxLength = 10
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(145, 23)
        Me.txtPhoneNumber.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(266, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Phone number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCountry)
        Me.GroupBox1.Controls.Add(Me.txtBilling)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCardNumber)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPostCode)
        Me.GroupBox1.Controls.Add(Me.txtSCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCityName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 258)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Information"
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"Thailand"})
        Me.cboCountry.Location = New System.Drawing.Point(34, 219)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(188, 23)
        Me.cboCountry.TabIndex = 19
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(99, 288)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(112, 32)
        Me.btnConfirm.TabIndex = 20
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(266, 288)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(112, 32)
        Me.btnCancle.TabIndex = 21
        Me.btnCancle.Text = "CANCLE"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(395, 6)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(59, 15)
        Me.lblUser.TabIndex = 22
        Me.lblUser.Text = "username"
        '
        'credit_validate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 341)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "credit_validate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "validate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSCode As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBilling As TextBox
    Friend WithEvents txtCityName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancle As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents cboCountry As ComboBox
End Class
