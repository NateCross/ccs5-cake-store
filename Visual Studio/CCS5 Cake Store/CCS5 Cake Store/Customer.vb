Imports IBM.Data.DB2

Public Class Customer
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "CustId",
        "CustFirstName",
        "CustLastName",
        "CustMiddleName",
        "CustStreet",
        "CustCity",
        "CustProvince",
        "CustEmailAddress"
    })

    Private ColumnNames = New List(Of String)({
        "Customer ID",
        "First Name",
        "Last Name",
        "Middle Name",
        "Street",
        "City",
        "Province",
        "Email Address"
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
            DataGridView.Columns(0).Width = 110
            DataGridView.Columns(0).ReadOnly = True
            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("customer", ColumnArray)
            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read
                row = New String() {
                        RdrPopulateGrid.GetString(0),
                        If(RdrPopulateGrid.IsDBNull(1), "", RdrPopulateGrid.GetString(1)),
                        If(RdrPopulateGrid.IsDBNull(2), "", RdrPopulateGrid.GetString(2)),
                        If(RdrPopulateGrid.IsDBNull(3), "", RdrPopulateGrid.GetString(3)),
                        If(RdrPopulateGrid.IsDBNull(4), "", RdrPopulateGrid.GetString(4)),
                        If(RdrPopulateGrid.IsDBNull(5), "", RdrPopulateGrid.GetString(5)),
                        If(RdrPopulateGrid.IsDBNull(6), "", RdrPopulateGrid.GetString(6)),
                        If(RdrPopulateGrid.IsDBNull(7), "", RdrPopulateGrid.GetString(7))
                    }
                DataGridView.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Sub RefreshDataGridSearch(ByRef Query As String)
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String
        Try
            SelectString = UtilityFunctions.Db2SearchStringGenerator("customer", "custlastname", Query, ColumnArray)
            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read
                row = New String() {
                        RdrPopulateGrid.GetString(0),
                        If(RdrPopulateGrid.IsDBNull(1), "", RdrPopulateGrid.GetString(1)),
                        If(RdrPopulateGrid.IsDBNull(2), "", RdrPopulateGrid.GetString(2)),
                        If(RdrPopulateGrid.IsDBNull(3), "", RdrPopulateGrid.GetString(3)),
                        If(RdrPopulateGrid.IsDBNull(4), "", RdrPopulateGrid.GetString(4)),
                        If(RdrPopulateGrid.IsDBNull(5), "", RdrPopulateGrid.GetString(5)),
                        If(RdrPopulateGrid.IsDBNull(6), "", RdrPopulateGrid.GetString(6)),
                        If(RdrPopulateGrid.IsDBNull(7), "", RdrPopulateGrid.GetString(7))
                    }
                DataGridView.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("customer", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully inserted customer.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("customer", "custid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted customer.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("customer", ColumnArray, Values)

            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited customer.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub
End Class
