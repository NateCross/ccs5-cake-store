Public Class UserControlSupplier

    Private FieldsArray As TextBox()
    Private TableClass As Supplier

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSupplierId,
            Me.TxtSupplierName,
            Me.TxtSupplierStreet,
            Me.TxtSupplierCity,
            Me.TxtSupplierProvince,
            Me.TxtSupplierEmailAddress
        }

        TableClass = New Supplier(Me.DataGridViewSupplier, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnSupplierInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplierInsert.Click
        Try
            Dim values = GetFieldValues()

            TableClass.EventCreate(values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSupplierDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplierDelete.Click
        Try
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

    Private Sub DataGridViewSupplier_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplier.MouseUp
        SELECTED_SUPPLIER = Me.DataGridViewSupplier.CurrentRow
    End Sub
End Class
