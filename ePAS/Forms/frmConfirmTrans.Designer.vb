<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmTrans
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRefCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnYes = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.lblDetails = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please confirm transaction.  Continue?"
        '
        'txtRefCode
        '
        Me.txtRefCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefCode.Location = New System.Drawing.Point(211, 162)
        Me.txtRefCode.Name = "txtRefCode"
        Me.txtRefCode.Size = New System.Drawing.Size(216, 26)
        Me.txtRefCode.TabIndex = 1
        Me.txtRefCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(228, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&POS Receipt Number:"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(552, 13)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 75)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Red
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(552, 119)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 75)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblDetails
        '
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.Color.White
        Me.lblDetails.Location = New System.Drawing.Point(35, 45)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(490, 78)
        Me.lblDetails.TabIndex = 17
        '
        'frmConfirmTrans
        '
        Me.AcceptButton = Me.btnYes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SSDProject.My.Resources.Resources.BACKGROUND_DESIGN
        Me.CancelButton = Me.btnNo
        Me.ClientSize = New System.Drawing.Size(639, 208)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRefCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConfirmTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm Transaction"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRefCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblDetails As System.Windows.Forms.Label
End Class
