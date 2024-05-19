Imports System

Module Program
    Sub Main(args As String())
        Dim userChar As Char
        Console.WriteLine("Enter a character")
        userChar = Console.ReadLine
        Console.WriteLine(Asc(userChar))
    End Sub
End Module
