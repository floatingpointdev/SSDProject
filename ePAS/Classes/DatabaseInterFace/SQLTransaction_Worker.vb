Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLTransaction_Worker

    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()

    Public Function AddLog(ByVal oLog As Transaction_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddLog", _
                oLog.dTransDate, _
                oLog.sCardID, _
                oLog.sMemberID, _
                oLog.sSite, _
                oLog.sTransMode, _
                oLog.sIPAddress, _
                oLog.sHostName, _
                oLog.sTerminal, _
                oLog.dAmount, _
                oLog.sCashier, _
                oLog.sTransCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function AddARLog(ByVal oAR As ARLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddARLog", _
                IIf(oAR.dtTransDate.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtTransDate), _
                oAR.sTransCode, _
                oAR.sMemberID, _
                oAR.sCardID, _
                oAR.sSite, _
                oAR.sLocation, _
                oAR.sCompanyCode, _
                oAR.dPrevBalance, _
                oAR.dAmount, _
                oAR.dNewBalance, _
                oAR.sUser, _
                IIf(oAR.dtApplicableMonth.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtApplicableMonth), _
                oAR.sRemarks, _
                oAR.sIPAddress, _
                oAR.sHostName, _
                oAR.sTransType, _
                oAR.iRefID, _
                oAR.sPOSRefCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UploadARLog(ByVal oAR As ARLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UploadARLog", _
                IIf(oAR.dtTransDate.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtTransDate), _
                oAR.sTransCode, _
                oAR.sMemberID, _
                oAR.sLocation, _
                oAR.dAmount, _
                oAR.sUser, _
                IIf(oAR.dtApplicableMonth.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtApplicableMonth), _
                oAR.sRemarks, _
                oAR.sIPAddress, _
                oAR.sHostName, _
                oAR.sTransType)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function


    Public Function UpdateARLogByID(ByVal oAR As ARLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateARLogByID", _
                oAR.iID, _
                oAR.dAmount, _
                oAR.sUser, _
                IIf(oAR.dtApplicableMonth.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtApplicableMonth), _
                oAR.sRemarks, _
                oAR.sIPAddress, _
                oAR.sHostName, _
                oAR.sTransType)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteCreditLogsByID(ByVal iID As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteCreditLogsbyID", iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function AddCALog(ByVal oCA As CALog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddCALog", _
                IIf(oCA.dtTransDate.ToString() = "1/1/0001 12:00:00 AM", Nothing, oCA.dtTransDate), _
                oCA.sTransCode, _
                oCA.sTransType, _
                oCA.sMemberID, _
                oCA.sCardID, _
                oCA.sSite, _
                oCA.sLocation, _
                oCA.sCompanyCode, _
                oCA.dPrevBalance, _
                oCA.dAmount, _
                oCA.dNewBalance, _
                oCA.sUser, _
                oCA.sRemarks, _
                oCA.sIPAddress, _
                oCA.sHostName, _
                oCA.iRefID, _
                oCA.sPOSRefCode)
        Catch ex As SqlException
            Return ex.Number

        End Try
        Return 0
    End Function

    Public Function UpdateCALogTransCode(ByVal oCA As CALog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCALogTransCode", _
                oCA.iID, _
                oCA.sTransCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateARLogTransCode(ByVal oAR As ARLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateARLogTransCode", _
                oAR.iID, _
                oAR.sTransCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UploadCALog(ByVal oCA As CALog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddCALog", _
                IIf(oCA.dtTransDate.ToString() = "1/1/0001 12:00:00 AM", Nothing, oCA.dtTransDate), _
                oCA.sTransCode, _
                oCA.sTransType, _
                oCA.sMemberID, _
                oCA.sCardID, _
                oCA.sLocation, _
                oCA.dAmount, _
                oCA.sUser, _
                oCA.sRemarks, _
                oCA.sIPAddress, _
                oCA.sHostName, _
                oCA.iRefID, _
                oCA.sPOSRefCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function AddUpdateCALog(ByVal oCA As CALog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddUpdateCALog", _
                oCA.iID, _
                oCA.sTransCode, _
                oCA.sMemberID, _
                oCA.sCardID, _
                oCA.dAmount, _
                oCA.sRemarks, _
                oCA.sUser, _
                oCA.sLocation, _
                oCA.sIPAddress, _
                oCA.sHostName, _
                oCA.iRefID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteCALogByID(ByVal iID As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteCALogbyID", iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function CheckCATransLog(ByVal oCA As CALog_Entity, iErrorCode as Integer) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckCATransLog", _
                oCA.dtTransDate, _
                oCA.sMemberID, _
                oCA.sLocation, _
                oCA.dAmount)
        Catch ex As SqlException
            iErrorCode = ex.Number
	    Return False
        End Try

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function CheckCATransLogByRefID(ByVal iRefID As Integer) As Integer
        Dim ds As New DataSet
        Dim dt As New DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckCATransLogByRefID", _
                iRefID)

            If ds.Tables.Count > 0 Then
                dt = ds.Tables(0)
                Return dt.Rows.Count
            End If
        Catch ex As SqlException
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function GetCALogs() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCALogs")
        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function AddOtherTransLog(ByVal oOtherTrans As OtherTransactions_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddOtherTransLog", _
                oOtherTrans.dTransDate, _
                oOtherTrans.sMemberID, _
                oOtherTrans.dAmount, _
                oOtherTrans.sTransType, _
                oOtherTrans.sUploadedBy, _
                oOtherTrans.sIPAddress, _
                oOtherTrans.sHostName, _
                oOtherTrans.sRemarks)

        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateLog(ByVal oLog As Transaction_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateLog", _
                oLog.sCardID, _
                oLog.sMemberID, _
                oLog.sSite, _
                oLog.dTransDate, _
                oLog.sTransMode, _
                oLog.sRemarks, _
                oLog.iPoints)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteLog(ByVal oLog As Transaction_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteLog", _
                oLog.dTransDate)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function GetLogs(ByVal dDateFrom As Date, ByVal dDateTo As Date) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogs", dDateFrom, dDateTo)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLogsByConcessionaire(ByVal dDateFrom As Date, ByVal dDateTo As Date, ByVal sConcessionaire As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogsByConcessionaire", dDateFrom, dDateTo, sConcessionaire)
        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLogsByConcessionaire1(ByVal dDateFrom As Date, ByVal dDateTo As Date, ByVal sConcessionaire As String, ByVal sSiteName As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogsByConcessionaire1", dDateFrom, dDateTo, sConcessionaire, sSiteName)
        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLogsBySearch(ByVal sWhere As String, ByVal sLike As String)
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        If sWhere = "CIM Number" Then sWhere = "A.MemberID"
        If sWhere = "Name" Then
            Dim dtMember As New DataTable
            dtMember = oSQLMember.GetMemberByName(sLike)
            If Not dtMember Is Nothing Then
                If dtMember.Rows.Count > 0 Then
                    sWhere = "A.MemberID"
                    sLike = dtMember.Rows(0)("MemberID")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End If

        If sWhere = "Transaction Date" Then
            sWhere = "TransDate"
        End If


        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogsBySearch", sWhere, "%" & sLike & "%")

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

    Public Function GetLogsBySearch(ByVal sWhere As String)
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogsBySearch1", sWhere)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

    Public Function GetLogsByCardID(ByVal oLog As Transaction_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLogsByCardID", _
            oLog.sCardID, _
            oLog.dTransDate)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLastTransLogByCardID(ByVal oLog As Transaction_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastTransLogByCardID", _
            oLog.sCardID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function


    Public Function GetLastTransLogByMemberID(ByVal oLog As Transaction_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastTransLogByMemberID", _
            oLog.sMemberID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLastCALogByMemberID(ByVal oLog As CALog_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        iErrorCode = 0
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastCALogByMemberID", _
                oLog.sMemberID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetLastARLogByMemberID(ByVal oLog As ARLog_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastARLogByMemberID", _
                oLog.sMemberID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function


    Public Function GetLastTransLogByTerminalID(ByVal sTerminalID) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLastTransLogByTerminalID", _
            sTerminalID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCreditLogsbyMemberID(ByVal sMemberID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCreditLogsByMemberID", sMemberID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCreditLogsPaymentByMemberID(ByVal sMemberID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCreditLogsPaymentByMemberID", sMemberID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetAllAR() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAllAR")
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function ProcessTransaction(ByVal oLog As Transaction_Entity, ByVal iID As Integer, ByVal iDecrementBy As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ProcessTransaction", _
                iID, _
                oLog.sCardID, _
                oLog.sMemberID, _
                oLog.sSite, _
                oLog.sConcessionaire, _
                oLog.dTransDate, _
                oLog.sTransMode, _
                oLog.sRemarks, _
                oLog.iPoints, _
                iDecrementBy, _
                iID)

        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function VoidTransaction(ByVal oLogs As Transaction_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_VoidTransaction", _
                oLogs.iID, oLogs.sTransMode, oLogs.sVoidedBy, oLogs.dAmount, oLogs.sIncidentReportNo)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function GetDistinctSitesFromLogs() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetDistinctSitesFromLogs")
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetDistinctConcessionairesFromLogs() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetDistinctConcessionairesFromLogs")
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCACreditLogsByCardID(ByVal sCardID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCACreditLogsByCardID", sCardID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCACreditLogsByMemberID(ByVal sMemberID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCACreditLogsByMemberID", sMemberID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCACreditLogsByDateRange(ByVal dDateFrom As Date, ByVal dDateTo As Date) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCACreditLogsByDateRange", dDateFrom, dDateTo)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCATransLogsByMemberID(ByVal sMemberID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCALogsByMemberID", sMemberID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckCreditLogs(ByVal oARLog As ARLog_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckARLog", _
                oARLog.sMemberID, _
                oARLog.dAmount, _
                oARLog.sRemarks)
            'oARLog.dtApplicableMonth)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function CheckOtherTransLog(ByVal oOtherTrans As OtherTransactions_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckOtherTransLog", _
                oOtherTrans.sMemberID, _
                oOtherTrans.dTransDate, _
                oOtherTrans.sTransType, _
                oOtherTrans.dAmount, _
                oOtherTrans.sRemarks)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function GetVoidableTransByMemberID(ByVal oLog As Transaction_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetVoidableTransByMemberID", oLog.sMemberID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetVoidedTransactions() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetVoidedTransactions")
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetVoidedTransByMemberID(ByVal oLog As Transaction_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetVoidedTransByMemberID", oLog.sMemberID)
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
