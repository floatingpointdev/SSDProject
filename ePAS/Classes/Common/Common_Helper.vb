Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Threading


Public Class Common_Helper

    Public Sub ErrorBox(ByVal sErrMsg As String, Optional ByVal sTitle As String = "Error")
        MessageBox.Show(sErrMsg, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub ShowBox(ByVal ConfirmMsg As String, Optional ByVal sTitle As String = "Success")
        MessageBox.Show(ConfirmMsg, sTitle, MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Public Function QBox(ByVal Msg As String, ByVal hdr As String)
        Return MessageBox.Show(Msg, hdr, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Public Sub SetCenterPosition(ByVal oObj As Windows.Forms.Form)
        oObj.Top = (Program.lMDIParentHeight / 2) - (oObj.Height / 2) - 34 '24 is menu height
        oObj.Left = (Program.lMDIParentWidth / 2) - (oObj.Width / 2)
    End Sub

    Public Sub setCursor(ByVal oFrm As Form, ByVal curVal As Cursor)
        For Each oControl As Control In GetChildControls(oFrm, Nothing)
            oControl.Cursor = curVal
        Next
    End Sub

    Private Function GetChildControls(ByVal ctrl As Control, ByVal ctrlType As Type) As Control()
        Dim controls As ArrayList = New ArrayList()

        For Each c As Control In ctrl.Controls
            If (ctrlType Is Nothing) Then
                controls.Add(c)
                controls.AddRange(GetChildControls(c, Nothing))
            Else
                If ctrlType.IsAssignableFrom(c.GetType()) Then
                    controls.Add(c)
                    controls.AddRange(GetChildControls(c, Nothing))
                End If
            End If
        Next

        Return CType(controls.ToArray(GetType(Control)), Control())
    End Function

    Public Sub SetFormFocus(ByVal frm As Form)
        frm.Activate()
        frm.TopMost = True
        frm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Public Function GetHexStrOfStr(ByVal sString As String) As String
        Dim sTemp As String = ""
        For i As Integer = 0 To sString.Length - 1
            sTemp = sTemp + Asc(sString.Substring(i, 1)).ToString("X2")
        Next
        Return sTemp
    End Function

    Public Function ImageToByte(ByVal pbImage As Image) As Byte()
        Dim ms = New System.IO.MemoryStream()
        pbImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function ByteToImage(ByVal byt() As Byte) As Image
        Dim ms As New System.IO.MemoryStream(byt)
        Return Image.FromStream(ms)
    End Function

    Public Sub SetDateFormat()
        Dim newCulture As CultureInfo = DirectCast(System.Threading.Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)
        newCulture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
        newCulture.DateTimeFormat.DateSeparator = "-"
        Thread.CurrentThread.CurrentCulture = newCulture
    End Sub
End Class
