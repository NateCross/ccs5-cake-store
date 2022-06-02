Imports IBM.Data.DB2

Module UtilityFunctions
    Public Function Db2UpdateStringGenerator(ByRef TableName As String, ByRef Columns As List(Of String), ByRef Values As List(Of String))
        Dim StrEdit As New System.Text.StringBuilder
        StrEdit.Append("UPDATE " & TableName & " SET ")
        For i As Integer = 1 To Columns.Count - 2
            StrEdit.Append(Columns(i) & "='" & Values(i) & "', ")
        Next
        StrEdit.Append(Columns(Columns.Count - 1) & "='" & Values(Columns.Count - 1) & "' ")
        StrEdit.Append("WHERE " & Columns(0) & "='" & Values(0) & "'")
        Return StrEdit.ToString
    End Function

    Public Function Db2SelectStringGenerator(ByRef TableName As String, ByRef Columns As List(Of String))
        Dim StrEdit As New System.Text.StringBuilder
        StrEdit.Append("SELECT ")
        For i As Integer = 0 To Columns.Count - 2
            StrEdit.Append(Columns(i) & ", ")
        Next
        StrEdit.Append(Columns(Columns.Count - 1) & " FROM " & TableName)
        Return StrEdit.ToString
    End Function

    Public Function Db2InsertStringGenerator(ByRef TableName As String, ByRef Columns As List(Of String), ByRef Values As List(Of String))
        Try
            Dim StrEdit As New System.Text.StringBuilder
            StrEdit.Append("INSERT INTO " & TableName & "(")
            For i As Integer = 0 To Columns.Count - 2
                StrEdit.Append(Columns(i) & ", ")
            Next
            StrEdit.Append(Columns(Columns.Count - 1) & ") VALUES ('")
            For i As Integer = 0 To Values.Count - 2
                StrEdit.Append(Values(i) & "', '")
            Next
            StrEdit.Append(Values(Values.Count - 1) & "')")
            Return StrEdit.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Db2DeleteStringGenerator(ByRef TableName As String, ByRef IdColumnName As String, ByRef Id As String)
        Try
            Dim StrDelete As New System.Text.StringBuilder
            StrDelete.Append("DELETE FROM " & TableName & " WHERE " & IdColumnName & " = '" & Id & "'")
            Return StrDelete.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function ExecuteReader(ByRef SelectQuery As String)
        Dim CmdQuery As db2command
        Dim RdrQuery As DB2DataReader

        Try
            CmdQuery = New DB2Command(SelectQuery, DASHBOARD_CONNECTION)
            RdrQuery = CmdQuery.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return RdrQuery

    End Function
End Module
