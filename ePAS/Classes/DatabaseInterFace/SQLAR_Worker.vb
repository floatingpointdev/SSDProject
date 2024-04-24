Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLAR_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function AddAR(ByVal oAR As AR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddAR", _
                oAR.sMemberID, _
                oAR.dARAmount, _
                IIf(oAR.dtApplicableMonth.ToString() = "1/1/0001 12:00:00 AM", Nothing, oAR.dtApplicableMonth.ToString()), _
                oAR.sAddedBy, _
                oAR.sIPAddress, _
                oAR.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateARByMemberID(ByVal oAR As AR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateARByMemberID", _
                        oAR.sMemberID, _
                        oAR.dARAmount, _
                        oAR.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateARConsumableByMemberID(ByVal oAR As AR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateARConsumableByMemberID", _
                oAR.sMemberID, _
                oAR.dARConsumable, _
                oAR.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function



    Public Function InsertUpdate(ByVal oAR As AR_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_InsertUpdateAR", _
                oAR.sMemberID, _
                oAR.dARAmount, _
                oAR.dtDateUploaded, _
                oAR.sUploadedBy, _
                oAR.dtDateUpdated, _
                oAR.sUpdatedBy, _
                oAR.dtDateAdded, _
                oAR.sAddedBy, _
                oAR.sIPAddress, _
                oAR.sHostName)

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

    'Public Function DeductARByMemberID(ByVal oAR As AR_Entity) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeductARByMemberID", _
    '        oAR.sMemberID, _
    '        oAR.dCAConsumable)
    'End Function

    'Public Function DeleteRewardsByID(ByVal oRewards As Rewards_Entity) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteRewardsByID", _
    '                                     oRewards.iID)
    'End Function

    'Public Function DeleteRewardsByMemberID(ByVal oRewards As Rewards_Entity) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteRewardsByMemberID", _
    '                                     oRewards.sMemberID)
    'End Function

    'Public Function CheckRewards(ByVal oRewards As Rewards_Entity) As Boolean
    '    Dim ds As New DataSet

    '    sqlConn = New SqlConnection(eConn.sConnString)

    '    Try
    '        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckRewards", _
    '            oRewards.sMemberID, _
    '            oRewards.dtValidFrom, _
    '            oRewards.dtValidTo)

    '    Catch ex As SqlException
    '        Return Nothing
    '    End Try

    '    If ds.Tables.Count > 0 Then
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            Return True
    '        End If
    '    End If
    '    Return False
    'End Function

    Public Function GetARByMemberID(ByVal oAR As AR_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        iErrorCode = 0
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetARByMemberID", _
                oAR.sMemberID)

        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetTotalARByMemberID(ByVal oARLog As ARLog_Entity) As Double
        Dim ds As New DataSet
        Dim dt As New DataTable

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetTotalARByMemberID", _
                oARLog.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                Return Val(dt.Rows(0)(0).ToString())
            End If
        End If
        Return Nothing
    End Function

    Public Function GetARLogSumByMemberID(ByVal oAR As AR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetARLogSumByMemberID", _
                oAR.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetSDARByMemberID(ByVal oAR As AR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetSDARByMemberID", _
                oAR.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckAR(ByVal oAR As AR_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckAR", _
                oAR.sMemberID, _
                oAR.dARAmount, _
                oAR.dtApplicableMonth)

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

    Public Function ResetAR(ByVal oResetLog As ResetLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetAR", _
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

    Public Function ResetARByMemberID(ByVal sMemberID As String) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetARByMemberID", _
                                      sMemberID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    'Public Function DeductRewardsByTransID(ByVal oRewards As Rewards_Entity, ByVal iDecrementBy As Integer) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Try
    '        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeductRewardsByTransID", _
    '            oRewards.iID, _
    '            iDecrementBy)

    '    Catch ex As SqlException
    '        Return ex.ErrorCode
    '    End Try
    'End Function


    'Public Function GetCurrentRewardsByMemberID(ByVal oRewards As Rewards_Entity) As Integer
    '    Dim ds As New DataSet

    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Try
    '        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCurrentRewardsByMemberID", _
    '            oRewards.sMemberID, _
    '            Date.Now.ToShortDateString())

    '    Catch ex As SqlException
    '        Return ex.ErrorCode
    '    End Try

    '    If ds.Tables.Count > 0 Then
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            Return CInt(ds.Tables(0).Rows(0)("ConsumablePoints"))
    '        End If
    '    End If
    'End Function

    'Public Function GetRewards() As DataTable
    '    Dim ds As New DataSet

    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Try
    '        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetRewards1")

    '    Catch ex As SqlException
    '        Return Nothing
    '    End Try

    '    If ds.Tables.Count > 0 Then
    '        Return ds.Tables(0)
    '    End If
    '    Return Nothing
    'End Function
End Class
