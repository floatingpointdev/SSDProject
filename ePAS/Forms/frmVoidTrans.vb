Public Class frmVoidTrans

    Private Sub frmVoidTrans_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmVoidTrans = Nothing
    End Sub

    Private Sub frmVoidTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTransLogs.AutoGenerateColumns = False
        PopulateMemberID()
        PopulateSite()
        PopulateConcessionaire()

        cboMemberID.Text = ""
        cboSite.Text = ""
        cboConcessionaire.Text = ""
    End Sub

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        Dim dtLogs As New DataTable
        Dim oLog As New Transaction_Entity
        Dim sWherePart As String = ""

        If cboMemberID.Text <> "" Then
            sWherePart += "A.MemberID LIKE '%" & cboMemberID.Text & "%'"
        End If
        If cboSite.Text <> "" Then
            If sWherePart <> "" Then sWherePart += " AND "
            sWherePart += "A.[Site] LIKE '%" & cboSite.Text & "%'"
        End If
        If cboConcessionaire.Text <> "" Then
            If sWherePart <> "" Then sWherePart += " AND "
            sWherePart += "A.Concessionaire LIKE '%" & cboConcessionaire.Text & "%'"
        End If

        If dtiFrom.Value > DateTime.MinValue Then
            If dtiTo.Value > DateTime.MinValue Then
                If dtiFrom.Value <= dtiTo.Value Then
                    If sWherePart <> "" Then sWherePart += " AND "
                    sWherePart += "TransDate between '" & dtiFrom.Value.ToShortDateString() & "' AND '" & dtiTo.Value.ToShortDateString & " 11:59 PM'"
                Else
                    MsgBox("Invalid date range.", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        End If

        dtLogs = oSQLLogs.GetLogsBySearch(sWherePart)

        dgTransLogs.DataSource = dtLogs
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Dim dtLogs As New DataTable
        Dim drVoid As DataRow()
        Dim iCount As Integer = 0

        btnVoid.Enabled = False

        dtLogs = dgTransLogs.DataSource

        If dtLogs Is Nothing Then
            btnVoid.Enabled = True
            Exit Sub

        End If


        drVoid = dtLogs.Select("colCheck=True")

        For Each dr As DataRow In drVoid
            If dr("Points") > 0 Then
                iCount += 1
                oSQLLogs.VoidTransaction(dr.Item("ID"), Program.sUserName)
            End If

        Next

        btnList.PerformClick()

        MsgBox(iCount.ToString() & " transaction(s) voided.", MsgBoxStyle.Information)

        btnVoid.Enabled = True

    End Sub

    Private Sub PopulateMemberID()
        Dim dtMember As New DataTable
        dtMember = oSQLMember.GetAllMemberInfo()

        If Not dtMember Is Nothing Then
            cboMemberID.DataSource = dtMember
            cboMemberID.DisplayMember = "MemberID"
            cboMemberID.ValueMember = "MemberID"
        End If
    End Sub

    Private Sub PopulateSite()
        Dim dtSites As New DataTable
        dtSites = oSQLLogs.GetDistinctSitesFromLogs()

        If Not dtSites Is Nothing Then
            cboSite.DataSource = dtSites
            cboSite.DisplayMember = "Site"
            cboSite.ValueMember = "Site"
        End If
    End Sub

    Private Sub PopulateConcessionaire()
        Dim dtConcessionaires As New DataTable
        dtConcessionaires = oSQLLogs.GetDistinctConcessionairesFromLogs()

        If Not dtConcessionaires Is Nothing Then
            cboConcessionaire.DataSource = dtConcessionaires
            cboConcessionaire.DisplayMember = "Concessionaire"
            cboConcessionaire.ValueMember = "Concessionaire"
        End If
    End Sub

End Class