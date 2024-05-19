Imports System

Module Program
    Const conversionRate = 2.2
    Sub Main(args As String())
        Dim i As Integer

        For i = 1 To 20 Step 1
            Console.WriteLine(i & "kg = " & i * conversionRate.ToString("2F") & " pounds")
        Next
    End Sub
End Module
