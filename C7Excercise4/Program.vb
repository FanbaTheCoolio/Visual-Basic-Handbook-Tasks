Imports System

Module Program
    Sub Main(args As String())
        Dim asciiCode As Integer
        Console.WriteLine("Enter a character")
        asciiCode = Console.ReadLine
        Console.WriteLine(ChrW(asciiCode))
    End Sub
End Module
