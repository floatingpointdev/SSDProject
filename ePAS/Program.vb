'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''CHANGE LOG:                                                                                            ''
''
''Latest Modification by:                                                                                ''
''  RVL
''Latest Modified date:                                                                                  ''
''  03.12.2012 - Added Expiry class for trial periods
''  02.25.2012 - Added prevention of running multiple instances
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Configuration
Imports System.IO.Ports

Module Program
    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    'DLL Declarations
    Private oLicense As LicenseLib.LicenseLib 'don't declare as New so as not to execute the New Event of LicenseLib
    Private oDBSetup As New DBSetup.DatabaseSetup
    Public oReader As New ACR1222L_Lib.ACR1222L

    Public Declare Function NtBeep Lib "kernel32" Alias "Beep" (ByVal FreqHz As Integer, ByVal DurationMs As Integer) As Integer

    'Entities
    Public eConn As New SQLConnection_Entity 'by DPD, 08.30

    'Global Variables
    Public lMDIParentHeight, lMDIParentWidth, hPort, lMaxSector, igHCard As Long
    Public sCardEvent, acsDevice, sEvent, sCardId, sSerCardId, sCOMPort, sCurrentDevice, sRpt, sDoorPort, sEmpId, sPassword, sDevices As String
    Public sPrinterPort As String = ""
    Public sPrinterBaudRate As String = ""
    Public iDelay, iOkBtnPressedFor, iMode As Integer
    Public bIsRestricted As Boolean

    Public iAccountType, iSuperAccountType As Integer

    Public bytAck(), bytFrame() As Byte
    Public sExpiry, sCardType As String

    Public bConnected As Boolean = False
    Public sUserName, sGroupCode As String
    Public sSuperUserName, sSuperGroupCode As String

    Public dRangeFrom, dRangeTo As Date

    Public sImportMode As String = ""
    Public sSiteName As String = ""
    Public sConcessionaire As String = ""
    Public sTerminalID As String = ""
    Public bDisplayPhoto As Boolean = False

    Public bViewOnly As Boolean = True

    Public sIPAddress As String = ""
    Public sHostName As String = ""
    Public iSDMin As Integer = 0
    Public iSDMax As Integer = 0
    Public iCAMin As Integer = 0
    Public iCAMax As Integer = 0

    Public bKioskMode As Boolean = False
    Public bSSD As Boolean = False

    Public sPOSRefCode As String = ""

    Public sSites As String = ""
    Public sMembers As String = ""

    Public bAutoPrint As Boolean = False

    Private bIsLicensed As Boolean = False
    Public iLicensePeriod As Integer = 0
    Public iLicensePeriodSpan As Integer = 0

    Public bUseLocalDB As Boolean = True
    Public bUseServerDB As Boolean = False
    Public bUseCloud As Boolean = False


    'Constants
    Public Const IDLE_MODE As Integer = 0
    Public Const CONTACTLESS_MODE As Integer = 1
    Public Const MANUAL_MODE As Integer = 2
    Public Const EMPLOYEE_ID As Integer = 0
    Public Const PASSWORD As Long = 1

    'Worker Class
    Public oSQLLogs As New SQLTransaction_Worker
    Public oSQLUserAccounts As New SQLUserAccounts_Worker
    Public oSQLReader As New SQLReaderSetup_Worker
    Public oSQLMember As New SQLMember_Worker
    Public oSQLCard As New SQLCard_Worker
    Public oSQLLoyalty As New SQLLoyalty_Worker
    Public oEncDec As New EncryptDecrypt_Helper
    Public oDBHelper As New Database_Helper
    Public oSQLRewards As New SQLRewards_Worker
    Public oSQLAR As New SQLAR_Worker
    Public oSQLCA As New SQLCA_Worker
    Public oSQLDatabase As New SQLDatabase_Worker
    Public oSQLPrintLog As New SQLPrintLog_Worker

    'Other Class Instantiations
    Public oCommon As New Common_Helper
    Public oPrinter As New RawPrinterHelper
    Public WithEvents oSerialPort As New SerialPort()

    'Form Instantiations
    'Public ofrmDBSetup As frmDBSetup = Nothing
    Public ofrmMemberManager As frmMemberManager = Nothing
    Public ofrmGroupManager As frmGroupManager = Nothing
    Public ofrmInputBox As frmInputBox = Nothing
    'Public ofrmTransactionLogs As frmTransactionLogs = Nothing
    'Public ofrmCardInitialization As frmCardInitialization = Nothing
    Public ofrmLogin As frmLogin = Nothing
    Public ofrmMdiParent As frmMdiParent = Nothing
    Public ofrmReaderSetup As frmReaderSetup = Nothing
    'Public ofrmLoyalty As frmLoyalty = Nothing
    Public ofrmUserAccounts As frmUserAccounts = Nothing
    Public ofrmUserManager As frmUserManager = Nothing
    'Public ofrmValueCard As frmValueCard = Nothing
    'Public ofrmAccumulate As frmAccumulate = Nothing
    'Public ofrmRedeem As frmRedeem = Nothing
    Public ofrmReportViewer As frmReportViewer = Nothing
    Public ofrmDateRange As frmDateRange = Nothing
    'Public ofrmRunStandalone As frmStandaloneService = Nothing
    Public ofrmImportData As frmImportData = Nothing
    Public ofrmTerminalConfig As frmTerminalConfig = Nothing
    'Public ofrmRewardsViewer As frmRewardsViewer = Nothing
    'Public ofrmVoidTrans As frmVoidTrans = Nothing
    Public ofrmCardDeleteTool As frmCardDeleteTool = Nothing
    Public ofrmService As frmService = Nothing
    'Public ofrmPreferences As frmPreferences = Nothing
    Public ofrmBalanceInqKiosk As frmBalanceInqKiosk = Nothing
    'Public ofrmCACreditLogs As frmCACreditLogs = Nothing
    Public ofrmVoidCardTrans As frmVoidCardTrans = Nothing
    Public ofrmSuperLogin As frmSuperLogin = Nothing
    'Public ofrmCAMaintenance As frmCAMaintenance = Nothing
    'Public ofrmSalaryDeductionMaintenance As frmSalaryDeductionMaintenance = Nothing
    Public ofrmPrinterSetup As frmPrinterSetup = Nothing
    Public ofrmVoidedTransViewer As frmVoidedTransViewer = Nothing
    Public ofrmVoidCorrection As frmVoidCorrection = Nothing
    Public ofrmResetCalendar As frmResetCalendar = Nothing
    Public ofrmManualReset As frmManualReset = Nothing

    Sub Main()
        Dim dlgResult As New DialogResult
        Dim sDatabaseName As String = ""
        Dim bCreateServerDB As Boolean = False
        Dim bEncrypt As Boolean = False
        Dim bShowSplash As Boolean = True

        Dim s As String = oEncDec.Decrypt("xk5Oum1Frf7eQNqPwJIhLw==")

        oLicense = New LicenseLib.LicenseLib

        oDBSetup.sManufacturerEmail = "support@smartcard.com.ph"
        oLicense.sManufacturerEmail = oDBSetup.sManufacturerEmail
        oLicense.iSplashImageBG = Nothing

        If Process.GetProcessesByName _
                (Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show _
            ("Another Instance of this process is already running",
            "Multiple Instances Forbidden",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            Application.Exit()
        Else

            oLicense.bSuppressWarning = True
            oLicense.iLicensePeriod = 365
            oLicense.sAppDetails = Application.ProductVersion.ToString() & "," & iLicensePeriod.ToString()
            oLicense.iLicensePeriod = -1 'to bypass licensing, indicate -1, any other number is the number of days this application will expire

            Try
                bIsLicensed = oLicense.ProcessLicense(Application.ProductName.ToString())
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            bIsLicensed = True 'override licensing

            If bIsLicensed Then
                iLicensePeriod = oLicense.iLicensePeriod
                iLicensePeriodSpan = oLicense.iLicensePeriodSpan


                oCommon.SetDateFormat()

                sHostName = System.Net.Dns.GetHostName
                For Each ipAddress As System.Net.IPAddress In System.Net.Dns.GetHostEntry(sHostName).AddressList
                    If ipAddress.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                        sIPAddress = ipAddress.ToString()
                        Exit For
                    End If
                Next

                oDBSetup.sAppDetails = Application.ProductVersion.ToString() & "," & iLicensePeriod.ToString()


                bUseLocalDB = config.AppSettings.Settings("UseLocalDB").Value
                bUseServerDB = config.AppSettings.Settings("UseServerDB").Value

                sDatabaseName = ""

                'Check RFID Reader Driver
                If oReader.gRetCode <> 0 Then
                    MessageBox.Show("RFID Reader Not Found Or Driver not installed.",
                                    "RFID Check",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                End If

                bCreateServerDB = False
                bEncrypt = False
                bShowSplash = True

                '=For Cloud Connectivity======================================================================================

                'bUseCloud = config.AppSettings.Settings("UseCloud").Value

                'If bUseCloud Then
                '    If Not oDBSetup.StartCloudProxy("future-name-371301", "sctcloudsql2017x", "127.0.0.1", "1433") Then
                '        MsgBox("Unable to start proxy for cloud.", MsgBoxStyle.Exclamation, Application.ProductName)
                '        Environment.Exit(0)
                '    End If
                'End If

                'If oDBSetup.CloudConnect(eConn.sConnString,
                '                      "future-name-371301",
                '                      "sctcloudsql2017x",
                '                      "127.0.0.1",
                '                      "1433",
                '                      sDatabaseName,
                '                      "sqlserver",
                '                      "Smartcard@2023",
                '                      bShowSplash,
                '                      Nothing) Then
                '=============================================================================================================

                '=Comment this block of Cloud Connectivity is used============================================================
                If oDBSetup.ConfigDatabase(eConn.sConnString,'pass the config file value, gets updated with updated value after execution of this function
                                           eConn.sConnStringServer,
                                           bUseLocalDB,
                                           bUseServerDB, 'use server db instead of localdb
                                           sDatabaseName, 'leave this blank if bUseServerDB is enabled
                                           bCreateServerDB, 'for use with LocalDB only
                                           bEncrypt,
                                           bShowSplash,
                                           Nothing) Then
                    '=============================================================================================================
                    eConn = New SQLConnection_Entity
                    Do
                        ofrmLogin = New frmLogin
                        dlgResult = ofrmLogin.ShowDialog()


                        'Dim ofrmTest = New frmStandaloneService2
                        'dlgResult = ofrmTest.ShowDialog()
                        'End

                        If dlgResult = DialogResult.OK Then
                            Dim ofrmMDIParent As New frmMdiParent
                            dlgResult = ofrmMDIParent.ShowDialog()
                        End If
                    Loop While (dlgResult <> DialogResult.Cancel)

                    If bUseCloud Then
                        oDBSetup.CloudDisconnect()
                    End If
                End If
            End If

        End If

    End Sub

    ' Values for "AppSet" property which sets the trial version
    ' to true or false. 
    ' "3ZCaP+CfPnw=" = false "TGjXO2zGzlk=" = true

    Public Function HandleRegistry() As Boolean
        'Dim firstRunDate As Date
        Dim sFirstRunDate As String = ""
        sFirstRunDate = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\INSTALLER\SCTTNA", "FirstRun", Nothing)
        If sFirstRunDate = Nothing Then
            'firstRunDate = Now
            sFirstRunDate = oEncDec.Encrypt(Now.ToShortDateString())
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\INSTALLER\SCTTNA", "FirstRun", sFirstRunDate)
        ElseIf (Now - Convert.ToDateTime(oEncDec.Decrypt(sFirstRunDate))).Days > 30 Then
            Return False
        End If
        Return True
    End Function
End Module
