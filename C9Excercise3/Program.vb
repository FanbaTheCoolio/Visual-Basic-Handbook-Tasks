Imports System

Module Program
    Structure employee
        Dim name As String
        Dim number As String
        Dim totalHoursWorked As Integer
        Dim hourlyRateOfPay As Double
    End Structure
    Sub Main(args As String())
        Dim currentEmployee As employee
        Console.WriteLine("Enter an employees name, number, hours worked, and hourly rate of pay")

        currentEmployee.name = Console.ReadLine
        currentEmployee.number = Console.ReadLine
        currentEmployee.totalHoursWorked = Console.ReadLine
        currentEmployee.hourlyRateOfPay = Console.ReadLine

        Console.WriteLine("Employee : " & currentEmployee.name)
        Console.WriteLine("Number : " & currentEmployee.number)
        Console.WriteLine("Your gross pay : " & (currentEmployee.totalHoursWorked * currentEmployee.hourlyRateOfPay))
    End Sub
End Module
