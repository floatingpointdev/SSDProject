<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.pnlTerminalConfig = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSSD = New System.Windows.Forms.CheckBox
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSDMax = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSDMin = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMVRMax = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMVRMin = New System.Windows.Forms.TextBox
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.pnlTerminalConfig.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTerminalConfig
        '
        Me.pnlTerminalConfig.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlTerminalConfig.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlTerminalConfig.Controls.Add(Me.btnCancel)
        Me.pnlTerminalConfig.Controls.Add(Me.GroupBox3)
        Me.pnlTerminalConfig.Controls.Add(Me.btnOK)
        Me.pnlTerminalConfig.Controls.Add(Me.GroupBox2)
        Me.pnlTerminalConfig.Controls.Add(Me.GroupBox1)
        Me.pnlTerminalConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.pnlTerminalConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTerminalConfig.Location = New System.Drawing.Point(0, 0)
        Me.pnlTerminalConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTerminalConfig.Name = "pnlTerminalConfig"
        Me.pnlTerminalConfig.Size = New System.Drawing.Size(446, 256)
        Me.pnlTerminalConfig.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlTerminalConfig.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlTerminalConfig.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlTerminalConfig.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.Abstract_blue011
        Me.pnlTerminalConfig.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlTerminalConfig.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlTerminalConfig.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlTerminalConfig.Style.GradientAngle = 90
        Me.pnlTerminalConfig.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSSD)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 100)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mode Of Operation"
        '
        'chkSSD
        '
        Me.chkSSD.AutoSize = True
        Me.chkSSD.Location = New System.Drawing.Point(11, 27)
        Me.chkSSD.Name = "chkSSD"
        Me.chkSSD.Size = New System.Drawing.Size(102, 17)
        Me.chkSSD.TabIndex = 0
        Me.chkSSD.Text = "South Star Drug"
        Me.chkSSD.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.BackColor = System.Drawing.Color.White
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnOK.Location = New System.Drawing.Point(332, 18)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 36)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 16
        Me.btnOK.Text = "OK"
        Me.btnOK.Tooltip = "Add loyalty points to card"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSDMax)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSDMin)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 64)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salary Deduction Limit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Max:"
        '
        'txtSDMax
        '
        Me.txtSDMax.Location = New System.Drawing.Point(192, 24)
        Me.txtSDMax.Name = "txtSDMax"
        Me.txtSDMax.Size = New System.Drawing.Size(96, 20)
        Me.txtSDMax.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Min:"
        '
        'txtSDMin
        '
        Me.txtSDMin.Location = New System.Drawing.Point(44, 25)
        Me.txtSDMin.Name = "txtSDMin"
        Me.txtSDMin.Size = New System.Drawing.Size(96, 20)
        Me.txtSDMin.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMVRMax)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMVRMin)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MVR Limit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Max:"
        '
        'txtMVRMax
        '
        Me.txtMVRMax.Location = New System.Drawing.Point(192, 22)
        Me.txtMVRMax.Name = "txtMVRMax"
        Me.txtMVRMax.Size = New System.Drawing.Size(96, 20)
        Me.txtMVRMax.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Min:"
        '
        'txtMVRMin
        '
        Me.txtMVRMin.Location = New System.Drawing.Point(44, 23)
        Me.txtMVRMin.Name = "txtMVRMin"
        Me.txtMVRMin.Size = New System.Drawing.Size(96, 20)
        Me.txtMVRMin.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(332, 69)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cancel"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(446, 256)
        Me.Controls.Add(Me.pnlTerminalConfig)
        Me.MaximizeBox = False
        Me.Name = "frmPreferences"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.pnlTerminalConfig.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTerminalConfig As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMVRMin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMVRMax As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSDMax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSDMin As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSSD As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
