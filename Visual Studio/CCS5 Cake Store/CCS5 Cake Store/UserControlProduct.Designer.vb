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
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.BtnProductDelete = New System.Windows.Forms.Button()
        Me.BtnProductCreate = New System.Windows.Forms.Button()
        Me.TxtProdId = New System.Windows.Forms.TextBox()
        Me.Fields = New System.Windows.Forms.GroupBox()
        Me.BtnProdClear = New System.Windows.Forms.Button()
        Me.BtnProdUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProdQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProdSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProdName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxProduct.SuspendLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fields.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxProduct
        '
        Me.GroupBoxProduct.AutoSize = True
        Me.GroupBoxProduct.Controls.Add(Me.DataGridViewProduct)
        Me.GroupBoxProduct.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxProduct.Name = "GroupBoxProduct"
        Me.GroupBoxProduct.Size = New System.Drawing.Size(695, 407)
        Me.GroupBoxProduct.TabIndex = 0
        Me.GroupBoxProduct.TabStop = False
        Me.GroupBoxProduct.Text = "Product"
        '
        'DataGridViewProduct
        '
        Me.DataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduct.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewProduct.Name = "DataGridViewProduct"
        Me.DataGridViewProduct.RowTemplate.Height = 24
        Me.DataGridViewProduct.Size = New System.Drawing.Size(683, 345)
        Me.DataGridViewProduct.TabIndex = 0
        '
        'BtnProductDelete
        '
        Me.BtnProductDelete.AutoSize = True
        Me.BtnProductDelete.Location = New System.Drawing.Point(103, 302)
        Me.BtnProductDelete.Name = "BtnProductDelete"
        Me.BtnProductDelete.Size = New System.Drawing.Size(156, 35)
        Me.BtnProductDelete.TabIndex = 2
        Me.BtnProductDelete.Text = "Delete Selected Row"
        Me.BtnProductDelete.UseVisualStyleBackColor = True
        '
        'BtnProductCreate
        '
        Me.BtnProductCreate.AutoSize = True
        Me.BtnProductCreate.Location = New System.Drawing.Point(103, 261)
        Me.BtnProductCreate.Name = "BtnProductCreate"
        Me.BtnProductCreate.Size = New System.Drawing.Size(156, 35)
        Me.BtnProductCreate.TabIndex = 1
        Me.BtnProductCreate.Text = "Insert New Entry"
        Me.BtnProductCreate.UseVisualStyleBackColor = True
        '
        'TxtProdId
        '
        Me.TxtProdId.Location = New System.Drawing.Point(9, 50)
        Me.TxtProdId.Name = "TxtProdId"
        Me.TxtProdId.Size = New System.Drawing.Size(250, 22)
        Me.TxtProdId.TabIndex = 1
        '
        'Fields
        '
        Me.Fields.Controls.Add(Me.BtnProdClear)
        Me.Fields.Controls.Add(Me.BtnProdUpdate)
        Me.Fields.Controls.Add(Me.BtnProductDelete)
        Me.Fields.Controls.Add(Me.Label4)
        Me.Fields.Controls.Add(Me.BtnProductCreate)
        Me.Fields.Controls.Add(Me.TxtProdQty)
        Me.Fields.Controls.Add(Me.Label3)
        Me.Fields.Controls.Add(Me.TxtProdSellingPrice)
        Me.Fields.Controls.Add(Me.Label2)
        Me.Fields.Controls.Add(Me.TxtProdName)
        Me.Fields.Controls.Add(Me.Label1)
        Me.Fields.Controls.Add(Me.TxtProdId)
        Me.Fields.Location = New System.Drawing.Point(704, 3)
        Me.Fields.Name = "Fields"
        Me.Fields.Size = New System.Drawing.Size(265, 407)
        Me.Fields.TabIndex = 2
        Me.Fields.TabStop = False
        Me.Fields.Text = "Fields"
        '
        'BtnProdClear
        '
        Me.BtnProdClear.Location = New System.Drawing.Point(103, 372)
        Me.BtnProdClear.Name = "BtnProdClear"
        Me.BtnProdClear.Size = New System.Drawing.Size(156, 23)
        Me.BtnProdClear.TabIndex = 10
        Me.BtnProdClear.Text = "Clear Fields"
        Me.BtnProdClear.UseVisualStyleBackColor = True
        '
        'BtnProdUpdate
        '
        Me.BtnProdUpdate.Location = New System.Drawing.Point(103, 343)
        Me.BtnProdUpdate.Name = "BtnProdUpdate"
        Me.BtnProdUpdate.Size = New System.Drawing.Size(156, 23)
        Me.BtnProdUpdate.TabIndex = 9
        Me.BtnProdUpdate.Text = "Update Selected Row"
        Me.BtnProdUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity*"
        '
        'TxtProdQty
        '
        Me.TxtProdQty.Location = New System.Drawing.Point(9, 212)
        Me.TxtProdQty.Name = "TxtProdQty"
        Me.TxtProdQty.Size = New System.Drawing.Size(250, 22)
        Me.TxtProdQty.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Selling Price*"
        '
        'TxtProdSellingPrice
        '
        Me.TxtProdSellingPrice.Location = New System.Drawing.Point(9, 157)
        Me.TxtProdSellingPrice.Name = "TxtProdSellingPrice"
        Me.TxtProdSellingPrice.Size = New System.Drawing.Size(250, 22)
        Me.TxtProdSellingPrice.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Name*"
        '
        'TxtProdName
        '
        Me.TxtProdName.Location = New System.Drawing.Point(9, 100)
        Me.TxtProdName.Name = "TxtProdName"
        Me.TxtProdName.Size = New System.Drawing.Size(250, 22)
        Me.TxtProdName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product ID*"
        '
        'UserControlProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Fields)
        Me.Controls.Add(Me.GroupBoxProduct)
        Me.Name = "UserControlProduct"
        Me.Size = New System.Drawing.Size(972, 419)
        Me.GroupBoxProduct.ResumeLayout(False)
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fields.ResumeLayout(False)
        Me.Fields.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxProduct As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProduct As System.Windows.Forms.DataGridView
    Friend WithEvents BtnProductDelete As System.Windows.Forms.Button
    Friend WithEvents BtnProductCreate As System.Windows.Forms.Button
    Friend WithEvents TxtProdId As System.Windows.Forms.TextBox
    Friend WithEvents Fields As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProdName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtProdSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProdQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnProdUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnProdClear As System.Windows.Forms.Button

End Class
