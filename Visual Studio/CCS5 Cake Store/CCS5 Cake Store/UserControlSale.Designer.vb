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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSaleId = New System.Windows.Forms.TextBox()
        Me.TxtCustId = New System.Windows.Forms.TextBox()
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
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSales.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.RowTemplate.Height = 24
        Me.DataGridViewSales.Size = New System.Drawing.Size(437, 375)
        Me.DataGridViewSales.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sale ID"
        '
        'TxtSaleId
        '
        Me.TxtSaleId.Location = New System.Drawing.Point(475, 44)
        Me.TxtSaleId.Name = "TxtSaleId"
        Me.TxtSaleId.Size = New System.Drawing.Size(100, 22)
        Me.TxtSaleId.TabIndex = 3
        '
        'TxtCustId
        '
        Me.TxtCustId.Location = New System.Drawing.Point(475, 107)
        Me.TxtCustId.Name = "TxtCustId"
        Me.TxtCustId.Size = New System.Drawing.Size(100, 22)
        Me.TxtCustId.TabIndex = 4
        '
        'BtnSaleInsert
        '
        Me.BtnSaleInsert.Location = New System.Drawing.Point(513, 199)
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
        Me.Controls.Add(Me.TxtCustId)
        Me.Controls.Add(Me.TxtSaleId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSale"
        Me.Size = New System.Drawing.Size(641, 408)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSales As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSaleId As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustId As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaleInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSaleDelete As System.Windows.Forms.Button

End Class
