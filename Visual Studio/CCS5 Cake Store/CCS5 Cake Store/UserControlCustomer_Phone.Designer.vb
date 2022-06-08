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
        Me.BtnCust_PhoneUpdate = New System.Windows.Forms.Button()
        Me.BtnCust_PhoneDelete = New System.Windows.Forms.Button()
        Me.BtnCust_PhoneInsert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCustPhoneNo = New System.Windows.Forms.TextBox()
        Me.DataGridViewCustomer_Phone = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewCustomer_Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnCust_PhoneUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnCust_PhoneDelete)
        Me.GroupBox1.Controls.Add(Me.BtnCust_PhoneInsert)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCustPhoneNo)
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomer_Phone)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Phone Numbers"
        '
        'BtnCust_PhoneUpdate
        '
        Me.BtnCust_PhoneUpdate.Location = New System.Drawing.Point(485, 245)
        Me.BtnCust_PhoneUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCust_PhoneUpdate.Name = "BtnCust_PhoneUpdate"
        Me.BtnCust_PhoneUpdate.Size = New System.Drawing.Size(100, 50)
        Me.BtnCust_PhoneUpdate.TabIndex = 13
        Me.BtnCust_PhoneUpdate.Text = "Update Selected Customer Phone"
        Me.BtnCust_PhoneUpdate.UseVisualStyleBackColor = True
        '
        'BtnCust_PhoneDelete
        '
        Me.BtnCust_PhoneDelete.Location = New System.Drawing.Point(485, 190)
        Me.BtnCust_PhoneDelete.Name = "BtnCust_PhoneDelete"
        Me.BtnCust_PhoneDelete.Size = New System.Drawing.Size(100, 50)
        Me.BtnCust_PhoneDelete.TabIndex = 12
        Me.BtnCust_PhoneDelete.Text = "Delete Selected Customer Phone"
        Me.BtnCust_PhoneDelete.UseVisualStyleBackColor = True
        '
        'BtnCust_PhoneInsert
        '
        Me.BtnCust_PhoneInsert.Location = New System.Drawing.Point(485, 135)
        Me.BtnCust_PhoneInsert.Name = "BtnCust_PhoneInsert"
        Me.BtnCust_PhoneInsert.Size = New System.Drawing.Size(100, 50)
        Me.BtnCust_PhoneInsert.TabIndex = 11
        Me.BtnCust_PhoneInsert.Text = "Insert New Customer Phone"
        Me.BtnCust_PhoneInsert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(460, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Customer Phone No."
        '
        'TxtCustPhoneNo
        '
        Me.TxtCustPhoneNo.Location = New System.Drawing.Point(463, 75)
        Me.TxtCustPhoneNo.Name = "TxtCustPhoneNo"
        Me.TxtCustPhoneNo.Size = New System.Drawing.Size(150, 20)
        Me.TxtCustPhoneNo.TabIndex = 9
        '
        'DataGridViewCustomer_Phone
        '
        Me.DataGridViewCustomer_Phone.AllowUserToAddRows = False
        Me.DataGridViewCustomer_Phone.AllowUserToDeleteRows = False
        Me.DataGridViewCustomer_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer_Phone.Location = New System.Drawing.Point(2, 16)
        Me.DataGridViewCustomer_Phone.Name = "DataGridViewCustomer_Phone"
        Me.DataGridViewCustomer_Phone.Size = New System.Drawing.Size(430, 454)
        Me.DataGridViewCustomer_Phone.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "+63"
        '
        'UserControlCustomer_Phone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControlCustomer_Phone"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewCustomer_Phone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomer_Phone As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCust_PhoneUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnCust_PhoneDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCust_PhoneInsert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCustPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
