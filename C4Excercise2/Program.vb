Imports System

Module Program
    Sub Main(args As String())
        Dim age As Integer
        Console.WriteLine("What is your age")

        age = Console.ReadLine()

        If age >= 17 Then
            Console.WriteLine("You can drive")
        Else
            Console.WriteLine("You can't drive")
        End If
    End Sub
End Module
