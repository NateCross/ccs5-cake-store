Imports IBM.Data.DB2

Public Class Employee
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "EmpId",
        "EmpFirstName",
        "EmpLastName",
        "EmpMiddleName",
        "EmpStreet",
        "EmpCity",
        "EmpProvince",
        "EmpEmailAddress",
        "EmpDateOfBirth",
        "EmpAge",
        "EmpPosition",
        "EmpMonthlySalary",
        "EmpSSS",
        "EmpPagIbig",
        "EmpPhilHealth",
        "EmpTIN",
        "EmpStartOfEmploymentDate",
        "EmpDateOfSeparation",
        "EmpUsername",
        "EmpPassword"
    })

    Private ColumnNames = New List(Of String)({
        "Employee ID",
        "First Name",
        "Last Name",
        "Middle Name",
        "Street",
        "City",
        "Province",
        "Email Address",
        "Date of Birth",
        "Age",
        "Position",
        "Monthly Salary",
        "SSS",
        "Pag-Ibig",
        "PhilHealth",
        "TIN",
        "Start Of Employment Date",
        "Date of Separation",
        "Username",
        "Password"
    })

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView, Db2Connection)
    End Sub

    Public Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = 20
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
        Dim rowList As List(Of String)
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("employee", ColumnArray)
            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read
                rowList = New List(Of String)
                For i As Integer = 0 To ColumnArray.Count - 1
                    rowList.Add(RdrPopulateGrid.GetString(i))
                Next
                row = rowList.ToArray
                DataGridView.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String

        Try
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("employee", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created employee.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("employee", "empid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted employee.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("employee", ColumnArray, Values)

            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited employee.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
