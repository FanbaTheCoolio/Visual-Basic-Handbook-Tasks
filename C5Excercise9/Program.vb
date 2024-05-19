Imports System

Module Program
    Sub Main(args As String())
        Dim i, timesTableToBeShown

        Console.WriteLine("Enter a time table to be shown")
        timesTableToBeShown = Console.ReadLine

        For i = 1 To 12 Step 1
            Console.WriteLine(i & " * " & timesTableToBeShown & " = " & i * timesTableToBeShown)
        Next
    End Sub
End Module
