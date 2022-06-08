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
        Me.BtnSupplierClear = New System.Windows.Forms.Button()
        Me.BtnSupplierUpdate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSupplierDelete = New System.Windows.Forms.Button()
        Me.BtnSupplierInsert = New System.Windows.Forms.Button()
        Me.TxtSupplierEmailAddress = New System.Windows.Forms.TextBox()
        Me.TxtSupplierCity = New System.Windows.Forms.TextBox()
        Me.TxtSupplierProvince = New System.Windows.Forms.TextBox()
        Me.TxtSupplierStreet = New System.Windows.Forms.TextBox()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSupplierClear)
        Me.GroupBox1.Controls.Add(Me.BtnSupplierUpdate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnSupplierDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplierInsert)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierEmailAddress)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierCity)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierProvince)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierStreet)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierName)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierSearchName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'TxtSupplierSearchName
        '
        Me.TxtSupplierSearchName.Location = New System.Drawing.Point(130, 17)
        Me.TxtSupplierSearchName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSupplierSearchName.Name = "TxtSupplierSearchName"
        Me.TxtSupplierSearchName.Size = New System.Drawing.Size(349, 20)
        Me.TxtSupplierSearchName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Supplier Names:"
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.AllowUserToAddRows = False
        Me.DataGridViewSupplier.AllowUserToDeleteRows = False
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(4, 40)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(475, 400)
        Me.DataGridViewSupplier.TabIndex = 0
        '
        'BtnSupplierClear
        '
        Me.BtnSupplierClear.Location = New System.Drawing.Point(622, 357)
        Me.BtnSupplierClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplierClear.Name = "BtnSupplierClear"
        Me.BtnSupplierClear.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplierClear.TabIndex = 30
        Me.BtnSupplierClear.Text = "Clear Fields"
        Me.BtnSupplierClear.UseVisualStyleBackColor = True
        '
        'BtnSupplierUpdate
        '
        Me.BtnSupplierUpdate.Location = New System.Drawing.Point(516, 357)
        Me.BtnSupplierUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplierUpdate.Name = "BtnSupplierUpdate"
        Me.BtnSupplierUpdate.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplierUpdate.TabIndex = 29
        Me.BtnSupplierUpdate.Text = "Update Selected Supplier"
        Me.BtnSupplierUpdate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(543, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Email Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(543, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Province "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Street"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(543, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'BtnSupplierDelete
        '
        Me.BtnSupplierDelete.Location = New System.Drawing.Point(622, 312)
        Me.BtnSupplierDelete.Name = "BtnSupplierDelete"
        Me.BtnSupplierDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplierDelete.TabIndex = 23
        Me.BtnSupplierDelete.Text = "Delete Selected Supplier"
        Me.BtnSupplierDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplierInsert
        '
        Me.BtnSupplierInsert.Location = New System.Drawing.Point(516, 312)
        Me.BtnSupplierInsert.Name = "BtnSupplierInsert"
        Me.BtnSupplierInsert.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplierInsert.TabIndex = 22
        Me.BtnSupplierInsert.Text = "Insert New Supplier"
        Me.BtnSupplierInsert.UseVisualStyleBackColor = True
        '
        'TxtSupplierEmailAddress
        '
        Me.TxtSupplierEmailAddress.Location = New System.Drawing.Point(546, 255)
        Me.TxtSupplierEmailAddress.Name = "TxtSupplierEmailAddress"
        Me.TxtSupplierEmailAddress.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierEmailAddress.TabIndex = 21
        '
        'TxtSupplierCity
        '
        Me.TxtSupplierCity.Location = New System.Drawing.Point(546, 148)
        Me.TxtSupplierCity.Name = "TxtSupplierCity"
        Me.TxtSupplierCity.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierCity.TabIndex = 20
        '
        'TxtSupplierProvince
        '
        Me.TxtSupplierProvince.Location = New System.Drawing.Point(546, 200)
        Me.TxtSupplierProvince.Name = "TxtSupplierProvince"
        Me.TxtSupplierProvince.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierProvince.TabIndex = 19
        '
        'TxtSupplierStreet
        '
        Me.TxtSupplierStreet.Location = New System.Drawing.Point(546, 104)
        Me.TxtSupplierStreet.Name = "TxtSupplierStreet"
        Me.TxtSupplierStreet.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierStreet.TabIndex = 18
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(546, 56)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplierName.TabIndex = 17
        '
        'UserControlSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplier"
        Me.Size = New System.Drawing.Size(768, 454)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplierSearchName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplierClear As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierUpdate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplierDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierInsert As System.Windows.Forms.Button
    Friend WithEvents TxtSupplierEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierProvince As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierStreet As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierName As System.Windows.Forms.TextBox

End Class
