Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLCA_Worker

    Private sqlConn As SqlConnection = Nothing

    Public Function AddCA(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddCA", _
                        oCA.sMemberID, _
                        oCA.dCAAmount, _
                        oCA.iApplicableYear, _
                        IIf(oCA.dtDateAdded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oCA.dtDateAdded), _
                        oCA.sAddedBy, _
                        oCA.sIPAddress, _
                        oCA.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function UploadCA(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UploadCA", _
                        oCA.sMemberID, _
                        oCA.dCAAmount, _
                        oCA.iApplicableYear, _
                        IIf(oCA.dtDateUploaded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oCA.dtDateUploaded), _
                        oCA.sUploadedBy, _
                        oCA.sIPAddress, _
                        oCA.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function AddUpdateCA(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddUpdateCA", _
                        oCA.iID, _
                        oCA.sMemberID, _
                        oCA.dCAAmount, _
                        oCA.dCAConsumable, _
                        oCA.iApplicableYear, _
                        oCA.sAddedBy, _
                        oCA.sIPAddress, _
                        oCA.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function UpdateCAByID(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCAByID", _
                        oCA.iID, _
                        oCA.dCAAmount, _
                        oCA.dCAConsumable, _
                        oCA.iApplicableYear, _
                        oCA.sUpdatedBy, _
                        oCA.sIPAddress, _
                        oCA.sHostName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function DeleteCAByID(ByVal iID As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteCAByID", iID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function GetCA(ByVal oCA As CA_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCA")

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    'Public Function GetCAByMemberID(ByVal oCA As CA_Entity) As DataTable
    '    Dim ds As New DataSet

    '    sqlConn = New SqlConnection(eConn.sConnString)
    '    Try
    '        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCAByMemberID", _
    '            oCA.sMemberID)

    '    Catch ex As SqlException
    '        Return Nothing
    '    End Try

    '    If ds.Tables.Count > 0 Then
    '        Return ds.Tables(0)
    '    End If
    '    Return Nothing
    'End Function

    Public Function GetCAByMemberIDByYear(ByVal oCA As CA_Entity, ByVal iYear As Integer) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCAByMemberIDByYear", _
                oCA.sMemberID, _
                iYear)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetCAByMemberID(ByVal oCA As CA_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        iErrorCode = 0
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetCAByMemberID", _
                oCA.sMemberID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function UpdateCAByMemberID(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCAByMemberID", _
                        oCA.sMemberID, _
                        oCA.dCAAmount, _
                        oCA.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateCAConsumableByMemberID(ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateCAConsumableByMemberID", _
                oCA.sMemberID, _
                oCA.dCAConsumable, _
                oCA.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateCAConsumableByMemberIDYear(ByVal oCA As CA_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_UpdateCAConsumableByMemberIDYear", _
                oCA.sMemberID, _
                oCA.dCAConsumable, _
                oCA.iApplicableYear)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckCA(ByVal oCA As CA_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckCA", _
                oCA.sMemberID, _
                oCA.dCAAmount, _
                oCA.iApplicableYear)

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

    Public Function RecomputeCA(ByVal oCA As CALog_Entity) As Integer
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_RecomputeCA", _
                oCA.sMemberID, _
                oCA.iRefID)

        Catch ex As SqlException
            Return ex.Number
        End Try

        Return 0
    End Function

    Public Function ResetCA(ByVal oResetLog As ResetLog_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetCA", _
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


    Public Function ResetCAByMemberID(ByVal sMemberID As String) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetCAByMemberID", _
                                      sMemberID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function
End Class
