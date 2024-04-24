Public Class OtherTransactions_Entity
    Private _iID As Integer
    Private _sMemberID As String
    Private _dTransDate As Date
    Private _dAmount As Double
    Private _sTransType As String
    Private _dDateUploaded As Date
    Private _sUploadedBy As String
    Private _sIPAddress As String
    Private _sHostName As String
    Private _sRemarks As String
    Private _iApplicableYear As Integer

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
    Public Property dTransDate() As Date
        Get
            Return _dTransDate
        End Get
        Set(ByVal value As Date)
            _dTransDate = value
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

    Public Property sTransType() As String
        Get
            Return _sTransType
        End Get
        Set(ByVal value As String)
            _sTransType = value
        End Set
    End Property
    Public Property dDateUploaded() As Date
        Get
            Return _dDateUploaded
        End Get
        Set(ByVal value As Date)
            _dDateUploaded = value
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

    Public Property sRemarks() As String
        Get
            Return _sRemarks
        End Get
        Set(ByVal value As String)
            _sRemarks = value
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
End Class
