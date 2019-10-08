Imports System

Module Menor
	Sub Main(args As String())
		Dim valor1, valor2, valor3 As UShort
		IngresarValores(valor1, valor2, valor3)
		Informes(valor1, valor2, valor3)
		Console.ReadKey()
	End Sub
	Sub IngresarValores(ByRef valor1 As UShort, ByRef valor2 As UShort, ByRef valor3 As UShort)
		Console.Write("Ingrese primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese segundo valor: ")
		valor2 = Console.ReadLine
		Console.Write("Ingrese tercer valor: ")
		valor3 = Console.ReadLine
	End Sub
	Sub Informes(ByRef valor1 As UShort, ByRef valor2 As UShort, ByRef valor3 As UShort)
		If valor1 < valor2 And valor1 < valor3 Then
			Console.WriteLine("El menor es: " & valor1)
		ElseIf valor2 < valor1 And valor2 < valor3 Then
			Console.WriteLine("El menor es: " & valor2)
		ElseIf valor3 < valor1 And valor3 < valor1 Then
			Console.WriteLine("El menor es: " & valor3)
		Else
			Console.WriteLine(" 'Valor ingresado incorrecto' ")
		End If
	End Sub
End Module
'3.2. Crear un proyecto y un módulo “Menor” para resolver con IF: ingresar tres valores y mostrar
'el menor.