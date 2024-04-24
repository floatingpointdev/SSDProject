Public Class frmManualReset
    Private iSearchIndex As Integer = 0

    Private Sub frmManualReset_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmManualReset = Nothing
    End Sub

    Private Sub frmManualReset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvMember.AutoGenerateColumns = False

        LoadMembersWithUnResetCredits()
    End Sub

    Private Sub LoadMembersWithUnResetCredits()
        Dim iErrorCode As Integer = 0

        Dim dt As New DataTable

        dt = oSQLMember.GetMembersWithUnResetCredits(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        With dgvMember
            .DataSource = dt
        End With

        If Not dt Is Nothing Then
            If dt.Rows.Count = 0 Then
                btnReset.Enabled = False
            End If
        Else
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        For Each dr As DataGridViewRow In dgvMember.Rows
            dr.Cells("colSelect").Value = chkAll.Checked
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearchKey.Text.Trim() <> "" Then
            If cboSearchBy.Text = "Employee ID" Then
                For Each dgr As DataGridViewRow In dgvMember.Rows
                    If dgr.Cells("colMemberID").Value = txtSearchKey.Text.Trim() Then
                        dgvMember.CurrentCell = dgr.Cells("colMemberID")
                        Exit Sub
                    End If
                Next
                MsgBox("Search reached the end of records.", MsgBoxStyle.Information)
            ElseIf cboSearchBy.Text = "FullName" Then
                Dim iCount As Integer = 0
                For Each dgr As DataGridViewRow In dgvMember.Rows
                    If dgr.Cells("colFullName").Value.ToString().ToLower().Contains(txtSearchKey.Text.Trim().ToLower()) Then
                        If iCount > iSearchIndex Then
                            dgvMember.CurrentCell = dgr.Cells("colFullName")
                            iSearchIndex = iCount
                            Exit Sub
                        End If
                    End If
                    iCount += 1
                Next
                If iCount = dgvMember.Rows.Count Then
                    iSearchIndex = 0
                    MsgBox("Search reached the end of records.", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MsgBox("Are you sure you want to reset the credits?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            btnReset.Enabled = False
            For Each dr As DataGridViewRow In dgvMember.Rows
                If dr.Cells("colSelect").Value Then
                    If dr.Cells("colCreditType").Value = "CA" Then
                        If oSQLCA.ResetCAByMemberID(dr.Cells("colMemberID").Value) <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            btnReset.Enabled = True
                            Exit Sub
                        End If
                    End If

                    If dr.Cells("colCreditType").Value = "AR" Then
                        If oSQLAR.ResetARByMemberID(dr.Cells("colMemberID").Value) <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            btnReset.Enabled = True
                            Exit Sub
                        End If
                    End If
                End If
            Next

            LoadMembersWithUnResetCredits()
            btnReset.Enabled = True
        End If
    End Sub
End Class