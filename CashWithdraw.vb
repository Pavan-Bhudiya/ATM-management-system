Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class CashWithdraw
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds, ds1 As New DataSet
    Dim da, da1 As New OleDb.OleDbDataAdapter
    Dim sql, sql1, srw As String
    Public balance, current As Integer
    Dim maxrows, i, currentrow, mr As Integer

    Private Sub CashWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Masters"
        sql1 = "SELECT * FROM Dailytrans"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da1 = New OleDb.OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Masters")
        da1.Fill(ds1, "Dailytrans")
        maxrows = ds.Tables("Masters").Rows.Count
        mr = ds1.Tables("Dailytrans").Rows.Count

    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        i = 0
        While i < maxrows + 1
            If lblacno.Text = ds.Tables("Masters").Rows(i)("Acc no") Then

                current = ds.Tables("Masters").Rows(i)("Amount")
                balance = current - Val(TextBox1.Text)

                daily()
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                ds.Tables("Masters").Rows(i).Item("Amount") = balance
                da.Update(ds, "Masters")
                MsgBox("Amount Withdrawn")
                Exit While
            End If
            i += 1
        End While


        If i = maxrows Then
            MsgBox("No enough balance")
        End If
        currentrow = i
    End Sub
    Public Sub daily()
        Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        cb1.QuotePrefix = "["
        cb1.QuoteSuffix = "]"
        Dim dsNewRow As DataRow
        dsNewRow = ds1.Tables("Dailytrans").NewRow()
        If ChooseAccountType.rdbtnCurrent.Checked = True Then
            srw = ChooseAccountType.rdbtnCurrent.Text
        Else
            srw = ChooseAccountType.rdbtnSavings.Text
        End If
        dsNewRow.Item("Acc no") = lblacno.Text
        dsNewRow.Item("Transfer type") = srw
        dsNewRow.Item("Amount Withdrawn") = Val(TextBox1.Text)
        dsNewRow.Item("Previous Amount") = current
        dsNewRow.Item("Current Amount") = balance

        ds1.Tables("Dailytrans").Rows.Add(dsNewRow)
        da1.Update(ds1, "Dailytrans")
        MsgBox("Daily Transaction Updated")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
    End Sub
End Class
