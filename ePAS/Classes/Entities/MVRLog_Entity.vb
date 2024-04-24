Public Class MVRLog_Entity
    Private _iID As Integer
    Private _sTransCode As String
    Private _dtTransDate As Date
    Private _sMemberID As String
    Private _sCardID As String
    Private _sCompanyCode As String
    Private _sSite As String
    Private _sLocation As String
    Private _dPrevBalance As Double
    Private _dAmount As Double
    Private _dNewBalance As Double
    Private _sUser As String
    Private _dtDateAdded As Date
    Private _dtDateUpdated As Date
    Private _dtDateUploaded As Date
    Private _sRemarks As String
    Private _sIPAddress As String
    Private _sHostName As String
    Private _sTransType As String
    Private _iRefID As Integer
    Private _sPOSRefCode As String


    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
        End Set
    End Property

    Public Property sTransCode() As String
        Get
            Return _sTransCode
        End Get
        Set(ByVal value As String)
            _sTransCode = value
        End Set
    End Property
    Public Property dtTransDate() As Date
        Get
            Return _dtTransDate
        End Get
        Set(ByVal value As Date)
            _dtTransDate = value
        End Set
    End Property

    Public Property sMemberID() As String
        Get
            Return _sMemberID
        End Get
        Set(ByVal value As String)
            _sMemberID = value
        End Set
    End Property

    Public Property sCardID() As String
        Get
            Return _sCardID
        End Get
        Set(ByVal value As String)
            _sCardID = value
        End Set
    End Property

    Public Property sSite() As String
        Get
            Return _sSite
        End Get
        Set(ByVal value As String)
            _sSite = value
        End Set
    End Property

    Public Property sLocation() As String
        Get
            Return _sLocation
        End Get
        Set(ByVal value As String)
            _sLocation = value
        End Set
    End Property

    Public Property sCompanyCode() As String
        Get
            Return _sCompanyCode
        End Get
        Set(ByVal value As String)
            _sCompanyCode = value
        End Set
    End Property

    Public Property dPrevBalance() As Double
        Get
            Return _dPrevBalance
        End Get
        Set(ByVal value As Double)
            _dPrevBalance = value
        End Set
    End Property

    Public Property dAmount() As Double
        Get
            Return _dAmount
        End Get
        Set(ByVal value As Double)
            _dAmount = value
        End Set
    End Property

    Public Property dNewBalance() As Double
        Get
            Return _dNewBalance
        End Get
        Set(ByVal value As Double)
            _dNewBalance = value
        End Set
    End Property

    Public Property sUser() As String
        Get
            Return _sUser
        End Get
        Set(ByVal value As String)
            _sUser = value
        End Set
    End Property

    Public Property dtDateAdded() As Date
        Get
            Return _dtDateAdded
        End Get
        Set(ByVal value As Date)
            _dtDateAdded = value
        End Set
    End Property

    Public Property dtDateUpdated() As Date
        Get
            Return _dtDateUpdated
        End Get
        Set(ByVal value As Date)
            _dtDateUpdated = value
        End Set
    End Property

    Public Property dtDateUploaded() As Date
        Get
            Return _dtDateUploaded
        End Get
        Set(ByVal value As Date)
            _dtDateUploaded = value
        End Set
    End Property

    Public Property sRemarks() As String
        Get
            Return _sRemarks
        End Get
        Set(ByVal value As String)
            _sRemarks = value
        End Set
    End Property

    Public Property sIPAddress() As String
        Get
            Return _sIPAddress
        End Get
        Set(ByVal value As String)
            _sIPAddress = value
        End Set
    End Property

    Public Property sHostName() As String
        Get
            Return _sHostName
        End Get
        Set(ByVal value As String)
            _sHostName = value
        End Set
    End Property

    Public Property sTransType() As String
        Get
            Return _sTransType
        End Get
        Set(ByVal value As String)
            _sTransType = value
        End Set
    End Property

    Public Property iRefID() As Integer
        Get
            Return _iRefID
        End Get
        Set(ByVal value As Integer)
            _iRefID = value
        End Set
    End Property

    Public Property sPOSRefCode() As String
        Get
            Return _sPOSRefCode
        End Get
        Set(ByVal value As String)
            _sPOSRefCode = value
        End Set
    End Property
End Class
