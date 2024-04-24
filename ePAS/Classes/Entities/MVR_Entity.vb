Public Class MVR_Entity
    Private _iID As Integer
    Private _sMemberID As String
    Private _dMVRAmount As Double
    Private _dMVRConsumable As Double
    Private _dtApplicablePeriod As Date
    Private _dtApplicablePayOut As Date
    Private _iApplicableYear As Integer
    Private _dtDateUploaded As Date
    Private _sUploadedBy As String
    Private _dtDateUpdated As Date
    Private _sUpdatedBy As String
    Private _dtDateAdded As Date
    Private _sAddedBy As String
    Private _sIPAddress As String
    Private _sHostName As String    

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
        End Set
    End Property

    Public Property dMVRAmount() As Double
        Get
            Return _dMVRAmount
        End Get
        Set(ByVal value As Double)
            _dMVRAmount = value
        End Set
    End Property

    Public Property dMVRConsumable() As Double
        Get
            Return _dMVRConsumable
        End Get
        Set(ByVal value As Double)
            _dMVRConsumable = value
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

    Public Property dtApplicablePeriod() As Date
        Get
            Return _dtApplicablePeriod
        End Get
        Set(ByVal value As Date)
            _dtApplicablePeriod = value
        End Set
    End Property
    Public Property dtApplicablePayOut() As Date
        Get
            Return _dtApplicablePayOut
        End Get
        Set(ByVal value As Date)
            _dtApplicablePayOut = value
        End Set
    End Property


    Public Property iApplicableYear() As Integer
        Get
            Return _iApplicableYear
        End Get
        Set(ByVal value As Integer)
            _iApplicableYear = value
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

    Public Property sUploadedBy() As String
        Get
            Return _sUploadedBy
        End Get
        Set(ByVal value As String)
            _sUploadedBy = value
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

    Public Property sUpdatedBy() As String
        Get
            Return _sUpdatedBy
        End Get
        Set(ByVal value As String)
            _sUpdatedBy = value
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

    Public Property sAddedBy() As String
        Get
            Return _sAddedBy
        End Get
        Set(ByVal value As String)
            _sAddedBy = value
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
End Class
