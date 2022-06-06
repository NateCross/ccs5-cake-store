Imports IBM.Data.DB2

Public Class Employee_Phone
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "EmpPhoneId",
        "EmpId",
        "EmpPhoneNo"
    })

    Private ColumnNames = New List(Of String)({
        "Employee Phone ID",
        "Employee ID",
        "Employee Phone No."
    })

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
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
            Return
        End Try
    End Sub

    Public Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("employee_phone", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2)
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("employee_phone", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created employee phone entry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("employee_phone", "empphoneid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted employee phone entry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("employee_phone", ColumnArray, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited employee phone entry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

End Class
