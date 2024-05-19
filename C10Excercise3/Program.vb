Imports System

Module Program
    Const path = "C:\Users\fahee\source\repos\visualBasicIntroduction\C10Excercise3\peopleRecord.txt"
    Const newPath = "C:\Users\fahee\source\repos\visualBasicIntroduction\C10Excercise3\peopleRecord2.txt"
    Structure person
        Dim name As String
        Dim dateOfBirth As String
    End Structure
    Sub deleteRecord(ByVal recordToBeRemoved As String)
        Console.WriteLine("Name    Date Of Birth")

        Dim line As String

        FileOpen(1, path, OpenMode.Input)
        FileOpen(2, newPath, OpenMode.Output)
        Do While Not EOF(1)
            line = LineInput(1)
            If Not line = recordToBeRemoved Then
                PrintLine(2, line)
            Else
                PrintLine(2)
            End If


        Loop
        FileClose(1)
    End Sub
    Sub readRecords()

        Console.WriteLine("Name    Date Of Birth")

        Dim i As Integer = 1
        Dim line As String

        FileOpen(1, path, OpenMode.Input)

        Do While Not EOF(1)
            line = LineInput(1)

            Console.Write(line & "    ")
            If i Mod 2 = 0 Then
                Console.WriteLine()
            End If
            i += 1
        Loop
        FileClose(1)
    End Sub

    Sub findSpecifiedName(ByVal name As String)
        Dim i As Integer = 1
        Dim line As String
        Dim isFound As Boolean = False

        FileOpen(1, path, OpenMode.Input)

        Do While Not EOF(1)
            line = LineInput(1)

            If name = line Then
                Console.WriteLine("Name has been found")
                Console.WriteLine("Name : " & line)
                Console.WriteLine("Date Of Birth : " & LineInput(i))
                isFound = True
                Exit Do
            End If
        Loop
        If Not isFound Then
            Console.WriteLine("Record not found")
        End If
        FileClose(1)
    End Sub

    Sub Main(args As String())
        Dim currentName, currentDateOfBirth As String
        FileOpen(1, path, OpenMode.Output)
        Do While True
            Dim peopleRecord As person

            Console.WriteLine("Enter a name")
            currentName = Console.ReadLine

            If currentName = "" Then Exit Do


            Console.WriteLine("Enter a date of birth")
            currentDateOfBirth = Console.ReadLine

            peopleRecord.name = currentName
            peopleRecord.dateOfBirth = currentDateOfBirth


            PrintLine(1, currentName)
            PrintLine(1, currentDateOfBirth)


        Loop

        FileClose(1)

        readRecords()

        findSpecifiedName("faheem")

        deleteRecord("faheem")


    End Sub
End Module
