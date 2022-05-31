Imports IBM.Data.DB2

Public Class UserControlProducts

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
        Debug.WriteLine("Enter tab inventory")
        Dim Prod As New Product(Me.DataGridView1, DASHBOARD_CONNECTION)
        Prod.Initialize()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
