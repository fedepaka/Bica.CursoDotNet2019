Imports Bica.CursoDotNet2019.Modelo
Imports Bica.CursoDotNet2019.Utiles.Enumerados

Public Interface IPersonas
    Function GuardarVendedor(apellidos As String, nombres As String, telefono As Integer, documento As Integer, tipoContrato As String, sueldo As Decimal) As Long
    Function GuardarCliente(apellidos As String, nombres As String, telefono As Integer, documento As Integer, categoria As String, codigo As Decimal) As Long

    Function ObtenerVendedores() As List(Of Vendedor)
    Function ObtenerClientes() As List(Of Cliente)
    Function ObtenerPersonas() As List(Of Persona)

End Interface
