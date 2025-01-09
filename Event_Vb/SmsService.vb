Public Class SmsService
    Public Sub Send(ByVal sender As Object, ByVal message As MessageEventArgs)
        Console.WriteLine($"Send by sms : {message.Text}")
    End Sub
End Class
