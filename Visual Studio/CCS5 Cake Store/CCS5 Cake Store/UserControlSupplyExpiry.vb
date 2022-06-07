Public Class UserControlSupplyExpiry

    Private TableClass As Supply_Expiry

    Private Sub InitializeFields()

        TableClass = New Supply_Expiry(Me.DataGridViewSupplyExpiry)
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_SUPPLY Is Nothing Then
            MsgBox("Please select a supply first.", vbExclamation)
            Return Nothing
        End If
        If Me.TxtSupplyExpiryQty.Text = "" Then
            MsgBox("Please input a quantity first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("supply_expiry", "supplyexpiryid"))
            .Add(SELECTED_SUPPLY.Cells(0).Value)
            .Add(Me.TxtSupplyExpiryQty.Text)
            .Add(Me.DateTimePickerSupplyExpiration.Value.Date.ToString("MM-dd-yyyy"))
        End With

        Return Values
    End Function


    Private Sub BtnSupplyExpiryInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyExpiryInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            TableClass.EventCreate(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSupplyExpiryDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyExpiryDelete.Click
        Try
            If Me.DataGridViewSupplyExpiry.CurrentRow Is Nothing Then
                MsgBox("Please select a supply expiry first.", vbExclamation)
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

    Private Sub BtnSupplyExpiryUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplyExpiryUpdate.Click
        Try
            If Me.DataGridViewSupplyExpiry.CurrentRow Is Nothing Then
                MsgBox("Please select a supply expiry first.", vbExclamation)
                Return
            End If
            If Me.TxtSupplyExpiryQty.Text = "" Then
                MsgBox("Please input a quantity first.", vbExclamation)
                Return
            End If

            TableClass.EventEdit(Me.DateTimePickerSupplyExpiration.Value.Date.ToString("MM-dd-yyyy"), Me.TxtSupplyExpiryQty.Text, Me.DataGridViewSupplyExpiry.CurrentRow.Cells(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub UserControlSupplyExpiry_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewSupplyExpiry_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplyExpiry.MouseUp
        Try
            If Me.DataGridViewSupplyExpiry.CurrentCell Is Nothing Then
                Return
            End If

            Me.DateTimePickerSupplyExpiration.Value = Me.DataGridViewSupplyExpiry.CurrentRow.Cells(3).Value
            Me.TxtSupplyExpiryQty.Text = Me.DataGridViewSupplyExpiry.CurrentRow.Cells(2).Value

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
