Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLLoyalty_Worker
    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()

    Public Function AddLoyalty(ByVal oLoyalty As Loyalty_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddLoyalty ", _
                        oLoyalty.iLoyaltyMode, _
                        oLoyalty.sLoyaltyCode, _
                        oLoyalty.sLoyaltyDesc, _
                        oLoyalty.iOperation, _
                        oLoyalty.iPointsEarned, _
                        oLoyalty.iPointThreshold, _
                        oLoyalty.dAmountPurchased, _
                        oLoyalty.iRewardType, _
                        oLoyalty.dCashRewardAmt, _
                        oLoyalty.iDecrementBy, _
                        oLoyalty.bWillExpire, _
                        oLoyalty.dExpiration)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function EditLoyalty(ByVal oLoyalty As Loyalty_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateLoyalty", _
                        oLoyalty.iLoyaltyMode, _
                        oLoyalty.sLoyaltyCode, _
                        oLoyalty.sLoyaltyDesc, _
                        oLoyalty.iOperation, _
                        oLoyalty.iPointsEarned, _
                        oLoyalty.iPointThreshold, _
                        oLoyalty.dAmountPurchased, _
                        oLoyalty.iRewardType, _
                        oLoyalty.dCashRewardAmt, _
                        oLoyalty.iDecrementBy, _
                        oLoyalty.bWillExpire, _
                        oLoyalty.dExpiration)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function DeleteLoyalty(ByVal oLoyalty As Loyalty_Entity) As Integer
        Dim sqlParam(1) As SqlParameter
        sqlConn = New SqlConnection(eConn.sConnString)
        sqlParam(0) = New SqlParameter("@LoyaltyCode", oLoyalty.sLoyaltyCode)
        sqlParam(1) = New SqlParameter("@return", SqlDbType.Int)

        sqlParam(0).Direction = ParameterDirection.Input
        sqlParam(1).Direction = ParameterDirection.ReturnValue
        SqlHelper.ExecuteNonQuery(sqlConn, CommandType.StoredProcedure, "spLoy_DeleteLoyalty", _
            sqlParam)
        Return sqlParam(1).Value
    End Function

    Public Function GetLoyaltyByCode(ByVal oLoyalty As Loyalty_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetLoyaltyByCode", _
                        oLoyalty.sLoyaltyCode)
        Catch ex As SqlException
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetAllLoyalty(ByRef iErrorCode As Integer) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAllLoyalty")
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

    Public Function CheckLoyalty(ByVal oLoyalty As Loyalty_Entity) As Boolean
        Dim dt As DataTable = GetLoyaltyByCode(oLoyalty)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
