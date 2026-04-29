Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports WinRateTracker.Models

Public Class WinrateTrackerForm
    ' ==== State ====
    Private state As New AppState()
    Private isDirty As Boolean = False
    Private ReadOnly savePath As String = Path.Combine(Application.StartupPath, "appstate.json")

    Private Sub LoadState()
        Try
            If File.Exists(savePath) Then
                Dim json = File.ReadAllText(savePath)
                Dim loaded = JsonConvert.DeserializeObject(Of AppState)(json)
                If loaded IsNot Nothing Then state = loaded
            End If
        Catch
            ' Ignore parse errors, keep defaults
        End Try
    End Sub

    Private Sub nudTarget_ValueChanged(sender As Object, e As EventArgs) Handles nudTarget.ValueChanged
        Dim q = ActiveQueue()
        isDirty = True
        q.Target = nudTarget.Value / 100.0
        RefreshUI()
    End Sub

    Private Sub SaveState()
        Try
            Dim json = JsonConvert.SerializeObject(state, Formatting.Indented)
            File.WriteAllText(savePath, json)
            isDirty = False
        Catch ex As Exception
            MessageBox.Show("Save failed: " & ex.Message)
        End Try
    End Sub

    Private Function ActiveQueue() As QueueStats
        Select Case state.Active
            Case "SoloQ" : Return state.SoloQ
            Case "Flex" : Return state.Flex
            Case "Normal" : Return state.Normal
            Case Else : Return state.SoloQ
        End Select
    End Function

    Private Sub RefreshUI()
        Dim q = ActiveQueue()
        Dim total = q.Wins + q.Losses
        Dim pct = If(total = 0, 0.0, q.Wins / total * 100.0)

        ' Summary label
        lblStats.Text = $"{q.Wins}W - {q.Losses}L ({pct:0}%) ({total}T)"

        ' --- ΝΕΟ: Target & Needed ---
        nudTarget.Text = (q.Target * 100).ToString("0.0") ' π.χ. 60.0
        Dim needed = q.NeededWinsToTarget
        If needed.HasValue Then
            lblNeeded.Text = needed.Value.ToString()
        Else
            lblNeeded.Text = "N/A"
        End If

        ' --- Chart ---
        Dim s As Series = chartStats.Series("Results")
        s.Points.Clear()

        If total = 0 Then
            ' Δείξε ένα “empty” κομμάτι για να μην κρύβεται ο κύκλος
            Dim p = s.Points(s.Points.AddY(1))
            p.AxisLabel = "No data"
            p.LegendText = "No data"
            p.Label = ""
            chartStats.Legends("Legend").Enabled = False
        Else
            chartStats.Legends("Legend").Enabled = True

            Dim pW = s.Points(s.Points.AddY(q.Wins))
            pW.AxisLabel = "Wins"
            pW.LegendText = $"Wins ({q.Wins})"
            pW.Label = "#PERCENT{P0}"
            pW.Color = Color.ForestGreen

            Dim pL = s.Points(s.Points.AddY(q.Losses))
            pL.AxisLabel = "Losses"
            pL.LegendText = $"Losses ({q.Losses})"
            pL.Label = "#PERCENT{P0}"
            pL.Color = Color.DarkRed
        End If
        ' Αν θες Doughnut αντί για Pie:
        ' s.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        ' s("DoughnutRadius") = "70" ' προαιρετικό: πάχος δαχτυλιδιού

        ' ... υπόλοιπα refresh (targets κ.λπ.)
    End Sub

    Private Sub ApplyActiveRadio()
        rdoSoloQ.Checked = (state.Active = "SoloQ")
        rdoFlex.Checked = (state.Active = "Flex")
        rdoNormal.Checked = (state.Active = "Normal")
    End Sub

    Private Sub SetActive(name As String)
        state.Active = name
        RefreshUI()
    End Sub

    ' ==== Mode selection ====
    Private Sub rdoSoloQ_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSoloQ.CheckedChanged
        If rdoSoloQ.Checked Then SetActive("SoloQ")
    End Sub

    Private Sub rdoFlex_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFlex.CheckedChanged
        If rdoFlex.Checked Then SetActive("Flex")
    End Sub

    Private Sub rdoNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormal.CheckedChanged
        If rdoNormal.Checked Then SetActive("Normal")
    End Sub

    ' ==== Save / Reset ====
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveState()
        MessageBox.Show("Saved!")
    End Sub

    Private Sub btnResetCurrent_Click(sender As Object, e As EventArgs) Handles btnResetCurrent.Click
        Dim q = ActiveQueue()
        If MessageBox.Show("Μηδενισμός του " & state.Active & "?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            q.Wins = 0
            q.Losses = 0
            RefreshUI()
        End If
    End Sub

    Private Sub WinrateTrackerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "LoL Winrate Tracker"
        SetupChart()
        LoadState()
        ApplyActiveRadio()
        RefreshUI()
    End Sub

    Private Sub SetupChart()
        chartStats.Series.Clear()
        chartStats.ChartAreas.Clear()
        chartStats.Legends.Clear()

        chartStats.ChartAreas.Add("Main")
        chartStats.Legends.Add("Legend")

        Dim s = chartStats.Series.Add("Results")
        s.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut ' ή Doughnut
        s.IsValueShownAsLabel = True
        s("PieLabelStyle") = "Outside"   ' ετικέτες εκτός κύκλου
        s("PieLineColor") = "Gray"       ' γραμμές οδηγών
        chartStats.Legends("Legend").Docking = DataVisualization.Charting.Docking.Bottom
    End Sub

    Private Sub lblStats_DoubleClick(sender As Object, e As EventArgs) Handles lblStats.DoubleClick
        Dim q = ActiveQueue()
        Using dlg As New DualAdjustDialog()
            dlg.QueueName = state.Active
            dlg.CurrentWins = q.Wins
            dlg.CurrentLosses = q.Losses

            If dlg.ShowDialog(Me) = DialogResult.OK Then
                q.Wins = dlg.ResultWins
                q.Losses = dlg.ResultLosses
                isDirty = True
                RefreshUI()
            End If
        End Using
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Θες σίγουρα να βγεις;", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ExportJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportJSONToolStripMenuItem.Click
        Using sfd As New SaveFileDialog()
            sfd.Title = "Export backup"
            sfd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
            sfd.FileName = $"LoLWinrateBackup_{DateTime.Now:yyyyMMdd_HHmm}.json"
            If sfd.ShowDialog(Me) = DialogResult.OK Then
                Try
                    Dim json = JsonConvert.SerializeObject(state, Formatting.Indented)
                    File.WriteAllText(sfd.FileName, json)
                    MessageBox.Show("Export completed!", "Export JSON", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Export failed: " & ex.Message, "Export JSON", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub ImportJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportJSONToolStripMenuItem.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Import backup"
            ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
            If ofd.ShowDialog(Me) = DialogResult.OK Then
                Try
                    Dim json = File.ReadAllText(ofd.FileName)

                    ' Προαιρετικό: ελαφρύ validation πριν το Deserialize
                    Dim root = JObject.Parse(json)
                    If root Is Nothing OrElse root("SoloQ") Is Nothing OrElse root("Flex") Is Nothing OrElse root("Normal") Is Nothing Then
                        Throw New Exception("Invalid backup format.")
                    End If

                    Dim imported = JsonConvert.DeserializeObject(Of AppState)(json)
                    If imported Is Nothing Then Throw New Exception("Could not parse backup.")

                    ' Επιβεβαίωση overwrite
                    If MessageBox.Show(
                        "This will replace your current data (SoloQ/Flex/Normal). Continue?",
                        "Import JSON",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    ) = DialogResult.Yes Then

                        state = imported
                        ' Προστασία: αν λείπει Active ή έχει άκυρη τιμή
                        If String.IsNullOrWhiteSpace(state.Active) Then state.Active = "SoloQ"
                        If Not {"SoloQ", "Flex", "Normal"}.Contains(state.Active) Then state.Active = "SoloQ"

                        ApplyActiveRadio()
                        RefreshUI()
                        MessageBox.Show("Import completed!", "Import JSON", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Import failed: " & ex.Message, "Import JSON", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub WinrateTrackerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isDirty Then
            Dim result = MessageBox.Show(
                "You have unsaved changes" & vbCrLf &
                "Do you want to save them before exiting?",
                "Save before exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            )

            Select Case result
                Case DialogResult.Yes
                    SaveState()
                ' συνεχίζει το κλείσιμο
                Case DialogResult.No
                ' συνεχίζει χωρίς save
                Case DialogResult.Cancel
                    e.Cancel = True ' ακύρωση του exit
            End Select
        End If
    End Sub
End Class
