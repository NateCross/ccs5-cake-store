Imports IBM.Data.DB2

Public Class Supply_Delivery
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "SupplyDeliveryId",
        "SupplierId",
        "EmpId",
        "PurchaseOrderId",
        "SupplyDeliveryPaymentDueDate",
        "SupplyDeliveryDate",
        "SupplyDeliveryTime"
    })

    Private ColumnNames = New List(Of String)({
        "Supply Delivery ID",
        "Supplier ID",
        "Employee ID",
        "Purchase Order ID",
        "Payment Due Date",
        "Date",
        "Time"
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
            SelectString = UtilityFunctions.Db2SelectStringGenerator("supply_delivery", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetString(3),
                    RdrPopulateGrid.GetDate(4),
                    RdrPopulateGrid.GetDate(5),
                    RdrPopulateGrid.GetTime(6).ToString
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supply_delivery", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created supply delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("supply_delivery", "supplydeliveryid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted supply delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef DueDate As String, ByRef ID As String)
        Try
            Dim StrEdit As String = "UPDATE supply_delivery SET supplydeliverypaymentduedate = '" & DueDate & "' where supplydeliveryid=" & ID
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited supply delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
