Imports System

Module Descuento
	Sub Main(args As String())
		Dim cantidad, PrecioUnitario As UShort
		Dim descuento, subtotal, MontoDescontado, Total As Decimal
		SeleccionIngreso(cantidad, PrecioUnitario, descuento, subtotal, MontoDescontado, Total)
		Console.ReadKey()
	End Sub

	Private Sub SeleccionIngreso(ByRef cantidad As UShort, ByRef PrecioUnitario As UShort, ByRef descuento As Decimal, ByRef subtotal As Decimal, ByRef MontoDescontado As Decimal, ByRef Total As Decimal)
		Do
			Console.Write("Ingrear Cantidad: ")
			cantidad = Console.ReadLine
			If cantidad <> 0 Then
				Console.Write("Ingrese precio Unitario: ")
				PrecioUnitario = Console.ReadLine
			End If
			If cantidad >= 10 And cantidad <= 50 Then
				descuento = 5
			ElseIf cantidad > 50 And cantidad <= 250 Then
				descuento = 10
			ElseIf cantidad > 250 Then
				descuento = 20
			End If
			CaclculosTotales(cantidad, PrecioUnitario, descuento, subtotal, MontoDescontado, Total)
			If cantidad > 0 Then
				Informes(descuento, subtotal, MontoDescontado, Total)
			Else
				Console.WriteLine("Exit")
			End If
		Loop Until cantidad = 0
	End Sub

	Private Sub Informes(descuento As Decimal, subtotal As Decimal, MontoDescontado As Decimal, Total As Decimal)
		Console.WriteLine("Subtotal: " & subtotal)
		Console.WriteLine("Descuento {0}% , {1}$ ", descuento, MontoDescontado)
		Console.WriteLine("Total: " & Total & vbCrLf)
	End Sub

	Private Sub CaclculosTotales(cantidad As UShort, PrecioUnitario As UShort, descuento As Decimal, ByRef subtotal As Decimal, ByRef MontoDescontado As Decimal, ByRef Total As Decimal)

		subtotal = cantidad * PrecioUnitario
		MontoDescontado = subtotal * descuento / 100
		Total = subtotal - MontoDescontado
	End Sub
End Module


'3.14. Crear un proyecto y un módulo “Descuento” para ingresar repetitivamente dos
'valores relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es
'entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es
'del 10% y si es 251 o más el descuento es del 20%. Informar por cada producto subtotal
'(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y el total
'(subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a cero, informar el
'total de pesos descontados y el total a cobrar.