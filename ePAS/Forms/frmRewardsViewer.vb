Public Class frmRewardsViewer
    Private dtRewards As New DataTable
    Private bIsNew As Boolean

    Private Sub frmRewardsViewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmRewardsViewer = Nothing
    End Sub

    Private Sub frmRewardsViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Program.bViewOnly Then            
            grpMaintenance.Enabled = False
            grpMaintenance.Visible = False
            dgRewards.Height = 539
        Else
            Me.Text = "Points/Rewards Maintenance"
            grpMaintenance.Enabled = True
            grpMaintenance.Visible = True
            dgRewards.Height = 485
        End If

        dgRewards.AutoGenerateColumns = False
        LoadRewards()

        dgRewards.ReadOnly = True
        btnSave.Enabled = False
        If dgRewards.Rows.Count > 0 Then
            btnEdit.Enabled = True
            btnRemove.Enabled = True
        Else
            btnEdit.Enabled = False
            btnRemove.Enabled = False
        End If
        btnCancel.Enabled = False

        ClearSearchParams()

        bIsNew = False
    End Sub

    Private Sub LoadRewards()
        dtRewards = oSQLRewards.GetRewards()
        dgRewards.DataSource = dtRewards
        If dgRewards.Rows.Count > 0 Then
            dgRewards.CurrentCell.Selected = False
            dgRewards.Rows(dgRewards.Rows.Count - 1).Selected = True
            dgRewards.CurrentCell = dgRewards.SelectedCells(1)
        End If
    End Sub

    Private Sub ClearSearchParams()
        tbSearch.Clear()
        cboSearchBy.SelectedIndex = -1
        btnFilter.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        LoadRewards()
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Dim dvRewards As New DataView

        Select Case cboSearchBy.Text
            Case "CIM Number"
                dvRewards = New DataView(dtRewards, "MemberID like '%" + tbSearch.Text + "%'", "", DataViewRowState.CurrentRows)
            Case "Name"
                dvRewards = New DataView(dtRewards, "FullName like  '%" + tbSearch.Text + "%'", "", DataViewRowState.CurrentRows)
            Case "Consumable Points"
                dvRewards = New DataView(dtRewards, "ConsumablePoints =  " + tbSearch.Text, "", DataViewRowState.CurrentRows)
            Case "Site"
                dvRewards = New DataView(dtRewards, "Address like  '%" + tbSearch.Text + "%'", "", DataViewRowState.CurrentRows)
        End Select

        dgRewards.DataSource = dvRewards


    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged
        If cboSearchBy.SelectedIndex < 0 Then
            btnFilter.Enabled = False
        Else
            btnFilter.Enabled = True
        End If
    End Sub

    Private Sub dgRewards_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRewards.CellContentClick

    End Sub

    Private Sub dgRewards_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgRewards.KeyUp
        Dim oRewards As New Rewards_Entity
        Dim iCount As Integer = 0

        If e.KeyData = Keys.Delete Then
            If MsgBox("Delete the selected item(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                iCount = dgRewards.SelectedRows.Count
                For Each dr As DataGridViewRow In dgRewards.SelectedRows
                    oRewards.iID = dr.Cells("colID").Value
                    oSQLRewards.DeleteRewardsByID(oRewards)
                Next
                btnFilter.PerformClick()
                MsgBox(iCount.ToString() & " item(s) deleted.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        bIsNew = True
        grpFilter.Enabled = False
        dgRewards.ReadOnly = False
        dgRewards.AllowUserToAddRows = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnCancel.Enabled = True

        dgRewards.MultiSelect = False
        dgRewards.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgRewards.CurrentCell = dgRewards.Rows(dgRewards.NewRowIndex).Cells(1)

        colMemberID.ReadOnly = False
        colName.ReadOnly = True

        colCardID.Visible = False
        colConsumablePoints.Visible = False
        colSite.Visible = False
        colDateAdded.Visible = False
        colAddedBy.Visible = False
        colDateUploaded.Visible = False
        colUploadedBy.Visible = False
        colDateUpdated.Visible = False
        colUpdatedBy.Visible = False


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If btnSave.Enabled = True Then
            If MsgBox("Discard changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Repopulate()
            End If
        Else
            Repopulate()
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim oRewards As New Rewards_Entity

        Dim iCount As Integer = 0
        iCount = dgRewards.SelectedRows.Count
        If MsgBox("Are you sure you want to delete " & iCount.ToString() & " item(s)", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataGridViewRow In dgRewards.SelectedRows
                oRewards.iID = dr.Cells("colID").Value
                oSQLRewards.DeleteRewardsByID(oRewards)
            Next
        End If

        Repopulate()
    End Sub

    Private Sub dgRewards_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRewards.CellEndEdit
        Dim iErrorCode As Integer = 0

        btnSave.Enabled = True

        If bIsNew Then
            If dgRewards.CurrentRow.Cells("colMemberID").Value.ToString() <> "" Then
                Dim oMember As New Member_Entity
                Dim dtMember As New DataTable
                oMember.sMemberID = dgRewards.CurrentRow.Cells("colMemberID").Value.ToString()
                dtMember = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)
                'TODO: do something if iErrorCode = -2146232060 

                If Not dtMember Is Nothing Then
                    If dtMember.Rows.Count > 0 Then
                        dgRewards.CurrentRow.Cells("colName").Value = dtMember.Rows(0)("FullName").ToString()
                    Else
                        MsgBox("Member ID not found.")
                        dgRewards.CurrentRow.Cells("colMemberID").Value = ""
                    End If
                Else
                    MsgBox("Member ID not found.")
                    dgRewards.CurrentRow.Cells("colMemberID").Value = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oRewards As New Rewards_Entity
        Dim oMember As New Member_Entity
        Dim iRowCount As Integer = 0

        Dim dtNewRows As New DataTable
        Dim dvNewRows As New DataView

        Dim iErrorCode As Integer = 0

        If dgRewards.DataSource.GetType().ToString() = "System.Data.DataView" Then
            dvNewRows = dgRewards.DataSource
            dtNewRows = dvNewRows.ToTable()
        Else
            dtNewRows = dgRewards.DataSource
        End If


        dtNewRows = dtNewRows.GetChanges()

        If Not dtNewRows Is Nothing Then
            If bIsNew Then


                For Each dr As DataRow In dtNewRows.Rows

                    oRewards.sMemberID = dr("MemberID").ToString()
                    oRewards.iPoints = CInt(Val(dr("Points").ToString()))
                    oRewards.dtValidFrom = IIf(dr("ValidFrom") Is System.DBNull.Value, Nothing, dr("ValidFrom"))
                    oRewards.dtValidTo = IIf(dr("ValidTo") Is System.DBNull.Value, Nothing, dr("ValidTo"))

                    oRewards.dtDateAdded = Date.Now
                    oRewards.sAddedBy = Program.sUserName

                    'Input Validations

                    If oRewards.sMemberID.Trim() = "" Then
                        MsgBox("CIM Number is required.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If oRewards.iPoints <= 0 Then
                        MsgBox("Invalid value for Points.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If oRewards.dtValidFrom >= oRewards.dtValidTo Then
                        MsgBox("Invalid date range for Effective Date and Expiration Date.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    'Database Validation
                    oMember.sMemberID = oRewards.sMemberID
                    If oSQLMember.CheckMember(oMember, iErrorCode) Then
                        'TODO: do something if iErrorCode = -2146232060 
                        If oSQLRewards.CheckRewards(oRewards) Then
                            MsgBox("Effectivity and Expiration Dates for CIM Number, " & oRewards.sMemberID & ", already exist.", MsgBoxStyle.Information)
                            Exit Sub
                        Else
                            oSQLRewards.AddRewards(oRewards)
                        End If
                    Else
                        MsgBox("CIM Number, " & oRewards.sMemberID & ", is not yet enrolled.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next

            Else
                For Each dr As DataRow In dtNewRows.Rows
                    oRewards.iID = dr("ID").ToString()
                    oRewards.sMemberID = dr("MemberID").ToString()
                    oRewards.iPoints = CInt(Val(dr("Points").ToString()))
                    oRewards.iConsumablePoints = CInt(Val(dr("ConsumablePoints").ToString()))
                    oRewards.dtValidFrom = IIf(dr("ValidFrom") Is System.DBNull.Value, Nothing, dr("ValidFrom"))
                    oRewards.dtValidTo = IIf(dr("ValidTo") Is System.DBNull.Value, Nothing, dr("ValidTo"))

                    oRewards.dtDateUpdated = Date.Now
                    oRewards.sUpdatedBy = Program.sUserName

                    'Input Validations

                    If oRewards.iPoints <= 0 Then
                        MsgBox("Invalid value for Points.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If oRewards.dtValidFrom >= oRewards.dtValidTo Then
                        MsgBox("Invalid date range for Effective Date and Expiration Date.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    oSQLRewards.UpdateRewards(oRewards)

                Next
            End If
        End If

        Repopulate()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim iIndex As Integer = 0
        bIsNew = False
        grpFilter.Enabled = False        
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnCancel.Enabled = True

        dgRewards.ReadOnly = False
        dgRewards.SelectionMode = DataGridViewSelectionMode.CellSelect
        iIndex = dgRewards.CurrentRow.Index
        dgRewards.CurrentCell = dgRewards.Rows(iIndex).Cells("colPoints")

        dgRewards.BeginEdit(True)

        colMemberID.ReadOnly = True
        colName.ReadOnly = True
        colConsumablePoints.Visible = True

        colCardID.Visible = False
        colSite.Visible = False
        colDateUploaded.Visible = False
        colUploadedBy.Visible = False
        colDateUpdated.Visible = False
        colUpdatedBy.Visible = False
        colDateAdded.Visible = False
        colAddedBy.Visible = False

    End Sub

    Private Sub Repopulate()
        bIsNew = False
        grpFilter.Enabled = True
        dgRewards.AllowUserToAddRows = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        If dgRewards.Rows.Count > 0 Then
            btnEdit.Enabled = True
            btnRemove.Enabled = True
        Else
            btnEdit.Enabled = True
            btnRemove.Enabled = False
        End If
        btnCancel.Enabled = False

        dgRewards.MultiSelect = True
        dgRewards.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colCardID.Visible = True
        colName.Visible = True
        colSite.Visible = True
        colDateUploaded.Visible = True
        colUploadedBy.Visible = True
        colDateUpdated.Visible = True
        colUpdatedBy.Visible = True
        colDateAdded.Visible = True
        colAddedBy.Visible = True


        LoadRewards()
    End Sub
End Class