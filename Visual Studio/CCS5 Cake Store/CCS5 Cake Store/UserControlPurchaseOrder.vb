Public Class UserControlPurchaseOrder

    Public Shared TableClass As Purchase_Order

    Private Sub InitializeFields()

        TableClass = New Purchase_Order(Me.DataGridViewPurchaseOrder, DASHBOARD_CONNECTION)
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("purchase_order", "purchaseorderid"))
            .Add(SELECTED_SUPPLIER.Cells(0).Value)
            .Add(CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            .Add(Me.DateTimePickerPurchaseOrder.Value.Date)
            .Add(DateString)
            .Add(TimeString)
            .Add("0.00")
        End With

        Return Values
    End Function

    Private Sub BtnPurchaseOrderInsert_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderInsert.Click
        Try
            Dim values = GetFieldValues()

            TableClass.EventCreate(values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnPurchaseOrderDelete_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnPurchaseOrderUpdate_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderUpdate.Click
        TableClass.EventEdit(Me.DateTimePickerPurchaseOrder.Value.Date, Me.DataGridViewPurchaseOrder.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub UserControlPurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewPurchaseOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewPurchaseOrder.MouseUp
        Globals.SELECTED_PURCHASE_ORDER = Me.DataGridViewPurchaseOrder.CurrentRow
    End Sub
End Class
