<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadingScreen
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
        Me.picLoad = New System.Windows.Forms.PictureBox
        Me.pnlLoad = New System.Windows.Forms.Panel
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLoad
        '
        Me.picLoad.BackColor = System.Drawing.Color.LightPink
        Me.picLoad.ErrorImage = Nothing
        Me.picLoad.Image = Global.SSDProject.My.Resources.Resources.loading_final_
        Me.picLoad.InitialImage = Nothing
        Me.picLoad.Location = New System.Drawing.Point(23, 37)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(292, 136)
        Me.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoad.TabIndex = 0
        Me.picLoad.TabStop = False
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.LightPink
        Me.pnlLoad.Controls.Add(Me.picLoad)
        Me.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoad.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(346, 206)
        Me.pnlLoad.TabIndex = 0
        '
        'frmLoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(346, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLoad)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadingScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingScreen"
        Me.TransparencyKey = System.Drawing.Color.LightPink
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLoad As System.Windows.Forms.PictureBox
    Friend WithEvents pnlLoad As System.Windows.Forms.Panel
End Class
