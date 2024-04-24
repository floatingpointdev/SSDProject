<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerminalConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTerminalConfig))
        Me.pnlTerminalConfig = New DevComponents.DotNetBar.PanelEx
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTerminalID = New System.Windows.Forms.TextBox
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSiteName = New System.Windows.Forms.TextBox
        Me.pnlTerminalConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTerminalConfig
        '
        Me.pnlTerminalConfig.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlTerminalConfig.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlTerminalConfig.Controls.Add(Me.btnCancel)
        Me.pnlTerminalConfig.Controls.Add(Me.Label2)
        Me.pnlTerminalConfig.Controls.Add(Me.txtTerminalID)
        Me.pnlTerminalConfig.Controls.Add(Me.btnOK)
        Me.pnlTerminalConfig.Controls.Add(Me.Label1)
        Me.pnlTerminalConfig.Controls.Add(Me.txtSiteName)
        Me.pnlTerminalConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.pnlTerminalConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTerminalConfig.Location = New System.Drawing.Point(0, 0)
        Me.pnlTerminalConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTerminalConfig.Name = "pnlTerminalConfig"
        Me.pnlTerminalConfig.Size = New System.Drawing.Size(353, 137)
        Me.pnlTerminalConfig.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlTerminalConfig.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlTerminalConfig.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlTerminalConfig.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlTerminalConfig.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlTerminalConfig.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlTerminalConfig.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlTerminalConfig.Style.GradientAngle = 90
        Me.pnlTerminalConfig.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(240, 90)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Terminal ID:"
        '
        'txtTerminalID
        '
        Me.txtTerminalID.Location = New System.Drawing.Point(95, 45)
        Me.txtTerminalID.Name = "txtTerminalID"
        Me.txtTerminalID.Size = New System.Drawing.Size(245, 20)
        Me.txtTerminalID.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnOK.Location = New System.Drawing.Point(131, 90)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOK.Size = New System.Drawing.Size(100, 36)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Site Name:"
        '
        'txtSiteName
        '
        Me.txtSiteName.Location = New System.Drawing.Point(95, 18)
        Me.txtSiteName.Name = "txtSiteName"
        Me.txtSiteName.Size = New System.Drawing.Size(246, 20)
        Me.txtSiteName.TabIndex = 1
        '
        'frmTerminalConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(353, 137)
        Me.Controls.Add(Me.pnlTerminalConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTerminalConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terminal Configuration"
        Me.pnlTerminalConfig.ResumeLayout(False)
        Me.pnlTerminalConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTerminalConfig As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSiteName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTerminalID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
