<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverrideCredits
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
        Me.pnlInp = New DevComponents.DotNetBar.PanelEx
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnOk = New DevComponents.DotNetBar.ButtonX
        Me.txtARBalance = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtCABalance = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtAR = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.txtCA = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.pnlInp.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInp
        '
        Me.pnlInp.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlInp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlInp.Controls.Add(Me.btnCancel)
        Me.pnlInp.Controls.Add(Me.btnOk)
        Me.pnlInp.Controls.Add(Me.txtARBalance)
        Me.pnlInp.Controls.Add(Me.LabelX1)
        Me.pnlInp.Controls.Add(Me.txtCABalance)
        Me.pnlInp.Controls.Add(Me.LabelX2)
        Me.pnlInp.Controls.Add(Me.txtAR)
        Me.pnlInp.Controls.Add(Me.LabelX19)
        Me.pnlInp.Controls.Add(Me.txtCA)
        Me.pnlInp.Controls.Add(Me.LabelX18)
        Me.pnlInp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInp.Location = New System.Drawing.Point(0, 0)
        Me.pnlInp.Name = "pnlInp"
        Me.pnlInp.Size = New System.Drawing.Size(506, 148)
        Me.pnlInp.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlInp.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlInp.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlInp.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlInp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlInp.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlInp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlInp.Style.GradientAngle = 90
        Me.pnlInp.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(394, 95)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnOk.Location = New System.Drawing.Point(288, 95)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOk.Size = New System.Drawing.Size(100, 36)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        '
        'txtARBalance
        '
        Me.txtARBalance.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtARBalance.Border.Class = "TextBoxBorder"
        Me.txtARBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtARBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARBalance.ForeColor = System.Drawing.Color.Black
        Me.txtARBalance.Location = New System.Drawing.Point(338, 55)
        Me.txtARBalance.Name = "txtARBalance"
        Me.txtARBalance.Size = New System.Drawing.Size(156, 21)
        Me.txtARBalance.TabIndex = 7
        Me.txtARBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(236, 57)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 16)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "AR Consumable:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCABalance
        '
        Me.txtCABalance.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtCABalance.Border.Class = "TextBoxBorder"
        Me.txtCABalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCABalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCABalance.ForeColor = System.Drawing.Color.Black
        Me.txtCABalance.Location = New System.Drawing.Point(338, 28)
        Me.txtCABalance.Name = "txtCABalance"
        Me.txtCABalance.Size = New System.Drawing.Size(156, 21)
        Me.txtCABalance.TabIndex = 3
        Me.txtCABalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(236, 30)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(96, 16)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "CA Consumable:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtAR
        '
        Me.txtAR.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtAR.Border.Class = "TextBoxBorder"
        Me.txtAR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAR.ForeColor = System.Drawing.Color.Black
        Me.txtAR.Location = New System.Drawing.Point(47, 55)
        Me.txtAR.Name = "txtAR"
        Me.txtAR.Size = New System.Drawing.Size(156, 21)
        Me.txtAR.TabIndex = 5
        Me.txtAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX19
        '
        Me.LabelX19.AutoSize = True
        '
        '
        '
        Me.LabelX19.BackgroundStyle.Class = ""
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.Color.White
        Me.LabelX19.Location = New System.Drawing.Point(16, 57)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(23, 16)
        Me.LabelX19.TabIndex = 4
        Me.LabelX19.Text = "AR:"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCA
        '
        Me.txtCA.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtCA.Border.Class = "TextBoxBorder"
        Me.txtCA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCA.ForeColor = System.Drawing.Color.Black
        Me.txtCA.Location = New System.Drawing.Point(47, 28)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(156, 21)
        Me.txtCA.TabIndex = 1
        Me.txtCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        '
        '
        '
        Me.LabelX18.BackgroundStyle.Class = ""
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.ForeColor = System.Drawing.Color.White
        Me.LabelX18.Location = New System.Drawing.Point(17, 30)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(23, 16)
        Me.LabelX18.TabIndex = 0
        Me.LabelX18.Text = "CA:"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmOverrideCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 148)
        Me.Controls.Add(Me.pnlInp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOverrideCredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Override Credits"
        Me.pnlInp.ResumeLayout(False)
        Me.pnlInp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInp As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtARBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCABalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
End Class
