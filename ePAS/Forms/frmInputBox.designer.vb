<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBox
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
        Me.pnlInp = New DevComponents.DotNetBar.PanelEx
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnOk = New DevComponents.DotNetBar.ButtonX
        Me.tbInput = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelL = New DevComponents.DotNetBar.LabelX
        Me.pnlInp.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInp
        '
        Me.pnlInp.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlInp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlInp.Controls.Add(Me.btnCancel)
        Me.pnlInp.Controls.Add(Me.btnOk)
        Me.pnlInp.Controls.Add(Me.tbInput)
        Me.pnlInp.Controls.Add(Me.LabelL)
        Me.pnlInp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInp.Location = New System.Drawing.Point(0, 0)
        Me.pnlInp.Name = "pnlInp"
        Me.pnlInp.Size = New System.Drawing.Size(305, 123)
        Me.pnlInp.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlInp.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlInp.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlInp.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlInp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlInp.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlInp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlInp.Style.GradientAngle = 90
        Me.pnlInp.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(188, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnOk.Location = New System.Drawing.Point(82, 71)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOk.Size = New System.Drawing.Size(100, 36)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        '
        'tbInput
        '
        '
        '
        '
        Me.tbInput.Border.Class = "TextBoxBorder"
        Me.tbInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.ForeColor = System.Drawing.Color.Black
        Me.tbInput.Location = New System.Drawing.Point(21, 35)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbInput.Size = New System.Drawing.Size(267, 21)
        Me.tbInput.TabIndex = 1
        '
        'LabelL
        '
        Me.LabelL.AutoSize = True
        '
        '
        '
        Me.LabelL.BackgroundStyle.Class = ""
        Me.LabelL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelL.ForeColor = System.Drawing.Color.White
        Me.LabelL.Location = New System.Drawing.Point(21, 12)
        Me.LabelL.Name = "LabelL"
        Me.LabelL.Size = New System.Drawing.Size(163, 16)
        Me.LabelL.TabIndex = 0
        Me.LabelL.Text = "Input Password to continue: "
        '
        'frmInputBox
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(305, 123)
        Me.Controls.Add(Me.pnlInp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Check Password"
        Me.pnlInp.ResumeLayout(False)
        Me.pnlInp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInp As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelL As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbInput As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
