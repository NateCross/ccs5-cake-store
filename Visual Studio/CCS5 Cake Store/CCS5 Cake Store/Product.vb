Imports IBM.Data.DB2

Class Product
    Inherits Table

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        MyBase.New(DataGridView, Db2Connection)
    End Sub

    Overrides Sub Initialize()
        Try
            DataGridView.ColumnCount = 4
            DataGridView.Columns(0).Name = "Product ID"
            DataGridView.Columns(1).Name = "Name"
            DataGridView.Columns(2).Name = "Selling Price"
            DataGridView.Columns(3).Name = "Quantity"

            DataGridView.Columns(0).Width = 110
            DataGridView.Columns(1).Width = 150
            DataGridView.Columns(2).Width = 150
            DataGridView.Columns(3).Width = 150

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
            "SELECT ProdId, ProdName, ProdSellingPrice, ProdQty FROM PRODUCT"

        Try 
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

    Public Overloads Sub EventCreate(ByRef Values() As String)
        Dim StrInsert As String
        Dim CmdInsert As DB2Command

        Try
            StrInsert = "INSERT INTO Product(prodid, prodname, prodsellingprice, prodqty) VALUES ('" & Values(0) & "', '" & Values(1) & "', '" & Values(2) & "', '" & Values(3) & "')"
            CmdInsert = New DB2Command(StrInsert, Db2Connection)
            CmdInsert.ExecuteNonQuery()
            MsgBox("Successfully inserted product.")

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
            StrDelete = "DELETE FROM Product WHERE ProdId = '" & ID & "'"
            CmdDelete = New DB2Command(StrDelete, Db2Connection)
            CmdDelete.ExecuteNonQuery()

            MsgBox("Successfully deleted product.")
            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef Values() As String)
        Dim StrEdit As String
        Dim ID = Values(0)
        Dim ProdName = Values(1)
        Dim ProdSellingPrice = Values(2)
        Dim ProdQty = Values(3)

        StrEdit = "UPDATE PRODUCT SET Prodname='" & ProdName & "', ProdSellingPrice='" & ProdSellingPrice & "', ProdQty='" & ProdQty & "' where ProdId='" & ID & "'"

        ExecuteCommand(StrEdit)
        MsgBox("Successfully edited product.")
    End Sub
End Class
