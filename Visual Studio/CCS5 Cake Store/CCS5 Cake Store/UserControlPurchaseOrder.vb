Public Class UserControlPurchaseOrder

    Public Shared TableClass As Purchase_Order

    Public Sub InitializeFields()

        TableClass = New Purchase_Order(Me.DataGridViewPurchaseOrder, DASHBOARD_CONNECTION)
        TableClass.Initialize()
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_SUPPLIER Is Nothing Then
            MsgBox("Please select a supplier first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(UtilityFunctions.GetIncrementedIndexID("purchase_order", "purchaseorderid"))
            .Add(Globals.SELECTED_SUPPLIER.Cells(0).Value)
            .Add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            .Add(Me.DateTimePickerPurchaseOrder.Value.Date.ToString("MM-dd-yyyy"))
            .Add(DateString)
            .Add(TimeString)
            .Add("0.00")
        End With

        Return Values
    End Function

    Private Sub BtnPurchaseOrderInsert_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            TableClass.EventCreate(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnPurchaseOrderDelete_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderDelete.Click
        Try
            If Me.DataGridViewPurchaseOrder.CurrentRow Is Nothing Then
                MsgBox("Please select a purchase order first.", vbExclamation)
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

    Private Sub BtnPurchaseOrderUpdate_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderUpdate.Click
        If Me.DataGridViewPurchaseOrder.CurrentRow Is Nothing Then
            MsgBox("Please select a purchase order first.", vbExclamation)
            Return
        End If

        TableClass.EventEdit(Me.DateTimePickerPurchaseOrder.Value.Date.ToString("MM-dd-yyyy"), Me.DataGridViewPurchaseOrder.CurrentRow.Cells(0).Value)
    End Sub

    ' Private Sub UserControlPurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Paint
    '     Debug.WriteLine("Paint triggered")
    '     Call InitializeFields()
    ' End Sub

    Private Sub DataGridViewPurchaseOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewPurchaseOrder.MouseUp
        If DataGridViewPurchaseOrder.CurrentCell Is Nothing Then
            Return
        End If
        Globals.SELECTED_PURCHASE_ORDER = Me.DataGridViewPurchaseOrder.CurrentRow
    End Sub
End Class
