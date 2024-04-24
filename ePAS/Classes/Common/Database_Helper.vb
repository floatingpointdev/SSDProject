Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class Database_Helper
    Private sqlConn As SqlConnection = Nothing

    Public Function GetTableFields(ByVal sTableName As String, ByRef iErrorCode As Integer) As DataTable
        Dim ds As New DataSet
        sqlConn = New SqlConnection(eConn.sConnString)

        Try
            ds = SqlHelper.ExecuteDataset(sqlConn, CommandType.Text, "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" & sTableName & "')")
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
