Public Class UserControlSupplyPayment

    Public Shared TableClass As Supply_Payment

    Private Sub InitializeFields()

        TableClass = New Supply_Payment(Me.DataGridViewSupplyPayment)
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_SUPPLIER Is Nothing Then
            MsgBox("Please select a supplier first.", vbExclamation)
            Return Nothing
        End If
        If Globals.SELECTED_SUPPLY_DELIVERY Is Nothing Then
            MsgBox("Please select a supplier first.", vbExclamation)
            Return Nothing
        End If
        If Me.TxtSupplyPaymentAmountPaid.Text Is "" Then
            MsgBox("Please input an amount paid first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("supply_payment", "supplypaymentid"))
            .Add(SELECTED_SUPPLIER.Cells(0).Value)
            .Add(CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            .Add(SELECTED_SUPPLY_DELIVERY.Cells(0).Value)
            .Add(Me.TxtSupplyPaymentAmountPaid.Text)
            .Add(DateString)
            .Add(TimeString)
        End With

        Return Values
    End Function

    Private Sub BtnSupplyPaymentInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyPaymentInsert.Click
        Try
            Dim Values = GetFieldValues()

            TableClass.EventCreate(Values)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSupplyPaymentDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyPaymentDelete.Click
        Try
            If Me.DataGridViewSupplyPayment.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
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

    Private Sub BtnSupplyPaymentUpdate_Click(sender As Object, e As EventArgs) Handles BtnSupplyPaymentUpdate.Click
        Try
            If Me.DataGridViewSupplyPayment.CurrentRow Is Nothing Then
                MsgBox("Please select a line item first.", vbExclamation)
                Return
            End If
            TableClass.EventEdit(Me.TxtSupplyPaymentAmountPaid.Text, Me.DataGridViewSupplyPayment.CurrentRow.Cells(0).Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserControlSupplyPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewSupplyPayment_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplyPayment.MouseUp
        If Me.DataGridViewSupplyPayment.CurrentCell Is Nothing Then
            Return
        End If

        Try
            Me.TxtSupplyPaymentAmountPaid.Text = Me.DataGridViewSupplyPayment.CurrentRow.Cells(4).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
