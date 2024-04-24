<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValueCard
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
        Me.pnlValue = New DevComponents.DotNetBar.PanelEx
        Me.btnValueCard = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.pnlValue.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlValue
        '
        Me.pnlValue.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlValue.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlValue.Controls.Add(Me.LabelX1)
        Me.pnlValue.Controls.Add(Me.btnValueCard)
        Me.pnlValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlValue.Location = New System.Drawing.Point(0, 0)
        Me.pnlValue.Name = "pnlValue"
        Me.pnlValue.Size = New System.Drawing.Size(395, 149)
        Me.pnlValue.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlValue.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlValue.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlValue.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlValue.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlValue.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlValue.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlValue.Style.GradientAngle = 90
        Me.pnlValue.TabIndex = 3
        '
        'btnValueCard
        '
        Me.btnValueCard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnValueCard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnValueCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnValueCard.ForeColor = System.Drawing.Color.Black
        Me.btnValueCard.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnValueCard.Location = New System.Drawing.Point(147, 91)
        Me.btnValueCard.Name = "btnValueCard"
        Me.btnValueCard.Size = New System.Drawing.Size(100, 36)
        Me.btnValueCard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnValueCard.TabIndex = 14
        Me.btnValueCard.Text = "Make Value Card"
        Me.btnValueCard.Tooltip = "Check current balance from card"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(52, 37)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(293, 16)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "Please place card on the reader/writer and click below."
        '
        'frmValueCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 149)
        Me.Controls.Add(Me.pnlValue)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmValueCard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Initialize Card"
        Me.pnlValue.ResumeLayout(False)
        Me.pnlValue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlValue As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnValueCard As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
