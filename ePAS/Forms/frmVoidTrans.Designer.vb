<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidTrans
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
        Me.pnlVoidTrans = New DevComponents.DotNetBar.PanelEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.dtiTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.dtiFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboConcessionaire = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSite = New System.Windows.Forms.ComboBox
        Me.cboMemberID = New System.Windows.Forms.ComboBox
        Me.btnList = New DevComponents.DotNetBar.ButtonX
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX
        Me.dgTransLogs = New System.Windows.Forms.DataGridView
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colConcessionaire = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlVoidTrans.SuspendLayout()
        CType(Me.dtiTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVoidTrans
        '
        Me.pnlVoidTrans.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlVoidTrans.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlVoidTrans.Controls.Add(Me.LabelX2)
        Me.pnlVoidTrans.Controls.Add(Me.LabelX1)
        Me.pnlVoidTrans.Controls.Add(Me.dtiTo)
        Me.pnlVoidTrans.Controls.Add(Me.dtiFrom)
        Me.pnlVoidTrans.Controls.Add(Me.Label3)
        Me.pnlVoidTrans.Controls.Add(Me.cboConcessionaire)
        Me.pnlVoidTrans.Controls.Add(Me.Label2)
        Me.pnlVoidTrans.Controls.Add(Me.cboSite)
        Me.pnlVoidTrans.Controls.Add(Me.cboMemberID)
        Me.pnlVoidTrans.Controls.Add(Me.btnList)
        Me.pnlVoidTrans.Controls.Add(Me.btnVoid)
        Me.pnlVoidTrans.Controls.Add(Me.dgTransLogs)
        Me.pnlVoidTrans.Controls.Add(Me.Label1)
        Me.pnlVoidTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVoidTrans.Location = New System.Drawing.Point(0, 0)
        Me.pnlVoidTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlVoidTrans.Name = "pnlVoidTrans"
        Me.pnlVoidTrans.Size = New System.Drawing.Size(972, 505)
        Me.pnlVoidTrans.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlVoidTrans.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlVoidTrans.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlVoidTrans.Style.BackgroundImage = Global.MVRProgram.My.Resources.Resources.Abstract_blue011
        Me.pnlVoidTrans.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlVoidTrans.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlVoidTrans.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlVoidTrans.Style.GradientAngle = 90
        Me.pnlVoidTrans.TabIndex = 2
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
        Me.LabelX2.Location = New System.Drawing.Point(717, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(20, 16)
        Me.LabelX2.TabIndex = 67
        Me.LabelX2.Text = "To:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.LabelX1.Location = New System.Drawing.Point(579, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 16)
        Me.LabelX1.TabIndex = 66
        Me.LabelX1.Text = "From:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.dtiTo.Location = New System.Drawing.Point(717, 25)
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
        Me.dtiTo.Size = New System.Drawing.Size(132, 20)
        Me.dtiTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiTo.TabIndex = 65
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
        Me.dtiFrom.Location = New System.Drawing.Point(579, 25)
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
        Me.dtiFrom.Size = New System.Drawing.Size(132, 20)
        Me.dtiFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFrom.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Concessionaire:"
        '
        'cboConcessionaire
        '
        Me.cboConcessionaire.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboConcessionaire.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConcessionaire.FormattingEnabled = True
        Me.cboConcessionaire.Location = New System.Drawing.Point(390, 25)
        Me.cboConcessionaire.Name = "cboConcessionaire"
        Me.cboConcessionaire.Size = New System.Drawing.Size(183, 21)
        Me.cboConcessionaire.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Site:"
        '
        'cboSite
        '
        Me.cboSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Location = New System.Drawing.Point(201, 25)
        Me.cboSite.Name = "cboSite"
        Me.cboSite.Size = New System.Drawing.Size(183, 21)
        Me.cboSite.TabIndex = 23
        '
        'cboMemberID
        '
        Me.cboMemberID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMemberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMemberID.FormattingEnabled = True
        Me.cboMemberID.Location = New System.Drawing.Point(12, 25)
        Me.cboMemberID.Name = "cboMemberID"
        Me.cboMemberID.Size = New System.Drawing.Size(183, 21)
        Me.cboMemberID.Sorted = True
        Me.cboMemberID.TabIndex = 22
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.Black
        Me.btnList.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnList.Location = New System.Drawing.Point(860, 11)
        Me.btnList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(100, 36)
        Me.btnList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnList.TabIndex = 21
        Me.btnList.Text = "List"
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Black
        Me.btnVoid.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnVoid.Location = New System.Drawing.Point(860, 458)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(100, 36)
        Me.btnVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVoid.TabIndex = 20
        Me.btnVoid.Text = "Void"
        '
        'dgTransLogs
        '
        Me.dgTransLogs.AllowUserToAddRows = False
        Me.dgTransLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colID, Me.colTransDate, Me.colMemberID, Me.colFullName, Me.colSite, Me.colConcessionaire, Me.colPoints, Me.colRemarks})
        Me.dgTransLogs.Location = New System.Drawing.Point(12, 63)
        Me.dgTransLogs.Name = "dgTransLogs"
        Me.dgTransLogs.RowHeadersVisible = False
        Me.dgTransLogs.Size = New System.Drawing.Size(948, 390)
        Me.dgTransLogs.TabIndex = 2
        '
        'colCheck
        '
        Me.colCheck.DataPropertyName = "colCheck"
        Me.colCheck.HeaderText = "Select"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCheck.Width = 50
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "TransID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colTransDate
        '
        Me.colTransDate.DataPropertyName = "TransDate"
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colTransDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 120
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "CIM Number"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        '
        'colFullName
        '
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "Name"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Width = 200
        '
        'colSite
        '
        Me.colSite.DataPropertyName = "Site"
        Me.colSite.HeaderText = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.ReadOnly = True
        '
        'colConcessionaire
        '
        Me.colConcessionaire.DataPropertyName = "Concessionaire"
        Me.colConcessionaire.HeaderText = "Concessionaire"
        Me.colConcessionaire.Name = "colConcessionaire"
        Me.colConcessionaire.ReadOnly = True
        '
        'colPoints
        '
        Me.colPoints.DataPropertyName = "Points"
        Me.colPoints.HeaderText = "Points"
        Me.colPoints.Name = "colPoints"
        Me.colPoints.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.DataPropertyName = "Remarks"
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CIM Number:"
        '
        'frmVoidTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 505)
        Me.Controls.Add(Me.pnlVoidTrans)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVoidTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void Transaction"
        Me.pnlVoidTrans.ResumeLayout(False)
        Me.pnlVoidTrans.PerformLayout()
        CType(Me.dtiTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlVoidTrans As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgTransLogs As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboConcessionaire As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSite As System.Windows.Forms.ComboBox
    Friend WithEvents cboMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents colCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colConcessionaire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
