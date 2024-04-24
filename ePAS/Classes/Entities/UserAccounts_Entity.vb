Public Class UserAccounts_Entity
    Private _sUserName As String
    Private _sPassword As String
    Private _sUserGroup As String
    Private _sUGroupDesc As String
    Private _bRestricted As Boolean
    Private _bHR As Boolean
    Private _sCardID As String
    Private _iAccountType As Integer

    Public Property sUserName() As String
        Get
            Return _sUserName
        End Get
        Set(ByVal value As String)
            _sUserName = value
        End Set
    End Property

    Public Property sPassword() As String
        Get
            Return _sPassword
        End Get
        Set(ByVal value As String)
            _sPassword = value
        End Set
    End Property

    Public Property sGroupCode() As String
        Get
            Return _sUserGroup
        End Get
        Set(ByVal value As String)
            _sUserGroup = value
        End Set
    End Property

    Public Property sGroupDesc() As String
        Get
            Return _sUGroupDesc
        End Get
        Set(ByVal value As String)
            _sUGroupDesc = value
        End Set
    End Property

    Public Property bRestricted() As Boolean
        Get
            Return _bRestricted
        End Get
        Set(ByVal value As Boolean)
            _bRestricted = value
        End Set
    End Property

    Public Property bHR() As Boolean
        Get
            Return _bHR
        End Get
        Set(ByVal value As Boolean)
            _bHR = value
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

    Public Property iAccountType() As Integer
        Get
            Return _iAccountType
        End Get
        Set(ByVal value As Integer)
            _iAccountType = value
        End Set
    End Property

End Class
