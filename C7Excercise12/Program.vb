Imports System

Module Program
    Function fahrenheitToCelcius(ByVal fahrenheit As Integer)
        Dim celcius As Double
        celcius = (fahrenheit - 32) / 1.8

        Return celcius
    End Function
    Sub Main(args As String())
        Dim userTemperature As Integer
        Console.WriteLine("Enter the temperature in fahrenheit")
        userTemperature = Console.ReadLine

        Console.WriteLine("The temperature in celcius is " & fahrenheitToCelcius(userTemperature))
    End Sub
End Module
