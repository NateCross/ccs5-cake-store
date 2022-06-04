Public Class UserControlSupplyDelivery

    Public Shared TableClass As Supply_Delivery

    Private Sub InitializeFields()

        TableClass = New Supply_Delivery(Me.DataGridViewSupplyDelivery, DASHBOARD_CONNECTION)
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("supply_delivery", "supplydeliveryid"))
            .Add(SELECTED_SUPPLIER.Cells(0).Value)
            .Add(CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            .Add(SELECTED_PURCHASE_ORDER.Cells(0).Value)
            .Add(Me.DateTimePickerSupplyDelivery.Value.Date.ToString("MM-dd-yyyy"))
            .Add(DateString)
            .Add(TimeString)
        End With

        Return Values
    End Function

    Private Sub BtnSupplyDeliveryInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyDeliveryInsert.Click
        Try
            Dim Values = GetFieldValues()

            TableClass.EventCreate(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyDeliveryDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyDeliveryDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyDeliveryUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplyDeliveryUpdate.Click
        Try
            TableClass.EventEdit(Me.DateTimePickerSupplyDelivery.Value.Date, Me.DataGridViewSupplyDelivery.CurrentRow.Cells(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSupplyDelivery_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplyDelivery.MouseUp
        Globals.SELECTED_SUPPLY_DELIVERY = Me.DataGridViewSupplyDelivery.CurrentRow
    End Sub

    Private Sub UserControlSupplyDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub
End Class
