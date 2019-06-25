Imports System

Module Tercero
	Sub Main(args As String())
		Dim valor1, valor2, valor3, valor4, valor5 As UShort
		Console.Write("Ingrese primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese segundo valor: ")
		valor2 = Console.ReadLine
		Console.Write("Ingrese tercer valor: ")
		valor3 = Console.ReadLine
		Console.Write("Ingrese cuarto valor: ")
		valor4 = Console.ReadLine
		Console.Write("Ingrese quinto valor: ")
		valor5 = Console.ReadLine
		If valor1 > valor2 And valor1 > valor3 And valor1 > valor4 And valor1 > valor5 Then
			Console.WriteLine("EL primer numero es el mayor")
		ElseIf (valor2 > valor1 And valor2 > valor3 And valor2 > valor4 And valor2 > valor5) Then
			Console.WriteLine("EL segundo numero es el mayor")
		ElseIf valor3 > valor2 And valor3 > valor1 And valor3 > valor4 And valor3 > valor5 Then
			Console.WriteLine("EL tercer numero es el mayor")
		ElseIf valor4 > valor2 And valor4 > valor3 And valor4 > valor1 And valor4 > valor5 Then
			Console.WriteLine("EL cuarto numero es el mayor")
		ElseIf valor5 > valor2 And valor5 > valor3 And valor5 > valor4 And valor5 > valor1 Then
			Console.WriteLine("EL quinto numero es el mayor")
		Else
			Console.WriteLine("No hay un solo numero mayor")
		End If
		Console.ReadKey()
	End Sub
End Module
'3.3. Crear un proyecto y un módulo “Tercero” para resolver con If: ingresar 5 valores enteros e
'informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.