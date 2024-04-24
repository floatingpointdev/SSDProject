<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardDeleteTool
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
        Me.components = New System.ComponentModel.Container
        Me.pnlGroupManger = New DevComponents.DotNetBar.PanelEx
        Me.grpImport = New System.Windows.Forms.GroupBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCardID = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlGroupManger.SuspendLayout()
        Me.grpImport.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.grpImport)
        Me.pnlGroupManger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGroupManger.Location = New System.Drawing.Point(0, 0)
        Me.pnlGroupManger.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGroupManger.Name = "pnlGroupManger"
        Me.pnlGroupManger.Size = New System.Drawing.Size(471, 174)
        Me.pnlGroupManger.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlGroupManger.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlGroupManger.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlGroupManger.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlGroupManger.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlGroupManger.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlGroupManger.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlGroupManger.Style.GradientAngle = 90
        Me.pnlGroupManger.TabIndex = 2
        '
        'grpImport
        '
        Me.grpImport.Controls.Add(Me.Label2)
        Me.grpImport.Controls.Add(Me.lblStatus)
        Me.grpImport.Controls.Add(Me.btnDelete)
        Me.grpImport.Controls.Add(Me.Label1)
        Me.grpImport.Controls.Add(Me.txtCardID)
        Me.grpImport.Location = New System.Drawing.Point(12, 3)
        Me.grpImport.Name = "grpImport"
        Me.grpImport.Size = New System.Drawing.Size(448, 162)
        Me.grpImport.TabIndex = 0
        Me.grpImport.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(78, 90)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(300, 23)
        Me.lblStatus.TabIndex = 21
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnDelete.Location = New System.Drawing.Point(172, 117)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 36)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card ID"
        '
        'txtCardID
        '
        Me.txtCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardID.Location = New System.Drawing.Point(75, 67)
        Me.txtCardID.Name = "txtCardID"
        Me.txtCardID.Size = New System.Drawing.Size(303, 20)
        Me.txtCardID.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(78, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Please Tap Card or Input the Card RFID Number below"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCardDeleteTool
        '
        Me.AcceptButton = Me.btnDelete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 174)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCardDeleteTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Delete Tool"
        Me.pnlGroupManger.ResumeLayout(False)
        Me.grpImport.ResumeLayout(False)
        Me.grpImport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grpImport As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardID As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
