Public Class frmVoidCardTrans
    Private oLogs As New Transaction_Entity
    Private dtLogs As New DataTable

    Private Sub frmVoidCardTrans_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmVoidCardTrans = Nothing
    End Sub

    Private Sub frmVoidCardTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTransLogs.AutoGenerateColumns = False
        btnVoid.Enabled = False
        PopulateMemberID()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        oLogs.sMemberID = cboMemberID.Text
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        Dim iErrorCode As Integer = 0
        btnVoid.Enabled = False
        dtLogs = oSQLLogs.GetVoidableTransByMemberID(oLogs, iErrorCode)
        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If
        dgTransLogs.DataSource = dtLogs
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim oMember As New Member_Entity
        Dim iErrorCode As Integer = 0
        Dim dtMember As New DataTable

        oMember.sMemberID = cboMemberID.Text
        dtMember = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Not dtMember Is Nothing Then
            If dtMember.Rows.Count > 0 Then
                txtName.Text = dtMember.Rows(0)("FullName").ToString()
            Else
                txtName.Text = ""
            End If
        End If
        oLogs.sMemberID = cboMemberID.Text
        PopulateGrid()
    End Sub

    Private Sub cboMemberID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMemberID.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub PopulateMemberID()
        Dim dtMember As New DataTable
        Dim iErrorCode As Integer = 0

        dtMember = oSQLMember.GetAllMemberInfo(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Not dtMember Is Nothing Then
            cboMemberID.DataSource = dtMember
            cboMemberID.DisplayMember = "MemberID"
            cboMemberID.ValueMember = "MemberID"
        End If
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Program.iSuperAccountType = 0

        Do While Program.iSuperAccountType <> 255 And Program.iSuperAccountType <> 3
            If ofrmSuperLogin Is Nothing Then
                ofrmSuperLogin = New frmSuperLogin
            End If
            ofrmSuperLogin.ShowDialog()
            If ofrmSuperLogin.DialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        Loop

        If ofrmVoidCorrection Is Nothing Then
            ofrmVoidCorrection = New frmVoidCorrection
        End If
        ofrmVoidCorrection.ShowDialog()
        If ofrmVoidCorrection.DialogResult = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        oLogs.sIncidentReportNo = ofrmVoidCorrection.sIncidentReportNo
        oLogs.dAmount = ofrmVoidCorrection.dAmount

        ofrmVoidCorrection = Nothing

        For Each dgr As DataGridViewRow In dgTransLogs.Rows            
            If dgr.Cells("colCheck").Value = True Then
                oLogs.iID = dgr.Cells("colID").Value
                oLogs.sVoidedBy = Program.sSuperUserName
                oLogs.sTransMode = dgr.Cells("colTransType").Value
                If oSQLLogs.VoidTransaction(oLogs) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Exit For
            End If

        Next
        btnSearch.PerformClick()
        MsgBox("Transaction(s) successfully voided.")
    End Sub

  
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVoid.Click
        If Program.ofrmVoidedTransViewer Is Nothing Then
            Program.ofrmVoidedTransViewer = New frmVoidedTransViewer
            Program.ofrmVoidedTransViewer.oLog = oLogs
            Program.ofrmVoidedTransViewer.ShowDialog()
            Program.ofrmVoidedTransViewer = Nothing
        End If
    End Sub

    Private Sub dgTransLogs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTransLogs.CellContentClick
        dgTransLogs.CommitEdit(DataGridViewDataErrorContexts.Commit)

        If dgTransLogs.Rows.Count > 0 Then

            For Each dr As DataGridViewRow In dgTransLogs.Rows
                If dr.Cells("colCheck").Value = True Then
                    If dr.Index <> e.RowIndex Then
                        dr.Cells("colCheck").Value = False
                    End If
                End If
            Next

            dgTransLogs.CommitEdit(DataGridViewDataErrorContexts.Commit)

            For Each dr As DataGridViewRow In dgTransLogs.Rows
                If dr.Cells("colCheck").Value = True Then
                    oLogs.sTransMode = dr.Cells("colTransType").Value
                    btnVoid.Enabled = True
                    Exit Sub
                End If
            Next

            btnVoid.Enabled = False

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class