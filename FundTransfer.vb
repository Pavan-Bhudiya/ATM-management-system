

Public Class FundTransfer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.rdbtnIBTransfer.Checked Then
            MsgBox("Fund Transferred")
        ElseIf Me.rdbtnToAnyOtherAcc.Checked Then
            MsgBox("Contact Branch To Choose Branch")

        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Main.Show()

    End Sub

    Private Sub FundTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class