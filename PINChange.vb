Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb

Public Class PINChange
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds, ds1 As New DataSet
    Dim da, da1 As New OleDb.OleDbDataAdapter
    Dim sql, sql1, srw As String
    Dim maxrows, i, currentrow, mr As Integer
    Public balance, current As Integer
    Private Sub PINChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
        con.Open()
        sql = "SELECT * FROM Masters"
        sql1 = "SELECT * FROM PIN"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da1 = New OleDb.OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Masters")
        da1.Fill(ds1, "PIN")
        maxrows = ds.Tables("Masters").Rows.Count
        mr = ds1.Tables("PIN").Rows.Count

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        i = 0
        Dim foundInMasters As Boolean = False
        While i < maxrows + 1
            If lblacno.Text = ds.Tables("Masters").Rows(i)("Acc no") Then
                foundInMasters = True
                If txtNewPIN.Text = txtConfirmPIN.Text Then
                    Dim cbMasters As New OleDb.OleDbCommandBuilder(da)
                    cbMasters.QuotePrefix = "["
                    cbMasters.QuoteSuffix = "]"
                    ds.Tables("Masters").Rows(i).Item("PIN") = txtNewPIN.Text

                    For j As Integer = 0 To mr - 1
                        If ds1.Tables("PIN").Rows(j)("Acc no") = lblacno.Text Then
                            ds1.Tables("PIN").Rows(j).Item("PIN") = txtNewPIN.Text
                            Exit For
                        End If
                    Next

                    Dim cbPIN As New OleDb.OleDbCommandBuilder(da1)
                    cbPIN.QuotePrefix = "["
                    cbPIN.QuoteSuffix = "]"

                    da.Update(ds, "Masters")
                    da1.Update(ds1, "PIN")
                    MsgBox("PIN changed")
                Else
                    MsgBox("Check PIN once again")
                End If
                Exit While
            End If
            i = +1
        End While
        If i = maxrows Then
            MsgBox("Invalid PIN number")
        End If
        currentrow = i
    End Sub
    Private Sub btnmain_Click(sender As Object, e As EventArgs) Handles btnmain.Click
        Main.Show()
    End Sub
End Class