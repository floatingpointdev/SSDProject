<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoyalty
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoyalty))
        Me.pnlLoyalty = New DevComponents.DotNetBar.PanelEx
        Me.pnlSave = New System.Windows.Forms.Panel
        Me.tabLoyaltyTypes = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.txtDesc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtLoyaltyCode = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.rbDecremental = New System.Windows.Forms.RadioButton
        Me.rbIncremental = New System.Windows.Forms.RadioButton
        Me.grpDecremental = New System.Windows.Forms.GroupBox
        Me.chkExpires = New System.Windows.Forms.CheckBox
        Me.numDecrementBy = New System.Windows.Forms.NumericUpDown
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.dtExpiration = New System.Windows.Forms.DateTimePicker
        Me.grpIncremental = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGiftTable = New DevComponents.DotNetBar.ButtonX
        Me.numCashAmount = New System.Windows.Forms.NumericUpDown
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.rbGift = New System.Windows.Forms.RadioButton
        Me.rbCash = New System.Windows.Forms.RadioButton
        Me.numPointThreshold = New System.Windows.Forms.NumericUpDown
        Me.numPointsEarned = New System.Windows.Forms.NumericUpDown
        Me.numAmount = New System.Windows.Forms.NumericUpDown
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.tbiPointSystem = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.tbiBracketing = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnClear = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.dg = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLoyaltyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLoyaltyMode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLoyaltyModeDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX
        Me.pnlLoyalty.SuspendLayout()
        Me.pnlSave.SuspendLayout()
        CType(Me.tabLoyaltyTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLoyaltyTypes.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.grpDecremental.SuspendLayout()
        CType(Me.numDecrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpIncremental.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numCashAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPointThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPointsEarned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdd.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoyalty
        '
        Me.pnlLoyalty.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLoyalty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLoyalty.Controls.Add(Me.pnlSave)
        Me.pnlLoyalty.Controls.Add(Me.pnlAdd)
        Me.pnlLoyalty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoyalty.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoyalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLoyalty.Name = "pnlLoyalty"
        Me.pnlLoyalty.Size = New System.Drawing.Size(855, 571)
        Me.pnlLoyalty.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLoyalty.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLoyalty.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLoyalty.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlLoyalty.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLoyalty.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLoyalty.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLoyalty.Style.GradientAngle = 90
        Me.pnlLoyalty.TabIndex = 1
        '
        'pnlSave
        '
        Me.pnlSave.Controls.Add(Me.tabLoyaltyTypes)
        Me.pnlSave.Controls.Add(Me.btnClear)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Location = New System.Drawing.Point(3, 3)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(840, 284)
        Me.pnlSave.TabIndex = 57
        '
        'tabLoyaltyTypes
        '
        Me.tabLoyaltyTypes.BackColor = System.Drawing.Color.Transparent
        Me.tabLoyaltyTypes.CanReorderTabs = True
        Me.tabLoyaltyTypes.ColorScheme.TabBackground = System.Drawing.Color.Transparent
        Me.tabLoyaltyTypes.ColorScheme.TabBackground2 = System.Drawing.Color.Transparent
        Me.tabLoyaltyTypes.ColorScheme.TabItemBackground2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.tabLoyaltyTypes.ColorScheme.TabItemBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(248, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(245, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(247, Byte), Integer)), 1.0!)})
        Me.tabLoyaltyTypes.ColorScheme.TabItemBackgroundGradientAngle = 0
        Me.tabLoyaltyTypes.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(168, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(89, Byte), Integer)), 0.45!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(141, Byte), Integer)), 1.0!)})
        Me.tabLoyaltyTypes.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.White
        Me.tabLoyaltyTypes.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.White
        Me.tabLoyaltyTypes.ColorScheme.TabPanelBackground = System.Drawing.Color.White
        Me.tabLoyaltyTypes.ColorScheme.TabPanelBackground2 = System.Drawing.Color.White
        Me.tabLoyaltyTypes.Controls.Add(Me.TabControlPanel2)
        Me.tabLoyaltyTypes.Controls.Add(Me.TabControlPanel1)
        Me.tabLoyaltyTypes.Location = New System.Drawing.Point(9, 9)
        Me.tabLoyaltyTypes.Name = "tabLoyaltyTypes"
        Me.tabLoyaltyTypes.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tabLoyaltyTypes.SelectedTabIndex = 0
        Me.tabLoyaltyTypes.Size = New System.Drawing.Size(709, 272)
        Me.tabLoyaltyTypes.TabIndex = 28
        Me.tabLoyaltyTypes.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabLoyaltyTypes.Tabs.Add(Me.tbiPointSystem)
        Me.tabLoyaltyTypes.Tabs.Add(Me.tbiBracketing)
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.txtDesc)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX6)
        Me.TabControlPanel1.Controls.Add(Me.txtLoyaltyCode)
        Me.TabControlPanel1.Controls.Add(Me.rbDecremental)
        Me.TabControlPanel1.Controls.Add(Me.rbIncremental)
        Me.TabControlPanel1.Controls.Add(Me.grpDecremental)
        Me.TabControlPanel1.Controls.Add(Me.grpIncremental)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(709, 246)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.tbiPointSystem
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtDesc.Border.Class = "TextBoxBorder"
        Me.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(99, 56)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.MaxLength = 20
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(156, 21)
        Me.txtDesc.TabIndex = 75
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(17, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(76, 19)
        Me.LabelX1.TabIndex = 69
        Me.LabelX1.Text = "Loyalty Code:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(17, 57)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(76, 19)
        Me.LabelX6.TabIndex = 74
        Me.LabelX6.Text = "Description:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLoyaltyCode
        '
        Me.txtLoyaltyCode.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtLoyaltyCode.Border.Class = "TextBoxBorder"
        Me.txtLoyaltyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLoyaltyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyCode.ForeColor = System.Drawing.Color.Black
        Me.txtLoyaltyCode.Location = New System.Drawing.Point(99, 20)
        Me.txtLoyaltyCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoyaltyCode.MaxLength = 20
        Me.txtLoyaltyCode.Name = "txtLoyaltyCode"
        Me.txtLoyaltyCode.Size = New System.Drawing.Size(156, 21)
        Me.txtLoyaltyCode.TabIndex = 68
        '
        'rbDecremental
        '
        Me.rbDecremental.AutoSize = True
        Me.rbDecremental.BackColor = System.Drawing.Color.Transparent
        Me.rbDecremental.Location = New System.Drawing.Point(99, 129)
        Me.rbDecremental.Name = "rbDecremental"
        Me.rbDecremental.Size = New System.Drawing.Size(96, 19)
        Me.rbDecremental.TabIndex = 71
        Me.rbDecremental.Text = "Decremental"
        Me.rbDecremental.UseVisualStyleBackColor = False
        '
        'rbIncremental
        '
        Me.rbIncremental.AutoSize = True
        Me.rbIncremental.BackColor = System.Drawing.Color.Transparent
        Me.rbIncremental.Checked = True
        Me.rbIncremental.Location = New System.Drawing.Point(99, 104)
        Me.rbIncremental.Name = "rbIncremental"
        Me.rbIncremental.Size = New System.Drawing.Size(90, 19)
        Me.rbIncremental.TabIndex = 70
        Me.rbIncremental.TabStop = True
        Me.rbIncremental.Text = "Incremental"
        Me.rbIncremental.UseVisualStyleBackColor = False
        '
        'grpDecremental
        '
        Me.grpDecremental.BackColor = System.Drawing.Color.Transparent
        Me.grpDecremental.Controls.Add(Me.chkExpires)
        Me.grpDecremental.Controls.Add(Me.numDecrementBy)
        Me.grpDecremental.Controls.Add(Me.LabelX7)
        Me.grpDecremental.Controls.Add(Me.GroupBox2)
        Me.grpDecremental.Location = New System.Drawing.Point(280, 0)
        Me.grpDecremental.Name = "grpDecremental"
        Me.grpDecremental.Size = New System.Drawing.Size(425, 240)
        Me.grpDecremental.TabIndex = 73
        Me.grpDecremental.TabStop = False
        '
        'chkExpires
        '
        Me.chkExpires.AutoSize = True
        Me.chkExpires.Location = New System.Drawing.Point(17, 80)
        Me.chkExpires.Name = "chkExpires"
        Me.chkExpires.Size = New System.Drawing.Size(67, 19)
        Me.chkExpires.TabIndex = 49
        Me.chkExpires.Text = "Expires"
        Me.chkExpires.UseVisualStyleBackColor = True
        '
        'numDecrementBy
        '
        Me.numDecrementBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numDecrementBy.Location = New System.Drawing.Point(111, 27)
        Me.numDecrementBy.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numDecrementBy.Name = "numDecrementBy"
        Me.numDecrementBy.Size = New System.Drawing.Size(156, 21)
        Me.numDecrementBy.TabIndex = 48
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
        Me.LabelX7.Location = New System.Drawing.Point(17, 27)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(80, 16)
        Me.LabelX7.TabIndex = 43
        Me.LabelX7.Text = "Decrement by:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.dtExpiration)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 144)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
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
        Me.LabelX8.Location = New System.Drawing.Point(14, 25)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(88, 16)
        Me.LabelX8.TabIndex = 45
        Me.LabelX8.Text = "Expiration Date:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtExpiration
        '
        Me.dtExpiration.Enabled = False
        Me.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtExpiration.Location = New System.Drawing.Point(108, 25)
        Me.dtExpiration.Name = "dtExpiration"
        Me.dtExpiration.Size = New System.Drawing.Size(156, 21)
        Me.dtExpiration.TabIndex = 47
        '
        'grpIncremental
        '
        Me.grpIncremental.BackColor = System.Drawing.Color.Transparent
        Me.grpIncremental.Controls.Add(Me.GroupBox1)
        Me.grpIncremental.Controls.Add(Me.numPointThreshold)
        Me.grpIncremental.Controls.Add(Me.numPointsEarned)
        Me.grpIncremental.Controls.Add(Me.numAmount)
        Me.grpIncremental.Controls.Add(Me.LabelX3)
        Me.grpIncremental.Controls.Add(Me.LabelX4)
        Me.grpIncremental.Controls.Add(Me.LabelX2)
        Me.grpIncremental.Location = New System.Drawing.Point(280, 0)
        Me.grpIncremental.Name = "grpIncremental"
        Me.grpIncremental.Size = New System.Drawing.Size(425, 240)
        Me.grpIncremental.TabIndex = 72
        Me.grpIncremental.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGiftTable)
        Me.GroupBox1.Controls.Add(Me.numCashAmount)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.rbGift)
        Me.GroupBox1.Controls.Add(Me.rbCash)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 128)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reward Type:"
        '
        'btnGiftTable
        '
        Me.btnGiftTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGiftTable.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGiftTable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGiftTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftTable.ForeColor = System.Drawing.Color.Black
        Me.btnGiftTable.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnGiftTable.Location = New System.Drawing.Point(39, 70)
        Me.btnGiftTable.Name = "btnGiftTable"
        Me.btnGiftTable.Size = New System.Drawing.Size(100, 36)
        Me.btnGiftTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGiftTable.TabIndex = 62
        Me.btnGiftTable.Text = "Gift Table..."
        Me.btnGiftTable.Tooltip = "Shows the Gift Table"
        '
        'numCashAmount
        '
        Me.numCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numCashAmount.DecimalPlaces = 2
        Me.numCashAmount.Location = New System.Drawing.Point(154, 19)
        Me.numCashAmount.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numCashAmount.Name = "numCashAmount"
        Me.numCashAmount.Size = New System.Drawing.Size(156, 21)
        Me.numCashAmount.TabIndex = 61
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(95, 21)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(53, 16)
        Me.LabelX5.TabIndex = 60
        Me.LabelX5.Text = "Amount:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'rbGift
        '
        Me.rbGift.AutoSize = True
        Me.rbGift.Location = New System.Drawing.Point(20, 45)
        Me.rbGift.Name = "rbGift"
        Me.rbGift.Size = New System.Drawing.Size(43, 19)
        Me.rbGift.TabIndex = 58
        Me.rbGift.Text = "Gift"
        Me.rbGift.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Location = New System.Drawing.Point(20, 20)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(53, 19)
        Me.rbCash.TabIndex = 57
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'numPointThreshold
        '
        Me.numPointThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPointThreshold.Location = New System.Drawing.Point(125, 79)
        Me.numPointThreshold.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPointThreshold.Name = "numPointThreshold"
        Me.numPointThreshold.Size = New System.Drawing.Size(156, 21)
        Me.numPointThreshold.TabIndex = 56
        '
        'numPointsEarned
        '
        Me.numPointsEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPointsEarned.Location = New System.Drawing.Point(124, 50)
        Me.numPointsEarned.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPointsEarned.Name = "numPointsEarned"
        Me.numPointsEarned.Size = New System.Drawing.Size(156, 21)
        Me.numPointsEarned.TabIndex = 55
        '
        'numAmount
        '
        Me.numAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numAmount.DecimalPlaces = 2
        Me.numAmount.Location = New System.Drawing.Point(124, 17)
        Me.numAmount.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(156, 21)
        Me.numAmount.TabIndex = 54
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(37, 52)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(81, 16)
        Me.LabelX3.TabIndex = 46
        Me.LabelX3.Text = "Points Earned:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(29, 82)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 16)
        Me.LabelX4.TabIndex = 49
        Me.LabelX4.Text = "Point Threshold:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(9, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(110, 16)
        Me.LabelX2.TabIndex = 44
        Me.LabelX2.Text = "Amount (For Every):"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbiPointSystem
        '
        Me.tbiPointSystem.AttachedControl = Me.TabControlPanel1
        Me.tbiPointSystem.Name = "tbiPointSystem"
        Me.tbiPointSystem.Text = "Point System"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(709, 246)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tbiBracketing
        '
        'tbiBracketing
        '
        Me.tbiBracketing.AttachedControl = Me.TabControlPanel2
        Me.tbiBracketing.Name = "tbiBracketing"
        Me.tbiBracketing.Text = "Bracketing"
        Me.tbiBracketing.Visible = False
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClear.Location = New System.Drawing.Point(724, 54)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "&Clear"
        Me.btnClear.Tooltip = "Clears all text areas."
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSave.Location = New System.Drawing.Point(724, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.Tooltip = "Saves/Updates the information."
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(724, 96)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Tooltip = "Cancel edit."
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.dg)
        Me.pnlAdd.Controls.Add(Me.btnEdit)
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Controls.Add(Me.btnRemove)
        Me.pnlAdd.Location = New System.Drawing.Point(3, 293)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(840, 275)
        Me.pnlAdd.TabIndex = 55
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colLoyaltyCode, Me.colDesc, Me.colLoyaltyMode, Me.colLoyaltyModeDesc})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(10, 13)
        Me.dg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.Size = New System.Drawing.Size(708, 251)
        Me.dg.TabIndex = 9
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 5
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
        'colDesc
        '
        Me.colDesc.DataPropertyName = "LoyaltyDesc"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 300
        '
        'colLoyaltyMode
        '
        Me.colLoyaltyMode.DataPropertyName = "LoyaltyMode"
        Me.colLoyaltyMode.HeaderText = "Mode"
        Me.colLoyaltyMode.Name = "colLoyaltyMode"
        Me.colLoyaltyMode.ReadOnly = True
        Me.colLoyaltyMode.Visible = False
        '
        'colLoyaltyModeDesc
        '
        Me.colLoyaltyModeDesc.DataPropertyName = "LoyaltyModeDesc"
        Me.colLoyaltyModeDesc.HeaderText = "LoyaltyMode"
        Me.colLoyaltyModeDesc.Name = "colLoyaltyModeDesc"
        Me.colLoyaltyModeDesc.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(724, 55)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 36)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.Tooltip = "Edits the selected data."
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAdd.Location = New System.Drawing.Point(724, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 36)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "A&dd"
        Me.btnAdd.Tooltip = "Adds new informtation"
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemove.Location = New System.Drawing.Point(724, 97)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 36)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "Re&move"
        Me.btnRemove.Tooltip = "Removes the selected data from the database."
        '
        'frmLoyalty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 571)
        Me.Controls.Add(Me.pnlLoyalty)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoyalty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loyalty Manager"
        Me.pnlLoyalty.ResumeLayout(False)
        Me.pnlSave.ResumeLayout(False)
        CType(Me.tabLoyaltyTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLoyaltyTypes.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.grpDecremental.ResumeLayout(False)
        Me.grpDecremental.PerformLayout()
        CType(Me.numDecrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpIncremental.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numCashAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPointThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPointsEarned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdd.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLoyalty As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dg As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents pnlSave As System.Windows.Forms.Panel
    Friend WithEvents tabLoyaltyTypes As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiPointSystem As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiBracketing As DevComponents.DotNetBar.TabItem
    Friend WithEvents txtDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLoyaltyCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbDecremental As System.Windows.Forms.RadioButton
    Friend WithEvents rbIncremental As System.Windows.Forms.RadioButton
    Friend WithEvents grpIncremental As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGiftTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents numCashAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbGift As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents numPointThreshold As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPointsEarned As System.Windows.Forms.NumericUpDown
    Friend WithEvents numAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents grpDecremental As System.Windows.Forms.GroupBox
    Friend WithEvents chkExpires As System.Windows.Forms.CheckBox
    Friend WithEvents numDecrementBy As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtExpiration As System.Windows.Forms.DateTimePicker
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLoyaltyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLoyaltyMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLoyaltyModeDesc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
