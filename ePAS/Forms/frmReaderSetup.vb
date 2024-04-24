Imports System.IO.Ports
Imports System.Configuration

Public Class frmReaderSetup

    Private dtReader As DataTable = oSQLReader.GetCurrentDevice()
    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Dim bRetVal As Boolean

        btnSet.Enabled = False

        If cmbReaders.SelectedIndex < 0 Then
            oCommon.ErrorBox("No Reader Selected.")
            Exit Sub
        End If

        '1. Get user selected values
        'Program.sDevices = cboReaders.SelectedItem.ToString()
        Program.sDevices = cmbReaders.Text
        Program.sCOMPort = cboCOMPort.Text

        '2. Connect to COM Port
        If cboCOMPort.Enabled Then
            If cboCOMPort.Text = "" Then
                oCommon.ErrorBox("Invalid COM Port settings.")
                btnSet.Enabled = True
                Exit Sub
            Else
                'Reset ports
                'If oSerialPort.IsOpen Then oSerialPort.Close()
                'bRetVal = oSerialCommWorker.OpenComm(Program.sCOMPort, _
                '                                           19200, SerialComm_Worker.enumParity.None, 8, SerialComm_Worker.enumStopBits.One)
                'If bRetVal = False Then
                '    If Program.bIsRestricted Then
                '        oClsCtrl.ErrorBox("Invalid COM Port settings. Please contact your system administrator.")
                '    Else
                '        oClsCtrl.ErrorBox("Invalid COM Port settings.")
                '    End If
                '    btnSet.Enabled = True
                '    Exit Sub
                'Else
                '    oSerialPort.Close()
                'End If
            End If

            bRetVal = False

        End If

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

            Me.Close()
        Else

            oCommon.ErrorBox("No device found.")
        End If


        'If cmbReaders.SelectedIndex < 0 Then
        '    oClsCtrl.ErrorBox("No Readers Selected")
        '    Exit Sub
        'End If

        ''Reset ports    

        ''Test the settings first before saving...
        'Program.sCurrentDevice = cmbReaders.SelectedItem.ToString()
        'If cboCOMPort.SelectedIndex <> -1 Then
        '    Program.sCOMPort = cboCOMPort.SelectedItem.ToString()
        'End If

        'Select Case Program.sCurrentDevice

        '    'Case "ACR122U"
        '    '    If oACR122U.Initialize() = 0 Then
        '    '        Program.acsDevice = oACR122U.GetDeviceName()
        '    '        If Program.acsDevice <> "" Then
        '    '            Program.bConnected = True
        '    '        End If
        '    '    End If           
        'End Select

        'If Program.bConnected = False Then
        '    oClsCtrl.ErrorBox("Unable to connect to the device.")
        '    Exit Sub
        'End If

        ''Save the settings
        'oSQLReader.UpdateDevice(Program.sCurrentDevice, Program.sCOMPort)

        'dtReader = oSQLReader.GetCurrentDevice()

        ''DONE: Before using .Rows(0), be sure to check first if dt has rows, or else it will cause an error.
        ''Program.sDevices = dt.Rows(0)("DeviceName")
        'If Not dtReader Is Nothing Then
        '    If dtReader.Rows.Count > 0 Then
        '        Program.sCurrentDevice = dtReader.Rows(0)("DeviceName")
        '        If dtReader.Rows(0)("COMPort") IsNot DBNull.Value Then
        '            Program.sCOMPort = dtReader.Rows(0)("COMPort")
        '        End If
        '        oClsCtrl.ShowBox("Default Reader Setup Done.")
        '    End If
        'End If
        btnSet.Enabled = True
    End Sub

    Private Sub frmReaderSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmReaderSetup = Nothing
    End Sub

    Private Sub frmReaderSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sArrPorts As String()
        Dim sDevices As String()
        Dim sCOMPort As String
        Dim dtDevices As New DataTable

        'Get reader in configuration

        Program.sDevices = config.AppSettings.Settings("DeviceName").Value
        Program.sCOMPort = config.AppSettings.Settings("COMPort").Value

        cboCOMPort.Enabled = config.AppSettings.Settings("COMEnabled").Value

        If cboCOMPort.Enabled Then
            sArrPorts = IO.Ports.SerialPort.GetPortNames()
            For Each sCOMPort In sArrPorts
                cboCOMPort.Items.Add(sCOMPort)
            Next
        End If

        'List support devices
        dtDevices.Columns.Add("DeviceName")
        dtDevices.Columns.Add("COMEnabled")

        sDevices = config.AppSettings.Settings("Devices").Value.Split(",")
        For i As Integer = 0 To sDevices.Length - 1
            Dim sItem As String() = sDevices(i).Split("-")
            dtDevices.Rows.Add(sItem(0), sItem(1))
        Next

        cmbReaders.DataSource = dtDevices
        cmbReaders.DisplayMember = "DeviceName"
        cmbReaders.ValueMember = "COMEnabled"

        'Dim sarrPorts As String() = IO.Ports.SerialPort.GetPortNames()
        'Dim sPort As String

        'For Each sPort In sarrPorts
        '    cboCOMPort.Items.Add(sPort)
        'Next

        'If dtReader IsNot Nothing Then
        '    If dtReader.Rows.Count > 0 Then
        '        cmbReaders.SelectedIndex = cmbReaders.FindString(dtReader.Rows(0)("DeviceName").ToString())
        '        cboCOMPort.SelectedIndex = cboCOMPort.FindString(dtReader.Rows(0)("COMPort").ToString())
        '    End If

        '    cmbReaders.SelectedIndex = -1
        'End If

        'cboCOMPort.SelectedIndex = -1
        'cboCOMPort.Enabled = False
    End Sub

    Private Sub cmbReaders_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReaders.SelectionChangeCommitted
        Select Case cmbReaders.SelectedItem.ToString
            Case "ACR38"
                'picDevice.Image = My.Resources.ACR38U
                cboCOMPort.SelectedIndex = -1
                cboCOMPort.Enabled = False
            Case "ViVOPay5000"
                cboCOMPort.Enabled = True
                'picDevice.Image = My.Resources.vivo
            Case "iProx"
                picDevice.Image = My.Resources.iProx
                cboCOMPort.SelectedIndex = -1
                cboCOMPort.Enabled = False
            Case "ACR122U"
                'picDevice.Image = My.Resources.ACR122U
                cboCOMPort.SelectedIndex = -1
                cboCOMPort.Enabled = False
            Case "PCR310U"
                picDevice.Image = My.Resources.PCR310U
                cboCOMPort.Enabled = True
            Case Else
                picDevice.Image = Nothing
                cboCOMPort.SelectedIndex = -1
                cboCOMPort.Enabled = False
        End Select
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
