Imports System

Module Program
    Sub Main(args As String())
        Dim examMark As Integer
        Console.WriteLine("What exam mark did you get")
        examMark = Console.ReadLine()

        Select Case examMark
            Case 0 To 40
                Console.WriteLine("Grade U")
            Case 41 To 50
                Console.WriteLine("Grade E")
            Case 51 To 60
                Console.WriteLine("Grade D")
            Case 61 To 70
                Console.WriteLine("Grade C")
            Case 71 To 80
                Console.WriteLine("Grade B")
            Case 81 To 100
                Console.WriteLine("Grade A")

        End Select
    End Sub
End Module
