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
        Me.UserControlProduct3 = New CakeStore.UserControlProduct()
        Me.UserControlSaleLineItem1 = New CakeStore.UserControlSaleLineItem()
        Me.UserControlSale1 = New CakeStore.UserControlSale()
        Me.UserControlCustomer1 = New CakeStore.UserControlCustomer()
        Me.TabPageInventory = New System.Windows.Forms.TabPage()
        Me.UserControlProduct1 = New CakeStore.UserControlProduct()
        Me.TabPageProductOrders = New System.Windows.Forms.TabPage()
        Me.UserControlProduct2 = New CakeStore.UserControlProduct()
        Me.UserControlProductOrderLineItem1 = New CakeStore.UserControlProductOrderLineItemTemp()
        Me.UserControlProductOrder1 = New CakeStore.UserControlProductOrder()
        Me.TabPageProductDeliveries = New System.Windows.Forms.TabPage()
        Me.UserControlProductOrder2 = New CakeStore.UserControlProductOrder()
        Me.UserControlCustomer2 = New CakeStore.UserControlCustomer()
        Me.UserControlProductDelivery1 = New CakeStore.UserControlProductDelivery()
        Me.TabPageSupplyOrders = New System.Windows.Forms.TabPage()
        Me.UserControlPurchaseOrderLineItem1 = New CakeStore.UserControlPurchaseOrderLineItem()
        Me.UserControlPurchaseOrder1 = New CakeStore.UserControlPurchaseOrder()
        Me.UserControlSupplier1 = New CakeStore.UserControlSupplier()
        Me.UserControlSupplies1 = New CakeStore.UserControlSupplies()
        Me.TabPageSupplyDelivery = New System.Windows.Forms.TabPage()
        Me.UserControlSupplies2 = New CakeStore.UserControlSupplies()
        Me.UserControlSupplier2 = New CakeStore.UserControlSupplier()
        Me.UserControlPurchaseOrder2 = New CakeStore.UserControlPurchaseOrder()
        Me.UserControlSupplyDelivery1 = New CakeStore.UserControlSupplyDelivery()
        Me.TabPageSupplyPayments = New System.Windows.Forms.TabPage()
        Me.UserControlSupplier4 = New CakeStore.UserControlSupplier()
        Me.UserControlSupplyDelivery2 = New CakeStore.UserControlSupplyDelivery()
        Me.UserControlSupplyPayment1 = New CakeStore.UserControlSupplyPayment()
        Me.TabPageSupplyUsage = New System.Windows.Forms.TabPage()
        Me.UserControlSupplyUsageLineItem1 = New CakeStore.UserControlSupplyUsageLineItem()
        Me.UserControlProduct4 = New CakeStore.UserControlProduct()
        Me.UserControlSupplyUsage1 = New CakeStore.UserControlSupplyUsage()
        Me.UserControlSupplies3 = New CakeStore.UserControlSupplies()
        Me.TabPageEmpManagement = New System.Windows.Forms.TabPage()
        Me.UserControlEmployee_Phone1 = New CakeStore.UserControlEmployee_Phone()
        Me.UserControlEmployee1 = New CakeStore.UserControlEmployee()
        Me.TabPageCustManagement = New System.Windows.Forms.TabPage()
        Me.UserControlCustomer_Phone2 = New CakeStore.UserControlCustomer_Phone()
        Me.UserControlCustomer3 = New CakeStore.UserControlCustomer()
        Me.TabPageSupplierManagement = New System.Windows.Forms.TabPage()
        Me.UserControlSupplier_Phone2 = New CakeStore.UserControlSupplier_Phone()
        Me.UserControlSupplier3 = New CakeStore.UserControlSupplier()
        Me.BtnQuitProgram = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.TabDashboard.SuspendLayout()
        Me.TabPageSales.SuspendLayout()
        Me.TabPageInventory.SuspendLayout()
        Me.TabPageProductOrders.SuspendLayout()
        Me.TabPageProductDeliveries.SuspendLayout()
        Me.TabPageSupplyOrders.SuspendLayout()
        Me.TabPageSupplyDelivery.SuspendLayout()
        Me.TabPageSupplyPayments.SuspendLayout()
        Me.TabPageSupplyUsage.SuspendLayout()
        Me.TabPageEmpManagement.SuspendLayout()
        Me.TabPageCustManagement.SuspendLayout()
        Me.TabPageSupplierManagement.SuspendLayout()
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
        Me.TabDashboard.Controls.Add(Me.TabPageCustManagement)
        Me.TabDashboard.Controls.Add(Me.TabPageSupplierManagement)
        Me.TabDashboard.Location = New System.Drawing.Point(12, -2)
        Me.TabDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.SelectedIndex = 0
        Me.TabDashboard.Size = New System.Drawing.Size(1893, 1182)
        Me.TabDashboard.TabIndex = 0
        '
        'TabPageSales
        '
        Me.TabPageSales.Controls.Add(Me.UserControlProduct3)
        Me.TabPageSales.Controls.Add(Me.UserControlSaleLineItem1)
        Me.TabPageSales.Controls.Add(Me.UserControlSale1)
        Me.TabPageSales.Controls.Add(Me.UserControlCustomer1)
        Me.TabPageSales.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSales.Name = "TabPageSales"
        Me.TabPageSales.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSales.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSales.TabIndex = 0
        Me.TabPageSales.Text = "Sales"
        Me.TabPageSales.UseVisualStyleBackColor = True
        '
        'UserControlProduct3
        '
        Me.UserControlProduct3.Location = New System.Drawing.Point(6, 577)
        Me.UserControlProduct3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProduct3.Name = "UserControlProduct3"
        Me.UserControlProduct3.Size = New System.Drawing.Size(965, 571)
        Me.UserControlProduct3.TabIndex = 4
        '
        'UserControlSaleLineItem1
        '
        Me.UserControlSaleLineItem1.Location = New System.Drawing.Point(873, 7)
        Me.UserControlSaleLineItem1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSaleLineItem1.Name = "UserControlSaleLineItem1"
        Me.UserControlSaleLineItem1.Size = New System.Drawing.Size(859, 566)
        Me.UserControlSaleLineItem1.TabIndex = 3
        '
        'UserControlSale1
        '
        Me.UserControlSale1.Location = New System.Drawing.Point(6, 7)
        Me.UserControlSale1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSale1.Name = "UserControlSale1"
        Me.UserControlSale1.Size = New System.Drawing.Size(861, 567)
        Me.UserControlSale1.TabIndex = 2
        '
        'UserControlCustomer1
        '
        Me.UserControlCustomer1.Location = New System.Drawing.Point(977, 585)
        Me.UserControlCustomer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlCustomer1.Name = "UserControlCustomer1"
        Me.UserControlCustomer1.Size = New System.Drawing.Size(1029, 572)
        Me.UserControlCustomer1.TabIndex = 1
        '
        'TabPageInventory
        '
        Me.TabPageInventory.Controls.Add(Me.UserControlProduct1)
        Me.TabPageInventory.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageInventory.Name = "TabPageInventory"
        Me.TabPageInventory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageInventory.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageInventory.TabIndex = 1
        Me.TabPageInventory.Text = "Inventory"
        Me.TabPageInventory.UseVisualStyleBackColor = True
        '
        'UserControlProduct1
        '
        Me.UserControlProduct1.Location = New System.Drawing.Point(5, 6)
        Me.UserControlProduct1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProduct1.Name = "UserControlProduct1"
        Me.UserControlProduct1.Size = New System.Drawing.Size(1000, 564)
        Me.UserControlProduct1.TabIndex = 0
        '
        'TabPageProductOrders
        '
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProduct2)
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProductOrderLineItem1)
        Me.TabPageProductOrders.Controls.Add(Me.UserControlProductOrder1)
        Me.TabPageProductOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductOrders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageProductOrders.Name = "TabPageProductOrders"
        Me.TabPageProductOrders.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageProductOrders.TabIndex = 2
        Me.TabPageProductOrders.Text = "Product Orders"
        Me.TabPageProductOrders.UseVisualStyleBackColor = True
        '
        'UserControlProduct2
        '
        Me.UserControlProduct2.Location = New System.Drawing.Point(3, 381)
        Me.UserControlProduct2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProduct2.Name = "UserControlProduct2"
        Me.UserControlProduct2.Size = New System.Drawing.Size(972, 575)
        Me.UserControlProduct2.TabIndex = 2
        '
        'UserControlProductOrderLineItem1
        '
        Me.UserControlProductOrderLineItem1.Location = New System.Drawing.Point(980, 2)
        Me.UserControlProductOrderLineItem1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProductOrderLineItem1.Name = "UserControlProductOrderLineItem1"
        Me.UserControlProductOrderLineItem1.Size = New System.Drawing.Size(861, 593)
        Me.UserControlProductOrderLineItem1.TabIndex = 1
        '
        'UserControlProductOrder1
        '
        Me.UserControlProductOrder1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlProductOrder1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProductOrder1.Name = "UserControlProductOrder1"
        Me.UserControlProductOrder1.Size = New System.Drawing.Size(963, 375)
        Me.UserControlProductOrder1.TabIndex = 0
        '
        'TabPageProductDeliveries
        '
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlProductOrder2)
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlCustomer2)
        Me.TabPageProductDeliveries.Controls.Add(Me.UserControlProductDelivery1)
        Me.TabPageProductDeliveries.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProductDeliveries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageProductDeliveries.Name = "TabPageProductDeliveries"
        Me.TabPageProductDeliveries.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageProductDeliveries.TabIndex = 3
        Me.TabPageProductDeliveries.Text = "Product Deliveries"
        '
        'UserControlProductOrder2
        '
        Me.UserControlProductOrder2.Location = New System.Drawing.Point(3, 599)
        Me.UserControlProductOrder2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProductOrder2.Name = "UserControlProductOrder2"
        Me.UserControlProductOrder2.Size = New System.Drawing.Size(959, 476)
        Me.UserControlProductOrder2.TabIndex = 2
        '
        'UserControlCustomer2
        '
        Me.UserControlCustomer2.Location = New System.Drawing.Point(859, 14)
        Me.UserControlCustomer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlCustomer2.Name = "UserControlCustomer2"
        Me.UserControlCustomer2.Size = New System.Drawing.Size(1029, 581)
        Me.UserControlCustomer2.TabIndex = 1
        '
        'UserControlProductDelivery1
        '
        Me.UserControlProductDelivery1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlProductDelivery1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProductDelivery1.Name = "UserControlProductDelivery1"
        Me.UserControlProductDelivery1.Size = New System.Drawing.Size(860, 592)
        Me.UserControlProductDelivery1.TabIndex = 0
        '
        'TabPageSupplyOrders
        '
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlPurchaseOrderLineItem1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlPurchaseOrder1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlSupplier1)
        Me.TabPageSupplyOrders.Controls.Add(Me.UserControlSupplies1)
        Me.TabPageSupplyOrders.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyOrders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSupplyOrders.Name = "TabPageSupplyOrders"
        Me.TabPageSupplyOrders.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSupplyOrders.TabIndex = 4
        Me.TabPageSupplyOrders.Text = "Purchase Orders"
        Me.TabPageSupplyOrders.UseVisualStyleBackColor = True
        '
        'UserControlPurchaseOrderLineItem1
        '
        Me.UserControlPurchaseOrderLineItem1.Location = New System.Drawing.Point(661, 0)
        Me.UserControlPurchaseOrderLineItem1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlPurchaseOrderLineItem1.Name = "UserControlPurchaseOrderLineItem1"
        Me.UserControlPurchaseOrderLineItem1.Size = New System.Drawing.Size(855, 554)
        Me.UserControlPurchaseOrderLineItem1.TabIndex = 3
        '
        'UserControlPurchaseOrder1
        '
        Me.UserControlPurchaseOrder1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlPurchaseOrder1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlPurchaseOrder1.Name = "UserControlPurchaseOrder1"
        Me.UserControlPurchaseOrder1.Size = New System.Drawing.Size(652, 591)
        Me.UserControlPurchaseOrder1.TabIndex = 2
        '
        'UserControlSupplier1
        '
        Me.UserControlSupplier1.Location = New System.Drawing.Point(897, 604)
        Me.UserControlSupplier1.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplier1.Name = "UserControlSupplier1"
        Me.UserControlSupplier1.Size = New System.Drawing.Size(1024, 553)
        Me.UserControlSupplier1.TabIndex = 1
        '
        'UserControlSupplies1
        '
        Me.UserControlSupplies1.Location = New System.Drawing.Point(5, 600)
        Me.UserControlSupplies1.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplies1.Name = "UserControlSupplies1"
        Me.UserControlSupplies1.Size = New System.Drawing.Size(882, 591)
        Me.UserControlSupplies1.TabIndex = 0
        '
        'TabPageSupplyDelivery
        '
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlSupplies2)
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlSupplier2)
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlPurchaseOrder2)
        Me.TabPageSupplyDelivery.Controls.Add(Me.UserControlSupplyDelivery1)
        Me.TabPageSupplyDelivery.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyDelivery.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSupplyDelivery.Name = "TabPageSupplyDelivery"
        Me.TabPageSupplyDelivery.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSupplyDelivery.TabIndex = 5
        Me.TabPageSupplyDelivery.Text = "Supply Deliveries"
        Me.TabPageSupplyDelivery.UseVisualStyleBackColor = True
        '
        'UserControlSupplies2
        '
        Me.UserControlSupplies2.Location = New System.Drawing.Point(1024, 587)
        Me.UserControlSupplies2.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplies2.Name = "UserControlSupplies2"
        Me.UserControlSupplies2.Size = New System.Drawing.Size(864, 559)
        Me.UserControlSupplies2.TabIndex = 3
        '
        'UserControlSupplier2
        '
        Me.UserControlSupplier2.Location = New System.Drawing.Point(4, 587)
        Me.UserControlSupplier2.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplier2.Name = "UserControlSupplier2"
        Me.UserControlSupplier2.Size = New System.Drawing.Size(1024, 559)
        Me.UserControlSupplier2.TabIndex = 2
        '
        'UserControlPurchaseOrder2
        '
        Me.UserControlPurchaseOrder2.Location = New System.Drawing.Point(612, 2)
        Me.UserControlPurchaseOrder2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlPurchaseOrder2.Name = "UserControlPurchaseOrder2"
        Me.UserControlPurchaseOrder2.Size = New System.Drawing.Size(640, 596)
        Me.UserControlPurchaseOrder2.TabIndex = 1
        '
        'UserControlSupplyDelivery1
        '
        Me.UserControlSupplyDelivery1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlSupplyDelivery1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSupplyDelivery1.Name = "UserControlSupplyDelivery1"
        Me.UserControlSupplyDelivery1.Size = New System.Drawing.Size(604, 596)
        Me.UserControlSupplyDelivery1.TabIndex = 0
        '
        'TabPageSupplyPayments
        '
        Me.TabPageSupplyPayments.Controls.Add(Me.UserControlSupplier4)
        Me.TabPageSupplyPayments.Controls.Add(Me.UserControlSupplyDelivery2)
        Me.TabPageSupplyPayments.Controls.Add(Me.UserControlSupplyPayment1)
        Me.TabPageSupplyPayments.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyPayments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSupplyPayments.Name = "TabPageSupplyPayments"
        Me.TabPageSupplyPayments.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSupplyPayments.TabIndex = 7
        Me.TabPageSupplyPayments.Text = "Supply Payments"
        Me.TabPageSupplyPayments.UseVisualStyleBackColor = True
        '
        'UserControlSupplier4
        '
        Me.UserControlSupplier4.Location = New System.Drawing.Point(5, 605)
        Me.UserControlSupplier4.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplier4.Name = "UserControlSupplier4"
        Me.UserControlSupplier4.Size = New System.Drawing.Size(1024, 559)
        Me.UserControlSupplier4.TabIndex = 7
        '
        'UserControlSupplyDelivery2
        '
        Me.UserControlSupplyDelivery2.Location = New System.Drawing.Point(632, 0)
        Me.UserControlSupplyDelivery2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSupplyDelivery2.Name = "UserControlSupplyDelivery2"
        Me.UserControlSupplyDelivery2.Size = New System.Drawing.Size(604, 596)
        Me.UserControlSupplyDelivery2.TabIndex = 6
        '
        'UserControlSupplyPayment1
        '
        Me.UserControlSupplyPayment1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlSupplyPayment1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSupplyPayment1.Name = "UserControlSupplyPayment1"
        Me.UserControlSupplyPayment1.Size = New System.Drawing.Size(623, 596)
        Me.UserControlSupplyPayment1.TabIndex = 5
        '
        'TabPageSupplyUsage
        '
        Me.TabPageSupplyUsage.Controls.Add(Me.UserControlSupplyUsageLineItem1)
        Me.TabPageSupplyUsage.Controls.Add(Me.UserControlProduct4)
        Me.TabPageSupplyUsage.Controls.Add(Me.UserControlSupplyUsage1)
        Me.TabPageSupplyUsage.Controls.Add(Me.UserControlSupplies3)
        Me.TabPageSupplyUsage.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplyUsage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSupplyUsage.Name = "TabPageSupplyUsage"
        Me.TabPageSupplyUsage.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSupplyUsage.TabIndex = 6
        Me.TabPageSupplyUsage.Text = "Supply Usage"
        Me.TabPageSupplyUsage.UseVisualStyleBackColor = True
        '
        'UserControlSupplyUsageLineItem1
        '
        Me.UserControlSupplyUsageLineItem1.Location = New System.Drawing.Point(643, 2)
        Me.UserControlSupplyUsageLineItem1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSupplyUsageLineItem1.Name = "UserControlSupplyUsageLineItem1"
        Me.UserControlSupplyUsageLineItem1.Size = New System.Drawing.Size(640, 571)
        Me.UserControlSupplyUsageLineItem1.TabIndex = 3
        '
        'UserControlProduct4
        '
        Me.UserControlProduct4.Location = New System.Drawing.Point(3, 578)
        Me.UserControlProduct4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlProduct4.Name = "UserControlProduct4"
        Me.UserControlProduct4.Size = New System.Drawing.Size(972, 569)
        Me.UserControlProduct4.TabIndex = 2
        '
        'UserControlSupplyUsage1
        '
        Me.UserControlSupplyUsage1.Location = New System.Drawing.Point(3, 2)
        Me.UserControlSupplyUsage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlSupplyUsage1.Name = "UserControlSupplyUsage1"
        Me.UserControlSupplyUsage1.Size = New System.Drawing.Size(640, 571)
        Me.UserControlSupplyUsage1.TabIndex = 1
        '
        'UserControlSupplies3
        '
        Me.UserControlSupplies3.Location = New System.Drawing.Point(981, 577)
        Me.UserControlSupplies3.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlSupplies3.Name = "UserControlSupplies3"
        Me.UserControlSupplies3.Size = New System.Drawing.Size(860, 569)
        Me.UserControlSupplies3.TabIndex = 0
        '
        'TabPageEmpManagement
        '
        Me.TabPageEmpManagement.Controls.Add(Me.UserControlEmployee_Phone1)
        Me.TabPageEmpManagement.Controls.Add(Me.UserControlEmployee1)
        Me.TabPageEmpManagement.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEmpManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEmpManagement.Name = "TabPageEmpManagement"
        Me.TabPageEmpManagement.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageEmpManagement.TabIndex = 8
        Me.TabPageEmpManagement.Text = "Employee Management"
        Me.TabPageEmpManagement.UseVisualStyleBackColor = True
        '
        'UserControlEmployee_Phone1
        '
        Me.UserControlEmployee_Phone1.Location = New System.Drawing.Point(1081, 4)
        Me.UserControlEmployee_Phone1.Margin = New System.Windows.Forms.Padding(5)
        Me.UserControlEmployee_Phone1.Name = "UserControlEmployee_Phone1"
        Me.UserControlEmployee_Phone1.Size = New System.Drawing.Size(801, 597)
        Me.UserControlEmployee_Phone1.TabIndex = 1
        '
        'UserControlEmployee1
        '
        Me.UserControlEmployee1.Location = New System.Drawing.Point(5, 2)
        Me.UserControlEmployee1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlEmployee1.Name = "UserControlEmployee1"
        Me.UserControlEmployee1.Size = New System.Drawing.Size(1069, 745)
        Me.UserControlEmployee1.TabIndex = 0
        '
        'TabPageCustManagement
        '
        Me.TabPageCustManagement.Controls.Add(Me.UserControlCustomer_Phone2)
        Me.TabPageCustManagement.Controls.Add(Me.UserControlCustomer3)
        Me.TabPageCustManagement.Location = New System.Drawing.Point(4, 25)
        Me.TabPageCustManagement.Name = "TabPageCustManagement"
        Me.TabPageCustManagement.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageCustManagement.TabIndex = 9
        Me.TabPageCustManagement.Text = "Customer Management"
        Me.TabPageCustManagement.UseVisualStyleBackColor = True
        '
        'UserControlCustomer_Phone2
        '
        Me.UserControlCustomer_Phone2.Location = New System.Drawing.Point(1036, 4)
        Me.UserControlCustomer_Phone2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlCustomer_Phone2.Name = "UserControlCustomer_Phone2"
        Me.UserControlCustomer_Phone2.Size = New System.Drawing.Size(853, 591)
        Me.UserControlCustomer_Phone2.TabIndex = 1
        '
        'UserControlCustomer3
        '
        Me.UserControlCustomer3.Location = New System.Drawing.Point(3, 2)
        Me.UserControlCustomer3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControlCustomer3.Name = "UserControlCustomer3"
        Me.UserControlCustomer3.Size = New System.Drawing.Size(1024, 559)
        Me.UserControlCustomer3.TabIndex = 0
        '
        'TabPageSupplierManagement
        '
        Me.TabPageSupplierManagement.Controls.Add(Me.UserControlSupplier_Phone2)
        Me.TabPageSupplierManagement.Controls.Add(Me.UserControlSupplier3)
        Me.TabPageSupplierManagement.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSupplierManagement.Name = "TabPageSupplierManagement"
        Me.TabPageSupplierManagement.Size = New System.Drawing.Size(1885, 1153)
        Me.TabPageSupplierManagement.TabIndex = 10
        Me.TabPageSupplierManagement.Text = "Supplier Management"
        Me.TabPageSupplierManagement.UseVisualStyleBackColor = True
        '
        'UserControlSupplier_Phone2
        '
        Me.UserControlSupplier_Phone2.Location = New System.Drawing.Point(1028, 4)
        Me.UserControlSupplier_Phone2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlSupplier_Phone2.Name = "UserControlSupplier_Phone2"
        Me.UserControlSupplier_Phone2.Size = New System.Drawing.Size(853, 591)
        Me.UserControlSupplier_Phone2.TabIndex = 1
        '
        'UserControlSupplier3
        '
        Me.UserControlSupplier3.Location = New System.Drawing.Point(4, 4)
        Me.UserControlSupplier3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControlSupplier3.Name = "UserControlSupplier3"
        Me.UserControlSupplier3.Size = New System.Drawing.Size(1024, 559)
        Me.UserControlSupplier3.TabIndex = 0
        '
        'BtnQuitProgram
        '
        Me.BtnQuitProgram.Location = New System.Drawing.Point(109, 1184)
        Me.BtnQuitProgram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnQuitProgram.Name = "BtnQuitProgram"
        Me.BtnQuitProgram.Size = New System.Drawing.Size(87, 34)
        Me.BtnQuitProgram.TabIndex = 1
        Me.BtnQuitProgram.Text = "Exit"
        Me.BtnQuitProgram.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(17, 1184)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(85, 34)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1912, 1055)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnQuitProgram)
        Me.Controls.Add(Me.TabDashboard)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.TabPageSupplyPayments.ResumeLayout(False)
        Me.TabPageSupplyUsage.ResumeLayout(False)
        Me.TabPageEmpManagement.ResumeLayout(False)
        Me.TabPageCustManagement.ResumeLayout(False)
        Me.TabPageSupplierManagement.ResumeLayout(False)
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
    Friend WithEvents UserControlSupplies2 As CakeStore.UserControlSupplies
    Friend WithEvents UserControlSupplyUsage1 As CakeStore.UserControlSupplyUsage
    Friend WithEvents UserControlSupplies3 As CakeStore.UserControlSupplies
    Friend WithEvents UserControlProduct4 As CakeStore.UserControlProduct
    Friend WithEvents UserControlSupplyUsageLineItem1 As CakeStore.UserControlSupplyUsageLineItem
    Friend WithEvents UserControlSupplyDelivery2 As CakeStore.UserControlSupplyDelivery
    Friend WithEvents UserControlSupplyPayment1 As CakeStore.UserControlSupplyPayment
    Friend WithEvents TabPageCustManagement As System.Windows.Forms.TabPage
    Friend WithEvents UserControlCustomer_Phone2 As CakeStore.UserControlCustomer_Phone
    Friend WithEvents UserControlCustomer3 As CakeStore.UserControlCustomer
    Friend WithEvents TabPageSupplierManagement As System.Windows.Forms.TabPage
    Friend WithEvents UserControlSupplier_Phone2 As CakeStore.UserControlSupplier_Phone
    Friend WithEvents UserControlSupplier3 As CakeStore.UserControlSupplier
    Friend WithEvents UserControlSupplier4 As CakeStore.UserControlSupplier
End Class
