Imports IBM.Data.DB2

Module Product
    Public Sub Initialize(DataGridView As DataGridView)
        DataGridView.ColumnCount = 4
        DataGridView.Columns(0).Name = "Product ID"
        DataGridView.Columns(1).Name = "Name"
        DataGridView.Columns(2).Name = "Selling Price"
        DataGridView.Columns(3).Name = "Quantity"

        DataGridView.Columns(0).Width = 110
        DataGridView.Columns(1).Width = 150
        DataGridView.Columns(2).Width = 150
        DataGridView.Columns(3).Width = 150

    End Sub

    Public Sub RefreshDataGrid(DataGridView As DataGridView)
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()

    End Sub

End Module
