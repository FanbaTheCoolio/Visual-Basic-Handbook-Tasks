Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer
        Console.WriteLine("Number    Square Of Number")
        For i = 1 To 12 Step 1
            Console.Write(i & "         ")
            Console.Write(i * i)
            Console.WriteLine()
        Next i
    End Sub
End Module
