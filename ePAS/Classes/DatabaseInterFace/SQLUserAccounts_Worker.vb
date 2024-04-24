Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLUserAccounts_Worker
    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()'REM by DPD 08.30

    Public Function AddUser(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_AddUser", _
                oUserAccounts.sUserName, _
                oUserAccounts.sPassword, _
                oUserAccounts.sGroupCode, _
                oUserAccounts.sCardID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function EditUserPassword(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_UpdateUser1", _
                oUserAccounts.sPassword, _
                oUserAccounts.sUserName, _
                oUserAccounts.sGroupCode, _
                oUserAccounts.sCardID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteUser(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_DeleteUser", _
                oUserAccounts.sUserName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function GetUserAccounts(ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetUsers")
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetUserByCard(ByVal sCardID As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetUserByCardID", sCardID)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function AssignUserGroup(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_AssignUserGroup", _
                oUserAccounts.sGroupCode, _
                oUserAccounts.sUserName)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function AddGroup(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_AddGroup", _
                oUserAccounts.sGroupCode, _
                oUserAccounts.sGroupDesc, _
                oUserAccounts.iAccountType)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
        'oUserAccounts.bRestricted, _
        'oUserAccounts.bHR)
    End Function

    Public Function EditGroup(ByVal oUserAccounts As UserAccounts_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_UpdateGroup", _
                oUserAccounts.sGroupCode, _
                oUserAccounts.sGroupDesc, _
                oUserAccounts.iAccountType)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
        'oUserAccounts.bRestricted, _
        'oUserAccounts.bHR)
    End Function

    Public Function DeleteGroup(ByVal oUserAccounts As UserAccounts_Entity, ByRef iErrorCode As Integer) As Integer
        Dim sqlParam(1) As SqlParameter
        sqlConn = New SqlConnection(eConn.sConnString)
        sqlParam(0) = New SqlParameter("@GroupCode", oUserAccounts.sGroupCode)
        sqlParam(1) = New SqlParameter("@return", SqlDbType.Int)

        sqlParam(0).Direction = ParameterDirection.Input
        sqlParam(1).Direction = ParameterDirection.ReturnValue
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, CommandType.StoredProcedure, "spPublic_DeleteGroup", _
                        sqlParam)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        Return sqlParam(1).Value
    End Function

    Public Function GetGroups(ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetGroups")
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckUser(ByVal sUserName As String, ByRef iErrorCode As Integer) As Boolean
        Dim dt As DataTable = GetUserInfo(sUserName, iErrorCode)
        If iErrorCode <> 0 Then Return False

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetUserInfo(ByVal sUserName As String, ByRef iErrorCode As Integer) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetUserInfo", sUserName)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CheckGroup(ByVal sGroupCode As String) As Boolean
        Dim iErrorCode As Integer = 0
        Dim dt As DataTable = GetGroupbyCode(sGroupCode, iErrorCode)
        If iErrorCode <> 0 Then
            Return False
        End If
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetGroupbyCode(ByVal sGroupCode As String, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetGroupByCode", sGroupCode)
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
