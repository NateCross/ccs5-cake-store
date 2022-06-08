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
        Me.BtnPurchaseOrderAddItems = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPurchaseOrderLineItemQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPurchaseOrderLineItemPrice = New System.Windows.Forms.TextBox()
        Me.BtnPurchaseOrderLineItemUpdate = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderLineItemDelete = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderLineItemInsert = New System.Windows.Forms.Button()
        Me.DataGridViewPurchaseOrderLineItem = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'BtnPurchaseOrderAddItems
        '
        Me.BtnPurchaseOrderAddItems.Location = New System.Drawing.Point(370, 362)
        Me.BtnPurchaseOrderAddItems.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPurchaseOrderAddItems.Name = "BtnPurchaseOrderAddItems"
        Me.BtnPurchaseOrderAddItems.Size = New System.Drawing.Size(100, 68)
        Me.BtnPurchaseOrderAddItems.TabIndex = 8
        Me.BtnPurchaseOrderAddItems.Text = "Add Items To Purchase Order"
        Me.BtnPurchaseOrderAddItems.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 389)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantity"
        '
        'TxtPurchaseOrderLineItemQty
        '
        Me.TxtPurchaseOrderLineItemQty.Location = New System.Drawing.Point(71, 405)
        Me.TxtPurchaseOrderLineItemQty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPurchaseOrderLineItemQty.Name = "TxtPurchaseOrderLineItemQty"
        Me.TxtPurchaseOrderLineItemQty.Size = New System.Drawing.Size(148, 20)
        Me.TxtPurchaseOrderLineItemQty.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 346)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price"
        '
        'TxtPurchaseOrderLineItemPrice
        '
        Me.TxtPurchaseOrderLineItemPrice.Location = New System.Drawing.Point(69, 362)
        Me.TxtPurchaseOrderLineItemPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPurchaseOrderLineItemPrice.Name = "TxtPurchaseOrderLineItemPrice"
        Me.TxtPurchaseOrderLineItemPrice.Size = New System.Drawing.Size(150, 20)
        Me.TxtPurchaseOrderLineItemPrice.TabIndex = 4
        '
        'BtnPurchaseOrderLineItemUpdate
        '
        Me.BtnPurchaseOrderLineItemUpdate.Location = New System.Drawing.Point(474, 410)
        Me.BtnPurchaseOrderLineItemUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPurchaseOrderLineItemUpdate.Name = "BtnPurchaseOrderLineItemUpdate"
        Me.BtnPurchaseOrderLineItemUpdate.Size = New System.Drawing.Size(150, 20)
        Me.BtnPurchaseOrderLineItemUpdate.TabIndex = 3
        Me.BtnPurchaseOrderLineItemUpdate.Text = "Update Selected Line Item"
        Me.BtnPurchaseOrderLineItemUpdate.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderLineItemDelete
        '
        Me.BtnPurchaseOrderLineItemDelete.Location = New System.Drawing.Point(474, 386)
        Me.BtnPurchaseOrderLineItemDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPurchaseOrderLineItemDelete.Name = "BtnPurchaseOrderLineItemDelete"
        Me.BtnPurchaseOrderLineItemDelete.Size = New System.Drawing.Size(150, 20)
        Me.BtnPurchaseOrderLineItemDelete.TabIndex = 2
        Me.BtnPurchaseOrderLineItemDelete.Text = "Delete Selected Line Item"
        Me.BtnPurchaseOrderLineItemDelete.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderLineItemInsert
        '
        Me.BtnPurchaseOrderLineItemInsert.Location = New System.Drawing.Point(474, 362)
        Me.BtnPurchaseOrderLineItemInsert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPurchaseOrderLineItemInsert.Name = "BtnPurchaseOrderLineItemInsert"
        Me.BtnPurchaseOrderLineItemInsert.Size = New System.Drawing.Size(150, 20)
        Me.BtnPurchaseOrderLineItemInsert.TabIndex = 1
        Me.BtnPurchaseOrderLineItemInsert.Text = "Insert New Line Item"
        Me.BtnPurchaseOrderLineItemInsert.UseVisualStyleBackColor = True
        '
        'DataGridViewPurchaseOrderLineItem
        '
        Me.DataGridViewPurchaseOrderLineItem.AllowUserToAddRows = False
        Me.DataGridViewPurchaseOrderLineItem.AllowUserToDeleteRows = False
        Me.DataGridViewPurchaseOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchaseOrderLineItem.Location = New System.Drawing.Point(4, 17)
        Me.DataGridViewPurchaseOrderLineItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewPurchaseOrderLineItem.Name = "DataGridViewPurchaseOrderLineItem"
        Me.DataGridViewPurchaseOrderLineItem.RowTemplate.Height = 24
        Me.DataGridViewPurchaseOrderLineItem.Size = New System.Drawing.Size(628, 325)
        Me.DataGridViewPurchaseOrderLineItem.TabIndex = 0
        '
        'UserControlPurchaseOrderLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
