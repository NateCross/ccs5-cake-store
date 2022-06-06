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
        Me.TxtCustPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCust_PhoneInsert = New System.Windows.Forms.Button()
        Me.BtnCust_PhoneDelete = New System.Windows.Forms.Button()
        Me.BtnCust_PhoneUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.DataGridViewCustomer_Phone,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomer_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 501)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Customer Phone Numbers"
        '
        'DataGridViewCustomer_Phone
        '
        Me.DataGridViewCustomer_Phone.AllowUserToAddRows = false
        Me.DataGridViewCustomer_Phone.AllowUserToDeleteRows = false
        Me.DataGridViewCustomer_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer_Phone.Location = New System.Drawing.Point(3, 20)
        Me.DataGridViewCustomer_Phone.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewCustomer_Phone.Name = "DataGridViewCustomer_Phone"
        Me.DataGridViewCustomer_Phone.Size = New System.Drawing.Size(568, 474)
        Me.DataGridViewCustomer_Phone.TabIndex = 0
        '
        'TxtCustPhoneNo
        '
        Me.TxtCustPhoneNo.Location = New System.Drawing.Point(616, 240)
        Me.TxtCustPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustPhoneNo.Name = "TxtCustPhoneNo"
        Me.TxtCustPhoneNo.Size = New System.Drawing.Size(132, 22)
        Me.TxtCustPhoneNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(612, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Phone No."
        '
        'BtnCust_PhoneInsert
        '
        Me.BtnCust_PhoneInsert.Location = New System.Drawing.Point(616, 312)
        Me.BtnCust_PhoneInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCust_PhoneInsert.Name = "BtnCust_PhoneInsert"
        Me.BtnCust_PhoneInsert.Size = New System.Drawing.Size(133, 55)
        Me.BtnCust_PhoneInsert.TabIndex = 6
        Me.BtnCust_PhoneInsert.Text = "Insert New Customer Phone"
        Me.BtnCust_PhoneInsert.UseVisualStyleBackColor = true
        '
        'BtnCust_PhoneDelete
        '
        Me.BtnCust_PhoneDelete.Location = New System.Drawing.Point(616, 373)
        Me.BtnCust_PhoneDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCust_PhoneDelete.Name = "BtnCust_PhoneDelete"
        Me.BtnCust_PhoneDelete.Size = New System.Drawing.Size(133, 49)
        Me.BtnCust_PhoneDelete.TabIndex = 7
        Me.BtnCust_PhoneDelete.Text = "Delete Selected Customer Phone"
        Me.BtnCust_PhoneDelete.UseVisualStyleBackColor = true
        '
        'BtnCust_PhoneUpdate
        '
        Me.BtnCust_PhoneUpdate.Location = New System.Drawing.Point(615, 429)
        Me.BtnCust_PhoneUpdate.Name = "BtnCust_PhoneUpdate"
        Me.BtnCust_PhoneUpdate.Size = New System.Drawing.Size(133, 53)
        Me.BtnCust_PhoneUpdate.TabIndex = 8
        Me.BtnCust_PhoneUpdate.Text = "Update Selected Customer Phone"
        Me.BtnCust_PhoneUpdate.UseVisualStyleBackColor = true
        '
        'UserControlCustomer_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnCust_PhoneUpdate)
        Me.Controls.Add(Me.BtnCust_PhoneDelete)
        Me.Controls.Add(Me.BtnCust_PhoneInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCustPhoneNo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserControlCustomer_Phone"
        Me.Size = New System.Drawing.Size(799, 505)
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.DataGridViewCustomer_Phone,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomer_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCustPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnCust_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents BtnCust_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCust_PhoneUpdate As System.Windows.Forms.Button

End Class
