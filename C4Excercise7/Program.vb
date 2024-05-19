Imports System

Module Program
    Sub Main(args As String())
        Dim monthNumber As Integer
        Console.WriteLine("Enter a month number")
        monthNumber = Console.ReadLine()

        Select Case monthNumber
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("Month has 31 days")
            Case 4, 6, 9, 11
                Console.WriteLine("Month has 30 days")
            Case 2
                Console.WriteLine("Month has 28 days")
        End Select
    End Sub
End Module
