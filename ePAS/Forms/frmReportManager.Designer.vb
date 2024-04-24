<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportManager))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.grpSites = New System.Windows.Forms.GroupBox
        Me.chkSites = New System.Windows.Forms.CheckBox
        Me.dgvSites = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colCheckSite = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colSiteCheck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpMembers = New System.Windows.Forms.GroupBox
        Me.chkMembers = New System.Windows.Forms.CheckBox
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.txtSearchKey = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.dgvMembers = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colCheckMember = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpDateRange = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.grpSites.SuspendLayout()
        CType(Me.dgvSites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMembers.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateRange.SuspendLayout()
        CType(Me.dtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.grpSites)
        Me.PanelEx1.Controls.Add(Me.grpMembers)
        Me.PanelEx1.Controls.Add(Me.grpDateRange)
        Me.PanelEx1.Controls.Add(Me.btnCancel)
        Me.PanelEx1.Controls.Add(Me.btnOK)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(949, 516)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 7
        '
        'grpSites
        '
        Me.grpSites.Controls.Add(Me.chkSites)
        Me.grpSites.Controls.Add(Me.dgvSites)
        Me.grpSites.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSites.ForeColor = System.Drawing.Color.White
        Me.grpSites.Location = New System.Drawing.Point(12, 100)
        Me.grpSites.Name = "grpSites"
        Me.grpSites.Size = New System.Drawing.Size(345, 404)
        Me.grpSites.TabIndex = 12
        Me.grpSites.TabStop = False
        Me.grpSites.Text = "Site Filter"
        '
        'chkSites
        '
        Me.chkSites.AutoSize = True
        Me.chkSites.Location = New System.Drawing.Point(26, 24)
        Me.chkSites.Name = "chkSites"
        Me.chkSites.Size = New System.Drawing.Size(15, 14)
        Me.chkSites.TabIndex = 4
        Me.chkSites.UseVisualStyleBackColor = True
        '
        'dgvSites
        '
        Me.dgvSites.AllowUserToAddRows = False
        Me.dgvSites.AllowUserToDeleteRows = False
        Me.dgvSites.AllowUserToResizeRows = False
        Me.dgvSites.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSites.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSites.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheckSite, Me.colSiteCheck})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSites.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSites.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvSites.Location = New System.Drawing.Point(6, 19)
        Me.dgvSites.Name = "dgvSites"
        Me.dgvSites.RowHeadersVisible = False
        Me.dgvSites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSites.Size = New System.Drawing.Size(333, 379)
        Me.dgvSites.TabIndex = 5
        '
        'colCheckSite
        '
        Me.colCheckSite.DataPropertyName = "Check"
        Me.colCheckSite.FalseValue = "False"
        Me.colCheckSite.HeaderText = ""
        Me.colCheckSite.Name = "colCheckSite"
        Me.colCheckSite.TrueValue = "True"
        Me.colCheckSite.Width = 50
        '
        'colSiteCheck
        '
        Me.colSiteCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colSiteCheck.DataPropertyName = "CompanyCode"
        Me.colSiteCheck.HeaderText = "CompanyCode"
        Me.colSiteCheck.Name = "colSiteCheck"
        Me.colSiteCheck.ReadOnly = True
        Me.colSiteCheck.Width = 250
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.chkMembers)
        Me.grpMembers.Controls.Add(Me.LabelX16)
        Me.grpMembers.Controls.Add(Me.btnSearch)
        Me.grpMembers.Controls.Add(Me.txtSearchKey)
        Me.grpMembers.Controls.Add(Me.LabelX12)
        Me.grpMembers.Controls.Add(Me.cboSearchBy)
        Me.grpMembers.Controls.Add(Me.dgvMembers)
        Me.grpMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.Color.White
        Me.grpMembers.Location = New System.Drawing.Point(369, 12)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(451, 492)
        Me.grpMembers.TabIndex = 11
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Member Filter"
        '
        'chkMembers
        '
        Me.chkMembers.AutoSize = True
        Me.chkMembers.Location = New System.Drawing.Point(26, 79)
        Me.chkMembers.Name = "chkMembers"
        Me.chkMembers.Size = New System.Drawing.Size(15, 14)
        Me.chkMembers.TabIndex = 11
        Me.chkMembers.UseVisualStyleBackColor = True
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        '
        '
        '
        Me.LabelX16.BackgroundStyle.Class = ""
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.White
        Me.LabelX16.Location = New System.Drawing.Point(150, 21)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(70, 16)
        Me.LabelX16.TabIndex = 8
        Me.LabelX16.Text = "Search Key:"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(341, 29)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        '
        'txtSearchKey
        '
        Me.txtSearchKey.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtSearchKey.Border.Class = "TextBoxBorder"
        Me.txtSearchKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearchKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchKey.ForeColor = System.Drawing.Color.Black
        Me.txtSearchKey.Location = New System.Drawing.Point(150, 45)
        Me.txtSearchKey.MaxLength = 20
        Me.txtSearchKey.Name = "txtSearchKey"
        Me.txtSearchKey.Size = New System.Drawing.Size(186, 21)
        Me.txtSearchKey.TabIndex = 9
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.White
        Me.LabelX12.Location = New System.Drawing.Point(6, 21)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(63, 16)
        Me.LabelX12.TabIndex = 6
        Me.LabelX12.Text = "Search By:"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboSearchBy
        '
        Me.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"EmployeeID", "FullName"})
        Me.cboSearchBy.Location = New System.Drawing.Point(6, 45)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(138, 23)
        Me.cboSearchBy.TabIndex = 7
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AllowUserToResizeRows = False
        Me.dgvMembers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheckMember, Me.colMemberID, Me.colFullName, Me.colAddress})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembers.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMembers.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMembers.Location = New System.Drawing.Point(6, 73)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(435, 413)
        Me.dgvMembers.TabIndex = 12
        '
        'colCheckMember
        '
        Me.colCheckMember.DataPropertyName = "Check"
        Me.colCheckMember.FalseValue = "False"
        Me.colCheckMember.HeaderText = ""
        Me.colCheckMember.Name = "colCheckMember"
        Me.colCheckMember.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCheckMember.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCheckMember.TrueValue = "True"
        Me.colCheckMember.Width = 50
        '
        'colMemberID
        '
        Me.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "EmployeeID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Width = 99
        '
        'colFullName
        '
        Me.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Width = 250
        '
        'colAddress
        '
        Me.colAddress.DataPropertyName = "Address"
        Me.colAddress.HeaderText = "Site"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = False
        '
        'grpDateRange
        '
        Me.grpDateRange.Controls.Add(Me.Label1)
        Me.grpDateRange.Controls.Add(Me.dtTo)
        Me.grpDateRange.Controls.Add(Me.Label2)
        Me.grpDateRange.Controls.Add(Me.dtFrom)
        Me.grpDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDateRange.ForeColor = System.Drawing.Color.White
        Me.grpDateRange.Location = New System.Drawing.Point(13, 12)
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(345, 82)
        Me.grpDateRange.TabIndex = 10
        Me.grpDateRange.TabStop = False
        Me.grpDateRange.Text = "Date Range"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'dtTo
        '
        '
        '
        '
        Me.dtTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtTo.ButtonDropDown.Visible = True
        Me.dtTo.ForeColor = System.Drawing.Color.Black
        Me.dtTo.Location = New System.Drawing.Point(180, 45)
        '
        '
        '
        Me.dtTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtTo.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTo.MonthCalendar.DisplayMonth = New Date(2011, 6, 1, 0, 0, 0, 0)
        Me.dtTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtTo.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTo.MonthCalendar.TodayButtonVisible = True
        Me.dtTo.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(146, 21)
        Me.dtTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(177, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'dtFrom
        '
        '
        '
        '
        Me.dtFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFrom.ButtonDropDown.Visible = True
        Me.dtFrom.ForeColor = System.Drawing.Color.Black
        Me.dtFrom.Location = New System.Drawing.Point(18, 45)
        Me.dtFrom.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFrom.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFrom.MonthCalendar.DisplayMonth = New Date(2011, 6, 1, 0, 0, 0, 0)
        Me.dtFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFrom.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtFrom.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(149, 21)
        Me.dtFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFrom.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(834, 73)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnOK.Location = New System.Drawing.Point(834, 15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOK.Size = New System.Drawing.Size(100, 36)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        '
        'frmReportManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(949, 516)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReportManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Manager"
        Me.PanelEx1.ResumeLayout(False)
        Me.grpSites.ResumeLayout(False)
        Me.grpSites.PerformLayout()
        CType(Me.dgvSites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMembers.ResumeLayout(False)
        Me.grpMembers.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        CType(Me.dtTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dtTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents grpMembers As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMembers As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSearchKey As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents grpSites As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSites As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents chkSites As System.Windows.Forms.CheckBox
    Friend WithEvents chkMembers As System.Windows.Forms.CheckBox
    Friend WithEvents colCheckMember As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCheckSite As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSiteCheck As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
