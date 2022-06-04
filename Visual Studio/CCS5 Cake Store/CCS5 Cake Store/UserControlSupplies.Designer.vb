<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplies
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
        Me.DataGridViewSupplies = New System.Windows.Forms.DataGridView()
        Me.TxtSupplyId = New System.Windows.Forms.TextBox()
        Me.TxtSupplyName = New System.Windows.Forms.TextBox()
        Me.TxtSupplyQty = New System.Windows.Forms.TextBox()
        Me.TxtSupplyUnitOfMeasurement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSupplyInsert = New System.Windows.Forms.Button()
        Me.BtnSupplyDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplies)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplies"
        '
        'DataGridViewSupplies
        '
        Me.DataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplies.Location = New System.Drawing.Point(0, 14)
        Me.DataGridViewSupplies.Name = "DataGridViewSupplies"
        Me.DataGridViewSupplies.Size = New System.Drawing.Size(450, 339)
        Me.DataGridViewSupplies.TabIndex = 0
        '
        'TxtSupplyId
        '
        Me.TxtSupplyId.Location = New System.Drawing.Point(490, 68)
        Me.TxtSupplyId.Name = "TxtSupplyId"
        Me.TxtSupplyId.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplyId.TabIndex = 1
        '
        'TxtSupplyName
        '
        Me.TxtSupplyName.Location = New System.Drawing.Point(490, 123)
        Me.TxtSupplyName.Name = "TxtSupplyName"
        Me.TxtSupplyName.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplyName.TabIndex = 2
        '
        'TxtSupplyQty
        '
        Me.TxtSupplyQty.Location = New System.Drawing.Point(490, 190)
        Me.TxtSupplyQty.Name = "TxtSupplyQty"
        Me.TxtSupplyQty.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplyQty.TabIndex = 3
        '
        'TxtSupplyUnitOfMeasurement
        '
        Me.TxtSupplyUnitOfMeasurement.Location = New System.Drawing.Point(490, 253)
        Me.TxtSupplyUnitOfMeasurement.Name = "TxtSupplyUnitOfMeasurement"
        Me.TxtSupplyUnitOfMeasurement.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplyUnitOfMeasurement.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Supply ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(487, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Unit of Measurement"
        '
        'BtnSupplyInsert
        '
        Me.BtnSupplyInsert.Location = New System.Drawing.Point(630, 112)
        Me.BtnSupplyInsert.Name = "BtnSupplyInsert"
        Me.BtnSupplyInsert.Size = New System.Drawing.Size(100, 41)
        Me.BtnSupplyInsert.TabIndex = 9
        Me.BtnSupplyInsert.Text = "Insert New Supply"
        Me.BtnSupplyInsert.UseVisualStyleBackColor = True
        '
        'BtnSupplyDelete
        '
        Me.BtnSupplyDelete.Location = New System.Drawing.Point(630, 190)
        Me.BtnSupplyDelete.Name = "BtnSupplyDelete"
        Me.BtnSupplyDelete.Size = New System.Drawing.Size(100, 41)
        Me.BtnSupplyDelete.TabIndex = 10
        Me.BtnSupplyDelete.Text = "Delete Selected Supply"
        Me.BtnSupplyDelete.UseVisualStyleBackColor = True
        '
        'UserControlSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSupplyDelete)
        Me.Controls.Add(Me.BtnSupplyInsert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSupplyUnitOfMeasurement)
        Me.Controls.Add(Me.TxtSupplyQty)
        Me.Controls.Add(Me.TxtSupplyName)
        Me.Controls.Add(Me.TxtSupplyId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplies"
        Me.Size = New System.Drawing.Size(761, 369)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplies As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplyId As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyUnitOfMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplyInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyDelete As System.Windows.Forms.Button

End Class
