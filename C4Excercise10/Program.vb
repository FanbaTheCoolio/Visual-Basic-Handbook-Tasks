Imports System

Module Program
    Sub Main(args As String())
        Dim amountOfHoursWorked, amountOfExtraHoursWorked, hourlyRate, amountOfExtraHours, grossPay As Double
        Console.WriteLine("Enter amount of hours worked and your hourly rate")
        amountOfHoursWorked = Console.ReadLine()
        hourlyRate = Console.ReadLine()

        If amountOfHoursWorked <= 60 And amountOfHoursWorked >= 0 Then
            If amountOfHoursWorked > 40 Then
                amountOfExtraHours = amountOfHoursWorked - 40
                grossPay = amountOfExtraHours * (hourlyRate * 1.5)
                grossPay += 40 * hourlyRate
            Else
                grossPay = amountOfHoursWorked * hourlyRate
            End If
            Console.WriteLine("Your gross pay is " & grossPay)
        Else
            Console.WriteLine("Amount of hours worked is not in range 0-60")
        End If
    End Sub
End Module
