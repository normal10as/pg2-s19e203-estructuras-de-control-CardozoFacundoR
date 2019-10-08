Imports System

Module Operaciones2
	Enum Operadores
		suma
		resta
		multiplicacion
		division
	End Enum
	Sub main()
		Dim a, b, c, d As Single
		a = 10
		b = 25
		c = 60
		d = 12
		Imprimir(a, b)
		Imprimir(a, b, c)
		Imprimir(a, b, c, d)
	End Sub

	Private Sub Imprimir(a As Single, b As Single, c As Single, d As Single)
		Console.WriteLine("Operaciones con cuatro numeros")
		Console.WriteLine("{0} + {1} + {2} + {3} = " & calcular(Operadores.suma, a, b, c, d), a, b, c, d)
		Console.WriteLine("{0} - {1} - {2} - {3} = " & calcular(Operadores.resta, a, b, c, d), a, b, c, d)
		Console.WriteLine("{0} * {1} * {2} * {3}  = " & calcular(Operadores.multiplicacion, a, b, c, d), a, b, c, d)
		Console.WriteLine("{0} / {1} / {2} / {3} = " & calcular(Operadores.division, a, b, c, d), a, b, c, d)
		Console.WriteLine("Operaciones por defecto")
		Console.WriteLine("{0} ? {1} ? {2} ? {3} = " & calcular(a, b, c, d), a, b, c, d)
		Console.WriteLine()
	End Sub

	Private Sub Imprimir(a As Single, b As Single, c As Single)
		Console.WriteLine("Operaciones con tres numeros")
		Console.WriteLine("{0} + {1} + {2} = " & Calcular(Operadores.suma, a, b, c), a, b, c)
		Console.WriteLine("{0} - {1} - {2}  = " & Calcular(Operadores.resta, a, b, c), a, b, c)
		Console.WriteLine("{0} * {1} * {2}  = " & Calcular(Operadores.multiplicacion, a, b, c), a, b, c)
		Console.WriteLine("{0} / {1} / {2}  = " & Calcular(Operadores.division, a, b, c), a, b, c)
		Console.WriteLine("Operaciones por defecto")
		Console.WriteLine("{0} ? {1} ? {2} = " & calcular(a, b, c), a, b, c)
		Console.WriteLine()
	End Sub

	Private Sub Imprimir(a As Single, b As Single)
		Console.WriteLine("Operaciones con dos numeros")
		Console.WriteLine("{0} + {1} = " & Calcular(Operadores.suma, a, b), a, b)
		Console.WriteLine("{0} - {1} = " & Calcular(Operadores.resta, a, b), a, b)
		Console.WriteLine("{0} * {1} = " & Calcular(Operadores.multiplicacion, a, b), a, b)
		Console.WriteLine("{0} / {1} = " & Calcular(Operadores.division, a, b), a, b)
		Console.WriteLine("Operaciones por defecto")
		Console.WriteLine("{0} ? {1} = " & calcular(a, b), a, b)
		Console.WriteLine()
	End Sub

	'Funcion para calcular las operaciones de 3 valores.
	Function Calcular(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single) As Single
		Return Calcular(operador, Calcular(operador, valor1, valor2), valor3)
	End Function

	'Funcion para calcular las operaciones de 4 valores
	Function calcular(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
		Return Calcular(operador, Calcular(operador, valor1, valor2, valor3), valor4)
	End Function

	'Funcion que opera 4 valores usando por defecto una suma.
	Function calcular(valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
		Return calcular(Calcular(Operadores.suma, valor1, valor2), valor3, valor4)
	End Function

	'Funcion que opera 3 valores usando por defecto una suma.
	Function calcular(valor1 As Single, valor2 As Single, valor3 As Single) As Single
		Return Calcular(Operadores.suma, valor1, valor2, valor3)
	End Function

	'Funcion que opera 2 valores usando por defecto una suma.
	Function calcular(valor1 As Single, valor2 As Single) As Single
		Return Calcular(Operadores.suma, valor1, valor2)
	End Function

	'Funcion de seleccion de operador a utilizar.
	Function Calcular(operador As Operadores, valor1 As Single, valor2 As Single) As Single
		Select Case operador
			Case Operadores.suma
				Return valor1 + valor2
			Case Operadores.resta
				Return valor1 - valor2
			Case Operadores.multiplicacion
				Return valor1 * valor2
			Case Operadores.division
				Return valor1 / valor2
		End Select
	End Function
End Module
'3.17. En base al ejercicio anterior: agregar una subrutina sobrecargada para mostrar por
'consola las operaciones realizadas. Esta subrutina se invoca desde el método main y ella
'invoca las funciones de cálculo. Ej.: resultado(operaciones.suma, 5, 8)
'imprimiría en consola 5 + 8 = 13