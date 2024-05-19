Imports System

Module Program
    Sub Main(args As String())
        Dim i, j, amountOfStars, amountOfRows As Integer
        Console.WriteLine("Enter amount of stars per row and number of rows to be displayed")

        amountOfStars = Console.ReadLine()
        amountOfRows = Console.ReadLine()

        For i = 1 To amountOfRows Step 1
            For j = 1 To amountOfStars Step 1
                Console.Write("*")
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Module
