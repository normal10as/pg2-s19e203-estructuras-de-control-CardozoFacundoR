Imports System

Module Primos
    Sub Main(args As String())
        Dim Numero As UShort = 1
        ObtenerPrimos(Numero)
        Console.ReadKey()
    End Sub

    Function ObtenerPrimos(ByRef Numero As UShort) As Boolean
        Do While Numero < 1000
            If Numero Mod Numero <> 0 And Numero Mod 1 = 0 Then
                Console.WriteLine(Numero)
            End If
            Numero = Numero + 1
        Loop
        Return Numero

    End Function

End Module
'3.13. Crear un proyecto y un módulo “Primos” para obtener los números primos menores a
'mil.En matemáticas, un número primo es un número natural mayor que 1 que tiene
'únicamente dos divisores distintos: él mismo y el 1.