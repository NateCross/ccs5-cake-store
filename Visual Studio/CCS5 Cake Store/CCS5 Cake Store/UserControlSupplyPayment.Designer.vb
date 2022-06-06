<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplyPayment
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
        Me.TxtSupplyPaymentAmountPaid = New System.Windows.Forms.TextBox()
        Me.BtnSupplyPaymentUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplyPaymentDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyPaymentInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewSupplyPayment = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSupplyPaymentAmountPaid)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyPaymentUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyPaymentDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyPaymentInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyPayment)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Payments"
        '
        'TxtSupplyPaymentAmountPaid
        '
        Me.TxtSupplyPaymentAmountPaid.Location = New System.Drawing.Point(40, 416)
        Me.TxtSupplyPaymentAmountPaid.Name = "TxtSupplyPaymentAmountPaid"
        Me.TxtSupplyPaymentAmountPaid.Size = New System.Drawing.Size(100, 22)
        Me.TxtSupplyPaymentAmountPaid.TabIndex = 16
        '
        'BtnSupplyPaymentUpdate
        '
        Me.BtnSupplyPaymentUpdate.Location = New System.Drawing.Point(395, 445)
        Me.BtnSupplyPaymentUpdate.Name = "BtnSupplyPaymentUpdate"
        Me.BtnSupplyPaymentUpdate.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyPaymentUpdate.TabIndex = 15
        Me.BtnSupplyPaymentUpdate.Text = "Update Selected Supply Payment"
        Me.BtnSupplyPaymentUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyPaymentDelete
        '
        Me.BtnSupplyPaymentDelete.Location = New System.Drawing.Point(395, 416)
        Me.BtnSupplyPaymentDelete.Name = "BtnSupplyPaymentDelete"
        Me.BtnSupplyPaymentDelete.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyPaymentDelete.TabIndex = 14
        Me.BtnSupplyPaymentDelete.Text = "Delete Selected Supply Payment"
        Me.BtnSupplyPaymentDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyPaymentInsert
        '
        Me.BtnSupplyPaymentInsert.Location = New System.Drawing.Point(395, 387)
        Me.BtnSupplyPaymentInsert.Name = "BtnSupplyPaymentInsert"
        Me.BtnSupplyPaymentInsert.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyPaymentInsert.TabIndex = 13
        Me.BtnSupplyPaymentInsert.Text = "Insert New Supply Payment"
        Me.BtnSupplyPaymentInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Amount Paid"
        '
        'DataGridViewSupplyPayment
        '
        Me.DataGridViewSupplyPayment.AllowUserToAddRows = False
        Me.DataGridViewSupplyPayment.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyPayment.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSupplyPayment.Name = "DataGridViewSupplyPayment"
        Me.DataGridViewSupplyPayment.RowTemplate.Height = 24
        Me.DataGridViewSupplyPayment.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewSupplyPayment.TabIndex = 0
        '
        'UserControlSupplyPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplyPayment"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplyPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyPayment As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplyPaymentAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplyPaymentUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyPaymentDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyPaymentInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
