<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        lblAccNo = New Label()
        lblATM = New Label()
        lblWelcomeUser = New Label()
        lblAccountNumber = New Label()
        lblAcc = New Label()
        Panel1 = New Panel()
        btnCashDeposit = New Button()
        btnPINChange = New Button()
        btnFundTransfer = New Button()
        btnFastCash = New Button()
        btnCashWithdrawal = New Button()
        btnBalanceInquiry = New Button()
        lblTransaction = New Label()
        lblUserame = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblAccNo
        ' 
        lblAccNo.AutoSize = True
        lblAccNo.Location = New Point(597, 68)
        lblAccNo.Name = "lblAccNo"
        lblAccNo.Size = New Size(0, 20)
        lblAccNo.TabIndex = 0
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(117, 29)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 1
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' lblWelcomeUser
        ' 
        lblWelcomeUser.AutoSize = True
        lblWelcomeUser.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcomeUser.ForeColor = Color.White
        lblWelcomeUser.Location = New Point(29, 152)
        lblWelcomeUser.Name = "lblWelcomeUser"
        lblWelcomeUser.Size = New Size(157, 41)
        lblWelcomeUser.TabIndex = 2
        lblWelcomeUser.Text = "WELCOME"
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAccountNumber.ForeColor = Color.White
        lblAccountNumber.Location = New Point(613, 152)
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(175, 41)
        lblAccountNumber.TabIndex = 3
        lblAccountNumber.Text = "Account No"
        ' 
        ' lblAcc
        ' 
        lblAcc.AutoSize = True
        lblAcc.ForeColor = Color.White
        lblAcc.Location = New Point(819, 169)
        lblAcc.Name = "lblAcc"
        lblAcc.Size = New Size(63, 20)
        lblAcc.TabIndex = 4
        lblAcc.Text = "Account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(btnCashDeposit)
        Panel1.Controls.Add(btnPINChange)
        Panel1.Controls.Add(btnFundTransfer)
        Panel1.Controls.Add(btnFastCash)
        Panel1.Controls.Add(btnCashWithdrawal)
        Panel1.Controls.Add(btnBalanceInquiry)
        Panel1.Controls.Add(lblTransaction)
        Panel1.Location = New Point(140, 208)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(888, 528)
        Panel1.TabIndex = 5
        ' 
        ' btnCashDeposit
        ' 
        btnCashDeposit.BackColor = Color.SkyBlue
        btnCashDeposit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCashDeposit.Location = New Point(29, 377)
        btnCashDeposit.Name = "btnCashDeposit"
        btnCashDeposit.Size = New Size(166, 110)
        btnCashDeposit.TabIndex = 6
        btnCashDeposit.Text = "Cash Deposit"
        btnCashDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnPINChange
        ' 
        btnPINChange.BackColor = Color.SkyBlue
        btnPINChange.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPINChange.Location = New Point(29, 222)
        btnPINChange.Name = "btnPINChange"
        btnPINChange.Size = New Size(166, 110)
        btnPINChange.TabIndex = 5
        btnPINChange.Text = "PIN Change"
        btnPINChange.UseVisualStyleBackColor = False
        ' 
        ' btnFundTransfer
        ' 
        btnFundTransfer.BackColor = Color.SkyBlue
        btnFundTransfer.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFundTransfer.Location = New Point(645, 377)
        btnFundTransfer.Name = "btnFundTransfer"
        btnFundTransfer.Size = New Size(166, 110)
        btnFundTransfer.TabIndex = 4
        btnFundTransfer.Text = "Fund Transfer"
        btnFundTransfer.UseVisualStyleBackColor = False
        ' 
        ' btnFastCash
        ' 
        btnFastCash.BackColor = Color.SkyBlue
        btnFastCash.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFastCash.Location = New Point(645, 222)
        btnFastCash.Name = "btnFastCash"
        btnFastCash.Size = New Size(166, 110)
        btnFastCash.TabIndex = 3
        btnFastCash.Text = "Fast Cash"
        btnFastCash.UseVisualStyleBackColor = False
        ' 
        ' btnCashWithdrawal
        ' 
        btnCashWithdrawal.BackColor = Color.SkyBlue
        btnCashWithdrawal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCashWithdrawal.Location = New Point(645, 85)
        btnCashWithdrawal.Name = "btnCashWithdrawal"
        btnCashWithdrawal.Size = New Size(166, 110)
        btnCashWithdrawal.TabIndex = 2
        btnCashWithdrawal.Text = "Cash Withdrawal"
        btnCashWithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btnBalanceInquiry
        ' 
        btnBalanceInquiry.BackColor = Color.SkyBlue
        btnBalanceInquiry.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBalanceInquiry.Location = New Point(29, 85)
        btnBalanceInquiry.Name = "btnBalanceInquiry"
        btnBalanceInquiry.Size = New Size(166, 110)
        btnBalanceInquiry.TabIndex = 1
        btnBalanceInquiry.Text = "Balance Inquiry"
        btnBalanceInquiry.UseVisualStyleBackColor = False
        ' 
        ' lblTransaction
        ' 
        lblTransaction.AutoSize = True
        lblTransaction.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransaction.ForeColor = Color.White
        lblTransaction.Location = New Point(230, 25)
        lblTransaction.Name = "lblTransaction"
        lblTransaction.Size = New Size(449, 41)
        lblTransaction.TabIndex = 0
        lblTransaction.Text = "PLEASE SELECT A TRANSACTION"
        ' 
        ' lblUserame
        ' 
        lblUserame.AutoSize = True
        lblUserame.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserame.ForeColor = Color.White
        lblUserame.Location = New Point(192, 161)
        lblUserame.Name = "lblUserame"
        lblUserame.Size = New Size(103, 28)
        lblUserame.TabIndex = 6
        lblUserame.Text = "UserName"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ClientSize = New Size(1160, 786)
        Controls.Add(lblUserame)
        Controls.Add(Panel1)
        Controls.Add(lblAcc)
        Controls.Add(lblAccountNumber)
        Controls.Add(lblWelcomeUser)
        Controls.Add(lblATM)
        Controls.Add(lblAccNo)
        Name = "Main"
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAccNo As Label
    Friend WithEvents lblATM As Label
    Friend WithEvents lblWelcomeUser As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblAcc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPINChange As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents btnFastCash As Button
    Friend WithEvents btnCashWithdrawal As Button
    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents lblTransaction As Label
    Friend WithEvents lblUserame As Label
    Friend WithEvents btnCashDeposit As Button
End Class
