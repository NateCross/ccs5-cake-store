Imports IBM.Data.DB2

Public Class Table
    Public Property DataGridView As DataGridView
    Public Property Db2Connection As Common.DbConnection

    Public Sub New(DataGridView As DataGridView, Db2Connection As Common.DbConnection)
        Me.DataGridView = DataGridView
        Me.Db2Connection = Db2Connection
    End Sub

    Overridable Sub Initialize()
    End Sub

    Overridable Sub RefreshDataGrid()
    End Sub

    Overridable Sub EventCreate()
    End Sub

    Overridable Sub EventDelete()
    End Sub

    Overridable Sub EventEdit()
    End Sub

    Overridable Sub ExecuteCommand(ByRef Command As String)
        Dim CmdExec As DB2Command

        Try
            CmdExec = New DB2Command(Command, Db2Connection)
            CmdExec.ExecuteNonQuery()
            Call RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class