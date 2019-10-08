Imports System
Module MultiploCinco
	Sub Main()
		Dim valor1, valor2 As UShort
		Dim contador As UShort

		IngresarValores(valor1, valor2)

		EstucturasDeControl(valor1, valor2, contador)

		Console.ReadKey()
	End Sub

	Private Sub EstucturasDeControl(ByRef valor1 As UShort, valor2 As UShort, ByRef contador As UShort)
		Do While valor1 <= valor2
			If Multiplos(valor1) = True Then
				contador = contador + 1
			End If
			valor1 = valor1 + 1
		Loop
		Console.WriteLine("Estructura DO WHILE ... LOOP")
		Console.WriteLine("Los multiplos de 5 son :" & contador & vbCrLf)

		Do
			If Multiplos(valor1) = True Then
				contador = 0
				contador = contador + 1
			End If
		Loop While (valor1 <= valor2)
		Console.WriteLine("Estructura DO ... LOOP WHILE")
		Console.WriteLine("Los multiplos de 5 son :" & contador & vbCrLf)

		Do Until (valor1 <> valor2)
			If Multiplos(valor1) = True Then
				contador = 0
				contador = +1
			End If
			valor1 = +1
		Loop
		Console.WriteLine("Estructura DO UNTIL ... LOOP")
		Console.WriteLine("Los multiplos de 5 son :" & contador & vbCrLf)

		Do
			If Multiplos(valor1) = True Then
				contador = 0
				contador = +1
			End If
			valor1 = +1
		Loop Until (valor1 <> valor2)
		Console.WriteLine("Estructura DO ... LOOP UNTIL")
		Console.WriteLine("Los multiplos de 5 son :" & contador & vbCrLf)

		For x = valor1 To valor2 Step +1
			If Multiplos(x) = True Then
				contador = 0
				contador = contador + 1
			End If
		Next
		Console.WriteLine("Estructura FOR")
		Console.WriteLine("Los multiplos de 5 son :" & contador)
	End Sub

	Private Sub IngresarValores(ByRef valor1 As UShort, ByRef valor2 As UShort)
		Console.Write("Ingresar primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingresar segundo valor: ")
		valor2 = Console.ReadLine
		Console.WriteLine()
	End Sub
	Function Multiplos(valor As UShort) As Boolean
        Return valor Mod 5 = 0
    End Function
End Module
'3.10. Crear un proyecto y un módulo “MultiplosCinco” para resolver con For y Do Loop:
'con ingresar dos valores numéricos enteros cualquiera, el primero menor al segundo,
'calcular cuántos números múltiplos de cinco hay entre ellos e informar. Repetir esta solución
'en el mismo módulo con las diferentes alternativas las estructuras de repetición “do while …
'loop”, “do until … loop”, “do … loop while”, “do … loop until y “for”