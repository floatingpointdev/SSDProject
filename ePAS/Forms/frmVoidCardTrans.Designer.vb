<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidCardTrans
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnVoid = New DevComponents.DotNetBar.ButtonX
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.cboMemberID = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btnViewVoid = New DevComponents.DotNetBar.ButtonX
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX
        Me.dgTransLogs = New System.Windows.Forms.DataGridView
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPOSRecNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTerminalID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSiteName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVoid
        '
        Me.btnVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Black
        Me.btnVoid.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnVoid.Location = New System.Drawing.Point(788, 53)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(100, 36)
        Me.btnVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVoid.TabIndex = 8
        Me.btnVoid.Text = "Void"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClose.Location = New System.Drawing.Point(788, 485)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 36)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        '
        'cboMemberID
        '
        Me.cboMemberID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMemberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemberID.FormattingEnabled = True
        Me.cboMemberID.Location = New System.Drawing.Point(109, 19)
        Me.cboMemberID.Name = "cboMemberID"
        Me.cboMemberID.Size = New System.Drawing.Size(232, 24)
        Me.cboMemberID.Sorted = True
        Me.cboMemberID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID:"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnViewVoid)
        Me.PanelEx1.Controls.Add(Me.txtName)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.btnSearch)
        Me.PanelEx1.Controls.Add(Me.btnRefresh)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.cboMemberID)
        Me.PanelEx1.Controls.Add(Me.dgTransLogs)
        Me.PanelEx1.Controls.Add(Me.btnVoid)
        Me.PanelEx1.Controls.Add(Me.btnClose)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(897, 533)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 25
        '
        'btnViewVoid
        '
        Me.btnViewVoid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewVoid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewVoid.ForeColor = System.Drawing.Color.Black
        Me.btnViewVoid.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnViewVoid.Location = New System.Drawing.Point(788, 131)
        Me.btnViewVoid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewVoid.Name = "btnViewVoid"
        Me.btnViewVoid.Size = New System.Drawing.Size(100, 36)
        Me.btnViewVoid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewVoid.TabIndex = 9
        Me.btnViewVoid.Text = "Voided Trans"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(109, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(337, 22)
        Me.txtName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSearch.Location = New System.Drawing.Point(346, 10)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRefresh.Location = New System.Drawing.Point(788, 10)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 36)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        '
        'dgTransLogs
        '
        Me.dgTransLogs.AllowUserToAddRows = False
        Me.dgTransLogs.AllowUserToDeleteRows = False
        Me.dgTransLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colID, Me.colTransDate, Me.colTransCode, Me.colPOSRecNo, Me.colMemberID, Me.colFullName, Me.colTransType, Me.colAmount, Me.colTerminalID, Me.colSiteName, Me.colUser})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTransLogs.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgTransLogs.Location = New System.Drawing.Point(14, 81)
        Me.dgTransLogs.Name = "dgTransLogs"
        Me.dgTransLogs.RowHeadersVisible = False
        Me.dgTransLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransLogs.Size = New System.Drawing.Size(766, 440)
        Me.dgTransLogs.TabIndex = 6
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
        Me.colID.HeaderText = "TID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 50
        '
        'colTransDate
        '
        Me.colTransDate.DataPropertyName = "TransDate"
        DataGridViewCellStyle7.Format = "G"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colTransDate.DefaultCellStyle = DataGridViewCellStyle7
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 120
        '
        'colTransCode
        '
        Me.colTransCode.DataPropertyName = "TransCode"
        Me.colTransCode.HeaderText = "TransCode"
        Me.colTransCode.Name = "colTransCode"
        Me.colTransCode.ReadOnly = True
        '
        'colPOSRecNo
        '
        Me.colPOSRecNo.DataPropertyName = "POSRefNo"
        Me.colPOSRecNo.HeaderText = "POSRecNo"
        Me.colPOSRecNo.Name = "colPOSRecNo"
        Me.colPOSRecNo.ReadOnly = True
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "CIMNumber"
        Me.colMemberID.HeaderText = "Member ID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Visible = False
        Me.colMemberID.Width = 120
        '
        'colFullName
        '
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "Name"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Visible = False
        Me.colFullName.Width = 200
        '
        'colTransType
        '
        Me.colTransType.DataPropertyName = "TransType"
        Me.colTransType.HeaderText = "TransType"
        Me.colTransType.Name = "colTransType"
        Me.colTransType.ReadOnly = True
        '
        'colAmount
        '
        Me.colAmount.DataPropertyName = "Amount"
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'colTerminalID
        '
        Me.colTerminalID.DataPropertyName = "Terminal"
        Me.colTerminalID.HeaderText = "TerminalID"
        Me.colTerminalID.Name = "colTerminalID"
        Me.colTerminalID.ReadOnly = True
        '
        'colSiteName
        '
        Me.colSiteName.DataPropertyName = "Site"
        Me.colSiteName.HeaderText = "StoreCode"
        Me.colSiteName.Name = "colSiteName"
        Me.colSiteName.ReadOnly = True
        '
        'colUser
        '
        Me.colUser.DataPropertyName = "User"
        Me.colUser.HeaderText = "Cashier"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'frmVoidCardTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(897, 533)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVoidCardTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void Transaction"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgTransLogs As System.Windows.Forms.DataGridView
    Friend WithEvents btnViewVoid As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPOSRecNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTerminalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSiteName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
