<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditGame))
        Me.tb_name = New MetroFramework.Controls.MetroTextBox()
        Me.tb_price = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tb_cat = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'tb_name
        '
        '
        '
        '
        Me.tb_name.CustomButton.Image = Nothing
        Me.tb_name.CustomButton.Location = New System.Drawing.Point(177, 1)
        Me.tb_name.CustomButton.Name = ""
        Me.tb_name.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_name.CustomButton.TabIndex = 1
        Me.tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_name.CustomButton.UseSelectable = True
        Me.tb_name.CustomButton.Visible = False
        Me.tb_name.Lines = New String(-1) {}
        Me.tb_name.Location = New System.Drawing.Point(58, 107)
        Me.tb_name.MaxLength = 32767
        Me.tb_name.Name = "tb_name"
        Me.tb_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_name.SelectedText = ""
        Me.tb_name.SelectionLength = 0
        Me.tb_name.SelectionStart = 0
        Me.tb_name.ShortcutsEnabled = True
        Me.tb_name.Size = New System.Drawing.Size(199, 23)
        Me.tb_name.TabIndex = 0
        Me.tb_name.UseSelectable = True
        Me.tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tb_price
        '
        '
        '
        '
        Me.tb_price.CustomButton.Image = Nothing
        Me.tb_price.CustomButton.Location = New System.Drawing.Point(177, 1)
        Me.tb_price.CustomButton.Name = ""
        Me.tb_price.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tb_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_price.CustomButton.TabIndex = 1
        Me.tb_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_price.CustomButton.UseSelectable = True
        Me.tb_price.CustomButton.Visible = False
        Me.tb_price.Lines = New String(-1) {}
        Me.tb_price.Location = New System.Drawing.Point(58, 236)
        Me.tb_price.MaxLength = 32767
        Me.tb_price.Name = "tb_price"
        Me.tb_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_price.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_price.SelectedText = ""
        Me.tb_price.SelectionLength = 0
        Me.tb_price.SelectionStart = 0
        Me.tb_price.ShortcutsEnabled = True
        Me.tb_price.Size = New System.Drawing.Size(199, 23)
        Me.tb_price.TabIndex = 2
        Me.tb_price.UseSelectable = True
        Me.tb_price.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_price.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(58, 82)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Name"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(58, 214)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Price"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(58, 147)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Category"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(200, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(120, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(39, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tb_cat
        '
        Me.tb_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cat.FormattingEnabled = True
        Me.tb_cat.Location = New System.Drawing.Point(58, 178)
        Me.tb_cat.Name = "tb_cat"
        Me.tb_cat.Size = New System.Drawing.Size(199, 24)
        Me.tb_cat.TabIndex = 11
        '
        'EditGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 450)
        Me.Controls.Add(Me.tb_cat)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.tb_name)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditGame"
        Me.Resizable = False
        Me.Text = "EDIT - GAME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tb_price As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tb_cat As ComboBox
End Class
