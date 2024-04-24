Public Class frmUserManager

    Private oUserAccounts As New UserAccounts_Entity

    Private Sub LoadUserdt()
        Dim iErrorCode As Integer = 0
        Dim dt As DataTable = oSQLUserAccounts.GetUserAccounts(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        dgvUsers.DataSource = dt

        If dgvUsers.Rows.Count = 0 Then
            btnChangePass.Enabled = False
            btnRemoveUser.Enabled = False
        Else
            btnChangePass.Enabled = True
            btnRemoveUser.Enabled = True
        End If
    End Sub

    Private Sub frmUserManager_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        oCommon.SetCenterPosition(Me)
        LoadUserdt()
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Program.ofrmUserAccounts = New frmUserAccounts
        With Program.ofrmUserAccounts
            .tbUserNameAcct.ReadOnly = False
            .cmbGroups.Enabled = True
            .UsersClearAll()
            .ShowDialog()
        End With
        LoadUserdt()
    End Sub

    Private Sub btnChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePass.Click
        If dgvUsers.Rows.Count > 0 Then
            If dgvUsers.SelectedRows(0).Cells(0) IsNot Nothing Then
                Program.ofrmUserAccounts = New frmUserAccounts
                'Program.ofrmUserAccounts.MdiParent = Me.MdiParent
                With Program.ofrmUserAccounts
                    .tbUserNameAcct.Text = dgvUsers.CurrentRow.Cells(0).Value.ToString()
                    .sUserGroup = dgvUsers.CurrentRow.Cells(1).Value.ToString()
                    .tbCardID.Text = dgvUsers.CurrentRow.Cells(2).Value.ToString
                    .tbUserNameAcct.ReadOnly = True
                    .cmbGroups.Enabled = True
                    .btnCard.Enabled = True
                    .ShowDialog()
                End With

                LoadUserdt()
            End If
        End If

    End Sub

    Private Sub btnRemoveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveUser.Click
        If dgvUsers.Rows.Count > 0 Then
            If dgvUsers.SelectedRows(0).Cells(0).Value IsNot Nothing Then
                If dgvUsers.CurrentRow.Cells("colUserName").Value.ToString() = Program.sUserName Then
                    oCommon.ShowBox("Can't delete user while logged-in.")
                Else
                    If oCommon.QBox("Are You Sure?", "Remove User") = Windows.Forms.DialogResult.Yes Then
                        oUserAccounts.sUserName = dgvUsers.CurrentRow.Cells("colUserName").Value
                        oSQLUserAccounts.DeleteUser(oUserAccounts)
                        LoadUserdt()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmUserManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmUserManager = Nothing
    End Sub

    Private Sub frmUserManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class