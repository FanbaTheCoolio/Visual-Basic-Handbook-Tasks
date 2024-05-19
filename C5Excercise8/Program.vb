Imports System

Module Program
    Sub Main(args As String())
        Dim i, userInput, sum, average, amountOfNumbers As Integer

        Console.WriteLine("Enter the amount of numbers you want to be averaged")
        amountOfNumbers = Console.ReadLine


        For i = 0 To amountOfNumbers - 1 Step 1
            Console.WriteLine("Enter a value")
            userInput = Console.ReadLine
            sum += userInput
        Next

        average = sum / i
        Console.WriteLine("The average is " & average)
    End Sub
End Module
