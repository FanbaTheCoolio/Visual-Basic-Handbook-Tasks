Imports System

Module Program
    Const path = "C:\Users\fahee\source\repos\visualBasicIntroduction\C10Excercise1\Test.txt"
    Sub Main(args As String())
        FileOpen(1, path, OpenMode.Output)
        For i As Integer = 0 To 4
            Console.WriteLine("Enter a line")
            PrintLine(1, Console.ReadLine)
        Next
        FileClose(1)
    End Sub
End Module
