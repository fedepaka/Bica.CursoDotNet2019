Public Class Vendedor
    Inherits Persona

    Public Property Id As Long
    Public Property TipoContrato As String
    Public Property Sueldo As Decimal
    Public Property IdPersona() As Long
        Get
            Return MyBase.Id
        End Get
        Set(value As Long)
            MyBase.Id = value
        End Set
    End Property

    Public Sub CalcularSueldo(sueldoBase As Decimal)
        If TipoContrato = "C" Then
            Me.Sueldo = sueldoBase + 350
        ElseIf TipoContrato = "N" Then
            Me.Sueldo = sueldoBase + 750
        Else
            Me.Sueldo = 0
        End If

    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Soy un vendedor: {0}, {1} de tipo {2}", Apellidos, Nombres, Me.GetType())
    End Function



End Class
