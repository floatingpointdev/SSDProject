<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReaderSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReaderSetup))
        Me.pnlRS = New DevComponents.DotNetBar.PanelEx
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.picDevice = New System.Windows.Forms.PictureBox
        Me.cboCOMPort = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.btnSet = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmbReaders = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Reader0 = New DevComponents.Editors.ComboItem
        Me.pnlRS.SuspendLayout()
        CType(Me.picDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRS
        '
        Me.pnlRS.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlRS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlRS.Controls.Add(Me.btnClose)
        Me.pnlRS.Controls.Add(Me.picDevice)
        Me.pnlRS.Controls.Add(Me.cboCOMPort)
        Me.pnlRS.Controls.Add(Me.LabelX2)
        Me.pnlRS.Controls.Add(Me.btnSet)
        Me.pnlRS.Controls.Add(Me.LabelX1)
        Me.pnlRS.Controls.Add(Me.cmbReaders)
        Me.pnlRS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRS.Location = New System.Drawing.Point(0, 0)
        Me.pnlRS.Name = "pnlRS"
        Me.pnlRS.Size = New System.Drawing.Size(414, 176)
        Me.pnlRS.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlRS.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRS.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlRS.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlRS.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlRS.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlRS.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlRS.Style.GradientAngle = 90
        Me.pnlRS.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnClose.Location = New System.Drawing.Point(557, 27)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 36)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.Tooltip = "Click to set selected as default Reader."
        '
        'picDevice
        '
        Me.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDevice.ErrorImage = Nothing
        Me.picDevice.Image = Global.SSDProject.My.Resources.Resources.ACS_image1
        Me.picDevice.Location = New System.Drawing.Point(12, 12)
        Me.picDevice.Name = "picDevice"
        Me.picDevice.Size = New System.Drawing.Size(149, 151)
        Me.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDevice.TabIndex = 9
        Me.picDevice.TabStop = False
        '
        'cboCOMPort
        '
        Me.cboCOMPort.DisplayMember = "Text"
        Me.cboCOMPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOMPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOMPort.ForeColor = System.Drawing.Color.Black
        Me.cboCOMPort.FormattingEnabled = True
        Me.cboCOMPort.ItemHeight = 15
        Me.cboCOMPort.Location = New System.Drawing.Point(253, 60)
        Me.cboCOMPort.Name = "cboCOMPort"
        Me.cboCOMPort.Size = New System.Drawing.Size(146, 21)
        Me.cboCOMPort.Sorted = True
        Me.cboCOMPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCOMPort.TabIndex = 3
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
        Me.LabelX2.Location = New System.Drawing.Point(182, 61)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(61, 16)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "&COM Port:"
        '
        'btnSet
        '
        Me.btnSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSet.BackColor = System.Drawing.Color.Transparent
        Me.btnSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.Black
        Me.btnSet.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnSet.Location = New System.Drawing.Point(300, 127)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSet.Size = New System.Drawing.Size(100, 36)
        Me.btnSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSet.TabIndex = 4
        Me.btnSet.Text = "S&et"
        Me.btnSet.Tooltip = "Click to set selected as default Reader."
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
        Me.LabelX1.Location = New System.Drawing.Point(181, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(119, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "&Set Default Reader: "
        '
        'cmbReaders
        '
        Me.cmbReaders.DisplayMember = "Text"
        Me.cmbReaders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReaders.ForeColor = System.Drawing.Color.Black
        Me.cmbReaders.FormattingEnabled = True
        Me.cmbReaders.ItemHeight = 15
        Me.cmbReaders.Items.AddRange(New Object() {Me.Reader0})
        Me.cmbReaders.Location = New System.Drawing.Point(180, 34)
        Me.cmbReaders.Name = "cmbReaders"
        Me.cmbReaders.Size = New System.Drawing.Size(220, 21)
        Me.cmbReaders.Sorted = True
        Me.cmbReaders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbReaders.TabIndex = 1
        '
        'Reader0
        '
        Me.Reader0.Text = "ACR1222L"
        '
        'frmReaderSetup
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(414, 176)
        Me.Controls.Add(Me.pnlRS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReaderSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Reader Setup"
        Me.pnlRS.ResumeLayout(False)
        Me.pnlRS.PerformLayout()
        CType(Me.picDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlRS As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSet As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents cmbReaders As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents cboCOMPort As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents picDevice As System.Windows.Forms.PictureBox
    Friend WithEvents Reader0 As DevComponents.Editors.ComboItem
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
End Class
