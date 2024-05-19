Imports System

Module Program
    Sub Main(args As String())
        Dim dateInput As String
        Dim currentDay, nextDay As Date
        Console.WriteLine("Enter date format")
        dateInput = Console.ReadLine
        Console.WriteLine(dateInput)
        currentDay = CDate(dateInput)
        nextDay = currentDay.AddDays(1)
        Console.WriteLine(nextDay)
    End Sub
End Module
