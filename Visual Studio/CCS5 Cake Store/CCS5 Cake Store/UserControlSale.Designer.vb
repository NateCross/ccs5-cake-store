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
        Me.BtnSaleDelete = New System.Windows.Forms.Button()
        Me.BtnSaleInsert = New System.Windows.Forms.Button()
        Me.DataGridViewSales = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSaleDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSaleInsert)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSales)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'BtnSaleDelete
        '
        Me.BtnSaleDelete.Location = New System.Drawing.Point(522, 208)
        Me.BtnSaleDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaleDelete.Name = "BtnSaleDelete"
        Me.BtnSaleDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnSaleDelete.TabIndex = 8
        Me.BtnSaleDelete.Text = "Delete Selected Sale"
        Me.BtnSaleDelete.UseVisualStyleBackColor = True
        '
        'BtnSaleInsert
        '
        Me.BtnSaleInsert.Location = New System.Drawing.Point(522, 154)
        Me.BtnSaleInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaleInsert.Name = "BtnSaleInsert"
        Me.BtnSaleInsert.Size = New System.Drawing.Size(100, 40)
        Me.BtnSaleInsert.TabIndex = 7
        Me.BtnSaleInsert.Text = "Insert New Sale"
        Me.BtnSaleInsert.UseVisualStyleBackColor = True
        '
        'DataGridViewSales
        '
        Me.DataGridViewSales.AllowUserToAddRows = False
        Me.DataGridViewSales.AllowUserToDeleteRows = False
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSales.Location = New System.Drawing.Point(4, 37)
        Me.DataGridViewSales.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.RowTemplate.Height = 24
        Me.DataGridViewSales.Size = New System.Drawing.Size(500, 400)
        Me.DataGridViewSales.TabIndex = 0
        '
        'UserControlSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UserControlSale"
        Me.Size = New System.Drawing.Size(640, 460)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSaleDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSaleInsert As System.Windows.Forms.Button

End Class
