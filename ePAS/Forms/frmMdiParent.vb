Imports System.Windows.Forms
Imports System.Configuration
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common

Public Class frmMdiParent
    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Private oSQLPreferences As New SQLPreferences_Worker
    Private oPreferences As New Preferences_Entity

    Private ofrmReportManager As New frmReportManager

    Private Sub frmMdiParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bRetVal As Boolean = False
        Dim bCOMEnabled As Boolean = False

        Me.Text = Application.ProductName + " v" + Application.ProductVersion.ToString() '.Substring(0, 3) 

        mnuSetup.Enabled = False
        mnuDevice.Enabled = False
        mnuTerminalConfig.Enabled = False
        mnuPreferences.Enabled = False
        mnuPrinterSetup.Enabled = False
        mnuResetDatabase.Enabled = False
        mnuUpdate.Enabled = False
        mnuUpdateDatabase.Enabled = False
        mnuUpdateClient.Enabled = False

        mnuProcessing.Enabled = False
        mnuRunService.Enabled = False
        mnuMembership.Enabled = False
        mnuKioskMode.Enabled = False
        mnuBatchUploading.Enabled = False
        'mnuManualTransaction.Enabled = False
        mnuResetCA.Enabled = False
        mnuResetAR.Enabled = False
        mnuVoidTransactions.Enabled = False
        mnuAutoResetCalendar.Enabled = False

        mnuReports.Enabled = False
        'mnuTransLogView.Enabled = False
        'mnuUploadedCA.Enabled = False
        'mnuManuallyAddedCA.Enabled = False
        'mnuOutstandingSalaryDeductions.Enabled = False
        'mnuTerminalEOD.Enabled = False
        'mnuEmployeeMasterFileReport.Enabled = False
        'mnuSalaryDeductionPaymentsReport.Enabled = False
        mnuCreditLimitAdjustmentsReport.Enabled = False

        mnuSecurity.Enabled = False
        mnuGroupManager.Enabled = False
        mnuUserManager.Enabled = False

        mnuAccount.Enabled = False
        mnuChangepass.Enabled = True
        mnuLogOut.Enabled = False

        If Program.sUserName = "xadmin" Then
            mnuResetDatabase.Enabled = True
            mnuResetDatabase.Visible = True
        Else
            mnuResetDatabase.Enabled = False
            mnuResetDatabase.Visible = False
        End If

        Select Case Program.iAccountType
            Case 0 'Guest
                mnuProcessing.Enabled = True
                mnuKioskMode.Enabled = True

                mnuAccount.Enabled = True
                mnuLogOut.Enabled = True

            Case 1 'User
                mnuSetup.Enabled = True
                mnuDevice.Enabled = True

                mnuProcessing.Enabled = True
                mnuRunService.Enabled = True
                mnuKioskMode.Enabled = True

                mnuReports.Enabled = True
                mnuEmployeeMasterFileReport.Enabled = False
                mnuConsolidatedBilling.Enabled = False
                mnuReIssuedCards.Enabled = False
                mnuEmployeeIssuedCards.Enabled = False

                mnuAccount.Enabled = True
                mnuLogOut.Enabled = True

                mnuTerminalEOD.Enabled = True

            Case 2 'HR
                mnuSetup.Enabled = True
                mnuDevice.Enabled = True

                mnuProcessing.Enabled = True
                mnuMembership.Enabled = True
                mnuBatchUploading.Enabled = True
                'mnuManualTransaction.Enabled = True
                mnuResetCA.Enabled = True
                mnuResetAR.Enabled = True
                mnuVoidTransactions.Enabled = True
                mnuAutoResetCalendar.Enabled = True

                mnuReports.Enabled = True
                'mnuUploadedCA.Enabled = True
                'mnuManuallyAddedCA.Enabled = True
                'mnuOutstandingSalaryDeductions.Enabled = True
                mnuTerminalEOD.Enabled = False
                'mnuEmployeeMasterFileReport.Enabled = True
                'mnuSalaryDeductionPaymentsReport.Enabled = True
                mnuCreditLimitAdjustmentsReport.Enabled = True

                mnuAccount.Enabled = True
                mnuLogOut.Enabled = True
            Case 3 'Admin
                mnuSetup.Enabled = True
                mnuDevice.Enabled = True
                mnuTerminalConfig.Enabled = True
                mnuPreferences.Enabled = True
                mnuPrinterSetup.Enabled = True
                mnuResetDatabase.Enabled = True
                mnuUpdate.Enabled = True
                mnuUpdateDatabase.Enabled = True
                'mnuUpdateClient.Enabled = True

                mnuProcessing.Enabled = True
                mnuRunService.Enabled = True
                mnuMembership.Enabled = True
                mnuKioskMode.Enabled = True
                mnuBatchUploading.Enabled = True
                'mnuManualTransaction.Enabled = True
                mnuResetCA.Enabled = True
                mnuResetAR.Enabled = True
                mnuVoidTransactions.Enabled = True
                mnuAutoResetCalendar.Enabled = True

                mnuReports.Enabled = True
                'mnuTransLogView.Enabled = True
                'mnuUploadedCA.Enabled = True
                'mnuManuallyAddedCA.Enabled = True
                'mnuOutstandingSalaryDeductions.Enabled = True
                'mnuTerminalEOD.Enabled = True
                'mnuEmployeeMasterFileReport.Enabled = True
                'mnuSalaryDeductionPaymentsReport.Enabled = True
                mnuCreditLimitAdjustmentsReport.Enabled = True

                mnuSecurity.Enabled = True
                mnuGroupManager.Enabled = True
                mnuUserManager.Enabled = True

                mnuAccount.Enabled = True
                If Program.sUserName = "xadmin" Then
                    mnuChangepass.Enabled = False
                Else
                    mnuChangepass.Enabled = True
                End If

                mnuLogOut.Enabled = True

            Case 4 'Accounting / View only

                mnuReports.Enabled = True
                mnuConsolidatedBilling.Enabled = True
                mnuTerminalEOD.Enabled = False
                mnuEmployeeMasterFileReport.Enabled = False
                mnuReIssuedCards.Enabled = False
                mnuEmployeeIssuedCards.Enabled = False
                mnuCreditLimitAdjustmentsReport.Enabled = False

                mnuAccount.Enabled = True
                mnuLogOut.Enabled = True
            Case 255 'Void
                mnuAccount.Enabled = True
                mnuChangepass.Enabled = False
                mnuLogOut.Enabled = True

        End Select

        lblUser.Text = Program.sUserName
        lblGroup.Text = Program.sGroupCode

        Program.lMDIParentHeight = Me.Height
        Program.lMDIParentWidth = Me.Width

        '1. Get saved device settings

        Program.sDevices = config.AppSettings.Settings("DeviceName").Value
        Program.sCOMPort = config.AppSettings.Settings("COMPort").Value
        bCOMEnabled = config.AppSettings.Settings("COMEnabled").Value

        Program.sSiteName = config.AppSettings.Settings("SiteName").Value
        Program.sConcessionaire = config.AppSettings.Settings("ConcessionaireName").Value
        Program.sTerminalID = config.AppSettings.Settings("TerminalID").Value

        Program.sPrinterPort = config.AppSettings.Settings("PrinterPort").Value
        Program.sPrinterBaudRate = config.AppSettings.Settings("PrinterBaudRate").Value

        'Program.bDisplayPhoto = config.AppSettings.Settings("DisplayPhoto").Value


        'Reset ports

        '3. Connect device by sending a command, like setting the lcd welcome message
        Select Case Program.sDevices
            Case "ACR1222L"
                'oReader = New ACR1222L_Lib.ACR1222L 'Temporarily disabled for testing
                bConnected = oReader.Initialize()
        End Select

        If bConnected = True Then
            If Program.sDevices = "ACR1222L" Then
                oReader.BuzzerControl(1)
                oReader.ClearLCD()
                oReader.BackLight(False)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off)
                Threading.Thread.Sleep(100)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off)
                Threading.Thread.Sleep(100)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off)
                Threading.Thread.Sleep(100)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.Off)
                Threading.Thread.Sleep(100)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.On)
                Threading.Thread.Sleep(100)
                oReader.LedControl(ACR1222L_Lib.LedStateSwitch.On, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off, ACR1222L_Lib.LedStateSwitch.Off)
                oReader.BackLight(True)
                Dim i As Integer
                i = oReader.DisplayLCD("Welcome", False, 0, 1, 4)
            End If
        Else

            If Program.iAccountType = 0 Then 'Program.bIsRestricted Then
                oCommon.ErrorBox("No device found. Please contact your system administrator.")
            Else
                oCommon.ErrorBox("No device found.")
                mnuDevice_Click(sender, e)
            End If
        End If

        'LoadPreferences()

        If Program.iAccountType = 0 Then 'Program.bIsRestricted Then
            'mnuRunStandalone.PerformClick()
            'Exit Sub
        End If

        If Not config.AppSettings.Settings("SSD").Value() Is Nothing Then
            Program.bSSD = config.AppSettings.Settings("SSD").Value()
        End If

        If Not config.AppSettings.Settings("KioskMode").Value() Is Nothing Then
            bKioskMode = config.AppSettings.Settings("KioskMode").Value()

            Dim ofrmBalanceInqKiosk As New frmBalanceInqKiosk

            If bKioskMode Then
                ofrmBalanceInqKiosk.ShowDialog()
            End If

        End If

    End Sub

    Private Sub LoadPreferences()
        Dim dt As New DataTable
        dt = oSQLPreferences.GetPreferences(oPreferences)

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Program.iCAMin = Val(dt.Rows(0)("CAMinLimit"))
                Program.iCAMax = Val(dt.Rows(0)("CAMaxLimit"))
                Program.iSDMin = Val(dt.Rows(0)("SalaryDeductionMinLimit"))
                Program.iSDMax = Val(dt.Rows(0)("SalaryDeductionMaxLimit"))
            End If
        End If
    End Sub

    Private Sub SetFormFocus(ByVal frm As Form)
        frm.Activate()
        frm.TopMost = True
        frm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub menu1UserManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserManager.Click
        If Program.ofrmUserManager Is Nothing Then
            Program.ofrmUserManager = New frmUserManager
            Program.ofrmUserManager.MdiParent = Me
            Program.ofrmUserManager.Show()
        Else
            SetFormFocus(Program.ofrmUserManager)
        End If
    End Sub

    Private Sub menu1GroupManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGroupManager.Click
        If Program.ofrmGroupManager Is Nothing Then
            Program.ofrmGroupManager = New frmGroupManager
            Program.ofrmGroupManager.MdiParent = Me
            Program.ofrmGroupManager.Show()
        Else
            SetFormFocus(Program.ofrmGroupManager)
        End If
    End Sub

    Private Sub menu1Changepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangepass.Click
        If Program.ofrmInputBox Is Nothing Then
            Program.ofrmInputBox = New frmInputBox
            Program.sEvent = "ChangePass"
            Program.ofrmInputBox.ShowDialog()
        Else
            SetFormFocus(Program.ofrmInputBox)
        End If
    End Sub

    Private Sub menu1LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOut.Click
        mnuChangepass.Enabled = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Program.oSerialPort.Close()
        For Each child As Form In Me.MdiChildren
            child.Close()
        Next
    End Sub

    Private Sub mnuDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDevice.Click
        If Program.ofrmReaderSetup Is Nothing Then
            Program.ofrmReaderSetup = New frmReaderSetup
            Program.ofrmReaderSetup.MdiParent = Me
            Program.ofrmReaderSetup.Show()
        Else
            SetFormFocus(Program.ofrmReaderSetup)
        End If
    End Sub

    Private Sub frmMdiParent_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Program.ofrmMDIParent Is Nothing Then
            Exit Sub
        End If
        Program.lMDIParentHeight = Me.Height
        Program.lMDIParentWidth = Me.Width
        If Me.ActiveMdiChild IsNot Nothing Then
            Program.oCommon.SetCenterPosition(Me.ActiveMdiChild)
        End If
    End Sub

    'Private Sub mnuLoyaltySetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmLoyalty Is Nothing Then
    '        Program.ofrmLoyalty = New frmLoyalty
    '        Program.ofrmLoyalty.MdiParent = Me
    '        Program.ofrmLoyalty.Show()
    '    Else
    '        SetFormFocus(Program.ofrmLoyalty)
    '    End If
    'End Sub

    Private Sub mnuMembership_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMembership.Click
        If Program.ofrmMemberManager Is Nothing Then
            Program.ofrmMemberManager = New frmMemberManager
            Program.ofrmMemberManager.MdiParent = Me
            Program.ofrmMemberManager.Show()
        Else
            SetFormFocus(Program.ofrmMemberManager)
        End If
    End Sub

    'Private Sub mnuCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmCardInitialization Is Nothing Then
    '        Program.ofrmCardInitialization = New frmCardInitialization
    '        Program.ofrmCardInitialization.MdiParent = Me
    '        Program.ofrmCardInitialization.Show()
    '    Else
    '        SetFormFocus(Program.ofrmCardInitialization)
    '    End If
    'End Sub

    'Private Sub mnuTransLogView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmCACreditLogs Is Nothing Then
    '        Program.ofrmCACreditLogs = New frmCACreditLogs
    '        Program.ofrmCACreditLogs.MdiParent = Me
    '        Program.ofrmCACreditLogs.Show()
    '    Else
    '        SetFormFocus(Program.ofrmTransactionLogs)
    '    End If

    'End Sub

    'Private Sub mnuAccumulatePoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmAccumulate Is Nothing Then
    '        Program.ofrmAccumulate = New frmAccumulate
    '        Program.ofrmAccumulate.MdiParent = Me
    '        Program.ofrmAccumulate.Show()
    '    Else
    '        SetFormFocus(Program.ofrmAccumulate)
    '    End If
    'End Sub

    'Private Sub mnuRedeemPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmRedeem Is Nothing Then
    '        Program.ofrmRedeem = New frmRedeem
    '        Program.ofrmRedeem.MdiParent = Me
    '        Program.ofrmRedeem.Show()
    '    Else
    '        SetFormFocus(Program.ofrmRedeem)
    '    End If
    'End Sub

    'Private Sub mnuValueCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Program.ofrmValueCard Is Nothing Then
    '        Program.ofrmValueCard = New frmValueCard
    '        Program.ofrmValueCard.MdiParent = Me
    '        Program.ofrmValueCard.Show()
    '    Else
    '        SetFormFocus(Program.ofrmValueCard)
    '    End If
    'End Sub

    Private Sub mnuImportData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportData.Click
        Program.sImportMode = "MasterFile"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()

            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuUploadRewards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Program.sImportMode = "Rewards"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing

            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()

            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuTerminalConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTerminalConfig.Click
        If Program.ofrmTerminalConfig Is Nothing Then
            Program.ofrmTerminalConfig = New frmTerminalConfig
            Program.ofrmTerminalConfig.MdiParent = Me
            Program.ofrmTerminalConfig.Show()
        Else
            SetFormFocus(Program.ofrmTerminalConfig)
        End If
    End Sub

    'Private Sub mnuRewardsViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Program.bViewOnly = True
    '    If Program.ofrmRewardsViewer Is Nothing Then
    '        Program.ofrmRewardsViewer = New frmRewardsViewer
    '        Program.ofrmRewardsViewer.MdiParent = Me
    '        Program.ofrmRewardsViewer.Show()
    '    Else
    '        SetFormFocus(Program.ofrmRewardsViewer)
    '    End If
    'End Sub

    Private Sub mnuUpdateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateDatabase.Click
        Dim dlgOpenFile As New OpenFileDialog
        Dim oRead As System.IO.StreamReader
        Dim sScript As String = ""
        Dim sFilename As String = ""
        Dim sqlConn As New SqlConnection

        dlgOpenFile.Filter = "SQL Script Files (*.sql)|*.sql"
        dlgOpenFile.ShowDialog(Me)

        If dlgOpenFile.FileName <> "" Then
            sFilename = dlgOpenFile.FileName

            oRead = File.OpenText(sFilename)
            sScript = oRead.ReadToEnd()
            oRead.Close()

            sqlConn = New SqlConnection(eConn.sConnString)

            Dim server As New Server(New ServerConnection(sqlConn))

            Try
                server.ConnectionContext.ExecuteNonQuery(sScript)
                MessageBox.Show("Update Successful.  Program needs to be restarted.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Application.Exit()
                End
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub mnuUpdateClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateClient.Click

    End Sub

    Private Sub mnuCardDeleteTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Program.ofrmCardDeleteTool Is Nothing Then
            Program.ofrmCardDeleteTool = New frmCardDeleteTool
            Program.ofrmCardDeleteTool.MdiParent = Me
            Program.ofrmCardDeleteTool.Show()
        Else
            SetFormFocus(Program.ofrmCardDeleteTool)
        End If
    End Sub

    Private Sub mnuRunService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRunService.Click
        If Program.ofrmService Is Nothing Then
            Program.ofrmService = New frmService
            Program.ofrmService.MdiParent = Me
            Program.ofrmService.Show()
        Else
            SetFormFocus(Program.ofrmService)
        End If
    End Sub


    Private Sub mnuKioskMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKioskMode.Click
        If Program.ofrmBalanceInqKiosk Is Nothing Then
            Program.ofrmBalanceInqKiosk = New frmBalanceInqKiosk
            'Program.ofrmBalanceInqKiosk.MdiParent = Me
            Program.ofrmBalanceInqKiosk.Show()
        Else
            SetFormFocus(Program.ofrmBalanceInqKiosk)
        End If
    End Sub

    Private Sub mnuUploadAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadAR.Click
        Program.sImportMode = "SALARY DEDUCTION PAYMENTS"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuUploadOtherTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadOtherTrans.Click
        Program.sImportMode = "OTHER TRANSACTIONS"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()

            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub



    Private Sub mnuUploadOfflineCATransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadOfflineCATransactions.Click
        Program.sImportMode = "OFFLINE CA TRANSACTIONS"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()

            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuUploadOfflineSDTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadOfflineSDTransactions.Click
        Program.sImportMode = "OFFLINE SD TRANSACTIONS"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()

            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuUploadedCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "UploadedCA"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuManuallyAddedCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "ManuallyAddedCA"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuTerminalEOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTerminalEOD.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "TerminalEOD"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuOutstandingSalaryDeductions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "OutstandingSD"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuUploadCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadCA.Click
        Program.sImportMode = "CA Credit Limit"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuUploadSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUploadSD.Click
        Program.sImportMode = "SD Credit Limit"

        If Program.ofrmImportData Is Nothing Then
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
        Else
            ofrmImportData.Close()
            ofrmImportData = Nothing
            Program.ofrmImportData = New frmImportData
            Program.ofrmImportData.MdiParent = Me
            Program.ofrmImportData.Show()
            'SetFormFocus(Program.ofrmImportData)
        End If
    End Sub

    Private Sub mnuPrinterSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrinterSetup.Click
        If Program.ofrmPrinterSetup Is Nothing Then
            Program.ofrmPrinterSetup = New frmPrinterSetup
            Program.ofrmPrinterSetup.MdiParent = Me
            Program.ofrmPrinterSetup.Show()
        Else
            SetFormFocus(Program.ofrmPrinterSetup)
        End If
    End Sub

    Private Sub mnuEmployeeMasterFileReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmployeeMasterFileReport.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "EmployeeMasterFile"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuSalaryDeductionPaymentsReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "SalaryDeductionPayments"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuResetDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResetDatabase.Click
        If MsgBox("This will reset all transaction and member data.  Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If oSQLDatabase.ResetData() <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If
            MsgBox("Database successfully reset.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub mnuResetAMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResetCA.Click
        Dim oResetLog As New ResetLog_Entity
        Dim oSQLResetLog As New SQLResetLog_Worker

        Program.iSuperAccountType = 0

        Do While Program.iSuperAccountType <> 255 And Program.iSuperAccountType <> 3
            If ofrmSuperLogin Is Nothing Then
                ofrmSuperLogin = New frmSuperLogin
            End If
            ofrmSuperLogin.ShowDialog()
            If ofrmSuperLogin.DialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        Loop


        If MsgBox("This will reset the balances for CA. Continue", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            oResetLog.sUser = Program.sUserName
            oResetLog.sTerminalID = Program.sTerminalID
            oResetLog.sIPAddress = Program.sIPAddress
            oResetLog.sHostName = Program.sHostName
            oResetLog.sSite = Program.sSiteName
            oResetLog.sTransMode = "CA"
            If oSQLCA.ResetCA(oResetLog) <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If oSQLResetLog.AddResetLog(oResetLog) <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If

            MsgBox("CA Balances successfully reset.")
        End If

    End Sub

    Private Sub mnuResetSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResetAR.Click
        Dim oResetLog As New ResetLog_Entity
        Dim oSQLResetLog As New SQLResetLog_Worker

        Program.iSuperAccountType = 0

        Do While Program.iSuperAccountType <> 255 And Program.iSuperAccountType <> 3
            If ofrmSuperLogin Is Nothing Then
                ofrmSuperLogin = New frmSuperLogin
            End If
            ofrmSuperLogin.ShowDialog()
            If ofrmSuperLogin.DialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        Loop


        If MsgBox("This will reset the balances for AR AR. Continue", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            oResetLog.sUser = Program.sUserName
            oResetLog.sTerminalID = Program.sTerminalID
            oResetLog.sIPAddress = Program.sIPAddress
            oResetLog.sHostName = Program.sHostName
            oResetLog.sSite = Program.sSiteName
            oResetLog.sTransMode = "AR"

            If oSQLAR.ResetAR(oResetLog) <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If oSQLResetLog.AddResetLog(oResetLog) <> 0 Then
                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If

            MsgBox("AR Balances successfully reset.")
        End If

    End Sub

    Private Sub mnuVoidTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVoidTransactions.Click
        If Program.ofrmVoidCardTrans Is Nothing Then
            Program.ofrmVoidCardTrans = New frmVoidCardTrans
            Program.ofrmVoidCardTrans.MdiParent = Me
            Program.ofrmVoidCardTrans.Show()
        Else
            SetFormFocus(Program.ofrmVoidCardTrans)
        End If
    End Sub

    Private Sub mnuConsolidatedBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidatedBilling.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "ConsolidatedReport"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub tmrAutoReset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoReset.Tick
        Dim iErrorCode As Integer = 0
        Dim oResetLog As New ResetLog_Entity
        Dim oSQLResetLog As New SQLResetLog_Worker
        Dim oResetCalendar As New SQLResetCalendar_Worker

        tmrAutoReset.Stop()

        oResetLog.sUser = Program.sUserName
        oResetLog.sTerminalID = Program.sTerminalID
        oResetLog.sIPAddress = Program.sIPAddress
        oResetLog.sHostName = Program.sHostName
        oResetLog.sSite = Program.sSiteName
        oResetCalendar.ResetBySchedule(oResetLog)

        tmrAutoReset.Start()
    End Sub

    Private Sub mnuAutoResetCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAutoResetCalendar.Click
        If Program.ofrmResetCalendar Is Nothing Then
            Program.ofrmResetCalendar = New frmResetCalendar
            tmrAutoReset.Stop()
            Program.ofrmResetCalendar.ShowDialog()
            tmrAutoReset.Start()
        Else
            SetFormFocus(Program.ofrmResetCalendar)
        End If
    End Sub

    Private Sub mnuReIssuedCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReIssuedCards.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "ReIssuedCards"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuEmployeeIssuedCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmployeeIssuedCards.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "MemberCardHistory"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuCreditLimitAdjustmentsReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreditLimitAdjustmentsReport.Click
        ofrmReportManager = New frmReportManager
        ofrmReportManager.sReport = "CreditAdjustments"
        ofrmReportManager.ShowDialog()
    End Sub

    Private Sub mnuManualCAARReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManualCAARReset.Click
        If Program.ofrmManualReset Is Nothing Then
            Program.ofrmManualReset = New frmManualReset
            tmrAutoReset.Stop()
            Program.ofrmManualReset.ShowDialog()
            tmrAutoReset.Start()
        Else
            SetFormFocus(Program.ofrmManualReset)
        End If
    End Sub
End Class
