Imports IBM.Data.DB2

Public Class FrmLogin
    Private LoginConnection As Common.DbConnection

    Private Function GetLoginCommand()
        Dim LoginString As String = "select empid from employee where empusername='" + Me.TxtUsername.Text + "' and emppassword='" + Me.TxtPassword.Text + "'"

        Try
            Return New DB2Command(LoginString, LoginConnection)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim CmdLogin As DB2Command
        Dim RdrLogin As DB2DataReader

        Try

            CmdLogin = GetLoginCommand()
            RdrLogin = CmdLogin.ExecuteReader

            If Not RdrLogin.HasRows Then
                MsgBox("Invalid username or password. Please try again.")
                Return
            End If

            RdrLogin.Read()
            Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_ID = RdrLogin.GetString(0)
            FrmDashboard.Show()
            Me.Hide()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnExitLogin_Click(sender As Object, e As EventArgs) Handles BtnExitLogin.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoginConnection = New DB2Connection(Globals.CONNECTION_STRING)
            Globals.DASHBOARD_CONNECTION = LoginConnection
            Globals.DASHBOARD_CONNECTION.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class
