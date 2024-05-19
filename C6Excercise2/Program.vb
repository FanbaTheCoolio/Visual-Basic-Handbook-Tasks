Imports System

Module Program
    Sub Main(args As String())
        Dim tally(0 To 5), diceRoll, i As Integer
        Randomize()


        For i = 1 To 30
            diceRoll = Int(Rnd() * 6)
            tally(diceRoll) = tally(diceRoll) + 1
        Next

        For i = 0 To 5
            Console.WriteLine("Number of " & i + 1 & "'s " & tally(i))
        Next
    End Sub
End Module
