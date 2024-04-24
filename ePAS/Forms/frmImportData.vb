Public Class frmImportData

    Private oExcel As New OLEDBExcel_Worker
    Private sFile As String = ""
    Private dsSource As New DataSet

    Private Sub frmImportData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ofrmImportData = Nothing
    End Sub

    Private Sub frmImportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtTarget As New DataTable
        Dim dtMappings As New DataTable
        Dim iErrorCode As Integer = 0

        dtMappings.Columns.Add("TargetFields")
        dtMappings.Columns.Add("SourceFields")
        dgMappings.AutoGenerateColumns = False

        Me.Text = Me.Text & " - " & sImportMode

        Select Case Program.sImportMode
            Case "MasterFile"
                'Get the field names of the table
                dtTarget = oDBHelper.GetTableFields("dbo.tbl_MemberDetails", iErrorCode)

                If iErrorCode <> 0 Then
                    MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                For Each dr As DataRow In dtTarget.Rows
                    Select Case dr("name")
                        Case "ID", "Photo", "LoyaltyCode", "ContactNo", "Email", "Birthdate"
                        Case "MembershipDate", "Expiry", "DepartmentCode", "GroupCode"                        
                        Case "DateUploaded", "DateUpdated", "UploadedBy", "UpdatedBy"
                        Case "DateAdded", "AddedBy", "IPAddress", "HostName"
                        Case "SiteName", "TerminalID"
                        Case "Active"
                        Case Else
                            dtMappings.Rows.Add(dr("name"), "")
                    End Select
                Next dr
                dtMappings.Rows.Add("AR", "")
                dtMappings.Rows.Add("CA", "")

                dgMappings.Height = 243

                dgMappings.DataSource = dtMappings

            Case "CA"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_CA"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("CAAmount")
                dtTarget.Rows.Add("ApplicableYear")
                'dtTarget.Rows.Add("ApplicablePayOut")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings
            Case "SALARY DEDUCTION PAYMENTS"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_SalaryDeduction"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("PaymentAmount")
                'dtTarget.Rows.Add("ApplicableMonth")
                dtTarget.Rows.Add("Remarks")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings

            Case "OTHER TRANSACTIONS"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_OtherTrans"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("TransDate")
                dtTarget.Rows.Add("Amount")
                dtTarget.Rows.Add("TransType")
                dtTarget.Rows.Add("Remarks")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings

            Case "OFFLINE CA TRANSACTIONS"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_CALog"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("TransDate")
                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("Location")
                dtTarget.Rows.Add("Amount")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings
            Case "OFFLINE SD TRANSACTIONS"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_ARLog"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("TransDate")
                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("Location")
                dtTarget.Rows.Add("Amount")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings
            Case "CA Credit Limit"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_CA"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("CreditLimit")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings
            Case "SD Credit Limit"
                grpValidity.Visible = False
                dtTarget.TableName = "tbl_SD"
                dtTarget.Columns.Add("name")

                dtTarget.Rows.Add("MemberID")
                dtTarget.Rows.Add("CreditLimit")

                For Each dr As DataRow In dtTarget.Rows
                    dtMappings.Rows.Add(dr("name"), "")
                Next dr

                dgMappings.DataSource = dtMappings

        End Select
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim dt As New DataTable
        Dim oMember As New Member_Entity
        Dim oRewards As New Rewards_Entity
        Dim oCA As New CA_Entity
        Dim oCALog As New CALog_Entity
        Dim oAR As New AR_Entity
        Dim oARLog As New ARLog_Entity

        Dim oOtherTrans As New OtherTransactions_Entity

        Dim iRowCount As Integer = 0

        Dim dtUploaded As New DataTable
        Dim dtFailed As New DataTable
        Dim dtTemp As New DataTable

        Dim iErrorCode As Integer = 0

        btnImport.Enabled = False

        Select Case Program.sImportMode
            Case "MasterFile"
                dtUploaded.Columns.Add("MemberID")
                dtUploaded.Columns.Add("Name")
                dtUploaded.Columns.Add("Reason")

                dtFailed.Columns.Add("MemberID")
                dtFailed.Columns.Add("Name")
                dtFailed.Columns.Add("Reason")

                dgUploaded.DataSource = dtUploaded
                dgFailed.DataSource = dtFailed

                'The Target fields are at Column 0 and the Source fields are at Column 1
                dt = dgMappings.DataSource
                If dt.Rows.Count > 0 Then
                    For Each drSource As DataRow In dsSource.Tables(0).Rows
                        For Each dr As DataRow In dt.Rows
                            If dr(1).ToString() <> "" Then
                                Select Case dr(0)
                                    Case "MemberID"
                                        oMember.sMemberID = drSource(dr(1)).ToString()
                                    Case "CardID"
                                        oMember.sCardID = drSource(dr(1)).ToString()
                                    Case "FName"
                                        oMember.sFName = drSource(dr(1)).ToString()
                                    Case "LName"
                                        oMember.sLName = drSource(dr(1)).ToString()
                                    Case "MName"
                                        oMember.sMName = drSource(dr(1)).ToString()
                                    Case "Address"
                                        oMember.sAddress = drSource(dr(1)).ToString()
                                    Case "ContactNo"
                                        oMember.sContactNo = drSource(dr(1)).ToString()
                                    Case "BirthDate"
                                        oMember.dBirthdate = drSource(dr(1))
                                    Case "Email"
                                        oMember.sEmail = drSource(dr(1)).ToString()
                                    Case "MembershipDate"
                                        oMember.dMembershipDate = drSource(dr(1))
                                    Case "Expiry"
                                        oMember.dLExpiry = drSource(dr(1))
                                    Case "DepartmentCode"
                                        oMember.sDepartmentCode = drSource(dr(1)).ToString()
                                    Case "GroupCode"
                                        oMember.sDepartmentCode = drSource(dr(1)).ToString()
                                    Case "LoyaltyCode"
                                        oMember.sLoyaltyCode = drSource(dr(1)).ToString()
                                    Case "CompanyCode"
                                        oMember.sCompanyCode = drSource(dr(1)).ToString()
                                    Case "AR"
                                        oAR.dARAmount = drSource(dr(1))
                                    Case "CA"
                                        oCA.dCAAmount = drSource(dr(1))
                                End Select
                            End If
                        Next
                        If Not oSQLMember.CheckMember(oMember, iErrorCode) Then
                            If iErrorCode <> 0 Then
                                MsgBox("Server is OFFLINE.  Please try again later.", MsgBoxStyle.Information)
                                Exit For
                            End If
                            pbProgress.Visible = True
                            If pbProgress.Value > 100 Then
                                pbProgress.Value = 0
                            Else
                                pbProgress.PerformStep()
                            End If

                            iRowCount += 1

                            If oMember.sMemberID Is Nothing Then oMember.sMemberID = ""

                            If oMember.sMemberID.Trim() = "" Then
                                'MsgBox("Member ID is blank.  Upload will terminate.", MsgBoxStyle.Information + MsgBoxStyle.Information)
                                'btnImport.Enabled = True
                                'Exit Sub
                                dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                  "Incomplete data.")
                            Else
                                If oSQLMember.IsUIDExist(oMember.sCardID) Then
                                    dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                        "Duplicate CardID.")
                                Else
                                    Try
                                        oMember.sUploadedBy = Program.sUserName
                                        'Inserts new member
                                        oMember.bActive = True
                                        oSQLMember.UploadMemberWithBalance(oMember, oAR, oCA)
                                        dtUploaded.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                          "Added.")
                                    Catch ex As Exception
                                        dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                          "Incomplete data.")
                                        MsgBox("Incomplete data in your Excel File. Row index: " + iRowCount, MsgBoxStyle.Information)
                                    End Try
                                End If


                            End If
                        Else 'Member Exists
                            If oMember.sCardID Is Nothing Then
                                oMember.sCardID = ""
                            End If

                            If oMember.sCardID.Trim() = "" Then
                                Try
                                    oMember.sUpdatedBy = Program.sUserName
                                    oSQLMember.UpdateUploadMemberWithBalance(oMember, oAR, oCA)
                                    dtUploaded.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                      "Updated.")

                                Catch ex As Exception
                                    dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                      "Incomplete data.")
                                    MsgBox("Incomplete data in your Excel File. Row index: " + iRowCount, MsgBoxStyle.Information)
                                End Try
                            Else
                                'Checks if memberid and cardid both exist
                                If Not oSQLMember.IsUIDFree(oMember.sCardID, oMember.sMemberID) Then
                                    dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                         "Duplicate CardID")
                                Else
                                    Try
                                        oMember.sUpdatedBy = Program.sUserName
                                        oSQLMember.UpdateUploadMemberWithBalance(oMember, oAR, oCA)
                                        dtUploaded.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                          "Updated.")

                                    Catch ex As Exception
                                        dtFailed.Rows.Add(oMember.sMemberID, oMember.sLName & ", " & oMember.sFName & " " & oMember.sMName, _
                                                          "Incomplete data.")
                                        MsgBox("Incomplete data in your Excel File. Row index: " + iRowCount, MsgBoxStyle.Information)
                                    End Try
                                End If
                            End If


                            Application.DoEvents()
                        End If
                    Next
                End If
                btnImport.Enabled = True
                pbProgress.Value = 100
                If iErrorCode = 0 Then
                    MsgBox("Process complete.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
        End Select
        pbProgress.Visible = False
        lblUploadCount.Text = dtUploaded.Rows.Count
        lblFailedCount.Text = dtFailed.Rows.Count
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        dlgOpenFile.FileName = ""
        dlgOpenFile.Filter = "Excel Files (*.xls,*.xlsx)|*.xls;*.xlsx"
        dlgOpenFile.ShowDialog(Me)
        lblLoading.Visible = True
        lblLoading.Refresh()

        grpImport.Enabled = False

        If dlgOpenFile.FileName <> "" Then
            txtFile.Text = dlgOpenFile.FileName

            'Get the rows from Excel file
            dsSource = GetDSFromExcelFile(dlgOpenFile.FileName)
            Dim dtSource As New DataTable

            dtSource.Columns.Add("SourceFields")

            'Get the column names
            For Each dc As DataColumn In dsSource.Tables(0).Columns
                dtSource.Rows.Add(dc.ToString())
            Next
            dtSource.Rows.Add("")

            'Bind it to the ComboBox
            Dim oCombo As New DataGridViewComboBoxColumn
            oCombo = dgMappings.Columns(1)
            oCombo.DataSource = dtSource
            oCombo.DisplayMember = "SourceFields"
            oCombo.ValueMember = "SourceFields"

            'Select Case Program.sImportMode
            '    Case "MasterFile"

            '    Case "Rewards"

            'End Select

            If txtFile.Text <> "" Then btnImport.Enabled = True
        End If

        lblLoading.Visible = False
        grpImport.Enabled = True

    End Sub

    Private Function GetDSFromExcelFile(ByVal sFileName As String) As DataSet
        Dim ds As DataSet = Nothing
        Dim dt As DataTable
        Try
            dt = oExcel.GetExcelWorksheetsV2(sFileName)
            ds = oExcel.GetDSFromExcelV2(sFileName, dt.Rows(0)(2).ToString())
        Catch ex As System.Data.OleDb.OleDbException
            Return Nothing
        End Try
        Return ds
    End Function

    Private Sub tmrWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWait.Tick
        pbProgress.PerformStep()
    End Sub

    Private Sub frmImportData_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If dgMappings.DataSource Is Nothing Then
            Me.Close()
        End If
    End Sub
End Class