Imports IBM.Data.DB2

Public Class Purchase_Order
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "PurchaseOrderId",
        "SupplierId",
        "EmpId",
        "PurchaseOrderDueDate",
        "PurchaseOrderDate",
        "PurchaseOrderTime",
        "PurchaseOrderSubtotal"
    })

    Private EditableColumns = New List(Of String)({
        "PurchaseOrderDueDate"
    })

    Private ColumnNames = New List(Of String)({
        "Purchase Order ID",
        "Supplier ID",
        "Employee ID",
        "Due Date",
        "Date",
        "Time",
        "Subtotal"
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
            DataGridView.Columns(0).Width = 110
            DataGridView.Columns(0).ReadOnly = True

            Call RefreshDataGrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("purchase_order", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetDate(3),
                    RdrPopulateGrid.GetDate(4),
                    RdrPopulateGrid.GetTime(5).ToString,
                    RdrPopulateGrid.GetString(6)
                }
                DataGridView.Rows.Add(row)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("purchase_order", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created purchase order.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("purchase_order", "purchaseorderid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted purchase order.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef DueDate As String, ByRef ID As String)
        Try
            Dim StrEdit As String = "UPDATE purchase_order SET purchaseorderduedate = '" & DueDate & "' where purchaseorderid=" & ID
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited purchase order.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
