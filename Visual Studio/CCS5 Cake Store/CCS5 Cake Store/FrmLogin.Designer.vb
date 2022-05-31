<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnExitLogin = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LabelUserId = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(356, 183)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(113, 45)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnExitLogin
        '
        Me.BtnExitLogin.Location = New System.Drawing.Point(504, 183)
        Me.BtnExitLogin.Name = "BtnExitLogin"
        Me.BtnExitLogin.Size = New System.Drawing.Size(118, 45)
        Me.BtnExitLogin.TabIndex = 1
        Me.BtnExitLogin.Text = "EXIT"
        Me.BtnExitLogin.UseVisualStyleBackColor = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(152, 57)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(511, 22)
        Me.TxtUsername.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(152, 126)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(511, 22)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'LabelUserId
        '
        Me.LabelUserId.AutoSize = True
        Me.LabelUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserId.Location = New System.Drawing.Point(18, 57)
        Me.LabelUserId.Name = "LabelUserId"
        Me.LabelUserId.Size = New System.Drawing.Size(91, 20)
        Me.LabelUserId.TabIndex = 4
        Me.LabelUserId.Text = "Username:"
        Me.LabelUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(21, 126)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(88, 20)
        Me.LabelPassword.TabIndex = 5
        Me.LabelPassword.Text = "Password:"
        Me.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 250)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUserId)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.BtnExitLogin)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnExitLogin As System.Windows.Forms.Button
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelUserId As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label

End Class
