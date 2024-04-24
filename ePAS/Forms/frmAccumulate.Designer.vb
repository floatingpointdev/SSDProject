<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccumulate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccumulate))
        Me.pnlAccumulate = New DevComponents.DotNetBar.PanelEx
        Me.btnGetBalance = New DevComponents.DotNetBar.ButtonX
        Me.btnAddPoints = New DevComponents.DotNetBar.ButtonX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtAmount = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtPoints = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.pnlAccumulate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAccumulate
        '
        Me.pnlAccumulate.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlAccumulate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlAccumulate.Controls.Add(Me.txtBalance)
        Me.pnlAccumulate.Controls.Add(Me.txtPoints)
        Me.pnlAccumulate.Controls.Add(Me.btnGetBalance)
        Me.pnlAccumulate.Controls.Add(Me.btnAddPoints)
        Me.pnlAccumulate.Controls.Add(Me.LabelX3)
        Me.pnlAccumulate.Controls.Add(Me.LabelX1)
        Me.pnlAccumulate.Controls.Add(Me.txtAmount)
        Me.pnlAccumulate.Controls.Add(Me.LabelX2)
        Me.pnlAccumulate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAccumulate.Location = New System.Drawing.Point(0, 0)
        Me.pnlAccumulate.Name = "pnlAccumulate"
        Me.pnlAccumulate.Size = New System.Drawing.Size(317, 167)
        Me.pnlAccumulate.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlAccumulate.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlAccumulate.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlAccumulate.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlAccumulate.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlAccumulate.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlAccumulate.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlAccumulate.Style.GradientAngle = 90
        Me.pnlAccumulate.TabIndex = 2
        '
        'btnGetBalance
        '
        Me.btnGetBalance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetBalance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGetBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGetBalance.ForeColor = System.Drawing.Color.Black
        Me.btnGetBalance.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnGetBalance.Location = New System.Drawing.Point(163, 111)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(100, 36)
        Me.btnGetBalance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGetBalance.TabIndex = 14
        Me.btnGetBalance.Text = "Get &Balance"
        Me.btnGetBalance.Tooltip = "Check current balance from card"
        '
        'btnAddPoints
        '
        Me.btnAddPoints.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddPoints.BackColor = System.Drawing.Color.White
        Me.btnAddPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPoints.ForeColor = System.Drawing.Color.Black
        Me.btnAddPoints.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnAddPoints.Location = New System.Drawing.Point(54, 111)
        Me.btnAddPoints.Name = "btnAddPoints"
        Me.btnAddPoints.Size = New System.Drawing.Size(100, 36)
        Me.btnAddPoints.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAddPoints.TabIndex = 15
        Me.btnAddPoints.Text = "Add Points"
        Me.btnAddPoints.Tooltip = "Add loyalty points to card"
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
        Me.LabelX3.Location = New System.Drawing.Point(36, 73)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(92, 16)
        Me.LabelX3.TabIndex = 11
        Me.LabelX3.Text = "Current Balance:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.LabelX1.Location = New System.Drawing.Point(47, 46)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 16)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Points Earned:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtAmount.Border.Class = "TextBoxBorder"
        Me.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(134, 16)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(149, 21)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAmount.WatermarkText = "Enter Amount"
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
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(81, 18)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(47, 16)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Amount:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPoints
        '
        Me.txtPoints.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtPoints.Border.Class = "TextBoxBorder"
        Me.txtPoints.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPoints.Location = New System.Drawing.Point(134, 44)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(149, 21)
        Me.txtPoints.TabIndex = 16
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPoints.WatermarkText = "0.00"
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtBalance.Border.Class = "TextBoxBorder"
        Me.txtBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBalance.Location = New System.Drawing.Point(134, 71)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(149, 21)
        Me.txtBalance.TabIndex = 17
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBalance.WatermarkText = "0.00"
        '
        'frmAccumulate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 167)
        Me.Controls.Add(Me.pnlAccumulate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccumulate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Accumulating Loyalty"
        Me.pnlAccumulate.ResumeLayout(False)
        Me.pnlAccumulate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAccumulate As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtAmount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnGetBalance As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAddPoints As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPoints As DevComponents.DotNetBar.Controls.TextBoxX
End Class
