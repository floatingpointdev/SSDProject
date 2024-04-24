Public Class frmGroupManager

    Private oUserAccounts As New UserAccounts_Entity
    Private iRow As Integer

    Private Sub LoadGroupdt()
        Dim dt As DataTable
        Dim iErrorCode As Integer = 0
        dt = oSQLUserAccounts.GetGroups(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        dgvGroups.DataSource = dt

        If dgvGroups.RowCount > 0 Then
            btnEdit.Enabled = True
            btnRemoveGroup.Enabled = True
            dgvGroups.CurrentCell.Selected = False
            dgvGroups.Rows(iRow).Selected = True
            dgvGroups.CurrentCell = dgvGroups.SelectedCells(0)
        Else
            btnEdit.Enabled = False
            btnRemoveGroup.Enabled = False
        End If

    End Sub

    Private Sub btnSaveGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGroup.Click
        If tbGroup.Text = "" And tbGroup.Enabled = True Then
            oCommon.ErrorBox("Group code cannot be empty.")
            tbGroup.Focus()
        ElseIf tbGroupDesc.Text = "" Then
            oCommon.ErrorBox("Group description cannot be empty.")
            tbGroupDesc.Focus()
        ElseIf Program.oSQLUserAccounts.CheckGroup(tbGroup.Text) = True And tbGroup.Enabled = True Then
            oCommon.ErrorBox("Group already exists.")
            tbGroup.Focus()
            'ElseIf cboHR.Checked And cbRestricted.Checked Then
            '    oCommon.ErrorBox("Group cannot be restricted and HR at the same time.")
        Else
            oUserAccounts.sGroupCode = tbGroup.Text
            oUserAccounts.sGroupDesc = tbGroupDesc.Text
            'oUserAccounts.bRestricted = cbRestricted.Checked
            'oUserAccounts.bHR = cboHR.Checked
            oUserAccounts.iAccountType = GetAccountType(cboAccountType.Text)
            If tbGroup.Enabled = True Then
                If oSQLUserAccounts.AddGroup(oUserAccounts) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                oCommon.ShowBox("Add Group Done.")
            Else
                If oSQLUserAccounts.EditGroup(oUserAccounts) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                oCommon.ShowBox("Group Updated.")
            End If
            LoadGroupdt()
            SearchMode()
        End If
    End Sub

    Private Function GetAccountType(ByVal sAccountType As String) As Integer
        Select Case sAccountType
            Case "Guest" : Return 0
            Case "User" : Return 1
            Case "HR" : Return 2
            Case "Admin" : Return 3
            Case "Accounting" : Return 4
            Case "Void" : Return 255
        End Select
    End Function

    Private Sub btnRemoveGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveGroup.Click
        Dim iErrorCode As Integer = 0

        If dgvGroups.SelectedRows(0).Cells(0).Value IsNot Nothing Then
            If dgvGroups.SelectedRows(0).Cells(0).Value.ToString() = Program.sGroupCode Then
                oCommon.ShowBox("Can't delete same Group while logged-in.")
            Else
                If oCommon.QBox("Remove Groups?", "Caution") = Windows.Forms.DialogResult.Yes Then
                    If dgvGroups.SelectedRows(0).Cells(0).Value IsNot DBNull.Value Then
                        oUserAccounts.sGroupCode = dgvGroups.SelectedRows(0).Cells(0).Value
                    Else
                        oUserAccounts.sGroupCode = ""
                    End If
                    If dgvGroups.SelectedRows(0).Cells(1).Value IsNot DBNull.Value Then
                        oUserAccounts.sGroupDesc = dgvGroups.SelectedRows(0).Cells(1).Value
                    Else
                        oUserAccounts.sGroupDesc = ""
                    End If
                    If oSQLUserAccounts.DeleteGroup(oUserAccounts, iErrorCode) = 1 Then
                        If iErrorCode <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        oCommon.ErrorBox("Existing users use this group", "Cannot delete group.")
                    Else
                        If iErrorCode <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        iRow = IIf(dgvGroups.CurrentCell.RowIndex > 0, dgvGroups.CurrentCell.RowIndex - 1, 0)
                        LoadGroupdt()
                        tbGroup.Text = ""
                        tbGroupDesc.Text = ""
                        dgvGroups_SelectionChanged(sender, e)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvGroups_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvGroups.SelectionChanged
        If dgvGroups.SelectedRows.Count > 0 Then
            tbGroup.Text = dgvGroups.SelectedCells(0).Value
            tbGroupDesc.Text = dgvGroups.SelectedCells(1).Value
            'cbRestricted.Checked = dgvGroups.SelectedCells(2).Value
            'cboHR.Checked = dgvGroups.SelectedCells(3).Value
        End If
    End Sub

    Private Sub frmGroupManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmGroupManager = Nothing
    End Sub

    Private Sub frmGroupManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oCommon.SetCenterPosition(Me)

        dgvGroups.AutoGenerateColumns = False

        cboAccountType.Items.Add("Guest")
        cboAccountType.Items.Add("User")
        cboAccountType.Items.Add("HR")
        cboAccountType.Items.Add("Accounting")
        cboAccountType.Items.Add("Admin")
        cboAccountType.Items.Add("Void")

        cboAccountType.SelectedIndex = 0

        LoadGroupdt()
        SearchMode()


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        tbGroup.Text = ""
        tbGroupDesc.Text = ""
        tbGroup.Enabled = True
        iRow = dgvGroups.Rows.Count
        EditMode()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        tbGroup.Enabled = False
        iRow = dgvGroups.CurrentCell.RowIndex
        EditMode()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        dgvGroups_SelectionChanged(sender, e)
        If dgvGroups.Rows.Count > 0 Then
            btnEdit.Enabled = True
            btnRemoveGroup.Enabled = True
        Else
            btnEdit.Enabled = False
            btnRemoveGroup.Enabled = False
        End If
        SearchMode()
    End Sub

    Private Sub SearchMode()
        gbEditGroup.Enabled = False
        gbSearchGroup.Enabled = True
    End Sub

    Private Sub EditMode()
        gbEditGroup.Enabled = True
        gbSearchGroup.Enabled = False
    End Sub
End Class