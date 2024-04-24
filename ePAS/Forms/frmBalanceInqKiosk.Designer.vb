<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceInqKiosk
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceInqKiosk))
        Me.dgvLogs = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTransDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCIMNo = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtCA = New System.Windows.Forms.TextBox
        Me.txtSalaryDeduction = New System.Windows.Forms.TextBox
        Me.tmrReader = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.pbStatus = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLogs
        '
        Me.dgvLogs.AllowUserToAddRows = False
        Me.dgvLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colTransType, Me.colTransDate, Me.colLocation, Me.colAmount, Me.colRemarks})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogs.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLogs.Location = New System.Drawing.Point(12, 100)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.RowHeadersVisible = False
        Me.dgvLogs.Size = New System.Drawing.Size(677, 536)
        Me.dgvLogs.TabIndex = 8
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colTransType
        '
        Me.colTransType.DataPropertyName = "TransType"
        Me.colTransType.HeaderText = "TransType"
        Me.colTransType.Name = "colTransType"
        Me.colTransType.ReadOnly = True
        '
        'colTransDate
        '
        Me.colTransDate.DataPropertyName = "TransDate"
        Me.colTransDate.HeaderText = "Date"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.ReadOnly = True
        Me.colTransDate.Width = 150
        '
        'colLocation
        '
        Me.colLocation.DataPropertyName = "Location"
        Me.colLocation.HeaderText = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.ReadOnly = True
        Me.colLocation.Width = 200
        '
        'colAmount
        '
        Me.colAmount.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.DataPropertyName = "Remarks"
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        Me.colRemarks.Width = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Member ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(351, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CA Balance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "AR Balance:"
        '
        'txtCIMNo
        '
        Me.txtCIMNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCIMNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIMNo.Location = New System.Drawing.Point(114, 10)
        Me.txtCIMNo.Name = "txtCIMNo"
        Me.txtCIMNo.Size = New System.Drawing.Size(195, 24)
        Me.txtCIMNo.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(114, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(195, 24)
        Me.txtName.TabIndex = 3
        '
        'txtCA
        '
        Me.txtCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCA.Location = New System.Drawing.Point(459, 10)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.ReadOnly = True
        Me.txtCA.Size = New System.Drawing.Size(230, 24)
        Me.txtCA.TabIndex = 5
        Me.txtCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalaryDeduction
        '
        Me.txtSalaryDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalaryDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaryDeduction.Location = New System.Drawing.Point(459, 37)
        Me.txtSalaryDeduction.Name = "txtSalaryDeduction"
        Me.txtSalaryDeduction.ReadOnly = True
        Me.txtSalaryDeduction.Size = New System.Drawing.Size(230, 24)
        Me.txtSalaryDeduction.TabIndex = 7
        Me.txtSalaryDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tmrReader
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Transaction History:"
        '
        'pbStatus
        '
        '
        '
        '
        Me.pbStatus.BackgroundStyle.Class = ""
        Me.pbStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbStatus.Location = New System.Drawing.Point(12, 642)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee
        Me.pbStatus.Size = New System.Drawing.Size(677, 39)
        Me.pbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.pbStatus.TabIndex = 10
        Me.pbStatus.Text = "Service Running"
        Me.pbStatus.TextVisible = True
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(35, 35)
        Me.btnPrint.Location = New System.Drawing.Point(589, 643)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnPrint.Size = New System.Drawing.Size(100, 36)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Visible = False
        '
        'frmBalanceInqKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 681)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSalaryDeduction)
        Me.Controls.Add(Me.txtCA)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCIMNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLogs)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBalanceInqKiosk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Inquiry Kiosk"
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLogs As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCIMNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCA As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryDeduction As System.Windows.Forms.TextBox
    Friend WithEvents tmrReader As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbStatus As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
End Class
