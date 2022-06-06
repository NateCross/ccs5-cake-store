Public Class UserControlSupplier

    Private FieldsArray As TextBox()
    Private TableClass As Supplier

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSupplierName,
            Me.TxtSupplierStreet,
            Me.TxtSupplierCity,
            Me.TxtSupplierProvince,
            Me.TxtSupplierEmailAddress
        }

        TableClass = New Supplier(Me.DataGridViewSupplier)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        Values.Add(UtilityFunctions.GetIncrementedIndexID("supplier", "supplierid"))
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnSupplierInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplierInsert.Click
        Try
            Dim Values = GetFieldValues()

            TableClass.EventCreate(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnSupplierDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplierDelete.Click
        Try
            If Me.DataGridViewSupplier.CurrentRow Is Nothing Then
                MsgBox("Please select a supplier first.", vbExclamation)
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

    Private Sub UserControlSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()

    End Sub

    Private Sub DataGridViewSupplier_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplier.MouseUp
        Try
            If DataGridViewSupplier.CurrentCell Is Nothing Then
                Return
            End If

            For i As Integer = 1 To DataGridViewSupplier.CurrentRow.Cells.Count - 1
                FieldsArray(i - 1).Text = Me.DataGridViewSupplier.CurrentRow.Cells(i).Value
            Next
            Globals.SELECTED_SUPPLIER = Me.DataGridViewSupplier.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub BtnSupplierClear_Click(sender As Object, e As EventArgs) Handles BtnSupplierClear.Click
        Try
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtSupplierSearchName_TextChanged(sender As Object, e As EventArgs) Handles TxtSupplierSearchName.TextChanged
        Try
            TableClass.RefreshDataGridSearch(Me.TxtSupplierSearchName.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplierUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplierUpdate.Click
        Try
            If Me.DataGridViewSupplier.CurrentRow Is Nothing Then
                MsgBox("Please select a supplier first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewSupplier.CurrentRow.Cells(0).Value

            TableClass.EventEdit(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub
End Class
