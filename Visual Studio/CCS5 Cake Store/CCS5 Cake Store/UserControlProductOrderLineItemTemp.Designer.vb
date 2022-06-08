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
        Me.DataGridViewProdOrderLineItem = New System.Windows.Forms.DataGridView()
        Me.BtnAddItemsToProdOrder = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProdOrderLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAddItemsToProdOrder)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnInsert)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtQty)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProdOrderLineItem)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Items"
        '
        'DataGridViewProdOrderLineItem
        '
        Me.DataGridViewProdOrderLineItem.AllowUserToAddRows = False
        Me.DataGridViewProdOrderLineItem.AllowUserToDeleteRows = False
        Me.DataGridViewProdOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProdOrderLineItem.Location = New System.Drawing.Point(4, 40)
        Me.DataGridViewProdOrderLineItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewProdOrderLineItem.Name = "DataGridViewProdOrderLineItem"
        Me.DataGridViewProdOrderLineItem.RowTemplate.Height = 24
        Me.DataGridViewProdOrderLineItem.Size = New System.Drawing.Size(450, 400)
        Me.DataGridViewProdOrderLineItem.TabIndex = 0
        '
        'BtnAddItemsToProdOrder
        '
        Me.BtnAddItemsToProdOrder.Location = New System.Drawing.Point(490, 235)
        Me.BtnAddItemsToProdOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddItemsToProdOrder.Name = "BtnAddItemsToProdOrder"
        Me.BtnAddItemsToProdOrder.Size = New System.Drawing.Size(110, 40)
        Me.BtnAddItemsToProdOrder.TabIndex = 21
        Me.BtnAddItemsToProdOrder.Text = "Add Items To Order"
        Me.BtnAddItemsToProdOrder.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(490, 191)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(110, 40)
        Me.BtnUpdate.TabIndex = 20
        Me.BtnUpdate.Text = "Update Selected Row"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(490, 147)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 40)
        Me.BtnDelete.TabIndex = 19
        Me.BtnDelete.Text = "Delete Selected Row"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(490, 103)
        Me.BtnInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(110, 40)
        Me.BtnInsert.TabIndex = 18
        Me.BtnInsert.Text = "Insert New Line Item"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(467, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(470, 55)
        Me.TxtQty.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(150, 20)
        Me.TxtQty.TabIndex = 16
        '
        'UserControlProductOrderLineItemTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UserControlProductOrderLineItemTemp"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewProdOrderLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProdOrderLineItem As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAddItemsToProdOrder As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox

End Class
