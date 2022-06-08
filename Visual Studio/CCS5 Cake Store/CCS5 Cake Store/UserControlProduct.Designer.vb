<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProduct
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
        Me.GroupBoxProduct = New System.Windows.Forms.GroupBox()
        Me.BtnProdClear = New System.Windows.Forms.Button()
        Me.BtnProdUpdate = New System.Windows.Forms.Button()
        Me.BtnProductDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnProductCreate = New System.Windows.Forms.Button()
        Me.TxtProdQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProdSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProdName = New System.Windows.Forms.TextBox()
        Me.TxtProdNameSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.GroupBoxProduct.SuspendLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxProduct
        '
        Me.GroupBoxProduct.AutoSize = True
        Me.GroupBoxProduct.Controls.Add(Me.BtnProdClear)
        Me.GroupBoxProduct.Controls.Add(Me.BtnProdUpdate)
        Me.GroupBoxProduct.Controls.Add(Me.BtnProductDelete)
        Me.GroupBoxProduct.Controls.Add(Me.Label4)
        Me.GroupBoxProduct.Controls.Add(Me.BtnProductCreate)
        Me.GroupBoxProduct.Controls.Add(Me.TxtProdQty)
        Me.GroupBoxProduct.Controls.Add(Me.Label3)
        Me.GroupBoxProduct.Controls.Add(Me.TxtProdSellingPrice)
        Me.GroupBoxProduct.Controls.Add(Me.Label2)
        Me.GroupBoxProduct.Controls.Add(Me.TxtProdName)
        Me.GroupBoxProduct.Controls.Add(Me.TxtProdNameSearch)
        Me.GroupBoxProduct.Controls.Add(Me.Label1)
        Me.GroupBoxProduct.Controls.Add(Me.DataGridViewProduct)
        Me.GroupBoxProduct.Location = New System.Drawing.Point(3, 2)
        Me.GroupBoxProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxProduct.Name = "GroupBoxProduct"
        Me.GroupBoxProduct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxProduct.Size = New System.Drawing.Size(955, 562)
        Me.GroupBoxProduct.TabIndex = 0
        Me.GroupBoxProduct.TabStop = False
        Me.GroupBoxProduct.Text = "Product"
        '
        'BtnProdClear
        '
        Me.BtnProdClear.Location = New System.Drawing.Point(739, 405)
        Me.BtnProdClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProdClear.Name = "BtnProdClear"
        Me.BtnProdClear.Size = New System.Drawing.Size(161, 49)
        Me.BtnProdClear.TabIndex = 20
        Me.BtnProdClear.Text = "Clear Fields"
        Me.BtnProdClear.UseVisualStyleBackColor = True
        '
        'BtnProdUpdate
        '
        Me.BtnProdUpdate.Location = New System.Drawing.Point(739, 343)
        Me.BtnProdUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProdUpdate.Name = "BtnProdUpdate"
        Me.BtnProdUpdate.Size = New System.Drawing.Size(161, 49)
        Me.BtnProdUpdate.TabIndex = 19
        Me.BtnProdUpdate.Text = "Update Selected Row"
        Me.BtnProdUpdate.UseVisualStyleBackColor = True
        '
        'BtnProductDelete
        '
        Me.BtnProductDelete.AutoSize = True
        Me.BtnProductDelete.Location = New System.Drawing.Point(739, 282)
        Me.BtnProductDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProductDelete.Name = "BtnProductDelete"
        Me.BtnProductDelete.Size = New System.Drawing.Size(161, 49)
        Me.BtnProductDelete.TabIndex = 12
        Me.BtnProductDelete.Text = "Delete Selected Row"
        Me.BtnProductDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(719, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Quantity"
        '
        'BtnProductCreate
        '
        Me.BtnProductCreate.AutoSize = True
        Me.BtnProductCreate.Location = New System.Drawing.Point(739, 220)
        Me.BtnProductCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProductCreate.Name = "BtnProductCreate"
        Me.BtnProductCreate.Size = New System.Drawing.Size(161, 49)
        Me.BtnProductCreate.TabIndex = 11
        Me.BtnProductCreate.Text = "Insert New Entry"
        Me.BtnProductCreate.UseVisualStyleBackColor = True
        '
        'TxtProdQty
        '
        Me.TxtProdQty.Location = New System.Drawing.Point(719, 178)
        Me.TxtProdQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProdQty.Name = "TxtProdQty"
        Me.TxtProdQty.Size = New System.Drawing.Size(199, 22)
        Me.TxtProdQty.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(719, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Selling Price"
        '
        'TxtProdSellingPrice
        '
        Me.TxtProdSellingPrice.Location = New System.Drawing.Point(719, 123)
        Me.TxtProdSellingPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProdSellingPrice.Name = "TxtProdSellingPrice"
        Me.TxtProdSellingPrice.Size = New System.Drawing.Size(199, 22)
        Me.TxtProdSellingPrice.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(719, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Product Name"
        '
        'TxtProdName
        '
        Me.TxtProdName.Location = New System.Drawing.Point(719, 68)
        Me.TxtProdName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProdName.Name = "TxtProdName"
        Me.TxtProdName.Size = New System.Drawing.Size(199, 22)
        Me.TxtProdName.TabIndex = 13
        '
        'TxtProdNameSearch
        '
        Me.TxtProdNameSearch.Location = New System.Drawing.Point(171, 18)
        Me.TxtProdNameSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProdNameSearch.Name = "TxtProdNameSearch"
        Me.TxtProdNameSearch.Size = New System.Drawing.Size(500, 22)
        Me.TxtProdNameSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Product Names:"
        '
        'DataGridViewProduct
        '
        Me.DataGridViewProduct.AllowUserToAddRows = False
        Me.DataGridViewProduct.AllowUserToDeleteRows = False
        Me.DataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduct.Location = New System.Drawing.Point(5, 49)
        Me.DataGridViewProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewProduct.Name = "DataGridViewProduct"
        Me.DataGridViewProduct.RowTemplate.Height = 24
        Me.DataGridViewProduct.Size = New System.Drawing.Size(667, 492)
        Me.DataGridViewProduct.TabIndex = 0
        '
        'UserControlProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxProduct)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserControlProduct"
        Me.Size = New System.Drawing.Size(960, 566)
        Me.GroupBoxProduct.ResumeLayout(False)
        Me.GroupBoxProduct.PerformLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxProduct As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProduct As System.Windows.Forms.DataGridView
    Friend WithEvents TxtProdNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnProdClear As System.Windows.Forms.Button
    Friend WithEvents BtnProdUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnProductDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnProductCreate As System.Windows.Forms.Button
    Friend WithEvents TxtProdQty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProdSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtProdName As System.Windows.Forms.TextBox

End Class
