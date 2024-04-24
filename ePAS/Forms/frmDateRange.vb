Public Class frmDateRange
    Private _dDateFrom As Date
    Private _dDateTo As Date
    Public Property DateFrom() As Date
        Get
            Return _dDateFrom
        End Get
        Set(ByVal value As Date)
            _dDateFrom = value
        End Set
    End Property

    Public Property DateTo() As Date
        Get
            Return _dDateTo
        End Get
        Set(ByVal value As Date)
            _dDateTo = value
        End Set
    End Property


    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub frmDateRange_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    If Not Program.ofrmRunStandalone Is Nothing Then
    '        Program.ofrmRunStandalone.TopMost = True
    '    End If
    '    Program.ofrmDateRange = Nothing
    'End Sub

    'Private Sub frmDateRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    If Not Program.ofrmRunStandalone Is Nothing Then
    '        Program.ofrmRunStandalone.TopMost = False
    '    End If
    '    dtFrom.Value = Date.Now
    '    dtTo.Value = Date.Now
    'End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If (DateTime.Compare(dtTo.Value, dtFrom.Value) < 0) Then
            oCommon.ErrorBox("Date to cannot be less than date from.")
            Exit Sub
        End If

        _dDateFrom = dtFrom.Value
        _dDateTo = dtTo.Value

        Program.dRangeFrom = dtFrom.Value
        Program.dRangeTo = dtTo.Value

        'Program.ofrmReportViewer = New frmReportViewer
        'Program.ofrmReportViewer.ShowDialog()

        Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub frmDateRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrom.Value = Now
        dtTo.Value = Now
    End Sub
End Class