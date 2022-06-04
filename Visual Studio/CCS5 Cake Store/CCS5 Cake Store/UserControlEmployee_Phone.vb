﻿Public Class UserControlEmployee_Phone

    Private FieldsArray As TextBox()
    Private TableClass As Employee_Phone ' Replace Sales with the class you made

    Private Sub InitializeFields()

        ' Declare all the text fields here
        ' Makes it easy to perform operations on all of them
        FieldsArray = {
            Me.TxtEmpPhoneId,
            Me.TxtEmpId,
            Me.TxtEmpPhoneNo
        }

        ' Change the "New Sales" into the class declared above
        ' then change the first argument to the datagridview in the form
        ' Keep the second argument
        TableClass = New Employee_Phone(Me.DataGridViewEmployee_Phone, DASHBOARD_CONNECTION)
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

    Private Sub BtnEmp_PhoneInsert_Click(sender As Object, e As EventArgs) Handles BtnEmp_PhoneInsert.Click
        Try
            Dim values = GetFieldValues()

            TableClass.EventCreate(values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnEmp_PhoneDelete_Click(sender As Object, e As EventArgs) Handles BtnEmp_PhoneDelete.Click
        Try
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
