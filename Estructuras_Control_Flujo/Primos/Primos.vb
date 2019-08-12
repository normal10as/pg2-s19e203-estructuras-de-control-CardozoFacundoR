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
'3.13. Crear un proyecto y un m�dulo �Primos� para obtener los n�meros primos menores a
'mil.En matem�ticas, un n�mero primo es un n�mero natural mayor que 1 que tiene
'�nicamente dos divisores distintos: �l mismo y el 1.