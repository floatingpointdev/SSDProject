Public Class frmReportManager
    Private _sReport As String

    Public Property sReport() As String
        Get
            Return _sReport
        End Get
        Set(ByVal value As String)
            _sReport = value
        End Set
    End Property

    Private Sub frmReportManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iErrorCode As Integer = 0

        dtFrom.Value = Now
        dtTo.Value = Now

        dgvSites.AutoGenerateColumns = False
        dgvMembers.AutoGenerateColumns = False

        Select Case sReport
            Case "OutstandingSD", "EmployeeMasterFile"
                grpDateRange.Enabled = False
            Case "TerminalEOD"
                grpSites.Enabled = False
                grpMembers.Enabled = False
            Case "ConsolidatedReport"
                grpSites.Enabled = False
                grpMembers.Enabled = False
            Case "MemberCardHistory"
                grpSites.Enabled = False
                grpMembers.Enabled = False
                grpDateRange.Enabled = False
            Case "ReIssuedCards", "CreditAdjustments"
                grpSites.Enabled = False
                grpMembers.Enabled = False
                grpDateRange.Enabled = False
        End Select

        'PopulateSites(iErrorCode)
        PopulateCompanyCode(iErrorCode)
        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If
        PopulateMembers()

        chkSites.Checked = True
        chkMembers.Checked = True
    End Sub

    Private Sub PopulateSites(ByRef iErrorCode As Integer)
        Dim dt As New DataTable

        dt = oSQLMember.GetDistinctSites(iErrorCode)

        If Not dt Is Nothing Then
            dt.Columns.Add("Check")
            dgvSites.DataSource = dt
        End If
    End Sub

    Private Sub PopulateCompanyCode(ByRef iErrorCode As Integer)
        Dim dt As New DataTable

        dt = oSQLMember.GetDistinctCompanyCode(iErrorCode)

        If Not dt Is Nothing Then
            dt.Columns.Add("Check")
            dgvSites.DataSource = dt
        End If
    End Sub

    Private Sub PopulateMembers()
        Dim dt As New DataTable
        Dim iErrorCode As Integer = 0

        dt = oSQLMember.GetAllMemberInfo(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Not dt Is Nothing Then
            dt.Columns.Add("Check")
            dgvMembers.DataSource = dt
        End If

    End Sub



    Private Sub dgvSites_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSites.CellContentClick
        'Dim sSites As String = ""

        dgvSites.Enabled = False

        sSites = ""

        dgvSites.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For Each dr As DataGridViewRow In dgvSites.Rows
            If dr.Cells(0).Value.ToString() = "True" Then
                sSites += dr.Cells(1).Value & ","
            End If
        Next

        If sSites.Length > 0 Then
            sSites = sSites.Substring(0, sSites.Length - 1)
        End If


        'Filter dgvMembers list
        Dim dt As New DataTable
        Dim dv As New DataView
        dt = dgvMembers.DataSource
        If Not dt Is Nothing Then
            dv = dt.DefaultView

            dv.RowFilter = "CompanyCode in  ('" & sSites.Replace(",", "','") & "')"
        End If
        dgvSites.Enabled = True
    End Sub

    Private Sub dgvMembers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick
        'Dim sMembers As String = ""

        dgvMembers.Enabled = False

        sMembers = ""

        dgvMembers.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For Each dr As DataGridViewRow In dgvMembers.Rows
            If dr.Cells(0).Value.ToString() = "True" Then
                sMembers += dr.Cells(1).Value & ","
            End If
        Next

        If sMembers.Length > 0 Then
            sMembers = sMembers.Substring(0, sMembers.Length - 1)
        End If


        dgvMembers.Enabled = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cboSearchBy.Text = "EmployeeID" Then
            For Each dr As DataGridViewRow In dgvMembers.Rows
                If dr.Cells("colMemberID").Value.ToString() = txtSearchKey.Text.Trim() Then
                    dgvMembers.CurrentCell = dr.Cells("colMemberID")
                End If
            Next
        End If

        If cboSearchBy.Text = "FullName" Then
            For Each dr As DataGridViewRow In dgvMembers.Rows
                If dr.Cells("colFullName").Value.ToString() = txtSearchKey.Text.Trim() Then
                    dgvMembers.CurrentCell = dr.Cells("colMemberID")
                End If
            Next
        End If
    End Sub

    Private Sub txtSearchKey_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchKey.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If (DateTime.Compare(dtTo.Value, dtFrom.Value) < 0) Then
            oCommon.ErrorBox("Date to cannot be less than date from.")
            Exit Sub
        End If

        'Program.dRangeFrom = dtFrom.Value
        'Program.dRangeTo = dtTo.Value

        ofrmReportViewer = New frmReportViewer
        ofrmReportViewer.sReport = sReport
        ofrmReportViewer.dDateFrom = dtFrom.Value
        ofrmReportViewer.dDateTo = dtTo.Value
        ofrmReportViewer.sSites = Program.sSites
        ofrmReportViewer.sMembers = Program.sMembers
        ofrmReportViewer.Show()

        'Me.DialogResult = Windows.Forms.DialogResult.OK

        'Me.Close()
    End Sub

    Private Sub chkSites_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSites.CheckedChanged
        chkSites.Enabled = False
        For Each dr As DataGridViewRow In dgvSites.Rows
            dr.Cells("colCheckSite").Value = chkSites.Checked
        Next
        dgvSites.CommitEdit(DataGridViewDataErrorContexts.Commit)

        'Force a CellContentClick event
        dgvSites_CellContentClick(sender, Nothing)

        chkSites.Enabled = True
    End Sub

    Private Sub chkMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMembers.CheckedChanged
        chkMembers.Enabled = False
        For Each dr As DataGridViewRow In dgvMembers.Rows
            dr.Cells("colCheckMember").Value = chkMembers.Checked
        Next
        dgvMembers.CommitEdit(DataGridViewDataErrorContexts.Commit)

        'Force a CellContentClick event
        dgvMembers_CellContentClick(sender, Nothing)

        chkMembers.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class