Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class Balance
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows, i, currentrow, c As Integer

    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Dailytrans"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "atm")
        maxrows = ds.Tables("atm").Rows.Count
        i = 0
        While i <> maxrows + 1
            If lblacno.Text = ds.Tables("atm").Rows(i)("Acc no") Then

                Dim dv As New DataView(ds.Tables("atm"), "[Acc no] = '" & lblacno.Text & "'", "Acc no", DataViewRowState.CurrentRows)

                'dv = New DataView(ds.Tables(0), "Acc no" & lblacno.Text & "  ", "Acc no", DataViewRowState.CurrentRows)
                DataGridView1.DataSource = dv
                Exit While
            ElseIf i = maxrows Then
                MsgBox("Contact Admin")
                Exit While
            End If
            i = +1
        End While
        currentrow = i
    End Sub


    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        MsgBox("Balance has been shown")
    End Sub

    Private Sub btnm_Click(sender As Object, e As EventArgs) Handles btnm.Click
        Main.Show()
    End Sub


End Class