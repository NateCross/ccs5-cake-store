Public Class UserControlCustomer_Phone

    Private FieldsArray As TextBox()
    Private TableClass As Customer_Phone

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtCustPhoneNo
        }

        TableClass = New Customer_Phone(Me.DataGridViewCustomer_Phone, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_CUSTOMER Is Nothing Then
            MsgBox("Please select a customer first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(UtilityFunctions.GetIncrementedIndexID("customer_phone", "custphoneid"))
            .Add(Globals.SELECTED_CUSTOMER.Cells(0).Value)
        End With

        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnCust_PhoneInsert_Click(sender As Object, e As EventArgs) Handles BtnCust_PhoneInsert.Click
        Try
            Dim Values = GetFieldValues()
            If Values Is Nothing Then
                Return
            End If

            TableClass.EventCreate(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnCust_PhoneDelete_Click(sender As Object, e As EventArgs) Handles BtnCust_PhoneDelete.Click
        Try
            If Me.DataGridViewCustomer_Phone.CurrentRow Is Nothing Then
                MsgBox("Please select a phone number first.", vbExclamation)
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

    Private Sub UserControlSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()

    End Sub

    Private Sub BtnCust_PhoneUpdate_Click(sender As Object, e As EventArgs) Handles BtnCust_PhoneUpdate.Click
        Try
            If Me.DataGridViewCustomer_Phone.CurrentRow Is Nothing Then
                MsgBox("Please select a phone number first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewCustomer_Phone.CurrentRow.Cells(0).Value
            TableClass.EventEdit(Values)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewCustomer_Phone_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewCustomer_Phone.MouseUp
        Try
            If Me.DataGridViewCustomer_Phone.CurrentCell Is Nothing Then
                Return
            End If
            Me.TxtCustPhoneNo.Text = Me.DataGridViewCustomer_Phone.CurrentRow.Cells(2).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub
End Class
