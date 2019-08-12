Imports System

Module Angulo
    Sub Main(args As String())
        Dim angulo As Short


        Console.Write("Ingresa tamaño de angulos: ")
        angulo = Console.ReadLine


        Select Case angulo
            Case angulo > 0, < 90
                Console.WriteLine("El angulo es Agudo")
            Case = 90
                Console.WriteLine("El angulo es recto")
            Case angulo > 90, < 180
                Console.WriteLine("El angulo es obtuso")
            Case = 180
                Console.WriteLine("EL angulo es Llano")
            Case angulo > 180 To 360
                Console.WriteLine("El angulo es concavo")
            Case Else
                Console.WriteLine("Error, tamaño ingresado incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module
'3.7. Crear un proyecto y un módulo “Angulo” para resolver con CASE: ingresar el tamaño de un ángulo en grados
'e imprimir el mensaje correspondiente según la siguiente tabla: 
'Agudo si es menor a 90° 
'Recto si es igual a 90° 
'Obtuso si es mayor que 90° pero menor que 180° 
'Llano si es igual a 180° 
'Cóncavo si es mayor que 180° pero menor que 360° 
'Error Si el valor es menor a 0º o mayor de 36