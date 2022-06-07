Public Class UserControlProductDelivery
    Private FieldsArray As TextBox()
    Public Shared TableClass As Product_Delivery

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtProdDeliveryStreet,
            Me.TxtProdDeliveryCity,
            Me.TxtProdDeliveryProvince
        }

        TableClass = New Product_Delivery(Me.DataGridViewProdDelivery, DASHBOARD_CONNECTION)
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

    Private Sub BtnProdDeliveryInsert_Click(sender As Object, e As EventArgs) Handles BtnProdDeliveryInsert.Click
        Try
            If Globals.SELECTED_CUSTOMER Is Nothing Then
                MsgBox("Please select a customer first.", vbExclamation)
                Return
            End If
            If Globals.SELECTED_PRODUCT_ORDER Is Nothing Then
                MsgBox("Please select a product order first.", vbExclamation)
                Return
            End If

            Dim Insert As New List(Of String)
            Dim Values = GetFieldValues()

            With Insert
                .Add(UtilityFunctions.GetIncrementedIndexID("product_delivery", "proddeliveryid"))
                .Add(Globals.SELECTED_CUSTOMER.Cells(0).Value)
                .Add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
                .Add(Globals.SELECTED_PRODUCT_ORDER.Cells(0).Value)
                .Add(Values(0))
                .Add(Values(1))
                .Add(Values(2))
                .Add(DateString)
                .Add(TimeString)
            End With

            TableClass.EventCreate(Insert)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnProdDeliveryUpdate_Click(sender As Object, e As EventArgs) Handles BtnProdDeliveryUpdate.Click
        Try
            If Me.DataGridViewProdDelivery.CurrentRow Is Nothing Then
                MsgBox("Please select a product delivery first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Dim ValuesToUpdate As New List(Of String)
            With ValuesToUpdate
                .Add(Me.DataGridViewProdDelivery.CurrentRow.Cells(0).Value)
                .AddRange(Values)
            End With

            TableClass.EventEdit(ValuesToUpdate)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnProdDeliveryDelete_Click(sender As Object, e As EventArgs) Handles BtnProdDeliveryDelete.Click
        Try
            If Me.DataGridViewProdDelivery.CurrentRow Is Nothing Then
                MsgBox("Please select a product delivery first.", vbExclamation)
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

    Private Sub UserControlProductDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()
    End Sub

    Private Sub DataGridViewProdDelivery_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewProdDelivery.MouseUp
        If DataGridViewProdDelivery.CurrentCell Is Nothing Then
            Return
        End If
        Try
            For i As Integer = 4 To 6
                FieldsArray(i - 4).Text = Me.DataGridViewProdDelivery.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
