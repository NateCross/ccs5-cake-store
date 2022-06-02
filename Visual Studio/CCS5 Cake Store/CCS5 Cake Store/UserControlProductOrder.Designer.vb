<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProductOrder
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
        Me.DataGridViewProductOrder = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtProdOrderId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCustId = New System.Windows.Forms.TextBox()
        Me.BtnProdOrderInsert = New System.Windows.Forms.Button()
        Me.BtnProdOrderDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProductOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProductOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 383)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Orders"
        '
        'DataGridViewProductOrder
        '
        Me.DataGridViewProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductOrder.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewProductOrder.Name = "DataGridViewProductOrder"
        Me.DataGridViewProductOrder.RowTemplate.Height = 24
        Me.DataGridViewProductOrder.Size = New System.Drawing.Size(749, 252)
        Me.DataGridViewProductOrder.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnProdOrderDelete)
        Me.GroupBox2.Controls.Add(Me.BtnProdOrderInsert)
        Me.GroupBox2.Controls.Add(Me.TxtCustId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtProdOrderId)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtProdOrderId
        '
        Me.TxtProdOrderId.Location = New System.Drawing.Point(6, 45)
        Me.TxtProdOrderId.Name = "TxtProdOrderId"
        Me.TxtProdOrderId.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdOrderId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Order ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer ID"
        '
        'TxtCustId
        '
        Me.TxtCustId.Location = New System.Drawing.Point(146, 45)
        Me.TxtCustId.Name = "TxtCustId"
        Me.TxtCustId.Size = New System.Drawing.Size(100, 22)
        Me.TxtCustId.TabIndex = 3
        '
        'BtnProdOrderInsert
        '
        Me.BtnProdOrderInsert.Location = New System.Drawing.Point(497, 25)
        Me.BtnProdOrderInsert.Name = "BtnProdOrderInsert"
        Me.BtnProdOrderInsert.Size = New System.Drawing.Size(119, 42)
        Me.BtnProdOrderInsert.TabIndex = 6
        Me.BtnProdOrderInsert.Text = "Insert New Product Order"
        Me.BtnProdOrderInsert.UseVisualStyleBackColor = True
        '
        'BtnProdOrderDelete
        '
        Me.BtnProdOrderDelete.Location = New System.Drawing.Point(622, 25)
        Me.BtnProdOrderDelete.Name = "BtnProdOrderDelete"
        Me.BtnProdOrderDelete.Size = New System.Drawing.Size(121, 42)
        Me.BtnProdOrderDelete.TabIndex = 7
        Me.BtnProdOrderDelete.Text = "Delete Selected Product Order"
        Me.BtnProdOrderDelete.UseVisualStyleBackColor = True
        '
        'UserControlProductOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlProductOrder"
        Me.Size = New System.Drawing.Size(767, 383)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewProductOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProductOrder As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnProdOrderDelete As System.Windows.Forms.Button
    Friend WithEvents BtnProdOrderInsert As System.Windows.Forms.Button
    Friend WithEvents TxtCustId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtProdOrderId As System.Windows.Forms.TextBox

End Class
