<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRedeem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRedeem))
        Me.pnlRedeem = New DevComponents.DotNetBar.PanelEx
        Me.btnRedeem = New DevComponents.DotNetBar.ButtonX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.btnCheck = New DevComponents.DotNetBar.ButtonX
        Me.txtRewardForm = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtRewards = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.pnlRedeem.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRedeem
        '
        Me.pnlRedeem.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlRedeem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlRedeem.Controls.Add(Me.txtRewards)
        Me.pnlRedeem.Controls.Add(Me.txtRewardForm)
        Me.pnlRedeem.Controls.Add(Me.btnRedeem)
        Me.pnlRedeem.Controls.Add(Me.LabelX3)
        Me.pnlRedeem.Controls.Add(Me.LabelX1)
        Me.pnlRedeem.Controls.Add(Me.btnCheck)
        Me.pnlRedeem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRedeem.Location = New System.Drawing.Point(0, 0)
        Me.pnlRedeem.Name = "pnlRedeem"
        Me.pnlRedeem.Size = New System.Drawing.Size(286, 169)
        Me.pnlRedeem.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlRedeem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlRedeem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlRedeem.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlRedeem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlRedeem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlRedeem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlRedeem.Style.GradientAngle = 90
        Me.pnlRedeem.TabIndex = 3
        '
        'btnRedeem
        '
        Me.btnRedeem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRedeem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRedeem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeem.ForeColor = System.Drawing.Color.Black
        Me.btnRedeem.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnRedeem.Location = New System.Drawing.Point(148, 101)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(100, 36)
        Me.btnRedeem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRedeem.TabIndex = 20
        Me.btnRedeem.Text = "Redeem"
        Me.btnRedeem.Tooltip = "Redeem rewards"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(70, 62)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(53, 16)
        Me.LabelX3.TabIndex = 18
        Me.LabelX3.Text = "Rewards:"
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
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(45, 30)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 16)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Reward Form:"
        '
        'btnCheck
        '
        Me.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.Black
        Me.btnCheck.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCheck.Location = New System.Drawing.Point(38, 101)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 36)
        Me.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCheck.TabIndex = 15
        Me.btnCheck.Text = "Check Rewards"
        Me.btnCheck.Tooltip = "Check for Rewards"
        '
        'txtRewardForm
        '
        '
        '
        '
        Me.txtRewardForm.Border.Class = "TextBoxBorder"
        Me.txtRewardForm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRewardForm.Location = New System.Drawing.Point(131, 28)
        Me.txtRewardForm.Name = "txtRewardForm"
        Me.txtRewardForm.ReadOnly = True
        Me.txtRewardForm.Size = New System.Drawing.Size(117, 21)
        Me.txtRewardForm.TabIndex = 21
        '
        'txtRewards
        '
        '
        '
        '
        Me.txtRewards.Border.Class = "TextBoxBorder"
        Me.txtRewards.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRewards.Location = New System.Drawing.Point(131, 60)
        Me.txtRewards.Name = "txtRewards"
        Me.txtRewards.ReadOnly = True
        Me.txtRewards.Size = New System.Drawing.Size(117, 21)
        Me.txtRewards.TabIndex = 22
        '
        'frmRedeem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 169)
        Me.Controls.Add(Me.pnlRedeem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRedeem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Redeeming Loyalty"
        Me.pnlRedeem.ResumeLayout(False)
        Me.pnlRedeem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRedeem As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnCheck As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRedeem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRewardForm As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRewards As DevComponents.DotNetBar.Controls.TextBoxX
End Class
