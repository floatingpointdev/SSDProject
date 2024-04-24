Imports Microsoft.SqlServer.Management.Smo
Imports system.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLServerSetup_Worker

    Private oCls As New Common_Helper()
    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()

    Public Function getSQLServers() As DataTable
        Application.DoEvents()
        Dim dt As DataTable = SmoApplication.EnumAvailableSqlServers(False)
        dt.Rows.Add("Refresh...")
        If (dt.Rows.Count > 0) Then
            Return dt
        End If
        Return Nothing
    End Function

    Public Function getDatabases(ByVal sServer As String, ByVal sUser As String, ByVal sPass As String, ByVal iAuthentication As Integer) As DataTable
        Dim dt As New DataTable()
        Dim dtNothing As New DataTable()

        dt.Columns.Add("Name")
        dtNothing.Columns.Add("Name")
        dtNothing.Rows.Add("")


        Dim bu As New SqlConnectionStringBuilder()

        bu.DataSource = sServer
        If (iAuthentication = 1) Then
            bu.IntegratedSecurity = False
            bu.UserID = sUser
            bu.Password = sPass
        Else
            bu.IntegratedSecurity = True
        End If

        Dim sqlConn As New SqlConnection(bu.ToString())


        Try
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
                sqlConn.Open()
            End If
        Catch ex As Exception
            oCls.ErrorBox("Unable to list existing databases. " + ex.Message)
            Return dtNothing
        End Try

        sqlConn.Close()

        Dim svrConn As New ServerConnection(sqlConn)
        Dim svr As New Server(svrConn)

        Try
            For Each db As Microsoft.SqlServer.Management.Smo.Database In svr.Databases
                Dim dr As DataRow = dt.NewRow()
                dr("Name") = db.Name
                dt.Rows.Add(dr)
            Next
        Catch ex As Exception
            oCls.ErrorBox("Unable to list existing databases. " + ex.Message)
            Return dtNothing
        End Try

        Return dt
    End Function

End Class
