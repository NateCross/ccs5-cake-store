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
        Me.TxtSupplySearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewSupplies = New System.Windows.Forms.DataGridView()
        Me.BtnSupplyClear = New System.Windows.Forms.Button()
        Me.BtnSupplyUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplyDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyInsert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSupplyUnitOfMeasurement = New System.Windows.Forms.TextBox()
        Me.TxtSupplyQty = New System.Windows.Forms.TextBox()
        Me.TxtSupplyName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSupplyClear)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyInsert)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSupplyUnitOfMeasurement)
        Me.GroupBox1.Controls.Add(Me.TxtSupplyQty)
        Me.GroupBox1.Controls.Add(Me.TxtSupplyName)
        Me.GroupBox1.Controls.Add(Me.TxtSupplySearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplies)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplies"
        '
        'TxtSupplySearch
        '
        Me.TxtSupplySearch.Location = New System.Drawing.Point(120, 17)
        Me.TxtSupplySearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSupplySearch.Name = "TxtSupplySearch"
        Me.TxtSupplySearch.Size = New System.Drawing.Size(334, 20)
        Me.TxtSupplySearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Supply Names:"
        '
        'DataGridViewSupplies
        '
        Me.DataGridViewSupplies.AllowUserToAddRows = False
        Me.DataGridViewSupplies.AllowUserToDeleteRows = False
        Me.DataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplies.Location = New System.Drawing.Point(4, 40)
        Me.DataGridViewSupplies.Name = "DataGridViewSupplies"
        Me.DataGridViewSupplies.Size = New System.Drawing.Size(450, 410)
        Me.DataGridViewSupplies.TabIndex = 0
        '
        'BtnSupplyClear
        '
        Me.BtnSupplyClear.Location = New System.Drawing.Point(497, 355)
        Me.BtnSupplyClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyClear.Name = "BtnSupplyClear"
        Me.BtnSupplyClear.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplyClear.TabIndex = 32
        Me.BtnSupplyClear.Text = "Clear Fields"
        Me.BtnSupplyClear.UseVisualStyleBackColor = True
        '
        'BtnSupplyUpdate
        '
        Me.BtnSupplyUpdate.Location = New System.Drawing.Point(497, 311)
        Me.BtnSupplyUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSupplyUpdate.Name = "BtnSupplyUpdate"
        Me.BtnSupplyUpdate.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplyUpdate.TabIndex = 31
        Me.BtnSupplyUpdate.Text = "Update Selected Supply"
        Me.BtnSupplyUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyDelete
        '
        Me.BtnSupplyDelete.Location = New System.Drawing.Point(497, 266)
        Me.BtnSupplyDelete.Name = "BtnSupplyDelete"
        Me.BtnSupplyDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplyDelete.TabIndex = 30
        Me.BtnSupplyDelete.Text = "Delete Selected Supply"
        Me.BtnSupplyDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyInsert
        '
        Me.BtnSupplyInsert.Location = New System.Drawing.Point(497, 220)
        Me.BtnSupplyInsert.Name = "BtnSupplyInsert"
        Me.BtnSupplyInsert.Size = New System.Drawing.Size(100, 40)
        Me.BtnSupplyInsert.TabIndex = 29
        Me.BtnSupplyInsert.Text = "Insert New Supply"
        Me.BtnSupplyInsert.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(470, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Unit of Measurement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Name"
        '
        'TxtSupplyUnitOfMeasurement
        '
        Me.TxtSupplyUnitOfMeasurement.Location = New System.Drawing.Point(471, 164)
        Me.TxtSupplyUnitOfMeasurement.Name = "TxtSupplyUnitOfMeasurement"
        Me.TxtSupplyUnitOfMeasurement.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplyUnitOfMeasurement.TabIndex = 25
        '
        'TxtSupplyQty
        '
        Me.TxtSupplyQty.Location = New System.Drawing.Point(471, 108)
        Me.TxtSupplyQty.Name = "TxtSupplyQty"
        Me.TxtSupplyQty.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplyQty.TabIndex = 24
        '
        'TxtSupplyName
        '
        Me.TxtSupplyName.Location = New System.Drawing.Point(471, 56)
        Me.TxtSupplyName.Name = "TxtSupplyName"
        Me.TxtSupplyName.Size = New System.Drawing.Size(150, 20)
        Me.TxtSupplyName.TabIndex = 23
        '
        'UserControlSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlSupplies"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplies As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplySearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplyClear As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyInsert As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplyUnitOfMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyName As System.Windows.Forms.TextBox

End Class
