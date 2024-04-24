Public Class AuditLog_Entity
    Private _iID As Integer
    Private _dtTransDate As Date
    Private _sUserID As String
    Private _sTransactionType As String
    Private _sTableName As String


    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
        End Set
    End Property
End Class
