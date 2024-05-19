Imports System

Module Program
    Sub Main(args As String())
        Dim listOfNumbers(0 To 48), randomNumber, i As Integer
        Randomize()
        For i = 1 To 49
            listOfNumbers(i - 1) = i
        Next
        i = 0
        Do Until i = 6
            randomNumber = Int(Rnd() * 48)
            If listOfNumbers(randomNumber) <> 0 Then
                Console.WriteLine(listOfNumbers(randomNumber))
                listOfNumbers(randomNumber) = 0
                i += 1
            End If

        Loop



    End Sub
End Module
