Imports IBM.Data.DB2

Public Module Globals
    ' Placed here because it will be constantly reused.
    ' The uid and password are preset here, as the user will be prompted
    ' to login using credentials in the database.
    Public CONNECTION_STRING As String = "server=localhost; database=cake; uid=db2admin; password=db2admin"

    ' Used as the employee ID for transactions
    Public CURRENTLY_LOGGED_IN_EMPLOYEE_ID As Integer

    ' So we can essentially pass this to user controls
    Public DASHBOARD_CONNECTION As Common.DbConnection
End Module
