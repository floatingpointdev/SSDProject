<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRewardsViewer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgRewards = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCardID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colConsumablePoints = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colValidFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colValidTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateUploaded = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUploadedBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUpdatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateAdded = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddedBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlLoyalty = New DevComponents.DotNetBar.PanelEx
        Me.grpFilter = New System.Windows.Forms.GroupBox
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.tbSearch = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.btnReset = New DevComponents.DotNetBar.ButtonX
        Me.btnFilter = New DevComponents.DotNetBar.ButtonX
        Me.grpMaintenance = New System.Windows.Forms.GroupBox
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        CType(Me.dgRewards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoyalty.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.grpMaintenance.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgRewards
        '
        Me.dgRewards.AllowUserToAddRows = False
        Me.dgRewards.AllowUserToDeleteRows = False
        Me.dgRewards.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRewards.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRewards.BackgroundColor = System.Drawing.Color.White
        Me.dgRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRewards.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colMemberID, Me.colCardID, Me.colName, Me.colPoints, Me.colConsumablePoints, Me.colValidFrom, Me.colValidTo, Me.colSite, Me.colDateUploaded, Me.colUploadedBy, Me.colDateUpdated, Me.colUpdatedBy, Me.colDateAdded, Me.colAddedBy})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRewards.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgRewards.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgRewards.Location = New System.Drawing.Point(12, 68)
        Me.dgRewards.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgRewards.Name = "dgRewards"
        Me.dgRewards.RowHeadersVisible = False
        Me.dgRewards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRewards.Size = New System.Drawing.Size(1153, 485)
        Me.dgRewards.TabIndex = 56
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "CIMNumber"
        Me.colMemberID.Name = "colMemberID"
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
        Me.colPoints.DataPropertyName = "Points"
        Me.colPoints.HeaderText = "Points"
        Me.colPoints.Name = "colPoints"
        Me.colPoints.Width = 61
        '
        'colConsumablePoints
        '
        Me.colConsumablePoints.DataPropertyName = "ConsumablePoints"
        Me.colConsumablePoints.HeaderText = "ConsumableRewards"
        Me.colConsumablePoints.Name = "colConsumablePoints"
        '
        'colValidFrom
        '
        Me.colValidFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colValidFrom.DataPropertyName = "ValidFrom"
        Me.colValidFrom.HeaderText = "EffectivityDate"
        Me.colValidFrom.Name = "colValidFrom"
        Me.colValidFrom.Width = 101
        '
        'colValidTo
        '
        Me.colValidTo.DataPropertyName = "ValidTo"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colValidTo.DefaultCellStyle = DataGridViewCellStyle5
        Me.colValidTo.HeaderText = "ExpirationDate"
        Me.colValidTo.Name = "colValidTo"
        '
        'colSite
        '
        Me.colSite.DataPropertyName = "Address"
        Me.colSite.HeaderText = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.ReadOnly = True
        '
        'colDateUploaded
        '
        Me.colDateUploaded.DataPropertyName = "DateUploaded"
        Me.colDateUploaded.HeaderText = "DateUploaded"
        Me.colDateUploaded.Name = "colDateUploaded"
        Me.colDateUploaded.ReadOnly = True
        '
        'colUploadedBy
        '
        Me.colUploadedBy.DataPropertyName = "UploadedBy"
        Me.colUploadedBy.HeaderText = "UploadedBy"
        Me.colUploadedBy.Name = "colUploadedBy"
        Me.colUploadedBy.ReadOnly = True
        '
        'colDateUpdated
        '
        Me.colDateUpdated.DataPropertyName = "DateUpdated"
        Me.colDateUpdated.HeaderText = "DateUpdated"
        Me.colDateUpdated.Name = "colDateUpdated"
        Me.colDateUpdated.ReadOnly = True
        '
        'colUpdatedBy
        '
        Me.colUpdatedBy.DataPropertyName = "UpdatedBy"
        Me.colUpdatedBy.HeaderText = "UpdatedBy"
        Me.colUpdatedBy.Name = "colUpdatedBy"
        Me.colUpdatedBy.ReadOnly = True
        '
        'colDateAdded
        '
        Me.colDateAdded.DataPropertyName = "DateAdded"
        Me.colDateAdded.HeaderText = "DateAdded"
        Me.colDateAdded.Name = "colDateAdded"
        Me.colDateAdded.ReadOnly = True
        '
        'colAddedBy
        '
        Me.colAddedBy.DataPropertyName = "AddedBy"
        Me.colAddedBy.HeaderText = "AddedBy"
        Me.colAddedBy.Name = "colAddedBy"
        Me.colAddedBy.ReadOnly = True
        '
        'pnlLoyalty
        '
        Me.pnlLoyalty.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLoyalty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLoyalty.Controls.Add(Me.dgRewards)
        Me.pnlLoyalty.Controls.Add(Me.grpFilter)
        Me.pnlLoyalty.Controls.Add(Me.grpMaintenance)
        Me.pnlLoyalty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoyalty.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoyalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLoyalty.Name = "pnlLoyalty"
        Me.pnlLoyalty.Size = New System.Drawing.Size(1177, 618)
        Me.pnlLoyalty.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLoyalty.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLoyalty.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLoyalty.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlLoyalty.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLoyalty.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLoyalty.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLoyalty.Style.GradientAngle = 90
        Me.pnlLoyalty.TabIndex = 57
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.LabelX6)
        Me.grpFilter.Controls.Add(Me.tbSearch)
        Me.grpFilter.Controls.Add(Me.cboSearchBy)
        Me.grpFilter.Controls.Add(Me.btnReset)
        Me.grpFilter.Controls.Add(Me.btnFilter)
        Me.grpFilter.Location = New System.Drawing.Point(12, 3)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(1153, 60)
        Me.grpFilter.TabIndex = 66
        Me.grpFilter.TabStop = False
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
        Me.LabelX6.Location = New System.Drawing.Point(6, 22)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(61, 16)
        Me.LabelX6.TabIndex = 59
        Me.LabelX6.Text = "Search By:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbSearch
        '
        Me.tbSearch.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbSearch.Border.Class = "TextBoxBorder"
        Me.tbSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSearch.Location = New System.Drawing.Point(279, 20)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(201, 20)
        Me.tbSearch.TabIndex = 58
        Me.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSearchBy
        '
        Me.cboSearchBy.BackColor = System.Drawing.Color.Honeydew
        Me.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"CIM Number", "Name", "Consumable Points", "Site"})
        Me.cboSearchBy.Location = New System.Drawing.Point(73, 20)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(200, 21)
        Me.cboSearchBy.TabIndex = 57
        '
        'btnReset
        '
        Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnReset.Location = New System.Drawing.Point(592, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnReset.Size = New System.Drawing.Size(100, 36)
        Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReset.TabIndex = 60
        Me.btnReset.Text = "Reset"
        Me.btnReset.Tooltip = "Reset grid view"
        '
        'btnFilter
        '
        Me.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnFilter.ForeColor = System.Drawing.Color.Black
        Me.btnFilter.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnFilter.Location = New System.Drawing.Point(486, 12)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnFilter.Size = New System.Drawing.Size(100, 36)
        Me.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFilter.TabIndex = 61
        Me.btnFilter.Text = "Filter"
        '
        'grpMaintenance
        '
        Me.grpMaintenance.Controls.Add(Me.btnAdd)
        Me.grpMaintenance.Controls.Add(Me.btnRemove)
        Me.grpMaintenance.Controls.Add(Me.btnEdit)
        Me.grpMaintenance.Controls.Add(Me.btnSave)
        Me.grpMaintenance.Controls.Add(Me.btnCancel)
        Me.grpMaintenance.Location = New System.Drawing.Point(12, 549)
        Me.grpMaintenance.Name = "grpMaintenance"
        Me.grpMaintenance.Size = New System.Drawing.Size(1153, 66)
        Me.grpMaintenance.TabIndex = 68
        Me.grpMaintenance.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAdd.Location = New System.Drawing.Point(296, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAdd.Size = New System.Drawing.Size(100, 38)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 64
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.Tooltip = "Adds new member information."
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemove.Location = New System.Drawing.Point(641, 14)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRemove.Size = New System.Drawing.Size(100, 38)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 63
        Me.btnRemove.Text = "Re&move"
        Me.btnRemove.Tooltip = "Removes the selected data from the database."
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(411, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnEdit.Size = New System.Drawing.Size(100, 38)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 67
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(526, 14)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSave.Size = New System.Drawing.Size(100, 38)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 62
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(756, 14)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 38)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "Cancel"
        '
        'frmRewardsViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 618)
        Me.Controls.Add(Me.pnlLoyalty)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmRewardsViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rewards Viewer"
        CType(Me.dgRewards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoyalty.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.grpMaintenance.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgRewards As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents pnlLoyalty As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCardID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colConsumablePoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValidFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValidTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateUploaded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUploadedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUpdatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateAdded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpMaintenance As System.Windows.Forms.GroupBox
End Class
