Public Class frmInputBox

    Private oSQLUserAccounts As New SQLUserAccounts_Worker
    Private oUserAccounts As New UserAccounts_Entity

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim dt As DataTable
        Dim iErrorCode As Integer = 0

        dt = oSQLUserAccounts.GetUserInfo(Program.sUserName, iErrorCode)

        'TODO: Do something here when server is offline

        If tbInput.Text <> dt.Rows(0).Item("Password") Then
            oCommon.ErrorBox("Password Invalid")
            tbInput.Focus()
            tbInput.SelectionStart = 0
            tbInput.SelectionLength = tbInput.TextLength
        Else
            tbInput.Text = ""
            Me.Close()

            Program.ofrmUserAccounts = New frmUserAccounts
            'Program.ofrmUserAccounts.MdiParent = Me.MdiParent

            With Program.ofrmUserAccounts
                .tbUserNameAcct.Text = Program.sUserName 'frmMdiParent.lblUser.Text
                .tbPasswordAcct.Focus()
                .sUserGroup = Program.sGroupCode 'frmMdiParent.lblGroup.Text
                .tbUserNameAcct.ReadOnly = True
                .tbCardID.Text = dt.Rows(0)("CardID")
                .btnCard.Enabled = False
                .cmbGroups.Enabled = False
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub tbInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbInput.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmInputBox_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Program.ofrmInputBox = Nothing
    End Sub
End Class