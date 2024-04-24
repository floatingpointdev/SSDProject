Public Class frmOverrideCredits

    Public sMemberID As String = ""
    Private oCA As New CA_Entity
    Private oAR As New AR_Entity

    Private Sub frmOverrideCredits_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmOverrideCredits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iErrorCode As Integer = 0

        Dim dtCA As New DataTable

        Dim dtAR As New DataTable

        'Load credits of the Member
        oCA.sMemberID = sMemberID
        dtCA = oSQLCA.GetCAByMemberID(oCA, iErrorCode)

        oAR.sMemberID = sMemberID
        dtAR = oSQLAR.GetARByMemberID(oAR, iErrorCode)

        If Not dtCA Is Nothing Then
            txtCA.Text = dtCA.Rows(0)("CAAmount").ToString()
            txtCABalance.Text = dtCA.Rows(0)("CAConsumable").ToString()
        End If

        If Not dtAR Is Nothing Then
            txtAR.Text = dtAR.Rows(0)("ARAmount").ToString()
            txtARBalance.Text = dtAR.Rows(0)("ARConsumable").ToString()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        oCA.dCAAmount = Val(txtCA.Text)
        oCA.dCAConsumable = Val(txtCABalance.Text)
        oCA.sUpdatedBy = sUserName

        oAR.dARAmount = Val(txtAR.Text)
        oAR.dARConsumable = Val(txtARBalance.Text)
        oAR.sUpdatedBy = sUserName

        If oCA.dCAAmount < 0 Then
            MsgBox("Invalid CA value.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oCA.dCAConsumable < 0 Then
            MsgBox("Invalid CA Consumable value.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oAR.dARAmount < 0 Then
            MsgBox("Invalid AR value.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oAR.dARConsumable < 0 Then
            MsgBox("Invalid AR Consumable value.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oCA.dCAConsumable > oCA.dCAAmount Then
            MsgBox("CA Consumable must not be greater than the CA (Reference\Initial).", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oAR.dARConsumable > oAR.dARAmount Then
            MsgBox("AR Consumable must not be greater than the AR (Reference\Initial).", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to override the values?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        If oSQLCA.UpdateCAByMemberID(oCA) <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oSQLCA.UpdateCAConsumableByMemberID(oCA) <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oSQLAR.UpdateARByMemberID(oAR) <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If oSQLAR.UpdateARConsumableByMemberID(oAR) <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        MsgBox("Successfully updated.", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class