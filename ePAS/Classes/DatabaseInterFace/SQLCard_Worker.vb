Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLCard_Worker
    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()

    Public Function AddCardDetail(ByVal oCard As Card_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddCardDetail", _
                        oCard.sCardID, _
                        oCard.sMemberID, _
                        oCard.iPoints, _
                        oCard.sLoyaltyCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function EditCardDetail(ByVal oCard As Card_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCardDetail", _
                        oCard.sCardID, _
                        oCard.sMemberID, _
                        oCard.iPoints, _
                        oCard.sLoyaltyCode, _
                        oCard.iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function EditCardDetailByMemberID(ByVal oCard As Card_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCardDetailByMemberID", _
                        oCard.sCardID, _
                        oCard.sMemberID, _
                        oCard.iPoints, _
                        oCard.sLoyaltyCode)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function UpdatePointsByCardID(ByVal oCard As Card_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdatePointsByCardID", _
                        oCard.sCardID, _
                        oCard.iPoints)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0


    End Function

    Public Function AddPointsToCard(ByVal oCard As Card_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddPointsToCard", _
                        oCard.sCardID, _
                        oCard.iPoints)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function DeleteCardDetail(ByVal oCard As Card_Entity) As Integer
        Dim sqlParam(1) As SqlParameter
        sqlConn = New SqlConnection(eConn.sConnString)
        sqlParam(0) = New SqlParameter("@CardID", oCard.sCardID)
        sqlParam(1) = New SqlParameter("@return", SqlDbType.Int)

        sqlParam(0).Direction = ParameterDirection.Input
        sqlParam(1).Direction = ParameterDirection.ReturnValue
        SqlHelper.ExecuteNonQuery(sqlConn, CommandType.StoredProcedure, "spLoy_DeleteCardDetail", _
            sqlParam)
        Return sqlParam(1).Value

    End Function

    Public Function CheckCard(ByVal oCard As Card_Entity) As Boolean
        Dim dt As DataTable = GetCardDetailsByID(oCard)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetCardDetailsByID(ByVal oCard As Card_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCardDetailByCardID", _
            oCard.sCardID)

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCardDetailsInfo() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAllCardDetails")

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

End Class
