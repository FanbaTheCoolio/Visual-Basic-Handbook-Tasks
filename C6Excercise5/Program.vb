Imports System

Module Program
    Sub Main(args As String())
        Dim randomCountry, i, score As Integer
        Dim countries(0 To 3, 0 To 1), guess As String
        countries(0, 0) = "England"
        countries(0, 1) = "London"

        countries(1, 0) = "France"
        countries(1, 1) = "Paris"

        countries(2, 0) = "Germany"
        countries(2, 1) = "Berlin"

        countries(3, 0) = "America"
        countries(3, 1) = "Washington"

        Randomize()


        For i = 0 To 4
            randomCountry = Int(Rnd() * 3)

            Console.WriteLine("What is the capital of " & countries(randomCountry, 0))
            guess = Console.ReadLine
            If guess = countries(randomCountry, 1) Then
                Console.WriteLine("Well done you got it right")
                score += 1
            Else
                Console.WriteLine("You got it wrong it was " & countries(randomCountry, 1))
            End If
        Next
        Console.WriteLine("You got " & score & "/5")
    End Sub
End Module
