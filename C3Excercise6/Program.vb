Imports System

Module Program
    Const costOfTurf = 10
    Sub Main(args As String())
        Dim length, width, area, totalCost As Integer

        Console.WriteLine("Enter the length and width of a rectangular-shaped garden")

        length = Console.ReadLine()
        width = Console.ReadLine()

        area = length * width
        totalCost = area * costOfTurf

        Console.WriteLine("The total cost of covering the garden in turf is " & totalCost)
    End Sub
End Module
