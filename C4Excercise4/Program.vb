Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber, secondNumber As Integer
        Console.WriteLine("Enter the values for 2 numbers")
        firstNumber = Console.ReadLine()
        secondNumber = Console.ReadLine()

        If firstNumber > secondNumber Then
            Console.WriteLine("Your first number was larger")
        ElseIf secondNumber > firstNumber Then
            Console.WriteLine("Your second number was larger")
        ElseIf firstNumber = secondNumber Then
            Console.WriteLine("Both numbers are equal")
        End If
    End Sub
End Module
