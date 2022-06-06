Public Class UserControlProductOrder

    Public Shared TableClass As Product_Order

    Private Sub InitializeFields()
        TableClass = New Product_Order(Me.DataGridViewProductOrder)
    End Sub

    Private Sub BtnProdOrderInsert_Click(sender As Object, e As EventArgs) Handles BtnProdOrderInsert.Click
        Try
            If Globals.SELECTED_CUSTOMER Is Nothing Then
                MsgBox("Please select a Customer first.", vbExclamation)
                Return
            End If

            Dim Values = New List(Of String)

            With Values
                .Add(GetIncrementedIndexID("product_order", "prodorderid"))
                .Add(Globals.SELECTED_CUSTOMER.Cells(0).Value)
                .Add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
                .Add(DateString)
                .Add(TimeString)
                .Add("0.00")
            End With

            TableClass.EventCreate(Values)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnProdOrderDelete_Click(sender As Object, e As EventArgs) Handles BtnProdOrderDelete.Click
        Try

            If Me.DataGridViewProductOrder.CurrentRow Is Nothing Then
                MsgBox("Please select an entry first.", vbExclamation)
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

    Private Sub UserControlProductOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewProductOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProductOrder.MouseUp
        Globals.SELECTED_PRODUCT_ORDER = DataGridViewProductOrder.CurrentRow
    End Sub
End Class
