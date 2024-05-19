Imports System

Module Program
    Sub Main(args As String())
        Dim waterTemperature As Integer
        Console.WriteLine("State the temperature of the water in the container")
        waterTemperature = Console.ReadLine()
        If waterTemperature >= 100 Then
            Console.WriteLine("Boiling")
        ElseIf waterTemperature <= 0 Then
            Console.WriteLine("Freezing")
        Else
            Console.WriteLine("Neither")
        End If
    End Sub
End Module
