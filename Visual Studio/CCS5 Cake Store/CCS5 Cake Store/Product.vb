Imports IBM.Data.DB2

Public Class Product
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "ProdId",
        "ProdName",
        "ProdSellingPrice",
        "ProdQty"
    })
    Private ColumnNames = New List(Of String)({
        "Product ID",
        "Name",
        "Selling Price",
        "Quantity"
    })

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView)
    End Sub

    Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = ColumnArray.Count
            For i As Integer = 0 To DataGridView.ColumnCount - 1
                DataGridView.Columns(i).Name = ColumnNames(i)
                DataGridView.Columns(i).Width = 150
            Next

            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("product", ColumnArray)
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
            SelectString = UtilityFunctions.Db2SearchStringGenerator("product", "prodname", Query, ColumnArray)
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

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("product", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully inserted product.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("product", "prodid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted product.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("product", ColumnArray, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited product.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
