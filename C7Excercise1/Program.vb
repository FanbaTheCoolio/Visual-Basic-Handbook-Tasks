Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As Double
        Console.WriteLine("Enter a decimal number")
        userInput = Console.ReadLine
        Console.WriteLine(Math.Round(userInput))
        Console.WriteLine(Math.Truncate(userInput))
    End Sub
End Module
