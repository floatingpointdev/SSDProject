Public Class frmSalaryDeductionMaintenance

    Private oCredits As New Credits_Entity
    Private oCreditLogs As New CreditsLog_Entity
    Private oMember As New Member_Entity

    Private bSDLogHasChanged As Boolean = False
    Private bSDPayHasChanged As Boolean = False
    Private iOldRowIndex As Integer = -1
    Private iOldRowIndex1 As Integer = -1

    Private dtSDLogs As New DataTable
    Private dtSDLogsPayment As New DataTable
    Private dtAllSD As New DataTable

    Private Sub frmSalaryDeductionMaintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bSDLogHasChanged Or bSDPayHasChanged Then
            If MsgBox("There are uncommitted changes.  Do you want to close this window?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmSalaryDeductionMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvSDLogs.AutoGenerateColumns = False
        dgvSDLogs.Enabled = False
        dgvSDLogs.AllowUserToAddRows = False

        dgvSDPayments.AutoGenerateColumns = False
        dgvSDPayments.AllowUserToAddRows = False
        dgvSDPayments.Enabled = False

        LoadInMemorySalaryDeductions()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim dt As New DataTable
        Dim iErrorCode As Integer = 0

        oMember.sMemberID = txtMemberID.Text
        dt = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)

        'TODO: do something if iErrorCode is -2146232060 

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                txtFullName.Text = dt.Rows(0)("FullName")

                dgvSDLogs.AllowUserToAddRows = True
                dgvSDLogs.Enabled = True
                dgvSDPayments.AllowUserToAddRows = True
                dgvSDPayments.Enabled = True

            Else
                txtFullName.Text = ""

                dgvSDLogs.AllowUserToAddRows = False
                dgvSDLogs.Enabled = False
                dgvSDPayments.AllowUserToAddRows = False
                dgvSDPayments.Enabled = False

            End If
        End If

        PopulateSDLogs()
        PopulateSDPay()
    End Sub

    Private Sub txtMemberID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMemberID.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub PopulateSDLogs()
        Dim dvSDLogs As New DataView

        oCreditLogs.sMemberID = txtMemberID.Text.Trim()
        dvSDLogs = dtAllSD.DefaultView
        dvSDLogs.RowFilter = "MemberID = '" & oCreditLogs.sMemberID & "' and isnull(TransType,'') = 'SD'"
        dtSDLogs = dvSDLogs.ToTable()
        'dtSDLogs = oSQLLogs.GetCreditLogsbyMemberID(oCreditLogs.sMemberID)
        dgvSDLogs.DataSource = dtSDLogs
        dtSDLogs.AcceptChanges()
    End Sub

    Private Sub PopulateSDPay()
        Dim dvSDPay As New DataView

        oCreditLogs.sMemberID = txtMemberID.Text.Trim()
        dvSDPay = dtAllSD.DefaultView
        dvSDPay.RowFilter = "MemberID = '" & oCreditLogs.sMemberID & "' and isnull(TransType,'') = 'PAID'"
        dtSDLogsPayment = dvSDPay.ToTable()
        'dtSDLogsPayment = oSQLLogs.GetCreditLogsPaymentByMemberID(oCreditLogs.sMemberID)

        dgvSDPayments.DataSource = dtSDLogsPayment
        dtSDLogsPayment.AcceptChanges()
    End Sub

    Private Sub LoadInMemorySalaryDeductions()        
        dtAllSD = oSQLLogs.GetAllCredits()
    End Sub

    Private Sub dgvSDLogs_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSDLogs.SelectionChanged
        If Not dgvSDLogs.CurrentRow Is Nothing Then
            If Not dgvSDLogs.CurrentRow.IsNewRow Then
                btnSDLogDelete.Enabled = True
            Else
                btnSDLogDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvSDLogs_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSDLogs.CellEndEdit
        bSDLogHasChanged = True
        btnSDLogSave.Enabled = True
        btnSDLogCancel.Enabled = True
    End Sub

    Private Sub btnSDLogSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDLogSave.Click
        Dim bHasErrors As Boolean = False
        Dim sErrorMsg As String = ""
        Dim dtModified As New DataTable
        Dim dtCredits As New DataTable
        Dim dCredits As Double = 0.0

        dtModified = dgvSDLogs.DataSource
        If Not dtModified Is Nothing Then
            dtModified = dtModified.GetChanges()
        End If

        If bSDLogHasChanged Then
            For Each dr As DataGridViewRow In dgvSDLogs.Rows
                'Required Parameter Check
                If dr.IsNewRow = False Then
                    If dr.Cells("colSDLogsAmount").Value.ToString() = "" Then
                        dr.Cells("colSDLogsAmount").Selected = True
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
                        oCreditLogs.iID = Int(Val(dr("ID").ToString()))
                        oCreditLogs.sMemberID = txtMemberID.Text

                        If oCreditLogs.iID = 0 Then
                            oCreditLogs.sLocation = Program.sTerminalID
                        Else
                            oCreditLogs.sLocation = dr("Location")
                        End If

                        oCreditLogs.dAmount = dr("Amount")
                        oCreditLogs.sRemarks = dr("Remarks").ToString()

                        oCreditLogs.sUser = Program.sUserName
                        oCreditLogs.sIPAddress = Program.sIPAddress
                        oCreditLogs.sHostName = Program.sHostName
                        oCreditLogs.sTransType = ""
                        Try
                            'If Not oSQLLogs.CheckCreditLogs(oCreditLogs) Then
                            dtCredits = oSQLCredits.GetCreditsLogSumByMemberID(oCredits)
                            If dtCredits.Rows.Count > 0 Then
                                dCredits = Val(dtCredits.Rows(0)("Amount").ToString())
                            Else
                                dCredits = 0
                            End If
                            If dCredits >= oCreditLogs.dAmount Then
                                oSQLLogs.AddCreditsLog(oCreditLogs)
                            Else
                                Throw New System.Exception("Will exceed credit limit.")
                            End If

                            'End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    ElseIf dr.RowState = DataRowState.Modified Then
                        oCreditLogs.sMemberID = txtMemberID.Text
                        oCreditLogs.iID = dr("ID")

                        If oCreditLogs.iID = 0 Then
                            oCreditLogs.sLocation = Program.sTerminalID
                        Else
                            oCreditLogs.sLocation = dr("Location")
                        End If

                        oCreditLogs.dAmount = dr("Amount")
                        oCreditLogs.sRemarks = dr("Remarks").ToString()

                        oCreditLogs.sUser = Program.sUserName
                        oCreditLogs.sIPAddress = Program.sIPAddress
                        oCreditLogs.sHostName = Program.sHostName
                        oCreditLogs.sTransType = ""

                        Try
                            'If Not oSQLLogs.CheckCreditLogs(oCreditLogs) Then
                            oSQLLogs.UpdateCreditsLogByID(oCreditLogs)
                            'End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    End If

                Next

                'For deleted rows
                For Each dr As DataGridViewRow In dgvSDLogsDeleted.Rows
                    If dr.IsNewRow = False Then
                        oCreditLogs.iID = Int(Val(dr.Cells("colSDLogsDelID").Value.ToString()))

                        Try
                            oSQLLogs.DeleteCreditLogsByID(oCreditLogs.iID)
                        Catch ex As Exception
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully deleted.  Please try again."
                            bHasErrors = True
                            Exit For
                        End Try
                    End If
                Next


                dgvSDLogsDeleted.Rows.Clear()

                LoadInMemorySalaryDeductions()
                PopulateSDLogs()


                If Not bHasErrors Then
                    MsgBox("Database successfully updated.", MsgBoxStyle.Information)
                    btnSDLogSave.Enabled = False
                    btnSDLogCancel.Enabled = False
                    bSDLogHasChanged = False
                Else
                    MsgBox(sErrorMsg, MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub btnSDLogDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDLogDelete.Click
        Dim iRow As Integer = dgvSDLogs.CurrentRow.Index
        Dim dr As New DataGridViewRow
        Dim iCol As Integer = 0
        Dim iHasRows As Integer = 0

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dr = dgvSDLogs.CurrentRow.Clone()
            For Each dc As DataGridViewCell In dgvSDLogs.CurrentRow.Cells
                dr.Cells(iCol).Value = dc.Value
                iCol += 1
            Next
            dgvSDLogsDeleted.Rows.Add(dr)

            dgvSDLogs.Rows.Remove(dgvSDLogs.CurrentRow)

            btnSDLogSave.Enabled = True
            btnSDLogCancel.Enabled = True
            bSDLogHasChanged = True

            If Not dgvSDLogs.CurrentRow Is Nothing Then
                If dgvSDLogs.CurrentRow.Index = 0 Then
                    btnSDLogDelete.Enabled = False
                Else
                    dgvSDLogs.CurrentCell = dgvSDLogs.CurrentRow.Cells(0)
                End If
            Else
                btnSDLogDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSDLogCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDLogCancel.Click
        If MsgBox("This will cancel all changes.  Proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dtSDLogs.RejectChanges()

            dgvSDLogsDeleted.Rows.Clear()

            btnSDLogSave.Enabled = False
            btnSDLogDelete.Enabled = False
            btnSDLogCancel.Enabled = False
            bSDLogHasChanged = False
        End If
    End Sub

    Private Sub dgvSDPayments_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSDPayments.SelectionChanged
        If Not dgvSDPayments.CurrentRow Is Nothing Then
            If Not dgvSDPayments.CurrentRow.IsNewRow Then
                btnSDPayDelete.Enabled = True
            Else
                btnSDPayDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvSDPayments_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSDPayments.CellEndEdit
        bSDPayHasChanged = True
        btnSDPaySave.Enabled = True
        btnSDPayCancel.Enabled = True
    End Sub

    Private Sub btnSDPaySave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDPaySave.Click
        Dim bHasErrors As Boolean = False
        Dim sErrorMsg As String = ""
        Dim dtModified As New DataTable

        dtModified = dgvSDPayments.DataSource
        If Not dtModified Is Nothing Then
            dtModified = dtModified.GetChanges()
        End If

        If bSDPayHasChanged Then
            For Each dr As DataGridViewRow In dgvSDPayments.Rows
                'Required Parameter Check
                If dr.IsNewRow = False Then
                    If dr.Cells("colSDPayAmount").Value.ToString() = "" Then
                        dr.Cells("colSDPayAmount").Selected = True
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
                        oCreditLogs.iID = Int(Val(dr("ID").ToString()))
                        oCreditLogs.sMemberID = txtMemberID.Text

                        If oCreditLogs.iID = 0 Then
                            oCreditLogs.sLocation = Program.sTerminalID
                        Else
                            oCreditLogs.sLocation = dr("Location")
                        End If

                        oCreditLogs.dAmount = dr("Amount") * -1
                        oCreditLogs.sRemarks = dr("Remarks").ToString()

                        oCreditLogs.sUser = Program.sUserName
                        oCreditLogs.sIPAddress = Program.sIPAddress
                        oCreditLogs.sHostName = Program.sHostName
                        oCreditLogs.sTransType = "PAID"
                        Try
                            'If Not oSQLLogs.CheckCreditLogs(oCreditLogs) Then
                            oSQLLogs.AddCreditsLog(oCreditLogs)
                            'End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    ElseIf dr.RowState = DataRowState.Modified Then
                        oCreditLogs.sMemberID = txtMemberID.Text

                        If oCreditLogs.iID = 0 Then
                            oCreditLogs.sLocation = Program.sTerminalID
                        Else
                            oCreditLogs.sLocation = dr("Location")
                        End If

                        oCreditLogs.dAmount = dr("Amount") * -1
                        oCreditLogs.sRemarks = dr("Remarks").ToString()

                        oCreditLogs.sUser = Program.sUserName
                        oCreditLogs.sIPAddress = Program.sIPAddress
                        oCreditLogs.sHostName = Program.sHostName
                        oCreditLogs.sTransType = "PAID"

                        Try
                            'If Not oSQLLogs.CheckCreditLogs(oCreditLogs) Then
                            oSQLLogs.UpdateCreditsLogByID(oCreditLogs)
                            'End If

                        Catch ex As Exception
                            bHasErrors = True
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully saved.  Please try again."
                            Exit For
                        End Try
                    End If

                Next

                'For deleted rows
                For Each dr As DataGridViewRow In dgvSDPaymentsDeleted.Rows
                    If dr.IsNewRow = False Then
                        oCreditLogs.iID = Int(Val(dr.Cells("colSDPayDelID").Value.ToString()))

                        Try
                            oSQLLogs.DeleteCreditLogsByID(oCreditLogs.iID)
                        Catch ex As Exception
                            sErrorMsg = ex.Message & vbCrLf & "Some records were not successfully deleted.  Please try again."
                            bHasErrors = True
                            Exit For
                        End Try
                    End If
                Next

                dgvSDPaymentsDeleted.Rows.Clear()

                LoadInMemorySalaryDeductions()
                PopulateSDPay()


                If Not bHasErrors Then
                    MsgBox("Database successfully updated.", MsgBoxStyle.Information)
                    btnSDPaySave.Enabled = False
                    btnSDPayCancel.Enabled = False
                    bSDPayHasChanged = False
                Else
                    MsgBox(sErrorMsg, MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub btnSDPayDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDPayDelete.Click
        Dim iRow As Integer = dgvSDPayments.CurrentRow.Index
        Dim dr As New DataGridViewRow
        Dim iCol As Integer = 0
        Dim iHasRows As Integer = 0

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dr = dgvSDPayments.CurrentRow.Clone()
            For Each dc As DataGridViewCell In dgvSDPayments.CurrentRow.Cells
                dr.Cells(iCol).Value = dc.Value
                iCol += 1
            Next

            dgvSDPaymentsDeleted.Rows.Add(dr)

            dgvSDPayments.Rows.Remove(dgvSDPayments.CurrentRow)

            btnSDPaySave.Enabled = True
            btnSDPayCancel.Enabled = True
            bSDPayHasChanged = True

            If Not dgvSDPayments.CurrentRow Is Nothing Then
                If dgvSDPayments.CurrentRow.Index = 0 Then
                    btnSDPayDelete.Enabled = False
                Else
                    dgvSDPayments.CurrentCell = dgvSDPayments.CurrentRow.Cells(0)
                End If
            Else
                btnSDPayDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSDPayCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDPayCancel.Click
        If MsgBox("This will cancel all changes.  Proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dtSDLogsPayment.RejectChanges()

            dgvSDPaymentsDeleted.Rows.Clear()

            btnSDPaySave.Enabled = False
            btnSDPayDelete.Enabled = False
            btnSDPayCancel.Enabled = False
            bSDPayHasChanged = False
        End If
    End Sub
End Class