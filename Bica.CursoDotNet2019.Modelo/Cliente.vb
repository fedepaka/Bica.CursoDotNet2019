Public Class Cliente
    Inherits Persona

    Public Property Id As Long
    Public Property Categoria As String
    Public Property Codigo As String
    Public Property IdPersona() As Long
        Get
            Return MyBase.Id
        End Get
        Set(value As Long)
            MyBase.Id = value
        End Set
    End Property

    Public Sub GenerarCodigo()
        Me.Codigo = String.Format("C{0}{1}", Me.Apellidos, DateTime.Now.ToString("ddMMyyyyhhmmss"))
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Soy un cliente: {0}, {1} de tipo {2}", Apellidos, Nombres, Me.GetType())
    End Function
End Class
