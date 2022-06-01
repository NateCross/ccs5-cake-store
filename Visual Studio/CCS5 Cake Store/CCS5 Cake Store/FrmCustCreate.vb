Public Class FrmCustCreate
    Public ReturnValues() As String

    Private Sub BtnCustOK_Click(sender As Object, e As EventArgs) Handles BtnCustOK.Click
        Dim Values = New String() {
                Me.TxtCustId.Text,
                Me.TxtCustFirstName.Text,
                Me.TxtCustLastName.Text,
                Me.TxtCustMiddleName.Text,
                Me.TxtCustStreet.Text,
                Me.TxtCustCity.Text,
                Me.TxtCustProvince.Text,
                Me.TxtCustEmailAddress.Text
            }
        ReturnValues = Values
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCustCancel_Click(sender As Object, e As EventArgs) Handles BtnCustCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class