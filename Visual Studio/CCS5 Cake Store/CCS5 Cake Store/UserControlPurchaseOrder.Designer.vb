<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlPurchaseOrder
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
        Me.DataGridViewPurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPurchaseOrderUpdate = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderDelete = New System.Windows.Forms.Button()
        Me.BtnPurchaseOrderInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerPurchaseOrder = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridViewPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewPurchaseOrder
        '
        Me.DataGridViewPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchaseOrder.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewPurchaseOrder.Name = "DataGridViewPurchaseOrder"
        Me.DataGridViewPurchaseOrder.RowTemplate.Height = 24
        Me.DataGridViewPurchaseOrder.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewPurchaseOrder.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderDelete)
        Me.GroupBox1.Controls.Add(Me.BtnPurchaseOrderInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPurchaseOrder)
        Me.GroupBox1.Controls.Add(Me.DataGridViewPurchaseOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 474)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Orders"
        '
        'BtnPurchaseOrderUpdate
        '
        Me.BtnPurchaseOrderUpdate.Location = New System.Drawing.Point(395, 445)
        Me.BtnPurchaseOrderUpdate.Name = "BtnPurchaseOrderUpdate"
        Me.BtnPurchaseOrderUpdate.Size = New System.Drawing.Size(233, 23)
        Me.BtnPurchaseOrderUpdate.TabIndex = 5
        Me.BtnPurchaseOrderUpdate.Text = "Update Selected Purchase Order"
        Me.BtnPurchaseOrderUpdate.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderDelete
        '
        Me.BtnPurchaseOrderDelete.Location = New System.Drawing.Point(395, 416)
        Me.BtnPurchaseOrderDelete.Name = "BtnPurchaseOrderDelete"
        Me.BtnPurchaseOrderDelete.Size = New System.Drawing.Size(233, 23)
        Me.BtnPurchaseOrderDelete.TabIndex = 4
        Me.BtnPurchaseOrderDelete.Text = "Delete Selected Purchase Order"
        Me.BtnPurchaseOrderDelete.UseVisualStyleBackColor = True
        '
        'BtnPurchaseOrderInsert
        '
        Me.BtnPurchaseOrderInsert.Location = New System.Drawing.Point(395, 387)
        Me.BtnPurchaseOrderInsert.Name = "BtnPurchaseOrderInsert"
        Me.BtnPurchaseOrderInsert.Size = New System.Drawing.Size(233, 23)
        Me.BtnPurchaseOrderInsert.TabIndex = 3
        Me.BtnPurchaseOrderInsert.Text = "Insert New Purchase Order"
        Me.BtnPurchaseOrderInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Due Date"
        '
        'DateTimePickerPurchaseOrder
        '
        Me.DateTimePickerPurchaseOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPurchaseOrder.Location = New System.Drawing.Point(40, 420)
        Me.DateTimePickerPurchaseOrder.Name = "DateTimePickerPurchaseOrder"
        Me.DateTimePickerPurchaseOrder.Size = New System.Drawing.Size(229, 22)
        Me.DateTimePickerPurchaseOrder.TabIndex = 1
        '
        'UserControlPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlPurchaseOrder"
        Me.Size = New System.Drawing.Size(640, 480)
        CType(Me.DataGridViewPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewPurchaseOrder As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPurchaseOrderInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPurchaseOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPurchaseOrderDelete As System.Windows.Forms.Button
    Friend WithEvents BtnPurchaseOrderUpdate As System.Windows.Forms.Button

End Class
