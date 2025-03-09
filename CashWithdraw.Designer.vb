<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashWithdraw
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
        lblname = New Label()
        lblacc = New Label()
        lblacno = New Label()
        lblU = New Label()
        Panel1 = New Panel()
        btnCancel = New Button()
        TextBox1 = New TextBox()
        btnOkay = New Button()
        lblAmountWithdraw = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.ForeColor = Color.White
        lblATM.Location = New Point(93, 25)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 2
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(909, 155)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 4
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(12, 146)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 3
        lblacc.Text = "Account"
        ' 
        ' lblacno
        ' 
        lblacno.AutoSize = True
        lblacno.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacno.ForeColor = Color.White
        lblacno.Location = New Point(177, 146)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 9
        lblacno.Text = "Account"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(1019, 155)
        lblU.Name = "lblU"
        lblU.Size = New Size(142, 38)
        lblU.TabIndex = 10
        lblU.Text = "Username"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnOkay)
        Panel1.Controls.Add(lblAmountWithdraw)
        Panel1.Location = New Point(210, 196)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(753, 352)
        Panel1.TabIndex = 17
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(580, 276)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(111, 57)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(148, 112)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(489, 82)
        TextBox1.TabIndex = 4
        ' 
        ' btnOkay
        ' 
        btnOkay.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkay.Location = New Point(77, 276)
        btnOkay.Name = "btnOkay"
        btnOkay.Size = New Size(95, 48)
        btnOkay.TabIndex = 3
        btnOkay.Text = "Okay"
        btnOkay.UseVisualStyleBackColor = True
        ' 
        ' lblAmountWithdraw
        ' 
        lblAmountWithdraw.AutoSize = True
        lblAmountWithdraw.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmountWithdraw.ForeColor = Color.White
        lblAmountWithdraw.Location = New Point(198, 39)
        lblAmountWithdraw.Name = "lblAmountWithdraw"
        lblAmountWithdraw.Size = New Size(467, 41)
        lblAmountWithdraw.TabIndex = 0
        lblAmountWithdraw.Text = "Please Enter Amount To Withdraw"
        ' 
        ' CashWithdraw
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1173, 745)
        Controls.Add(Panel1)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblATM)
        Name = "CashWithdraw"
        Text = "CashWithdraw"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblATM As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents lblU As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblAmountWithdraw As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCancel As Button
End Class
