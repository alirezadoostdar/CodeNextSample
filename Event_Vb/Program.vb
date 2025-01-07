Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())
        Dim smsService As New SmsService()
        Dim emailService As New EmailService()
        Dim stock As New Stock
        Dim price As Integer = 0
        AddHandler stock.OnPriceChanged, AddressOf smsService.Send
        AddHandler stock.OnPriceChanged, AddressOf emailService.Send
        Dim rnd As New Random
        While True
            price = rnd.Next(10000, 50000)
            stock.Update(price)
            Thread.Sleep(500)
        End While
        Console.WriteLine("Hello World!")
    End Sub
End Module
