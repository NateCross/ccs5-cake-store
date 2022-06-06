<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplyUsage
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
        Me.DataGridViewSupplyUsage = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtSupplyUsageProdQtyAdded = New System.Windows.Forms.TextBox()
        Me.BtnSupplyUsageDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyUsage)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Usage"
        '
        'DataGridViewSupplyUsage
        '
        Me.DataGridViewSupplyUsage.AllowUserToAddRows = False
        Me.DataGridViewSupplyUsage.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyUsage.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSupplyUsage.Name = "DataGridViewSupplyUsage"
        Me.DataGridViewSupplyUsage.RowTemplate.Height = 24
        Me.DataGridViewSupplyUsage.Size = New System.Drawing.Size(622, 333)
        Me.DataGridViewSupplyUsage.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSupplyUsageProdQtyAdded)
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageDelete)
        Me.GroupBox2.Controls.Add(Me.BtnSupplyUsageInsert)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 114)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtSupplyUsageProdQtyAdded
        '
        Me.TxtSupplyUsageProdQtyAdded.Location = New System.Drawing.Point(28, 54)
        Me.TxtSupplyUsageProdQtyAdded.Name = "TxtSupplyUsageProdQtyAdded"
        Me.TxtSupplyUsageProdQtyAdded.Size = New System.Drawing.Size(100, 22)
        Me.TxtSupplyUsageProdQtyAdded.TabIndex = 16
        '
        'BtnSupplyUsageDelete
        '
        Me.BtnSupplyUsageDelete.Location = New System.Drawing.Point(383, 68)
        Me.BtnSupplyUsageDelete.Name = "BtnSupplyUsageDelete"
        Me.BtnSupplyUsageDelete.Size = New System.Drawing.Size(233, 40)
        Me.BtnSupplyUsageDelete.TabIndex = 14
        Me.BtnSupplyUsageDelete.Text = "Delete Selected Supply Usage"
        Me.BtnSupplyUsageDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageInsert
        '
        Me.BtnSupplyUsageInsert.Location = New System.Drawing.Point(383, 21)
        Me.BtnSupplyUsageInsert.Name = "BtnSupplyUsageInsert"
        Me.BtnSupplyUsageInsert.Size = New System.Drawing.Size(233, 41)
        Me.BtnSupplyUsageInsert.TabIndex = 13
        Me.BtnSupplyUsageInsert.Text = "Insert New Supply Usage"
        Me.BtnSupplyUsageInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Product Quantity Added"
        '
        'UserControlSupplyUsage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplyUsage"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSupplyUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyUsage As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSupplyUsageProdQtyAdded As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplyUsageDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
