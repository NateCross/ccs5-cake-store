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
        Me.TxtSupplierSearchName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewSupplier = New System.Windows.Forms.DataGridView()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierStreet = New System.Windows.Forms.TextBox()
        Me.TxtSupplierProvince = New System.Windows.Forms.TextBox()
        Me.TxtSupplierCity = New System.Windows.Forms.TextBox()
        Me.TxtSupplierEmailAddress = New System.Windows.Forms.TextBox()
        Me.BtnSupplierInsert = New System.Windows.Forms.Button()
        Me.BtnSupplierDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSupplierUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplierClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSupplierSearchName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(687, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'TxtSupplierSearchName
        '
        Me.TxtSupplierSearchName.Location = New System.Drawing.Point(174, 28)
        Me.TxtSupplierSearchName.Name = "TxtSupplierSearchName"
        Me.TxtSupplierSearchName.Size = New System.Drawing.Size(502, 22)
        Me.TxtSupplierSearchName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Supplier Names:"
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.AllowUserToAddRows = False
        Me.DataGridViewSupplier.AllowUserToDeleteRows = False
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(4, 52)
        Me.DataGridViewSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(672, 381)
        Me.DataGridViewSupplier.TabIndex = 0
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(943, 71)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierName.TabIndex = 2
        '
        'TxtSupplierStreet
        '
        Me.TxtSupplierStreet.Location = New System.Drawing.Point(736, 156)
        Me.TxtSupplierStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierStreet.Name = "TxtSupplierStreet"
        Me.TxtSupplierStreet.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierStreet.TabIndex = 3
        '
        'TxtSupplierProvince
        '
        Me.TxtSupplierProvince.Location = New System.Drawing.Point(736, 241)
        Me.TxtSupplierProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierProvince.Name = "TxtSupplierProvince"
        Me.TxtSupplierProvince.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierProvince.TabIndex = 4
        '
        'TxtSupplierCity
        '
        Me.TxtSupplierCity.Location = New System.Drawing.Point(943, 156)
        Me.TxtSupplierCity.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierCity.Name = "TxtSupplierCity"
        Me.TxtSupplierCity.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierCity.TabIndex = 5
        '
        'TxtSupplierEmailAddress
        '
        Me.TxtSupplierEmailAddress.Location = New System.Drawing.Point(943, 241)
        Me.TxtSupplierEmailAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSupplierEmailAddress.Name = "TxtSupplierEmailAddress"
        Me.TxtSupplierEmailAddress.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplierEmailAddress.TabIndex = 6
        '
        'BtnSupplierInsert
        '
        Me.BtnSupplierInsert.Location = New System.Drawing.Point(735, 302)
        Me.BtnSupplierInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSupplierInsert.Name = "BtnSupplierInsert"
        Me.BtnSupplierInsert.Size = New System.Drawing.Size(133, 50)
        Me.BtnSupplierInsert.TabIndex = 7
        Me.BtnSupplierInsert.Text = "Insert New Supplier"
        Me.BtnSupplierInsert.UseVisualStyleBackColor = True
        '
        'BtnSupplierDelete
        '
        Me.BtnSupplierDelete.Location = New System.Drawing.Point(942, 302)
        Me.BtnSupplierDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSupplierDelete.Name = "BtnSupplierDelete"
        Me.BtnSupplierDelete.Size = New System.Drawing.Size(133, 50)
        Me.BtnSupplierDelete.TabIndex = 8
        Me.BtnSupplierDelete.Text = "Delete Selected Supplier"
        Me.BtnSupplierDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(939, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(732, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Street"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(939, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(732, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Province "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(939, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email Address"
        '
        'BtnSupplierUpdate
        '
        Me.BtnSupplierUpdate.Location = New System.Drawing.Point(736, 374)
        Me.BtnSupplierUpdate.Name = "BtnSupplierUpdate"
        Me.BtnSupplierUpdate.Size = New System.Drawing.Size(132, 50)
        Me.BtnSupplierUpdate.TabIndex = 15
        Me.BtnSupplierUpdate.Text = "Update Selected Supplier"
        Me.BtnSupplierUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplierClear
        '
        Me.BtnSupplierClear.Location = New System.Drawing.Point(943, 374)
        Me.BtnSupplierClear.Name = "BtnSupplierClear"
        Me.BtnSupplierClear.Size = New System.Drawing.Size(132, 50)
        Me.BtnSupplierClear.TabIndex = 16
        Me.BtnSupplierClear.Text = "Clear Fields"
        Me.BtnSupplierClear.UseVisualStyleBackColor = True
        '
        'UserControlSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSupplierClear)
        Me.Controls.Add(Me.BtnSupplierUpdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSupplierDelete)
        Me.Controls.Add(Me.BtnSupplierInsert)
        Me.Controls.Add(Me.TxtSupplierEmailAddress)
        Me.Controls.Add(Me.TxtSupplierCity)
        Me.Controls.Add(Me.TxtSupplierProvince)
        Me.Controls.Add(Me.TxtSupplierStreet)
        Me.Controls.Add(Me.TxtSupplierName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserControlSupplier"
        Me.Size = New System.Drawing.Size(1113, 450)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierStreet As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierProvince As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplierInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierDelete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierSearchName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplierUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierClear As System.Windows.Forms.Button

End Class
