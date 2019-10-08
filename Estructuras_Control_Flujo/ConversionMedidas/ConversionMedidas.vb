Imports System

Module Program

	Sub Main(args As String())
		Dim UnidadMedida, CantidadMedida As Byte
		Dim metros, centimetros, yardas, pies, pulgas As Single
		Console.WriteLine("|| Metros:1 || Centimetros:2 || Yardas:3 || Pies:4 || Pulgadas:5 ||")
		Console.Write("Ingrese unidad de medida: ")
		UnidadMedida = Console.ReadLine
		Console.WriteLine("Ingrese cantidad de {0} a convertir: ", UnidadMedida)
		CantidadMedida = Console.ReadLine
		centimetros = 1
		metros = centimetros * 100
		pulgas = centimetros * 2.54
		pies = pulgas * 12
		yardas = pies * 3

		Select Case UnidadMedida
			Case 1
				centimetros *= 100
				pulgas *= 15.5
				pies /= 9.5
				'yardas = 
		End Select



		Console.WriteLine("Centimetros " & centimetros)
		Console.WriteLine("Pulgadas " & pulgas)
		Console.ReadKey()
	End Sub
End Module


'3.9. Crear un proyecto y un módulo “ConversionMedidas”, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.