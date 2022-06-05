<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSupplyDelivery
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
        Me.BtnSupplyDeliveryUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplyDeliveryDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyDeliveryInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerSupplyDelivery = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewSupplyDelivery = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplyDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSupplyDeliveryUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyDeliveryDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyDeliveryInsert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerSupplyDelivery)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplyDelivery)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Deliveries"
        '
        'BtnSupplyDeliveryUpdate
        '
        Me.BtnSupplyDeliveryUpdate.Location = New System.Drawing.Point(395, 445)
        Me.BtnSupplyDeliveryUpdate.Name = "BtnSupplyDeliveryUpdate"
        Me.BtnSupplyDeliveryUpdate.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyDeliveryUpdate.TabIndex = 10
        Me.BtnSupplyDeliveryUpdate.Text = "Update Selected Supply Delivery"
        Me.BtnSupplyDeliveryUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyDeliveryDelete
        '
        Me.BtnSupplyDeliveryDelete.Location = New System.Drawing.Point(395, 416)
        Me.BtnSupplyDeliveryDelete.Name = "BtnSupplyDeliveryDelete"
        Me.BtnSupplyDeliveryDelete.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyDeliveryDelete.TabIndex = 9
        Me.BtnSupplyDeliveryDelete.Text = "Delete Selected Supply Delivery"
        Me.BtnSupplyDeliveryDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyDeliveryInsert
        '
        Me.BtnSupplyDeliveryInsert.Location = New System.Drawing.Point(395, 387)
        Me.BtnSupplyDeliveryInsert.Name = "BtnSupplyDeliveryInsert"
        Me.BtnSupplyDeliveryInsert.Size = New System.Drawing.Size(233, 23)
        Me.BtnSupplyDeliveryInsert.TabIndex = 8
        Me.BtnSupplyDeliveryInsert.Text = "Insert New Supply Delivery"
        Me.BtnSupplyDeliveryInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Payment Due Date"
        '
        'DateTimePickerSupplyDelivery
        '
        Me.DateTimePickerSupplyDelivery.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerSupplyDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerSupplyDelivery.Location = New System.Drawing.Point(40, 420)
        Me.DateTimePickerSupplyDelivery.Name = "DateTimePickerSupplyDelivery"
        Me.DateTimePickerSupplyDelivery.Size = New System.Drawing.Size(229, 22)
        Me.DateTimePickerSupplyDelivery.TabIndex = 6
        '
        'DataGridViewSupplyDelivery
        '
        Me.DataGridViewSupplyDelivery.AllowUserToAddRows = False
        Me.DataGridViewSupplyDelivery.AllowUserToDeleteRows = False
        Me.DataGridViewSupplyDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplyDelivery.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewSupplyDelivery.Name = "DataGridViewSupplyDelivery"
        Me.DataGridViewSupplyDelivery.RowTemplate.Height = 24
        Me.DataGridViewSupplyDelivery.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewSupplyDelivery.TabIndex = 0
        '
        'UserControlSupplyDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplyDelivery"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplyDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplyDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSupplyDeliveryUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyDeliveryDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyDeliveryInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerSupplyDelivery As System.Windows.Forms.DateTimePicker

End Class
