'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''CHANGE LOG:                                                                                            ''
''  Changed receipt output folder to AppStartupPath\Receipts\*.txt                                              
''Latest Modification by:                                                                                ''
''  RVL
''Latest Modified date:                                                                                  ''
''  10/05/11
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class RawPrinterHelper
    Private oLog As New Transaction_Entity

    Public Sub PrintReceipt(ByVal oReceiptEntity As Receipt_Entity)
        'oLog.sCustomerCode = oReceiptEntity.sCustomerCode
        oLog.dTransDate = oReceiptEntity.dTransDate
        Dim sPattern(20) As String
        Dim iPatIndex As Integer = 0
        Dim dtP As DataTable = oSQLLogs.GetLogsByCardID(oLog)
        Dim iQtyTotal As Integer = 0
        For i As Integer = 0 To dtP.Rows.Count - 1
            iQtyTotal += dtP.Rows(i)("Qty")
        Next
        Dim s As String = ""

        sPattern(0) = "         SmartCard Technik Inc."
        sPattern(iPatIndex + 1) = "     San Antonio Village, Makati City"
        sPattern(iPatIndex + 2) = "CASHIER : CASHIENAME     #CaNO"
        sPattern(iPatIndex + 3) = Date.Now.ToString("d") & "                " & Date.Now.ToString("hh:mm tt")
        sPattern(iPatIndex + 4) = "OR#" & dtP.Rows(0)("TID").ToString.PadLeft(9, "0")
        sPattern(iPatIndex + 5) = "-".PadLeft(40, "-")
        sPattern(iPatIndex + 6) = "  Qty Item Desc          Price   Amount"
        sPattern(iPatIndex + 7) = "-".PadLeft(40, "-")
        sPattern(iPatIndex + 8) = "00QTY ITEMDESCRIPTION  PRICE00  AMOUNT0"
        sPattern(iPatIndex + 9) = "-".PadLeft(40, "-")
        sPattern(iPatIndex + 10) = "SUBTOTAL                  " & "Php " & oReceiptEntity.dSubTotal.ToString.PadLeft(10, " ")
        sPattern(iPatIndex + 11) = "Used Loyalty Amt              " & oReceiptEntity.iUsedPts.ToString.PadLeft(10, " ")
        sPattern(iPatIndex + 12) = "TOTAL                     " & "Php " & oReceiptEntity.dTotal.ToString.PadLeft(10, " ")
        'DONE: loyalty and modes of payment
        Select Case oReceiptEntity.sMode
            Case "Cash"
                sPattern(iPatIndex + 13) = "    CASH                  " & "Php " & oReceiptEntity.dCash.ToString.PadLeft(10, " ")
                sPattern(iPatIndex + 14) = "-".PadLeft(40, "-")
                sPattern(iPatIndex + 15) = "  CHANGE                  " & "Php " & oReceiptEntity.dChange.ToString.PadLeft(10, " ")
                'Case "Credit"
                '    spattern(iPatIndex +13) = "Card No. : " & oReceiptEntity.sCardNo
                '    spattern(iPatIndex +14) = "Card Expiry : " & oReceiptEntity.dtCardExpiry
                '    spattern(iPatIndex +15) = "Card Type : " & oReceiptEntity.sCardType
            Case "Cash Card"
                'DONE: Cash Card
                sPattern(iPatIndex + 13) = "Cash Card : " & oReceiptEntity.iUsedCash
                sPattern(iPatIndex + 14) = "Balance   : " & oReceiptEntity.iCashBal
        End Select

        sPattern(iPatIndex + 16) = "Total No. of Items : " & iQtyTotal
        sPattern(iPatIndex + 17) = "           OFFICIAL RECEIPT"

        For i As Integer = 0 To sPattern.Length - 1
            If i = 2 Then
                sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("CASHIENAME", oReceiptEntity.sCashierName.PadRight(10, " "))
                sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("CaNO", oReceiptEntity.iCashierNo.ToString.PadLeft(4, "0"))
            ElseIf i = 8 Then
                For j As Integer = 0 To dtP.Rows.Count - 1
                    sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("00QTY", dtP.Rows(j)("Qty").ToString.PadLeft(5, " "))
                    sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("ITEMDESCRIPTION", dtP.Rows(j)("ItemCode").ToString.PadRight(15, " "))
                    sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("PRICE00", dtP.Rows(j)("Price").ToString.PadLeft(7, " "))
                    sPattern(iPatIndex + i) = sPattern(iPatIndex + i).Replace("AMOUNT0", dtP.Rows(j)("Amt").ToString.PadLeft(7, " "))
                    s &= sPattern(iPatIndex + i) & vbCrLf
                    sPattern(iPatIndex + 8) = "00QTY ITEMDESCRIPTION  PRICE00  AMOUNT0"
                Next
                i += 1
            End If
            s &= sPattern(iPatIndex + i) & vbCrLf
            If i = 16 Then
                s &= vbCrLf
            ElseIf i = 17 Then
                s &= vbCrLf & vbCrLf & vbCrLf
            End If
        Next
        RawPrinterHelper.SendStringToPrinter(oReceiptEntity.sPrinterName, s)
        Dim sPath As String = Application.StartupPath & "\Receipts\Print" & Date.Now.ToString("hhmmss") & ".txt"
        Dim sw As New IO.StreamWriter(sPath)
        sw.WriteLine(s)
        sw.Close()
        sw.Dispose()
        Process.Start(sPath)
    End Sub

    ' Structure and API declarions:
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function
    <DllImport("kernel32.dll", EntryPoint:="GetLastError", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetLastError() As Int32
    End Function

    ' SendBytesToPrinter()
    ' When the function is given a printer name and an unmanaged array of  
    ' bytes, the function sends those bytes to the print queue.
    ' Returns True on success or False on failure.
    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Dim hPrinter As IntPtr          ' The printer handle.
        Dim dwError As Int32            ' Last error - in case there was trouble.
        Dim di As DOCINFOW = Nothing    ' Describes your document (name, port, data type).
        Dim dwWritten As Int32          ' The number of bytes written by WritePrinter().
        Dim bSuccess As Boolean         ' Your success code.

        ' Set up the DOCINFO structure.
        With di
            .pDocName = "My Visual Basic .NET RAW Document"
            .pDataType = "RAW"
        End With
        ' Assume failure unless you specifically succeed.
        bSuccess = False
        If OpenPrinter(szPrinterName, hPrinter, 0) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then
                    ' Write your printer-specific bytes to the printer.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)
                End If
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        ' If you did not succeed, GetLastError may give more information
        ' about why not.
        If bSuccess = False Then
            dwError = GetLastError()
        End If
        Return bSuccess
    End Function ' SendBytesToPrinter()

    ' SendFileToPrinter()
    ' When the function is given a file name and a printer name, 
    ' the function reads the contents of the file and sends the
    ' contents to the printer.
    ' Presumes that the file contains printer-ready data.
    ' Shows how to use the SendBytesToPrinter function.
    ' Returns True on success or False on failure.
    Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        ' Open the file.
        Dim fs As New FileStream(szFileName, FileMode.Open)
        ' Create a BinaryReader on the file.
        Dim br As New BinaryReader(fs)
        ' Dim an array of bytes large enough to hold the file's contents.
        Dim bytes(fs.Length) As Byte
        Dim bSuccess As Boolean
        ' Your unmanaged pointer
        Dim pUnmanagedBytes As IntPtr

        ' Read the contents of the file into the array.
        bytes = br.ReadBytes(fs.Length)
        ' Allocate some unmanaged memory for those bytes.
        pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
        ' Copy the managed byte array into the unmanaged array.
        Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
        ' Send the unmanaged bytes to the printer.
        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
        ' Free the unmanaged memory that you allocated earlier.
        Marshal.FreeCoTaskMem(pUnmanagedBytes)
        Return bSuccess
    End Function ' SendFileToPrinter()

    ' When the function is given a string and a printer name,
    ' the function sends the string to the printer as raw bytes.
    Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
        Dim bSucc As Boolean
        Dim pBytes As IntPtr
        Dim dwCount As Int32
        ' How many characters are in the string?
        dwCount = szString.Length()
        ' Assume that the printer is expecting ANSI text, and then convert
        ' the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        ' Send the converted ANSI string to the printer.
        bSucc = SendBytesToPrinter(szPrinterName, pBytes, dwCount)
        Marshal.FreeCoTaskMem(pBytes)
        Return bSucc
    End Function

End Class
