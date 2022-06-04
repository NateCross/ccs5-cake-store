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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSupplierPhoneId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSupplierId = New System.Windows.Forms.TextBox()
        Me.TxtSupplierPhoneNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSupplier_PhoneInsert
        '
        Me.BtnSupplier_PhoneInsert.Location = New System.Drawing.Point(468, 257)
        Me.BtnSupplier_PhoneInsert.Name = "BtnSupplier_PhoneInsert"
        Me.BtnSupplier_PhoneInsert.Size = New System.Drawing.Size(100, 45)
        Me.BtnSupplier_PhoneInsert.TabIndex = 24
        Me.BtnSupplier_PhoneInsert.Text = "Insert New Supplier Phone"
        Me.BtnSupplier_PhoneInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 407)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier_Phone"
        '
        'DataGridViewSupplier_Phone
        '
        Me.DataGridViewSupplier_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier_Phone.Location = New System.Drawing.Point(2, 16)
        Me.DataGridViewSupplier_Phone.Name = "DataGridViewSupplier_Phone"
        Me.DataGridViewSupplier_Phone.Size = New System.Drawing.Size(426, 385)
        Me.DataGridViewSupplier_Phone.TabIndex = 0
        '
        'BtnSupplier_PhoneDelete
        '
        Me.BtnSupplier_PhoneDelete.Location = New System.Drawing.Point(468, 327)
        Me.BtnSupplier_PhoneDelete.Name = "BtnSupplier_PhoneDelete"
        Me.BtnSupplier_PhoneDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplier_PhoneDelete.TabIndex = 25
        Me.BtnSupplier_PhoneDelete.Text = "Delete Selected Supplier Phone"
        Me.BtnSupplier_PhoneDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Supplier Phone No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Supplier ID"
        '
        'TxtSupplierPhoneId
        '
        Me.TxtSupplierPhoneId.Location = New System.Drawing.Point(468, 63)
        Me.TxtSupplierPhoneId.Name = "TxtSupplierPhoneId"
        Me.TxtSupplierPhoneId.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierPhoneId.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(465, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Supplier Phone ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtSupplierId
        '
        Me.TxtSupplierId.Location = New System.Drawing.Point(468, 133)
        Me.TxtSupplierId.Name = "TxtSupplierId"
        Me.TxtSupplierId.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierId.TabIndex = 20
        '
        'TxtSupplierPhoneNo
        '
        Me.TxtSupplierPhoneNo.Location = New System.Drawing.Point(468, 208)
        Me.TxtSupplierPhoneNo.Name = "TxtSupplierPhoneNo"
        Me.TxtSupplierPhoneNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierPhoneNo.TabIndex = 21
        '
        'UserControlSupplier_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSupplier_PhoneInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSupplier_PhoneDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSupplierPhoneId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSupplierId)
        Me.Controls.Add(Me.TxtSupplierPhoneNo)
        Me.Name = "UserControlSupplier_Phone"
        Me.Size = New System.Drawing.Size(604, 417)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierPhoneId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierId As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierPhoneNo As System.Windows.Forms.TextBox

End Class
