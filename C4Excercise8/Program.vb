Imports System

Module Program
    Sub Main(args As String())
        Dim monthNumber As Integer
        Console.WriteLine("Enter a month number")
        monthNumber = Console.ReadLine()

        Select Case monthNumber
            Case 1
                Console.WriteLine("January")
            Case 2
                Console.WriteLine("February")
            Case 3
                Console.WriteLine("March")
            Case 4
                Console.WriteLine("April")
            Case 5
                Console.WriteLine("May")
            Case 6
                Console.WriteLine("June")
            Case 7
                Console.WriteLine("July")
            Case 8
                Console.WriteLine("August")
            Case 9
                Console.WriteLine("September")
            Case 10
                Console.WriteLine("October")
            Case 11
                Console.WriteLine("November")
            Case 12
                Console.WriteLine("December")
        End Select
    End Sub
End Module
