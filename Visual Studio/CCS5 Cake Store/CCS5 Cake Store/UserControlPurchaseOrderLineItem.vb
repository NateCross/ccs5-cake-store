Imports IBM.Data.DB2

Public Class UserControlPurchaseOrderLineItem

    Private FieldsArray As TextBox()
    Private TableClass As Purchase_Order_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtPurchaseOrderLineItemPrice,
            Me.TxtPurchaseOrderLineItemQty
        }

        TableClass = New Purchase_Order_Line_Item(Me.DataGridViewPurchaseOrderLineItem, DASHBOARD_CONNECTION)
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_PURCHASE_ORDER Is Nothing Then
            MsgBox("Please select a purchase order first.", vbExclamation)
            Return Nothing
        End If
        If Globals.SELECTED_SUPPLY Is Nothing Then
            MsgBox("Please select a supply first.", vbExclamation)
            Return Nothing
        End If


        Dim Values = New List(Of String)

        Values.Add(Globals.SELECTED_PURCHASE_ORDER.Cells(0).Value)
        Values.Add(Globals.SELECTED_SUPPLY.Cells(0).Value)
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub ClearFields()
        Try
            For Each Field As TextBox In FieldsArray
                Field.Clear()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPurchaseOrderLineItemInsert_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderLineItemInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            Dim ConvertedValues = New String() {
                Values(0),
                Values(1),
                Values(2),
                Values(3)
            }
            Me.DataGridViewPurchaseOrderLineItem.Rows.Add(ConvertedValues)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub BtnPurchaseOrderLineItemDelete_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderLineItemDelete.Click
        Try
            If Me.DataGridViewPurchaseOrderLineItem.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Call TableClass.DeleteInTemp()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPurchaseOrderLineItemUpdate_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderLineItemUpdate.Click
        Try
            If Me.DataGridViewPurchaseOrderLineItem.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            TableClass.EditInTemp(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnPurchaseOrderAddItems_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrderAddItems.Click
        Try
            If Me.DataGridViewPurchaseOrderLineItem.RowCount = 0 Then
                MsgBox("Please add supplies to the purchase order first.", vbExclamation)
                Return
            End If

            For i = 0 To Me.DataGridViewPurchaseOrderLineItem.RowCount - 2
                Dim Values = New List(Of String) From {
                    Me.DataGridViewPurchaseOrderLineItem.Rows(i).Cells(0).Value,
                    Me.DataGridViewPurchaseOrderLineItem.Rows(i).Cells(1).Value,
                    Me.DataGridViewPurchaseOrderLineItem.Rows(i).Cells(2).Value,
                    Me.DataGridViewPurchaseOrderLineItem.Rows(i).Cells(3).Value
                }
                TableClass.EventCreate(Values)
                Call UpdateSubtotal(Values(0), Values(1), Values(3))
            Next
            Me.DataGridViewPurchaseOrderLineItem.Rows.Clear()
            MsgBox("Successfully saved purchase order.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub UserControlPurchaseOrderLineItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub UpdateSubtotal(ByRef PurchaseOrderId As String, ByRef SupplyId As String, ByRef OrderQty As Decimal)
        Dim StrGetSubtotal As String
        Dim StrUpdateSubtotal As String

        Dim CmdGetSubtotal As DB2Command
        Dim RdrGetSubtotal As DB2DataReader
        Dim CmdUpdateSubtotal As DB2Command
        Dim Subtotal As String

        Try
            StrGetSubtotal = "SELECT sum(purchaseorderlineitemprice * purchaseorderlineitemqty) from purchase_order_line_item where purchaseorderid = " & PurchaseOrderId
            CmdGetSubtotal = New DB2Command(StrGetSubtotal, DASHBOARD_CONNECTION)
            RdrGetSubtotal = CmdGetSubtotal.ExecuteReader

            If Not RdrGetSubtotal.HasRows Then
                Return
            End If

            RdrGetSubtotal.Read()
            Subtotal = RdrGetSubtotal.GetString(0)

            StrUpdateSubtotal = "UPDATE purchase_order SET purchaseordersubtotal =" & Subtotal & " where purchaseorderid =" & PurchaseOrderId
            CmdUpdateSubtotal = New DB2Command(StrUpdateSubtotal, DASHBOARD_CONNECTION)
            CmdUpdateSubtotal.ExecuteNonQuery()

            UserControlPurchaseOrder.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridViewPurchaseOrderLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewPurchaseOrderLineItem.MouseUp
        Try
            If DataGridViewPurchaseOrderLineItem.CurrentCell Is Nothing Then
                Return
            End If

            For i As Integer = 2 To Me.DataGridViewPurchaseOrderLineItem.CurrentRow.Cells.Count - 1
                FieldsArray(i - 2).Text = Me.DataGridViewPurchaseOrderLineItem.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
