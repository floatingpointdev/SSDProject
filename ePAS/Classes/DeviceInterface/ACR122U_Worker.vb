Imports SSDProject.ModWinsCard

Public Class ACR122U_Worker

    Private igRetCode As Integer
    Private igHContext As Integer
    'Private igHCard As Integer
    Private igProtocol As Integer

    Private bytgSendBuff(263) As Byte
    Private bytgRecvBuff(263) As Byte

    Private sReadersList As String

    Private igSendLen, igRecvLen, igNBytesRet, igReqType As Integer

    Private gRdrState As SCARD_READERSTATE
    Private gpioSendRequest As SCARD_IO_REQUEST

    Private _sCardUID As String
    Private _sCardUIDHex As String

    Private _sReturnValue As String

    Public Property sCardUID() As String
        Get
            Return _sCardUID
        End Get
        Set(ByVal value As String)
            _sCardUID = value
        End Set
    End Property

    Public ReadOnly Property sCardUIDHex() As String
        Get
            Return _sCardUIDHex
        End Get
    End Property

    Public ReadOnly Property sReturnValue() As String
        Get
            Return _sReturnValue
        End Get
    End Property

    Public Function Initialize() As Integer
        igRetCode = ModWinsCard.SCardEstablishContext(SCARD_SCOPE_USER, 0, 0, igHContext)

        Return igRetCode
    End Function

    Public Function GetDeviceName() As String
        Dim iDeviceCount As Integer = 255

        Dim sDeviceName As String = ""

        igRetCode = SCardListReaders(igHContext, Nothing, Nothing, iDeviceCount)

        If igRetCode <> SCARD_S_SUCCESS Then
            Return sDeviceName
        End If

        Dim iCtr As Integer

        For iCtr = 0 To 255
            sReadersList = sReadersList + vbNullChar
        Next

        igRetCode = SCardListReaders(igHContext, Nothing, sReadersList, iDeviceCount)

        If igRetCode <> SCARD_S_SUCCESS Then
            Return sDeviceName
        End If

        sDeviceName = sReadersList

        Return sDeviceName
    End Function

    Public Function CardConnect(ByVal sDeviceName As String) As Integer
        igRetCode = SCardConnect(igHContext, sDeviceName, SCARD_SHARE_SHARED, _
                                          SCARD_PROTOCOL_T0 Or SCARD_PROTOCOL_T1, igHCard, igProtocol)
        Return igRetCode
    End Function

    Public Function GetCardUID() As Integer
        ClearBuffers()
        bytgSendBuff(0) = &HFF 'Class
        bytgSendBuff(1) = &HCA 'INS
        bytgSendBuff(2) = &H0  'P1
        bytgSendBuff(3) = &H0  'P2
        bytgSendBuff(4) = &H0
        igRetCode = SendAPDU(5, 6)
        If igRetCode = 0 Then
            'sCardUID = ConvertHexToText(bytgRecvBuff, 6)
            _sCardUID = ConvertStrArrayToStr(bytgRecvBuff, 6) 'ACR122U always return a 5 byte ID            
            '_sCardUID = _sCardUID.Substring(0, 4)
            Dim oEncDec As New EncryptDecrypt_Helper
            _sCardUIDHex = oEncDec.GetHexStringFromBytes(bytgRecvBuff)
        End If
        Return igRetCode
    End Function

    Private Function ConvertHexToText(ByVal bytString As Byte(), ByVal iRecvLen As Integer) As String
        Dim sText As String = ""

        For i As Integer = 0 To iRecvLen - 1
            If Chr(bytString(i)) <> Nothing Then
                sText = sText & Chr(bytString(i))
            End If
        Next
        Return sText
    End Function

    Private Function ConvertStrArrayToStr(ByVal bytString As Byte(), ByVal iRecvLen As Integer) As String
        Dim sText As String = ""
        'get only the first 4 bytes or characters, because PCR310U and ACR122U values are the same only at the first 4 bytes
        'For i As Integer = 0 To iRecvLen - 1
        For i As Integer = 0 To 4 - 1
            If Chr(bytString(i)) <> Nothing Then
                sText = sText & bytString(i)
            End If
        Next
        Return sText
    End Function

    Public Function LoadAuthentication() As Boolean
        ClearBuffers()
        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &H82
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = &H1
        bytgSendBuff(4) = &H6
        bytgSendBuff(5) = &HFF
        bytgSendBuff(6) = &HFF
        bytgSendBuff(7) = &HFF
        bytgSendBuff(8) = &HFF
        bytgSendBuff(9) = &HFF
        bytgSendBuff(10) = &HFF
        igRetCode = SendAPDU(11, 2)
        If igRetCode = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function LoadAuthentication(ByVal sDiversifiedKey As String) As Boolean
        Dim bytDivKey(5) As Byte

        Dim iCount As Integer = 0
        For iIndex As Integer = 0 To 10 Step 2
            bytDivKey(iCount) = CByte("&H" + sDiversifiedKey.Substring(iIndex, 2))
            iCount += 1
        Next


        ClearBuffers()
        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &H82
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = &H1
        bytgSendBuff(4) = &H6
        bytgSendBuff(5) = bytDivKey(0)
        bytgSendBuff(6) = bytDivKey(1)
        bytgSendBuff(7) = bytDivKey(2)
        bytgSendBuff(8) = bytDivKey(3)
        bytgSendBuff(9) = bytDivKey(4)
        bytgSendBuff(10) = bytDivKey(5)
        igRetCode = SendAPDU(11, 2)

        If igRetCode = 0 Then
            Return True
        End If
        Return False

    End Function

    Public Function ReadBlock(ByVal iBlock As Integer) As Integer
        'NOTE:  Each Sector has 3 Blocks except for Sector 0
        '       Sector 0 is assigned to UserID, but will not consume 2 blocks because of its length
        '       The rest of the sectors will occupy a field (3 blocks), so, this function should
        '       automate the reading from those blocks if the length of the string to be read exceeds
        '       16 bytes for each block
        '---------------------------------------First 16 bytes---------------------------------------
        _sReturnValue = ""
        ClearBuffers()

        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HB0
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + iBlock.ToString("X"))
        bytgSendBuff(4) = &H10

        igRetCode = SendAPDU(5, 18)

        If igRetCode <> 0 Then Return igRetCode 'prevent further reading

        For i As Integer = 0 To 15
            _sReturnValue += Hex2Text(bytgRecvBuff(i))
        Next

        '---------------------------------------Second 16 bytes--------------------------------------
        ClearBuffers()

        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HB0
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + (iBlock + 1).ToString("X"))
        bytgSendBuff(4) = &H10

        igRetCode = SendAPDU(5, 18)

        If igRetCode <> 0 Then Return igRetCode 'prevent further reading

        For i As Integer = 0 To 15
            _sReturnValue += Chr(bytgRecvBuff(i))
        Next

        '---------------------------------------Third 16 bytes---------------------------------------
        If iBlock > 1 Then
            ClearBuffers()

            bytgSendBuff(0) = &HFF
            bytgSendBuff(1) = &HB0
            bytgSendBuff(2) = &H0
            bytgSendBuff(3) = CByte("&H" + (iBlock + 2).ToString("X"))
            bytgSendBuff(4) = &H10

            igRetCode = SendAPDU(5, 18)
            If igRetCode = 0 Then
                For i As Integer = 0 To 15
                    _sReturnValue += Chr(bytgRecvBuff(i))
                Next
            End If
        End If
        Return igRetCode
    End Function

    Public Function WriteBlock(ByVal iBlock As Integer, ByVal sData As String) As Integer
        'NOTE:  Each Sector has 3 Blocks except for Sector 0
        '       Sector 0 is assigned to UserID, but will not consume 2 blocks becuase of its length
        '       The rest of the sectors will occupy a field (3 blocks), so, this function should
        '       automate the writing to those blocks if the length of the string to be written exceeds
        '       16 bytes for each block
        '---------------------------------------First 16 bytes---------------------------------------
        ClearBuffers()

        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HD6
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + iBlock.ToString("X"))
        bytgSendBuff(4) = &H10 '16 bytes

        'convert the data to hex string
        sData = sData.PadRight(48, Nothing)
        For i As Integer = 0 To 15 'sData.Length - 1
            bytgSendBuff(5 + i) = Asc(Mid(sData, i + 1, 1))
        Next

        igRetCode = SendAPDU(21, 2)

        If igRetCode <> 0 Then Return igRetCode 'prevent further writing on error

        '---------------------------------------Second 16 bytes--------------------------------------
        ClearBuffers()

        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HD6
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + (iBlock + 1).ToString("X"))
        bytgSendBuff(4) = &H10 '16 bytes

        'convert the data to hex string
        For i As Integer = 0 To 15
            bytgSendBuff(5 + i) = Asc(Mid(sData, i + 17, 1))
        Next

        igRetCode = SendAPDU(21, 2)

        If igRetCode <> 0 Then Return igRetCode 'prevent further writing on error

        '---------------------------------------Third 16 bytes---------------------------------------
        If iBlock > 1 Then
            ClearBuffers()

            bytgSendBuff(0) = &HFF
            bytgSendBuff(1) = &HD6
            bytgSendBuff(2) = &H0
            bytgSendBuff(3) = CByte("&H" + (iBlock + 2).ToString("X"))
            bytgSendBuff(4) = &H10 '16 bytes

            'convert the data to hex string
            For i As Integer = 0 To 15
                bytgSendBuff(5 + i) = Asc(Mid(sData, i + 33, 1))
            Next

            igRetCode = SendAPDU(21, 2)
        End If

        Return igRetCode

    End Function

    Public Function WriteSingleBlock(ByVal iBlock As Integer, ByVal sData As String) As Integer
        ClearBuffers()

        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HD6
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + iBlock.ToString("X"))
        bytgSendBuff(4) = &H10 '16 bytes

        'convert the data to hex string
        sData = sData.PadRight(16, Nothing)
        For i As Integer = 0 To 15
            bytgSendBuff(5 + i) = Asc(Mid(sData, i + 1, 1))
        Next

        igRetCode = SendAPDU(21, 2)

        If igRetCode <> 0 Then Return igRetCode
    End Function

    Public Function FormatSector(ByVal iSectorInDec As Integer, ByVal sKey As String, ByVal sAccessBits As String) As Integer
        'Command        Key A                Bits     Key B
        'FF D6 00 3B 10 FF FF FF FF FF FF FF 07 80 69 FF FF FF FF FF FF
        bytgSendBuff(0) = &HFF
        bytgSendBuff(1) = &HD6
        bytgSendBuff(2) = &H0
        bytgSendBuff(3) = CByte("&H" + iSectorInDec.ToString("X"))
        bytgSendBuff(4) = &H10 '16 bytes

    End Function

    Public Function AuthenticateBlock(ByVal iBlock As Integer, ByVal iKeyType As Integer, ByVal iLocation As Integer) As Integer
        ClearBuffers()
        ' <-    command   -> |
        'FF 86 00 00 05 01 00 04 60 00 - Block 4, Type A
        'FF 86 00 00 05 01 00 04 60 01 - Block 4, Type A, Location 1
        'FF 86 00 00 05 01 00 04 61 00 - Block 4, Type B
        'FF 86 00 00 05 01 00 03 60 00 - Block 3, Type A

        bytgSendBuff(0) = &HFF                              ' Class
        bytgSendBuff(1) = &H86                              ' INS
        bytgSendBuff(2) = &H0                               ' P1
        bytgSendBuff(3) = &H0                               ' P2
        bytgSendBuff(4) = &H5                               ' Lc
        bytgSendBuff(5) = &H1                               ' Byte 1 : Version number
        bytgSendBuff(6) = &H0                               ' Byte 2
        bytgSendBuff(7) = CByte("&H" + iBlock.ToString("X"))              ' Byte 3 : Block number

        If (iKeyType = 0) Then
            bytgSendBuff(8) = &H60
        ElseIf iKeyType = 1 Then
            bytgSendBuff(8) = &H61
        End If

        bytgSendBuff(9) = iLocation.ToString("X")

        igRetCode = SendAPDU(10, 2)

        If igRetCode = 0 Then
            Return True
        End If
        Return False

    End Function

    Public Function ValWrite(ByVal iAmt As Long, ByVal iBlk As Integer) As Boolean

        Dim indx As Integer
        Dim tmpStr As String = ""

        If iAmt > 4294967295 Then
            Return False
        End If

        Call ClearBuffers()
        bytgSendBuff(0) = &HFF                                      ' CLA
        bytgSendBuff(1) = &HD7                                      ' INS
        bytgSendBuff(2) = &H0                                       ' P1
        bytgSendBuff(3) = CByte("&H" + iBlk.ToString("X"))          ' P2 : Block No.    
        bytgSendBuff(4) = &H5                                       ' Lc : Data length
        bytgSendBuff(5) = &H0                                       ' VB_OP Value
        bytgSendBuff(6) = (iAmt >> 24) And &HFF                   ' Amount MSByte
        bytgSendBuff(7) = (iAmt >> 16) And &HFF                   ' Amount middle byte
        bytgSendBuff(8) = (iAmt >> 8) And &HFF                    ' Amount middle byte
        bytgSendBuff(9) = iAmt And &HFF                           ' Amount LSByte

        igRetCode = SendAPDU(10, 2)
        If igRetCode <> ModWinsCard.SCARD_S_SUCCESS Then
            Return False
        Else
            For indx = 0 To 1
                tmpStr = tmpStr + Microsoft.VisualBasic.Right("00" & Hex(bytgRecvBuff(indx)), 2) + " "
            Next indx

            'Check for response
            If tmpStr.Trim <> "90 00" Then
                Return False
            Else
                Return True
            End If
        End If


    End Function

    Public Function ValIncrement(ByVal iAmt As Long, ByVal iBlk As Integer) As Boolean

        Dim indx As Integer
        Dim tmpStr As String = ""

        If iAmt > 4294967295 Then
            Return False
        End If

        ClearBuffers()
        bytgSendBuff(0) = &HFF                                  ' CLA
        bytgSendBuff(1) = &HD7                                  ' INS
        bytgSendBuff(2) = &H0                                   ' P1
        bytgSendBuff(3) = CByte("&H" + iBlk.ToString("X"))      ' P2 : Block No.
        bytgSendBuff(4) = &H5                                   ' Lc : Data length
        bytgSendBuff(5) = &H1                                   ' VB_OP Value
        bytgSendBuff(6) = (iAmt >> 24) And &HFF                 ' Amount MSByte
        bytgSendBuff(7) = (iAmt >> 16) And &HFF                 ' Amount middle byte
        bytgSendBuff(8) = (iAmt >> 8) And &HFF                  ' Amount middle byte
        bytgSendBuff(9) = iAmt And &HFF                         ' Amount LSByte

        igRetCode = SendAPDU(10, 2)
        If igRetCode <> ModWinsCard.SCARD_S_SUCCESS Then
            Return False
        Else
            For indx = 0 To 1
                tmpStr = tmpStr + Microsoft.VisualBasic.Right("00" & Hex(bytgRecvBuff(indx)), 2) + " "
            Next indx

            'Check for response            
            If tmpStr.Trim <> "90 00" Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function ValDecrement(ByVal iAmt As Long, ByVal iBlk As Integer) As Boolean

        Dim indx As Integer
        Dim tmpStr As String = ""

        If iAmt > 4294967295 Then
            Return False
        End If

        ClearBuffers()
        bytgSendBuff(0) = &HFF                                  ' CLA
        bytgSendBuff(1) = &HD7                                  ' INS
        bytgSendBuff(2) = &H0                                   ' P1
        bytgSendBuff(3) = CByte("&H" + iBlk.ToString("X"))      ' P2 : Block No.
        bytgSendBuff(4) = &H5                                   ' Lc : Data length
        bytgSendBuff(5) = &H2                                   ' VB_OP Value
        bytgSendBuff(6) = (iAmt >> 24) And &HFF                 ' Amount MSByte
        bytgSendBuff(7) = (iAmt >> 16) And &HFF                 ' Amount middle byte
        bytgSendBuff(8) = (iAmt >> 8) And &HFF                  ' Amount middle byte
        bytgSendBuff(9) = iAmt And &HFF                         ' Amount LSByte

        igRetCode = SendAPDU(10, 2)
        If igRetCode <> ModWinsCard.SCARD_S_SUCCESS Then
            Return False
        Else
            For indx = 0 To 1
                tmpStr = tmpStr + Microsoft.VisualBasic.Right("00" & Hex(bytgRecvBuff(indx)), 2) + " "
            Next indx

            'Check for response            
            If tmpStr.Trim <> "90 00" Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function ValRead(ByVal iBlk As Integer) As Long

        Dim indx As Integer
        Dim tmpStr As String = ""
        Dim iTmpAmt As Long

        ClearBuffers()
        bytgSendBuff(0) = &HFF                                  ' CLA
        bytgSendBuff(1) = &HB1                                  ' INS
        bytgSendBuff(2) = &H0                                   ' P1
        bytgSendBuff(3) = CByte("&H" + iBlk.ToString("X"))      ' P2 : Block No.
        bytgSendBuff(4) = &H4

        igRetCode = SendAPDU(5, 6)
        If igRetCode <> ModWinsCard.SCARD_S_SUCCESS Then
            Return False
        Else
            For indx = 4 To 5
                tmpStr = tmpStr + Microsoft.VisualBasic.Right("00" & Hex(bytgRecvBuff(indx)), 2) + " "
            Next indx

            'Check for response            
            If tmpStr.Trim <> "90 00" Then
                Return False
            Else
                Try
                    iTmpAmt = bytgRecvBuff(3)
                    iTmpAmt = iTmpAmt + (bytgRecvBuff(2) * 256)
                    iTmpAmt = iTmpAmt + (bytgRecvBuff(1) * 256 * 256)
                    iTmpAmt = iTmpAmt + (bytgRecvBuff(0) * 256 * 256 * 256)
                    Return CLng(iTmpAmt)
                Catch ex As Exception
                    Return 0
                End Try
            End If
        End If

    End Function

    Private Sub ClearBuffers()
        For lIndex As Integer = 0 To 262
            bytgRecvBuff(lIndex) = &H0
            bytgSendBuff(lIndex) = &H0
        Next
    End Sub

    Public Function SendAPDU(ByVal iSendLen As Integer, ByVal iRecvLen As Integer) As Integer
        gpioSendRequest.dwProtocol = igProtocol
        gpioSendRequest.cbPciLength = Len(gpioSendRequest)

        igRetCode = SCardTransmit(igHCard, gpioSendRequest, bytgSendBuff(0), iSendLen, gpioSendRequest, bytgRecvBuff(0), iRecvLen)

        If bytgRecvBuff(0).ToString("X") <> "90" And iRecvLen = 2 Then
            igRetCode = -1
        End If
        Return igRetCode
    End Function


    Public Function Hex2Text(ByVal sHex As Byte) As String
        Return Chr(sHex)
    End Function

End Class
