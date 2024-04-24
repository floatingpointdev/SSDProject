Public Class Preferences_Entity
    Private _iID As Integer
    Private _iCAMin As Double
    Private _iCAMax As Double
    Private _iSDMin As Double
    Private _iSDMax As Double

    Public Property iID() As Integer
        Get
            Return _iID
        End Get
        Set(ByVal value As Integer)
            _iID = value
        End Set
    End Property

    Public Property iCAMin() As Double
        Get
            Return _iCAMin
        End Get
        Set(ByVal value As Double)
            _iCAMin = value
        End Set
    End Property

    Public Property iCAMax() As Double
        Get
            Return _iCAMax
        End Get
        Set(ByVal value As Double)
            _iCAMax = value
        End Set
    End Property

    Public Property iSDMin() As Double
        Get
            Return _iSDMin
        End Get
        Set(ByVal value As Double)
            _iSDMin = value
        End Set
    End Property
    Public Property iSDMax() As Double
        Get
            Return _iSDMax
        End Get
        Set(ByVal value As Double)
            _iSDMax = value
        End Set
    End Property
End Class
