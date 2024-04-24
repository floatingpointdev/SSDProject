<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaryDeductionMaintenance
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
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.txtFullName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMemberID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvSDPaymentsDeleted = New System.Windows.Forms.DataGridView
        Me.colSDPayDelID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayDelRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvSDPayments = New System.Windows.Forms.DataGridView
        Me.colSDPayID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDPayRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSDPayCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSDPayDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnSDPaySave = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvSDLogsDeleted = New System.Windows.Forms.DataGridView
        Me.colSDLogsDelID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsDelRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSDLogCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSDLogDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnSDLogSave = New DevComponents.DotNetBar.ButtonX
        Me.dgvSDLogs = New System.Windows.Forms.DataGridView
        Me.colSDLogsID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDLogsRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlGroupManger.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSDPaymentsDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSDPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSDLogsDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSDLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.btnSearch)
        Me.pnlGroupManger.Controls.Add(Me.txtFullName)
        Me.pnlGroupManger.Controls.Add(Me.Label2)
        Me.pnlGroupManger.Controls.Add(Me.txtMemberID)
        Me.pnlGroupManger.Controls.Add(Me.Label1)
        Me.pnlGroupManger.Controls.Add(Me.GroupBox2)
        Me.pnlGroupManger.Controls.Add(Me.GroupBox1)
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
        Me.pnlGroupManger.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSearch.Location = New System.Drawing.Point(418, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(134, 30)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(263, 21)
        Me.txtFullName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name:"
        '
        'txtMemberID
        '
        Me.txtMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberID.Location = New System.Drawing.Point(15, 30)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(103, 21)
        Me.txtMemberID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CIM No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSDPaymentsDeleted)
        Me.GroupBox2.Controls.Add(Me.dgvSDPayments)
        Me.GroupBox2.Controls.Add(Me.btnSDPayCancel)
        Me.GroupBox2.Controls.Add(Me.btnSDPayDelete)
        Me.GroupBox2.Controls.Add(Me.btnSDPaySave)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1001, 227)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salary Deduction Payments"
        '
        'dgvSDPaymentsDeleted
        '
        Me.dgvSDPaymentsDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSDPaymentsDeleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSDPayDelID, Me.colSDPayDelTransCode, Me.colSDPayDelTransDate, Me.colSDPayDelMemberID, Me.colSDPayDelLocation, Me.colSDPayDelAmount, Me.colSDPayDelRemarks})
        Me.dgvSDPaymentsDeleted.Location = New System.Drawing.Point(21, 92)
        Me.dgvSDPaymentsDeleted.Name = "dgvSDPaymentsDeleted"
        Me.dgvSDPaymentsDeleted.Size = New System.Drawing.Size(576, 115)
        Me.dgvSDPaymentsDeleted.TabIndex = 25
        Me.dgvSDPaymentsDeleted.Visible = False
        '
        'colSDPayDelID
        '
        Me.colSDPayDelID.DataPropertyName = "ID"
        Me.colSDPayDelID.HeaderText = "ID"
        Me.colSDPayDelID.Name = "colSDPayDelID"
        Me.colSDPayDelID.ReadOnly = True
        Me.colSDPayDelID.Width = 50
        '
        'colSDPayDelTransCode
        '
        Me.colSDPayDelTransCode.DataPropertyName = "TransCode"
        Me.colSDPayDelTransCode.HeaderText = "TransCode"
        Me.colSDPayDelTransCode.Name = "colSDPayDelTransCode"
        Me.colSDPayDelTransCode.ReadOnly = True
        '
        'colSDPayDelTransDate
        '
        Me.colSDPayDelTransDate.DataPropertyName = "TransDate"
        Me.colSDPayDelTransDate.HeaderText = "TransDate"
        Me.colSDPayDelTransDate.Name = "colSDPayDelTransDate"
        Me.colSDPayDelTransDate.ReadOnly = True
        '
        'colSDPayDelMemberID
        '
        Me.colSDPayDelMemberID.DataPropertyName = "MemberID"
        Me.colSDPayDelMemberID.HeaderText = "CIM No"
        Me.colSDPayDelMemberID.Name = "colSDPayDelMemberID"
        Me.colSDPayDelMemberID.Visible = False
        '
        'colSDPayDelLocation
        '
        Me.colSDPayDelLocation.DataPropertyName = "Location"
        Me.colSDPayDelLocation.HeaderText = "Location"
        Me.colSDPayDelLocation.Name = "colSDPayDelLocation"
        Me.colSDPayDelLocation.ReadOnly = True
        '
        'colSDPayDelAmount
        '
        Me.colSDPayDelAmount.DataPropertyName = "Amount"
        Me.colSDPayDelAmount.HeaderText = "Amount"
        Me.colSDPayDelAmount.Name = "colSDPayDelAmount"
        '
        'colSDPayDelRemarks
        '
        Me.colSDPayDelRemarks.DataPropertyName = "Remarks"
        Me.colSDPayDelRemarks.HeaderText = "Remarks"
        Me.colSDPayDelRemarks.Name = "colSDPayDelRemarks"
        '
        'dgvSDPayments
        '
        Me.dgvSDPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSDPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSDPayID, Me.colSDPayTransCode, Me.colSDPayTransDate, Me.colSDPayMemberID, Me.colSDPayLocation, Me.colSDPayAmount, Me.colSDPayRemarks})
        Me.dgvSDPayments.Location = New System.Drawing.Point(9, 18)
        Me.dgvSDPayments.Name = "dgvSDPayments"
        Me.dgvSDPayments.Size = New System.Drawing.Size(882, 200)
        Me.dgvSDPayments.TabIndex = 24
        '
        'colSDPayID
        '
        Me.colSDPayID.DataPropertyName = "ID"
        Me.colSDPayID.HeaderText = "ID"
        Me.colSDPayID.Name = "colSDPayID"
        Me.colSDPayID.ReadOnly = True
        Me.colSDPayID.Width = 50
        '
        'colSDPayTransCode
        '
        Me.colSDPayTransCode.DataPropertyName = "TransCode"
        Me.colSDPayTransCode.HeaderText = "TransCode"
        Me.colSDPayTransCode.Name = "colSDPayTransCode"
        Me.colSDPayTransCode.ReadOnly = True
        '
        'colSDPayTransDate
        '
        Me.colSDPayTransDate.DataPropertyName = "TransDate"
        Me.colSDPayTransDate.HeaderText = "TransDate"
        Me.colSDPayTransDate.Name = "colSDPayTransDate"
        Me.colSDPayTransDate.ReadOnly = True
        '
        'colSDPayMemberID
        '
        Me.colSDPayMemberID.DataPropertyName = "MemberID"
        Me.colSDPayMemberID.HeaderText = "CIM No"
        Me.colSDPayMemberID.Name = "colSDPayMemberID"
        Me.colSDPayMemberID.Visible = False
        '
        'colSDPayLocation
        '
        Me.colSDPayLocation.DataPropertyName = "Location"
        Me.colSDPayLocation.HeaderText = "Location"
        Me.colSDPayLocation.Name = "colSDPayLocation"
        Me.colSDPayLocation.ReadOnly = True
        '
        'colSDPayAmount
        '
        Me.colSDPayAmount.DataPropertyName = "Amount"
        Me.colSDPayAmount.HeaderText = "Amount"
        Me.colSDPayAmount.Name = "colSDPayAmount"
        '
        'colSDPayRemarks
        '
        Me.colSDPayRemarks.DataPropertyName = "Remarks"
        Me.colSDPayRemarks.HeaderText = "Remarks"
        Me.colSDPayRemarks.Name = "colSDPayRemarks"
        '
        'btnSDPayCancel
        '
        Me.btnSDPayCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDPayCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDPayCancel.Enabled = False
        Me.btnSDPayCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDPayCancel.ForeColor = System.Drawing.Color.Black
        Me.btnSDPayCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDPayCancel.Location = New System.Drawing.Point(896, 182)
        Me.btnSDPayCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDPayCancel.Name = "btnSDPayCancel"
        Me.btnSDPayCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnSDPayCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDPayCancel.TabIndex = 23
        Me.btnSDPayCancel.Text = "Cancel"
        '
        'btnSDPayDelete
        '
        Me.btnSDPayDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDPayDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDPayDelete.Enabled = False
        Me.btnSDPayDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDPayDelete.ForeColor = System.Drawing.Color.Black
        Me.btnSDPayDelete.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDPayDelete.Location = New System.Drawing.Point(896, 58)
        Me.btnSDPayDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDPayDelete.Name = "btnSDPayDelete"
        Me.btnSDPayDelete.Size = New System.Drawing.Size(100, 36)
        Me.btnSDPayDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDPayDelete.TabIndex = 22
        Me.btnSDPayDelete.Text = "Delete"
        '
        'btnSDPaySave
        '
        Me.btnSDPaySave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDPaySave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDPaySave.Enabled = False
        Me.btnSDPaySave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDPaySave.ForeColor = System.Drawing.Color.Black
        Me.btnSDPaySave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDPaySave.Location = New System.Drawing.Point(896, 18)
        Me.btnSDPaySave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDPaySave.Name = "btnSDPaySave"
        Me.btnSDPaySave.Size = New System.Drawing.Size(100, 36)
        Me.btnSDPaySave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDPaySave.TabIndex = 21
        Me.btnSDPaySave.Text = "Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSDLogsDeleted)
        Me.GroupBox1.Controls.Add(Me.btnSDLogCancel)
        Me.GroupBox1.Controls.Add(Me.btnSDLogDelete)
        Me.GroupBox1.Controls.Add(Me.btnSDLogSave)
        Me.GroupBox1.Controls.Add(Me.dgvSDLogs)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 289)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salary Deduction Transaction Logs"
        '
        'dgvSDLogsDeleted
        '
        Me.dgvSDLogsDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSDLogsDeleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSDLogsDelID, Me.colSDLogsDelTransCode, Me.colSDLogsDelTransDate, Me.colSDLogsDelMemberID, Me.colSDLogsDelLocation, Me.colSDLogsDelAmount, Me.colSDLogsDelRemarks})
        Me.dgvSDLogsDeleted.Location = New System.Drawing.Point(21, 154)
        Me.dgvSDLogsDeleted.Name = "dgvSDLogsDeleted"
        Me.dgvSDLogsDeleted.Size = New System.Drawing.Size(576, 115)
        Me.dgvSDLogsDeleted.TabIndex = 24
        Me.dgvSDLogsDeleted.Visible = False
        '
        'colSDLogsDelID
        '
        Me.colSDLogsDelID.DataPropertyName = "ID"
        Me.colSDLogsDelID.HeaderText = "ID"
        Me.colSDLogsDelID.Name = "colSDLogsDelID"
        Me.colSDLogsDelID.ReadOnly = True
        Me.colSDLogsDelID.Width = 50
        '
        'colSDLogsDelTransCode
        '
        Me.colSDLogsDelTransCode.DataPropertyName = "TransCode"
        Me.colSDLogsDelTransCode.HeaderText = "TransCode"
        Me.colSDLogsDelTransCode.Name = "colSDLogsDelTransCode"
        Me.colSDLogsDelTransCode.ReadOnly = True
        '
        'colSDLogsDelTransDate
        '
        Me.colSDLogsDelTransDate.DataPropertyName = "TransDate"
        Me.colSDLogsDelTransDate.HeaderText = "TransDate"
        Me.colSDLogsDelTransDate.Name = "colSDLogsDelTransDate"
        Me.colSDLogsDelTransDate.ReadOnly = True
        '
        'colSDLogsDelMemberID
        '
        Me.colSDLogsDelMemberID.DataPropertyName = "MemberID"
        Me.colSDLogsDelMemberID.HeaderText = "CIM No"
        Me.colSDLogsDelMemberID.Name = "colSDLogsDelMemberID"
        Me.colSDLogsDelMemberID.Visible = False
        '
        'colSDLogsDelLocation
        '
        Me.colSDLogsDelLocation.DataPropertyName = "Location"
        Me.colSDLogsDelLocation.HeaderText = "Location"
        Me.colSDLogsDelLocation.Name = "colSDLogsDelLocation"
        Me.colSDLogsDelLocation.ReadOnly = True
        '
        'colSDLogsDelAmount
        '
        Me.colSDLogsDelAmount.DataPropertyName = "Amount"
        Me.colSDLogsDelAmount.HeaderText = "Amount"
        Me.colSDLogsDelAmount.Name = "colSDLogsDelAmount"
        '
        'colSDLogsDelRemarks
        '
        Me.colSDLogsDelRemarks.DataPropertyName = "Remarks"
        Me.colSDLogsDelRemarks.HeaderText = "Remarks"
        Me.colSDLogsDelRemarks.Name = "colSDLogsDelRemarks"
        '
        'btnSDLogCancel
        '
        Me.btnSDLogCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDLogCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDLogCancel.Enabled = False
        Me.btnSDLogCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDLogCancel.ForeColor = System.Drawing.Color.Black
        Me.btnSDLogCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDLogCancel.Location = New System.Drawing.Point(896, 247)
        Me.btnSDLogCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDLogCancel.Name = "btnSDLogCancel"
        Me.btnSDLogCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnSDLogCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDLogCancel.TabIndex = 23
        Me.btnSDLogCancel.Text = "Cancel"
        '
        'btnSDLogDelete
        '
        Me.btnSDLogDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDLogDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDLogDelete.Enabled = False
        Me.btnSDLogDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDLogDelete.ForeColor = System.Drawing.Color.Black
        Me.btnSDLogDelete.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDLogDelete.Location = New System.Drawing.Point(896, 59)
        Me.btnSDLogDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDLogDelete.Name = "btnSDLogDelete"
        Me.btnSDLogDelete.Size = New System.Drawing.Size(100, 36)
        Me.btnSDLogDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDLogDelete.TabIndex = 22
        Me.btnSDLogDelete.Text = "Delete"
        '
        'btnSDLogSave
        '
        Me.btnSDLogSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSDLogSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSDLogSave.Enabled = False
        Me.btnSDLogSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSDLogSave.ForeColor = System.Drawing.Color.Black
        Me.btnSDLogSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSDLogSave.Location = New System.Drawing.Point(896, 19)
        Me.btnSDLogSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSDLogSave.Name = "btnSDLogSave"
        Me.btnSDLogSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSDLogSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSDLogSave.TabIndex = 21
        Me.btnSDLogSave.Text = "Save"
        '
        'dgvSDLogs
        '
        Me.dgvSDLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSDLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSDLogsID, Me.colSDLogsTransCode, Me.colSDLogsTransDate, Me.colSDLogsMemberID, Me.colSDLogsLocation, Me.colSDLogsAmount, Me.colSDLogsRemarks})
        Me.dgvSDLogs.Location = New System.Drawing.Point(9, 19)
        Me.dgvSDLogs.Name = "dgvSDLogs"
        Me.dgvSDLogs.Size = New System.Drawing.Size(882, 264)
        Me.dgvSDLogs.TabIndex = 0
        '
        'colSDLogsID
        '
        Me.colSDLogsID.DataPropertyName = "ID"
        Me.colSDLogsID.HeaderText = "ID"
        Me.colSDLogsID.Name = "colSDLogsID"
        Me.colSDLogsID.ReadOnly = True
        Me.colSDLogsID.Width = 50
        '
        'colSDLogsTransCode
        '
        Me.colSDLogsTransCode.DataPropertyName = "TransCode"
        Me.colSDLogsTransCode.HeaderText = "TransCode"
        Me.colSDLogsTransCode.Name = "colSDLogsTransCode"
        Me.colSDLogsTransCode.ReadOnly = True
        '
        'colSDLogsTransDate
        '
        Me.colSDLogsTransDate.DataPropertyName = "TransDate"
        Me.colSDLogsTransDate.HeaderText = "TransDate"
        Me.colSDLogsTransDate.Name = "colSDLogsTransDate"
        Me.colSDLogsTransDate.ReadOnly = True
        '
        'colSDLogsMemberID
        '
        Me.colSDLogsMemberID.DataPropertyName = "MemberID"
        Me.colSDLogsMemberID.HeaderText = "CIM No"
        Me.colSDLogsMemberID.Name = "colSDLogsMemberID"
        Me.colSDLogsMemberID.Visible = False
        '
        'colSDLogsLocation
        '
        Me.colSDLogsLocation.DataPropertyName = "Location"
        Me.colSDLogsLocation.HeaderText = "Location"
        Me.colSDLogsLocation.Name = "colSDLogsLocation"
        Me.colSDLogsLocation.ReadOnly = True
        '
        'colSDLogsAmount
        '
        Me.colSDLogsAmount.DataPropertyName = "Amount"
        Me.colSDLogsAmount.HeaderText = "Amount"
        Me.colSDLogsAmount.Name = "colSDLogsAmount"
        '
        'colSDLogsRemarks
        '
        Me.colSDLogsRemarks.DataPropertyName = "Remarks"
        Me.colSDLogsRemarks.HeaderText = "Remarks"
        Me.colSDLogsRemarks.Name = "colSDLogsRemarks"
        '
        'frmSalaryDeductionMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 598)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSalaryDeductionMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Deduction Maintenance"
        Me.pnlGroupManger.ResumeLayout(False)
        Me.pnlGroupManger.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSDPaymentsDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSDPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSDLogsDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSDLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSDPayCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSDPayDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSDPaySave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSDLogCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSDLogDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSDLogSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvSDLogs As System.Windows.Forms.DataGridView
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvSDPayments As System.Windows.Forms.DataGridView
    Friend WithEvents colSDPayID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSDLogsDeleted As System.Windows.Forms.DataGridView
    Friend WithEvents colSDLogsDelID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDLogsDelRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSDPaymentsDeleted As System.Windows.Forms.DataGridView
    Friend WithEvents colSDPayDelID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDPayDelRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
