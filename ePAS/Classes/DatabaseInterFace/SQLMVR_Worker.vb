Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLMVR_Worker

    Private sqlConn As SqlConnection = Nothing

    Public Function AddMVR(ByVal oMVR As MVR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddMVR", _
            oMVR.sMemberID, _
            oMVR.dMVRAmount, _
            oMVR.iApplicableYear, _
            IIf(oMVR.dtDateAdded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oMVR.dtDateAdded), _
            oMVR.sAddedBy, _
            oMVR.sIPAddress, _
            oMVR.sHostName)
    End Function

    Public Function UploadMVR(ByVal oMVR As MVR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UploadMVR", _
            oMVR.sMemberID, _
            oMVR.dMVRAmount, _
            oMVR.iApplicableYear, _
            IIf(oMVR.dtDateUploaded.ToString() = "1/1/0001 12:00:00 AM", Nothing, oMVR.dtDateUploaded), _
            oMVR.sUploadedBy, _
            oMVR.sIPAddress, _
            oMVR.sHostName)
    End Function

    Public Function AddUpdateMVR(ByVal oMVR As MVR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddUpdateMVR", _
            oMVR.iID, _
            oMVR.sMemberID, _
            oMVR.dMVRAmount, _
            oMVR.dMVRConsumable, _
            oMVR.iApplicableYear, _
            oMVR.sAddedBy, _
            oMVR.sIPAddress, _
            oMVR.sHostName)
    End Function

    Public Function UpdateMVRByID(ByVal oMVR As MVR_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateMVRByID", _
            oMVR.iID, _
            oMVR.dMVRAmount, _
            oMVR.dMVRConsumable, _
            oMVR.iApplicableYear, _
            oMVR.sUpdatedBy, _
            oMVR.sIPAddress, _
            oMVR.sHostName)
    End Function

    Public Function DeleteMVRByID(ByVal iID As Integer) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteMVRByID", iID)
    End Function

    Public Function GetMVR(ByVal oMVR As MVR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMVR")

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetMVRByMemberID(ByVal oMVR As MVR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMVRByMemberID", _
                oMVR.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetMVRByMemberIDByYear(ByVal oMVR As MVR_Entity, ByVal iYear As Integer) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMVRByMemberIDByYear", _
                oMVR.sMemberID, _
                iYear)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetAMAByMemberID(ByVal oMVR As MVR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAMAByMemberID", _
                oMVR.sMemberID)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function UpdateMVRConsumableByMemberID(ByVal oMVR As MVR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_UpdateMVRConsumableByMemberID", _
                oMVR.sMemberID, _
                oMVR.dMVRConsumable)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function UpdateMVRConsumableByMemberIDYear(ByVal oMVR As MVR_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_UpdateMVRConsumableByMemberIDYear", _
                oMVR.sMemberID, _
                oMVR.dMVRConsumable, _
                oMVR.iApplicableYear)

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckMVR(ByVal oMVR As MVR_Entity) As Boolean
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_CheckMVR", _
                oMVR.sMemberID, _
                oMVR.dMVRAmount, _
                oMVR.iApplicableYear)

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

    Public Function RecomputeMVR(ByVal oMVR As MVRLog_Entity) As Integer
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_RecomputeMVR", _
                oMVR.sMemberID, _
                oMVR.iRefID)

        Catch ex As SqlException
            Return Nothing
        End Try

        Return Nothing
    End Function

    Public Function ResetAMA() As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Return SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetMVR")
    End Function
End Class
