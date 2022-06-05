Imports IBM.Data.DB2

Public Class Supply_Payment
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "SupplyPaymentId",
        "SupplierId",
        "EmpId",
        "SupplyDeliveryId",
        "SupplyPaymentTotalAmountDue",
        "SupplyPaymentDate",
        "SupplyPaymentTime"
    })

    Private ColumnNames = New List(Of String)({
        "Supply Payment ID",
        "Supplier ID",
        "Employee ID",
        "Supply Delivery ID",
        "Amount Paid",
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
            SelectString = UtilityFunctions.Db2SelectStringGenerator("supply_payment", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetString(3),
                    RdrPopulateGrid.GetString(4),
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supply_payment", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created supply payment.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("supply_payment", "supplypaymentid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted supply payment.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef AmountDue As String, ByRef ID As String)
        Try
            Dim StrEdit As String = "UPDATE supply_payment SET supplypaymenttotalamountdue = '" & AmountDue & "' where supplypaymentid=" & ID
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited supply payment.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
