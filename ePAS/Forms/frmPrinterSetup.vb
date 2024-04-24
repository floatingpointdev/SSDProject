Imports System.Configuration

Public Class frmPrinterSetup
    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Private Sub frmPrinterSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sArrPorts As String()

        sArrPorts = IO.Ports.SerialPort.GetPortNames()
        For Each sCOMPort In sArrPorts
            cboCOMPorts.Items.Add(sCOMPort)
        Next

        cboCOMPorts.Text = config.AppSettings.Settings("PrinterPort").Value()
        cboBaudrates.Text = config.AppSettings.Settings("PrinterBaudRate").Value()
        chkAutoPrint.Checked = config.AppSettings.Settings("AutoPrint").Value()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Program.sPrinterPort = cboCOMPorts.Text
        Program.sPrinterBaudRate = cboBaudrates.Text
        Program.bAutoPrint = chkAutoPrint.Checked

        config.AppSettings.Settings.Item("PrinterPort").Value = cboCOMPorts.Text
        config.AppSettings.Settings.Item("PrinterBaudRate").Value = cboBaudrates.Text
        config.AppSettings.Settings.Item("AutoPrint").Value = chkAutoPrint.Checked

        config.Save(System.Configuration.ConfigurationSaveMode.Modified, True)

        MsgBox("Configuration updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub frmPrinterSetup_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Program.ofrmPrinterSetup = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class