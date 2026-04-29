Public Class DualAdjustDialog
    Public Property QueueName As String = "Mode"
    Public Property CurrentWins As Integer = 0
    Public Property CurrentLosses As Integer = 0

    Public ReadOnly Property ResultWins As Integer
        Get
            Return _resultWins
        End Get
    End Property

    Public ReadOnly Property ResultLosses As Integer
        Get
            Return _resultLosses
        End Get
    End Property

    Private _resultWins As Integer = 0
    Private _resultLosses As Integer = 0

    Private Sub DualAdjustDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Adjust " & QueueName
        txtWins.Text = CurrentWins.ToString()
        txtLosses.Text = CurrentLosses.ToString()

        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.AcceptButton = btnOK
        Me.CancelButton = btnCancel
    End Sub

    ' --- Wins ---
    Private Sub btnWinsPlus_Click(sender As Object, e As EventArgs) Handles btnWinsPlus.Click
        Dim v = ParseInt(txtWins.Text)
        txtWins.Text = (v + 1).ToString()
    End Sub

    Private Sub btnWinsMinus_Click(sender As Object, e As EventArgs) Handles btnWinsMinus.Click
        Dim v = ParseInt(txtWins.Text)
        If v > 0 Then v -= 1
        txtWins.Text = v.ToString()
    End Sub

    ' --- Losses ---
    Private Sub btnLossPlus_Click(sender As Object, e As EventArgs) Handles btnLossPlus.Click
        Dim v = ParseInt(txtLosses.Text)
        txtLosses.Text = (v + 1).ToString()
    End Sub

    Private Sub btnLossMinus_Click(sender As Object, e As EventArgs) Handles btnLossMinus.Click
        Dim v = ParseInt(txtLosses.Text)
        If v > 0 Then v -= 1
        txtLosses.Text = v.ToString()
    End Sub

    ' --- OK / Cancel ---
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim w = ParseInt(txtWins.Text)
        Dim l = ParseInt(txtLosses.Text)
        If w < 0 OrElse l < 0 Then
            MessageBox.Show("Δώσε μη αρνητικούς ακέραιους.")
            Exit Sub
        End If
        _resultWins = w
        _resultLosses = l
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ParseInt(s As String) As Integer
        Dim v As Integer
        If Integer.TryParse((If(s, "")).Trim(), v) AndAlso v >= 0 Then
            Return v
        End If
        Return 0
    End Function
End Class