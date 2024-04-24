Public Class SerialPort_Worker
    Private COMPort As New IO.Ports.SerialPort

    Public Function SendData(ByVal sData As String, ByVal sCOMPort As String, ByVal sBaudRate As String) As Boolean
        COMPort.PortName = sCOMPort
        COMPort.BaudRate = Int(sBaudRate)
        If COMPort.IsOpen Then COMPort.Close()
        Try
            COMPort.Open()
            COMPort.Write(sData)
            COMPort.Write(Chr(&H1D) + "V" + Chr(66) + Chr(0)) 'Feed and Cut
            COMPort.Close()
            Return True
        Catch ex As Exception
            COMPort.Close()
            Return False
        End Try
        COMPort.Close()
        Return True
    End Function
End Class
