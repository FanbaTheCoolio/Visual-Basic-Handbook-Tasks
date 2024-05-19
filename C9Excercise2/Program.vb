Imports System

Module Program
    Structure countryInfomation
        Dim countryName As String
        Dim currencyName As String
        Dim exchangeRate As Double
    End Structure
    Sub Main(args As String())
        Dim country(0 To 2) As countryInfomation
        Dim countryName, currencyName As String
        Dim exchangeRate As Double
        Dim i As Integer
        For i = 0 To 2
            Console.WriteLine("Enter a country, its currency name and the exchange rate")
            countryName = Console.ReadLine
            currencyName = Console.ReadLine
            exchangeRate = Console.ReadLine

            country(i).countryName = countryName
            country(i).currencyName = currencyName
            country(i).exchangeRate = exchangeRate

        Next

        Console.WriteLine("Name    Currency    Exchange")
        For i = 0 To 2
            Console.Write(country(i).countryName & "    " & country(i).currencyName & "    " & country(i).exchangeRate)
            Console.WriteLine()
        Next
    End Sub
End Module
