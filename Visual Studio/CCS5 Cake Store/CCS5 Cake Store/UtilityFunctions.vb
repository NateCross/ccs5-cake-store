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
    End Function

    Public Function Db2DeleteStringGenerator(ByRef TableName As String, ByRef IdColumnName As String, ByRef Id As String)
        Dim StrDelete As New System.Text.StringBuilder
        StrDelete.Append("DELETE FROM " & TableName & " WHERE " & IdColumnName & " = '" & Id & "'")
        Return StrDelete.ToString

    End Function

    Public Function ExecuteReader(ByRef SelectQuery As String)
        Dim CmdQuery As db2command
        Dim RdrQuery As DB2DataReader

        Try
            CmdQuery = New DB2Command(SelectQuery, DASHBOARD_CONNECTION)
            RdrQuery = CmdQuery.ExecuteReader
            Return RdrQuery
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function GetIncrementedIndexID(ByRef TableName As String, PrimaryKey As String)
        Dim CommandString = "SELECT " & PrimaryKey & " FROM " & TableName & " ORDER BY " & PrimaryKey & " DESC"
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Try
            Cmd = New DB2Command(CommandString, DASHBOARD_CONNECTION)
Rdr = Cmd.ExecuteReader
            If Not Rdr.HasRows Then
                Return 1
            End If
            Rdr.Read()
            Return Rdr.GetInt32(0) + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return -1
        End Try
    End Function
End Module
