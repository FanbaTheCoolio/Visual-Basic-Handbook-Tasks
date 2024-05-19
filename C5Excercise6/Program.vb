Imports System

Module Program
    Sub Main(args As String())
        Dim i, maximum As Integer
        Console.WriteLine("Enter a number")

        maximum = Console.ReadLine

        For i = 1 To maximum Step 1
            Console.WriteLine(i * i)
        Next
    End Sub
End Module
