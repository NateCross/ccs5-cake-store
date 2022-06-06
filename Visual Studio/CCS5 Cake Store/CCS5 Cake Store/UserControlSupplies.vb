Public Class UserControlSupplies

    Private FieldsArray As TextBox()
    Public Shared TableClass As Supplies

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSupplyName,
            Me.TxtSupplyQty,
            Me.TxtSupplyUnitOfMeasurement
        }

        TableClass = New Supplies(Me.DataGridViewSupplies)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        Values.Add(UtilityFunctions.GetIncrementedIndexID("supplies", "supplyid"))
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnSupplyInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyInsert.Click
        Try
            Dim Values = GetFieldValues()

            TableClass.EventCreate(Values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSupplyDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyDelete.Click
        Try
            If Me.DataGridViewSupplies.CurrentRow Is Nothing Then
                MsgBox("Please select a supply first.", vbExclamation)
                Return
            End If

            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub UserControlSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()

    End Sub

    Private Sub DataGridViewSupplies_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplies.MouseUp
        Try
            For i As Integer = 1 To DataGridViewSupplies.CurrentRow.Cells.Count - 1
                FieldsArray(i - 1).Text = Me.DataGridViewSupplies.CurrentRow.Cells(i).Value
            Next
            Globals.SELECTED_SUPPLY = Me.DataGridViewSupplies.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplyUpdate.Click
        Try
            If Me.DataGridViewSupplies.CurrentRow Is Nothing Then
                MsgBox("Please select a supply first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewSupplies.CurrentRow.Cells(0).Value

            TableClass.EventEdit(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub BtnSupplyClear_Click(sender As Object, e As EventArgs) Handles BtnSupplyClear.Click
        Try
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtSupplySearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSupplySearch.TextChanged
        Try
            TableClass.RefreshDataGridSearch(Me.TxtSupplySearch.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
