Imports System

Module Program
    Sub Main(args As String())
        Dim userGuess, randomNumber As Integer
        Randomize()

        randomNumber = Int(Rnd() * 99) + 1

        Do
            Console.WriteLine("Enter your guess")
            userGuess = Console.ReadLine
            If userGuess > randomNumber Then
                Console.WriteLine("Your guess was to large")
            ElseIf userGuess < randomNumber Then
                Console.WriteLine("Your guess was to small")
            ElseIf userGuess = randomNumber Then
                Console.WriteLine("Correct!")
            End If
        Loop Until userGuess = randomNumber
    End Sub
End Module
