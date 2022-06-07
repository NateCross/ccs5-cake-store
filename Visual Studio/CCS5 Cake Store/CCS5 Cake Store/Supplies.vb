Imports IBM.Data.DB2

Public Class Supplies
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "SupplyId",
        "SupplyName",
        "SupplyQty",
        "SupplyUnitOfMeasurement"
    })

    Private ColumnNames = New List(Of String)({
        "Supply ID",
        "Name",
        "Quantity",
        "Unit of Measurement"
    })

    Public Sub New(DataGridView As DataGridView)
        MyBase.New(DataGridView)
    End Sub

    Public Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = ColumnArray.Count
            For i As Integer = 0 To DataGridView.ColumnCount - 1
                DataGridView.Columns(i).Name = ColumnNames(i)
            Next

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
            SelectString = UtilityFunctions.Db2SelectStringGenerator("supplies", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetString(3)
                }
                DataGridView.Rows.Add(row)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub RefreshDataGridSearch(ByRef Query As String)
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SearchStringGenerator("supplies", "supplyname", Query, ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetString(3)
                }
                DataGridView.Rows.Add(row)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String
        If UtilityFunctions.CheckIfValuesAreValid(Values) = False Then
            MsgBox("Please input a value in each field.", vbExclamation)
            Return
        End If

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supplies", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created supply.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("supplies", "supplyid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted supply.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("supplies", ColumnArray, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited supply.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
