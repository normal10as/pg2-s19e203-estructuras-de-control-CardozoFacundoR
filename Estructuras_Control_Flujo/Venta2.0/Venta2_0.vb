Imports System

Module Venta2_0
	Enum descuento
		descuento1 = 5
		descuento2 = 10
		descuento3 = 20
	End Enum
	Sub Main(args As String())
		Dim Cantidad, porcdescuento As UShort
		Dim PrecioUnitario, SubTotal, MontoDescontado As Double
		IngresoDatos(Cantidad, PrecioUnitario)
		OperacionDescuento(Cantidad, porcdescuento, PrecioUnitario, SubTotal, MontoDescontado)
		Console.WriteLine(" Subtotal: {0} ", SubTotal)
		Console.WriteLine("Porcentaje de descuento: {0}% Monto Descontado: {1}", porcdescuento, MontoDescontado)
		Console.WriteLine("Total: " & SubTotal - MontoDescontado)
		Console.ReadKey()
	End Sub

	Private Sub OperacionDescuento(Cantidad As UShort, ByRef porcdescuento As UShort, PrecioUnitario As Double, ByRef SubTotal As Double, ByRef MontoDescontado As Double)
		SubTotal = Cantidad * PrecioUnitario
		Select Case Cantidad
			Case 10 To 50
				MontoDescontado = SubTotal * descuento.descuento1 / 100
				porcdescuento = 5
			Case 51 To 250
				MontoDescontado = SubTotal * descuento.descuento2 / 100
				porcdescuento = 10
			Case > 250
				MontoDescontado = SubTotal * descuento.descuento3 / 100
				porcdescuento = 20
			Case Else
				porcdescuento = 0
				Console.WriteLine("El producto no recibe descuento.")
		End Select
	End Sub

	Private Sub IngresoDatos(ByRef Cantidad As UShort, ByRef PrecioUnitario As Double)
		Console.Write("Ingrese la cantidad del producto: ")
		Cantidad = Console.ReadLine
		Console.Write("Ingrese precio del producto: ")
		PrecioUnitario = Console.ReadLine
	End Sub
End Module
'3.6.Crear un proyecto y un módulo “Venta2.0”, para resolver el problema “Venta” (3.4) con CASE. 
'3.4.Crear un proyecto y un módulo “Venta” para resolver con IF:
'ingresar dos valores relacionados a un producto en venta: cantidad y precio unitario.
'Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, 
'si es entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. 
'Informar subtotal(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y 
'el total(subtotal – monto descontado). 