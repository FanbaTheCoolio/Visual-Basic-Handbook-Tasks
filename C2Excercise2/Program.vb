Imports System

Module Program
    Sub Main(args As String())
        Dim firstInput, secondInput, product As Integer

        Console.WriteLine("Enter 2 integers")
        firstInput = Console.ReadLine()
        secondInput = Console.ReadLine()

        product = firstInput * secondInput

        Console.WriteLine("The product is " & product)
        Console.Read()
    End Sub
End Module

