Imports System.Data.OleDb
Public Class OLEDBExcel_Worker
    Private OleDbConn As OleDbConnection

    Private Sub oleOpen(ByVal sFile As String)
        OleDbConn = New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=" & sFile & ";Extended Properties=Excel 8.0")
        OleDbConn.Open()
    End Sub

    Private Sub oleOpenV2(ByVal sFile As String)
        OleDbConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & sFile & ";Excel 12.0 Xml;HDR=YES;IMEX=1")
        OleDbConn.Open()
    End Sub

    Private Sub oleClose()
        OleDbConn.Close()
    End Sub

    Public Function GetExcelWorksheets(ByVal sFile As String) As DataTable
        oleOpen(sFile)
        Dim dt As DataTable = OleDbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        oleClose()
        Return dt
    End Function

    Public Function GetExcelWorksheetsV2(ByVal sFile As String) As DataTable
        oleOpenV2(sFile)
        Dim dt As DataTable = OleDbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        oleClose()
        Return dt
    End Function


    Public Function GetDSFromExcel(ByVal sFile As String, ByVal sWorkSheet As String) As DataSet
        Dim sCmd As OleDbCommand
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim oleDa As OleDbDataAdapter
        oleOpen(sFile)
        sCmd = New OleDbCommand("SELECT * FROM [" & sWorkSheet & "]", OleDbConn)
        oleDa = New OleDbDataAdapter(sCmd)
        oleDa.Fill(ds)
        dt.TableName = sWorkSheet.Replace("$", "")
        ds.Tables.Add(dt)
        oleClose()
        Return ds
    End Function

    Public Function GetDSFromExcelV2(ByVal sFile As String, ByVal sWorkSheet As String) As DataSet
        Dim sCmd As OleDbCommand
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim oleDa As OleDbDataAdapter
        oleOpenV2(sFile)
        sCmd = New OleDbCommand("SELECT * FROM [" & sWorkSheet & "]", OleDbConn)
        oleDa = New OleDbDataAdapter(sCmd)
        oleDa.Fill(ds)
        dt.TableName = sWorkSheet.Replace("$", "")
        ds.Tables.Add(dt)
        oleClose()
        Return ds
    End Function


    Public Function isFormatValidByFirstAndLastColumnNames(ByVal sFile As String, ByVal sWorksheet As String, _
        ByVal sFirstColumnName As String, ByVal sLastColumnName As String) As Boolean

        Dim ds As DataSet = GetDSFromExcel(sFile, sWorksheet)
        Dim dt As DataTable = ds.Tables(sWorksheet.Replace("$", ""))

        If dt.Columns.Count > 0 Then
            If dt.Columns(0).ColumnName.Trim() <> sFirstColumnName.Trim() Then
                Return False
                If dt.Columns(dt.Columns.Count - 1).ColumnName.Trim() <> sLastColumnName.Trim() Then
                    Return False
                Else
                    Return True
                End If
                Return False
            End If
        End If
    End Function

End Class
