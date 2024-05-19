Imports System

Module Program
    Sub Main(args As String())
        Dim i, randomNumber As Integer
        Randomize()
        For i = 0 To 5
            randomNumber = Int(Rnd() * 6) + 5
            Console.WriteLine("A " & randomNumber & " was rolled")
        Next


    End Sub
End Module
