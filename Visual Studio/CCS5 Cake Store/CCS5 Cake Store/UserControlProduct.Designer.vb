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
        Me.BtnProductDelete = New System.Windows.Forms.Button()
        Me.BtnProductCreate = New System.Windows.Forms.Button()
        Me.DataGridViewProduct = New System.Windows.Forms.DataGridView()
        Me.GroupBoxProduct.SuspendLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxProduct
        '
        Me.GroupBoxProduct.AutoSize = True
        Me.GroupBoxProduct.Controls.Add(Me.BtnProductDelete)
        Me.GroupBoxProduct.Controls.Add(Me.BtnProductCreate)
        Me.GroupBoxProduct.Controls.Add(Me.DataGridViewProduct)
        Me.GroupBoxProduct.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxProduct.Name = "GroupBoxProduct"
        Me.GroupBoxProduct.Size = New System.Drawing.Size(695, 428)
        Me.GroupBoxProduct.TabIndex = 0
        Me.GroupBoxProduct.TabStop = False
        Me.GroupBoxProduct.Text = "Product"
        '
        'BtnProductDelete
        '
        Me.BtnProductDelete.AutoSize = True
        Me.BtnProductDelete.Location = New System.Drawing.Point(533, 372)
        Me.BtnProductDelete.Name = "BtnProductDelete"
        Me.BtnProductDelete.Size = New System.Drawing.Size(156, 35)
        Me.BtnProductDelete.TabIndex = 2
        Me.BtnProductDelete.Text = "Delete Selected Row"
        Me.BtnProductDelete.UseVisualStyleBackColor = True
        '
        'BtnProductCreate
        '
        Me.BtnProductCreate.AutoSize = True
        Me.BtnProductCreate.Location = New System.Drawing.Point(426, 372)
        Me.BtnProductCreate.Name = "BtnProductCreate"
        Me.BtnProductCreate.Size = New System.Drawing.Size(101, 35)
        Me.BtnProductCreate.TabIndex = 1
        Me.BtnProductCreate.Text = "Create"
        Me.BtnProductCreate.UseVisualStyleBackColor = True
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
        'UserControlProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxProduct)
        Me.Name = "UserControlProduct"
        Me.Size = New System.Drawing.Size(701, 419)
        Me.GroupBoxProduct.ResumeLayout(False)
        Me.GroupBoxProduct.PerformLayout()
        CType(Me.DataGridViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxProduct As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProduct As System.Windows.Forms.DataGridView
    Friend WithEvents BtnProductDelete As System.Windows.Forms.Button
    Friend WithEvents BtnProductCreate As System.Windows.Forms.Button

End Class
