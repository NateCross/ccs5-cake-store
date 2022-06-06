Imports IBM.Data.DB2

Public Class Sale_Line_Item
    Inherits Table

    Private Key = "SaleLineItemId"
    Public ColumnArray = New List(Of String)({
        "SaleId",
        "ProdId",
        "SaleLineItemPrice",
        "SaleLineItemQty"
    })

    Private EditableColumns = New List(Of String)({
        "SaleLineItemQty"
    })
    Private EditableColumnIndex = New List(Of Integer)({
        3
    })

    Public ColumnNames = New List(Of String)({
        "Sale Line Item ID",
        "Sale ID",
        "Product ID",
        "Price",
        "Quantity"
    })

    Public Sub New(DataGridView As DataGridView)
        MyBase.New(DataGridView)
    End Sub

    Public Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = ColumnArray.Count
            For i As Integer = 0 To DataGridView.ColumnCount - 1
                DataGridView.Columns(i).Name = ColumnNames(i + 1)
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
            MsgBox("Successfully inserted line item.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub DeleteInTemp()
        Try
            DataGridView.Rows.Remove(DataGridView.CurrentRow)
            MsgBox("Successfully deleted line item.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub EditInTemp(ByRef Values As List(Of String))
        Try
            For i = 0 To EditableColumnIndex.Count - 1
                DataGridView.CurrentRow.Cells(EditableColumnIndex(i)).Value = Values(EditableColumnIndex(i))
                MsgBox("Successfully edited line item.")
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Dim ColumnsToInsert As New List(Of String)
        With ColumnsToInsert
            .Add(Key)
            .AddRange(ColumnArray)
        End With

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("sale_line_item", ColumnsToInsert, Values)
            ExecuteCommand(StrInsert)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
