Public Class Rewards_Entity
    Private _iID As Integer
    Private _sMemberID As String
    Private _iPoints As Integer
    Private _iConsumablePoints As Integer
    Private _dtValidFrom As Date
    Private _dtValidTo As Date
    Private _dtDateUploaded As Date
    Private _sUploadedBy As String
    Private _dtDateUpdated As Date
    Private _sUpdatedBy As String
    Private _dtDateAdded As Date
    Private _sAddedBy As String

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
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

    Public Property iPoints() As Integer
        Get
            Return _iPoints
        End Get
        Set(ByVal value As Integer)
            _iPoints = value
        End Set
    End Property

    Public Property iConsumablePoints() As Integer
        Get
            Return _iConsumablePoints
        End Get
        Set(ByVal value As Integer)
            _iConsumablePoints = value
        End Set
    End Property

    Public Property dtValidFrom() As Date
        Get
            Return _dtValidFrom
        End Get
        Set(ByVal value As Date)
            _dtValidFrom = value
        End Set
    End Property


    Public Property dtValidTo() As Date
        Get
            Return _dtValidTo
        End Get
        Set(ByVal value As Date)
            _dtValidTo = value
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

End Class
