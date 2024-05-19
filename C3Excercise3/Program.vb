Imports System

Module Program

    Sub Main(args As String())
        Dim fahrenheitTemperature, centigradeTemperature As Double
        Console.WriteLine("Enter the temperature in fahrenheit")
        fahrenheitTemperature = Console.ReadLine()

        centigradeTemperature = (fahrenheitTemperature - 32) / 1.8

        Console.WriteLine("The temperature in celcius is : " & centigradeTemperature)
    End Sub
End Module
