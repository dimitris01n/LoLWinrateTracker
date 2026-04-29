Namespace Models
    Class AppState
        Public SoloQ As New QueueStats()
        Public Flex As New QueueStats()
        Public Normal As New QueueStats()
        Public Active As String = "SoloQ" ' "Flex" or "Normal"
    End Class
End Namespace