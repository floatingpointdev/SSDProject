Public Class frmCardDeleteTool

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim oMember As New Member_Entity
        Dim oRewards As New Rewards_Entity
        Dim dtMember As New DataTable
        Dim iErrorCode As Integer = 0

        If txtCardID.Text.Trim() <> "" Then
            oMember.sCardID = txtCardID.Text

            dtMember = oSQLMember.GetMemberByCardID(oMember, iErrorCode)

            If iErrorCode Then
                'TODO: 08.09.2016
            End If

            If Not dtMember Is Nothing Then
                If dtMember.Rows.Count > 0 Then
                    oMember.sMemberID = dtMember.Rows(0)("MemberID").ToString()

                    oSQLMember.DeleteMember(oMember)

                    oRewards.sMemberID = oMember.sMemberID
                    oSQLRewards.DeleteRewardsByMemberID(oRewards)

                    lblStatus.Text = "Card Deleted."
                    Timer1.Start()
                End If
            End If
        End If
        txtCardID.Focus()
        txtCardID.Text = ""
    End Sub

    Private Sub frmCardDeleteTool_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmCardDeleteTool = Nothing
    End Sub

    Private Sub frmCardDeleteTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCardID.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        lblStatus.Text = ""
    End Sub
End Class