<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProductDelivery
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnProdDeliveryDelete = New System.Windows.Forms.Button()
        Me.BtnProdDeliveryUpdate = New System.Windows.Forms.Button()
        Me.BtnProdDeliveryInsert = New System.Windows.Forms.Button()
        Me.TxtProdDeliveryProvince = New System.Windows.Forms.TextBox()
        Me.TxtProdDeliveryCity = New System.Windows.Forms.TextBox()
        Me.TxtProdDeliveryStreet = New System.Windows.Forms.TextBox()
        Me.DataGridViewProdDelivery = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProdDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnProdDeliveryDelete)
        Me.GroupBox1.Controls.Add(Me.BtnProdDeliveryUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnProdDeliveryInsert)
        Me.GroupBox1.Controls.Add(Me.TxtProdDeliveryProvince)
        Me.GroupBox1.Controls.Add(Me.TxtProdDeliveryCity)
        Me.GroupBox1.Controls.Add(Me.TxtProdDeliveryStreet)
        Me.GroupBox1.Controls.Add(Me.DataGridViewProdDelivery)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Deliveries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Province"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "City"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Street"
        '
        'BtnProdDeliveryDelete
        '
        Me.BtnProdDeliveryDelete.Location = New System.Drawing.Point(482, 445)
        Me.BtnProdDeliveryDelete.Name = "BtnProdDeliveryDelete"
        Me.BtnProdDeliveryDelete.Size = New System.Drawing.Size(146, 23)
        Me.BtnProdDeliveryDelete.TabIndex = 6
        Me.BtnProdDeliveryDelete.Text = "Delete Selected"
        Me.BtnProdDeliveryDelete.UseVisualStyleBackColor = True
        '
        'BtnProdDeliveryUpdate
        '
        Me.BtnProdDeliveryUpdate.Location = New System.Drawing.Point(482, 416)
        Me.BtnProdDeliveryUpdate.Name = "BtnProdDeliveryUpdate"
        Me.BtnProdDeliveryUpdate.Size = New System.Drawing.Size(146, 23)
        Me.BtnProdDeliveryUpdate.TabIndex = 5
        Me.BtnProdDeliveryUpdate.Text = "Update Selected"
        Me.BtnProdDeliveryUpdate.UseVisualStyleBackColor = True
        '
        'BtnProdDeliveryInsert
        '
        Me.BtnProdDeliveryInsert.Location = New System.Drawing.Point(482, 387)
        Me.BtnProdDeliveryInsert.Name = "BtnProdDeliveryInsert"
        Me.BtnProdDeliveryInsert.Size = New System.Drawing.Size(146, 23)
        Me.BtnProdDeliveryInsert.TabIndex = 4
        Me.BtnProdDeliveryInsert.Text = "Insert"
        Me.BtnProdDeliveryInsert.UseVisualStyleBackColor = True
        '
        'TxtProdDeliveryProvince
        '
        Me.TxtProdDeliveryProvince.Location = New System.Drawing.Point(99, 448)
        Me.TxtProdDeliveryProvince.Name = "TxtProdDeliveryProvince"
        Me.TxtProdDeliveryProvince.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdDeliveryProvince.TabIndex = 3
        '
        'TxtProdDeliveryCity
        '
        Me.TxtProdDeliveryCity.Location = New System.Drawing.Point(99, 422)
        Me.TxtProdDeliveryCity.Name = "TxtProdDeliveryCity"
        Me.TxtProdDeliveryCity.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdDeliveryCity.TabIndex = 2
        '
        'TxtProdDeliveryStreet
        '
        Me.TxtProdDeliveryStreet.Location = New System.Drawing.Point(99, 394)
        Me.TxtProdDeliveryStreet.Name = "TxtProdDeliveryStreet"
        Me.TxtProdDeliveryStreet.Size = New System.Drawing.Size(100, 22)
        Me.TxtProdDeliveryStreet.TabIndex = 1
        '
        'DataGridViewProdDelivery
        '
        Me.DataGridViewProdDelivery.AllowUserToAddRows = False
        Me.DataGridViewProdDelivery.AllowUserToDeleteRows = False
        Me.DataGridViewProdDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProdDelivery.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewProdDelivery.Name = "DataGridViewProdDelivery"
        Me.DataGridViewProdDelivery.RowTemplate.Height = 24
        Me.DataGridViewProdDelivery.Size = New System.Drawing.Size(622, 360)
        Me.DataGridViewProdDelivery.TabIndex = 0
        '
        'UserControlProductDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlProductDelivery"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewProdDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewProdDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnProdDeliveryDelete As System.Windows.Forms.Button
    Friend WithEvents BtnProdDeliveryUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnProdDeliveryInsert As System.Windows.Forms.Button
    Friend WithEvents TxtProdDeliveryProvince As System.Windows.Forms.TextBox
    Friend WithEvents TxtProdDeliveryCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtProdDeliveryStreet As System.Windows.Forms.TextBox

End Class
