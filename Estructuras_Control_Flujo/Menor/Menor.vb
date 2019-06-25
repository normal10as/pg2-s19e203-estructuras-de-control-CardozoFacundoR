Imports System

Module Menor
	Sub Main(args As String())
		Dim valor1, valor2, valor3 As UShort
		Console.Write("Ingrese primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese segundo valor: ")
		valor2 = Console.ReadLine
		Console.Write("Ingrese tercer valor: ")
		valor3 = Console.ReadLine
		If valor1 < valor2 And valor1 < valor3 Then
			Console.WriteLine("El menor es: " & valor1)
		ElseIf valor2 < valor1 And valor2 < valor3 Then
			Console.WriteLine("El menor es: " & valor2)
		ElseIf valor3 < valor1 And valor3 < valor1 Then
			Console.WriteLine("El menor es: " & valor3)
		Else
			Console.WriteLine(" 'Valor ingresado incorrecto' ")
		End If
		Console.ReadKey()
	End Sub
End Module
'3.2. Crear un proyecto y un módulo “Menor” para resolver con IF: ingresar tres valores y mostrar
'el menor.