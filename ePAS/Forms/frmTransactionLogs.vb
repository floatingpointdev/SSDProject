Public Class frmTransactionLogs

    Private dlgSave As New SaveFileDialog
    Private dt As DataTable
    Private oLog As New Transaction_Entity

    Private Sub frmTransactionLogs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Program.ofrmTransactionLogs = Nothing
    End Sub

    Friend Sub Nav(Optional ByVal bSave As Boolean = 0, Optional ByVal bEdit As Boolean = 1)
        pnlSave.Enabled = bSave
        pnlAdd.Enabled = bEdit
    End Sub

    Private Sub frmTransactionLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtiFrom.Value = Date.Now
        dtiTo.Value = Date.Now
        dgv.AutoGenerateColumns = False
        'oCommon.SetCenterPosition(Me)
        Nav()
        btnRefresh.PerformClick()
        btnSearch.Enabled = False
    End Sub

    Private Sub LoadDgv()

        If DateTime.Compare(dtiTo.Value, dtiFrom.Value) < 0 Then
            oCommon.ErrorBox("Date to cannot be less than date from.")
            Exit Sub
        End If

        dt = oSQLLogs.GetLogs(dtiFrom.Value, dtiTo.Value)
        dgv.DataSource = dt
        If dgv.Rows.Count > 0 Then
            dgv.CurrentCell.Selected = False
            dgv.Rows(dgv.Rows.Count - 1).Selected = True
            dgv.CurrentCell = dgv.SelectedCells(0)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim dtA As DataTable = Program.oSQLLogs.GetLogsBySearch(cboSearchBy.Text, tbSearch.Text)
        If Not dtA Is Nothing Then
            If dtA.Rows.Count > 0 Then
                dgv.DataSource = dtA
                dgv.AutoGenerateColumns = False
            Else
                dgv.DataSource = Nothing
                oCommon.ErrorBox("No results found")

            End If
        Else
            dgv.DataSource = Nothing
            oCommon.ErrorBox("No results found")
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadDgv()
        cboSearchBy.SelectedIndex = -1
    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged
        If cboSearchBy.Text = "" Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnExportText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportText.Click
        dlgSave.Filter = "txt files (*.txt)|*.txt"
        Export()
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        dlgSave.Filter = "csv files (*.csv)|*.csv"
        Export()
    End Sub

    Private Sub Export()
        ' dt As DataTable = oSQLLogs.GetLogs(dtiFrom.Value, dtiTo.Value)
        Dim sRow As String = ""

        dlgSave.FilterIndex = 2
        dlgSave.RestoreDirectory = True

        If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sw As New IO.StreamWriter(dlgSave.OpenFile())
            If (sw IsNot Nothing) Then
                For i As Integer = 0 To dt.Columns.Count - 1
                    sRow = sRow & dt.Columns(i).ColumnName & ", "
                Next
                sw.WriteLine(sRow)
                For Each row As DataRow In dt.Rows
                    sRow = ""
                    For i As Integer = 0 To dt.Columns.Count - 1
                        sRow = sRow & row(i).ToString & ", "
                    Next
                    sw.WriteLine(sRow)
                Next
                sw.Close()
                sw.Dispose()
                dt.Dispose()
                If oCommon.QBox("Would you like to open file now?", "Successfully Exported") _
                    = Windows.Forms.DialogResult.Yes Then
                    Process.Start(dlgSave.FileName)
                End If
            End If
        End If

    End Sub

    Friend Sub Clear()
        tbCardID.Text = ""
        dtiTransDate.Focus()
        dtiTransDate.Value = dtiTransDate.MinDate
        tbPoints.Text = ""
        cboTransMode.SelectedIndex = -1
        tbRemarks.Text = ""
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Nav(1, 0)
        dtiTransDate.Focus()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgv.SelectedRows.Count > 0 Then
            If oCommon.QBox("Are You Sure?", "Remove Data") = Windows.Forms.DialogResult.Yes Then
                oLog.dTransDate = dgv.SelectedCells("colTransDate").Value
                oSQLLogs.DeleteLog(oLog)
                Clear()
                LoadDgv()
                dgv_SelectionChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub dgv_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.SelectionChanged
        If dgv.SelectedRows.Count > 0 And dgv.RowCount > 0 Then
            'tbCardID.Text = dgv.SelectedCells(0).Value
            'dtiTransDate.Value = dgv.SelectedCells(1).Value
            'tbPoints.Text = dgv.SelectedCells(2).Value
            'cboTransMode.Text = dgv.SelectedCells(3).Value
            'tbRemarks.Text = dgv.SelectedCells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Nav()
        LoadDgv()
        dgv_SelectionChanged(sender, e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
        Nav()
        dgv_SelectionChanged(sender, e)
    End Sub

End Class