<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemp
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
        Me.grpDecremental = New System.Windows.Forms.GroupBox
        Me.chkExpires = New System.Windows.Forms.CheckBox
        Me.numDecrementBy = New System.Windows.Forms.NumericUpDown
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.dtExpiration = New System.Windows.Forms.DateTimePicker
        Me.txtDesc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtLoyaltyCode = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.rbDecremental = New System.Windows.Forms.RadioButton
        Me.rbIncremental = New System.Windows.Forms.RadioButton
        Me.grpIncremental = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGiftTable = New DevComponents.DotNetBar.ButtonX
        Me.numCashAmount = New System.Windows.Forms.NumericUpDown
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.rbGift = New System.Windows.Forms.RadioButton
        Me.rbCash = New System.Windows.Forms.RadioButton
        Me.numPointThreshold = New System.Windows.Forms.NumericUpDown
        Me.numPointsRatio = New System.Windows.Forms.NumericUpDown
        Me.numAmount = New System.Windows.Forms.NumericUpDown
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.grpDecremental.SuspendLayout()
        CType(Me.numDecrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpIncremental.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numCashAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPointThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPointsRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDecremental
        '
        Me.grpDecremental.Controls.Add(Me.chkExpires)
        Me.grpDecremental.Controls.Add(Me.numDecrementBy)
        Me.grpDecremental.Controls.Add(Me.LabelX7)
        Me.grpDecremental.Controls.Add(Me.GroupBox2)
        Me.grpDecremental.Location = New System.Drawing.Point(269, 88)
        Me.grpDecremental.Name = "grpDecremental"
        Me.grpDecremental.Size = New System.Drawing.Size(425, 240)
        Me.grpDecremental.TabIndex = 65
        Me.grpDecremental.TabStop = False
        '
        'chkExpires
        '
        Me.chkExpires.AutoSize = True
        Me.chkExpires.Location = New System.Drawing.Point(17, 80)
        Me.chkExpires.Name = "chkExpires"
        Me.chkExpires.Size = New System.Drawing.Size(60, 17)
        Me.chkExpires.TabIndex = 49
        Me.chkExpires.Text = "Expires"
        Me.chkExpires.UseVisualStyleBackColor = True
        '
        'numDecrementBy
        '
        Me.numDecrementBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numDecrementBy.Location = New System.Drawing.Point(111, 27)
        Me.numDecrementBy.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numDecrementBy.Name = "numDecrementBy"
        Me.numDecrementBy.Size = New System.Drawing.Size(156, 20)
        Me.numDecrementBy.TabIndex = 48
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(17, 27)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(80, 16)
        Me.LabelX7.TabIndex = 43
        Me.LabelX7.Text = "Decrement by:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.dtExpiration)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 144)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(14, 25)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(88, 16)
        Me.LabelX8.TabIndex = 45
        Me.LabelX8.Text = "Expiration Date:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtExpiration
        '
        Me.dtExpiration.Enabled = False
        Me.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtExpiration.Location = New System.Drawing.Point(108, 25)
        Me.dtExpiration.Name = "dtExpiration"
        Me.dtExpiration.Size = New System.Drawing.Size(156, 20)
        Me.dtExpiration.TabIndex = 47
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtDesc.Border.Class = "TextBoxBorder"
        Me.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(102, 141)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.MaxLength = 20
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(156, 21)
        Me.txtDesc.TabIndex = 67
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(20, 107)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(76, 19)
        Me.LabelX1.TabIndex = 61
        Me.LabelX1.Text = "Loyalty Code:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(20, 142)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(76, 19)
        Me.LabelX6.TabIndex = 66
        Me.LabelX6.Text = "Description:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLoyaltyCode
        '
        Me.txtLoyaltyCode.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtLoyaltyCode.Border.Class = "TextBoxBorder"
        Me.txtLoyaltyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLoyaltyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyCode.ForeColor = System.Drawing.Color.Black
        Me.txtLoyaltyCode.Location = New System.Drawing.Point(102, 105)
        Me.txtLoyaltyCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoyaltyCode.MaxLength = 20
        Me.txtLoyaltyCode.Name = "txtLoyaltyCode"
        Me.txtLoyaltyCode.Size = New System.Drawing.Size(156, 21)
        Me.txtLoyaltyCode.TabIndex = 60
        Me.txtLoyaltyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbDecremental
        '
        Me.rbDecremental.AutoSize = True
        Me.rbDecremental.Location = New System.Drawing.Point(102, 214)
        Me.rbDecremental.Name = "rbDecremental"
        Me.rbDecremental.Size = New System.Drawing.Size(85, 17)
        Me.rbDecremental.TabIndex = 63
        Me.rbDecremental.Text = "Decremental"
        Me.rbDecremental.UseVisualStyleBackColor = True
        '
        'rbIncremental
        '
        Me.rbIncremental.AutoSize = True
        Me.rbIncremental.Checked = True
        Me.rbIncremental.Location = New System.Drawing.Point(102, 189)
        Me.rbIncremental.Name = "rbIncremental"
        Me.rbIncremental.Size = New System.Drawing.Size(80, 17)
        Me.rbIncremental.TabIndex = 62
        Me.rbIncremental.TabStop = True
        Me.rbIncremental.Text = "Incremental"
        Me.rbIncremental.UseVisualStyleBackColor = True
        '
        'grpIncremental
        '
        Me.grpIncremental.Controls.Add(Me.GroupBox1)
        Me.grpIncremental.Controls.Add(Me.numPointThreshold)
        Me.grpIncremental.Controls.Add(Me.numPointsRatio)
        Me.grpIncremental.Controls.Add(Me.numAmount)
        Me.grpIncremental.Controls.Add(Me.LabelX3)
        Me.grpIncremental.Controls.Add(Me.LabelX4)
        Me.grpIncremental.Controls.Add(Me.LabelX2)
        Me.grpIncremental.Location = New System.Drawing.Point(286, 88)
        Me.grpIncremental.Name = "grpIncremental"
        Me.grpIncremental.Size = New System.Drawing.Size(408, 240)
        Me.grpIncremental.TabIndex = 64
        Me.grpIncremental.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGiftTable)
        Me.GroupBox1.Controls.Add(Me.numCashAmount)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.rbGift)
        Me.GroupBox1.Controls.Add(Me.rbCash)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 128)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reward Type:"
        '
        'btnGiftTable
        '
        Me.btnGiftTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGiftTable.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGiftTable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGiftTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftTable.ForeColor = System.Drawing.Color.Black
        Me.btnGiftTable.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnGiftTable.Location = New System.Drawing.Point(39, 70)
        Me.btnGiftTable.Name = "btnGiftTable"
        Me.btnGiftTable.Size = New System.Drawing.Size(100, 36)
        Me.btnGiftTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGiftTable.TabIndex = 62
        Me.btnGiftTable.Text = "Gift Table..."
        Me.btnGiftTable.Tooltip = "Shows the Gift Table"
        '
        'numCashAmount
        '
        Me.numCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numCashAmount.Location = New System.Drawing.Point(154, 19)
        Me.numCashAmount.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numCashAmount.Name = "numCashAmount"
        Me.numCashAmount.Size = New System.Drawing.Size(156, 20)
        Me.numCashAmount.TabIndex = 61
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(95, 21)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(53, 16)
        Me.LabelX5.TabIndex = 60
        Me.LabelX5.Text = "Amount:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'rbGift
        '
        Me.rbGift.AutoSize = True
        Me.rbGift.Location = New System.Drawing.Point(20, 45)
        Me.rbGift.Name = "rbGift"
        Me.rbGift.Size = New System.Drawing.Size(41, 17)
        Me.rbGift.TabIndex = 58
        Me.rbGift.Text = "Gift"
        Me.rbGift.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Location = New System.Drawing.Point(20, 20)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(49, 17)
        Me.rbCash.TabIndex = 57
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'numPointThreshold
        '
        Me.numPointThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPointThreshold.Location = New System.Drawing.Point(125, 79)
        Me.numPointThreshold.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPointThreshold.Name = "numPointThreshold"
        Me.numPointThreshold.Size = New System.Drawing.Size(156, 20)
        Me.numPointThreshold.TabIndex = 56
        '
        'numPointsRatio
        '
        Me.numPointsRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPointsRatio.Location = New System.Drawing.Point(124, 50)
        Me.numPointsRatio.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPointsRatio.Name = "numPointsRatio"
        Me.numPointsRatio.Size = New System.Drawing.Size(156, 20)
        Me.numPointsRatio.TabIndex = 55
        '
        'numAmount
        '
        Me.numAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numAmount.Location = New System.Drawing.Point(124, 17)
        Me.numAmount.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(156, 20)
        Me.numAmount.TabIndex = 54
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(48, 52)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(71, 16)
        Me.LabelX3.TabIndex = 46
        Me.LabelX3.Text = "Points Ratio:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(29, 82)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 16)
        Me.LabelX4.TabIndex = 49
        Me.LabelX4.Text = "Point Threshold:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(9, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(110, 16)
        Me.LabelX2.TabIndex = 44
        Me.LabelX2.Text = "Amount (For Every):"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 416)
        Me.Controls.Add(Me.grpDecremental)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtLoyaltyCode)
        Me.Controls.Add(Me.rbDecremental)
        Me.Controls.Add(Me.rbIncremental)
        Me.Controls.Add(Me.grpIncremental)
        Me.Name = "frmTemp"
        Me.Text = "frmTemp"
        Me.grpDecremental.ResumeLayout(False)
        Me.grpDecremental.PerformLayout()
        CType(Me.numDecrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpIncremental.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numCashAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPointThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPointsRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDecremental As System.Windows.Forms.GroupBox
    Friend WithEvents chkExpires As System.Windows.Forms.CheckBox
    Friend WithEvents numDecrementBy As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtExpiration As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLoyaltyCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbDecremental As System.Windows.Forms.RadioButton
    Friend WithEvents rbIncremental As System.Windows.Forms.RadioButton
    Friend WithEvents grpIncremental As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGiftTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents numCashAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbGift As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents numPointThreshold As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPointsRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents numAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
