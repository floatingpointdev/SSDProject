<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grpImport = New System.Windows.Forms.GroupBox
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX
        Me.btnImport = New DevComponents.DotNetBar.ButtonX
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgMappings = New System.Windows.Forms.DataGridView
        Me.colTarget = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSource = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.pbProgress = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.grpValidity = New System.Windows.Forms.GroupBox
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblLoading = New System.Windows.Forms.Label
        Me.pnlGroupManger = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblFailedCount = New System.Windows.Forms.Label
        Me.lblUploadCount = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgUploaded = New System.Windows.Forms.DataGridView
        Me.dgFailed = New System.Windows.Forms.DataGridView
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.grpImport.SuspendLayout()
        CType(Me.dgMappings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValidity.SuspendLayout()
        Me.pnlGroupManger.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUploaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFailed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpImport
        '
        Me.grpImport.Controls.Add(Me.btnBrowse)
        Me.grpImport.Controls.Add(Me.btnImport)
        Me.grpImport.Controls.Add(Me.Label2)
        Me.grpImport.Controls.Add(Me.dgMappings)
        Me.grpImport.Controls.Add(Me.pbProgress)
        Me.grpImport.Controls.Add(Me.Label1)
        Me.grpImport.Controls.Add(Me.txtFile)
        Me.grpImport.Controls.Add(Me.grpValidity)
        Me.grpImport.Location = New System.Drawing.Point(12, 3)
        Me.grpImport.Name = "grpImport"
        Me.grpImport.Size = New System.Drawing.Size(448, 419)
        Me.grpImport.TabIndex = 0
        Me.grpImport.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnBrowse.Location = New System.Drawing.Point(326, 26)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnBrowse.Size = New System.Drawing.Size(100, 36)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "&Browse..."
        '
        'btnImport
        '
        Me.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImport.Enabled = False
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.Black
        Me.btnImport.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnImport.Location = New System.Drawing.Point(326, 369)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnImport.Size = New System.Drawing.Size(100, 36)
        Me.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImport.TabIndex = 9
        Me.btnImport.Text = "&Import"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Mappings:"
        '
        'dgMappings
        '
        Me.dgMappings.AllowUserToAddRows = False
        Me.dgMappings.AllowUserToResizeRows = False
        Me.dgMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMappings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTarget, Me.colSource})
        Me.dgMappings.Location = New System.Drawing.Point(21, 113)
        Me.dgMappings.Name = "dgMappings"
        Me.dgMappings.Size = New System.Drawing.Size(405, 243)
        Me.dgMappings.TabIndex = 4
        '
        'colTarget
        '
        Me.colTarget.DataPropertyName = "TargetFields"
        Me.colTarget.HeaderText = "TargetFields"
        Me.colTarget.Name = "colTarget"
        Me.colTarget.ReadOnly = True
        '
        'colSource
        '
        Me.colSource.DataPropertyName = "SourceFields"
        Me.colSource.HeaderText = "SourceColumns"
        Me.colSource.Name = "colSource"
        Me.colSource.Width = 220
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(21, 60)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(300, 20)
        Me.pbProgress.TabIndex = 3
        Me.pbProgress.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&File:"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(21, 34)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(300, 20)
        Me.txtFile.TabIndex = 1
        '
        'grpValidity
        '
        Me.grpValidity.Controls.Add(Me.dtTo)
        Me.grpValidity.Controls.Add(Me.dtFrom)
        Me.grpValidity.Controls.Add(Me.Label4)
        Me.grpValidity.Controls.Add(Me.Label3)
        Me.grpValidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValidity.ForeColor = System.Drawing.Color.White
        Me.grpValidity.Location = New System.Drawing.Point(21, 362)
        Me.grpValidity.Name = "grpValidity"
        Me.grpValidity.Size = New System.Drawing.Size(405, 66)
        Me.grpValidity.TabIndex = 20
        Me.grpValidity.TabStop = False
        Me.grpValidity.Text = "Validity Period"
        Me.grpValidity.Visible = False
        '
        'dtTo
        '
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(205, 37)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(183, 20)
        Me.dtTo.TabIndex = 8
        '
        'dtFrom
        '
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(7, 37)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(183, 20)
        Me.dtFrom.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(202, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "F&rom:"
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Black
        Me.lblLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(97, 199)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(247, 23)
        Me.lblLoading.TabIndex = 21
        Me.lblLoading.Text = "Loading File..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoading.Visible = False
        '
        'pnlGroupManger
        '
        Me.pnlGroupManger.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlGroupManger.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlGroupManger.Controls.Add(Me.lblLoading)
        Me.pnlGroupManger.Controls.Add(Me.GroupBox1)
        Me.pnlGroupManger.Controls.Add(Me.grpImport)
        Me.pnlGroupManger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGroupManger.Location = New System.Drawing.Point(0, 0)
        Me.pnlGroupManger.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGroupManger.Name = "pnlGroupManger"
        Me.pnlGroupManger.Size = New System.Drawing.Size(1057, 437)
        Me.pnlGroupManger.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlGroupManger.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlGroupManger.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlGroupManger.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.pnlGroupManger.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlGroupManger.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlGroupManger.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlGroupManger.Style.GradientAngle = 90
        Me.pnlGroupManger.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFailedCount)
        Me.GroupBox1.Controls.Add(Me.lblUploadCount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dgUploaded)
        Me.GroupBox1.Controls.Add(Me.dgFailed)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(467, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 418)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result:"
        '
        'lblFailedCount
        '
        Me.lblFailedCount.Location = New System.Drawing.Point(516, 222)
        Me.lblFailedCount.Name = "lblFailedCount"
        Me.lblFailedCount.Size = New System.Drawing.Size(56, 13)
        Me.lblFailedCount.TabIndex = 10
        Me.lblFailedCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUploadCount
        '
        Me.lblUploadCount.Location = New System.Drawing.Point(516, 25)
        Me.lblUploadCount.Name = "lblUploadCount"
        Me.lblUploadCount.Size = New System.Drawing.Size(56, 13)
        Me.lblUploadCount.TabIndex = 9
        Me.lblUploadCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "F&ailed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "&Uploaded:"
        '
        'dgUploaded
        '
        Me.dgUploaded.AllowUserToAddRows = False
        Me.dgUploaded.AllowUserToResizeRows = False
        Me.dgUploaded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUploaded.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgUploaded.Location = New System.Drawing.Point(11, 44)
        Me.dgUploaded.Name = "dgUploaded"
        Me.dgUploaded.Size = New System.Drawing.Size(561, 164)
        Me.dgUploaded.TabIndex = 11
        '
        'dgFailed
        '
        Me.dgFailed.AllowUserToAddRows = False
        Me.dgFailed.AllowUserToResizeRows = False
        Me.dgFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgFailed.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgFailed.Location = New System.Drawing.Point(11, 240)
        Me.dgFailed.Name = "dgFailed"
        Me.dgFailed.Size = New System.Drawing.Size(561, 164)
        Me.dgFailed.TabIndex = 13
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "OpenFileDialog1"
        '
        'tmrWait
        '
        '
        'frmImportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 437)
        Me.Controls.Add(Me.pnlGroupManger)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmImportData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data"
        Me.grpImport.ResumeLayout(False)
        Me.grpImport.PerformLayout()
        CType(Me.dgMappings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValidity.ResumeLayout(False)
        Me.grpValidity.PerformLayout()
        Me.pnlGroupManger.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgUploaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFailed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpImport As System.Windows.Forms.GroupBox
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMappings As System.Windows.Forms.DataGridView
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImport As DevComponents.DotNetBar.ButtonX
    Private WithEvents pnlGroupManger As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpValidity As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents colTarget As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSource As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgFailed As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgUploaded As System.Windows.Forms.DataGridView
    Friend WithEvents lblFailedCount As System.Windows.Forms.Label
    Friend WithEvents lblUploadCount As System.Windows.Forms.Label
    Friend WithEvents tmrWait As System.Windows.Forms.Timer
    Friend WithEvents lblLoading As System.Windows.Forms.Label
End Class
