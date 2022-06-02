Imports IBM.Data.DB2

Public Class UserControlProductOrderLineItem
    Private FieldsArray As TextBox()
    Private TableClass As Product_Order_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtProdOrderLineItemId,
            Me.TxtProdOrderId,
            Me.TxtProdId,
            Me.TxtPrice,
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
        Try
            Dim Values = New List(Of String)
            For Each Field In FieldsArray
                Values.Add(Field.Text)
            Next
            Return Values
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
                Call UpdateSubtotal(TableClass.DataGridView.CurrentRow.Cells(1).Value, TableClass.DataGridView.CurrentRow.Cells(2).Value, TableClass.DataGridView.CurrentRow.Cells(4).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Try
            Dim values = GetFieldValues()
            TableClass.EventCreate(values)
            Call UpdateSubtotal(values(1), values(2), values(4))
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim Values = GetFieldValues()
            TableClass.EventEdit(Values)
            Call UpdateSubtotal(Values(1), Values(2), Values(4))
            Me.TxtProdOrderLineItemId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Try
            Call ClearFields()
            Me.TxtProdOrderLineItemId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub UserControlProductOrderLineItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub UpdateQuantity(ByRef ProdId As String, ByRef OrderQty As Integer)

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
        End Try
    End Sub

    Private Sub DataGridViewProdOrderLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProdOrderLineItem.MouseUp
        Try
            For i As Integer = 0 To Me.DataGridViewProdOrderLineItem.CurrentRow.Cells.Count - 1
                FieldsArray(i).Text = Me.DataGridViewProdOrderLineItem.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
