Public Class Stock

    'Public Delegate Sub OnPriceChangedHandler(ByVal message As String)
    'Public Event OnPriceChanged As OnPriceChangedHandler
    Public Event PriceChanged As EventHandler(Of MessageEventArgs)
    Protected Overridable Sub OnPriceChanged(ByVal e As MessageEventArgs)
        RaiseEvent PriceChanged(Me, New MessageEventArgs($"new price is : {Price}"))
    End Sub
    Public Property Price As Integer
    Public Sub Update(ByVal newPrice As Integer)
        Price = newPrice
        OnPriceChanged(New MessageEventArgs($"new price is : {Price}"))
    End Sub
End Class

Public Class MessageEventArgs
    Inherits EventArgs
    Public ReadOnly Property Text As String
    Sub New(ByVal text As String)
        Me.Text = text
    End Sub
End Class
