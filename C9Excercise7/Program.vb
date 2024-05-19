Imports System

Module Program
    Const range = 4
    Structure friendInfo
        Dim name As String
        Dim age As Integer
    End Structure

    Function getAverageAge(ByVal friendList() As friendInfo)
        Dim averageAge As Double
        For i As Integer = 0 To range
            averageAge += friendList(i).age
        Next
        averageAge /= range + 1
        averageAge = Math.Round(averageAge, 2)
        Return averageAge
    End Function

    Sub displayFriendsAgeComparedToAverage(ByVal friendList() As friendInfo, ByVal averageAge As Integer)
        For i As Integer = 0 To range
            If friendList(i).age > averageAge Then
                Console.WriteLine(friendList(i).name & " is older then the average age")
            ElseIf friendList(i).age < averageAge Then
                Console.WriteLine(friendList(i).name & " is younger then the average age")
            End If
        Next
    End Sub
    Sub Main(args As String())
        Dim friendList(0 To range) As friendInfo
        Dim averageAge As Integer
        For i As Integer = 0 To range
            Console.WriteLine("Enter friend's name and age")

            friendList(i).name = Console.ReadLine
            friendList(i).age = Console.ReadLine

        Next

        averageAge = getAverageAge(friendList)
        Console.WriteLine("The average age is " & averageAge)
        displayFriendsAgeComparedToAverage(friendList, averageAge)
    End Sub
End Module
