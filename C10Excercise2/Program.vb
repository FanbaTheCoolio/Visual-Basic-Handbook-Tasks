Imports System

Module Program
    Const path = "C:\Users\fahee\source\repos\visualBasicIntroduction\C10Excercise2\Input.txt"
    Sub Main(args As String())
        Dim line As String
        FileOpen(1, path, OpenMode.Input)
        Do While Not EOF(1)
            line = LineInput(1)
            Console.WriteLine(line)
        Loop
        FileClose(1)
    End Sub
End Module
