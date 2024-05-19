Imports System

Module Program
    Structure countryInfomation
        Dim countryName As String
        Dim currencyName As String
        Dim exchangeRate As Double
    End Structure
    Sub Main(args As String())
        Dim country As countryInfomation
        Dim countryName, currencyName As String
        Dim exchangeRate As Double
        Console.WriteLine("Enter a country, its currency name and the exchange rate")
        countryName = Console.ReadLine
        currencyName = Console.ReadLine
        exchangeRate = Console.ReadLine

        country.countryName = countryName
        country.currencyName = currencyName
        country.exchangeRate = exchangeRate

        Console.WriteLine("The countries name is : " & country.countryName)
        Console.WriteLine("The currencies name is : " & country.currencyName)
        Console.WriteLine("The exchange rate is : " & country.exchangeRate)
    End Sub
End Module
