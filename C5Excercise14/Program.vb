Imports System

Module Program
    Sub Main(args As String())
        Dim currentInput, maximum, i As Integer

        For i = 1 To 8
            Console.WriteLine("Enter a number")
            currentInput = Console.ReadLine
            If currentInput > maximum Then maximum = currentInput
        Next
        Console.WriteLine("The greatest number you inputed is " & maximum)
    End Sub
End Module
