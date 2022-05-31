<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventoryCreate
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
        Me.TxtProdId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProdName = New System.Windows.Forms.TextBox()
        Me.TxtProdSellingPrice = New System.Windows.Forms.TextBox()
        Me.TxtProdQty = New System.Windows.Forms.TextBox()
        Me.BtnProdOK = New System.Windows.Forms.Button()
        Me.BtnProdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtProdId
        '
        Me.TxtProdId.Location = New System.Drawing.Point(191, 30)
        Me.TxtProdId.Name = "TxtProdId"
        Me.TxtProdId.Size = New System.Drawing.Size(196, 22)
        Me.TxtProdId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product ID*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selling Price*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity*"
        '
        'TxtProdName
        '
        Me.TxtProdName.Location = New System.Drawing.Point(191, 71)
        Me.TxtProdName.Name = "TxtProdName"
        Me.TxtProdName.Size = New System.Drawing.Size(196, 22)
        Me.TxtProdName.TabIndex = 5
        '
        'TxtProdSellingPrice
        '
        Me.TxtProdSellingPrice.Location = New System.Drawing.Point(191, 110)
        Me.TxtProdSellingPrice.Name = "TxtProdSellingPrice"
        Me.TxtProdSellingPrice.Size = New System.Drawing.Size(196, 22)
        Me.TxtProdSellingPrice.TabIndex = 6
        '
        'TxtProdQty
        '
        Me.TxtProdQty.Location = New System.Drawing.Point(191, 149)
        Me.TxtProdQty.Name = "TxtProdQty"
        Me.TxtProdQty.Size = New System.Drawing.Size(196, 22)
        Me.TxtProdQty.TabIndex = 7
        '
        'BtnProdOK
        '
        Me.BtnProdOK.Location = New System.Drawing.Point(323, 205)
        Me.BtnProdOK.Name = "BtnProdOK"
        Me.BtnProdOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnProdOK.TabIndex = 8
        Me.BtnProdOK.Text = "OK"
        Me.BtnProdOK.UseVisualStyleBackColor = True
        '
        'BtnProdCancel
        '
        Me.BtnProdCancel.Location = New System.Drawing.Point(427, 205)
        Me.BtnProdCancel.Name = "BtnProdCancel"
        Me.BtnProdCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnProdCancel.TabIndex = 9
        Me.BtnProdCancel.Text = "Cancel"
        Me.BtnProdCancel.UseVisualStyleBackColor = True
        '
        'FrmInventoryCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 240)
        Me.Controls.Add(Me.BtnProdCancel)
        Me.Controls.Add(Me.BtnProdOK)
        Me.Controls.Add(Me.TxtProdQty)
        Me.Controls.Add(Me.TxtProdSellingPrice)
        Me.Controls.Add(Me.TxtProdName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProdId)
        Me.Name = "FrmInventoryCreate"
        Me.Text = "FrmInventoryCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtProdId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtProdName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProdSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtProdQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnProdOK As System.Windows.Forms.Button
    Friend WithEvents BtnProdCancel As System.Windows.Forms.Button
End Class
