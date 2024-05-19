Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber, secondNumber, thirdNumber As Integer
        Console.WriteLine("Enter the values for 3 numbers")
        firstNumber = Console.ReadLine()
        secondNumber = Console.ReadLine()
        thirdNumber = Console.ReadLine()

        If firstNumber > secondNumber And firstNumber > thirdNumber Then
            Console.WriteLine("Your first number was larger")
        ElseIf secondNumber > firstNumber And secondNumber > thirdNumber Then
            Console.WriteLine("Your second number was larger")
        ElseIf thirdNumber > firstNumber And thirdNumber > secondNumber Then
            Console.WriteLine("Your third number was larger")
        End If
    End Sub
End Module