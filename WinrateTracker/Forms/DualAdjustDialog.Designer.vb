<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DualAdjustDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DualAdjustDialog))
        Me.txtWins = New System.Windows.Forms.TextBox()
        Me.btnWinsPlus = New System.Windows.Forms.Button()
        Me.btnWinsMinus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLosses = New System.Windows.Forms.TextBox()
        Me.btnLossMinus = New System.Windows.Forms.Button()
        Me.btnLossPlus = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWins
        '
        Me.txtWins.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtWins.ForeColor = System.Drawing.Color.White
        Me.txtWins.Location = New System.Drawing.Point(6, 25)
        Me.txtWins.Name = "txtWins"
        Me.txtWins.Size = New System.Drawing.Size(113, 26)
        Me.txtWins.TabIndex = 1
        '
        'btnWinsPlus
        '
        Me.btnWinsPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWinsPlus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnWinsPlus.Location = New System.Drawing.Point(84, 57)
        Me.btnWinsPlus.Name = "btnWinsPlus"
        Me.btnWinsPlus.Size = New System.Drawing.Size(35, 26)
        Me.btnWinsPlus.TabIndex = 2
        Me.btnWinsPlus.Text = "+1"
        Me.btnWinsPlus.UseVisualStyleBackColor = True
        '
        'btnWinsMinus
        '
        Me.btnWinsMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWinsMinus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnWinsMinus.Location = New System.Drawing.Point(43, 57)
        Me.btnWinsMinus.Name = "btnWinsMinus"
        Me.btnWinsMinus.Size = New System.Drawing.Size(35, 26)
        Me.btnWinsMinus.TabIndex = 3
        Me.btnWinsMinus.Text = "-1"
        Me.btnWinsMinus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWins)
        Me.GroupBox1.Controls.Add(Me.btnWinsMinus)
        Me.GroupBox1.Controls.Add(Me.btnWinsPlus)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 94)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wins"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLosses)
        Me.GroupBox2.Controls.Add(Me.btnLossMinus)
        Me.GroupBox2.Controls.Add(Me.btnLossPlus)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(203, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 94)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Losses"
        '
        'txtLosses
        '
        Me.txtLosses.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtLosses.ForeColor = System.Drawing.Color.White
        Me.txtLosses.Location = New System.Drawing.Point(6, 25)
        Me.txtLosses.Name = "txtLosses"
        Me.txtLosses.Size = New System.Drawing.Size(113, 26)
        Me.txtLosses.TabIndex = 1
        '
        'btnLossMinus
        '
        Me.btnLossMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLossMinus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnLossMinus.Location = New System.Drawing.Point(43, 57)
        Me.btnLossMinus.Name = "btnLossMinus"
        Me.btnLossMinus.Size = New System.Drawing.Size(35, 26)
        Me.btnLossMinus.TabIndex = 3
        Me.btnLossMinus.Text = "-1"
        Me.btnLossMinus.UseVisualStyleBackColor = True
        '
        'btnLossPlus
        '
        Me.btnLossPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLossPlus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnLossPlus.Location = New System.Drawing.Point(84, 57)
        Me.btnLossPlus.Name = "btnLossPlus"
        Me.btnLossPlus.Size = New System.Drawing.Size(35, 26)
        Me.btnLossPlus.TabIndex = 2
        Me.btnLossPlus.Text = "+1"
        Me.btnLossPlus.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnOK.Location = New System.Drawing.Point(259, 120)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 30)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "Apply"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 30)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DualAdjustDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(338, 162)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DualAdjustDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DualAdjustDialog"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtWins As TextBox
    Friend WithEvents btnWinsPlus As Button
    Friend WithEvents btnWinsMinus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLosses As TextBox
    Friend WithEvents btnLossMinus As Button
    Friend WithEvents btnLossPlus As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
