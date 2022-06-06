Public Class UserControlProduct
    Private FieldsArray As TextBox()
    Public Shared TableClass As Product

    Private Sub InitializeFields()
        FieldsArray = {
            Me.TxtProdName,
            Me.TxtProdSellingPrice,
            Me.TxtProdQty
        }
        TableClass = New Product(Me.DataGridViewProduct, DASHBOARD_CONNECTION)

    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub


    Private Sub UserControlProduct_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        Values.Add(UtilityFunctions.GetIncrementedIndexID("product", "prodid"))
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnProductCreate_Click(sender As Object, e As EventArgs) Handles BtnProductCreate.Click
        Try
            Dim Values = GetFieldValues()

            TableClass.EventCreate(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnProductDelete_Click(sender As Object, e As EventArgs) Handles BtnProductDelete.Click
        Try
            If Me.DataGridViewProduct.CurrentRow Is Nothing Then
                MsgBox("Please select a product first.", vbExclamation)
                Return
            End If
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridViewProduct_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProduct.MouseUp
        Try
            For i As Integer = 1 To DataGridViewProduct.CurrentRow.Cells.Count - 1
                FieldsArray(i - 1).Text = Me.DataGridViewProduct.CurrentRow.Cells(i).Value
            Next
            Globals.SELECTED_PRODUCT = Me.DataGridViewProduct.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnProdUpdate_Click(sender As Object, e As EventArgs) Handles BtnProdUpdate.Click
        Try
            If Me.DataGridViewProduct.CurrentRow Is Nothing Then
                MsgBox("Please select a product first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewProduct.CurrentRow.Cells(0).Value

            TableClass.EventEdit(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnProdClear_Click(sender As Object, e As EventArgs) Handles BtnProdClear.Click
        Try
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtProdNameSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtProdNameSearch.TextChanged
        Try
            TableClass.RefreshDataGridSearch(Me.TxtProdNameSearch.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
