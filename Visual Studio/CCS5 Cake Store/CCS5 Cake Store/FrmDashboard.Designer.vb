<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TabDashboard = New System.Windows.Forms.TabControl()
        Me.TabPageSales = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPageInventory = New System.Windows.Forms.TabPage()
        Me.BtnQuitProgram = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.GroupProducts = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabDashboard.SuspendLayout()
        Me.TabPageSales.SuspendLayout()
        Me.TabPageInventory.SuspendLayout()
        Me.GroupProducts.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabDashboard
        '
        Me.TabDashboard.Controls.Add(Me.TabPageSales)
        Me.TabDashboard.Controls.Add(Me.TabPageInventory)
        Me.TabDashboard.Location = New System.Drawing.Point(4, -3)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.SelectedIndex = 0
        Me.TabDashboard.Size = New System.Drawing.Size(878, 513)
        Me.TabDashboard.TabIndex = 0
        '
        'TabPageSales
        '
        Me.TabPageSales.Controls.Add(Me.GroupBox1)
        Me.TabPageSales.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSales.Name = "TabPageSales"
        Me.TabPageSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSales.Size = New System.Drawing.Size(870, 484)
        Me.TabPageSales.TabIndex = 0
        Me.TabPageSales.Text = "Sales"
        Me.TabPageSales.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'TabPageInventory
        '
        Me.TabPageInventory.Controls.Add(Me.GroupProducts)
        Me.TabPageInventory.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInventory.Name = "TabPageInventory"
        Me.TabPageInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInventory.Size = New System.Drawing.Size(870, 484)
        Me.TabPageInventory.TabIndex = 1
        Me.TabPageInventory.Text = "Inventory"
        Me.TabPageInventory.UseVisualStyleBackColor = True
        '
        'BtnQuitProgram
        '
        Me.BtnQuitProgram.Location = New System.Drawing.Point(783, 517)
        Me.BtnQuitProgram.Name = "BtnQuitProgram"
        Me.BtnQuitProgram.Size = New System.Drawing.Size(87, 34)
        Me.BtnQuitProgram.TabIndex = 1
        Me.BtnQuitProgram.Text = "Exit"
        Me.BtnQuitProgram.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(691, 517)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(86, 34)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'GroupProducts
        '
        Me.GroupProducts.Controls.Add(Me.DataGridView1)
        Me.GroupProducts.Location = New System.Drawing.Point(6, 6)
        Me.GroupProducts.Name = "GroupProducts"
        Me.GroupProducts.Size = New System.Drawing.Size(538, 301)
        Me.GroupProducts.TabIndex = 0
        Me.GroupProducts.TabStop = False
        Me.GroupProducts.Text = "Products"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(526, 274)
        Me.DataGridView1.TabIndex = 0
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 558)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnQuitProgram)
        Me.Controls.Add(Me.TabDashboard)
        Me.Name = "FrmDashboard"
        Me.Text = "Dashboard"
        Me.TabDashboard.ResumeLayout(False)
        Me.TabPageSales.ResumeLayout(False)
        Me.TabPageInventory.ResumeLayout(False)
        Me.GroupProducts.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabDashboard As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageInventory As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitProgram As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents GroupProducts As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
