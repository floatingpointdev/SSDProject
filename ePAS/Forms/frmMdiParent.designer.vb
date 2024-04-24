<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdiParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMdiParent))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.mnuSetup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTerminalConfig = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDevice = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrinterSetup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPreferences = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdateDatabase = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdateClient = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuResetDatabase = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProcessing = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRunService = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMembership = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuKioskMode = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBatchUploading = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuImportData = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuUploadAR = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUploadOtherTrans = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuUploadOfflineCATransactions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUploadOfflineSDTransactions = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuUploadCA = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUploadSD = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVoidTransactions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuResetCA = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuResetAR = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAutoResetCalendar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuManualCAARReset = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuTerminalEOD = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEmployeeMasterFileReport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuConsolidatedBilling = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReIssuedCards = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEmployeeIssuedCards = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCreditLimitAdjustmentsReport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSecurity = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGroupManager = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUserManager = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangepass = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblGroup = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrAutoReset = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetup, Me.mnuProcessing, Me.mnuReports, Me.mnuSecurity, Me.mnuAccount})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuSetup
        '
        Me.mnuSetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTerminalConfig, Me.mnuDevice, Me.mnuPrinterSetup, Me.mnuPreferences, Me.mnuUpdate, Me.mnuResetDatabase})
        Me.mnuSetup.Image = Global.SSDProject.My.Resources.Resources.Settings
        Me.mnuSetup.Name = "mnuSetup"
        Me.mnuSetup.Size = New System.Drawing.Size(65, 20)
        Me.mnuSetup.Text = "&Setup"
        '
        'mnuTerminalConfig
        '
        Me.mnuTerminalConfig.Image = Global.SSDProject.My.Resources.Resources.configuration
        Me.mnuTerminalConfig.Name = "mnuTerminalConfig"
        Me.mnuTerminalConfig.Size = New System.Drawing.Size(196, 22)
        Me.mnuTerminalConfig.Text = "&Terminal Configuration"
        '
        'mnuDevice
        '
        Me.mnuDevice.Image = Global.SSDProject.My.Resources.Resources.devices
        Me.mnuDevice.Name = "mnuDevice"
        Me.mnuDevice.Size = New System.Drawing.Size(196, 22)
        Me.mnuDevice.Text = "&Reader Setup"
        '
        'mnuPrinterSetup
        '
        Me.mnuPrinterSetup.Image = Global.SSDProject.My.Resources.Resources.printer
        Me.mnuPrinterSetup.Name = "mnuPrinterSetup"
        Me.mnuPrinterSetup.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrinterSetup.Text = "&Printer Setup"
        '
        'mnuPreferences
        '
        Me.mnuPreferences.Image = Global.SSDProject.My.Resources.Resources.preferences
        Me.mnuPreferences.Name = "mnuPreferences"
        Me.mnuPreferences.Size = New System.Drawing.Size(196, 22)
        Me.mnuPreferences.Text = "Pre&ferences"
        Me.mnuPreferences.Visible = False
        '
        'mnuUpdate
        '
        Me.mnuUpdate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpdateDatabase, Me.mnuUpdateClient})
        Me.mnuUpdate.Image = Global.SSDProject.My.Resources.Resources.process
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(196, 22)
        Me.mnuUpdate.Text = "&Update"
        Me.mnuUpdate.Visible = False
        '
        'mnuUpdateDatabase
        '
        Me.mnuUpdateDatabase.Name = "mnuUpdateDatabase"
        Me.mnuUpdateDatabase.Size = New System.Drawing.Size(154, 22)
        Me.mnuUpdateDatabase.Text = "Database"
        '
        'mnuUpdateClient
        '
        Me.mnuUpdateClient.Name = "mnuUpdateClient"
        Me.mnuUpdateClient.Size = New System.Drawing.Size(154, 22)
        Me.mnuUpdateClient.Text = "Client Software"
        Me.mnuUpdateClient.Visible = False
        '
        'mnuResetDatabase
        '
        Me.mnuResetDatabase.Name = "mnuResetDatabase"
        Me.mnuResetDatabase.Size = New System.Drawing.Size(196, 22)
        Me.mnuResetDatabase.Text = "Reset &Database"
        '
        'mnuProcessing
        '
        Me.mnuProcessing.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRunService, Me.mnuMembership, Me.ToolStripSeparator2, Me.mnuKioskMode, Me.mnuBatchUploading, Me.mnuVoidTransactions, Me.mnuResetCA, Me.mnuResetAR, Me.mnuAutoResetCalendar, Me.mnuManualCAARReset})
        Me.mnuProcessing.Image = Global.SSDProject.My.Resources.Resources.process
        Me.mnuProcessing.Name = "mnuProcessing"
        Me.mnuProcessing.Size = New System.Drawing.Size(92, 20)
        Me.mnuProcessing.Text = "P&rocessing"
        '
        'mnuRunService
        '
        Me.mnuRunService.Image = Global.SSDProject.My.Resources.Resources.ACS_image1
        Me.mnuRunService.Name = "mnuRunService"
        Me.mnuRunService.Size = New System.Drawing.Size(184, 22)
        Me.mnuRunService.Text = "Run Service"
        '
        'mnuMembership
        '
        Me.mnuMembership.Image = Global.SSDProject.My.Resources.Resources.Member_icon
        Me.mnuMembership.Name = "mnuMembership"
        Me.mnuMembership.Size = New System.Drawing.Size(184, 22)
        Me.mnuMembership.Text = "Mem&bership"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'mnuKioskMode
        '
        Me.mnuKioskMode.Image = Global.SSDProject.My.Resources.Resources.touch_screen_kiosk_icon
        Me.mnuKioskMode.Name = "mnuKioskMode"
        Me.mnuKioskMode.Size = New System.Drawing.Size(184, 22)
        Me.mnuKioskMode.Text = "Kiosk Mode"
        '
        'mnuBatchUploading
        '
        Me.mnuBatchUploading.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuImportData, Me.ToolStripSeparator3, Me.mnuUploadAR, Me.mnuUploadOtherTrans, Me.ToolStripSeparator4, Me.mnuUploadOfflineCATransactions, Me.mnuUploadOfflineSDTransactions, Me.ToolStripSeparator5, Me.mnuUploadCA, Me.mnuUploadSD})
        Me.mnuBatchUploading.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuBatchUploading.Name = "mnuBatchUploading"
        Me.mnuBatchUploading.Size = New System.Drawing.Size(184, 22)
        Me.mnuBatchUploading.Text = "Batch Uploading"
        '
        'mnuImportData
        '
        Me.mnuImportData.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuImportData.Name = "mnuImportData"
        Me.mnuImportData.Size = New System.Drawing.Size(259, 22)
        Me.mnuImportData.Text = "&Upload Employee Master File"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(256, 6)
        Me.ToolStripSeparator3.Visible = False
        '
        'mnuUploadAR
        '
        Me.mnuUploadAR.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadAR.Name = "mnuUploadAR"
        Me.mnuUploadAR.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadAR.Text = "Upload Salary Deduction Payments"
        '
        'mnuUploadOtherTrans
        '
        Me.mnuUploadOtherTrans.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadOtherTrans.Name = "mnuUploadOtherTrans"
        Me.mnuUploadOtherTrans.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadOtherTrans.Text = "Upload Other Transactions"
        Me.mnuUploadOtherTrans.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(256, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'mnuUploadOfflineCATransactions
        '
        Me.mnuUploadOfflineCATransactions.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadOfflineCATransactions.Name = "mnuUploadOfflineCATransactions"
        Me.mnuUploadOfflineCATransactions.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadOfflineCATransactions.Text = "Upload Offline CA Transactions"
        Me.mnuUploadOfflineCATransactions.Visible = False
        '
        'mnuUploadOfflineSDTransactions
        '
        Me.mnuUploadOfflineSDTransactions.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadOfflineSDTransactions.Name = "mnuUploadOfflineSDTransactions"
        Me.mnuUploadOfflineSDTransactions.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadOfflineSDTransactions.Text = "Upload Offline SD Transactions"
        Me.mnuUploadOfflineSDTransactions.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(256, 6)
        Me.ToolStripSeparator5.Visible = False
        '
        'mnuUploadCA
        '
        Me.mnuUploadCA.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadCA.Name = "mnuUploadCA"
        Me.mnuUploadCA.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadCA.Text = "Upload CA Credit Limit"
        Me.mnuUploadCA.Visible = False
        '
        'mnuUploadSD
        '
        Me.mnuUploadSD.Image = Global.SSDProject.My.Resources.Resources.import
        Me.mnuUploadSD.Name = "mnuUploadSD"
        Me.mnuUploadSD.Size = New System.Drawing.Size(259, 22)
        Me.mnuUploadSD.Text = "Upload SD Credit Limit"
        Me.mnuUploadSD.Visible = False
        '
        'mnuVoidTransactions
        '
        Me.mnuVoidTransactions.Image = Global.SSDProject.My.Resources.Resources.void
        Me.mnuVoidTransactions.Name = "mnuVoidTransactions"
        Me.mnuVoidTransactions.Size = New System.Drawing.Size(184, 22)
        Me.mnuVoidTransactions.Text = "Void Transactions"
        '
        'mnuResetCA
        '
        Me.mnuResetCA.Image = Global.SSDProject.My.Resources.Resources.refresh
        Me.mnuResetCA.Name = "mnuResetCA"
        Me.mnuResetCA.Size = New System.Drawing.Size(184, 22)
        Me.mnuResetCA.Text = "Reset CA"
        '
        'mnuResetAR
        '
        Me.mnuResetAR.Image = Global.SSDProject.My.Resources.Resources.refresh
        Me.mnuResetAR.Name = "mnuResetAR"
        Me.mnuResetAR.Size = New System.Drawing.Size(184, 22)
        Me.mnuResetAR.Text = "Reset AR"
        '
        'mnuAutoResetCalendar
        '
        Me.mnuAutoResetCalendar.Image = Global.SSDProject.My.Resources.Resources.refresh
        Me.mnuAutoResetCalendar.Name = "mnuAutoResetCalendar"
        Me.mnuAutoResetCalendar.Size = New System.Drawing.Size(184, 22)
        Me.mnuAutoResetCalendar.Text = "AutoReset Calendar"
        '
        'mnuManualCAARReset
        '
        Me.mnuManualCAARReset.Image = Global.SSDProject.My.Resources.Resources.refresh
        Me.mnuManualCAARReset.Name = "mnuManualCAARReset"
        Me.mnuManualCAARReset.Size = New System.Drawing.Size(184, 22)
        Me.mnuManualCAARReset.Text = "Manual CA/AR Reset"
        Me.mnuManualCAARReset.Visible = False
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuTerminalEOD, Me.mnuEmployeeMasterFileReport, Me.mnuConsolidatedBilling, Me.mnuReIssuedCards, Me.mnuEmployeeIssuedCards, Me.mnuCreditLimitAdjustmentsReport})
        Me.mnuReports.Image = Global.SSDProject.My.Resources.Resources.reports
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(75, 20)
        Me.mnuReports.Text = "Re&ports"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(241, 6)
        '
        'mnuTerminalEOD
        '
        Me.mnuTerminalEOD.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuTerminalEOD.Name = "mnuTerminalEOD"
        Me.mnuTerminalEOD.Size = New System.Drawing.Size(244, 22)
        Me.mnuTerminalEOD.Text = "Terminal End-Of-Day Report"
        '
        'mnuEmployeeMasterFileReport
        '
        Me.mnuEmployeeMasterFileReport.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuEmployeeMasterFileReport.Name = "mnuEmployeeMasterFileReport"
        Me.mnuEmployeeMasterFileReport.Size = New System.Drawing.Size(244, 22)
        Me.mnuEmployeeMasterFileReport.Text = "Employee Master File Report"
        '
        'mnuConsolidatedBilling
        '
        Me.mnuConsolidatedBilling.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuConsolidatedBilling.Name = "mnuConsolidatedBilling"
        Me.mnuConsolidatedBilling.Size = New System.Drawing.Size(244, 22)
        Me.mnuConsolidatedBilling.Text = "Consolidated Billing Report"
        '
        'mnuReIssuedCards
        '
        Me.mnuReIssuedCards.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuReIssuedCards.Name = "mnuReIssuedCards"
        Me.mnuReIssuedCards.Size = New System.Drawing.Size(244, 22)
        Me.mnuReIssuedCards.Text = "Re-Issued Cards Report"
        '
        'mnuEmployeeIssuedCards
        '
        Me.mnuEmployeeIssuedCards.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuEmployeeIssuedCards.Name = "mnuEmployeeIssuedCards"
        Me.mnuEmployeeIssuedCards.Size = New System.Drawing.Size(244, 22)
        Me.mnuEmployeeIssuedCards.Text = "Employee Issued Cards Report"
        '
        'mnuCreditLimitAdjustmentsReport
        '
        Me.mnuCreditLimitAdjustmentsReport.Image = Global.SSDProject.My.Resources.Resources.custom_reports
        Me.mnuCreditLimitAdjustmentsReport.Name = "mnuCreditLimitAdjustmentsReport"
        Me.mnuCreditLimitAdjustmentsReport.Size = New System.Drawing.Size(244, 22)
        Me.mnuCreditLimitAdjustmentsReport.Text = "Credit Limit Adjustments Report"
        '
        'mnuSecurity
        '
        Me.mnuSecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGroupManager, Me.mnuUserManager})
        Me.mnuSecurity.Image = Global.SSDProject.My.Resources.Resources.Security
        Me.mnuSecurity.Name = "mnuSecurity"
        Me.mnuSecurity.Size = New System.Drawing.Size(77, 20)
        Me.mnuSecurity.Text = "S&ecurity"
        '
        'mnuGroupManager
        '
        Me.mnuGroupManager.Image = Global.SSDProject.My.Resources.Resources.groups
        Me.mnuGroupManager.Name = "mnuGroupManager"
        Me.mnuGroupManager.Size = New System.Drawing.Size(157, 22)
        Me.mnuGroupManager.Text = "&Group Manager"
        Me.mnuGroupManager.ToolTipText = "Manages the groups and accessibility."
        '
        'mnuUserManager
        '
        Me.mnuUserManager.Image = Global.SSDProject.My.Resources.Resources.User
        Me.mnuUserManager.Name = "mnuUserManager"
        Me.mnuUserManager.Size = New System.Drawing.Size(157, 22)
        Me.mnuUserManager.Text = "U&ser Manager"
        Me.mnuUserManager.ToolTipText = "Manages user accounts."
        '
        'mnuAccount
        '
        Me.mnuAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChangepass, Me.mnuLogOut})
        Me.mnuAccount.Image = Global.SSDProject.My.Resources.Resources.clients
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.Size = New System.Drawing.Size(80, 20)
        Me.mnuAccount.Text = "A&ccount"
        '
        'mnuChangepass
        '
        Me.mnuChangepass.Image = Global.SSDProject.My.Resources.Resources.change_pass
        Me.mnuChangepass.Name = "mnuChangepass"
        Me.mnuChangepass.Size = New System.Drawing.Size(168, 22)
        Me.mnuChangepass.Text = "&Change Password"
        Me.mnuChangepass.ToolTipText = "Changes the password of the current user."
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Image = Global.SSDProject.My.Resources.Resources.logout48
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(168, 22)
        Me.mnuLogOut.Text = "&Logout"
        Me.mnuLogOut.ToolTipText = "Logs out the current user."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUser, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblGroup})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel1.Text = "Logged in as: "
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(68, 17)
        Me.lblUser.Text = "USERNAME"
        Me.lblUser.ToolTipText = "User currently logged in."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel3.Text = "           Group: "
        '
        'lblGroup
        '
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(46, 17)
        Me.lblGroup.Text = "GROUP"
        Me.lblGroup.ToolTipText = "Current user's security level."
        '
        'tmrAutoReset
        '
        Me.tmrAutoReset.Enabled = True
        Me.tmrAutoReset.Interval = 60000
        '
        'frmMdiParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SSDProject.My.Resources.Resources.e_PAS_800_X_600
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMdiParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tap Card System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProcessing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSecurity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUserManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGroupManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChangepass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblGroup As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDevice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembership As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTerminalConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateClient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRunService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPreferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKioskMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBatchUploading As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUploadCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUploadAR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUploadOtherTrans As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUploadOfflineCATransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUploadOfflineSDTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTerminalEOD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuUploadSD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrinterSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmployeeMasterFileReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetAR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVoidTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsolidatedBilling As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrAutoReset As System.Windows.Forms.Timer
    Friend WithEvents mnuAutoResetCalendar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReIssuedCards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmployeeIssuedCards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCreditLimitAdjustmentsReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuManualCAARReset As System.Windows.Forms.ToolStripMenuItem

End Class
