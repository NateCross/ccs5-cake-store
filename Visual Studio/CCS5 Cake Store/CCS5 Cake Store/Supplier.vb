Imports IBM.Data.DB2

Public Class Supplier
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "SupplierId",
        "SupplierName",
        "SupplierStreet",
        "SupplierCity",
        "SupplierProvince",
        "SupplierEmailAddress"
    })

    Private ColumnNames = New List(Of String)({
        "Supplier ID",
        "Name",
        "Street",
        "City",
        "Province",
        "Email Address"
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
            ' Replace the first argument with the table name
            ' It must match the exact table name in database
            SelectString = UtilityFunctions.Db2SelectStringGenerator("supplier", ColumnArray)

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
                    RdrPopulateGrid.GetString(3),
                    RdrPopulateGrid.GetString(4),
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supplier", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created supplier.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("supplier", "supplierid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted supplier.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("supplier", ColumnArray, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited supplier.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Now we can make the usercontrol
    ' Go to project -> add user control
End Class
