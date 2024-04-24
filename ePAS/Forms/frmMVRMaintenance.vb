Public Class frmMVRMaintenance

    Private oMVR As New MVR_Entity
    Private oMVRLog As New MVRLog_Entity

    Private dtMVR As New DataTable
    Private dtMVRLogs As New DataTable
    Private dtMVRTransLog As New DataTable

    Private bHasChanged As Boolean = False
    Private bLogHasChanged As Boolean = False
    Private iOldRowIndex As Integer = -1
    Private iOldRowIndex1 As Integer = -1

    Private Sub frmMVRMaintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bHasChanged Or bLogHasChanged Then
            If MsgBox("There are uncommitted changes.  Do you want to close this window?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMVRMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvMVR.AutoGenerateColumns = False
        dgvMVRTransLog.AutoGenerateColumns = False
        dgvMVRTransLog.Enabled = False
        dgvMVRTransLog.AllowUserToAddRows = False

        LoadInMemoryMVRLogs() 'should come before PopulateMVR
        PopulateMVR()
    End Sub

    Private Sub dgvMVR_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMVR.CellEndEdit
        Dim dt As New DataTable
        Dim oMember As New Member_Entity
        Dim iErrorCode As Integer = 0

        If dgvMVR.CurrentCell.ColumnIndex = 1 Then 'CIMNo
            If Not dgvMVR.CurrentCell.Value Is Nothing Then
                oMember.sMemberID = dgvMVR.CurrentCell.Value.ToString()
                dt = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)

                If iErrorCode = -2146232060 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If


                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        dgvMVR.CurrentRow.Cells("colMVRFullName").Value = dt.Rows(0)("FullName").ToString()
                        dgvMVR.CurrentRow.Cells("colMVRSite").Value = dt.Rows(0)("Address").ToString()
                    Else
                        MsgBox("CIM Number not found.", MsgBoxStyle.Information)
                        dgvMVR.CurrentRow.Cells(2).Value = ""
                    End If
                Else
                    MsgBox("CIM Number not found.", MsgBoxStyle.Information)
                    dgvMVR.CurrentRow.Cells("colMVRFullName").Value = ""
                End If
            End If
        End If

        If dgvMVR.CurrentCell.ColumnIndex = 4 Then 'MVRAmount
            If Not dgvMVR.CurrentCell.Value Is Nothing Then
                dgvMVR.CurrentRow.Cells("colMVRConsumable").Value = dgvMVR.CurrentCell.Value
            End If
        End If

        btnMVRSave.Enabled = True
        btnMVRCancel.Enabled = True
        If Not dgvMVR.CurrentRow.IsNewRow Then
            btnMVRDelete.Enabled = True
        Else
            btnMVRDelete.Enabled = False
        End If

        bHasChanged = True
    End Sub

    Private Sub dgvMVR_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMVR.SelectionChanged
        If Not dgvMVR.CurrentRow Is Nothing Then
            '* Prevent from firing this event when changing columns
            If iOldRowIndex = dgvMVR.CurrentRow.Index Then Exit Sub

            iOldRowIndex = dgvMVR.CurrentRow.Index

            '* Configure the row for editing
            If Not dgvMVR.CurrentRow.IsNewRow Then
                btnMVRDelete.Enabled = True

                '* Enable adding of transactions only when the current row is committed
                '* It is committed when the record has ID
                If dgvMVR.CurrentRow.Cells("colMVRID").Value.ToString() <> "" Then
                    PopulateMVRTransLog(1)

                    dgvMVRTransLog.Enabled = True
                    dgvMVRTransLog.AllowUserToAddRows = True

                    If Not dgvMVRTransLog.CurrentRow Is Nothing Then
                        If dgvMVRTransLog.CurrentRow.IsNewRow Then
                            btnMVRTransLogDelete.Enabled = False
                        Else
                            btnMVRTransLogDelete.Enabled = True
                        End If

                    Else
                        btnMVRTransLogDelete.Enabled = False
                    End If

                    btnMVRTransLogCancel.Enabled = False
                Else
                    dgvMVRTransLog.Enabled = False
                    dgvMVRTransLog.AllowUserToAddRows = False
                End If

            Else
                oMVRLog.sMemberID = ""
                dgvMVRTransLog.Enabled = False
                dgvMVRTransLog.AllowUserToAddRows = False

                btnMVRDelete.Enabled = False

                dgvMVR.CurrentRow.Cells("colMVRMemberID").ReadOnly = False
                dgvMVR.CurrentRow.Cells("colMVRAmount").ReadOnly = False

                dgvMVRTransLog.DataSource = Nothing

            End If
        Else
            dgvMVRTransLog.Enabled = False
            dgvMVRTransLog.AllowUserToAddRows = False
        End If

    End Sub

    Private Sub btnMVRCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRCancel.Click
        If MsgBox("This will cancel all changes.  Proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dtMVR.RejectChanges()

            dgvMVRDeleted.Rows.Clear()

            btnMVRSave.Enabled = False
            btnMVRDelete.Enabled = False
            btnMVRCancel.Enabled = False
            bHasChanged = False
        End If
    End Sub

    Private Sub btnMVRDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRDelete.Click
        Dim iRow As Integer = dgvMVR.CurrentRow.Index
        Dim dr As New DataGridViewRow
        Dim iCol As Integer = 0
        Dim iHasRows As Integer = 0

        'Check first if the row to be deleted has existing transaction logs
        oMVRLog.iRefID = Int(Val(dgvMVR.CurrentRow.Cells("colMVRID").Value.ToString()))
        iHasRows = dgvMVRTransLog.Rows.Count - 1
        If iHasRows > 0 Then
            MsgBox("Can't delete this record while it has underlying transactions.", MsgBoxStyle.Information)
            Exit Sub
        End If


        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dr = dgvMVR.CurrentRow.Clone()
            For Each dc As DataGridViewCell In dgvMVR.CurrentRow.Cells
                dr.Cells(iCol).Value = dc.Value
                iCol += 1
            Next
            dgvMVRDeleted.Rows.Add(dr)

            dgvMVR.Rows.Remove(dgvMVR.CurrentRow)

            btnMVRSave.Enabled = True
            btnMVRCancel.Enabled = True
            bHasChanged = True

            If Not dgvMVR.CurrentRow Is Nothing Then
                If dgvMVR.CurrentRow.Index = 0 Then
                    btnMVRDelete.Enabled = False
                Else
                    dgvMVR.CurrentCell = dgvMVR.CurrentRow.Cells(0)
                End If
            Else
                btnMVRDelete.Enabled = False
            End If

        End If
    End Sub

    Private Sub btnMVRSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRSave.Click
        Dim bHasErrors As Boolean = False
        Dim sErrorMsg As String = ""
        Dim dtModified As New DataTable

        dtModified = dgvMVR.DataSource
        If Not dtModified Is Nothing Then
            dtModified = dtModified.GetChanges()
        End If


        If bHasChanged Then
            'dgvMVR.ClearSelection()
            For Each dr As DataGridViewRow In dgvMVR.Rows
                'Required Parameter Check
                If dr.IsNewRow = False Then
                    If dr.Cells("colMVRMemberID").Value.ToString() = "" Then
                        dr.Cells("colMVRMemberID").Selected = True
                        bHasErrors = True
                    End If

                    If dr.Cells("colMVRAmount").Value.ToString() = "" Then
                        dr.Cells("colMVRAmount").Selected = True
                        bHasErrors = True
                    End If

                    If dr.Cells("colMVRConsumable").Value.ToString() = "" Then
                        dr.Cells("colMVRConsumable").Selected = True
                        bHasErrors = True
                    End If

                    If dr.Cells("colMVRApplicableYear").Value.ToString() = "" Then
                        dr.Cells("colMVRApplicableYear").Selected = True
                        bHasErrors = True
                    End If

                    If bHasErrors Then
                        Exit For
                    End If
                End If

            Next

        End If

        If bHasErrors Then
            MsgBox("Required field(s).", MsgBoxStyle.Information)
        Else
            'For New and Updated Rows
            If Not dtModified Is Nothing Then
                For Each dr As DataRow In dtModified.Rows
                    If dr.RowState = DataRowState.Added Then
                        oMVR.iID = Int(Val(dr("ID").ToString()))
                        oMVR.sMemberID = dr("MemberID")
                        oMVR.dMVRAmount = dr("MVRAmount")
                        oMVR.dMVRConsumable = dr("MVRConsumable")
                        oMVR.iApplicableYear = dr("ApplicableYear")
                        oMVR.sAddedBy = Program.sUserName
                        oMVR.sUpdatedBy = Program.sUserName
                        oMVR.sIPAddress = Program.sIPAddress
                        oMVR.sHostName = Program.sHostName
                        Try
                            If Not oSQLMVR.CheckMVR(oMVR) Then
                                oSQLMVR.AddMVR(oMVR)                           
                            End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    ElseIf dr.RowState = DataRowState.Modified Then
                        oMVR.iID = Int(Val(dr("ID").ToString()))
                        oMVR.sMemberID = dr("MemberID")
                        oMVR.dMVRAmount = dr("MVRAmount")
                        oMVR.dMVRConsumable = dr("MVRConsumable")
                        oMVR.iApplicableYear = dr("ApplicableYear")
                        oMVR.sUpdatedBy = Program.sUserName
                        oMVR.sIPAddress = Program.sIPAddress
                        oMVR.sHostName = Program.sHostName
                        Try
                            'If Not oSQLMVR.CheckMVR(oMVR) Then
                            oSQLMVR.UpdateMVRByID(oMVR)
                            'End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    End If

                Next

                'For deleted rows
                For Each dr As DataGridViewRow In dgvMVRDeleted.Rows
                    If dr.IsNewRow = False Then
                        oMVR.iID = Int(Val(dr.Cells("colMVRDelID").Value.ToString()))

                        Try
                            oSQLMVR.DeleteMVRByID(oMVR.iID)
                        Catch ex As Exception
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully deleted.  Please try again."
                            bHasErrors = True
                            Exit For
                        End Try
                    End If
                Next


                dgvMVRDeleted.Rows.Clear()


                PopulateMVR() 'dtMVR.AcceptChanges() <- does not reflect the ID field

                If Not bHasErrors Then
                    If txtMemberID.Text.Trim() <> "" Then
                        btnSearch.PerformClick()
                    End If


                    MsgBox("Database successfully updated.", MsgBoxStyle.Information)
                    btnMVRSave.Enabled = False
                    btnMVRCancel.Enabled = False
                    bHasChanged = False
                Else
                    MsgBox(sErrorMsg, MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub dgvMVRTransLog_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMVRTransLog.CellEndEdit
        Dim dMVRConsumable As Double = 0.0
        Dim dMVRTransAmount As Double = 0.0

        'Get the referenced MVR Consumable amount
        dMVRConsumable = Val(dgvMVR.CurrentRow.Cells("colMVRConsumable").Value.ToString())

        'Compute total deduction to MVR Consumable
        For Each dr As DataGridViewRow In dgvMVRTransLog.Rows
            If Not dr.Cells("colMVRLogAmount").Value Is Nothing Then
                dMVRTransAmount += Int(Val(dr.Cells("colMVRLogAmount").Value.ToString()))
                If dMVRConsumable >= dMVRTransAmount Then
                    dr.Cells("colMVRLogRefID").Value = dgvMVR.CurrentRow.Cells("colMVRID").Value
                    dgvMVRTransLog.CommitEdit(DataGridViewDataErrorContexts.Commit)
                Else
                    MsgBox("Insufficient MVR Amount.", MsgBoxStyle.Information)
                    dgvMVRTransLog.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    dgvMVRTransLog.Rows.Remove(dr)
                End If
            End If
        Next

        grpMVR.Enabled = False
        btnMVRTransLogSave.Enabled = True
        btnMVRTransLogCancel.Enabled = True
        bLogHasChanged = True
    End Sub

    Private Sub dgvMVRTransLog_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMVRTransLog.SelectionChanged
        If Not dgvMVRTransLog.CurrentRow Is Nothing Then
            'Prevent from firing this event when changing columns
            'If iOldRowIndex1 = dgvMVRTransLog.CurrentRow.Index Then Exit Sub

            iOldRowIndex1 = dgvMVRTransLog.CurrentRow.Index

            'Configure the row for editing
            If Not dgvMVRTransLog.CurrentRow.IsNewRow Then
                If dgvMVRTransLog.Rows.Count >= 1 Then
                    btnMVRTransLogDelete.Enabled = True

                    dgvMVRTransLog.CurrentRow.Cells("colMVRLogTransDate").ReadOnly = True
                    dgvMVRTransLog.CurrentRow.Cells("colMVRLogLocation").ReadOnly = True
                Else
                    btnMVRTransLogDelete.Enabled = False
                End If
            Else
                btnMVRTransLogDelete.Enabled = False
            End If
        Else
            btnMVRTransLogDelete.Enabled = False
        End If

        
    End Sub

    Private Sub PopulateMVR()
        dtMVR = oSQLMVR.GetMVR(oMVR)
        dgvMVR.DataSource = dtMVR
    End Sub

    Private Sub PopulateMVRTransLog(ByVal iPopulateMode As Integer)
        '* Since dtMVRLogs has already been populated at Form Load event, just get the rows from it where
        '* the MemberIDs corresponds to the selected MemberID from the MVR datagridview
        '* to do this, we'll need a DataView

        Dim dvMVRTransLog As New DataView

        '* Get the MemberID
        oMVRLog.sMemberID = dgvMVR.CurrentRow.Cells("colMVRMemberID").Value.ToString()
        oMVRLog.iID = dgvMVR.CurrentRow.Cells("colMVRID").Value.ToString()

        dvMVRTransLog = dtMVRLogs.DefaultView
        dvMVRTransLog.RowFilter = "MemberID = '" & oMVRLog.sMemberID & "' and MVRRefID = '" & oMVRLog.iID & "'"

        '* Store the filtered records into a temporary DataTable and bind it to the MVRLog datagridview
        dtMVRTransLog = dvMVRTransLog.ToTable()
        dtMVRTransLog.AcceptChanges()
        dgvMVRTransLog.DataSource = dtMVRTransLog

    End Sub

    Private Sub btnMVRTransLogSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRTransLogSave.Click
        Dim bHasErrors As Boolean = False
        Dim sErrorMsg As String = ""
        Dim dtModified As New DataTable

        dtModified = dtMVRTransLog.GetChanges()

        If bLogHasChanged Then            
            For Each dr As DataGridViewRow In dgvMVRTransLog.Rows
                '* Required Parameter Check
                If dr.IsNewRow = False Then
                    If dr.Cells("colMVRLogAmount").Value.ToString() = "" Then
                        dr.Cells("colMVRLogAmount").Selected = True
                        bHasErrors = True
                    End If

                    If bHasErrors Then
                        Exit For
                    End If
                End If
            Next

        End If
        If bHasErrors Then
            MsgBox("Required field(s).", MsgBoxStyle.Information)
        Else
            '* For New and Updated Rows
            oMVR.sMemberID = dgvMVR.CurrentRow.Cells("colMVRMemberID").Value.ToString()
            If Not dtModified Is Nothing Then
                For Each dr As DataRow In dtModified.Rows
                    If dr.RowState = DataRowState.Added Then
                        oMVRLog.iID = Int(Val(dr("ID").ToString()))
                        oMVRLog.sMemberID = oMVR.sMemberID
                        oMVRLog.sCardID = ""
                        oMVRLog.dAmount = dr("Amount")
                        If oMVRLog.iID = 0 Then
                            oMVRLog.sLocation = Program.sTerminalID
                        Else
                            oMVRLog.sLocation = dr("Location")
                        End If

                        oMVRLog.sRemarks = dr("Remarks").ToString()
                        oMVRLog.sTransType = "MVR"
                        oMVRLog.sTransCode = Format(Int(StripOff(Now.ToString("yyyyMMddhhmmss"))), "000000000000000")
                        oMVRLog.sUser = Program.sUserName
                        oMVRLog.sIPAddress = Program.sIPAddress
                        oMVRLog.sHostName = Program.sHostName
                        oMVRLog.iRefID = dgvMVR.CurrentRow.Cells("colMVRID").Value
                        Try
                            '* Add the logs
                            oSQLLogs.AddMVRLog(oMVRLog)
                            '* Do a recomputation on server side
                            oSQLMVR.RecomputeMVR(oMVRLog)
                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try

                    ElseIf dr.RowState = DataRowState.Modified Then
                        oMVRLog.iID = Int(Val(dr("ID").ToString()))
                        oMVRLog.sMemberID = oMVR.sMemberID
                        oMVRLog.sCardID = ""
                        oMVRLog.dAmount = dr("Amount")
                        If oMVRLog.iID = 0 Then
                            oMVRLog.sLocation = Program.sTerminalID
                        Else
                            oMVRLog.sLocation = dr("Location")
                        End If

                        oMVRLog.sRemarks = dr("Remarks").ToString()
                        oMVRLog.sTransType = "MVR"
                        oMVRLog.sTransCode = Format(Int(StripOff(Now.ToString("yyyyMMddhhmmss"))), "000000000000000")
                        oMVRLog.sUser = Program.sUserName
                        oMVRLog.sIPAddress = Program.sIPAddress
                        oMVRLog.sHostName = Program.sHostName
                        oMVRLog.iRefID = dgvMVR.CurrentRow.Cells("colMVRID").Value
                        Try
                            oSQLLogs.AddUpdateMVRLog(oMVRLog)
                            oSQLMVR.RecomputeMVR(oMVRLog)
                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    End If
                Next
            End If


            '* For Deleted Rows

            For Each dr As DataGridViewRow In dgvMVRTransLogDeleted.Rows
                If dr.IsNewRow = False Then
                    oMVRLog.iID = Int(Val(dr.Cells("colMVRTransLogDelID").Value.ToString()))
                    oMVRLog.iRefID = Int(Val(dr.Cells("colMVRTransLogDelRefID").Value.ToString()))
                    Try
                        oSQLLogs.DeleteMVRLogByID(oMVRLog.iID)
                        oSQLMVR.RecomputeMVR(oMVRLog)
                    Catch ex As Exception
                        sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully deleted.  Please try again."
                        bHasErrors = True
                        Exit For
                    End Try
                End If
            Next

            dgvMVRTransLogDeleted.Rows.Clear()

            LoadInMemoryMVRLogs()
            PopulateMVR()
            PopulateMVRTransLog(1)

            If Not bHasErrors Then

                grpMVR.Enabled = True

                If txtMemberID.Text.Trim() <> "" Then
                    btnSearch.PerformClick()
                End If

                MsgBox("Database successfully updated.", MsgBoxStyle.Information)

                btnMVRTransLogSave.Enabled = False
                btnMVRTransLogCancel.Enabled = False
                bLogHasChanged = False
            Else
                MsgBox(sErrorMsg, MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnMVRTransLogDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRTransLogDelete.Click
        Dim iRow As Integer = dgvMVRTransLog.CurrentRow.Index
        Dim dr As New DataGridViewRow
        Dim iCol As Integer = 0

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            'freeze the main grid so that changes in the transaction grid will not disappear
            grpMVR.Enabled = False

            dr = dgvMVRTransLog.CurrentRow.Clone()
            For Each dc As DataGridViewCell In dgvMVRTransLog.CurrentRow.Cells
                dr.Cells(iCol).Value = dc.Value
                iCol += 1
            Next
            dgvMVRTransLogDeleted.Rows.Add(dr)

            dgvMVRTransLog.Rows.Remove(dgvMVRTransLog.CurrentRow)

            btnMVRTransLogSave.Enabled = True
            btnMVRTransLogCancel.Enabled = True
            bLogHasChanged = True

            'Force a selectionchange event
            If dgvMVRTransLog.Rows.Count > 0 Then
                iOldRowIndex1 = -1
                dgvMVRTransLog.CurrentCell = dgvMVRTransLog.Rows(iRow).Cells(0)
            End If
        End If
    End Sub

    Private Function StripOff(ByVal sString As String) As String
        sString = sString.Replace(":", "")
        sString = sString.Replace("PM", "")
        sString = sString.Replace("AM", "")
        sString = sString.Replace("/", "")
        sString = sString.Replace(" ", "")
        Return sString
    End Function

    Private Sub btnMVRTransLogCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMVRTransLogCancel.Click

        If MsgBox("This will cancel all changes.  Proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            'No changes could be found when the table is derived from dataview
            'dtMVRLogs.RejectChanges()
            'dtMVRTransLog.RejectChanges()

            PopulateMVRTransLog(1)

            'dgvMVR_SelectionChanged(sender, e)
            dgvMVRTransLogDeleted.Rows.Clear()

            grpMVR.Enabled = True
            btnMVRTransLogSave.Enabled = False
            btnMVRTransLogCancel.Enabled = False

            If Not dgvMVRTransLog.CurrentRow Is Nothing Then
                If Not dgvMVRTransLog.CurrentRow.IsNewRow Then
                    btnMVRTransLogDelete.Enabled = True
                Else
                    btnMVRTransLogDelete.Enabled = False
                End If
            Else
                btnMVRTransLogDelete.Enabled = False
            End If

            bLogHasChanged = False
        End If
    End Sub

    Private Sub LoadInMemoryMVRLogs()
        dtMVRLogs = oSQLLogs.getMVRLogs
    End Sub

   
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        For Each dr As DataGridViewRow In dgvMVR.Rows
            If Not dr.IsNewRow Then
                If dr.Cells("colMVRMemberID").Value.ToString() = txtMemberID.Text Then
                    dgvMVR.CurrentCell = dr.Cells(0)
                    dgvMVR_SelectionChanged(sender, e)
                End If
            End If

        Next
    End Sub

    Private Sub txtMemberID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMemberID.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub dgvMVRTransLog_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMVRTransLog.DataSourceChanged
        If dgvMVRTransLog.Rows.Count > 0 Then
            dgvMVRTransLog.CurrentCell = dgvMVRTransLog.Rows(0).Cells(0)
            If dgvMVRTransLog.CurrentRow.IsNewRow Then
                btnMVRTransLogDelete.Enabled = False
            End If
        Else

        End If

    End Sub
End Class