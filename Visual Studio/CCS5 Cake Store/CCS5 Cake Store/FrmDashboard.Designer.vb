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
        Me.UserControlProduct3 = New CakeStore.UserControlProduct()
        Me.UserControlSaleLineItem1 = New CakeStore.UserControlSaleLineItem()
        Me.UserControlSale1 = New CakeStore.UserControlSale()
        Me.UserControlCustomer1 = New CakeStore.UserControlCustomer()
        Me.UserControlProduct1 = New CakeStore.UserControlProduct()
        Me.UserControlProduct2 = New CakeStore.UserControlProduct()
        Me.UserControlProductOrderLineItem1 = New CakeStore.UserControlProductOrderLineItemTemp()
        Me.UserControlProductOrder1 = New CakeStore.UserControlProductOrder()
        Me.UserControlProductOrder2 = New CakeStore.UserControlProductOrder()
        Me.UserControlCustomer2 = New CakeStore.UserControlCustomer()
        Me.UserControlProductDelivery1 = New CakeStore.UserControlProductDelivery()
        Me.UserControlPurchaseOrderLineItem1 = New CakeStore.UserControlPurchaseOrderLineItem()
        Me.UserControlPurchaseOrder1 = New CakeStore.UserControlPurchaseOrder()
        Me.UserControlSupplier1 = New CakeStore.UserControlSupplier()
        Me.UserControlSupplies1 = New CakeStore.UserControlSupplies()
        Me.UserControlEmployee_Phone1 = New CakeStore.UserControlEmployee_Phone()
        Me.UserControlEmployee1 = New CakeStore.UserControlEmployee()
        Me.UserControlSupplyDelivery1 = New CakeStore.UserControlSupplyDelivery()
        Me.UserControlPurchaseOrder2 = New CakeStore.UserControlPurchaseOrder()
        Me.UserControlSupplier2 = New CakeStore.UserControlSupplier()
        Me.TabDashboard.SuspendLayout()
        Me.TabPageSales.SuspendLayout()
        Me.TabPageInventory.SuspendLayout()
        Me.TabPageProductOrders.SuspendLayout()
        Me.TabPageProductDeliveries.SuspendLayout()
        Me.TabPageSupplyOrders.SuspendLayout()
        Me.TabPageSupplyDelivery.SuspendLayout()
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
        Me.TabDashboard.Size = New System.Drawing.Size(1909, 1013)
        Me.TabDashboard.TabIndex = 0
        '
        'TabPageSales
        '
        Me.TabPageSales.Controls.Add(Me.UserControlProduct3)
        Me.TabPageSales.Controls.Add(Me.UserControlSaleLineItem1)
        Me.TabPageSales.Controls.Add(Me.UserControlSale1)
        Me.TabPageSales.Controls.Add(Me.UserControlCustomer1)
        Me.TabPageSales.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSales.Name = "TabPageSales"
        Me.TabPageSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSales.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageSales.TabIndex = 0
        Me.TabPageSales.Text = "Sales"
        Me.TabPageSales.UseVisualStyleBackColor = True
        '
        'TabPageInventory
        '
        Me.TabPageInventory.Controls.Add(Me.UserControlProduct1)
        Me.TabPageInventory.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInventory.Name = "TabPageInventory"
        Me.TabPageInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInventory.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageInventory.TabIndex = 1
        Me.TabPageInventory.Text = "Inventory"
        Me.TabPageInventory.UseVisualStyleBackColor = True
        '
        'TabPageProductOrders
        '
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProduct2)
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProductOrderLineItem1)
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProductOrder1)
        Me.TabPageProductOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductOrders.Name = "TabPageProductOrders"
        Me.TabPageProductOrders.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageProductOrders.TabIndex = 2
        Me.TabPageProductOrders.Text = "Product Orders"
        Me.TabPageProductOrders.UseVisualStyleBackColor = True
        '
        'TabPageProductDeliveries
        '
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlProductOrder2)
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlCustomer2)
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlProductDelivery1)
        Me.TabPageProductDeliveries.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductDeliveries.Name = "TabPageProductDeliveries"
        Me.TabPageProductDeliveries.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageProductDeliveries.TabIndex = 3
        Me.TabPageProductDeliveries.Text = "Product Deliveries"
        '
        'TabPageSupplyOrders
        '
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlPurchaseOrderLineItem1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlPurchaseOrder1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlSupplier1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlSupplies1)
        Me.TabPageSupplyOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyOrders.Name = "TabPageSupplyOrders"
        Me.TabPageSupplyOrders.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageSupplyOrders.TabIndex = 4
        Me.TabPageSupplyOrders.Text = "Supply Orders"
        Me.TabPageSupplyOrders.UseVisualStyleBackColor = True
        '
        'TabPageSupplyDelivery
        '
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlSupplier2)
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlPurchaseOrder2)
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlSupplyDelivery1)
        Me.TabPageSupplyDelivery.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyDelivery.Name = "TabPageSupplyDelivery"
        Me.TabPageSupplyDelivery.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageSupplyDelivery.TabIndex = 5
        Me.TabPageSupplyDelivery.Text = "Supply Deliveries"
        Me.TabPageSupplyDelivery.UseVisualStyleBackColor = True
        '
        'TabPageSupplyPayments
        '
        Me.TabPageSupplyPayments.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyPayments.Name = "TabPageSupplyPayments"
        Me.TabPageSupplyPayments.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageSupplyPayments.TabIndex = 7
        Me.TabPageSupplyPayments.Text = "Supply Payments"
        Me.TabPageSupplyPayments.UseVisualStyleBackColor = True
        '
        'TabPageSupplyUsage
        '
        Me.TabPageSupplyUsage.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyUsage.Name = "TabPageSupplyUsage"
        Me.TabPageSupplyUsage.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageSupplyUsage.TabIndex = 6
        Me.TabPageSupplyUsage.Text = "Supply Usage"
        Me.TabPageSupplyUsage.UseVisualStyleBackColor = True
        '
        'TabPageEmpManagement
        '
        Me.TabPageEmpManagement.Controls.Add(Me.UserControlEmployee_Phone1)
        Me.TabPageEmpManagement.Controls.Add(Me.UserControlEmployee1)
        Me.TabPageEmpManagement.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEmpManagement.Name = "TabPageEmpManagement"
        Me.TabPageEmpManagement.Size = New System.Drawing.Size(1901, 984)
        Me.TabPageEmpManagement.TabIndex = 8
        Me.TabPageEmpManagement.Text = "Employee Management"
        Me.TabPageEmpManagement.UseVisualStyleBackColor = True
        '
        'BtnQuitProgram
        '
        Me.BtnQuitProgram.Location = New System.Drawing.Point(104, 1016)
        Me.BtnQuitProgram.Name = "BtnQuitProgram"
        Me.BtnQuitProgram.Size = New System.Drawing.Size(87, 34)
        Me.BtnQuitProgram.TabIndex = 1
        Me.BtnQuitProgram.Text = "Exit"
        Me.BtnQuitProgram.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(12, 1016)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(86, 34)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'UserControlProduct3
        '
        Me.UserControlProduct3.Location = New System.Drawing.Point(6, 3)
        Me.UserControlProduct3.Name = "UserControlProduct3"
        Me.UserControlProduct3.Size = New System.Drawing.Size(972, 419)
        Me.UserControlProduct3.TabIndex = 4
        '
        'UserControlSaleLineItem1
        '
        Me.UserControlSaleLineItem1.Location = New System.Drawing.Point(1014, 420)
        Me.UserControlSaleLineItem1.Name = "UserControlSaleLineItem1"
        Me.UserControlSaleLineItem1.Size = New System.Drawing.Size(750, 450)
        Me.UserControlSaleLineItem1.TabIndex = 3
        '
        'UserControlSale1
        '
        Me.UserControlSale1.Location = New System.Drawing.Point(1014, 6)
        Me.UserControlSale1.Name = "UserControlSale1"
        Me.UserControlSale1.Size = New System.Drawing.Size(641, 408)
        Me.UserControlSale1.TabIndex = 2
        '
        'UserControlCustomer1
        '
        Me.UserControlCustomer1.Location = New System.Drawing.Point(3, 439)
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
        'UserControlProduct2
        '
        Me.UserControlProduct2.Location = New System.Drawing.Point(777, 392)
        Me.UserControlProduct2.Name = "UserControlProduct2"
        Me.UserControlProduct2.Size = New System.Drawing.Size(972, 419)
        Me.UserControlProduct2.TabIndex = 2
        '
        'UserControlProductOrderLineItem1
        '
        Me.UserControlProductOrderLineItem1.Location = New System.Drawing.Point(3, 392)
        Me.UserControlProductOrderLineItem1.Name = "UserControlProductOrderLineItem1"
        Me.UserControlProductOrderLineItem1.Size = New System.Drawing.Size(768, 438)
        Me.UserControlProductOrderLineItem1.TabIndex = 1
        '
        'UserControlProductOrder1
        '
        Me.UserControlProductOrder1.Location = New System.Drawing.Point(3, 3)
        Me.UserControlProductOrder1.Name = "UserControlProductOrder1"
        Me.UserControlProductOrder1.Size = New System.Drawing.Size(767, 383)
        Me.UserControlProductOrder1.TabIndex = 0
        '
        'UserControlProductOrder2
        '
        Me.UserControlProductOrder2.Location = New System.Drawing.Point(3, 489)
        Me.UserControlProductOrder2.Name = "UserControlProductOrder2"
        Me.UserControlProductOrder2.Size = New System.Drawing.Size(767, 383)
        Me.UserControlProductOrder2.TabIndex = 2
        '
        'UserControlCustomer2
        '
        Me.UserControlCustomer2.Location = New System.Drawing.Point(649, 3)
        Me.UserControlCustomer2.Name = "UserControlCustomer2"
        Me.UserControlCustomer2.Size = New System.Drawing.Size(1000, 661)
        Me.UserControlCustomer2.TabIndex = 1
        '
        'UserControlProductDelivery1
        '
        Me.UserControlProductDelivery1.Location = New System.Drawing.Point(3, 3)
        Me.UserControlProductDelivery1.Name = "UserControlProductDelivery1"
        Me.UserControlProductDelivery1.Size = New System.Drawing.Size(640, 480)
        Me.UserControlProductDelivery1.TabIndex = 0
        '
        'UserControlPurchaseOrderLineItem1
        '
        Me.UserControlPurchaseOrderLineItem1.Location = New System.Drawing.Point(1124, 490)
        Me.UserControlPurchaseOrderLineItem1.Name = "UserControlPurchaseOrderLineItem1"
        Me.UserControlPurchaseOrderLineItem1.Size = New System.Drawing.Size(640, 480)
        Me.UserControlPurchaseOrderLineItem1.TabIndex = 3
        '
        'UserControlPurchaseOrder1
        '
        Me.UserControlPurchaseOrder1.Location = New System.Drawing.Point(1012, 4)
        Me.UserControlPurchaseOrder1.Name = "UserControlPurchaseOrder1"
        Me.UserControlPurchaseOrder1.Size = New System.Drawing.Size(640, 480)
        Me.UserControlPurchaseOrder1.TabIndex = 2
        '
        'UserControlSupplier1
        '
        Me.UserControlSupplier1.Location = New System.Drawing.Point(4, 454)
        Me.UserControlSupplier1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlSupplier1.Name = "UserControlSupplier1"
        Me.UserControlSupplier1.Size = New System.Drawing.Size(1113, 450)
        Me.UserControlSupplier1.TabIndex = 1
        '
        'UserControlSupplies1
        '
        Me.UserControlSupplies1.Location = New System.Drawing.Point(4, 4)
        Me.UserControlSupplies1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlSupplies1.Name = "UserControlSupplies1"
        Me.UserControlSupplies1.Size = New System.Drawing.Size(1015, 454)
        Me.UserControlSupplies1.TabIndex = 0
        '
        'UserControlEmployee_Phone1
        '
        Me.UserControlEmployee_Phone1.Location = New System.Drawing.Point(989, 4)
        Me.UserControlEmployee_Phone1.Margin = New System.Windows.Forms.Padding(4)
        Me.UserControlEmployee_Phone1.Name = "UserControlEmployee_Phone1"
        Me.UserControlEmployee_Phone1.Size = New System.Drawing.Size(811, 518)
        Me.UserControlEmployee_Phone1.TabIndex = 1
        '
        'UserControlEmployee1
        '
        Me.UserControlEmployee1.Location = New System.Drawing.Point(6, 3)
        Me.UserControlEmployee1.Name = "UserControlEmployee1"
        Me.UserControlEmployee1.Size = New System.Drawing.Size(976, 747)
        Me.UserControlEmployee1.TabIndex = 0
        '
        'UserControlSupplyDelivery1
        '
        Me.UserControlSupplyDelivery1.Location = New System.Drawing.Point(3, 3)
        Me.UserControlSupplyDelivery1.Name = "UserControlSupplyDelivery1"
        Me.UserControlSupplyDelivery1.Size = New System.Drawing.Size(640, 480)
        Me.UserControlSupplyDelivery1.TabIndex = 0
        '
        'UserControlPurchaseOrder2
        '
        Me.UserControlPurchaseOrder2.Location = New System.Drawing.Point(649, 3)
        Me.UserControlPurchaseOrder2.Name = "UserControlPurchaseOrder2"
        Me.UserControlPurchaseOrder2.Size = New System.Drawing.Size(640, 480)
        Me.UserControlPurchaseOrder2.TabIndex = 1
        '
        'UserControlSupplier2
        '
        Me.UserControlSupplier2.Location = New System.Drawing.Point(4, 490)
        Me.UserControlSupplier2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlSupplier2.Name = "UserControlSupplier2"
        Me.UserControlSupplier2.Size = New System.Drawing.Size(1113, 450)
        Me.UserControlSupplier2.TabIndex = 2
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnQuitProgram)
        Me.Controls.Add(Me.TabDashboard)
        Me.Name = "FrmDashboard"
        Me.Text = "Cake Store Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabDashboard.ResumeLayout(False)
        Me.TabPageSales.ResumeLayout(False)
        Me.TabPageInventory.ResumeLayout(False)
        Me.TabPageProductOrders.ResumeLayout(False)
        Me.TabPageProductDeliveries.ResumeLayout(False)
        Me.TabPageSupplyOrders.ResumeLayout(False)
        Me.TabPageSupplyDelivery.ResumeLayout(False)
        Me.TabPageEmpManagement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabDashboard As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageInventory As System.Windows.Forms.TabPage
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
    Friend WithEvents UserControlSale1 As CakeStore.UserControlSale
    Friend WithEvents UserControlSaleLineItem1 As CakeStore.UserControlSaleLineItem
    Friend WithEvents UserControlProductOrder1 As CakeStore.UserControlProductOrder
    Friend WithEvents UserControlProductOrderLineItem1 As CakeStore.UserControlProductOrderLineItemTemp
    Friend WithEvents UserControlProduct2 As CakeStore.UserControlProduct
    Friend WithEvents UserControlProduct3 As CakeStore.UserControlProduct
    Friend WithEvents UserControlProductOrder2 As CakeStore.UserControlProductOrder
    Friend WithEvents UserControlCustomer2 As CakeStore.UserControlCustomer
    Friend WithEvents UserControlProductDelivery1 As CakeStore.UserControlProductDelivery
    Friend WithEvents UserControlSupplies1 As CakeStore.UserControlSupplies
    Friend WithEvents UserControlSupplier1 As CakeStore.UserControlSupplier
    Friend WithEvents UserControlEmployee_Phone1 As CakeStore.UserControlEmployee_Phone
    Friend WithEvents UserControlPurchaseOrder1 As CakeStore.UserControlPurchaseOrder
    Friend WithEvents UserControlPurchaseOrderLineItem1 As CakeStore.UserControlPurchaseOrderLineItem
    Friend WithEvents UserControlSupplier2 As CakeStore.UserControlSupplier
    Friend WithEvents UserControlPurchaseOrder2 As CakeStore.UserControlPurchaseOrder
    Friend WithEvents UserControlSupplyDelivery1 As CakeStore.UserControlSupplyDelivery
End Class
