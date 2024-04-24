Public Class frmValueCard

    Private Sub btnValueCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValueCard.Click
        If Program.sCurrentDevice = "ACR122U" Then
            'If oACR122U.CardConnect(Program.acsDevice) = 0 Then
            '    'TODO: Fix
            '    'If oClsCtrl.SetVal(0, 4) Then
            '    'Else
            '    '    oClsCtrl.ErrorBox("Failed.")
            '    'End If
            'End If
        End If
    End Sub

    Private Sub frmValueCard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing       
        ofrmValueCard = Nothing
    End Sub

    Private Sub frmValueCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCommon.SetCenterPosition(Me)
    End Sub

End Class