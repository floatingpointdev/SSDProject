<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidedTransViewer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX
        Me.dgTransLogs = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoidDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoidedBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSiteName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTerminalID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnRefresh)
        Me.PanelEx1.Controls.Add(Me.dgTransLogs)
        Me.PanelEx1.Controls.Add(Me.btnClose)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(979, 465)
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
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRefresh.Location = New System.Drawing.Point(868, 10)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 36)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        '
        'dgTransLogs
        '
        Me.dgTransLogs.AllowUserToAddRows = False
        Me.dgTransLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTransLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colVoidDate, Me.colVoidedBy, Me.colTransDate, Me.colMemberID, Me.colFullName, Me.colTransType, Me.colAmount, Me.colSiteName, Me.colTerminalID, Me.colUser})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTransLogs.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgTransLogs.Location = New System.Drawing.Point(14, 13)
        Me.dgTransLogs.Name = "dgTransLogs"
        Me.dgTransLogs.RowHeadersVisible = False
        Me.dgTransLogs.Size = New System.Drawing.Size(849, 440)
        Me.dgTransLogs.TabIndex = 0
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
        'colVoidDate
        '
        Me.colVoidDate.DataPropertyName = "DateVoided"
        Me.colVoidDate.HeaderText = "Date Voided"
        Me.colVoidDate.Name = "colVoidDate"
        Me.colVoidDate.ReadOnly = True
        '
        'colVoidedBy
        '
        Me.colVoidedBy.DataPropertyName = "Supervisor"
        Me.colVoidedBy.HeaderText = "VoidedBy"
        Me.colVoidedBy.Name = "colVoidedBy"
        Me.colVoidedBy.ReadOnly = True
        '
        'colTransDate
        '
        Me.colTransDate.DataPropertyName = "TransDate"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colTransDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 120
        '
        'colMemberID
        '
        Me.colMemberID.DataPropertyName = "MemberID"
        Me.colMemberID.HeaderText = "EmployeeID"
        Me.colMemberID.Name = "colMemberID"
        Me.colMemberID.ReadOnly = True
        Me.colMemberID.Width = 120
        '
        'colFullName
        '
        Me.colFullName.DataPropertyName = "FullName"
        Me.colFullName.HeaderText = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
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
        'colSiteName
        '
        Me.colSiteName.DataPropertyName = "SiteName"
        Me.colSiteName.HeaderText = "StoreCode"
        Me.colSiteName.Name = "colSiteName"
        Me.colSiteName.ReadOnly = True
        '
        'colTerminalID
        '
        Me.colTerminalID.DataPropertyName = "TerminalID"
        Me.colTerminalID.HeaderText = "TerminalID"
        Me.colTerminalID.Name = "colTerminalID"
        Me.colTerminalID.ReadOnly = True
        '
        'colUser
        '
        Me.colUser.DataPropertyName = "Cashier"
        Me.colUser.HeaderText = "Cashier"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClose.Location = New System.Drawing.Point(868, 56)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 36)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        '
        'frmVoidedTransViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(979, 465)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoidedTransViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voided Transactions"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.dgTransLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgTransLogs As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoidDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoidedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSiteName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTerminalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
