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
        Me.TxtSupplyName = New System.Windows.Forms.TextBox()
        Me.TxtSupplyQty = New System.Windows.Forms.TextBox()
        Me.TxtSupplyUnitOfMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSupplyInsert = New System.Windows.Forms.Button()
        Me.BtnSupplyDelete = New System.Windows.Forms.Button()
        Me.BtnSupplyUpdate = New System.Windows.Forms.Button()
        Me.BtnSupplyClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSupplySearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSupplySearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewSupplies)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(608, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplies"
        '
        'DataGridViewSupplies
        '
        Me.DataGridViewSupplies.AllowUserToAddRows = False
        Me.DataGridViewSupplies.AllowUserToDeleteRows = False
        Me.DataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplies.Location = New System.Drawing.Point(0, 51)
        Me.DataGridViewSupplies.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewSupplies.Name = "DataGridViewSupplies"
        Me.DataGridViewSupplies.Size = New System.Drawing.Size(600, 383)
        Me.DataGridViewSupplies.TabIndex = 0
        '
        'TxtSupplyName
        '
        Me.TxtSupplyName.Location = New System.Drawing.Point(653, 151)
        Me.TxtSupplyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSupplyName.Name = "TxtSupplyName"
        Me.TxtSupplyName.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplyName.TabIndex = 2
        '
        'TxtSupplyQty
        '
        Me.TxtSupplyQty.Location = New System.Drawing.Point(653, 234)
        Me.TxtSupplyQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSupplyQty.Name = "TxtSupplyQty"
        Me.TxtSupplyQty.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplyQty.TabIndex = 3
        '
        'TxtSupplyUnitOfMeasurement
        '
        Me.TxtSupplyUnitOfMeasurement.Location = New System.Drawing.Point(653, 311)
        Me.TxtSupplyUnitOfMeasurement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSupplyUnitOfMeasurement.Name = "TxtSupplyUnitOfMeasurement"
        Me.TxtSupplyUnitOfMeasurement.Size = New System.Drawing.Size(132, 22)
        Me.TxtSupplyUnitOfMeasurement.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(649, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(649, 214)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Unit of Measurement"
        '
        'BtnSupplyInsert
        '
        Me.BtnSupplyInsert.Location = New System.Drawing.Point(840, 138)
        Me.BtnSupplyInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSupplyInsert.Name = "BtnSupplyInsert"
        Me.BtnSupplyInsert.Size = New System.Drawing.Size(133, 50)
        Me.BtnSupplyInsert.TabIndex = 9
        Me.BtnSupplyInsert.Text = "Insert New Supply"
        Me.BtnSupplyInsert.UseVisualStyleBackColor = True
        '
        'BtnSupplyDelete
        '
        Me.BtnSupplyDelete.Location = New System.Drawing.Point(840, 220)
        Me.BtnSupplyDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSupplyDelete.Name = "BtnSupplyDelete"
        Me.BtnSupplyDelete.Size = New System.Drawing.Size(133, 50)
        Me.BtnSupplyDelete.TabIndex = 10
        Me.BtnSupplyDelete.Text = "Delete Selected Supply"
        Me.BtnSupplyDelete.UseVisualStyleBackColor = True
        '
        'BtnSupplyUpdate
        '
        Me.BtnSupplyUpdate.Location = New System.Drawing.Point(840, 292)
        Me.BtnSupplyUpdate.Name = "BtnSupplyUpdate"
        Me.BtnSupplyUpdate.Size = New System.Drawing.Size(133, 50)
        Me.BtnSupplyUpdate.TabIndex = 11
        Me.BtnSupplyUpdate.Text = "Update Selected Supply"
        Me.BtnSupplyUpdate.UseVisualStyleBackColor = True
        '
        'BtnSupplyClear
        '
        Me.BtnSupplyClear.Location = New System.Drawing.Point(840, 366)
        Me.BtnSupplyClear.Name = "BtnSupplyClear"
        Me.BtnSupplyClear.Size = New System.Drawing.Size(133, 46)
        Me.BtnSupplyClear.TabIndex = 12
        Me.BtnSupplyClear.Text = "Clear Fields"
        Me.BtnSupplyClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Supply Names:"
        '
        'TxtSupplySearch
        '
        Me.TxtSupplySearch.Location = New System.Drawing.Point(165, 27)
        Me.TxtSupplySearch.Name = "TxtSupplySearch"
        Me.TxtSupplySearch.Size = New System.Drawing.Size(435, 22)
        Me.TxtSupplySearch.TabIndex = 2
        '
        'UserControlSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSupplyClear)
        Me.Controls.Add(Me.BtnSupplyUpdate)
        Me.Controls.Add(Me.BtnSupplyDelete)
        Me.Controls.Add(Me.BtnSupplyInsert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSupplyUnitOfMeasurement)
        Me.Controls.Add(Me.TxtSupplyQty)
        Me.Controls.Add(Me.TxtSupplyName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserControlSupplies"
        Me.Size = New System.Drawing.Size(1015, 454)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewSupplies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewSupplies As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSupplyName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplyUnitOfMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplyInsert As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyDelete As System.Windows.Forms.Button
    Friend WithEvents TxtSupplySearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupplyUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyClear As System.Windows.Forms.Button

End Class
