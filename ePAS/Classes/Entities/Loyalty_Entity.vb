Public Class Loyalty_Entity
    Private _iID As Integer
    Private _iLoyaltyMode As Integer
    Private _sLoyaltyCode As String
    Private _sLoyaltyDesc As String
    Private _iOperation As Integer
    Private _iPointsEarned As Integer
    Private _iPointThreshold As Integer
    Private _dAmountPurchased As Double
    Private _iRewardType As Integer
    Private _dCashRewardAmt As Double
    Private _iDecrementBy As Integer
    Private _bWillExpire As Boolean
    Private _dExpiration As Date

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
        End Set
    End Property

    Public Property iLoyaltyMode() As Integer
        Get
            Return _iLoyaltyMode
        End Get
        Set(ByVal value As Integer)
            _iLoyaltyMode = value
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

    Public Property sLoyaltyDesc() As String
        Get
            Return _sLoyaltyDesc
        End Get
        Set(ByVal value As String)
            _sLoyaltyDesc = value
        End Set
    End Property

    Public Property iOperation() As Integer
        Get
            Return _iOperation
        End Get
        Set(ByVal value As Integer)
            _iOperation = value
        End Set
    End Property

    Public Property dAmountPurchased() As Double
        Get
            Return _dAmountPurchased
        End Get
        Set(ByVal value As Double)
            _dAmountPurchased = value
        End Set
    End Property

    Public Property iPointsEarned() As Integer
        Get
            Return _iPointsEarned
        End Get
        Set(ByVal value As Integer)
            _iPointsEarned = value
        End Set
    End Property

    Public Property iPointThreshold() As Integer
        Get
            Return _iPointThreshold
        End Get
        Set(ByVal value As Integer)
            _iPointThreshold = value
        End Set
    End Property

    Public Property iRewardType() As Integer
        Get
            Return _iRewardType
        End Get
        Set(ByVal value As Integer)
            _iRewardType = value
        End Set
    End Property

    Public Property dCashRewardAmt() As Double
        Get
            Return _dCashRewardAmt
        End Get
        Set(ByVal value As Double)
            _dCashRewardAmt = value
        End Set
    End Property

    Public Property iDecrementBy() As Integer
        Get
            Return _iDecrementBy
        End Get
        Set(ByVal value As Integer)
            _iDecrementBy = value
        End Set
    End Property

    Public Property bWillExpire() As Boolean
        Get
            Return _bWillExpire
        End Get
        Set(ByVal value As Boolean)
            _bWillExpire = value
        End Set
    End Property

    Public Property dExpiration() As Date
        Get
            Return _dExpiration
        End Get
        Set(ByVal value As Date)
            _dExpiration = value
        End Set
    End Property
End Class
