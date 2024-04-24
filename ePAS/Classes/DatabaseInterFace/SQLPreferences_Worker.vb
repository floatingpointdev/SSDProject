Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLPreferences_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function GetPreferences(ByVal oPreferences As Preferences_Entity) As DataTable
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_GetPreferences")

        Catch ex As SqlException
            Return Nothing
        End Try

        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function UpdatePreferences(ByVal oPreferences As Preferences_Entity) As Integer
        Dim ds As New DataSet

        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, "spLoy_UpdatePreferences", _
                                          oPreferences.iCAMin, _
                                          oPreferences.iCAMax, _
                                          oPreferences.iSDMin, _
                                          oPreferences.iSDMax)

        Catch ex As SqlException
            Return Nothing
        End Try

        Return 0
    End Function
End Class
