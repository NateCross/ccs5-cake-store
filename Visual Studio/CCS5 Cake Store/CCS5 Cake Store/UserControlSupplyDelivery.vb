Imports IBM.Data.DB2

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

            Call UpdateSupplyQuantities(Values(3))
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

    Private Sub UpdateSupplyQuantities(ByRef PurchaseOrderId As String)
        Dim StrGetAddedSupplies As String
        Dim RdrGetAddedSupplies As DB2DataReader
        Dim StrUpdateSupplies As String
        Dim CmdUpdateSupplies As DB2Command

        Try
            StrGetAddedSupplies = "SELECT supplyid, sum(purchaseorderlineitemqty) FROM purchase_order_line_item WHERE purchaseorderid=" & PurchaseOrderId & " GROUP BY supplyid"
            RdrGetAddedSupplies = ExecuteReader(StrGetAddedSupplies)
            If (Not RdrGetAddedSupplies.HasRows) Then
                Return
            End If

            While RdrGetAddedSupplies.Read
                StrUpdateSupplies = "UPDATE supplies SET supplyqty=supplyqty +" & RdrGetAddedSupplies.GetString(1) & " WHERE supplyid=" & RdrGetAddedSupplies.GetString(0)
                CmdUpdateSupplies = New DB2Command(StrUpdateSupplies, DASHBOARD_CONNECTION)
                CmdUpdateSupplies.ExecuteNonQuery()
            End While

            MsgBox("Successfully updated supply quantities.")
            UserControlSupplies.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub
End Class
