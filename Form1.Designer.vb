<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lstSentences = New System.Windows.Forms.ListBox()
        Me.btnNextsentence = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSentences
        '
        Me.lstSentences.FormattingEnabled = True
        Me.lstSentences.ItemHeight = 15
        Me.lstSentences.Location = New System.Drawing.Point(69, 27)
        Me.lstSentences.Name = "lstSentences"
        Me.lstSentences.Size = New System.Drawing.Size(635, 214)
        Me.lstSentences.TabIndex = 0
        '
        'btnNextsentence
        '
        Me.btnNextsentence.Location = New System.Drawing.Point(69, 272)
        Me.btnNextsentence.Name = "btnNextsentence"
        Me.btnNextsentence.Size = New System.Drawing.Size(152, 60)
        Me.btnNextsentence.TabIndex = 1
        Me.btnNextsentence.Text = "Next Sentence"
        Me.btnNextsentence.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(552, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 60)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 60)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Sentences"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNextsentence)
        Me.Controls.Add(Me.lstSentences)
        Me.Name = "Form1"
        Me.Text = "Random Sentences"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstSentences As ListBox
    Friend WithEvents btnNextsentence As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
