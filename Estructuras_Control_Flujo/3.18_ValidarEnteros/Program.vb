Imports System

Module ProgramSub
	Sub Main(args As String())
		Dim valor1, valor2, valor3 As Short
		Validacion(valor1, valor2, valor3)
		Informes(valor1, valor2, valor3)
		Console.ReadKey()
	End Sub
	Private Function Validacion(ByRef valor1 As Short, ByRef valor2 As Short, ByRef valor3 As Short) As Boolean
		Do
			IngresarValores(valor1, valor2, valor3)
			If valor1 < 1 Or valor2 < 1 Or valor3 < 1 Then
				Console.WriteLine("Solo puede ingresar numeros positivos, Mayores a CERO")
			End If
		Loop Until valor1 > 0 And valor2 > 0 And valor3 > 0
		Return True
	End Function
	Sub IngresarValores(ByRef valor1 As Short, ByRef valor2 As Short, ByRef valor3 As Short)
		Console.Write("Ingrese primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese segundo valor: ")
		valor2 = Console.ReadLine
		Console.Write("Ingrese tercer valor: ")
		valor3 = Console.ReadLine
	End Sub
	Sub Informes(ByRef valor1 As Short, ByRef valor2 As Short, ByRef valor3 As Short)
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
'3.18. Utilizar una función para validar los valores ingresados en el punto 2.3 sean enteros
'positivos, si no cumple esta condición pedir el reingreso del dato.