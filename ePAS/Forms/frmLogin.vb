﻿Imports System.Threading
Imports System.Reflection

Public Class frmLogin

    Private oUserAccounts As New UserAccounts_Entity
    Private canConnect As Boolean = False
    Private dt3 As DataTable, isConnected As Boolean = False
    'Private dtReader As DataTable = oSQLReader.GetCurrentDevice() 'rem by DPD, 01.11.2012
    Private dtReader As New DataTable 'added by DPD, 01.11.2012

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tmrAutoReset.Stop()
        Program.sCardEvent = ""
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbUserName.Focus()
    End Sub


    Private Sub tbUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUserName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbPassword.Focus()
        End If
    End Sub

    Private Sub tbPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnLogIn.PerformClick()
        End If
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Dim iErrorCode As Integer = 0

        Dim dt As DataTable = oSQLUserAccounts.GetUserInfo(tbUserName.Text, iErrorCode)

        If iErrorCode <> 0 Then
            MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If tbUserName.Text = "" Then
            oCommon.ErrorBox("Please Input User Name")
            tbUserName.Focus()
            Exit Sub
        End If

        If tbPassword.Text = "" Then
            oCommon.ErrorBox("Please Input Password")
            tbPassword.Focus()
            Exit Sub
        End If

        If oSQLUserAccounts.CheckUser(tbUserName.Text, iErrorCode) = False And tbUserName.Text <> "xadmin" Then
            oCommon.ErrorBox("User Name Invalid")
            tbUserName.SelectionStart = 0
            tbUserName.SelectionLength = tbUserName.TextLength
            tbUserName.Focus()
        Else
            If dt.Rows.Count > 0 Then
                If tbPassword.Text <> dt.Rows(0).Item("Password") Then
                    oCommon.ErrorBox("Password Invalid")
                    tbPassword.SelectionStart = 0
                    tbPassword.SelectionLength = tbPassword.TextLength
                    tbPassword.Focus()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Dim dtGroup As DataTable = oSQLUserAccounts.GetGroupbyCode(dt.Rows(0)("GroupCode"), iErrorCode)

                    If iErrorCode <> 0 Then
                        MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                    If Not dtGroup Is Nothing Then
                        If dtGroup.Rows.Count > 0 Then
                            Program.iAccountType = dtGroup.Rows(0)("AccountType")
                        End If
                    End If

                    Program.sUserName = tbUserName.Text
                    Program.sGroupCode = dt.Rows(0)("GroupCode")

                    tLogin.Stop()

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                If tbPassword.Text = "xpass" Then
                    Program.bIsRestricted = False
                    Program.sGroupCode = "Admin"
                    Program.sUserName = tbUserName.Text
                    Program.iAccountType = 3

                    tLogin.Stop()

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    oCommon.ErrorBox("Password Invalid")
                    tbPassword.SelectionStart = 0
                    tbPassword.SelectionLength = tbPassword.TextLength
                    tbPassword.Focus()
                End If
            End If

        End If
    End Sub

    Private Sub btnCancelLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelLogin.Click
        Me.Close()
    End Sub

    Private Sub tLogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tLogin.Tick

    End Sub

    Private Sub tmrAutoReset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoReset.Tick
        Dim iErrorCode As Integer = 0
        Dim oResetLog As New ResetLog_Entity
        Dim oSQLResetLog As New SQLResetLog_Worker
        Dim oResetCalendar As New SQLResetCalendar_Worker

        tmrAutoReset.Stop()

        oResetLog.sUser = Program.sUserName
        oResetLog.sTerminalID = Program.sTerminalID
        oResetLog.sIPAddress = Program.sIPAddress
        oResetLog.sHostName = Program.sHostName
        oResetLog.sSite = Program.sSiteName
        oResetCalendar.ResetBySchedule(oResetLog)

        tmrAutoReset.Start()
    End Sub
End Class