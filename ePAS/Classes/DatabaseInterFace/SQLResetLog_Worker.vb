Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLResetLog_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function AddResetLog(ByVal oResetLog As ResetLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddResetLog", _
                    oResetLog.sUser, _
                    oResetLog.sSite, _
                    oResetLog.sTerminalID, _
                    oResetLog.sIPAddress, _
                    oResetLog.sHostName, _
                    oResetLog.sTransMode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function


End Class
