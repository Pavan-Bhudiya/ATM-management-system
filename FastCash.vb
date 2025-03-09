Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class FastCash
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds, ds1 As New DataSet
    Dim da, da1 As New OleDb.OleDbDataAdapter
    Dim sql, sql1 As String
    Public balance, current As Integer
    Dim maxrows, i, currentrow As Integer


    Private Sub FastCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Masters"
        sql1 = "SELECT * FROM Dailytrans"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da1 = New OleDb.OleDbDataAdapter(sql1, con)

        da.Fill(ds, "Masters")
        da1.Fill(ds1, "Dailytrans")
        maxrows = ds.Tables("Masters").Rows.Count

    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        ProcessFastCashWithdrawal(500)

    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        ProcessFastCashWithdrawal(1000)

    End Sub

    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        ProcessFastCashWithdrawal(5000)

    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        ProcessFastCashWithdrawal(10000)

    End Sub

    Private Sub btn20000_Click(sender As Object, e As EventArgs) Handles btn20000.Click
        ProcessFastCashWithdrawal(2000)

    End Sub

    Private Sub btn40000_Click(sender As Object, e As EventArgs) Handles btn40000.Click
        ProcessFastCashWithdrawal(40000)
        i = 0

    End Sub
    Private Sub ProcessFastCashWithdrawal(withdrawalAmount As Integer)
        i = 0
        Dim accountFound As Boolean = False
        While i < maxrows
            If lblacno.Text = ds.Tables("Masters").Rows(i)("Acc no") Then
                accountFound = True
                ' Get current balance from the Masters table (assumed column "Amount")
                current = ds.Tables("Masters").Rows(i)("Amount")
                If current < withdrawalAmount Then
                    MsgBox("Insufficient funds")
                    Exit Sub
                End If
                balance = current - withdrawalAmount

                ' Update Masters table with new balance
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("Masters").Rows(i).Item("Amount") = balance
                da.Update(ds, "Masters")

                ' Log the transaction in Dailytrans table
                LogFastCashTransaction(withdrawalAmount)

                MsgBox("Withdrawal successful. New balance: " & balance.ToString())
                Exit While
            End If
            i += 1
        End While

        If Not accountFound Then
            MsgBox("No account found with the provided account number.")
        End If

        currentrow = i
    End Sub

    Private Sub LogFastCashTransaction(withdrawalAmount As Integer)
        ' Log the transaction in Dailytrans table
        Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        cb1.QuotePrefix = "["
        cb1.QuoteSuffix = "]"
        Dim dsNewRow As DataRow = ds1.Tables("Dailytrans").NewRow()
        dsNewRow.Item("Acc no") = lblacno.Text
        dsNewRow.Item("Transfer type") = "FastCash"
        dsNewRow.Item("Amount Withdrawn") = withdrawalAmount
        dsNewRow.Item("Previous Amount") = current
        dsNewRow.Item("Current Amount") = balance
        ds1.Tables("Dailytrans").Rows.Add(dsNewRow)
        da1.Update(ds1, "Dailytrans")
        MsgBox("Transaction logged.")
    End Sub
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Main.Show()
    End Sub
End Class