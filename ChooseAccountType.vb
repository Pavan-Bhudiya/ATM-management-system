Imports System.Data.SqlClient
Imports System.Data

Public Class ChooseAccountType
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows, i, currentrow As Integer

    Private Sub ChooseAccountType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Masters"
        da = New OleDb.OleDbDataAdapter(sql, con)
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

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        CashWithdraw.Show()

    End Sub

    Private Sub btnMmenu_Click(sender As Object, e As EventArgs) Handles btnMmenu.Click
        Main.Show()
    End Sub
End Class
