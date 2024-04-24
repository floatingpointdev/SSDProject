Public Class frmConfirmTrans

    Private _sDetails As String

    Public Property sDetails() As String
        Get
            Return _sDetails
        End Get
        Set(ByVal value As String)
            _sDetails = value
        End Set
    End Property

    Private Sub frmConfirmTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDetails.Text = sDetails
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        If txtRefCode.Text.Trim() = "" Then
            MsgBox("POS Receipt Number is required.")
            Exit Sub
        End If
        sPOSRefCode = txtRefCode.Text.Trim()
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        DialogResult = Windows.Forms.DialogResult.No
    End Sub
End Class