Imports IBM.Data.DB2

Public Class UserControlSupplyUsage

    Private TableClass As Supply_Usage

    Private Sub InitializeFields()

        TableClass = New Supply_Usage(Me.DataGridViewSupplyUsage, DASHBOARD_CONNECTION)
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_PRODUCT Is Nothing Then
            MsgBox("Please select a product first.", vbExclamation)
            Return Nothing
        End If
        If Me.TxtSupplyUsageProdQtyAdded.Text = "" Then
            MsgBox("Please input a quantity to be added.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("supply_usage", "supplyusageid"))
            .Add(SELECTED_PRODUCT.Cells(0).Value)
            .Add(CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            .Add(Me.TxtSupplyUsageProdQtyAdded.Text)
            .Add(DateString)
            .Add(TimeString)
        End With

        Return Values
    End Function

    Private Sub BtnSupplyUsageInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            TableClass.EventCreate(Values)

            Call AddProductQuantity(Values(1), Values(3))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSupplyUsageDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyUsageDelete.Click
        Try
            If Me.DataGridViewSupplyUsage.CurrentRow Is Nothing Then
                MsgBox("Please select a supply usage first.", vbExclamation)
                Return
            End If

            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSupplyUsage_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplyUsage.MouseUp
        Try
            If Me.DataGridViewSupplyUsage.CurrentCell Is Nothing Then
                Return
            End If

            Globals.SELECTED_SUPPLY_USAGE = Me.DataGridViewSupplyUsage.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserControlSupplyUsage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub AddProductQuantity(ByRef ProdId As String, ByRef QtyAdded As Integer)
        Dim StrAddQuantity As String
        Dim CmdAddQuantity As DB2Command

        Try
            StrAddQuantity = "UPDATE product SET prodqty=prodqty +" & QtyAdded & " WHERE prodid=" & ProdId
            CmdAddQuantity = New DB2Command(StrAddQuantity, DASHBOARD_CONNECTION)
            CmdAddQuantity.ExecuteNonQuery()

            UserControlProduct.TableClass.RefreshDataGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub
End Class
