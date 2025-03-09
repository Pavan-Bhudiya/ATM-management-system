<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
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
        lblacc = New Label()
        lblname = New Label()
        lblATM = New Label()
        lblUser = New Label()
        lblacno = New Label()
        DataGridView1 = New DataGridView()
        btnOkay = New Button()
        btnm = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblacc
        ' 
        lblacc.AutoSize = True
        lblacc.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacc.Location = New Point(0, 130)
        lblacc.Name = "lblacc"
        lblacc.Size = New Size(118, 38)
        lblacc.TabIndex = 0
        lblacc.Text = "Account"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(779, 130)
        lblname.Name = "lblname"
        lblname.Size = New Size(91, 38)
        lblname.TabIndex = 1
        lblname.Text = "Name"
        ' 
        ' lblATM
        ' 
        lblATM.AutoSize = True
        lblATM.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblATM.Location = New Point(23, 9)
        lblATM.Name = "lblATM"
        lblATM.Size = New Size(934, 106)
        lblATM.TabIndex = 2
        lblATM.Text = "BANCO DE SUENOS ATM"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(892, 130)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(147, 38)
        lblUser.TabIndex = 7
        lblUser.Text = "UserName"
        ' 
        ' lblacno
        ' 
        lblacno.AutoSize = True
        lblacno.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblacno.ForeColor = Color.White
        lblacno.Location = New Point(146, 130)
        lblacno.Name = "lblacno"
        lblacno.Size = New Size(118, 38)
        lblacno.TabIndex = 8
        lblacno.Text = "Account"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(180, 276)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(747, 200)
        DataGridView1.TabIndex = 9
        ' 
        ' btnOkay
        ' 
        btnOkay.Location = New Point(301, 512)
        btnOkay.Name = "btnOkay"
        btnOkay.Size = New Size(143, 58)
        btnOkay.TabIndex = 10
        btnOkay.Text = "OK"
        btnOkay.UseVisualStyleBackColor = True
        ' 
        ' btnm
        ' 
        btnm.Location = New Point(647, 512)
        btnm.Name = "btnm"
        btnm.Size = New Size(143, 58)
        btnm.TabIndex = 12
        btnm.Text = "Main Menu"
        btnm.UseVisualStyleBackColor = True
        ' 
        ' Balance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1096, 735)
        Controls.Add(btnm)
        Controls.Add(btnOkay)
        Controls.Add(DataGridView1)
        Controls.Add(lblacno)
        Controls.Add(lblUser)
        Controls.Add(lblATM)
        Controls.Add(lblname)
        Controls.Add(lblacc)
        Name = "Balance"
        Text = "Balance"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblacc As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblATM As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblacno As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnOkay As Button
    Friend WithEvents btnm As Button
End Class
