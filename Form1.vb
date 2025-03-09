Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            Timer1.Stop()
            ProgressBar1.Hide()
            btnStart.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStart.Visible = False
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        Timer1.Start()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Login.Show()


    End Sub
End Class
