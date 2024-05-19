Imports System

Module Program
    Sub Main(args As String())
        Dim firstRealNumber, secondRealNumber, product As Double
        Console.WriteLine("Enter 2 decimal numbers")

        firstRealNumber = Console.ReadLine()
        secondRealNumber = Console.ReadLine()
        product = firstRealNumber * secondRealNumber

        Console.WriteLine("The product of these 2 real's are: " + product.ToString("N2"))
    End Sub
End Module
