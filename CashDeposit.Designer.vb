<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashDeposit
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
        TextBox1 = New TextBox()
        btnConfrim = New Button()
        lblDeposit = New Label()
        lblU = New Label()
        lblacno = New Label()
        lblname = New Label()
        lblacc = New Label()
        lblATM = New Label()
        btnTerminate = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCashDeposit
        ' 
        lblCashDeposit.AutoSize = True
        lblCashDeposit.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCashDeposit.Location = New Point(399, 157)
        lblCashDeposit.Name = "lblCashDeposit"
        lblCashDeposit.Size = New Size(193, 41)
        lblCashDeposit.TabIndex = 25
        lblCashDeposit.Text = "Cash Deposit"
        ' 
        ' btnMmenu
        ' 
        btnMmenu.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMmenu.Location = New Point(931, 651)
        btnMmenu.Name = "btnMmenu"
        btnMmenu.Size = New Size(200, 61)
        btnMmenu.TabIndex = 26
        btnMmenu.Text = "Main Menu"
        btnMmenu.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(btnTerminate)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnConfrim)
        Panel1.Controls.Add(lblDeposit)
        Panel1.Location = New Point(201, 266)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(753, 352)
        Panel1.TabIndex = 32
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(140, 113)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(489, 82)
        TextBox1.TabIndex = 33
        ' 
        ' btnConfrim
        ' 
        btnConfrim.BackColor = Color.SteelBlue
        btnConfrim.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfrim.Location = New Point(67, 277)
        btnConfrim.Name = "btnConfrim"
        btnConfrim.Size = New Size(136, 53)
        btnConfrim.TabIndex = 3
        btnConfrim.Text = "Confirm"
        btnConfrim.UseVisualStyleBackColor = False
        ' 
        ' lblDeposit
        ' 
        lblDeposit.AutoSize = True
        lblDeposit.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDeposit.ForeColor = SystemColors.ButtonHighlight
        lblDeposit.Location = New Point(198, 39)
        lblDeposit.Name = "lblDeposit"
        lblDeposit.Size = New Size(443, 41)
        lblDeposit.TabIndex = 0
        lblDeposit.Text = "Please Enter Amount To Deposit"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(1017, 166)
        lblU.Name = "lblU"
        lblU.Size = New Size(142, 38)
        lblU.TabIndex = 31
        lblU.Text = "Username"
        ' 
        ' lblacno
        ' 
        lblacno.AutoSize = True
        lblacno.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacno.ForeColor = Color.White
        lblacno.Location = New Point(175, 157)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 30
        lblacno.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(907, 166)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 29
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(10, 157)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 28
        lblacc.Text = "Account"
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(91, 36)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 27
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' btnTerminate
        ' 
        btnTerminate.BackColor = Color.SteelBlue
        btnTerminate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTerminate.Location = New Point(526, 263)
        btnTerminate.Name = "btnTerminate"
        btnTerminate.Size = New Size(136, 53)
        btnTerminate.TabIndex = 34
        btnTerminate.Text = "Cancel"
        btnTerminate.UseVisualStyleBackColor = False
        ' 
        ' CashDeposit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1169, 749)
        Controls.Add(lblCashDeposit)
        Controls.Add(btnMmenu)
        Controls.Add(Panel1)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblATM)
        Name = "CashDeposit"
        Text = "CashDeposit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCashDeposit As Label
    Friend WithEvents btnMmenu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfrim As Button
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents lblATM As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTerminate As Button
End Class
