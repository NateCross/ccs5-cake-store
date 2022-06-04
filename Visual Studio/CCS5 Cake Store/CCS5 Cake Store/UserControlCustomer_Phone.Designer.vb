<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlCustomer_Phone
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
        Me.DataGridViewCustomer_Phone = New System.Windows.Forms.DataGridView()
        Me.TxtCustPhoneId = New System.Windows.Forms.TextBox()
        Me.TxtCustId = New System.Windows.Forms.TextBox()
        Me.TxtCustPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCust_PhoneInsert = New System.Windows.Forms.Button()
        Me.BtnCust_PhoneDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewCustomer_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomer_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 407)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer_Phone"
        '
        'DataGridViewCustomer_Phone
        '
        Me.DataGridViewCustomer_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer_Phone.Location = New System.Drawing.Point(2, 16)
        Me.DataGridViewCustomer_Phone.Name = "DataGridViewCustomer_Phone"
        Me.DataGridViewCustomer_Phone.Size = New System.Drawing.Size(426, 385)
        Me.DataGridViewCustomer_Phone.TabIndex = 0
        '
        'TxtCustPhoneId
        '
        Me.TxtCustPhoneId.Location = New System.Drawing.Point(462, 69)
        Me.TxtCustPhoneId.Name = "TxtCustPhoneId"
        Me.TxtCustPhoneId.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustPhoneId.TabIndex = 1
        '
        'TxtCustId
        '
        Me.TxtCustId.Location = New System.Drawing.Point(462, 139)
        Me.TxtCustId.Name = "TxtCustId"
        Me.TxtCustId.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustId.TabIndex = 2
        '
        'TxtCustPhoneNo
        '
        Me.TxtCustPhoneNo.Location = New System.Drawing.Point(462, 214)
        Me.TxtCustPhoneNo.Name = "TxtCustPhoneNo"
        Me.TxtCustPhoneNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustPhoneNo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Phone ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(459, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Phone No."
        '
        'BtnCust_PhoneInsert
        '
        Me.BtnCust_PhoneInsert.Location = New System.Drawing.Point(462, 263)
        Me.BtnCust_PhoneInsert.Name = "BtnCust_PhoneInsert"
        Me.BtnCust_PhoneInsert.Size = New System.Drawing.Size(100, 45)
        Me.BtnCust_PhoneInsert.TabIndex = 6
        Me.BtnCust_PhoneInsert.Text = "Insert New Customer Phone"
        Me.BtnCust_PhoneInsert.UseVisualStyleBackColor = True
        '
        'BtnCust_PhoneDelete
        '
        Me.BtnCust_PhoneDelete.Location = New System.Drawing.Point(462, 333)
        Me.BtnCust_PhoneDelete.Name = "BtnCust_PhoneDelete"
        Me.BtnCust_PhoneDelete.Size = New System.Drawing.Size(100, 40)
        Me.BtnCust_PhoneDelete.TabIndex = 7
        Me.BtnCust_PhoneDelete.Text = "Delete Selected Customer Phone"
        Me.BtnCust_PhoneDelete.UseVisualStyleBackColor = True
        '
        'UserControlCustomer_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnCust_PhoneDelete)
        Me.Controls.Add(Me.BtnCust_PhoneInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCustPhoneId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCustId)
        Me.Controls.Add(Me.TxtCustPhoneNo)
        Me.Name = "UserControlCustomer_Phone"
        Me.Size = New System.Drawing.Size(599, 410)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewCustomer_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomer_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCustPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustId As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustPhoneId As System.Windows.Forms.TextBox
    Friend WithEvents BtnCust_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents BtnCust_PhoneDelete As System.Windows.Forms.Button

End Class
