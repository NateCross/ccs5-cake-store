Imports IBM.Data.DB2

Public Class UserControlSaleLineItem
    Private FieldsArray As TextBox()
    Private TableClass As Sale_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSaleQty
        }

        TableClass = New Sale_Line_Item(Me.DataGridViewSaleTemp)
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
        If Globals.SELECTED_SALE Is Nothing Then
            MsgBox("Please select a sale first.", vbExclamation)
            Return Nothing
        End If
        If Globals.SELECTED_PRODUCT Is Nothing Then
            MsgBox("Please select a product first.", vbExclamation)
            Return Nothing
        End If
        If FieldsArray(0).Text = "" Then
            MsgBox("Please input a quantity first.", vbExclamation)
            Return Nothing
        End If

        Values.Add(Globals.SELECTED_SALE.Cells(0).Value)
        Values.Add(Globals.SELECTED_PRODUCT.Cells(0).Value)
        Values.Add(Globals.SELECTED_PRODUCT.Cells(2).Value)
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next

        Return Values
    End Function

    Private Sub BtnSaleLineItemInsert_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemInsert.Click
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
            Me.DataGridViewSaleTemp.Rows.Add(ConvertedValues)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemDelete_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemDelete.Click
        Try
            If Me.DataGridViewSaleTemp.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.DeleteInTemp()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemUpdate_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemUpdate.Click
        Try
            If Me.DataGridViewSaleTemp.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = DataGridViewSaleTemp.CurrentRow.Cells(0).Value
            TableClass.EditInTemp(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSaleLineItemClearFields_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemClearFields.Click
        Try
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserControlSaleLineItem_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSaleLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSaleTemp.MouseUp
        Try
            If Me.DataGridViewSaleTemp.CurrentCell Is Nothing Then
                Return
            End If

            FieldsArray(0).Text = Me.DataGridViewSaleTemp.CurrentRow.Cells(3).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub UpdateSubtotal(ByRef SaleID As String, ByRef ProdId As String, ByRef SaleQty As Integer)
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
            StrGetSubtotal = "SELECT sum(salelineitemprice * salelineitemqty) from sale_line_item where saleid = " & SaleID
            CmdGetSubtotal = New DB2Command(StrGetSubtotal, DASHBOARD_CONNECTION)
            RdrGetSubtotal = CmdGetSubtotal.ExecuteReader

            If Not RdrGetSubtotal.HasRows Then
                Return
            End If

            RdrGetSubtotal.Read()
            Subtotal = RdrGetSubtotal.GetString(0)

            StrUpdateSubtotal = "UPDATE sale SET salesubtotal =" & Subtotal & " where saleid =" & SaleID
            CmdUpdateSubtotal = New DB2Command(StrUpdateSubtotal, DASHBOARD_CONNECTION)
            CmdUpdateSubtotal.ExecuteNonQuery()

            StrGetQty = "SELECT prodqty from product WHERE prodid=" & ProdId
            RdrGetQty = ExecuteReader(StrGetQty)

            If Not RdrGetQty.HasRows Then
                Return
            End If

            RdrGetQty.Read()
            Qty = RdrGetQty.GetInt32(0)
            Qty -= SaleQty

            StrUpdateQty = "UPDATE product SET prodqty=" & Qty & " where prodid=" & ProdId
            CmdUpdateQty = New DB2Command(StrUpdateQty, DASHBOARD_CONNECTION)
            CmdUpdateQty.ExecuteNonQuery()

            UserControlSale.TableClass.RefreshDataGrid()
            UserControlProduct.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAddToSale_Click(sender As Object, e As EventArgs) Handles BtnAddToSale.Click
        Try
            If Me.DataGridViewSaleTemp.RowCount = 0 Then
                MsgBox("Please add products to the sale first.", vbExclamation)
                Return
            End If

            For i = 0 To Me.DataGridViewSaleTemp.RowCount - 1
                Dim values = New List(Of String) From {
                    UtilityFunctions.GetIncrementedIndexID("sale_line_item", "salelineitemid"),
                    Me.DataGridViewSaleTemp.Rows(i).Cells(0).Value,
                    Me.DataGridViewSaleTemp.Rows(i).Cells(1).Value,
                    Me.DataGridViewSaleTemp.Rows(i).Cells(2).Value,
                    Me.DataGridViewSaleTemp.Rows(i).Cells(3).Value
                }
                TableClass.EventCreate(values)
                Call UpdateSubtotal(values(1), values(2), values(4))
            Next
            Me.DataGridViewSaleTemp.Rows.Clear()
            MsgBox("Successfully saved sale.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
