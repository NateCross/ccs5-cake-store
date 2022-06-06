Imports IBM.Data.DB2

Public Class UserControlProductOrderLineItemTemp
    Private FieldsArray As TextBox()
    Private TableClass As Product_Order_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtQty
        }

        TableClass = New Product_Order_Line_Item(Me.DataGridViewProdOrderLineItem, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        Try
            For Each Field As TextBox In FieldsArray
                Field.Clear()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        If Globals.SELECTED_PRODUCT_ORDER Is Nothing Then
            MsgBox("Please select a product order first.", vbExclamation)
            Return Nothing
        End If
        If Globals.SELECTED_PRODUCT Is Nothing Then
            MsgBox("Please select a product first.", vbExclamation)
            Return Nothing
        End If
        If Me.TxtQty.Text = "" Then
            MsgBox("Please input a quantity first.", vbExclamation)
            Return Nothing
        End If

        Values.Add(Globals.SELECTED_PRODUCT_ORDER.Cells(0).Value)
        Values.Add(Globals.SELECTED_PRODUCT.Cells(0).Value)
        Values.Add(Globals.SELECTED_PRODUCT.Cells(2).Value)
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try

            If Me.DataGridViewProdOrderLineItem.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Me.DataGridViewProdOrderLineItem.Rows.Remove(Me.DataGridViewProdOrderLineItem.CurrentRow)
                MsgBox("Successfully deleted line item.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Try
            Dim values = GetFieldValues()
            If values Is Nothing Then
                Return
            End If

            Dim ConvertedValues = New String() {
                values(0),
                values(1),
                values(2),
                values(3)
            }
            Me.DataGridViewProdOrderLineItem.Rows.Add(ConvertedValues)
            MsgBox("Successfully inserted line item.")
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If Me.DataGridViewProdOrderLineItem.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            DataGridViewProdOrderLineItem.CurrentRow.Cells(3).Value = Values(3)
            MsgBox("Successfully edited line item.")
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        Try
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub UserControlProductOrderLineItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            With DataGridViewProdOrderLineItem
                .ColumnCount = 4
                .Columns(0).Name = "Product Order ID"
                .Columns(1).Name = "Product ID"
                .Columns(2).Name = "Price"
                .Columns(3).Name = "Quantity"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Sub UpdateSubtotal(ByRef ProdOrderId As String, ByRef ProdId As String, ByRef OrderQty As Integer)
        Dim StrGetSubtotal As String
        Dim StrUpdateSubtotal As String
        Dim StrGetQty As String
        Dim StrUpdateQty As String

        Dim CmdGetSubtotal As DB2Command
        Dim RdrGetSubtotal As DB2DataReader
        Dim CmdUpdateSubtotal As DB2Command
        Dim RdrGetQty As DB2DataReader
        Dim CmdUpdateQty As DB2Command
        Dim Subtotal As String
        Dim Qty As Integer

        Try
            StrGetSubtotal = "SELECT sum(prodorderlineitemprice * prodorderlineitemqty) from product_order_line_item where prodorderid = " & ProdOrderId
            CmdGetSubtotal = New DB2Command(StrGetSubtotal, DASHBOARD_CONNECTION)
            RdrGetSubtotal = CmdGetSubtotal.ExecuteReader

            If Not RdrGetSubtotal.HasRows Then
                Return
            End If

            RdrGetSubtotal.Read()
            Subtotal = RdrGetSubtotal.GetString(0)

            StrUpdateSubtotal = "UPDATE product_order SET prodordersubtotal =" & Subtotal & " where prodorderid =" & ProdOrderId
            CmdUpdateSubtotal = New DB2Command(StrUpdateSubtotal, DASHBOARD_CONNECTION)
            CmdUpdateSubtotal.ExecuteNonQuery()

            StrGetQty = "SELECT prodqty from product WHERE prodid=" & ProdId
            RdrGetQty = ExecuteReader(StrGetQty)

            If Not RdrGetQty.HasRows Then
                Return
            End If

            RdrGetQty.Read()
            Qty = RdrGetQty.GetInt32(0)
            Debug.WriteLine(Qty)
            Qty -= OrderQty

            StrUpdateQty = "UPDATE product SET prodqty=" & Qty & " where prodid=" & ProdId
            CmdUpdateQty = New DB2Command(StrUpdateQty, DASHBOARD_CONNECTION)
            CmdUpdateQty.ExecuteNonQuery()

            UserControlProductOrder.TableClass.RefreshDataGrid()
            UserControlProduct.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridViewProdOrderLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProdOrderLineItem.MouseUp
        Try
            If DataGridViewProdOrderLineItem.CurrentCell Is Nothing Then
                Return
            End If

            For i As Integer = 3 To Me.DataGridViewProdOrderLineItem.CurrentRow.Cells.Count - 1
                FieldsArray(i - 3).Text = Me.DataGridViewProdOrderLineItem.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub BtnAddItemsToProdOrder_Click(sender As Object, e As EventArgs) Handles BtnAddItemsToProdOrder.Click
        Try
            If DataGridViewProdOrderLineItem.RowCount = 0 Then
                MsgBox("Please add line items first.", vbExclamation)
                Return
            End If

            For i = 0 To Me.DataGridViewProdOrderLineItem.RowCount - 1
                Dim values = New List(Of String) From {
                    UtilityFunctions.GetIncrementedIndexID("product_order_line_item", "prodorderlineitemid"),
                Me.DataGridViewProdOrderLineItem.Rows(i).Cells(0).Value,
                Me.DataGridViewProdOrderLineItem.Rows(i).Cells(1).Value,
                Me.DataGridViewProdOrderLineItem.Rows(i).Cells(2).Value,
                Me.DataGridViewProdOrderLineItem.Rows(i).Cells(3).Value
                }
                TableClass.EventCreate(values)
                Call UpdateSubtotal(values(1), values(2), values(4))
            Next
            Me.DataGridViewProdOrderLineItem.Rows.Clear()
            MsgBox("Successfully saved product order.")
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
