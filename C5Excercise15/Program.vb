Imports System

Module Program
    Sub Main(args As String())
        Dim currentInput, minimum, maximum, i As Integer

        For i = 1 To 8
            Console.WriteLine("Enter a number")
            currentInput = Console.ReadLine
            If currentInput > maximum Then maximum = currentInput
            If currentInput < minimum Then minimum = currentInput
        Next
        Console.WriteLine("The greatest number you inputed is " & maximum)
        Console.WriteLine("The smallest number you inputed is " & minimum)
    End Sub
End Module
