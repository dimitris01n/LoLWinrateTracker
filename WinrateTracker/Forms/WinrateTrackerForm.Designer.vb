<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinrateTrackerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinrateTrackerForm))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoNormal = New System.Windows.Forms.RadioButton()
        Me.rdoFlex = New System.Windows.Forms.RadioButton()
        Me.rdoSoloQ = New System.Windows.Forms.RadioButton()
        Me.panelStats = New System.Windows.Forms.Panel()
        Me.chartStats = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.nudTarget = New System.Windows.Forms.NumericUpDown()
        Me.lblNeeded = New System.Windows.Forms.Label()
        Me.lblNeededTitle = New System.Windows.Forms.Label()
        Me.lblTargetTitle = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnResetCurrent = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelStats.SuspendLayout()
        CType(Me.chartStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTop.Controls.Add(Me.GroupBox1)
        Me.panelTop.ForeColor = System.Drawing.Color.White
        Me.panelTop.Location = New System.Drawing.Point(13, 36)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(4)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(751, 97)
        Me.panelTop.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rdoNormal)
        Me.GroupBox1.Controls.Add(Me.rdoFlex)
        Me.GroupBox1.Controls.Add(Me.rdoSoloQ)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(749, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Queue Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select your mode:"
        '
        'rdoNormal
        '
        Me.rdoNormal.AutoSize = True
        Me.rdoNormal.Location = New System.Drawing.Point(272, 65)
        Me.rdoNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNormal.Name = "rdoNormal"
        Me.rdoNormal.Size = New System.Drawing.Size(72, 22)
        Me.rdoNormal.TabIndex = 2
        Me.rdoNormal.TabStop = True
        Me.rdoNormal.Text = "Normal"
        Me.rdoNormal.UseVisualStyleBackColor = True
        '
        'rdoFlex
        '
        Me.rdoFlex.AutoSize = True
        Me.rdoFlex.Location = New System.Drawing.Point(151, 65)
        Me.rdoFlex.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFlex.Name = "rdoFlex"
        Me.rdoFlex.Size = New System.Drawing.Size(101, 22)
        Me.rdoFlex.TabIndex = 1
        Me.rdoFlex.TabStop = True
        Me.rdoFlex.Text = "Ranked Flex"
        Me.rdoFlex.UseVisualStyleBackColor = True
        '
        'rdoSoloQ
        '
        Me.rdoSoloQ.AutoSize = True
        Me.rdoSoloQ.Location = New System.Drawing.Point(16, 65)
        Me.rdoSoloQ.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSoloQ.Name = "rdoSoloQ"
        Me.rdoSoloQ.Size = New System.Drawing.Size(112, 22)
        Me.rdoSoloQ.TabIndex = 0
        Me.rdoSoloQ.TabStop = True
        Me.rdoSoloQ.Text = "Ranked SoloQ"
        Me.rdoSoloQ.UseVisualStyleBackColor = True
        '
        'panelStats
        '
        Me.panelStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelStats.Controls.Add(Me.chartStats)
        Me.panelStats.Controls.Add(Me.Label2)
        Me.panelStats.Controls.Add(Me.lblStats)
        Me.panelStats.Controls.Add(Me.nudTarget)
        Me.panelStats.Controls.Add(Me.lblNeeded)
        Me.panelStats.Controls.Add(Me.lblNeededTitle)
        Me.panelStats.Controls.Add(Me.lblTargetTitle)
        Me.panelStats.ForeColor = System.Drawing.Color.White
        Me.panelStats.Location = New System.Drawing.Point(14, 141)
        Me.panelStats.Margin = New System.Windows.Forms.Padding(4)
        Me.panelStats.Name = "panelStats"
        Me.panelStats.Size = New System.Drawing.Size(750, 237)
        Me.panelStats.TabIndex = 1
        '
        'chartStats
        '
        Me.chartStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.chartStats.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartStats.Legends.Add(Legend1)
        Me.chartStats.Location = New System.Drawing.Point(3, 3)
        Me.chartStats.Name = "chartStats"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartStats.Series.Add(Series1)
        Me.chartStats.Size = New System.Drawing.Size(311, 229)
        Me.chartStats.TabIndex = 16
        Me.chartStats.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WinRate"
        '
        'lblStats
        '
        Me.lblStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStats.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblStats.Location = New System.Drawing.Point(320, 190)
        Me.lblStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(422, 37)
        Me.lblStats.TabIndex = 15
        Me.lblStats.Text = "0W - 0L (0%) (0T)"
        Me.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudTarget
        '
        Me.nudTarget.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.nudTarget.DecimalPlaces = 1
        Me.nudTarget.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.nudTarget.ForeColor = System.Drawing.Color.White
        Me.nudTarget.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudTarget.Location = New System.Drawing.Point(545, 59)
        Me.nudTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.nudTarget.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nudTarget.Name = "nudTarget"
        Me.nudTarget.Size = New System.Drawing.Size(181, 33)
        Me.nudTarget.TabIndex = 14
        Me.nudTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNeeded
        '
        Me.lblNeeded.AutoSize = True
        Me.lblNeeded.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblNeeded.Location = New System.Drawing.Point(618, 139)
        Me.lblNeeded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNeeded.Name = "lblNeeded"
        Me.lblNeeded.Size = New System.Drawing.Size(23, 26)
        Me.lblNeeded.TabIndex = 13
        Me.lblNeeded.Text = "0"
        '
        'lblNeededTitle
        '
        Me.lblNeededTitle.AutoSize = True
        Me.lblNeededTitle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblNeededTitle.Location = New System.Drawing.Point(481, 100)
        Me.lblNeededTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNeededTitle.Name = "lblNeededTitle"
        Me.lblNeededTitle.Size = New System.Drawing.Size(254, 26)
        Me.lblNeededTitle.TabIndex = 12
        Me.lblNeededTitle.Text = "Wins you need to achieve it:"
        '
        'lblTargetTitle
        '
        Me.lblTargetTitle.AutoSize = True
        Me.lblTargetTitle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblTargetTitle.Location = New System.Drawing.Point(530, 16)
        Me.lblTargetTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTargetTitle.Name = "lblTargetTitle"
        Me.lblTargetTitle.Size = New System.Drawing.Size(212, 26)
        Me.lblTargetTitle.TabIndex = 10
        Me.lblTargetTitle.Text = "Set a winrate target (%)"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBottom.Controls.Add(Me.btnResetCurrent)
        Me.panelBottom.Controls.Add(Me.btnSave)
        Me.panelBottom.Location = New System.Drawing.Point(14, 381)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(750, 58)
        Me.panelBottom.TabIndex = 2
        '
        'btnResetCurrent
        '
        Me.btnResetCurrent.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnResetCurrent.FlatAppearance.BorderSize = 2
        Me.btnResetCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetCurrent.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnResetCurrent.Location = New System.Drawing.Point(4, 4)
        Me.btnResetCurrent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetCurrent.Name = "btnResetCurrent"
        Me.btnResetCurrent.Size = New System.Drawing.Size(115, 31)
        Me.btnResetCurrent.TabIndex = 1
        Me.btnResetCurrent.Text = "Reset Current"
        Me.btnResetCurrent.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnSave.Location = New System.Drawing.Point(644, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 31)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportJSONToolStripMenuItem, Me.ImportJSONToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportJSONToolStripMenuItem
        '
        Me.ExportJSONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExportJSONToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExportJSONToolStripMenuItem.Name = "ExportJSONToolStripMenuItem"
        Me.ExportJSONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportJSONToolStripMenuItem.Text = "Export JSON"
        '
        'ImportJSONToolStripMenuItem
        '
        Me.ImportJSONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ImportJSONToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImportJSONToolStripMenuItem.Name = "ImportJSONToolStripMenuItem"
        Me.ImportJSONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImportJSONToolStripMenuItem.Text = "Import JSON"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WinrateTrackerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(770, 442)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelStats)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "WinrateTrackerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinRate Tracker"
        Me.panelTop.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelStats.ResumeLayout(False)
        Me.panelStats.PerformLayout()
        CType(Me.chartStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoSoloQ As RadioButton
    Friend WithEvents panelStats As Panel
    Friend WithEvents panelBottom As Panel
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents rdoFlex As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResetCurrent As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTargetTitle As Label
    Friend WithEvents lblNeeded As Label
    Friend WithEvents lblNeededTitle As Label
    Friend WithEvents nudTarget As NumericUpDown
    Friend WithEvents lblStats As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chartStats As DataVisualization.Charting.Chart
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
