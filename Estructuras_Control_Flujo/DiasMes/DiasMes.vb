Imports System.Math
Enum DiasDeMes
    Enero = 1
    Febrero
    Marzo
    Abril
    Mayo
    Junio
    Julio
    Agosto
    Septiembre
    Octubre
    Noviembre
    Diciembre
End Enum
Module DiasMes
	Sub Main(args As String())
		Dim mes As Byte
		Console.WriteLine("Ingrese el mes que desea averiguar la cantidad de dias: ")
		mes = Console.ReadLine
		SeleccionMes(mes)
		Console.ReadKey()
	End Sub
	Private Sub SeleccionMes(mes As Byte)
		Select Case mes
			Case DiasDeMes.Febrero
				Console.WriteLine("Ingrese el año: ")
				Dim anio As UShort = Console.ReadLine
				If multiplo(anio, 4) And Not multiplo(anio, 100) Or multiplo(anio, 400) Then
					Console.WriteLine("Febrero tiene 29 dias")
				Else
					Console.WriteLine("Febrero tiene 28 dias")
				End If
			Case DiasDeMes.Enero, DiasDeMes.Marzo, DiasDeMes.Mayo, DiasDeMes.Julio, DiasDeMes.Agosto, DiasDeMes.Octubre, DiasDeMes.Diciembre

				Console.WriteLine("El mes tiene 31 dias")

			Case DiasDeMes.Abril, DiasDeMes.Junio, DiasDeMes.Septiembre, DiasDeMes.Noviembre

				Console.WriteLine("El mes tiene 30 dias")

			Case Else

				Console.WriteLine("mes incorrecto.")
		End Select
	End Sub
	Function multiplo(valor As UShort, divisor As UShort) As Boolean
		Return valor Mod divisor = 0
	End Function
End Module
'3.8. Crear un proyecto y un módulo “DiasMes” para resolver con CASE: 
'Elabore un programa que indique cuantos días tiene un mes respetando los siguientes requerimientos:  
'• En el flujo normal se ingresa el número de mes a evaluar y mediante una enumeración se informa la cantidad 
'de días que tiene el mes. 
'• En el caso de ser febrero, además ingresar el año y tener en cuenta que tiene 28 días 
'y si es un año bisiesto tiene 29 días. Un año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando 
'es múltiplo de 400. Por ejemplo, el año 2000 si bisiesto pero el 2100 no lo es