Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports System.Configuration

Public Class frmReportViewer

    Private oReportDocument As New ReportDocument()
    Private oSQLConn As New SQLConnection_Entity
    'Private sDateFrom As String = "" 'Program.dRangeFrom
    'Private sDateTo As String = "" 'Program.dRangeTo

    Private _dDateFrom As Date
    Private _dDateTo As Date
    Private _sReport As String
    Private _sSites As String = ""
    Private _sMembers As String = ""
    Private _sCardID As String = ""

    Public Property dDateFrom() As Date
        Get
            Return _dDateFrom
        End Get
        Set(ByVal value As Date)
            _dDateFrom = value
        End Set
    End Property

    Public Property dDateTo() As Date
        Get
            Return _dDateTo
        End Get
        Set(ByVal value As Date)
            _dDateTo = value
        End Set
    End Property

    Public Property sReport() As String
        Get
            Return _sReport
        End Get
        Set(ByVal value As String)
            _sReport = value
        End Set
    End Property

    Public Property sSites() As String
        Get
            Return _sSites
        End Get
        Set(ByVal value As String)
            _sSites = value
        End Set
    End Property

    Public Property sMembers() As String
        Get
            Return _sMembers
        End Get
        Set(ByVal value As String)
            _sMembers = value
        End Set
    End Property

    Public Property sCardID() As String
        Get
            Return _sCardID
        End Get
        Set(ByVal value As String)
            _sCardID = value
        End Set
    End Property

    Private Sub frmReportViewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmReportViewer = Nothing
    End Sub

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Not Program.ofrmDateRange Is Nothing Then
        '    Program.ofrmDateRange.TopMost = False
        'End If

        picLoading.Left = (Me.Width / 2) - (picLoading.Width / 2)
        picLoading.Top = (Me.Height / 2) - (picLoading.Height / 2)

        oReportDocument.Load(Application.StartupPath + "\Reports\" + sReport + ".rpt")
        'oReportDocument.Load(Application.StartupPath + "\Reports\" + Program.sRpt + ".rpt")

        crvDTR.ShowPrintButton = True
        crvDTR.ShowExportButton = True

        Dim sConnString() As String = oSQLConn.GetSQLConnectionString.Split(";")
        Dim sDatabase As String = ""
        Dim sServer As String = ""
        Dim sUser As String = ""
        Dim sPassword As String = ""
        Dim bIntegratedSecurity As Boolean = False

        Dim sTemp() As String

        For i As Integer = 0 To sConnString.Length - 1

            If sConnString(i).StartsWith("Initial Catalog=") Then
                sTemp = sConnString(i).Split("=")
                sDatabase = sTemp(1)
            End If

            If sConnString(i).StartsWith("Data Source=") Then
                sTemp = sConnString(i).Split("=")
                sServer = sTemp(1)
            End If

            If sConnString(i).StartsWith("User ID=") Then
                sTemp = sConnString(i).Split("=")
                sUser = sTemp(1)
            End If

            If sConnString(i).StartsWith("Password=") Then
                sTemp = sConnString(i).Split("=")
                sPassword = sTemp(1)
            End If

            If sConnString(i).StartsWith("Integrated Security=") Then
                sTemp = sConnString(i).Split("=")
                bIntegratedSecurity = True
            End If
        Next


        Dim oConnInfo As New ConnectionInfo

        If bIntegratedSecurity = True Then
            oReportDocument.SetDatabaseLogon("", "", sServer, sDatabase)
        Else
            oReportDocument.SetDatabaseLogon(sUser, sPassword, sServer, sDatabase)
        End If

        ''Added by DPD, 10.24.2011
        'oReportDocument.SetParameterValue("DateFrom", Convert.ToDateTime(Program.dRangeFrom.ToShortDateString()).ToShortDateString())
        'oReportDocument.SetParameterValue("DateTo", Convert.ToDateTime(Program.dRangeTo.ToShortDateString()).ToShortDateString())

        'sDateFrom = Program.dRangeFrom
        'sDateTo = Program.dRangeTo
        If sReport = "OutstandingSD" Then
            oReportDocument.SetParameterValue("@Sites", sSites)
            oReportDocument.SetParameterValue("@Members", sMembers)
        ElseIf sReport = "IndividualTransactionLogs" Then
            oReportDocument.SetParameterValue("@CardID", sCardID)
        ElseIf sReport = "TerminalEOD" Then
            oReportDocument.SetParameterValue("@DateFrom", Convert.ToDateTime(dDateFrom).ToShortDateString())
            oReportDocument.SetParameterValue("@TerminalID", Program.sTerminalID)
        ElseIf sReport = "ConsolidatedReport" Then
            oReportDocument.SetParameterValue("@DateFrom", Convert.ToDateTime(dDateFrom).ToShortDateString())
            oReportDocument.SetParameterValue("@DateTo", Convert.ToDateTime(dDateTo).ToShortDateString())
        ElseIf sReport = "MemberCardHistory" Then
        ElseIf sReport = "ReIssuedCards" Then
        ElseIf sReport = "CreditAdjustments" Then
        Else
            oReportDocument.SetParameterValue("@DateFrom", Convert.ToDateTime(dDateFrom).ToShortDateString())
            oReportDocument.SetParameterValue("@DateTo", Convert.ToDateTime(dDateTo).ToShortDateString())
            oReportDocument.SetParameterValue("@Sites", sSites)
            oReportDocument.SetParameterValue("@Members", sMembers)
        End If

        oConnInfo.ServerName = sServer
        oConnInfo.DatabaseName = sDatabase
        oConnInfo.UserID = sUser
        oConnInfo.Password = sPassword
        oConnInfo.IntegratedSecurity = bIntegratedSecurity
        Try
            oSetDBLogonForReport(oConnInfo, oReportDocument)
            oSetDBLogonForSubreports(oConnInfo, oReportDocument)
        Catch ex As Exception
            If ex.Message.Contains("Logon failed.") Then
                MsgBox("Logon failed or Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End Try

        crvDTR.ReportSource = oReportDocument
        crvDTR.Refresh()
    End Sub

    Public Sub oSetDBLogonForReport(ByVal oConnectionInfo As ConnectionInfo, ByVal oReportDocument As ReportDocument)
        Dim oTables As Tables = oReportDocument.Database.Tables

        For Each oTbl As CrystalDecisions.CrystalReports.Engine.Table In oTables
            Dim oTableLogOnInfo As TableLogOnInfo = oTbl.LogOnInfo
            oTableLogOnInfo.ConnectionInfo = oConnectionInfo
            oTbl.ApplyLogOnInfo(oTableLogOnInfo)
            oTbl.Location = oTbl.Location.Substring(oTbl.Location.LastIndexOf(".") + 1)
        Next

    End Sub

    Public Sub oSetDBLogonForSubreports(ByVal oConnectionInfo As ConnectionInfo, ByVal oReportDocument As ReportDocument)
        Dim oSections As Sections = oReportDocument.ReportDefinition.Sections

        For Each oSection As Section In oSections
            Dim oReportObjects As ReportObjects = oSection.ReportObjects
            For Each oReportObject As ReportObject In oReportObjects
                If oReportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim oSubreportObject As SubreportObject = CType(oReportObject, SubreportObject)
                    Dim oSubReportDocument As ReportDocument = oSubreportObject.OpenSubreport(oSubreportObject.SubreportName)
                    oSetDBLogonForReport(oConnectionInfo, oReportDocument)
                End If
            Next
        Next
    End Sub

End Class