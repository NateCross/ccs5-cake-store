Imports IBM.Data.DB2

Public Class FrmDashboard

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            If Globals.CURRENTLY_LOGGED_IN_EMPLOYEE_POSITION = "MANAGER" Then
                If Me.TabDashboard.TabPages(8) Is Nothing Then
                    Me.TabDashboard.TabPages.Insert(8, Me.TabPageEmpManagement)

                End If
            Else
                Me.TabDashboard.TabPages.Remove(Me.TabPageEmpManagement)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
        Me.Hide()
    End Sub

    Private Sub FrmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Not e.CloseReason = CloseReason.UserClosing Then
            FrmLogin.Close()
            Me.Close()
        End If

        Dim ConfirmClose = MsgBox("Do you wish to exit?", MsgBoxStyle.YesNo)
        If ConfirmClose = DialogResult.Yes Then
            Try
                e.Cancel = False
                DASHBOARD_CONNECTION.Close()
                FrmLogin.Close()
                Return
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            e.Cancel = True
        End If

    End Sub

    ' If a table usercontrol appears in multiple tabs, run the initializefields subroutine here.
    ' This allows it to refresh changes properly since normally
    ' If you change in one tab, the other tab does not change automatically
    Private Sub TabDashboard_TabIndexChanged(sender As Object, e As EventArgs) Handles TabDashboard.SelectedIndexChanged
        If TabDashboard.SelectedIndex = 4 Then
            Call UserControlPurchaseOrder1.InitializeFields()
        ElseIf TabDashboard.SelectedIndex = 5 Then
            Call UserControlPurchaseOrder2.InitializeFields()
        End If
    End Sub
End Class