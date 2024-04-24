Public Class Member_Entity
    Private _iID As Integer
    Private _sMemberID As String
    Private _sCardID As String
    Private _sLName As String
    Private _sFName As String
    Private _sMName As String
    Private _sAddress As String
    Private _sContactNo As String
    Private _dBirthdate As Date
    Private _sEmail As String
    Private _dMembershipDate As Date
    Private _dLExpiry As Date
    Private _sDepartmentCode As String
    Private _sGroupCode As String
    Private _sLoyaltyCode As String
    Private _bytPhoto As Byte()
    Private _sCompanyCode As String

    Private _dDateUploaded As Date
    Private _sUploadedBy As String
    Private _dDateAdded As Date
    Private _sAddedBy As String
    Private _dDateUpdated As Date
    Private _sUpdatedby As String

    Private _bActive As Boolean

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

    Public Property sCardID() As String
        Get
            Return _sCardID
        End Get
        Set(ByVal value As String)
            _sCardID = value
        End Set
    End Property

    Public Property sLName() As String
        Get
            Return _sLName
        End Get
        Set(ByVal value As String)
            _sLName = value
        End Set
    End Property

    Public Property sFName() As String
        Get
            Return _sFName
        End Get
        Set(ByVal value As String)
            _sFName = value
        End Set
    End Property

    Public Property sMName() As String
        Get
            Return _sMName
        End Get
        Set(ByVal value As String)
            _sMName = value
        End Set
    End Property

    Public Property sAddress() As String
        Get
            Return _sAddress
        End Get
        Set(ByVal value As String)
            _sAddress = value
        End Set
    End Property

    Public Property dBirthdate() As Date
        Get
            Return _dBirthdate
        End Get
        Set(ByVal value As Date)
            _dBirthdate = value
        End Set
    End Property

    Public Property sContactNo() As String
        Get
            Return _sContactNo
        End Get
        Set(ByVal value As String)
            _sContactNo = value
        End Set
    End Property

    Public Property sEmail() As String
        Get
            Return _sEmail
        End Get
        Set(ByVal value As String)
            _sEmail = value
        End Set
    End Property

    Public Property dMembershipDate() As Date
        Get
            Return _dMembershipDate
        End Get
        Set(ByVal value As Date)
            _dMembershipDate = value
        End Set
    End Property

    Public Property dLExpiry() As Date
        Get
            Return _dLExpiry
        End Get
        Set(ByVal value As Date)
            _dLExpiry = value
        End Set
    End Property

    Public Property sDepartmentCode() As String
        Get
            Return _sDepartmentCode
        End Get
        Set(ByVal value As String)
            _sDepartmentCode = value
        End Set
    End Property

    Public Property sGroupCode() As String
        Get
            Return _sGroupCode
        End Get
        Set(ByVal value As String)
            _sGroupCode = value
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

    Public Property bytPhoto() As Byte()
        Get
            Return _bytPhoto
        End Get
        Set(ByVal value As Byte())
            _bytPhoto = value
        End Set
    End Property

    Public Property sCompanyCode() As String
        Get
            Return _sCompanyCode
        End Get
        Set(ByVal value As String)
            _sCompanyCode = value
        End Set
    End Property

    Public Property dDateUploaded() As Date
        Get
            Return _dDateUploaded
        End Get
        Set(ByVal value As Date)
            _ddateUploaded = value
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

    Public Property dDateAdded() As Date
        Get
            Return _dDateAdded
        End Get
        Set(ByVal value As Date)
            _dDateAdded = value
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

    Public Property dDateUpdated() As Date
        Get
            Return _dDateUpdated
        End Get
        Set(ByVal value As Date)
            _dDateUpdated = value
        End Set
    End Property

    Public Property sUpdatedBy() As String
        Get
            Return _sUpdatedby
        End Get
        Set(ByVal value As String)
            _sUpdatedby = value
        End Set
    End Property

    Public Property bActive() As Boolean
        Get
            Return _bActive
        End Get
        Set(ByVal value As Boolean)
            _bActive = value
        End Set
    End Property
End Class
