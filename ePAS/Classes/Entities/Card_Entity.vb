Public Class Card_Entity
    Private _iID As Integer
    Private _sCardID As String
    Private _sMemberID As String
    Private _iPoints As Double
    Private _sLoyaltyCode As String

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
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

    Public Property sMemberID() As String
        Get
            Return _sMemberID
        End Get
        Set(ByVal value As String)
            _sMemberID = value
        End Set
    End Property

    Public Property iPoints() As Double
        Get
            Return _iPoints
        End Get
        Set(ByVal value As Double)
            _iPoints = value
        End Set
    End Property

    Public Property sLoyaltyCode() As String
        Get
            Return _sLoyaltyCode
        End Get
        Set(ByVal value As String)
            _sLoyaltyCode = value
        End Set
    End Property
End Class
