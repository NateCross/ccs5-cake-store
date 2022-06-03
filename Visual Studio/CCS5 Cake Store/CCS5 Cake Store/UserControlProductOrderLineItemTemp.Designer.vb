<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProductOrderLineItemTemp
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProdOrderId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProdId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProdOrderLineItemId = New System.Windows.Forms.TextBox()
        Me.DataGridViewProdOrderLineItem = New System.Windows.Forms.DataGridView()
        Me.BtnAddItemsToProdOrder = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewProdOrderLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProdOrderLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 432)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtQty)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtProdOrderId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtProdId)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtProdOrderLineItemId)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(595, 131)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(155, 23)
        Me.BtnClear.TabIndex = 14
        Me.BtnClear.Text = "Clear Fields"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(595, 91)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(155, 34)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Update Selected Row"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(595, 55)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(155, 35)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete Selected Row"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(595, 18)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(155, 35)
        Me.BtnInsert.TabIndex = 11
        Me.BtnInsert.Text = "Insert New Line Item"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(398, 84)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(100, 22)
        Me.TxtQty.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 7
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(213, 84)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrice.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product ID"
        '
        'TxtProdOrderId
        '
        Me.TxtProdOrderId.Location = New System.Drawing.Point(6, 84)
        Me.TxtProdOrderId.Name = "TxtProdOrderId"
        Me.TxtProdOrderId.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdOrderId.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Order ID"
        '
        'TxtProdId
        '
        Me.TxtProdId.Location = New System.Drawing.Point(6, 131)
        Me.TxtProdId.Name = "TxtProdId"
        Me.TxtProdId.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdId.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Order Line Item ID"
        '
        'TxtProdOrderLineItemId
        '
        Me.TxtProdOrderLineItemId.Location = New System.Drawing.Point(6, 34)
        Me.TxtProdOrderLineItemId.Name = "TxtProdOrderLineItemId"
        Me.TxtProdOrderLineItemId.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdOrderLineItemId.TabIndex = 0
        '
        'DataGridViewProdOrderLineItem
        '
        Me.DataGridViewProdOrderLineItem.AllowUserToAddRows = False
        Me.DataGridViewProdOrderLineItem.AllowUserToDeleteRows = False
        Me.DataGridViewProdOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProdOrderLineItem.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewProdOrderLineItem.Name = "DataGridViewProdOrderLineItem"
        Me.DataGridViewProdOrderLineItem.RowTemplate.Height = 24
        Me.DataGridViewProdOrderLineItem.Size = New System.Drawing.Size(756, 240)
        Me.DataGridViewProdOrderLineItem.TabIndex = 0
        '
        'BtnAddItemsToProdOrder
        '
        Me.BtnAddItemsToProdOrder.Location = New System.Drawing.Point(604, 430)
        Me.BtnAddItemsToProdOrder.Name = "BtnAddItemsToProdOrder"
        Me.BtnAddItemsToProdOrder.Size = New System.Drawing.Size(155, 43)
        Me.BtnAddItemsToProdOrder.TabIndex = 15
        Me.BtnAddItemsToProdOrder.Text = "Add Items To Order"
        Me.BtnAddItemsToProdOrder.UseVisualStyleBackColor = True
        '
        'UserControlProductOrderLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnAddItemsToProdOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlProductOrderLineItem"
        Me.Size = New System.Drawing.Size(768, 482)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewProdOrderLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProdOrderLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProdOrderId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtProdId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProdOrderLineItemId As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddItemsToProdOrder As System.Windows.Forms.Button

End Class
