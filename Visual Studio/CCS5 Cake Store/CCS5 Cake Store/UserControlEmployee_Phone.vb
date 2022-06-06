Public Class UserControlEmployee_Phone

    Private FieldsArray As TextBox()
    Private TableClass As Employee_Phone

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtEmpPhoneNo
        }

        TableClass = New Employee_Phone(Me.DataGridViewEmployee_Phone, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
    End Sub

    Private Function GetFieldValues()
        If Globals.SELECTED_EMPLOYEE Is Nothing Then
            MsgBox("Please select an employee first.", vbExclamation)
            Return Nothing
        End If

        Dim Values = New List(Of String)
        With Values
            .Add(UtilityFunctions.GetIncrementedIndexID("employee_phone", "empphoneid"))
            .Add(Globals.SELECTED_EMPLOYEE.Cells(0).Value)
        End With
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        Return Values
    End Function

    Private Sub BtnEmp_PhoneInsert_Click(sender As Object, e As EventArgs) Handles BtnEmp_PhoneInsert.Click
        Try
            Dim values = GetFieldValues()

            TableClass.EventCreate(values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnEmp_PhoneDelete_Click(sender As Object, e As EventArgs) Handles BtnEmp_PhoneDelete.Click
        Try
            If Me.DataGridViewEmployee_Phone.CurrentRow Is Nothing Then
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

    Private Sub BtnEmp_PhoneUpdate_Click(sender As Object, e As EventArgs) Handles BtnEmp_PhoneUpdate.Click
        Try
            If Me.DataGridViewEmployee_Phone.CurrentRow Is Nothing Then
                MsgBox("Please select a phone number first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewEmployee_Phone.CurrentRow.Cells(0).Value
            TableClass.EventEdit(Values)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridViewEmployee_Phone_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewEmployee_Phone.MouseUp
        Try
            If Me.DataGridViewEmployee_Phone.CurrentCell Is Nothing Then
                Return
            End If
            Me.TxtEmpPhoneNo.Text = Me.DataGridViewEmployee_Phone.CurrentRow.Cells(2).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try
    End Sub
End Class
