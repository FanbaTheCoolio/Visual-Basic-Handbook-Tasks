Imports System

Module Program
    Const range = 4
    Structure TStudent
        Dim firstName As String
        Dim surname As String
        Dim depositPaid As Decimal
        Dim dateOfBirth As Date
    End Structure
    Sub Main(args As String())
        Dim studentList(0 To range) As TStudent

        For i As Integer = 0 To range
            Console.WriteLine("Enter student forename, surname, deposit paid, and Dob")

            studentList(i).firstName = Console.ReadLine
            studentList(i).surname = Console.ReadLine
            studentList(i).depositPaid = Console.ReadLine
            studentList(i).dateOfBirth = CDate(Console.ReadLine)
        Next

        Console.WriteLine("Forename    Surname    Deposit    Dob")
        For i = 0 To 2
            Console.Write(studentList(i).firstName & "    " & studentList(i).surname & "    " & studentList(i).depositPaid & "    " & studentList(i).dateOfBirth)
            Console.WriteLine()
        Next
    End Sub
End Module
