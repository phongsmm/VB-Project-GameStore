<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtBoxUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxPass = New MetroFramework.Controls.MetroTextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.btnRegister = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 95)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 159)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Password"
        '
        'txtBoxUser
        '
        '
        '
        '
        Me.txtBoxUser.CustomButton.Image = Nothing
        Me.txtBoxUser.CustomButton.Location = New System.Drawing.Point(257, 1)
        Me.txtBoxUser.CustomButton.Name = ""
        Me.txtBoxUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxUser.CustomButton.TabIndex = 1
        Me.txtBoxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxUser.CustomButton.UseSelectable = True
        Me.txtBoxUser.CustomButton.Visible = False
        Me.txtBoxUser.Lines = New String(-1) {}
        Me.txtBoxUser.Location = New System.Drawing.Point(23, 117)
        Me.txtBoxUser.MaxLength = 32767
        Me.txtBoxUser.Name = "txtBoxUser"
        Me.txtBoxUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxUser.SelectedText = ""
        Me.txtBoxUser.SelectionLength = 0
        Me.txtBoxUser.SelectionStart = 0
        Me.txtBoxUser.ShortcutsEnabled = True
        Me.txtBoxUser.Size = New System.Drawing.Size(279, 23)
        Me.txtBoxUser.TabIndex = 2
        Me.txtBoxUser.UseSelectable = True
        Me.txtBoxUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxPass
        '
        '
        '
        '
        Me.txtBoxPass.CustomButton.Image = Nothing
        Me.txtBoxPass.CustomButton.Location = New System.Drawing.Point(257, 1)
        Me.txtBoxPass.CustomButton.Name = ""
        Me.txtBoxPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxPass.CustomButton.TabIndex = 1
        Me.txtBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxPass.CustomButton.UseSelectable = True
        Me.txtBoxPass.CustomButton.Visible = False
        Me.txtBoxPass.Lines = New String(-1) {}
        Me.txtBoxPass.Location = New System.Drawing.Point(23, 181)
        Me.txtBoxPass.MaxLength = 32767
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxPass.SelectedText = ""
        Me.txtBoxPass.SelectionLength = 0
        Me.txtBoxPass.SelectionStart = 0
        Me.txtBoxPass.ShortcutsEnabled = True
        Me.txtBoxPass.Size = New System.Drawing.Size(279, 23)
        Me.txtBoxPass.TabIndex = 3
        Me.txtBoxPass.UseSelectable = True
        Me.txtBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(116, 247)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(102, 37)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(116, 302)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(102, 37)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 450)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtBoxPass)
        Me.Controls.Add(Me.txtBoxUser)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Text = "Game Store - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBoxUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRegister As MetroFramework.Controls.MetroButton
End Class
