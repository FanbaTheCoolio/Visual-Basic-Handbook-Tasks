Imports System

Module Program
    Sub Main(args As String())
        Dim name, welcomeMessage As String

        Console.WriteLine("Enter your name?")
        name = Console.ReadLine()

        welcomeMessage = "Welcome " + name + " How are you?"

        Console.WriteLine(welcomeMessage)
    End Sub
End Module
