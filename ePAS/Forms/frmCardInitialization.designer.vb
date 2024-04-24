<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardInitialization
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCardInitialization))
        Me.pnlLocAss = New DevComponents.DotNetBar.PanelEx
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.dgvCard = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX
        Me.pnlSave = New System.Windows.Forms.Panel
        Me.btnGetCardID = New DevComponents.DotNetBar.ButtonX
        Me.cboLoyaltyCode = New System.Windows.Forms.ComboBox
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.tbPoints = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cboMemberID = New System.Windows.Forms.ComboBox
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnClear = New DevComponents.DotNetBar.ButtonX
        Me.tbCardID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.colCardID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLoyaltyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlLocAss.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        CType(Me.dgvCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLocAss
        '
        Me.pnlLocAss.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLocAss.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLocAss.Controls.Add(Me.pnlAdd)
        Me.pnlLocAss.Controls.Add(Me.pnlSave)
        Me.pnlLocAss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLocAss.Location = New System.Drawing.Point(0, 0)
        Me.pnlLocAss.Name = "pnlLocAss"
        Me.pnlLocAss.Size = New System.Drawing.Size(569, 499)
        Me.pnlLocAss.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLocAss.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLocAss.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLocAss.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlLocAss.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLocAss.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLocAss.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLocAss.Style.GradientAngle = 90
        Me.pnlLocAss.TabIndex = 1
        '
        'pnlAdd
        '
        Me.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Controls.Add(Me.dgvCard)
        Me.pnlAdd.Controls.Add(Me.btnEdit)
        Me.pnlAdd.Controls.Add(Me.btnRemove)
        Me.pnlAdd.Location = New System.Drawing.Point(3, 206)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(554, 284)
        Me.pnlAdd.TabIndex = 35
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAdd.Location = New System.Drawing.Point(119, 227)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 36)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.Tooltip = "Add new data."
        '
        'dgvCard
        '
        Me.dgvCard.AllowUserToAddRows = False
        Me.dgvCard.AllowUserToDeleteRows = False
        Me.dgvCard.AllowUserToResizeColumns = False
        Me.dgvCard.AllowUserToResizeRows = False
        Me.dgvCard.BackgroundColor = System.Drawing.Color.White
        Me.dgvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCardID, Me.colMemberID, Me.colName, Me.colPoints, Me.colLoyaltyCode, Me.colID})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCard.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCard.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvCard.Location = New System.Drawing.Point(5, 18)
        Me.dgvCard.MultiSelect = False
        Me.dgvCard.Name = "dgvCard"
        Me.dgvCard.ReadOnly = True
        Me.dgvCard.RowHeadersVisible = False
        Me.dgvCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCard.Size = New System.Drawing.Size(540, 203)
        Me.dgvCard.TabIndex = 13
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(225, 227)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 36)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.Tooltip = "Edit the selected data."
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemove.Location = New System.Drawing.Point(331, 227)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 36)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "Re&move"
        Me.btnRemove.Tooltip = "Removes the selected data from the database."
        '
        'pnlSave
        '
        Me.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSave.Controls.Add(Me.btnGetCardID)
        Me.pnlSave.Controls.Add(Me.cboLoyaltyCode)
        Me.pnlSave.Controls.Add(Me.LabelX3)
        Me.pnlSave.Controls.Add(Me.tbPoints)
        Me.pnlSave.Controls.Add(Me.cboMemberID)
        Me.pnlSave.Controls.Add(Me.LabelX2)
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Controls.Add(Me.btnClear)
        Me.pnlSave.Controls.Add(Me.tbCardID)
        Me.pnlSave.Controls.Add(Me.LabelX5)
        Me.pnlSave.Controls.Add(Me.LabelX1)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Location = New System.Drawing.Point(3, 3)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(554, 197)
        Me.pnlSave.TabIndex = 34
        '
        'btnGetCardID
        '
        Me.btnGetCardID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetCardID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGetCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCardID.ForeColor = System.Drawing.Color.Black
        Me.btnGetCardID.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnGetCardID.Location = New System.Drawing.Point(66, 145)
        Me.btnGetCardID.Name = "btnGetCardID"
        Me.btnGetCardID.Size = New System.Drawing.Size(100, 36)
        Me.btnGetCardID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGetCardID.TabIndex = 7
        Me.btnGetCardID.Text = "Get Card ID"
        Me.btnGetCardID.Tooltip = "Gets Card ID from the tapped card"
        '
        'cboLoyaltyCode
        '
        Me.cboLoyaltyCode.BackColor = System.Drawing.Color.Honeydew
        Me.cboLoyaltyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoyaltyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoyaltyCode.ForeColor = System.Drawing.Color.Black
        Me.cboLoyaltyCode.FormattingEnabled = True
        Me.cboLoyaltyCode.Location = New System.Drawing.Point(173, 102)
        Me.cboLoyaltyCode.Name = "cboLoyaltyCode"
        Me.cboLoyaltyCode.Size = New System.Drawing.Size(257, 23)
        Me.cboLoyaltyCode.TabIndex = 6
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
        Me.LabelX3.Location = New System.Drawing.Point(89, 105)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(76, 16)
        Me.LabelX3.TabIndex = 24
        Me.LabelX3.Text = "Loyalty Code:"
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
        Me.tbPoints.Location = New System.Drawing.Point(173, 75)
        Me.tbPoints.Name = "tbPoints"
        Me.tbPoints.Size = New System.Drawing.Size(258, 21)
        Me.tbPoints.TabIndex = 5
        Me.tbPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbPoints.WatermarkText = "Enter Points"
        '
        'cboMemberID
        '
        Me.cboMemberID.BackColor = System.Drawing.Color.Honeydew
        Me.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemberID.ForeColor = System.Drawing.Color.Black
        Me.cboMemberID.FormattingEnabled = True
        Me.cboMemberID.Location = New System.Drawing.Point(174, 46)
        Me.cboMemberID.Name = "cboMemberID"
        Me.cboMemberID.Size = New System.Drawing.Size(257, 23)
        Me.cboMemberID.TabIndex = 3
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
        Me.LabelX2.Location = New System.Drawing.Point(126, 77)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(39, 16)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Points:"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(384, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Tooltip = "Cancel initialization"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClear.Location = New System.Drawing.Point(278, 145)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Tooltip = "Clears all text areas."
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
        Me.tbCardID.Location = New System.Drawing.Point(174, 19)
        Me.tbCardID.Name = "tbCardID"
        Me.tbCardID.ReadOnly = True
        Me.tbCardID.Size = New System.Drawing.Size(258, 21)
        Me.tbCardID.TabIndex = 1
        Me.tbCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCardID.WatermarkText = "Tap Card"
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
        Me.LabelX5.Location = New System.Drawing.Point(101, 49)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 16)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Member ID:"
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
        Me.LabelX1.Location = New System.Drawing.Point(119, 21)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(47, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Card ID:"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(172, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.Tooltip = "Saves/Updates the information."
        '
        'colCardID
        '
        Me.colCardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCardID.DataPropertyName = "CardID"
        Me.colCardID.HeaderText = "Card ID"
        Me.colCardID.Name = "colCardID"
        Me.colCardID.ReadOnly = True
        Me.colCardID.Width = 73
        '
        'colMemberID
        '
        Me.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "Member ID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Width = 94
        '
        'colName
        '
        Me.colName.DataPropertyName = "FullName"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 150
        '
        'colPoints
        '
        Me.colPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPoints.DataPropertyName = "Points"
        Me.colPoints.HeaderText = "Points"
        Me.colPoints.Name = "colPoints"
        Me.colPoints.ReadOnly = True
        Me.colPoints.Width = 66
        '
        'colLoyaltyCode
        '
        Me.colLoyaltyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLoyaltyCode.DataPropertyName = "LoyaltyCode"
        Me.colLoyaltyCode.HeaderText = "Loyalty Code"
        Me.colLoyaltyCode.Name = "colLoyaltyCode"
        Me.colLoyaltyCode.ReadOnly = True
        Me.colLoyaltyCode.Width = 101
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'frmCardInitialization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(569, 499)
        Me.Controls.Add(Me.pnlLocAss)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCardInitialization"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Card Initialization"
        Me.pnlLocAss.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        CType(Me.dgvCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSave.ResumeLayout(False)
        Me.pnlSave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLocAss As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvCard As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pnlSave As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbCardID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents tbPoints As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboLoyaltyCode As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnGetCardID As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colCardID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLoyaltyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
