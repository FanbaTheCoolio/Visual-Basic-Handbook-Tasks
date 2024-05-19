Imports System

Module Program
    Const range = 14
    Structure employee
        Dim name As String
        Dim number As String
        Dim totalHoursWorked As Integer
        Dim hourlyRateOfPay As Double
    End Structure
    Sub Main(args As String())
        Dim currentEmployee(0 To range) As employee
        Dim isFound As Boolean

        Dim numberToSearchFor As String
        For i As Integer = 0 To range
            Console.WriteLine("Enter an employees name, number, hours worked, and hourly rate of pay")

            currentEmployee(i).name = Console.ReadLine
            currentEmployee(i).number = Console.ReadLine
            currentEmployee(i).totalHoursWorked = Console.ReadLine
            currentEmployee(i).hourlyRateOfPay = Console.ReadLine
        Next

        Console.WriteLine("Enter employee number to search for")
        numberToSearchFor = Console.ReadLine
        For i = 0 To range
            If numberToSearchFor = currentEmployee(i).number Then
                isFound = True
                Console.WriteLine("Employee : " & currentEmployee(i).name)
                Console.WriteLine("Your gross pay : " & (currentEmployee(i).totalHoursWorked * currentEmployee(i).hourlyRateOfPay))
            End If
        Next

        If Not isFound Then
            Console.WriteLine("Employee could not be found")
        End If
    End Sub
End Module
