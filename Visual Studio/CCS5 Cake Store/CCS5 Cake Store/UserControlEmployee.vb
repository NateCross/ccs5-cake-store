Imports IBM.Data.DB2

Public Class UserControlEmployee

    Private FieldsArray As TextBox()
    Private FieldsDateArray As DateTimePicker()
    Private Emp As Employee

    Private Sub InitializeFields()
        FieldsArray = {
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
        FieldsDateArray = {
            Me.DateTimePickerDOB,
            Me.DateTimePickerEmployment
        }
        Emp = New Employee(Me.DataGridViewEmployee, DASHBOARD_CONNECTION)

        Me.BtnEmpTerminate.Enabled = False
    End Sub

    Private Sub ClearFields()
        For Each Field As TextBox In FieldsArray
            Field.Clear()
        Next
        For Each Field In FieldsDateArray
            Field.ResetText()
        Next
    End Sub

    Private Function GetFieldValues()
        Dim Values = New List(Of String)

        Values.Add(GetIncrementedIndexID("employee", "empid"))
        For Each Field In FieldsArray
            Values.Add(Field.Text)
        Next
        For Each Field In FieldsDateArray
            Values.Add(Field.Value.Date.ToString("MM-dd-yyyy"))
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
            If Me.DataGridViewEmployee.CurrentRow Is Nothing Then
                MsgBox("Please select an employee first.", vbExclamation)
                Return
            End If
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
            For i As Integer = 1 To Me.DataGridViewEmployee.CurrentRow.Cells.Count - 4
                FieldsArray(i - 1).Text = Me.DataGridViewEmployee.CurrentRow.Cells(i).Value
            Next
            For i As Integer = Me.DataGridViewEmployee.CurrentRow.Cells.Count - 3 To Me.DataGridViewEmployee.CurrentRow.Cells.Count - 2
                FieldsDateArray(i - 17).Value = Me.DataGridViewEmployee.CurrentRow.Cells(i).Value
            Next
            Me.BtnEmpTerminate.Enabled = True

            Globals.SELECTED_EMPLOYEE = Me.DataGridViewEmployee.CurrentRow
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return
        End Try

    End Sub

    Private Sub BtnEmpUpdate_Click(sender As Object, e As EventArgs) Handles BtnEmpUpdate.Click
        Try
            If Me.DataGridViewEmployee.CurrentRow Is Nothing Then
                MsgBox("Please select an employee first.", vbExclamation)
                Return
            End If

            Dim Values = GetFieldValues()
            Values(0) = Me.DataGridViewEmployee.CurrentRow.Cells(0).Value
            Emp.EventEdit(Values)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnEmpClear_Click(sender As Object, e As EventArgs) Handles BtnEmpClear.Click
        Try
            Call ClearFields()
            Me.BtnEmpTerminate.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnEmpTerminate_Click(sender As Object, e As EventArgs) Handles BtnEmpTerminate.Click
        Dim CmdExec As Db2command
        Dim StrExec As String

        Try
            Dim ConfirmClose = MsgBox("Do you wish to terminate this employee's contract?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                StrExec = "UPDATE employee SET empdateofseparation=current_date where empid=" & Me.DataGridViewEmployee.CurrentRow.Cells(0).Value
                CmdExec = New DB2Command(StrExec, DASHBOARD_CONNECTION)
                CmdExec.ExecuteNonQuery()

                Call Emp.RefreshDataGrid()
                Call ClearFields()
                Me.BtnEmpTerminate.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtEmpLastNameSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpLastNameSearch.TextChanged
        Try
            If (Me.TxtEmpLastNameSearch.Text = "") Then
                Emp.RefreshDataGrid()
                Return
            End If

            Emp.RefreshDataGridSearch(Me.TxtEmpLastNameSearch.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
