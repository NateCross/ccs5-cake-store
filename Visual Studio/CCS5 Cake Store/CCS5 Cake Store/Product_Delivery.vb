Imports IBM.Data.DB2

Public Class Product_Delivery
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "ProdDeliveryId",
        "CustId",
        "EmpId",
        "ProdOrderId",
        "ProdDeliveryStreet",
        "ProdDeliveryCity",
        "ProdDeliveryProvince",
        "ProdDeliveryDate",
        "ProdDeliveryTime"
    })
    Private EditableColumns = New List(Of String)({
        "ProdDeliveryStreet",
        "ProdDeliveryCity",
        "ProdDeliveryProvince"
    })


    Private ColumnNames = New List(Of String)({
        "Product Delivery ID",
        "Customer ID",
        "Employee ID",
        "Product Order ID",
        "Delivery Street",
        "Delivery City",
        "Delivery Province",
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
            SelectString = UtilityFunctions.Db2SelectStringGenerator("product_delivery", ColumnArray)

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
                    RdrPopulateGrid.GetDate(7),
                    RdrPopulateGrid.GetTime(8).ToString
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("product_delivery", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created product delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("product_delivery", "proddeliveryid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted product delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values As List(Of String))
        Try
            Dim StrEdit As String = UtilityFunctions.Db2UpdateStringGenerator("product_delivery", EditableColumns, Values)
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited product delivery.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
