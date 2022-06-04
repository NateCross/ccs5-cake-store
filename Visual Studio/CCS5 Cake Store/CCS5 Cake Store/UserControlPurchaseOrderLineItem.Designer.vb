<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlPurchaseOrderLineItem
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
        Me.DataGridViewPurchaseOrderLineItem = New System.Windows.Forms.DataGridView()
        Me.BtnPurchaseOrderLineItemInsert = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderLineItemDelete = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderLineItemUpdate = New System.Windows.Forms.Button()
        Me.TxtPurchaseOrderLineItemPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPurchaseOrderLineItemQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPurchaseOrderAddItems = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewPurchaseOrderLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderAddItems)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtPurchaseOrderLineItemQty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPurchaseOrderLineItemPrice)
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderLineItemUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderLineItemDelete)
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderLineItemInsert)
        Me.GroupBox1.Controls.Add(Me.DataGridViewPurchaseOrderLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'DataGridViewPurchaseOrderLineItem
        '
        Me.DataGridViewPurchaseOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchaseOrderLineItem.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewPurchaseOrderLineItem.Name = "DataGridViewPurchaseOrderLineItem"
        Me.DataGridViewPurchaseOrderLineItem.RowTemplate.Height = 24
        Me.DataGridViewPurchaseOrderLineItem.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewPurchaseOrderLineItem.TabIndex = 0
        '
        'BtnPurchaseOrderLineItemInsert
        '
        Me.BtnPurchaseOrderLineItemInsert.Location = New System.Drawing.Point(445, 387)
        Me.BtnPurchaseOrderLineItemInsert.Name = "BtnPurchaseOrderLineItemInsert"
        Me.BtnPurchaseOrderLineItemInsert.Size = New System.Drawing.Size(183, 23)
        Me.BtnPurchaseOrderLineItemInsert.TabIndex = 1
        Me.BtnPurchaseOrderLineItemInsert.Text = "Insert New Line Item"
        Me.BtnPurchaseOrderLineItemInsert.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderLineItemDelete
        '
        Me.BtnPurchaseOrderLineItemDelete.Location = New System.Drawing.Point(445, 416)
        Me.BtnPurchaseOrderLineItemDelete.Name = "BtnPurchaseOrderLineItemDelete"
        Me.BtnPurchaseOrderLineItemDelete.Size = New System.Drawing.Size(183, 23)
        Me.BtnPurchaseOrderLineItemDelete.TabIndex = 2
        Me.BtnPurchaseOrderLineItemDelete.Text = "Delete Selected Line Item"
        Me.BtnPurchaseOrderLineItemDelete.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderLineItemUpdate
        '
        Me.BtnPurchaseOrderLineItemUpdate.Location = New System.Drawing.Point(445, 445)
        Me.BtnPurchaseOrderLineItemUpdate.Name = "BtnPurchaseOrderLineItemUpdate"
        Me.BtnPurchaseOrderLineItemUpdate.Size = New System.Drawing.Size(183, 23)
        Me.BtnPurchaseOrderLineItemUpdate.TabIndex = 3
        Me.BtnPurchaseOrderLineItemUpdate.Text = "Update Selected Line Item"
        Me.BtnPurchaseOrderLineItemUpdate.UseVisualStyleBackColor = True
        '
        'TxtPurchaseOrderLineItemPrice
        '
        Me.TxtPurchaseOrderLineItemPrice.Location = New System.Drawing.Point(6, 417)
        Me.TxtPurchaseOrderLineItemPrice.Name = "TxtPurchaseOrderLineItemPrice"
        Me.TxtPurchaseOrderLineItemPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtPurchaseOrderLineItemPrice.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price"
        '
        'TxtPurchaseOrderLineItemQty
        '
        Me.TxtPurchaseOrderLineItemQty.Location = New System.Drawing.Point(112, 416)
        Me.TxtPurchaseOrderLineItemQty.Name = "TxtPurchaseOrderLineItemQty"
        Me.TxtPurchaseOrderLineItemQty.Size = New System.Drawing.Size(100, 22)
        Me.TxtPurchaseOrderLineItemQty.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantity"
        '
        'BtnPurchaseOrderAddItems
        '
        Me.BtnPurchaseOrderAddItems.Location = New System.Drawing.Point(312, 387)
        Me.BtnPurchaseOrderAddItems.Name = "BtnPurchaseOrderAddItems"
        Me.BtnPurchaseOrderAddItems.Size = New System.Drawing.Size(127, 81)
        Me.BtnPurchaseOrderAddItems.TabIndex = 8
        Me.BtnPurchaseOrderAddItems.Text = "Add Items To Purchase Order"
        Me.BtnPurchaseOrderAddItems.UseVisualStyleBackColor = True
        '
        'UserControlPurchaseOrderLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlPurchaseOrderLineItem"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewPurchaseOrderLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewPurchaseOrderLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents BtnPurchaseOrderLineItemInsert As System.Windows.Forms.Button
    Friend WithEvents BtnPurchaseOrderLineItemUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnPurchaseOrderLineItemDelete As System.Windows.Forms.Button
    Friend WithEvents BtnPurchaseOrderAddItems As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseOrderLineItemQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseOrderLineItemPrice As System.Windows.Forms.TextBox

End Class
