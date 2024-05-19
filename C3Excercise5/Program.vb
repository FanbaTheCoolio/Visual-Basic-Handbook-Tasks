Imports System

Module Program
    Sub Main(args As String())
        Dim shallowHeight, shallowLength, shallowDepth, shallowVolume, deepHeight, deepWidth, deepLength, deepVolume, totalVolume As Integer
        Console.WriteLine("Enter the height, length and depth of the shallowest part of the pool")

        shallowHeight = Console.ReadLine()
        shallowLength = Console.ReadLine()
        shallowDepth = Console.ReadLine()

        Console.WriteLine("Enter the height, length and depth of the deepest part of the pool")


        deepHeight = Console.ReadLine()
        deepWidth = Console.ReadLine()
        deepLength = Console.ReadLine()

        shallowVolume = shallowLength * shallowHeight * shallowDepth
        deepVolume = deepLength * deepHeight * deepHeight
        totalVolume = shallowVolume + deepVolume

        Console.WriteLine("The total volume is " & totalVolume)

    End Sub
End Module
