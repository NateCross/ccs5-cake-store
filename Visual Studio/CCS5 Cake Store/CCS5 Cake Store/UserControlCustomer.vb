Public Class UserControlCustomer
    Private FieldsArray As TextBox()
    Private Cust As Customer

    Private Sub InitializeFields()
        FieldsArray = {
            Me.TxtCustId,
            Me.TxtCustFirstName,
            Me.TxtCustLastName,
            Me.TxtCustMiddleName,
            Me.TxtCustStreet,
            Me.TxtCustCity,
            Me.TxtCustProvince,
            Me.TxtCustEmailAddress
        }
        Cust = New Customer(Me.DataGridViewCustomers, DASHBOARD_CONNECTION)
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

    Private Sub UserControlCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        Cust.Initialize()
    End Sub

    Private Sub BtnCustCreate_Click(sender As Object, e As EventArgs) Handles BtnCustCreate.Click
        Try
            Dim Values = GetFieldValues()

            Cust.EventCreate(Values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnCustDelete_Click(sender As Object, e As EventArgs) Handles BtnCustDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Cust.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewCustomers_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewCustomers.MouseUp
        Try
            For i As Integer = 0 To DataGridViewCustomers.CurrentRow.Cells.Count - 1
                FieldsArray(i).Text = Me.DataGridViewCustomers.CurrentRow.Cells(i).Value
            Next
            Me.TxtCustId.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCustUpdate_Click(sender As Object, e As EventArgs) Handles BtnCustUpdate.Click
        Try
            Dim Values = GetFieldValues()
            Cust.EventEdit(Values)
            Me.TxtCustId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCustClear_Click(sender As Object, e As EventArgs) Handles BtnCustClear.Click
        Try
            Call ClearFields()
            Me.TxtCustId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
