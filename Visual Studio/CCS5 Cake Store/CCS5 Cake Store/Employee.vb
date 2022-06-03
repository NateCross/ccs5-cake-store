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
        "EmpAge",
        "EmpPosition",
        "EmpMonthlySalary",
        "EmpSSS",
        "EmpPagIbig",
        "EmpPhilHealth",
        "EmpTIN",
        "EmpUsername",
        "EmpPassword",
        "EmpDateOfBirth",
        "EmpStartOfEmploymentDate",
        "EmpDateOfSeparation"
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
        "Age",
        "Position",
        "Monthly Salary",
        "SSS",
        "Pag-Ibig",
        "PhilHealth",
        "TIN",
        "Username",
        "Password",
        "Date of Birth",
        "Start Of Employment Date",
        "Date of Separation"
    })

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView)
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
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("employee", ColumnArray)
            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read
                ' Checks for null; VB errors if we use get string
                ' on a null attribute
                Dim seperation = If(RdrPopulateGrid.IsDBNull(19), Nothing, RdrPopulateGrid.GetDate(19))
                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetString(3),
                    RdrPopulateGrid.GetString(4),
                    RdrPopulateGrid.GetString(5),
                    RdrPopulateGrid.GetString(6),
                    RdrPopulateGrid.GetString(7),
                    RdrPopulateGrid.GetString(8),
                    RdrPopulateGrid.GetString(9),
                    RdrPopulateGrid.GetString(10),
                    RdrPopulateGrid.GetString(11),
                    RdrPopulateGrid.GetString(12),
                    RdrPopulateGrid.GetString(13),
                    RdrPopulateGrid.GetString(14),
                    RdrPopulateGrid.GetString(15),
                    RdrPopulateGrid.GetString(16),
                    RdrPopulateGrid.GetDate(17),
                    RdrPopulateGrid.GetDate(18),
                    seperation
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
