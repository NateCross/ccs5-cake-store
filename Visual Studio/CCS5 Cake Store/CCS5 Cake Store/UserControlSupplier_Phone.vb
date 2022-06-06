Public Class UserControlSupplier_Phone

    Private FieldsArray As TextBox()
    Private TableClass As Supplier_Phone

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSupplierPhoneNo
        }

        TableClass = New Supplier_Phone(Me.DataGridViewSupplier_Phone, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_SUPPLIER Is Nothing Then
            MsgBox("Please select a supplier first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(UtilityFunctions.GetIncrementedIndexID("supplier_phone", "supplierphoneid"))
            .Add(Globals.SELECTED_SUPPLIER.Cells(0).Value)
        End With

        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnSupplier_PhoneInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplier_PhoneInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            TableClass.EventCreate(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnSupplier_PhoneDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplier_PhoneDelete.Click
        Try
            If Me.DataGridViewSupplier_Phone.CurrentRow Is Nothing Then
                MsgBox("Please select a phone number first.", vbExclamation)
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

    Private Sub BtnSupplier_PhoneUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplier_PhoneUpdate.Click
        Try
            If Me.DataGridViewSupplier_Phone.CurrentRow Is Nothing Then
                MsgBox("Please select a phone number first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewSupplier_Phone.CurrentRow.Cells(0).Value
            TableClass.EventEdit(Values)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridViewSupplier_Phone_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplier_Phone.MouseUp
        Try
            If Me.DataGridViewSupplier_Phone.CurrentCell Is Nothing Then
                Return
            End If
            Me.TxtSupplierPhoneNo.Text = Me.DataGridViewSupplier_Phone.CurrentRow.Cells(2).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub
End Class
