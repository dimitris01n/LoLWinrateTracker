Public Class QueueStats
    Public Wins As Integer
    Public Losses As Integer

    ' Στόχος winrate (0..1). π.χ. 0.6 για 60%
    Public Target As Double = 0.0

    <Newtonsoft.Json.JsonIgnore>
    Public ReadOnly Property Winrate As Double
        Get
            Dim total = Wins + Losses
            If total = 0 Then Return 0
            Return Wins / total
        End Get
    End Property

    ' Πόσα επιπλέον wins χρειάζονται για να φτάσουμε το Target
    <Newtonsoft.Json.JsonIgnore>
    Public ReadOnly Property NeededWinsToTarget As Integer?
        Get
            Dim t = Target
            Dim w = Wins
            Dim l = Losses

            ' sanity clamps
            If t <= 0 Then Return 0
            If t >= 1.0 Then
                If l = 0 AndAlso (w > 0) Then Return 0
                ' πρακτικά ανέφικτο (χωρίς άπειρα wins)
                Return Nothing ' N/A
            End If

            Dim numerator As Double = t * (w + l) - w
            Dim denom As Double = 1.0 - t

            If numerator <= 0 Then Return 0

            Dim x As Double = numerator / denom
            Dim ceil As Integer = CInt(Math.Ceiling(x))
            If ceil < 0 Then ceil = 0
            Return ceil
        End Get
    End Property
End Class