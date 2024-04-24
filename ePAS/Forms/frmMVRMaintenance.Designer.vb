<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMVRMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlGroupManger = New DevComponents.DotNetBar.PanelEx
        Me.grpMVRTrans = New System.Windows.Forms.GroupBox
        Me.dgvMVRTransLogDeleted = New System.Windows.Forms.DataGridView
        Me.colMVRTransLogDelID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRTransLogDelRefID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnMVRTransLogCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnMVRTransLogDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnMVRTransLogSave = New DevComponents.DotNetBar.ButtonX
        Me.dgvMVRTransLog = New System.Windows.Forms.DataGridView
        Me.colMVRLogID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRLogRefID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpMVR = New System.Windows.Forms.GroupBox
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMemberID = New System.Windows.Forms.TextBox
        Me.dgvMVRDeleted = New System.Windows.Forms.DataGridView
        Me.colMVRDelID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelSite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelConsumable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRDelApplicableYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnMVRCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnMVRDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnMVRSave = New DevComponents.DotNetBar.ButtonX
        Me.dgvMVR = New System.Windows.Forms.DataGridView
        Me.colMVRID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRSite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRConsumable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMVRApplicableYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlGroupManger.SuspendLayout()
        Me.grpMVRTrans.SuspendLayout()
        CType(Me.dgvMVRTransLogDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMVRTransLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMVR.SuspendLayout()
        CType(Me.dgvMVRDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMVR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.grpMVRTrans)
        Me.pnlGroupManger.Controls.Add(Me.grpMVR)
        Me.pnlGroupManger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGroupManger.Location = New System.Drawing.Point(0, 0)
        Me.pnlGroupManger.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGroupManger.Name = "pnlGroupManger"
        Me.pnlGroupManger.Size = New System.Drawing.Size(1016, 598)
        Me.pnlGroupManger.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlGroupManger.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlGroupManger.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlGroupManger.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlGroupManger.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlGroupManger.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlGroupManger.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlGroupManger.Style.GradientAngle = 90
        Me.pnlGroupManger.TabIndex = 2
        '
        'grpMVRTrans
        '
        Me.grpMVRTrans.Controls.Add(Me.dgvMVRTransLogDeleted)
        Me.grpMVRTrans.Controls.Add(Me.btnMVRTransLogCancel)
        Me.grpMVRTrans.Controls.Add(Me.btnMVRTransLogDelete)
        Me.grpMVRTrans.Controls.Add(Me.btnMVRTransLogSave)
        Me.grpMVRTrans.Controls.Add(Me.dgvMVRTransLog)
        Me.grpMVRTrans.Location = New System.Drawing.Point(3, 304)
        Me.grpMVRTrans.Name = "grpMVRTrans"
        Me.grpMVRTrans.Size = New System.Drawing.Size(1001, 289)
        Me.grpMVRTrans.TabIndex = 3
        Me.grpMVRTrans.TabStop = False
        Me.grpMVRTrans.Text = "MVR Transaction Logs"
        '
        'dgvMVRTransLogDeleted
        '
        Me.dgvMVRTransLogDeleted.AllowUserToAddRows = False
        Me.dgvMVRTransLogDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMVRTransLogDeleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMVRTransLogDelID, Me.colMVRTransLogDelTransDate, Me.colMVRTransLogDelTransCode, Me.colMVRTransLogDelMemberID, Me.colMVRTransLogDelAmount, Me.colMVRTransLogDelLocation, Me.colMVRTransLogDelRemarks, Me.colMVRTransLogDelRefID})
        Me.dgvMVRTransLogDeleted.Location = New System.Drawing.Point(45, 103)
        Me.dgvMVRTransLogDeleted.Name = "dgvMVRTransLogDeleted"
        Me.dgvMVRTransLogDeleted.Size = New System.Drawing.Size(550, 165)
        Me.dgvMVRTransLogDeleted.TabIndex = 24
        Me.dgvMVRTransLogDeleted.Visible = False
        '
        'colMVRTransLogDelID
        '
        Me.colMVRTransLogDelID.DataPropertyName = "ID"
        Me.colMVRTransLogDelID.HeaderText = "ID"
        Me.colMVRTransLogDelID.Name = "colMVRTransLogDelID"
        Me.colMVRTransLogDelID.ReadOnly = True
        Me.colMVRTransLogDelID.Width = 50
        '
        'colMVRTransLogDelTransDate
        '
        Me.colMVRTransLogDelTransDate.HeaderText = "TransDate"
        Me.colMVRTransLogDelTransDate.Name = "colMVRTransLogDelTransDate"
        Me.colMVRTransLogDelTransDate.ReadOnly = True
        '
        'colMVRTransLogDelTransCode
        '
        Me.colMVRTransLogDelTransCode.HeaderText = "TransCode"
        Me.colMVRTransLogDelTransCode.Name = "colMVRTransLogDelTransCode"
        Me.colMVRTransLogDelTransCode.ReadOnly = True
        '
        'colMVRTransLogDelMemberID
        '
        Me.colMVRTransLogDelMemberID.DataPropertyName = "MemberID"
        Me.colMVRTransLogDelMemberID.HeaderText = "CIMNo"
        Me.colMVRTransLogDelMemberID.Name = "colMVRTransLogDelMemberID"
        Me.colMVRTransLogDelMemberID.Visible = False
        '
        'colMVRTransLogDelAmount
        '
        Me.colMVRTransLogDelAmount.DataPropertyName = "Amount"
        Me.colMVRTransLogDelAmount.HeaderText = "Amount"
        Me.colMVRTransLogDelAmount.Name = "colMVRTransLogDelAmount"
        '
        'colMVRTransLogDelLocation
        '
        Me.colMVRTransLogDelLocation.DataPropertyName = "Location"
        Me.colMVRTransLogDelLocation.HeaderText = "Location"
        Me.colMVRTransLogDelLocation.Name = "colMVRTransLogDelLocation"
        Me.colMVRTransLogDelLocation.ReadOnly = True
        '
        'colMVRTransLogDelRemarks
        '
        Me.colMVRTransLogDelRemarks.DataPropertyName = "Remarks"
        Me.colMVRTransLogDelRemarks.HeaderText = "Remarks"
        Me.colMVRTransLogDelRemarks.Name = "colMVRTransLogDelRemarks"
        Me.colMVRTransLogDelRemarks.Width = 200
        '
        'colMVRTransLogDelRefID
        '
        Me.colMVRTransLogDelRefID.DataPropertyName = "MVRRefID"
        Me.colMVRTransLogDelRefID.HeaderText = "RefID"
        Me.colMVRTransLogDelRefID.Name = "colMVRTransLogDelRefID"
        Me.colMVRTransLogDelRefID.ReadOnly = True
        '
        'btnMVRTransLogCancel
        '
        Me.btnMVRTransLogCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRTransLogCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRTransLogCancel.Enabled = False
        Me.btnMVRTransLogCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRTransLogCancel.ForeColor = System.Drawing.Color.Black
        Me.btnMVRTransLogCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRTransLogCancel.Location = New System.Drawing.Point(896, 246)
        Me.btnMVRTransLogCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRTransLogCancel.Name = "btnMVRTransLogCancel"
        Me.btnMVRTransLogCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRTransLogCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRTransLogCancel.TabIndex = 23
        Me.btnMVRTransLogCancel.Text = "Cancel"
        '
        'btnMVRTransLogDelete
        '
        Me.btnMVRTransLogDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRTransLogDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRTransLogDelete.Enabled = False
        Me.btnMVRTransLogDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRTransLogDelete.ForeColor = System.Drawing.Color.Black
        Me.btnMVRTransLogDelete.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRTransLogDelete.Location = New System.Drawing.Point(896, 59)
        Me.btnMVRTransLogDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRTransLogDelete.Name = "btnMVRTransLogDelete"
        Me.btnMVRTransLogDelete.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRTransLogDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRTransLogDelete.TabIndex = 22
        Me.btnMVRTransLogDelete.Text = "Delete"
        '
        'btnMVRTransLogSave
        '
        Me.btnMVRTransLogSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRTransLogSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRTransLogSave.Enabled = False
        Me.btnMVRTransLogSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRTransLogSave.ForeColor = System.Drawing.Color.Black
        Me.btnMVRTransLogSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRTransLogSave.Location = New System.Drawing.Point(896, 19)
        Me.btnMVRTransLogSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRTransLogSave.Name = "btnMVRTransLogSave"
        Me.btnMVRTransLogSave.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRTransLogSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRTransLogSave.TabIndex = 21
        Me.btnMVRTransLogSave.Text = "Save"
        '
        'dgvMVRTransLog
        '
        Me.dgvMVRTransLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMVRTransLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMVRLogID, Me.colMVRLogMemberID, Me.colMVRLogTransDate, Me.colMVRLogTransCode, Me.colMVRLogAmount, Me.colMVRLogLocation, Me.colMVRLogRemarks, Me.colMVRLogRefID})
        Me.dgvMVRTransLog.Location = New System.Drawing.Point(9, 19)
        Me.dgvMVRTransLog.Name = "dgvMVRTransLog"
        Me.dgvMVRTransLog.Size = New System.Drawing.Size(882, 263)
        Me.dgvMVRTransLog.TabIndex = 0
        '
        'colMVRLogID
        '
        Me.colMVRLogID.DataPropertyName = "ID"
        Me.colMVRLogID.HeaderText = "ID"
        Me.colMVRLogID.Name = "colMVRLogID"
        Me.colMVRLogID.ReadOnly = True
        Me.colMVRLogID.Width = 50
        '
        'colMVRLogMemberID
        '
        Me.colMVRLogMemberID.DataPropertyName = "MemberID"
        Me.colMVRLogMemberID.HeaderText = "CIMNo"
        Me.colMVRLogMemberID.Name = "colMVRLogMemberID"
        Me.colMVRLogMemberID.Visible = False
        '
        'colMVRLogTransDate
        '
        Me.colMVRLogTransDate.DataPropertyName = "TransDate"
        Me.colMVRLogTransDate.HeaderText = "TransDate"
        Me.colMVRLogTransDate.Name = "colMVRLogTransDate"
        '
        'colMVRLogTransCode
        '
        Me.colMVRLogTransCode.DataPropertyName = "TransCode"
        Me.colMVRLogTransCode.HeaderText = "TransCode"
        Me.colMVRLogTransCode.Name = "colMVRLogTransCode"
        Me.colMVRLogTransCode.ReadOnly = True
        '
        'colMVRLogAmount
        '
        Me.colMVRLogAmount.DataPropertyName = "Amount"
        Me.colMVRLogAmount.HeaderText = "Amount"
        Me.colMVRLogAmount.Name = "colMVRLogAmount"
        '
        'colMVRLogLocation
        '
        Me.colMVRLogLocation.DataPropertyName = "Location"
        Me.colMVRLogLocation.HeaderText = "Location"
        Me.colMVRLogLocation.Name = "colMVRLogLocation"
        Me.colMVRLogLocation.ReadOnly = True
        '
        'colMVRLogRemarks
        '
        Me.colMVRLogRemarks.DataPropertyName = "Remarks"
        Me.colMVRLogRemarks.HeaderText = "Remarks"
        Me.colMVRLogRemarks.Name = "colMVRLogRemarks"
        Me.colMVRLogRemarks.Width = 200
        '
        'colMVRLogRefID
        '
        Me.colMVRLogRefID.DataPropertyName = "MVRRefID"
        Me.colMVRLogRefID.HeaderText = "RefID"
        Me.colMVRLogRefID.Name = "colMVRLogRefID"
        Me.colMVRLogRefID.ReadOnly = True
        '
        'grpMVR
        '
        Me.grpMVR.Controls.Add(Me.btnSearch)
        Me.grpMVR.Controls.Add(Me.Label1)
        Me.grpMVR.Controls.Add(Me.txtMemberID)
        Me.grpMVR.Controls.Add(Me.dgvMVRDeleted)
        Me.grpMVR.Controls.Add(Me.btnMVRCancel)
        Me.grpMVR.Controls.Add(Me.btnMVRDelete)
        Me.grpMVR.Controls.Add(Me.btnMVRSave)
        Me.grpMVR.Controls.Add(Me.dgvMVR)
        Me.grpMVR.Location = New System.Drawing.Point(3, 3)
        Me.grpMVR.Name = "grpMVR"
        Me.grpMVR.Size = New System.Drawing.Size(1001, 289)
        Me.grpMVR.TabIndex = 2
        Me.grpMVR.TabStop = False
        Me.grpMVR.Text = "MVR"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSearch.Location = New System.Drawing.Point(267, 13)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CIM Number:"
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(85, 21)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(160, 20)
        Me.txtMemberID.TabIndex = 25
        '
        'dgvMVRDeleted
        '
        Me.dgvMVRDeleted.AllowUserToAddRows = False
        Me.dgvMVRDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMVRDeleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMVRDelID, Me.colMVRDelName, Me.colMVRDelFullName, Me.colMVRDelSite, Me.colMVRDelAmount, Me.colMVRDelConsumable, Me.colMVRDelApplicableYear})
        Me.dgvMVRDeleted.Location = New System.Drawing.Point(45, 105)
        Me.dgvMVRDeleted.Name = "dgvMVRDeleted"
        Me.dgvMVRDeleted.Size = New System.Drawing.Size(550, 165)
        Me.dgvMVRDeleted.TabIndex = 24
        Me.dgvMVRDeleted.Visible = False
        '
        'colMVRDelID
        '
        Me.colMVRDelID.DataPropertyName = "ID"
        Me.colMVRDelID.HeaderText = "ID"
        Me.colMVRDelID.Name = "colMVRDelID"
        Me.colMVRDelID.ReadOnly = True
        Me.colMVRDelID.Width = 50
        '
        'colMVRDelName
        '
        Me.colMVRDelName.DataPropertyName = "MemberID"
        Me.colMVRDelName.HeaderText = "CIMNo"
        Me.colMVRDelName.Name = "colMVRDelName"
        Me.colMVRDelName.ReadOnly = True
        '
        'colMVRDelFullName
        '
        Me.colMVRDelFullName.DataPropertyName = "FullName"
        Me.colMVRDelFullName.HeaderText = "Name"
        Me.colMVRDelFullName.Name = "colMVRDelFullName"
        Me.colMVRDelFullName.ReadOnly = True
        Me.colMVRDelFullName.Width = 200
        '
        'colMVRDelSite
        '
        Me.colMVRDelSite.DataPropertyName = "Site"
        Me.colMVRDelSite.HeaderText = "Site"
        Me.colMVRDelSite.Name = "colMVRDelSite"
        Me.colMVRDelSite.ReadOnly = True
        '
        'colMVRDelAmount
        '
        Me.colMVRDelAmount.DataPropertyName = "MVRAmount"
        Me.colMVRDelAmount.HeaderText = "MVRAmount"
        Me.colMVRDelAmount.Name = "colMVRDelAmount"
        Me.colMVRDelAmount.ReadOnly = True
        '
        'colMVRDelConsumable
        '
        Me.colMVRDelConsumable.DataPropertyName = "MVRConsumable"
        Me.colMVRDelConsumable.HeaderText = "MVRConsumable"
        Me.colMVRDelConsumable.Name = "colMVRDelConsumable"
        '
        'colMVRDelApplicableYear
        '
        Me.colMVRDelApplicableYear.DataPropertyName = "ApplicableYear"
        Me.colMVRDelApplicableYear.HeaderText = "ApplicableYear"
        Me.colMVRDelApplicableYear.Name = "colMVRDelApplicableYear"
        '
        'btnMVRCancel
        '
        Me.btnMVRCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRCancel.Enabled = False
        Me.btnMVRCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRCancel.ForeColor = System.Drawing.Color.Black
        Me.btnMVRCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRCancel.Location = New System.Drawing.Point(896, 247)
        Me.btnMVRCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRCancel.Name = "btnMVRCancel"
        Me.btnMVRCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRCancel.TabIndex = 23
        Me.btnMVRCancel.Text = "Cancel"
        '
        'btnMVRDelete
        '
        Me.btnMVRDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRDelete.Enabled = False
        Me.btnMVRDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRDelete.ForeColor = System.Drawing.Color.Black
        Me.btnMVRDelete.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRDelete.Location = New System.Drawing.Point(896, 59)
        Me.btnMVRDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRDelete.Name = "btnMVRDelete"
        Me.btnMVRDelete.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRDelete.TabIndex = 22
        Me.btnMVRDelete.Text = "Delete"
        '
        'btnMVRSave
        '
        Me.btnMVRSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMVRSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMVRSave.Enabled = False
        Me.btnMVRSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMVRSave.ForeColor = System.Drawing.Color.Black
        Me.btnMVRSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnMVRSave.Location = New System.Drawing.Point(896, 19)
        Me.btnMVRSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMVRSave.Name = "btnMVRSave"
        Me.btnMVRSave.Size = New System.Drawing.Size(100, 36)
        Me.btnMVRSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMVRSave.TabIndex = 21
        Me.btnMVRSave.Text = "Save"
        '
        'dgvMVR
        '
        Me.dgvMVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMVR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMVRID, Me.colMVRMemberID, Me.colMVRFullName, Me.colMVRSite, Me.colMVRAmount, Me.colMVRConsumable, Me.colMVRApplicableYear})
        Me.dgvMVR.Location = New System.Drawing.Point(9, 60)
        Me.dgvMVR.Name = "dgvMVR"
        Me.dgvMVR.Size = New System.Drawing.Size(882, 223)
        Me.dgvMVR.TabIndex = 0
        '
        'colMVRID
        '
        Me.colMVRID.DataPropertyName = "ID"
        Me.colMVRID.HeaderText = "ID"
        Me.colMVRID.Name = "colMVRID"
        Me.colMVRID.ReadOnly = True
        Me.colMVRID.Width = 50
        '
        'colMVRMemberID
        '
        Me.colMVRMemberID.DataPropertyName = "MemberID"
        Me.colMVRMemberID.HeaderText = "CIMNo"
        Me.colMVRMemberID.Name = "colMVRMemberID"
        Me.colMVRMemberID.ReadOnly = True
        '
        'colMVRFullName
        '
        Me.colMVRFullName.DataPropertyName = "FullName"
        Me.colMVRFullName.HeaderText = "Name"
        Me.colMVRFullName.Name = "colMVRFullName"
        Me.colMVRFullName.ReadOnly = True
        Me.colMVRFullName.Width = 200
        '
        'colMVRSite
        '
        Me.colMVRSite.DataPropertyName = "Site"
        Me.colMVRSite.HeaderText = "Site"
        Me.colMVRSite.Name = "colMVRSite"
        Me.colMVRSite.ReadOnly = True
        '
        'colMVRAmount
        '
        Me.colMVRAmount.DataPropertyName = "MVRAmount"
        Me.colMVRAmount.HeaderText = "MVRAmount"
        Me.colMVRAmount.Name = "colMVRAmount"
        Me.colMVRAmount.ReadOnly = True
        '
        'colMVRConsumable
        '
        Me.colMVRConsumable.DataPropertyName = "MVRConsumable"
        Me.colMVRConsumable.HeaderText = "MVRConsumable"
        Me.colMVRConsumable.Name = "colMVRConsumable"
        '
        'colMVRApplicableYear
        '
        Me.colMVRApplicableYear.DataPropertyName = "ApplicableYear"
        Me.colMVRApplicableYear.HeaderText = "ApplicableYear"
        Me.colMVRApplicableYear.Name = "colMVRApplicableYear"
        '
        'frmMVRMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 598)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMVRMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MVR Maintenance"
        Me.pnlGroupManger.ResumeLayout(False)
        Me.grpMVRTrans.ResumeLayout(False)
        CType(Me.dgvMVRTransLogDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMVRTransLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMVR.ResumeLayout(False)
        Me.grpMVR.PerformLayout()
        CType(Me.dgvMVRDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grpMVR As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMVR As System.Windows.Forms.DataGridView
    Friend WithEvents btnMVRSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMVRCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMVRDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents grpMVRTrans As System.Windows.Forms.GroupBox
    Friend WithEvents btnMVRTransLogCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMVRTransLogDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMVRTransLogSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvMVRTransLog As System.Windows.Forms.DataGridView
    Friend WithEvents colMVRID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRSite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRConsumable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRApplicableYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMVRTransLogDeleted As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMVRDeleted As System.Windows.Forms.DataGridView
    Friend WithEvents colMVRDelID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelSite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelConsumable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRDelApplicableYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRLogRefID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMVRTransLogDelRefID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
End Class
