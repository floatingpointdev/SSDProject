Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLRewards_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function AddRewards(ByVal oRewards As Rewards_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddRewards", _
                        oRewards.sMemberID, _
                        oRewards.iPoints, _
                        oRewards.dtValidFrom, _
                        oRewards.dtValidTo, _
                        IIf(oRewards.dtDateUploaded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oRewards.dtDateUploaded.ToString()), _
                        IIf(oRewards.dtDateUpdated.ToString() = "1/1/0001 12:00:00 AM", Nothing, oRewards.dtDateUpdated), _
                        IIf(oRewards.dtDateAdded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oRewards.dtDateAdded), _
                        oRewards.sUploadedBy, _
                        oRewards.sUpdatedBy, _
                        oRewards.sAddedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function UpdateRewards(ByVal oRewards As Rewards_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateRewards", _
                oRewards.iID, _
                oRewards.sMemberID, _
                oRewards.iPoints, _
                oRewards.iConsumablePoints, _
                oRewards.dtValidFrom, _
                oRewards.dtValidTo, _
                IIf(oRewards.dtDateUpdated.ToString() = "1/1/0001 12:00:00 AM", Nothing, oRewards.dtDateUpdated), _
                oRewards.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteRewardsByID(ByVal oRewards As Rewards_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteRewardsByID", _
                                             oRewards.iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteRewardsByMemberID(oRewards As Rewards_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteRewardsByMemberID", _
                                             oRewards.sMemberID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function CheckRewards(ByVal oRewards As Rewards_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckRewards", _
                oRewards.sMemberID, _
                oRewards.dtValidFrom, _
                oRewards.dtValidTo)

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

    Public Function GetRewardsByMemberID(ByVal oRewards As Rewards_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetRewardsByMemberID", _
                oRewards.sMemberID, Date.Now.ToShortDateString())

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function DeductRewardsByTransID(ByVal oRewards As Rewards_Entity, ByVal iDecrementBy As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeductRewardsByTransID", _
                oRewards.iID, _
                iDecrementBy)

        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function


    Public Function GetCurrentRewardsByMemberID(ByVal oRewards As Rewards_Entity) As Integer
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCurrentRewardsByMemberID", _
                oRewards.sMemberID, _
                Date.Now.ToShortDateString())

        Catch ex As SqlException
            Return ex.Number
        End Try

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return CInt(ds.Tables(0).Rows(0)("ConsumablePoints"))
            End If
        End If
    End Function

    Public Function GetRewards() As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetRewards1")

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function
End Class
