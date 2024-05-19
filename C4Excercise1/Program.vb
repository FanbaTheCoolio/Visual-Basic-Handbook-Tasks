Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber, secondNumber As Integer
        Console.WriteLine("Enter 2 numbers")

        firstNumber = Console.ReadLine()
        secondNumber = Console.ReadLine()

        If firstNumber = secondNumber Then
            Console.WriteLine("Your numbers are the same!")
        End If
    End Sub
End Module
