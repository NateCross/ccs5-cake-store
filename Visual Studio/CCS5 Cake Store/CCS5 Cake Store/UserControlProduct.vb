Public Class UserControlProduct

    Private Sub ClearFields()
        Me.TxtProdId.Clear()
        Me.TxtProdName.Clear()
        Me.TxtProdQty.Clear()
        Me.TxtProdSellingPrice.Clear()
    End Sub

    Private Sub UserControlProduct_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Dim Prod As New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
        Prod.Initialize()
    End Sub

    Private Sub BtnProductCreate_Click(sender As Object, e As EventArgs) Handles BtnProductCreate.Click
        Dim Values = New String() {
                    Me.TxtProdId.Text,
                    Me.TxtProdName.Text,
                    Me.TxtProdSellingPrice.Text,
                    Me.TxtProdQty.Text
                }
        Dim Prod As New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
        Prod.EventCreate(Values)
        Call ClearFields()
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

    Private Sub DataGridViewProduct_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProduct.MouseUp
        Try
            Me.TxtProdId.Text = Me.DataGridViewProduct.CurrentRow.Cells(0).Value
            Me.TxtProdName.Text = Me.DataGridViewProduct.CurrentRow.Cells(1).Value
            Me.TxtProdSellingPrice.Text = Me.DataGridViewProduct.CurrentRow.Cells(2).Value
            Me.TxtProdQty.Text = Me.DataGridViewProduct.CurrentRow.Cells(3).Value
            Me.TxtProdId.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnProdUpdate_Click(sender As Object, e As EventArgs) Handles BtnProdUpdate.Click
        Dim Values = New String() {
                Me.TxtProdId.Text,
                Me.TxtProdName.Text,
                Me.TxtProdSellingPrice.Text,
                Me.TxtProdQty.Text
            }

        Try
            Dim Prod = New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)
            Prod.EventEdit(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.TxtProdId.Enabled = True

    End Sub

    Private Sub BtnProdClear_Click(sender As Object, e As EventArgs) Handles BtnProdClear.Click
        Try
            Call ClearFields()
            Me.TxtProdId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
