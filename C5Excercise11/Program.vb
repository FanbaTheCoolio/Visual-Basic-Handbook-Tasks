Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As Integer
        Do Until (userInput >= 10 And userInput <= 20)
            Console.WriteLine("Enter a number within the range of 10-20")
            userInput = Console.ReadLine
        Loop
        Console.WriteLine("Input validated")
    End Sub
End Module
