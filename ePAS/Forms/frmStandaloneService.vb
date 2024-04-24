Imports System.ComponentModel

Public Class frmStandaloneService
    Private bStopService As Boolean = False
    Private tmrDate As New Timer With {.Interval = 100}


    Private Sub tmrService_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrService.Tick
        Dim iErrorCode As Integer = 0
        Dim oLog As New Transaction_Entity
        Dim dtMember, dtLoyalty, dtRewards As New DataTable
        Dim iOldBal As Integer = 0
        Dim oMember As New Member_Entity
        Dim oLoyalty As New Loyalty_Entity
        Dim oRewards As New Rewards_Entity
        Dim bytImage As Byte()

        Dim iTotalRewards As Integer = 0
        Dim bHasRewards As Boolean = False

        Static Dim isIdle As Boolean
        Static Dim sOldCardID As String
        Static Dim iLapse As Integer


        'Dim dDate As Date
        'Dim tSpan As New TimeSpan

        tmrService.Enabled = False

        If bStopService = True Then Exit Sub

        'Detect Card presence
        If oReader.ConnectCard() = 0 Then
            oReader.LoadAuthentication()
            oMember.sCardID = oReader.GetCardID(iErrorCode)
            'Threading.Thread.Sleep(10)
            'oReader.ClearLCD()
            DisplayDontRemoveCard()
            'Get Loyalty Code where card is enrolled
            '--------------------------------------------------
            dtMember = oSQLMember.GetMemberByCardID(oMember)
            '--------------------------------------------------

            If Not dtMember Is Nothing Then
                If dtMember.Rows.Count > 0 Then
                    'Get details of the Loyalty Code
                    oLoyalty.sLoyaltyCode = dtMember.Rows(0)("LoyaltyCode").ToString()
                    '--------------------------------------------------
                    dtLoyalty = oSQLLoyalty.GetLoyaltyByCode(oLoyalty)
                    '--------------------------------------------------
                    oMember.sFName = dtMember.Rows(0)("FName")
                    oMember.sLName = dtMember.Rows(0)("LName")
                    If Not dtLoyalty Is Nothing Then
                        oRewards.sMemberID = dtMember.Rows(0)("MemberID").ToString()
                        If dtLoyalty.Rows.Count > 0 Then
                            Dim dr As DataRow = dtLoyalty.Rows(0)
                            If dr("LoyaltyMode") = 0 Then 'Point System
                                oLoyalty.iLoyaltyMode = 0
                                If dr("Operation") = 0 Then 'Incremental
                                    oLoyalty.iOperation = 0
                                Else 'Decremental
                                    oLoyalty.iOperation = 1
                                    oLoyalty.iDecrementBy = CInt(dr("DecrementBy"))
                                    If dr("WillExpire") = 0 Then
                                        oLoyalty.bWillExpire = False
                                        'Check available rewards
                                        '--------------------------------------------------
                                        dtRewards = oSQLRewards.GetRewardsByMemberID(oRewards)
                                        '--------------------------------------------------
                                        If Not dtRewards Is Nothing Then
                                            For Each drRewards As DataRow In dtRewards.Rows
                                                iTotalRewards += drRewards("ConsumablePoints")
                                            Next

                                            If iTotalRewards >= oLoyalty.iDecrementBy Then
                                                If sOldCardID <> oMember.sCardID Then
                                                    'First tap, balance inquiry                                                    
                                                    oReader.DisplayLCD("Hi, you have", False, 4, 1, 2)
                                                    oReader.DisplayLCD(iTotalRewards.ToString(), True, 4, 2, 3)
                                                    oReader.DisplayLCD("points.", False, 4, 2, 6)
                                                    oReader.DisplayLCD("Please tap again", False, 4, 3, 0)
                                                    oReader.DisplayLCD("to claim.", False, 4, 4, 3)
                                                    pbStatus.Text = "Balance Inquiry"
                                                    sOldCardID = oMember.sCardID
                                                    iLapse = 0
                                                Else
                                                    'Second tap, process transaction
                                                    For Each drRewards As DataRow In dtRewards.Rows
                                                        oRewards.iID = drRewards("ID")
                                                        If drRewards("ConsumablePoints") >= oLoyalty.iDecrementBy Then
                                                            iOldBal = drRewards("ConsumablePoints")

                                                            With oLog
                                                                .dTransDate = Now
                                                                .iPoints = oLoyalty.iDecrementBy
                                                                .sCardID = oMember.sCardID
                                                                .sMemberID = oRewards.sMemberID
                                                                .sTransMode = "Redeem"
                                                                .sSite = Program.sSiteName
                                                                .sConcessionaire = Program.sConcessionaire
                                                                .iRewardsRefID = oRewards.iID
                                                            End With

                                                            'This process is transaction based, if something happens on connectivity, changes will rollback
                                                            If oSQLLogs.ProcessTransaction(oLog, oRewards.iID, oLoyalty.iDecrementBy) Then 'If oSQLLogs.AddLog(oLog) >= -1 Then
                                                                'If oSQLRewards.DeductRewardsByTransID(oRewards, oLoyalty.iDecrementBy) >= -1 Then
                                                                iTotalRewards = oSQLRewards.GetCurrentRewardsByMemberID(oRewards)

                                                                If iTotalRewards >= 0 Then
                                                                    iErrorCode = oReader.ConnectCard()
                                                                    oReader.AuthenticateBlock(4)
                                                                    iErrorCode = oReader.WriteValue(4, iTotalRewards)
                                                                Else
                                                                    DisplayServerOffline(oMember.sCardID)
                                                                    sOldCardID = ""
                                                                    isIdle = False
                                                                    GoTo Skip0
                                                                End If

                                                                PopulateLogs()
                                                                'Else
                                                                '    DisplayServerOffline(oMember.sCardID)
                                                                '    sOldCardID = ""
                                                                '    isIdle = False
                                                                '    GoTo Skip0
                                                                'End If
                                                            Else
                                                                DisplayServerOffline(oMember.sCardID)
                                                                sOldCardID = ""
                                                                isIdle = False
                                                                GoTo Skip0
                                                            End If
                                                            Exit For
                                                        End If
                                                    Next
                                                    oReader.ClearLCD()
                                                    oReader.DisplayLCD("Prev Rwrds: " + iOldBal.ToString(), False, 4, 1, 0)
                                                    oReader.DisplayLCD("Redeemed  : " + oLoyalty.iDecrementBy.ToString(), False, 4, 2, 0)
                                                    oReader.DisplayLCD("Curr Rwrds: " + iTotalRewards.ToString(), False, 4, 3, 0)
                                                    oReader.DisplayLCD("Thank You", True, 4, 4, 3)
                                                    pbStatus.Text = "Reward(s) Claimed"
                                                    Application.DoEvents()
                                                    PopulateLogs()
                                                    sOldCardID = ""
                                                End If
                                            Else
                                                oReader.ClearLCD()
                                                oReader.DisplayLCD("Sorry,", False, 4, 1, 5)
                                                oReader.DisplayLCD("you don't have", False, 4, 2, 1)
                                                oReader.DisplayLCD("enough  rewards.", False, 4, 3, 0)
                                                pbStatus.Text = "Sorry, not enough rewards."
                                                oReader.BuzzerControl(5)
                                                sOldCardID = ""
                                            End If

                                            txtCIMNumber.Text = oRewards.sMemberID
                                            txtName.Text = oMember.sLName + ", " + oMember.sFName
                                            txtAvailableRewards.Text = iTotalRewards
                                            oMember.sMemberID = oRewards.sMemberID
                                            '--------------------------------------------------
                                            bytImage = oSQLMember.GetPhotoByMemberID(oMember)
                                            '--------------------------------------------------
                                            If bytImage Is Nothing Then
                                                pbImage.Image = My.Resources.ACS_image1
                                            Else
                                                pbImage.Image = oCommon.ByteToImage(bytImage)
                                            End If

                                            Wait(oMember.sCardID)
                                        Else 'if dtRewards is nothing
                                            DisplayServerOffline(oMember.sCardID)
                                            sOldCardID = ""
                                            isIdle = False
                                            GoTo Skip0
                                        End If
                                    Else
                                        oLoyalty.bWillExpire = True
                                        oLoyalty.dExpiration = dr("ExpirationDate")
                                    End If

                                End If
                            Else 'Bracketing
                                oLoyalty.iLoyaltyMode = 1
                            End If 'If dr("LoyaltyMode") = 0 Then
                        Else  'If dtLoyalty.Rows.Count > 0 Then
                            Threading.Thread.Sleep(10)
                            oReader.DisplayLCD("Loyalty  Code", False, 4, 1, 2)
                            oReader.DisplayLCD("Not Defined", False, 4, 3, 3)
                            pbStatus.Text = "Loyalty Code Not Defined."
                            iErrorCode = oReader.BuzzerControl(5)
                            Wait(oMember.sCardID)
                            sOldCardID = ""
                        End If

                        isIdle = False
                    Else 'if dtLoyalty is nothing
                        DisplayServerOffline(oMember.sCardID)
                        sOldCardID = ""
                        isIdle = False
                        GoTo Skip0
                    End If
                Else 'if dtMember.Rows.Count = 0
                    'DisplayServerOffline(oMember.sCardID)
                    oReader.ClearLCD()
                    oReader.DisplayLCD("Unregistered", True, 4, 2, 2)
                    oReader.DisplayLCD("card", True, 4, 3, 6)
                    pbStatus.Text = "Unregistered Card."
                    oReader.BuzzerControl(5)
                    Wait("")
                    sOldCardID = ""
                    isIdle = False
                    GoTo Skip0
                End If
                
            Else 'if dtMember is nothing
                DisplayServerOffline(oMember.sCardID)
                sOldCardID = ""
                isIdle = False
                GoTo Skip0
            End If
        Else 'if ConnectCard is false 
Skip0:
            If isIdle = False Then 'perform the code below only once while no card detected
                oReader.ConnectReader()
                oReader.ClearLCD()
                oReader.DisplayLCD("Please", False, 0, 1, 5)
                oReader.DisplayLCD("Tap Card", False, 0, 2, 4)

                txtCIMNumber.Clear()
                txtAvailableRewards.Clear()
                txtName.Clear()
                pbImage.Image = My.Resources.ACS_image1
                If pbStatus.Text <> "Service Running" Then pbStatus.Text = "Service Running"
                isIdle = True
            End If


            If sOldCardID <> "" Then iLapse += 1

            If iLapse >= 200 Then
                iLapse = 0
                sOldCardID = ""
            End If

            'If progressbar is on marquee mode, disable the following:
            'If pbService.Value < pbService.Maximum Then
            '    pbService.PerformStep()
            'Else
            '    pbService.Value = 0
            'End If
        End If 'If oReader.ConnectCard() = 0 Then
        tmrService.Enabled = True
    End Sub

    Private Sub frmStandaloneService_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bStopService = True
        oReader.ClearLCD()
        oReader.DisplayLCD("Welcome", False, 0, 1, 4)

        Program.ofrmRunStandalone = Nothing
    End Sub

    Private Sub frmStandaloneService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler tmrDate.Tick, AddressOf tmrDate_Tick

        dgLogs.AutoGenerateColumns = False

        PopulateLogs()

        tmrDate.Enabled = True
        tmrService.Enabled = True
    End Sub

    Private Sub tmrDate_Tick()
        lblDate.Text = Now
    End Sub

    '----------------user defined functions-------------------
    Private Sub DisplayServerOffline(ByVal sCurrentCardID As String)
        pbStatus.Text = "Server Offline.  Try again later."
        oReader.ClearLCD()
        oReader.DisplayLCD("Server Offline", True, 4, 2, 1)
        oReader.DisplayLCD("Please try again", False, 4, 3, 0)
        oReader.DisplayLCD("later", False, 4, 4, 6)
        oReader.BuzzerControl(5)
        Wait(sCurrentCardID)
    End Sub

    Private Sub DisplayDontRemoveCard()
        pbStatus.Text = "Don't remove card. Please wait."
        oReader.ClearLCD()
        oReader.DisplayLCD("Don't remove", True, 4, 1, 2)
        oReader.DisplayLCD("card", True, 4, 2, 6)
        oReader.DisplayLCD("PLEASE  WAIT", False, 4, 3, 2)
    End Sub

    Private Sub Wait(ByVal sCurrentCardID As String)
        Dim iErrorCode As Integer = 0
        'Dim i As Integer

        While oReader.ConnectCard() = 0 And Me.IsDisposed = False

            Application.DoEvents()
        End While

        'While oReader.GetCardID(iErrorCode) = sCurrentCardID 'TODO:  Need to find another way, this is slow
        '    Application.DoEvents()
        '    i += 1
        '    Me.Text = i
        'End While
    End Sub

    Private Sub PopulateLogs()
        Dim dtLogs As New DataTable
        dtLogs = oSQLLogs.GetLogsByConcessionaire1(Date.Now, Date.Now, Program.sConcessionaire, Program.sSiteName)
        'dtLogs = oSQLLogs.GetLogsByConcessionaire(Date.Now, Date.Now, Program.sConcessionaire)

        If Not dtLogs Is Nothing Then
            dgLogs.DataSource = dtLogs

            If dgLogs.Rows.Count > 0 Then
                dgLogs.CurrentCell = dgLogs.Rows(dgLogs.Rows.Count - 1).Cells(0)
            End If
        Else

        End If

    End Sub

    Private Sub dgLogs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLogs.CellContentClick
        Dim oSender = DirectCast(sender, DataGridView)
        Dim iAccountTypeTmp As Integer = Program.iAccountType
        Dim sUserNameTmp As String = Program.sUserName
        Dim sGroupCode As String = Program.sGroupCode
        Dim iTransID As Integer = 0
        Dim dt As DataTable = dgLogs.DataSource


        Me.TopMost = False

        If TypeOf oSender.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            ofrmLogin = New frmLogin
            ofrmLogin.TopMost = True
            If ofrmLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Program.iAccountType = 2 Or Program.iAccountType = 3 Or Program.iAccountType = 255 Then

                    iTransID = dt.Rows(e.RowIndex)("ID")
                    oSQLLogs.VoidTransaction(iTransID, Program.sUserName)

                    dgLogs.DataSource = oSQLLogs.GetLogsByConcessionaire1(Date.Now, Date.Now, Program.sConcessionaire, Program.sSiteName)
                    'dgLogs.DataSource = oSQLLogs.GetLogsByConcessionaire(Date.Now, Date.Now, Program.sConcessionaire)

                    If dgLogs.Rows.Count > 0 Then
                        dgLogs.CurrentCell = dgLogs.Rows(dgLogs.Rows.Count - 1).Cells(0)
                    End If
                    MsgBox("Transaction Voided.", MsgBoxStyle.Information)
                Else
                    MsgBox("Unauthorized Account.", MsgBoxStyle.Information)
                End If
                Program.iAccountType = iAccountTypeTmp
                Program.sUserName = sUserNameTmp
                Program.sGroupCode = sGroupCode

            End If
        End If
        Me.TopMost = True
    End Sub
End Class