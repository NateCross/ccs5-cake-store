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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSupplier_PhoneUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplier_PhoneInsert = New System.Windows.Forms.Button()
        Me.BtnSupplier_PhoneDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSupplierPhoneNo = New System.Windows.Forms.TextBox()
        Me.DataGridViewSupplier_Phone = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnSupplier_PhoneUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnSupplier_PhoneInsert)
        Me.GroupBox1.Controls.Add(Me.BtnSupplier_PhoneDelete)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierPhoneNo)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 476)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Phone Numbers"
        '
        'BtnSupplier_PhoneUpdate
        '
        Me.BtnSupplier_PhoneUpdate.Location = New System.Drawing.Point(485, 246)
        Me.BtnSupplier_PhoneUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplier_PhoneUpdate.Name = "BtnSupplier_PhoneUpdate"
        Me.BtnSupplier_PhoneUpdate.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplier_PhoneUpdate.TabIndex = 31
        Me.BtnSupplier_PhoneUpdate.Text = "Update Selected Supplier Phone"
        Me.BtnSupplier_PhoneUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplier_PhoneInsert
        '
        Me.BtnSupplier_PhoneInsert.Location = New System.Drawing.Point(485, 135)
        Me.BtnSupplier_PhoneInsert.Name = "BtnSupplier_PhoneInsert"
        Me.BtnSupplier_PhoneInsert.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplier_PhoneInsert.TabIndex = 29
        Me.BtnSupplier_PhoneInsert.Text = "Insert New Supplier Phone"
        Me.BtnSupplier_PhoneInsert.UseVisualStyleBackColor = True
        '
        'BtnSupplier_PhoneDelete
        '
        Me.BtnSupplier_PhoneDelete.Location = New System.Drawing.Point(485, 191)
        Me.BtnSupplier_PhoneDelete.Name = "BtnSupplier_PhoneDelete"
        Me.BtnSupplier_PhoneDelete.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplier_PhoneDelete.TabIndex = 30
        Me.BtnSupplier_PhoneDelete.Text = "Delete Selected Supplier Phone"
        Me.BtnSupplier_PhoneDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Supplier Phone No."
        '
        'TxtSupplierPhoneNo
        '
        Me.TxtSupplierPhoneNo.Location = New System.Drawing.Point(463, 75)
        Me.TxtSupplierPhoneNo.Name = "TxtSupplierPhoneNo"
        Me.TxtSupplierPhoneNo.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierPhoneNo.TabIndex = 27
        '
        'DataGridViewSupplier_Phone
        '
        Me.DataGridViewSupplier_Phone.AllowUserToAddRows = False
        Me.DataGridViewSupplier_Phone.AllowUserToDeleteRows = False
        Me.DataGridViewSupplier_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier_Phone.Location = New System.Drawing.Point(2, 16)
        Me.DataGridViewSupplier_Phone.Name = "DataGridViewSupplier_Phone"
        Me.DataGridViewSupplier_Phone.Size = New System.Drawing.Size(430, 454)
        Me.DataGridViewSupplier_Phone.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "+63"
        '
        'UserControlSupplier_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplier_Phone"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplier_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplier_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSupplier_PhoneUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplier_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSupplier_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
