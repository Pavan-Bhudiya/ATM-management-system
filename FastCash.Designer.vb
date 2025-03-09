<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastCash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblATM = New Label()
        lblU = New Label()
        lblacno = New Label()
        lblname = New Label()
        lblacc = New Label()
        Panel1 = New Panel()
        btn40000 = New Button()
        btn20000 = New Button()
        btn10000 = New Button()
        btn5000 = New Button()
        btn1000 = New Button()
        btn500 = New Button()
        lblFWithdrawal = New Label()
        btnMain = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(91, 17)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 4
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(1000, 132)
        lblU.Name = "lblU"
        lblU.Size = New Size(142, 38)
        lblU.TabIndex = 14
        lblU.Text = "Username"
        ' 
        ' lblacno
        ' 
        lblacno.AutoSize = True
        lblacno.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacno.ForeColor = Color.White
        lblacno.Location = New Point(158, 123)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 13
        lblacno.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(890, 132)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 12
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(-7, 123)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 11
        lblacc.Text = "Account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(btn40000)
        Panel1.Controls.Add(btn20000)
        Panel1.Controls.Add(btn10000)
        Panel1.Controls.Add(btn5000)
        Panel1.Controls.Add(btn1000)
        Panel1.Controls.Add(btn500)
        Panel1.Location = New Point(314, 308)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(572, 286)
        Panel1.TabIndex = 15
        ' 
        ' btn40000
        ' 
        btn40000.Location = New Point(374, 214)
        btn40000.Name = "btn40000"
        btn40000.Size = New Size(94, 29)
        btn40000.TabIndex = 6
        btn40000.Text = "40,000"
        btn40000.UseVisualStyleBackColor = True
        ' 
        ' btn20000
        ' 
        btn20000.Location = New Point(374, 106)
        btn20000.Name = "btn20000"
        btn20000.Size = New Size(94, 29)
        btn20000.TabIndex = 5
        btn20000.Text = "20,000"
        btn20000.UseVisualStyleBackColor = True
        ' 
        ' btn10000
        ' 
        btn10000.Location = New Point(374, 35)
        btn10000.Name = "btn10000"
        btn10000.Size = New Size(94, 29)
        btn10000.TabIndex = 4
        btn10000.Text = "10,000"
        btn10000.UseVisualStyleBackColor = True
        ' 
        ' btn5000
        ' 
        btn5000.Location = New Point(109, 202)
        btn5000.Name = "btn5000"
        btn5000.Size = New Size(94, 29)
        btn5000.TabIndex = 3
        btn5000.Text = "5,000"
        btn5000.UseVisualStyleBackColor = True
        ' 
        ' btn1000
        ' 
        btn1000.Location = New Point(109, 115)
        btn1000.Name = "btn1000"
        btn1000.Size = New Size(94, 29)
        btn1000.TabIndex = 2
        btn1000.Text = "1,000"
        btn1000.UseVisualStyleBackColor = True
        ' 
        ' btn500
        ' 
        btn500.Location = New Point(109, 35)
        btn500.Name = "btn500"
        btn500.Size = New Size(94, 29)
        btn500.TabIndex = 1
        btn500.Text = "500"
        btn500.UseVisualStyleBackColor = True
        ' 
        ' lblFWithdrawal
        ' 
        lblFWithdrawal.AutoSize = True
        lblFWithdrawal.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFWithdrawal.Location = New Point(428, 161)
        lblFWithdrawal.Name = "lblFWithdrawal"
        lblFWithdrawal.Size = New Size(299, 41)
        lblFWithdrawal.TabIndex = 0
        lblFWithdrawal.Text = "Fast Cash Withdrawal"
        ' 
        ' btnMain
        ' 
        btnMain.Location = New Point(940, 666)
        btnMain.Name = "btnMain"
        btnMain.Size = New Size(162, 52)
        btnMain.TabIndex = 16
        btnMain.Text = "Main Menu"
        btnMain.UseVisualStyleBackColor = True
        ' 
        ' FastCash
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1142, 759)
        Controls.Add(btnMain)
        Controls.Add(Panel1)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblFWithdrawal)
        Controls.Add(lblATM)
        Name = "FastCash"
        Text = "FastCash"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblATM As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn40000 As Button
    Friend WithEvents btn20000 As Button
    Friend WithEvents btn10000 As Button
    Friend WithEvents btn5000 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents lblFWithdrawal As Label
    Friend WithEvents btnMain As Button
End Class
