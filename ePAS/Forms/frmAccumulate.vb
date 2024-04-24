Public Class frmAccumulate

    Private oMember As New Member_Entity
    Private oLog As New Transaction_Entity
    Private oCard As New Card_Entity
    Private bRes As Boolean = False

    Private Sub frmAccumulate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
        ofrmAccumulate = Nothing
    End Sub

    Private Sub frmAccumulate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCommon.SetCenterPosition(Me)
    End Sub

    Private Function CheckLoyalty() As Boolean
        Dim dt As DataTable
        Dim dDateOnly As Date

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
        dt = oSQLMember.GetMemberByCardID(oMember)
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

    Private Sub btnGetBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetBalance.Click
        txtAmount.Text = ""
        txtPoints.Text = ""
        txtBalance.Text = ""
        bRes = False
        'While bRes = False
        '    If CheckLoyalty() Then
        '        bRes = True
        '        If oClsCtrl.DisplayPresent() Then
        '            Select Case Program.sCurrentDevice
        '                Case "ACR38"
        '                    txtBalance.Text = oClsCtrl.GetVal(2)
        '                Case "ViVOPay5000"
        '                    txtBalance.Text = oClsCtrl.GetVal(2)
        '                    oViVo.StoreLCDMsg(oSerialPort, "%F1%P0117Balance:\%F2%Pcc29%S1-- " & _
        '                        txtBalance.Text, 17)
        '                    oViVo.SetLCDMsg(oSerialPort, 17, 0)
        '                Case Else
        '                    txtBalance.Text = oClsCtrl.GetVal(2)
        '            End Select
        '        End If
        '    Else
        '        If oClsCtrl.QBox("Continue?", "") = Windows.Forms.DialogResult.No Then
        '            bRes = True
        '        End If
        '    End If
        'End While
    End Sub

    Private Sub btnAddPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPoints.Click
        Dim dt As DataTable
        Dim iAmt, iTotPts, iAmtEq, iPtsEq As Double
        Dim bRes1 As Boolean = False, bRes2 As Boolean = False
        Dim sTempVal As String = ""

        'tbAmount.Text = ""

        bRes = False
        While bRes = False
            If CheckLoyalty() Then
                bRes = True
                dt = oSQLCard.GetCardDetailsByID(oCard)

                If txtAmount.Text = "" Then
                    iAmt = 0
                Else
                    iAmt = CInt(txtAmount.Text)
                End If
                iAmtEq = dt.Rows(0)("Amount")
                iPtsEq = dt.Rows(0)("PointsRatio")
                'rem by DPD, 01.26.2012, for example:
                '  for every 200 pesos, gain 50 points
                '  if purchased amount is 300, it should only gain 50 points, not 75 points

                'iTotPts = (iAmt / iAmtEq) * iPtsEq

                '...so this should be an integer division:

                iTotPts = (iAmt \ iAmtEq) * iPtsEq

                'If oClsCtrl.DisplayPresent() Then
                '    Select Case Program.sCurrentDevice
                '        Case "ACR38"
                '            sTempVal = oClsCtrl.GetVal(2)
                '        Case Else
                '            sTempVal = oClsCtrl.GetVal(2)
                '    End Select
                '    If sTempVal = "0" Then
                '        Select Case Program.sCurrentDevice
                '            Case "ACR122U"
                '                If oACR122U.ValWrite(iTotPts, 2) Then
                '                    bRes1 = True
                '                End If
                '            Case Else
                '                bRes2 = oClsCtrl.AddVal(iTotPts, 2)
                '        End Select
                '    ElseIf sTempVal = "0" Then
                '        Select Case Program.sCurrentDevice
                '            Case "CLOUD 4710F"
                '                If oACR122U.ValWrite(iTotPts, 2) Then
                '                    bRes1 = True
                '                End If
                '            Case Else
                '                bRes2 = oClsCtrl.AddVal(iTotPts, 2)
                '        End Select
                '    Else
                '        Select Case Program.sCurrentDevice
                '            Case "ACR38"
                '                bRes2 = oClsCtrl.AddVal(iTotPts, 2)
                '            Case Else
                '                bRes2 = oClsCtrl.AddVal(iTotPts, 2)
                '        End Select
                '        If bRes2 Then
                '            bRes1 = True
                '        End If
                '    End If
                '    If bRes1 Then
                '        txtPoints.Text = iTotPts
                '        oCard.iPoints = oClsCtrl.GetVal(2)
                '        oSQLCard.AddPointsToCard(oCard)
                '        txtBalance.Text = oCard.iPoints
                '        oLog.sCardID = oCard.sCardID
                '        oLog.dTransDate = Date.Now
                '        oLog.sTransMode = "Accumulate"
                '        oLog.sRemarks = ""
                '        oLog.iPoints = oCard.iPoints 'added by DPD, 01.26.2012
                '        oSQLLogs.AddLog(oLog)
                '    End If
                'End If
            Else
                If oCommon.QBox("Continue?", "") = Windows.Forms.DialogResult.No Then
                    bRes = True
                End If
            End If
        End While

    End Sub

End Class