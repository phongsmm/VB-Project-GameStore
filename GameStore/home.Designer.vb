<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.btnStore = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(90, 123)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(132, 40)
        Me.btnStore.TabIndex = 0
        Me.btnStore.Text = "Store"
        Me.btnStore.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(90, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Order"
        Me.Button2.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton4.BackgroundImage = Global.GameStore.My.Resources.Resources.files
        Me.MetroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton4.Location = New System.Drawing.Point(96, 195)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(37, 27)
        Me.MetroButton4.TabIndex = 3
        Me.MetroButton4.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton3.BackgroundImage = Global.GameStore.My.Resources.Resources.carts
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton3.Enabled = False
        Me.MetroButton3.Location = New System.Drawing.Point(98, 130)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(37, 27)
        Me.MetroButton3.TabIndex = 2
        Me.MetroButton3.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Logout"
        Me.Button1.UseSelectable = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnStore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.Resizable = False
        Me.Text = "Home Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStore As MetroFramework.Controls.MetroButton
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
End Class
