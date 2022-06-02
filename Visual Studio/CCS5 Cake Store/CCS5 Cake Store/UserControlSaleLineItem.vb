Imports IBM.Data.DB2

Public Class UserControlSaleLineItem
    Private FieldsArray As TextBox()
    Private TableClass As Sale_Line_Item

    Private Sub InitializeFields()

        FieldsArray = {
            Me.TxtSaleLineItemID,
            Me.TxtSaleId,
            Me.TxtSaleProdId,
            Me.TxtSalePrice,
            Me.TxtSaleQty
        }

        TableClass = New Sale_Line_Item(Me.DataGridViewSaleLineItem, DASHBOARD_CONNECTION)
    End Sub

    Private Sub ClearFields()
        Try
            For Each Field As TextBox In FieldsArray
                Field.Clear()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetFieldValues()
        Try
            Dim Values = New List(Of String)
            For Each Field In FieldsArray
                Values.Add(Field.Text)
            Next
            Return Values
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub BtnSaleLineItemInsert_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemInsert.Click
        Try
            Dim values = GetFieldValues()
            TableClass.EventCreate(values)
            Call UpdateSubtotal(values(1))
            Call ClearFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemDelete_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemDelete.Click
        Try
            Dim ConfirmClose = MsgBox("Do you wish to delete this entry?", MsgBoxStyle.YesNo)
            If ConfirmClose = DialogResult.Yes Then
                TableClass.EventDelete()
                Call UpdateSubtotal(TableClass.DataGridView.CurrentRow.Cells(1).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSaleLineItemUpdate_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemUpdate.Click
        Try
            Dim Values = GetFieldValues()
            TableClass.EventEdit(Values)
            Call UpdateSubtotal(Values(1))
            Me.TxtSaleLineItemID.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSaleLineItemClearFields_Click(sender As Object, e As EventArgs) Handles BtnSaleLineItemClearFields.Click
        Try
            Call ClearFields()
            Me.TxtSaleLineItemID.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserControlSaleLineItem_Enter(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call InitializeFields()
            TableClass.Initialize()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridViewSaleLineItem_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridViewSaleLineItem.MouseUp
        Try
            For i As Integer = 0 To Me.DataGridViewSaleLineItem.CurrentRow.Cells.Count - 1
                FieldsArray(i).Text = Me.DataGridViewSaleLineItem.CurrentRow.Cells(i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' db2 select s.saleid, sum(li.salelineitemprice) as subtotal from sale s left join sale_line_item li on li.saleid = s.saleid group by s.saleid
    Public Sub UpdateSubtotal(ByRef SaleID As String)
        Dim StrGetSubtotal As String
        Dim StrUpdateSubtotal As String

        Dim CmdGetSubtotal As DB2Command
        Dim RdrGetSubtotal As DB2DataReader
        Dim CmdUpdateSubtotal As DB2Command
        Dim Subtotal As String

        Try
            StrGetSubtotal = "SELECT sum(salelineitemprice * salelineitemqty) from sale_line_item where saleid = " & SaleID
            CmdGetSubtotal = New DB2Command(StrGetSubtotal, DASHBOARD_CONNECTION)
            RdrGetSubtotal = CmdGetSubtotal.ExecuteReader

            If Not RdrGetSubtotal.HasRows Then
                Return
            End If

            RdrGetSubtotal.Read()
            Subtotal = RdrGetSubtotal.GetString(0)

            StrUpdateSubtotal = "UPDATE sale SET salesubtotal =" & Subtotal & " where saleid =" & SaleID
            CmdUpdateSubtotal = New DB2Command(StrUpdateSubtotal, DASHBOARD_CONNECTION)
            CmdUpdateSubtotal.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
