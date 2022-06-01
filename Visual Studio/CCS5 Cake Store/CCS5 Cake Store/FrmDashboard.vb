Imports IBM.Data.DB2

Public Class FrmDashboard
    Private Sub TerminateConnection()
        ' Write code to save changes to database
    End Sub

    Private Sub RefreshDataGrid()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Enter
        ' Try
        ' DashboardConnection = New DB2Connection(Globals.CONNECTION_STRING)
        ' DASHBOARD_CONNECTION = DashboardConnection
        ' DashboardConnection.Open()
        ' Catch ex As Exception
        '     MsgBox(ex.ToString)
        ' End Try
    End Sub

    Private Sub BtnQuitProgram_Click(sender As Object, e As EventArgs) Handles BtnQuitProgram.Click
        Dim ConfirmClose = MsgBox("Do you wish to exit?", MsgBoxStyle.YesNo)
        If ConfirmClose = DialogResult.Yes Then
            Try
                DASHBOARD_CONNECTION.Close()
                FrmLogin.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        DASHBOARD_CONNECTION.Close()
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPageSales.Enter
        Debug.WriteLine("Enter tab 1")
    End Sub

    Private Sub TabPage1_Leave(sender As Object, e As EventArgs) Handles TabPageSales.Leave
        Debug.WriteLine("Leave tab 1")
    End Sub

    Private Sub TabPageInventory_Enter(sender As Object, e As EventArgs) Handles TabPageInventory.Enter
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class