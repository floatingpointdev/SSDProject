Imports System.ComponentModel

Public Class frmMemberManager

    Private oMember As New Member_Entity
    Private oCard As New Card_Entity
    Private oLoyalty As New Loyalty_Entity
    Private dt As DataTable
    Private iRow, iResult As Integer
    Private bIsNew As Boolean = False

    Private bwGetPhoto As BackgroundWorker = New BackgroundWorker

    Private iSearchIndex As Integer = 0

#Region "Keypress"



    Private Sub frmMemberManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Program.bConnected Then
            btnGetCardID.Enabled = False
        Else
            btnGetCardID.Enabled = True
        End If

        dgvMember.AutoGenerateColumns = False
        btnNav(1, , 0)

        dtiExpiry.Value = Date.Now.AddYears(1)

        'If Not LoadLoyalty() Then
        '    pnlSave.Enabled = False
        '    pnlAdd.Enabled = False
        '    Exit Sub
        'End If

        If Not LoadMember() Then
            pnlSave.Enabled = False
            pnlAdd.Enabled = False
            Exit Sub
        End If

        bwGetPhoto.WorkerSupportsCancellation = True
        bwGetPhoto.WorkerReportsProgress = True

        AddHandler bwGetPhoto.DoWork, AddressOf bwGetPhoto_DoWork
        AddHandler bwGetPhoto.ProgressChanged, AddressOf bwGetPhoto_ProgressChanged
        AddHandler bwGetPhoto.RunWorkerCompleted, AddressOf bwGetPhoto_RunWorkerCompleted
    End Sub

    Private Sub tbMemberID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMemberID.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbCardID.Focus()
        End If
    End Sub

    Private Sub tbCardID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCardID.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbLName.Focus()
        End If
    End Sub

    Private Sub tbLName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbLName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbFName.Focus()
        End If
    End Sub

    Private Sub tbFName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbFName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbMName.Focus()
        End If
    End Sub

    Private Sub tbMName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbAddress.Focus()
        End If
    End Sub

    Private Sub tbCAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAddress.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbContactNo.Focus()
        End If
    End Sub

    Private Sub tbContactNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbContactNo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbEmail.Focus()
        End If
        If (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "+") Or (e.KeyChar = " ") Or (e.KeyChar = "-")) Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEmail.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbEmail.Focus()
        End If
    End Sub

    Private Sub dtiBirthdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtiBirthdate.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtiMembershipDate.Focus()
        End If
    End Sub

    Private Sub dtiMembershipDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            dtiExpiry.Focus()
        End If
    End Sub

    Private Sub dtiExpiry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtiExpiry.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Function LoadMember() As Boolean
        Dim iErrorCode As Integer = 0
        dt = oSQLMember.GetAllMemberInfoAndCardDetails(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Return False
        End If

        With dgvMember
            .DataSource = dt
            .Focus()
            If .RowCount > 0 Then
                btnEdit.Enabled = True
                btnRemove.Enabled = True
                btnOverrideCredits.Enabled = True
                .CurrentCell.Selected = False
                If iRow >= .RowCount Then iRow = .RowCount - 1
                .Rows(iRow).Selected = True
                .CurrentCell = .SelectedCells(1)
            Else
                btnEdit.Enabled = False
                btnRemove.Enabled = False
                btnOverrideCredits.Enabled = False
            End If
        End With
        Return True
    End Function

    Friend Sub ClearCtrl(Optional ByVal edit As Boolean = False)
        If edit = False Then
            pbImage.Image = Nothing
            tbMemberID.Text = ""
            tbMemberID.Focus()
        Else
            tbLName.Focus()
        End If
        tbLName.Text = ""
        tbFName.Text = ""
        tbMName.Text = ""
        tbCardID.Text = ""
        tbAddress.Text = ""
        tbContactNo.Text = ""
        tbEmail.Text = ""
        'tbPoints.Text = ""
        dtiBirthdate.Text = dtiBirthdate.MinDate
        dtiMembershipDate.Text = ""
        dtiExpiry.Text = dtiExpiry.MinDate
        txtAMA.Clear()
        txtCredit.Clear()
        txtCompanyCode.Clear()
        chkActive.Checked = True
    End Sub

    Private Sub btnNav(Optional ByVal bCID As Boolean = False, _
        Optional ByVal bAdd As Boolean = True, Optional ByVal bSave As Boolean = True)
        tbMemberID.ReadOnly = bCID
        pnlAdd.Enabled = bAdd
        pnlSave.Enabled = bSave
    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnNav(, 0, )
        ClearCtrl()
        bIsNew = True
        iRow = dgvMember.Rows.Count
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        bIsNew = False
        btnNav(1, 0, )
        tbMemberID.Focus()
        iRow = dgvMember.CurrentCell.RowIndex
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim iErrorCode As Integer = 0

        If MsgBox("Are you sure you want to delete " & dgvMember.SelectedRows.Count.ToString() & " item(s)", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If dgvMember.SelectedRows.Count = 1 Then
                oMember.sMemberID = dgvMember.CurrentRow.Cells("colMemberID").Value
                iRow = IIf(dgvMember.CurrentCell.RowIndex > 0, dgvMember.CurrentCell.RowIndex - 1, 0)
                If oSQLMember.DeleteMemberAndBalance(oMember) <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                'added by DPD, 01.24.2012
                'btnClear_Click(sender, e)
                ClearCtrl(False)

            ElseIf dgvMember.SelectedRows.Count > 1 Then
                'For multiple deletions
                For Each dgr As DataGridViewRow In dgvMember.SelectedRows
                    oMember.sMemberID = dgr.Cells("colMemberID").Value

                    If oSQLMember.DeleteMemberAndBalance(oMember) <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    iRow = IIf(dgvMember.CurrentCell.RowIndex > 0, dgvMember.CurrentCell.RowIndex - 1, 0)
                Next
                ClearCtrl()
            End If

            LoadMember()
            dgvMember_SelectionChanged(sender, e)

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oAR As New AR_Entity
        Dim oCA As New CA_Entity
        Dim iErrorCode As Integer = 0

        If tbMemberID.Text = "" And tbMemberID.ReadOnly = False Then
            oCommon.ErrorBox("Member ID cannot be empty!")
            tbMemberID.Focus()
        ElseIf tbLName.Text = "" Then
            oCommon.ErrorBox("Last Name cannot be empty!")
            tbLName.Focus()
        ElseIf tbFName.Text = "" Then
            oCommon.ErrorBox("First Name cannot be empty!")
            tbFName.Focus()
            'ElseIf dtiExpiry.Text = "" Then
            '    oClsCtrl.ErrorBox("Expiry date cannot be empty!")
            '    dtiExpiry.Focus()
        Else
            oMember.sMemberID = tbMemberID.Text

            If oSQLMember.CheckMember(oMember, iErrorCode) = True And tbMemberID.ReadOnly = False Then
                oCommon.ErrorBox("Member ID already exists.")
                tbMemberID.Focus()
            Else
                If iErrorCode <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                With oMember
                    .sCardID = tbCardID.Text
                    .sLName = tbLName.Text
                    .sFName = tbFName.Text
                    .sMName = tbMName.Text
                    .sAddress = tbAddress.Text
                    .sContactNo = tbContactNo.Text
                    .sEmail = tbEmail.Text
                    .dBirthdate = dtiBirthdate.Value.ToString("MM/dd/yyyy")
                    .dLExpiry = dtiExpiry.Value.ToString("MM/dd/yyyy")
                    .sLoyaltyCode = cboLoyaltyCode.Text
                    .sCompanyCode = txtCompanyCode.Text
                    If pbImage.Image IsNot Nothing Then
                        .bytPhoto = oCommon.ImageToByte(pbImage.Image)
                    End If
                    .bActive = chkActive.Checked
                End With

                With oCard
                    .sMemberID = tbMemberID.Text
                    .sCardID = tbCardID.Text
                    '.iPoints = CInt(Val(tbPoints.Text))
                End With

                oAR.dARAmount = Val(txtCredit.Text.Trim())
                oCA.dCAAmount = Val(txtAMA.Text.Trim())

                If bIsNew Then
                    If oSQLMember.IsUIDExist(oCard.sCardID) Then
                        oCommon.ShowBox("Card ID already used.")
                        Exit Sub
                    Else
                        oMember.dMembershipDate = Date.Now.ToShortDateString
                        oMember.sAddedBy = Program.sUserName
                        'oSQLMember.AddMember(oMember)

                        If oSQLMember.AddMemberWithBalance(oMember, oAR, oCA) <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            Exit Sub
                        Else
                            oCommon.ShowBox("Member Added.")
                        End If
                        'oSQLCard.AddCardDetail(oCard)
                    End If
                Else
                    If Not oSQLMember.IsUIDFree(oCard.sCardID, oMember.sMemberID) Then
                        oCommon.ShowBox("Card ID already used.")
                        Exit Sub
                    Else
                        oMember.dMembershipDate = Date.Now.ToShortDateString 'dtiMembershipDate.Text
                        oMember.sUpdatedBy = Program.sUserName
                        'oSQLMember.EditMember(oMember)

                        If oSQLMember.EditMemberWithBalance(oMember, oAR, oCA) <> 0 Then
                            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                            Exit Sub
                        Else
                            oCommon.ShowBox("Member Updated.")
                        End If
                        'oSQLCard.EditCardDetailByMemberID(oCard)

                    End If
                End If

                ClearCtrl()
                btnNav(1, , 0)
                LoadMember()
                dgvMember_SelectionChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If tbMemberID.ReadOnly = True Then
            ClearCtrl(1)
        Else
            ClearCtrl()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnNav(1, , 0)
        dgvMember_SelectionChanged(sender, e)
    End Sub

    Private Sub dgvMember_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMember.SelectionChanged
        Dim dtemp As Date = Nothing
        Dim iErrorCode As Integer = 0

        If dgvMember.SelectedRows.Count > 0 And dgvMember.RowCount > 0 Then
            'tbMemberID.Text = dgvMember.SelectedCells(0).Value
            tbMemberID.Text = dgvMember.SelectedCells(1).Value
            oMember.sMemberID = tbMemberID.Text
            Dim dtMember As DataTable = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)

            If iErrorCode <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If

            tbFName.Text = dtMember.Rows(0)("FName")
            tbLName.Text = dtMember.Rows(0)("LName")
            tbMName.Text = dtMember.Rows(0)("MName").ToString()
            tbAddress.Text = dtMember.Rows(0)("Address").ToString()
            tbContactNo.Text = dtMember.Rows(0)("ContactNo").ToString()
            tbEmail.Text = dtMember.Rows(0)("Email").ToString()
            dtiBirthdate.Value = IIf(dtMember.Rows(0)("Birthdate") Is System.DBNull.Value, Nothing, dtMember.Rows(0)("Birthdate"))
            dtemp = IIf(dtMember.Rows(0)("MembershipDate") Is System.DBNull.Value, Nothing, dtMember.Rows(0)("MembershipDate"))
            dtiMembershipDate.Text = dtemp.ToString("MM/dd/yyyy")
            dtiExpiry.Text = IIf(dtMember.Rows(0)("Expiry") Is System.DBNull.Value, Nothing, dtMember.Rows(0)("Expiry"))
            If dtMember.Rows(0)("CardID") IsNot DBNull.Value Then
                tbCardID.Text = dtMember.Rows(0)("CardID")
            Else
                tbCardID.Text = ""
            End If
            If dtMember.Rows(0)("Active") Then
                chkActive.Checked = True
            Else
                chkActive.Checked = False
            End If

            'tbPoints.Text = IIf(dtMember.Rows(0)("Points") Is System.DBNull.Value, "", dtMember.Rows(0)("Points"))

            'Dim oRewards As New Rewards_Entity
            'oRewards.sMemberID = oMember.sMemberID
            'tbPoints.Text = oSQLRewards.GetCurrentRewardsByMemberID(oRewards)

            cboLoyaltyCode.SelectedValue = dtMember.Rows(0)("LoyaltyCode").ToString()

            txtCompanyCode.Text = dtMember.Rows(0)("CompanyCode").ToString()

            txtAMA.Text = dtMember.Rows(0)("AMABalance")
            txtCredit.Text = dtMember.Rows(0)("SDBalance")

            'Run

            'If Not bwGetPhoto.IsBusy = True Then
            '    If bwGetPhoto.WorkerSupportsCancellation = True Then
            '        bwGetPhoto.CancelAsync()
            '    End If
            While bwGetPhoto.IsBusy
                Application.DoEvents()
            End While
            bwGetPhoto.RunWorkerAsync()
            'End If

            'Cancel
            'If bwGetPhoto.WorkerSupportsCancellation = True Then
            '    bwGetPhoto.CancelAsync()
            'End If
        End If
    End Sub

    Private Sub frmMemberManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmMemberManager = Nothing
    End Sub
#Region "Backup"
    'Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnSave.Click
    '    'LOCAL VARIABLES
    '    Dim sDevice_LVAR As String = ""
    '    Dim iResult As Integer
    '    Dim bError As Boolean = False
    '    Dim sEncText_LVAR As New System.Text.UTF8Encoding()
    '    Dim bytText_LVAR() As Byte
    '    Dim sSendStr As String = ""

    '    'Validations
    '    If Trim(tbEmpID.Text) = "" Then
    '        oClsCtrl.ErrorBox("Employee ID cannot be empty.")
    '        tbEmpID.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbLastName.Text) = "" Then
    '        oClsCtrl.ErrorBox("Last Name of Employee cannot be empty.")
    '        tbLastName.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbFirstName.Text) = "" Then
    '        oClsCtrl.ErrorBox("First Name of Employee cannot be empty.")
    '        tbFirstName.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbMidName.Text) = "" Then
    '        oClsCtrl.ErrorBox("Middle Name of Employee cannot be empty.")
    '        tbMidName.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbPosition.Text) = "" Then
    '        oClsCtrl.ErrorBox("Position of Employee cannot be empty.")
    '        tbPosition.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbContactNo.Text) = "" Then
    '        oClsCtrl.ErrorBox("Contact Number of Employee cannot be empty.")
    '        tbContactNo.Focus()
    '        Exit Sub
    '    ElseIf Trim(tbEmailAdd.Text) = "" Then
    '        oClsCtrl.ErrorBox("Email Address of Employee cannot be empty.")
    '        tbEmailAdd.Focus()
    '        Exit Sub
    '    ElseIf oClsCtrl.CheckEmail(tbEmailAdd.Text) = False Then
    '        oClsCtrl.ErrorBox("Invalid format for email address.")
    '        tbEmailAdd.Focus()
    '        Exit Sub
    '    End If
    '    'Populate oMember object
    '    oMember.sEmpID = tbEmpID.Text
    '    oMember.sLName = tbLastName.Text
    '    oMember.sFName = tbFirstName.Text
    '    oMember.sMName = tbMidName.Text
    '    oMember.sPosition = tbPosition.Text
    '    oMember.sContactNo = tbContactNo.Text
    '    oMember.sEmail = tbEmailAdd.Text
    '    'Write data to card
    '    oClsCtrl.CritBox("Do not remove card")

    '    frmLogs.lboxLogs.Items.Add("Trying to write data to card")
    '    frmLogs.lboxLogs.Items.Add("")

    '    If bIsReaderAuthenticated = True Then
    '        Select Case Program.sCurrentDevice
    '            Case "PCR310U"
    '                'Card ID
    '                oMember.sCardID = tbCardID.Text
    '                'Employee ID
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sEmpID)
    '                iResult = WriteToCardViaPromagPCR310U(0, 1, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Employee ID)", oMember.sEmpID)
    '                Else
    '                    LogData("Write to Card Failed (Employee ID)", oMember.sEmpID)
    '                    bError = True
    '                End If
    '                'Last Name
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sLName)
    '                iResult = WriteToCardViaPromagPCR310U(1, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Last Name)", oMember.sLName)
    '                Else
    '                    LogData("Write to Card Failed (Last Name)", oMember.sLName)
    '                    bError = True
    '                End If
    '                'First Name
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sFName)
    '                iResult = WriteToCardViaPromagPCR310U(2, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (First Name)", oMember.sFName)
    '                Else
    '                    LogData("Write to Card Failed (First Name)", oMember.sFName)
    '                    bError = True
    '                End If
    '                'Middle Name
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sMName)
    '                iResult = WriteToCardViaPromagPCR310U(3, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Middle Name)", oMember.sMName)
    '                Else
    '                    LogData("Write to Card Failed (Middle Name)", oMember.sMName)
    '                    bError = True
    '                End If
    '                'Position
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sPosition)
    '                iResult = WriteToCardViaPromagPCR310U(4, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Position)", oMember.sPosition)
    '                Else
    '                    LogData("Write to Card Failed (Position)", oMember.sPosition)
    '                    bError = True
    '                End If
    '                'Contact Number
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sContactNo)
    '                iResult = WriteToCardViaPromagPCR310U(5, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Contact Number)", oMember.sContactNo)
    '                Else
    '                    LogData("Write to Card Failed (Contact Number)", oMember.sContactNo)
    '                    bError = True
    '                End If
    '                'Email Address
    '                bytText_LVAR = sEncText_LVAR.GetBytes(oMember.sEmail)
    '                iResult = WriteToCardViaPromagPCR310U(6, 0, bytText_LVAR)
    '                If iResult = 0 Then
    '                    LogData("Write to Card Success (Email Address)", oMember.sEmail)
    '                    frmLogs.lboxLogs.Items.Add("")
    '                    frmLogs.lboxLogs.Items.Add("")
    '                Else
    '                    LogData("Write to Card Failed (Email Address)", oMember.sEmail)
    '                    frmLogs.lboxLogs.Items.Add("")
    '                    frmLogs.lboxLogs.Items.Add("")
    '                    bError = True
    '                End If
    '                If bError = False Then
    '                    oClsCtrl.ShowBox("Operation completed successfully.")
    '                Else
    '                    oClsCtrl.ShowBox("Operation completed with error." & _
    '                                        vbCrLf & _
    '                                        "Please refer to the event logs.", "")
    '                End If
    '            Case "ACR122U", "AET62"

    '            Case "ACR38"
    '                Program.sAcsDeviceName = oACR38.GetDeviceName()
    '                If Program.sAcsDeviceName.Contains("CCID USB") Then
    '                    If oACR38.CardConnect(sAcsDeviceName) Then
    '                        If oACR38.MemoryConnect() Then
    '                            tbCardID.Text = oACR38.GetATR(sAcsDeviceName)
    '                            If tbCardID.Text <> "" Then
    '                                sSendStr = tbEmpID.Text & vbCrLf & tbLastName.Text & vbCrLf & tbFirstName.Text & vbCrLf & _
    '                                    tbMidName.Text & vbCrLf & tbPosition.Text & vbCrLf & tbContactNo.Text & vbCrLf & _
    '                                    tbEmailAdd.Text
    '                                If sSendStr.Length > 220 Then
    '                                    frmLogs.lboxLogs.Items.Add("Total text length must not exceed 220 characters.")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                    Exit Sub
    '                                End If
    '                                If oACR38.WriteMem(sSendStr, 20) Then
    '                                    LogData("Write to Card Success ", "")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                Else
    '                                    LogData("Something went wrong during writing to card ", "")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                    frmLogs.lboxLogs.Items.Add("")
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If

    '        End Select
    '    Else
    '        oClsCtrl.ErrorBox("Authentication not yet loaded")
    '        frmLogs.lboxLogs.Items.Add("Aunthentication not yet loaded")
    '        frmLogs.lboxLogs.Items.Add("")
    '        frmLogs.lboxLogs.Items.Add("")
    '    End If

    'End Sub
#End Region



    Private Sub btnSaveToCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim bError As Boolean
        Dim sErrString As String = ""

        With oMember
            .sLName = tbLName.Text
            .sFName = tbFName.Text
            .sMName = tbMName.Text
            .sCardID = tbCardID.Text
            .sAddress = tbAddress.Text
            .sContactNo = tbContactNo.Text
            .sEmail = tbEmail.Text
            .dBirthdate = dtiBirthdate.Value.ToString("MM/dd/yyyy")
            .dLExpiry = dtiExpiry.Value.ToString("MM/dd/yyyy")
        End With


        Select Case Program.sCurrentDevice

            'Case "ACR122U"
            '    'Employee ID
            '    oACR122U.AuthenticateBlock(1, 0, 0)
            '    iResult = oACR122U.WriteBlock(1, oMember.sMemberID)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Employee ID)" & oMember.sMemberID & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Employee ID)" & oMember.sMemberID & vbCrLf
            '        bError = True
            '    End If
            '    'Last Name
            '    oACR122U.AuthenticateBlock(4, 0, 0)
            '    iResult = oACR122U.WriteBlock(4, oMember.sLName)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Last Name)" & oMember.sLName & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Last Name)" & oMember.sLName & vbCrLf
            '        bError = True
            '    End If
            '    'First Name
            '    oACR122U.AuthenticateBlock(8, 0, 0)
            '    iResult = oACR122U.WriteBlock(8, oMember.sFName)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (First Name)" & oMember.sFName & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (First Name)" & oMember.sFName & vbCrLf
            '    End If
            '    'Middle Name
            '    oACR122U.AuthenticateBlock(12, 0, 0)
            '    iResult = oACR122U.WriteBlock(12, oMember.sMName)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Middle Name)" & oMember.sMName & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Middle Name)" & oMember.sMName & vbCrLf
            '        bError = True
            '    End If
            '    'Position
            '    oACR122U.AuthenticateBlock(16, 0, 0)
            '    iResult = oACR122U.WriteBlock(16, oMember.sAddress)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Position)" & oMember.sAddress & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Position)" & oMember.sAddress & vbCrLf
            '        bError = True
            '    End If
            '    'Contact Number
            '    oACR122U.AuthenticateBlock(20, 0, 0)
            '    iResult = oACR122U.WriteBlock(20, oMember.sContactNo)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Contact Number)" & oMember.sContactNo & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Contact Number)" & oMember.sContactNo & vbCrLf
            '        bError = True
            '    End If
            '    'Email Address
            '    oACR122U.AuthenticateBlock(24, 0, 0)
            '    iResult = oACR122U.WriteBlock(24, oMember.sEmail)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Email Address)" & oMember.sEmail & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Email Address)" & oMember.sEmail & vbCrLf
            '        bError = True
            '    End If

            '    'Birthdate
            '    oACR122U.AuthenticateBlock(28, 0, 0)
            '    iResult = oACR122U.WriteBlock(28, oMember.dBirthdate)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Birthdate)" & oMember.dBirthdate & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Birthdate)" & oMember.dBirthdate & vbCrLf
            '        bError = True
            '    End If

            '    'Member Since
            '    oACR122U.AuthenticateBlock(32, 0, 0)
            '    iResult = oACR122U.WriteBlock(32, oMember.dMembershipDate)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Member Since)" & oMember.dMembershipDate & vbCrLf
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Member Since)" & oMember.dMembershipDate & vbCrLf
            '        bError = True
            '    End If

            '    'Member Expiry
            '    oACR122U.AuthenticateBlock(36, 0, 0)
            '    iResult = oACR122U.WriteBlock(36, oMember.dLExpiry)
            '    If iResult = 0 Then
            '        sErrString &= "Write to Card Success (Member Expiry)" & oMember.dLExpiry
            '    ElseIf iResult = -1 Then
            '        sErrString &= "Write to Card Failed (Member Expiry)" & oMember.dLExpiry
            '        bError = True
            '    End If
            '    If bError = False Then
            '        oClsCtrl.ShowBox(sErrString)
            '    Else
            '        oClsCtrl.ShowBox(sErrString, "")
            '    End If

        End Select
    End Sub


    Private Sub btnGetCardID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCardID.Click
        Dim iErrorCode As Integer = 0

        btnGetCardID.Enabled = False

        oReader.ConnectReader()
        oReader.ClearLCD()
        oReader.DisplayLCD("Please", False, 0, 1, 5)
        oReader.DisplayLCD("Tap Card", False, 0, 2, 4)

        While oReader.ConnectCard() <> 0
            Application.DoEvents()
        End While

        tbCardID.Text = oReader.GetCardID(iErrorCode)

        oReader.ConnectReader()
        oReader.ClearLCD()
        oReader.DisplayLCD("Please", False, 0, 1, 5)
        oReader.DisplayLCD("Remove Card", False, 0, 2, 3)
        While oReader.IsCardPresent
            Application.DoEvents()
        End While

        oReader.ConnectReader()
        oReader.ClearLCD()

        btnGetCardID.Enabled = True
    End Sub

    Private Function LoadLoyalty() As Boolean
        Dim iErrorCode As Integer = 0
        Dim dt As DataTable = oSQLLoyalty.GetAllLoyalty(iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Return False
        End If


        If Not dt Is Nothing Then
            dt.Rows.Add(0)
            If dt.Rows.Count > 0 Then
                cboLoyaltyCode.DataSource = dt
                cboLoyaltyCode.DisplayMember = "LoyaltyCode"
                cboLoyaltyCode.ValueMember = "LoyaltyCode"
            End If
            Return True
        End If
        Return False
    End Function

    Private Sub bwGetPhoto_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        'Dim worker As BackgroundWorker = CType(sender, BackgroundWorker) '<- What the?
        Dim bytImage As Byte()

        'For i As Integer = 1 To 10
        If bwGetPhoto.CancellationPending = True Then
            e.Cancel = True
            bytImage = oSQLMember.GetPhotoByMemberID(oMember)
            If bytImage Is Nothing Then
                pbImage.Image = Nothing
            Else
                pbImage.Image = oCommon.ByteToImage(bytImage)
            End If
            'Exit For
        Else
            ' Perform a time consuming operation and report progress.
            bytImage = oSQLMember.GetPhotoByMemberID(oMember)
            If bytImage Is Nothing Then
                pbImage.Image = Nothing
            Else
                pbImage.Image = oCommon.ByteToImage(bytImage)
            End If
            'System.Threading.Thread.Sleep(500)
            'bwGetPhoto.ReportProgress(i * 10)
        End If
        'Next
    End Sub

    Private Sub bwGetPhoto_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        'Me.tbProgress.Text = e.ProgressPercentage.ToString() & "%"
    End Sub

    Private Sub bwGetPhoto_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            'Me.tbProgress.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            'Me.tbProgress.Text = "Error: " & e.Error.Message
        Else
            'Me.tbProgress.Text = "Done!"
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()

        fdlg.Title = "Browse for Picture"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Image Files (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.png"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbImage.Image = Image.FromFile(fdlg.FileName)
        End If
    End Sub

    Private Sub btnRemovePhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePhoto.Click
        pbImage.Image = Nothing
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearchKey.Text.Trim() <> "" Then
            If cboSearchBy.Text = "Employee ID" Then
                For Each dgr As DataGridViewRow In dgvMember.Rows
                    If dgr.Cells("colMemberID").Value = txtSearchKey.Text.Trim() Then
                        dgvMember.CurrentCell = dgr.Cells("colMemberID")
                        Exit Sub
                    End If
                Next
                MsgBox("Search reached the end of records.", MsgBoxStyle.Information)
            ElseIf cboSearchBy.Text = "FullName" Then
                Dim iCount As Integer = 0
                For Each dgr As DataGridViewRow In dgvMember.Rows
                    If dgr.Cells("colFullName").Value.ToString().ToLower().Contains(txtSearchKey.Text.Trim().ToLower()) Then
                        If iCount > iSearchIndex Then
                            dgvMember.CurrentCell = dgr.Cells("colFullName")
                            iSearchIndex = iCount
                            Exit Sub
                        End If
                    End If
                    iCount += 1
                Next
                If iCount = dgvMember.Rows.Count Then
                    iSearchIndex = 0
                    MsgBox("Search reached the end of records.", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnOverrideCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverrideCredits.Click
        Dim ofrmOverrideCredits As New frmOverrideCredits
        ofrmOverrideCredits.sMemberID = tbMemberID.Text.Trim()
        btnOverrideCredits.Enabled = False
        ofrmOverrideCredits.ShowDialog()
        ofrmOverrideCredits = Nothing
        btnOverrideCredits.Enabled = True
    End Sub
End Class