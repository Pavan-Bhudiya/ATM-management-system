<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblWelcome = New Label()
        btnStart = New Button()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(184, 26)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(479, 46)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome To Banco De Suenos"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.ActiveCaption
        btnStart.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = Color.Blue
        btnStart.Location = New Point(392, 141)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(171, 70)
        btnStart.TabIndex = 1
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(295, 648)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(496, 29)
        ProgressBar1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.lgo
        ClientSize = New Size(963, 689)
        Controls.Add(ProgressBar1)
        Controls.Add(btnStart)
        Controls.Add(lblWelcome)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
