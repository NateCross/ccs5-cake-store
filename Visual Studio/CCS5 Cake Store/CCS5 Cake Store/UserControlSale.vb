Public Class UserControlSale

    Private FieldsArray As TextBox()
    Public Shared TableClass As Sales

    Private Sub InitializeFields()

        TableClass = New Sales(Me.DataGridViewSales)
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_CUSTOMER Is Nothing Then
            MsgBox("Please select a Customer first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(GetIncrementedIndexID("sale", "saleid"))
            .Add(Globals.SELECTED_CUSTOMER.Cells(0).Value)
        End With

        Return Values
    End Function

    Private Sub BtnSaleInsert_Click(sender As Object, e As EventArgs) Handles BtnSaleInsert.Click
        Try
            Dim values = GetFieldValues()
            If values Is Nothing Then
                Return
            End If

            values.add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            values.add(DateString)
            values.add(TimeString)
            values.add("0.00")

            TableClass.EventCreate(values)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnSaleDelete_Click(sender As Object, e As EventArgs) Handles BtnSaleDelete.Click
        Try
            If Me.DataGridViewSales.CurrentRow Is Nothing Then
                MsgBox("Please select a sale first.", vbExclamation)
                Return
            End If
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub UserControlSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewSales_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSales.MouseUp
        Try
            Globals.SELECTED_SALE = DataGridViewSales.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
