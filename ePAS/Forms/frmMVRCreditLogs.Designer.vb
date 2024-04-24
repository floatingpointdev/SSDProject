<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMVRCreditLogs
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlLoyalty = New DevComponents.DotNetBar.PanelEx
        Me.pnlSave = New System.Windows.Forms.Panel
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.tbRemarks = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.dtiTransDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.cboTransMode = New System.Windows.Forms.ComboBox
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.tbCardID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.tbPoints = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnClear = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dgTransLogs = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCardID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colConcessionaire = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.dtiTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.dtiFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.tbSearch = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnExportExcel = New DevComponents.DotNetBar.ButtonX
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.btnExportText = New DevComponents.DotNetBar.ButtonX
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX
        Me.pnlLoyalty.SuspendLayout()
        Me.pnlSave.SuspendLayout()
        CType(Me.dtiTransDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdd.SuspendLayout()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoyalty
        '
        Me.pnlLoyalty.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLoyalty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLoyalty.Controls.Add(Me.pnlSave)
        Me.pnlLoyalty.Controls.Add(Me.btnEdit)
        Me.pnlLoyalty.Controls.Add(Me.pnlAdd)
        Me.pnlLoyalty.Controls.Add(Me.btnRemove)
        Me.pnlLoyalty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoyalty.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoyalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLoyalty.Name = "pnlLoyalty"
        Me.pnlLoyalty.Size = New System.Drawing.Size(858, 582)
        Me.pnlLoyalty.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLoyalty.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLoyalty.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLoyalty.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlLoyalty.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLoyalty.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLoyalty.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLoyalty.Style.GradientAngle = 90
        Me.pnlLoyalty.TabIndex = 3
        '
        'pnlSave
        '
        Me.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSave.Controls.Add(Me.LabelX8)
        Me.pnlSave.Controls.Add(Me.tbRemarks)
        Me.pnlSave.Controls.Add(Me.LabelX7)
        Me.pnlSave.Controls.Add(Me.dtiTransDate)
        Me.pnlSave.Controls.Add(Me.cboTransMode)
        Me.pnlSave.Controls.Add(Me.LabelX5)
        Me.pnlSave.Controls.Add(Me.tbCardID)
        Me.pnlSave.Controls.Add(Me.LabelX4)
        Me.pnlSave.Controls.Add(Me.tbPoints)
        Me.pnlSave.Controls.Add(Me.LabelX3)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Controls.Add(Me.btnClear)
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Location = New System.Drawing.Point(871, 55)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(747, 131)
        Me.pnlSave.TabIndex = 70
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(369, 13)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(54, 16)
        Me.LabelX8.TabIndex = 79
        Me.LabelX8.Text = "Remarks:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.Visible = False
        '
        'tbRemarks
        '
        Me.tbRemarks.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbRemarks.Border.Class = "TextBoxBorder"
        Me.tbRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemarks.ForeColor = System.Drawing.Color.Black
        Me.tbRemarks.Location = New System.Drawing.Point(369, 37)
        Me.tbRemarks.Multiline = True
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.ReadOnly = True
        Me.tbRemarks.Size = New System.Drawing.Size(356, 78)
        Me.tbRemarks.TabIndex = 15
        Me.tbRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbRemarks.Visible = False
        Me.tbRemarks.WatermarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(18, 40)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(100, 16)
        Me.LabelX7.TabIndex = 77
        Me.LabelX7.Text = "Transaction  Date:"
        '
        'dtiTransDate
        '
        '
        '
        '
        Me.dtiTransDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiTransDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTransDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiTransDate.ButtonDropDown.Visible = True
        Me.dtiTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiTransDate.ForeColor = System.Drawing.Color.Black
        Me.dtiTransDate.Location = New System.Drawing.Point(126, 38)
        Me.dtiTransDate.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtiTransDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiTransDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiTransDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiTransDate.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtiTransDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTransDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtiTransDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTransDate.MonthCalendar.DisplayMonth = New Date(2011, 7, 1, 0, 0, 0, 0)
        Me.dtiTransDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiTransDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiTransDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiTransDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiTransDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiTransDate.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtiTransDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTransDate.MonthCalendar.TodayButtonVisible = True
        Me.dtiTransDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiTransDate.Name = "dtiTransDate"
        Me.dtiTransDate.Size = New System.Drawing.Size(155, 21)
        Me.dtiTransDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiTransDate.TabIndex = 5
        '
        'cboTransMode
        '
        Me.cboTransMode.BackColor = System.Drawing.Color.Honeydew
        Me.cboTransMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTransMode.ForeColor = System.Drawing.Color.Black
        Me.cboTransMode.FormattingEnabled = True
        Me.cboTransMode.Items.AddRange(New Object() {"Cash", "Gift"})
        Me.cboTransMode.Location = New System.Drawing.Point(125, 92)
        Me.cboTransMode.Name = "cboTransMode"
        Me.cboTransMode.Size = New System.Drawing.Size(236, 23)
        Me.cboTransMode.TabIndex = 11
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(82, 95)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(36, 16)
        Me.LabelX5.TabIndex = 75
        Me.LabelX5.Text = "Mode:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbCardID
        '
        Me.tbCardID.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbCardID.Border.Class = "TextBoxBorder"
        Me.tbCardID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCardID.ForeColor = System.Drawing.Color.Black
        Me.tbCardID.Location = New System.Drawing.Point(126, 11)
        Me.tbCardID.Name = "tbCardID"
        Me.tbCardID.ReadOnly = True
        Me.tbCardID.Size = New System.Drawing.Size(235, 21)
        Me.tbCardID.TabIndex = 2
        Me.tbCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCardID.WatermarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(44, 13)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(74, 16)
        Me.LabelX4.TabIndex = 72
        Me.LabelX4.Text = "CIM Number:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbPoints
        '
        Me.tbPoints.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbPoints.Border.Class = "TextBoxBorder"
        Me.tbPoints.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPoints.ForeColor = System.Drawing.Color.Black
        Me.tbPoints.Location = New System.Drawing.Point(125, 65)
        Me.tbPoints.Name = "tbPoints"
        Me.tbPoints.Size = New System.Drawing.Size(236, 21)
        Me.tbPoints.TabIndex = 8
        Me.tbPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(65, 67)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(53, 16)
        Me.LabelX3.TabIndex = 71
        Me.LabelX3.Text = "Rewards:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(764, 137)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.Tooltip = "Saves/Updates the information."
        Me.btnSave.Visible = False
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClear.Location = New System.Drawing.Point(870, 137)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Tooltip = "Clears all text areas."
        Me.btnClear.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(976, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Tooltip = "Cancel edit."
        Me.btnCancel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(871, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 36)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 36
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.Tooltip = "Edits the selected data."
        Me.btnEdit.Visible = False
        '
        'pnlAdd
        '
        Me.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdd.Controls.Add(Me.LabelX2)
        Me.pnlAdd.Controls.Add(Me.dgTransLogs)
        Me.pnlAdd.Controls.Add(Me.LabelX1)
        Me.pnlAdd.Controls.Add(Me.cboSearchBy)
        Me.pnlAdd.Controls.Add(Me.dtiTo)
        Me.pnlAdd.Controls.Add(Me.LabelX6)
        Me.pnlAdd.Controls.Add(Me.dtiFrom)
        Me.pnlAdd.Controls.Add(Me.tbSearch)
        Me.pnlAdd.Controls.Add(Me.btnExportExcel)
        Me.pnlAdd.Controls.Add(Me.btnSearch)
        Me.pnlAdd.Controls.Add(Me.btnExportText)
        Me.pnlAdd.Controls.Add(Me.btnRefresh)
        Me.pnlAdd.Location = New System.Drawing.Point(9, 12)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(837, 568)
        Me.pnlAdd.TabIndex = 64
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(197, 16)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(20, 16)
        Me.LabelX2.TabIndex = 63
        Me.LabelX2.Text = "To:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dgTransLogs
        '
        Me.dgTransLogs.AllowUserToAddRows = False
        Me.dgTransLogs.AllowUserToDeleteRows = False
        Me.dgTransLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgTransLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMemberID, Me.colCardID, Me.colTransDate, Me.colName, Me.colPoints, Me.colSite, Me.colTransType, Me.colConcessionaire})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTransLogs.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgTransLogs.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgTransLogs.Location = New System.Drawing.Point(12, 72)
        Me.dgTransLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgTransLogs.Name = "dgTransLogs"
        Me.dgTransLogs.ReadOnly = True
        Me.dgTransLogs.RowHeadersVisible = False
        Me.dgTransLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTransLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransLogs.Size = New System.Drawing.Size(818, 448)
        Me.dgTransLogs.TabIndex = 55
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "CIMNumber"
        Me.colMemberID.HeaderText = "CIMNumber"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        '
        'colCardID
        '
        Me.colCardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCardID.DataPropertyName = "CardID"
        Me.colCardID.HeaderText = "Card ID"
        Me.colCardID.Name = "colCardID"
        Me.colCardID.ReadOnly = True
        Me.colCardID.Width = 68
        '
        'colTransDate
        '
        Me.colTransDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTransDate.DataPropertyName = "TransDate"
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 55
        '
        'colName
        '
        Me.colName.DataPropertyName = "FullName"
        Me.colName.HeaderText = "FullName"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 200
        '
        'colPoints
        '
        Me.colPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPoints.DataPropertyName = "Amount"
        Me.colPoints.HeaderText = "Amount"
        Me.colPoints.Name = "colPoints"
        Me.colPoints.ReadOnly = True
        Me.colPoints.Width = 68
        '
        'colSite
        '
        Me.colSite.DataPropertyName = "Site"
        Me.colSite.HeaderText = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.ReadOnly = True
        '
        'colTransType
        '
        Me.colTransType.DataPropertyName = "TransType"
        Me.colTransType.HeaderText = "TransType"
        Me.colTransType.Name = "colTransType"
        Me.colTransType.ReadOnly = True
        '
        'colConcessionaire
        '
        Me.colConcessionaire.DataPropertyName = "Terminal"
        Me.colConcessionaire.HeaderText = "Terminal"
        Me.colConcessionaire.Name = "colConcessionaire"
        Me.colConcessionaire.ReadOnly = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(39, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 16)
        Me.LabelX1.TabIndex = 62
        Me.LabelX1.Text = "From:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboSearchBy
        '
        Me.cboSearchBy.BackColor = System.Drawing.Color.Honeydew
        Me.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"CIM Number", "Name", "Transaction Date", "Site", "Concessionaire"})
        Me.cboSearchBy.Location = New System.Drawing.Point(79, 41)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(200, 21)
        Me.cboSearchBy.TabIndex = 30
        '
        'dtiTo
        '
        '
        '
        '
        Me.dtiTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiTo.ButtonDropDown.Visible = True
        Me.dtiTo.Location = New System.Drawing.Point(223, 14)
        Me.dtiTo.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtiTo.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiTo.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtiTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtiTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTo.MonthCalendar.DisplayMonth = New Date(2011, 7, 1, 0, 0, 0, 0)
        Me.dtiTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiTo.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtiTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiTo.MonthCalendar.TodayButtonVisible = True
        Me.dtiTo.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiTo.Name = "dtiTo"
        Me.dtiTo.Size = New System.Drawing.Size(111, 20)
        Me.dtiTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiTo.TabIndex = 29
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(12, 45)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(61, 16)
        Me.LabelX6.TabIndex = 55
        Me.LabelX6.Text = "Search By:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtiFrom
        '
        '
        '
        '
        Me.dtiFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFrom.ButtonDropDown.Visible = True
        Me.dtiFrom.Location = New System.Drawing.Point(79, 14)
        Me.dtiFrom.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtiFrom.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiFrom.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtiFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtiFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFrom.MonthCalendar.DisplayMonth = New Date(2011, 7, 1, 0, 0, 0, 0)
        Me.dtiFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFrom.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtiFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtiFrom.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiFrom.Name = "dtiFrom"
        Me.dtiFrom.Size = New System.Drawing.Size(103, 20)
        Me.dtiFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFrom.TabIndex = 28
        '
        'tbSearch
        '
        Me.tbSearch.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbSearch.Border.Class = "TextBoxBorder"
        Me.tbSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSearch.Location = New System.Drawing.Point(285, 43)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(201, 20)
        Me.tbSearch.TabIndex = 31
        Me.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExportExcel
        '
        Me.btnExportExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExportExcel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnExportExcel.Location = New System.Drawing.Point(631, 525)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnExportExcel.Size = New System.Drawing.Size(100, 36)
        Me.btnExportExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportExcel.TabIndex = 45
        Me.btnExportExcel.Text = "Export To Excel"
        Me.btnExportExcel.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSearch.Location = New System.Drawing.Point(525, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "Search"
        '
        'btnExportText
        '
        Me.btnExportText.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportText.BackColor = System.Drawing.Color.Transparent
        Me.btnExportText.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportText.ForeColor = System.Drawing.Color.Black
        Me.btnExportText.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnExportText.Location = New System.Drawing.Point(523, 525)
        Me.btnExportText.Name = "btnExportText"
        Me.btnExportText.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnExportText.Size = New System.Drawing.Size(100, 36)
        Me.btnExportText.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportText.TabIndex = 42
        Me.btnExportText.Text = "Export To Text"
        Me.btnExportText.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRefresh.Location = New System.Drawing.Point(631, 21)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRefresh.Size = New System.Drawing.Size(100, 36)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 30
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Tooltip = "Refresh grid view"
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Enabled = False
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemove.Location = New System.Drawing.Point(979, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 36)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 39
        Me.btnRemove.Text = "Re&move"
        Me.btnRemove.Tooltip = "Removes the selected data from the database."
        Me.btnRemove.Visible = False
        '
        'frmMVRCreditLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 582)
        Me.Controls.Add(Me.pnlLoyalty)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMVRCreditLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlLoyalty.ResumeLayout(False)
        Me.pnlSave.ResumeLayout(False)
        Me.pnlSave.PerformLayout()
        CType(Me.dtiTransDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLoyalty As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnlSave As System.Windows.Forms.Panel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiTransDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cboTransMode As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCardID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbPoints As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgTransLogs As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents dtiTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnExportExcel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExportText As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCardID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colConcessionaire As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
