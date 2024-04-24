Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLReaderSetup_Worker

    Private sqlConn As SqlConnection = Nothing
    'Private eConn As New SQLConnection_Entity()'REM by DPD 08.30

    Public Function AddDevice(ByVal sReader As String, ByVal sCOMPort As String) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)

        Return SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_AddDevice", sReader, sCOMPort)
    End Function

    Public Function UpdateDevice(ByVal sReader As String, ByVal sCOMPort As String) As Integer
        sqlConn = New SqlConnection(eConn.sConnString)

        Return SqlHelper.ExecuteNonQuery(sqlConn, "spPublic_UpdateDevice", sReader, sCOMPort)
    End Function

    Public Function GetCurrentDevice() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetCurrentDevice") 'Note: an error will occur here during debugging, but not on live run.

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

    Public Function GetDevices() As DataTable
        sqlConn = New SqlConnection(eConn.sConnString)
        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataset(sqlConn, "spPublic_GetDevices")

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            End If
        End If

        Return Nothing
    End Function

End Class
