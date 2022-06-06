<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlEmployee_Phone
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtnEmp_PhoneInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewEmployee_Phone = New System.Windows.Forms.DataGridView()
        Me.BtnEmp_PhoneDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmpPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEmp_PhoneUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewEmployee_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEmp_PhoneInsert
        '
        Me.BtnEmp_PhoneInsert.Location = New System.Drawing.Point(619, 302)
        Me.BtnEmp_PhoneInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEmp_PhoneInsert.Name = "BtnEmp_PhoneInsert"
        Me.BtnEmp_PhoneInsert.Size = New System.Drawing.Size(133, 55)
        Me.BtnEmp_PhoneInsert.TabIndex = 15
        Me.BtnEmp_PhoneInsert.Text = "Insert New Employee Phone"
        Me.BtnEmp_PhoneInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewEmployee_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 501)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Phone Numbers"
        '
        'DataGridViewEmployee_Phone
        '
        Me.DataGridViewEmployee_Phone.AllowUserToAddRows = False
        Me.DataGridViewEmployee_Phone.AllowUserToDeleteRows = False
        Me.DataGridViewEmployee_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmployee_Phone.Location = New System.Drawing.Point(3, 20)
        Me.DataGridViewEmployee_Phone.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewEmployee_Phone.Name = "DataGridViewEmployee_Phone"
        Me.DataGridViewEmployee_Phone.Size = New System.Drawing.Size(568, 474)
        Me.DataGridViewEmployee_Phone.TabIndex = 0
        '
        'BtnEmp_PhoneDelete
        '
        Me.BtnEmp_PhoneDelete.Location = New System.Drawing.Point(618, 365)
        Me.BtnEmp_PhoneDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEmp_PhoneDelete.Name = "BtnEmp_PhoneDelete"
        Me.BtnEmp_PhoneDelete.Size = New System.Drawing.Size(133, 49)
        Me.BtnEmp_PhoneDelete.TabIndex = 16
        Me.BtnEmp_PhoneDelete.Text = "Delete Selected Employee Phone"
        Me.BtnEmp_PhoneDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(615, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Employee Phone No."
        '
        'TxtEmpPhoneNo
        '
        Me.TxtEmpPhoneNo.Location = New System.Drawing.Point(649, 243)
        Me.TxtEmpPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmpPhoneNo.Name = "TxtEmpPhoneNo"
        Me.TxtEmpPhoneNo.Size = New System.Drawing.Size(132, 22)
        Me.TxtEmpPhoneNo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(616, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "+63"
        '
        'BtnEmp_PhoneUpdate
        '
        Me.BtnEmp_PhoneUpdate.Location = New System.Drawing.Point(619, 421)
        Me.BtnEmp_PhoneUpdate.Name = "BtnEmp_PhoneUpdate"
        Me.BtnEmp_PhoneUpdate.Size = New System.Drawing.Size(132, 47)
        Me.BtnEmp_PhoneUpdate.TabIndex = 18
        Me.BtnEmp_PhoneUpdate.Text = "Update Selected Employee Phone"
        Me.BtnEmp_PhoneUpdate.UseVisualStyleBackColor = True
        '
        'UserControlEmployee_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnEmp_PhoneUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEmp_PhoneInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEmp_PhoneDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEmpPhoneNo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserControlEmployee_Phone"
        Me.Size = New System.Drawing.Size(811, 518)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewEmployee_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEmp_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewEmployee_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEmp_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnEmp_PhoneUpdate As System.Windows.Forms.Button

End Class
