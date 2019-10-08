Imports System
Module fibonacci
	Sub Main(args As String())
		Dim valor2 As UShort = 1
		Dim valor1, resultado As UShort
		Dim contador As Byte = 0

		Calcular(valor2, valor1, resultado)
	End Sub

	Private Sub Calcular(ByRef valor2 As UShort, ByRef valor1 As UShort, ByRef resultado As UShort)
		Console.WriteLine("NUMEROS FIBONACCI ")
		For x = 3 To 20
			resultado = valor1 + valor2
			Mostrar(x, resultado)
			valor1 = valor2
			valor2 = resultado
		Next
	End Sub

	Private Sub Mostrar(indice As UShort, valor As UShort)
		Console.WriteLine("{0}) {1}", indice, valor)
	End Sub
End Module
'3.12. Crear un proyecto y un módulo “Fibonacci” para elaborar “Los números de
'Fibonacci”, estos constituyen una secuencia que empieza con 0 y 1; el número que sigue a
'éstos se calcula sumando los dos anteriores y así sucesivamente. Utilizando la estructura de
'repetición más adecuada elaborar un algoritmo que imprima los 20 primeros números de la
'secuencia.