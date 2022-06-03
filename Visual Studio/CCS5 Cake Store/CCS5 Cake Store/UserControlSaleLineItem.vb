Imports IBM.Data.DB2

Public Class UserControlSaleLineItem
    Private FieldsArray As TextBox()
    Private TableClass As Sale_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSaleQty,
            Me.TxtSalePrice
        }

        TableClass = New Sale_Line_Item(Me.DataGridViewSaleLineItem, DASHBOARD_CONNECTION)
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
        Try
            Dim Values = New List(Of String)

            Values.Add(Globals.SELECTED_SALE.Cells(0).Value)
            Values.Add(Globals.SELECTED_PRODUCT.Cells(0).Value)
            For Each Field In FieldsArray
                Values.Add(Field.Text)
            Next

            Return Values
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub BtnSaleLineItemInsert_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemInsert.Click
        Try
            Dim values = GetFieldValues()
            Dim ConvertedValues = New String() {
                values(0),
                values(1),
                values(2),
                values(3)
            }
            Me.DataGridViewSaleTemp.Rows.Add(ConvertedValues)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemDelete_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Me.DataGridViewSaleTemp.Rows.Remove(Me.DataGridViewSaleTemp.CurrentRow)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemUpdate_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemUpdate.Click
        Try
            Dim Values = GetFieldValues()
            DataGridViewSaleTemp.CurrentRow.Cells(2).Value = Values(2)
            DataGridViewSaleTemp.CurrentRow.Cells(3).Value = Values(3)
            ' TableClass.EventEdit(Values)
            ' Call UpdateSubtotal(Values(1), Values(3), Values(4))
            ' Me.TxtSaleLineItemID.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSaleLineItemClearFields_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemClearFields.Click
        Try
            Call ClearFields()
            Me.TxtSaleLineItemID.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub InitializeTempDataGrid()
        Me.DataGridViewSaleTemp.ColumnCount = TableClass.ColumnArray.Count - 1
        For i As Integer = 1 To DataGridViewSaleTemp.ColumnCount - 1
            DataGridViewSaleTemp.Columns(i - 1).Name = TableClass.ColumnNames(i)
            DataGridViewSaleTemp.Columns(i - 1).Width = 150
        Next
        ' DataGridViewSaleTemp.Columns(0).Width = 110
        ' DataGridViewSaleTemp.Columns(0).ReadOnly = True
    End Sub

    Private Sub UserControlSaleLineItem_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
            Call InitializeTempDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSaleLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSaleLineItem.MouseUp
        Try
            For i As Integer = 2 To Me.DataGridViewSaleTemp.CurrentRow.Cells.Count - 1
                FieldsArray(i - 2).Text = Me.DataGridViewSaleLineItem.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' db2 select s.saleid, sum(li.salelineitemprice) as subtotal from sale s left join sale_line_item li on li.saleid = s.saleid group by s.saleid
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
        ' Loop to add each row in the temp one by one
        ' and call these functions repeatedly
        Try
            For i = 0 To Me.DataGridViewSaleTemp.RowCount - 2
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

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
