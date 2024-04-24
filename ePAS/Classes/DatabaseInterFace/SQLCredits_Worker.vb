Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLCredits_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function AddCredits(ByVal oCredits As Credits_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddCredits", _
            oCredits.sMemberID, _
            oCredits.dCreditsAmount, _
            IIf(oCredits.dtApplicableMonth.ToString() = "1/1/0001 12:00:00 AM", Nothing, oCredits.dtApplicableMonth.ToString()), _
            oCredits.sAddedBy, _
            oCredits.sIPAddress, _
            oCredits.sHostName)
    End Function

    Public Function UpdateCreditsByMemberID(ByVal oCredits As Credits_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCreditsByMemberID", _
            oCredits.sMemberID, _
            oCredits.dCreditsAmount)
    End Function

    Public Function UpdateCreditsConsumableByMemberID(ByVal oCredits As Credits_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCreditsConsumableByMemberID", _
            oCredits.sMemberID, _
            oCredits.dCreditsConsumable)
    End Function



    Public Function InsertUpdate(ByVal oCredits As Credits_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_InsertUpdateCredits", _
                oCredits.sMemberID, _
                oCredits.dCreditsAmount, _
                oCredits.dtDateUploaded, _
                oCredits.sUploadedBy, _
                oCredits.dtDateUpdated, _
                oCredits.sUpdatedBy, _
                oCredits.dtDateAdded, _
                oCredits.sAddedBy, _
                oCredits.sIPAddress, _
                oCredits.sHostName)

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

    'Public Function DeductCreditsByMemberID(ByVal oCredits As Credits_Entity) As Integer
    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeductCreditsByMemberID", _
    '        oCredits.sMemberID, _
    '        oCredits.dMVRConsumable)
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

    Public Function GetCreditsByMemberID(ByVal oCredits As Credits_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCreditsByMemberID", _
                oCredits.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetTotalCreditsByMemberID(ByVal oCreditsLog As CreditsLog_Entity) As Double
        Dim ds As New DataSet
        Dim dt As New DataTable

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetTotalCreditsByMemberID", _
                oCreditsLog.sMemberID)

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

    Public Function GetCreditsLogSumByMemberID(ByVal oCredits As Credits_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCreditsLogSumByMemberID", _
                oCredits.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetSDCreditsByMemberID(ByVal oCredits As Credits_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetSDCreditsByMemberID", _
                oCredits.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckCredits(ByVal oCredits As Credits_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckCredits", _
                oCredits.sMemberID, _
                oCredits.dCreditsAmount, _
                oCredits.dtApplicableMonth)

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

    Public Function ResetCredits() As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetCredits")
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
