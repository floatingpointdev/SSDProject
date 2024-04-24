Public Class Transaction_Entity
    Private _iID As Integer
    Private _dTransDate As Date
    Private _sCardID As String
    Private _sMemberID As String
    Private _sSite As String
    Private _sConcessionaire As String
    Private _iPoints As Integer
    Private _sTransMode As String
    Private _sRemarks As String
    Private _iRewardsRefID As Integer

    Private _sIPAddress As String
    Private _sHostName As String
    Private _sTerminal As String
    Private _dAmount As Double
    Private _sCashier As String
    Private _sVoidedBy As String
    Private _dtDateVoided As Date
    Private _sTransCode As String
    Private _sIncidentReportNo As String

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
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

    Public Property sSite() As String
        Get
            Return _sSite
        End Get
        Set(ByVal value As String)
            _sSite = value
        End Set
    End Property

    Public Property sConcessionaire() As String
        Get
            Return _sConcessionaire
        End Get
        Set(ByVal value As String)
            _sConcessionaire = value
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


    Public Property sTransMode() As String
        Get
            Return _sTransMode
        End Get
        Set(ByVal value As String)
            _sTransMode = value
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

    Public Property iRewardsRefID() As Integer
        Get
            Return _iRewardsRefID
        End Get
        Set(ByVal value As Integer)
            _iRewardsRefID = value
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

    Public Property sTerminal() As String
        Get
            Return _sTerminal
        End Get
        Set(ByVal value As String)
            _sTerminal = value
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

    Public Property sCashier() As String
        Get
            Return _sCashier
        End Get
        Set(ByVal value As String)
            _sCashier = value
        End Set
    End Property

    Public Property sVoidedBy() As String
        Get
            Return _sVoidedBy
        End Get
        Set(ByVal value As String)
            _sVoidedBy = value
        End Set
    End Property

    Public Property dtDateVoided() As Date
        Get
            Return _dtDateVoided
        End Get
        Set(ByVal value As Date)
            _dtDateVoided = value
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

    Public Property sIncidentReportNo() As String
        Get
            Return _sIncidentReportNo
        End Get
        Set(ByVal value As String)
            _sIncidentReportNo = value
        End Set
    End Property
End Class
