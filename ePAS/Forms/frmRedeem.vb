Public Class frmRedeem

    Private oMember As New Member_Entity
    Private oCard As New Card_Entity
    Private oLog As New Transaction_Entity
    Private bRes As Boolean = False
    Private iCurrPts, iRewards As Double

    Private Sub frmRedeem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      
        ofrmRedeem = Nothing

    End Sub

    Private Sub frmRedeem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCommon.SetCenterPosition(Me)
    End Sub

    Private Function CheckLoyalty() As Boolean
        Dim dDateOnly As Date
        Dim dt As DataTable
        Dim iErrorCode As Integer = 0

        'oClsCtrl.DisplayPresent()
        MessageBox.Show("Tap Card")
        oMember.sCardID = "" 'oClsCtrl.GetCardID()
        oCard.sCardID = oMember.sCardID
        If oMember.sCardID = "" Then
            oCommon.ErrorBox("Card ID not detected")
            Return False
        End If
        If oSQLCard.CheckCard(oCard) = False Then
            oCommon.ErrorBox("Loyalty card not found")
            Return False
        End If
        dt = oSQLMember.GetMemberByCardID(oMember, iErrorCode)

        'TODO: 
        If iErrorCode Then

        End If

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                dDateOnly = dt.Rows(0)("Expiry")
                dDateOnly = dDateOnly.Date
                If dDateOnly >= Date.Now.Date Then
                    oLog.sCardID = oMember.sCardID
                Else
                    oCommon.ErrorBox("Loyalty card expired")
                    Return False
                End If
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim dt As DataTable

        bRes = False
        While bRes = False
            If CheckLoyalty() Then
                bRes = True
                dt = oSQLCard.GetCardDetailsByID(oCard)
                iCurrPts = 0 'oClsCtrl.GetVal(2) 'TODO: Fix
                If dt.Rows(0)("RewardForm") = True Then
                    txtRewardForm.Text = "Cash"
                Else
                    txtRewardForm.Text = "Gift"
                End If
                'rem by DPD, 01.26.2012, should not show the remainder, so it must be an integer division
                'iRewards = (iCurrPts / dt.Rows(0)("PointThreshold")) * dt.Rows(0)("Rewards")

                'added by DPD, 01.26.2012
                iRewards = (iCurrPts \ dt.Rows(0)("PointThreshold")) * dt.Rows(0)("Rewards")

                'added by DPD, 01.24.2012
                If iCurrPts >= dt.Rows(0)("PointThreshold") Then
                    txtRewards.Text = iRewards
                Else
                    txtRewards.Text = "0"
                End If

            Else
                If oCommon.QBox("Continue?", "") = Windows.Forms.DialogResult.No Then
                    bRes = True
                End If
            End If
        End While
    End Sub

    Private Sub btnRedeem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedeem.Click
        Dim dt As New DataTable
        Dim iSubVal As Double

        If oCommon.QBox("Redeem all rewards?", "Confirmation") = Windows.Forms.DialogResult.Yes Then
            'added by DPD, 01.26.2012, should leave the remaining points
            dt = oSQLCard.GetCardDetailsByID(oCard)
            iSubVal = (iCurrPts \ dt.Rows(0)("PointThreshold")) * dt.Rows(0)("PointThreshold")

            'rem by DPD, 01.26.2012
            'If oClsCtrl.SubVal(iCurrPts, 4) Then
            'xTODO: FIx
            'If oClsCtrl.SubVal(iSubVal, 2) Then
            '    oCard.iPoints = 0
            '    oSQLCard.AddPointsToCard(oCard)
            '    oLog.sCardID = oCard.sCardID
            '    oLog.dTransDate = Date.Now
            '    oLog.sTransMode = "Redeem"
            '    oLog.sRemarks = ""

            '    'added by DPD, 01.26.2012
            '    oLog.iPoints = iSubVal
            '    oSQLLogs.AddLog(oLog)
            'Else
            'End If
            btnCheck_Click(sender, e)
        End If
    End Sub

End Class