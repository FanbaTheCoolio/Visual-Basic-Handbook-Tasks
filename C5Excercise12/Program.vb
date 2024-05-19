

Module Program
    Sub Main(args As String())
        Dim userInput, i, average As Integer

        i = 1
        Console.WriteLine(userInput)
        Do
            Console.WriteLine("Enter a number within the range of 10-20")
            userInput = Console.ReadLine

            If userInput >= 10 And userInput <= 20 Then
                average += userInput
                i += 1
            Else
                Console.WriteLine("Input not in range")
            End If



        Loop Until userInput = 0

        average /= i
        Console.WriteLine("The average of your valid numbers is " & average)
    End Sub
End Module
