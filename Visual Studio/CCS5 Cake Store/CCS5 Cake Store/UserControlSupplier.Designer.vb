<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplier
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
        Me.DataGridViewSupplier = New System.Windows.Forms.DataGridView()
        Me.TxtSupplierId = New System.Windows.Forms.TextBox()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierStreet = New System.Windows.Forms.TextBox()
        Me.TxtSupplierProvince = New System.Windows.Forms.TextBox()
        Me.TxtSupplierCity = New System.Windows.Forms.TextBox()
        Me.TxtSupplierEmailAddress = New System.Windows.Forms.TextBox()
        Me.BtnSupplierInsert = New System.Windows.Forms.Button()
        Me.BtnSupplierDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(3, 19)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(504, 333)
        Me.DataGridViewSupplier.TabIndex = 0
        '
        'TxtSupplierId
        '
        Me.TxtSupplierId.Location = New System.Drawing.Point(552, 58)
        Me.TxtSupplierId.Name = "TxtSupplierId"
        Me.TxtSupplierId.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierId.TabIndex = 1
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(707, 58)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierName.TabIndex = 2
        '
        'TxtSupplierStreet
        '
        Me.TxtSupplierStreet.Location = New System.Drawing.Point(552, 127)
        Me.TxtSupplierStreet.Name = "TxtSupplierStreet"
        Me.TxtSupplierStreet.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierStreet.TabIndex = 3
        '
        'TxtSupplierProvince
        '
        Me.TxtSupplierProvince.Location = New System.Drawing.Point(552, 196)
        Me.TxtSupplierProvince.Name = "TxtSupplierProvince"
        Me.TxtSupplierProvince.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierProvince.TabIndex = 4
        '
        'TxtSupplierCity
        '
        Me.TxtSupplierCity.Location = New System.Drawing.Point(707, 127)
        Me.TxtSupplierCity.Name = "TxtSupplierCity"
        Me.TxtSupplierCity.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierCity.TabIndex = 5
        '
        'TxtSupplierEmailAddress
        '
        Me.TxtSupplierEmailAddress.Location = New System.Drawing.Point(707, 196)
        Me.TxtSupplierEmailAddress.Name = "TxtSupplierEmailAddress"
        Me.TxtSupplierEmailAddress.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierEmailAddress.TabIndex = 6
        '
        'BtnSupplierInsert
        '
        Me.BtnSupplierInsert.Location = New System.Drawing.Point(552, 275)
        Me.BtnSupplierInsert.Name = "BtnSupplierInsert"
        Me.BtnSupplierInsert.Size = New System.Drawing.Size(100, 41)
        Me.BtnSupplierInsert.TabIndex = 7
        Me.BtnSupplierInsert.Text = "Insert New Supplier"
        Me.BtnSupplierInsert.UseVisualStyleBackColor = True
        '
        'BtnSupplierDelete
        '
        Me.BtnSupplierDelete.Location = New System.Drawing.Point(707, 275)
        Me.BtnSupplierDelete.Name = "BtnSupplierDelete"
        Me.BtnSupplierDelete.Size = New System.Drawing.Size(100, 41)
        Me.BtnSupplierDelete.TabIndex = 8
        Me.BtnSupplierDelete.Text = "Delete Selected Supplier"
        Me.BtnSupplierDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Supplier ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(704, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Street"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(704, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(549, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Province "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(704, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email Address"
        '
        'UserControlSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSupplierDelete)
        Me.Controls.Add(Me.BtnSupplierInsert)
        Me.Controls.Add(Me.TxtSupplierEmailAddress)
        Me.Controls.Add(Me.TxtSupplierCity)
        Me.Controls.Add(Me.TxtSupplierProvince)
        Me.Controls.Add(Me.TxtSupplierStreet)
        Me.Controls.Add(Me.TxtSupplierName)
        Me.Controls.Add(Me.TxtSupplierId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplier"
        Me.Size = New System.Drawing.Size(835, 366)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplierId As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierStreet As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierProvince As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplierInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
