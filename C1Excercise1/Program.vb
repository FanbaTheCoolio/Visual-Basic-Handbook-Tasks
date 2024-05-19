Imports System

Module Program
    Sub Main(args As String())
        Dim firstInput, secondInput, thirdInput, sum As Integer

        Console.WriteLine("Enter 3 integers")
        firstInput = Console.ReadLine()
        secondInput = Console.ReadLine()
        thirdInput = Console.ReadLine()

        sum = firstInput + secondInput + thirdInput

        Console.WriteLine("The sum is " & sum)
        Console.Read()
    End Sub
End Module
