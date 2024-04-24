<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinterSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrinterSetup))
        Me.pnlRS = New DevComponents.DotNetBar.PanelEx
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAutoPrint = New System.Windows.Forms.CheckBox
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.cboCOMPorts = New System.Windows.Forms.ComboBox
        Me.cboBaudrates = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlRS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRS
        '
        Me.pnlRS.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlRS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlRS.Controls.Add(Me.btnCancel)
        Me.pnlRS.Controls.Add(Me.GroupBox1)
        Me.pnlRS.Controls.Add(Me.btnOK)
        Me.pnlRS.Controls.Add(Me.cboCOMPorts)
        Me.pnlRS.Controls.Add(Me.cboBaudrates)
        Me.pnlRS.Controls.Add(Me.Label2)
        Me.pnlRS.Controls.Add(Me.Label1)
        Me.pnlRS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRS.Location = New System.Drawing.Point(0, 0)
        Me.pnlRS.Name = "pnlRS"
        Me.pnlRS.Size = New System.Drawing.Size(390, 169)
        Me.pnlRS.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlRS.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRS.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlRS.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlRS.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlRS.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlRS.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlRS.Style.GradientAngle = 90
        Me.pnlRS.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnCancel.Location = New System.Drawing.Point(279, 74)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAutoPrint)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 71)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printing Option(s):"
        '
        'chkAutoPrint
        '
        Me.chkAutoPrint.AutoSize = True
        Me.chkAutoPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoPrint.ForeColor = System.Drawing.Color.White
        Me.chkAutoPrint.Location = New System.Drawing.Point(7, 30)
        Me.chkAutoPrint.Name = "chkAutoPrint"
        Me.chkAutoPrint.Size = New System.Drawing.Size(143, 19)
        Me.chkAutoPrint.TabIndex = 4
        Me.chkAutoPrint.Text = "&Automatic Printing"
        Me.chkAutoPrint.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnOK.Location = New System.Drawing.Point(279, 25)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOK.Size = New System.Drawing.Size(100, 36)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "&OK"
        '
        'cboCOMPorts
        '
        Me.cboCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOMPorts.FormattingEnabled = True
        Me.cboCOMPorts.Location = New System.Drawing.Point(96, 27)
        Me.cboCOMPorts.Name = "cboCOMPorts"
        Me.cboCOMPorts.Size = New System.Drawing.Size(158, 21)
        Me.cboCOMPorts.TabIndex = 1
        '
        'cboBaudrates
        '
        Me.cboBaudrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaudrates.FormattingEnabled = True
        Me.cboBaudrates.Items.AddRange(New Object() {"110", "150", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
        Me.cboBaudrates.Location = New System.Drawing.Point(96, 55)
        Me.cboBaudrates.Name = "cboBaudrates"
        Me.cboBaudrates.Size = New System.Drawing.Size(158, 21)
        Me.cboBaudrates.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Baud Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&COM Port:"
        '
        'frmPrinterSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(390, 169)
        Me.Controls.Add(Me.pnlRS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrinterSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printer Setup"
        Me.pnlRS.ResumeLayout(False)
        Me.pnlRS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlRS As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBaudrates As System.Windows.Forms.ComboBox
    Friend WithEvents cboCOMPorts As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutoPrint As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
