Public Class frmVoidedTransViewer

    Private dtLogs As New DataTable
    Public oLog As New Transaction_Entity

    Private Sub frmVoidedTransViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTransLogs.AutoGenerateColumns = False
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        Dim iErrorCode As Integer = 0
        dtLogs = oSQLLogs.GetVoidedTransByMemberID(oLog, iErrorCode)
        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If
        dgTransLogs.DataSource = dtLogs
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ofrmVoidedTransViewer = Nothing
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        PopulateGrid()
    End Sub
End Class