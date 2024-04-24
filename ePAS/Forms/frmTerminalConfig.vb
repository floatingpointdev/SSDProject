Imports System.Configuration

Public Class frmTerminalConfig
    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        config.AppSettings.Settings.Item("SiteName").Value = txtSiteName.Text.Trim()
        'config.AppSettings.Settings.Item("ConcessionaireName").Value = txtConcessionaire.Text.Trim()
        config.AppSettings.Settings.Item("TerminalID").Value = txtTerminalID.Text.Trim()
        config.Save(System.Configuration.ConfigurationSaveMode.Modified, True)
        Program.sSiteName = config.AppSettings.Settings("SiteName").Value
        'Program.sConcessionaire = config.AppSettings.Settings("ConcessionaireName").Value
        Program.sTerminalID = config.AppSettings.Settings("TerminalID").Value

        MsgBox("Configuration updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub frmTerminalConfig_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmTerminalConfig = Nothing
    End Sub

    Private Sub frmTerminalConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Program.sSiteName = config.AppSettings.Settings("SiteName").Value
        'Program.sConcessionaire = config.AppSettings.Settings("ConcessionaireName").Value
        Program.sTerminalID = config.AppSettings.Settings("TerminalID").Value
        txtSiteName.Text = Program.sSiteName
        'txtTerminalID.Text = Program.sConcessionaire
        txtTerminalID.Text = Program.sTerminalID
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class