<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSale
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
        Me.DataGridViewSales = New System.Windows.Forms.DataGridView()
        Me.BtnSaleInsert = New System.Windows.Forms.Button()
        Me.BtnSaleDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSales)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 402)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'DataGridViewSales
        '
        Me.DataGridViewSales.AllowUserToAddRows = False
        Me.DataGridViewSales.AllowUserToDeleteRows = False
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSales.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.RowTemplate.Height = 24
        Me.DataGridViewSales.Size = New System.Drawing.Size(437, 375)
        Me.DataGridViewSales.TabIndex = 0
        '
        'BtnSaleInsert
        '
        Me.BtnSaleInsert.Location = New System.Drawing.Point(513, 208)
        Me.BtnSaleInsert.Name = "BtnSaleInsert"
        Me.BtnSaleInsert.Size = New System.Drawing.Size(109, 46)
        Me.BtnSaleInsert.TabIndex = 5
        Me.BtnSaleInsert.Text = "Insert New Sale"
        Me.BtnSaleInsert.UseVisualStyleBackColor = True
        '
        'BtnSaleDelete
        '
        Me.BtnSaleDelete.Location = New System.Drawing.Point(513, 260)
        Me.BtnSaleDelete.Name = "BtnSaleDelete"
        Me.BtnSaleDelete.Size = New System.Drawing.Size(109, 46)
        Me.BtnSaleDelete.TabIndex = 6
        Me.BtnSaleDelete.Text = "Delete Selected Sale"
        Me.BtnSaleDelete.UseVisualStyleBackColor = True
        '
        'UserControlSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSaleDelete)
        Me.Controls.Add(Me.BtnSaleInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSale"
        Me.Size = New System.Drawing.Size(641, 408)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSaleInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSaleDelete As System.Windows.Forms.Button

End Class
