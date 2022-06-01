<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlCustomer
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
        Me.BtnCustCreate = New System.Windows.Forms.Button()
        Me.BtnCustDelete = New System.Windows.Forms.Button()
        Me.DataGridViewCustomers = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCustUpdate = New System.Windows.Forms.Button()
        Me.BtnCustClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCustLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCustFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCustId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCustEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCustProvince = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCustCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCustStreet = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomers)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 655)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customers"
        '
        'BtnCustCreate
        '
        Me.BtnCustCreate.AutoSize = True
        Me.BtnCustCreate.Location = New System.Drawing.Point(103, 480)
        Me.BtnCustCreate.Name = "BtnCustCreate"
        Me.BtnCustCreate.Size = New System.Drawing.Size(156, 35)
        Me.BtnCustCreate.TabIndex = 3
        Me.BtnCustCreate.Text = "Insert New Entry"
        Me.BtnCustCreate.UseVisualStyleBackColor = True
        '
        'BtnCustDelete
        '
        Me.BtnCustDelete.AutoSize = True
        Me.BtnCustDelete.Location = New System.Drawing.Point(103, 521)
        Me.BtnCustDelete.Name = "BtnCustDelete"
        Me.BtnCustDelete.Size = New System.Drawing.Size(156, 35)
        Me.BtnCustDelete.TabIndex = 3
        Me.BtnCustDelete.Text = "Delete Selected Row"
        Me.BtnCustDelete.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomers
        '
        Me.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomers.Location = New System.Drawing.Point(6, 21)
        Me.DataGridViewCustomers.Name = "DataGridViewCustomers"
        Me.DataGridViewCustomers.RowTemplate.Height = 24
        Me.DataGridViewCustomers.Size = New System.Drawing.Size(704, 628)
        Me.DataGridViewCustomers.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtCustEmailAddress)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCustProvince)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtCustCity)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtCustStreet)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCustMiddleName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtCustLastName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCustFirstName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCustId)
        Me.GroupBox2.Controls.Add(Me.BtnCustClear)
        Me.GroupBox2.Controls.Add(Me.BtnCustUpdate)
        Me.GroupBox2.Controls.Add(Me.BtnCustCreate)
        Me.GroupBox2.Controls.Add(Me.BtnCustDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(725, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 655)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fields"
        '
        'BtnCustUpdate
        '
        Me.BtnCustUpdate.Location = New System.Drawing.Point(103, 562)
        Me.BtnCustUpdate.Name = "BtnCustUpdate"
        Me.BtnCustUpdate.Size = New System.Drawing.Size(156, 23)
        Me.BtnCustUpdate.TabIndex = 4
        Me.BtnCustUpdate.Text = "Update Selected Row"
        Me.BtnCustUpdate.UseVisualStyleBackColor = True
        '
        'BtnCustClear
        '
        Me.BtnCustClear.Location = New System.Drawing.Point(103, 591)
        Me.BtnCustClear.Name = "BtnCustClear"
        Me.BtnCustClear.Size = New System.Drawing.Size(156, 23)
        Me.BtnCustClear.TabIndex = 5
        Me.BtnCustClear.Text = "Clear Fields"
        Me.BtnCustClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Middle Name"
        '
        'TxtCustMiddleName
        '
        Me.TxtCustMiddleName.Location = New System.Drawing.Point(9, 203)
        Me.TxtCustMiddleName.Name = "TxtCustMiddleName"
        Me.TxtCustMiddleName.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustMiddleName.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Last Name"
        '
        'TxtCustLastName
        '
        Me.TxtCustLastName.Location = New System.Drawing.Point(9, 148)
        Me.TxtCustLastName.Name = "TxtCustLastName"
        Me.TxtCustLastName.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustLastName.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "First Name"
        '
        'TxtCustFirstName
        '
        Me.TxtCustFirstName.Location = New System.Drawing.Point(9, 91)
        Me.TxtCustFirstName.Name = "TxtCustFirstName"
        Me.TxtCustFirstName.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustFirstName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Customer ID*"
        '
        'TxtCustId
        '
        Me.TxtCustId.Location = New System.Drawing.Point(9, 41)
        Me.TxtCustId.Name = "TxtCustId"
        Me.TxtCustId.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustId.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Email Address"
        '
        'TxtCustEmailAddress
        '
        Me.TxtCustEmailAddress.Location = New System.Drawing.Point(9, 420)
        Me.TxtCustEmailAddress.Name = "TxtCustEmailAddress"
        Me.TxtCustEmailAddress.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustEmailAddress.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Province"
        '
        'TxtCustProvince
        '
        Me.TxtCustProvince.Location = New System.Drawing.Point(9, 365)
        Me.TxtCustProvince.Name = "TxtCustProvince"
        Me.TxtCustProvince.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustProvince.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "City"
        '
        'TxtCustCity
        '
        Me.TxtCustCity.Location = New System.Drawing.Point(9, 308)
        Me.TxtCustCity.Name = "TxtCustCity"
        Me.TxtCustCity.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustCity.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Street"
        '
        'TxtCustStreet
        '
        Me.TxtCustStreet.Location = New System.Drawing.Point(9, 258)
        Me.TxtCustStreet.Name = "TxtCustStreet"
        Me.TxtCustStreet.Size = New System.Drawing.Size(250, 22)
        Me.TxtCustStreet.TabIndex = 17
        '
        'UserControlCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlCustomer"
        Me.Size = New System.Drawing.Size(1000, 661)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCustDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCustCreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCustClear As System.Windows.Forms.Button
    Friend WithEvents BtnCustUpdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCustEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCustProvince As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCustCity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCustStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCustMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCustLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCustFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCustId As System.Windows.Forms.TextBox

End Class
