Imports System

Module Program
    Sub Main(args As String())
        Dim phrase As String
        Dim amountToRepeat, i As Integer

        Console.WriteLine("Enter a phrase and how many times you want it to be repeated")

        phrase = Console.ReadLine()
        amountToRepeat = Console.ReadLine()

        For i = 1 To amountToRepeat Step 1
            Console.WriteLine(phrase)
        Next i
    End Sub
End Module
