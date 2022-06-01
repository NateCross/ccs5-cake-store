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
        Me.TabPageProductOrders = New System.Windows.Forms.TabPage()
        Me.TabPageProductDeliveries = New System.Windows.Forms.TabPage()
        Me.TabPageSupplyOrders = New System.Windows.Forms.TabPage()
        Me.TabPageSupplyDelivery = New System.Windows.Forms.TabPage()
        Me.TabPageSupplyPayments = New System.Windows.Forms.TabPage()
        Me.TabPageSupplyUsage = New System.Windows.Forms.TabPage()
        Me.TabPageEmpManagement = New System.Windows.Forms.TabPage()
        Me.BtnQuitProgram = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.UserControlCustomer1 = New CakeStore.UserControlCustomer()
        Me.UserControlProduct1 = New CakeStore.UserControlProduct()
        Me.UserControlEmployee1 = New CakeStore.UserControlEmployee()
        Me.TabDashboard.SuspendLayout()
        Me.TabPageSales.SuspendLayout()
        Me.TabPageInventory.SuspendLayout()
        Me.TabPageEmpManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabDashboard
        '
        Me.TabDashboard.Controls.Add(Me.TabPageSales)
        Me.TabDashboard.Controls.Add(Me.TabPageInventory)
        Me.TabDashboard.Controls.Add(Me.TabPageProductOrders)
        Me.TabDashboard.Controls.Add(Me.TabPageProductDeliveries)
        Me.TabDashboard.Controls.Add(Me.TabPageSupplyOrders)
        Me.TabDashboard.Controls.Add(Me.TabPageSupplyDelivery)
        Me.TabDashboard.Controls.Add(Me.TabPageSupplyPayments)
        Me.TabDashboard.Controls.Add(Me.TabPageSupplyUsage)
        Me.TabDashboard.Controls.Add(Me.TabPageEmpManagement)
        Me.TabDashboard.Location = New System.Drawing.Point(12, -3)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.SelectedIndex = 0
        Me.TabDashboard.Size = New System.Drawing.Size(1281, 933)
        Me.TabDashboard.TabIndex = 0
        '
        'TabPageSales
        '
        Me.TabPageSales.Controls.Add(Me.UserControlCustomer1)
        Me.TabPageSales.Controls.Add(Me.GroupBox1)
        Me.TabPageSales.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSales.Name = "TabPageSales"
        Me.TabPageSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSales.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageSales.TabIndex = 0
        Me.TabPageSales.Text = "Sales"
        Me.TabPageSales.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'TabPageInventory
        '
        Me.TabPageInventory.Controls.Add(Me.UserControlProduct1)
        Me.TabPageInventory.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInventory.Name = "TabPageInventory"
        Me.TabPageInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInventory.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageInventory.TabIndex = 1
        Me.TabPageInventory.Text = "Inventory"
        Me.TabPageInventory.UseVisualStyleBackColor = True
        '
        'TabPageProductOrders
        '
        Me.TabPageProductOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductOrders.Name = "TabPageProductOrders"
        Me.TabPageProductOrders.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageProductOrders.TabIndex = 2
        Me.TabPageProductOrders.Text = "Product Orders"
        Me.TabPageProductOrders.UseVisualStyleBackColor = True
        '
        'TabPageProductDeliveries
        '
        Me.TabPageProductDeliveries.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductDeliveries.Name = "TabPageProductDeliveries"
        Me.TabPageProductDeliveries.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageProductDeliveries.TabIndex = 3
        Me.TabPageProductDeliveries.Text = "Product Deliveries"
        '
        'TabPageSupplyOrders
        '
        Me.TabPageSupplyOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyOrders.Name = "TabPageSupplyOrders"
        Me.TabPageSupplyOrders.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageSupplyOrders.TabIndex = 4
        Me.TabPageSupplyOrders.Text = "Supply Orders"
        Me.TabPageSupplyOrders.UseVisualStyleBackColor = True
        '
        'TabPageSupplyDelivery
        '
        Me.TabPageSupplyDelivery.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyDelivery.Name = "TabPageSupplyDelivery"
        Me.TabPageSupplyDelivery.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageSupplyDelivery.TabIndex = 5
        Me.TabPageSupplyDelivery.Text = "Supply Deliveries"
        Me.TabPageSupplyDelivery.UseVisualStyleBackColor = True
        '
        'TabPageSupplyPayments
        '
        Me.TabPageSupplyPayments.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyPayments.Name = "TabPageSupplyPayments"
        Me.TabPageSupplyPayments.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageSupplyPayments.TabIndex = 7
        Me.TabPageSupplyPayments.Text = "Supply Payments"
        Me.TabPageSupplyPayments.UseVisualStyleBackColor = True
        '
        'TabPageSupplyUsage
        '
        Me.TabPageSupplyUsage.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyUsage.Name = "TabPageSupplyUsage"
        Me.TabPageSupplyUsage.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageSupplyUsage.TabIndex = 6
        Me.TabPageSupplyUsage.Text = "Supply Usage"
        Me.TabPageSupplyUsage.UseVisualStyleBackColor = True
        '
        'TabPageEmpManagement
        '
        Me.TabPageEmpManagement.Controls.Add(Me.UserControlEmployee1)
        Me.TabPageEmpManagement.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEmpManagement.Name = "TabPageEmpManagement"
        Me.TabPageEmpManagement.Size = New System.Drawing.Size(1273, 904)
        Me.TabPageEmpManagement.TabIndex = 8
        Me.TabPageEmpManagement.Text = "Employee Management"
        Me.TabPageEmpManagement.UseVisualStyleBackColor = True
        '
        'BtnQuitProgram
        '
        Me.BtnQuitProgram.Location = New System.Drawing.Point(114, 932)
        Me.BtnQuitProgram.Name = "BtnQuitProgram"
        Me.BtnQuitProgram.Size = New System.Drawing.Size(87, 34)
        Me.BtnQuitProgram.TabIndex = 1
        Me.BtnQuitProgram.Text = "Exit"
        Me.BtnQuitProgram.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(22, 932)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(86, 34)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'UserControlCustomer1
        '
        Me.UserControlCustomer1.Location = New System.Drawing.Point(6, 235)
        Me.UserControlCustomer1.Name = "UserControlCustomer1"
        Me.UserControlCustomer1.Size = New System.Drawing.Size(1002, 693)
        Me.UserControlCustomer1.TabIndex = 1
        '
        'UserControlProduct1
        '
        Me.UserControlProduct1.Location = New System.Drawing.Point(6, 6)
        Me.UserControlProduct1.Name = "UserControlProduct1"
        Me.UserControlProduct1.Size = New System.Drawing.Size(1000, 433)
        Me.UserControlProduct1.TabIndex = 0
        '
        'UserControlEmployee1
        '
        Me.UserControlEmployee1.Location = New System.Drawing.Point(6, 3)
        Me.UserControlEmployee1.Name = "UserControlEmployee1"
        Me.UserControlEmployee1.Size = New System.Drawing.Size(976, 747)
        Me.UserControlEmployee1.TabIndex = 0
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1305, 975)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnQuitProgram)
        Me.Controls.Add(Me.TabDashboard)
        Me.Name = "FrmDashboard"
        Me.Text = "Cake Store Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabDashboard.ResumeLayout(False)
        Me.TabPageSales.ResumeLayout(False)
        Me.TabPageInventory.ResumeLayout(False)
        Me.TabPageEmpManagement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabDashboard As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageInventory As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitProgram As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents TabPageProductOrders As System.Windows.Forms.TabPage
    Friend WithEvents TabPageProductDeliveries As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSupplyOrders As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSupplyDelivery As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSupplyPayments As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSupplyUsage As System.Windows.Forms.TabPage
    Friend WithEvents TabPageEmpManagement As System.Windows.Forms.TabPage
    Friend WithEvents UserControlProduct1 As CakeStore.UserControlProduct
    Friend WithEvents UserControlCustomer1 As CakeStore.UserControlCustomer
    Friend WithEvents UserControlEmployee1 As CakeStore.UserControlEmployee
End Class
