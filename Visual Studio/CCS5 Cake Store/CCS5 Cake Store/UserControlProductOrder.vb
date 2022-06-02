Public Class UserControlProductOrder

    Private FieldsArray As TextBox()
    Public Shared TableClass As Product_Order

    Private Sub InitializeFields()
        FieldsArray = {
            Me.TxtProdOrderId,
            Me.TxtCustId
        }

        TableClass = New Product_Order(Me.DataGridViewProductOrder, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnProdOrderInsert_Click(sender As Object, e As EventArgs) Handles BtnProdOrderInsert.Click
        Try
            Dim Values = GetFieldValues()

            Values.add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            Values.add(DateString)
            Values.add(TimeString)
            Values.add("0.00") ' Empty subtotal

            TableClass.EventCreate(Values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnProdOrderDelete_Click(sender As Object, e As EventArgs) Handles BtnProdOrderDelete.Click
        Try
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
End Class
