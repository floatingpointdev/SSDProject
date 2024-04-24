Public Class frmMVRCreditLogs

    Private dtTransLogs As New DataTable
    Private oSQLTransLogs As New SQLTransaction_Worker

    Private Sub frmMVRCreditLogs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmMVRCreditLogs = Nothing
    End Sub

    Private Sub frmMVRCreditLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtiFrom.Value = Date.Now
        dtiTo.Value = Date.Now

        dgTransLogs.AutoGenerateColumns = False

        LoadLogs()
    End Sub

    Private Sub LoadLogs()
        dtTransLogs = oSQLTransLogs.GetMVRCreditLogsByDateRange(dtiFrom.Value, dtiTo.Value)
        dgTransLogs.DataSource = dtTransLogs

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If ValidateParams() Then
            LoadLogs()
        End If
    End Sub

    Private Function ValidateParams() As Boolean
        If dtiFrom.Value > dtiTo.Value Then
            MsgBox("Invalid date range.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
End Class