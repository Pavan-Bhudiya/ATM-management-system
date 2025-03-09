<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FundTransfer
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
        lblTransfer = New Label()
        Panel1 = New Panel()
        btnSubmit = New Button()
        rdbtnToAnyOtherAcc = New RadioButton()
        rdbtnIBTransfer = New RadioButton()
        lblFTransfer = New Label()
        btnMainMenu = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(95, 18)
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
        lblU.Location = New Point(1005, 145)
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
        lblacno.Location = New Point(163, 136)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 13
        lblacno.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(895, 145)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 12
        lblname.Text = "Name"
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(-2, 136)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 11
        lblacc.Text = "Account"
        ' 
        ' lblTransfer
        ' 
        lblTransfer.AutoSize = True
        lblTransfer.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransfer.Location = New Point(407, 197)
        lblTransfer.Name = "lblTransfer"
        lblTransfer.Size = New Size(204, 41)
        lblTransfer.TabIndex = 15
        lblTransfer.Text = "Fund  Transfer"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(btnSubmit)
        Panel1.Controls.Add(rdbtnToAnyOtherAcc)
        Panel1.Controls.Add(rdbtnIBTransfer)
        Panel1.Controls.Add(lblFTransfer)
        Panel1.Location = New Point(309, 253)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(616, 314)
        Panel1.TabIndex = 16
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(187, 245)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(243, 45)
        btnSubmit.TabIndex = 20
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' rdbtnToAnyOtherAcc
        ' 
        rdbtnToAnyOtherAcc.AutoSize = True
        rdbtnToAnyOtherAcc.Location = New Point(203, 178)
        rdbtnToAnyOtherAcc.Name = "rdbtnToAnyOtherAcc"
        rdbtnToAnyOtherAcc.Size = New Size(174, 24)
        rdbtnToAnyOtherAcc.TabIndex = 19
        rdbtnToAnyOtherAcc.TabStop = True
        rdbtnToAnyOtherAcc.Text = "To Any Other Account"
        rdbtnToAnyOtherAcc.UseVisualStyleBackColor = True
        ' 
        ' rdbtnIBTransfer
        ' 
        rdbtnIBTransfer.AutoSize = True
        rdbtnIBTransfer.Location = New Point(203, 121)
        rdbtnIBTransfer.Name = "rdbtnIBTransfer"
        rdbtnIBTransfer.Size = New Size(208, 24)
        rdbtnIBTransfer.TabIndex = 18
        rdbtnIBTransfer.TabStop = True
        rdbtnIBTransfer.Text = "Internal Bank Transfer Fund"
        rdbtnIBTransfer.UseVisualStyleBackColor = True
        ' 
        ' lblFTransfer
        ' 
        lblFTransfer.AutoSize = True
        lblFTransfer.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFTransfer.Location = New Point(127, 16)
        lblFTransfer.Name = "lblFTransfer"
        lblFTransfer.Size = New Size(446, 41)
        lblFTransfer.TabIndex = 17
        lblFTransfer.Text = "Please Select Fund Transfer Type"
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.Location = New Point(786, 608)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(243, 45)
        btnMainMenu.TabIndex = 21
        btnMainMenu.Text = "Main Menu"
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' FundTransfer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(1156, 721)
        Controls.Add(btnMainMenu)
        Controls.Add(Panel1)
        Controls.Add(lblTransfer)
        Controls.Add(lblU)
        Controls.Add(lblacno)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Controls.Add(lblATM)
        Name = "FundTransfer"
        Text = "FundTransfer"
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
    Friend WithEvents lblTransfer As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents rdbtnToAnyOtherAcc As RadioButton
    Friend WithEvents rdbtnIBTransfer As RadioButton
    Friend WithEvents lblFTransfer As Label
    Friend WithEvents btnMainMenu As Button
End Class
