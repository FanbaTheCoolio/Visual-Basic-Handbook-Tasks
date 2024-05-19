Imports System

Module Program
    Sub Main(args As String())
        Dim inchesHeight, centimetreHeight, stoneWeight, kilogramWeight As Double
        Console.WriteLine("Enter height in inches and weight in stone")
        inchesHeight = Console.ReadLine()
        stoneWeight = Console.ReadLine()

        centimetreHeight = inchesHeight * 2.54
        kilogramWeight = stoneWeight * 6.364

        Console.WriteLine("Your height in centimetres is " & centimetreHeight & " and your weight in kilograms is " & kilogramWeight)

    End Sub
End Module
