Imports System

Module Program
    Sub Main(args As String())
        Dim userString As String

        Console.WriteLine("Enter a string")
        userString = Console.ReadLine
        Console.WriteLine(Len(userString))
    End Sub
End Module
