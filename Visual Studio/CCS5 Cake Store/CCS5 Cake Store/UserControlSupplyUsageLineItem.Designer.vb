<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplyUsageLineItem
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
        Me.DataGridViewSupplyUsageLineItem = New System.Windows.Forms.DataGridView()
        Me.BtnSupplyUsageLineItemAddToSupplyUsage = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageLineItemUpdate = New System.Windows.Forms.Button()
        Me.TxtSupplyUsageLineItemQtyUsed = New System.Windows.Forms.TextBox()
        Me.BtnSupplyUsageLineItemDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageLineItemInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyUsageLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageLineItemAddToSupplyUsage)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageLineItemUpdate)
        Me.GroupBox1.Controls.Add(Me.TxtSupplyUsageLineItemQtyUsed)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageLineItemDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageLineItemInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyUsageLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'DataGridViewSupplyUsageLineItem
        '
        Me.DataGridViewSupplyUsageLineItem.AllowUserToAddRows = False
        Me.DataGridViewSupplyUsageLineItem.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyUsageLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyUsageLineItem.Location = New System.Drawing.Point(4, 17)
        Me.DataGridViewSupplyUsageLineItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewSupplyUsageLineItem.Name = "DataGridViewSupplyUsageLineItem"
        Me.DataGridViewSupplyUsageLineItem.RowTemplate.Height = 24
        Me.DataGridViewSupplyUsageLineItem.Size = New System.Drawing.Size(466, 325)
        Me.DataGridViewSupplyUsageLineItem.TabIndex = 0
        '
        'BtnSupplyUsageLineItemAddToSupplyUsage
        '
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Location = New System.Drawing.Point(162, 400)
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Name = "BtnSupplyUsageLineItemAddToSupplyUsage"
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Size = New System.Drawing.Size(308, 50)
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.TabIndex = 28
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Text = "Add Items to Supply Usage"
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageLineItemUpdate
        '
        Me.BtnSupplyUsageLineItemUpdate.Location = New System.Drawing.Point(370, 346)
        Me.BtnSupplyUsageLineItemUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageLineItemUpdate.Name = "BtnSupplyUsageLineItemUpdate"
        Me.BtnSupplyUsageLineItemUpdate.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplyUsageLineItemUpdate.TabIndex = 27
        Me.BtnSupplyUsageLineItemUpdate.Text = "Update Selected Supply Usage"
        Me.BtnSupplyUsageLineItemUpdate.UseVisualStyleBackColor = True
        '
        'TxtSupplyUsageLineItemQtyUsed
        '
        Me.TxtSupplyUsageLineItemQtyUsed.Location = New System.Drawing.Point(16, 380)
        Me.TxtSupplyUsageLineItemQtyUsed.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSupplyUsageLineItemQtyUsed.Name = "TxtSupplyUsageLineItemQtyUsed"
        Me.TxtSupplyUsageLineItemQtyUsed.Size = New System.Drawing.Size(130, 20)
        Me.TxtSupplyUsageLineItemQtyUsed.TabIndex = 26
        '
        'BtnSupplyUsageLineItemDelete
        '
        Me.BtnSupplyUsageLineItemDelete.Location = New System.Drawing.Point(266, 346)
        Me.BtnSupplyUsageLineItemDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageLineItemDelete.Name = "BtnSupplyUsageLineItemDelete"
        Me.BtnSupplyUsageLineItemDelete.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplyUsageLineItemDelete.TabIndex = 25
        Me.BtnSupplyUsageLineItemDelete.Text = "Delete Selected Supply Usage"
        Me.BtnSupplyUsageLineItemDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageLineItemInsert
        '
        Me.BtnSupplyUsageLineItemInsert.Location = New System.Drawing.Point(162, 346)
        Me.BtnSupplyUsageLineItemInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageLineItemInsert.Name = "BtnSupplyUsageLineItemInsert"
        Me.BtnSupplyUsageLineItemInsert.Size = New System.Drawing.Size(100, 50)
        Me.BtnSupplyUsageLineItemInsert.TabIndex = 24
        Me.BtnSupplyUsageLineItemInsert.Text = "Insert New Supply Usage"
        Me.BtnSupplyUsageLineItemInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 365)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Supply Quantity Used"
        '
        'UserControlSupplyUsageLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UserControlSupplyUsageLineItem"
        Me.Size = New System.Drawing.Size(480, 460)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplyUsageLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyUsageLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSupplyUsageLineItemAddToSupplyUsage As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageLineItemUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtSupplyUsageLineItemQtyUsed As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplyUsageLineItemDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageLineItemInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
