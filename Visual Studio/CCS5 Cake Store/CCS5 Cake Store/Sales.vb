Imports IBM.Data.DB2

Public Class Sales
    Inherits Table

    ' Make a table first, this has the subroutines we run
    ' in each user control

    ' Names of attributes of the table
    ' Must be done in order
    Private ColumnArray = New List(Of String)({
        "SaleId",
        "CustId",
        "EmpId",
        "SaleDate",
        "SaleTime",
        "SaleSubtotal"
    })

    ' Names of the columns to be used in the data grid
    ' Must have the same order and number as columnarray above
    Private ColumnNames = New List(Of String)({
        "Sale ID",
        "Customer ID",
        "Employee ID",
        "Date",
        "Time",
        "Subtotal"
    })

    ' Copy + paste this for each new table
    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView, Db2Connection)
    End Sub

    ' You can copy paste this
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
            ' Replace the first argument with the table name
            ' It must match the exact table name in database
            SelectString = UtilityFunctions.Db2SelectStringGenerator("sale", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                ' Make a string array according to the data types
                ' GetString(i) = almost everything
                ' GetDate(i) = DATE
                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetDate(3),
                    RdrPopulateGrid.GetTime(4).ToString,
                    RdrPopulateGrid.GetString(5)
                }
                DataGridView.Rows.Add(row)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Copy + paste the following methods. Just change the strings
    ' that are the first arguments to their respective ones for the table
    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("sale", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created sale.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("sale", "saleid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted sale.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("sale", ColumnArray, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited sale.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Now we can make the usercontrol
    ' Go to project -> add user control
End Class
