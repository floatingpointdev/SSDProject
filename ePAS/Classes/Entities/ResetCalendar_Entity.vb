Public Class ResetCalendar_Entity
    Private _iID As Integer
    Private _dDate As Date
    Private _sType As String
    Private _bDone As Boolean
    Private _sAddedBy As String
    Private _dDateAdded As Date
    Private _sUpdatedBy As String
    Private _dDateUpdated As Date
    Private _sIPAddress As String
    Private _sHostName As String
    Private _sSite As String
    Private _sTerminalID As String

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
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

    Public Property sType() As String
        Get
            Return _sType
        End Get
        Set(ByVal value As String)
            _sType = value
        End Set
    End Property

    Public Property bDone() As Boolean
        Get
            Return _bDone
        End Get
        Set(ByVal value As Boolean)
            _bDone = value
        End Set
    End Property

    Public Property sAddedBy() As String
        Get
            Return _sAddedBy
        End Get
        Set(ByVal value As String)
            _sAddedBy = value
        End Set
    End Property

    Public Property dDateAdded() As Date
        Get
            Return _dDateAdded
        End Get
        Set(ByVal value As Date)
            _dDateAdded = value
        End Set
    End Property

    Public Property sUpdatedBy() As String
        Get
            Return _sUpdatedBy
        End Get
        Set(ByVal value As String)
            _sUpdatedBy = value
        End Set
    End Property

    Public Property dDateUpdated() As Date
        Get
            Return _dDateUpdated
        End Get
        Set(ByVal value As Date)
            _dDateUpdated = value
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

    Public Property sSite() As String
        Get
            Return _sSite
        End Get
        Set(ByVal value As String)
            _sSite = value
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
End Class
