Imports System

Module Program
    Sub Main(args As String())
        Dim userNumber As Integer
        Console.WriteLine("Enter a number")
        userNumber = Console.ReadLine()

        If userNumber >= 21 And userNumber <= 29 Then
            Console.WriteLine("Number is within range")
        Else
            Console.WriteLine("Number is not within range")
        End If
    End Sub
End Module
