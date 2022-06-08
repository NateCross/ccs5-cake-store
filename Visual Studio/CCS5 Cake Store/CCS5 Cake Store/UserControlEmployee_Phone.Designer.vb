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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewEmployee_Phone = New System.Windows.Forms.DataGridView()
        Me.BtnEmp_PhoneUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEmp_PhoneInsert = New System.Windows.Forms.Button()
        Me.BtnEmp_PhoneDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmpPhoneNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewEmployee_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEmp_PhoneUpdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnEmp_PhoneInsert)
        Me.GroupBox1.Controls.Add(Me.BtnEmp_PhoneDelete)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtEmpPhoneNo)
        Me.GroupBox1.Controls.Add(Me.DataGridViewEmployee_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 476)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Phone Numbers"
        '
        'DataGridViewEmployee_Phone
        '
        Me.DataGridViewEmployee_Phone.AllowUserToAddRows = False
        Me.DataGridViewEmployee_Phone.AllowUserToDeleteRows = False
        Me.DataGridViewEmployee_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmployee_Phone.Location = New System.Drawing.Point(2, 16)
        Me.DataGridViewEmployee_Phone.Name = "DataGridViewEmployee_Phone"
        Me.DataGridViewEmployee_Phone.Size = New System.Drawing.Size(430, 454)
        Me.DataGridViewEmployee_Phone.TabIndex = 0
        '
        'BtnEmp_PhoneUpdate
        '
        Me.BtnEmp_PhoneUpdate.Location = New System.Drawing.Point(468, 255)
        Me.BtnEmp_PhoneUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEmp_PhoneUpdate.Name = "BtnEmp_PhoneUpdate"
        Me.BtnEmp_PhoneUpdate.Size = New System.Drawing.Size(100, 50)
        Me.BtnEmp_PhoneUpdate.TabIndex = 24
        Me.BtnEmp_PhoneUpdate.Text = "Update Selected Employee Phone"
        Me.BtnEmp_PhoneUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "+63"
        '
        'BtnEmp_PhoneInsert
        '
        Me.BtnEmp_PhoneInsert.Location = New System.Drawing.Point(468, 144)
        Me.BtnEmp_PhoneInsert.Name = "BtnEmp_PhoneInsert"
        Me.BtnEmp_PhoneInsert.Size = New System.Drawing.Size(100, 50)
        Me.BtnEmp_PhoneInsert.TabIndex = 21
        Me.BtnEmp_PhoneInsert.Text = "Insert New Employee Phone"
        Me.BtnEmp_PhoneInsert.UseVisualStyleBackColor = True
        '
        'BtnEmp_PhoneDelete
        '
        Me.BtnEmp_PhoneDelete.Location = New System.Drawing.Point(468, 200)
        Me.BtnEmp_PhoneDelete.Name = "BtnEmp_PhoneDelete"
        Me.BtnEmp_PhoneDelete.Size = New System.Drawing.Size(100, 50)
        Me.BtnEmp_PhoneDelete.TabIndex = 22
        Me.BtnEmp_PhoneDelete.Text = "Delete Selected Employee Phone"
        Me.BtnEmp_PhoneDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Employee Phone No."
        '
        'TxtEmpPhoneNo
        '
        Me.TxtEmpPhoneNo.Location = New System.Drawing.Point(465, 75)
        Me.TxtEmpPhoneNo.Name = "TxtEmpPhoneNo"
        Me.TxtEmpPhoneNo.Size = New System.Drawing.Size(110, 20)
        Me.TxtEmpPhoneNo.TabIndex = 19
        '
        'UserControlEmployee_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlEmployee_Phone"
        Me.Size = New System.Drawing.Size(600, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewEmployee_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewEmployee_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEmp_PhoneUpdate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnEmp_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents BtnEmp_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpPhoneNo As System.Windows.Forms.TextBox

End Class
