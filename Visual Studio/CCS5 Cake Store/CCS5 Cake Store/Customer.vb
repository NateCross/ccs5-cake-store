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

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView, Db2Connection)
    End Sub

    Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = 8
            DataGridView.Columns(0).Name = "Customer ID"
            DataGridView.Columns(1).Name = "First Name"
            DataGridView.Columns(2).Name = "Last Name"
            DataGridView.Columns(3).Name = "Middle Name"
            DataGridView.Columns(4).Name = "Street"
            DataGridView.Columns(5).Name = "City"
            DataGridView.Columns(6).Name = "Province"
            DataGridView.Columns(7).Name = "Email Address"

            DataGridView.Columns(0).Width = 110
            DataGridView.Columns(1).Width = 150
            DataGridView.Columns(2).Width = 150
            DataGridView.Columns(3).Width = 150
            DataGridView.Columns(4).Width = 150
            DataGridView.Columns(5).Width = 150
            DataGridView.Columns(6).Width = 150
            DataGridView.Columns(7).Width = 150

            DataGridView.Columns(0).ReadOnly = True

            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String =
            "SELECT CustId, CustFirstName, CustLastName, CustMiddleName, CustStreet, CustCity, CustProvince, CustEmailAddress FROM CUSTOMER"

        Try
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
                        RdrPopulateGrid.GetString(5),
                        RdrPopulateGrid.GetString(6),
                        RdrPopulateGrid.GetString(7)
                    }
                DataGridView.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventCreate(ByRef Values As List(Of String))
        Dim StrInsert As String
        Dim CmdInsert As DB2Command

        Try
            StrInsert = "INSERT INTO customer(custid, custfirstname, custlastname, custmiddlename, custstreet, custcity, custprovince, custemailaddress) VALUES ('" & Values(0) & "', '" & Values(1) & "', '" & Values(2) & "', '" & Values(3) & "', '" & Values(4) & "', '" & Values(5) & "', '" & Values(6) & "', '" & Values(7) & "')"
            CmdInsert = New DB2Command(StrInsert, Db2Connection)
            CmdInsert.ExecuteNonQuery()
            MsgBox("Successfully inserted customer.")

            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim CmdDelete As DB2Command
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = "DELETE FROM customer WHERE custid = '" & ID & "'"
            CmdDelete = New DB2Command(StrDelete, Db2Connection)
            CmdDelete.ExecuteNonQuery()

            MsgBox("Successfully deleted customer.")
            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("customer", ColumnArray, Values)

            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited customer.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
