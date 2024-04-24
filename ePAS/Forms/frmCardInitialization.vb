Public Class frmCardInitialization

    Private oCard As New Card_Entity
    Private oMember As New Member_Entity
    Private bEdit As Boolean = False

    Private Sub frmCardInitialization_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        LoadCbodt()
        LoadDgv()
        If dgvCard.Rows.Count < 1 Then
            cboMemberID.SelectedIndex = -1
            cboLoyaltyCode.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmLocationSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmCardInitialization = Nothing
    End Sub

    Private Sub frmLocationSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCommon.SetCenterPosition(Me)
        dgvCard.AutoGenerateColumns = False
        Nav()
    End Sub

    Private Sub LoadCbodt()
        Dim iErrorCode As Integer = 0
        Dim dt As DataTable = oSQLMember.GetAllMemberInfo

        cboMemberID.Focus()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cboMemberID.DataSource = dt
                cboMemberID.DisplayMember = "IDFullName"
                cboMemberID.ValueMember = "MemberID"
            End If
        End If
        dt = oSQLLoyalty.GetAllLoyalty ierrorcode
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cboLoyaltyCode.DataSource = dt
                cboLoyaltyCode.DisplayMember = "LoyaltyCode"
                cboLoyaltyCode.ValueMember = "LoyaltyCode"
            End If
        End If
    End Sub

    Friend Sub LoadDgv()
        Dim dt As DataTable = oSQLCard.GetCardDetailsInfo
        dgvCard.DataSource = dt
        If dgvCard.Rows.Count > 0 Then
            btnRemove.Enabled = True
            btnEdit.Enabled = True
            dgvCard.CurrentCell.Selected = False
            dgvCard.Rows(dgvCard.Rows.Count - 1).Selected = True
            dgvCard.CurrentCell = dgvCard.SelectedCells(0)
        Else
            btnRemove.Enabled = False
            btnEdit.Enabled = False
        End If
    End Sub

    Friend Sub Clear()
        tbCardID.Text = ""
        cboMemberID.Focus()
        cboMemberID.SelectedIndex = -1
        tbPoints.Text = ""
        cboLoyaltyCode.SelectedIndex = -1
    End Sub

    Private Sub dgvCard_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCard.SelectionChanged
        If dgvCard.SelectedRows.Count > 0 And dgvCard.RowCount > 0 Then
            tbCardID.Text = dgvCard.SelectedCells(0).Value.ToString()
            cboMemberID.SelectedValue = dgvCard.SelectedCells(1).Value.ToString()
            tbPoints.Text = dgvCard.SelectedCells(2).Value.ToString()
            cboLoyaltyCode.SelectedValue = dgvCard.SelectedCells(4).Value.ToString()
        End If
    End Sub

    Friend Sub Nav(Optional ByVal bSave As Boolean = 0, Optional ByVal bEdit As Boolean = 1)
        pnlSave.Enabled = bSave
        pnlAdd.Enabled = bEdit
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        oCard.sCardID = tbCardID.Text
        If oCard.sCardID = "" Then
            oCommon.ErrorBox("Card ID cannot be empty")
        ElseIf cboLoyaltyCode.Text = "" Then    'added by DPD, 01.26.2012
            oCommon.ErrorBox("Loyalty Code cannot be empty")
        ElseIf oSQLCard.CheckCard(oCard) Then
            oCommon.ErrorBox("Card ID already initialized.")
        Else
            oCard.iPoints = Val(IIf(tbPoints.Text = "", 0, tbPoints.Text))
            oCard.sMemberID = cboMemberID.SelectedValue.ToString()
            oCard.sLoyaltyCode = cboLoyaltyCode.Text
            oMember.sMemberID = oCard.sMemberID
            oMember.sCardID = oCard.sCardID
            If bEdit = False Then
                oSQLCard.AddCardDetail(oCard)
                oCommon.ShowBox("Card initialization Done")
            Else
                oCard.iID = dgvCard.SelectedCells(5).Value
                oSQLCard.EditCardDetail(oCard)
                oCommon.ShowBox("Card Detail Updated")
            End If
            oSQLMember.AssignCardToMember(oMember)
            Nav()
            LoadDgv()
            dgvCard_SelectionChanged(sender, e)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
        Nav()
        dgvCard_SelectionChanged(sender, e)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Clear()
        bEdit = False
        cboMemberID.Enabled = True
        Nav(1, 0)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Nav(1, 0)
        bEdit = True
        cboMemberID.Enabled = False
        tbPoints.Focus()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgvCard.SelectedRows.Count > 0 Then
            If oCommon.QBox("Are You Sure?", "Remove Data") = Windows.Forms.DialogResult.Yes Then
                oCard.sCardID = dgvCard.CurrentRow.Cells(0).Value
                If oSQLCard.DeleteCardDetail(oCard) = 1 Then
                    oCommon.ErrorBox("Existing member uses this card", "Cannot delete Card.")
                End If
                Clear()
                LoadDgv()
                dgvCard_SelectionChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub btnGetCardID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCardID.Click
        tbCardID.Text = "" 'oClsCtrl.GetCardID
    End Sub

    Private Sub tbPoints_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPoints.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cboLoyaltyCode.Focus()
        End If
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        ElseIf (e.KeyChar = ".") Then
            If tbPoints.Text.Contains(".") Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub
End Class