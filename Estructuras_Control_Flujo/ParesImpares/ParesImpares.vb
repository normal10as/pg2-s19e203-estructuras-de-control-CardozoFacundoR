Imports System

Module ParesImpares
    Sub Main(args As String())
        Dim valor As UShort
        Dim pares, impares As Byte
        pares = 0
        impares = 0
        ContadorParesImpares(valor, pares, impares)
        Imprimir(pares, impares)
        Console.ReadKey()
    End Sub
    Private Sub Imprimir(pares As Byte, impares As Byte)
        If pares And impares > 0 Then
            Console.WriteLine("La cantidad de pares es: " & pares)
            Console.WriteLine("La cantidad de impares es: " & impares)
        ElseIf pares > 0 And impares = 0 Then
            Console.WriteLine("Solo se han ingresado numeros pares. ")
            Console.WriteLine("La cantidad de pares es: " & pares)
        Else
            Console.WriteLine("Solo se han ingresado numeros impares.")
            Console.WriteLine("La cantidad de impares es: " & impares)
        End If
    End Sub
    Private Sub ContadorParesImpares(ByRef valor As UShort, ByRef pares As Byte, ByRef impares As Byte)
        Do
            Console.Write("Ingrese un numero positivo: ")
            valor = Console.ReadLine()
            If valor Mod 2 = 0 And valor <> 0 Then
                pares += 1
            ElseIf valor Mod 2 <> 0 And valor <> 0 Then
                impares += 1
            End If
        Loop While valor <> 0
    End Sub
End Module
'3.11. Crear un proyecto y un módulo “ParesImpares” Utilizando la estructura de repetición
'más adecuada elaborar un programa que se ingresen valores enteros hasta que se ingrese
'cero(descartar negativos).Luego informar cuantos son pares y cuantos impares. Si todos son
'pares o todos son impares informar esta situación particular en lugar de la consigna anterior.