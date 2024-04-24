<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetCalendar
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.dgARCalendar = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewDateTimeInputColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgCACalendar = New System.Windows.Forms.DataGridView
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgARCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCACalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.dgARCalendar)
        Me.PanelEx1.Controls.Add(Me.btnSave)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.dgCACalendar)
        Me.PanelEx1.Controls.Add(Me.btnClose)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(800, 464)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 26
        '
        'dgARCalendar
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgARCalendar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgARCalendar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgARCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgARCalendar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewDateTimeInputColumn1})
        Me.dgARCalendar.Location = New System.Drawing.Point(351, 31)
        Me.dgARCalendar.Name = "dgARCalendar"
        Me.dgARCalendar.Size = New System.Drawing.Size(333, 421)
        Me.dgARCalendar.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewDateTimeInputColumn1
        '
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewDateTimeInputColumn1.ButtonDropDown.Visible = True
        Me.DataGridViewDateTimeInputColumn1.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.DataGridViewDateTimeInputColumn1.DataPropertyName = "Date"
        Me.DataGridViewDateTimeInputColumn1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.DataGridViewDateTimeInputColumn1.HeaderText = "Date"
        Me.DataGridViewDateTimeInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDateTimeInputColumn1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DataGridViewDateTimeInputColumn1.Name = "DataGridViewDateTimeInputColumn1"
        Me.DataGridViewDateTimeInputColumn1.Width = 200
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(689, 31)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(348, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AR Reset Schedule:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CA Reset Schedule:"
        '
        'dgCACalendar
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Format = "MM/dd/yyyy hh:mm tt"
        Me.dgCACalendar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCACalendar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCACalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCACalendar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colDate})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Format = "MM/dd/yyyy hh:mm tt"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCACalendar.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCACalendar.Location = New System.Drawing.Point(12, 31)
        Me.dgCACalendar.Name = "dgCACalendar"
        DataGridViewCellStyle7.Format = "MM/dd/yyyy mm:hh tt"
        Me.dgCACalendar.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgCACalendar.RowTemplate.DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt"
        Me.dgCACalendar.Size = New System.Drawing.Size(333, 421)
        Me.dgCACalendar.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClose.Location = New System.Drawing.Point(689, 78)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 36)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colDate
        '
        '
        '
        '
        Me.colDate.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.colDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.colDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.colDate.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.colDate.ButtonDropDown.Visible = True
        Me.colDate.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.colDate.DataPropertyName = "Date"
        DataGridViewCellStyle5.Format = "MM/dd/yyyy hh:mm tt"
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.colDate.HeaderText = "Date"
        Me.colDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.colDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.colDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.colDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.colDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.colDate.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.colDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.colDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.colDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.colDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 200
        '
        'frmResetCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(800, 464)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmResetCalendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Calendar"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgARCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCACalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgCACalendar As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgARCalendar As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDateTimeInputColumn1 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
End Class
