Public Class AR_Entity
    Private _iID As Integer
    Private _sMemberID As String
    Private _dARAmount As Double
    Private _dARConsumable As Double
    Private _dtApplicableMonth As Date
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

    Public Property dARAmount() As Double
        Get
            Return _dARAmount
        End Get
        Set(ByVal value As Double)
            _dARAmount = value
        End Set
    End Property

    Public Property dARConsumable() As Double
        Get
            Return _dARConsumable
        End Get
        Set(ByVal value As Double)
            _dARConsumable = value
        End Set
    End Property

    Public Property dtApplicableMonth() As Date
        Get
            Return _dtApplicableMonth
        End Get
        Set(ByVal value As Date)
            _dtApplicableMonth = value
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
