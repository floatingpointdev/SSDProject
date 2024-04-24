Imports System.Configuration

Public Class frmPreferences
    Private oSQLPreferences As New SQLPreferences_Worker
    Private oPreferences As New Preferences_Entity

    Private config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Private Sub frmPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPreferences()

        chkSSD.Checked = config.AppSettings.Settings("SSD").Value()
    End Sub

    Private Sub LoadPreferences()
        Dim dt As New DataTable
        dt = oSQLPreferences.GetPreferences(oPreferences)

        txtMVRMin.Text = 0
        txtMVRMax.Text = 0
        txtSDMin.Text = 0
        txtSDMax.Text = 0

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                txtMVRMin.Text = Val(dt.Rows(0)("MVRMinLimit"))
                txtMVRMax.Text = Val(dt.Rows(0)("MVRMaxLimit"))
                txtSDMin.Text = Val(dt.Rows(0)("SalaryDeductionMinLimit"))
                txtSDMax.Text = Val(dt.Rows(0)("SalaryDeductionMaxLimit"))

                oPreferences.iMVRMin = Val(txtMVRMin.Text)
                oPreferences.iMVRMax = Val(txtMVRMax.Text)
                oPreferences.iSDMin = Val(txtSDMin.Text)
                oPreferences.iSDMax = Val(txtSDMax.Text)
            End If
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        oPreferences.iMVRMin = Val(txtMVRMin.Text)
        oPreferences.iMVRMax = Val(txtMVRMax.Text)
        oPreferences.iSDMin = Val(txtSDMin.Text)
        oPreferences.iSDMax = Val(txtSDMax.Text)
        oSQLPreferences.UpdatePreferences(oPreferences)

        Program.iSDMin = oPreferences.iSDMin
        Program.iSDMax = oPreferences.iSDMax
        Program.iMVRMin = oPreferences.iMVRMin
        Program.iMVRMax = oPreferences.iMVRMax

        Program.bSSD = chkSSD.Checked

        config.AppSettings.Settings.Item("SSD").Value = chkSSD.Checked

        config.Save(System.Configuration.ConfigurationSaveMode.Modified, True)

        MsgBox("Configuration updated.  Please restart the application." & vbCrLf & "Program will now exit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmPreferences_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Program.ofrmPreferences = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class