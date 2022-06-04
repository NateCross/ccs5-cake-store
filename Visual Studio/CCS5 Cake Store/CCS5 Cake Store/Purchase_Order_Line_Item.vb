Imports IBM.Data.DB2

Public Class Purchase_Order_Line_Item
    Inherits Table

    ' We omit the PurchaseOrderLineItemId since its value
    ' will be automatic
    Private Key = "PurchaseOrderLineItemId"
    Private ColumnArray = New List(Of String)({
        "PurchaseOrderId",
        "SupplyId",
        "PurchaseOrderLineItemPrice",
        "PurchaseOrderLineItemQty"
    })

    Private EditableColumns = New List(Of String)({
        "PurchaseOrderLineItemPrice",
        "PurchaseOrderLineItemQty"
    })
    Private EditableColumnIndex = New List(Of Integer)({
        2,
        3
    })

    Private ColumnNames = New List(Of String)({
        "Purchase Order ID",
        "Supply ID",
        "Price",
        "Quantity"
    })

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView)
    End Sub

    Public Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = ColumnArray.Count
            For i As Integer = 0 To DataGridView.ColumnCount - 1
                DataGridView.Columns(i).Name = ColumnNames(i)
                DataGridView.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub InsertToTemp(ByRef Values As List(Of String))
        Try
            Dim Converted = New String() {
                Values(0),
                Values(1),
                Values(2),
                Values(3),
                Values(4)
            }
            DataGridView.Rows.Add(Converted)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub DeleteInTemp()
        Try
            DataGridView.Rows.Remove(DataGridView.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub EditInTemp(ByRef Values As List(Of String))
        Try
            For i = 0 To EditableColumnIndex.Count - 1
                DataGridView.CurrentRow.Cells(EditableColumnIndex(i)).Value = Values(EditableColumnIndex(i))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' This will not be called by the buttons
    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Dim ValuesToInsert As New List(Of String)
        With ValuesToInsert
            .Add(GetIncrementedIndexID("purchase_order_line_item", "purchaseorderlineitemid"))
            .AddRange(Values)
        End With

        Dim ColumnsToInsert As New List(Of String)
        With ColumnsToInsert
            .Add(Key)
            .AddRange(ColumnArray)
        End With

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("purchase_order_line_item", ColumnsToInsert, ValuesToInsert)
            ExecuteCommand(StrInsert)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
