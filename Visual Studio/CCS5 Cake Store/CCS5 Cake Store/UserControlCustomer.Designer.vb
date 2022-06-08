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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCustEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCustProvince = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCustCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCustStreet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCustLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCustFirstName = New System.Windows.Forms.TextBox()
        Me.BtnCustClear = New System.Windows.Forms.Button()
        Me.BtnCustUpdate = New System.Windows.Forms.Button()
        Me.BtnCustCreate = New System.Windows.Forms.Button()
        Me.BtnCustDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCustLastNameSearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewCustomers = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCustEmailAddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtCustProvince)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtCustCity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtCustStreet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCustMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCustLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCustFirstName)
        Me.GroupBox1.Controls.Add(Me.BtnCustClear)
        Me.GroupBox1.Controls.Add(Me.BtnCustUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnCustCreate)
        Me.GroupBox1.Controls.Add(Me.BtnCustDelete)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCustLastNameSearch)
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomers)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(764, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customers"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(543, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Email Address"
        '
        'TxtCustEmailAddress
        '
        Me.TxtCustEmailAddress.Location = New System.Drawing.Point(546, 298)
        Me.TxtCustEmailAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustEmailAddress.Name = "TxtCustEmailAddress"
        Me.TxtCustEmailAddress.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustEmailAddress.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(543, 237)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Province"
        '
        'TxtCustProvince
        '
        Me.TxtCustProvince.Location = New System.Drawing.Point(546, 253)
        Me.TxtCustProvince.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustProvince.Name = "TxtCustProvince"
        Me.TxtCustProvince.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustProvince.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(543, 191)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "City"
        '
        'TxtCustCity
        '
        Me.TxtCustCity.Location = New System.Drawing.Point(546, 207)
        Me.TxtCustCity.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustCity.Name = "TxtCustCity"
        Me.TxtCustCity.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustCity.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(543, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Street"
        '
        'TxtCustStreet
        '
        Me.TxtCustStreet.Location = New System.Drawing.Point(546, 167)
        Me.TxtCustStreet.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustStreet.Name = "TxtCustStreet"
        Me.TxtCustStreet.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustStreet.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Middle Name"
        '
        'TxtCustMiddleName
        '
        Me.TxtCustMiddleName.Location = New System.Drawing.Point(546, 122)
        Me.TxtCustMiddleName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustMiddleName.Name = "TxtCustMiddleName"
        Me.TxtCustMiddleName.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustMiddleName.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Last Name"
        '
        'TxtCustLastName
        '
        Me.TxtCustLastName.Location = New System.Drawing.Point(546, 77)
        Me.TxtCustLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustLastName.Name = "TxtCustLastName"
        Me.TxtCustLastName.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustLastName.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(543, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "First Name"
        '
        'TxtCustFirstName
        '
        Me.TxtCustFirstName.Location = New System.Drawing.Point(546, 31)
        Me.TxtCustFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustFirstName.Name = "TxtCustFirstName"
        Me.TxtCustFirstName.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustFirstName.TabIndex = 29
        '
        'BtnCustClear
        '
        Me.BtnCustClear.Location = New System.Drawing.Point(503, 378)
        Me.BtnCustClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCustClear.Name = "BtnCustClear"
        Me.BtnCustClear.Size = New System.Drawing.Size(118, 40)
        Me.BtnCustClear.TabIndex = 28
        Me.BtnCustClear.Text = "Clear Fields"
        Me.BtnCustClear.UseVisualStyleBackColor = True
        '
        'BtnCustUpdate
        '
        Me.BtnCustUpdate.Location = New System.Drawing.Point(625, 334)
        Me.BtnCustUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCustUpdate.Name = "BtnCustUpdate"
        Me.BtnCustUpdate.Size = New System.Drawing.Size(118, 40)
        Me.BtnCustUpdate.TabIndex = 27
        Me.BtnCustUpdate.Text = "Update Selected Row"
        Me.BtnCustUpdate.UseVisualStyleBackColor = True
        '
        'BtnCustCreate
        '
        Me.BtnCustCreate.AutoSize = True
        Me.BtnCustCreate.Location = New System.Drawing.Point(503, 334)
        Me.BtnCustCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCustCreate.Name = "BtnCustCreate"
        Me.BtnCustCreate.Size = New System.Drawing.Size(118, 40)
        Me.BtnCustCreate.TabIndex = 26
        Me.BtnCustCreate.Text = "Insert New Entry"
        Me.BtnCustCreate.UseVisualStyleBackColor = True
        '
        'BtnCustDelete
        '
        Me.BtnCustDelete.AutoSize = True
        Me.BtnCustDelete.Location = New System.Drawing.Point(625, 378)
        Me.BtnCustDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCustDelete.Name = "BtnCustDelete"
        Me.BtnCustDelete.Size = New System.Drawing.Size(118, 40)
        Me.BtnCustDelete.TabIndex = 25
        Me.BtnCustDelete.Text = "Delete Selected Row"
        Me.BtnCustDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Last Names:"
        '
        'TxtCustLastNameSearch
        '
        Me.TxtCustLastNameSearch.Location = New System.Drawing.Point(111, 17)
        Me.TxtCustLastNameSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustLastNameSearch.Name = "TxtCustLastNameSearch"
        Me.TxtCustLastNameSearch.Size = New System.Drawing.Size(368, 20)
        Me.TxtCustLastNameSearch.TabIndex = 1
        '
        'DataGridViewCustomers
        '
        Me.DataGridViewCustomers.AllowUserToAddRows = False
        Me.DataGridViewCustomers.AllowUserToDeleteRows = False
        Me.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomers.Location = New System.Drawing.Point(4, 40)
        Me.DataGridViewCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewCustomers.Name = "DataGridViewCustomers"
        Me.DataGridViewCustomers.RowTemplate.Height = 24
        Me.DataGridViewCustomers.Size = New System.Drawing.Size(475, 400)
        Me.DataGridViewCustomers.TabIndex = 0
        '
        'UserControlCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UserControlCustomer"
        Me.Size = New System.Drawing.Size(768, 454)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCustLastNameSearch As System.Windows.Forms.TextBox
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
    Friend WithEvents BtnCustClear As System.Windows.Forms.Button
    Friend WithEvents BtnCustUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnCustCreate As System.Windows.Forms.Button
    Friend WithEvents BtnCustDelete As System.Windows.Forms.Button

End Class
