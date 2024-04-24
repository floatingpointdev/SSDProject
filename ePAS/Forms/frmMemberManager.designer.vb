<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberManager
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberManager))
        Me.pnlCard = New DevComponents.DotNetBar.PanelEx
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.btnOverrideCredits = New DevComponents.DotNetBar.ButtonX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.txtSearchKey = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.dgvMember = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCardID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBirthdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLExpiry = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAMABalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSDBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.pnlSave = New System.Windows.Forms.Panel
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.txtCredit = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.txtAMA = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.txtCompanyCode = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnRemovePhoto = New DevComponents.DotNetBar.ButtonX
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX
        Me.pbImage = New System.Windows.Forms.PictureBox
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.cboLoyaltyCode = New System.Windows.Forms.ComboBox
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.btnGetCardID = New DevComponents.DotNetBar.ButtonX
        Me.dtiMembershipDate = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.tbEmail = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.dtiBirthdate = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.tbCardID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.dtiExpiry = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.tbContactNo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.tbMName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.tbFName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.tbAddress = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.tbMemberID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.tbLName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.btnClear = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.pnlCard.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSave.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiBirthdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiExpiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlCard.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlCard.Controls.Add(Me.pnlAdd)
        Me.pnlCard.Controls.Add(Me.pnlSave)
        Me.pnlCard.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.pnlCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlCard.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(1107, 618)
        Me.pnlCard.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlCard.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlCard.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlCard.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlCard.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlCard.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlCard.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlCard.Style.GradientAngle = 90
        Me.pnlCard.Style.LineAlignment = System.Drawing.StringAlignment.Near
        Me.pnlCard.TabIndex = 1
        '
        'pnlAdd
        '
        Me.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdd.Controls.Add(Me.btnOverrideCredits)
        Me.pnlAdd.Controls.Add(Me.LabelX16)
        Me.pnlAdd.Controls.Add(Me.btnSearch)
        Me.pnlAdd.Controls.Add(Me.txtSearchKey)
        Me.pnlAdd.Controls.Add(Me.LabelX12)
        Me.pnlAdd.Controls.Add(Me.cboSearchBy)
        Me.pnlAdd.Controls.Add(Me.dgvMember)
        Me.pnlAdd.Controls.Add(Me.btnEdit)
        Me.pnlAdd.Controls.Add(Me.btnRemove)
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Location = New System.Drawing.Point(500, 13)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(596, 593)
        Me.pnlAdd.TabIndex = 39
        '
        'btnOverrideCredits
        '
        Me.btnOverrideCredits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOverrideCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnOverrideCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOverrideCredits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOverrideCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverrideCredits.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnOverrideCredits.Location = New System.Drawing.Point(6, 540)
        Me.btnOverrideCredits.Name = "btnOverrideCredits"
        Me.btnOverrideCredits.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOverrideCredits.Size = New System.Drawing.Size(100, 36)
        Me.btnOverrideCredits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOverrideCredits.TabIndex = 58
        Me.btnOverrideCredits.Text = "Override"
        Me.btnOverrideCredits.Tooltip = "Override Credits"
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
        Me.LabelX16.Location = New System.Drawing.Point(194, 5)
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
        Me.btnSearch.Location = New System.Drawing.Point(478, 22)
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
        Me.txtSearchKey.Location = New System.Drawing.Point(194, 30)
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
        Me.LabelX12.Location = New System.Drawing.Point(4, 5)
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
        Me.cboSearchBy.Location = New System.Drawing.Point(4, 29)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(182, 23)
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
        Me.dgvMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colMemberID, Me.colCardID, Me.colFullName, Me.colAddress, Me.colNo, Me.colBirthdate, Me.colLCode, Me.colLExpiry, Me.colAMABalance, Me.colSDBalance})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvMember.Location = New System.Drawing.Point(6, 63)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMember.Size = New System.Drawing.Size(572, 466)
        Me.dgvMember.TabIndex = 33
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
        Me.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "EmployeeID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Width = 99
        '
        'colCardID
        '
        Me.colCardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCardID.DataPropertyName = "CardID"
        Me.colCardID.HeaderText = "Card ID"
        Me.colCardID.Name = "colCardID"
        Me.colCardID.ReadOnly = True
        Me.colCardID.Visible = False
        '
        'colFullName
        '
        Me.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.MinimumWidth = 250
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Width = 250
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress.DataPropertyName = "Address"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.MinimumWidth = 200
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Visible = False
        '
        'colNo
        '
        Me.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNo.DataPropertyName = "ContactNo"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.colNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.colNo.HeaderText = "Contact No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Visible = False
        '
        'colBirthdate
        '
        Me.colBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBirthdate.DataPropertyName = "Birthdate"
        Me.colBirthdate.HeaderText = "Birthdate"
        Me.colBirthdate.Name = "colBirthdate"
        Me.colBirthdate.ReadOnly = True
        Me.colBirthdate.Visible = False
        '
        'colLCode
        '
        Me.colLCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLCode.DataPropertyName = "Email"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.colLCode.DefaultCellStyle = DataGridViewCellStyle5
        Me.colLCode.HeaderText = "Email"
        Me.colLCode.Name = "colLCode"
        Me.colLCode.ReadOnly = True
        Me.colLCode.Visible = False
        '
        'colLExpiry
        '
        Me.colLExpiry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLExpiry.DataPropertyName = "Expiry"
        DataGridViewCellStyle6.Format = "MM/dd/yyyy"
        Me.colLExpiry.DefaultCellStyle = DataGridViewCellStyle6
        Me.colLExpiry.HeaderText = "Member Expiry"
        Me.colLExpiry.Name = "colLExpiry"
        Me.colLExpiry.ReadOnly = True
        Me.colLExpiry.Visible = False
        '
        'colAMABalance
        '
        Me.colAMABalance.DataPropertyName = "AMABalance"
        Me.colAMABalance.HeaderText = "CA Balance"
        Me.colAMABalance.Name = "colAMABalance"
        Me.colAMABalance.ReadOnly = True
        '
        'colSDBalance
        '
        Me.colSDBalance.DataPropertyName = "SDBalance"
        Me.colSDBalance.HeaderText = "AR Balance"
        Me.colSDBalance.Name = "colSDBalance"
        Me.colSDBalance.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(362, 538)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnEdit.Size = New System.Drawing.Size(100, 38)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.Tooltip = "Edits the selected data."
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemove.Location = New System.Drawing.Point(478, 538)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRemove.Size = New System.Drawing.Size(100, 38)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "Re&move"
        Me.btnRemove.Tooltip = "Removes the selected data from the database."
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAdd.Location = New System.Drawing.Point(246, 538)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAdd.Size = New System.Drawing.Size(100, 38)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.Tooltip = "Adds new member information."
        '
        'pnlSave
        '
        Me.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSave.Controls.Add(Me.chkActive)
        Me.pnlSave.Controls.Add(Me.txtCredit)
        Me.pnlSave.Controls.Add(Me.LabelX19)
        Me.pnlSave.Controls.Add(Me.txtAMA)
        Me.pnlSave.Controls.Add(Me.LabelX18)
        Me.pnlSave.Controls.Add(Me.LabelX17)
        Me.pnlSave.Controls.Add(Me.txtCompanyCode)
        Me.pnlSave.Controls.Add(Me.btnRemovePhoto)
        Me.pnlSave.Controls.Add(Me.btnBrowse)
        Me.pnlSave.Controls.Add(Me.pbImage)
        Me.pnlSave.Controls.Add(Me.LabelX15)
        Me.pnlSave.Controls.Add(Me.TextBoxX2)
        Me.pnlSave.Controls.Add(Me.TextBoxX1)
        Me.pnlSave.Controls.Add(Me.LabelX14)
        Me.pnlSave.Controls.Add(Me.cboLoyaltyCode)
        Me.pnlSave.Controls.Add(Me.LabelX13)
        Me.pnlSave.Controls.Add(Me.btnGetCardID)
        Me.pnlSave.Controls.Add(Me.dtiMembershipDate)
        Me.pnlSave.Controls.Add(Me.tbEmail)
        Me.pnlSave.Controls.Add(Me.LabelX11)
        Me.pnlSave.Controls.Add(Me.LabelX3)
        Me.pnlSave.Controls.Add(Me.dtiBirthdate)
        Me.pnlSave.Controls.Add(Me.tbCardID)
        Me.pnlSave.Controls.Add(Me.LabelX7)
        Me.pnlSave.Controls.Add(Me.dtiExpiry)
        Me.pnlSave.Controls.Add(Me.LabelX10)
        Me.pnlSave.Controls.Add(Me.LabelX8)
        Me.pnlSave.Controls.Add(Me.tbContactNo)
        Me.pnlSave.Controls.Add(Me.LabelX9)
        Me.pnlSave.Controls.Add(Me.tbMName)
        Me.pnlSave.Controls.Add(Me.LabelX6)
        Me.pnlSave.Controls.Add(Me.tbFName)
        Me.pnlSave.Controls.Add(Me.LabelX2)
        Me.pnlSave.Controls.Add(Me.tbAddress)
        Me.pnlSave.Controls.Add(Me.tbMemberID)
        Me.pnlSave.Controls.Add(Me.LabelX5)
        Me.pnlSave.Controls.Add(Me.LabelX1)
        Me.pnlSave.Controls.Add(Me.tbLName)
        Me.pnlSave.Controls.Add(Me.LabelX4)
        Me.pnlSave.Controls.Add(Me.btnClear)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Location = New System.Drawing.Point(12, 13)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(482, 593)
        Me.pnlSave.TabIndex = 38
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkActive.ForeColor = System.Drawing.Color.White
        Me.chkActive.Location = New System.Drawing.Point(201, 295)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(63, 19)
        Me.chkActive.TabIndex = 23
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtCredit
        '
        Me.txtCredit.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtCredit.Border.Class = "TextBoxBorder"
        Me.txtCredit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.ForeColor = System.Drawing.Color.Black
        Me.txtCredit.Location = New System.Drawing.Point(221, 265)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(156, 21)
        Me.txtCredit.TabIndex = 22
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX19
        '
        Me.LabelX19.AutoSize = True
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.Color.White
        Me.LabelX19.Location = New System.Drawing.Point(190, 267)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(23, 16)
        Me.LabelX19.TabIndex = 21
        Me.LabelX19.Text = "AR:"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtAMA
        '
        Me.txtAMA.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtAMA.Border.Class = "TextBoxBorder"
        Me.txtAMA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMA.ForeColor = System.Drawing.Color.Black
        Me.txtAMA.Location = New System.Drawing.Point(221, 238)
        Me.txtAMA.Name = "txtAMA"
        Me.txtAMA.Size = New System.Drawing.Size(156, 21)
        Me.txtAMA.TabIndex = 20
        Me.txtAMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.ForeColor = System.Drawing.Color.White
        Me.LabelX18.Location = New System.Drawing.Point(191, 240)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(23, 16)
        Me.LabelX18.TabIndex = 19
        Me.LabelX18.Text = "CA:"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.White
        Me.LabelX17.Location = New System.Drawing.Point(123, 213)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(92, 16)
        Me.LabelX17.TabIndex = 17
        Me.LabelX17.Text = "Company Code:"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtCompanyCode.Border.Class = "TextBoxBorder"
        Me.txtCompanyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCompanyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyCode.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyCode.Location = New System.Drawing.Point(221, 211)
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Size = New System.Drawing.Size(156, 21)
        Me.txtCompanyCode.TabIndex = 18
        Me.txtCompanyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemovePhoto
        '
        Me.btnRemovePhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemovePhoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemovePhoto.Location = New System.Drawing.Point(13, 196)
        Me.btnRemovePhoto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemovePhoto.Name = "btnRemovePhoto"
        Me.btnRemovePhoto.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRemovePhoto.Size = New System.Drawing.Size(100, 36)
        Me.btnRemovePhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemovePhoto.TabIndex = 25
        Me.btnRemovePhoto.Text = "&Remove"
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Location = New System.Drawing.Point(13, 151)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnBrowse.Size = New System.Drawing.Size(100, 36)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowse.TabIndex = 24
        Me.btnBrowse.Text = "&Browse"
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImage.Location = New System.Drawing.Point(6, 15)
        Me.pbImage.Margin = New System.Windows.Forms.Padding(2)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(115, 132)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 57
        Me.pbImage.TabStop = False
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.White
        Me.LabelX15.Location = New System.Drawing.Point(140, 513)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(73, 16)
        Me.LabelX15.TabIndex = 56
        Me.LabelX15.Text = "Group Code:"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX15.Visible = False
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Enabled = False
        Me.TextBoxX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(221, 511)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.ReadOnly = True
        Me.TextBoxX2.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxX2.TabIndex = 55
        Me.TextBoxX2.TabStop = False
        Me.TextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxX2.Visible = False
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Enabled = False
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(221, 484)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxX1.TabIndex = 54
        Me.TextBoxX1.TabStop = False
        Me.TextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxX1.Visible = False
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.White
        Me.LabelX14.Location = New System.Drawing.Point(111, 484)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(104, 16)
        Me.LabelX14.TabIndex = 53
        Me.LabelX14.Text = "Department Code:"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX14.Visible = False
        '
        'cboLoyaltyCode
        '
        Me.cboLoyaltyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoyaltyCode.Enabled = False
        Me.cboLoyaltyCode.FormattingEnabled = True
        Me.cboLoyaltyCode.Location = New System.Drawing.Point(221, 455)
        Me.cboLoyaltyCode.Name = "cboLoyaltyCode"
        Me.cboLoyaltyCode.Size = New System.Drawing.Size(156, 23)
        Me.cboLoyaltyCode.TabIndex = 52
        Me.cboLoyaltyCode.Visible = False
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.White
        Me.LabelX13.Location = New System.Drawing.Point(135, 458)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(79, 16)
        Me.LabelX13.TabIndex = 51
        Me.LabelX13.Text = "Loyalty Code:"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX13.Visible = False
        '
        'btnGetCardID
        '
        Me.btnGetCardID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetCardID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGetCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCardID.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnGetCardID.Location = New System.Drawing.Point(382, 40)
        Me.btnGetCardID.Name = "btnGetCardID"
        Me.btnGetCardID.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnGetCardID.Size = New System.Drawing.Size(78, 36)
        Me.btnGetCardID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGetCardID.TabIndex = 4
        Me.btnGetCardID.Text = "&Get CardID"
        '
        'dtiMembershipDate
        '
        Me.dtiMembershipDate.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.dtiMembershipDate.Border.Class = "TextBoxBorder"
        Me.dtiMembershipDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiMembershipDate.Enabled = False
        Me.dtiMembershipDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiMembershipDate.ForeColor = System.Drawing.Color.Black
        Me.dtiMembershipDate.Location = New System.Drawing.Point(221, 399)
        Me.dtiMembershipDate.Name = "dtiMembershipDate"
        Me.dtiMembershipDate.ReadOnly = True
        Me.dtiMembershipDate.Size = New System.Drawing.Size(97, 21)
        Me.dtiMembershipDate.TabIndex = 46
        Me.dtiMembershipDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtiMembershipDate.Visible = False
        Me.dtiMembershipDate.WatermarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbEmail.Border.Class = "TextBoxBorder"
        Me.tbEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.ForeColor = System.Drawing.Color.Black
        Me.tbEmail.Location = New System.Drawing.Point(221, 344)
        Me.tbEmail.MaxLength = 50
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(239, 21)
        Me.tbEmail.TabIndex = 16
        Me.tbEmail.Visible = False
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.White
        Me.LabelX11.Location = New System.Drawing.Point(175, 346)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(37, 16)
        Me.LabelX11.TabIndex = 15
        Me.LabelX11.Text = "Email:"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX11.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.White
        Me.LabelX3.Location = New System.Drawing.Point(130, 401)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 16)
        Me.LabelX3.TabIndex = 42
        Me.LabelX3.Text = "Member Since:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX3.Visible = False
        '
        'dtiBirthdate
        '
        '
        '
        '
        Me.dtiBirthdate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiBirthdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiBirthdate.ButtonDropDown.Visible = True
        Me.dtiBirthdate.Enabled = False
        Me.dtiBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiBirthdate.ForeColor = System.Drawing.Color.Black
        Me.dtiBirthdate.IsPopupCalendarOpen = False
        Me.dtiBirthdate.Location = New System.Drawing.Point(221, 371)
        Me.dtiBirthdate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiBirthdate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiBirthdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiBirthdate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiBirthdate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiBirthdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiBirthdate.MonthCalendar.DisplayMonth = New Date(2011, 7, 1, 0, 0, 0, 0)
        Me.dtiBirthdate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiBirthdate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiBirthdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiBirthdate.MonthCalendar.TodayButtonVisible = True
        Me.dtiBirthdate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiBirthdate.Name = "dtiBirthdate"
        Me.dtiBirthdate.Size = New System.Drawing.Size(97, 21)
        Me.dtiBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiBirthdate.TabIndex = 24
        Me.dtiBirthdate.Visible = False
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
        Me.tbCardID.Location = New System.Drawing.Point(220, 47)
        Me.tbCardID.Name = "tbCardID"
        Me.tbCardID.Size = New System.Drawing.Size(156, 21)
        Me.tbCardID.TabIndex = 3
        Me.tbCardID.TabStop = False
        Me.tbCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCardID.WatermarkText = "Tap Card"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.White
        Me.LabelX7.Location = New System.Drawing.Point(165, 49)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(49, 16)
        Me.LabelX7.TabIndex = 2
        Me.LabelX7.Text = "Card ID:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtiExpiry
        '
        '
        '
        '
        Me.dtiExpiry.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiExpiry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiry.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiExpiry.ButtonDropDown.Visible = True
        Me.dtiExpiry.Enabled = False
        Me.dtiExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiExpiry.ForeColor = System.Drawing.Color.Black
        Me.dtiExpiry.IsPopupCalendarOpen = False
        Me.dtiExpiry.Location = New System.Drawing.Point(221, 427)
        Me.dtiExpiry.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiExpiry.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiExpiry.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiExpiry.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiry.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiExpiry.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiExpiry.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiry.MonthCalendar.DisplayMonth = New Date(2011, 7, 1, 0, 0, 0, 0)
        Me.dtiExpiry.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiExpiry.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiExpiry.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiExpiry.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiExpiry.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiExpiry.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiry.MonthCalendar.TodayButtonVisible = True
        Me.dtiExpiry.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiExpiry.Name = "dtiExpiry"
        Me.dtiExpiry.Size = New System.Drawing.Size(97, 21)
        Me.dtiExpiry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiExpiry.TabIndex = 30
        Me.dtiExpiry.Visible = False
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.White
        Me.LabelX10.Location = New System.Drawing.Point(125, 429)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(90, 16)
        Me.LabelX10.TabIndex = 35
        Me.LabelX10.Text = "Member Expiry:"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX10.Visible = False
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.White
        Me.LabelX8.Location = New System.Drawing.Point(158, 373)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(56, 16)
        Me.LabelX8.TabIndex = 33
        Me.LabelX8.Text = "Birthdate:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.Visible = False
        '
        'tbContactNo
        '
        Me.tbContactNo.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbContactNo.Border.Class = "TextBoxBorder"
        Me.tbContactNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContactNo.ForeColor = System.Drawing.Color.Black
        Me.tbContactNo.Location = New System.Drawing.Point(221, 317)
        Me.tbContactNo.MaxLength = 50
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(239, 21)
        Me.tbContactNo.TabIndex = 14
        Me.tbContactNo.Visible = False
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.White
        Me.LabelX9.Location = New System.Drawing.Point(145, 319)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(68, 16)
        Me.LabelX9.TabIndex = 13
        Me.LabelX9.Text = "Contact No:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX9.Visible = False
        '
        'tbMName
        '
        Me.tbMName.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbMName.Border.Class = "TextBoxBorder"
        Me.tbMName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMName.ForeColor = System.Drawing.Color.Black
        Me.tbMName.Location = New System.Drawing.Point(221, 138)
        Me.tbMName.MaxLength = 20
        Me.tbMName.Name = "tbMName"
        Me.tbMName.Size = New System.Drawing.Size(239, 21)
        Me.tbMName.TabIndex = 10
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(135, 140)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(79, 16)
        Me.LabelX6.TabIndex = 9
        Me.LabelX6.Text = "Middle Name:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbFName
        '
        Me.tbFName.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbFName.Border.Class = "TextBoxBorder"
        Me.tbFName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFName.ForeColor = System.Drawing.Color.Black
        Me.tbFName.Location = New System.Drawing.Point(221, 111)
        Me.tbFName.MaxLength = 20
        Me.tbFName.Name = "tbFName"
        Me.tbFName.Size = New System.Drawing.Size(239, 21)
        Me.tbFName.TabIndex = 8
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(147, 113)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(67, 16)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "First Name:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbAddress
        '
        Me.tbAddress.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbAddress.Border.Class = "TextBoxBorder"
        Me.tbAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.ForeColor = System.Drawing.Color.Black
        Me.tbAddress.Location = New System.Drawing.Point(221, 165)
        Me.tbAddress.MaxLength = 100
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(239, 37)
        Me.tbAddress.TabIndex = 12
        '
        'tbMemberID
        '
        Me.tbMemberID.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbMemberID.Border.Class = "TextBoxBorder"
        Me.tbMemberID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemberID.ForeColor = System.Drawing.Color.Black
        Me.tbMemberID.Location = New System.Drawing.Point(221, 13)
        Me.tbMemberID.MaxLength = 20
        Me.tbMemberID.Name = "tbMemberID"
        Me.tbMemberID.Size = New System.Drawing.Size(239, 21)
        Me.tbMemberID.TabIndex = 1
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(162, 165)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(52, 16)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Address:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(140, 15)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(77, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Employee ID:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbLName
        '
        Me.tbLName.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbLName.Border.Class = "TextBoxBorder"
        Me.tbLName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLName.ForeColor = System.Drawing.Color.Black
        Me.tbLName.Location = New System.Drawing.Point(221, 84)
        Me.tbLName.MaxLength = 20
        Me.tbLName.Name = "tbLName"
        Me.tbLName.Size = New System.Drawing.Size(239, 21)
        Me.tbLName.TabIndex = 6
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(148, 86)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 16)
        Me.LabelX4.TabIndex = 5
        Me.LabelX4.Text = "Last Name:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClear.Location = New System.Drawing.Point(189, 538)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Tooltip = "Clears all text areas."
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(75, 538)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.Tooltip = "Saves/Updates the information."
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(303, 538)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.Tooltip = "Cancel registration."
        '
        'frmMemberManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 618)
        Me.Controls.Add(Me.pnlCard)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Information"
        Me.pnlCard.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSave.ResumeLayout(False)
        Me.pnlSave.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiBirthdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiExpiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCard As DevComponents.DotNetBar.PanelEx
    Friend WithEvents tbAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbMemberID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvMember As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tbMName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbLName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbContactNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiExpiry As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents pnlSave As System.Windows.Forms.Panel
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents tbCardID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiBirthdate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiMembershipDate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnGetCardID As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboLoyaltyCode As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRemovePhoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSearchKey As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCompanyCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCredit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAMA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnOverrideCredits As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCardID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBirthdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLExpiry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAMABalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSDBalance As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
