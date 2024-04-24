Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLResetCalendar_Worker

    Private sqlConn As SqlConnection = Nothing

    Public Function AddResetCalendar(ByVal oResetCalendar As ResetCalendar_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddResetCalendar", _
                    oResetCalendar.dDate, _
                    oResetCalendar.sType, _
                    oResetCalendar.sAddedBy, _
                    oResetCalendar.sIPAddress, _
                    oResetCalendar.sHostName, _
                    oResetCalendar.sSite, _
                    oResetCalendar.sTerminalID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateResetCalendar(ByVal oResetCalendar As ResetCalendar_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateResetCalendar", _
                    oResetCalendar.iID, _
                    oResetCalendar.dDate, _
                    oResetCalendar.sType, _
                    oResetCalendar.sUpdatedBy, _
                    oResetCalendar.sIPAddress, _
                    oResetCalendar.sHostName, _
                    oResetCalendar.sSite, _
                    oResetCalendar.sTerminalID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteResetCalendar(ByVal oResetCalendar As ResetCalendar_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteResetCalendar", _
                    oResetCalendar.iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function GetResetCalendar(ByVal oResetCalendar As ResetCalendar_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetResetCalendar")
        Catch ex As SqlException
            '2812 - stored procedure not found
            '10054
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End If
        Return Nothing
    End Function

    Public Function ResetBySchedule(ByVal oResetLog As ResetLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetBySchedule", _
                                             oResetLog.sUser, _
                                             oResetLog.sSite, _
                                             oResetLog.sTerminalID, _
                                             oResetLog.sIPAddress, _
                                             oResetLog.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

End Class
