Imports System

Module Angulo
    Sub Main(args As String())
        Dim angulo As Short


        Console.Write("Ingresa tama�o de angulos: ")
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
                Console.WriteLine("Error, tama�o ingresado incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module
'3.7. Crear un proyecto y un m�dulo �Angulo� para resolver con CASE: ingresar el tama�o de un �ngulo en grados
'e imprimir el mensaje correspondiente seg�n la siguiente tabla: 
'Agudo si es menor a 90� 
'Recto si es igual a 90� 
'Obtuso si es mayor que 90� pero menor que 180� 
'Llano si es igual a 180� 
'C�ncavo si es mayor que 180� pero menor que 360� 
'Error Si el valor es menor a 0� o mayor de 36