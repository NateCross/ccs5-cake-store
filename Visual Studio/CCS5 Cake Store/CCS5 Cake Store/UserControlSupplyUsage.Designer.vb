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
        Me.TxtSupplyUsageProdQtyAdded = New System.Windows.Forms.TextBox()
        Me.BtnSupplyUsageDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyUsageInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSupplyUsageProdQtyAdded)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUsageInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyUsage)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Usage"
        '
        'DataGridViewSupplyUsage
        '
        Me.DataGridViewSupplyUsage.AllowUserToAddRows = False
        Me.DataGridViewSupplyUsage.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyUsage.Location = New System.Drawing.Point(4, 17)
        Me.DataGridViewSupplyUsage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewSupplyUsage.Name = "DataGridViewSupplyUsage"
        Me.DataGridViewSupplyUsage.RowTemplate.Height = 24
        Me.DataGridViewSupplyUsage.Size = New System.Drawing.Size(466, 325)
        Me.DataGridViewSupplyUsage.TabIndex = 0
        '
        'TxtSupplyUsageProdQtyAdded
        '
        Me.TxtSupplyUsageProdQtyAdded.Location = New System.Drawing.Point(60, 380)
        Me.TxtSupplyUsageProdQtyAdded.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSupplyUsageProdQtyAdded.Name = "TxtSupplyUsageProdQtyAdded"
        Me.TxtSupplyUsageProdQtyAdded.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplyUsageProdQtyAdded.TabIndex = 20
        '
        'BtnSupplyUsageDelete
        '
        Me.BtnSupplyUsageDelete.Location = New System.Drawing.Point(295, 400)
        Me.BtnSupplyUsageDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageDelete.Name = "BtnSupplyUsageDelete"
        Me.BtnSupplyUsageDelete.Size = New System.Drawing.Size(175, 50)
        Me.BtnSupplyUsageDelete.TabIndex = 19
        Me.BtnSupplyUsageDelete.Text = "Delete Selected Supply Usage"
        Me.BtnSupplyUsageDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyUsageInsert
        '
        Me.BtnSupplyUsageInsert.Location = New System.Drawing.Point(295, 346)
        Me.BtnSupplyUsageInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUsageInsert.Name = "BtnSupplyUsageInsert"
        Me.BtnSupplyUsageInsert.Size = New System.Drawing.Size(175, 50)
        Me.BtnSupplyUsageInsert.TabIndex = 18
        Me.BtnSupplyUsageInsert.Text = "Insert New Supply Usage"
        Me.BtnSupplyUsageInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 365)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Product Quantity Added"
        '
        'UserControlSupplyUsage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UserControlSupplyUsage"
        Me.Size = New System.Drawing.Size(480, 460)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplyUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyUsage As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplyUsageProdQtyAdded As System.Windows.Forms.TextBox
    Friend WithEvents BtnSupplyUsageDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUsageInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
