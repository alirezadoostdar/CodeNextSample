Public Class EmailService
    Public Sub Send(ByVal sender As Object, ByVal message As MessageEventArgs)
        Console.WriteLine($"Send by email : {message.Text}")
    End Sub
End Class
