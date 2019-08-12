Imports System

Module Descuento
    Sub Main(args As String())
        Dim cantidad, PrecioUnitario As UShort
        Dim descuento, subtotal, MontoDescontado, Total As Decimal
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