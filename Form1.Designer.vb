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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Challenger1 = New System.Windows.Forms.TextBox()
        Me.Challenger2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.R1Opp1 = New System.Windows.Forms.TextBox()
        Me.R1Opp2 = New System.Windows.Forms.TextBox()
        Me.R2Opp1 = New System.Windows.Forms.TextBox()
        Me.R2Opp2 = New System.Windows.Forms.TextBox()
        Me.R3Opp1 = New System.Windows.Forms.TextBox()
        Me.R3Opp2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(48, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(184, 212)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh Arena"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Challengers:"
        '
        'Challenger1
        '
        Me.Challenger1.AllowDrop = True
        Me.Challenger1.Location = New System.Drawing.Point(259, 96)
        Me.Challenger1.Name = "Challenger1"
        Me.Challenger1.Size = New System.Drawing.Size(100, 20)
        Me.Challenger1.TabIndex = 3
        '
        'Challenger2
        '
        Me.Challenger2.AllowDrop = True
        Me.Challenger2.Location = New System.Drawing.Point(268, 122)
        Me.Challenger2.Name = "Challenger2"
        Me.Challenger2.Size = New System.Drawing.Size(100, 20)
        Me.Challenger2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Opponents:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Round 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Round 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Round 1"
        '
        'R1Opp1
        '
        Me.R1Opp1.AllowDrop = True
        Me.R1Opp1.Location = New System.Drawing.Point(430, 246)
        Me.R1Opp1.Name = "R1Opp1"
        Me.R1Opp1.Size = New System.Drawing.Size(100, 20)
        Me.R1Opp1.TabIndex = 9
        '
        'R1Opp2
        '
        Me.R1Opp2.AllowDrop = True
        Me.R1Opp2.Location = New System.Drawing.Point(443, 272)
        Me.R1Opp2.Name = "R1Opp2"
        Me.R1Opp2.Size = New System.Drawing.Size(100, 20)
        Me.R1Opp2.TabIndex = 10
        '
        'R2Opp1
        '
        Me.R2Opp1.AllowDrop = True
        Me.R2Opp1.Location = New System.Drawing.Point(430, 159)
        Me.R2Opp1.Name = "R2Opp1"
        Me.R2Opp1.Size = New System.Drawing.Size(100, 20)
        Me.R2Opp1.TabIndex = 11
        '
        'R2Opp2
        '
        Me.R2Opp2.AllowDrop = True
        Me.R2Opp2.Location = New System.Drawing.Point(443, 185)
        Me.R2Opp2.Name = "R2Opp2"
        Me.R2Opp2.Size = New System.Drawing.Size(100, 20)
        Me.R2Opp2.TabIndex = 12
        '
        'R3Opp1
        '
        Me.R3Opp1.AllowDrop = True
        Me.R3Opp1.Location = New System.Drawing.Point(430, 81)
        Me.R3Opp1.Name = "R3Opp1"
        Me.R3Opp1.Size = New System.Drawing.Size(100, 20)
        Me.R3Opp1.TabIndex = 13
        '
        'R3Opp2
        '
        Me.R3Opp2.AllowDrop = True
        Me.R3Opp2.Location = New System.Drawing.Point(443, 107)
        Me.R3Opp2.Name = "R3Opp2"
        Me.R3Opp2.Size = New System.Drawing.Size(100, 20)
        Me.R3Opp2.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Reset Challenge"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 326)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.R3Opp2)
        Me.Controls.Add(Me.R3Opp1)
        Me.Controls.Add(Me.R2Opp2)
        Me.Controls.Add(Me.R2Opp1)
        Me.Controls.Add(Me.R1Opp2)
        Me.Controls.Add(Me.R1Opp1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Challenger2)
        Me.Controls.Add(Me.Challenger1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Friday Night Jams Dubs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Challenger1 As TextBox
    Friend WithEvents Challenger2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents R1Opp1 As TextBox
    Friend WithEvents R1Opp2 As TextBox
    Friend WithEvents R2Opp1 As TextBox
    Friend WithEvents R2Opp2 As TextBox
    Friend WithEvents R3Opp1 As TextBox
    Friend WithEvents R3Opp2 As TextBox
    Friend WithEvents Button2 As Button
End Class
