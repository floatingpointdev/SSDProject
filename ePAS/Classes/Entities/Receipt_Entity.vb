'' Modified by : Ryan Vincent Lao
'' Modified Date : 7/6/2011
'' Change Log :
''      Added dTransDate for Transaction Date
''      Added iCashBal for Casr card balance

Public Class Receipt_Entity
    Private _sCashierName As String
    Private _iCashierNo As Integer
    Private _sPrinterName As String
    Private _dTotal As Double
    Private _dSubTotal As Double
    Private _dCash As Double
    Private _dChange As Double
    Private _sCardNo As String
    Private _dtCardExpiry As String
    Private _sCardType As String
    Private _iUsedPts As Integer
    Private _iUsedCash As Integer
    Private _iCashBal As Integer
    Private _sMode As String
    Private _sCustomerCode As String
    Private _dTransDate As Date
    Private _iQtyTot As Integer

    Public Property sCashierName() As String
        Get
            Return _sCashierName
        End Get
        Set(ByVal value As String)
            _sCashierName = value
        End Set
    End Property

    Public Property iCashierNo() As Integer
        Get
            Return _iCashierNo
        End Get
        Set(ByVal value As Integer)
            _iCashierNo = value
        End Set
    End Property

    Public Property sPrinterName() As String
        Get
            Return _sPrinterName
        End Get
        Set(ByVal value As String)
            _sPrinterName = value
        End Set
    End Property

    Public Property dSubTotal() As Double
        Get
            Return _dSubTotal
        End Get
        Set(ByVal value As Double)
            _dSubTotal = value
        End Set
    End Property

    Public Property dTotal() As Double
        Get
            Return _dTotal
        End Get
        Set(ByVal value As Double)
            _dTotal = value
        End Set
    End Property

    Public Property dCash() As Double
        Get
            Return _dCash
        End Get
        Set(ByVal value As Double)
            _dCash = value
        End Set
    End Property

    Public Property dChange() As Double
        Get
            Return _dChange
        End Get
        Set(ByVal value As Double)
            _dChange = value
        End Set
    End Property

    Public Property sCardNo() As String
        Get
            Return _sCardNo
        End Get
        Set(ByVal value As String)
            _sCardNo = value
        End Set
    End Property

    Public Property dtCardExpiry() As String
        Get
            Return _dtCardExpiry
        End Get
        Set(ByVal value As String)
            _dtCardExpiry = value
        End Set
    End Property

    Public Property sCardType() As String
        Get
            Return _sCardType
        End Get
        Set(ByVal value As String)
            _sCardType = value
        End Set
    End Property

    Public Property iUsedPts() As Integer
        Get
            Return _iUsedPts
        End Get
        Set(ByVal value As Integer)
            _iUsedPts = value
        End Set
    End Property

    Public Property iUsedCash() As Integer
        Get
            Return _iUsedCash
        End Get
        Set(ByVal value As Integer)
            _iUsedCash = value
        End Set
    End Property

    Public Property iCashBal() As Integer
        Get
            Return _iCashBal
        End Get
        Set(ByVal value As Integer)
            _iCashBal = value
        End Set
    End Property

    Public Property sMode() As String
        Get
            Return _sMode
        End Get
        Set(ByVal value As String)
            _sMode = value
        End Set
    End Property

    Public Property sCustomerCode() As String
        Get
            Return _sCustomerCode
        End Get
        Set(ByVal value As String)
            _sCustomerCode = value
        End Set
    End Property

    Public Property dTransDate() As Date
        Get
            Return _dTransDate
        End Get
        Set(ByVal value As Date)
            _dTransDate = value
        End Set
    End Property

    Public Property iQtyTot() As Integer
        Get
            Return _iQtyTot
        End Get
        Set(ByVal value As Integer)
            _iQtyTot = value
        End Set
    End Property

End Class
