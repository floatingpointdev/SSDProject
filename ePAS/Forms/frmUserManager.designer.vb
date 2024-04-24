<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManager))
        Me.dgvUsers = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.colUserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCardID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabelUser = New DevComponents.DotNetBar.LabelX
        Me.pnlSecurity = New DevComponents.DotNetBar.PanelEx
        Me.btnRemoveUser = New DevComponents.DotNetBar.ButtonX
        Me.btnChangePass = New DevComponents.DotNetBar.ButtonX
        Me.btnAddUser = New DevComponents.DotNetBar.ButtonX
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSecurity.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUserName, Me.colGroup, Me.colCardID})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvUsers.Location = New System.Drawing.Point(12, 35)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(426, 234)
        Me.dgvUsers.TabIndex = 0
        '
        'colUserName
        '
        Me.colUserName.DataPropertyName = "UserName"
        Me.colUserName.HeaderText = "User Name"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.ReadOnly = True
        Me.colUserName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colUserName.Width = 170
        '
        'colGroup
        '
        Me.colGroup.DataPropertyName = "GroupCode"
        Me.colGroup.HeaderText = "Member Of"
        Me.colGroup.Name = "colGroup"
        Me.colGroup.ReadOnly = True
        Me.colGroup.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colGroup.Width = 140
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
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        '
        '
        '
        Me.LabelUser.BackgroundStyle.Class = ""
        Me.LabelUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.Color.White
        Me.LabelUser.Location = New System.Drawing.Point(12, 13)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(45, 16)
        Me.LabelUser.TabIndex = 2
        Me.LabelUser.Text = "Users: "
        '
        'pnlSecurity
        '
        Me.pnlSecurity.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlSecurity.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlSecurity.Controls.Add(Me.LabelUser)
        Me.pnlSecurity.Controls.Add(Me.dgvUsers)
        Me.pnlSecurity.Controls.Add(Me.btnRemoveUser)
        Me.pnlSecurity.Controls.Add(Me.btnChangePass)
        Me.pnlSecurity.Controls.Add(Me.btnAddUser)
        Me.pnlSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSecurity.Location = New System.Drawing.Point(0, 0)
        Me.pnlSecurity.Name = "pnlSecurity"
        Me.pnlSecurity.Size = New System.Drawing.Size(450, 339)
        Me.pnlSecurity.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlSecurity.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlSecurity.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlSecurity.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlSecurity.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlSecurity.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlSecurity.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlSecurity.Style.GradientAngle = 90
        Me.pnlSecurity.TabIndex = 9
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveUser.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveUser.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRemoveUser.Location = New System.Drawing.Point(287, 284)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnRemoveUser.Size = New System.Drawing.Size(100, 36)
        Me.btnRemoveUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveUser.TabIndex = 3
        Me.btnRemoveUser.Text = "Re&move"
        Me.btnRemoveUser.Tooltip = "Removes the selected user."
        '
        'btnChangePass
        '
        Me.btnChangePass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChangePass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChangePass.ForeColor = System.Drawing.Color.Black
        Me.btnChangePass.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnChangePass.Location = New System.Drawing.Point(175, 284)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnChangePass.Size = New System.Drawing.Size(100, 36)
        Me.btnChangePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChangePass.TabIndex = 2
        Me.btnChangePass.Text = "E&dit"
        Me.btnChangePass.Tooltip = "Edit the selected user."
        '
        'btnAddUser
        '
        Me.btnAddUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAddUser.ForeColor = System.Drawing.Color.Black
        Me.btnAddUser.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAddUser.Location = New System.Drawing.Point(63, 284)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAddUser.Size = New System.Drawing.Size(100, 36)
        Me.btnAddUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "&Add"
        Me.btnAddUser.Tooltip = "Adds a user."
        '
        'frmUserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 339)
        Me.Controls.Add(Me.pnlSecurity)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Manager"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSecurity.ResumeLayout(False)
        Me.pnlSecurity.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUsers As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents LabelUser As DevComponents.DotNetBar.LabelX
    Private WithEvents btnAddUser As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnChangePass As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemoveUser As DevComponents.DotNetBar.ButtonX
    Private WithEvents pnlSecurity As DevComponents.DotNetBar.PanelEx
    Friend WithEvents colUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCardID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
