Imports Bica.CursoDotNet2019.Datos.Bica.CursoDotNet2019.Datos
Imports Bica.CursoDotNet2019.Utiles.Enumerados

Public Module Persona_DataModule

    ''' <summary>
    ''' Guarda un nuevo registro de persona en BD
    ''' </summary>
    ''' <param name="apellidos"></param>
    ''' <param name="nombres"></param>
    ''' <param name="telefono"></param>
    ''' <param name="tipoDocumento"></param>
    ''' <param name="documento"></param>
    ''' <param name="tipoPersona"></param>
    ''' <returns></returns>
    Public Function GuardarPersona(apellidos As String, nombres As String, telefono As Integer, tipoDocumento As TipoDocumento, documento As Integer, tipoPersona As TipoPersona) As Long
        Dim resultado As Long = 0
        Dim persona As Persona


        Using bd = New B_CursoDotNetEntities()
            persona = New Persona()
            persona.Apellidos = apellidos
            persona.Nombres = nombres
            persona.Telefono = telefono
            persona.Documento = documento
            persona.TipoPersona = Integer.Parse(tipoPersona)
            persona.TipoDocumento = Integer.Parse(tipoDocumento)

            bd.Persona.Add(persona)
            bd.SaveChanges()
            resultado = persona.Id
        End Using

        Return resultado
    End Function

End Module
