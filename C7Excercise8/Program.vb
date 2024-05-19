Imports System

Module Program
    Sub Main(args As String())
        Dim firstName, secondName, firstNameEdit, secondNameEdit, fullName
        Console.WriteLine("Enter your first name followed by your second")
        firstName = Console.ReadLine
        secondName = Console.ReadLine

        firstNameEdit = UCase(Left(firstName, 1)) + LCase(Right(firstName, Len(firstName) - 1))
        secondNameEdit = UCase(secondName)
        fullName = firstNameEdit + " " + secondNameEdit
        Console.WriteLine(fullName)
    End Sub
End Module
