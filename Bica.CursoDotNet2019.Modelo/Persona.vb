Imports Bica.CursoDotNet2019.Utiles

Public MustInherit Class Persona
    Public Property Id As Long
    Public Property Nombres As String
    Public Property Apellidos As String
    Public Property Telefono As Integer
    Public Property Documento As Integer
    Public Property TipoDocumento As Enumerados.TipoDocumento
    Public Property TipoPersona As Enumerados.TipoPersona

    Public Overrides Function ToString() As String
        Return String.Format("Soy la persona {0}, {1} de Tipo {2}", Apellidos, Nombres, Me.GetType()) ' MyBase.ToString()
    End Function

End Class
