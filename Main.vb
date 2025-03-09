Imports System.Data.SqlClient
Imports System.Data
Public Class Main
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows, i, currentrow As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Masters"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "atm")
        maxrows = ds.Tables("atm").Rows.Count
        i = 0
        While i <> maxrows + 1
            If lblAcc.Text = ds.Tables("atm").Rows(i)("Acc no") Then
                lblUserame.Text = ds.Tables("atm").Rows(i)("Customer Name")

                Balance.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                Balance.lblUser.Text = ds.Tables("atm").Rows(i)("Customer Name")

                CashWithdraw.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                CashWithdraw.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                ChooseAccountType.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                ChooseAccountType.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                FastCash.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                FastCash.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                FundTransfer.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                FundTransfer.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                PINChange.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                PINChange.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                ChooseCashDeposit.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                ChooseCashDeposit.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                CashDeposit.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                CashDeposit.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")

                Exit While
            ElseIf i = maxrows Then
                MsgBox("Admin User")
            End If
            i += 1
        End While
        currentrow = i
    End Sub

    Private Sub btnBalanceInquiry_Click(sender As Object, e As EventArgs) Handles btnBalanceInquiry.Click
        Balance.Show()
    End Sub

    Private Sub btnCashWithdrawal_Click(sender As Object, e As EventArgs) Handles btnCashWithdrawal.Click
        ChooseAccountType.Show()
    End Sub

    Private Sub btnFastCash_Click(sender As Object, e As EventArgs) Handles btnFastCash.Click
        FastCash.Show()
    End Sub

    Private Sub btnFundTransfer_Click(sender As Object, e As EventArgs) Handles btnFundTransfer.Click
        FundTransfer.Show()
    End Sub

    Private Sub btnPINChange_Click(sender As Object, e As EventArgs) Handles btnPINChange.Click
        PINChange.Show()
    End Sub

    Private Sub btnCashDeposit_Click(sender As Object, e As EventArgs) Handles btnCashDeposit.Click
        ChooseCashDeposit.Show()

    End Sub
End Class