﻿Public Class UserControlCustomer_Phone

    Private FieldsArray As TextBox()
    Private TableClass As Customer_Phone' Replace Sales with the class you made

    Private Sub InitializeFields()

        ' Declare all the text fields here
        ' Makes it easy to perform operations on all of them
        FieldsArray = {
            Me.TxtCustId,
            Me.TxtCustPhoneId,
            Me.TxtCustPhoneNo
        }

        ' Change the "New Sales" into the class declared above
        ' then change the first argument to the datagridview in the form
        ' Keep the second argument
        TableClass = New Customer_Phone(Me.DataGridViewCustomer_Phone, DASHBOARD_CONNECTION)
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

    ' Those were all the needed functions.
    ' Now we handle the events.
    ' Look at the bar above this pane that says "UserControlSale"
    ' Change the left box to the element you want to give an event to
    ' then change the right box to what event
    ' Just follow the events here

    Private Sub BtnCust_PhoneInsert_Click(sender As Object, e As EventArgs) Handles BtnCust_PhoneInsert.Click
        Try
            Dim values = GetFieldValues()

            ' The following lines are lines I put to set defaults
            ' for the remaining fields
            ' You only really need the getfieldvalues in most cases
            values.add(Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID)
            values.add(DateString)
            values.add(TimeString)
            values.add("0.00") ' Empty subtotal

            TableClass.EventCreate(values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnCust_PhoneDelete_Click(sender As Object, e As EventArgs) Handles BtnCust_PhoneDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    ' Build the program with Build -> Build CCS5 Cake Store
    ' Then, this user control will show up in the Toolbox menu on the right
    ' You can then add it to the Dashboard form

    ' Don't forget this, actually, or the program will break
    Private Sub UserControlSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call InitializeFields()
        TableClass.Initialize()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class