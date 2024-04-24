Public Class frmUserAccounts

    Private oUserAccounts As New UserAccounts_Entity
    Public sUserGroup As String = ""
    Public bUser As Boolean

    Public Sub UsersClearAll()
        tbUserNameAcct.Text = ""
        tbPasswordAcct.Text = ""
        tbConfirmAcct.Text = ""
        cmbGroups.Text = ""
        tbCardID.Text = ""
    End Sub

    Friend Sub LoadCmbdt()
        Dim iErrorCode As Integer = 0
        Dim dt As DataTable = oSQLUserAccounts.GetGroups(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        cmbGroups.DataSource = dt
        cmbGroups.DisplayMember = "GroupCode"
        cmbGroups.ValueMember = "GroupCode"
    End Sub

    Private Sub frmUserAccounts_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        oCommon.SetCenterPosition(Me)
        LoadCmbdt()
        'If bUser = True Then
        '    UsersNav(1, 0)
        'Else
        '    UsersNav()
        'End If
        If Program.sGroupCode <> "" Then
            cmbGroups.Text = sUserGroup
        End If
    End Sub

#Region "Keypress"

    Private Sub tbUserNameAcct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUserNameAcct.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbPasswordAcct.Focus()
        End If
    End Sub

    Private Sub tbPasswordAcct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPasswordAcct.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbConfirmAcct.Focus()
        End If
    End Sub

    Private Sub tbConfirmAcct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbConfirmAcct.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cmbGroups.Focus()
        End If
    End Sub
#End Region

    Private Sub btnSaveAcct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAcct.Click
        Dim iErrorCode As Integer = 0

        If tbUserNameAcct.Text = "" Then
            oCommon.ErrorBox("Please Input User Name")
            tbUserNameAcct.Focus()
        ElseIf tbPasswordAcct.Text = "" Then
            oCommon.ErrorBox("Please Input Password")
            tbPasswordAcct.Focus()
        ElseIf tbPasswordAcct.Text <> tbConfirmAcct.Text Then
            oCommon.ErrorBox("Password didn't match")
            tbPasswordAcct.Focus()
            tbPasswordAcct.SelectionStart = 0
            tbPasswordAcct.SelectionLength = tbPasswordAcct.TextLength
        ElseIf cmbGroups.Text = "" Then
            oCommon.ErrorBox("Groups cannot be empty")
            cmbGroups.Focus()
        ElseIf tbUserNameAcct.Enabled = False Then
            oSQLUserAccounts.EditUserPassword(oUserAccounts)
            oCommon.ShowBox("Password Changed!")
        ElseIf oSQLUserAccounts.CheckUser(tbUserNameAcct.Text, iErrorCode) = True And tbUserNameAcct.ReadOnly = False Then
            If iErrorCode <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If
            oCommon.ErrorBox("User Name Already Taken!")
            tbUserNameAcct.Focus()
        Else
            oUserAccounts.sUserName = tbUserNameAcct.Text
            oUserAccounts.sPassword = tbPasswordAcct.Text
            oUserAccounts.sGroupCode = cmbGroups.SelectedValue
            oUserAccounts.sCardID = tbCardID.Text

            If tbUserNameAcct.ReadOnly = True Then
                If oSQLUserAccounts.EditUserPassword(oUserAccounts) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                oCommon.ShowBox("User updated!")
            Else
                If oSQLUserAccounts.AddUser(oUserAccounts) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                oCommon.ShowBox("User Added!")

            End If
            bUser = False
            Me.Close()
        End If

    End Sub

    Private Sub btnCancelUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelUser.Click
        Me.Close()
    End Sub

    Private Sub frmUserAccounts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmUserAccounts = Nothing
    End Sub

    Private Sub btnCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCard.Click
        oCommon.ShowBox("Tap Card.", "")
        Select Case Program.sCurrentDevice
            'Case "ACR122U"
            '    If Program.oACR122U.CardConnect(Program.acsDevice) = 0 Then
            '        If Program.oACR122U.GetCardUID = 0 Then
            '            tbCardID.Text = Program.oACR122U.sCardUID
            '        End If
            '    End If
        End Select
    End Sub

    Private Sub frmUserAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmUserAccounts_Enter(sender, e)
    End Sub
End Class