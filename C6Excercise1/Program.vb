Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer
        Dim listOfNames(0 To 5) As String
        Dim currentName As String

        For i = 0 To 5
            Console.WriteLine("Enter a name")
            listOfNames(i) = Console.ReadLine
        Next

        For i = 0 To 5
            Console.WriteLine(listOfNames(i))
        Next
        For i = 5 To 0 Step -1
            Console.WriteLine(listOfNames(i))
        Next
    End Sub
End Module
