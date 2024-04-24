Imports System.Configuration
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class frmService

    Private sStatus As String = ""
    Private sOldCardID As String = ""
    Private iElapsed As Integer = 0
    Private sOpMode As String = ""
    Private oPrinter As New Printer
    Private pFont As New Font("Courier New", 8.25)

    Private oMember As New Member_Entity

    Private bEnableCharge As Boolean = False

    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Private oSerialPort As New SerialPort_Worker

    Private oConfirmTrans As New frmConfirmTrans

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, _
            btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, _
            btn9.Click, btnPeriod.Click, _
            btnC.Click, btnCE.Click


        Dim sInput As String = ""
        Dim sSplit As String()

        'Static dblAmount As Double
        Static hasPeriod As Boolean

        'If hasPeriod = False Then
        '    dblAmount = Val(txtAmount.Text.Replace(",", ""))
        'End If

        txtAmount.Text = txtAmount.Text.Replace(",", "")

        If hasPeriod = False And Val(txtAmount.Text) = 0 Then
            sInput = ""
        Else
            sInput = txtAmount.Text
        End If


        sSplit = sInput.Split(".")


        Select Case sender.Name
            Case "btn0", "btn1", "btn2", _
            "btn3", "btn4", "btn5", _
            "btn6", "btn7", "btn8", "btn9"
                If sSplit.Length = 2 Then
                    If sSplit(1).Length >= 2 Then
                        GoTo Skip0
                    End If
                End If

        End Select

        Select Case sender.Name
            Case "btn0" : sInput += "0"
            Case "btn1" : sInput += "1"
            Case "btn2" : sInput += "2"
            Case "btn3" : sInput += "3"
            Case "btn4" : sInput += "4"
            Case "btn5" : sInput += "5"
            Case "btn6" : sInput += "6"
            Case "btn7" : sInput += "7"
            Case "btn8" : sInput += "8"
            Case "btn9" : sInput += "9"
            Case "btnPeriod"
                sInput += IIf(hasPeriod, "", ".")
                hasPeriod = True
            Case "btnC"
                sInput = "0."
                hasPeriod = False
            Case "btnCE"
                If sInput.Length > 0 Then
                    If sInput.Substring(sInput.Length - 1, 1) = "." Then
                        hasPeriod = False
                    End If
                    sInput = sInput.Substring(0, sInput.Length - 1)
                End If
            Case "btnEnter"
                sInput = "0"
                hasPeriod = False
        End Select

        'dblAmount = Val(sInput)
Skip0:
        txtAmount.Text = sInput
        txtDoubleAmount.Value = Val(sInput)
    End Sub

    Private Sub tmrService_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrService.Tick
        lblDate.Text = Now.ToShortDateString() + " " + Now.ToShortTimeString()

        txtStatus.Text = sMarquee(sStatus)
        sStatus = txtStatus.Text
    End Sub

    Private Sub tmrReader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReader.Tick
        Dim iErrorCode As Integer = 0
        Dim oCA As New CA_Entity
        Dim oCALog As New CALog_Entity
        Dim oPrintLog As New PrintLog_Entity
        Dim oAR As New AR_Entity
        Dim oARLog As New ARLog_Entity

        Dim sLog As String = ""
        Dim dtMember As DataTable = Nothing
        Dim dtCA As DataTable = Nothing
        Dim dtCALog As DataTable = Nothing
        Dim dtAR As DataTable = Nothing
        Dim dtARLog As DataTable = Nothing
        Dim dCAConsumable As Double = 0.0
        Dim dPayAmount As Double = 0.0
        Dim dAR As Double = 0.0

        Dim sTransCode As String = Format(Int(StripOff(Now.ToString("yyMMddhhmmss"))), "000000000000")
        'Dim sReceiptHeader As String = "Southstar Drug" & vbCrLf & "TapCard Receipt" & vbCrLf & vbCrLf
        Dim iCARefID As Integer = 0
        Dim iARRefID As Integer = 0        

        'Detect Card presence
        tmrReader.Enabled = False

        If oReader.ConnectCard() = 0 Then
            oReader.LoadAuthentication()
            oMember.sCardID = oReader.GetCardID(iErrorCode)

            If oMember.sCardID <> "" Then
                If sOldCardID <> oMember.sCardID Then
                    tmrVAT.Enabled = False
                    lblVAT.Visible = False
                    oReader.ClearLCD()

                    grpInput.Enabled = False
                    Me.Cursor = Cursors.WaitCursor
                    tmrService.Enabled = False
                    txtStatus.Text = "Please wait..."
                    Application.DoEvents()

                    dtMember = oSQLMember.GetMemberByCardID(oMember, iErrorCode)

                    tmrService.Enabled = True
                    grpInput.Enabled = True
                    Me.Cursor = Cursors.Default

                    If iErrorCode <> 0 Then
                        ServerOffLine()
                        GoTo Skip0
                    Else
                        If dtMember.Rows.Count > 0 Then
                            'Member info
                            oMember.sFName = dtMember.Rows(0)("FullName").ToString()
                            oMember.sMemberID = dtMember.Rows(0)("MemberID").ToString()
                            oMember.sAddress = dtMember.Rows(0)("Address").ToString()
                            oMember.sCompanyCode = dtMember.Rows(0)("CompanyCode").ToString()
                            oMember.bActive = dtMember.Rows(0)("Active").ToString()

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
                                iCARefID = dtCA.Rows(0)("ID")
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
                                iARRefID = dtAR.Rows(0)("ID")
                            Else
                                dAR = 0
                            End If

                            dPayAmount = Val(txtAmount.Text.Replace(",", ""))

                            If oMember.bActive Then

                                If sOpMode = "CAPayMode" Then
                                    If dtCA.Rows.Count > 0 Then
                                        'Check CA amount
                                        If dCAConsumable > Program.iCAMin Then
                                            If dCAConsumable >= dPayAmount Then
                                                ProcessCA(oCA, oCALog, dCAConsumable, dPayAmount, iErrorCode, _
                                                          sTransCode, iCARefID, _
                                                          dtCALog, _
                                                          sLog, oPrintLog)
                                            Else
                                                sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                                sLog += "Payment Transaction" & vbCrLf & vbCrLf
                                                sLog += "Cashier             : " & Program.sUserName & vbCrLf
                                                sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                                sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                                sLog += "Name                : " & oMember.sFName & vbCrLf
                                                sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                                sLog += vbCrLf
                                                sLog += "Amount Charge       : " & dPayAmount.ToString("#,##0.00") & vbCrLf
                                                sLog += "CA Balance          : " & dCAConsumable.ToString("#,##0.00") & vbCrLf & vbCrLf

                                                sLog += "Insufficient Balance" & vbCrLf
                                                LogActivity(sLog)

                                                oReader.ClearLCD()
                                                oReader.DisplayLCDCentered("Insufficient", True, 4, 1)
                                                oReader.DisplayLCDCentered("Balance", True, 4, 2)
                                                oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                                oReader.DisplayLCDCentered("Card", False, 4, 4)
                                                oReader.BuzzerControl(5)
                                                MsgBox("Insufficient Balance", MsgBoxStyle.Information)

                                                ResetCA()
                                            End If
                                        Else
                                            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                            sLog += "Payment Transaction" & vbCrLf & vbCrLf
                                            sLog += "Cashier             : " & Program.sUserName & vbCrLf
                                            sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                            sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                            sLog += "Name                : " & oMember.sFName & vbCrLf
                                            sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                            sLog += vbCrLf
                                            sLog += "Amount Charge       : " & dPayAmount.ToString("#,##0.00") & vbCrLf
                                            sLog += "CA Balance          : " & dCAConsumable.ToString("#,##0.00") & vbCrLf & vbCrLf
                                            sLog += "Remaing AR Credit    : " & dAR.ToString("#,##0.00") & vbCrLf
                                            sLog += "Insufficient Balance" & vbCrLf
                                            LogActivity(sLog)

                                            oReader.ClearLCD()
                                            oReader.DisplayLCDCentered("Insufficient", True, 4, 1)
                                            oReader.DisplayLCDCentered("Balance", True, 4, 2)
                                            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                            oReader.DisplayLCDCentered("Card", False, 4, 4)
                                            oReader.BuzzerControl(5)
                                            MsgBox("Insufficient Balance", MsgBoxStyle.Information)

                                            ResetCA()
                                        End If
                                    Else
                                        sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                        sLog += "Member Details" & vbCrLf & vbCrLf
                                        sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                        sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                        sLog += "Name                : " & oMember.sFName & vbCrLf
                                        sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                        sLog += vbCrLf
                                        sLog += "Member is not eligible for CA"
                                        LogActivity(sLog)

                                        oReader.DisplayLCDCentered("Card", False, 4, 2)
                                        oReader.DisplayLCDCentered("not eligible", False, 4, 3)
                                        oReader.BuzzerControl(5)
                                    End If

                                    '===================================SALARY PAY MODE=================================
                                ElseIf sOpMode = "SalaryPayMode" Then
                                    If dtAR.Rows.Count > 0 Then
                                        'Check AR amount

                                        If dAR > Program.iCAMin Then 'TODO: 07.24.2016, might not needed
                                            If dAR >= dPayAmount Then
                                                oARLog.dPrevBalance = dAR
                                                dAR = dAR - dPayAmount
                                                oAR.dARConsumable = dAR

                                                oARLog.sTransCode = sTransCode
                                                oARLog.dtTransDate = Now.ToString()
                                                oARLog.sMemberID = oMember.sMemberID
                                                oARLog.sCardID = oMember.sCardID
                                                oARLog.sSite = Program.sSiteName
                                                oARLog.sLocation = Program.sTerminalID
                                                oARLog.sCompanyCode = oMember.sCompanyCode
                                                oARLog.dAmount = dPayAmount
                                                oARLog.dNewBalance = dAR
                                                oARLog.dtApplicableMonth = dtAR.Rows(0)("ApplicablePeriod")
                                                oARLog.sUser = Program.sUserName
                                                oARLog.sIPAddress = Program.sIPAddress
                                                oARLog.sHostName = Program.sHostName

                                                oARLog.sPOSRefCode = Program.sPOSRefCode
                                                oCALog.sTransType = "AR"

                                                oARLog.iRefID = iARRefID

                                                'Exit Sub 'for testing

                                                If oSQLAR.UpdateARConsumableByMemberID(oAR) <> 0 Then
                                                    ServerOffline()
                                                    ResetSal()
                                                    Exit Sub
                                                End If

                                                If oSQLLogs.AddARLog(oARLog) <> 0 Then
                                                    ServerOffline()
                                                    ResetSal()
                                                    Exit Sub
                                                End If

                                                dtARLog = oSQLLogs.GetLastARLogByMemberID(oARLog, iErrorCode)
                                                If iErrorCode <> 0 Then
                                                    ServerOffline()
                                                    ResetSal()
                                                    Exit Sub
                                                End If
                                                If Not dtARLog Is Nothing Then
                                                    If dtARLog.Rows.Count > 0 Then
                                                        oARLog.iID = dtARLog.Rows(0)("ID")
                                                        sTransCode = dtARLog.Rows(0)("ID").ToString().PadLeft(6, "0")
                                                        oARLog.sTransCode = sTransCode

                                                        If oSQLLogs.UpdateARLogTransCode(oARLog) <> 0 Then
                                                            ServerOffline()
                                                            ResetSal()
                                                            Exit Sub
                                                        End If
                                                    End If
                                                End If

                                                sLog += "          SOUTH STAR DRUG" & vbCrLf
                                                sLog += "          TAP CARD SYSTEM" & vbCrLf
                                                sLog += StrDup(50, "-") & vbCrLf
                                                sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                                sLog += "Payment Transaction" & vbCrLf & vbCrLf
                                                sLog += "Site                : " & Program.sSiteName & vbCrLf
                                                sLog += "Cashier             : " & Program.sUserName & vbCrLf
                                                sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                                sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                                sLog += "Name                : " & oMember.sFName & vbCrLf
                                                sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                                sLog += vbCrLf
                                                sLog += "Amount Charged      : " & dPayAmount.ToString("#,##0.00") & vbCrLf
                                                sLog += "Balance (AR Credit) : " & dAR.ToString("#,##0.00") & vbCrLf

                                                sLog += "Transaction Number  : " & sTransCode & vbCrLf
                                                sLog += "POS Receipt Number  : " & Program.sPOSRefCode & vbCrLf

                                                sLog += vbCrLf & vbCrLf
                                                sLog += "______________________" & vbCrLf
                                                sLog += oMember.sFName & vbCrLf & vbCrLf & vbCrLf

                                                oPrintLog.sTransCode = sTransCode
                                                oPrintLog.sTerminalID = Program.sTerminalID
                                                oPrintLog.sHostName = Program.sHostName
                                                oPrintLog.sIPAddress = Program.sIPAddress
                                                oPrintLog.dDate = Now.Date
                                                oPrintLog.sTransMode = sOpMode
                                                oPrintLog.sPrintDetails = sLog
                                                oPrintLog.sSite = Program.sSiteName

                                                If oSQLPrintLog.SavePrintLog(oPrintLog) <> 0 Then
                                                    ServerOffline()
                                                    ResetSal()
                                                    Exit Sub
                                                End If
                                                LogActivity(sLog)

                                                If Program.bAutoPrint Then
                                                    oSerialPort.SendData(sLog, Program.sPrinterPort, Program.sPrinterBaudRate)
                                                End If

                                                oReader.ClearLCD()
                                                oReader.DisplayLCDCentered("Transaction", True, 4, 1)
                                                oReader.DisplayLCDCentered("Successful", True, 4, 2)
                                                oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                                oReader.DisplayLCDCentered("Card", False, 4, 4)
                                                oReader.BuzzerControl(1)

                                                MsgBox("Transaction successful.", MsgBoxStyle.Information)
                                                ResetSal()
                                            Else
                                                sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                                sLog += "Payment Transaction" & vbCrLf & vbCrLf
                                                sLog += "Cashier             : " & Program.sUserName & vbCrLf
                                                sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                                sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                                sLog += "Name                : " & oMember.sFName & vbCrLf
                                                sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                                sLog += "Site                : " & oMember.sAddress & vbCrLf
                                                sLog += vbCrLf
                                                sLog += "Amount Charge       : " & dPayAmount.ToString("#,##0.00") & vbCrLf
                                                sLog += "AR Credit  Balance  : " & dAR.ToString("#,##0.00") & vbCrLf & vbCrLf

                                                sLog += "Insufficient Balance" & vbCrLf
                                                LogActivity(sLog)

                                                oReader.ClearLCD()
                                                oReader.DisplayLCDCentered("Insufficient", True, 4, 1)
                                                oReader.DisplayLCDCentered("Balance", True, 4, 2)
                                                oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                                oReader.DisplayLCDCentered("Card", False, 4, 4)
                                                oReader.BuzzerControl(5)
                                                MsgBox("Insufficient Balance", MsgBoxStyle.Information)

                                                'btnCA_Click(sender, e)
                                                ResetSal()
                                            End If
                                        Else
                                            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                            sLog += "Payment Transaction" & vbCrLf & vbCrLf
                                            sLog += "Cashier             : " & Program.sUserName & vbCrLf
                                            sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                            sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                            sLog += "Name                : " & oMember.sFName & vbCrLf
                                            sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                            sLog += "Site                : " & oMember.sAddress & vbCrLf
                                            sLog += vbCrLf
                                            sLog += "Amount Charge       : " & dPayAmount.ToString("#,##0.00") & vbCrLf
                                            sLog += "AR Credit Balance   : " & dAR.ToString("#,##0.00") & vbCrLf & vbCrLf
                                            sLog += "Insufficient Balance" & vbCrLf
                                            LogActivity(sLog)

                                            oReader.ClearLCD()
                                            oReader.DisplayLCDCentered("Insufficient", True, 4, 1)
                                            oReader.DisplayLCDCentered("Balance", True, 4, 2)
                                            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                            oReader.DisplayLCDCentered("Card", False, 4, 4)
                                            oReader.BuzzerControl(5)
                                            MsgBox("Insufficient Balance", MsgBoxStyle.Information)

                                            ResetSal()
                                        End If
                                    Else
                                        sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                        sLog += "Member Details" & vbCrLf & vbCrLf
                                        sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                        sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                        sLog += "Name                : " & oMember.sFName & vbCrLf
                                        sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                        sLog += vbCrLf
                                        sLog += "Member is not eligible for AR Credit"
                                        LogActivity(sLog)

                                        oReader.DisplayLCDCentered("Card", False, 4, 2)
                                        oReader.DisplayLCDCentered("not eligible", False, 4, 3)
                                        oReader.BuzzerControl(5)
                                    End If

                                    '===============================END SALARY PAY MODE=================================

                                Else
                                    '---------------------------------Balance Inquiry----------------------------
                                    sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                    sLog += "Balance Inquiry" & vbCrLf & vbCrLf
                                    sLog += "Card ID             : " & oMember.sCardID & vbCrLf
                                    sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
                                    sLog += "Name                : " & oMember.sFName & vbCrLf
                                    sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
                                    sLog += vbCrLf
                                    sLog += "CA Balance          : " & dCAConsumable.ToString("#,##0.00") & vbCrLf & vbCrLf
                                    sLog += "AR Credit Balance   : " & dAR.ToString("#,##0.00") & vbCrLf & vbCrLf '(Program.iSDMax - dAR).ToString("#,##0.00") & vbCrLf

                                    If Not oMember.bActive Then
                                        sLog += "***INACTIVE****" & vbCrLf
                                    End If

                                    LogActivity(sLog)

                                    oReader.ClearLCD()
                                    oReader.DisplayLCD("CA :" & dCAConsumable.ToString("#,##0.00"), True, 4, 1, 0)
                                    oReader.DisplayLCD("AR :" & (dAR).ToString("#,##0.00"), True, 4, 2, 0)

                                    oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                    oReader.DisplayLCDCentered("Card", False, 4, 4)
                                End If

                            Else
                                sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                                sLog += "Card ID: " & oMember.sCardID & vbCrLf
                                sLog += vbCrLf
                                sLog += "Member/Employee is Inactive"
                                sLog += vbCrLf
                                LogActivity(sLog)

                                oReader.DisplayLCDCentered("Inactive", True, 4, 1)
                                oReader.DisplayLCDCentered("Member/Employee", True, 4, 2)
                                oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                                oReader.DisplayLCDCentered("Card", False, 4, 4)
                                oReader.BuzzerControl(5)

                                Do While oReader.ConnectCard() = 0
                                    If ofrmService Is Nothing Then Exit Do
                                    Application.DoEvents()
                                Loop

                            End If

                            '--------------------------

                        Else
                            'If Member not found
                            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
                            sLog += "Card ID: " & oMember.sCardID & vbCrLf
                            sLog += vbCrLf
                            sLog += "Card not registered."
                            sLog += vbCrLf
                            LogActivity(sLog)

                            oReader.DisplayLCDCentered("Unregistered", True, 4, 1)
                            oReader.DisplayLCDCentered("card", True, 4, 2)
                            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
                            oReader.DisplayLCDCentered("Card", False, 4, 4)
                            oReader.BuzzerControl(5)

                            Do While oReader.ConnectCard() = 0
                                If ofrmService Is Nothing Then Exit Do
                                Application.DoEvents()
                            Loop
                        End If
                        sOldCardID = oMember.sCardID
                    End If
                End If
            End If
        Else
            If sOldCardID <> "" Then
Skip0:
                sOldCardID = ""
                ResetLCD(sOpMode)
            Else
                tmrVAT.Enabled = False
                lblVAT.Visible = False
            End If
        End If
        If Not ofrmService Is Nothing Then
            tmrReader.Enabled = True
        End If

    End Sub

    Private Sub ProcessCA(ByRef oCA As CA_Entity, ByRef oCALog As CALog_Entity, _
                          ByRef dCAConsumable As Double, ByRef dPayAmount As Double, _
                          ByRef iErrorCode As Integer, _
                          ByRef sTransCode As String, ByRef iCARefID As Integer, _
                          ByRef dtCALog As DataTable, _
                          ByRef sLog As String, ByRef oPrintLog As PrintLog_Entity)

        Dim iStage As Integer = 0

        oCALog.dPrevBalance = dCAConsumable
        dCAConsumable = dCAConsumable - dPayAmount
        oCA.dCAConsumable = dCAConsumable

        oCALog.sTransCode = sTransCode
        oCALog.dtTransDate = Now.ToString()
        oCALog.sMemberID = oMember.sMemberID
        oCALog.sCardID = oMember.sCardID
        oCALog.sSite = Program.sSiteName
        oCALog.sLocation = Program.sTerminalID
        oCALog.sCompanyCode = oMember.sCompanyCode
        oCALog.dAmount = dPayAmount
        oCALog.dNewBalance = dCAConsumable
        oCALog.sUser = Program.sUserName
        oCALog.sIPAddress = Program.sIPAddress
        oCALog.sHostName = Program.sHostName

        oCALog.sPOSRefCode = Program.sPOSRefCode

        oCALog.sTransType = "CA"

        oCALog.iRefID = iCARefID

Stage0: iStage = 0
        If oSQLCA.UpdateCAConsumableByMemberID(oCA) <> 0 Then
            ServerOffline()
            ResetCA()
            Exit Sub
        End If

Stage1: iStage = 1
        If oSQLLogs.AddCALog(oCALog) <> 0 Then
            ServerOffline()
            ResetCA()
            Exit Sub
        End If

Stage2: iStage = 2
        dtCALog = oSQLLogs.GetLastCALogByMemberID(oCALog, iErrorCode)
        If iErrorCode <> 0 Then
            ServerOffline()
            ResetCA()
            Exit Sub
        End If

Stage3: iStage = 3
        If Not dtCALog Is Nothing Then
            If dtCALog.Rows.Count > 0 Then
                oCALog.iID = dtCALog.Rows(0)("ID")
                sTransCode = dtCALog.Rows(0)("ID").ToString().PadLeft(6, "0")
                oCALog.sTransCode = sTransCode
                If oSQLLogs.UpdateCALogTransCode(oCALog) <> 0 Then
                    ServerOffline()
                    ResetCA()
                    Exit Sub
                End If
            End If
        End If

        sLog += "          SOUTH STAR DRUG" & vbCrLf
        sLog += "          TAP CARD SYSTEM" & vbCrLf
        sLog += StrDup(50, "-") & vbCrLf
        sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
        sLog += "Payment Transaction" & vbCrLf & vbCrLf
        sLog += "Site                : " & Program.sSiteName & vbCrLf
        sLog += "Cashier             : " & Program.sUserName & vbCrLf
        sLog += "Card ID             : " & oMember.sCardID & vbCrLf
        sLog += "Member ID           : " & oMember.sMemberID & vbCrLf
        sLog += "Name                : " & oMember.sFName & vbCrLf
        sLog += "Company Code        : " & oMember.sCompanyCode & vbCrLf
        sLog += vbCrLf
        sLog += "Amount Charged      : " & dPayAmount.ToString("#,##0.00") & vbCrLf

        sLog += "Balance (CA)        : " & dCAConsumable.ToString("#,##0.00") & vbCrLf

        sLog += "Transaction Number  : " & sTransCode & vbCrLf
        sLog += "POS Receipt Number  : " & Program.sPOSRefCode & vbCrLf

        sLog += vbCrLf & vbCrLf
        sLog += "______________________" & vbCrLf
        sLog += oMember.sFName & vbCrLf & vbCrLf & vbCrLf

        oPrintLog.sTransCode = sTransCode
        oPrintLog.sTerminalID = Program.sTerminalID
        oPrintLog.sHostName = Program.sHostName
        oPrintLog.sIPAddress = Program.sIPAddress
        oPrintLog.dDate = Now.Date
        oPrintLog.sTransMode = sOpMode
        oPrintLog.sPrintDetails = sLog
        oPrintLog.sSite = Program.sSiteName

Stage4: iStage = 4
        If oSQLPrintLog.SavePrintLog(oPrintLog) <> 0 Then
            ServerOffline()
            ResetCA()
            Exit Sub
        End If
        LogActivity(sLog)

        If Program.bAutoPrint Then
            oSerialPort.SendData(sLog, Program.sPrinterPort, Program.sPrinterBaudRate)
        End If

        oReader.ClearLCD()
        oReader.DisplayLCDCentered("Transaction", True, 4, 1)
        oReader.DisplayLCDCentered("Successful", True, 4, 2)
        oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
        oReader.DisplayLCDCentered("Card", False, 4, 4)
        oReader.BuzzerControl(1)

        MsgBox("Transaction successful.", MsgBoxStyle.Information)
        ResetCA()
    End Sub

    Private Sub ResetLCD(ByVal sOpMode As String)
        oReader.ClearLCD()
        If sOpMode = "BalanceInquiry" Then
            oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
            oReader.DisplayLCDCentered("Please", False, 4, 3)
            oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        Else
            oReader.DisplayLCDCentered("Pay Mode", True, 4, 1)
            oReader.DisplayLCDCentered("Please", False, 4, 3)
            oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        End If

    End Sub


    Private Function sMarquee(ByVal sMessage As String) As String
        If sMessage.Length > 0 Then
            sMessage = sMessage.PadLeft(30, " ")
            Dim Str1 As String = sMessage.Remove(0, 1)
            Dim Str2 As String = sMessage(0)
            sMessage = Str1 & Str2
        End If
        Return sMessage
    End Function

    Private Sub frmService_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("Welcome", False, 0, 1)
        tmrReader.Enabled = False
        ofrmService = Nothing
    End Sub

    Private Sub frmService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sStatus = "Balance Inquiry Mode"
        sOpMode = "BalanceInquiry"
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
        oReader.DisplayLCDCentered("Please", False, 4, 3)
        oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        oReader.BuzzerControl(1)

        bEnableCharge = config.AppSettings.Settings("Charge").Value()
        btnCA.Text = "CA"

        If bEnableCharge Then
            btnCharge.Visible = True
        Else
            btnCharge.Visible = False
        End If

        txtDoubleAmount.Value = 0

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LogActivity(ByVal sMsg As String)
        'Dim sLogDate As String = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        'txtTrans.Text += StrDup(50, "-") & vbCrLf
        'txtTrans.Text += sMsg & vbCrLf
        'txtTrans.Text += StrDup(50, "-") & vbCrLf
        'txtTrans.SelectionStart = txtTrans.TextLength
        'txtTrans.ScrollToCaret()

        sMsg = StrDup(50, "-") & vbCrLf & sMsg & vbCrLf
        sMsg += StrDup(50, "-") & vbCrLf

        rtxtTrans.Font = New Font("Courier New", 11, FontStyle.Regular)
        rtxtTrans.Text += sMsg

        rtxtTrans.SelectionStart = rtxtTrans.TextLength
        rtxtTrans.ScrollToCaret()
    End Sub

    Private Function StripOff(ByVal sString As String) As String
        sString = sString.Replace(":", "")
        sString = sString.Replace("PM", "")
        sString = sString.Replace("AM", "")
        sString = sString.Replace("/", "")
        sString = sString.Replace(" ", "")
        Return sString
    End Function

    Private Function GetCenter(ByVal sString As String, ByVal iScreenWidth As Integer) As Integer
        Dim iMidScreen As Integer = iScreenWidth / 2
        Dim iMidString As Integer = sString.Length / 2
        Dim iCenter = iMidScreen - iMidString

        Return iCenter
    End Function

    Private Sub btnCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCA.Click
        Dim dAmount As Double = 0.0
        Dim sLog As String = ""

        oConfirmTrans = New frmConfirmTrans

        oConfirmTrans.sDetails = ""

        If sOpMode = "CAPayMode" Then 'for cancelling
            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
            sLog += "Payment Transaction" & vbCrLf & vbCrLf
            sLog += "Cashier         : " & Program.sUserName & vbCrLf
            sLog += "Card ID         : " & oMember.sCardID & vbCrLf
            sLog += "Member ID       : " & oMember.sMemberID & vbCrLf
            sLog += "Name            : " & oMember.sFName & vbCrLf
            sLog += "Site            : " & oMember.sAddress & vbCrLf
            sLog += vbCrLf
            'sLog += "Amount Charge   : " & dPayAmount.ToString() & vbCrLf
            'sLog += "Balance (CA)   : " & dCAConsumable.ToString() & vbCrLf & vbCrLf
            sLog += "Transaction Cancelled." & vbCrLf
            LogActivity(sLog)

            'txtAmount.Text = "0."
            'sStatus = "Balance Inquiry Mode"
            'sOpMode = "BalanceInquiry"
            'btnCA.Text = "CA"
            'btnSal.Enabled = True
            ResetCA()
            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Transaction", True, 4, 1)
            oReader.DisplayLCDCentered("Cancelled.", True, 4, 2)
            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
            oReader.DisplayLCDCentered("Card", False, 4, 4)
            oReader.BuzzerControl(5)

            Do While oReader.ConnectCard = 0
                Application.DoEvents()
            Loop

            sStatus = "Balance Inquiry Mode"
            sOpMode = "BalanceInquiry"
            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
            oReader.DisplayLCDCentered("Please", False, 4, 3)
            oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        Else
            dAmount = Val(txtAmount.Text.Replace(",", ""))

            If dAmount > 0 Then
                sLog += "Transaction Mode: CA" & vbCrLf

                sLog += "Amount          : " & dAmount.ToString() & vbCrLf

                oConfirmTrans.sDetails = sLog

                oConfirmTrans.ShowDialog()

                If oConfirmTrans.DialogResult = Windows.Forms.DialogResult.No Then
                    oConfirmTrans = Nothing
                    Exit Sub
                End If

                sStatus = "Please tap card."
                sOpMode = "CAPayMode"

                oReader.ClearLCD()
                oReader.DisplayLCDCentered("Pay Mode", True, 4, 1)
                oReader.DisplayLCDCentered("Please", False, 4, 3)
                oReader.DisplayLCDCentered("Tap Card", False, 4, 4)

                btnCA.Text = "X"
                btnSal.Enabled = False
                btnCharge.Enabled = False
                btnPrint.Enabled = False
                btnVoid.Enabled = False
                gbKeypad.Enabled = False
            Else
                MsgBox("No Amount specified.", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub btnSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSal.Click
        Dim dAmount As Double = 0.0
        Dim sLog As String = ""

        oConfirmTrans = New frmConfirmTrans

        oConfirmTrans.sDetails = ""

        If sOpMode = "SalaryPayMode" Then 'for cancelling
            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
            sLog += "Payment Transaction" & vbCrLf & vbCrLf
            sLog += "Cashier         : " & Program.sUserName & vbCrLf
            sLog += "Card ID         : " & oMember.sCardID & vbCrLf
            sLog += "Member ID       : " & oMember.sMemberID & vbCrLf
            sLog += "Name            : " & oMember.sFName & vbCrLf
            sLog += "Site            : " & oMember.sAddress & vbCrLf
            sLog += vbCrLf
            'sLog += "Amount Charge   : " & dPayAmount.ToString() & vbCrLf
            'sLog += "Balance (CA)   : " & dCAConsumable.ToString() & vbCrLf & vbCrLf
            sLog += "Transaction Cancelled." & vbCrLf
            LogActivity(sLog)

            ResetSal()

            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Transaction", True, 4, 1)
            oReader.DisplayLCDCentered("Cancelled.", True, 4, 2)
            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
            oReader.DisplayLCDCentered("Card", False, 4, 4)
            oReader.BuzzerControl(5)

            Do While oReader.ConnectCard = 0
                Application.DoEvents()
            Loop

            sStatus = "Balance Inquiry Mode"
            sOpMode = "BalanceInquiry"
            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
            oReader.DisplayLCDCentered("Please", False, 4, 3)
            oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        Else
            dAmount = Val(txtAmount.Text.Replace(",", ""))

            If dAmount > 0 Then

                sLog += "Transaction Mode: AR" & vbCrLf
                sLog += "Amount          : " & dAmount.ToString() & vbCrLf

                oConfirmTrans.sDetails = sLog

                oConfirmTrans.ShowDialog()

                If oConfirmTrans.DialogResult = Windows.Forms.DialogResult.No Then
                    oConfirmTrans = Nothing
                    Exit Sub
                End If

                sStatus = "Please tap card."
                sOpMode = "SalaryPayMode"

                oReader.ClearLCD()
                oReader.DisplayLCDCentered("Pay Mode", True, 4, 1)
                oReader.DisplayLCDCentered("Please", False, 4, 3)
                oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
                btnSal.Text = "X"
                btnCA.Enabled = False
                btnCharge.Enabled = False
                btnPrint.Enabled = False
                btnVoid.Enabled = False
                gbKeypad.Enabled = False
            Else
                MsgBox("No Amount specified.", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub ResetCA()
        txtAmount.Text = "0."
        txtDoubleAmount.Value = 0
        sStatus = "Balance Inquiry Mode"
        sOpMode = "BalanceInquiry"
        btnCA.Text = "CA"

        btnSal.Enabled = True
        btnCharge.Enabled = True
        btnPrint.Enabled = True
        btnVoid.Enabled = True
        gbKeypad.Enabled = True
    End Sub

    Private Sub ResetSal()
        txtAmount.Text = "0."
        txtDoubleAmount.Value = 0
        sStatus = "Balance Inquiry Mode"
        sOpMode = "BalanceInquiry"
        btnSal.Text = "AR"
        btnCA.Enabled = True
        btnCharge.Enabled = True
        btnPrint.Enabled = True
        btnVoid.Enabled = True
        gbKeypad.Enabled = True
    End Sub

    Private Sub ResetCharge()
        txtAmount.Text = "0."
        sStatus = "Balance Inquiry Mode"
        sOpMode = "BalanceInquiry"
        btnCharge.Text = "CHARGE"
        btnSal.Enabled = True
        btnCA.Enabled = True
        btnPrint.Enabled = True
        btnVoid.Enabled = True
        gbKeypad.Enabled = True
    End Sub

    Private Sub btnCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharge.Click
        Dim dAmount As Double = 0.0
        Dim sLog As String = ""

        If sOpMode = "ChargePayMode" Then 'for cancelling
            sLog += Now.ToString("MM/dd/yyyy hh:mm:ss tt") & vbCrLf
            sLog += "Payment Transaction" & vbCrLf & vbCrLf
            sLog += "Cashier         : " & Program.sUserName & vbCrLf
            sLog += "Card ID         : " & oMember.sCardID & vbCrLf
            sLog += "Member ID       : " & oMember.sMemberID & vbCrLf
            sLog += "Name            : " & oMember.sFName & vbCrLf
            sLog += "Site            : " & oMember.sAddress & vbCrLf
            sLog += vbCrLf
            'sLog += "Amount Charge   : " & dPayAmount.ToString() & vbCrLf
            'sLog += "Balance (CA)   : " & dCAConsumable.ToString() & vbCrLf & vbCrLf
            sLog += "Transaction Cancelled." & vbCrLf
            LogActivity(sLog)

            ResetCharge()

            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Transaction", True, 4, 1)
            oReader.DisplayLCDCentered("Cancelled.", True, 4, 2)
            oReader.DisplayLCDCentered("Please Remove", False, 4, 3)
            oReader.DisplayLCDCentered("Card", False, 4, 4)
            oReader.BuzzerControl(5)

            Do While oReader.ConnectCard = 0
                Application.DoEvents()
            Loop

            sStatus = "Balance Inquiry Mode"
            sOpMode = "BalanceInquiry"
            oReader.ClearLCD()
            oReader.DisplayLCDCentered("Balance  Inquiry", True, 4, 1)
            oReader.DisplayLCDCentered("Please", False, 4, 3)
            oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
        Else
            dAmount = Val(txtAmount.Text)

            If dAmount > 0 Then
                sStatus = "Please tap card."
                sOpMode = "ChargePayMode"

                oReader.ClearLCD()
                oReader.DisplayLCDCentered("Pay Mode", True, 4, 1)
                oReader.DisplayLCDCentered("Please", False, 4, 3)
                oReader.DisplayLCDCentered("Tap Card", False, 4, 4)
                btnCharge.Text = "X"
                btnCA.Enabled = False
                btnSal.Enabled = False
                btnPrint.Enabled = False
                btnVoid.Enabled = False
                gbKeypad.Enabled = False
            Else
                MsgBox("No Amount specified.", MsgBoxStyle.Information)
            End If

        End If
    End Sub


    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        tmrReader.Enabled = False
        If Program.ofrmVoidCardTrans Is Nothing Then
            Program.ofrmVoidCardTrans = New frmVoidCardTrans
            Program.ofrmVoidCardTrans.ShowDialog()
        Else
            SetFormFocus(Program.ofrmVoidCardTrans)
        End If
        tmrReader.Enabled = True
    End Sub

    Private Sub SetFormFocus(ByVal frm As Form)
        frm.Activate()
        frm.TopMost = True
        frm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub tmrVAT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVAT.Tick
        lblVAT.Visible = Not lblVAT.Visible
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim dt As New DataTable
        Dim sLog As String = ""
        Dim oPrintLog As New PrintLog_Entity
        Dim iErrorCode As Integer = 0

        'dt = oSQLLogs.GetLastTransLogByTerminalID(Program.sTerminalID)

        oPrintLog.sTerminalID = Program.sTerminalID
        oPrintLog.sSite = Program.sSiteName
        dt = oSQLPrintLog.GetLastPrintLog(oPrintLog, iErrorCode)
        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If dt.Rows.Count > 0 Then
            oPrintLog.sPrintDetails = dt.Rows(0)("PrintDetails").ToString()
            oSerialPort.SendData(oPrintLog.sPrintDetails, Program.sPrinterPort, Program.sPrinterBaudRate)
        End If

    End Sub

    Private Sub frmService_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F8
                btnCA.PerformClick()
            Case Keys.F9
                btnSal.PerformClick()
            Case Keys.F12
                btnPrint.PerformClick()
            Case Keys.Escape
                btnC.PerformClick()
            Case Keys.NumPad0, 48
                btn0.Focus()
                btn0.PerformClick()
            Case Keys.NumPad1, 49
                btn1.Focus()
                btn1.PerformClick()
            Case Keys.NumPad2, 50
                btn2.Focus()
                btn2.PerformClick()
            Case Keys.NumPad3, 51
                btn3.Focus()
                btn3.PerformClick()
            Case Keys.NumPad4, 52
                btn4.Focus()
                btn4.PerformClick()
            Case Keys.NumPad5, 53
                btn5.Focus()
                btn5.PerformClick()
            Case Keys.NumPad6, 54
                btn6.Focus()
                btn6.PerformClick()
            Case Keys.NumPad7, 55
                btn7.Focus()
                btn7.PerformClick()
            Case Keys.NumPad8, 56
                btn8.Focus()
                btn8.PerformClick()
            Case Keys.NumPad9, 57
                btn9.Focus()
                btn9.PerformClick()
            Case 190, 110
                btnPeriod.Focus()
                btnPeriod.PerformClick()
            Case 8
                btnCE.PerformClick()


        End Select
    End Sub

    Private Sub ServerOffline()
        oReader.ClearLCD()
        oReader.DisplayLCDCentered("OFFLINE", True, 4, 1)
        oReader.DisplayLCDCentered("Please Try Again", False, 4, 2)
        oReader.DisplayLCDCentered("Later", False, 4, 3)
        oReader.BuzzerControl(5)
        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
        Do While oReader.ConnectCard() = 0
            If ofrmService Is Nothing Then Exit Do
            Application.DoEvents()
        Loop
        tmrReader.Enabled = True
    End Sub

End Class
