Imports System

Module Program
    Dim counters As Integer

    Sub initialiseGame()
        Do
            Console.WriteLine("Enter how many counters you would like to use? (10-50)")
            counters = Console.ReadLine
            If Not (counters >= 10 And counters <= 50) Then
                Console.WriteLine("Your number is not within the range")
            End If
        Loop Until counters >= 10 And counters <= 50
    End Sub

    Sub userTakeCounter()
        Dim countersToRemove As Integer
        Do
            Console.WriteLine("How many counters would you like to remove (1-3)")
            countersToRemove = Console.ReadLine
            If Not (countersToRemove >= 1 And countersToRemove <= 3) Then
                Console.WriteLine("Your number is not within the range")
            End If
        Loop Until countersToRemove >= 1 And countersToRemove <= 3
        counters -= countersToRemove
        Console.WriteLine("Their are " & counters & " counters left")
    End Sub

    Sub programTakesCounter()
        Dim countersToRemove As Integer
        countersToRemove = Int(Rnd() * 3) + 1
        counters -= countersToRemove
        Console.WriteLine("The program took " & countersToRemove)
        Console.WriteLine("Their are " & counters & " counters left")
    End Sub
    Sub Main(args As String())
        initialiseGame()
        Do
            userTakeCounter()
            programTakesCounter()
        Loop Until counters < 5
        Console.WriteLine("Game Over")
    End Sub
End Module
