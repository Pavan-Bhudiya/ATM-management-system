<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PINChange
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
        txtNewPIN = New TextBox()
        txtConfirmPIN = New TextBox()
        txtOldPIN = New TextBox()
        lblConfirmPIN = New Label()
        lblNewPIN = New Label()
        lblOldPIN = New Label()
        btnCancel = New Button()
        btnSubmit = New Button()
        lblPINChange = New Label()
        btnmain = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(79, 20)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 7
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(1006, 144)
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
        lblacno.Location = New Point(164, 135)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 13
        lblacno.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(896, 144)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 12
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(-1, 135)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 11
        lblacc.Text = "Account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(txtNewPIN)
        Panel1.Controls.Add(txtConfirmPIN)
        Panel1.Controls.Add(txtOldPIN)
        Panel1.Controls.Add(lblConfirmPIN)
        Panel1.Controls.Add(lblNewPIN)
        Panel1.Controls.Add(lblOldPIN)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnSubmit)
        Panel1.Location = New Point(192, 246)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(795, 314)
        Panel1.TabIndex = 18
        ' 
        ' txtNewPIN
        ' 
        txtNewPIN.Location = New Point(255, 104)
        txtNewPIN.Name = "txtNewPIN"
        txtNewPIN.Size = New Size(125, 27)
        txtNewPIN.TabIndex = 27
        ' 
        ' txtConfirmPIN
        ' 
        txtConfirmPIN.Location = New Point(255, 163)
        txtConfirmPIN.Name = "txtConfirmPIN"
        txtConfirmPIN.Size = New Size(125, 27)
        txtConfirmPIN.TabIndex = 26
        ' 
        ' txtOldPIN
        ' 
        txtOldPIN.Location = New Point(255, 36)
        txtOldPIN.Name = "txtOldPIN"
        txtOldPIN.Size = New Size(125, 27)
        txtOldPIN.TabIndex = 25
        ' 
        ' lblConfirmPIN
        ' 
        lblConfirmPIN.AutoSize = True
        lblConfirmPIN.Location = New Point(37, 170)
        lblConfirmPIN.Name = "lblConfirmPIN"
        lblConfirmPIN.Size = New Size(147, 20)
        lblConfirmPIN.TabIndex = 24
        lblConfirmPIN.Text = "Confirm PIN Number"
        ' 
        ' lblNewPIN
        ' 
        lblNewPIN.AutoSize = True
        lblNewPIN.Location = New Point(37, 100)
        lblNewPIN.Name = "lblNewPIN"
        lblNewPIN.Size = New Size(104, 20)
        lblNewPIN.TabIndex = 23
        lblNewPIN.Text = "Enter New PIN"
        ' 
        ' lblOldPIN
        ' 
        lblOldPIN.AutoSize = True
        lblOldPIN.Location = New Point(37, 39)
        lblOldPIN.Name = "lblOldPIN"
        lblOldPIN.Size = New Size(98, 20)
        lblOldPIN.TabIndex = 22
        lblOldPIN.Text = "Enter Old PIN"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(549, 252)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(174, 45)
        btnCancel.TabIndex = 21
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(218, 252)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(174, 45)
        btnSubmit.TabIndex = 20
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblPINChange
        ' 
        lblPINChange.AutoSize = True
        lblPINChange.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPINChange.Location = New Point(371, 184)
        lblPINChange.Name = "lblPINChange"
        lblPINChange.Size = New Size(175, 41)
        lblPINChange.TabIndex = 17
        lblPINChange.Text = "PIN Change"
        ' 
        ' btnmain
        ' 
        btnmain.Location = New Point(503, 613)
        btnmain.Name = "btnmain"
        btnmain.Size = New Size(174, 45)
        btnmain.TabIndex = 21
        btnmain.Text = "Main Menu"
        btnmain.UseVisualStyleBackColor = True
        ' 
        ' PINChange
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1163, 738)
        Controls.Add(btnmain)
        Controls.Add(Panel1)
        Controls.Add(lblPINChange)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblATM)
        Name = "PINChange"
        Text = "PINChange"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblATM As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblacc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblConfirmPIN As Label
    Friend WithEvents lblNewPIN As Label
    Friend WithEvents lblOldPIN As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblPINChange As Label
    Friend WithEvents btnmain As Button
    Friend WithEvents txtNewPIN As TextBox
    Friend WithEvents txtConfirmPIN As TextBox
    Friend WithEvents txtOldPIN As TextBox
End Class
