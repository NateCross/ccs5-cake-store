Public Class UserControlProduct

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduct.CellEndEdit
        Dim Prod As New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
        Prod.EventEdit()
    End Sub

    Private Sub UserControlProduct_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Dim Prod As New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
        Prod.Initialize()
    End Sub

    Private Sub BtnProductCreate_Click(sender As Object, e As EventArgs) Handles BtnProductCreate.Click
        Dim ReturnValues = New FrmInventoryCreate

        Try
            If Not ReturnValues.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Return
            End If
            Dim Values = New String() {
                    ReturnValues.TxtProdId.Text,
                    ReturnValues.TxtProdName.Text,
                    ReturnValues.TxtProdSellingPrice.Text,
                    ReturnValues.TxtProdQty.Text
                }
            Dim Prod As New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
            Prod.EventCreate(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnProductDelete_Click(sender As Object, e As EventArgs) Handles BtnProductDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Dim Prod = New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
                Prod.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
