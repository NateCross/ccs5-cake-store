Public Class UserControlSupplies

    Private FieldsArray As TextBox()
    Public Shared TableClass As Supplies ' Replace Sales with the class you made

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSupplyId,
            Me.TxtSupplyName,
            Me.TxtSupplyQty,
            Me.TxtSupplyUnitOfMeasurement
        }

        ' Change the "New Sales" into the class declared above
        ' then change the first argument to the datagridview in the form
        ' Keep the second argument
        TableClass = New Supplies(Me.DataGridViewSupplies, DASHBOARD_CONNECTION)
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

    Private Sub BtnSupplyInsert_Click(sender As Object, e As EventArgs) Handles BtnSupplyInsert.Click
        Try
            Dim values = GetFieldValues()

            TableClass.EventCreate(values)
            Call ClearFields()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSupplyDelete_Click(sender As Object, e As EventArgs) Handles BtnSupplyDelete.Click
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

    Private Sub DataGridViewSupplies_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSupplies.MouseUp
        Globals.SELECTED_SUPPLY = Me.DataGridViewSupplies.CurrentRow
    End Sub
End Class
