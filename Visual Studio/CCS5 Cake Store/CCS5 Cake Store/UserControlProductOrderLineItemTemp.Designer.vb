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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Controls.Add(Me.BtnAddItemsToProdOrder)
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtQty)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.BtnAddItemsToProdOrder.Location = New System.Drawing.Point(595, 127)
        Me.BtnAddItemsToProdOrder.Name = "BtnAddItemsToProdOrder"
        Me.BtnAddItemsToProdOrder.Size = New System.Drawing.Size(155, 32)
        Me.BtnAddItemsToProdOrder.TabIndex = 15
        Me.BtnAddItemsToProdOrder.Text = "Add Items To Order"
        Me.BtnAddItemsToProdOrder.UseVisualStyleBackColor = True
        '
        'UserControlProductOrderLineItemTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlProductOrderLineItemTemp"
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
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddItemsToProdOrder As System.Windows.Forms.Button

End Class
