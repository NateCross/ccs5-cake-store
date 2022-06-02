<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSaleLineItem
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
        Me.BtnSaleLineItemClearFields = New System.Windows.Forms.Button()
        Me.BtnSaleLineItemUpdate = New System.Windows.Forms.Button()
        Me.BtnSaleLineItemDelete = New System.Windows.Forms.Button()
        Me.BtnSaleLineItemInsert = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSaleQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSalePrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSaleProdId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSaleId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSaleLineItemID = New System.Windows.Forms.TextBox()
        Me.DataGridViewSaleLineItem = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSaleLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSaleLineItemClearFields)
        Me.GroupBox1.Controls.Add(Me.BtnSaleLineItemUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnSaleLineItemDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSaleLineItemInsert)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSaleQty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtSalePrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtSaleProdId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSaleId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSaleLineItemID)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSaleLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 443)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sale Line Items"
        '
        'BtnSaleLineItemClearFields
        '
        Me.BtnSaleLineItemClearFields.Location = New System.Drawing.Point(376, 398)
        Me.BtnSaleLineItemClearFields.Name = "BtnSaleLineItemClearFields"
        Me.BtnSaleLineItemClearFields.Size = New System.Drawing.Size(132, 36)
        Me.BtnSaleLineItemClearFields.TabIndex = 14
        Me.BtnSaleLineItemClearFields.Text = "Clear Fields"
        Me.BtnSaleLineItemClearFields.UseVisualStyleBackColor = True
        '
        'BtnSaleLineItemUpdate
        '
        Me.BtnSaleLineItemUpdate.Location = New System.Drawing.Point(376, 356)
        Me.BtnSaleLineItemUpdate.Name = "BtnSaleLineItemUpdate"
        Me.BtnSaleLineItemUpdate.Size = New System.Drawing.Size(132, 36)
        Me.BtnSaleLineItemUpdate.TabIndex = 13
        Me.BtnSaleLineItemUpdate.Text = "Update Line Item"
        Me.BtnSaleLineItemUpdate.UseVisualStyleBackColor = True
        '
        'BtnSaleLineItemDelete
        '
        Me.BtnSaleLineItemDelete.Location = New System.Drawing.Point(376, 306)
        Me.BtnSaleLineItemDelete.Name = "BtnSaleLineItemDelete"
        Me.BtnSaleLineItemDelete.Size = New System.Drawing.Size(132, 44)
        Me.BtnSaleLineItemDelete.TabIndex = 12
        Me.BtnSaleLineItemDelete.Text = "Delete Selected Line Item"
        Me.BtnSaleLineItemDelete.UseVisualStyleBackColor = True
        '
        'BtnSaleLineItemInsert
        '
        Me.BtnSaleLineItemInsert.Location = New System.Drawing.Point(376, 256)
        Me.BtnSaleLineItemInsert.Name = "BtnSaleLineItemInsert"
        Me.BtnSaleLineItemInsert.Size = New System.Drawing.Size(132, 44)
        Me.BtnSaleLineItemInsert.TabIndex = 11
        Me.BtnSaleLineItemInsert.Text = "Insert Line Item"
        Me.BtnSaleLineItemInsert.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quantity"
        '
        'TxtSaleQty
        '
        Me.TxtSaleQty.Location = New System.Drawing.Point(319, 228)
        Me.TxtSaleQty.Name = "TxtSaleQty"
        Me.TxtSaleQty.Size = New System.Drawing.Size(189, 22)
        Me.TxtSaleQty.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Location = New System.Drawing.Point(321, 181)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(187, 22)
        Me.TxtSalePrice.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product ID"
        '
        'TxtSaleProdId
        '
        Me.TxtSaleProdId.Location = New System.Drawing.Point(319, 135)
        Me.TxtSaleProdId.Name = "TxtSaleProdId"
        Me.TxtSaleProdId.Size = New System.Drawing.Size(189, 22)
        Me.TxtSaleProdId.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sale ID"
        '
        'TxtSaleId
        '
        Me.TxtSaleId.Location = New System.Drawing.Point(321, 90)
        Me.TxtSaleId.Name = "TxtSaleId"
        Me.TxtSaleId.Size = New System.Drawing.Size(189, 22)
        Me.TxtSaleId.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sale Line Item ID"
        '
        'TxtSaleLineItemID
        '
        Me.TxtSaleLineItemID.Location = New System.Drawing.Point(321, 41)
        Me.TxtSaleLineItemID.Name = "TxtSaleLineItemID"
        Me.TxtSaleLineItemID.Size = New System.Drawing.Size(189, 22)
        Me.TxtSaleLineItemID.TabIndex = 1
        '
        'DataGridViewSaleLineItem
        '
        Me.DataGridViewSaleLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSaleLineItem.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSaleLineItem.Name = "DataGridViewSaleLineItem"
        Me.DataGridViewSaleLineItem.RowTemplate.Height = 24
        Me.DataGridViewSaleLineItem.Size = New System.Drawing.Size(295, 413)
        Me.DataGridViewSaleLineItem.TabIndex = 0
        '
        'UserControlSaleLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSaleLineItem"
        Me.Size = New System.Drawing.Size(750, 455)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSaleLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSaleLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSaleId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSaleLineItemID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSaleLineItemInsert As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSaleQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSaleProdId As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaleLineItemDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSaleLineItemUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSaleLineItemClearFields As System.Windows.Forms.Button

End Class
