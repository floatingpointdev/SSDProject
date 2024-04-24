Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLPrintLog_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function AddPrintLog(ByVal oPrintLog As PrintLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddPrintLog", _
                    oPrintLog.sTransCode, _
                    oPrintLog.sTerminalID, _
                    oPrintLog.sHostName, _
                    oPrintLog.sIPAddress, _
                    oPrintLog.dDate, _
                    oPrintLog.sTransMode, _
                    oPrintLog.sPrintDetails, _
                    oPrintLog.sSite)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function SavePrintLog(ByVal oPrintLog As PrintLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddPrintLog", _
                oPrintLog.sTransCode, _
                oPrintLog.sTerminalID, _
                oPrintLog.sHostName, _
                oPrintLog.sIPAddress, _
                oPrintLog.dDate, _
                oPrintLog.sTransMode, _
                oPrintLog.sPrintDetails, _
                oPrintLog.sSite)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function GetLastPrintLog(ByVal oPrintLog As PrintLog_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        iErrorCode = 0
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastPrintLog", _
                        oPrintLog.sTerminalID, _
                        oPrintLog.sSite)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function
End Class
