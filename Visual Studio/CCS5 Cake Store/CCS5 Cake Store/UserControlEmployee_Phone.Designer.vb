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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmpPhoneId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmpId = New System.Windows.Forms.TextBox()
        Me.TxtEmpPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewEmployee_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEmp_PhoneInsert
        '
        Me.BtnEmp_PhoneInsert.Location = New System.Drawing.Point(619, 302)
        Me.BtnEmp_PhoneInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 501)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee_Phone"
        '
        'DataGridViewEmployee_Phone
        '
        Me.DataGridViewEmployee_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmployee_Phone.Location = New System.Drawing.Point(3, 20)
        Me.DataGridViewEmployee_Phone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewEmployee_Phone.Name = "DataGridViewEmployee_Phone"
        Me.DataGridViewEmployee_Phone.Size = New System.Drawing.Size(568, 474)
        Me.DataGridViewEmployee_Phone.TabIndex = 0
        '
        'BtnEmp_PhoneDelete
        '
        Me.BtnEmp_PhoneDelete.Location = New System.Drawing.Point(619, 388)
        Me.BtnEmp_PhoneDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(615, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Employee ID"
        '
        'TxtEmpPhoneId
        '
        Me.TxtEmpPhoneId.Location = New System.Drawing.Point(619, 63)
        Me.TxtEmpPhoneId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEmpPhoneId.Name = "TxtEmpPhoneId"
        Me.TxtEmpPhoneId.Size = New System.Drawing.Size(132, 22)
        Me.TxtEmpPhoneId.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(615, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employee Phone ID"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.Location = New System.Drawing.Point(619, 149)
        Me.TxtEmpId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(132, 22)
        Me.TxtEmpId.TabIndex = 11
        '
        'TxtEmpPhoneNo
        '
        Me.TxtEmpPhoneNo.Location = New System.Drawing.Point(649, 243)
        Me.TxtEmpPhoneNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        'UserControlEmployee_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEmp_PhoneInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEmp_PhoneDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEmpPhoneId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEmpId)
        Me.Controls.Add(Me.TxtEmpPhoneNo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpPhoneId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
