Public Class FrmInventoryCreate

    Public ReturnValues() As String

    Private Sub BtnProdOK_Click(sender As Object, e As EventArgs) Handles BtnProdOK.Click
        Dim Values = New String() {
                Me.TxtProdId.Text,
                Me.TxtProdName.Text,
                Me.TxtProdSellingPrice.Text,
                Me.TxtProdQty.Text
            }
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnProdCancel_Click(sender As Object, e As EventArgs) Handles BtnProdCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class