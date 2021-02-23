<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Me.tb_name = New MetroFramework.Controls.MetroTextBox()
        Me.tb_pass = New MetroFramework.Controls.MetroTextBox()
        Me.tb_p = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'tb_name
        '
        '
        '
        '
        Me.tb_name.CustomButton.Image = Nothing
        Me.tb_name.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.tb_name.CustomButton.Name = ""
        Me.tb_name.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_name.CustomButton.TabIndex = 1
        Me.tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_name.CustomButton.UseSelectable = True
        Me.tb_name.CustomButton.Visible = False
        Me.tb_name.Lines = New String(-1) {}
        Me.tb_name.Location = New System.Drawing.Point(48, 88)
        Me.tb_name.MaxLength = 32767
        Me.tb_name.Name = "tb_name"
        Me.tb_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_name.SelectedText = ""
        Me.tb_name.SelectionLength = 0
        Me.tb_name.SelectionStart = 0
        Me.tb_name.ShortcutsEnabled = True
        Me.tb_name.Size = New System.Drawing.Size(203, 23)
        Me.tb_name.TabIndex = 0
        Me.tb_name.UseSelectable = True
        Me.tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tb_pass
        '
        '
        '
        '
        Me.tb_pass.CustomButton.Image = Nothing
        Me.tb_pass.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.tb_pass.CustomButton.Name = ""
        Me.tb_pass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tb_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_pass.CustomButton.TabIndex = 1
        Me.tb_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_pass.CustomButton.UseSelectable = True
        Me.tb_pass.CustomButton.Visible = False
        Me.tb_pass.Lines = New String(-1) {}
        Me.tb_pass.Location = New System.Drawing.Point(48, 140)
        Me.tb_pass.MaxLength = 32767
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_pass.SelectedText = ""
        Me.tb_pass.SelectionLength = 0
        Me.tb_pass.SelectionStart = 0
        Me.tb_pass.ShortcutsEnabled = True
        Me.tb_pass.Size = New System.Drawing.Size(203, 23)
        Me.tb_pass.TabIndex = 1
        Me.tb_pass.UseSelectable = True
        Me.tb_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tb_p
        '
        '
        '
        '
        Me.tb_p.CustomButton.Image = Nothing
        Me.tb_p.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.tb_p.CustomButton.Name = ""
        Me.tb_p.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tb_p.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_p.CustomButton.TabIndex = 1
        Me.tb_p.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_p.CustomButton.UseSelectable = True
        Me.tb_p.CustomButton.Visible = False
        Me.tb_p.Lines = New String(-1) {}
        Me.tb_p.Location = New System.Drawing.Point(48, 202)
        Me.tb_p.MaxLength = 32767
        Me.tb_p.Name = "tb_p"
        Me.tb_p.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_p.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_p.SelectedText = ""
        Me.tb_p.SelectionLength = 0
        Me.tb_p.SelectionStart = 0
        Me.tb_p.ShortcutsEnabled = True
        Me.tb_p.Size = New System.Drawing.Size(203, 23)
        Me.tb_p.TabIndex = 2
        Me.tb_p.UseSelectable = True
        Me.tb_p.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_p.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(48, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(176, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(48, 66)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(48, 118)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Password"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(48, 180)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Privilege"
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 434)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_p)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_name)
        Me.Name = "EditCustomer"
        Me.Resizable = False
        Me.Text = "EDIT - USER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tb_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tb_p As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
