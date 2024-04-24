<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandaloneService
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandaloneService))
        Me.tmrService = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtName = New System.Windows.Forms.TextBox
        Me.dgLogs = New System.Windows.Forms.DataGridView
        Me.colTransCount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoid = New System.Windows.Forms.DataGridViewButtonColumn
        Me.lblDate = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtAvailableRewards = New System.Windows.Forms.TextBox
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtCIMNumber = New System.Windows.Forms.TextBox
        Me.pbStatus = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.pbImage = New System.Windows.Forms.PictureBox
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.dgLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrService
        '
        Me.tmrService.Interval = 50
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.dgLogs)
        Me.PanelEx1.Controls.Add(Me.lblDate)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.pbStatus)
        Me.PanelEx1.Controls.Add(Me.pbImage)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(928, 555)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.MVRProgram.My.Resources.Resources.Abstract_blue011
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.txtName)
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(3, 296)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(251, 117)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 6
        Me.GroupPanel3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(3, 13)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(239, 66)
        Me.txtName.TabIndex = 0
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgLogs
        '
        Me.dgLogs.AllowUserToAddRows = False
        Me.dgLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTransCount, Me.colTransDate, Me.colMemberID, Me.colName, Me.colVoid})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLogs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgLogs.Location = New System.Drawing.Point(260, 72)
        Me.dgLogs.Name = "dgLogs"
        Me.dgLogs.ReadOnly = True
        Me.dgLogs.RowHeadersVisible = False
        Me.dgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLogs.Size = New System.Drawing.Size(656, 438)
        Me.dgLogs.TabIndex = 5
        '
        'colTransCount
        '
        Me.colTransCount.DataPropertyName = "RowCounter"
        Me.colTransCount.HeaderText = "TransCount"
        Me.colTransCount.Name = "colTransCount"
        Me.colTransCount.ReadOnly = True
        '
        'colTransDate
        '
        Me.colTransDate.DataPropertyName = "TransDate"
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 200
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "CIMNumber"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Width = 150
        '
        'colName
        '
        Me.colName.DataPropertyName = "FullName"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colVoid
        '
        Me.colVoid.HeaderText = ""
        Me.colVoid.Name = "colVoid"
        Me.colVoid.ReadOnly = True
        Me.colVoid.Text = "Void"
        Me.colVoid.UseColumnTextForButtonValue = True
        Me.colVoid.Width = 50
        '
        'lblDate
        '
        '
        '
        '
        Me.lblDate.BackgroundStyle.Class = ""
        Me.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(260, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(525, 54)
        Me.lblDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.lblDate.TabIndex = 4
        Me.lblDate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtAvailableRewards)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(3, 448)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(251, 62)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Available Rewards"
        '
        'txtAvailableRewards
        '
        Me.txtAvailableRewards.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableRewards.Location = New System.Drawing.Point(3, 8)
        Me.txtAvailableRewards.Name = "txtAvailableRewards"
        Me.txtAvailableRewards.Size = New System.Drawing.Size(239, 24)
        Me.txtAvailableRewards.TabIndex = 1
        Me.txtAvailableRewards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtCIMNumber)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 218)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(251, 72)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "CIMNumber"
        '
        'txtCIMNumber
        '
        Me.txtCIMNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIMNumber.Location = New System.Drawing.Point(3, 13)
        Me.txtCIMNumber.Name = "txtCIMNumber"
        Me.txtCIMNumber.Size = New System.Drawing.Size(239, 24)
        Me.txtCIMNumber.TabIndex = 0
        Me.txtCIMNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbStatus
        '
        '
        '
        '
        Me.pbStatus.BackgroundStyle.Class = ""
        Me.pbStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbStatus.Location = New System.Drawing.Point(0, 516)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee
        Me.pbStatus.Size = New System.Drawing.Size(928, 39)
        Me.pbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.pbStatus.TabIndex = 1
        Me.pbStatus.Text = "Service Running"
        Me.pbStatus.TextVisible = True
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Image = Global.MVRProgram.My.Resources.Resources.ACS_image1
        Me.pbImage.Location = New System.Drawing.Point(43, 12)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(170, 200)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'frmStandaloneService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 555)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStandaloneService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Standalone Service"
        Me.TopMost = True
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.dgLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents tmrService As System.Windows.Forms.Timer
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pbStatus As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtAvailableRewards As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtCIMNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgLogs As System.Windows.Forms.DataGridView
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents colTransCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoid As System.Windows.Forms.DataGridViewButtonColumn
End Class
