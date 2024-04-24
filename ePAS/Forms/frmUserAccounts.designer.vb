<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccounts))
        Me.pnlUsers = New DevComponents.DotNetBar.PanelEx
        Me.btnCard = New DevComponents.DotNetBar.ButtonX
        Me.tbCardID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cmbGroups = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelGroups = New DevComponents.DotNetBar.LabelX
        Me.tbConfirmAcct = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelConfirm = New DevComponents.DotNetBar.LabelX
        Me.tbPasswordAcct = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelPassword = New DevComponents.DotNetBar.LabelX
        Me.btnCancelUser = New DevComponents.DotNetBar.ButtonX
        Me.btnSaveAcct = New DevComponents.DotNetBar.ButtonX
        Me.tbUserNameAcct = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.pnlUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUsers
        '
        Me.pnlUsers.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlUsers.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlUsers.Controls.Add(Me.btnCard)
        Me.pnlUsers.Controls.Add(Me.tbCardID)
        Me.pnlUsers.Controls.Add(Me.LabelX2)
        Me.pnlUsers.Controls.Add(Me.cmbGroups)
        Me.pnlUsers.Controls.Add(Me.LabelGroups)
        Me.pnlUsers.Controls.Add(Me.tbConfirmAcct)
        Me.pnlUsers.Controls.Add(Me.LabelConfirm)
        Me.pnlUsers.Controls.Add(Me.tbPasswordAcct)
        Me.pnlUsers.Controls.Add(Me.LabelPassword)
        Me.pnlUsers.Controls.Add(Me.btnCancelUser)
        Me.pnlUsers.Controls.Add(Me.btnSaveAcct)
        Me.pnlUsers.Controls.Add(Me.tbUserNameAcct)
        Me.pnlUsers.Controls.Add(Me.LabelX1)
        Me.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(368, 216)
        Me.pnlUsers.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlUsers.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlUsers.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlUsers.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlUsers.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlUsers.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlUsers.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlUsers.Style.GradientAngle = 90
        Me.pnlUsers.TabIndex = 0
        '
        'btnCard
        '
        Me.btnCard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.ForeColor = System.Drawing.Color.Black
        Me.btnCard.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCard.Location = New System.Drawing.Point(26, 163)
        Me.btnCard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCard.Size = New System.Drawing.Size(100, 36)
        Me.btnCard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCard.TabIndex = 10
        Me.btnCard.Text = "Get CardID"
        Me.btnCard.Visible = False
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
        Me.tbCardID.Location = New System.Drawing.Point(122, 128)
        Me.tbCardID.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCardID.Name = "tbCardID"
        Me.tbCardID.ReadOnly = True
        Me.tbCardID.Size = New System.Drawing.Size(229, 21)
        Me.tbCardID.TabIndex = 9
        Me.tbCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCardID.Visible = False
        Me.tbCardID.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCardID.WatermarkText = "Tap Card"
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
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(74, 128)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(44, 16)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "CardID:"
        Me.LabelX2.TextLineAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX2.Visible = False
        '
        'cmbGroups
        '
        Me.cmbGroups.DisplayMember = "Text"
        Me.cmbGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroups.ForeColor = System.Drawing.Color.Black
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.ItemHeight = 15
        Me.cmbGroups.Location = New System.Drawing.Point(122, 101)
        Me.cmbGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(229, 21)
        Me.cmbGroups.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbGroups.TabIndex = 7
        Me.cmbGroups.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroups.WatermarkText = "Choose Group"
        '
        'LabelGroups
        '
        Me.LabelGroups.AutoSize = True
        '
        '
        '
        Me.LabelGroups.BackgroundStyle.Class = ""
        Me.LabelGroups.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGroups.ForeColor = System.Drawing.Color.White
        Me.LabelGroups.Location = New System.Drawing.Point(79, 101)
        Me.LabelGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelGroups.Name = "LabelGroups"
        Me.LabelGroups.Size = New System.Drawing.Size(39, 16)
        Me.LabelGroups.TabIndex = 6
        Me.LabelGroups.Text = "Group:"
        Me.LabelGroups.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'tbConfirmAcct
        '
        Me.tbConfirmAcct.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbConfirmAcct.Border.Class = "TextBoxBorder"
        Me.tbConfirmAcct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbConfirmAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmAcct.ForeColor = System.Drawing.Color.Black
        Me.tbConfirmAcct.Location = New System.Drawing.Point(122, 74)
        Me.tbConfirmAcct.Margin = New System.Windows.Forms.Padding(2)
        Me.tbConfirmAcct.Name = "tbConfirmAcct"
        Me.tbConfirmAcct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmAcct.Size = New System.Drawing.Size(229, 21)
        Me.tbConfirmAcct.TabIndex = 5
        Me.tbConfirmAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbConfirmAcct.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmAcct.WatermarkText = "Confirm Desired Password"
        '
        'LabelConfirm
        '
        Me.LabelConfirm.AutoSize = True
        '
        '
        '
        Me.LabelConfirm.BackgroundStyle.Class = ""
        Me.LabelConfirm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConfirm.ForeColor = System.Drawing.Color.White
        Me.LabelConfirm.Location = New System.Drawing.Point(14, 74)
        Me.LabelConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelConfirm.Name = "LabelConfirm"
        Me.LabelConfirm.Size = New System.Drawing.Size(104, 16)
        Me.LabelConfirm.TabIndex = 4
        Me.LabelConfirm.Text = "Confirm Password:"
        Me.LabelConfirm.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'tbPasswordAcct
        '
        Me.tbPasswordAcct.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbPasswordAcct.Border.Class = "TextBoxBorder"
        Me.tbPasswordAcct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPasswordAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPasswordAcct.ForeColor = System.Drawing.Color.Black
        Me.tbPasswordAcct.Location = New System.Drawing.Point(122, 47)
        Me.tbPasswordAcct.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPasswordAcct.Name = "tbPasswordAcct"
        Me.tbPasswordAcct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPasswordAcct.Size = New System.Drawing.Size(229, 21)
        Me.tbPasswordAcct.TabIndex = 3
        Me.tbPasswordAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbPasswordAcct.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPasswordAcct.WatermarkText = "Enter Desired Password"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        '
        '
        '
        Me.LabelPassword.BackgroundStyle.Class = ""
        Me.LabelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.White
        Me.LabelPassword.Location = New System.Drawing.Point(59, 47)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(59, 16)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password:"
        Me.LabelPassword.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'btnCancelUser
        '
        Me.btnCancelUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUser.ForeColor = System.Drawing.Color.Black
        Me.btnCancelUser.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancelUser.Location = New System.Drawing.Point(242, 163)
        Me.btnCancelUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelUser.Name = "btnCancelUser"
        Me.btnCancelUser.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancelUser.Size = New System.Drawing.Size(100, 36)
        Me.btnCancelUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelUser.TabIndex = 12
        Me.btnCancelUser.Text = "Ca&ncel"
        Me.btnCancelUser.Tooltip = "Cancel and close this form."
        '
        'btnSaveAcct
        '
        Me.btnSaveAcct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveAcct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAcct.ForeColor = System.Drawing.Color.Black
        Me.btnSaveAcct.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSaveAcct.Location = New System.Drawing.Point(134, 163)
        Me.btnSaveAcct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveAcct.Name = "btnSaveAcct"
        Me.btnSaveAcct.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSaveAcct.Size = New System.Drawing.Size(100, 36)
        Me.btnSaveAcct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSaveAcct.TabIndex = 11
        Me.btnSaveAcct.Text = "Sa&ve"
        Me.btnSaveAcct.Tooltip = "Save changes to database."
        '
        'tbUserNameAcct
        '
        Me.tbUserNameAcct.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbUserNameAcct.Border.Class = "TextBoxBorder"
        Me.tbUserNameAcct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbUserNameAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserNameAcct.ForeColor = System.Drawing.Color.Black
        Me.tbUserNameAcct.Location = New System.Drawing.Point(122, 20)
        Me.tbUserNameAcct.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUserNameAcct.Name = "tbUserNameAcct"
        Me.tbUserNameAcct.Size = New System.Drawing.Size(229, 21)
        Me.tbUserNameAcct.TabIndex = 1
        Me.tbUserNameAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbUserNameAcct.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserNameAcct.WatermarkText = "Enter Desired User Name"
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
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(52, 21)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(66, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "User Name:"
        Me.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'frmUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 216)
        Me.Controls.Add(Me.pnlUsers)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccounts"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Accounts"
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlUsers As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancelUser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSaveAcct As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbUserNameAcct As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbPasswordAcct As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelPassword As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbConfirmAcct As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelConfirm As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbGroups As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelGroups As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCardID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCard As DevComponents.DotNetBar.ButtonX
End Class
