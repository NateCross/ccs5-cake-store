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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnProdOrderDelete = New System.Windows.Forms.Button()
        Me.BtnProdOrderInsert = New System.Windows.Forms.Button()
        Me.DataGridViewProductOrder = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerProdOrderDueDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelDueDate = New System.Windows.Forms.Label()
        Me.BtnProdOrderUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewProductOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnProdOrderUpdate)
        Me.GroupBox2.Controls.Add(Me.LabelDueDate)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerProdOrderDueDate)
        Me.GroupBox2.Controls.Add(Me.BtnProdOrderDelete)
        Me.GroupBox2.Controls.Add(Me.BtnProdOrderInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BtnProdOrderDelete
        '
        Me.BtnProdOrderDelete.Location = New System.Drawing.Point(489, 25)
        Me.BtnProdOrderDelete.Name = "BtnProdOrderDelete"
        Me.BtnProdOrderDelete.Size = New System.Drawing.Size(121, 42)
        Me.BtnProdOrderDelete.TabIndex = 7
        Me.BtnProdOrderDelete.Text = "Delete Selected Product Order"
        Me.BtnProdOrderDelete.UseVisualStyleBackColor = True
        '
        'BtnProdOrderInsert
        '
        Me.BtnProdOrderInsert.Location = New System.Drawing.Point(364, 25)
        Me.BtnProdOrderInsert.Name = "BtnProdOrderInsert"
        Me.BtnProdOrderInsert.Size = New System.Drawing.Size(119, 42)
        Me.BtnProdOrderInsert.TabIndex = 6
        Me.BtnProdOrderInsert.Text = "Insert New Product Order"
        Me.BtnProdOrderInsert.UseVisualStyleBackColor = True
        '
        'DataGridViewProductOrder
        '
        Me.DataGridViewProductOrder.AllowUserToAddRows = False
        Me.DataGridViewProductOrder.AllowUserToDeleteRows = False
        Me.DataGridViewProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductOrder.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewProductOrder.Name = "DataGridViewProductOrder"
        Me.DataGridViewProductOrder.RowTemplate.Height = 24
        Me.DataGridViewProductOrder.Size = New System.Drawing.Size(749, 252)
        Me.DataGridViewProductOrder.TabIndex = 0
        '
        'DateTimePickerProdOrderDueDate
        '
        Me.DateTimePickerProdOrderDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerProdOrderDueDate.Location = New System.Drawing.Point(53, 38)
        Me.DateTimePickerProdOrderDueDate.Name = "DateTimePickerProdOrderDueDate"
        Me.DateTimePickerProdOrderDueDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerProdOrderDueDate.TabIndex = 8
        '
        'LabelDueDate
        '
        Me.LabelDueDate.AutoSize = True
        Me.LabelDueDate.Location = New System.Drawing.Point(50, 18)
        Me.LabelDueDate.Name = "LabelDueDate"
        Me.LabelDueDate.Size = New System.Drawing.Size(123, 17)
        Me.LabelDueDate.TabIndex = 9
        Me.LabelDueDate.Text = "Delivery Due Date"
        '
        'BtnProdOrderUpdate
        '
        Me.BtnProdOrderUpdate.Location = New System.Drawing.Point(616, 25)
        Me.BtnProdOrderUpdate.Name = "BtnProdOrderUpdate"
        Me.BtnProdOrderUpdate.Size = New System.Drawing.Size(121, 42)
        Me.BtnProdOrderUpdate.TabIndex = 10
        Me.BtnProdOrderUpdate.Text = "Update Selected Product Order"
        Me.BtnProdOrderUpdate.UseVisualStyleBackColor = True
        '
        'UserControlProductOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlProductOrder"
        Me.Size = New System.Drawing.Size(767, 383)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewProductOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProductOrder As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnProdOrderDelete As System.Windows.Forms.Button
    Friend WithEvents BtnProdOrderInsert As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerProdOrderDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelDueDate As System.Windows.Forms.Label
    Friend WithEvents BtnProdOrderUpdate As System.Windows.Forms.Button

End Class
