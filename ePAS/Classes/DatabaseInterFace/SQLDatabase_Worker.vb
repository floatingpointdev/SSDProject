Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLDatabase_Worker
    Private sqlConn As SqlConnection = Nothing

    Public Function ResetData() As Integer
        sqlConn = New SqlConnection(eConn.sConnString)
        Try
            SqlHelper.ExecuteNonQuery(sqlConn, "spLoy_ResetData")
        Catch ex As SqlException
            Return ex.Number
        End Try
        Return 0

    End Function
End Class
