Public Class UserControlEmployee

    Private FieldsArray As TextBox()
    Private Emp As Employee

    ' Note: Get the date and time fields, too
    Private Sub InitializeFields()
        FieldsArray = {
            Me.TxtEmpId,
            Me.TxtEmpFirstName,
            Me.TxtEmpLastName,
            Me.TxtEmpMiddleName,
            Me.TxtEmpStreet,
            Me.TxtEmpCity,
            Me.TxtEmpProvince,
            Me.TxtEmpEmailAddress,
            Me.TxtEmpAge,
            Me.TxtEmpPosition,
            Me.TxtEmpMonthlySalary,
            Me.TxtEmpSSS,
            Me.TxtEmpPagIbig,
            Me.TxtEmpPhilHealth,
            Me.TxtEmpTIN,
            Me.TxtEmpUsername,
            Me.TxtEmpPassword
        }
        Emp = New Employee(Me.DataGridViewEmployee, DASHBOARD_CONNECTION)
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

    Private Sub UserControlEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        Emp.Initialize()
    End Sub

    Private Sub BtnEmpInsert_Click(sender As Object, e As EventArgs) Handles BtnEmpInsert.Click
        Try
            Dim values = GetFieldValues()

            Emp.EventCreate(values)
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnEmpDelete_Click(sender As Object, e As EventArgs) Handles BtnEmpDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                Emp.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewEmployee_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewEmployee.MouseUp
        Try
            For i As Integer = 0 To DataGridViewEmployee.CurrentRow.Cells.Count - 1
                FieldsArray(i).Text = Me.DataGridViewEmployee.CurrentRow.Cells(i).Value
            Next
            Me.TxtEmpId.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnEmpUpdate_Click(sender As Object, e As EventArgs) Handles BtnEmpUpdate.Click
        Try
            Dim Values = GetFieldValues()
            Emp.EventEdit(Values)
            Me.TxtEmpId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnEmpClear_Click(sender As Object, e As EventArgs) Handles BtnEmpClear.Click
        Try
            Call ClearFields()
            Me.TxtEmpId.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
