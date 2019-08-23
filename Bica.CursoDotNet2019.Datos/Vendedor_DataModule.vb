Imports Bica.CursoDotNet2019.Datos.Bica.CursoDotNet2019.Datos
Imports Bica.CursoDotNet2019.Utiles.Enumerados

Public Module Vendedor_DataModule

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="apellidos"></param>
    ''' <param name="nombres"></param>
    ''' <param name="telefono"></param>
    ''' <param name="tipoDocumento"></param>
    ''' <param name="documento"></param>
    ''' <param name="tipoContrato"></param>
    ''' <param name="sueldo"></param>
    ''' <returns></returns>
    Public Function GuardarVendedor(apellidos As String, nombres As String, telefono As Integer, tipoDocumento As TipoDocumento, documento As Integer, tipoContrato As String, sueldo As Decimal) As Long
        Dim resultado As Long = 0
        'guardamos el objeto padre
        Dim idPersona = Persona_DataModule.GuardarPersona(apellidos, nombres, telefono, tipoDocumento, documento, TipoPersona.VENDEDOR)
        Dim vendedor As Vendedor
        Using bd = New B_CursoDotNetEntities()
            vendedor = New Vendedor
            vendedor.IdPersona = idPersona
            vendedor.Sueldo = sueldo
            vendedor.TipoContrato = tipoContrato

            bd.Vendedor.Add(vendedor)
            bd.SaveChanges()
            resultado = vendedor.IdPersona
        End Using

        Return resultado
    End Function

    ''' <summary>
    ''' Obtiene un vendedor por id persona
    ''' </summary>
    ''' <param name="idVendedor"></param>
    ''' <returns></returns>
    Public Function ObtenerVendedorPorId(idVendedor As Long) As Modelo.Vendedor

        Using bd = New B_CursoDotNetEntities()
            Dim objVendedor = (From v In bd.Vendedor.Include("Persona") Where v.Persona.Id = idVendedor).FirstOrDefault()

            Return MapVendedor(objVendedor)
        End Using

    End Function

#Region "Métodos Privados"
    Private Function MapVendedor(vendedor As Vendedor) As Modelo.Vendedor
        If vendedor Is Nothing Then
            Return Nothing
        Else
            Dim objVendedor As Modelo.Vendedor = New Modelo.Vendedor()
            objVendedor.Id = vendedor.Id
            objVendedor.IdPersona = vendedor.Persona.Id
            objVendedor.Nombres = vendedor.Persona.Nombres
            objVendedor.Apellidos = vendedor.Persona.Apellidos
            objVendedor.Documento = vendedor.Persona.Documento
            objVendedor.Sueldo = vendedor.Sueldo
            objVendedor.Telefono = vendedor.Persona.Telefono
            objVendedor.TipoContrato = vendedor.TipoContrato
            objVendedor.TipoDocumento = vendedor.Persona.TipoDocumento
            objVendedor.TipoPersona = CType([Enum].Parse(GetType(TipoPersona), vendedor.Persona.TipoPersona), TipoPersona)
            Return objVendedor
        End If
    End Function
#End Region
End Module
