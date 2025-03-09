<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseCashDeposit
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
        lblCashDeposit = New Label()
        btnMmenu = New Button()
        Panel1 = New Panel()
        btnProceed = New Button()
        rdbtnCurrent = New RadioButton()
        rdbtnSavings = New RadioButton()
        lblAccountType = New Label()
        lblU = New Label()
        lblacno = New Label()
        lblname = New Label()
        lblacc = New Label()
        lblATM = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCashDeposit
        ' 
        lblCashDeposit.AutoSize = True
        lblCashDeposit.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCashDeposit.Location = New Point(389, 147)
        lblCashDeposit.Name = "lblCashDeposit"
        lblCashDeposit.Size = New Size(193, 41)
        lblCashDeposit.TabIndex = 17
        lblCashDeposit.Text = "Cash Deposit"
        ' 
        ' btnMmenu
        ' 
        btnMmenu.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMmenu.Location = New Point(921, 641)
        btnMmenu.Name = "btnMmenu"
        btnMmenu.Size = New Size(200, 61)
        btnMmenu.TabIndex = 18
        btnMmenu.Text = "Main Menu"
        btnMmenu.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(btnProceed)
        Panel1.Controls.Add(rdbtnCurrent)
        Panel1.Controls.Add(rdbtnSavings)
        Panel1.Controls.Add(lblAccountType)
        Panel1.Location = New Point(191, 256)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(753, 352)
        Panel1.TabIndex = 24
        ' 
        ' btnProceed
        ' 
        btnProceed.BackColor = Color.SteelBlue
        btnProceed.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProceed.Location = New Point(301, 277)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(136, 53)
        btnProceed.TabIndex = 3
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = False
        ' 
        ' rdbtnCurrent
        ' 
        rdbtnCurrent.AutoSize = True
        rdbtnCurrent.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbtnCurrent.Location = New Point(545, 177)
        rdbtnCurrent.Name = "rdbtnCurrent"
        rdbtnCurrent.Size = New Size(131, 42)
        rdbtnCurrent.TabIndex = 2
        rdbtnCurrent.TabStop = True
        rdbtnCurrent.Text = "Current"
        rdbtnCurrent.UseVisualStyleBackColor = True
        ' 
        ' rdbtnSavings
        ' 
        rdbtnSavings.AutoSize = True
        rdbtnSavings.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbtnSavings.Location = New Point(112, 177)
        rdbtnSavings.Name = "rdbtnSavings"
        rdbtnSavings.Size = New Size(131, 42)
        rdbtnSavings.TabIndex = 1
        rdbtnSavings.TabStop = True
        rdbtnSavings.Text = "Savings"
        rdbtnSavings.UseVisualStyleBackColor = True
        ' 
        ' lblAccountType
        ' 
        lblAccountType.AutoSize = True
        lblAccountType.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAccountType.ForeColor = SystemColors.ButtonHighlight
        lblAccountType.Location = New Point(198, 39)
        lblAccountType.Name = "lblAccountType"
        lblAccountType.Size = New Size(377, 41)
        lblAccountType.TabIndex = 0
        lblAccountType.Text = "Please Select Account Type"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(1007, 156)
        lblU.Name = "lblU"
        lblU.Size = New Size(142, 38)
        lblU.TabIndex = 23
        lblU.Text = "Username"
        ' 
        ' lblacno
        ' 
        lblacno.AutoSize = True
        lblacno.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacno.ForeColor = Color.White
        lblacno.Location = New Point(165, 147)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 22
        lblacno.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(897, 156)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 21
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(0, 147)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 20
        lblacc.Text = "Account"
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(81, 26)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 19
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' ChooseCashDeposit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(1148, 728)
        Controls.Add(lblCashDeposit)
        Controls.Add(btnMmenu)
        Controls.Add(Panel1)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblATM)
        Name = "ChooseCashDeposit"
        Text = "ChooseCashDeposit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCashDeposit As Label
    Friend WithEvents btnMmenu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProceed As Button
    Friend WithEvents rdbtnCurrent As RadioButton
    Friend WithEvents rdbtnSavings As RadioButton
    Friend WithEvents lblAccountType As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents lblATM As Label
End Class
