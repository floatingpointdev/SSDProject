<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
        Me.crvDTR = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.picLoading = New System.Windows.Forms.PictureBox
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvDTR
        '
        Me.crvDTR.ActiveViewIndex = -1
        Me.crvDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvDTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvDTR.Location = New System.Drawing.Point(0, 0)
        Me.crvDTR.Name = "crvDTR"
        Me.crvDTR.SelectionFormula = ""
        Me.crvDTR.ShowGroupTreeButton = False
        Me.crvDTR.Size = New System.Drawing.Size(758, 525)
        Me.crvDTR.TabIndex = 0
        Me.crvDTR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvDTR.ViewTimeSelectionFormula = ""
        '
        'picLoading
        '
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(113, 103)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(66, 66)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLoading.TabIndex = 5
        Me.picLoading.TabStop = False
        Me.picLoading.Visible = False
        Me.picLoading.WaitOnLoad = True
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 525)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.crvDTR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvDTR As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Private WithEvents picLoading As System.Windows.Forms.PictureBox
End Class
