Public Class Stock

    Public Delegate Sub OnPriceChangedHandler(ByVal message As String)
    Public Event OnPriceChanged As OnPriceChangedHandler
    Public Property Price As Integer
    Public Sub Update(ByVal newPrice As Integer)
        Price = newPrice
        RaiseEvent OnPriceChanged($"price changed to {Price}")
    End Sub
End Class
