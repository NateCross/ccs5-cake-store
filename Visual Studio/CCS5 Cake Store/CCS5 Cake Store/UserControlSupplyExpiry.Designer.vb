<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplyExpiry
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
        Me.GroupBoxSupplyExpiry = New System.Windows.Forms.GroupBox()
        Me.DataGridViewSupplyExpiry = New System.Windows.Forms.DataGridView()
        Me.BtnSupplyExpiryUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplyExpiryDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyExpiryInsert = New System.Windows.Forms.Button()
        Me.LblSupplyExpirationDate = New System.Windows.Forms.Label()
        Me.DateTimePickerSupplyExpiration = New System.Windows.Forms.DateTimePicker()
        Me.TxtSupplyExpiryQty = New System.Windows.Forms.TextBox()
        Me.LblSupplyExpirationQuantity = New System.Windows.Forms.Label()
        Me.GroupBoxSupplyExpiry.SuspendLayout()
        CType(Me.DataGridViewSupplyExpiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxSupplyExpiry
        '
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.LblSupplyExpirationQuantity)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.TxtSupplyExpiryQty)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.BtnSupplyExpiryUpdate)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.BtnSupplyExpiryDelete)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.BtnSupplyExpiryInsert)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.LblSupplyExpirationDate)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.DateTimePickerSupplyExpiration)
        Me.GroupBoxSupplyExpiry.Controls.Add(Me.DataGridViewSupplyExpiry)
        Me.GroupBoxSupplyExpiry.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxSupplyExpiry.Name = "GroupBoxSupplyExpiry"
        Me.GroupBoxSupplyExpiry.Size = New System.Drawing.Size(634, 474)
        Me.GroupBoxSupplyExpiry.TabIndex = 0
        Me.GroupBoxSupplyExpiry.TabStop = False
        Me.GroupBoxSupplyExpiry.Text = "Supply Expiration"
        '
        'DataGridViewSupplyExpiry
        '
        Me.DataGridViewSupplyExpiry.AllowUserToAddRows = False
        Me.DataGridViewSupplyExpiry.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyExpiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyExpiry.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSupplyExpiry.Name = "DataGridViewSupplyExpiry"
        Me.DataGridViewSupplyExpiry.RowTemplate.Height = 24
        Me.DataGridViewSupplyExpiry.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewSupplyExpiry.TabIndex = 0
        '
        'BtnSupplyExpiryUpdate
        '
        Me.BtnSupplyExpiryUpdate.Location = New System.Drawing.Point(395, 445)
        Me.BtnSupplyExpiryUpdate.Name = "BtnSupplyExpiryUpdate"
        Me.BtnSupplyExpiryUpdate.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyExpiryUpdate.TabIndex = 15
        Me.BtnSupplyExpiryUpdate.Text = "Update Selected Supply Expiry"
        Me.BtnSupplyExpiryUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyExpiryDelete
        '
        Me.BtnSupplyExpiryDelete.Location = New System.Drawing.Point(395, 416)
        Me.BtnSupplyExpiryDelete.Name = "BtnSupplyExpiryDelete"
        Me.BtnSupplyExpiryDelete.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyExpiryDelete.TabIndex = 14
        Me.BtnSupplyExpiryDelete.Text = "Delete Selected Supply Expiry"
        Me.BtnSupplyExpiryDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyExpiryInsert
        '
        Me.BtnSupplyExpiryInsert.Location = New System.Drawing.Point(395, 387)
        Me.BtnSupplyExpiryInsert.Name = "BtnSupplyExpiryInsert"
        Me.BtnSupplyExpiryInsert.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyExpiryInsert.TabIndex = 13
        Me.BtnSupplyExpiryInsert.Text = "Insert New Supply Expiry"
        Me.BtnSupplyExpiryInsert.UseVisualStyleBackColor = True
        '
        'LblSupplyExpirationDate
        '
        Me.LblSupplyExpirationDate.AutoSize = True
        Me.LblSupplyExpirationDate.Location = New System.Drawing.Point(37, 400)
        Me.LblSupplyExpirationDate.Name = "LblSupplyExpirationDate"
        Me.LblSupplyExpirationDate.Size = New System.Drawing.Size(151, 17)
        Me.LblSupplyExpirationDate.TabIndex = 12
        Me.LblSupplyExpirationDate.Text = "Supply Expiration Date"
        '
        'DateTimePickerSupplyExpiration
        '
        Me.DateTimePickerSupplyExpiration.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerSupplyExpiration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerSupplyExpiration.Location = New System.Drawing.Point(40, 420)
        Me.DateTimePickerSupplyExpiration.Name = "DateTimePickerSupplyExpiration"
        Me.DateTimePickerSupplyExpiration.Size = New System.Drawing.Size(129, 22)
        Me.DateTimePickerSupplyExpiration.TabIndex = 11
        '
        'TxtSupplyExpiryQty
        '
        Me.TxtSupplyExpiryQty.Location = New System.Drawing.Point(212, 420)
        Me.TxtSupplyExpiryQty.Name = "TxtSupplyExpiryQty"
        Me.TxtSupplyExpiryQty.Size = New System.Drawing.Size(100, 22)
        Me.TxtSupplyExpiryQty.TabIndex = 17
        '
        'LblSupplyExpirationQuantity
        '
        Me.LblSupplyExpirationQuantity.AutoSize = True
        Me.LblSupplyExpirationQuantity.Location = New System.Drawing.Point(209, 400)
        Me.LblSupplyExpirationQuantity.Name = "LblSupplyExpirationQuantity"
        Me.LblSupplyExpirationQuantity.Size = New System.Drawing.Size(127, 17)
        Me.LblSupplyExpirationQuantity.TabIndex = 18
        Me.LblSupplyExpirationQuantity.Text = "Expiration Quantity"
        '
        'UserControlSupplyExpiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxSupplyExpiry)
        Me.Name = "UserControlSupplyExpiry"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBoxSupplyExpiry.ResumeLayout(False)
        Me.GroupBoxSupplyExpiry.PerformLayout()
        CType(Me.DataGridViewSupplyExpiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSupplyExpiry As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyExpiry As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSupplyExpiryUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyExpiryDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyExpiryInsert As System.Windows.Forms.Button
    Friend WithEvents LblSupplyExpirationDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerSupplyExpiration As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSupplyExpiryQty As System.Windows.Forms.TextBox
    Friend WithEvents LblSupplyExpirationQuantity As System.Windows.Forms.Label

End Class
