<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.pnlLoyalty = New DevComponents.DotNetBar.PanelEx
        Me.SuspendLayout()
        '
        'pnlLoyalty
        '
        Me.pnlLoyalty.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlLoyalty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlLoyalty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoyalty.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoyalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLoyalty.Name = "pnlLoyalty"
        Me.pnlLoyalty.Size = New System.Drawing.Size(284, 261)
        Me.pnlLoyalty.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlLoyalty.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlLoyalty.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlLoyalty.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlLoyalty.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlLoyalty.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlLoyalty.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlLoyalty.Style.GradientAngle = 90
        Me.pnlLoyalty.TabIndex = 3
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pnlLoyalty)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLoyalty As DevComponents.DotNetBar.PanelEx
End Class
