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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSupplyUsageLineItemAddToSupplyUsage = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageLineItemUpdate = New System.Windows.Forms.Button()
        Me.TxtSupplyUsageLineItemQtyUsed = New System.Windows.Forms.TextBox()
        Me.BtnSupplyUsageLineItemDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageLineItemInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyUsageLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyUsageLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'DataGridViewSupplyUsageLineItem
        '
        Me.DataGridViewSupplyUsageLineItem.AllowUserToAddRows = False
        Me.DataGridViewSupplyUsageLineItem.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyUsageLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyUsageLineItem.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSupplyUsageLineItem.Name = "DataGridViewSupplyUsageLineItem"
        Me.DataGridViewSupplyUsageLineItem.RowTemplate.Height = 24
        Me.DataGridViewSupplyUsageLineItem.Size = New System.Drawing.Size(622, 333)
        Me.DataGridViewSupplyUsageLineItem.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageLineItemAddToSupplyUsage)
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageLineItemUpdate)
        Me.GroupBox2.Controls.Add(Me.TxtSupplyUsageLineItemQtyUsed)
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageLineItemDelete)
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageLineItemInsert)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 114)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BtnSupplyUsageLineItemAddToSupplyUsage
        '
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Location = New System.Drawing.Point(241, 58)
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Name = "BtnSupplyUsageLineItemAddToSupplyUsage"
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Size = New System.Drawing.Size(387, 44)
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.TabIndex = 22
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.Text = "Add Items to Supply Usage"
        Me.BtnSupplyUsageLineItemAddToSupplyUsage.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageLineItemUpdate
        '
        Me.BtnSupplyUsageLineItemUpdate.Location = New System.Drawing.Point(503, 9)
        Me.BtnSupplyUsageLineItemUpdate.Name = "BtnSupplyUsageLineItemUpdate"
        Me.BtnSupplyUsageLineItemUpdate.Size = New System.Drawing.Size(125, 43)
        Me.BtnSupplyUsageLineItemUpdate.TabIndex = 21
        Me.BtnSupplyUsageLineItemUpdate.Text = "Update Selected Supply Usage"
        Me.BtnSupplyUsageLineItemUpdate.UseVisualStyleBackColor = True
        '
        'TxtSupplyUsageLineItemQtyUsed
        '
        Me.TxtSupplyUsageLineItemQtyUsed.Location = New System.Drawing.Point(40, 42)
        Me.TxtSupplyUsageLineItemQtyUsed.Name = "TxtSupplyUsageLineItemQtyUsed"
        Me.TxtSupplyUsageLineItemQtyUsed.Size = New System.Drawing.Size(100, 22)
        Me.TxtSupplyUsageLineItemQtyUsed.TabIndex = 20
        '
        'BtnSupplyUsageLineItemDelete
        '
        Me.BtnSupplyUsageLineItemDelete.Location = New System.Drawing.Point(372, 9)
        Me.BtnSupplyUsageLineItemDelete.Name = "BtnSupplyUsageLineItemDelete"
        Me.BtnSupplyUsageLineItemDelete.Size = New System.Drawing.Size(125, 43)
        Me.BtnSupplyUsageLineItemDelete.TabIndex = 19
        Me.BtnSupplyUsageLineItemDelete.Text = "Delete Selected Supply Usage"
        Me.BtnSupplyUsageLineItemDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageLineItemInsert
        '
        Me.BtnSupplyUsageLineItemInsert.Location = New System.Drawing.Point(241, 9)
        Me.BtnSupplyUsageLineItemInsert.Name = "BtnSupplyUsageLineItemInsert"
        Me.BtnSupplyUsageLineItemInsert.Size = New System.Drawing.Size(125, 43)
        Me.BtnSupplyUsageLineItemInsert.TabIndex = 18
        Me.BtnSupplyUsageLineItemInsert.Text = "Insert New Supply Usage"
        Me.BtnSupplyUsageLineItemInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Supply Quantity Used"
        '
        'UserControlSupplyUsageLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplyUsageLineItem"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSupplyUsageLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyUsageLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplyUsageLineItemQtyUsed As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplyUsageLineItemDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageLineItemInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplyUsageLineItemAddToSupplyUsage As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageLineItemUpdate As System.Windows.Forms.Button

End Class
