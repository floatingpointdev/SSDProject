Public Class frmLoadingScreen

#Region "Move"
    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Private Sub picLoad_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLoad.MouseDown, pnlLoad.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub picLoad_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLoad.MouseUp, pnlLoad.MouseDown
        drag = False
    End Sub

    Private Sub picLoad_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLoad.MouseMove, pnlLoad.MouseDown
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
#End Region

End Class