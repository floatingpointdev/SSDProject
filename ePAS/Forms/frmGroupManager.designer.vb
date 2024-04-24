<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupManager))
        Me.pnlGroupManger = New DevComponents.DotNetBar.PanelEx
        Me.gbSearchGroup = New System.Windows.Forms.GroupBox
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnRemoveGroup = New DevComponents.DotNetBar.ButtonX
        Me.dgvGroups = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colGroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccountType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbEditGroup = New System.Windows.Forms.GroupBox
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cboAccountType = New System.Windows.Forms.ComboBox
        Me.tbGroupDesc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.tbGroup = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnSaveGroup = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PicGroups = New System.Windows.Forms.PictureBox
        Me.pnlGroupManger.SuspendLayout()
        Me.gbSearchGroup.SuspendLayout()
        CType(Me.dgvGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEditGroup.SuspendLayout()
        CType(Me.PicGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.gbSearchGroup)
        Me.pnlGroupManger.Controls.Add(Me.gbEditGroup)
        Me.pnlGroupManger.Controls.Add(Me.PicGroups)
        Me.pnlGroupManger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGroupManger.Location = New System.Drawing.Point(0, 0)
        Me.pnlGroupManger.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGroupManger.Name = "pnlGroupManger"
        Me.pnlGroupManger.Size = New System.Drawing.Size(446, 439)
        Me.pnlGroupManger.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlGroupManger.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlGroupManger.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlGroupManger.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlGroupManger.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlGroupManger.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlGroupManger.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlGroupManger.Style.GradientAngle = 90
        Me.pnlGroupManger.TabIndex = 0
        '
        'gbSearchGroup
        '
        Me.gbSearchGroup.Controls.Add(Me.btnAdd)
        Me.gbSearchGroup.Controls.Add(Me.btnEdit)
        Me.gbSearchGroup.Controls.Add(Me.btnRemoveGroup)
        Me.gbSearchGroup.Controls.Add(Me.dgvGroups)
        Me.gbSearchGroup.Location = New System.Drawing.Point(11, 184)
        Me.gbSearchGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSearchGroup.Name = "gbSearchGroup"
        Me.gbSearchGroup.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSearchGroup.Size = New System.Drawing.Size(420, 244)
        Me.gbSearchGroup.TabIndex = 36
        Me.gbSearchGroup.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAdd.Location = New System.Drawing.Point(56, 197)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAdd.Size = New System.Drawing.Size(100, 36)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.Tooltip = "Add new group."
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(160, 197)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnEdit.Size = New System.Drawing.Size(100, 36)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.Tooltip = "Edit selected group."
        '
        'btnRemoveGroup
        '
        Me.btnRemoveGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveGroup.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveGroup.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemoveGroup.Location = New System.Drawing.Point(264, 197)
        Me.btnRemoveGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveGroup.Name = "btnRemoveGroup"
        Me.btnRemoveGroup.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRemoveGroup.Size = New System.Drawing.Size(100, 36)
        Me.btnRemoveGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveGroup.TabIndex = 11
        Me.btnRemoveGroup.Text = "Re&move"
        Me.btnRemoveGroup.Tooltip = "Removes the selected data from the database."
        '
        'dgvGroups
        '
        Me.dgvGroups.AllowUserToAddRows = False
        Me.dgvGroups.AllowUserToDeleteRows = False
        Me.dgvGroups.AllowUserToResizeColumns = False
        Me.dgvGroups.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colGroupName, Me.colDescription, Me.colAccountType})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGroups.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGroups.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvGroups.Location = New System.Drawing.Point(5, 12)
        Me.dgvGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGroups.MultiSelect = False
        Me.dgvGroups.Name = "dgvGroups"
        Me.dgvGroups.ReadOnly = True
        Me.dgvGroups.RowHeadersVisible = False
        Me.dgvGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGroups.ShowEditingIcon = False
        Me.dgvGroups.Size = New System.Drawing.Size(410, 175)
        Me.dgvGroups.TabIndex = 8
        '
        'colGroupName
        '
        Me.colGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGroupName.DataPropertyName = "GroupCode"
        Me.colGroupName.HeaderText = "Group"
        Me.colGroupName.Name = "colGroupName"
        Me.colGroupName.ReadOnly = True
        Me.colGroupName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colGroupName.Width = 66
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "GroupDesc"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDescription.Width = 180
        '
        'colAccountType
        '
        Me.colAccountType.DataPropertyName = "AccountTypeDesc"
        Me.colAccountType.HeaderText = "AccountType"
        Me.colAccountType.Name = "colAccountType"
        Me.colAccountType.ReadOnly = True
        '
        'gbEditGroup
        '
        Me.gbEditGroup.Controls.Add(Me.LabelX2)
        Me.gbEditGroup.Controls.Add(Me.cboAccountType)
        Me.gbEditGroup.Controls.Add(Me.tbGroupDesc)
        Me.gbEditGroup.Controls.Add(Me.tbGroup)
        Me.gbEditGroup.Controls.Add(Me.LabelX5)
        Me.gbEditGroup.Controls.Add(Me.btnCancel)
        Me.gbEditGroup.Controls.Add(Me.btnSaveGroup)
        Me.gbEditGroup.Controls.Add(Me.LabelX1)
        Me.gbEditGroup.Location = New System.Drawing.Point(115, 2)
        Me.gbEditGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.gbEditGroup.Name = "gbEditGroup"
        Me.gbEditGroup.Padding = New System.Windows.Forms.Padding(2)
        Me.gbEditGroup.Size = New System.Drawing.Size(316, 178)
        Me.gbEditGroup.TabIndex = 35
        Me.gbEditGroup.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(8, 93)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 16)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Account Type:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboAccountType
        '
        Me.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountType.FormattingEnabled = True
        Me.cboAccountType.Location = New System.Drawing.Point(93, 90)
        Me.cboAccountType.Name = "cboAccountType"
        Me.cboAccountType.Size = New System.Drawing.Size(211, 23)
        Me.cboAccountType.TabIndex = 5
        '
        'tbGroupDesc
        '
        Me.tbGroupDesc.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbGroupDesc.Border.Class = "TextBoxBorder"
        Me.tbGroupDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbGroupDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGroupDesc.ForeColor = System.Drawing.Color.Black
        Me.tbGroupDesc.Location = New System.Drawing.Point(93, 49)
        Me.tbGroupDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGroupDesc.MaxLength = 50
        Me.tbGroupDesc.Multiline = True
        Me.tbGroupDesc.Name = "tbGroupDesc"
        Me.tbGroupDesc.Size = New System.Drawing.Size(211, 34)
        Me.tbGroupDesc.TabIndex = 3
        Me.tbGroupDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbGroupDesc.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGroupDesc.WatermarkText = "Enter Group Description"
        '
        'tbGroup
        '
        Me.tbGroup.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbGroup.Border.Class = "TextBoxBorder"
        Me.tbGroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGroup.ForeColor = System.Drawing.Color.Black
        Me.tbGroup.Location = New System.Drawing.Point(93, 19)
        Me.tbGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGroup.MaxLength = 10
        Me.tbGroup.Name = "tbGroup"
        Me.tbGroup.Size = New System.Drawing.Size(210, 21)
        Me.tbGroup.TabIndex = 1
        Me.tbGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbGroup.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGroup.WatermarkText = "Enter Group"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(21, 49)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(69, 16)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "Description:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(203, 131)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Tooltip = "Cancel edit."
        '
        'btnSaveGroup
        '
        Me.btnSaveGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGroup.ForeColor = System.Drawing.Color.Black
        Me.btnSaveGroup.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSaveGroup.Location = New System.Drawing.Point(93, 131)
        Me.btnSaveGroup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveGroup.Name = "btnSaveGroup"
        Me.btnSaveGroup.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSaveGroup.Size = New System.Drawing.Size(100, 36)
        Me.btnSaveGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSaveGroup.TabIndex = 6
        Me.btnSaveGroup.Text = "Sa&ve"
        Me.btnSaveGroup.Tooltip = "Saves the changes made."
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(48, 21)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(41, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Group:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PicGroups
        '
        Me.PicGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicGroups.Image = Global.SSDProject.My.Resources.Resources.groups
        Me.PicGroups.Location = New System.Drawing.Point(11, 11)
        Me.PicGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.PicGroups.Name = "PicGroups"
        Me.PicGroups.Size = New System.Drawing.Size(100, 100)
        Me.PicGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGroups.TabIndex = 35
        Me.PicGroups.TabStop = False
        '
        'frmGroupManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(446, 439)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGroupManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Manager"
        Me.pnlGroupManger.ResumeLayout(False)
        Me.gbSearchGroup.ResumeLayout(False)
        CType(Me.dgvGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEditGroup.ResumeLayout(False)
        Me.gbEditGroup.PerformLayout()
        CType(Me.PicGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnSaveGroup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gbEditGroup As System.Windows.Forms.GroupBox
    Friend WithEvents tbGroupDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbGroup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PicGroups As System.Windows.Forms.PictureBox
    Friend WithEvents gbSearchGroup As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemoveGroup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvGroups As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents colGroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccountType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
