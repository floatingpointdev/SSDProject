Public Class frmResetCalendar
    Private dtResetCalendar1 As New DataTable
    Private dtResetCalendar2 As New DataTable
    Private dtAR As New DataTable
    Private dtCA As New DataTable
    Private oSQLResetCalendar As New SQLResetCalendar_Worker
    Private oResetCalendar As New ResetCalendar_Entity
    Private dvResetCalendar1 As New DataView
    Private dvResetCalendar2 As New DataView

    Private Sub frmResetCalendar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmResetCalendar = Nothing
    End Sub

    Private Sub frmResetCalendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iErrorCode As Integer = 0

        dgCACalendar.AutoGenerateColumns = False
        dgARCalendar.AutoGenerateColumns = False

        'Get all calendars
        dtResetCalendar1 = oSQLResetCalendar.GetResetCalendar(oResetCalendar, iErrorCode)
        dtResetCalendar2 = oSQLResetCalendar.GetResetCalendar(oResetCalendar, iErrorCode)
        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Get table for CA

        dvResetCalendar1 = dtResetCalendar1.DefaultView
        dvResetCalendar1.RowFilter = "Type = 'CA'"
        dtCA = dvResetCalendar1.ToTable()
        dtCA.AcceptChanges()
        dgCACalendar.DataSource = dtCA


        'Get table for AR
        dvResetCalendar2 = dtResetCalendar2.DefaultView
        dvResetCalendar2.RowFilter = "Type = 'AR'"
        dtAR = dvResetCalendar2.ToTable()
        dtAR.AcceptChanges()

        dgARCalendar.DataSource = dtAR

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dtModified As New DataTable
        Dim iIndex As Integer = 0
        Dim bHasChanges As Boolean = False
        Dim iErrorCode As Integer = 0

        dtModified = dgCACalendar.DataSource
        dtModified = dtModified.GetChanges()

        If Not dtModified Is Nothing Then
            For Each dr As DataRow In dtModified.Rows                
                If dr.RowState = DataRowState.Added Then
                    oResetCalendar.dDate = dr("Date")
                    oResetCalendar.sType = "CA"
                    oResetCalendar.sAddedBy = Program.sUserName
                    oResetCalendar.sIPAddress = Program.sIPAddress
                    oResetCalendar.sHostName = Program.sHostName
                    oResetCalendar.sTerminalID = Program.sTerminalID
                    oResetCalendar.sSite = Program.sSiteName

                    If oSQLResetCalendar.AddResetCalendar(oResetCalendar) <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                ElseIf dr.RowState = DataRowState.Deleted Then
                    If iIndex < dtModified.Rows.Count Then
                        oResetCalendar.iID = dtModified.Rows(iIndex)(0, DataRowVersion.Original)
                        oSQLResetCalendar.DeleteResetCalendar(oResetCalendar)
                    End If

                ElseIf dr.RowState = DataRowState.Modified Then
                    oResetCalendar.iID = dr("ID")
                    oResetCalendar.dDate = dr("Date")
                    oResetCalendar.sType = "CA"
                    oResetCalendar.sUpdatedBy = Program.sUserName
                    oResetCalendar.sIPAddress = Program.sIPAddress
                    oResetCalendar.sHostName = Program.sHostName
                    oResetCalendar.sTerminalID = Program.sTerminalID
                    oResetCalendar.sSite = Program.sSiteName

                    If oSQLResetCalendar.UpdateResetCalendar(oResetCalendar) <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
                iIndex += 1
            Next
            bHasChanges = True
        End If

        dtModified = dgARCalendar.DataSource
        dtModified = dtModified.GetChanges()

        If Not dtModified Is Nothing Then
            For Each dr As DataRow In dtModified.Rows
                If dr.RowState = DataRowState.Added Then
                    oResetCalendar.dDate = dr("Date")
                    oResetCalendar.sType = "AR"
                    oResetCalendar.sAddedBy = Program.sUserName
                    oResetCalendar.sIPAddress = Program.sIPAddress
                    oResetCalendar.sHostName = Program.sHostName
                    oResetCalendar.sTerminalID = Program.sTerminalID
                    oResetCalendar.sSite = Program.sSiteName

                    If oSQLResetCalendar.AddResetCalendar(oResetCalendar) <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                ElseIf dr.RowState = DataRowState.Deleted Then
                    If iIndex < dtModified.Rows.Count Then
                        oResetCalendar.iID = dtModified.Rows(iIndex)(0, DataRowVersion.Original)

                        If oSQLResetCalendar.DeleteResetCalendar(oResetCalendar) <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End If
                ElseIf dr.RowState = DataRowState.Modified Then
                    oResetCalendar.iID = dr("ID")
                    oResetCalendar.dDate = dr("Date")
                    oResetCalendar.sType = "AR"
                    oResetCalendar.sUpdatedBy = Program.sUserName
                    oResetCalendar.sIPAddress = Program.sIPAddress
                    oResetCalendar.sHostName = Program.sHostName
                    oResetCalendar.sTerminalID = Program.sTerminalID
                    oResetCalendar.sSite = Program.sSiteName

                    If oSQLResetCalendar.UpdateResetCalendar(oResetCalendar) <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            Next
            bHasChanges = True
        End If

        If bHasChanges Then
            frmResetCalendar_Load(sender, e)
            MsgBox("Calendar successfully saved.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()         
    End Sub

    'Private Sub dgCACalendar_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCACalendar.DataError

    'End Sub
End Class