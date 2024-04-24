<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuperLogin))
        Me.pnlLogin = New DevComponents.DotNetBar.PanelEx
        Me.btnCancelLogin = New DevComponents.DotNetBar.ButtonX
        Me.btnLogIn = New DevComponents.DotNetBar.ButtonX
        Me.tbPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.tbUserName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelPass = New DevComponents.DotNetBar.LabelX
        Me.LabelUser = New DevComponents.DotNetBar.LabelX
        Me.tLogin = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLogin.Controls.Add(Me.btnCancelLogin)
        Me.pnlLogin.Controls.Add(Me.btnLogIn)
        Me.pnlLogin.Controls.Add(Me.tbPassword)
        Me.pnlLogin.Controls.Add(Me.tbUserName)
        Me.pnlLogin.Controls.Add(Me.LabelPass)
        Me.pnlLogin.Controls.Add(Me.LabelUser)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(325, 150)
        Me.pnlLogin.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLogin.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlLogin.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLogin.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.LOGIN_330X170PX___BG_PATTERN_WITH_LOGO
        Me.pnlLogin.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLogin.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLogin.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLogin.Style.GradientAngle = 90
        Me.pnlLogin.TabIndex = 0
        '
        'btnCancelLogin
        '
        Me.btnCancelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelLogin.ForeColor = System.Drawing.Color.Black
        Me.btnCancelLogin.Location = New System.Drawing.Point(165, 102)
        Me.btnCancelLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelLogin.Name = "btnCancelLogin"
        Me.btnCancelLogin.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancelLogin.Size = New System.Drawing.Size(100, 36)
        Me.btnCancelLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelLogin.TabIndex = 5
        Me.btnCancelLogin.Text = "Cancel"
        Me.btnCancelLogin.Tooltip = "Cancel login and exit."
        '
        'btnLogIn
        '
        Me.btnLogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Black
        Me.btnLogIn.Location = New System.Drawing.Point(59, 102)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnLogIn.Size = New System.Drawing.Size(100, 36)
        Me.btnLogIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.Tooltip = "Click to Log in."
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbPassword.Border.Class = "TextBoxBorder"
        Me.tbPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.Black
        Me.tbPassword.Location = New System.Drawing.Point(115, 64)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(178, 21)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbPassword.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.WatermarkText = "Input Password here"
        '
        'tbUserName
        '
        Me.tbUserName.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.tbUserName.Border.Class = "TextBoxBorder"
        Me.tbUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserName.ForeColor = System.Drawing.Color.Black
        Me.tbUserName.Location = New System.Drawing.Point(115, 37)
        Me.tbUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(178, 21)
        Me.tbUserName.TabIndex = 1
        Me.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbUserName.WatermarkFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserName.WatermarkText = "Input User Name here"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        '
        '
        '
        Me.LabelPass.BackgroundStyle.Class = ""
        Me.LabelPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.ForeColor = System.Drawing.Color.White
        Me.LabelPass.Location = New System.Drawing.Point(33, 66)
        Me.LabelPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(76, 16)
        Me.LabelPass.TabIndex = 2
        Me.LabelPass.Text = "&Password: "
        Me.LabelPass.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.LabelUser.Location = New System.Drawing.Point(25, 39)
        Me.LabelUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(84, 16)
        Me.LabelUser.TabIndex = 0
        Me.LabelUser.Text = "&User Name: "
        Me.LabelUser.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmSuperLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelLogin
        Me.ClientSize = New System.Drawing.Size(325, 150)
        Me.Controls.Add(Me.pnlLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuperLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supervisor Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLogin As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelUser As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelPass As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancelLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLogIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tLogin As System.Windows.Forms.Timer
End Class
