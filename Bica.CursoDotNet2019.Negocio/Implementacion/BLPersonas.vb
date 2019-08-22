Imports Bica.CursoDotNet2019.Datos
Imports Bica.CursoDotNet2019.Modelo
Imports Bica.CursoDotNet2019.Utiles

Public Class BLPersonas
    Implements IPersonas

    Public Function GuardarVendedor(apellidos As String, nombres As String, telefono As Integer, documento As Integer, tipoContrato As String, sueldo As Decimal) As Long Implements IPersonas.GuardarVendedor
        Throw New NotImplementedException()
        Vendedor_DataModule.GuardarVendedor(apellidos, nombres, telefono, TipoDocumento.CUIT, documento, tipoContrato, sueldo)


    End Function

    Public Function GuardarCliente(apellidos As String, nombres As String, telefono As Integer, documento As Integer, categoria As String, codigo As Decimal) As Long Implements IPersonas.GuardarCliente
        Throw New NotImplementedException()
    End Function

    Public Function ObtenerVendedores() As List(Of Vendedor) Implements IPersonas.ObtenerVendedores
        Throw New NotImplementedException()
    End Function

    Public Function ObtenerClientes() As List(Of Cliente) Implements IPersonas.ObtenerClientes
        Throw New NotImplementedException()
    End Function

    Public Function ObtenerPersonas() As List(Of Persona) Implements IPersonas.ObtenerPersonas
        Throw New NotImplementedException()
    End Function
End Class
