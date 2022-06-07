﻿Imports IBM.Data.DB2

Public Class Supply_Expiry
    Inherits Table

    Private ColumnArray = New List(Of String)({
        "SupplyExpiryId",
        "SupplyId",
        "SupplyExpiryQty",
        "SupplyExpiryDate"
    })

    Private ColumnNames = New List(Of String)({
        "Supply Expiry ID",
        "Supply ID",
        "Supply Expiry Quantity",
        "Expiration Date"
    })

    Public Sub New(DataGridView As DataGridView)
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
        End Try
    End Sub

    Public Overrides Sub RefreshDataGrid()
        Dim CmdPopulateGrid As DB2Command
        Dim RdrPopulateGrid As DB2DataReader
        Dim row As String()
        Dim SelectString As String

        Try
            SelectString = UtilityFunctions.Db2SelectStringGenerator("supply_expiry", ColumnArray)

            CmdPopulateGrid = New DB2Command(SelectString, Db2Connection)
            RdrPopulateGrid = CmdPopulateGrid.ExecuteReader
            DataGridView.Rows.Clear()
            While RdrPopulateGrid.Read

                row = New String() {
                    RdrPopulateGrid.GetString(0),
                    RdrPopulateGrid.GetString(1),
                    RdrPopulateGrid.GetString(2),
                    RdrPopulateGrid.GetDate(3)
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
            StrInsert = UtilityFunctions.Db2InsertStringGenerator("supply_expiry", ColumnArray, Values)
            ExecuteCommand(StrInsert)
            MsgBox("Successfully created supply expiry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overrides Sub EventDelete()
        Dim StrDelete As String
        Dim ID = Me.DataGridView.CurrentRow.Cells(0).Value

        Try
            StrDelete = UtilityFunctions.Db2DeleteStringGenerator("supply_expiry", "supplyexpiryid", ID)
            ExecuteCommand(StrDelete)
            MsgBox("Successfully deleted supply expiry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Overloads Sub EventEdit(ByRef ExpiryDate As String, ByRef Qty As String, ByRef ID As String)
        Try
            Dim StrEdit As String = "UPDATE supply_expiry SET supplyexpirydate = '" & ExpiryDate & "', supplyexpiryqty='" & Qty & "' where supplyexpiryid=" & ID
            ExecuteCommand(StrEdit)
            MsgBox("Successfully edited supply expiry.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
