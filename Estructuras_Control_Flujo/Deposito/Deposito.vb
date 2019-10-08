Imports System

Module Program
	Sub Main(args As String())
		Dim CapIni, CantMeses, interes, saldo, TotInt As Double
		Const TasaAnual As Byte = 36
		IngresoDatos(CapIni, CantMeses)
		Console.WriteLine("MES " & vbTab & "||    CAPITAL " & vbTab & "||   INTERES " & vbTab & "|| SALDO ")
		CalculoInteres(CapIni, CantMeses, interes, saldo, TasaAnual, TotInt)
		Console.WriteLine("Total Interes Ganado: " & TotInt)
		Console.ReadKey()
	End Sub

	Private Sub IngresoDatos(ByRef CapIni As Double, ByRef CantMeses As Double)
		Console.Write("Ingrese capital inicial: " & vbCrLf)
		CapIni = Console.ReadLine
		Console.Write("Ingrese cantidad de meses: ")
		CantMeses = Console.ReadLine
	End Sub

	Private Sub CalculoInteres(ByRef CapIni As Double, CantMeses As Double, ByRef interes As Double, ByRef saldo As Double, TasaAnual As Byte, ByRef totint As Double)
		For x = 1 To CantMeses
			interes = CapIni * (TasaAnual / 12)
			saldo = CapIni + interes
			Console.WriteLine(x & vbTab & vbTab & CapIni & vbTab & vbTab & interes & vbTab & "  " & saldo)
			CapIni += interes
			totint = totint + interes
		Next
	End Sub
End Module
'3.15. Crear un proyecto y un módulo “Deposito” para resolver el siguiente planteo: se
'deposita un capital a un plazo de n meses, con una tasa de interés de 36% anual (es una
'constante), capitalizable cada mes, es decir, se suman los intereses ganados al capital.
'Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y luego imprima el
'siguiente reporte:
'MES CAPITAL INTERES SALDO
'1 99,999.99 99,999.99 99,999.99
'2 99,999.99 99,999.99 99,999.99
'x xx, xxx.xx xx,xxx.xx xx,xxx.xx
'n 99, 999.99 99, 999.99 99, 999.99
'TOTAL INTERES GANADO: 99,999.99
'Donde:
'MES: es el número de mes.
'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2,
'deberá tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor
'que gana en el mes correspondiente.
'SALDO: es el el capital sumado el interés.
'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.