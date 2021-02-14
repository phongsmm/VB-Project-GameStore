<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.txtBoxUser = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(190, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 30)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "LOGIN PAGE"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(245, 218)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(133, 113)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(59, 15)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "username"
        '
        'txtBoxPass
        '
        Me.txtBoxPass.Location = New System.Drawing.Point(203, 157)
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.Size = New System.Drawing.Size(108, 23)
        Me.txtBoxPass.TabIndex = 8
        '
        'txtBoxUser
        '
        Me.txtBoxUser.Location = New System.Drawing.Point(203, 113)
        Me.txtBoxUser.Name = "txtBoxUser"
        Me.txtBoxUser.Size = New System.Drawing.Size(108, 23)
        Me.txtBoxUser.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(152, 218)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 312)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtBoxPass)
        Me.Controls.Add(Me.txtBoxUser)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents txtBoxUser As TextBox
    Friend WithEvents btnLogin As Button
End Class
