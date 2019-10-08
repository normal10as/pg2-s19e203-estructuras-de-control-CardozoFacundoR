Imports System

Module Comparar
	Sub Main(args As String())
		Dim valor1, valor2 As UShort
		IngresarValor(valor1, valor2)
		Informe(valor1, valor2)
		Console.ReadKey()
	End Sub
	Sub IngresarValor(ByRef valor1 As UShort, ByRef valor2 As UShort)
		Console.Write("Ingrese un valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese otro valor: ")
		valor2 = Console.ReadLine
	End Sub
	Sub Informe(ByRef valor1 As UShort, ByRef valor2 As UShort)
		If valor1 > valor2 Then
			Console.WriteLine("El numero {0} es mayor a {1} ", valor1, valor2)
		ElseIf valor1 < valor2 Then
			Console.WriteLine("El numero {0} es menor a {1} ", valor1, valor2)
		Else
			Console.WriteLine("El numero {0} y el numero {1} son iguales ", valor1, valor2)
		End If
	End Sub
End Module

'3.1. Crear un proyecto y un módulo “Comparar” para resolver con IF: se ingresan dos valores
'numéricos e informar por pantalla cuál es la relación entre ambos: mayor, menor o igual.