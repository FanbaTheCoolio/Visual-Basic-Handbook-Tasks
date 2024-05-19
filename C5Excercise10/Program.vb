Imports System

Module Program
    Sub Main(args As String())
        Dim userInput, sum As Integer
        userInput = 1

        Do Until userInput = 0
            Console.WriteLine("Enter your value")
            userInput = Console.ReadLine
            sum += userInput
        Loop
        Console.WriteLine("The sum is " & sum)
    End Sub
End Module
