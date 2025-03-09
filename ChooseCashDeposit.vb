Imports System.Data.SqlClient
Imports System.Data

Public Class ChooseCashDeposit
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows, i, currentrow As Integer
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        CashDeposit.Show()

    End Sub

    Private Sub ChooseCashDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        Sql = "SELECT * FROM Masters"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "atm")
        maxrows = ds.Tables("atm").Rows.Count
        i = 0
        While i <> maxrows + 1
            If lblacno.Text = ds.Tables("atm").Rows(i)("Acc no") Then
                lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")
                CashWithdraw.lblacno.Text = ds.Tables("atm").Rows(i)("Acc no")
                CashWithdraw.lblU.Text = ds.Tables("atm").Rows(i)("Customer Name")
                Exit While
            ElseIf i = maxrows Then
                MsgBox("Admin User")
            End If
            i += 1
        End While
        currentrow = i
    End Sub

    Private Sub btnMmenu_Click(sender As Object, e As EventArgs) Handles btnMmenu.Click
        Main.Show()

    End Sub
End Class