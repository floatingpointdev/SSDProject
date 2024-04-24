Public Class frmLoyalty

    Private oItems As New Loyalty_Entity
    Private oLoyalty As New Loyalty_Entity
    Private bIsNew As Boolean = False

    Private Sub frmLoyalty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tabLoyaltyTypes.SelectedTab = tbiPointSystem
        dg.AutoGenerateColumns = False

        pnlSave.Enabled = False

        LoadDgv()

    End Sub


    Private Sub LoadDgv()
        Dim dt As DataTable = oSQLLoyalty.GetAllLoyalty
        dg.DataSource = dt
        If dg.Rows.Count > 0 Then
            btnRemove.Enabled = True
            btnEdit.Enabled = True
            dg.CurrentCell.Selected = False
            dg.Rows(dg.Rows.Count - 1).Selected = True

            dg.CurrentCell = dg.SelectedCells(1)
        Else
            btnRemove.Enabled = False
            btnEdit.Enabled = False
        End If
    End Sub

    
    Private Sub frmLoyalty_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Program.ofrmLoyalty = Nothing
    End Sub

    Private Sub rbIncremental_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIncremental.CheckedChanged
        grpIncremental.Visible = rbIncremental.Checked
        grpIncremental.Enabled = rbIncremental.Checked
        grpDecremental.Visible = Not rbIncremental.Checked
        grpDecremental.Enabled = Not rbIncremental.Checked
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        bIsNew = True
        pnlSave.Enabled = True
        pnlAdd.Enabled = False

        btnClear.PerformClick()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        bIsNew = False
        pnlSave.Enabled = True
        pnlAdd.Enabled = False
        txtLoyaltyCode.ReadOnly = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        pnlSave.Enabled = False
        pnlAdd.Enabled = True
    End Sub

    Private Sub chkExpires_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExpires.CheckedChanged
        dtExpiration.Enabled = chkExpires.Checked
    End Sub

    Private Sub rbCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCash.CheckedChanged
        numCashAmount.Enabled = rbCash.Checked
        btnGiftTable.Enabled = Not rbCash.Checked
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If bIsNew Then txtLoyaltyCode.Clear()
        txtDesc.Clear()
        rbIncremental.Checked = True

        numAmount.Value = 0
        numPointsEarned.Value = 0
        numPointThreshold.Value = 0
        rbCash.Checked = True
        numCashAmount.Value = 0

        numDecrementBy.Value = 0
        chkExpires.Checked = False
        dtExpiration.Value = Date.Now

        txtLoyaltyCode.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtLoyaltyCode.Text.Trim() = "" Then
            MsgBox("Please specify a code for this loyalty scheme.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        With oLoyalty
            .sLoyaltyCode = txtLoyaltyCode.Text.Trim()
            .sLoyaltyDesc = txtDesc.Text.Trim()
            If tabLoyaltyTypes.SelectedTab Is tbiPointSystem Then
                .iLoyaltyMode = 0 'Point System
            End If
            If tabLoyaltyTypes.SelectedTab Is tbiBracketing Then
                .iLoyaltyMode = 1 'Bracketing 
            End If
            If rbIncremental.Checked Then
                .iOperation = 0
            Else
                .iOperation = 1
            End If
            .dAmountPurchased = numAmount.Value
            .iPointsEarned = numPointsEarned.Value
            .iPointThreshold = numPointThreshold.Value
            If rbCash.Checked Then
                .iRewardType = 0 'Cash
            Else
                .iRewardType = 1 'Gift
            End If
            .dCashRewardAmt = numCashAmount.Value
            .iDecrementBy = numDecrementBy.Value
            .bWillExpire = chkExpires.Checked
            .dExpiration = dtExpiration.Value.ToShortDateString()

        End With

        If Not oSQLLoyalty.CheckLoyalty(oLoyalty) Then
            'If bIsNew Then
            oSQLLoyalty.AddLoyalty(oLoyalty)
            'Else
            '    oSQLLoyalty.EditLoyalty(oLoyalty)
            'End If
        Else
            oSQLLoyalty.EditLoyalty(oLoyalty)
        End If

        btnClear.PerformClick()
        LoadDgv()
        btnCancel.PerformClick()
        MsgBox("Successfully saved.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            oLoyalty.sLoyaltyCode = txtLoyaltyCode.Text.ToString()
            oSQLLoyalty.DeleteLoyalty(oLoyalty)
            btnClear.PerformClick()
            LoadDgv()
        End If
    End Sub

    Private Sub dg_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg.SelectionChanged
        Dim dt As DataTable = dg.DataSource

        Dim dr As DataRow = dt.Rows(dg.CurrentRow.Index)

        If dr("LoyaltyMode") = 0 Then
            tabLoyaltyTypes.SelectedTab = tbiPointSystem
        Else
            tabLoyaltyTypes.SelectedTab = tbiBracketing
        End If
        txtLoyaltyCode.Text = dr("LoyaltyCode").ToString()
        txtDesc.Text = dr("LoyaltyDesc").ToString()
        If IIf(dr("Operation") Is System.DBNull.Value, 0, dr("Operation")) = 0 Then
            rbIncremental.Checked = True
            numAmount.Value = dr("AmountPurchased")
            numPointsEarned.Value = dr("PointsEarned")
            numPointThreshold.Value = dr("PointThreshold")
            If dr("RewardType") = 0 Then
                rbCash.Checked = True
            Else
                rbGift.Checked = True
            End If
        Else
            rbDecremental.Checked = True
            numDecrementBy.Value = dr("DecrementBy")
            If dr("WillExpire") Then
                chkExpires.Checked = True
                dtExpiration.Value = dr("ExpirationDate")
            End If
        End If


    End Sub


End Class