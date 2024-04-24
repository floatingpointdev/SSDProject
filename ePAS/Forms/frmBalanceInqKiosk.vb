Public Class frmBalanceInqKiosk
    Private sOpMode As String = ""
    Private sOldCardID As String = ""
    Private oMember As New Member_Entity
    Private dtLogs As DataTable = Nothing

    Private Sub frmBalanceInqKiosk_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Static Dim strStream As String = ""
        Dim dtMember As New DataTable
        Dim dtCA As New DataTable
        Dim dtAR As New DataTable
        Dim iErrorCode As Integer = 0
        Dim oCA As New CA_Entity
        Dim oAR As New AR_Entity
        Dim dCAConsumable As Double = 0.0
        Dim dAR As Double = 0.0


        'NOTE:  PCR330M issues a NumLock key then the Card ID number sequence and an CR/LF key at the end

        Select Case e.KeyCode
            Case Keys.NumPad0
                strStream += "0"
            Case Keys.NumPad1
                strStream += "1"
            Case Keys.NumPad2
                strStream += "2"
            Case Keys.NumPad3
                strStream += "3"
            Case Keys.NumPad4
                strStream += "4"
            Case Keys.NumPad5
                strStream += "5"
            Case Keys.NumPad6
                strStream += "6"
            Case Keys.NumPad7
                strStream += "7"
            Case Keys.NumPad8
                strStream += "8"
            Case Keys.NumPad9
                strStream += "9"
            Case Keys.Enter
                oMember.sCardID = strStream
                strStream = ""
                dtMember = oSQLMember.GetMemberByCardID(oMember, iErrorCode)
                If iErrorCode <> 0 Then
                    ServerOffline()
                    Exit Sub
                End If
                If Not dtMember Is Nothing Then
                    If dtMember.Rows.Count > 0 Then

                        txtCIMNo.Clear()
                        txtName.Clear()
                        txtCA.Clear()
                        txtSalaryDeduction.Clear()
                        pbStatus.Text = "Service Running"
                        dgvLogs.DataSource = Nothing

                        txtCIMNo.Text = dtMember.Rows(0)("MemberID").ToString()

                        'Member info
                        oMember.sFName = dtMember.Rows(0)("FName").ToString()
                        oMember.sLName = dtMember.Rows(0)("LName").ToString()
                        oMember.sMemberID = dtMember.Rows(0)("MemberID").ToString()
                        oMember.sAddress = dtMember.Rows(0)("Address").ToString()

                        'CA info
                        oCA.sMemberID = oMember.sMemberID

                        'AR info
                        oAR.sMemberID = oMember.sMemberID

                        'Check if CA is uploaded
                        dtCA = oSQLCA.GetCAByMemberID(oCA, iErrorCode)
                        If iErrorCode <> 0 Then
                            ServerOffline()
                            Exit Sub
                        End If
                        If dtCA.Rows.Count > 0 Then
                            dCAConsumable = CDbl(dtCA.Rows(0)("CAConsumable"))
                        Else
                            dCAConsumable = 0
                        End If

                        'Also check the AR
                        dtAR = oSQLAR.GetARByMemberID(oAR, iErrorCode)
                        If iErrorCode <> 0 Then
                            ServerOffline()
                            Exit Sub
                        End If
                        If dtAR.Rows.Count > 0 Then
                            dAR = Val(dtAR.Rows(0)("ARConsumable").ToString())
                        Else
                            dAR = 0
                        End If

                        'Get Transactions
                        dgvLogs.AutoGenerateColumns = False
                        dtLogs = oSQLLogs.GetCACreditLogsByCardID(oMember.sCardID)

                        txtCIMNo.Text = oMember.sMemberID
                        txtName.Text = oMember.sLName & ", " & oMember.sFName
                        txtCA.Text = dCAConsumable.ToString("#,##0.00")
                        txtSalaryDeduction.Text = dAR.ToString("#,###0.00")

                        If Not dtLogs Is Nothing Then
                            dgvLogs.DataSource = dtLogs
                        End If
                    Else
                        'If Member not found
                        txtCIMNo.Text = oMember.sCardID
                        txtName.Clear()
                        txtCA.Clear()
                        txtSalaryDeduction.Clear()
                        dgvLogs.DataSource = Nothing
                        pbStatus.Text = "Unregistered Card"
                    End If
                Else
                    'If Member not found
                    txtCIMNo.Text = oMember.sCardID
                    txtName.Clear()
                    txtCA.Clear()
                    txtSalaryDeduction.Clear()
                    dgvLogs.DataSource = Nothing
                    pbStatus.Text = "Unregistered Card."
                End If
            Case Else

        End Select

    End Sub

    Private Sub frmBalanceInqKiosk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
        oReader.DisplayLCDCentered("Please", False, 4, 3)
        oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        oReader.BuzzerControl(1)
        tmrReader.Enabled = True
    End Sub


    Private Sub tmrReader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReader.Tick
        Dim iErrorCode As Integer = 0
        Dim oCA As New CA_Entity
        Dim oCALog As New CALog_Entity
        Dim oAR As New AR_Entity
        Dim oARLog As New ARLog_Entity
        Dim sLog As String = ""
        Dim dtMember As DataTable = Nothing
        Dim dtCA As DataTable = Nothing
        Dim dtAR As DataTable = Nothing
        Dim dCAConsumable As Double = 0.0
        Dim dAR As Double = 0.0
        Dim sStatusMsg As String = ""


        'Detect Card presence
        tmrReader.Enabled = False

        If oReader.ConnectCard() = 0 Then
            oReader.LoadAuthentication()
            oMember.sCardID = oReader.GetCardID(iErrorCode)

            If oMember.sCardID <> "" Then
                If sOldCardID <> oMember.sCardID Then
                    oReader.ClearLCD()
                    pbStatus.Text = "Please wait..."
                    Application.DoEvents()
                    dtMember = oSQLMember.GetMemberByCardID(oMember, iErrorCode)
                    If iErrorCode <> 0 Then
                        ServerOffline()
                        If ofrmBalanceInqKiosk Is Nothing Then Exit Sub
                        GoTo Skip0
                    End If

                    If dtMember.Rows.Count > 0 Then
                        'Member info
                        oMember.sFName = dtMember.Rows(0)("FName").ToString()
                        oMember.sLName = dtMember.Rows(0)("LName").ToString()
                        oMember.sMemberID = dtMember.Rows(0)("MemberID").ToString()
                        oMember.sAddress = dtMember.Rows(0)("Address").ToString()

                        'CA info
                        oCA.sMemberID = oMember.sMemberID

                        'AR info
                        oAR.sMemberID = oMember.sMemberID

                        'Check if CA is uploaded
                        'dtCA = oSQLCA.GetCAByMemberIDByYear(oCA, Now.Year)
                        dtCA = oSQLCA.GetCAByMemberID(oCA, iErrorCode)
                        If iErrorCode <> 0 Then
                            ServerOffline()
                            GoTo skip0
                        End If
                        If dtCA.Rows.Count > 0 Then
                            dCAConsumable = CDbl(dtCA.Rows(0)("CAConsumable"))
                        Else
                            dCAConsumable = 0
                        End If

                        'Also check the AR
                        'dtAR = oSQLAR.GetARLogSumByMemberID(oAR)
                        dtAR = oSQLAR.GetARByMemberID(oAR, iErrorCode)
                        If iErrorCode <> 0 Then
                            ServerOffline()
                            GoTo Skip0
                        End If
                        If dtAR.Rows.Count > 0 Then
                            dAR = Val(dtAR.Rows(0)("ARConsumable").ToString())
                        Else
                            dAR = 0
                        End If

                        'Get Transactions
                        dgvLogs.AutoGenerateColumns = False
                        dtLogs = oSQLLogs.GetCACreditLogsByCardID(oMember.sCardID)

                        txtCIMNo.Text = oMember.sMemberID
                        txtName.Text = oMember.sLName & ", " & oMember.sFName
                        txtCA.Text = dCAConsumable.ToString("#,##0.00")
                        txtSalaryDeduction.Text = dAR.ToString("#,###0.00") '(Program.iSDMax - dAR).ToString("#,###0.00")

                        If Not dtLogs Is Nothing Then
                            dgvLogs.DataSource = dtLogs
                        End If
                        pbStatus.Text = "Please remove card."

                        oReader.ClearLCD()
                        oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                        oReader.DisplayLCDCentered("Card", False, 4, 4)
                        oReader.BuzzerControl(1)

                    Else
                        'If Member not found
                        pbStatus.Text = "Unregistered Card.  Please remove card."
                        oReader.DisplayLCDCentered("Unregistered", False, 4, 2)
                        oReader.DisplayLCDCentered("card", False, 4, 3)
                        oReader.BuzzerControl(5)
                    End If
                    sOldCardID = oMember.sCardID
                End If
            End If
        Else
            If sOldCardID <> "" Then
Skip0:
                sOldCardID = ""
                oReader.ClearLCD()
                txtCIMNo.Clear()
                txtName.Clear()
                txtCA.Clear()
                txtSalaryDeduction.Clear()
                pbStatus.Text = "Service Running"
                dgvLogs.DataSource = Nothing

                oReader.ClearLCD()
                oReader.DisplayLCDCentered("Welcome", False, 0, 1)
            End If
        End If
        tmrReader.Enabled = True
    End Sub

    Private Sub frmBalanceInqKiosk_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("Welcome", False, 0, 1)
        tmrReader.Enabled = False
        tmrReader.Stop()
        ofrmBalanceInqKiosk = Nothing
    End Sub

    Private Sub txtCIMNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCIMNo.KeyPress
        Dim dtMember As New DataTable
        Dim dtCA As New DataTable
        Dim dtAR As New DataTable

        Dim oCA As New CA_Entity
        Dim oAR As New AR_Entity

        Dim dCAConsumable As Double = 0.0
        Dim dAR As Double = 0.0

        Dim iErrorCode As Integer = 0

        If e.KeyChar = Chr(13) Then
            If txtCIMNo.Text.Trim() <> "" Then
                oMember.sMemberID = txtCIMNo.Text.Trim()
                dtMember = oSQLMember.GetMemberByMemberID(oMember, iErrorCode)

                If iErrorCode <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If dtMember.Rows.Count > 0 Then
                    'Member info
                    oMember.sFName = dtMember.Rows(0)("FName").ToString()
                    oMember.sLName = dtMember.Rows(0)("LName").ToString()
                    oMember.sMemberID = dtMember.Rows(0)("MemberID").ToString()
                    oMember.sAddress = dtMember.Rows(0)("Address").ToString()
                    oMember.sCardID = dtMember.Rows(0)("CardID").ToString()

                    'CA info
                    oCA.sMemberID = oMember.sMemberID

                    'AR info
                    oAR.sMemberID = oMember.sMemberID

                    'Check if CA is uploaded
                    'dtCA = oSQLCA.GetCAByMemberIDByYear(oCA, Now.Year)
                    dtCA = oSQLCA.GetCAByMemberID(oCA, iErrorCode)
                    If iErrorCode <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    If dtCA.Rows.Count > 0 Then
                        dCAConsumable = CDbl(dtCA.Rows(0)("CAConsumable"))
                    Else
                        dCAConsumable = 0
                    End If

                    'Also check the AR
                    'dtAR = oSQLAR.GetARLogSumByMemberID(oAR)
                    dtAR = oSQLAR.GetARByMemberID(oAR, iErrorCode)
                    If iErrorCode <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    If dtAR.Rows.Count > 0 Then
                        dAR = Val(dtAR.Rows(0)("ARConsumable").ToString())
                    Else
                        dAR = 0
                    End If

                    'Get Transactions
                    dgvLogs.AutoGenerateColumns = False
                    dtLogs = oSQLLogs.GetCACreditLogsByMemberID(oMember.sMemberID)

                    txtCIMNo.Text = oMember.sMemberID
                    txtName.Text = oMember.sLName & ", " & oMember.sFName
                    txtCA.Text = dCAConsumable.ToString("#,##0.00")
                    txtSalaryDeduction.Text = dAR.ToString("#,###0.00")


                    If Not dtLogs Is Nothing Then
                        dgvLogs.DataSource = dtLogs
                    End If
                Else
                    txtCIMNo.Clear()
                    txtName.Clear()
                    txtCA.Clear()
                    txtSalaryDeduction.Clear()


                    dgvLogs.DataSource = Nothing
                    MsgBox("Member ID not found.")
                End If
            End If
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ofrmReportViewer = New frmReportViewer
        ofrmReportViewer.sReport = "IndividualTransactionLogs"
        ofrmReportViewer.sCardID = oMember.sCardID
        ofrmReportViewer.Show()
    End Sub


    Private Sub ServerOffline()
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("OFFLINE", True, 4, 1)
        oReader.DisplayLCDCentered("Please Try Again", False, 4, 2)
        oReader.DisplayLCDCentered("Later", False, 4, 3)
        oReader.BuzzerControl(5)
        pbStatus.Text = "Server is OFFLINE. Please try again later."
        Do While oReader.ConnectCard() = 0
            If ofrmBalanceInqKiosk Is Nothing Then Exit Do
            Application.DoEvents()
        Loop
        pbStatus.Text = "Service Running"
        'If Not ofrmBalanceInqKiosk Is Nothing Then tmrReader.Enabled = True
    End Sub

End Class