Imports IBM.Data.DB2

Public Class Supply_Usage_Line_Item
    Inherits Table

    Private Key = "SupplyUsageLineItemId"
    Private ColumnArray = New List(Of String)({
        "SupplyUsageId",
        "SupplyId",
        "SupplyUsageLineItemQty"
    })

    Private EditableColumns = New List(Of String)({
        "SupplyUsageLineItemQty"
    })
    Private EditableColumnIndex = New List(Of Integer)({
        2
    })

    Private ColumnNames = New List(Of String)({
        "Supply Usage ID",
        "Supply ID",
        "Quantity Used"
    })

    Public Sub New(DataGridView As DataGridView)
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
                Values(3)
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

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Dim ValuesToInsert As New List(Of String)
        With ValuesToInsert
            .Add(GetIncrementedIndexID("supply_usage_line_item", "supplyusagelineitemid"))
            .AddRange(Values)
        End With

        Dim ColumnsToInsert As New List(Of String)
        With ColumnsToInsert
            .Add(Key)
            .AddRange(ColumnArray)
        End With

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supply_usage_line_item", ColumnsToInsert, ValuesToInsert)
            ExecuteCommand(StrInsert)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
