Imports IBM.Data.DB2

Public Class UserControlSupplyUsageLineItem

    Private TableClass As Supply_Usage_Line_Item

    Private Sub InitializeFields()
        TableClass = New Supply_Usage_Line_Item(Me.DataGridViewSupplyUsageLineItem, DASHBOARD_CONNECTION)
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)

        Values.Add(Globals.SELECTED_SUPPLY_USAGE.Cells(0).Value)
        Values.Add(Globals.SELECTED_SUPPLY.Cells(0).Value)
        Values.Add(Me.TxtSupplyUsageLineItemQtyUsed.Text)

        Return Values
    End Function

    Private Sub ClearFields()
        Try
            Me.TxtSupplyUsageLineItemQtyUsed.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyUsageLineItemInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageLineItemInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            Dim ConvertedValues = New String() {
                Values(0),
                Values(1),
                Values(2)
            }
            Me.DataGridViewSupplyUsageLineItem.Rows.Add(ConvertedValues)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyUsageLineItemDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageLineItemDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Call TableClass.DeleteInTemp()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyUsageLineItemUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageLineItemUpdate.Click
        Try
            Dim Values = GetFieldValues()
            TableClass.EditInTemp(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyUsageLineItemAddToSupplyUsage_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageLineItemAddToSupplyUsage.Click
        Try
            For i = 0 To Me.DataGridViewSupplyUsageLineItem.RowCount - 1
                Dim Values = New List(Of String) From {
                    Me.DataGridViewSupplyUsageLineItem.Rows(i).Cells(0).Value,
                    Me.DataGridViewSupplyUsageLineItem.Rows(i).Cells(1).Value,
                    Me.DataGridViewSupplyUsageLineItem.Rows(i).Cells(2).Value
                }
                TableClass.EventCreate(Values)
                Call SubtractSupplies(Values(1), Values(2))
            Next
            Me.DataGridViewSupplyUsageLineItem.Rows.Clear()
            MsgBox("Successfully saved supply usage.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserControlSupplyUsageLineItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub SubtractSupplies(ByRef SupplyId As String, ByRef SupplyQty As Decimal)
        Dim StrUpdateSupplies As String
        Dim CmdUpdateSupplies As DB2Command

        Try
            StrUpdateSupplies = "UPDATE supplies SET supplyqty=supplyqty-" & SupplyQty & " WHERE supplyid=" & SupplyId
            CmdUpdateSupplies = New DB2Command(StrUpdateSupplies, DASHBOARD_CONNECTION)
            CmdUpdateSupplies.ExecuteNonQuery()

            UserControlSupplies.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSupplyUsageLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplyUsageLineItem.MouseUp
        Try
            Me.TxtSupplyUsageLineItemQtyUsed.Text = Me.DataGridViewSupplyUsageLineItem.CurrentRow.Cells(2).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
