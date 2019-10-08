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
				Console.WriteLine("Ingrese el a�o: ")
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
'3.8. Crear un proyecto y un m�dulo �DiasMes� para resolver con CASE: 
'Elabore un programa que indique cuantos d�as tiene un mes respetando los siguientes requerimientos:  
'� En el flujo normal se ingresa el n�mero de mes a evaluar y mediante una enumeraci�n se informa la cantidad 
'de d�as que tiene el mes. 
'� En el caso de ser febrero, adem�s ingresar el a�o y tener en cuenta que tiene 28 d�as 
'y si es un a�o bisiesto tiene 29 d�as. Un a�o bisiesto es aqu�l que es m�ltiplo de 4 y no de 100 o cuando 
'es m�ltiplo de 400. Por ejemplo, el a�o 2000 si bisiesto pero el 2100 no lo es