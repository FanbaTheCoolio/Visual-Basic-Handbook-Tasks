Imports System

Module Program
    Sub Main(args As String())
        Dim length, width, depth, volume As Double
        Console.WriteLine("Enter the length, width and depth of your swimming pool")
        length = Console.ReadLine()
        width = Console.ReadLine()
        depth = Console.ReadLine()
        volume = length * width * depth
        Console.WriteLine("The amount of water needed to fill the pool is " & volume)
    End Sub
End Module
