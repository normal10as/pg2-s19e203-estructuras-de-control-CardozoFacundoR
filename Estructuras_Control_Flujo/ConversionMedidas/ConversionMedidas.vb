Imports System

Module Program

    Sub Main(args As String())

        Console.WriteLine("Un n�mero primo es un n�mero natural mayor que 1 que tiene �nicamente dos divisores distintos: �l mismo y el 1")

        Dim valor As UInteger = 1

        For x = 1 To 20

            ObtenerProximoPrimo(valor)

            Console.Write(" " & valor)

        Next

    End Sub

    Sub ObtenerProximoPrimo(ByRef valor As UInteger)

        Do

            valor += 1

        Loop Until isPrimo(valor)

    End Sub

    Function isPrimo(valor As UInteger) As Boolean

        Dim divisor, raizcuadrada As UInteger

        ' el m�ximo valor divisor sera equivalente a la ra�z cuadrada del valor

        ' esto reduce iteraciones innecesarias

        raizcuadrada = Math.Sqrt(valor)

        'Console.WriteLine("Raiz cuadrada: " & raizcuadrada)

        ' el primer valor divisor para descartar un numero primo es 2

        divisor = 2

        ' itera si el resto es distinto de cero y el divisor es menor o igual a la ra�z cuadrada

        ' si el primer calculo de resto da 0 no itera en absoluto

        Do While valor Mod divisor <> 0 And divisor <= raizcuadrada

            'Console.Write(" " & divisor)

            divisor += 1

        Loop

        'si el divisor es mayor a la ra�z cuadrada es primo

        Return divisor > raizcuadrada

    End Function

End Module


'3.9. Crear un proyecto y un m�dulo �ConversionMedidas�, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, cent�metros,
'yardas, pies y pulgadas: 
'� Presentar un men� y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y despu�s mostrar las equivalencias.
'� Utilizar �nicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'� Ejemplo: si escogi� metros, debe solicitar y leer el n�mero de metros a convertir, luego
'imprimir la equivalencia en cent�metros, pies, yardas y pulgadas.