Imports System.Data.SqlClient
Imports System.Data
Public Class Login
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxrows As Integer
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim con As New OleDb.OleDbConnection
        Dim SearchId, i, currentrow As Integer
        SearchId = txtPIN.Text
        i = 0
        ' Open the database connection
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\atm.accdb;"
            con.Open()

            ' Retrieve data and check for the PIN
            sql = "SELECT * FROM PIN"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "atm")
            maxrows = ds.Tables("atm").Rows.Count

            ' Loop through the rows to find the matching PIN
            While i <> maxrows
                If SearchId = ds.Tables("atm").Rows(i)("PIN") Then
                    Me.Close()
                    Main.lblAcc.Text = ds.Tables("atm").Rows(i)("Acc no")
                    Main.Show()
                    Exit While
                ElseIf i = maxrows - 1 Then
                    MsgBox("Invalid PIN")
                    Exit While
                End If
                i += 1
            End While
            currentrow = i
        Catch ex As OleDb.OleDbException
            MsgBox("OLEDB Exception: " & ex.Message) ' Display any connection-related errors
        Catch ex As Exception
            MsgBox("General Exception: " & ex.Message) ' Handle other exceptions
        Finally
            ' Close the connection in the Finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPIN.Text = " "
        txtPIN.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnSelectAllDigits(sender As Object, e As EventArgs) Handles MyBase.Click, btn1.Click, btn2.Click, btn3.Click, btn6.Click,
        btn5.Click, btn4.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        txtPIN.Text = txtPIN.Text & sender.text
    End Sub
End Class