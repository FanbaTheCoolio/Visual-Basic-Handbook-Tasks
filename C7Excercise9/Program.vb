Imports SystemImports System

Module Program
    Sub Main(args As String())
        Dim randomNumber As Integer
        Randomize()
        Do
            randomNumber = Int(Rnd() * 6) + 1
            Console.WriteLine("A " & randomNumber & " was rolled")
        Loop Until randomNumber = 6
    End Sub
End Module