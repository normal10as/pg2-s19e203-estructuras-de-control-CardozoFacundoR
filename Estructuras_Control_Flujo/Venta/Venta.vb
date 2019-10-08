Imports System

Module Venta
	Sub Main(args As String())
		Dim Cantidad, Descuento As UShort
		Dim PrecioUnitario, SubTotal, MontoDescontado As Double
		IngresoDatos(Cantidad, PrecioUnitario)
		Calcular(Cantidad, Descuento, PrecioUnitario, SubTotal, MontoDescontado)
		Informe(Descuento, SubTotal, MontoDescontado)
		Console.ReadKey()
	End Sub

	Private Sub Informe(Descuento As UShort, SubTotal As Double, MontoDescontado As Double)
		Console.WriteLine("Subtotal: {0} ", SubTotal)
		Console.WriteLine("Porcentaje de descuento: {0}% Monto Descontado: {1}", Descuento, MontoDescontado)
		Console.WriteLine("Total: " & SubTotal - MontoDescontado)
	End Sub

	Private Sub Calcular(Cantidad As UShort, ByRef Descuento As UShort, PrecioUnitario As Double, ByRef SubTotal As Double, ByRef MontoDescontado As Double)
		If Cantidad >= 10 And Cantidad <= 50 Then
			Descuento = 5
		ElseIf Cantidad > 50 And Cantidad <= 250 Then
			Descuento = 10
		ElseIf Cantidad > 250 Then
			Descuento = 20
		Else
			Console.WriteLine("El producto no recibe descuento.")
		End If

		SubTotal = Cantidad * PrecioUnitario
		MontoDescontado = SubTotal * Descuento / 100
	End Sub

	Private Sub IngresoDatos(ByRef Cantidad As UShort, ByRef PrecioUnitario As Double)
		Console.Write("Ingrese la cantidad del producto: ")
		Cantidad = Console.ReadLine
		Console.Write("Ingrese precio del producto: ")
		PrecioUnitario = Console.ReadLine
	End Sub
End Module
'3.4.Crear un proyecto y un módulo “Venta” para resolver con IF:
'ingresar dos valores relacionados a un producto en venta: cantidad y precio unitario.
'Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, 
'si es entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. 
'Informar subtotal(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y 
'el total(subtotal – monto descontado). 