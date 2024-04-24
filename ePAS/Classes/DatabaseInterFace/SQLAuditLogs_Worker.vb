Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLAuditLogs_Worker
    Private sqlConn As SqlConnection = Nothing
    'Public Function AddAuditLog(ByVal oAuditLog As AuditLog_Entity) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)

    '    Return SqlHelper.ExecuteNonQuery(sqlConn, "spAudit_AddLog", _
    '        oAuditLog.sCardID, _
    '        oAuditLog.sMemberID, _
    '        oAuditLog.iPoints, _
    '        oAuditLog.sLoyaltyCode)
    'End Function
End Class
