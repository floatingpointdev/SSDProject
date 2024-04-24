Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLMember_Worker
    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()

    Public Function AddMember(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddMember ", _
                       oMember.sMemberID, _
                       oMember.sCardID, _
                       oMember.sFName, _
                       oMember.sLName, _
                       oMember.sMName, _
                       oMember.sAddress, _
                       oMember.sContactNo, _
                       IIf(oMember.dBirthdate = "#12:00:00 AM#", System.DBNull.Value, oMember.dBirthdate), _
                       oMember.sEmail, _
                       IIf(oMember.dMembershipDate = "#12:00:00 AM#", System.DBNull.Value, oMember.dMembershipDate), _
                       IIf(oMember.dLExpiry = "#12:00:00 AM#", System.DBNull.Value, oMember.dLExpiry), _
                       oMember.sDepartmentCode, _
                       oMember.sGroupCode, _
                       oMember.sLoyaltyCode, _
                       oMember.bytPhoto, _
                       oMember.sCompanyCode, _
                       IIf(oMember.dDateAdded = "#12:00:00 AM#", System.DBNull.Value, oMember.dDateAdded), _
                       oMember.sAddedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function AddMemberWithBalance(ByVal oMember As Member_Entity, ByVal oAR As AR_Entity, ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AddMemberWithBalance ", _
                oMember.sMemberID, _
                oMember.sCardID, _
                oMember.sFName, _
                oMember.sLName, _
                oMember.sMName, _
                oMember.sAddress, _
                oMember.sContactNo, _
                IIf(oMember.dBirthdate = "#12:00:00 AM#", System.DBNull.Value, oMember.dBirthdate), _
                oMember.sEmail, _
                IIf(oMember.dMembershipDate = "#12:00:00 AM#", System.DBNull.Value, oMember.dMembershipDate), _
                IIf(oMember.dLExpiry = "#12:00:00 AM#", System.DBNull.Value, oMember.dLExpiry), _
                oMember.sDepartmentCode, _
                oMember.sGroupCode, _
                oMember.sLoyaltyCode, _
                oMember.bytPhoto, _
                oMember.sCompanyCode, _
                IIf(oMember.dDateAdded = "#12:00:00 AM#", System.DBNull.Value, oMember.dDateAdded), _
                oMember.sAddedBy, _
                oCA.dCAAmount, _
                oAR.dARAmount, _
                Program.sIPAddress, _
                Program.sHostName, _
                Program.sSiteName, _
                Program.sTerminalID, _
                oMember.bActive)
        Catch ex As SqlException
            Return ex.Number            
        End Try
        Return 0
    End Function


    Public Function UploadMember(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UploadMember ", _
                        oMember.sMemberID, _
                        oMember.sCardID, _
                        oMember.sFName, _
                        oMember.sLName, _
                        oMember.sMName, _
                        oMember.sAddress, _
                        oMember.sContactNo, _
                        IIf(oMember.dBirthdate = "#12:00:00 AM#", System.DBNull.Value, oMember.dBirthdate), _
                        oMember.sEmail, _
                        IIf(oMember.dMembershipDate = "#12:00:00 AM#", System.DBNull.Value, oMember.dMembershipDate), _
                        IIf(oMember.dLExpiry = "#12:00:00 AM#", System.DBNull.Value, oMember.dLExpiry), _
                        oMember.sDepartmentCode, _
                        oMember.sGroupCode, _
                        oMember.sLoyaltyCode, _
                        oMember.bytPhoto, _
                        oMember.sCompanyCode, _
                        IIf(oMember.dDateUploaded = "#12:00:00 AM#", System.DBNull.Value, oMember.dDateUploaded), _
                        oMember.sUploadedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function UploadMemberWithBalance(ByVal oMember As Member_Entity, ByVal oAR As AR_Entity, ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UploadMemberWithBalance ", _
                        oMember.sMemberID, _
                        oMember.sCardID, _
                        oMember.sFName, _
                        oMember.sLName, _
                        oMember.sMName, _
                        oMember.sAddress, _
                        oMember.sCompanyCode, _
                        oAR.dARAmount, _
                        oCA.dCAAmount, _
                        IIf(oMember.dDateUploaded = "#12:00:00 AM#", System.DBNull.Value, oMember.dDateUploaded), _
                        oMember.sUploadedBy, _
                        Program.sIPAddress, _
                        Program.sHostName, _
                        Program.sSiteName, _
                        Program.sTerminalID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function EditMember(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateMember", _
                        oMember.sMemberID, _
                        oMember.sCardID, _
                        oMember.sFName, _
                        oMember.sLName, _
                        oMember.sMName, _
                        oMember.sAddress, _
                        oMember.sContactNo, _
                        IIf(oMember.dBirthdate = "#12:00:00 AM#", Nothing, oMember.dBirthdate), _
                        oMember.sEmail, _
                        IIf(oMember.dMembershipDate = "#12:00:00 AM#", Nothing, oMember.dMembershipDate), _
                        IIf(oMember.dLExpiry = "#12:00:00 AM#", Nothing, oMember.dMembershipDate), _
                        oMember.sDepartmentCode, _
                        oMember.sGroupCode, _
                        oMember.sLoyaltyCode, _
                        oMember.bytPhoto, _
                        oMember.sCompanyCode, _
                        IIf(oMember.dDateUpdated = "#12:00:00 AM#", Nothing, oMember.dDateUpdated), _
                        oMember.sUpdatedBy)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function EditMemberWithBalance(ByVal oMember As Member_Entity, ByVal oAR As AR_Entity, ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateMemberWithBalance", _
            oMember.sMemberID, _
            oMember.sCardID, _
            oMember.sFName, _
            oMember.sLName, _
            oMember.sMName, _
            oMember.sAddress, _
            oMember.sCompanyCode, _
            oAR.dARAmount, _
            oCA.dCAAmount, _
            IIf(oMember.dDateUpdated = "#12:00:00 AM#", Nothing, oMember.dDateUpdated), _
            oMember.sUpdatedBy, _
            Program.sIPAddress, _
            Program.sHostName, _
            Program.sSiteName, _
            Program.sTerminalID, _
            oMember.bActive)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function UpdateUploadMemberWithBalance(ByVal oMember As Member_Entity, ByVal oAR As AR_Entity, ByVal oCA As CA_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_UpdateUploadMemberWithBalance", _
                        oMember.sMemberID, _
                        oMember.sCardID, _
                        oMember.sFName, _
                        oMember.sLName, _
                        oMember.sMName, _
                        oMember.sAddress, _
                        oMember.sCompanyCode, _
                        oAR.dARAmount, _
                        oCA.dCAAmount, _
                        IIf(oMember.dDateUpdated = "#12:00:00 AM#", Nothing, oMember.dDateUpdated), _
                        oMember.sUpdatedBy, _
                        Program.sIPAddress, _
                        Program.sHostName, _
                        Program.sSiteName, _
                        Program.sTerminalID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function AssignCardToMember(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_AssignCardToMember", _
                        oMember.sMemberID, _
                        oMember.sCardID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function

    Public Function DeleteMember(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteMember", _
                oMember.sMemberID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function DeleteMemberAndBalance(ByVal oMember As Member_Entity) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_DeleteMemberAndBalance", _
                oMember.sMemberID)
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0
    End Function

    Public Function CheckMember(ByVal oMember As Member_Entity, ByRef iErrorCode As Integer) As Boolean
        Dim dt As New DataTable
        Try
            dt = GetMemberByMemberID(oMember, iErrorCode)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return False
        End Try
        If iErrorCode <> 0 Then
            Return False
        End If
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetMemberByCardID(ByVal oMember As Member_Entity, ByRef iErrorCode As Integer) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMemberByCardID", _
                        oMember.sCardID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetMemberByName(ByVal sName As String) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMemberByName", _
                        sName)
        Catch ex As SqlException
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetMemberByID(ByVal oMember As Member_Entity) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMemberByID", _
            oMember.iID)

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetMemberByMemberID(ByVal oMember As Member_Entity, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMemberByMemberID", _
            oMember.sMemberID)
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetAllMemberInfo(ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAllMembers")
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


    Public Function GetMembersWithUnResetCredits(ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetMembersWithUnResetCredits")
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
    Public Function GetAllMemberInfoAndCardDetails(ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetAllMembersAndCardDetail")
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

    Public Function GenerateAutoID() As String
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GenerateAutoID")

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)("ID").ToString() 'DateTime.Now.Year.ToString() & ds.Tables(0).Rows(0)("ID").ToString().PadLeft(6, "0")
            Else
                Return DateTime.Now.Year.ToString() & "000001"
            End If
        End If

        Return Nothing
    End Function

    Public Function GetPhotoByMemberID(ByVal oMember As Member_Entity) As Byte()
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)


        If sqlConn.State = ConnectionState.Open Then sqlConn.Close()

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetPhotoByMemberID", _
                oMember.sMemberID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0)("Photo") Is System.DBNull.Value Then
                    Return Nothing
                Else
                    Return ds.Tables(0).Rows(0)("Photo")
                End If
            End If

        End If
        Return Nothing
    End Function

    Public Function IsUIDExist(ByVal sCardID As String) As Boolean
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        If sCardID Is Nothing Then
            Return False
        End If

        If sCardID.ToString() = "" Then Return False

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_IsUIDExist", sCardID)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function IsUIDFree(ByVal sCardID As String, ByVal sMemberID As String) As Boolean
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        If sCardID Is Nothing Then Return False
        If sCardID.ToString() = "" Then Return True

        ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_IsUIDFree", sCardID, sMemberID)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return False
            End If
        End If

        Return True
    End Function

    Public Function GetDistinctSites(ByRef iErrorCode As Integer) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetDistinctSites")
        Catch ex As SqlException
            iErrorCode = ex.Number
            Return Nothing
        End Try


        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function GetDistinctCompanyCode(ByRef iErrorCode As Integer) As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As New DataSet

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetDistinctCompanyCode")
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
