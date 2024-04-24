Public Class PrintLog_Entity
    Private _iID As Integer
    Private _sTransCode As String
    Private _sTerminalID As String
    Private _sHostName As String
    Private _sIPAddress As String
    Private _dDate As Date
    Private _sTransMode As String
    Private _sPrintDetails As String
    Private _sSite As String

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

    Public Property sTerminalID() As String
        Get
            Return _sTerminalID
        End Get
        Set(ByVal value As String)
            _sTerminalID = value
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

    Public Property sIPAddress() As String
        Get
            Return _sIPAddress
        End Get
        Set(ByVal value As String)
            _sIPAddress = value
        End Set
    End Property

    Public Property dDate() As Date
        Get
            Return _dDate
        End Get
        Set(ByVal value As Date)
            _dDate = value
        End Set
    End Property

    Public Property sTransMode() As String
        Get
            Return _sTransMode
        End Get
        Set(ByVal value As String)
            _sTransMode = value
        End Set
    End Property

    Public Property sPrintDetails() As String
        Get
            Return _sPrintDetails
        End Get
        Set(ByVal value As String)
            _sPrintDetails = value
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
End Class
