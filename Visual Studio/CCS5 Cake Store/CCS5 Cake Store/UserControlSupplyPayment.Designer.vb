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
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(446, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Payments"
        '
        'TxtSupplyPaymentAmountPaid
        '
        Me.TxtSupplyPaymentAmountPaid.Location = New System.Drawing.Point(50, 343)
        Me.TxtSupplyPaymentAmountPaid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSupplyPaymentAmountPaid.Name = "TxtSupplyPaymentAmountPaid"
        Me.TxtSupplyPaymentAmountPaid.Size = New System.Drawing.Size(175, 20)
        Me.TxtSupplyPaymentAmountPaid.TabIndex = 16
        '
        'BtnSupplyPaymentUpdate
        '
        Me.BtnSupplyPaymentUpdate.Location = New System.Drawing.Point(267, 419)
        Me.BtnSupplyPaymentUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSupplyPaymentUpdate.Name = "BtnSupplyPaymentUpdate"
        Me.BtnSupplyPaymentUpdate.Size = New System.Drawing.Size(175, 50)
        Me.BtnSupplyPaymentUpdate.TabIndex = 15
        Me.BtnSupplyPaymentUpdate.Text = "Update Selected Supply Payment"
        Me.BtnSupplyPaymentUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyPaymentDelete
        '
        Me.BtnSupplyPaymentDelete.Location = New System.Drawing.Point(267, 365)
        Me.BtnSupplyPaymentDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSupplyPaymentDelete.Name = "BtnSupplyPaymentDelete"
        Me.BtnSupplyPaymentDelete.Size = New System.Drawing.Size(175, 50)
        Me.BtnSupplyPaymentDelete.TabIndex = 14
        Me.BtnSupplyPaymentDelete.Text = "Delete Selected Supply Payment"
        Me.BtnSupplyPaymentDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyPaymentInsert
        '
        Me.BtnSupplyPaymentInsert.Location = New System.Drawing.Point(267, 311)
        Me.BtnSupplyPaymentInsert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSupplyPaymentInsert.Name = "BtnSupplyPaymentInsert"
        Me.BtnSupplyPaymentInsert.Size = New System.Drawing.Size(175, 50)
        Me.BtnSupplyPaymentInsert.TabIndex = 13
        Me.BtnSupplyPaymentInsert.Text = "Insert New Supply Payment"
        Me.BtnSupplyPaymentInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 328)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Amount Paid"
        '
        'DataGridViewSupplyPayment
        '
        Me.DataGridViewSupplyPayment.AllowUserToAddRows = False
        Me.DataGridViewSupplyPayment.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyPayment.Location = New System.Drawing.Point(4, 17)
        Me.DataGridViewSupplyPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewSupplyPayment.Name = "DataGridViewSupplyPayment"
        Me.DataGridViewSupplyPayment.RowTemplate.Height = 24
        Me.DataGridViewSupplyPayment.Size = New System.Drawing.Size(438, 290)
        Me.DataGridViewSupplyPayment.TabIndex = 0
        '
        'UserControlSupplyPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UserControlSupplyPayment"
        Me.Size = New System.Drawing.Size(450, 480)
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
