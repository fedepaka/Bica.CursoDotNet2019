Imports Bica.CursoDotNet2019.Modelo
Imports Bica.CursoNet.Model

Module Module1

    Sub Main()

        ImprimirMenu()

    End Sub


    Private Sub ImprimirMenu()
        Console.Clear()

        Console.WriteLine("*****************************************************" + Environment.NewLine)
        Console.WriteLine("*****************************************************" + Environment.NewLine)
        Console.WriteLine("1 - Ejemplo de uso Select ***************************" + Environment.NewLine)
        Console.WriteLine("2 - Ejemplo listado de Personas *********************" + Environment.NewLine)
        Console.WriteLine("*****************************************************" + Environment.NewLine)
        Console.WriteLine("9 - Salir *******************************************" + Environment.NewLine)
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Ingrese una opción y presiona enter: " + Environment.NewLine)

        Dim opcion As Integer
        Dim resultado = Integer.TryParse(Console.ReadLine(), opcion)

        Console.Clear()

        Select Case opcion
            Case 1
                Console.WriteLine("Usted eligió ejemplo de uso Select ***************************" + Environment.NewLine)
                EjemploUsoSelect()
            Case 2
                Console.WriteLine("Usted eligió ejemplo listado de Personas ***************************" + Environment.NewLine)
                ImprimirListadoPersonas(CrearListadoPersonas())
            Case 9
                Environment.Exit(0)
            Case Else
                ImprimirMenu()
        End Select
        Console.WriteLine("Presione tecla para continuar ...")
        Console.ReadLine()
        ImprimirMenu()
    End Sub

    ''' <summary>
    ''' Sentencia de control de flujo
    ''' </summary>
    Private Sub EjemploUsoSelect()
        Console.WriteLine("Ingrese un número y presione enter: ")
        Dim numero As Integer
        Dim resultado = Integer.TryParse(Console.ReadLine(), numero)
        Select Case numero
            Case 1 To 5
                Console.WriteLine("El valor está entre 1 y 5 inclusive")
            Case 6, 7, 8
                Console.WriteLine("El valor está entre 6 y 8 inclusive")
            Case 9 To 10
                Console.WriteLine("Valor igual a 9 o 10")
            Case Is > 20
                Console.WriteLine("El valor es mayor a 20")
            Case Else
                Console.WriteLine("El valor no cumple con las condiciones anteriores")
        End Select


    End Sub

    ''' <summary>
    ''' Ejemplo de herencia y polimorfismo
    ''' Devuelve un listado de personas
    ''' </summary>
    ''' <returns></returns>
    Private Function CrearListadoPersonas() As List(Of Persona)
        Dim listaPersonas As List(Of Persona) = New List(Of Persona)

        For index = 1 To 10
            'Dim persona = New Persona()
            'persona.Apellidos = "Perez " + index.ToString()
            'persona.Nombres = "Felipe " + index.ToString()

            Dim cliente = New Cliente()
            cliente.Nombres = "Alfredo " + index.ToString()
            cliente.Apellidos = "Gomez " + index.ToString()


            Dim empleado = New Vendedor()
            empleado.Apellidos = "Crespo " + index.ToString()
            empleado.Nombres = "Pedro " + index.ToString()

            'listaPersonas.Add(persona)
            listaPersonas.Add(cliente)
            listaPersonas.Add(empleado)

        Next

        Return listaPersonas
    End Function

    ''' <summary>
    ''' Pruebas de For, For Each y While
    ''' Imprime un  listado de nombres de personas
    ''' </summary>
    ''' <param name="listaPersonas"></param>
    Private Sub ImprimirListadoPersonas(listaPersonas As List(Of Persona))

        '¿cuando usar For?
        For index = 0 To listaPersonas.Count - 1
            listaPersonas.ElementAt(index).Nombres = listaPersonas.ElementAt(index).Nombres + "S"
            Console.WriteLine(listaPersonas.ElementAt(index).ToString() + Environment.NewLine)
        Next

        ''¿cuando usar For Each?
        For Each persona In listaPersonas
            'persona = persona.Nombres + "s" 'no es posible efectuar este camio en el objeto
            Console.WriteLine(persona.ToString() + Environment.NewLine)
        Next

        Dim contador As Integer = 0
        While contador < 10
            Console.WriteLine("Estoy imprimiendo la línea " + contador.ToString())
            contador = contador + 1
        End While

    End Sub
End Module
