Public Class frmVoidCorrection

    Public dAmount As Double = 0.0
    Public sIncidentReportNo As String = ""
    Private Sub frmConfirmTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIncidentReportNo.Text = ""
        txtAmount.Text = ""
        txtIncidentReportNo.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtIncidentReportNo.Text.Trim() = "" Then
            MsgBox("Incident Report Number is required.")
            Exit Sub
        End If

        If txtAmount.Text.Trim() = "" Then
            MsgBox("Amount is required.")
            Exit Sub
        End If

        sIncidentReportNo = txtIncidentReportNo.Text.Trim()
        dAmount = Val(txtAmount.Text.Trim())

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class