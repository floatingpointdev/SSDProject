<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmService))
        Me.grpInput = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblVAT = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCharge = New System.Windows.Forms.Button
        Me.btnSal = New System.Windows.Forms.Button
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.btnCA = New System.Windows.Forms.Button
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.gbKeypad = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btnPeriod = New System.Windows.Forms.Button
        Me.btnVoid = New System.Windows.Forms.Button
        Me.btnCE = New System.Windows.Forms.Button
        Me.txtTrans = New System.Windows.Forms.TextBox
        Me.lblDate = New System.Windows.Forms.Label
        Me.tmrService = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReader = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.txtDoubleAmount = New DevComponents.Editors.DoubleInput
        Me.rtxtTrans = New System.Windows.Forms.RichTextBox
        Me.tmrVAT = New System.Windows.Forms.Timer(Me.components)
        Me.grpInput.SuspendLayout()
        Me.gbKeypad.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.txtDoubleAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.lblVAT)
        Me.grpInput.Controls.Add(Me.btnPrint)
        Me.grpInput.Controls.Add(Me.btnCharge)
        Me.grpInput.Controls.Add(Me.btnSal)
        Me.grpInput.Controls.Add(Me.txtStatus)
        Me.grpInput.Controls.Add(Me.btnCA)
        Me.grpInput.Controls.Add(Me.txtAmount)
        Me.grpInput.Controls.Add(Me.gbKeypad)
        Me.grpInput.Controls.Add(Me.btnVoid)
        Me.grpInput.Location = New System.Drawing.Point(13, 60)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(380, 473)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(327, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "F12"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(334, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "F9"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(334, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "F8"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVAT
        '
        Me.lblVAT.BackColor = System.Drawing.Color.Red
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(290, 379)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(75, 75)
        Me.lblVAT.TabIndex = 17
        Me.lblVAT.Text = "VAT"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVAT.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(289, 263)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 75)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnCharge
        '
        Me.btnCharge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharge.Location = New System.Drawing.Point(289, 182)
        Me.btnCharge.Name = "btnCharge"
        Me.btnCharge.Size = New System.Drawing.Size(75, 75)
        Me.btnCharge.TabIndex = 15
        Me.btnCharge.Text = "CHARGE"
        Me.btnCharge.UseVisualStyleBackColor = False
        Me.btnCharge.Visible = False
        '
        'btnSal
        '
        Me.btnSal.BackColor = System.Drawing.Color.Cyan
        Me.btnSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSal.Location = New System.Drawing.Point(289, 101)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(75, 75)
        Me.btnSal.TabIndex = 14
        Me.btnSal.Text = "AR"
        Me.btnSal.UseVisualStyleBackColor = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Orange
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(7, 410)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(268, 44)
        Me.txtStatus.TabIndex = 15
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCA
        '
        Me.btnCA.BackColor = System.Drawing.Color.Teal
        Me.btnCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCA.ForeColor = System.Drawing.Color.Cyan
        Me.btnCA.Location = New System.Drawing.Point(289, 20)
        Me.btnCA.Name = "btnCA"
        Me.btnCA.Size = New System.Drawing.Size(75, 75)
        Me.btnCA.TabIndex = 13
        Me.btnCA.Text = "CA"
        Me.btnCA.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(7, 20)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(268, 47)
        Me.txtAmount.TabIndex = 0
        Me.txtAmount.Text = "0."
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.Visible = False
        '
        'gbKeypad
        '
        Me.gbKeypad.Controls.Add(Me.Label4)
        Me.gbKeypad.Controls.Add(Me.btn7)
        Me.gbKeypad.Controls.Add(Me.btn8)
        Me.gbKeypad.Controls.Add(Me.btn9)
        Me.gbKeypad.Controls.Add(Me.btn4)
        Me.gbKeypad.Controls.Add(Me.btn5)
        Me.gbKeypad.Controls.Add(Me.btn6)
        Me.gbKeypad.Controls.Add(Me.btn1)
        Me.gbKeypad.Controls.Add(Me.btnC)
        Me.gbKeypad.Controls.Add(Me.btn2)
        Me.gbKeypad.Controls.Add(Me.btn0)
        Me.gbKeypad.Controls.Add(Me.btn3)
        Me.gbKeypad.Controls.Add(Me.btnPeriod)
        Me.gbKeypad.Location = New System.Drawing.Point(7, 65)
        Me.gbKeypad.Name = "gbKeypad"
        Me.gbKeypad.Size = New System.Drawing.Size(268, 339)
        Me.gbKeypad.TabIndex = 20
        Me.gbKeypad.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(218, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ESC"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(15, 11)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 75)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(97, 11)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 75)
        Me.btn8.TabIndex = 2
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(179, 11)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 75)
        Me.btn9.TabIndex = 3
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(15, 92)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 75)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(97, 92)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 75)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(179, 92)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 75)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(15, 173)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 75)
        Me.btn1.TabIndex = 7
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Red
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(179, 254)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 75)
        Me.btnC.TabIndex = 12
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(97, 173)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 75)
        Me.btn2.TabIndex = 8
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(97, 254)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(75, 75)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(179, 173)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 75)
        Me.btn3.TabIndex = 9
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btnPeriod
        '
        Me.btnPeriod.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod.Location = New System.Drawing.Point(15, 254)
        Me.btnPeriod.Name = "btnPeriod"
        Me.btnPeriod.Size = New System.Drawing.Size(75, 75)
        Me.btnPeriod.TabIndex = 10
        Me.btnPeriod.Text = "."
        Me.btnPeriod.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.Black
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(289, 379)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 75)
        Me.btnVoid.TabIndex = 18
        Me.btnVoid.Text = "VOID"
        Me.btnVoid.UseVisualStyleBackColor = False
        Me.btnVoid.Visible = False
        '
        'btnCE
        '
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(418, 30)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(75, 75)
        Me.btnCE.TabIndex = 12
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'txtTrans
        '
        Me.txtTrans.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrans.Location = New System.Drawing.Point(399, 13)
        Me.txtTrans.Multiline = True
        Me.txtTrans.Name = "txtTrans"
        Me.txtTrans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTrans.Size = New System.Drawing.Size(254, 520)
        Me.txtTrans.TabIndex = 1
        Me.txtTrans.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(13, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(380, 44)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "mm/dd/yy hh:mm am/pm"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrService
        '
        Me.tmrService.Enabled = True
        '
        'tmrReader
        '
        Me.tmrReader.Enabled = True
        Me.tmrReader.Interval = 500
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtDoubleAmount)
        Me.PanelEx1.Controls.Add(Me.rtxtTrans)
        Me.PanelEx1.Controls.Add(Me.lblDate)
        Me.PanelEx1.Controls.Add(Me.txtTrans)
        Me.PanelEx1.Controls.Add(Me.grpInput)
        Me.PanelEx1.Controls.Add(Me.btnCE)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(918, 545)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 13
        '
        'txtDoubleAmount
        '
        '
        '
        '
        Me.txtDoubleAmount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDoubleAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDoubleAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtDoubleAmount.DisplayFormat = "#,##0.##"
        Me.txtDoubleAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoubleAmount.Increment = 1
        Me.txtDoubleAmount.Location = New System.Drawing.Point(19, 79)
        Me.txtDoubleAmount.Name = "txtDoubleAmount"
        Me.txtDoubleAmount.Size = New System.Drawing.Size(268, 47)
        Me.txtDoubleAmount.TabIndex = 23
        '
        'rtxtTrans
        '
        Me.rtxtTrans.Location = New System.Drawing.Point(399, 13)
        Me.rtxtTrans.Name = "rtxtTrans"
        Me.rtxtTrans.Size = New System.Drawing.Size(507, 520)
        Me.rtxtTrans.TabIndex = 13
        Me.rtxtTrans.Text = ""
        '
        'tmrVAT
        '
        Me.tmrVAT.Interval = 500
        '
        'frmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 545)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.gbKeypad.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.txtDoubleAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents txtTrans As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnCA As System.Windows.Forms.Button
    Friend WithEvents btnCE As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents tmrService As System.Windows.Forms.Timer
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents tmrReader As System.Windows.Forms.Timer
    Friend WithEvents btnSal As System.Windows.Forms.Button
    Friend WithEvents btnCharge As System.Windows.Forms.Button
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents gbKeypad As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents rtxtTrans As System.Windows.Forms.RichTextBox
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents tmrVAT As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDoubleAmount As DevComponents.Editors.DoubleInput
End Class
