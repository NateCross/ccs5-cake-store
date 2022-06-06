<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplier_Phone
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
        Me.BtnSupplier_PhoneInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewSupplier_Phone = New System.Windows.Forms.DataGridView()
        Me.BtnSupplier_PhoneDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSupplierPhoneNo = New System.Windows.Forms.TextBox()
        Me.BtnSupplier_PhoneUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSupplier_PhoneInsert
        '
        Me.BtnSupplier_PhoneInsert.Location = New System.Drawing.Point(624, 244)
        Me.BtnSupplier_PhoneInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSupplier_PhoneInsert.Name = "BtnSupplier_PhoneInsert"
        Me.BtnSupplier_PhoneInsert.Size = New System.Drawing.Size(133, 55)
        Me.BtnSupplier_PhoneInsert.TabIndex = 24
        Me.BtnSupplier_PhoneInsert.Text = "Insert New Supplier Phone"
        Me.BtnSupplier_PhoneInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 501)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Phone Numbers"
        '
        'DataGridViewSupplier_Phone
        '
        Me.DataGridViewSupplier_Phone.AllowUserToAddRows = False
        Me.DataGridViewSupplier_Phone.AllowUserToDeleteRows = False
        Me.DataGridViewSupplier_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier_Phone.Location = New System.Drawing.Point(3, 20)
        Me.DataGridViewSupplier_Phone.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewSupplier_Phone.Name = "DataGridViewSupplier_Phone"
        Me.DataGridViewSupplier_Phone.Size = New System.Drawing.Size(568, 474)
        Me.DataGridViewSupplier_Phone.TabIndex = 0
        '
        'BtnSupplier_PhoneDelete
        '
        Me.BtnSupplier_PhoneDelete.Location = New System.Drawing.Point(624, 330)
        Me.BtnSupplier_PhoneDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSupplier_PhoneDelete.Name = "BtnSupplier_PhoneDelete"
        Me.BtnSupplier_PhoneDelete.Size = New System.Drawing.Size(133, 49)
        Me.BtnSupplier_PhoneDelete.TabIndex = 25
        Me.BtnSupplier_PhoneDelete.Text = "Delete Selected Supplier Phone"
        Me.BtnSupplier_PhoneDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Supplier Phone No."
        '
        'TxtSupplierPhoneNo
        '
        Me.TxtSupplierPhoneNo.Location = New System.Drawing.Point(624, 184)
        Me.TxtSupplierPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierPhoneNo.Name = "TxtSupplierPhoneNo"
        Me.TxtSupplierPhoneNo.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierPhoneNo.TabIndex = 21
        '
        'BtnSupplier_PhoneUpdate
        '
        Me.BtnSupplier_PhoneUpdate.Location = New System.Drawing.Point(624, 401)
        Me.BtnSupplier_PhoneUpdate.Name = "BtnSupplier_PhoneUpdate"
        Me.BtnSupplier_PhoneUpdate.Size = New System.Drawing.Size(132, 42)
        Me.BtnSupplier_PhoneUpdate.TabIndex = 26
        Me.BtnSupplier_PhoneUpdate.Text = "Update Selected Supplier Phone"
        Me.BtnSupplier_PhoneUpdate.UseVisualStyleBackColor = True
        '
        'UserControlSupplier_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSupplier_PhoneUpdate)
        Me.Controls.Add(Me.BtnSupplier_PhoneInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSupplier_PhoneDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSupplierPhoneNo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserControlSupplier_Phone"
        Me.Size = New System.Drawing.Size(805, 513)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSupplier_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSupplier_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplier_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSupplier_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplier_PhoneUpdate As System.Windows.Forms.Button

End Class
