<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualReset
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
        Me.pnlGroupManger = New DevComponents.DotNetBar.PanelEx
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.txtSearchKey = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.dgvMember = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCAAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAMABalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colARAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCreditType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnReset = New DevComponents.DotNetBar.ButtonX
        Me.pnlGroupManger.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.pnlAdd)
        Me.pnlGroupManger.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlGroupManger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGroupManger.Location = New System.Drawing.Point(0, 0)
        Me.pnlGroupManger.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGroupManger.Name = "pnlGroupManger"
        Me.pnlGroupManger.Size = New System.Drawing.Size(866, 608)
        Me.pnlGroupManger.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlGroupManger.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlGroupManger.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlGroupManger.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlGroupManger.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlGroupManger.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlGroupManger.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlGroupManger.Style.GradientAngle = 90
        Me.pnlGroupManger.TabIndex = 2
        '
        'pnlAdd
        '
        Me.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdd.Controls.Add(Me.chkAll)
        Me.pnlAdd.Controls.Add(Me.LabelX16)
        Me.pnlAdd.Controls.Add(Me.btnSearch)
        Me.pnlAdd.Controls.Add(Me.txtSearchKey)
        Me.pnlAdd.Controls.Add(Me.LabelX12)
        Me.pnlAdd.Controls.Add(Me.cboSearchBy)
        Me.pnlAdd.Controls.Add(Me.dgvMember)
        Me.pnlAdd.Controls.Add(Me.btnReset)
        Me.pnlAdd.Location = New System.Drawing.Point(12, 12)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(841, 593)
        Me.pnlAdd.TabIndex = 40
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(15, 67)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(15, 14)
        Me.chkAll.TabIndex = 59
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.White
        Me.LabelX16.Location = New System.Drawing.Point(321, 5)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(70, 16)
        Me.LabelX16.TabIndex = 30
        Me.LabelX16.Text = "Search Key:"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Location = New System.Drawing.Point(605, 22)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 32
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
        Me.txtSearchKey.Location = New System.Drawing.Point(321, 30)
        Me.txtSearchKey.MaxLength = 20
        Me.txtSearchKey.Name = "txtSearchKey"
        Me.txtSearchKey.Size = New System.Drawing.Size(267, 21)
        Me.txtSearchKey.TabIndex = 31
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.White
        Me.LabelX12.Location = New System.Drawing.Point(131, 5)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(63, 16)
        Me.LabelX12.TabIndex = 28
        Me.LabelX12.Text = "Search By:"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboSearchBy
        '
        Me.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Employee ID", "FullName"})
        Me.cboSearchBy.Location = New System.Drawing.Point(131, 29)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(182, 21)
        Me.cboSearchBy.TabIndex = 29
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMember.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colID, Me.colMemberID, Me.colFullName, Me.colCAAmount, Me.colAMABalance, Me.colARAmount, Me.colSDBalance, Me.colCreditType})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMember.Location = New System.Drawing.Point(6, 63)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMember.Size = New System.Drawing.Size(814, 466)
        Me.dgvMember.TabIndex = 33
        '
        'colSelect
        '
        Me.colSelect.FalseValue = "False"
        Me.colSelect.HeaderText = ""
        Me.colSelect.Name = "colSelect"
        Me.colSelect.TrueValue = "True"
        Me.colSelect.Width = 30
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colMemberID
        '
        Me.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "EmployeeID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.Width = 99
        '
        'colFullName
        '
        Me.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.MinimumWidth = 250
        Me.colFullName.Name = "colFullName"
        Me.colFullName.Width = 250
        '
        'colCAAmount
        '
        Me.colCAAmount.DataPropertyName = "CAAmount"
        Me.colCAAmount.HeaderText = "CA Amount"
        Me.colCAAmount.Name = "colCAAmount"
        Me.colCAAmount.ReadOnly = True
        '
        'colAMABalance
        '
        Me.colAMABalance.DataPropertyName = "CAConsumable"
        Me.colAMABalance.HeaderText = "CA Balance"
        Me.colAMABalance.Name = "colAMABalance"
        '
        'colARAmount
        '
        Me.colARAmount.DataPropertyName = "ARAmount"
        Me.colARAmount.HeaderText = "AR Amount"
        Me.colARAmount.Name = "colARAmount"
        Me.colARAmount.ReadOnly = True
        '
        'colSDBalance
        '
        Me.colSDBalance.DataPropertyName = "ARConsumable"
        Me.colSDBalance.HeaderText = "AR Balance"
        Me.colSDBalance.Name = "colSDBalance"
        '
        'colCreditType
        '
        Me.colCreditType.DataPropertyName = "CreditType"
        Me.colCreditType.HeaderText = "CreditType"
        Me.colCreditType.Name = "colCreditType"
        Me.colCreditType.ReadOnly = True
        Me.colCreditType.Visible = False
        '
        'btnReset
        '
        Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnReset.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnReset.Location = New System.Drawing.Point(368, 538)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnReset.Size = New System.Drawing.Size(100, 38)
        Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        '
        'frmManualReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 608)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmManualReset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual CA/AR Reset"
        Me.pnlGroupManger.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSearchKey As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMember As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents btnReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCAAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAMABalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colARAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCreditType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
